``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev |    Gen 0 | Allocated |
|---------------------------------- |----------:|----------:|----------:|---------:|----------:|
|                       LinqExample | 636.43 us | 1.0966 us | 0.9157 us | 158.2031 | 648.44 KB |
|                LowCostLinqExample | 411.18 us | 0.4115 us | 0.3436 us |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 168.19 us | 0.1566 us | 0.1388 us |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 216.66 us | 0.0791 us | 0.0702 us |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  49.57 us | 0.3881 us | 0.3631 us |  38.0859 | 156.25 KB |
