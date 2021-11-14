``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                            Method |       Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|---------:|---------:|------:|--------:|---------:|----------:|
|                       LinqExample | 7,239.8 μs | 92.21 μs | 86.25 μs | 19.46 |    0.23 | 109.3750 | 480,000 B |
|                LowCostLinqExample | 4,109.6 μs |  9.34 μs |  8.73 μs | 11.04 |    0.03 |        - |         - |
|      EvenBetterLowCostLinqExample |   805.9 μs |  4.11 μs |  3.21 μs |  2.17 |    0.01 |        - |         - |
| NearOptimalSolutionUsingDelegates | 3,619.7 μs |  9.09 μs |  8.50 μs |  9.73 |    0.03 |        - |         - |
|               NearOptimalSolution |   372.1 μs |  0.25 μs |  0.23 μs |  1.00 |    0.00 |        - |         - |
