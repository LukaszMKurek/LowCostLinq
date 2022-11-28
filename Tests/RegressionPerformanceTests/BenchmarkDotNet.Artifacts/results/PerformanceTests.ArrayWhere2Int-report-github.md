``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                       Method | CollectionSize |          Mean |     Error |    StdDev |  Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|----------:|----------:|-------:|--------:|
|                                         **Linq** |            **[0]** |    **35.4103 ns** | **0.0087 ns** | **0.0072 ns** | **124.14** |    **0.04** |
|                      LowCostLinqWithDelegate |            [0] |    11.0378 ns | 0.0011 ns | 0.0010 ns |  38.70 |    0.01 |
|                     LowCostLinqWithDelegate2 |            [0] |    27.0503 ns | 0.0012 ns | 0.0011 ns |  94.83 |    0.02 |
|                   LowCostLinqWithStructWhere |            [0] |    20.9382 ns | 0.0030 ns | 0.0028 ns |  73.41 |    0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    27.0038 ns | 0.0170 ns | 0.0159 ns |  94.68 |    0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    26.3549 ns | 0.0165 ns | 0.0138 ns |  92.39 |    0.05 |
|                                    LinqCount |            [0] |    32.7963 ns | 0.0816 ns | 0.0763 ns | 115.00 |    0.27 |
|                 LowCostLinqWithDelegateCount |            [0] |     5.6734 ns | 0.0004 ns | 0.0003 ns |  19.89 |    0.00 |
|              LowCostLinqWithStructWhereCount |            [0] |    13.9607 ns | 0.0009 ns | 0.0009 ns |  48.94 |    0.01 |
|                                  LinqToArray |            [0] |    35.1235 ns | 0.0158 ns | 0.0132 ns | 123.13 |    0.06 |
|               LowCostLinqWithDelegateToArray |            [0] |     7.7296 ns | 0.0092 ns | 0.0086 ns |  27.10 |    0.03 |
|                 LowCostLinqWithStructToArray |            [0] |    16.3474 ns | 0.0015 ns | 0.0014 ns |  57.31 |    0.01 |
|                                         Take |            [0] |    57.0375 ns | 0.0158 ns | 0.0140 ns | 199.96 |    0.06 |
|                                  LowCostTake |            [0] |    18.6166 ns | 0.0038 ns | 0.0036 ns |  65.26 |    0.02 |
|                        LowCostTakeWithStruct |            [0] |    26.8140 ns | 0.0013 ns | 0.0012 ns |  94.00 |    0.02 |
|                               SkipTakeSingle |            [0] |    75.3208 ns | 0.0108 ns | 0.0091 ns | 264.05 |    0.07 |
|                        LowCostSkipTakeSingle |            [0] |    23.0121 ns | 0.0074 ns | 0.0061 ns |  80.67 |    0.03 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    32.7454 ns | 0.0021 ns | 0.0019 ns | 114.80 |    0.03 |
|                              ForeachDelegate |            [0] |     1.6063 ns | 0.0006 ns | 0.0006 ns |   5.63 |    0.00 |
|                                      Foreach |            [0] |     0.5016 ns | 0.0055 ns | 0.0052 ns |   1.76 |    0.02 |
|                                          For |            [0] |     0.2852 ns | 0.0001 ns | 0.0001 ns |   1.00 |    0.00 |
|                                              |                |               |           |           |        |         |
|                                         **Linq** |         **[1000]** | **7,708.6268 ns** | **2.9285 ns** | **2.5960 ns** |  **31.12** |    **0.01** |
|                      LowCostLinqWithDelegate |         [1000] | 3,639.5599 ns | 1.8825 ns | 1.7609 ns |  14.69 |    0.01 |
|                     LowCostLinqWithDelegate2 |         [1000] | 4,125.5314 ns | 0.3215 ns | 0.2510 ns |  16.65 |    0.00 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,178.9742 ns | 6.3556 ns | 5.9450 ns |   4.76 |    0.03 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,487.6232 ns | 0.5193 ns | 0.4336 ns |  26.19 |    0.00 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,815.6319 ns | 1.7399 ns | 1.3584 ns |  15.40 |    0.01 |
|                                    LinqCount |         [1000] | 4,594.8863 ns | 4.6091 ns | 4.3114 ns |  18.55 |    0.02 |
|                 LowCostLinqWithDelegateCount |         [1000] | 3,344.0036 ns | 0.0683 ns | 0.0606 ns |  13.50 |    0.00 |
|              LowCostLinqWithStructWhereCount |         [1000] |   491.9483 ns | 0.0412 ns | 0.0386 ns |   1.99 |    0.00 |
|                                  LinqToArray |         [1000] | 5,484.3155 ns | 2.9070 ns | 2.5769 ns |  22.14 |    0.01 |
|               LowCostLinqWithDelegateToArray |         [1000] | 4,562.4960 ns | 3.5468 ns | 3.1442 ns |  18.42 |    0.01 |
|                 LowCostLinqWithStructToArray |         [1000] | 1,369.0108 ns | 0.5215 ns | 0.4355 ns |   5.53 |    0.00 |
|                                         Take |         [1000] |   314.8418 ns | 0.2008 ns | 0.1780 ns |   1.27 |    0.00 |
|                                  LowCostTake |         [1000] |    97.4670 ns | 0.0597 ns | 0.0559 ns |   0.39 |    0.00 |
|                        LowCostTakeWithStruct |         [1000] |    52.6567 ns | 0.0077 ns | 0.0069 ns |   0.21 |    0.00 |
|                               SkipTakeSingle |         [1000] |   226.6197 ns | 0.0750 ns | 0.0665 ns |   0.91 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |   106.1795 ns | 0.0365 ns | 0.0341 ns |   0.43 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    57.6395 ns | 0.0019 ns | 0.0014 ns |   0.23 |    0.00 |
|                              ForeachDelegate |         [1000] | 3,339.0663 ns | 0.2342 ns | 0.2076 ns |  13.48 |    0.00 |
|                                      Foreach |         [1000] |   247.8640 ns | 0.0253 ns | 0.0237 ns |   1.00 |    0.00 |
|                                          For |         [1000] |   247.7386 ns | 0.0050 ns | 0.0042 ns |   1.00 |    0.00 |
|                                              |                |               |           |           |        |         |
|                                         **Linq** |           **[50]** |   **444.1396 ns** | **0.3342 ns** | **0.2963 ns** |  **28.15** |    **0.25** |
|                      LowCostLinqWithDelegate |           [50] |   206.5137 ns | 0.1430 ns | 0.1268 ns |  13.09 |    0.11 |
|                     LowCostLinqWithDelegate2 |           [50] |   237.1771 ns | 0.2979 ns | 0.2640 ns |  15.03 |    0.13 |
|                   LowCostLinqWithStructWhere |           [50] |    90.1086 ns | 0.2348 ns | 0.2197 ns |   5.71 |    0.05 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   357.5058 ns | 0.1404 ns | 0.1245 ns |  22.66 |    0.20 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   215.5060 ns | 0.0602 ns | 0.0534 ns |  13.66 |    0.12 |
|                                    LinqCount |           [50] |   274.4986 ns | 0.0614 ns | 0.0544 ns |  17.40 |    0.15 |
|                 LowCostLinqWithDelegateCount |           [50] |   176.0486 ns | 0.0364 ns | 0.0340 ns |  11.16 |    0.09 |
|              LowCostLinqWithStructWhereCount |           [50] |    32.6069 ns | 0.0573 ns | 0.0508 ns |   2.07 |    0.02 |
|                                  LinqToArray |           [50] |   411.2453 ns | 0.3723 ns | 0.3109 ns |  26.07 |    0.24 |
|               LowCostLinqWithDelegateToArray |           [50] |   286.3333 ns | 0.3667 ns | 0.3430 ns |  18.15 |    0.15 |
|                 LowCostLinqWithStructToArray |           [50] |   136.6415 ns | 0.0435 ns | 0.0340 ns |   8.66 |    0.08 |
|                                         Take |           [50] |   312.4335 ns | 0.1353 ns | 0.1200 ns |  19.80 |    0.17 |
|                                  LowCostTake |           [50] |    97.4246 ns | 0.0209 ns | 0.0196 ns |   6.17 |    0.05 |
|                        LowCostTakeWithStruct |           [50] |    53.1926 ns | 0.0352 ns | 0.0329 ns |   3.37 |    0.03 |
|                               SkipTakeSingle |           [50] |   226.8172 ns | 0.1857 ns | 0.1737 ns |  14.37 |    0.13 |
|                        LowCostSkipTakeSingle |           [50] |   104.0270 ns | 0.0227 ns | 0.0212 ns |   6.59 |    0.05 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    58.1184 ns | 0.0047 ns | 0.0039 ns |   3.68 |    0.03 |
|                              ForeachDelegate |           [50] |   170.8850 ns | 0.0323 ns | 0.0252 ns |  10.83 |    0.10 |
|                                      Foreach |           [50] |    13.5582 ns | 0.0566 ns | 0.0502 ns |   0.86 |    0.01 |
|                                          For |           [50] |    15.7810 ns | 0.1397 ns | 0.1306 ns |   1.00 |    0.00 |
|                                              |                |               |           |           |        |         |
|                                         **Linq** |            **[5]** |    **82.0823 ns** | **0.1118 ns** | **0.1046 ns** |  **40.17** |    **0.06** |
|                      LowCostLinqWithDelegate |            [5] |    26.3295 ns | 0.0344 ns | 0.0287 ns |  12.89 |    0.02 |
|                     LowCostLinqWithDelegate2 |            [5] |    42.7166 ns | 0.0169 ns | 0.0141 ns |  20.91 |    0.02 |
|                   LowCostLinqWithStructWhere |            [5] |    26.9318 ns | 0.0006 ns | 0.0005 ns |  13.19 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    60.4449 ns | 0.0728 ns | 0.0681 ns |  29.59 |    0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    41.5730 ns | 0.0209 ns | 0.0185 ns |  20.35 |    0.02 |
|                                    LinqCount |            [5] |    67.2279 ns | 0.3666 ns | 0.3429 ns |  32.89 |    0.17 |
|                 LowCostLinqWithDelegateCount |            [5] |    21.6536 ns | 0.0187 ns | 0.0175 ns |  10.60 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [5] |    15.3899 ns | 0.0025 ns | 0.0024 ns |   7.53 |    0.01 |
|                                  LinqToArray |            [5] |    99.2447 ns | 0.0680 ns | 0.0603 ns |  48.59 |    0.04 |
|               LowCostLinqWithDelegateToArray |            [5] |    56.1997 ns | 0.3768 ns | 0.3525 ns |  27.51 |    0.18 |
|                 LowCostLinqWithStructToArray |            [5] |    43.9134 ns | 0.0048 ns | 0.0043 ns |  21.50 |    0.02 |
|                                         Take |            [5] |   127.4451 ns | 0.1860 ns | 0.1740 ns |  62.39 |    0.10 |
|                                  LowCostTake |            [5] |    35.1247 ns | 0.0897 ns | 0.0839 ns |  17.19 |    0.05 |
|                        LowCostTakeWithStruct |            [5] |    33.7826 ns | 0.0018 ns | 0.0015 ns |  16.54 |    0.01 |
|                               SkipTakeSingle |            [5] |   117.5537 ns | 0.0717 ns | 0.0636 ns |  57.55 |    0.07 |
|                        LowCostSkipTakeSingle |            [5] |    36.9525 ns | 0.0357 ns | 0.0334 ns |  18.09 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    37.4181 ns | 0.0012 ns | 0.0010 ns |  18.32 |    0.02 |
|                              ForeachDelegate |            [5] |    17.4646 ns | 0.2650 ns | 0.2479 ns |   8.55 |    0.13 |
|                                      Foreach |            [5] |     2.2160 ns | 0.0025 ns | 0.0021 ns |   1.08 |    0.00 |
|                                          For |            [5] |     2.0426 ns | 0.0023 ns | 0.0019 ns |   1.00 |    0.00 |
