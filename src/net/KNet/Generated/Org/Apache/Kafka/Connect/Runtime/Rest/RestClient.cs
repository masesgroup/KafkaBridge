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
*  using connect-runtime-3.4.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Connect.Runtime.Rest
{
    #region RestClient
    public partial class RestClient
    {
        #region Constructors
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.html#%3Cinit%3E(org.apache.kafka.connect.runtime.WorkerConfig)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Org.Apache.Kafka.Connect.Runtime.WorkerConfig"/></param>
        public RestClient(Org.Apache.Kafka.Connect.Runtime.WorkerConfig arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.html#httpRequest(java.lang.String,java.lang.String,javax.ws.rs.core.HttpHeaders,java.lang.Object,com.fasterxml.jackson.core.type.TypeReference,javax.crypto.SecretKey,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Ws.Rs.Core.HttpHeaders"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Com.Fasterxml.Jackson.Core.Type.TypeReference"/></param>
        /// <param name="arg5"><see cref="Javax.Crypto.SecretKey"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse"/></returns>
        public Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse<T> HttpRequest<T>(string arg0, string arg1, Javax.Ws.Rs.Core.HttpHeaders arg2, object arg3, Com.Fasterxml.Jackson.Core.Type.TypeReference<T> arg4, Javax.Crypto.SecretKey arg5, string arg6)
        {
            return IExecute<Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse<T>>("httpRequest", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.html#httpRequest(java.lang.String,java.lang.String,javax.ws.rs.core.HttpHeaders,java.lang.Object,com.fasterxml.jackson.core.type.TypeReference)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Ws.Rs.Core.HttpHeaders"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="Com.Fasterxml.Jackson.Core.Type.TypeReference"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse"/></returns>
        public Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse<T> HttpRequest<T>(string arg0, string arg1, Javax.Ws.Rs.Core.HttpHeaders arg2, object arg3, Com.Fasterxml.Jackson.Core.Type.TypeReference<T> arg4)
        {
            return IExecute<Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse<T>>("httpRequest", arg0, arg1, arg2, arg3, arg4);
        }

        #endregion

        #region Nested classes
        #region HttpResponse
        public partial class HttpResponse
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#%3Cinit%3E(int,java.util.Map,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Util.Map"/></param>
            /// <param name="arg2"><see cref="object"/></param>
            public HttpResponse(int arg0, Java.Util.Map arg1, object arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#body()"/> 
            /// </summary>
            public object Body
            {
                get { return IExecute("body"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#headers()"/> 
            /// </summary>
            public Java.Util.Map Headers
            {
                get { return IExecute<Java.Util.Map>("headers"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#status()"/> 
            /// </summary>
            public int Status
            {
                get { return IExecute<int>("status"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region HttpResponse<T>
        public partial class HttpResponse<T>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#%3Cinit%3E(int,java.util.Map,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Java.Util.Map"/></param>
            /// <param name="arg2"><typeparamref name="T"/></param>
            public HttpResponse(int arg0, Java.Util.Map<string, string> arg1, T arg2)
                : base(arg0, arg1, arg2)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse{T}"/> to <see cref="Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse(Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse<T> t) => t.Cast<Org.Apache.Kafka.Connect.Runtime.Rest.RestClient.HttpResponse>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#body()"/> 
            /// </summary>
            public T Body
            {
                get { return IExecute<T>("body"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#headers()"/> 
            /// </summary>
            public Java.Util.Map<string, string> Headers
            {
                get { return IExecute<Java.Util.Map<string, string>>("headers"); }
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/static/org.apache.kafka/connect-runtime/3.4.0/org/apache/kafka/connect/runtime/rest/RestClient.HttpResponse.html#status()"/> 
            /// </summary>
            public int Status
            {
                get { return IExecute<int>("status"); }
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