﻿/*
*  Copyright 2023 MASES s.r.l.
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

using MASES.KNet.Common.Serialization;
using Java.Time;
using Java.Util;
using MASES.JCOBridge.C2JBridge;
using System;
using System.Collections.Concurrent;
using MASES.KNet.Serialization;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.KNet.Common.Header;
using MASES.KNet.Common.Record;
using System.Collections.Generic;
using System.Collections;

namespace MASES.KNet.Clients.Consumer
{
    public class KNetConsumerRecord<K, V>
    {
        readonly IKNetDeserializer<K> _keyDeserializer;
        readonly IKNetDeserializer<V> _valueDeserializer;
        readonly ConsumerRecord<byte[], byte[]> _record;

        public KNetConsumerRecord(ConsumerRecord<byte[], byte[]> record, IKNetDeserializer<K> keyDeserializer, IKNetDeserializer<V> valueDeserializer)
        {
            _record = record;
            _keyDeserializer = keyDeserializer;
            _valueDeserializer = valueDeserializer;
        }

        public string Topic => _record.Topic;

        public int Partition => _record.Partition;

        public Headers Headers => _record.Headers;

        public object RawKey => _record.RawKey;

        public object RawValue => _record.RawValue;

        public long Offset => _record.Offset;

        public System.DateTime DateTime => _record.DateTime;

        public long Timestamp => _record.Timestamp;

        public TimestampType TimestampType => _record.TimestampType;

        public int SerializedKeySize => _record.SerializedKeySize;

        public int SerializedValueSize => _record.SerializedValueSize;

        public K Key
        {
            get
            {
                return _keyDeserializer.DeserializeWithHeaders(Topic, Headers, _record.Key);
            }
        }

        public V Value
        {
            get
            {
                return _valueDeserializer.DeserializeWithHeaders(Topic, Headers, _record.Value);
            }
        }

        public override string ToString()
        {
            return $"Topic: {Topic} - Partition {Partition} - Offset {Offset} - Key {Key} - Value {Value}";
        }
    }

    class KNetConsumerRecordsEnumerator<K, V> : IEnumerator<KNetConsumerRecord<K, V>>
    {
        readonly IKNetDeserializer<K> _keyDeserializer;
        readonly IKNetDeserializer<V> _valueDeserializer;
        readonly ConsumerRecords<byte[], byte[]> _records;
        IEnumerator<ConsumerRecord<byte[], byte[]>> _recordEnumerator;

        public KNetConsumerRecordsEnumerator(ConsumerRecords<byte[], byte[]> records, IKNetDeserializer<K> keyDeserializer, IKNetDeserializer<V> valueDeserializer)
        {
            _records = records;
            _recordEnumerator = _records.GetEnumerator();
            _keyDeserializer = keyDeserializer;
            _valueDeserializer = valueDeserializer;
        }

        public KNetConsumerRecord<K, V> Current => new KNetConsumerRecord<K, V>(_recordEnumerator.Current, _keyDeserializer, _valueDeserializer);

        object IEnumerator.Current => (_recordEnumerator as IEnumerator)?.Current;

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            return _recordEnumerator.MoveNext();
        }

        public void Reset()
        {
            _recordEnumerator = _records.GetEnumerator();
        }
    }

    public class KNetConsumerRecords<K, V> : IEnumerable<KNetConsumerRecord<K, V>>
    {
        readonly IKNetDeserializer<K> _keyDeserializer;
        readonly IKNetDeserializer<V> _valueDeserializer;
        readonly ConsumerRecords<byte[], byte[]> _records;

        public KNetConsumerRecords(ConsumerRecords<byte[], byte[]> records, IKNetDeserializer<K> keyDeserializer, IKNetDeserializer<V> valueDeserializer)
        {
            _records = records;
            _keyDeserializer = keyDeserializer;
            _valueDeserializer = valueDeserializer;
        }

        public IEnumerator<KNetConsumerRecord<K, V>> GetEnumerator()
        {
            return new KNetConsumerRecordsEnumerator<K, V>(_records, _keyDeserializer, _valueDeserializer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new KNetConsumerRecordsEnumerator<K, V>(_records, _keyDeserializer, _valueDeserializer);
        }
    }

    //public class Message<K, V>
    //{
    //    readonly ConsumerRecord<K, V> record;
    //    readonly KNetConsumerCallback<K, V> obj;
    //    internal Message(KNetConsumerCallback<K, V> obj)
    //    {
    //        this.obj = obj;
    //    }
    //    internal Message(ConsumerRecord<K, V> record)
    //    {
    //        this.record = record;
    //    }

    //    public string Topic => record != null ? record.Topic : obj.BridgeInstance.Invoke<string>("getTopic");

    //    public int Partition => record != null ? record.Partition : obj.BridgeInstance.Invoke<int>("getPartition");

    //    public K Key => record != null ? record.Key : obj.BridgeInstance.Invoke<K>("getKey");

    //    public V Value => record != null ? record.Value : obj.BridgeInstance.Invoke<V>("getValue");
    //}

    interface IKNetConsumerCallback<K, V> : IJVMBridgeBase
    {
        void RecordReady(KNetConsumerRecord<K, V> message);
    }

    class KNetConsumerCallback<K, V> : JVMBridgeListener, IKNetConsumerCallback<K, V>
    {
        readonly IKNetDeserializer<K> _keyDeserializer;
        readonly IKNetDeserializer<V> _valueDeserializer;
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string BridgeClassName => "org.mases.knet.clients.consumer.KNetConsumerCallback";

        readonly Action<KNetConsumerRecord<K, V>> recordReadyFunction = null;
        public virtual Action<KNetConsumerRecord<K, V>> OnRecordReady { get { return recordReadyFunction; } }
        public KNetConsumerCallback(Action<KNetConsumerRecord<K, V>> recordReady, IKNetDeserializer<K> keyDeserializer, IKNetDeserializer<V> valueDeserializer)
        {
            if (recordReady != null) recordReadyFunction = recordReady;
            else recordReadyFunction = RecordReady;

            _keyDeserializer = keyDeserializer;
            _valueDeserializer = valueDeserializer;

            AddEventHandler("recordReady", new EventHandler<CLRListenerEventArgs<CLREventData>>(OnRecordReadyEventHandler));
        }

        void OnRecordReadyEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var record = this.BridgeInstance.Invoke<ConsumerRecord<byte[], byte[]>>("getRecord");
            OnRecordReady(new KNetConsumerRecord<K, V>(record, _keyDeserializer, _valueDeserializer));
        }

        public virtual void RecordReady(KNetConsumerRecord<K, V> message) { }
    }

    public interface IKNetConsumer<K, V> : IConsumer<byte[], byte[]>
    {
        bool IsCompleting { get; }

        bool IsEmpty { get; }

        int WaitingMessages { get; }

        void SetCallback(Action<KNetConsumerRecord<K, V>> cb);

        new KNetConsumerRecords<K, V> Poll(long timeoutMs);

        new KNetConsumerRecords<K, V> Poll(Duration timeout);

        void ConsumeAsync(long timeoutMs);

        void Consume(long timeoutMs, Action<KNetConsumerRecord<K, V>> callback);
    }

    public class KNetConsumer<K, V> : KafkaConsumer<byte[], byte[]>, IKNetConsumer<K, V>
    {
        readonly bool autoCreateSerDes = false;
        bool threadRunning = false;
        long dequeing = 0;
        readonly System.Threading.Thread consumeThread = null;
        readonly System.Threading.ManualResetEvent threadExited = null;
        readonly ConcurrentQueue<KNetConsumerRecords<K, V>> consumedRecords = null;
        readonly KNetConsumerCallback<K, V> consumerCallback = null;
        readonly IKNetDeserializer<K> _keyDeserializer;
        readonly IKNetDeserializer<V> _valueDeserializer;

        public override string BridgeClassName => "org.mases.knet.clients.consumer.KNetConsumer";

        public KNetConsumer(Properties props, bool useJVMCallback = false)
            : this(props, new KNetSerDes<K>(), new KNetSerDes<V>(), useJVMCallback)
        {
            autoCreateSerDes = true;

            if (useJVMCallback)
            {
                consumerCallback = new KNetConsumerCallback<K, V>(CallbackMessage, _keyDeserializer, _valueDeserializer);
                IExecute("setCallback", consumerCallback);
            }
            else
            {
                consumedRecords = new();
                threadRunning = true;
                threadExited = new(false);
                consumeThread = new(ConsumeHandler);
                consumeThread.Start();
            }
        }

        public KNetConsumer(Properties props, IKNetDeserializer<K> keyDeserializer, IKNetDeserializer<V> valueDeserializer, bool useJVMCallback = false)
            : base(CheckProperties(props), keyDeserializer.KafkaDeserializer, valueDeserializer.KafkaDeserializer)
        {
            _keyDeserializer = keyDeserializer;
            _valueDeserializer = valueDeserializer;

            if (useJVMCallback)
            {
                consumerCallback = new KNetConsumerCallback<K, V>(CallbackMessage, _keyDeserializer, _valueDeserializer);
                IExecute("setCallback", consumerCallback);
            }
            else
            {
                consumedRecords = new();
                threadRunning = true;
                threadExited = new(false);
                consumeThread = new(ConsumeHandler);
                consumeThread.Start();
            }
        }

        static Properties CheckProperties(Properties props)
        {
            if (!props.ContainsKey(ConsumerConfig.KEY_DESERIALIZER_CLASS_CONFIG))
            {
                props.Put(ConsumerConfig.KEY_DESERIALIZER_CLASS_CONFIG, "org.apache.kafka.common.serialization.ByteArrayDeserializer");
            }
            else throw new InvalidOperationException($"KNetConsumer auto manages configuration property {ConsumerConfig.KEY_DESERIALIZER_CLASS_CONFIG}, remove from configuration.");

            if (!props.ContainsKey(ConsumerConfig.VALUE_DESERIALIZER_CLASS_CONFIG))
            {
                props.Put(ConsumerConfig.VALUE_DESERIALIZER_CLASS_CONFIG, "org.apache.kafka.common.serialization.ByteArrayDeserializer");
            }
            else throw new InvalidOperationException($"KNetConsumer auto manages configuration property {ConsumerConfig.VALUE_DESERIALIZER_CLASS_CONFIG}, remove from configuration.");

            return props;
        }

        ~KNetConsumer()
        {
            if (autoCreateSerDes)
            {
                _keyDeserializer?.Dispose();
                _valueDeserializer?.Dispose();
            }
        }

        public new KNetConsumerRecords<K, V> Poll(long timeoutMs)
        {
            var records = IExecute<ConsumerRecords<byte[], byte[]>>("poll", timeoutMs);
            return new KNetConsumerRecords<K, V>(records, _keyDeserializer, _valueDeserializer);
        }

        public new KNetConsumerRecords<K, V> Poll(Duration timeout)
        {
            var records = IExecute<ConsumerRecords<byte[], byte[]>>("poll", timeout);
            return new KNetConsumerRecords<K, V>(records, _keyDeserializer, _valueDeserializer);
        }

        Action<KNetConsumerRecord<K, V>> actionCallback = null;

        void CallbackMessage(KNetConsumerRecord<K, V> message)
        {
            actionCallback?.Invoke(message);
        }

        public override void Dispose()
        {
            base.Dispose();
            IExecute("setCallback", null);
            consumerCallback?.Dispose();
            threadRunning = false;
            if (consumedRecords != null)
            {
                lock (consumedRecords)
                {
                    System.Threading.Monitor.Pulse(consumedRecords);
                }
                while (IsCompleting) { threadExited.WaitOne(100); };
                actionCallback = null;
            }
        }

        public void SetCallback(Action<KNetConsumerRecord<K, V>> cb)
        {
            actionCallback = cb;
        }

        void ConsumeHandler(object o)
        {
            try
            {
                while (threadRunning)
                {
                    if (consumedRecords.TryDequeue(out KNetConsumerRecords<K, V> records))
                    {
                        System.Threading.Interlocked.Increment(ref dequeing);
                        try
                        {
                            foreach (var item in records)
                            {
                                actionCallback?.Invoke(item);
                            }
                        }
                        catch { }
                        finally
                        {
                            System.Threading.Interlocked.Decrement(ref dequeing);
                        }
                    }
                    else
                    {
                        lock (consumedRecords)
                        {
                            System.Threading.Monitor.Wait(consumedRecords);
                        }
                    }
                }
            }
            catch { }
            finally { threadExited.Set(); threadRunning = false; }
        }

        public bool IsCompleting => !consumedRecords.IsEmpty || System.Threading.Interlocked.Read(ref dequeing) != 0;

        public bool IsEmpty => consumedRecords.IsEmpty;

        public int WaitingMessages => consumedRecords.Count;

        public void ConsumeAsync(long timeoutMs)
        {
            Duration duration = TimeSpan.FromMilliseconds(timeoutMs);
            if (consumedRecords == null) throw new ArgumentException("Cannot be used since constructor was called with useJVMCallback set to true.");
            if (!threadRunning) throw new InvalidOperationException("Dispatching thread is not running.");
            var results = this.Poll(duration);
            consumedRecords.Enqueue(results);
            lock (consumedRecords)
            {
                System.Threading.Monitor.Pulse(consumedRecords);
            }
        }

        public void Consume(long timeoutMs, Action<KNetConsumerRecord<K, V>> callback)
        {
            Duration duration = TimeSpan.FromMilliseconds(timeoutMs);
            if (consumerCallback == null) throw new ArgumentException("Cannot be used since constructor was called with useJVMCallback set to false.");
            try
            {
                actionCallback = callback;
                IExecute("consume", duration);
            }
            finally
            {
                duration?.Dispose();
                actionCallback = null;
            }
        }
    }
}
