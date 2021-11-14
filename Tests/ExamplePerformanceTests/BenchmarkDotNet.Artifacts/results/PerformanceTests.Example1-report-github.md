``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.403
  [Host]     : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT
  DefaultJob : .NET 5.0.12 (5.0.1221.52207), X64 RyuJIT


```
|                            Method |      Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |----------:|---------:|---------:|------:|--------:|---------:|----------:|
|                       LinqExample | 597.03 μs | 2.509 μs | 2.224 μs |  9.23 |    0.14 | 158.2031 |    648 KB |
|                LowCostLinqExample | 313.68 μs | 1.195 μs | 1.118 μs |  4.85 |    0.08 |  80.0781 |    328 KB |
|      EvenBetterLowCostLinqExample | 160.02 μs | 3.105 μs | 3.575 μs |  2.49 |    0.08 |  80.3223 |    328 KB |
| NearOptimalSolutionUsingDelegates | 238.30 μs | 1.105 μs | 0.979 μs |  3.68 |    0.06 |  80.3223 |    328 KB |
|               NearOptimalSolution |  64.70 μs | 1.046 μs | 0.928 μs |  1.00 |    0.00 |  38.2080 |    156 KB |
