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

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region ValueTransformer
    public partial class ValueTransformer
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html#close()"/>
        /// </summary>
        public virtual void Close()
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html#init(org.apache.kafka.streams.processor.ProcessorContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.ProcessorContext"/></param>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.ProcessorContext arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html#transform(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public virtual object Transform(object arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IValueTransformer<V, VR>
    /// <summary>
    /// .NET interface for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html"/>
    /// </summary>
    public partial interface IValueTransformer<V, VR>
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ValueTransformer<V, VR>
    public partial class ValueTransformer<V, VR> : Org.Apache.Kafka.Streams.Kstream.IValueTransformer<V, VR>
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html#close()"/>
        /// </summary>
        public virtual void Close()
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html#init(org.apache.kafka.streams.processor.ProcessorContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Streams.Processor.ProcessorContext"/></param>
        public virtual void Init(Org.Apache.Kafka.Streams.Processor.ProcessorContext arg0)
        {
            
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.4.0/org/apache/kafka/streams/kstream/ValueTransformer.html#transform(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="VR"/></returns>
        public virtual VR Transform(V arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}