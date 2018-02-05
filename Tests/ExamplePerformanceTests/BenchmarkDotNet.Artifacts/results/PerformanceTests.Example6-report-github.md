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
|                       LinqExample | 10,439.8 us | 18.0333 us | 15.9861 us |  39.43 |     0.06 | 218.7500 |  960000 B |
|                LowCostLinqExample |  2,703.2 us |  7.9412 us |  7.0397 us |  10.21 |     0.03 |        - |       0 B |
|      EvenBetterLowCostLinqExample |  1,761.6 us |  0.2614 us |  0.2445 us |   6.65 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  1,549.8 us |  1.0425 us |  0.8705 us |   5.85 |     0.00 |        - |       0 B |
|               NearOptimalSolution |    264.8 us |  0.1751 us |  0.1638 us |   1.00 |     0.00 |        - |       0 B |
