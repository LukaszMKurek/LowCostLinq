``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |      Error |        StdDev | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|--------------:|------:|--------:|----------:|------:|------:|----------:|
|                       LinqExample | 15,785.6 us | 127.007 us |   118.8028 us | 20.11 |    0.15 | 1812.5000 |     - |     - | 7680000 B |
|                LowCostLinqExample | 10,954.1 us | 167.672 us |   156.8403 us | 13.96 |    0.20 |  671.8750 |     - |     - | 2880000 B |
|      EvenBetterLowCostLinqExample | 13,701.2 us | 352.962 us | 1,040.7152 us | 16.79 |    0.92 |         - |     - |     - |         - |
|            BestLowCostLinqExample |  2,451.8 us |   2.151 us |     2.0121 us |  3.12 |    0.01 |         - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  5,748.1 us |   1.119 us |     0.9918 us |  7.33 |    0.01 |         - |     - |     - |         - |
|               NearOptimalSolution |    784.8 us |   1.298 us |     1.2137 us |  1.00 |    0.00 |         - |     - |     - |         - |
