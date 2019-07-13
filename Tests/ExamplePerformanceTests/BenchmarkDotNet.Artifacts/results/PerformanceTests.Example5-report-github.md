``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 1,341.89 us |  1.2289 us |  1.0894 us | 25.56 |    0.02 | 457.0313 |     - |     - | 1920000 B |
|                LowCostLinqExample |   608.74 us | 11.1790 us | 10.4568 us | 11.59 |    0.20 |        - |     - |     - |         - |
|           ShortLowCostLinqExample |   629.44 us | 10.7856 us |  9.5612 us | 11.99 |    0.18 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |   332.67 us |  0.0522 us |  0.0488 us |  6.34 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |   315.25 us |  0.0521 us |  0.0462 us |  6.00 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    52.51 us |  0.0088 us |  0.0082 us |  1.00 |    0.00 |        - |     - |     - |         - |
