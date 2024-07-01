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

namespace Org.Apache.Kafka.Common.Header
{
    #region IHeaders
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHeaders
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Headers
    public partial class Headers : Org.Apache.Kafka.Common.Header.IHeaders
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/header/Headers.html#headers-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<Org.Apache.Kafka.Common.Header.Header> HeadersMethod(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Iterable<Org.Apache.Kafka.Common.Header.Header>>("headers", "(Ljava/lang/String;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/header/Headers.html#lastHeader-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Header"/></returns>
        public Org.Apache.Kafka.Common.Header.Header LastHeader(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Header.Header>("lastHeader", "(Ljava/lang/String;)Lorg/apache/kafka/common/header/Header;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/header/Headers.html#toArray--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Header"/></returns>
        public Org.Apache.Kafka.Common.Header.Header[] ToArray()
        {
            return IExecuteWithSignatureArray<Org.Apache.Kafka.Common.Header.Header>("toArray", "()[Lorg/apache/kafka/common/header/Header;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/header/Headers.html#add-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public Org.Apache.Kafka.Common.Header.Headers Add(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Header.Headers>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/header/Headers.html#add-org.apache.kafka.common.header.Header-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Common.Header.Header"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public Org.Apache.Kafka.Common.Header.Headers Add(Org.Apache.Kafka.Common.Header.Header arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Header.Headers>("add", "(Lorg/apache/kafka/common/header/Header;)Lorg/apache/kafka/common/header/Headers;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.7.0/org/apache/kafka/common/header/Headers.html#remove-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Common.Header.Headers"/></returns>
        /// <exception cref="Java.Lang.IllegalStateException"/>
        public Org.Apache.Kafka.Common.Header.Headers Remove(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Common.Header.Headers>("remove", "(Ljava/lang/String;)Lorg/apache/kafka/common/header/Headers;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}