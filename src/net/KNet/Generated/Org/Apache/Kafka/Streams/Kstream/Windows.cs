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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Kstream
{
    #region Windows
    public partial class Windows
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/Windows.html#windowsFor-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map WindowsFor(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Map>("windowsFor", "(J)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/Windows.html#gracePeriodMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GracePeriodMs()
        {
            return IExecuteWithSignature<long>("gracePeriodMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/Windows.html#size--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Windows<W>
    public partial class Windows<W>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Streams.Kstream.Windows{W}"/> to <see cref="Org.Apache.Kafka.Streams.Kstream.Windows"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Streams.Kstream.Windows(Org.Apache.Kafka.Streams.Kstream.Windows<W> t) => t.Cast<Org.Apache.Kafka.Streams.Kstream.Windows>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/Windows.html#windowsFor-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public Java.Util.Map<Java.Lang.Long, W> WindowsFor(long arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Java.Lang.Long, W>>("windowsFor", "(J)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/Windows.html#gracePeriodMs--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long GracePeriodMs()
        {
            return IExecuteWithSignature<long>("gracePeriodMs", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/kstream/Windows.html#size--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long Size()
        {
            return IExecuteWithSignature<long>("size", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}