﻿/*
*  Copyright 2022 MASES s.r.l.
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

using MASES.KNet.Clients.Consumer;
using MASES.KNet.Clients.Producer;
using MASES.KNet.Common.Serialization;
using Java.Util;
using System;
using System.Diagnostics;
using System.Linq;

namespace MASES.KNet.Benchmark
{
    partial class Program
    {
        static IProducer<int, byte[]> knetProducer = null;
        static Serializer<int> knetKeySerializer = null;
        static Serializer<byte[]> knetValueSerializer = null;

        static IProducer<int, byte[]> KNetProducer()
        {
            if (knetProducer == null || !SharedObjects)
            {
                Properties props = ProducerConfigBuilder.Create()
                                                        .WithBootstrapServers(Server)
                                                        .WithAcks(Acks ? ProducerConfig.Acks.One : ProducerConfig.Acks.None)
                                                        .WithRetries(MessageSendMaxRetries)
                                                        .WithLingerMs(LingerMs)
                                                        .WithBatchSize(BatchSize)
                                                        .WithMaxInFlightRequestPerConnection(MaxInFlight)
                                                        .WithEnableIdempotence(false)
                                                        .WithSendBuffer(SocketSendBufferBytes)
                                                        .WithReceiveBuffer(SocketReceiveBufferBytes)
                                                        .WithBufferMemory(128 * 1024 * 1024)
                                                        .WithKeySerializerClass("org.apache.kafka.common.serialization.IntegerSerializer")
                                                        .WithValueSerializerClass("org.apache.kafka.common.serialization.ByteArraySerializer")
                                                        .ToProperties();
                if (UseSerdes)
                {
                    knetKeySerializer = new Serializer<int>(serializeWithHeadersFun: (topic, headers, data) =>
                    {
                        var key = BitConverter.GetBytes(data);
                        return key;
                    });
                    knetValueSerializer = new Serializer<byte[]>(serializeWithHeadersFun: (topic, headers, data) =>
                    {
                        // var value = Encoding.Unicode.GetBytes(data);
                        return data;
                    });
                }

                knetProducer = UseSerdes ? new KafkaProducer<int, byte[]>(props, knetKeySerializer, knetValueSerializer) : new KafkaProducer<int, byte[]>(props);
            }
            return knetProducer;
        }

        static Stopwatch ProduceKNet(int length, int numpacket, byte[] data = null)
        {
            try
            {
                var producer = KNetProducer();
                //  producer.PartitionsFor(TopicName("KNET", length)); // used to get metadata before do the test

                Callback callback = null;
                if (UseCallback)
                {
                    callback = new Callback((o1, o2) =>
                    {
                        if (o2 != null) Console.WriteLine(o2.ToString());
                        else Console.WriteLine($"Produced on topic {o1.Topic} at offset {o1.Offset}");
                    });
                }
                Stopwatch swCreateRecord = null;
                Stopwatch swSendRecord = null;
                Stopwatch stopWatch = null;
                try
                {
                    if (data == null)
                    {
                        var rand = new Random();
                        data = new byte[length];
                        for (int i = 0; i < length; i++)
                        {
                            data[i] = (byte)rand.Next(0, byte.MaxValue);
                        }
                    }
                    var record = new ProducerRecord<int, byte[]>(TopicName("KNET", length), 42, data);
                    if (ProducePreLoad)
                    {
                        swCreateRecord = new();
                        swSendRecord = new();
                        System.Collections.Generic.List<ProducerRecord<int, byte[]>> messages = new();
                        for (int i = 0; i < numpacket; i++)
                        {
                            var rand = new Random();
                            data = new byte[length];
                            for (int ii = 0; ii < length; ii++)
                            {
                                data[ii] = (byte)rand.Next(0, byte.MaxValue);
                            }
                            swCreateRecord.Start();
                            record = new ProducerRecord<int, byte[]>(TopicName("KNET", length), i, data);
                            swCreateRecord.Stop();
                            messages.Add(record);
                        }
                        stopWatch = Stopwatch.StartNew();
                        for (int i = 0; i < numpacket; i++)
                        {
                            swSendRecord.Start();
                            var result = UseCallback ? producer.Send(messages[i], callback) : producer.Send(messages[i]);
                            swSendRecord.Stop();
                            if (WithBurst)
                            {
                                if (i % BurstLength == 0)
                                {
                                    stopWatch.Stop();
                                    System.Threading.Thread.Sleep(BurstInterval);
                                    stopWatch.Start();
                                }
                            }
                            if (ContinuousFlushKNet) producer.Flush();
                        }
                    }
                    else
                    {
                        swCreateRecord = new();
                        swSendRecord = new();
                        stopWatch = Stopwatch.StartNew();
                        for (int i = 0; i < numpacket; i++)
                        {
                            if (!SinglePacket)
                            {
                                swCreateRecord.Start();
                                byte[] newData = new byte[data.Length];
                                Array.Copy(data, 0, newData, 0, data.Length);
                                record = new ProducerRecord<int, byte[]>(TopicName("KNET", length), i, newData);
                                swCreateRecord.Stop();
                            }
                            swSendRecord.Start();
                            var result = UseCallback ? producer.Send(record, callback) : producer.Send(record);
                            swSendRecord.Stop();
                            if (WithBurst)
                            {
                                if (i % BurstLength == 0)
                                {
                                    stopWatch.Stop();
                                    System.Threading.Thread.Sleep(BurstInterval);
                                    stopWatch.Start();
                                }
                            }
                            if (ContinuousFlushKNet) producer.Flush();
                        }
                    }
                }
                finally { producer.Flush(); stopWatch.Stop(); callback?.Dispose(); if (!SharedObjects) producer.Dispose(); }
                if (ShowResults && !ProducePreLoad)
                {
                    Console.WriteLine($"KNET: Create {swCreateRecord.ElapsedMicroSeconds()} Send {swSendRecord.ElapsedMicroSeconds()} -> {swCreateRecord.ElapsedMicroSeconds() + swSendRecord.ElapsedMicroSeconds()} -> BackTime {stopWatch.ElapsedMicroSeconds() - (swCreateRecord.ElapsedMicroSeconds() + swSendRecord.ElapsedMicroSeconds())}");
                }
                return stopWatch;
            }
            catch (Java.Util.Concurrent.ExecutionException ex)
            {
                throw ex.InnerException;
            }
        }

        static Deserializer<int> knetKeyDeserializer = null;
        static Deserializer<byte[]> knetValueDeserializer = null;
        static IConsumer<int, byte[]> knetConsumer = null;

        static IConsumer<int, byte[]> KNetConsumer()
        {
            if (knetConsumer == null || !SharedObjects)
            {
                Properties props = ConsumerConfigBuilder.Create()
                                                        .WithBootstrapServers(Server)
                                                        .WithGroupId(Guid.NewGuid().ToString())
                                                        .WithEnableAutoCommit(!AlwaysCommit)
                                                        .WithAutoCommitIntervalMs(1000)
                                                        .WithSendBuffer(SocketSendBufferBytes)
                                                        .WithReceiveBuffer(SocketReceiveBufferBytes)
                                                        .WithFetchMinBytes(FetchMinBytes)
                                                        .WithKeyDeserializerClass("org.apache.kafka.common.serialization.IntegerDeserializer")
                                                        .WithValueDeserializerClass("org.apache.kafka.common.serialization.ByteArrayDeserializer")
                                                        .WithAutoOffsetReset(ConsumerConfig.AutoOffsetReset.EARLIEST)
                                                        .ToProperties();
                if (UseSerdes)
                {
                    knetKeyDeserializer = new Deserializer<int>(deserializeFun: (topic, data) =>
                    {
                        var key = BitConverter.ToInt32(data, 0);
                        return key;
                    });
                    knetValueDeserializer = new Deserializer<byte[]>(deserializeFun: (topic, data) =>
                    {
                        // var value = Encoding.Unicode.GetString(data);
                        return data;
                    });
                }

                knetConsumer = UseSerdes ? new KafkaConsumer<int, byte[]>(props, knetKeyDeserializer, knetValueDeserializer) : new KafkaConsumer<int, byte[]>(props);
            }
            return knetConsumer;
        }

        static Stopwatch ConsumeKNet(int length, int numpacket, byte[] data = null)
        {
            try
            {
                Stopwatch stopWatch = null;
                ConsumerRebalanceListener rebalanceListener = new(
                                    revoked: (o) =>
                                    {
                                        if (ShowLogs) Console.WriteLine("Revoked: {0}", o.ToString());
                                    },
                                    assigned: (o) =>
                                    {
                                        if (ShowLogs) Console.WriteLine("Assigned: {0}", o.ToString());
                                        stopWatch = Stopwatch.StartNew();
                                    });

                var consumer = KNetConsumer();
                try
                {
                    int counter = 0;
                    consumer.Subscribe(Collections.Singleton(TopicName("KNET", length)), rebalanceListener);
                    while (true)
                    {
                        var records = consumer.Poll(TimeSpan.FromMinutes(1));
                        if (!CheckOnConsume)
                        {
                            counter += records.Count;
                        }
                        else
                        {
                            foreach (var item in records)
                            {
                                if (!item.Value.SequenceEqual(data)
                                    || (!SinglePacket && item.Key != counter))
                                {
                                    throw new InvalidOperationException("Incorrect data");
                                }
                                counter++;
                            }
                        }
                        if (AlwaysCommit) consumer.CommitSync();
                        if (counter >= numpacket)
                        {
                            consumer.CommitSync();
                            stopWatch.Stop();
                            consumer.Unsubscribe();
                            return stopWatch;
                        }
                    }
                }
                finally
                {
                    rebalanceListener?.Dispose();
                    if (!SharedObjects) consumer.Dispose();
                }
            }
            catch (Java.Util.Concurrent.ExecutionException ex)
            {
                throw ex.InnerException;
            }
        }

        static Stopwatch ConsumeProduceKNet(int length, int numpacket, byte[] data = null)
        {
            try
            {
                Stopwatch stopWatch = null;
                ConsumerRebalanceListener rebalanceListener = new(
                                    revoked: (o) =>
                                    {
                                        if (ShowLogs) Console.WriteLine("Revoked: {0}", o.ToString());
                                    },
                                    assigned: (o) =>
                                    {
                                        if (ShowLogs) Console.WriteLine("Assigned: {0}", o.ToString());
                                        stopWatch = Stopwatch.StartNew();
                                    });

                var consumer = KNetConsumer();
                var producer = KNetProducer();
                try
                {
                    int counter = 0;
                    consumer.Subscribe(Collections.Singleton(TopicName("KNET", length)), rebalanceListener);
                    while (true)
                    {
                        var records = consumer.Poll(TimeSpan.FromMinutes(1));
                        foreach (var item in records)
                        {
                            var record = new ProducerRecord<int, byte[]>(TopicName("KNET_COPY", length), item.Key, item.Value);
                            producer.Send(record);
                            counter++;
                        }
                        producer.Flush();
                        consumer.CommitSync();
                        if (counter >= numpacket)
                        {
                            stopWatch.Stop();
                            consumer.Unsubscribe();
                            return stopWatch;
                        }
                    }
                }
                finally
                {
                    rebalanceListener?.Dispose();
                    if (!SharedObjects)
                    {
                        consumer.Dispose();
                        producer.Dispose();
                    }
                }
            }
            catch (Java.Util.Concurrent.ExecutionException ex)
            {
                throw ex.InnerException;
            }
        }
    }
}
