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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*  using connect-api-3.8.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Data
{
    #region Values declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html"/>
    /// </summary>
    public partial class Values : MASES.JCOBridge.C2JBridge.JVMBridgeBase<Values>
    {
        const string _bridgeClassName = "org.apache.kafka.connect.data.Values";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Values() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Values(params object[] args) : base(args) { }

        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class

    }
    #endregion

    #region Values implementation
    public partial class Values
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToBoolean-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Boolean ConvertToBoolean(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Boolean>(LocalBridgeClazz, "convertToBoolean", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Boolean;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToByte-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Byte"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Byte ConvertToByte(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Byte>(LocalBridgeClazz, "convertToByte", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Byte;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToDouble-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Double"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Double ConvertToDouble(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Double>(LocalBridgeClazz, "convertToDouble", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Double;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToFloat-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Float"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Float ConvertToFloat(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Float>(LocalBridgeClazz, "convertToFloat", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Float;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToInteger-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Integer ConvertToInteger(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Integer>(LocalBridgeClazz, "convertToInteger", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Integer;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToLong-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Long"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Long ConvertToLong(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Long>(LocalBridgeClazz, "convertToLong", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Long;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToShort-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.Short"/></returns>
        /// <exception cref="Org.Apache.Kafka.Connect.Errors.DataException"/>
        public static Java.Lang.Short ConvertToShort(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.Short>(LocalBridgeClazz, "convertToShort", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/Short;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToString-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ConvertToString(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "convertToString", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/lang/String;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToDecimal-org.apache.kafka.connect.data.Schema-java.lang.Object-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        public static Java.Math.BigDecimal ConvertToDecimal(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1, int arg2)
        {
            return SExecuteWithSignature<Java.Math.BigDecimal>(LocalBridgeClazz, "convertToDecimal", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;I)Ljava/math/BigDecimal;", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#dateFormatFor-java.util.Date-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <returns><see cref="Java.Text.DateFormat"/></returns>
        public static Java.Text.DateFormat DateFormatFor(Java.Util.Date arg0)
        {
            return SExecuteWithSignature<Java.Text.DateFormat>(LocalBridgeClazz, "dateFormatFor", "(Ljava/util/Date;)Ljava/text/DateFormat;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToDate-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public static Java.Util.Date ConvertToDate(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Util.Date>(LocalBridgeClazz, "convertToDate", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/util/Date;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToTime-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public static Java.Util.Date ConvertToTime(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Util.Date>(LocalBridgeClazz, "convertToTime", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/util/Date;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToTimestamp-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Date"/></returns>
        public static Java.Util.Date ConvertToTimestamp(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Util.Date>(LocalBridgeClazz, "convertToTimestamp", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/util/Date;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToList-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        public static Java.Util.List<object> ConvertToList(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Util.List<object>>(LocalBridgeClazz, "convertToList", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/util/List;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToMap-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        public static Java.Util.Map<object, object> ConvertToMap(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Java.Util.Map<object, object>>(LocalBridgeClazz, "convertToMap", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Ljava/util/Map;", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#inferSchema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></returns>
        public static Org.Apache.Kafka.Connect.Data.Schema InferSchema(object arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Schema>(LocalBridgeClazz, "inferSchema", "(Ljava/lang/Object;)Lorg/apache/kafka/connect/data/Schema;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#parseString-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.SchemaAndValue"/></returns>
        public static Org.Apache.Kafka.Connect.Data.SchemaAndValue ParseString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.SchemaAndValue>(LocalBridgeClazz, "parseString", "(Ljava/lang/String;)Lorg/apache/kafka/connect/data/SchemaAndValue;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.8.1/org/apache/kafka/connect/data/Values.html#convertToStruct-org.apache.kafka.connect.data.Schema-java.lang.Object-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Data.Schema"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Data.Struct"/></returns>
        public static Org.Apache.Kafka.Connect.Data.Struct ConvertToStruct(Org.Apache.Kafka.Connect.Data.Schema arg0, object arg1)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Connect.Data.Struct>(LocalBridgeClazz, "convertToStruct", "(Lorg/apache/kafka/connect/data/Schema;Ljava/lang/Object;)Lorg/apache/kafka/connect/data/Struct;", arg0, arg1);
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