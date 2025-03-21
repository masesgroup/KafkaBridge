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

using Org.Apache.Kafka.Clients.Admin;
using MASES.KNetPS.Cmdlet;
using System.Management.Automation;
using MASES.KNet.Admin;

namespace MASES.KNetPS.ClientCmdlet
{
    [Cmdlet(VerbsCommon.New, "KafkaAdminClient")]
    [OutputType(typeof(KafkaAdminClient))]
    public class NewKafkaAdminClientCmdletCommand : KNetPSCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The configuration to be used as a AdminClientConfigBuilder object")]
        public AdminClientConfigBuilder Configuration { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin KafkaAdminClient!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessCommand()
        {
            WriteObject(KafkaAdminClient.Create(Configuration.ToProperties()));
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End KafkaAdminClient!");
        }
    }
}
