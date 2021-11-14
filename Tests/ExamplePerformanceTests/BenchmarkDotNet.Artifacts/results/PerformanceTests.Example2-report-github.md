``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|---------:|----------:|
|                       LinqExample | 7,726.0 μs | 150.89 μs | 167.72 μs | 15.80 |    0.35 | 109.3750 | 480,008 B |
|                LowCostLinqExample | 4,334.9 μs |   6.22 μs |   5.82 μs |  8.86 |    0.01 |        - |       4 B |
|      EvenBetterLowCostLinqExample |   922.0 μs |   7.02 μs |   6.57 μs |  1.89 |    0.01 |        - |         - |
| NearOptimalSolutionUsingDelegates | 3,722.0 μs |   2.24 μs |   2.10 μs |  7.61 |    0.01 |        - |       2 B |
|               NearOptimalSolution |   489.1 μs |   0.43 μs |   0.40 μs |  1.00 |    0.00 |        - |         - |
