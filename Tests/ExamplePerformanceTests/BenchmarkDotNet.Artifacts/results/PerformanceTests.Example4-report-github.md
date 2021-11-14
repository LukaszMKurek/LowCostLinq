``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen 0 |   Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|----------:|------------:|
|                       LinqExample | 14,460.7 μs | 267.84 μs | 237.43 μs | 18.75 |    0.30 | 1828.1250 | 7,680,008 B |
|                LowCostLinqExample |  7,199.4 μs |  14.92 μs |  11.65 μs |  9.33 |    0.03 |  687.5000 | 2,880,004 B |
|      EvenBetterLowCostLinqExample |  7,403.9 μs |  12.07 μs |   9.42 μs |  9.60 |    0.03 |         - |         4 B |
|            BestLowCostLinqExample |  1,840.5 μs |   6.71 μs |   6.28 μs |  2.39 |    0.01 |         - |         1 B |
| NearOptimalSolutionUsingDelegates |  6,695.7 μs |  10.11 μs |   9.46 μs |  8.68 |    0.03 |         - |         4 B |
|               NearOptimalSolution |    771.2 μs |   2.10 μs |   1.86 μs |  1.00 |    0.00 |         - |         1 B |
