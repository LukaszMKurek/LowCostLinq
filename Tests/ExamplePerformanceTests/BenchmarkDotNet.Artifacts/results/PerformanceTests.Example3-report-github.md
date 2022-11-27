``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |     Error |      StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|----------:|------------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 16,494.5 μs | 556.43 μs | 1,640.63 μs | 20.72 |    2.49 | 109.3750 |  480008 B |          NA |
|                LowCostLinqExample |  7,214.7 μs |   7.42 μs |     6.58 μs |  9.99 |    0.01 |        - |       4 B |          NA |
|      EvenBetterLowCostLinqExample |  1,730.2 μs |   4.06 μs |     3.80 μs |  2.40 |    0.01 |        - |       1 B |          NA |
| NearOptimalSolutionUsingDelegates |  6,199.9 μs |   3.54 μs |     3.13 μs |  8.59 |    0.00 |        - |       4 B |          NA |
|               NearOptimalSolution |    722.1 μs |   0.22 μs |     0.20 μs |  1.00 |    0.00 |        - |         - |          NA |
