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
*  This file is generated by MASES.JNetReflector (ver. 2.5.4.0)
*/

package org.mases.knet.generated.org.apache.kafka.raft;

public final class RaftClient_Listener extends org.mases.jcobridge.JCListener implements org.apache.kafka.raft.RaftClient.Listener {
    public RaftClient_Listener(String key) throws org.mases.jcobridge.JCNativeException {
        super(key);
    }

    //@Override
    public void handleCommit(org.apache.kafka.raft.BatchReader arg0) {
        raiseEvent("handleCommit", arg0);
    }
    //@Override
    public void handleLoadSnapshot(org.apache.kafka.snapshot.SnapshotReader arg0) {
        raiseEvent("handleLoadSnapshot", arg0);
    }
    //@Override
    public void beginShutdown() {
        raiseEvent("beginShutdown");
    }
    //@Override
    public void beginShutdownDefault() {
        org.apache.kafka.raft.RaftClient.Listener.super.beginShutdown();
    }
    //@Override
    public void handleLeaderChange(org.apache.kafka.raft.LeaderAndEpoch arg0) {
        raiseEvent("handleLeaderChange", arg0);
    }
    //@Override
    public void handleLeaderChangeDefault(org.apache.kafka.raft.LeaderAndEpoch arg0) {
        org.apache.kafka.raft.RaftClient.Listener.super.handleLeaderChange(arg0);
    }

}