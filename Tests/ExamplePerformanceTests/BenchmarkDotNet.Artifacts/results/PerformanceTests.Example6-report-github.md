``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |       Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|---------:|---------:|------:|--------:|---------:|----------:|
|                       LinqExample | 8,806.2 μs | 16.52 μs | 14.64 μs | 33.07 |    0.11 | 218.7500 | 960,008 B |
|                LowCostLinqExample | 2,221.0 μs |  5.91 μs |  5.24 μs |  8.34 |    0.03 |        - |       2 B |
|      EvenBetterLowCostLinqExample | 1,627.4 μs |  3.29 μs |  3.08 μs |  6.11 |    0.02 |        - |       1 B |
| NearOptimalSolutionUsingDelegates | 1,560.7 μs |  3.46 μs |  2.89 μs |  5.86 |    0.02 |        - |       1 B |
|               NearOptimalSolution |   266.3 μs |  0.99 μs |  0.88 μs |  1.00 |    0.00 |        - |         - |
