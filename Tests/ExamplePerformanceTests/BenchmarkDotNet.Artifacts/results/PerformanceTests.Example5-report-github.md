``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 1,298.63 us | 1.3993 us | 1.1685 us |  19.35 |     0.03 | 457.0313 | 1920000 B |
|                LowCostLinqExample |   510.72 us | 0.3029 us | 0.2529 us |   7.61 |     0.01 |        - |       0 B |
|           ShortLowCostLinqExample |   508.28 us | 0.3498 us | 0.3272 us |   7.57 |     0.01 |        - |       0 B |
|      EvenBetterLowCostLinqExample |   369.00 us | 2.0570 us | 1.8235 us |   5.50 |     0.03 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |   306.40 us | 1.0629 us | 0.9423 us |   4.57 |     0.02 |        - |       0 B |
|               NearOptimalSolution |    67.11 us | 0.1137 us | 0.1008 us |   1.00 |     0.00 |        - |       0 B |
