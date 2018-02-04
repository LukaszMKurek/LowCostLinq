``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |----------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 746.18 us | 4.0816 us | 3.8180 us |  15.09 |     0.08 | 158.2031 | 648.44 KB |
|                LowCostLinqExample | 421.96 us | 1.5564 us | 1.4558 us |   8.53 |     0.03 |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 184.84 us | 2.5107 us | 2.0965 us |   3.74 |     0.04 |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 218.92 us | 0.3353 us | 0.2618 us |   4.43 |     0.01 |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  49.46 us | 0.0765 us | 0.0715 us |   1.00 |     0.00 |  38.0859 | 156.25 KB |
