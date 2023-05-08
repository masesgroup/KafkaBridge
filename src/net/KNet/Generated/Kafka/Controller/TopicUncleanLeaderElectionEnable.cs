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

namespace Kafka.Controller
{
    #region TopicUncleanLeaderElectionEnable
    public partial class TopicUncleanLeaderElectionEnable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="topic"><see cref="string"/></param>
        public TopicUncleanLeaderElectionEnable(string topic)
            : base(topic)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Controller.TopicUncleanLeaderElectionEnable"/> to <see cref="Kafka.Controller.ControllerEvent"/>
        /// </summary>
        public static implicit operator Kafka.Controller.ControllerEvent(Kafka.Controller.TopicUncleanLeaderElectionEnable t) => t.Cast<Kafka.Controller.ControllerEvent>();
        /// <summary>
        /// Converter from <see cref="Kafka.Controller.TopicUncleanLeaderElectionEnable"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Kafka.Controller.TopicUncleanLeaderElectionEnable t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#apply(java.lang.String)"/>
        /// </summary>
        /// <param name="topic"><see cref="string"/></param>
        /// <returns><see cref="Kafka.Controller.TopicUncleanLeaderElectionEnable"/></returns>
        public static Kafka.Controller.TopicUncleanLeaderElectionEnable Apply(string topic)
        {
            return SExecute<Kafka.Controller.TopicUncleanLeaderElectionEnable>(LocalBridgeClazz, "apply", topic);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#productArity()"/> 
        /// </summary>
        public int ProductArity
        {
            get { return IExecute<int>("productArity"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#productPrefix()"/> 
        /// </summary>
        public string ProductPrefix
        {
            get { return IExecute<string>("productPrefix"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#state()"/> 
        /// </summary>
        public Kafka.Controller.ControllerState State
        {
            get { return IExecute<Kafka.Controller.ControllerState>("state"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#topic()"/> 
        /// </summary>
        public string Topic
        {
            get { return IExecute<string>("topic"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#canEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="x$1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEqual(object x_1)
        {
            return IExecute<bool>("canEqual", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#productElement(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        public object ProductElement(int x_1)
        {
            return IExecute("productElement", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#productElementName(int)"/>
        /// </summary>
        /// <param name="x$1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string ProductElementName(int x_1)
        {
            return IExecute<string>("productElementName", x_1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#copy(java.lang.String)"/>
        /// </summary>
        /// <param name="topic"><see cref="string"/></param>
        /// <returns><see cref="Kafka.Controller.TopicUncleanLeaderElectionEnable"/></returns>
        public Kafka.Controller.TopicUncleanLeaderElectionEnable Copy(string topic)
        {
            return IExecute<Kafka.Controller.TopicUncleanLeaderElectionEnable>("copy", topic);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/TopicUncleanLeaderElectionEnable.html#preempt()"/>
        /// </summary>
        public void Preempt()
        {
            IExecute("preempt");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}