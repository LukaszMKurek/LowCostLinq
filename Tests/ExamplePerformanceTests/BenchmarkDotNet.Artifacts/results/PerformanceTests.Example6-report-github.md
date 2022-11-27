``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2130 (21H2)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|---------:|----------:|
|                       LinqExample | 9,140.5 μs | 174.07 μs | 154.31 μs | 32.18 |    1.26 | 218.7500 | 960,008 B |
|                LowCostLinqExample | 2,295.4 μs |  37.81 μs |  33.52 μs |  8.08 |    0.38 |        - |         - |
|      EvenBetterLowCostLinqExample | 1,661.0 μs |  18.43 μs |  16.34 μs |  5.85 |    0.23 |        - |         - |
| NearOptimalSolutionUsingDelegates | 1,820.5 μs |  15.58 μs |  14.58 μs |  6.44 |    0.26 |        - |         - |
|               NearOptimalSolution |   283.2 μs |   5.64 μs |   9.27 μs |  1.00 |    0.00 |        - |         - |
