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
*  This file is generated by MASES.JNetReflector (ver. 2.5.1.0)
*  using connect-api-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Header
{
    #region IHeaders
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IHeaders
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Headers
    public partial class Headers : Org.Apache.Kafka.Connect.Header.IHeaders
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#isEmpty--"/>
        /// </summary>
        /// <returns><see cref="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecuteWithSignature<bool>("isEmpty", "()Z");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#size--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecuteWithSignature<int>("size", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#allWithName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Org.Apache.Kafka.Connect.Header.Header> AllWithName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Iterator<Org.Apache.Kafka.Connect.Header.Header>>("allWithName", "(Ljava/lang/String;)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#lastWithName-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Header"/></returns>
        public Org.Apache.Kafka.Connect.Header.Header LastWithName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Header>("lastWithName", "(Ljava/lang/String;)Lorg/apache/kafka/connect/header/Header;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#add-java.lang.String-java.lang.Object-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Add(Java.Lang.String arg0, object arg1, Org.Apache.Kafka.Connect.Data.Schema arg2)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("add", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#add-java.lang.String-org.apache.kafka.connect.data.SchemaAndValue-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.SchemaAndValue"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Add(Java.Lang.String arg0, Org.Apache.Kafka.Connect.Data.SchemaAndValue arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#add-org.apache.kafka.connect.header.Header-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Header.Header"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Add(Org.Apache.Kafka.Connect.Header.Header arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("add", "(Lorg/apache/kafka/connect/header/Header;)Lorg/apache/kafka/connect/header/Headers;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addBoolean-java.lang.String-boolean-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddBoolean(Java.Lang.String arg0, bool arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addBoolean", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addByte-java.lang.String-byte-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddByte(Java.Lang.String arg0, byte arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addByte", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addBytes-java.lang.String-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddBytes(Java.Lang.String arg0, byte[] arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addBytes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addDate-java.lang.String-java.util.Date-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddDate(Java.Lang.String arg0, Java.Util.Date arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addDecimal-java.lang.String-java.math.BigDecimal-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigDecimal"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddDecimal(Java.Lang.String arg0, Java.Math.BigDecimal arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addDecimal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addDouble-java.lang.String-double-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="double"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddDouble(Java.Lang.String arg0, double arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addDouble", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addFloat-java.lang.String-float-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddFloat(Java.Lang.String arg0, float arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addFloat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addInt-java.lang.String-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddInt(Java.Lang.String arg0, int arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addList-java.lang.String-java.util.List-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddList(Java.Lang.String arg0, Java.Util.List<object> arg1, Org.Apache.Kafka.Connect.Data.Schema arg2)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addList", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addLong-java.lang.String-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddLong(Java.Lang.String arg0, long arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addMap-java.lang.String-java.util.Map-org.apache.kafka.connect.data.Schema-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddMap(Java.Lang.String arg0, Java.Util.Map<object, object> arg1, Org.Apache.Kafka.Connect.Data.Schema arg2)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addMap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addShort-java.lang.String-short-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddShort(Java.Lang.String arg0, short arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addShort", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addString-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddString(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addStruct-java.lang.String-org.apache.kafka.connect.data.Struct-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddStruct(Java.Lang.String arg0, Org.Apache.Kafka.Connect.Data.Struct arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addStruct", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addTime-java.lang.String-java.util.Date-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddTime(Java.Lang.String arg0, Java.Util.Date arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addTime", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#addTimestamp-java.lang.String-java.util.Date-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers AddTimestamp(Java.Lang.String arg0, Java.Util.Date arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("addTimestamp", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#apply-java.lang.String-org.apache.kafka.connect.header.Headers.HeaderTransform-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Connect.Header.Headers.HeaderTransform"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Apply(Java.Lang.String arg0, Org.Apache.Kafka.Connect.Header.Headers.HeaderTransform arg1)
        {
            return IExecute<Org.Apache.Kafka.Connect.Header.Headers>("apply", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#apply-org.apache.kafka.connect.header.Headers.HeaderTransform-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Header.Headers.HeaderTransform"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Apply(Org.Apache.Kafka.Connect.Header.Headers.HeaderTransform arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("apply", "(Lorg/apache/kafka/connect/header/Headers$HeaderTransform;)Lorg/apache/kafka/connect/header/Headers;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#clear--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Clear()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("clear", "()Lorg/apache/kafka/connect/header/Headers;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#duplicate--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Duplicate()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("duplicate", "()Lorg/apache/kafka/connect/header/Headers;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#remove-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers Remove(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("remove", "(Ljava/lang/String;)Lorg/apache/kafka/connect/header/Headers;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#retainLatest--"/>
        /// </summary>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers RetainLatest()
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("retainLatest", "()Lorg/apache/kafka/connect/header/Headers;");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.html#retainLatest-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Headers"/></returns>
        public Org.Apache.Kafka.Connect.Header.Headers RetainLatest(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Headers>("retainLatest", "(Ljava/lang/String;)Lorg/apache/kafka/connect/header/Headers;", arg0);
        }

        #endregion

        #region Nested classes
        #region HeaderTransform
        public partial class HeaderTransform
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.7.0/org/apache/kafka/connect/header/Headers.HeaderTransform.html#apply-org.apache.kafka.connect.header.Header-"/>
            /// </summary>
            /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Header.Header"/></param>
            /// <returns><see cref="Org.Apache.Kafka.Connect.Header.Header"/></returns>
            public Org.Apache.Kafka.Connect.Header.Header Apply(Org.Apache.Kafka.Connect.Header.Header arg0)
            {
                return IExecuteWithSignature<Org.Apache.Kafka.Connect.Header.Header>("apply", "(Lorg/apache/kafka/connect/header/Header;)Lorg/apache/kafka/connect/header/Header;", arg0);
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