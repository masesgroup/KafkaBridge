---
title: Streams SDK of .NET suite for Apache Kafka™
_description: Describes how to use Streams SDK of .NET suite for Apache Kafka™
---

# KNet: Streams SDK

This is only a quick introduction to KNet Streams SDK, many other information related to Apache Kafka™ Streams can be found at the following links: https://kafka.apache.org/documentation/#streams and https://kafka.apache.org/documentation/streams/

## Why KNet Streams SDK

KNet Streams SDK adds the ability to manage complex .NET types in Apache Kafka™ Streams without manage them in the JVM. 
**The Apache Kafka™ Streams APIs available in .NET suite for Apache Kafka™ works well if the types used are known within the JVM.**
Starting from the previous sentence, it works well using native types (bool, string, long, int, and so on), however it does not work if the type in .NET does not have a JVM counterpart.

To solve this limitation there are two ways:
1. if there is the need of a complex type in .NET, an equivalent class shall be avalable in the JVM; so the right steps are:
   - create the JVM class (in Java or any other language supported)
   - reflect the JVM class with JNetReflector, or manually create it, in .NET
   - use the generated .NET class as key, or value, type in Apache Kafka™ Streams API available in _.NET suite for Apache Kafka_
2. otherwise use directly the .NET types in the KNet Streams API available in _.NET suite for Apache Kafka_; this implies:
   - the developer does not need any knowledge of the JVM
   - everything is mananged, behind the scene, from KNet Streams API

## General 

The KNet Streams SDK is a set of API which expose, in .NET, the one available in Apache Kafka™ Streams and adds the feature to directly manages serializable types of .NET:
- The implementation is backed by a standard Apache Kafka™ Streams which is instructed to work with raw data (i.e. array of bytes);
- The data are exposed, in .NET, using the types assigned, most of translation jobs are supported by [KNet serializers](usageSerDes.md).

## API set

The available classes are under the following namespaces:
- **MASES.KNet.Streams**: covers _org.apache.kafka.streams_ Java package
- **MASES.KNet.Streams.Kstream**: covers _org.apache.kafka.streams.kstream_ Java package
- **MASES.KNet.Streams.Processor**: covers _org.apache.kafka.streams.processor_ Java package
- **MASES.KNet.Streams.Processor.Api**: covers _org.apache.kafka.streams.processor.api_ Java package
- **MASES.KNet.Streams.State**: covers _org.apache.kafka.streams.state_ Java package
- **MASES.KNet.Streams.Utils**: adds some useful functions

All KNet Streams SDK APIs starts with the KNet prefix to avoid confusion during development; some examples are:
- _org.apache.kafka.streams.KafkaStreams_ is managed from **MASES.KNet.Streams.Streams**
- _org.apache.kafka.streams.state.KeyValueIterator<K, V>_ is managed from **MASES.KNet.Streams.State.KeyValueIterator<TKey, TValue>** applying byte[] on both K and V on _org.apache.kafka.streams.state.KeyValueIterator<K, V>_; there are special cases for this, and other classes, to manage different JVM types:
  - **MASES.KNet.Streams.State.TimestampedKeyValueIterator<TKey, TValue>** uses an _org.apache.kafka.streams.state.KeyValueIterator<K, V>_ applying byte[] on K and _org.apache.kafka.streams.state.ValueAndTimestamp<byte[]>_ on V;
  - **MASES.KNet.Streams.State.TimestampedWindowedKeyValueIterator<TKey, TValue>** uses an _org.apache.kafka.streams.state.KeyValueIterator<K, V>_ applying _org.apache.kafka.streams.kstream.Windowed<byte[]>_ on K and _org.apache.kafka.streams.state.ValueAndTimestamp<byte[]>_ on V;

**Current available APIs cover a subset of the full APIs available in Apache Kafka™ Streams and some classes are only placeholder for some implemented APIs.**

## Examples

Following two examples describing two different cases.

### Simple types example

Below a simple usage example of the APIs available till now:

```C#
string topicName = "topic-input";
string storageId = "myStorage";

StreamsConfigBuilder streamsConfig = StreamsConfigBuilder.Create();
StreamsBuilder builder = new StreamsBuilder(streamsConfig);

Org.Apache.Kafka™.Streams.State.KeyValueBytesStoreSupplier storeSupplier = Org.Apache.Kafka™.Streams.State.Stores.InMemoryKeyValueStore(storageId);
Materialized<string, string> materialized = Materialized<string, string>.As(storeSupplier);
GlobalKTable<string, string> globalTable = builder.GlobalTable(topicName, materialized);
Topology topology = builder.Build();
Streams streams = new Streams(topology, streamsConfig);

streams.Start();

ReadOnlyKeyValueStore<string, string> keyValueStore = streams.Store(storageId, QueryableStoreTypes.KeyValueStore<string, string>());
KeyValueIterator<string, string> keyValueIterator = keyValueStore.All;

while (keyValueIterator.HasNext)
{
    KeyValue<string, string> kv = keyValueIterator.Next;

}

```

