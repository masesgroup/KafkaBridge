﻿/*
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

#nullable enable

using Java.Util;
using MASES.JCOBridge.C2JBridge;
using Org.Apache.Kafka.Connect.Connector;
using Org.Apache.Kafka.Connect.Data;
using Org.Apache.Kafka.Connect.Header;
using System;

namespace Org.Apache.Kafka.Connect.Source
{
    /// <summary>
    /// <see cref="SourceRecord"/> are generated by <see cref="MASES.KNet.Connect.KNetSourceTask{TTask}"/> and passed to Kafka Connect for storage in Kafka.
    /// In addition to the standard fields in <see cref="ConnectRecord{R, TKey, TValue}"/> which specify where data is stored in Kafka, they also include a sourcePartition and sourceOffset.
    /// </summary>
    public partial class SourceRecord
    {
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{String, TKeySource}"/> in <paramref name="sourcePartition"/></typeparam>
        /// <typeparam name="TOffset">The value type of source offset <see cref="Map{String, TOffset}"/> in <paramref name="sourceOffset"/></typeparam>
        /// <typeparam name="TKey?">The type of the key to be inserted in Kafka</typeparam>
        /// <typeparam name="TValue?">The type of value to be inserted in Kafka</typeparam>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <returns>A newvly allocated <see cref="SourceRecord{TKey, TOffset}"/></returns>
        /// <remarks>These values can have arbitrary structure and should be represented using Org.Apache.Kafka.Connect.Data.* objects (or primitive values). 
        /// For example, a database connector might specify the <paramref name="sourcePartition"/> as a record containing { "db": "database_name", "table": "table_name"} and the <paramref name="sourceOffset"/> as a <see langword="long"/> containing the timestamp of the row.</remarks>
        public static SourceRecord<TKeySource, TOffset, TKey?, TValue?> New<TKeySource, TOffset, TKey, TValue>(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                                                                     string topic, int? partition, Schema valueSchema, TValue? value)

        {
            return new SourceRecord<TKeySource, TOffset, TKey?, TValue?>(sourcePartition, sourceOffset, topic, partition, valueSchema, value);
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{String, TKeySource}"/> in <paramref name="sourcePartition"/></typeparam>
        /// <typeparam name="TOffset">The value type of source offset <see cref="Map{String, TOffset}"/> in <paramref name="sourceOffset"/></typeparam>
        /// <typeparam name="TKey?">The type of the key to be inserted in Kafka</typeparam>
        /// <typeparam name="TValue?">The type of value to be inserted in Kafka</typeparam>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <returns>A newvly allocated <see cref="SourceRecord{TKey, TOffset}"/></returns>
        /// <remarks>These values can have arbitrary structure and should be represented using Org.Apache.Kafka.Connect.Data.* objects (or primitive values). 
        /// For example, a database connector might specify the <paramref name="sourcePartition"/> as a record containing { "db": "database_name", "table": "table_name"} and the <paramref name="sourceOffset"/> as a <see langword="long"/> containing the timestamp of the row.</remarks>
        public static SourceRecord<TKeySource, TOffset, TKey?, TValue?> New<TKeySource, TOffset, TKey, TValue>(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                                                                     string topic, Schema valueSchema, TValue? value)

        {
            return new SourceRecord<TKeySource, TOffset, TKey?, TValue?>(sourcePartition, sourceOffset, topic, valueSchema, value);
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{String, TKeySource}"/> in <paramref name="sourcePartition"/></typeparam>
        /// <typeparam name="TOffset">The value type of source offset <see cref="Map{String, TOffset}"/> in <paramref name="sourceOffset"/></typeparam>
        /// <typeparam name="TKey?">The type of the key to be inserted in Kafka</typeparam>
        /// <typeparam name="TValue?">The type of value to be inserted in Kafka</typeparam>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <returns>A newvly allocated <see cref="SourceRecord{TKey, TOffset}"/></returns>
        /// <remarks>These values can have arbitrary structure and should be represented using Org.Apache.Kafka.Connect.Data.* objects (or primitive values). 
        /// For example, a database connector might specify the <paramref name="sourcePartition"/> as a record containing { "db": "database_name", "table": "table_name"} and the <paramref name="sourceOffset"/> as a <see langword="long"/> containing the timestamp of the row.</remarks>
        public static SourceRecord<TKeySource, TOffset, TKey?, TValue?> New<TKeySource, TOffset, TKey, TValue>(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                                                             string topic, Schema keySchema, TKey? key, Schema valueSchema, TValue? value)

        {
            return new SourceRecord<TKeySource, TOffset, TKey?, TValue?>(sourcePartition, sourceOffset, topic, keySchema, key, valueSchema, value);
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{String, TKeySource}"/> in <paramref name="sourcePartition"/></typeparam>
        /// <typeparam name="TOffset">The value type of source offset <see cref="Map{String, TOffset}"/> in <paramref name="sourceOffset"/></typeparam>
        /// <typeparam name="TKey?">The type of the key to be inserted in Kafka</typeparam>
        /// <typeparam name="TValue?">The type of value to be inserted in Kafka</typeparam>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <returns>A newvly allocated <see cref="SourceRecord{TKey, TOffset}"/></returns>
        /// <remarks>These values can have arbitrary structure and should be represented using Org.Apache.Kafka.Connect.Data.* objects (or primitive values). 
        /// For example, a database connector might specify the <paramref name="sourcePartition"/> as a record containing { "db": "database_name", "table": "table_name"} and the <paramref name="sourceOffset"/> as a <see langword="long"/> containing the timestamp of the row.</remarks>
        public static SourceRecord<TKeySource, TOffset, TKey?, TValue?> New<TKeySource, TOffset, TKey, TValue>(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                                                                     string topic, int? partition,
                                                                     Schema keySchema, TKey? key, Schema valueSchema, TValue? value)

        {
            return new SourceRecord<TKeySource, TOffset, TKey?, TValue?>(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value);
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{String, TKeySource}"/> in <paramref name="sourcePartition"/></typeparam>
        /// <typeparam name="TOffset">The value type of source offset <see cref="Map{String, TOffset}"/> in <paramref name="sourceOffset"/></typeparam>
        /// <typeparam name="TKey?">The type of the key to be inserted in Kafka</typeparam>
        /// <typeparam name="TValue?">The type of value to be inserted in Kafka</typeparam>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <param name="timestamp">The timestamp; may be null</param>
        /// <returns>A newvly allocated <see cref="SourceRecord{TKey, TOffset}"/></returns>
        /// <remarks>These values can have arbitrary structure and should be represented using Org.Apache.Kafka.Connect.Data.* objects (or primitive values). 
        /// For example, a database connector might specify the <paramref name="sourcePartition"/> as a record containing { "db": "database_name", "table": "table_name"} and the <paramref name="sourceOffset"/> as a <see langword="long"/> containing the timestamp of the row.</remarks>
        public static SourceRecord<TKeySource, TOffset, TKey?, TValue?> New<TKeySource, TOffset, TKey, TValue>(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                                                                     string topic, int? partition,
                                                                     Schema keySchema, TKey? key,
                                                                     Schema valueSchema, TValue? value,
                                                                     DateTime timestamp)

        {
            return new SourceRecord<TKeySource, TOffset, TKey?, TValue?>(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value, timestamp);
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{String, TKeySource}"/> in <paramref name="sourcePartition"/></typeparam>
        /// <typeparam name="TOffset">The value type of source offset <see cref="Map{String, TOffset}"/> in <paramref name="sourceOffset"/></typeparam>
        /// <typeparam name="TKey?">The type of the key to be inserted in Kafka</typeparam>
        /// <typeparam name="TValue?">The type of value to be inserted in Kafka</typeparam>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <param name="timestamp">The timestamp; may be null</param>
        /// <param name="headers">The <see cref="Headers"/>s; may be null or empty</param>
        /// <returns>A newvly allocated <see cref="SourceRecord{TKey, TOffset}"/></returns>
        /// <remarks>These values can have arbitrary structure and should be represented using Org.Apache.Kafka.Connect.Data.* objects (or primitive values). 
        /// For example, a database connector might specify the <paramref name="sourcePartition"/> as a record containing { "db": "database_name", "table": "table_name"} and the <paramref name="sourceOffset"/> as a <see langword="long"/> containing the timestamp of the row.</remarks>
        public static SourceRecord<TKeySource, TOffset, TKey?, TValue?> New<TKeySource, TOffset, TKey, TValue>(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                                                             string topic, int? partition,
                                                             Schema keySchema, TKey? key,
                                                             Schema valueSchema, TValue? value,
                                                             DateTime timestamp, Headers headers)

        {
            return new SourceRecord<TKeySource, TOffset, TKey?, TValue?>(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value, timestamp, headers);
        }
        /// <summary>
        /// Convert to <see cref="SourceRecord{TKey, TValue}"/>
        /// </summary>
        public SourceRecord<TKey?, TValue?> CastTo<TKey, TValue>() => this.Cast<SourceRecord<TKey?, TValue?>>();
        /// <summary>
        /// Convert to <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/>
        /// </summary>
        public SourceRecord<TKeySource, TOffset, TKey?, TValue?> CastTo<TKeySource, TOffset, TKey, TValue>() => this.Cast<SourceRecord<TKeySource, TOffset, TKey?, TValue?>>();
    }
    /// <summary>
    /// <see cref="SourceRecord{TKey, TValue}"/> are generated by <see cref="MASES.KNet.Connect.KNetSourceTask{TTask}"/> and passed to Kafka Connect for storage in Kafka.
    /// In addition to the standard fields in <see cref="ConnectRecord{R, TKey, TValue}"/> which specify where data is stored in Kafka, they also include a sourcePartition and sourceOffset.
    /// </summary>
    /// <typeparam name="TKey">The type of the key to be inserted in Kafka</typeparam>
    /// <typeparam name="TValue">The type of value to be inserted in Kafka</typeparam>
    public class SourceRecord<TKey, TValue> : SourceRecord<object, object, TKey, TValue>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.source.SourceRecord";

        /// <summary>
        /// Converts an <see cref="SourceRecord{TKey, TValue}"/> in <see cref="SourceRecord"/>
        /// </summary>
        /// <param name="source">The <see cref="SourceRecord{TKey, TValue}"/> to convert</param>
        public static implicit operator SourceRecord(SourceRecord<TKey?, TValue?> source) => source.Cast<SourceRecord>();

        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TValue}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, object> sourcePartition, Map<Java.Lang.String, object> sourceOffset,
                            string topic, int? partition, Schema valueSchema, TValue? value)
            : base(sourcePartition, sourceOffset, topic, partition, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TValue}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, object> sourcePartition, Map<Java.Lang.String, object> sourceOffset,
                            string topic, Schema valueSchema, TValue? value)
            : base(sourcePartition, sourceOffset, topic, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, object> sourcePartition, Map<Java.Lang.String, object> sourceOffset,
                            string topic, Schema keySchema, TKey? key, Schema valueSchema, TValue? value)
            : base(sourcePartition, sourceOffset, topic, keySchema, key, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TValue}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, object> sourcePartition, Map<Java.Lang.String, object> sourceOffset,
                            string topic, int? partition,
                            Schema keySchema, TKey? key, Schema valueSchema, TValue? value)
                 : base(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TValue}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <param name="timestamp">The timestamp; may be null</param>
        public SourceRecord(Map<Java.Lang.String, object> sourcePartition, Map<Java.Lang.String, object> sourceOffset,
                            string topic, int? partition,
                            Schema keySchema, TKey? key,
                            Schema valueSchema, TValue? value,
                            DateTime timestamp)
                  : base(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value, timestamp)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TValue}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <param name="timestamp">The timestamp; may be null</param>
        /// <param name="headers">The <see cref="Headers"/>s; may be null or empty</param>
        public SourceRecord(Map<Java.Lang.String, object> sourcePartition, Map<Java.Lang.String, object> sourceOffset,
                            string topic, int? partition,
                            Schema keySchema, TKey? key,
                            Schema valueSchema, TValue? value,
                            DateTime timestamp, Headers headers)
              : base(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value, timestamp, headers)
        {
        }
    }

    /// <summary>
    /// <see cref="SourceRecord{TKeySource, TOffset}"/> are generated by <see cref="MASES.KNet.Connect.KNetSourceTask{TTask}"/> and passed to Kafka Connect for storage in Kafka.
    /// In addition to the standard fields in <see cref="ConnectRecord{R, TKey, TValue}"/> which specify where data is stored in Kafka, they also include a sourcePartition and sourceOffset.
    /// </summary>
    /// <typeparam name="TKeySource">The value type of source partition <see cref="Map{K, V}"/> in the sourcePartition parameters</typeparam>
    /// <typeparam name="TOffset">The value type of source offset <see cref="Map{K, V}"/> in the sourceOffset parameters</typeparam>
    /// <typeparam name="TKey">The type of the key to be inserted in Kafka</typeparam>
    /// <typeparam name="TValue">The type of value to be inserted in Kafka</typeparam>
    public class SourceRecord<TKeySource, TOffset, TKey, TValue> : ConnectRecord<SourceRecord<TKey?, TValue?>, TKey?, TValue?>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.apache.kafka.connect.source.SourceRecord";

        /// <summary>
        /// Converts an <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/> in <see cref="SourceRecord"/>
        /// </summary>
        /// <param name="source">The <see cref="SourceRecord{TKeySource, TOffset, TKey, TValue}"/> to convert</param>
        public static implicit operator SourceRecord(SourceRecord<TKeySource, TOffset, TKey?, TValue?> source) => source.Cast<SourceRecord>();

        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                            string topic, int? partition, Schema valueSchema, TValue? value)
            : base(sourcePartition, sourceOffset, topic, partition, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                            string topic, Schema valueSchema, TValue? value)
            : base(sourcePartition, sourceOffset, topic, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                            string topic, Schema keySchema, TKey? key, Schema valueSchema, TValue? value)
            : base(sourcePartition, sourceOffset, topic, keySchema, key, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        public SourceRecord(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                            string topic, int? partition,
                            Schema keySchema, TKey? key, Schema valueSchema, TValue? value)
                 : base(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value)
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <param name="timestamp">The timestamp; may be null</param>
        public SourceRecord(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                            string topic, int? partition,
                            Schema keySchema, TKey? key,
                            Schema valueSchema, TValue? value,
                            DateTime timestamp)
                  : base(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value, new DateTimeOffset(timestamp).ToUnixTimeMilliseconds())
        {
        }
        /// <summary>
        /// Creates a new <see cref="SourceRecord{TKey, TOffset}"/>
        /// </summary>
        /// <param name="sourcePartition">The parameter represents a single input sourcePartition that the record came from (e.g. a filename, table name, or topic-partition).</param>
        /// <param name="sourceOffset">The parameter represents a position in that <paramref name="sourcePartition"/> which can be used to resume consumption of data.</param>
        /// <param name="topic">The name of the topic; may be null</param>
        /// <param name="partition">The partition number for the Kafka topic; may be null</param>
        /// <param name="keySchema">The schema for the key; may be null</param>
        /// <param name="key">The key; may be null</param>
        /// <param name="valueSchema">The schema for the value; may be null</param>
        /// <param name="value">The value; may be null</param>
        /// <param name="timestamp">The timestamp; may be null</param>
        /// <param name="headers">The <see cref="Headers"/>s; may be null or empty</param>
        public SourceRecord(Map<Java.Lang.String, TKeySource> sourcePartition, Map<Java.Lang.String, TOffset> sourceOffset,
                            string topic, int? partition,
                            Schema keySchema, TKey? key,
                            Schema valueSchema, TValue? value,
                            DateTime timestamp, Headers headers)
              : base(sourcePartition, sourceOffset, topic, partition, keySchema, key, valueSchema, value, new DateTimeOffset(timestamp).ToUnixTimeMilliseconds(), headers)
        {
        }
        /// <summary>
        /// The source partition
        /// </summary>
        public Map<Java.Lang.String, TKeySource> SourcePartition => IExecute<Map<Java.Lang.String, TKeySource>>("sourcePartition");
        /// <summary>
        /// The source offset
        /// </summary>
        public Map<Java.Lang.String, TOffset> SourceOffset => IExecute<Map<Java.Lang.String, TOffset>>("sourceOffset");
    }
}