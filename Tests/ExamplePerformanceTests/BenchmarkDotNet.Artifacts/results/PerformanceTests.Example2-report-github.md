``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 10,051.3 μs | 266.25 μs | 768.19 μs | 18.09 |    1.92 | 109.3750 |  480008 B |          NA |
|                LowCostLinqExample |  4,249.9 μs |   4.08 μs |   3.62 μs |  7.92 |    0.40 |        - |       4 B |          NA |
|      EvenBetterLowCostLinqExample |    515.0 μs |   0.08 μs |   0.07 μs |  0.96 |    0.05 |        - |         - |          NA |
| NearOptimalSolutionUsingDelegates |  3,962.9 μs |   1.38 μs |   1.22 μs |  7.39 |    0.38 |        - |       4 B |          NA |
|               NearOptimalSolution |    557.9 μs |  13.22 μs |  37.51 μs |  1.00 |    0.00 |        - |         - |          NA |
