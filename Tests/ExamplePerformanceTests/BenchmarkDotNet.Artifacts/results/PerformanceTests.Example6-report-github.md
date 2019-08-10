``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 10,377.0 us | 34.4218 us | 32.1982 us | 39.15 |    0.13 | 218.7500 |     - |     - |  960000 B |
|                LowCostLinqExample |  2,935.6 us |  0.8505 us |  0.7539 us | 11.08 |    0.01 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  1,920.5 us |  0.2348 us |  0.2196 us |  7.25 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  1,784.8 us |  0.3847 us |  0.3410 us |  6.73 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    265.0 us |  0.1907 us |  0.1784 us |  1.00 |    0.00 |        - |     - |     - |         - |
