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
*  using kafka-tools-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region ClientCompatibilityTest
    public partial class ClientCompatibilityTest
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.4.0/org/apache/kafka/tools/ClientCompatibilityTest.html#main(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Lang.Exception"/>
        public static void Main(string[] arg0)
        {
            SExecute(LocalBridgeClazz, "main", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.4.0/org/apache/kafka/tools/ClientCompatibilityTest.html#testConsume(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.Throwable"/>
        public void TestConsume(long arg0)
        {
            IExecute("testConsume", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.4.0/org/apache/kafka/tools/ClientCompatibilityTest.html#testProduce()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        public void TestProduce()
        {
            IExecute("testProduce");
        }

        #endregion

        #region Nested classes
        #region ClientCompatibilityTestDeserializer
        public partial class ClientCompatibilityTestDeserializer : Org.Apache.Kafka.Common.Serialization.IDeserializer<byte[]>, Org.Apache.Kafka.Common.IClusterResourceListener
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Tools.ClientCompatibilityTest.ClientCompatibilityTestDeserializer"/> to <see cref="Org.Apache.Kafka.Common.Serialization.Deserializer"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Serialization.Deserializer(Org.Apache.Kafka.Tools.ClientCompatibilityTest.ClientCompatibilityTestDeserializer t) => t.Cast<Org.Apache.Kafka.Common.Serialization.Deserializer>();
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Tools.ClientCompatibilityTest.ClientCompatibilityTestDeserializer"/> to <see cref="Org.Apache.Kafka.Common.ClusterResourceListener"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.ClusterResourceListener(Org.Apache.Kafka.Tools.ClientCompatibilityTest.ClientCompatibilityTestDeserializer t) => t.Cast<Org.Apache.Kafka.Common.ClusterResourceListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.4.0/org/apache/kafka/tools/ClientCompatibilityTest.ClientCompatibilityTestDeserializer.html#deserialize(java.lang.String,byte[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            /// <returns><see cref="object"/></returns>
            public object Deserialize(string arg0, byte[] arg1)
            {
                return IExecute("deserialize", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.4.0/org/apache/kafka/tools/ClientCompatibilityTest.ClientCompatibilityTestDeserializer.html#onUpdate(org.apache.kafka.common.ClusterResource)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.ClusterResource"/></param>
            public void OnUpdate(Org.Apache.Kafka.Common.ClusterResource arg0)
            {
                IExecute("onUpdate", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}