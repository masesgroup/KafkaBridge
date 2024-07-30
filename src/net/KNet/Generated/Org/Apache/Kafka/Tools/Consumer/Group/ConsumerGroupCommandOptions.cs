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
*  This file is generated by MASES.JNetReflector (ver. 2.5.7.0)
*  using kafka-tools-3.8.0.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Tools.Consumer.Group
{
    #region ConsumerGroupCommandOptions
    public partial class ConsumerGroupCommandOptions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-tools/3.8.0/org/apache/kafka/tools/consumer/group/ConsumerGroupCommandOptions.html#fromArgs-java.lang.String[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Org.Apache.Kafka.Tools.Consumer.Group.ConsumerGroupCommandOptions"/></returns>
        public static Org.Apache.Kafka.Tools.Consumer.Group.ConsumerGroupCommandOptions FromArgs(Java.Lang.String[] arg0)
        {
            return SExecuteWithSignature<Org.Apache.Kafka.Tools.Consumer.Group.ConsumerGroupCommandOptions>(LocalBridgeClazz, "fromArgs", "([Ljava/lang/String;)Lorg/apache/kafka/tools/consumer/group/ConsumerGroupCommandOptions;", new object[] { arg0 });
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