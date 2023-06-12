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
*  using kafka-clients-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Record
{
    #region CompressionRatioEstimator
    public partial class CompressionRatioEstimator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#COMPRESSION_RATIO_DETERIORATE_STEP"/>
        /// </summary>
        public static float COMPRESSION_RATIO_DETERIORATE_STEP { get { return SGetField<float>(LocalBridgeClazz, "COMPRESSION_RATIO_DETERIORATE_STEP"); } }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#COMPRESSION_RATIO_IMPROVING_STEP"/>
        /// </summary>
        public static float COMPRESSION_RATIO_IMPROVING_STEP { get { return SGetField<float>(LocalBridgeClazz, "COMPRESSION_RATIO_IMPROVING_STEP"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#estimation(java.lang.String,org.apache.kafka.common.record.CompressionType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <returns><see cref="float"/></returns>
        public static float Estimation(string arg0, Org.Apache.Kafka.Common.Record.CompressionType arg1)
        {
            return SExecute<float>(LocalBridgeClazz, "estimation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#updateEstimation(java.lang.String,org.apache.kafka.common.record.CompressionType,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public static float UpdateEstimation(string arg0, Org.Apache.Kafka.Common.Record.CompressionType arg1, float arg2)
        {
            return SExecute<float>(LocalBridgeClazz, "updateEstimation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#removeEstimation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public static void RemoveEstimation(string arg0)
        {
            SExecute(LocalBridgeClazz, "removeEstimation", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#resetEstimation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public static void ResetEstimation(string arg0)
        {
            SExecute(LocalBridgeClazz, "resetEstimation", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.4.0/org/apache/kafka/common/record/CompressionRatioEstimator.html#setEstimation(java.lang.String,org.apache.kafka.common.record.CompressionType,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Record.CompressionType"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public static void SetEstimation(string arg0, Org.Apache.Kafka.Common.Record.CompressionType arg1, float arg2)
        {
            SExecute(LocalBridgeClazz, "setEstimation", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}