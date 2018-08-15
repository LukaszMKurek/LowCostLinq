``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                            Method |      Mean |      Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |----------:|-----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 644.46 us | 10.8096 us | 9.5824 us |  12.25 |     0.18 | 158.2031 | 648.44 KB |
|                LowCostLinqExample | 402.65 us |  0.2480 us | 0.2199 us |   7.65 |     0.00 |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 174.48 us |  0.1036 us | 0.0969 us |   3.32 |     0.00 |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 201.24 us |  2.5370 us | 2.3731 us |   3.82 |     0.04 |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  52.63 us |  0.0228 us | 0.0202 us |   1.00 |     0.00 |  38.0859 | 156.25 KB |
