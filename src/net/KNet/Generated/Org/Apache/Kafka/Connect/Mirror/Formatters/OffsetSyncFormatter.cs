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
*  using connect-mirror-3.6.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror.Formatters
{
    #region OffsetSyncFormatter
    public partial class OffsetSyncFormatter
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.6.0/org/apache/kafka/connect/mirror/formatters/OffsetSyncFormatter.html#writeTo-org.apache.kafka.clients.consumer.ConsumerRecord-java.io.PrintStream-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Consumer.ConsumerRecord"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintStream"/></param>
        public void WriteTo(Org.Apache.Kafka.Clients.Consumer.ConsumerRecord<byte[], byte[]> arg0, Java.Io.PrintStream arg1)
        {
            IExecute("writeTo", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}