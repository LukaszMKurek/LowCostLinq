``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 |   Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|------------:|
|                       LinqExample | 1,513.26 μs | 17.076 μs | 14.259 μs | 22.57 |    0.21 | 458.9844 | 1,920,000 B |
|                LowCostLinqExample |   392.21 μs |  6.020 μs |  5.631 μs |  5.85 |    0.08 |        - |           - |
|           ShortLowCostLinqExample |   417.56 μs |  0.648 μs |  0.607 μs |  6.23 |    0.01 |        - |           - |
|      EvenBetterLowCostLinqExample |   219.71 μs |  0.157 μs |  0.146 μs |  3.28 |    0.00 |        - |           - |
| NearOptimalSolutionUsingDelegates |   307.14 μs |  5.085 μs |  4.757 μs |  4.58 |    0.07 |        - |           - |
|               NearOptimalSolution |    67.04 μs |  0.077 μs |  0.072 μs |  1.00 |    0.00 |        - |           - |
