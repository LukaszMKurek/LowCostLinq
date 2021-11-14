``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|                            Method |      Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |----------:|---------:|---------:|------:|--------:|---------:|----------:|
|                       LinqExample | 540.72 μs | 2.772 μs | 2.593 μs | 10.92 |    0.06 | 158.2031 |    648 KB |
|                LowCostLinqExample | 262.53 μs | 0.573 μs | 0.536 μs |  5.30 |    0.02 |  80.0781 |    328 KB |
|      EvenBetterLowCostLinqExample | 125.12 μs | 0.076 μs | 0.063 μs |  2.53 |    0.01 |  80.3223 |    328 KB |
| NearOptimalSolutionUsingDelegates | 180.72 μs | 0.103 μs | 0.092 μs |  3.65 |    0.01 |  80.3223 |    328 KB |
|               NearOptimalSolution |  49.51 μs | 0.115 μs | 0.096 μs |  1.00 |    0.00 |  38.2080 |    156 KB |
