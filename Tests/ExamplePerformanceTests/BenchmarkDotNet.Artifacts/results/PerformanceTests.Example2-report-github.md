``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                            Method |       Mean |       Error |        StdDev |      Median | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|------------:|--------------:|------------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 9,421.2 us | 315.8801 us |   832.1544 us |  9,378.8 us | 25.66 |    1.87 | 109.3750 |     - |     - |  480000 B |
|                LowCostLinqExample | 9,891.8 us | 629.9231 us | 1,857.3425 us | 11,113.9 us | 29.09 |    3.24 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |   796.2 us |   0.9367 us |     0.8303 us |    795.8 us |  2.14 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates | 4,077.0 us |   1.9311 us |     1.7119 us |  4,076.5 us | 10.98 |    0.01 |        - |     - |     - |         - |
|               NearOptimalSolution |   371.4 us |   0.1785 us |     0.1491 us |    371.3 us |  1.00 |    0.00 |        - |     - |     - |         - |
