``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |        Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 |   Allocated |
|---------------------------------- |------------:|---------:|---------:|------:|--------:|---------:|------------:|
|                       LinqExample | 1,192.58 μs | 5.835 μs | 5.173 μs | 23.21 |    0.15 | 458.9844 | 1,920,001 B |
|                LowCostLinqExample |   440.69 μs | 1.230 μs | 1.091 μs |  8.58 |    0.04 |        - |           - |
|           ShortLowCostLinqExample |   424.98 μs | 1.709 μs | 1.598 μs |  8.27 |    0.04 |        - |           - |
|      EvenBetterLowCostLinqExample |   219.42 μs | 0.126 μs | 0.098 μs |  4.27 |    0.02 |        - |           - |
| NearOptimalSolutionUsingDelegates |   295.21 μs | 1.461 μs | 1.366 μs |  5.75 |    0.03 |        - |           - |
|               NearOptimalSolution |    51.38 μs | 0.212 μs | 0.188 μs |  1.00 |    0.00 |        - |           - |
