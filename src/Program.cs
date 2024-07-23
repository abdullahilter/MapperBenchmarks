using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Running;
using MapperBenchmarks;

var config = new ManualConfig()
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .AddExporter(DefaultConfig.Instance.GetExporters().ToArray())
    .AddLogger(DefaultConfig.Instance.GetLoggers().ToArray())
    .AddColumnProvider(DefaultConfig.Instance.GetColumnProviders().ToArray());

BenchmarkRunner.Run<Benchmarks>(config);

Console.ReadLine();