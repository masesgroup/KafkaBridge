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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*/

package org.mases.knet.generated.org.apache.kafka.common.serialization;

public final class Serializer extends org.mases.jcobridge.JCListener implements org.apache.kafka.common.serialization.Serializer {
    public Serializer(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public byte[] serialize(java.lang.String arg0, java.lang.Object arg1) {
        raiseEvent("serialize", arg0, arg1); Object retVal = getReturnData(); return (byte[])retVal;
    }
    //@Override
    public byte[] serialize(java.lang.String arg0, org.apache.kafka.common.header.Headers arg1, java.lang.Object arg2) {
        raiseEvent("serialize3", arg0, arg1, arg2); Object retVal = getReturnData(); return (byte[])retVal;
    }
    //@Override
    public void close() {
        raiseEvent("close");
    }
    //@Override
    public void configure(java.util.Map arg0, boolean arg1) {
        raiseEvent("configure", arg0, arg1);
    }

}