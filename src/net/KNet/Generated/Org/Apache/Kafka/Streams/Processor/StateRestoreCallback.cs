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
*  This file is generated by MASES.JNetReflector (ver. 2.5.5.0)
*  using kafka-streams-3.7.1.jar as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Org.Apache.Kafka.Streams.Processor
{
    #region IStateRestoreCallback
    /// <summary>
    /// .NET interface for org.mases.knet.generated.org.apache.kafka.streams.processor.StateRestoreCallback implementing <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateRestoreCallback.html"/>
    /// </summary>
    public partial interface IStateRestoreCallback
    {
        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateRestoreCallback
    public partial class StateRestoreCallback : Org.Apache.Kafka.Streams.Processor.IStateRestoreCallback
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
        /// Handlers initializer for <see cref="StateRestoreCallback"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("restore", new global::System.EventHandler<CLRListenerEventArgs<CLREventData<byte[]>>>(RestoreEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <remarks>If <see cref="OnRestore"/> has a value it takes precedence over corresponding class method</remarks>
        public global::System.Action<byte[], byte[]> OnRestore { get; set; } = null;

        void RestoreEventHandler(object sender, CLRListenerEventArgs<CLREventData<byte[]>> data)
        {
            var methodToExecute = (OnRestore != null) ? OnRestore : Restore;
            methodToExecute.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<byte[]>(0));
        }

        /// <summary>
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public virtual void Restore(byte[] arg0, byte[] arg1)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StateRestoreCallbackDirect
    public partial class StateRestoreCallbackDirect : Org.Apache.Kafka.Streams.Processor.IStateRestoreCallback
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
        /// <see href="https://www.javadoc.io/doc/org.apache.kafka/kafka-streams/3.7.1/org/apache/kafka/streams/processor/StateRestoreCallback.html#restore-byte[]-byte[]-"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public override void Restore(byte[] arg0, byte[] arg1)
        {
            IExecute("restore", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}