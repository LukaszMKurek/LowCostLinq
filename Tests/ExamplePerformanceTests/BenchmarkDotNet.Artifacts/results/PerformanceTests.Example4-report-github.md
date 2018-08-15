``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |      StdDev | Scaled | ScaledSD |     Gen 0 | Allocated |
|---------------------------------- |------------:|------------:|------------:|-------:|---------:|----------:|----------:|
|                       LinqExample | 14,068.6 us | 177.4427 us | 165.9800 us |  17.56 |     0.20 | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 10,463.7 us |  22.3017 us |  20.8610 us |  13.06 |     0.03 |  671.8750 | 2880000 B |
|      EvenBetterLowCostLinqExample | 11,213.8 us |   0.6727 us |   0.5963 us |  14.00 |     0.02 |         - |       0 B |
|            BestLowCostLinqExample |  2,963.9 us |   5.5658 us |   4.9340 us |   3.70 |     0.01 |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  5,737.7 us |   0.5331 us |   0.4986 us |   7.16 |     0.01 |         - |       0 B |
|               NearOptimalSolution |    801.2 us |   1.0532 us |   0.9851 us |   1.00 |     0.00 |         - |       0 B |
