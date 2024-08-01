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

package org.mases.knet.generated.org.apache.kafka.common.serialization;

public final class Serde extends org.mases.jcobridge.JCListener implements org.apache.kafka.common.serialization.Serde {
    public Serde(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public org.apache.kafka.common.serialization.Deserializer deserializer() {
        raiseEvent("deserializer"); Object retVal = getReturnData(); return (org.apache.kafka.common.serialization.Deserializer)retVal;
    }
    //@Override
    public org.apache.kafka.common.serialization.Serializer serializer() {
        raiseEvent("serializer"); Object retVal = getReturnData(); return (org.apache.kafka.common.serialization.Serializer)retVal;
    }
    //@Override
    public void close() {
        raiseEvent("close");
    }
    //@Override
    public void closeDefault() {
        org.apache.kafka.common.serialization.Serde.super.close();
    }
    //@Override
    public void configure(java.util.Map arg0, boolean arg1) {
        raiseEvent("configure", arg0, arg1);
    }
    //@Override
    public void configureDefault(java.util.Map arg0, boolean arg1) {
        org.apache.kafka.common.serialization.Serde.super.configure(arg0, arg1);
    }

}