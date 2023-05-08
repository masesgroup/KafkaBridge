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
    #region BrokerChangeHandler
    public partial class BrokerChangeHandler
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/BrokerChangeHandler.html#%3Cinit%3E(kafka.controller.ControllerEventManager)"/>
        /// </summary>
        /// <param name="eventManager"><see cref="Kafka.Controller.ControllerEventManager"/></param>
        public BrokerChangeHandler(Kafka.Controller.ControllerEventManager eventManager)
            : base(eventManager)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Kafka.Controller.BrokerChangeHandler"/> to <see cref="Kafka.Zookeeper.ZNodeChildChangeHandler"/>
        /// </summary>
        public static implicit operator Kafka.Zookeeper.ZNodeChildChangeHandler(Kafka.Controller.BrokerChangeHandler t) => t.Cast<Kafka.Zookeeper.ZNodeChildChangeHandler>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/BrokerChangeHandler.html#path()"/> 
        /// </summary>
        public string Path
        {
            get { return IExecute<string>("path"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka_2.13/3.4.0/kafka/controller/BrokerChangeHandler.html#handleChildChange()"/>
        /// </summary>
        public void HandleChildChange()
        {
            IExecute("handleChildChange");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}