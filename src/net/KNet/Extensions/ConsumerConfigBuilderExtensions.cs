﻿/*
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

using MASES.JCOBridge.C2JBridge;
using MASES.KNet.Clients.Consumer;
using MASES.KNet.Common.Serialization;
using System;

namespace MASES.KNet.Extensions
{
    public static class ConsumerConfigBuilderExtensions
    {
        public static ConsumerConfigBuilder WithKeyDeserializerClass<T>(this ConsumerConfigBuilder builder)
        {
            return WithKeyDeserializerClass(builder, typeof(T));
        }

        public static ConsumerConfigBuilder WithKeyDeserializerClass(this ConsumerConfigBuilder builder, System.Type type)
        {
            if (type == typeof(byte[]))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<ByteArrayDeserializer>());
            }
            else if (type == typeof(double))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<DoubleDeserializer>());
            }
            else if (type == typeof(float))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<FloatDeserializer>());
            }
            else if (type == typeof(int))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<IntegerDeserializer>());
            }
            else if (type == typeof(long))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<LongDeserializer>());
            }
            else if (type == typeof(short))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<ShortDeserializer>());
            }
            else if (type == typeof(string))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<StringDeserializer>());
            }
            else if (type == typeof(Guid))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<UUIDDeserializer>());
            }
            else if (type == typeof(void))
            {
                return builder.WithKeyDeserializerClass(JVMBridgeBase.ClassNameOf<VoidDeserializer>());
            }
            // add other

            return builder;
        }

        public static ConsumerConfigBuilder WithValueDeserializerClass<T>(this ConsumerConfigBuilder builder)
        {
            return WithValueDeserializerClass(builder, typeof(T));
        }

        public static ConsumerConfigBuilder WithValueDeserializerClass(this ConsumerConfigBuilder builder, System.Type type)
        {
            if (type == typeof(string))
            {
                return builder.WithValueDeserializerClass(JVMBridgeBase.ClassNameOf<StringDeserializer>());
            }
            // add other

            return builder;
        }
    }
}
