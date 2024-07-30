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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-clients-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region DescribeProducersOptions
    public partial class DescribeProducersOptions
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/DescribeProducersOptions.html#brokerId--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.OptionalInt"/></returns>
        public Java.Util.OptionalInt BrokerId()
        {
            return IExecuteWithSignature<Java.Util.OptionalInt>("brokerId", "()Ljava/util/OptionalInt;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.8.0/org/apache/kafka/clients/admin/DescribeProducersOptions.html#brokerId-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.DescribeProducersOptions"/></returns>
        public Org.Apache.Kafka.Clients.Admin.DescribeProducersOptions BrokerId(int arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Clients.Admin.DescribeProducersOptions>("brokerId", "(I)Lorg/apache/kafka/clients/admin/DescribeProducersOptions;", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}