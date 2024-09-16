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
*  This file is generated by MASES.JNetReflector (ver. 2.5.8.0)
*/

package org.mases.knet.generated.org.apache.kafka.streams.processor;

public final class StateRestoreListener extends org.mases.jcobridge.JCListener implements org.apache.kafka.streams.processor.StateRestoreListener {
    public StateRestoreListener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void onBatchRestored(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2, long arg3) {
        raiseEvent("onBatchRestored", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onRestoreEnd(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        raiseEvent("onRestoreEnd", arg0, arg1, arg2);
    }
    //@Override
    public void onRestoreStart(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2, long arg3) {
        raiseEvent("onRestoreStart", arg0, arg1, arg2, arg3);
    }
    //@Override
    public void onRestoreSuspended(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        raiseEvent("onRestoreSuspended", arg0, arg1, arg2);
    }
    //@Override
    public void onRestoreSuspendedDefault(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        org.apache.kafka.streams.processor.StateRestoreListener.super.onRestoreSuspended(arg0, arg1, arg2);
    }

}