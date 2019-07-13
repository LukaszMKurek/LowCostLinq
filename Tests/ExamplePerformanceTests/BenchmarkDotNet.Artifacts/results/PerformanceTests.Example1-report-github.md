``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 641.06 us | 1.4957 us | 1.3991 us | 11.43 |    0.20 | 158.2031 |     - |     - | 648.44 KB |
|                LowCostLinqExample | 421.08 us | 8.0689 us | 7.5477 us |  7.51 |    0.13 |  80.0781 |     - |     - | 328.13 KB |
|      EvenBetterLowCostLinqExample | 170.21 us | 0.0942 us | 0.0835 us |  3.03 |    0.05 |  80.0781 |     - |     - | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 225.84 us | 0.0639 us | 0.0597 us |  4.03 |    0.07 |  81.7871 |     - |     - | 335.94 KB |
|               NearOptimalSolution |  56.08 us | 1.0206 us | 0.9547 us |  1.00 |    0.00 |  38.0859 |     - |     - | 156.25 KB |
