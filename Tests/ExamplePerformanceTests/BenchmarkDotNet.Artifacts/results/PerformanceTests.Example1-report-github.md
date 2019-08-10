``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview7-012821
  [Host]     : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.6 (CoreCLR 4.6.27817.03, CoreFX 4.6.27818.02), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 636.84 us | 3.1617 us | 2.9574 us | 11.44 |    0.05 | 158.2031 |     - |     - | 648.44 KB |
|                LowCostLinqExample | 415.61 us | 1.5215 us | 1.4232 us |  7.47 |    0.03 |  80.0781 |     - |     - | 328.13 KB |
|      EvenBetterLowCostLinqExample | 158.23 us | 0.4382 us | 0.3421 us |  2.84 |    0.01 |  80.0781 |     - |     - | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 223.29 us | 0.0912 us | 0.0762 us |  4.01 |    0.00 |  81.7871 |     - |     - | 335.94 KB |
|               NearOptimalSolution |  55.66 us | 0.0116 us | 0.0109 us |  1.00 |    0.00 |  38.0859 |     - |     - | 156.25 KB |
