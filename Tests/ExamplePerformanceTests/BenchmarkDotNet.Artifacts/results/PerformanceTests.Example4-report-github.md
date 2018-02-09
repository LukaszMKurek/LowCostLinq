``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |    StdDev | Scaled | ScaledSD |     Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|----------:|-------:|---------:|----------:|----------:|
|                       LinqExample | 14,044.1 us | 11.9685 us | 9.9942 us |  18.28 |     0.03 | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 11,110.9 us |  8.1459 us | 7.6197 us |  14.47 |     0.03 |  671.8750 | 2880000 B |
|      EvenBetterLowCostLinqExample | 10,672.2 us |  2.7525 us | 2.4400 us |  13.89 |     0.02 |         - |       0 B |
|            BestLowCostLinqExample |  3,006.0 us |  1.0511 us | 0.8777 us |   3.91 |     0.01 |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  6,201.0 us |  0.1467 us | 0.1145 us |   8.07 |     0.01 |         - |       0 B |
|               NearOptimalSolution |    768.1 us |  1.4756 us | 1.3081 us |   1.00 |     0.00 |         - |       0 B |
