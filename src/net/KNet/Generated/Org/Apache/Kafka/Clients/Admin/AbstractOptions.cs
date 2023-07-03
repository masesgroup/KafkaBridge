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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region AbstractOptions
    public partial class AbstractOptions
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/admin/AbstractOptions.html#timeoutMs--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int? TimeoutMs()
        {
            return IExecute<int?>("timeoutMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/admin/AbstractOptions.html#timeoutMs-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.AbstractOptions"/></returns>
        public Org.Apache.Kafka.Clients.Admin.AbstractOptions TimeoutMs(int? arg0)
        {
            return IExecute<Org.Apache.Kafka.Clients.Admin.AbstractOptions>("timeoutMs", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractOptions<T>
    public partial class AbstractOptions<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Clients.Admin.AbstractOptions{T}"/> to <see cref="Org.Apache.Kafka.Clients.Admin.AbstractOptions"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Clients.Admin.AbstractOptions(Org.Apache.Kafka.Clients.Admin.AbstractOptions<T> t) => t.Cast<Org.Apache.Kafka.Clients.Admin.AbstractOptions>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/admin/AbstractOptions.html#timeoutMs--"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int? TimeoutMs()
        {
            return IExecute<int?>("timeoutMs");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/clients/admin/AbstractOptions.html#timeoutMs-java.lang.Integer-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><typeparamref name="T"/></returns>
        public T TimeoutMs(int? arg0)
        {
            return IExecute<T>("timeoutMs", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}