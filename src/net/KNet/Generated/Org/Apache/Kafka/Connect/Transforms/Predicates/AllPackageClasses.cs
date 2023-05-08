/*
*  Copyright 2023 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using connect-transforms-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace Org.Apache.Kafka.Connect.Transforms.Predicates
{
    #region HasHeaderKey
    /// <summary>
    /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/HasHeaderKey.html"/>
    /// </summary>
    public partial class HasHeaderKey : MASES.JCOBridge.C2JBridge.JVMBridgeBase<HasHeaderKey>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HasHeaderKey() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HasHeaderKey(params object[] args) : base(args) { }

        private static IJavaType LocalBridgeClazz = ClazzOf("org.apache.kafka.connect.transforms.predicates.HasHeaderKey");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.transforms.predicates.HasHeaderKey";
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

    #region HasHeaderKey<R>
    /// <summary>
    /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/HasHeaderKey.html"/>
    /// </summary>
    /// <typeparam name="R"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/></typeparam>
    public partial class HasHeaderKey<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<HasHeaderKey<R>> where R: Org.Apache.Kafka.Connect.Connector.ConnectRecord<R>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public HasHeaderKey() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public HasHeaderKey(params object[] args) : base(args) { }

        private static IJavaType LocalBridgeClazz = ClazzOf("org.apache.kafka.connect.transforms.predicates.HasHeaderKey");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.transforms.predicates.HasHeaderKey";
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

    #region RecordIsTombstone
    /// <summary>
    /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/RecordIsTombstone.html"/>
    /// </summary>
    public partial class RecordIsTombstone : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RecordIsTombstone>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RecordIsTombstone() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RecordIsTombstone(params object[] args) : base(args) { }

        private static IJavaType LocalBridgeClazz = ClazzOf("org.apache.kafka.connect.transforms.predicates.RecordIsTombstone");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.transforms.predicates.RecordIsTombstone";
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

    #region RecordIsTombstone<R>
    /// <summary>
    /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/RecordIsTombstone.html"/>
    /// </summary>
    /// <typeparam name="R"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/></typeparam>
    public partial class RecordIsTombstone<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<RecordIsTombstone<R>> where R: Org.Apache.Kafka.Connect.Connector.ConnectRecord<R>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public RecordIsTombstone() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public RecordIsTombstone(params object[] args) : base(args) { }

        private static IJavaType LocalBridgeClazz = ClazzOf("org.apache.kafka.connect.transforms.predicates.RecordIsTombstone");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.transforms.predicates.RecordIsTombstone";
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

    #region TopicNameMatches
    /// <summary>
    /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html"/>
    /// </summary>
    public partial class TopicNameMatches : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TopicNameMatches>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TopicNameMatches() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TopicNameMatches(params object[] args) : base(args) { }

        private static IJavaType LocalBridgeClazz = ClazzOf("org.apache.kafka.connect.transforms.predicates.TopicNameMatches");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.transforms.predicates.TopicNameMatches";
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

    #region TopicNameMatches<R>
    /// <summary>
    /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-transforms/3.4.0/org/apache/kafka/connect/transforms/predicates/TopicNameMatches.html"/>
    /// </summary>
    /// <typeparam name="R"><see cref="Org.Apache.Kafka.Connect.Connector.ConnectRecord{R}"/></typeparam>
    public partial class TopicNameMatches<R> : MASES.JCOBridge.C2JBridge.JVMBridgeBase<TopicNameMatches<R>> where R: Org.Apache.Kafka.Connect.Connector.ConnectRecord<R>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public TopicNameMatches() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public TopicNameMatches(params object[] args) : base(args) { }

        private static IJavaType LocalBridgeClazz = ClazzOf("org.apache.kafka.connect.transforms.predicates.TopicNameMatches");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.transforms.predicates.TopicNameMatches";
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