﻿using Java.Util;
using MASES.KNet.Common.Config;
using MASES.KNet.Connect;
using MASES.KNet.Connect.Sink;

namespace MASES.KNetTemplate.KNetConnect
{
    public class KNetConnectSink : KNetSinkConnector<KnetConnectSinkTask>
    {
        public override string ConnectorName => "MASES.KNetTemplate.KNetConnect.KNetConnectSink";

        public override void Start(Map<string, string> props)
        {

        }

        public override void Stop()
        {

        }

        public override void TaskConfigs(int index, Map<string, string> config)
        {

        }

        public override Config Validate(Map<string, string> connectorConfigs)
        {
            return null;
        }
    }

    public class KnetConnectSinkTask : KNetSinkTask
    {
        public override void Put(Collection<SinkRecord> collection)
        {

        }

        public override void Start(Map<string, string> props)
        {

        }

        public override void Stop()
        {

        }

        public override string Version()
        {
            return "KnetConnectSinkTask";
        }
    }
}
