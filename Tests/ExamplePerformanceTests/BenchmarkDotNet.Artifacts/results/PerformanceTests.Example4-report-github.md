``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev | Scaled | ScaledSD |     Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|-------:|---------:|----------:|----------:|
|                       LinqExample | 14,354.8 us | 13.8292 us | 11.5480 us |  18.16 |     0.02 | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 10,168.0 us |  5.6586 us |  5.0162 us |  12.86 |     0.01 |  671.8750 | 2880000 B |
|      EvenBetterLowCostLinqExample | 10,921.9 us |  2.0310 us |  1.4686 us |  13.82 |     0.01 |         - |       0 B |
|            BestLowCostLinqExample |  2,951.8 us | 16.7860 us | 14.8803 us |   3.73 |     0.02 |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  5,994.3 us |  2.0709 us |  1.8358 us |   7.58 |     0.01 |         - |       0 B |
|               NearOptimalSolution |    790.5 us |  0.6989 us |  0.6196 us |   1.00 |     0.00 |         - |       0 B |
