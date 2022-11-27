``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 525.97 μs | 10.481 μs | 19.940 μs |  9.99 |    0.23 | 158.2031 | 648.44 KB |        4.15 |
|                LowCostLinqExample | 285.76 μs |  3.693 μs |  3.274 μs |  5.58 |    0.06 |  80.0781 | 328.13 KB |        2.10 |
|      EvenBetterLowCostLinqExample | 133.25 μs |  2.636 μs |  3.427 μs |  2.60 |    0.07 |  80.3223 | 328.13 KB |        2.10 |
| NearOptimalSolutionUsingDelegates | 205.16 μs |  3.951 μs |  4.392 μs |  4.02 |    0.10 |  80.3223 | 328.13 KB |        2.10 |
|               NearOptimalSolution |  51.17 μs |  0.045 μs |  0.040 μs |  1.00 |    0.00 |  38.2080 | 156.25 KB |        1.00 |
