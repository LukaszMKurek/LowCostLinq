``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |      Gen0 | Allocated | Alloc Ratio |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|----------:|----------:|------------:|
|                       LinqExample | 15,924.7 μs | 330.65 μs | 974.92 μs | 18.46 |    0.83 | 1828.1250 | 7680008 B |          NA |
|                LowCostLinqExample |  7,376.8 μs |  25.02 μs |  23.40 μs |  9.36 |    0.03 |  687.5000 | 2880004 B |          NA |
|      EvenBetterLowCostLinqExample |  7,597.8 μs |   1.73 μs |   1.62 μs |  9.64 |    0.01 |         - |       4 B |          NA |
|            BestLowCostLinqExample |  1,834.8 μs |   1.08 μs |   0.95 μs |  2.33 |    0.00 |         - |       1 B |          NA |
| NearOptimalSolutionUsingDelegates |  6,202.6 μs |   0.33 μs |   0.31 μs |  7.87 |    0.00 |         - |       4 B |          NA |
|               NearOptimalSolution |    787.9 μs |   0.39 μs |   0.37 μs |  1.00 |    0.00 |         - |         - |          NA |
