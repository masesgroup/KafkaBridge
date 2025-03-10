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

using MASES.JNetPSCore.Cmdlet;
using MASES.KNet;
using System.Management.Automation;

namespace MASES.KNetPS.Cmdlet
{
    public class StartKNetPSCmdletCommandBase<TCmdlet> : StartJNetPSCmdletCommandBase<TCmdlet, KNetPSCore>
        where TCmdlet : StartKNetPSCmdletCommandBase<TCmdlet>
    {
        /// <inheritdoc cref="KNetCore{T}.ApplicationScalaVersion" />
        [Parameter(
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The version of scala to be used.")]
        public string ScalaVersion { get; set; }

        /// <inheritdoc cref="KNetCore{T}.ApplicationJarRootPath" />
        [Parameter(
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The folder where Kafka package are stored. Default consider the application use the Jars in the package.")]
        public string KafkaJarLocation { get; set; }

        /// <inheritdoc cref="KNetCore{T}.ApplicationLog4JConfiguration" />
        [Parameter(
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The file containing the configuration of log4j.")]
        public string Log4JPath { get; set; }

        /// <inheritdoc cref="KNetCore{T}.ApplicationLogPath" />
        [Parameter(
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "The path where log will be stored.")]
        public string LogPath { get; set; }

        /// <inheritdoc cref="KNetCore{T}.ApplicationDisableJMX" />
        [Parameter(
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = "Disable JMX. Default is JMX enabled without security.")]
        public bool? DisableJMX { get; set; }

        protected override void OnBeforeCreateGlobalInstance()
        {
            KNetPSHelper<KNetPSCore>.SetScalaVersion(ScalaVersion);
            KNetPSHelper<KNetPSCore>.SetJarRootPath(KafkaJarLocation);
            KNetPSHelper<KNetPSCore>.SetLog4JPath(Log4JPath);
            KNetPSHelper<KNetPSCore>.SetLogPath(LogPath);
            KNetPSHelper<KNetPSCore>.SetDisableJMX(DisableJMX);
        }
    }
}
