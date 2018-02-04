``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 11,757.7 us | 32.7095 us | 30.5965 us |  16.25 |     0.04 | 109.3750 |  480000 B |
|                LowCostLinqExample | 11,510.5 us | 28.9980 us | 24.2147 us |  15.91 |     0.03 |        - |       0 B |
|      EvenBetterLowCostLinqExample |  2,661.1 us |  1.2628 us |  1.0545 us |   3.68 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  5,967.0 us | 10.0795 us |  8.9353 us |   8.25 |     0.01 |        - |       0 B |
|               NearOptimalSolution |    723.4 us |  0.6497 us |  0.6077 us |   1.00 |     0.00 |        - |       0 B |
