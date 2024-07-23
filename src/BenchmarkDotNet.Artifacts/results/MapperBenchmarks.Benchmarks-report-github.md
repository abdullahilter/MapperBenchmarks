```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3880/23H2/2023Update/SunValley3)
13th Gen Intel Core i9-13900H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 8.0.303
  [Host] : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
| Method               | Mean       | Error    | StdDev   |
|--------------------- |-----------:|---------:|---------:|
| MapWithAgileMapper   | 1,605.7 ns | 27.04 ns | 25.29 ns |
| MapWithTinyMapper    |   785.7 ns | 15.40 ns | 15.81 ns |
| MapWithExpressMapper | 1,388.4 ns | 15.33 ns | 29.54 ns |
| MapWithAutoMapper    |   485.2 ns |  5.99 ns |  5.60 ns |
| MapWithManualMapping |   250.6 ns |  4.77 ns |  4.69 ns |
| MapWithMapster       |   194.0 ns |  2.63 ns |  2.33 ns |
