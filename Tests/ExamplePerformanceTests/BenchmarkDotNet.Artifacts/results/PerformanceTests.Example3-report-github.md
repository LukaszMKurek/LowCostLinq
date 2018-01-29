``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev |    Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|---------:|----------:|
|                       LinqExample | 11,829.0 us | 16.4441 us | 15.3818 us | 109.3750 |  480000 B |
|                LowCostLinqExample | 11,476.6 us | 38.4655 us | 35.9806 us |        - |       0 B |
|      EvenBetterLowCostLinqExample |  1,930.3 us | 11.3197 us | 10.5885 us |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  5,979.7 us | 18.2722 us | 17.0919 us |        - |       0 B |
|               NearOptimalSolution |    722.9 us |  0.2390 us |  0.2119 us |        - |       0 B |
