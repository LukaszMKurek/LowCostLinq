``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 9,366.6 μs | 184.48 μs | 246.27 μs | 32.24 |    1.34 | 218.7500 |  960008 B |          NA |
|                LowCostLinqExample | 2,324.6 μs |  46.13 μs |  43.15 μs |  7.96 |    0.27 |        - |       2 B |          NA |
|      EvenBetterLowCostLinqExample | 1,676.8 μs |  23.43 μs |  21.92 μs |  5.74 |    0.23 |        - |       1 B |          NA |
| NearOptimalSolutionUsingDelegates | 1,829.9 μs |  17.69 μs |  15.68 μs |  6.27 |    0.25 |        - |       1 B |          NA |
|               NearOptimalSolution |   293.8 μs |   5.76 μs |  10.95 μs |  1.00 |    0.00 |        - |         - |          NA |
