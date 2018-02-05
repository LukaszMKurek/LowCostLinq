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
|                       LinqExample | 637.53 us | 7.8790 us | 6.5793 us |  12.87 |     0.13 | 158.2031 | 648.44 KB |
|                LowCostLinqExample | 405.56 us | 4.9524 us | 4.6325 us |   8.19 |     0.09 |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 181.16 us | 0.1339 us | 0.1187 us |   3.66 |     0.01 |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 217.04 us | 0.4563 us | 0.4045 us |   4.38 |     0.01 |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  49.53 us | 0.1292 us | 0.1008 us |   1.00 |     0.00 |  38.0859 | 156.25 KB |
