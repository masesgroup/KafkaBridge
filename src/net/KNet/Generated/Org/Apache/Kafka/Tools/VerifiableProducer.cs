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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*  using kafka-tools-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region VerifiableProducer declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html"/>
    /// </summary>
    public partial class VerifiableProducer : Java.Lang.AutoCloseable, MASES.JCOBridge.C2JBridge.IJVMBridgeMain
    {
        const string _bridgeClassName = "org.apache.kafka.tools.VerifiableProducer";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public VerifiableProducer() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public VerifiableProducer(params object[] args) : base(args) { }

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

    #region VerifiableProducer implementation
    public partial class VerifiableProducer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#org.apache.kafka.tools.VerifiableProducer(org.apache.kafka.clients.producer.KafkaProducer,java.lang.String,int,int,java.lang.Integer,java.lang.Long,java.lang.Integer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Clients.Producer.KafkaProducer"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Lang.Integer"/></param>
        /// <param name="arg5"><see cref="Java.Lang.Long"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Integer"/></param>
        public VerifiableProducer(Org.Apache.Kafka.Clients.Producer.KafkaProducer<Java.Lang.String, Java.Lang.String> arg0, Java.Lang.String arg1, int arg2, int arg3, Java.Lang.Integer arg4, Java.Lang.Long arg5, Java.Lang.Integer arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#loadProps-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Properties"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Util.Properties LoadProps(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Properties>(LocalBridgeClazz, "loadProps", "(Ljava/lang/String;)Ljava/util/Properties;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#getKey--"/> 
        /// </summary>
        public Java.Lang.String Key
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getKey", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#getValue-long-"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetValue(long arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getValue", "(J)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#close--"/>
        /// </summary>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/VerifiableProducer.html#send-java.lang.String-java.lang.String-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public void Send(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            IExecuteWithSignature("send", "(Ljava/lang/String;Ljava/lang/String;)V", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}