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
*  using connect-mirror-3.7.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Mirror
{
    #region MirrorMaker
    public partial class MirrorMaker
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#org.apache.kafka.connect.mirror.MirrorMaker(java.util.Map,java.util.List,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public MirrorMaker(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0, Java.Util.List<Java.Lang.String> arg1, Org.Apache.Kafka.Common.Utils.Time arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#org.apache.kafka.connect.mirror.MirrorMaker(java.util.Map,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        public MirrorMaker(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0, Java.Util.List<Java.Lang.String> arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#org.apache.kafka.connect.mirror.MirrorMaker(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public MirrorMaker(Java.Util.Map<Java.Lang.String, Java.Lang.String> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#org.apache.kafka.connect.mirror.MirrorMaker(org.apache.kafka.connect.mirror.MirrorMakerConfig,java.util.List,org.apache.kafka.common.utils.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Mirror.MirrorMakerConfig"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="Org.Apache.Kafka.Common.Utils.Time"/></param>
        public MirrorMaker(Org.Apache.Kafka.Connect.Mirror.MirrorMakerConfig arg0, Java.Util.List<Java.Lang.String> arg1, Org.Apache.Kafka.Common.Utils.Time arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#CONNECTOR_CLASSES"/>
        /// </summary>
        public static Java.Util.List CONNECTOR_CLASSES { get { if (!_CONNECTOR_CLASSESReady) { _CONNECTOR_CLASSESContent = SGetField<Java.Util.List>(LocalBridgeClazz, "CONNECTOR_CLASSES"); _CONNECTOR_CLASSESReady = true; } return _CONNECTOR_CLASSESContent; } }
        private static Java.Util.List _CONNECTOR_CLASSESContent = default;
        private static bool _CONNECTOR_CLASSESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#main-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public static void Main(Java.Lang.String[] arg0)
        {
            SExecuteWithSignature(LocalBridgeClazz, "main", "([Ljava/lang/String;)V", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#awaitStop--"/>
        /// </summary>
        public void AwaitStop()
        {
            IExecuteWithSignature("awaitStop", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#start--"/>
        /// </summary>
        public void Start()
        {
            IExecuteWithSignature("start", "()V");
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-mirror/3.7.0/org/apache/kafka/connect/mirror/MirrorMaker.html#stop--"/>
        /// </summary>
        public void Stop()
        {
            IExecuteWithSignature("stop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}