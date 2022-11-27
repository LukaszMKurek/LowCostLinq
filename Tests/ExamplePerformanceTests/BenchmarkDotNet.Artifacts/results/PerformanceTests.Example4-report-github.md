``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2130 (21H2)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                            Method |        Mean |       Error |       StdDev | Ratio | RatioSD |     Gen 0 |   Allocated |
|---------------------------------- |------------:|------------:|-------------:|------:|--------:|----------:|------------:|
|                       LinqExample | 32,952.9 μs | 4,283.52 μs | 12,630.07 μs | 21.61 |    0.90 | 1812.5000 | 7,680,015 B |
|                LowCostLinqExample |  8,450.5 μs |   166.87 μs |    462.40 μs | 11.27 |    0.40 |  687.5000 | 2,880,008 B |
|      EvenBetterLowCostLinqExample |  7,917.2 μs |   141.51 μs |    138.98 μs |  9.84 |    0.24 |         - |           - |
|            BestLowCostLinqExample |  1,964.3 μs |    39.01 μs |     54.69 μs |  2.47 |    0.06 |         - |           - |
| NearOptimalSolutionUsingDelegates |  6,300.7 μs |    69.32 μs |     64.85 μs |  7.82 |    0.13 |         - |           - |
|               NearOptimalSolution |    804.8 μs |     9.22 μs |      8.18 μs |  1.00 |    0.00 |         - |           - |
