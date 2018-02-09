``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |     Error |     StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|-----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 11,746.0 us | 93.227 us | 87.2050 us |  16.29 |     0.12 | 109.3750 |  480000 B |
|                LowCostLinqExample |  8,674.3 us | 25.834 us | 24.1653 us |  12.03 |     0.04 |        - |       0 B |
|      EvenBetterLowCostLinqExample |  2,739.1 us |  1.619 us |  1.5144 us |   3.80 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  5,978.8 us |  4.903 us |  4.5863 us |   8.29 |     0.01 |        - |       0 B |
|               NearOptimalSolution |    721.2 us |  1.072 us |  0.8952 us |   1.00 |     0.00 |        - |       0 B |
