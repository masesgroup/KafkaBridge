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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*  using kafka-clients-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Metrics
{
    #region IMeasurableStat
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IMeasurableStat
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MeasurableStat
    public partial class MeasurableStat : Org.Apache.Kafka.Common.Metrics.IMeasurableStat, Org.Apache.Kafka.Common.Metrics.IStat, Org.Apache.Kafka.Common.Metrics.IMeasurable
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Metrics.MeasurableStat"/> to <see cref="Org.Apache.Kafka.Common.Metrics.Stat"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Metrics.Stat(Org.Apache.Kafka.Common.Metrics.MeasurableStat t) => t.Cast<Org.Apache.Kafka.Common.Metrics.Stat>();
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Metrics.MeasurableStat"/> to <see cref="Org.Apache.Kafka.Common.Metrics.Measurable"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Metrics.Measurable(Org.Apache.Kafka.Common.Metrics.MeasurableStat t) => t.Cast<Org.Apache.Kafka.Common.Metrics.Measurable>();

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
}