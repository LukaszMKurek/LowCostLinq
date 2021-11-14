``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen 0 |   Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
|                       LinqExample | 15,094.0 μs | 203.72 μs | 217.98 μs | 18.92 |    0.40 | 1828.1250 | 7,680,000 B |
|                LowCostLinqExample |  7,263.0 μs | 103.44 μs |  86.37 μs |  9.12 |    0.12 |  687.5000 | 2,880,000 B |
|      EvenBetterLowCostLinqExample |  7,704.7 μs |  30.14 μs |  28.19 μs |  9.65 |    0.12 |         - |           - |
|            BestLowCostLinqExample |  1,834.3 μs |  20.02 μs |  18.73 μs |  2.30 |    0.03 |         - |           - |
| NearOptimalSolutionUsingDelegates |  6,356.7 μs | 105.19 μs | 103.31 μs |  7.97 |    0.15 |         - |           - |
|               NearOptimalSolution |    798.3 μs |   9.55 μs |   8.93 μs |  1.00 |    0.00 |         - |           - |
