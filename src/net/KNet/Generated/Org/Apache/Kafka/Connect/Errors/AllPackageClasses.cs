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
*  This file is generated by MASES.JNetReflector (ver. 2.0.0.0)
*  using connect-api-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace Org.Apache.Kafka.Connect.Errors
{
    #region AlreadyExistsException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/AlreadyExistsException.html"/>
    /// </summary>
    public partial class AlreadyExistsException : Org.Apache.Kafka.Connect.Errors.ConnectException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.AlreadyExistsException";

        // TODO: complete the class

    }
    #endregion

    #region ConnectException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/ConnectException.html"/>
    /// </summary>
    public partial class ConnectException : Org.Apache.Kafka.Common.KafkaException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.ConnectException";

        // TODO: complete the class

    }
    #endregion

    #region DataException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/DataException.html"/>
    /// </summary>
    public partial class DataException : Org.Apache.Kafka.Connect.Errors.ConnectException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.DataException";

        // TODO: complete the class

    }
    #endregion

    #region IllegalWorkerStateException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/IllegalWorkerStateException.html"/>
    /// </summary>
    public partial class IllegalWorkerStateException : Org.Apache.Kafka.Connect.Errors.ConnectException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.IllegalWorkerStateException";

        // TODO: complete the class

    }
    #endregion

    #region NotFoundException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/NotFoundException.html"/>
    /// </summary>
    public partial class NotFoundException : Org.Apache.Kafka.Connect.Errors.ConnectException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.NotFoundException";

        // TODO: complete the class

    }
    #endregion

    #region RetriableException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/RetriableException.html"/>
    /// </summary>
    public partial class RetriableException : Org.Apache.Kafka.Connect.Errors.ConnectException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.RetriableException";

        // TODO: complete the class

    }
    #endregion

    #region SchemaBuilderException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/SchemaBuilderException.html"/>
    /// </summary>
    public partial class SchemaBuilderException : Org.Apache.Kafka.Connect.Errors.DataException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.SchemaBuilderException";

        // TODO: complete the class

    }
    #endregion

    #region SchemaProjectorException
    /// <summary>
    /// <see href="https://www.javadoc.io/doc/org.apache.kafka/connect-api/3.4.0/org/apache/kafka/connect/errors/SchemaProjectorException.html"/>
    /// </summary>
    public partial class SchemaProjectorException : Org.Apache.Kafka.Connect.Errors.DataException
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeException_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.errors.SchemaProjectorException";

        // TODO: complete the class

    }
    #endregion



}