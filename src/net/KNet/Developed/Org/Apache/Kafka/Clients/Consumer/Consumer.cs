﻿/*
*  Copyright 2023 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;
using Org.Apache.Kafka.Common;
using Java.Time;
using Java.Util;
using Java.Util.Regex;

namespace Org.Apache.Kafka.Clients.Consumer
{
    public partial interface IConsumer: IJVMBridgeBase, System.IDisposable
    {
        Set<TopicPartition> Assignment();

        Set<string> Subscription();
        
        Set<TopicPartition> Paused();

        Map<MetricName, T> Metrics<T>() where T : Metric;

        void Subscribe(Collection<string> topics);

        void Subscribe(Collection<string> topics, ConsumerRebalanceListener listener);

        void Assign(Collection<TopicPartition> partitions);

        void Subscribe(Pattern pattern, ConsumerRebalanceListener listener);

        void Subscribe(Pattern pattern);

        void Unsubscribe();

        void CommitSync();

        void CommitSync(Duration timeout);

        void CommitSync(Map<TopicPartition, OffsetAndMetadata> offsets);

        void CommitSync(Map<TopicPartition, OffsetAndMetadata> offsets, Duration timeout);

        void CommitAsync();

        void CommitAsync(OffsetCommitCallback callback);

        void CommitAsync(Map<TopicPartition, OffsetAndMetadata> offsets, OffsetCommitCallback callback);

        void Seek(TopicPartition partition, long offset);

        void Seek(TopicPartition partition, OffsetAndMetadata offsetAndMetadata);

        void SeekToBeginning(Collection<TopicPartition> partitions);

        void SeekToEnd(Collection<TopicPartition> partitions);

        long Position(TopicPartition partition);

        long Position(TopicPartition partition, Duration timeout);

        Map<TopicPartition, OffsetAndMetadata> Committed(Set<TopicPartition> partitions);

        Map<TopicPartition, OffsetAndMetadata> Committed(Set<TopicPartition> partitions, Duration timeout);

        List<PartitionInfo> PartitionsFor(string topic);

        List<PartitionInfo> PartitionsFor(string topic, Duration timeout);

        Map<string, List<PartitionInfo>> ListTopics();

        Map<string, List<PartitionInfo>> ListTopics(Duration timeout);

        void Pause(Collection<TopicPartition> partitions);

        void Resume(Collection<TopicPartition> partitions);

        Map<TopicPartition, OffsetAndTimestamp> OffsetsForTimes(Map<TopicPartition, long?> timestampsToSearch);

        Map<TopicPartition, OffsetAndTimestamp> OffsetsForTimes(Map<TopicPartition, long?> timestampsToSearch, Duration timeout);

        Map<TopicPartition, long?> BeginningOffsets(Collection<TopicPartition> partitions);

        Map<TopicPartition, long?> BeginningOffsets(Collection<TopicPartition> partitions, Duration timeout);

        Map<TopicPartition, long?> EndOffsets(Collection<TopicPartition> partitions);

        Map<TopicPartition, long?> EndOffsets(Collection<TopicPartition> partitions, Duration timeout);

        OptionalLong CurrentLag(TopicPartition topicPartition);

        ConsumerGroupMetadata GroupMetadata();

        void EnforceRebalance();

        void EnforceRebalance(string reason);

        void Wakeup();
    }

    public partial interface IConsumer<K, V> : IConsumer
    {
        ConsumerRecords<K, V> Poll(Duration timeout);
    }
}
