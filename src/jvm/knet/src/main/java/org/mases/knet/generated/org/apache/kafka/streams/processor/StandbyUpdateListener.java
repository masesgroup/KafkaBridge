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
*/

package org.mases.knet.generated.org.apache.kafka.streams.processor;

public final class StandbyUpdateListener extends org.mases.jcobridge.JCListener implements org.apache.kafka.streams.processor.StandbyUpdateListener {
    public StandbyUpdateListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onBatchLoaded(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, org.apache.kafka.streams.processor.TaskId arg2, long arg3, long arg4, long arg5) {
        raiseEvent("onBatchLoaded", arg0, arg1, arg2, arg3, arg4, arg5);
    }
    //@Override
    public void onUpdateStart(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        raiseEvent("onUpdateStart", arg0, arg1, arg2);
    }
    //@Override
    public void onUpdateSuspended(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2, long arg3, org.apache.kafka.streams.processor.StandbyUpdateListener.SuspendReason arg4) {
        raiseEvent("onUpdateSuspended", arg0, arg1, arg2, arg3, arg4);
    }

}