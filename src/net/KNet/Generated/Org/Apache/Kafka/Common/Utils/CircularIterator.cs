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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using kafka-clients-3.6.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Utils
{
    #region CircularIterator
    public partial class CircularIterator
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#org.apache.kafka.common.utils.CircularIterator(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public CircularIterator(Java.Util.Collection arg0)
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
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#hasNext--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#next--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecute("next");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#peek--"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecute("peek");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#remove--"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CircularIterator<T>
    public partial class CircularIterator<T>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#org.apache.kafka.common.utils.CircularIterator(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public CircularIterator(Java.Util.Collection<T> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Common.Utils.CircularIterator{T}"/> to <see cref="Org.Apache.Kafka.Common.Utils.CircularIterator"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Common.Utils.CircularIterator(Org.Apache.Kafka.Common.Utils.CircularIterator<T> t) => t.Cast<Org.Apache.Kafka.Common.Utils.CircularIterator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#hasNext--"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#next--"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Next()
        {
            return IExecute<T>("next");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#peek--"/>
        /// </summary>

        /// <returns><typeparamref name="T"/></returns>
        public T Peek()
        {
            return IExecute<T>("peek");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.1/org/apache/kafka/common/utils/CircularIterator.html#remove--"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}