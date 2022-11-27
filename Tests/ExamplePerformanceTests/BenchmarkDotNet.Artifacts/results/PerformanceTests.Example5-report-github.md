``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 1,325.87 μs | 21.704 μs | 20.302 μs | 24.38 |    0.72 | 458.9844 | 1920001 B |          NA |
|                LowCostLinqExample |   435.19 μs |  8.305 μs |  7.769 μs |  8.00 |    0.27 |        - |         - |          NA |
|           ShortLowCostLinqExample |   435.82 μs |  8.025 μs |  7.114 μs |  8.02 |    0.29 |        - |         - |          NA |
|      EvenBetterLowCostLinqExample |   226.48 μs |  4.518 μs |  4.437 μs |  4.16 |    0.15 |        - |         - |          NA |
| NearOptimalSolutionUsingDelegates |   347.33 μs |  4.408 μs |  4.123 μs |  6.39 |    0.22 |        - |         - |          NA |
|               NearOptimalSolution |    54.11 μs |  1.063 μs |  1.420 μs |  1.00 |    0.00 |        - |         - |          NA |
