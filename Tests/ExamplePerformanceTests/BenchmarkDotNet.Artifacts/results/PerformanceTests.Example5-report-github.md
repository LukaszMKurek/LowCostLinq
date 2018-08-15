``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 1,234.87 us | 0.2779 us | 0.2600 us |  17.72 |     0.11 | 457.0313 | 1920000 B |
|                LowCostLinqExample |   633.64 us | 7.0740 us | 6.6170 us |   9.09 |     0.11 |        - |       0 B |
|           ShortLowCostLinqExample |   570.99 us | 0.7429 us | 0.6949 us |   8.19 |     0.05 |        - |       0 B |
|      EvenBetterLowCostLinqExample |   360.57 us | 0.3721 us | 0.3299 us |   5.17 |     0.03 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |   298.24 us | 0.0158 us | 0.0148 us |   4.28 |     0.03 |        - |       0 B |
|               NearOptimalSolution |    69.69 us | 0.4721 us | 0.4416 us |   1.00 |     0.00 |        - |       0 B |
