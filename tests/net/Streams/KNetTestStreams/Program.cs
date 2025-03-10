﻿/*
*  Copyright 2025 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using Java.Util;
using MASES.JCOBridge.C2JBridge;
using MASES.KNet;
using Org.Apache.Kafka.Clients.Consumer;
using Org.Apache.Kafka.Common.Serialization;
using Org.Apache.Kafka.Streams;
using Org.Apache.Kafka.Streams.Errors;
using Org.Apache.Kafka.Streams.Kstream;
using MASES.KNet.TestCommon;
using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace MASES.KNetTestStreams
{
    class Program
    {
        const string INPUT_TOPIC = "streams-plaintext-input";
        const string OUTPUT_TOPIC = "streams-wordcount-output";

        static bool useSerdes = true;
        static bool useCallback = true;

        const string theServer = "localhost:9092";
        const string theTopic = "myTopic";

        static string serverToUse = theServer;
        static string topicToUse = theTopic;
        static readonly ManualResetEvent resetEvent = new(false);

        static void Main(string[] args)
        {
            SharedKNetCore.Create();
            var appArgs = SharedKNetCore.FilteredArgs;

            if (appArgs.Length != 0)
            {
                serverToUse = args[0];
            }

            //Thread threadConsume = new Thread(PipeDemo)
            Thread threadConsume = new(WordCountDemo)
            {
                Name = "DemoThread"
            };
            threadConsume.Start();

            Console.CancelKeyPress += Console_CancelKeyPress;
            Console.WriteLine("Press Ctrl-C to exit");
            resetEvent.WaitOne();
            Thread.Sleep(2000); // wait the threads exit
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            if (e.Cancel) resetEvent.Set();
        }

        static void PipeDemo()
        {
            try
            {
                var props = new Properties();

                props.Put(StreamsConfig.APPLICATION_ID_CONFIG, "streams-pipe");
                props.Put(StreamsConfig.BOOTSTRAP_SERVERS_CONFIG, serverToUse);
                props.Put(StreamsConfig.DEFAULT_KEY_SERDE_CLASS_CONFIG, Serdes.String().Dyn().getClass());
                props.Put(StreamsConfig.DEFAULT_VALUE_SERDE_CLASS_CONFIG, Serdes.String().Dyn().getClass());

                // setting offset reset to earliest so that we can re-run the demo code with the same pre-loaded data
                props.Put(ConsumerConfig.AUTO_OFFSET_RESET_CONFIG, "earliest");

                var builder = new StreamsBuilder();

                builder.Stream<string, string>(topicToUse).To("streams-pipe-output");

                using (var streams = new KafkaStreams(builder.Build(), props))
                {
                    streams.Start();
                    while (!resetEvent.WaitOne(1000))
                    {
                        var state = streams.StateMethod();
                        Console.WriteLine($"KafkaStreams state: {state}");
                    }
                }
            }
            catch (Java.Util.Concurrent.ExecutionException ex)
            {
                Console.WriteLine("Streams ended with error: {0}", ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Streams ended with error: {0}", ex.Message);
            }
        }

        static void WordCountDemo()
        {
            try
            {
                var props = new Properties();

                props.Put(StreamsConfig.APPLICATION_ID_CONFIG, "WordCountDemo");
                props.Put(StreamsConfig.BOOTSTRAP_SERVERS_CONFIG, serverToUse);
                props.Put(StreamsConfig.DEFAULT_KEY_SERDE_CLASS_CONFIG, Serdes.String().Dyn().getClass());
                props.Put(StreamsConfig.DEFAULT_VALUE_SERDE_CLASS_CONFIG, Serdes.String().Dyn().getClass());

                // setting offset reset to earliest so that we can re-run the demo code with the same pre-loaded data
                props.Put(ConsumerConfig.AUTO_OFFSET_RESET_CONFIG, "earliest");

                ValueMapper<string, Java.Lang.Iterable<Java.Lang.String>> valueMapper = null;
                KeyValueMapper<string, Java.Lang.String, Java.Lang.String> keyValuemapper = null;
                StreamsUncaughtExceptionHandler errorHandler = null;

                try
                {
                    var builder = new StreamsBuilder();

                    KStream<string, string> source = builder.Stream<string, string>(topicToUse);

                    valueMapper = new ValueMapper<string, Java.Lang.Iterable<Java.Lang.String>>()
                    {
                        OnApply = (value) =>
                        {
                            Regex regex = new("\\W+");

                            ArrayList<Java.Lang.String> arrayList = new();

                            foreach (var item in regex.Split(value))
                            {
                                arrayList.Add(item);
                            }

                            return arrayList; // value->Arrays.asList(value.toLowerCase(Locale.getDefault()).split("\\W+"))
                        }
                    };

                    keyValuemapper = new KeyValueMapper<string, Java.Lang.String, Java.Lang.String>()
                    {
                        OnApply = (key, value) =>
                        {
                            return value;
                        }
                    };

                    KTable<Java.Lang.String, Java.Lang.Long> counts = source.FlatMapValues<Java.Lang.String, string, Java.Lang.Iterable<Java.Lang.String>, Java.Lang.String>(valueMapper)
                                                                            .GroupBy(keyValuemapper)
                                                                            .Count();

                    /***** version using Dynamic engine ******
                    
                    KTable<string, long> counts = JVMBridgeBase.Wraps<KTable<string, long>>(source.Dyn()
                        .flatMapValues(valueMapper)
                        .groupBy(keyValuemapper)
                        .count() as IJavaObject);
                    ******************************************/

                    // need to override value serde to Long type
                    counts.ToStream().To(OUTPUT_TOPIC, Produced<Java.Lang.String, Java.Lang.Long>.With(Serdes.String(), Serdes.Long()));

                    using (var streams = new KafkaStreams(builder.Build(), props))
                    {
                        errorHandler = new StreamsUncaughtExceptionHandler()
                        {
                            OnHandle = (exception) =>
                            {
                                Console.WriteLine(exception.ToString());
                                return StreamsUncaughtExceptionHandler.StreamThreadExceptionResponse.SHUTDOWN_APPLICATION;
                            }
                        };
                        streams.SetUncaughtExceptionHandler(errorHandler);
                        streams.Start();
                        while (!resetEvent.WaitOne(1000))
                        {
                            var state = streams.StateMethod();
                            Console.WriteLine($"KafkaStreams state: {state}");
                        }
                    }
                }
                finally
                {
                    valueMapper?.Dispose();
                    keyValuemapper?.Dispose();
                    errorHandler?.Dispose();
                }
            }
            catch (Java.Util.Concurrent.ExecutionException ex)
            {
                Console.WriteLine("Streams ended with error: {0}", ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Streams ended with error: {0}", ex.Message);
            }
        }
    }
}
