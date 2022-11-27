``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |      Mean |    Error |   StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |----------:|---------:|---------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 490.27 μs | 3.026 μs | 2.683 μs |  9.58 |    0.06 | 158.6914 | 648.44 KB |        4.15 |
|                LowCostLinqExample | 287.60 μs | 0.351 μs | 0.329 μs |  5.62 |    0.01 |  80.0781 | 328.13 KB |        2.10 |
|      EvenBetterLowCostLinqExample | 126.26 μs | 0.312 μs | 0.276 μs |  2.47 |    0.01 |  80.3223 | 328.13 KB |        2.10 |
| NearOptimalSolutionUsingDelegates | 202.65 μs | 0.075 μs | 0.063 μs |  3.96 |    0.00 |  80.3223 | 328.13 KB |        2.10 |
|               NearOptimalSolution |  51.16 μs | 0.055 μs | 0.051 μs |  1.00 |    0.00 |  38.2080 | 156.25 KB |        1.00 |
