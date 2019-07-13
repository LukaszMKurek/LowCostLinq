``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 10,356.7 us | 3.3757 us | 2.8188 us | 39.07 |    0.03 | 218.7500 |     - |     - |  960000 B |
|                LowCostLinqExample |  2,934.5 us | 0.6059 us | 0.5668 us | 11.07 |    0.01 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  1,737.5 us | 0.2780 us | 0.2601 us |  6.55 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  1,784.9 us | 0.2982 us | 0.2490 us |  6.73 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    265.1 us | 0.1571 us | 0.1469 us |  1.00 |    0.00 |        - |     - |     - |         - |
