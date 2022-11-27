``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2130 (21H2)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 |   Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|------------:|
|                       LinqExample | 1,331.07 μs | 23.830 μs | 22.291 μs | 24.57 |    0.80 | 458.9844 | 1,920,001 B |
|                LowCostLinqExample |   427.73 μs |  7.238 μs |  6.771 μs |  7.90 |    0.22 |        - |           - |
|           ShortLowCostLinqExample |   436.94 μs |  8.647 μs | 10.619 μs |  8.08 |    0.29 |        - |           - |
|      EvenBetterLowCostLinqExample |   225.76 μs |  4.431 μs |  4.145 μs |  4.17 |    0.11 |        - |           - |
| NearOptimalSolutionUsingDelegates |   354.84 μs |  2.423 μs |  2.148 μs |  6.56 |    0.16 |        - |           - |
|               NearOptimalSolution |    54.23 μs |  1.072 μs |  1.100 μs |  1.00 |    0.00 |        - |           - |
