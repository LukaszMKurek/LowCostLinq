``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 1,349.60 us |  0.3733 us |  0.3309 us | 25.67 |    0.01 | 457.0313 |     - |     - | 1920000 B |
|                LowCostLinqExample |   637.41 us | 12.7029 us | 17.8076 us | 12.05 |    0.39 |        - |     - |     - |         - |
|           ShortLowCostLinqExample |   624.33 us | 12.2298 us | 22.9705 us | 11.81 |    0.34 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |   312.49 us |  0.0300 us |  0.0250 us |  5.94 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |   315.00 us |  0.0608 us |  0.0569 us |  5.99 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    52.58 us |  0.0058 us |  0.0052 us |  1.00 |    0.00 |        - |     - |     - |         - |
