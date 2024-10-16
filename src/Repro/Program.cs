// MIT License. See LICENSE file.

using System;
using System.Text.Json;
using STJsonAVRepro;

Console.WriteLine("Begin");

var optReflection = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    DefaultBufferSize = 81920,
    WriteIndented = false,
};

// Uncomment this line to switch to source-generated serializer:
// optReflection.TypeInfoResolverChain.Insert(0, SimpleTestJsonContext.Default);

var obj = new SimpleTestClass();
obj.Initialize();

var counter = 0ul;
for (var i = 0ul; i < 10_000_000ul; i++)
{
    counter += (ulong)JsonSerializer.Serialize(obj, optReflection).Length;
}

Console.WriteLine("Counter {0}", counter);
Console.WriteLine("End");
