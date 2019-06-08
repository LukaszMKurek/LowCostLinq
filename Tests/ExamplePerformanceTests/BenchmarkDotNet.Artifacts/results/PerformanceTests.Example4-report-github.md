``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |     Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------------:|------:|--------:|----------:|------:|------:|----------:|
|                       LinqExample | 14,446.3 us | 134.186 us | 118.952 us | 14,418.7 us | 18.37 |    0.15 | 1828.1250 |     - |     - | 7680000 B |
|                LowCostLinqExample | 11,075.1 us |  71.667 us |  55.953 us | 11,071.5 us | 14.08 |    0.07 |  671.8750 |     - |     - | 2880000 B |
|      EvenBetterLowCostLinqExample | 12,192.5 us | 267.996 us | 751.490 us | 11,971.9 us | 15.16 |    0.77 |         - |     - |     - |         - |
|            BestLowCostLinqExample |  3,013.3 us |   5.884 us |   5.504 us |  3,012.5 us |  3.83 |    0.01 |         - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  5,749.9 us |   2.348 us |   1.961 us |  5,749.7 us |  7.31 |    0.01 |         - |     - |     - |         - |
|               NearOptimalSolution |    786.5 us |   1.396 us |   1.237 us |    786.2 us |  1.00 |    0.00 |         - |     - |     - |         - |
