LowCostLinq is a library that deliver interface similar to LINQ but better performance.
===========================

Example LINQ expression:

```C#
// LinqExample
var result = collection
	.Where(i => i != 0)
	.Select(i => i + 2)
	.Skip(16)
	.Take(32)
	.ToArray();
```

Can be optimized by adding invocation of extension method **AsLowCostLinq**:

```C#
// LowCostLinqExample
var result = collection.AsLowCostLinq() // <-- HERE is magic!
	.Where(i => i != 0)
	.Select(i => i + 2)
	.Skip(16)
	.Take(32)
	.ToArray();
```
	
Second expression will allocate less objects and will be noticably faster than LINQ.

Performance results for this example:

``` ini
BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev | Scaled |    Gen 0 | Allocated |
|---------------------------------- |----------:|----------:|----------:|-------:|---------:|----------:|
|                   **LinqExample** | 746.18 us | 4.0816 us | 3.8180 us |  15.09 | 158.2031 | 648.44 KB |
|            **LowCostLinqExample** | 421.96 us | 1.5564 us | 1.4558 us |   8.53 |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 184.84 us | 2.5107 us | 2.0965 us |   3.74 |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 218.92 us | 0.3353 us | 0.2618 us |   4.43 |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  49.46 us | 0.0765 us | 0.0715 us |   1.00 |  38.0859 | 156.25 KB |

For details look at **ExamplePerformanceTests** project.

In above results we can see that:
1. LINQ is several times worse than hand implementation (more than 10x lower and 4x more memory consume)
2. LINQ are much easier to write and much error prone
3. LowCostLinq is easy to use and it is noticable faster than LINQ (about 2x faster and 2x less memory allocation) when we use delegate
4. LowCostLinq can be even faster when we use new API (3x timest faster than LINQ)

Example 2:

```C#
// LinqExample
var result = collection
		.Where(i => i != 0)
		.Where(i => i != 1)
		.Where(i => i != 2)
		.Where(i => i != 3)
		.First(i => i > SomeMagicNumber);
```					
and optimized with new API:

```C#
// EvenBetterLowCostLinqExample
var result = collection.AsLowCostLinq()
		.Where(Items.AreNotEqualTo(0)) // instead delegate, this magic can be inlined during jitting
		.Where(Items.AreNotEqualTo(1))
		.Where(Items.AreNotEqualTo(2))
		.Where(Items.AreNotEqualTo(3))
		.Where(Items.AreGreatherThan(SomeMagicNumber))
		.First(); // currently I am going to not implement faster wersion of First. I do not want blow API even more
```					
Performance results for this example:

``` ini
BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |       Mean |      Error |     StdDev | Scaled |    Gen 0 | Allocated |
|---------------------------------- |-----------:|-----------:|-----------:|-------:|---------:|----------:|
|                   **LinqExample** | 7,451.6 us |  9.4269 us |  7.3599 us |  15.37 | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,852.7 us | 14.0379 us | 13.1311 us |  14.13 |        - |       0 B |
|  **EvenBetterLowCostLinqExample** | 1,180.0 us |  1.6694 us |  1.5616 us |   2.43 |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 4,100.3 us | 36.4034 us | 34.0518 us |   8.46 |        - |       0 B |
|               NearOptimalSolution |   484.8 us |  0.2729 us |  0.2419 us |   1.00 |        - |       0 B |

We see that LowCostLinq:
1. 0 bytes allocated!
2. Performance is 5x times beter than LINQ and can be even better in future!
3. 3x slower than hand write code

Example 3:

```C#
// LinqExample
for (int n = 0; n < Iterations; n++)
{
    int p1 = n;
    int p2 = n;
    int p3 = n;
    int p4 = n;

    var result = collection
        .Where(i => i != p1)
        .Where(i => i != p2)
        .Where(i => i != p3)
        .Where(i => i != p4);

    foreach (var item in result)
    {
        preventOptimize |= item;
    }
}
```

and optimized with new API:

```C#
// EvenBetterLowCostLinqExample
for (int n = 0; n < Iterations; n++)
{
    int p1 = n;
    int p2 = n;
    int p3 = n;
    int p4 = n;

    var result = collection.AsLowCostLinq()
        .Where(p1, (param, i) => i != param) // delegate is not allocated and closure is not allocated every times
        .Where(p2, (param, i) => i != param)
        .Where(p3, (param, i) => i != param)
        .Where(p4, (param, i) => i != param);

    foreach (var item in result)
    {
        preventOptimize |= item;
    }
}
```

Performance test results:

``` ini
BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error | Scaled |     Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-------:|----------:|----------:|
|                   **LinqExample** | 14,354.8 us | 13.8292 us |  18.16 | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 10,168.0 us |  5.6586 us |  12.86 |  671.8750 | 2880000 B |
|  **EvenBetterLowCostLinqExample** | 10,921.9 us |  2.0310 us |  13.82 |         - |       0 B |
|            BestLowCostLinqExample |  2,951.8 us | 16.7860 us |   3.73 |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  5,994.3 us |  2.0709 us |   7.58 |         - |       0 B |
|               NearOptimalSolution |    790.5 us |  0.6989 us |   1.00 |         - |       0 B |

As we can see with new API we can reduce number of delegate allocation to zero.

Requirments to compile and use all API:
- .Net 4.7.1 or dotnetcore 2.0 with all updates
- Visual Studio at least 15.5

Warning! Library is not yet finished. Not all LINQ methods is implemented yet. Not all implemented method is fully tested. Not all method currently achive full performance.
In some situations performance can be worse than in LINQ, some times I can not force jitter to generate efficient code. Performance problem with current version jitter is the one of reasons that code in library is so bloated. Mayby future version of .net jitter will generate better code. There are some signs that it will be better.
Some functionality can not be implemented without massive duplication of code due to not sufficent C# language support, for example, my main problem was method inference.

Because library code is bloated there is some risk that performance in real world will not be as great as we see in synthetic benchmark. Instruction cache in CPU can be affected, due to much more instruction will be generated. Size of library will increase. Jitting code will take much long time. Play with carefull, and always profile performance.

During work on LowCostLinq library I encounter many problems, some of them already was reported:

- https://github.com/dotnet/csharplang/issues/997 
- https://github.com/dotnet/coreclr/issues/14890
- https://github.com/dotnet/coreclr/issues/9908
- https://github.com/dotnet/coreclr/issues/1133
- https://github.com/dotnet/coreclr/issues/5996
- https://github.com/dotnet/coreclr/issues/4331
- https://github.com/dotnet/coreclr/issues/2591
- https://github.com/dotnet/roslyn/issues/10378
