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
*/

package org.mases.knet.generated.org.apache.kafka.common.metrics;

public final class MetricsReporter extends org.mases.jcobridge.JCListener implements org.apache.kafka.common.metrics.MetricsReporter {
    public MetricsReporter(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void configure(java.util.Map arg0) {
        raiseEvent("configure", arg0);
    }
    //@Override
    public void close() {
        raiseEvent("close");
    }
    //@Override
    public void init(java.util.List arg0) {
        raiseEvent("init", arg0);
    }
    //@Override
    public void metricChange(org.apache.kafka.common.metrics.KafkaMetric arg0) {
        raiseEvent("metricChange", arg0);
    }
    //@Override
    public void metricRemoval(org.apache.kafka.common.metrics.KafkaMetric arg0) {
        raiseEvent("metricRemoval", arg0);
    }
    //@Override
    public java.util.Set reconfigurableConfigs() {
        raiseEvent("reconfigurableConfigs"); Object retVal = getReturnData(); return (java.util.Set)retVal;
    }
    //@Override
    public java.util.Set reconfigurableConfigsDefault() {
        return org.apache.kafka.common.metrics.MetricsReporter.super.reconfigurableConfigs();
    }
    //@Override
    public void contextChange(org.apache.kafka.common.metrics.MetricsContext arg0) {
        raiseEvent("contextChange", arg0);
    }
    //@Override
    public void contextChangeDefault(org.apache.kafka.common.metrics.MetricsContext arg0) {
        org.apache.kafka.common.metrics.MetricsReporter.super.contextChange(arg0);
    }
    //@Override
    public void reconfigure(java.util.Map arg0) {
        raiseEvent("reconfigure", arg0);
    }
    //@Override
    public void reconfigureDefault(java.util.Map arg0) {
        org.apache.kafka.common.metrics.MetricsReporter.super.reconfigure(arg0);
    }
    //@Override
    public void validateReconfiguration(java.util.Map arg0) {
        raiseEvent("validateReconfiguration", arg0);
    }
    //@Override
    public void validateReconfigurationDefault(java.util.Map arg0) {
        org.apache.kafka.common.metrics.MetricsReporter.super.validateReconfiguration(arg0);
    }

}