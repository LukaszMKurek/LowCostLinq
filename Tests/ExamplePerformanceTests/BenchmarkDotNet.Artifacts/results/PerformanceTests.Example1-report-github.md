``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.2130 (21H2)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT


```
|                            Method |      Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Allocated |
|---------------------------------- |----------:|---------:|---------:|------:|--------:|---------:|----------:|
|                       LinqExample | 522.12 μs | 0.367 μs | 0.325 μs | 10.21 |    0.03 | 158.2031 |    648 KB |
|                LowCostLinqExample | 287.40 μs | 0.425 μs | 0.355 μs |  5.62 |    0.02 |  80.0781 |    328 KB |
|      EvenBetterLowCostLinqExample | 125.95 μs | 0.395 μs | 0.369 μs |  2.46 |    0.01 |  80.3223 |    328 KB |
| NearOptimalSolutionUsingDelegates | 217.20 μs | 0.114 μs | 0.095 μs |  4.25 |    0.01 |  80.3223 |    328 KB |
|               NearOptimalSolution |  51.13 μs | 0.171 μs | 0.143 μs |  1.00 |    0.00 |  38.2080 |    156 KB |
