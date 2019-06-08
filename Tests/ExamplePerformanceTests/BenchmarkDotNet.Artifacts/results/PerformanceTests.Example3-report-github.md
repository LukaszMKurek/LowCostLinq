``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |      StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|------------:|------------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 15,143.0 us | 295.7698 us | 394.8442 us | 20.75 |    0.54 | 109.3750 |     - |     - |  480000 B |
|                LowCostLinqExample | 10,425.4 us |  45.9979 us |  35.9121 us | 14.41 |    0.05 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  2,691.1 us |   2.0527 us |   1.9201 us |  3.72 |    0.01 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  6,093.5 us |  35.6312 us |  31.5862 us |  8.42 |    0.05 |        - |     - |     - |         - |
|               NearOptimalSolution |    723.7 us |   0.9904 us |   0.8270 us |  1.00 |    0.00 |        - |     - |     - |         - |
