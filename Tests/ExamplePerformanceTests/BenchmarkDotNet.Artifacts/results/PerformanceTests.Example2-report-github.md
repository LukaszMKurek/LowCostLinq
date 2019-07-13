``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |       Mean |       Error |      StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|------------:|------------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 8,832.2 us | 171.7380 us | 217.1936 us | 23.57 |    0.65 | 109.3750 |     - |     - |  480000 B |
|                LowCostLinqExample | 6,993.5 us | 137.5799 us | 229.8651 us | 18.60 |    0.55 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample | 1,166.3 us |   2.2417 us |   1.9872 us |  3.14 |    0.01 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates | 4,109.6 us |  12.3842 us |  10.9783 us | 11.07 |    0.03 |        - |     - |     - |         - |
|               NearOptimalSolution |   371.2 us |   0.0603 us |   0.0503 us |  1.00 |    0.00 |        - |     - |     - |         - |
