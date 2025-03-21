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

package org.mases.knet.developed.streams.processor.api;

import org.apache.kafka.streams.state.StoreBuilder;

import java.util.Set;

public final class ProcessorSupplier extends org.mases.jcobridge.JCListener implements org.apache.kafka.streams.processor.api.ProcessorSupplier {
    public ProcessorSupplier(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    public Set<StoreBuilder<?>> storesDefault() {
        return org.apache.kafka.streams.processor.api.ProcessorSupplier.super.stores();
    }

    @Override
    public Set<StoreBuilder<?>> stores() {
        raiseEvent("stores");
        Object retVal = getReturnData();
        return (Set<StoreBuilder<?>>) retVal;
    }

    @Override
    public org.apache.kafka.streams.processor.api.Processor get() {
        raiseEvent("get");
        Object retVal = getReturnData();
        return (org.apache.kafka.streams.processor.api.Processor) retVal;
    }
}