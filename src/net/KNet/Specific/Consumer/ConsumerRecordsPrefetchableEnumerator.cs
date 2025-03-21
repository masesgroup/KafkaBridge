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

using MASES.KNet.Serialization;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JCOBridge.C2JBridge;
using System;

namespace MASES.KNet.Consumer
{
#if NET7_0_OR_GREATER
    sealed class ConsumerRecordsPrefetchableEnumerator<K, V, TJVMK, TJVMV>(Java.Util.Iterator<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<TJVMK, TJVMV>> records,
                                                             ISerDes<K, TJVMK> keySerDes,
                                                             ISerDes<V, TJVMV> valueSerDes,
                                                             bool isAsync, CancellationToken token = default)
        : JVMBridgeBasePrefetchableEnumerator<ConsumerRecord<K, V, TJVMK, TJVMV>>(records.BridgeInstance, new PrefetchableEnumeratorSettings()),
          IAsyncEnumerator<ConsumerRecord<K, V, TJVMK, TJVMV>>
    {
        Java.Util.Iterator<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<TJVMK, TJVMV>> _records = records; // used to do not lost reference

        protected override object ConvertObject(object input)
        {
            if (input is IJavaObject obj)
            {
                return new ConsumerRecord<K, V, TJVMK, TJVMV>(JVMBridgeBase.WrapsDirect<Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<TJVMK, TJVMV>>(obj), keySerDes, valueSerDes, true);
            }
            throw new InvalidCastException($"input is not a valid IJavaObject");
        }

        protected override bool DoWorkCycle()
        {
            return isAsync ? !token.IsCancellationRequested : base.DoWorkCycle();
        }

        public ConsumerRecord<K, V, TJVMK, TJVMV> Current => (this as IEnumerator<ConsumerRecord<K, V, TJVMK, TJVMV>>).Current;

        public ValueTask<bool> MoveNextAsync()
        {
            return new ValueTask<bool>(MoveNext());
        }

        public ValueTask DisposeAsync()
        {
            Dispose();
            return new ValueTask();
        }
    }
#endif
}
