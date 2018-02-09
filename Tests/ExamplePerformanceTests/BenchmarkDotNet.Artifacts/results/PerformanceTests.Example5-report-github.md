``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 1,325.21 us | 0.2943 us | 0.2458 us |  26.99 |     0.03 | 457.0313 | 1920000 B |
|                LowCostLinqExample |   555.11 us | 1.8667 us | 1.6548 us |  11.31 |     0.03 |        - |       0 B |
|           ShortLowCostLinqExample |   563.93 us | 1.2390 us | 1.1589 us |  11.49 |     0.03 |        - |       0 B |
|      EvenBetterLowCostLinqExample |   373.52 us | 0.5502 us | 0.5146 us |   7.61 |     0.01 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |   295.61 us | 0.0114 us | 0.0101 us |   6.02 |     0.01 |        - |       0 B |
|               NearOptimalSolution |    49.10 us | 0.0619 us | 0.0483 us |   1.00 |     0.00 |        - |       0 B |
