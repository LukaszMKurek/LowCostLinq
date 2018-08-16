``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **86.40 ns** |   **0.0355 ns** |   **0.0314 ns** |   **5.83** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     40.48 ns |   0.0038 ns |   0.0034 ns |   2.73 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     32.59 ns |   0.0238 ns |   0.0222 ns |   2.20 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     62.76 ns |   0.5403 ns |   0.5054 ns |   4.24 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     57.19 ns |   0.0034 ns |   0.0030 ns |   3.86 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     49.15 ns |   0.0031 ns |   0.0026 ns |   3.32 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     45.41 ns |   0.3735 ns |   0.3494 ns |   3.07 |     0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    100.32 ns |   0.0464 ns |   0.0411 ns |   6.77 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     91.17 ns |   0.0793 ns |   0.0741 ns |   6.15 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     87.47 ns |   0.0403 ns |   0.0357 ns |   5.90 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     79.14 ns |   0.0401 ns |   0.0375 ns |   5.34 |     0.00 |
|                                                 LinqCount |            [0] |     85.37 ns |   0.0478 ns |   0.0424 ns |   5.76 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     36.59 ns |   0.0114 ns |   0.0107 ns |   2.47 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     34.84 ns |   0.4116 ns |   0.3850 ns |   2.35 |     0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |     43.80 ns |   0.0028 ns |   0.0025 ns |   2.96 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     35.88 ns |   0.0035 ns |   0.0031 ns |   2.42 |     0.00 |
|                                               LinqToArray |            [0] |     97.12 ns |   0.0411 ns |   0.0344 ns |   6.56 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     47.93 ns |   0.0115 ns |   0.0107 ns |   3.23 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     46.08 ns |   0.0082 ns |   0.0077 ns |   3.11 |     0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     53.68 ns |   0.6192 ns |   0.5792 ns |   3.62 |     0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     45.61 ns |   0.0125 ns |   0.0104 ns |   3.08 |     0.00 |
|                                                      Take |            [0] |    120.30 ns |   0.1811 ns |   0.1605 ns |   8.12 |     0.01 |
|                                               LowCostTake |            [0] |     44.77 ns |   0.0050 ns |   0.0047 ns |   3.02 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     42.29 ns |   0.0576 ns |   0.0510 ns |   2.85 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     55.73 ns |   0.0017 ns |   0.0016 ns |   3.76 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     53.26 ns |   0.0100 ns |   0.0093 ns |   3.59 |     0.00 |
|                                            SkipTakeSingle |            [0] |    146.20 ns |   0.0672 ns |   0.0628 ns |   9.87 |     0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     54.82 ns |   0.0560 ns |   0.0524 ns |   3.70 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     54.05 ns |   0.0038 ns |   0.0033 ns |   3.65 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     65.37 ns |   0.0305 ns |   0.0285 ns |   4.41 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     58.08 ns |   0.6545 ns |   0.5802 ns |   3.92 |     0.04 |
|                                           ForeachDelegate |            [0] |     19.14 ns |   0.0112 ns |   0.0104 ns |   1.29 |     0.00 |
|                                                   Foreach |            [0] |     14.82 ns |   0.0049 ns |   0.0046 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |         **[1000]** | **12,367.68 ns** |  **12.4971 ns** |  **11.6898 ns** |   **2.33** |     **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] |  9,519.57 ns | 152.6031 ns | 142.7450 ns |   1.79 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,898.63 ns |   5.0075 ns |   4.6840 ns |   1.68 |     0.02 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,404.38 ns |   2.8666 ns |   2.6814 ns |   1.77 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  7,964.84 ns |   7.3138 ns |   6.1073 ns |   1.50 |     0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,693.38 ns |   2.9063 ns |   2.2690 ns |   0.51 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,755.18 ns |   0.5614 ns |   0.4977 ns |   0.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,829.61 ns |  74.2279 ns |  69.4328 ns |   4.49 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 21,529.42 ns |  38.4581 ns |  35.9737 ns |   4.05 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,118.12 ns | 102.5251 ns |  95.9020 ns |   1.72 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  7,995.45 ns |   5.2359 ns |   4.8977 ns |   1.51 |     0.01 |
|                                                 LinqCount |         [1000] |  6,810.11 ns |   4.7178 ns |   4.1822 ns |   1.28 |     0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,744.83 ns |  13.7667 ns |  12.2038 ns |   1.65 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,987.88 ns |   0.7028 ns |   0.5487 ns |   1.32 |     0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,745.07 ns |   1.3527 ns |   1.2653 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,224.38 ns |   0.5723 ns |   0.5354 ns |   0.23 |     0.00 |
|                                               LinqToArray |         [1000] |  8,276.54 ns | 147.1028 ns | 137.6000 ns |   1.56 |     0.03 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,698.61 ns |   5.3404 ns |   4.9954 ns |   1.83 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,745.66 ns |  10.2030 ns |   9.5439 ns |   1.65 |     0.02 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,232.79 ns |   4.7503 ns |   4.4434 ns |   0.61 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,410.41 ns |  34.7409 ns |  32.4967 ns |   0.45 |     0.01 |
|                                                      Take |         [1000] |    450.98 ns |   0.0805 ns |   0.0753 ns |   0.08 |     0.00 |
|                                               LowCostTake |         [1000] |    249.22 ns |   0.2508 ns |   0.2346 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    199.54 ns |   0.0095 ns |   0.0089 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    124.82 ns |   1.1561 ns |   1.0814 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     98.49 ns |   0.0137 ns |   0.0114 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    382.35 ns |   0.0747 ns |   0.0623 ns |   0.07 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    251.03 ns |   0.0304 ns |   0.0269 ns |   0.05 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    238.07 ns |   4.1589 ns |   3.8902 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    118.57 ns |   0.0379 ns |   0.0316 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     82.58 ns |   0.0031 ns |   0.0028 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |         [1000] |  9,145.43 ns |  20.4713 ns |  18.1473 ns |   1.72 |     0.02 |
|                                                   Foreach |         [1000] |  5,309.94 ns |  60.6346 ns |  53.7510 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |           **[50]** |    **701.61 ns** |   **0.3220 ns** |   **0.2514 ns** |   **2.45** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    506.18 ns |   0.0161 ns |   0.0134 ns |   1.77 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    464.96 ns |   0.0678 ns |   0.0601 ns |   1.62 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    539.72 ns |   0.0621 ns |   0.0485 ns |   1.89 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    453.17 ns |   0.3044 ns |   0.2847 ns |   1.58 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    188.86 ns |   0.0327 ns |   0.0306 ns |   0.66 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    140.49 ns |   1.3561 ns |   1.2685 ns |   0.49 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,302.69 ns |   1.2682 ns |   1.1863 ns |   4.55 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,178.51 ns |   1.8858 ns |   1.7640 ns |   4.12 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    543.29 ns |   0.1151 ns |   0.1020 ns |   1.90 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    483.51 ns |   0.2082 ns |   0.1947 ns |   1.69 |     0.00 |
|                                                 LinqCount |           [50] |    427.55 ns |   0.1908 ns |   0.1490 ns |   1.49 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    473.24 ns |   0.5519 ns |   0.5162 ns |   1.65 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    385.18 ns |   0.0441 ns |   0.0391 ns |   1.35 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    134.89 ns |   0.3269 ns |   0.2729 ns |   0.47 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     89.71 ns |   0.0049 ns |   0.0043 ns |   0.31 |     0.00 |
|                                               LinqToArray |           [50] |    689.12 ns |   0.6312 ns |   0.5595 ns |   2.41 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    653.34 ns |   0.2187 ns |   0.1939 ns |   2.28 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    579.10 ns |   2.1948 ns |   1.7136 ns |   2.02 |     0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    271.73 ns |   0.0597 ns |   0.0498 ns |   0.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    224.17 ns |   0.0972 ns |   0.0812 ns |   0.78 |     0.00 |
|                                                      Take |           [50] |    456.02 ns |   6.0358 ns |   5.6459 ns |   1.59 |     0.02 |
|                                               LowCostTake |           [50] |    249.53 ns |   0.0390 ns |   0.0365 ns |   0.87 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    203.22 ns |   0.1588 ns |   0.1326 ns |   0.71 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    125.41 ns |   0.0367 ns |   0.0343 ns |   0.44 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     98.20 ns |   1.1268 ns |   1.0540 ns |   0.34 |     0.00 |
|                                            SkipTakeSingle |           [50] |    382.48 ns |   0.1187 ns |   0.1052 ns |   1.34 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    254.74 ns |   0.0376 ns |   0.0294 ns |   0.89 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    235.60 ns |   0.0264 ns |   0.0206 ns |   0.82 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    118.50 ns |   0.4925 ns |   0.4365 ns |   0.41 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     83.82 ns |   0.0087 ns |   0.0077 ns |   0.29 |     0.00 |
|                                           ForeachDelegate |           [50] |    489.71 ns |   2.2488 ns |   2.1035 ns |   1.71 |     0.01 |
|                                                   Foreach |           [50] |    286.16 ns |   0.0555 ns |   0.0492 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |            **[5]** |    **150.27 ns** |   **2.3221 ns** |   **2.1721 ns** |   **3.69** |     **0.05** |
|                                   LowCostLinqWithDelegate |            [5] |     82.90 ns |   0.0381 ns |   0.0337 ns |   2.03 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     71.50 ns |   0.1319 ns |   0.1234 ns |   1.75 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    106.86 ns |   0.0572 ns |   0.0478 ns |   2.62 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     91.53 ns |   0.0916 ns |   0.0715 ns |   2.25 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     62.42 ns |   0.0461 ns |   0.0360 ns |   1.53 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     54.37 ns |   0.0127 ns |   0.0119 ns |   1.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    236.58 ns |   2.7753 ns |   2.5960 ns |   5.81 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    210.26 ns |   0.1039 ns |   0.0972 ns |   5.16 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    131.43 ns |   0.0375 ns |   0.0350 ns |   3.23 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    118.70 ns |   0.0513 ns |   0.0480 ns |   2.91 |     0.00 |
|                                                 LinqCount |            [5] |    123.56 ns |   1.8543 ns |   1.7345 ns |   3.03 |     0.04 |
|                              LowCostLinqWithDelegateCount |            [5] |     77.98 ns |   0.0444 ns |   0.0415 ns |   1.91 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     68.39 ns |   0.1706 ns |   0.1596 ns |   1.68 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     52.17 ns |   0.0190 ns |   0.0178 ns |   1.28 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     41.24 ns |   0.4328 ns |   0.4048 ns |   1.01 |     0.01 |
|                                               LinqToArray |            [5] |    177.31 ns |   0.0284 ns |   0.0251 ns |   4.35 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    122.65 ns |   0.2022 ns |   0.1892 ns |   3.01 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    115.88 ns |   0.0540 ns |   0.0451 ns |   2.84 |     0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     92.20 ns |   0.2305 ns |   0.2156 ns |   2.26 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     81.58 ns |   0.2556 ns |   0.2391 ns |   2.00 |     0.01 |
|                                                      Take |            [5] |    218.38 ns |   0.9050 ns |   0.8465 ns |   5.36 |     0.02 |
|                                               LowCostTake |            [5] |     88.05 ns |   0.0779 ns |   0.0608 ns |   2.16 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     76.82 ns |   0.1250 ns |   0.0976 ns |   1.89 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     82.01 ns |   0.0296 ns |   0.0276 ns |   2.01 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     64.10 ns |   0.0333 ns |   0.0312 ns |   1.57 |     0.00 |
|                                            SkipTakeSingle |            [5] |    198.10 ns |   0.0570 ns |   0.0533 ns |   4.86 |     0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     95.59 ns |   0.0450 ns |   0.0421 ns |   2.35 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     89.83 ns |   0.0676 ns |   0.0632 ns |   2.20 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     76.86 ns |   0.8997 ns |   0.8416 ns |   1.89 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     62.17 ns |   0.0071 ns |   0.0059 ns |   1.53 |     0.00 |
|                                           ForeachDelegate |            [5] |     64.86 ns |   0.0239 ns |   0.0212 ns |   1.59 |     0.00 |
|                                                   Foreach |            [5] |     40.75 ns |   0.0279 ns |   0.0261 ns |   1.00 |     0.00 |
