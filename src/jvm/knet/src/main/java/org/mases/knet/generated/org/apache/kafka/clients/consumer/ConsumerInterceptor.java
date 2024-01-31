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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*/

package org.mases.knet.generated.org.apache.kafka.clients.consumer;

public final class ConsumerInterceptor extends org.mases.jcobridge.JCListener implements org.apache.kafka.clients.consumer.ConsumerInterceptor {
    public ConsumerInterceptor(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public org.apache.kafka.clients.consumer.ConsumerRecords onConsume(org.apache.kafka.clients.consumer.ConsumerRecords arg0) {
        raiseEvent("onConsume", arg0); Object retVal = getReturnData(); return (org.apache.kafka.clients.consumer.ConsumerRecords)retVal;
    }
    //@Override
    public void close() {
        raiseEvent("close");
    }
    //@Override
    public void onCommit(java.util.Map arg0) {
        raiseEvent("onCommit", arg0);
    }
    //@Override
    public void configure(java.util.Map arg0) {
        raiseEvent("configure", arg0);
    }

}