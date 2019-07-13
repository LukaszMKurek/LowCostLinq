``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |        StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|--------------:|------:|--------:|--------:|------:|------:|----------:|
|                       LinqExample | 19,660.3 us | 479.7357 us | 1,384.1472 us | 28.41 |    2.60 | 93.7500 |     - |     - |  480000 B |
|                LowCostLinqExample | 11,899.5 us | 234.6747 us |   358.3730 us | 16.31 |    0.64 |       - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  2,168.0 us |   2.4131 us |     2.2572 us |  3.00 |    0.00 |       - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  6,262.0 us | 120.6023 us |   134.0491 us |  8.74 |    0.16 |       - |     - |     - |         - |
|               NearOptimalSolution |    722.7 us |   0.2667 us |     0.2227 us |  1.00 |    0.00 |       - |     - |     - |         - |
