``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev |     Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|----------:|----------:|
|                       LinqExample | 14,384.6 us | 90.2034 us | 84.3763 us | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 10,135.3 us |  2.8324 us |  2.6494 us |  671.8750 | 2880000 B |
|      EvenBetterLowCostLinqExample | 10,944.9 us | 20.1747 us | 18.8714 us |         - |       0 B |
|            BestLowCostLinqExample |  2,211.4 us |  1.4088 us |  1.2488 us |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  6,000.1 us |  1.4933 us |  1.1659 us |         - |       0 B |
|               NearOptimalSolution |    790.1 us |  0.2530 us |  0.2366 us |         - |       0 B |
