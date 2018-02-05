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
|                       LinqExample | 7,467.4 us | 20.8365 us | 17.3994 us |  15.41 |     0.04 | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,729.6 us |  7.6179 us |  7.1258 us |  13.89 |     0.02 |        - |       0 B |
|      EvenBetterLowCostLinqExample | 1,178.9 us |  2.6094 us |  2.1790 us |   2.43 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 4,072.8 us |  4.6845 us |  4.3819 us |   8.40 |     0.01 |        - |       0 B |
|               NearOptimalSolution |   484.6 us |  0.3356 us |  0.2975 us |   1.00 |     0.00 |        - |       0 B |
