``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                            Method |        Mean |       Error |      StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|------------:|------------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 13,689.9 us |  72.0084 us |  60.1302 us |  18.89 |     0.08 | 109.3750 |  480000 B |
|                LowCostLinqExample |  9,971.7 us |  27.8905 us |  24.7242 us |  13.76 |     0.03 |        - |       0 B |
|      EvenBetterLowCostLinqExample |  2,702.9 us |   3.5862 us |   2.7998 us |   3.73 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  6,413.3 us | 127.0305 us | 141.1941 us |   8.85 |     0.19 |        - |       0 B |
|               NearOptimalSolution |    724.9 us |   0.1471 us |   0.1148 us |   1.00 |     0.00 |        - |       0 B |
