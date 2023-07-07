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
*  using kafka-clients-3.5.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Security.Authenticator
{
    #region CredentialCache
    public partial class CredentialCache
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.html#cache-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="C"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/></returns>
        public Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C> CacheMethod<C>(string arg0, Java.Lang.Class arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C>>("cache", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.html#createCache-java.lang.String-java.lang.Class-"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="C"></typeparam>
        /// <returns><see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/></returns>
        public Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C> CreateCache<C>(string arg0, Java.Lang.Class arg1)
        {
            return IExecute<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C>>("createCache", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region Cache
        public partial class Cache
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#org.apache.kafka.common.security.authenticator.CredentialCache$Cache(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Cache(Java.Lang.Class arg0)
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
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#get-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="object"/></returns>
            public object Get(string arg0)
            {
                return IExecute("get", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#put-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object Put(string arg0, object arg1)
            {
                return IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#remove-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="object"/></returns>
            public object Remove(string arg0)
            {
                return IExecute("remove", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#credentialClass--"/>
            /// </summary>

            /// <returns><see cref="Java.Lang.Class"/></returns>
            public Java.Lang.Class CredentialClass()
            {
                return IExecute<Java.Lang.Class>("credentialClass");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Cache<C>
        public partial class Cache<C>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#org.apache.kafka.common.security.authenticator.CredentialCache$Cache(java.lang.Class)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
            public Cache(Java.Lang.Class arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache{C}"/> to <see cref="Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache"/>
            /// </summary>
            public static implicit operator Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache(Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache<C> t) => t.Cast<Org.Apache.Kafka.Common.Security.Authenticator.CredentialCache.Cache>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#get-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><typeparamref name="C"/></returns>
            public C Get(string arg0)
            {
                return IExecute<C>("get", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#put-java.lang.String-java.lang.Object-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><typeparamref name="C"/></param>
            /// <returns><typeparamref name="C"/></returns>
            public C Put(string arg0, C arg1)
            {
                return IExecute<C>("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#remove-java.lang.String-"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><typeparamref name="C"/></returns>
            public C Remove(string arg0)
            {
                return IExecute<C>("remove", arg0);
            }
            /// <summary>
            /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.5.0/org/apache/kafka/common/security/authenticator/CredentialCache.Cache.html#credentialClass--"/>
            /// </summary>

            /// <returns><see cref="Java.Lang.Class"/></returns>
            public Java.Lang.Class CredentialClass()
            {
                return IExecute<Java.Lang.Class>("credentialClass");
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