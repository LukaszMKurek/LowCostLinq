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
|                       LinqExample | 9,500.2 us | 1.4362 us | 1.2731 us |  35.84 |     0.02 | 218.7500 |  960000 B |
|                LowCostLinqExample | 2,954.6 us | 1.4645 us | 1.2982 us |  11.15 |     0.01 |        - |       0 B |
|      EvenBetterLowCostLinqExample | 1,761.0 us | 0.2287 us | 0.2139 us |   6.64 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 1,569.5 us | 1.7803 us | 1.5782 us |   5.92 |     0.01 |        - |       0 B |
|               NearOptimalSolution |   265.1 us | 0.1488 us | 0.1391 us |   1.00 |     0.00 |        - |       0 B |
