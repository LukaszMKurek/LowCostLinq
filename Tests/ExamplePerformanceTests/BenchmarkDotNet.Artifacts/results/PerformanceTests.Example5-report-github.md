``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |    Error |   StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|---------:|---------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 1,287.24 μs | 0.520 μs | 0.435 μs | 25.27 |    0.10 | 458.9844 | 1920001 B |          NA |
|                LowCostLinqExample |   414.90 μs | 0.383 μs | 0.320 μs |  8.15 |    0.04 |        - |         - |          NA |
|           ShortLowCostLinqExample |   412.46 μs | 0.616 μs | 0.576 μs |  8.10 |    0.03 |        - |         - |          NA |
|      EvenBetterLowCostLinqExample |   216.38 μs | 0.281 μs | 0.263 μs |  4.25 |    0.02 |        - |         - |          NA |
| NearOptimalSolutionUsingDelegates |   338.58 μs | 0.316 μs | 0.296 μs |  6.65 |    0.03 |        - |         - |          NA |
|               NearOptimalSolution |    50.94 μs | 0.205 μs | 0.192 μs |  1.00 |    0.00 |        - |         - |          NA |
