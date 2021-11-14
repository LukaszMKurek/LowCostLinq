``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                            Method |        Mean |     Error |      StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|------------:|------:|--------:|---------:|----------:|
|                       LinqExample | 17,353.4 μs | 827.14 μs | 2,438.83 μs | 22.32 |    3.17 | 109.3750 | 480,000 B |
|                LowCostLinqExample |  7,571.9 μs | 147.70 μs |   170.09 μs | 10.17 |    0.36 |        - |         - |
|      EvenBetterLowCostLinqExample |  1,819.4 μs |  14.25 μs |    12.64 μs |  2.44 |    0.05 |        - |         - |
| NearOptimalSolutionUsingDelegates |  6,525.9 μs |  29.91 μs |    24.97 μs |  8.75 |    0.19 |        - |         - |
|               NearOptimalSolution |    744.8 μs |  14.74 μs |    14.48 μs |  1.00 |    0.00 |        - |         - |
