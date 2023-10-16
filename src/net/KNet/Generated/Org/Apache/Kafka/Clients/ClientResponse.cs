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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using kafka-clients-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients
{
    #region ClientResponse
    public partial class ClientResponse
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#hasResponse--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasResponse()
        {
            return IExecute<bool>("hasResponse");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#wasDisconnected--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool WasDisconnected()
        {
            return IExecute<bool>("wasDisconnected");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#wasTimedOut--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool WasTimedOut()
        {
            return IExecute<bool>("wasTimedOut");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#destination--"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Destination()
        {
            return IExecute<string>("destination");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#receivedTimeMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReceivedTimeMs()
        {
            return IExecute<long>("receivedTimeMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#requestLatencyMs--"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long RequestLatencyMs()
        {
            return IExecute<long>("requestLatencyMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#authenticationException--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Errors.AuthenticationException"/></returns>
        public Org.Apache.Kafka.Common.Errors.AuthenticationException AuthenticationException()
        {
            var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("authenticationException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Apache.Kafka.Common.Errors.AuthenticationException>(obj);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#versionMismatch--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Common.Errors.UnsupportedVersionException"/></returns>
        public Org.Apache.Kafka.Common.Errors.UnsupportedVersionException VersionMismatch()
        {
            var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("versionMismatch"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Apache.Kafka.Common.Errors.UnsupportedVersionException>(obj);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.0/org/apache/kafka/clients/ClientResponse.html#onComplete--"/>
        /// </summary>
        public void OnComplete()
        {
            IExecute("onComplete");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}