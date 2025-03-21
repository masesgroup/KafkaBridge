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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Org.Apache.Kafka.Streams.Processor.Api
{
    public partial interface IProcessor<KIn, VIn, KOut, VOut> : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#init-org.apache.kafka.streams.processor.api.ProcessorContext-"/>
        /// </summary>
        void Init(ProcessorContext<KOut, VOut> context);
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#process-org.apache.kafka.streams.processor.api.Record-"/>
        /// </summary>
        void Process(Record<KIn, VIn> record);
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.5.0/org/apache/kafka/streams/processor/api/Processor.html#close--"/>
        /// </summary>
        void Close();
    }

    public partial class Processor<KIn, VIn, KOut, VOut> : IProcessor<KIn, VIn, KOut, VOut>
    {

    }
}
