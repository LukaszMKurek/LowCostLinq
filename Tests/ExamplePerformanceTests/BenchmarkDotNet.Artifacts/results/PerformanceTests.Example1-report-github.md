``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|---------:|------:|------:|----------:|
|                       LinqExample | 637.74 us | 0.5240 us | 0.4375 us | 11.44 | 158.2031 |     - |     - | 648.44 KB |
|                LowCostLinqExample | 412.25 us | 0.2016 us | 0.1788 us |  7.40 |  80.0781 |     - |     - | 328.13 KB |
|      EvenBetterLowCostLinqExample | 171.78 us | 0.0812 us | 0.0634 us |  3.08 |  80.0781 |     - |     - | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 226.00 us | 0.1290 us | 0.1077 us |  4.06 |  81.7871 |     - |     - | 335.94 KB |
|               NearOptimalSolution |  55.73 us | 0.0147 us | 0.0130 us |  1.00 |  38.0859 |     - |     - | 156.25 KB |
