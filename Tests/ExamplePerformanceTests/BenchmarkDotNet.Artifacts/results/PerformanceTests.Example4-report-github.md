``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                            Method |        Mean |       Error |        StdDev |      Median | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|--------------:|------------:|------:|--------:|----------:|------:|------:|----------:|
|                       LinqExample | 15,477.7 us | 313.1636 us |   923.3698 us | 15,542.7 us | 20.11 |    0.64 | 1828.1250 |     - |     - | 7680000 B |
|                LowCostLinqExample | 10,627.7 us | 157.4219 us |   147.2526 us | 10,541.2 us | 13.34 |    0.33 |  671.8750 |     - |     - | 2880000 B |
|      EvenBetterLowCostLinqExample | 14,334.4 us | 681.2529 us | 1,976.4382 us | 13,645.0 us | 18.62 |    2.22 |         - |     - |     - |         - |
|            BestLowCostLinqExample |  1,985.4 us |   0.2592 us |     0.2164 us |  1,985.4 us |  2.49 |    0.04 |         - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  5,755.9 us |  12.3345 us |    10.9342 us |  5,749.5 us |  7.22 |    0.11 |         - |     - |     - |         - |
|               NearOptimalSolution |    797.0 us |  13.5953 us |    12.7171 us |    793.9 us |  1.00 |    0.00 |         - |     - |     - |         - |
