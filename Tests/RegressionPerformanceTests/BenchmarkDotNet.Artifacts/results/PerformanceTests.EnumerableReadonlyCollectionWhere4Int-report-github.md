``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **142.39 ns** |   **0.1994 ns** |     **0.1767 ns** |    **142.41 ns** |  **7.92** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     55.10 ns |   0.0301 ns |     0.0267 ns |     55.09 ns |  3.07 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     56.50 ns |   0.0558 ns |     0.0436 ns |     56.49 ns |  3.14 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     81.24 ns |   0.0430 ns |     0.0402 ns |     81.25 ns |  4.52 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     81.00 ns |   0.0226 ns |     0.0200 ns |     81.00 ns |  4.51 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     65.58 ns |   0.0176 ns |     0.0156 ns |     65.58 ns |  3.65 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     65.85 ns |   0.0124 ns |     0.0097 ns |     65.85 ns |  3.66 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    137.71 ns |   0.0542 ns |     0.0507 ns |    137.69 ns |  7.66 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    135.89 ns |   0.0368 ns |     0.0344 ns |    135.88 ns |  7.56 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    127.80 ns |   0.0421 ns |     0.0373 ns |    127.80 ns |  7.11 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    123.72 ns |   0.0264 ns |     0.0234 ns |    123.72 ns |  6.88 |    0.00 |
|                                                 LinqCount |            [0] |    145.30 ns |   2.8712 ns |     3.0721 ns |    143.27 ns |  8.14 |    0.19 |
|                              LowCostLinqWithDelegateCount |            [0] |     58.84 ns |   0.0412 ns |     0.0385 ns |     58.83 ns |  3.27 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     56.17 ns |   0.0338 ns |     0.0316 ns |     56.16 ns |  3.13 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     58.21 ns |   1.0195 ns |     0.9536 ns |     57.67 ns |  3.25 |    0.06 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     57.13 ns |   0.0167 ns |     0.0139 ns |     57.12 ns |  3.18 |    0.00 |
|                                               LinqToArray |            [0] |    157.06 ns |   0.0656 ns |     0.0614 ns |    157.07 ns |  8.74 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     70.84 ns |   1.4357 ns |     1.4101 ns |     70.95 ns |  3.93 |    0.08 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     67.48 ns |   0.0333 ns |     0.0312 ns |     67.48 ns |  3.75 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     66.53 ns |   0.0147 ns |     0.0138 ns |     66.53 ns |  3.70 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     67.25 ns |   0.0230 ns |     0.0215 ns |     67.24 ns |  3.74 |    0.00 |
|                                                      Take |            [0] |    181.76 ns |   3.6323 ns |     3.8866 ns |    178.93 ns | 10.19 |    0.22 |
|                                               LowCostTake |            [0] |     68.59 ns |   0.0128 ns |     0.0107 ns |     68.59 ns |  3.82 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     68.18 ns |   0.0143 ns |     0.0134 ns |     68.18 ns |  3.79 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     78.77 ns |   0.0362 ns |     0.0338 ns |     78.77 ns |  4.38 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     83.53 ns |   1.1083 ns |     1.0367 ns |     83.01 ns |  4.66 |    0.06 |
|                                            SkipTakeSingle |            [0] |    202.30 ns |   0.0702 ns |     0.0586 ns |    202.30 ns | 11.26 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     91.59 ns |   0.1291 ns |     0.1207 ns |     91.55 ns |  5.10 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     92.24 ns |   1.5845 ns |     1.4821 ns |     91.28 ns |  5.12 |    0.09 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     95.14 ns |   0.0536 ns |     0.0475 ns |     95.15 ns |  5.29 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     93.71 ns |   0.0351 ns |     0.0328 ns |     93.70 ns |  5.21 |    0.00 |
|                                           ForeachDelegate |            [0] |     22.13 ns |   0.3789 ns |     0.3544 ns |     21.90 ns |  1.22 |    0.01 |
|                                                   Foreach |            [0] |     17.97 ns |   0.0045 ns |     0.0035 ns |     17.97 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **20,605.18 ns** | **407.7970 ns** |   **842.1715 ns** | **21,056.63 ns** |  **3.72** |    **0.16** |
|                                   LowCostLinqWithDelegate |         [1000] | 17,487.40 ns | 415.0083 ns | 1,210.5986 ns | 17,432.45 ns |  2.98 |    0.17 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 16,879.48 ns | 336.8662 ns |   710.5652 ns | 17,073.66 ns |  3.04 |    0.16 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 17,003.78 ns | 335.2565 ns |   637.8604 ns | 17,059.14 ns |  3.10 |    0.12 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 18,903.19 ns | 375.6110 ns |   808.5424 ns | 19,187.02 ns |  3.43 |    0.11 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,340.76 ns | 108.2429 ns |   101.2505 ns |  7,339.22 ns |  1.33 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,996.46 ns |   3.8715 ns |     3.6214 ns |  6,996.47 ns |  1.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 31,219.36 ns | 620.5694 ns | 1,634.8281 ns | 31,657.32 ns |  5.70 |    0.30 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 31,915.44 ns | 627.6520 ns | 1,416.7152 ns | 32,414.94 ns |  5.64 |    0.32 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 13,916.51 ns | 171.0578 ns |   160.0076 ns | 13,805.18 ns |  2.52 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 13,307.00 ns |   4.5829 ns |     4.0626 ns | 13,306.78 ns |  2.41 |    0.00 |
|                                                 LinqCount |         [1000] | 15,088.93 ns |  46.4587 ns |    43.4575 ns | 15,079.91 ns |  2.73 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 15,848.77 ns | 253.7508 ns |   211.8934 ns | 15,900.36 ns |  2.87 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 16,383.40 ns | 324.7715 ns |   677.9191 ns | 16,565.89 ns |  2.85 |    0.11 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,039.56 ns |   2.7299 ns |     2.5536 ns |  6,040.01 ns |  1.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,570.32 ns |   2.4279 ns |     1.8956 ns |  5,569.85 ns |  1.01 |    0.00 |
|                                               LinqToArray |         [1000] | 17,306.36 ns |  39.4234 ns |    34.9478 ns | 17,301.90 ns |  3.13 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 17,944.54 ns |  37.7509 ns |    35.3122 ns | 17,928.13 ns |  3.25 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 15,896.42 ns |  39.1043 ns |    36.5782 ns | 15,901.90 ns |  2.88 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,560.84 ns | 146.2924 ns |   136.8420 ns |  7,471.97 ns |  1.37 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,666.47 ns |  15.3247 ns |    14.3347 ns |  7,670.29 ns |  1.39 |    0.00 |
|                                                      Take |         [1000] |    653.29 ns |   1.9758 ns |     1.8482 ns |    652.66 ns |  0.12 |    0.00 |
|                                               LowCostTake |         [1000] |    437.99 ns |   8.6724 ns |    11.5774 ns |    429.33 ns |  0.08 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    412.79 ns |   2.2993 ns |     2.1508 ns |    412.77 ns |  0.07 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    232.48 ns |   0.0557 ns |     0.0494 ns |    232.48 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    233.33 ns |   3.0651 ns |     2.8671 ns |    231.25 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    590.01 ns |   0.2925 ns |     0.2593 ns |    590.04 ns |  0.11 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    474.68 ns |   9.1553 ns |    10.5433 ns |    478.45 ns |  0.09 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    447.28 ns |   4.8743 ns |     4.3210 ns |    445.35 ns |  0.08 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    275.29 ns |   4.5809 ns |     4.2850 ns |    275.93 ns |  0.05 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    268.73 ns |   0.0683 ns |     0.0639 ns |    268.74 ns |  0.05 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,959.10 ns |   2.8382 ns |     2.5160 ns | 10,958.77 ns |  1.98 |    0.00 |
|                                                   Foreach |         [1000] |  5,526.03 ns |   2.1879 ns |     1.9396 ns |  5,526.28 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |  **1,148.93 ns** |  **25.4512 ns** |    **37.3060 ns** |  **1,133.27 ns** |  **3.81** |    **0.14** |
|                                   LowCostLinqWithDelegate |           [50] |    850.24 ns |  16.8936 ns |    28.6866 ns |    838.84 ns |  2.76 |    0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    878.75 ns |  16.8076 ns |    14.0351 ns |    879.54 ns |  2.88 |    0.05 |
|                                  LowCostLinqWithDelegate2 |           [50] |    882.83 ns |   1.7119 ns |     1.3366 ns |    882.67 ns |  2.89 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    973.31 ns |  16.0443 ns |    15.0079 ns |    976.07 ns |  3.18 |    0.05 |
|                                LowCostLinqWithStructWhere |           [50] |    427.14 ns |   6.2924 ns |     5.5780 ns |    423.61 ns |  1.40 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    419.42 ns |   0.1560 ns |     0.1459 ns |    419.39 ns |  1.37 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,791.81 ns |  53.0745 ns |   156.4913 ns |  1,682.82 ns |  6.08 |    0.45 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,651.84 ns |  18.3217 ns |    17.1381 ns |  1,657.04 ns |  5.40 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    841.61 ns |  12.4888 ns |    11.6820 ns |    834.28 ns |  2.75 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    801.53 ns |   0.1517 ns |     0.1185 ns |    801.51 ns |  2.62 |    0.00 |
|                                                 LinqCount |           [50] |    902.30 ns |   3.7739 ns |     3.5301 ns |    903.25 ns |  2.95 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    889.43 ns |  25.0877 ns |    73.9716 ns |    848.11 ns |  3.02 |    0.23 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    845.93 ns |  16.4940 ns |    20.2561 ns |    847.46 ns |  2.77 |    0.07 |
|                           LowCostLinqWithStructWhereCount |           [50] |    363.46 ns |   0.0821 ns |     0.0768 ns |    363.48 ns |  1.19 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    345.67 ns |   0.0469 ns |     0.0416 ns |    345.67 ns |  1.13 |    0.00 |
|                                               LinqToArray |           [50] |  1,232.87 ns |   3.0937 ns |     2.8938 ns |  1,232.98 ns |  4.03 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |  1,122.92 ns |   8.6527 ns |     8.0937 ns |  1,123.36 ns |  3.67 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    996.02 ns |   6.4451 ns |     5.7134 ns |    995.02 ns |  3.26 |    0.02 |
|                              LowCostLinqWithStructToArray |           [50] |    544.80 ns |   0.4604 ns |     0.4306 ns |    545.02 ns |  1.78 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    556.11 ns |   0.2888 ns |     0.2702 ns |    556.15 ns |  1.82 |    0.00 |
|                                                      Take |           [50] |    668.29 ns |   5.7087 ns |     5.3399 ns |    669.86 ns |  2.19 |    0.02 |
|                                               LowCostTake |           [50] |    444.81 ns |   8.4377 ns |     8.2869 ns |    447.65 ns |  1.45 |    0.03 |
|                                  LowCostTakeWithoutChecks |           [50] |    481.67 ns |  22.8865 ns |    67.4814 ns |    435.59 ns |  1.68 |    0.20 |
|                                     LowCostTakeWithStruct |           [50] |    233.28 ns |   0.0476 ns |     0.0446 ns |    233.27 ns |  0.76 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    232.79 ns |   0.3060 ns |     0.2713 ns |    232.86 ns |  0.76 |    0.00 |
|                                            SkipTakeSingle |           [50] |    600.83 ns |  11.9842 ns |    14.2664 ns |    590.80 ns |  1.98 |    0.05 |
|                                     LowCostSkipTakeSingle |           [50] |    467.47 ns |   8.9574 ns |     8.3787 ns |    462.00 ns |  1.53 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    558.23 ns |  29.2242 ns |    86.1683 ns |    619.68 ns |  2.00 |    0.21 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    271.01 ns |   0.0698 ns |     0.0653 ns |    271.01 ns |  0.89 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    270.08 ns |   0.1026 ns |     0.0801 ns |    270.11 ns |  0.88 |    0.00 |
|                                           ForeachDelegate |           [50] |    582.14 ns |   0.0964 ns |     0.0902 ns |    582.16 ns |  1.90 |    0.00 |
|                                                   Foreach |           [50] |    305.64 ns |   0.0455 ns |     0.0425 ns |    305.63 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **250.36 ns** |   **0.0946 ns** |     **0.0884 ns** |    **250.35 ns** |  **5.55** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    142.98 ns |   0.7876 ns |     0.7367 ns |    143.13 ns |  3.17 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    151.61 ns |   3.0553 ns |     3.3959 ns |    152.26 ns |  3.36 |    0.07 |
|                                  LowCostLinqWithDelegate2 |            [5] |    171.41 ns |   0.2812 ns |     0.2493 ns |    171.38 ns |  3.80 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    178.48 ns |   1.3629 ns |     1.2749 ns |    178.80 ns |  3.95 |    0.03 |
|                                LowCostLinqWithStructWhere |            [5] |     93.04 ns |   1.4207 ns |     1.3290 ns |     92.21 ns |  2.06 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     93.30 ns |   0.0912 ns |     0.0853 ns |     93.27 ns |  2.07 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    305.05 ns |   0.7585 ns |     0.6724 ns |    305.36 ns |  6.76 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    293.98 ns |   0.3816 ns |     0.3383 ns |    293.82 ns |  6.51 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    216.49 ns |   0.3107 ns |     0.2426 ns |    216.42 ns |  4.79 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    200.91 ns |   0.1625 ns |     0.1520 ns |    200.88 ns |  4.45 |    0.01 |
|                                                 LinqCount |            [5] |    231.36 ns |   0.1041 ns |     0.0974 ns |    231.35 ns |  5.13 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |    139.35 ns |   1.3852 ns |     1.2957 ns |    138.76 ns |  3.09 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    146.65 ns |   1.4468 ns |     1.3533 ns |    145.74 ns |  3.25 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [5] |     87.54 ns |   0.0204 ns |     0.0191 ns |     87.54 ns |  1.94 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     87.24 ns |   1.3874 ns |     1.2978 ns |     86.46 ns |  1.93 |    0.03 |
|                                               LinqToArray |            [5] |    301.03 ns |   0.2977 ns |     0.2639 ns |    301.09 ns |  6.67 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    196.88 ns |   0.0913 ns |     0.0854 ns |    196.88 ns |  4.36 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    189.69 ns |   0.2163 ns |     0.1689 ns |    189.72 ns |  4.20 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    134.19 ns |   0.0194 ns |     0.0151 ns |    134.19 ns |  2.97 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    137.54 ns |   0.0508 ns |     0.0424 ns |    137.53 ns |  3.05 |    0.00 |
|                                                      Take |            [5] |    315.88 ns |   1.3094 ns |     1.1608 ns |    316.14 ns |  7.00 |    0.03 |
|                                               LowCostTake |            [5] |    162.13 ns |   0.3444 ns |     0.3053 ns |    162.09 ns |  3.59 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    166.78 ns |   2.7285 ns |     2.5522 ns |    167.36 ns |  3.69 |    0.05 |
|                                     LowCostTakeWithStruct |            [5] |    117.86 ns |   0.0374 ns |     0.0349 ns |    117.87 ns |  2.61 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    109.45 ns |   0.0952 ns |     0.0743 ns |    109.43 ns |  2.42 |    0.00 |
|                                            SkipTakeSingle |            [5] |    314.04 ns |   0.1746 ns |     0.1458 ns |    314.04 ns |  6.95 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    193.66 ns |   1.6616 ns |     1.5543 ns |    192.57 ns |  4.29 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    198.05 ns |   0.6754 ns |     0.6318 ns |    198.17 ns |  4.39 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    135.34 ns |   2.4107 ns |     2.2550 ns |    135.03 ns |  3.00 |    0.05 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    132.95 ns |   0.1116 ns |     0.1044 ns |    132.96 ns |  2.95 |    0.01 |
|                                           ForeachDelegate |            [5] |     76.87 ns |   0.0096 ns |     0.0090 ns |     76.87 ns |  1.70 |    0.00 |
|                                                   Foreach |            [5] |     45.14 ns |   0.0982 ns |     0.0919 ns |     45.17 ns |  1.00 |    0.00 |
