``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|------:|--------:|--------:|------:|------:|----------:|
|                       LinqExample | 14,665.0 us | 291.335 us | 470.451 us | 20.24 |    0.65 | 93.7500 |     - |     - |  480000 B |
|                LowCostLinqExample | 11,063.7 us | 126.434 us | 118.266 us | 15.27 |    0.16 |       - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  1,719.8 us |  16.653 us |  15.578 us |  2.37 |    0.02 |       - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  6,309.6 us | 118.548 us | 131.766 us |  8.73 |    0.18 |       - |     - |     - |         - |
|               NearOptimalSolution |    724.4 us |   1.694 us |   1.584 us |  1.00 |    0.00 |       - |     - |     - |         - |
