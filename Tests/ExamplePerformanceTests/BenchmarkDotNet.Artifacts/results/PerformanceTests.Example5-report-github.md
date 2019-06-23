``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 1,343.67 us |  0.7022 us |  0.6225 us | 25.48 |    0.01 | 457.0313 |     - |     - | 1920000 B |
|                LowCostLinqExample |   646.40 us | 12.7777 us | 18.3254 us | 12.22 |    0.32 |        - |     - |     - |         - |
|           ShortLowCostLinqExample |   585.86 us |  1.1043 us |  0.9789 us | 11.11 |    0.02 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |   328.41 us |  0.2001 us |  0.1774 us |  6.23 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |   317.24 us |  0.7690 us |  0.6817 us |  6.02 |    0.01 |        - |     - |     - |         - |
|               NearOptimalSolution |    52.73 us |  0.0103 us |  0.0092 us |  1.00 |    0.00 |        - |     - |     - |         - |
