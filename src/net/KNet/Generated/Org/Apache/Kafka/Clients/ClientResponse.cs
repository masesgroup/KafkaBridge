/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-clients-3.7.0.jar as reference
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#hasResponse--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool HasResponse()
        {
            return IExecuteWithSignature<bool>("hasResponse", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#wasDisconnected--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WasDisconnected()
        {
            return IExecuteWithSignature<bool>("wasDisconnected", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#wasTimedOut--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool WasTimedOut()
        {
            return IExecuteWithSignature<bool>("wasTimedOut", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#destination--"/>
        /// </summary>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String Destination()
        {
            return IExecuteWithSignature<Java.Lang.String>("destination", "()Ljava/lang/String;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#receivedTimeMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long ReceivedTimeMs()
        {
            return IExecuteWithSignature<long>("receivedTimeMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#requestLatencyMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long RequestLatencyMs()
        {
            return IExecuteWithSignature<long>("requestLatencyMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#authenticationException--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Errors.AuthenticationException"/></returns>
        public Org.Apache.Kafka.Common.Errors.AuthenticationException AuthenticationException()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("authenticationException", "()Lorg/apache/kafka/common/errors/AuthenticationException;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Apache.Kafka.Common.Errors.AuthenticationException>(obj);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#versionMismatch--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Errors.UnsupportedVersionException"/></returns>
        public Org.Apache.Kafka.Common.Errors.UnsupportedVersionException VersionMismatch()
        {
            var obj = IExecuteWithSignature<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("versionMismatch", "()Lorg/apache/kafka/common/errors/UnsupportedVersionException;"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Org.Apache.Kafka.Common.Errors.UnsupportedVersionException>(obj);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/clients/ClientResponse.html#onComplete--"/>
        /// </summary>
        public void OnComplete()
        {
            IExecuteWithSignature("onComplete", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}