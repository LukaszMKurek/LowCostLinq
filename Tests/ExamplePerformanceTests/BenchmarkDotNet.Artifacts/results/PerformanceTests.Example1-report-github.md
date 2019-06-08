``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------- |----------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
|                       LinqExample | 640.10 us | 0.3340 us | 0.2607 us | 11.22 |    0.12 | 158.2031 |     - |     - | 648.44 KB |
|                LowCostLinqExample | 427.92 us | 2.3662 us | 1.9759 us |  7.50 |    0.10 |  80.0781 |     - |     - | 328.13 KB |
|      EvenBetterLowCostLinqExample | 181.36 us | 1.8018 us | 1.5972 us |  3.18 |    0.03 |  80.0781 |     - |     - | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 229.02 us | 0.6062 us | 0.5373 us |  4.01 |    0.05 |  81.7871 |     - |     - | 335.94 KB |
|               NearOptimalSolution |  57.08 us | 0.7826 us | 0.6110 us |  1.00 |    0.00 |  38.0859 |     - |     - | 156.25 KB |
