``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2130 (21H2)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                            Method |        Mean |     Error |      StdDev | Ratio | RatioSD |   Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|------------:|------:|--------:|--------:|----------:|
|                       LinqExample | 17,763.4 μs | 639.01 μs | 1,823.13 μs | 24.91 |    2.77 | 93.7500 | 480,015 B |
|                LowCostLinqExample |  7,219.3 μs |   7.18 μs |     6.72 μs | 10.02 |    0.01 |       - |         - |
|      EvenBetterLowCostLinqExample |  1,730.6 μs |   1.67 μs |     1.48 μs |  2.40 |    0.00 |       - |         - |
| NearOptimalSolutionUsingDelegates |  6,204.2 μs |   3.39 μs |     3.00 μs |  8.61 |    0.00 |       - |         - |
|               NearOptimalSolution |    720.1 μs |   0.12 μs |     0.10 μs |  1.00 |    0.00 |       - |         - |
