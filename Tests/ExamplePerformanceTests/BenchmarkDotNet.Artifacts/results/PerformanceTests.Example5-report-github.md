``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 1,345.59 us |  5.8590 us |  5.1939 us | 1,343.13 us | 25.60 |    0.10 | 457.0313 |     - |     - | 1920000 B |
|                LowCostLinqExample |   583.04 us | 13.5848 us | 17.1804 us |   575.51 us | 11.12 |    0.33 |        - |     - |     - |         - |
|           ShortLowCostLinqExample |   590.63 us | 11.7999 us | 30.4593 us |   577.60 us | 11.46 |    0.67 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |   377.32 us |  3.9533 us |  3.6979 us |   376.68 us |  7.18 |    0.07 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |   315.11 us |  0.1272 us |  0.1062 us |   315.11 us |  6.00 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    52.55 us |  0.0052 us |  0.0048 us |    52.55 us |  1.00 |    0.00 |        - |     - |     - |         - |
