LowCostLinq is a library that deliver interface similar to LINQ but better performance.
===========================

Example LINQ expression:

```C#
var result = collection
	.Where(i => i != 0)
	.Select(i => i + 2)
	.Skip(16)
	.Take(32)
	.ToArray();
```

Can be optimized by adding invocation of extension method **AsLowCostLinq**:

```C#
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

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |      Mean |     Error |    StdDev |    Gen 0 | Allocated |
|---------------------------------- |----------:|----------:|----------:|---------:|----------:|
|                       **LinqExample** | 636.43 us | 1.0966 us | 0.9157 us | 158.2031 | 648.44 KB |
|                **LowCostLinqExample** | 411.18 us | 0.4115 us | 0.3436 us |  80.0781 | 328.13 KB |
|      EvenBetterLowCostLinqExample | 168.19 us | 0.1566 us | 0.1388 us |  80.0781 | 328.13 KB |
| NearOptimalSolutionUsingDelegates | 216.66 us | 0.0791 us | 0.0702 us |  81.7871 | 335.94 KB |
|               NearOptimalSolution |  49.57 us | 0.3881 us | 0.3631 us |  38.0859 | 156.25 KB |

For details look at **ExamplePerformanceTests** project.

In above results we can see that:
1. LINQ is several times worse than hand implementation (more than 10x lower and 4x more memory consume)
2. LINQ are much easier to write and much error prone
3. LowCostLinq is easy to use and it is noticable faster than LINQ (about 2x faster and 2x less memory allocation) when we use delegate
4. LowCostLinq can be even faster when we use new API (3x timest faster than LINQ)

Example 2:

```C#
var result = collection
		.Where(i => i != 0)
		.Where(i => i != 1)
		.Where(i => i != 2)
		.Where(i => i != 3)
		.First(i => i > SomeMagicNumber);
```					
and optimized with new API:

```C#
var result = collection.AsLowCostLinq()
		.Where(Item.AreNotEqualTo(0)) // instead delegate, this magic can be inlined during jitting
		.Where(Item.AreNotEqualTo(1))
		.Where(Item.AreNotEqualTo(2))
		.Where(Item.AreNotEqualTo(3))
		.First(i => i > SomeMagicNumber); // faster version is not yet implemented
```					
Performance results for this example:

``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |       Mean |      Error |     StdDev |    Gen 0 | Allocated |
|---------------------------------- |-----------:|-----------:|-----------:|---------:|----------:|
|                       **LinqExample** | 7,486.5 us |  6.7709 us |  6.3335 us | 109.3750 |  480000 B |
|                LowCostLinqExample | 6,856.0 us | 17.5388 us | 16.4058 us |        - |       0 B |
|      **EvenBetterLowCostLinqExample** | 1,587.9 us |  3.1845 us |  2.9787 us |        - |       0 B |
| NearOptimalSolutionUsingDelegates | 4,134.5 us | 43.8768 us | 41.0424 us |        - |       0 B |
|               NearOptimalSolution |   486.0 us |  0.8945 us |  0.8368 us |        - |       0 B |

We see that LowCostLinq:
1. 0 bytes allocated!
2. Performance is 5x times beter than LINQ and can be even better in future!
3. 3x slower than hand write code

Example 3:

```C#
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

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.192)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914061 Hz, Resolution=255.4891 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                            Method |        Mean |      Error |     StdDev |     Gen 0 | Allocated |
|---------------------------------- |------------:|-----------:|-----------:|----------:|----------:|
|                      ** LinqExample** | 14,384.6 us | 90.2034 us | 84.3763 us | 1828.1250 | 7680000 B |
|                LowCostLinqExample | 10,135.3 us |  2.8324 us |  2.6494 us |  671.8750 | 2880000 B |
|      **EvenBetterLowCostLinqExample** | 10,944.9 us | 20.1747 us | 18.8714 us |         - |       0 B |
|            BestLowCostLinqExample |  2,211.4 us |  1.4088 us |  1.2488 us |         - |       0 B |
| NearOptimalSolutionUsingDelegates |  6,000.1 us |  1.4933 us |  1.1659 us |         - |       0 B |
|               NearOptimalSolution |    790.1 us |  0.2530 us |  0.2366 us |         - |       0 B |

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
