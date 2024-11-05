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
*  This file is generated by MASES.JNetReflector (ver. 2.5.10.0)
*/

package org.mases.knet.generated.org.apache.kafka.streams.processor;

public final class StateRestoreListener implements org.mases.jcobridge.IJCListener, org.apache.kafka.streams.processor.StateRestoreListener {
    final org.mases.jcobridge.JCListener _internalListener;

    public StateRestoreListener(String key) throws org.mases.jcobridge.JCNativeException {
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
    public void onBatchRestored(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2, long arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onBatchRestored", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onRestoreEnd(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRestoreEnd", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onRestoreStart(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2, long arg3) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRestoreStart", eventDataExchange, arg0, arg1, arg2, arg3); if (!eventDataExchange.getHasOverride()) throw new UnsupportedOperationException("The method shall be implemented in .NET side since does not have a default implementation within the JVM");
    }
    //@Override
    public void onRestoreSuspended(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        org.mases.jnet.developed.JNetEventResult eventDataExchange = new org.mases.jnet.developed.JNetEventResult();
        raiseEvent("onRestoreSuspended", eventDataExchange, arg0, arg1, arg2); if (!eventDataExchange.getHasOverride()) org.apache.kafka.streams.processor.StateRestoreListener.super.onRestoreSuspended(arg0, arg1, arg2);
    }
    //@Override
    public void onRestoreSuspendedDefault(org.apache.kafka.common.TopicPartition arg0, java.lang.String arg1, long arg2) {
        org.apache.kafka.streams.processor.StateRestoreListener.super.onRestoreSuspended(arg0, arg1, arg2);
    }

}