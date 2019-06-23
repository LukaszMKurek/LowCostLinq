``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |      StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|------------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 14,587.6 us | 289.0233 us | 395.6183 us | 20.17 |    0.56 | 109.3750 |     - |     - |  480000 B |
|                LowCostLinqExample | 11,328.2 us | 492.0363 us | 436.1774 us | 15.67 |    0.60 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  2,168.9 us |   4.0246 us |   3.7646 us |  3.00 |    0.01 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  6,042.1 us |  85.7489 us |  80.2096 us |  8.36 |    0.11 |        - |     - |     - |         - |
|               NearOptimalSolution |    722.7 us |   0.1272 us |   0.1190 us |  1.00 |    0.00 |        - |     - |     - |         - |
