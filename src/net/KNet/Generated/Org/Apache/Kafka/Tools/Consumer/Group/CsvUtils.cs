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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*  using kafka-tools-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools.Consumer.Group
{
    #region CsvUtils
    public partial class CsvUtils
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
        #region CsvRecordNoGroup
        public partial class CsvRecordNoGroup
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#org.apache.kafka.tools.consumer.group.CsvUtils$CsvRecordNoGroup(java.lang.String,int,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="long"/></param>
            public CsvRecordNoGroup(Java.Lang.String arg0, int arg1, long arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#FIELDS"/>
            /// </summary>
            public static Java.Lang.String[] FIELDS { get { if (!_FIELDSReady) { _FIELDSContent = SGetFieldArray<Java.Lang.String>(LocalBridgeClazz, "FIELDS"); _FIELDSReady = true; } return _FIELDSContent; } }
            private static Java.Lang.String[] _FIELDSContent = default;
            private static bool _FIELDSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#getOffset--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#setOffset-long-"/>
            /// </summary>
            public long Offset
            {
                get { return IExecuteWithSignature<long>("getOffset", "()J"); } set { IExecuteWithSignature("setOffset", "(J)V", value); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#getPartition--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#setPartition-int-"/>
            /// </summary>
            public int Partition
            {
                get { return IExecuteWithSignature<int>("getPartition", "()I"); } set { IExecuteWithSignature("setPartition", "(I)V", value); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#getTopic--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordNoGroup.html#setTopic-java.lang.String-"/>
            /// </summary>
            public Java.Lang.String Topic
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getTopic", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTopic", "(Ljava/lang/String;)V", value); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CsvRecordWithGroup
        public partial class CsvRecordWithGroup
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#org.apache.kafka.tools.consumer.group.CsvUtils$CsvRecordWithGroup(java.lang.String,java.lang.String,int,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="long"/></param>
            public CsvRecordWithGroup(Java.Lang.String arg0, Java.Lang.String arg1, int arg2, long arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#FIELDS"/>
            /// </summary>
            public static Java.Lang.String[] FIELDS { get { if (!_FIELDSReady) { _FIELDSContent = SGetFieldArray<Java.Lang.String>(LocalBridgeClazz, "FIELDS"); _FIELDSReady = true; } return _FIELDSContent; } }
            private static Java.Lang.String[] _FIELDSContent = default;
            private static bool _FIELDSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#getGroup--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#setGroup-java.lang.String-"/>
            /// </summary>
            public Java.Lang.String Group
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getGroup", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setGroup", "(Ljava/lang/String;)V", value); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#getOffset--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#setOffset-long-"/>
            /// </summary>
            public long Offset
            {
                get { return IExecuteWithSignature<long>("getOffset", "()J"); } set { IExecuteWithSignature("setOffset", "(J)V", value); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#getPartition--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#setPartition-int-"/>
            /// </summary>
            public int Partition
            {
                get { return IExecuteWithSignature<int>("getPartition", "()I"); } set { IExecuteWithSignature("setPartition", "(I)V", value); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#getTopic--"/> <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/CsvUtils.CsvRecordWithGroup.html#setTopic-java.lang.String-"/>
            /// </summary>
            public Java.Lang.String Topic
            {
                get { return IExecuteWithSignature<Java.Lang.String>("getTopic", "()Ljava/lang/String;"); } set { IExecuteWithSignature("setTopic", "(Ljava/lang/String;)V", value); }
            }

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