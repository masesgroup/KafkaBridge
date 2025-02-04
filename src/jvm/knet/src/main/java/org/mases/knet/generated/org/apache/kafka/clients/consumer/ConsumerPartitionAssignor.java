/*
*  Copyright 2025 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.5.12.0)
*/

package org.mases.knet.generated.org.apache.kafka.clients.consumer;

public final class ConsumerPartitionAssignor implements org.mases.jcobridge.IJCListener, org.apache.kafka.clients.consumer.ConsumerPartitionAssignor {
    final org.mases.jcobridge.JCListener _internalListener;

    public ConsumerPartitionAssignor(String key) throws org.mases.jcobridge.JCNativeException {
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
    public java.lang.String name() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("name", eventDataExchange); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (java.lang.String)retVal;
    }
    //@Override
    public org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupAssignment assign(org.apache.kafka.common.Cluster arg0, org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupSubscription arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("assign", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM"); Object retVal = eventDataExchange.getReturnData(); return (org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.GroupAssignment)retVal;
    }
    //@Override
    public java.nio.ByteBuffer subscriptionUserData(java.util.Set arg0) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("subscriptionUserData", eventDataExchange, arg0); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.subscriptionUserData(arg0); else retVal = eventDataExchange.getReturnData(); return (java.nio.ByteBuffer)retVal;
    }
    //@Override
    public java.nio.ByteBuffer subscriptionUserDataDefault(java.util.Set arg0) {
        return org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.subscriptionUserData(arg0);
    }
    //@Override
    public java.util.List supportedProtocols() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("supportedProtocols", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.supportedProtocols(); else retVal = eventDataExchange.getReturnData(); return (java.util.List)retVal;
    }
    //@Override
    public java.util.List supportedProtocolsDefault() {
        return org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.supportedProtocols();
    }
    //@Override
    public short version() {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("version", eventDataExchange); Object retVal; if (!eventDataExchange.getHasOverride()) retVal = org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.version(); else retVal = eventDataExchange.getReturnData(); return (short)retVal;
    }
    //@Override
    public short versionDefault() {
        return org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.version();
    }
    //@Override
    public void onAssignment(org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment arg0, org.apache.kafka.clients.consumer.ConsumerGroupMetadata arg1) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onAssignment", eventDataExchange, arg0, arg1); if (!eventDataExchange.getHasOverride()) org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.onAssignment(arg0, arg1);
    }
    //@Override
    public void onAssignmentDefault(org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.Assignment arg0, org.apache.kafka.clients.consumer.ConsumerGroupMetadata arg1) {
        org.apache.kafka.clients.consumer.ConsumerPartitionAssignor.super.onAssignment(arg0, arg1);
    }

}