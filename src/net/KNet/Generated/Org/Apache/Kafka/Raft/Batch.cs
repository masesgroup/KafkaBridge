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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-raft-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Raft
{
    #region Batch
    public partial class Batch
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#control-long-int-long-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Batch"/></returns>
        public static Org.Apache.Kafka.Raft.Batch Control(long arg0, int arg1, long arg2, int arg3, Java.Util.List arg4)
        {
            return SExecute<Org.Apache.Kafka.Raft.Batch>(LocalBridgeClazz, "control", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#data-long-int-long-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Batch"/></returns>
        public static Org.Apache.Kafka.Raft.Batch Data(long arg0, int arg1, long arg2, int arg3, Java.Util.List arg4)
        {
            return SExecute<Org.Apache.Kafka.Raft.Batch>(LocalBridgeClazz, "data", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#epoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#sizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int SizeInBytes()
        {
            return IExecuteWithSignature<int>("sizeInBytes", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#iterator--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#controlRecords--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List ControlRecords()
        {
            return IExecuteWithSignature<Java.Util.List>("controlRecords", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#records--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List Records()
        {
            return IExecuteWithSignature<Java.Util.List>("records", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#appendTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long AppendTimestamp()
        {
            return IExecuteWithSignature<long>("appendTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#baseOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long BaseOffset()
        {
            return IExecuteWithSignature<long>("baseOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#lastOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LastOffset()
        {
            return IExecuteWithSignature<long>("lastOffset", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Batch<T>
    public partial class Batch<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Org.Apache.Kafka.Raft.Batch{T}"/> to <see cref="Org.Apache.Kafka.Raft.Batch"/>
        /// </summary>
        public static implicit operator Org.Apache.Kafka.Raft.Batch(Org.Apache.Kafka.Raft.Batch<T> t) => t.Cast<Org.Apache.Kafka.Raft.Batch>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#control-long-int-long-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Batch"/></returns>
        public static Org.Apache.Kafka.Raft.Batch<T> Control(long arg0, int arg1, long arg2, int arg3, Java.Util.List<Org.Apache.Kafka.Raft.ControlRecord> arg4)
        {
            return SExecute<Org.Apache.Kafka.Raft.Batch<T>>(LocalBridgeClazz, "control", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#data-long-int-long-int-java.util.List-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Raft.Batch"/></returns>
        public static Org.Apache.Kafka.Raft.Batch<T> Data(long arg0, int arg1, long arg2, int arg3, Java.Util.List<T> arg4)
        {
            return SExecute<Org.Apache.Kafka.Raft.Batch<T>>(LocalBridgeClazz, "data", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#epoch--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Epoch()
        {
            return IExecuteWithSignature<int>("epoch", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#sizeInBytes--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int SizeInBytes()
        {
            return IExecuteWithSignature<int>("sizeInBytes", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#iterator--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> Iterator()
        {
            return IExecuteWithSignature<Java.Util.Iterator<T>>("iterator", "()Ljava/util/Iterator;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#controlRecords--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<Org.Apache.Kafka.Raft.ControlRecord> ControlRecords()
        {
            return IExecuteWithSignature<Java.Util.List<Org.Apache.Kafka.Raft.ControlRecord>>("controlRecords", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#records--"/>
        /// </summary>
        /// <returns><see cref="Java.Util.List"/></returns>
        public Java.Util.List<T> Records()
        {
            return IExecuteWithSignature<Java.Util.List<T>>("records", "()Ljava/util/List;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#appendTimestamp--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long AppendTimestamp()
        {
            return IExecuteWithSignature<long>("appendTimestamp", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#baseOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long BaseOffset()
        {
            return IExecuteWithSignature<long>("baseOffset", "()J");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-raft/3.7.1/org/apache/kafka/raft/Batch.html#lastOffset--"/>
        /// </summary>
        /// <returns><see cref="long"/></returns>
        public long LastOffset()
        {
            return IExecuteWithSignature<long>("lastOffset", "()J");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}