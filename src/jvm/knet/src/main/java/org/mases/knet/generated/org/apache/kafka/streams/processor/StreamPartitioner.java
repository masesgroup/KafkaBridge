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
*  This file is generated by MASES.JNetReflector (ver. 2.5.6.0)
*/

package org.mases.knet.generated.org.apache.kafka.streams.processor;

public final class StreamPartitioner extends org.mases.jcobridge.JCListener implements org.apache.kafka.streams.processor.StreamPartitioner {
    public StreamPartitioner(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public java.lang.Integer partition(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2, int arg3) {
        raiseEvent("partition", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (java.lang.Integer)retVal;
    }
    //@Override
    public java.util.Optional partitions(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2, int arg3) {
        raiseEvent("partitions", arg0, arg1, arg2, arg3); Object retVal = getReturnData(); return (java.util.Optional)retVal;
    }
    //@Override
    public java.util.Optional partitionsDefault(java.lang.String arg0, java.lang.Object arg1, java.lang.Object arg2, int arg3) {
        return org.apache.kafka.streams.processor.StreamPartitioner.super.partitions(arg0, arg1, arg2, arg3);
    }

}