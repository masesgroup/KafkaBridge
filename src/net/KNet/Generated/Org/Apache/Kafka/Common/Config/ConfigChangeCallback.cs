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
*  using kafka-clients-3.6.2.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Common.Config
{
    #region IConfigChangeCallback
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.common.config.ConfigChangeCallback implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/ConfigChangeCallback.html"/>
    /// </summary>
    public partial interface IConfigChangeCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConfigChangeCallback
    public partial class ConfigChangeCallback : Org.Apache.Kafka.Common.Config.IConfigChangeCallback
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
        /// Handlers initializer for <see cref="ConfigChangeCallback"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("onChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Lang.String>>>(OnChangeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/ConfigChangeCallback.html#onChange-java.lang.String-org.apache.kafka.common.config.ConfigData-"/>
        /// </summary>
        /// <remarks>If <see cref="OnOnChange"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Lang.String, Org.Apache.Kafka.Common.Config.ConfigData> OnOnChange { get; set; } = null;

        void OnChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Lang.String>> data)
        {
            var methodToExecute = (OnOnChange != null) ? OnOnChange : OnChange;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<Org.Apache.Kafka.Common.Config.ConfigData>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-clients/3.6.2/org/apache/kafka/common/config/ConfigChangeCallback.html#onChange-java.lang.String-org.apache.kafka.common.config.ConfigData-"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Org.Apache.Kafka.Common.Config.ConfigData"/></param>
        public virtual void OnChange(Java.Lang.String arg0, Org.Apache.Kafka.Common.Config.ConfigData arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}