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

using Org.Apache.Kafka.Common.Serialization;
using Java.Util;

namespace Org.Apache.Kafka.Streams.KStream
{
    public class TimeWindowedSerializer<T> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TimeWindowedSerializer<T>>
    {
        public override bool IsCloseable => true;

        public override string ClassName => "org.apache.kafka.streams.kstream.TimeWindowedSerializer";

        public TimeWindowedSerializer() { }

        public TimeWindowedSerializer(Serializer<T> inner)
            : base(inner)
        {
        }

        public void Configure(Map<string, object> configs, bool isKey)
        {
            IExecute("configure", configs, isKey);
        }

        public byte[] Serialize(string topic, Windowed<T> data)
        {
            return IExecute<byte[]>("serialize", topic, data);
        }

        public byte[] SerializeBaseKey(string topic, Windowed<T> data)
        {
            return IExecute<byte[]>("serializeBaseKey", topic, data);
        }
    }
}
