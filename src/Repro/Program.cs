using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;
using STJsonAVRepro;

var config = DefaultConfig.Instance
    .AddJob(Job.ShortRun
        .WithRuntime(CoreRuntime.Core80)
        .WithEnvironmentVariables(new EnvironmentVariable("DOTNET_TieredPGO", "0"))
        .WithId(".NET 8.0"));

_ = BenchmarkRunner.Run<SerializerBenchmarks>(config, args);
