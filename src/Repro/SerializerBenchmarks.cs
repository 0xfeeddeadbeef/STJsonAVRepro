// MIT License. See LICENSE file.

using System.Text.Json;
using BenchmarkDotNet.Attributes;

namespace STJsonAVRepro;

[MemoryDiagnoser]
public class SerializerBenchmarks
{
    private readonly SimpleTestClass _obj;
    private readonly JsonSerializerOptions _optReflection;
    private readonly JsonSerializerOptions _optSourceGen;

    public SerializerBenchmarks()
    {
        _optReflection = new(JsonSerializerDefaults.Web)
        {
            DefaultBufferSize = 81920,
            WriteIndented = false,
        };

        _optSourceGen = new(JsonSerializerDefaults.Web)
        {
            DefaultBufferSize = 81920,
            WriteIndented = false,
        };

        _optSourceGen.TypeInfoResolverChain.Insert(0, SimpleTestJsonContext.Default);

        var obj = new SimpleTestClass();
        obj.Initialize();

        _obj = obj;
    }

    [Benchmark(Baseline = true)]
    public int UseReflection() => JsonSerializer.Serialize(_obj, _optReflection).Length;

    [Benchmark]
    public int UseSourceGenerator() => JsonSerializer.Serialize(_obj, _optSourceGen).Length;
}
