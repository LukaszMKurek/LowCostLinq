``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |          Mean |      Error |     StdDev |  Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|--------:|
|                                                      **Linq** |            **[0]** |    **48.8515 ns** |  **0.0185 ns** |  **0.0155 ns** | **149.86** |    **0.25** |
|                                   LowCostLinqWithDelegate |            [0] |    17.9607 ns |  0.0005 ns |  0.0004 ns |  55.10 |    0.09 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    10.8460 ns |  0.0033 ns |  0.0031 ns |  33.27 |    0.06 |
|                                  LowCostLinqWithDelegate2 |            [0] |    31.4241 ns |  0.0009 ns |  0.0008 ns |  96.40 |    0.16 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    28.7226 ns |  0.0009 ns |  0.0008 ns |  88.11 |    0.14 |
|                                LowCostLinqWithStructWhere |            [0] |    25.1420 ns |  0.0008 ns |  0.0008 ns |  77.12 |    0.13 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    20.6995 ns |  0.0041 ns |  0.0039 ns |  63.50 |    0.10 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    31.1036 ns |  0.0360 ns |  0.0337 ns |  95.43 |    0.20 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    27.1820 ns |  0.0083 ns |  0.0073 ns |  83.39 |    0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    28.1693 ns |  0.0322 ns |  0.0302 ns |  86.41 |    0.16 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    25.3870 ns |  0.0065 ns |  0.0054 ns |  77.88 |    0.13 |
|                                                 LinqCount |            [0] |    46.8403 ns |  0.0056 ns |  0.0049 ns | 143.69 |    0.23 |
|                              LowCostLinqWithDelegateCount |            [0] |     5.9048 ns |  0.0007 ns |  0.0006 ns |  18.11 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     5.6731 ns |  0.0058 ns |  0.0052 ns |  17.41 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |    13.9752 ns |  0.0037 ns |  0.0035 ns |  42.87 |    0.07 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    13.9611 ns |  0.0007 ns |  0.0006 ns |  42.83 |    0.07 |
|                                               LinqToArray |            [0] |    47.0194 ns |  0.0151 ns |  0.0133 ns | 144.24 |    0.23 |
|                            LowCostLinqWithDelegateToArray |            [0] |     8.5700 ns |  0.0035 ns |  0.0033 ns |  26.29 |    0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     7.8503 ns |  0.0142 ns |  0.0133 ns |  24.09 |    0.06 |
|                              LowCostLinqWithStructToArray |            [0] |    16.2760 ns |  0.0217 ns |  0.0203 ns |  49.94 |    0.11 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    16.1266 ns |  0.0033 ns |  0.0031 ns |  49.47 |    0.08 |
|                                                      Take |            [0] |    70.9601 ns |  0.0149 ns |  0.0132 ns | 217.68 |    0.37 |
|                                               LowCostTake |            [0] |    23.3631 ns |  0.0029 ns |  0.0027 ns |  71.67 |    0.12 |
|                                  LowCostTakeWithoutChecks |            [0] |    18.3717 ns |  0.0036 ns |  0.0034 ns |  56.36 |    0.09 |
|                                     LowCostTakeWithStruct |            [0] |    32.6340 ns |  0.0018 ns |  0.0016 ns | 100.11 |    0.16 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    27.5485 ns |  0.0014 ns |  0.0012 ns |  84.51 |    0.14 |
|                                            SkipTakeSingle |            [0] |    90.2927 ns |  0.0181 ns |  0.0142 ns | 277.00 |    0.46 |
|                                     LowCostSkipTakeSingle |            [0] |    23.9668 ns |  0.0024 ns |  0.0022 ns |  73.52 |    0.12 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    24.1038 ns |  0.0222 ns |  0.0208 ns |  73.93 |    0.14 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    32.7868 ns |  0.0009 ns |  0.0008 ns | 100.58 |    0.16 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    32.5578 ns |  0.0017 ns |  0.0015 ns |  99.87 |    0.16 |
|                                           ForeachDelegate |            [0] |     2.6197 ns |  0.0005 ns |  0.0004 ns |   8.04 |    0.01 |
|                                                   Foreach |            [0] |     0.9914 ns |  0.0011 ns |  0.0010 ns |   3.04 |    0.01 |
|                                                       For |            [0] |     0.3260 ns |  0.0006 ns |  0.0005 ns |   1.00 |    0.00 |
|                                                           |                |               |            |            |        |         |
|                                                      **Linq** |         **[1000]** | **8,206.9294 ns** |  **4.0284 ns** |  **3.3639 ns** |  **33.08** |    **0.01** |
|                                   LowCostLinqWithDelegate |         [1000] | 4,353.4622 ns |  0.8931 ns |  0.7917 ns |  17.55 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 4,054.1718 ns | 72.0469 ns | 63.8677 ns |  16.34 |    0.26 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 4,124.2685 ns |  1.2273 ns |  1.1480 ns |  16.62 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 4,121.8061 ns |  1.5823 ns |  1.4800 ns |  16.61 |    0.01 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,547.6086 ns |  0.4612 ns |  0.4314 ns |   6.24 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,289.5777 ns |  1.4647 ns |  1.2984 ns |   5.20 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 7,418.9665 ns |  1.3833 ns |  1.2262 ns |  29.90 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 6,487.5035 ns |  0.9905 ns |  0.8781 ns |  26.15 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 4,028.1621 ns |  1.2514 ns |  1.0450 ns |  16.24 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,925.1150 ns |  1.6781 ns |  1.4876 ns |  15.82 |    0.01 |
|                                                 LinqCount |         [1000] | 4,119.7117 ns |  2.9070 ns |  2.5770 ns |  16.60 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,830.5999 ns |  0.5043 ns |  0.4718 ns |  15.44 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 3,701.3508 ns |  0.1969 ns |  0.1745 ns |  14.92 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   503.7125 ns |  0.1429 ns |  0.1267 ns |   2.03 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   498.8876 ns |  0.3868 ns |  0.3429 ns |   2.01 |    0.00 |
|                                               LinqToArray |         [1000] | 5,722.6068 ns |  4.4346 ns |  3.9312 ns |  23.07 |    0.02 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 5,015.7214 ns |  2.7762 ns |  2.3183 ns |  20.22 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 4,789.5275 ns |  2.6698 ns |  2.3667 ns |  19.30 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,608.3858 ns |  0.4443 ns |  0.3710 ns |   6.48 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,515.7659 ns |  0.7026 ns |  0.6228 ns |   6.11 |    0.00 |
|                                                      Take |         [1000] |   319.7541 ns |  0.0864 ns |  0.0766 ns |   1.29 |    0.00 |
|                                               LowCostTake |         [1000] |   106.8565 ns |  0.0123 ns |  0.0103 ns |   0.43 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |   103.1491 ns |  0.0151 ns |  0.0141 ns |   0.42 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    68.4946 ns |  0.0493 ns |  0.0461 ns |   0.28 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    57.8019 ns |  0.0767 ns |  0.0680 ns |   0.23 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   244.3575 ns |  0.0503 ns |  0.0446 ns |   0.98 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   108.5940 ns |  0.0203 ns |  0.0180 ns |   0.44 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   103.7743 ns |  0.0233 ns |  0.0218 ns |   0.42 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    60.3339 ns |  0.0847 ns |  0.0792 ns |   0.24 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    57.6155 ns |  0.0394 ns |  0.0369 ns |   0.23 |    0.00 |
|                                           ForeachDelegate |         [1000] | 3,345.3068 ns |  2.6041 ns |  2.4359 ns |  13.48 |    0.01 |
|                                                   Foreach |         [1000] |   484.5938 ns |  0.0764 ns |  0.0596 ns |   1.95 |    0.00 |
|                                                       For |         [1000] |   248.1069 ns |  0.0094 ns |  0.0088 ns |   1.00 |    0.00 |
|                                                           |                |               |            |            |        |         |
|                                                      **Linq** |           **[50]** |   **462.5668 ns** |  **0.3617 ns** |  **0.3383 ns** |  **31.87** |    **0.09** |
|                                   LowCostLinqWithDelegate |           [50] |   234.8066 ns |  0.2057 ns |  0.1924 ns |  16.18 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   215.4493 ns |  0.5075 ns |  0.4748 ns |  14.84 |    0.06 |
|                                  LowCostLinqWithDelegate2 |           [50] |   234.3557 ns |  0.0124 ns |  0.0110 ns |  16.14 |    0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   230.5082 ns |  0.1669 ns |  0.1561 ns |  15.88 |    0.05 |
|                                LowCostLinqWithStructWhere |           [50] |   107.4473 ns |  0.0276 ns |  0.0245 ns |   7.40 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    89.5122 ns |  0.0263 ns |  0.0246 ns |   6.17 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   425.5192 ns |  0.1066 ns |  0.0945 ns |  29.31 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   368.8953 ns |  0.1076 ns |  0.0954 ns |  25.41 |    0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   253.2659 ns |  0.0362 ns |  0.0321 ns |  17.45 |    0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   227.0977 ns |  0.1778 ns |  0.1663 ns |  15.64 |    0.04 |
|                                                 LinqCount |           [50] |   256.1461 ns |  0.1597 ns |  0.1415 ns |  17.65 |    0.05 |
|                              LowCostLinqWithDelegateCount |           [50] |   205.6528 ns |  0.1476 ns |  0.1380 ns |  14.17 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   193.0884 ns |  0.0629 ns |  0.0588 ns |  13.30 |    0.04 |
|                           LowCostLinqWithStructWhereCount |           [50] |    39.2537 ns |  0.0664 ns |  0.0622 ns |   2.70 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    39.5015 ns |  0.0374 ns |  0.0292 ns |   2.72 |    0.01 |
|                                               LinqToArray |           [50] |   410.4896 ns |  0.4183 ns |  0.3913 ns |  28.28 |    0.08 |
|                            LowCostLinqWithDelegateToArray |           [50] |   306.6668 ns |  0.3539 ns |  0.3310 ns |  21.13 |    0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   288.6263 ns |  0.5029 ns |  0.4704 ns |  19.88 |    0.06 |
|                              LowCostLinqWithStructToArray |           [50] |   134.0596 ns |  0.0332 ns |  0.0277 ns |   9.24 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   135.6987 ns |  0.1039 ns |  0.0921 ns |   9.35 |    0.03 |
|                                                      Take |           [50] |   318.7780 ns |  0.0450 ns |  0.0375 ns |  21.97 |    0.06 |
|                                               LowCostTake |           [50] |   107.1376 ns |  0.0387 ns |  0.0362 ns |   7.38 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |   103.9262 ns |  0.0440 ns |  0.0411 ns |   7.16 |    0.02 |
|                                     LowCostTakeWithStruct |           [50] |    69.4461 ns |  0.0094 ns |  0.0079 ns |   4.79 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    58.0395 ns |  0.1435 ns |  0.1342 ns |   4.00 |    0.01 |
|                                            SkipTakeSingle |           [50] |   244.1763 ns |  0.0516 ns |  0.0458 ns |  16.82 |    0.05 |
|                                     LowCostSkipTakeSingle |           [50] |   108.5486 ns |  0.0198 ns |  0.0186 ns |   7.48 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   104.1731 ns |  0.0441 ns |  0.0413 ns |   7.18 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    60.0092 ns |  0.0099 ns |  0.0077 ns |   4.13 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    58.1128 ns |  0.0085 ns |  0.0067 ns |   4.00 |    0.01 |
|                                           ForeachDelegate |           [50] |   178.7090 ns |  0.0112 ns |  0.0088 ns |  12.31 |    0.03 |
|                                                   Foreach |           [50] |    23.3045 ns |  0.0261 ns |  0.0244 ns |   1.61 |    0.00 |
|                                                       For |           [50] |    14.5163 ns |  0.0423 ns |  0.0396 ns |   1.00 |    0.00 |
|                                                           |                |               |            |            |        |         |
|                                                      **Linq** |            **[5]** |    **89.9497 ns** |  **0.0303 ns** |  **0.0269 ns** |  **43.85** |    **0.17** |
|                                   LowCostLinqWithDelegate |            [5] |    33.3528 ns |  0.0442 ns |  0.0413 ns |  16.26 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    28.6488 ns |  0.1020 ns |  0.0905 ns |  13.96 |    0.08 |
|                                  LowCostLinqWithDelegate2 |            [5] |    50.0119 ns |  0.0254 ns |  0.0237 ns |  24.38 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    45.3951 ns |  0.0193 ns |  0.0181 ns |  22.13 |    0.08 |
|                                LowCostLinqWithStructWhere |            [5] |    33.6296 ns |  0.0012 ns |  0.0010 ns |  16.39 |    0.06 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    28.2071 ns |  0.0065 ns |  0.0061 ns |  13.75 |    0.05 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    67.0791 ns |  0.0634 ns |  0.0593 ns |  32.70 |    0.11 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    62.6517 ns |  0.0580 ns |  0.0543 ns |  30.54 |    0.12 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    48.7559 ns |  0.0338 ns |  0.0316 ns |  23.77 |    0.09 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    42.8595 ns |  0.1291 ns |  0.1207 ns |  20.89 |    0.11 |
|                                                 LinqCount |            [5] |    65.7697 ns |  0.0858 ns |  0.0761 ns |  32.06 |    0.13 |
|                              LowCostLinqWithDelegateCount |            [5] |    24.2764 ns |  0.0194 ns |  0.0172 ns |  11.83 |    0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    22.1880 ns |  0.0147 ns |  0.0115 ns |  10.81 |    0.04 |
|                           LowCostLinqWithStructWhereCount |            [5] |    17.5878 ns |  0.0676 ns |  0.0599 ns |   8.57 |    0.04 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    16.2577 ns |  0.0027 ns |  0.0024 ns |   7.92 |    0.03 |
|                                               LinqToArray |            [5] |   100.1680 ns |  0.0948 ns |  0.0840 ns |  48.83 |    0.18 |
|                            LowCostLinqWithDelegateToArray |            [5] |    57.0647 ns |  0.0776 ns |  0.0726 ns |  27.82 |    0.10 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    54.3685 ns |  0.1780 ns |  0.1665 ns |  26.50 |    0.12 |
|                              LowCostLinqWithStructToArray |            [5] |    46.3348 ns |  0.0086 ns |  0.0077 ns |  22.59 |    0.09 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    48.3845 ns |  0.0743 ns |  0.0695 ns |  23.59 |    0.09 |
|                                                      Take |            [5] |   133.4689 ns |  0.0622 ns |  0.0520 ns |  65.03 |    0.25 |
|                                               LowCostTake |            [5] |    41.9686 ns |  0.0112 ns |  0.0105 ns |  20.46 |    0.08 |
|                                  LowCostTakeWithoutChecks |            [5] |    36.6287 ns |  0.0250 ns |  0.0234 ns |  17.86 |    0.07 |
|                                     LowCostTakeWithStruct |            [5] |    41.4971 ns |  0.0016 ns |  0.0015 ns |  20.23 |    0.07 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    36.8256 ns |  0.0012 ns |  0.0011 ns |  17.95 |    0.07 |
|                                            SkipTakeSingle |            [5] |   127.3637 ns |  0.2776 ns |  0.2597 ns |  62.09 |    0.24 |
|                                     LowCostSkipTakeSingle |            [5] |    37.2312 ns |  0.0410 ns |  0.0384 ns |  18.15 |    0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    36.3425 ns |  0.0517 ns |  0.0459 ns |  17.72 |    0.07 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    38.1265 ns |  0.0023 ns |  0.0022 ns |  18.59 |    0.07 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    36.8289 ns |  0.0013 ns |  0.0012 ns |  17.95 |    0.07 |
|                                           ForeachDelegate |            [5] |    19.4938 ns |  0.4099 ns |  0.3834 ns |   9.50 |    0.20 |
|                                                   Foreach |            [5] |     4.1606 ns |  0.0114 ns |  0.0101 ns |   2.03 |    0.01 |
|                                                       For |            [5] |     2.0513 ns |  0.0080 ns |  0.0074 ns |   1.00 |    0.00 |
