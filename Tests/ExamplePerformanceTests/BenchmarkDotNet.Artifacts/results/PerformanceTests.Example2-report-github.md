``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |       Mean |      Error |     StdDev |    Gen 0 | Allocated |
|---------------------------------- |-----------:|-----------:|-----------:|---------:|----------:|
|                       LinqExample | 7,486.5 us |  6.7709 us |  6.3335 us | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,856.0 us | 17.5388 us | 16.4058 us |        - |       0 B |
|      EvenBetterLowCostLinqExample | 1,587.9 us |  3.1845 us |  2.9787 us |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 4,134.5 us | 43.8768 us | 41.0424 us |        - |       0 B |
|               NearOptimalSolution |   486.0 us |  0.8945 us |  0.8368 us |        - |       0 B |
