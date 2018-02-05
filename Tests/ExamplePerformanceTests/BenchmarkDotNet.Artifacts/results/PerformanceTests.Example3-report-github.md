``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 11,763.2 us | 32.398 us | 28.720 us |  16.15 |     0.05 | 109.3750 |  480000 B |
|                LowCostLinqExample | 11,345.6 us | 64.219 us | 60.070 us |  15.57 |     0.08 |        - |       0 B |
|      EvenBetterLowCostLinqExample |  2,695.9 us | 16.479 us | 15.415 us |   3.70 |     0.02 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  6,023.1 us | 24.216 us | 22.652 us |   8.27 |     0.03 |        - |       0 B |
|               NearOptimalSolution |    728.5 us |  1.460 us |  1.365 us |   1.00 |     0.00 |        - |       0 B |
