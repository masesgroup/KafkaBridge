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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using kafka-tools-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools
{
    #region ConnectPluginPath
    public partial class ConnectPluginPath
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/ConnectPluginPath.html#LIST_TABLE_COLUMNS"/>
        /// </summary>
        public static object[] LIST_TABLE_COLUMNS { get { if (!_LIST_TABLE_COLUMNSReady) { _LIST_TABLE_COLUMNSContent = SGetFieldArray<object>(LocalBridgeClazz, "LIST_TABLE_COLUMNS"); _LIST_TABLE_COLUMNSReady = true; } return _LIST_TABLE_COLUMNSContent; } }
        private static object[] _LIST_TABLE_COLUMNSContent = default;
        private static bool _LIST_TABLE_COLUMNSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/ConnectPluginPath.html#NO_ALIAS"/>
        /// </summary>
        public static Java.Lang.String NO_ALIAS { get { if (!_NO_ALIASReady) { _NO_ALIASContent = SGetField<Java.Lang.String>(LocalBridgeClazz, "NO_ALIAS"); _NO_ALIASReady = true; } return _NO_ALIASContent; } }
        private static Java.Lang.String _NO_ALIASContent = default;
        private static bool _NO_ALIASReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/ConnectPluginPath.html#mainNoExit-java.lang.String[]-java.io.PrintStream-java.io.PrintStream-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Io.PrintStream"/></param>
        /// <param name="arg2"><see cref="Java.Io.PrintStream"/></param>
        /// <returns><see cref="int"/></returns>
        public static int MainNoExit(Java.Lang.String[] arg0, Java.Io.PrintStream arg1, Java.Io.PrintStream arg2)
        {
            return SExecute<int>(LocalBridgeClazz, "mainNoExit", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.6.2/org/apache/kafka/tools/ConnectPluginPath.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
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