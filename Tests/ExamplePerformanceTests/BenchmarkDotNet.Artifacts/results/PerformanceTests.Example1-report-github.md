``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Scaled |    Gen 0 | Allocated |
|---------------------------------- |----------:|----------:|----------:|-------:|---------:|----------:|
|                       LinqExample | 638.32 us | 0.3318 us | 0.2941 us |  12.82 | 158.2031 | 648.44 KB |
|                LowCostLinqExample | 403.00 us | 0.0884 us | 0.0783 us |   8.09 |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 179.42 us | 0.0549 us | 0.0487 us |   3.60 |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 229.49 us | 0.0742 us | 0.0694 us |   4.61 |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  49.80 us | 0.0085 us | 0.0080 us |   1.00 |  38.0859 | 156.25 KB |
