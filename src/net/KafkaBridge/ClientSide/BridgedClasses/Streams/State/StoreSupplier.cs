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

using MASES.JCOBridge.C2JBridge;
using MASES.KafkaBridge.Streams.Processor;

namespace MASES.KafkaBridge.Streams.State
{
    public interface IStoreSupplier<T> : IJVMBridgeBase
        where T : StateStore
    {
        string Name { get; }

        T Get { get; }

        string MetricsScope { get; }
    }


    public class StoreSupplier<T> : JVMBridgeBase<StoreSupplier<T>, IStoreSupplier<T>>, IStoreSupplier<T>
        where T : StateStore
    {
        public override string ClassName => "org.apache.kafka.streams.state.StoreSupplier";

        public string Name => IExecute<string>("name");

        public virtual T Get { get; }

        public string MetricsScope => IExecute<string>("metricsScope");
    }
}
