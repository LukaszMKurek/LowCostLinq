``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |       Mean |      Error |     StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |-----------:|-----------:|-----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 8,645.1 us | 148.550 us | 138.954 us | 23.06 |    0.23 | 109.3750 |     - |     - |  480000 B |
|                LowCostLinqExample | 6,394.6 us | 121.488 us | 107.696 us | 17.12 |    0.32 |        - |     - |     - |         - |
|      EvenBetterLowCostLinqExample | 1,140.2 us |   2.722 us |   2.413 us |  3.06 |    0.01 |        - |     - |     - |         - |
| NearOptimalSolutionUsingDelegates | 4,080.4 us |   4.960 us |   4.142 us | 10.93 |    0.05 |        - |     - |     - |         - |
|               NearOptimalSolution |   373.2 us |   1.962 us |   1.638 us |  1.00 |    0.00 |        - |     - |     - |         - |
