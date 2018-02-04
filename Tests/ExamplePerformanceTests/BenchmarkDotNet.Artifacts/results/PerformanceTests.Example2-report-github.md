``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |       Mean |      Error |     StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|-----------:|-----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 7,451.6 us |  9.4269 us |  7.3599 us |  15.37 |     0.02 | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,852.7 us | 14.0379 us | 13.1311 us |  14.13 |     0.03 |        - |       0 B |
|      EvenBetterLowCostLinqExample | 1,180.0 us |  1.6694 us |  1.5616 us |   2.43 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 4,100.3 us | 36.4034 us | 34.0518 us |   8.46 |     0.07 |        - |       0 B |
|               NearOptimalSolution |   484.8 us |  0.2729 us |  0.2419 us |   1.00 |     0.00 |        - |       0 B |
