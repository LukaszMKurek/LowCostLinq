``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|----------:|
|                       LinqExample | 13,173.9 μs | 255.72 μs | 226.69 μs | 18.11 |    0.37 | 109.3750 | 480,008 B |
|                LowCostLinqExample |  6,484.9 μs |   8.23 μs |   6.87 μs |  8.92 |    0.05 |        - |       4 B |
|      EvenBetterLowCostLinqExample |  1,700.7 μs |  29.13 μs |  31.17 μs |  2.33 |    0.04 |        - |       1 B |
| NearOptimalSolutionUsingDelegates |  6,466.2 μs |   7.33 μs |   6.12 μs |  8.90 |    0.04 |        - |       6 B |
|               NearOptimalSolution |    727.4 μs |   4.93 μs |   4.37 μs |  1.00 |    0.00 |        - |         - |
