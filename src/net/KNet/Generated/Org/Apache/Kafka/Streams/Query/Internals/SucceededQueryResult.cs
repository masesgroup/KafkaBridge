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
*  using kafka-streams-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Query.Internals
{
    #region SucceededQueryResult
    public partial class SucceededQueryResult
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/query/internals/SucceededQueryResult.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public SucceededQueryResult(object arg0)
            : base(arg0)
        {
        }

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

    #region SucceededQueryResult<R>
    public partial class SucceededQueryResult<R>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/query/internals/SucceededQueryResult.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="R"/></param>
        public SucceededQueryResult(R arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Query.Internals.SucceededQueryResult{R}"/> to <see cref="Org.Apache.Kafka.Streams.Query.Internals.SucceededQueryResult"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Query.Internals.SucceededQueryResult(Org.Apache.Kafka.Streams.Query.Internals.SucceededQueryResult<R> t) => t.Cast<Org.Apache.Kafka.Streams.Query.Internals.SucceededQueryResult>();

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