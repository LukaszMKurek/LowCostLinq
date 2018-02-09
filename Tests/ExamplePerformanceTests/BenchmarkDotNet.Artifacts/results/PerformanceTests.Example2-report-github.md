``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |       Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |-----------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 7,546.0 us | 15.324 us | 14.334 us |  15.65 |     0.05 | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,017.4 us | 20.761 us | 19.420 us |  12.48 |     0.05 |        - |       0 B |
|      EvenBetterLowCostLinqExample | 1,135.8 us |  1.771 us |  1.656 us |   2.36 |     0.01 |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 4,052.7 us |  4.825 us |  4.513 us |   8.41 |     0.02 |        - |       0 B |
|               NearOptimalSolution |   482.1 us |  1.293 us |  1.210 us |   1.00 |     0.00 |        - |       0 B |
