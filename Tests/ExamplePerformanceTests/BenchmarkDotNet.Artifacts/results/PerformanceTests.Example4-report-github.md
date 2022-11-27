``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |     Error |      StdDev | Ratio | RatioSD |      Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|----------:|------------:|------:|--------:|----------:|----------:|------------:|
|                       LinqExample | 17,046.5 μs | 443.47 μs | 1,293.61 μs | 21.49 |    1.59 | 1812.5000 | 7680015 B |          NA |
|                LowCostLinqExample |  7,638.8 μs | 122.21 μs |   114.31 μs |  9.14 |    0.23 |  687.5000 | 2880013 B |          NA |
|      EvenBetterLowCostLinqExample |  7,954.5 μs | 158.19 μs |   205.69 μs |  9.57 |    0.23 |         - |       8 B |          NA |
|            BestLowCostLinqExample |  1,950.2 μs |  32.59 μs |    27.21 μs |  2.34 |    0.08 |         - |       1 B |          NA |
| NearOptimalSolutionUsingDelegates |  6,303.8 μs |  34.29 μs |    28.63 μs |  7.56 |    0.19 |         - |       4 B |          NA |
|               NearOptimalSolution |    831.1 μs |  16.34 μs |    21.25 μs |  1.00 |    0.00 |         - |         - |          NA |
