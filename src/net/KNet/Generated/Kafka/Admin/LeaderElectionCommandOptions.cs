/*
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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using kafka_2.13-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Kafka.Admin
{
    #region LeaderElectionCommandOptions
    public partial class LeaderElectionCommandOptions
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#%3Cinit%3E(java.lang.String[])"/>
        /// </summary>
        /// <param name="args"><see cref="string"/></param>
        public LeaderElectionCommandOptions(string[] args)
            : base(args)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#adminClientConfig()"/> 
        /// </summary>
        public Joptsimple.ArgumentAcceptingOptionSpec<string> AdminClientConfig
        {
            get { return IExecute<Joptsimple.ArgumentAcceptingOptionSpec<string>>("adminClientConfig"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#allTopicPartitions()"/> 
        /// </summary>
        public Joptsimple.OptionSpecBuilder AllTopicPartitions
        {
            get { return IExecute<Joptsimple.OptionSpecBuilder>("allTopicPartitions"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#bootstrapServer()"/> 
        /// </summary>
        public Joptsimple.ArgumentAcceptingOptionSpec<string> BootstrapServer
        {
            get { return IExecute<Joptsimple.ArgumentAcceptingOptionSpec<string>>("bootstrapServer"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#electionType()"/> 
        /// </summary>
        public Joptsimple.ArgumentAcceptingOptionSpec<Org.Apache.Kafka.Common.ElectionType> ElectionType
        {
            get { return IExecute<Joptsimple.ArgumentAcceptingOptionSpec<Org.Apache.Kafka.Common.ElectionType>>("electionType"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#partition()"/> 
        /// </summary>
        public Joptsimple.ArgumentAcceptingOptionSpec<int?> Partition
        {
            get { return IExecute<Joptsimple.ArgumentAcceptingOptionSpec<int?>>("partition"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#pathToJsonFile()"/> 
        /// </summary>
        public Joptsimple.ArgumentAcceptingOptionSpec<string> PathToJsonFile
        {
            get { return IExecute<Joptsimple.ArgumentAcceptingOptionSpec<string>>("pathToJsonFile"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/admin/LeaderElectionCommandOptions.html#topic()"/> 
        /// </summary>
        public Joptsimple.ArgumentAcceptingOptionSpec<string> Topic
        {
            get { return IExecute<Joptsimple.ArgumentAcceptingOptionSpec<string>>("topic"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}