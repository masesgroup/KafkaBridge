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

// Copied from original Apache Kafka source file ConnectDistributed.java

package org.mases.knet.developed.connect.cli;

import org.apache.kafka.common.utils.Exit;
import org.apache.kafka.common.utils.Time;
import org.apache.kafka.common.utils.Utils;
import org.apache.kafka.connect.connector.policy.ConnectorClientConfigOverridePolicy;
import org.apache.kafka.connect.json.JsonConverter;
import org.apache.kafka.connect.json.JsonConverterConfig;
import org.apache.kafka.connect.runtime.*;
import org.apache.kafka.connect.runtime.distributed.DistributedConfig;
import org.apache.kafka.connect.runtime.distributed.DistributedHerder;
import org.apache.kafka.connect.runtime.isolation.Plugins;
import org.apache.kafka.connect.runtime.rest.RestClient;
import org.apache.kafka.connect.runtime.rest.RestServer;
import org.apache.kafka.connect.storage.*;
import org.apache.kafka.connect.util.ConnectUtils;
import org.apache.kafka.connect.util.SharedTopicAdmin;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import java.util.Arrays;
import java.util.Collections;
import java.util.HashMap;
import java.util.Map;

import static org.apache.kafka.clients.CommonClientConfigs.CLIENT_ID_CONFIG;

/**
 * <p>
 * Command line utility that runs Kafka Connect in distributed mode. In this mode, the process joints a group of other workers
 * and work is distributed among them. This is useful for running Connect as a service, where connectors can be
 * submitted to the cluster to be automatically executed in a scalable, distributed fashion. This also allows you to
 * easily scale out horizontally, elastically adding or removing capacity simply by starting or stopping worker
 * instances.
 * </p>
 */
public class ConnectDistributed extends AbstractConnectCli<DistributedHerder, DistributedConfig> {
    private static final Logger log = LoggerFactory.getLogger(ConnectDistributed.class);

    public ConnectDistributed(String... args) {
        super(args);
    }

    @Override
    protected DistributedHerder createHerder(DistributedConfig config, String workerId, Plugins plugins, ConnectorClientConfigOverridePolicy connectorClientConfigOverridePolicy, RestServer restServer, RestClient restClient) {

        String kafkaClusterId = config.kafkaClusterId();
        String clientIdBase = ConnectUtils.clientIdBase(config);
        // Create the admin client to be shared by all backing stores.
        Map<String, Object> adminProps = new HashMap<>(config.originals());
        ConnectUtils.addMetricsContextProperties(adminProps, config, kafkaClusterId);
        adminProps.put(CLIENT_ID_CONFIG, clientIdBase + "shared-admin");
        SharedTopicAdmin sharedAdmin = new SharedTopicAdmin(adminProps);

        KafkaOffsetBackingStore offsetBackingStore = new KafkaOffsetBackingStore(sharedAdmin, () -> clientIdBase,
                plugins.newInternalConverter(true, JsonConverter.class.getName(), Collections.singletonMap(JsonConverterConfig.SCHEMAS_ENABLE_CONFIG, "false")));
        offsetBackingStore.configure(config);

        Worker worker = new Worker(workerId, Time.SYSTEM, plugins, config, offsetBackingStore, connectorClientConfigOverridePolicy);
        WorkerConfigTransformer configTransformer = worker.configTransformer();

        Converter internalValueConverter = worker.getInternalValueConverter();
        StatusBackingStore statusBackingStore = new KafkaStatusBackingStore(Time.SYSTEM, internalValueConverter, sharedAdmin, clientIdBase);
        statusBackingStore.configure(config);

        ConfigBackingStore configBackingStore = new KafkaConfigBackingStore(
                internalValueConverter,
                config,
                configTransformer,
                sharedAdmin,
                clientIdBase);

        // Pass the shared admin to the distributed herder as an additional AutoCloseable object that should be closed when the
        // herder is stopped. This is easier than having to track and own the lifecycle ourselves.
        return new DistributedHerder(config, Time.SYSTEM, worker,
                kafkaClusterId, statusBackingStore, configBackingStore,
                restServer.advertisedUrl().toString(), restClient, connectorClientConfigOverridePolicy,
                Collections.emptyList(), sharedAdmin);
    }

    protected String usage() {
        return "ConnectDistributed <Env of worker.properties>";
    }

    protected void processExtraArgs(Herder herder, Connect connect, String[] extraArgs) {
        // avoids this like in Apache Kafka
    }

    protected DistributedConfig createConfig(Map<String, String> workerProps) {
        return new DistributedConfig(workerProps);
    }

    public static void main(String[] args) {
        ConnectDistributed connectDistributed = new ConnectDistributed(args);
        connectDistributed.run();
    }
}