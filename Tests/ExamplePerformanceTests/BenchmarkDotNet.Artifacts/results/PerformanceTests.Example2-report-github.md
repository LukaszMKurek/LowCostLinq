``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2130 (21H2)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                            Method |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|---------:|----------:|
|                       LinqExample | 9,528.3 μs | 262.42 μs | 748.69 μs | 9,478.6 μs | 21.62 |    1.88 | 109.3750 | 480,008 B |
|                LowCostLinqExample | 4,250.8 μs |   2.60 μs |   2.43 μs | 4,250.3 μs |  9.43 |    0.49 |        - |         - |
|      EvenBetterLowCostLinqExample |   515.1 μs |   0.07 μs |   0.06 μs |   515.1 μs |  1.15 |    0.06 |        - |         - |
| NearOptimalSolutionUsingDelegates | 3,957.6 μs |   2.48 μs |   2.07 μs | 3,957.5 μs |  8.85 |    0.44 |        - |         - |
|               NearOptimalSolution |   437.9 μs |   8.75 μs |  23.79 μs |   422.1 μs |  1.00 |    0.00 |        - |         - |
