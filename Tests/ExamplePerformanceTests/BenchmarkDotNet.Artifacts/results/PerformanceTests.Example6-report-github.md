``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                            Method |       Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|---------:|---------:|------:|--------:|---------:|----------:|
|                       LinqExample | 9,340.8 μs | 11.57 μs | 10.25 μs | 18.94 |    0.02 | 218.7500 | 960,000 B |
|                LowCostLinqExample | 2,016.7 μs |  1.90 μs |  1.78 μs |  4.09 |    0.00 |        - |         - |
|      EvenBetterLowCostLinqExample | 1,868.4 μs | 24.33 μs | 22.76 μs |  3.79 |    0.05 |        - |         - |
| NearOptimalSolutionUsingDelegates | 2,020.5 μs |  1.39 μs |  1.23 μs |  4.10 |    0.01 |        - |         - |
|               NearOptimalSolution |   493.3 μs |  0.41 μs |  0.35 μs |  1.00 |    0.00 |        - |         - |
