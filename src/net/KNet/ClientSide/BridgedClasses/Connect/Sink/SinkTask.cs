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

using Java.Util;
using Org.Apache.Kafka.Clients.Consumer;
using Org.Apache.Kafka.Common;
using Org.Apache.Kafka.Connect.Connector;

namespace Org.Apache.Kafka.Connect.Sink
{
    public class SinkTask : Task
    {
        public override bool IsInterface => false;
        public override bool IsAbstract => true;

        public override string ClassName => "org.apache.kafka.connect.sink.SinkTask";

        public void Initialize(SinkTaskContext context) => IExecute("initialize", context);

        public void Put(Collection<SinkRecord> records) => IExecute("put", records);

        public void Flush(Map<TopicPartition, OffsetAndMetadata> currentOffsets) => IExecute("flush", currentOffsets);

        public Map<TopicPartition, OffsetAndMetadata> PreCommit(Map<TopicPartition, OffsetAndMetadata> currentOffsets) => IExecute<Map<TopicPartition, OffsetAndMetadata>>("preCommit", currentOffsets);

        public void Open(Collection<TopicPartition> partitions) => IExecute("open", partitions);

        public void Close(Collection<TopicPartition> partitions) => IExecute("close", partitions);
    }
}
