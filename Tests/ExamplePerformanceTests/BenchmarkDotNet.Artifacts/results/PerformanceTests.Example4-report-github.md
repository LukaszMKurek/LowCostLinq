``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Scaled | ScaledSD |     Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|-------:|---------:|----------:|----------:|
|                       LinqExample | 14,525.8 us |  33.967 us |  31.773 us |  18.30 |     0.05 | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 10,303.9 us |  55.894 us |  52.284 us |  12.98 |     0.07 |  671.8750 | 2880000 B |
|      EvenBetterLowCostLinqExample | 11,197.7 us | 157.538 us | 147.361 us |  14.11 |     0.18 |         - |       0 B |
|            BestLowCostLinqExample |  2,949.1 us |   6.434 us |   6.018 us |   3.72 |     0.01 |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  6,068.2 us |  18.276 us |  14.269 us |   7.65 |     0.02 |         - |       0 B |
|               NearOptimalSolution |    793.6 us |   1.906 us |   1.592 us |   1.00 |     0.00 |         - |       0 B |
