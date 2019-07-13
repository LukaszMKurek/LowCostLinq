``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |      StdDev | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|------------:|------:|--------:|----------:|------:|------:|----------:|
|                       LinqExample | 15,614.1 us | 310.4361 us | 318.7950 us | 19.70 |    0.54 | 1828.1250 |     - |     - | 7680000 B |
|                LowCostLinqExample | 11,131.5 us | 215.3985 us | 221.1984 us | 14.03 |    0.42 |  671.8750 |     - |     - | 2880000 B |
|      EvenBetterLowCostLinqExample | 13,300.2 us | 264.4293 us | 607.5703 us | 16.64 |    1.13 |         - |     - |     - |         - |
|            BestLowCostLinqExample |  2,454.9 us |   0.3064 us |   0.2866 us |  3.10 |    0.04 |         - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  5,758.7 us |  14.4253 us |  13.4935 us |  7.27 |    0.10 |         - |     - |     - |         - |
|               NearOptimalSolution |    792.7 us |   9.7001 us |   9.0735 us |  1.00 |    0.00 |         - |     - |     - |         - |
