``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |------------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 10,347.4 us | 3.8219 us | 3.3880 us | 39.04 |    0.04 | 218.7500 |     - |     - |  960000 B |
|                LowCostLinqExample |  2,913.3 us | 0.3318 us | 0.2942 us | 10.99 |    0.01 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample |  1,763.6 us | 0.3049 us | 0.2546 us |  6.65 |    0.00 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates |  1,784.8 us | 0.4233 us | 0.3752 us |  6.73 |    0.00 |        - |     - |     - |         - |
|               NearOptimalSolution |    265.0 us | 0.2090 us | 0.1853 us |  1.00 |    0.00 |        - |     - |     - |         - |
