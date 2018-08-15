``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 7,212.3 us | 12.479 us | 11.673 us |  19.33 |     0.16 | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,872.4 us | 60.578 us | 56.665 us |  18.42 |     0.21 |        - |       0 B |
|      EvenBetterLowCostLinqExample | 1,137.3 us |  1.875 us |  1.754 us |   3.05 |     0.02 |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 3,834.5 us |  5.003 us |  4.177 us |  10.28 |     0.08 |        - |       0 B |
|               NearOptimalSolution |   373.1 us |  3.337 us |  3.121 us |   1.00 |     0.00 |        - |       0 B |
