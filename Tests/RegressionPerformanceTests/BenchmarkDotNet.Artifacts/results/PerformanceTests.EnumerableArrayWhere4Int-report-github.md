``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **112.51 ns** |   **0.0283 ns** |     **0.0237 ns** |    **112.52 ns** | **10.03** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     43.73 ns |   0.0653 ns |     0.0611 ns |     43.69 ns |  3.90 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     49.56 ns |   0.0170 ns |     0.0133 ns |     49.56 ns |  4.42 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     69.90 ns |   0.0109 ns |     0.0085 ns |     69.90 ns |  6.23 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     72.34 ns |   0.2481 ns |     0.2071 ns |     72.25 ns |  6.45 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |     53.71 ns |   0.0104 ns |     0.0081 ns |     53.71 ns |  4.79 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     55.28 ns |   0.0130 ns |     0.0115 ns |     55.27 ns |  4.93 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    120.17 ns |   0.0258 ns |     0.0229 ns |    120.17 ns | 10.71 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    121.95 ns |   0.1218 ns |     0.1139 ns |    121.95 ns | 10.87 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    111.87 ns |   1.0588 ns |     0.9386 ns |    111.63 ns |  9.96 |    0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    112.50 ns |   1.9639 ns |     1.8370 ns |    111.15 ns | 10.05 |    0.17 |
|                                                 LinqCount |            [0] |    112.53 ns |   0.0345 ns |     0.0288 ns |    112.53 ns | 10.03 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     42.11 ns |   0.0592 ns |     0.0524 ns |     42.09 ns |  3.75 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     41.82 ns |   0.5200 ns |     0.4864 ns |     41.89 ns |  3.73 |    0.05 |
|                           LowCostLinqWithStructWhereCount |            [0] |     45.85 ns |   0.0150 ns |     0.0117 ns |     45.84 ns |  4.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     46.05 ns |   0.0052 ns |     0.0046 ns |     46.05 ns |  4.11 |    0.00 |
|                                               LinqToArray |            [0] |    127.19 ns |   0.0472 ns |     0.0442 ns |    127.17 ns | 11.34 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     51.89 ns |   0.0337 ns |     0.0315 ns |     51.88 ns |  4.63 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     51.08 ns |   0.0139 ns |     0.0116 ns |     51.09 ns |  4.55 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     55.03 ns |   0.9950 ns |     0.9308 ns |     54.46 ns |  4.92 |    0.09 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     55.92 ns |   0.0470 ns |     0.0416 ns |     55.91 ns |  4.99 |    0.00 |
|                                                      Take |            [0] |    148.46 ns |   0.2813 ns |     0.2493 ns |    148.32 ns | 13.24 |    0.02 |
|                                               LowCostTake |            [0] |     56.12 ns |   0.5329 ns |     0.4985 ns |     55.75 ns |  5.01 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [0] |     57.09 ns |   0.0160 ns |     0.0125 ns |     57.08 ns |  5.09 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     67.59 ns |   0.0033 ns |     0.0026 ns |     67.59 ns |  6.03 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     67.62 ns |   0.0042 ns |     0.0035 ns |     67.62 ns |  6.03 |    0.00 |
|                                            SkipTakeSingle |            [0] |    173.98 ns |   3.3837 ns |     3.4748 ns |    172.38 ns | 15.59 |    0.31 |
|                                     LowCostSkipTakeSingle |            [0] |     76.93 ns |   0.0201 ns |     0.0157 ns |     76.92 ns |  6.86 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     76.17 ns |   0.0981 ns |     0.0869 ns |     76.16 ns |  6.79 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     79.33 ns |   0.1948 ns |     0.1726 ns |     79.25 ns |  7.07 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     79.95 ns |   0.9512 ns |     0.8897 ns |     79.36 ns |  7.14 |    0.08 |
|                                           ForeachDelegate |            [0] |     14.57 ns |   0.0067 ns |     0.0060 ns |     14.57 ns |  1.30 |    0.00 |
|                                                   Foreach |            [0] |     11.22 ns |   0.0038 ns |     0.0032 ns |     11.21 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **13,331.31 ns** | **261.5286 ns** |   **478.2199 ns** | **13,336.32 ns** |  **3.13** |    **0.11** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,737.87 ns | 320.0607 ns |   938.6826 ns | 11,806.17 ns |  2.63 |    0.17 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 11,887.03 ns | 233.6236 ns |   461.1501 ns | 11,898.67 ns |  2.75 |    0.08 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,819.86 ns | 245.5725 ns |   720.2217 ns | 11,694.89 ns |  2.76 |    0.10 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 13,573.34 ns | 269.3779 ns |   714.3519 ns | 13,524.36 ns |  3.08 |    0.11 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,738.28 ns |   3.1464 ns |     2.9431 ns |  1,736.57 ns |  0.40 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,566.33 ns |   0.6449 ns |     0.5717 ns |  1,566.25 ns |  0.36 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 24,831.85 ns | 495.3579 ns | 1,304.9707 ns | 25,105.73 ns |  5.72 |    0.35 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 24,525.22 ns | 487.6425 ns | 1,149.4307 ns | 24,073.74 ns |  5.69 |    0.21 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,634.85 ns | 138.5519 ns |   129.6015 ns |  8,661.24 ns |  2.00 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,042.95 ns |   2.8512 ns |     2.5275 ns |  8,043.91 ns |  1.86 |    0.00 |
|                                                 LinqCount |         [1000] |  8,877.16 ns |  60.5939 ns |    47.3078 ns |  8,890.43 ns |  2.05 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,499.23 ns | 207.3084 ns |   467.9296 ns | 10,608.30 ns |  2.44 |    0.11 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 12,522.72 ns | 317.3260 ns |   935.6429 ns | 12,607.88 ns |  2.94 |    0.16 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,385.48 ns |  10.1167 ns |     9.4632 ns |  1,379.23 ns |  0.32 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,368.71 ns |   3.9707 ns |     3.5199 ns |  1,368.72 ns |  0.32 |    0.00 |
|                                               LinqToArray |         [1000] | 10,841.60 ns |  40.3392 ns |    37.7333 ns | 10,848.16 ns |  2.51 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 12,170.85 ns |  65.2075 ns |    60.9952 ns | 12,153.89 ns |  2.82 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 12,143.14 ns |  46.6729 ns |    41.3743 ns | 12,146.28 ns |  2.81 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,481.60 ns |   6.0522 ns |     5.3652 ns |  2,482.15 ns |  0.57 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,472.65 ns |   2.0606 ns |     1.8267 ns |  2,473.07 ns |  0.57 |    0.00 |
|                                                      Take |         [1000] |    513.24 ns |   3.9946 ns |     3.7365 ns |    511.36 ns |  0.12 |    0.00 |
|                                               LowCostTake |         [1000] |    339.28 ns |   6.5769 ns |     9.0025 ns |    340.68 ns |  0.08 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    286.42 ns |   5.6764 ns |     7.9575 ns |    283.50 ns |  0.07 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    121.98 ns |   0.1333 ns |     0.1113 ns |    121.97 ns |  0.03 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    111.73 ns |   0.0294 ns |     0.0246 ns |    111.73 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    426.55 ns |   6.3824 ns |     5.6579 ns |    423.86 ns |  0.10 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    610.61 ns |   6.8546 ns |     6.4118 ns |    612.78 ns |  0.14 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    375.57 ns |   8.1662 ns |    23.8212 ns |    370.82 ns |  0.09 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    156.37 ns |   0.1286 ns |     0.1203 ns |    156.34 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    146.31 ns |   0.2534 ns |     0.2371 ns |    146.16 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,678.02 ns | 116.7594 ns |   109.2168 ns |  9,615.53 ns |  2.24 |    0.03 |
|                                                   Foreach |         [1000] |  4,321.32 ns |   2.9793 ns |     2.7868 ns |  4,321.37 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **775.08 ns** |   **2.5332 ns** |     **2.3696 ns** |    **774.95 ns** |  **3.27** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    628.22 ns |  16.5341 ns |    48.2307 ns |    622.86 ns |  2.52 |    0.12 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    669.52 ns |  16.4216 ns |    48.4195 ns |    670.31 ns |  2.82 |    0.20 |
|                                  LowCostLinqWithDelegate2 |           [50] |    633.38 ns |  15.8802 ns |    20.6488 ns |    625.17 ns |  2.70 |    0.11 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    718.57 ns |   7.0050 ns |     6.2097 ns |    719.44 ns |  3.03 |    0.03 |
|                                LowCostLinqWithStructWhere |           [50] |    145.24 ns |   0.1540 ns |     0.1365 ns |    145.24 ns |  0.61 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    139.50 ns |   0.8535 ns |     0.7127 ns |    139.30 ns |  0.59 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,538.66 ns |  44.2530 ns |   127.6800 ns |  1,600.45 ns |  6.78 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,353.89 ns |  23.9596 ns |    22.4119 ns |  1,352.55 ns |  5.71 |    0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    544.52 ns |   1.3580 ns |     1.2703 ns |    544.79 ns |  2.30 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    530.24 ns |  10.5767 ns |    10.3878 ns |    531.05 ns |  2.25 |    0.04 |
|                                                 LinqCount |           [50] |    559.32 ns |   2.4298 ns |     2.2728 ns |    558.31 ns |  2.36 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    552.27 ns |  11.0682 ns |    26.9416 ns |    555.93 ns |  2.41 |    0.09 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    657.12 ns |  18.2258 ns |    53.4532 ns |    652.73 ns |  2.70 |    0.17 |
|                           LowCostLinqWithStructWhereCount |           [50] |    107.89 ns |   0.2312 ns |     0.2162 ns |    108.00 ns |  0.46 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    106.94 ns |   0.2422 ns |     0.2023 ns |    106.83 ns |  0.45 |    0.00 |
|                                               LinqToArray |           [50] |    865.77 ns |   1.6040 ns |     1.5004 ns |    866.29 ns |  3.66 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    777.52 ns |   4.9675 ns |     3.8783 ns |    778.66 ns |  3.28 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    778.01 ns |  15.8509 ns |    18.8694 ns |    769.06 ns |  3.29 |    0.09 |
|                              LowCostLinqWithStructToArray |           [50] |    235.21 ns |   0.0437 ns |     0.0341 ns |    235.21 ns |  0.99 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    235.14 ns |   0.3509 ns |     0.3111 ns |    235.00 ns |  0.99 |    0.00 |
|                                                      Take |           [50] |    511.45 ns |   2.5542 ns |     2.3892 ns |    510.35 ns |  2.16 |    0.01 |
|                                               LowCostTake |           [50] |    331.61 ns |   8.4483 ns |    24.5100 ns |    325.38 ns |  1.37 |    0.06 |
|                                  LowCostTakeWithoutChecks |           [50] |    311.65 ns |   7.2562 ns |    20.8193 ns |    312.79 ns |  1.32 |    0.08 |
|                                     LowCostTakeWithStruct |           [50] |    118.77 ns |   0.1083 ns |     0.1013 ns |    118.80 ns |  0.50 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    112.77 ns |   0.0079 ns |     0.0066 ns |    112.77 ns |  0.48 |    0.00 |
|                                            SkipTakeSingle |           [50] |    432.23 ns |   1.0591 ns |     0.9907 ns |    432.05 ns |  1.82 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    365.48 ns |   7.0814 ns |    10.1559 ns |    366.91 ns |  1.53 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    495.00 ns |  37.6419 ns |   110.9879 ns |    572.97 ns |  2.18 |    0.47 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    156.39 ns |   0.1966 ns |     0.1839 ns |    156.30 ns |  0.66 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    145.84 ns |   0.0770 ns |     0.0721 ns |    145.83 ns |  0.62 |    0.00 |
|                                           ForeachDelegate |           [50] |    505.76 ns |   0.1504 ns |     0.1333 ns |    505.70 ns |  2.14 |    0.00 |
|                                                   Foreach |           [50] |    236.88 ns |   0.0784 ns |     0.0695 ns |    236.87 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **184.85 ns** |   **0.0739 ns** |     **0.0691 ns** |    **184.83 ns** |  **5.39** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    113.58 ns |   2.4310 ns |     7.1679 ns |    117.39 ns |  3.38 |    0.14 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    110.20 ns |   2.2057 ns |     3.7455 ns |    111.81 ns |  3.25 |    0.10 |
|                                  LowCostLinqWithDelegate2 |            [5] |    150.02 ns |   3.4561 ns |    10.1361 ns |    145.80 ns |  4.37 |    0.32 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    147.73 ns |   2.9462 ns |     5.0029 ns |    149.30 ns |  4.22 |    0.16 |
|                                LowCostLinqWithStructWhere |            [5] |     65.43 ns |   0.0148 ns |     0.0124 ns |     65.43 ns |  1.91 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     62.81 ns |   0.8056 ns |     0.7536 ns |     63.22 ns |  1.83 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    248.90 ns |   0.2485 ns |     0.2325 ns |    248.91 ns |  7.26 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    249.97 ns |   0.3772 ns |     0.3529 ns |    250.11 ns |  7.29 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    154.07 ns |   0.0460 ns |     0.0430 ns |    154.08 ns |  4.49 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    151.71 ns |   0.5635 ns |     0.4995 ns |    151.45 ns |  4.42 |    0.02 |
|                                                 LinqCount |            [5] |    163.84 ns |   0.0892 ns |     0.0790 ns |    163.82 ns |  4.78 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     99.12 ns |   1.9970 ns |     5.5337 ns |    100.48 ns |  2.81 |    0.19 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     96.68 ns |   1.9593 ns |     3.1076 ns |     97.14 ns |  2.83 |    0.10 |
|                           LowCostLinqWithStructWhereCount |            [5] |     48.83 ns |   0.0154 ns |     0.0144 ns |     48.83 ns |  1.42 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     49.27 ns |   0.2305 ns |     0.2156 ns |     49.30 ns |  1.44 |    0.01 |
|                                               LinqToArray |            [5] |    228.21 ns |   0.0571 ns |     0.0506 ns |    228.20 ns |  6.65 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    135.84 ns |   0.1628 ns |     0.1522 ns |    135.87 ns |  3.96 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    141.13 ns |   0.1924 ns |     0.1800 ns |    141.13 ns |  4.11 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     92.88 ns |   1.8351 ns |     1.7166 ns |     91.51 ns |  2.71 |    0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     93.45 ns |   1.1716 ns |     1.0386 ns |     93.31 ns |  2.72 |    0.03 |
|                                                      Take |            [5] |    258.85 ns |   0.4168 ns |     0.3695 ns |    258.70 ns |  7.55 |    0.02 |
|                                               LowCostTake |            [5] |    134.83 ns |   2.9049 ns |     8.5651 ns |    131.75 ns |  4.06 |    0.19 |
|                                  LowCostTakeWithoutChecks |            [5] |    115.96 ns |   2.3334 ns |     4.5511 ns |    116.02 ns |  3.31 |    0.13 |
|                                     LowCostTakeWithStruct |            [5] |     81.08 ns |   0.3326 ns |     0.3111 ns |     81.12 ns |  2.36 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     83.06 ns |   0.8126 ns |     0.7601 ns |     82.43 ns |  2.42 |    0.02 |
|                                            SkipTakeSingle |            [5] |    241.94 ns |   1.3027 ns |     1.2186 ns |    242.24 ns |  7.05 |    0.03 |
|                                     LowCostSkipTakeSingle |            [5] |    144.45 ns |   2.8841 ns |     7.1288 ns |    145.52 ns |  4.12 |    0.17 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    148.99 ns |   3.0022 ns |     5.9956 ns |    149.79 ns |  4.33 |    0.17 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     91.80 ns |   0.1713 ns |     0.1602 ns |     91.73 ns |  2.68 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     91.03 ns |   0.2079 ns |     0.1843 ns |     90.93 ns |  2.65 |    0.01 |
|                                           ForeachDelegate |            [5] |     65.71 ns |   0.0310 ns |     0.0259 ns |     65.71 ns |  1.92 |    0.00 |
|                                                   Foreach |            [5] |     34.30 ns |   0.0581 ns |     0.0515 ns |     34.29 ns |  1.00 |    0.00 |
