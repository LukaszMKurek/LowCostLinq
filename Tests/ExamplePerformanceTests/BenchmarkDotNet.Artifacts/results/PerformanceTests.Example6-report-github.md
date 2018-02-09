``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |     Error |    StdDev | Scaled | ScaledSD |    Gen 0 | Allocated |
|---------------------------------- |------------:|----------:|----------:|-------:|---------:|---------:|----------:|
|                       LinqExample | 10,355.3 us | 1.1865 us | 1.0518 us |  39.12 |     0.02 | 218.7500 |  960000 B |
|                LowCostLinqExample |  2,694.9 us | 0.5174 us | 0.4321 us |  10.18 |     0.00 |        - |       0 B |
|      EvenBetterLowCostLinqExample |  1,731.1 us | 0.1981 us | 0.1756 us |   6.54 |     0.00 |        - |       0 B |
| NearOptimalSolutionUsingDelegates |  1,547.0 us | 0.1009 us | 0.0788 us |   5.84 |     0.00 |        - |       0 B |
|               NearOptimalSolution |    264.7 us | 0.1535 us | 0.1282 us |   1.00 |     0.00 |        - |       0 B |
