``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |       Mean |     Error |    StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |-----------:|----------:|----------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 8,984.7 μs | 291.58 μs | 859.72 μs | 18.54 |    0.72 | 109.3750 |  480008 B |          NA |
|                LowCostLinqExample | 4,251.5 μs |   3.86 μs |   3.42 μs |  9.67 |    0.08 |        - |       4 B |          NA |
|      EvenBetterLowCostLinqExample |   514.8 μs |   0.08 μs |   0.07 μs |  1.17 |    0.01 |        - |         - |          NA |
| NearOptimalSolutionUsingDelegates | 3,956.1 μs |   2.88 μs |   2.69 μs |  9.00 |    0.07 |        - |       4 B |          NA |
|               NearOptimalSolution |   439.6 μs |   4.37 μs |   3.65 μs |  1.00 |    0.00 |        - |         - |          NA |
