/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*  using kafka-shell-3.9.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Shell
{
    #region InteractiveShell declaration
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.html"/>
    /// </summary>
    public partial class InteractiveShell : Java.Lang.AutoCloseable
    {
        const string _bridgeClassName = "org.apache.kafka.shell.InteractiveShell";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public InteractiveShell() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public InteractiveShell(params object[] args) : base(args) { }

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
        public override bool IsBridgeCloseable => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        // TODO: complete the class
        #region HistoryIterator declaration
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.HistoryIterator.html"/>
        /// </summary>
        public partial class HistoryIterator : Java.Util.Iterator<Java.Util.Map.Entry<Java.Lang.Integer, Java.Lang.String>>
        {
            const string _bridgeClassName = "org.apache.kafka.shell.InteractiveShell$HistoryIterator";
            /// <summary>
            /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
            /// </summary>
            public HistoryIterator() { }
            /// <summary>
            /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
            /// </summary>
            public HistoryIterator(params object[] args) : base(args) { }

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

    
    }
    #endregion

    #region InteractiveShell implementation
    public partial class InteractiveShell
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.html#screenWidth--"/>
        /// </summary>
        /// <returns><see cref="int"/></returns>
        public int ScreenWidth()
        {
            return IExecuteWithSignature<int>("screenWidth", "()I");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.html#history-int-"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Util.Map.Entry<Java.Lang.Integer, Java.Lang.String>> History(int arg0)
        {
            return IExecuteWithSignature<Java.Util.Iterator<Java.Util.Map.Entry<Java.Lang.Integer, Java.Lang.String>>>("history", "(I)Ljava/util/Iterator;", arg0);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.html#close--"/>
        /// </summary>
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecuteWithSignature("close", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.html#runMainLoop--"/>
        /// </summary>
        /// <exception cref="Java.Lang.Exception"/>
        public void RunMainLoop()
        {
            IExecuteWithSignature("runMainLoop", "()V");
        }

        #endregion

        #region Nested classes
        #region HistoryIterator implementation
        public partial class HistoryIterator
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.HistoryIterator.html#hasNext--"/>
            /// </summary>
            /// <returns><see cref="bool"/></returns>
            public bool HasNext()
            {
                return IExecuteWithSignature<bool>("hasNext", "()Z");
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-shell/3.9.0/org/apache/kafka/shell/InteractiveShell.HistoryIterator.html#next--"/>
            /// </summary>
            /// <returns><see cref="object"/></returns>
            public object Next()
            {
                return IExecuteWithSignature("next", "()Ljava/lang/Object;");
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