The above example uses simple type, i.e. `string`, as data stored within the topic.

### Complex types example

A more complex example is the one below where the value is a serializable .NET class:

```C#
public class TestType
{
    public TestType(int i)
    {
        name = description = value = i.ToString();
    }

    public string name;
    public string description;
    public string value;

    public override string ToString()
    {
        return $"name {name} - description {description} - value {value}";
    }
}


string topicName = "topic-input";
string storageId = "myStorage";

StreamsConfigBuilder streamsConfig = StreamsConfigBuilder.Create();
// streamsConfig.KNetKeySerDes = typeof(JsonSerDes.Key<>); // needed for complex keys
streamsConfig.KNetValueSerDes = typeof(JsonSerDes.Value<>);

StreamsBuilder builder = new StreamsBuilder(streamsConfig);

Org.Apache.Kafka™.Streams.State.KeyValueBytesStoreSupplier storeSupplier = Org.Apache.Kafka™.Streams.State.Stores.InMemoryKeyValueStore(storageId);
Materialized<int, TestType> materialized = Materialized<int, TestType>.As(storeSupplier);
GlobalKTable<int, TestType> globalTable = builder.GlobalTable(topicName, materialized);
Topology topology = builder.Build();
Streams streams = new Streams(topology, streamsConfig);

streams.Start();

ReadOnlyKeyValueStore<int, TestType> keyValueStore = streams.Store(storageId, QueryableStoreTypes.KeyValueStore<int, TestType>());
KeyValueIterator<int, TestType> keyValueIterator = keyValueStore.All;

while (keyValueIterator.HasNext)
{
    KNetKeyValue<int, TestType> kv = keyValueIterator.Next;

}

```

The above example uses a complex type for value, i.e. `TestType`, as data stored within the topic. The selected serializer is the JSON serializer (`JsonSerDes.Value<V>`) applied over `StreamsConfigBuilder` instance.
If even the key needs a complex type just uncomment the line with `streamsConfig.KNetKeySerDes = typeof(JsonSerDes.Key<>);` and replace the key type with your custom key type.
Other ready made serializers can be found on [KNet serializers](usageSerDes.md).

## Performance consideration

In the previous examples data retrieve use a `KeyValueIterator<TKey, TValue>` obtained from a `ReadOnlyKeyValueStore<TKey, TValue>`. 
In KNet Streams SDK the serializer is used only when the specifc field is requested, so the following cycle can traverse the full `KeyValueIterator<TKey, TValue>` content searching a specifc key, then the value is returned:

```C#
while (keyValueIterator.HasNext)
{
    KeyValue<int, TestType> kv = keyValueIterator.Next;
    if (kv.Key == 100) // key deserialization happens here
    {
        return kv.Value; // value deserialization happens here
    }
}

```

The approach reduces the serialization impact when not needed.
However there are conditions which needs to avoid the deserialization to be made in sync. Consider a condition where there is a lot of work done on key and/or value returned, the serialization can impact the whole cycle:

```C#
while (keyValueIterator.HasNext)
{
    KeyValue<int, TestType> kv = keyValueIterator.Next;
    longFunction(kv.Key, kv.Value); // key and value deserialization happens here before invocation of longFunction
}

void longFunction(int key, TestType value)
{
    // long work here
}

```

To solve this problem KNet Streams SDK comes with a feature to deserialize in parallel while `longFunction` do its work; `KeyValueIterator<TKey, TValue>` can return a special `IEnumerator<TKeyValue>` which deserialize in parallel:

```C#
IEnumerator<KeyValue<int, TestType>> enumerator = keyValueIterator.ToIEnumerator(); // it was used the default, i.e. with prefetch feature
// key and value deserialization happens behind the scene
while (enumerator.MoveNext())
{
    KeyValue<int, TestType> kv = keyValueIterator.Current; 
    longFunction(kv.Key, kv.Value); // key and value are already ready before invocation of longFunction
}

void longFunction(int key, TestType value)
{
    // long work here
}

```

> [!WARNING]
> This feature uses an external thread and cannot be stopped; upon executed `ToIEnumerator` function, the thread starts and continues till the end of the available data.

The previous point can be mitigated using the `foreach` statement since iterators implements both `IEnumerable<T>` and `IAsyncEnumerable<T>`:

```C#
foreach (KeyValue<int, TestType> kv in keyValueIterator) 
{
    if (kv.Key == 100) break; // when iteration breaks, keyValueIterator is Disposed and the external thread exit
    longFunction(kv.Key, kv.Value); // key and value are already ready before invocation of longFunction
}

void longFunction(int key, TestType value)
{
    // long work here
}

```

or

```C#
await foreach (KeyValue<int, TestType> kv in keyValueIterator) 
{
    if (kv.Key == 100) break; // when iteration breaks, keyValueIterator is Disposed and the external thread exit
    longFunction(kv.Key, kv.Value); // key and value are already ready before invocation of longFunction
}

void longFunction(int key, TestType value)
{
    // long work here
}

```
