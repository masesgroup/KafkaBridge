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

using Org.Apache.Kafka.Common;
using Java.Util;

namespace Org.Apache.Kafka.Clients.Admin
{
    public class ReplicaInfo : MASES.JCOBridge.C2JBridge.JVMBridgeBase<ReplicaInfo>
    {
        public override string ClassName => "org.apache.kafka.clients.admin.ReplicaInfo";

        [System.Obsolete("This is not public in Apache Kafka API")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public ReplicaInfo()
        {
        }

        public ReplicaInfo(long size, long offsetLag, bool isFuture)
            : base(size, offsetLag, isFuture)
        {
        }

        public long Size => IExecute<long>("size");

        public long OffsetLag => IExecute<long>("offsetLag");

        public bool IsFuture => IExecute<bool>("isFuture");
    }
}
