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
*  This file is generated by MASES.JNetReflector (ver. 2.5.9.0)
*/

package org.mases.knet.generated.org.apache.kafka.common.metrics;

public final class MetricsReporter implements org.mases.jcobridge.IJCListener, org.apache.kafka.common.metrics.MetricsReporter {
    final org.mases.jcobridge.JCListener _internalListener;

    public MetricsReporter(String key) throws org.mases.jcobridge.JCNativeException {
        super();
        _internalListener = new org.mases.jcobridge.JCListener(key);
    }

    public synchronized void release() {
       _internalListener.release();
    }
    
    public synchronized void raiseEvent(String eventName) {
       _internalListener.raiseEvent(eventName);
    }
    
    public synchronized void raiseEvent(String eventName, Object e) {
       _internalListener.raiseEvent(eventName, e);
    }
    
    public synchronized void raiseEvent(String eventName, Object e, Object... objects) {
       _internalListener.raiseEvent(eventName, e, objects);
    }
    
    public Object getEventData() {
       return _internalListener.getEventData();
    }
    
    public boolean hasExtraData() {
       return _internalListener.hasExtraData();
    }
    
    public int extraDataLength() {
       return _internalListener.extraDataLength();
    }
    
    public Object[] extraData() {
       return _internalListener.extraData();
    }
    
    public Object getReturnData() {
       return _internalListener.getReturnData();
    }
    
    public void setReturnData(Object retData) {
       _internalListener.setReturnData(retData);
    }

    //@Override
    public void configure(java.util.Map arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("configure", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void close() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("close", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void init(java.util.List arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("init", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void metricChange(org.apache.kafka.common.metrics.KafkaMetric arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("metricChange", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void metricRemoval(org.apache.kafka.common.metrics.KafkaMetric arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("metricRemoval", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public java.util.Set reconfigurableConfigs() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("reconfigurableConfigs", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = org.apache.kafka.common.metrics.MetricsReporter.super.reconfigurableConfigs(); else retVal = eventDataExchange.getReturnData(); return (java.util.Set)retVal;
    }
    //@Override
    public java.util.Set reconfigurableConfigsDefault() {
        return org.apache.kafka.common.metrics.MetricsReporter.super.reconfigurableConfigs();
    }
    //@Override
    public void contextChange(org.apache.kafka.common.metrics.MetricsContext arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("contextChange", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) org.apache.kafka.common.metrics.MetricsReporter.super.contextChange(arg0);
    }
    //@Override
    public void contextChangeDefault(org.apache.kafka.common.metrics.MetricsContext arg0) {
        org.apache.kafka.common.metrics.MetricsReporter.super.contextChange(arg0);
    }
    //@Override
    public void reconfigure(java.util.Map arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("reconfigure", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) org.apache.kafka.common.metrics.MetricsReporter.super.reconfigure(arg0);
    }
    //@Override
    public void reconfigureDefault(java.util.Map arg0) {
        org.apache.kafka.common.metrics.MetricsReporter.super.reconfigure(arg0);
    }
    //@Override
    public void validateReconfiguration(java.util.Map arg0) throws org.apache.kafka.common.config.ConfigException {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("validateReconfiguration", eventDataExchange, arg0); if (!eventDataExchange.getHasOverride()) org.apache.kafka.common.metrics.MetricsReporter.super.validateReconfiguration(arg0);
    }
    //@Override
    public void validateReconfigurationDefault(java.util.Map arg0) throws org.apache.kafka.common.config.ConfigException {
        org.apache.kafka.common.metrics.MetricsReporter.super.validateReconfiguration(arg0);
    }

}