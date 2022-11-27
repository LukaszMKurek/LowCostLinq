``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.2130/21H2/November2021Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |       Error |      StdDev | Ratio | RatioSD |    Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|------------:|------------:|------:|--------:|--------:|----------:|------------:|
|                       LinqExample | 23,162.8 μs | 1,259.89 μs | 3,714.82 μs | 34.54 |    4.12 | 93.7500 |  480015 B |          NA |
|                LowCostLinqExample |  7,244.0 μs |    70.78 μs |    62.74 μs |  9.61 |    0.25 |       - |       4 B |          NA |
|      EvenBetterLowCostLinqExample |  1,795.6 μs |    25.77 μs |    22.84 μs |  2.38 |    0.07 |       - |       1 B |          NA |
| NearOptimalSolutionUsingDelegates |  6,335.5 μs |    46.48 μs |    38.81 μs |  8.39 |    0.21 |       - |       4 B |          NA |
|               NearOptimalSolution |    749.6 μs |    14.74 μs |    17.55 μs |  1.00 |    0.00 |       - |         - |          NA |
