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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Clients.Admin
{
    #region OffsetSpec
    public partial class OffsetSpec
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/OffsetSpec.html#earliest--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.OffsetSpec"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.OffsetSpec Earliest()
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.OffsetSpec>(LocalBridgeClazz, "earliest");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/OffsetSpec.html#forTimestamp-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.OffsetSpec"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.OffsetSpec ForTimestamp(long arg0)
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.OffsetSpec>(LocalBridgeClazz, "forTimestamp", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/OffsetSpec.html#latest--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.OffsetSpec"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.OffsetSpec Latest()
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.OffsetSpec>(LocalBridgeClazz, "latest");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/clients/admin/OffsetSpec.html#maxTimestamp--"/>
        /// </summary>

        /// <returns><see cref="Org.Apache.Kafka.Clients.Admin.OffsetSpec"/></returns>
        public static Org.Apache.Kafka.Clients.Admin.OffsetSpec MaxTimestamp()
        {
            return SExecute<Org.Apache.Kafka.Clients.Admin.OffsetSpec>(LocalBridgeClazz, "maxTimestamp");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region EarliestSpec
        public partial class EarliestSpec
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region LatestSpec
        public partial class LatestSpec
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MaxTimestampSpec
        public partial class MaxTimestampSpec
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TimestampSpec
        public partial class TimestampSpec
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