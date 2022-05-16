/*
 *  Copyright 2022 MASES s.r.l.
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

package org.mases.knet.connect.sink;

import org.apache.kafka.common.config.ConfigDef;
import org.apache.kafka.common.config.ConfigException;
import org.apache.kafka.connect.connector.Task;
import org.apache.kafka.connect.sink.SinkConnector;
import org.apache.kafka.connect.sink.SinkConnectorContext;
import org.mases.jcobridge.*;
import org.mases.knet.connect.KNetConnectProxy;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class KNetSinkConnector extends SinkConnector {
    private static final Logger log = LoggerFactory.getLogger(KNetSinkConnector.class);

    private static final String registrationName = "KNetSinkConnector";

    Object dataToExchange = null;

    public Object getDataToExchange() {
        return dataToExchange;
    }

    public void setDataToExchange(Object dte) {
        dataToExchange = dte;
    }

    public SinkConnectorContext getContext() {
        return context();
    }

    @Override
    public void start(Map<String, String> props) {
        try {
            if (!KNetConnectProxy.initializeSinkConnector(props)) {
                log.error("Failed Invoke of \"initializeSinkConnector\"");
                throw new ConfigException("Failed Invoke of \"initializeSinkConnector\"");
            } else {
                JCOBridge.RegisterJVMGlobal(registrationName, this);
                try {
                    dataToExchange = props;
                    JCObject sink = KNetConnectProxy.getSinkConnector();
                    if (sink == null) throw new ConfigException("getSinkConnector returned null.");
                    sink.Invoke("StartInternal");
                } finally {
                    dataToExchange = null;
                }
            }
        } catch (JCException | IOException jcne) {
            log.error("Failed Invoke of \"start\"", jcne);
        }
    }

    @Override
    public Class<? extends Task> taskClass() {
        return KNetSinkTask.class;
    }

    @Override
    public List<Map<String, String>> taskConfigs(int maxTasks) {
        ArrayList<Map<String, String>> configs = new ArrayList<>();
        for (int i = 0; i < maxTasks; i++) {
            Map<String, String> config = new HashMap<>();
            try {
                dataToExchange = config;
                JCObject sink = KNetConnectProxy.getSinkConnector();
                if (sink == null) throw new ConfigException("getSinkConnector returned null.");
                sink.Invoke("TaskConfigsInternal", i);
            } catch (JCException | IOException jcne) {
                log.error("Failed Invoke of \"start\"", jcne);
            } finally {
                dataToExchange = null;
            }
            configs.add(config);
        }
        return configs;
    }

    @Override
    public void stop() {
        try {
            try {
                JCObject sink = KNetConnectProxy.getSinkConnector();
                if (sink == null) throw new ConfigException("getSinkConnector returned null.");
                sink.Invoke("StopInternal");
            } finally {
                JCOBridge.UnregisterJVMGlobal(registrationName);
            }
        } catch (JCException | IOException jcne) {
            log.error("Failed Invoke of \"stop\"", jcne);
        }
    }

    @Override
    public ConfigDef config() {
        return KNetConnectProxy.CONFIG_DEF;
    }

    @Override
    public String version() {
        try {
            JCObject sink = KNetConnectProxy.getSinkConnector();
            if (sink != null) {
                return (String) sink.Invoke("VersionInternal");
            }
        } catch (JCException | IOException jcne) {
            log.error("Failed Invoke of \"version\"", jcne);
        }
        return "NOT AVAILABLE";
    }
}
