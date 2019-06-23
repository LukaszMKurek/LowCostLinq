``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 10,359.4 us | 2.8206 us | 2.6383 us | 39.10 |    0.03 | 218.7500 |     - |     - |  960000 B |
|                LowCostLinqExample |  2,922.3 us | 0.4400 us | 0.4116 us | 11.03 |    0.01 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  1,737.6 us | 0.1771 us | 0.1656 us |  6.56 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  1,784.7 us | 0.2314 us | 0.2165 us |  6.74 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    264.9 us | 0.1760 us | 0.1561 us |  1.00 |    0.00 |        - |     - |     - |         - |
