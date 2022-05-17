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

using Java.Util;
using MASES.KNet.Common.Config;
using MASES.KNet.Connect;
using MASES.KNet.Connect.Source;

namespace MASES.KNetConnectTest
{
    public class KNetSourceTestConnector : KNetSourceConnector<KNetSourceTestTask>
    {
        public override string ConnectorName => "MASES.KNetConnectTest.KNetSourceTestConnector";

        public override void Start(Map<string, string> props)
        {

        }

        public override void Stop()
        {

        }

        public override void TaskConfigs(int index, Map<string, string> config)
        {
            
        }
    }

    public class KNetSourceTestTask : KNetSourceTask
    {
        public override List<SourceRecord> Poll()
        {
            ArrayList<SourceRecord> records = new();

            return records;
        }

        public override void Start(Map<string, string> props)
        {

        }

        public override void Stop()
        {

        }

        public override string Version()
        {
            return "KnetSourceTestTask";
        }
    }
}
