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
*  This file is generated by MASES.JNetReflector (ver. 2.5.3.0)
*/

package org.mases.knet.generated.org.apache.kafka.streams.processor.api;

public final class Processor extends org.mases.jcobridge.JCListener implements org.apache.kafka.streams.processor.api.Processor {
    public Processor(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void process(org.apache.kafka.streams.processor.api.Record arg0) {
        raiseEvent("process", arg0);
    }
    //@Override
    public void close() {
        raiseEvent("close");
    }
    //@Override
    public void closeDefault() {
        org.apache.kafka.streams.processor.api.Processor.super.close();
    }
    //@Override
    public void init(org.apache.kafka.streams.processor.api.ProcessorContext arg0) {
        raiseEvent("init", arg0);
    }
    //@Override
    public void initDefault(org.apache.kafka.streams.processor.api.ProcessorContext arg0) {
        org.apache.kafka.streams.processor.api.Processor.super.init(arg0);
    }

}