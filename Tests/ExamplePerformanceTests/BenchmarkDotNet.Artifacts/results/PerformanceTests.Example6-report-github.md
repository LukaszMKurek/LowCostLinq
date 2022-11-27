``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |       Mean |   Error |  StdDev | Ratio | RatioSD |     Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |-----------:|--------:|--------:|------:|--------:|---------:|----------:|------------:|
|                       LinqExample | 8,787.1 μs | 2.23 μs | 1.86 μs | 33.02 |    0.19 | 218.7500 |  960008 B |          NA |
|                LowCostLinqExample | 2,212.7 μs | 0.78 μs | 0.73 μs |  8.31 |    0.05 |        - |       2 B |          NA |
|      EvenBetterLowCostLinqExample | 1,692.4 μs | 0.42 μs | 0.40 μs |  6.36 |    0.03 |        - |       1 B |          NA |
| NearOptimalSolutionUsingDelegates | 1,783.3 μs | 0.58 μs | 0.52 μs |  6.70 |    0.04 |        - |       1 B |          NA |
|               NearOptimalSolution |   266.1 μs | 1.54 μs | 1.44 μs |  1.00 |    0.00 |        - |         - |          NA |
