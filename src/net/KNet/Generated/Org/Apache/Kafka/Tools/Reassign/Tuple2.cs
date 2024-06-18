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
*  using kafka-tools-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools.Reassign
{
    #region Tuple2
    public partial class Tuple2
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/reassign/Tuple2.html#org.apache.kafka.tools.reassign.Tuple2(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public Tuple2(object arg0, object arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/reassign/Tuple2.html#v1"/>
        /// </summary>
        public object v1 { get { if (!_v1Ready) { _v1Content = IGetField<object>("v1"); _v1Ready = true; } return _v1Content; } }
        private object _v1Content = default;
        private bool _v1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/reassign/Tuple2.html#v2"/>
        /// </summary>
        public object v2 { get { if (!_v2Ready) { _v2Content = IGetField<object>("v2"); _v2Ready = true; } return _v2Content; } }
        private object _v2Content = default;
        private bool _v2Ready = false; // this is used because in case of generics 

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

    #region Tuple2<V1, V2>
    public partial class Tuple2<V1, V2>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/reassign/Tuple2.html#org.apache.kafka.tools.reassign.Tuple2(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="V1"/></param>
        /// <param name="arg1"><typeparamref name="V2"/></param>
        public Tuple2(V1 arg0, V2 arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Tools.Reassign.Tuple2{V1, V2}"/> to <see cref="Org.Apache.Kafka.Tools.Reassign.Tuple2"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Tools.Reassign.Tuple2(Org.Apache.Kafka.Tools.Reassign.Tuple2<V1, V2> t) => t.Cast<Org.Apache.Kafka.Tools.Reassign.Tuple2>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/reassign/Tuple2.html#v1"/>
        /// </summary>
        public V1 v1 { get { if (!_v1Ready) { _v1Content = IGetField<V1>("v1"); _v1Ready = true; } return _v1Content; } }
        private V1 _v1Content = default;
        private bool _v1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.7.0/org/apache/kafka/tools/reassign/Tuple2.html#v2"/>
        /// </summary>
        public V2 v2 { get { if (!_v2Ready) { _v2Content = IGetField<V2>("v2"); _v2Ready = true; } return _v2Content; } }
        private V2 _v2Content = default;
        private bool _v2Ready = false; // this is used because in case of generics 

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