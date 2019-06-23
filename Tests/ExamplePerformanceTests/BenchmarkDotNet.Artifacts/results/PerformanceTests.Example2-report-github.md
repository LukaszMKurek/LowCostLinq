``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |      StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|------------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 11,517.7 us | 228.0659 us | 465.8783 us | 30.33 |    1.99 | 109.3750 |     - |     - |  480000 B |
|                LowCostLinqExample |  6,617.6 us | 130.1225 us | 288.3425 us | 18.33 |    0.66 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  1,141.2 us |   0.3860 us |   0.3422 us |  3.07 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  4,078.0 us |   4.5824 us |   4.2864 us | 10.99 |    0.01 |        - |     - |     - |         - |
|               NearOptimalSolution |    371.2 us |   0.0884 us |   0.0784 us |  1.00 |    0.00 |        - |     - |     - |         - |
