``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **117.42 ns** |   **0.0432 ns** |     **0.0383 ns** |    **117.42 ns** | **10.27** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     44.34 ns |   0.0075 ns |     0.0070 ns |     44.34 ns |  3.88 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     41.55 ns |   0.0092 ns |     0.0076 ns |     41.55 ns |  3.63 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     70.07 ns |   0.0093 ns |     0.0087 ns |     70.07 ns |  6.13 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     66.10 ns |   0.0177 ns |     0.0166 ns |     66.09 ns |  5.78 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     54.82 ns |   0.0057 ns |     0.0051 ns |     54.82 ns |  4.79 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     53.71 ns |   0.0080 ns |     0.0071 ns |     53.71 ns |  4.70 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    119.36 ns |   0.0505 ns |     0.0422 ns |    119.36 ns | 10.43 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    114.67 ns |   0.1338 ns |     0.1251 ns |    114.70 ns | 10.02 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    110.62 ns |   0.0560 ns |     0.0497 ns |    110.61 ns |  9.67 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    100.75 ns |   0.1053 ns |     0.0933 ns |    100.73 ns |  8.81 |    0.01 |
|                                                 LinqCount |            [0] |    113.96 ns |   0.0999 ns |     0.0935 ns |    113.97 ns |  9.96 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     41.93 ns |   0.0243 ns |     0.0215 ns |     41.92 ns |  3.67 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     42.11 ns |   0.0207 ns |     0.0194 ns |     42.11 ns |  3.68 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     45.93 ns |   0.0189 ns |     0.0167 ns |     45.94 ns |  4.02 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     45.61 ns |   0.0032 ns |     0.0029 ns |     45.61 ns |  3.99 |    0.00 |
|                                               LinqToArray |            [0] |    132.49 ns |   0.0842 ns |     0.0788 ns |    132.49 ns | 11.58 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     58.61 ns |   0.0736 ns |     0.0688 ns |     58.62 ns |  5.12 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     51.67 ns |   0.0332 ns |     0.0310 ns |     51.67 ns |  4.52 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     55.85 ns |   0.0176 ns |     0.0165 ns |     55.86 ns |  4.88 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     56.26 ns |   0.0404 ns |     0.0378 ns |     56.24 ns |  4.92 |    0.00 |
|                                                      Take |            [0] |    152.26 ns |   0.0314 ns |     0.0278 ns |    152.26 ns | 13.31 |    0.01 |
|                                               LowCostTake |            [0] |     56.23 ns |   0.0162 ns |     0.0151 ns |     56.24 ns |  4.92 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     54.26 ns |   0.0192 ns |     0.0180 ns |     54.26 ns |  4.74 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     67.81 ns |   0.0123 ns |     0.0115 ns |     67.82 ns |  5.93 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     65.54 ns |   0.0278 ns |     0.0260 ns |     65.53 ns |  5.73 |    0.00 |
|                                            SkipTakeSingle |            [0] |    172.75 ns |   0.0964 ns |     0.0902 ns |    172.77 ns | 15.10 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     76.79 ns |   0.0111 ns |     0.0092 ns |     76.79 ns |  6.71 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     78.11 ns |   0.0167 ns |     0.0157 ns |     78.10 ns |  6.83 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     79.85 ns |   0.0159 ns |     0.0149 ns |     79.85 ns |  6.98 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     79.54 ns |   0.0137 ns |     0.0129 ns |     79.54 ns |  6.95 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.08 ns |   0.0113 ns |     0.0105 ns |     15.08 ns |  1.32 |    0.00 |
|                                                   Foreach |            [0] |     11.44 ns |   0.0035 ns |     0.0033 ns |     11.44 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **13,822.40 ns** | **118.6901 ns** |   **111.0228 ns** | **13,786.75 ns** |  **3.20** |    **0.03** |
|                                   LowCostLinqWithDelegate |         [1000] | 10,910.70 ns | 220.3355 ns |   642.7290 ns | 10,820.28 ns |  2.52 |    0.15 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 16,369.15 ns | 745.0290 ns | 2,196.7348 ns | 17,637.74 ns |  4.10 |    0.35 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,955.78 ns | 248.5066 ns |   700.9172 ns | 11,980.41 ns |  2.76 |    0.14 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 12,856.49 ns |  74.3701 ns |    69.5658 ns | 12,854.88 ns |  2.98 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,494.49 ns |   0.8665 ns |     0.8106 ns |  1,494.26 ns |  0.35 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,325.58 ns |   0.2387 ns |     0.2233 ns |  1,325.56 ns |  0.31 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 24,782.04 ns | 490.6157 ns |   859.2738 ns | 24,686.94 ns |  5.69 |    0.22 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 24,730.75 ns | 115.3719 ns |   107.9189 ns | 24,749.30 ns |  5.72 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,510.51 ns |   1.8772 ns |     1.6641 ns |  8,510.59 ns |  1.97 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  7,799.73 ns |   1.3749 ns |     1.1481 ns |  7,799.95 ns |  1.81 |    0.00 |
|                                                 LinqCount |         [1000] |  9,402.37 ns | 185.6054 ns |   344.0316 ns |  9,246.70 ns |  2.20 |    0.08 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,287.43 ns | 119.2892 ns |   111.5832 ns | 10,306.03 ns |  2.38 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 14,782.66 ns | 433.7471 ns | 1,278.9132 ns | 15,219.34 ns |  3.34 |    0.37 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    543.53 ns |   0.2065 ns |     0.1932 ns |    543.58 ns |  0.13 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    547.82 ns |   0.1698 ns |     0.1588 ns |    547.85 ns |  0.13 |    0.00 |
|                                               LinqToArray |         [1000] | 10,867.22 ns |  13.0119 ns |    11.5347 ns | 10,866.36 ns |  2.51 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 12,997.64 ns |  34.0503 ns |    30.1847 ns | 13,002.02 ns |  3.01 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,346.81 ns |  28.4084 ns |    26.5732 ns | 11,339.92 ns |  2.63 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,948.20 ns |   1.6398 ns |     1.2803 ns |  1,948.10 ns |  0.45 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,953.22 ns |   3.6554 ns |     3.0524 ns |  1,953.89 ns |  0.45 |    0.00 |
|                                                      Take |         [1000] |    538.97 ns |   5.3856 ns |     4.7742 ns |    539.82 ns |  0.12 |    0.00 |
|                                               LowCostTake |         [1000] |    306.96 ns |   6.1282 ns |    14.5642 ns |    300.11 ns |  0.07 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    298.41 ns |   2.7851 ns |     2.6052 ns |    298.92 ns |  0.07 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    106.54 ns |   0.0173 ns |     0.0154 ns |    106.54 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     98.08 ns |   0.0100 ns |     0.0088 ns |     98.07 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    422.91 ns |   0.3537 ns |     0.3136 ns |    422.90 ns |  0.10 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    360.47 ns |   2.5002 ns |     2.3387 ns |    360.45 ns |  0.08 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    345.24 ns |   6.8955 ns |    11.5207 ns |    343.23 ns |  0.08 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    143.62 ns |   0.0347 ns |     0.0308 ns |    143.61 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    150.56 ns |   0.0349 ns |     0.0327 ns |    150.55 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,661.48 ns |  12.1134 ns |    11.3309 ns |  9,663.00 ns |  2.24 |    0.00 |
|                                                   Foreach |         [1000] |  4,321.13 ns |   1.7937 ns |     1.6778 ns |  4,320.97 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **776.61 ns** |   **3.1214 ns** |     **2.9198 ns** |    **776.70 ns** |  **3.27** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    533.10 ns |   1.9550 ns |     1.6325 ns |    532.88 ns |  2.25 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    668.76 ns |  15.5877 ns |    45.4700 ns |    649.14 ns |  2.81 |    0.18 |
|                                  LowCostLinqWithDelegate2 |           [50] |    634.78 ns |  12.3825 ns |    11.5826 ns |    628.63 ns |  2.68 |    0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    719.23 ns |  16.7077 ns |    49.2632 ns |    702.76 ns |  3.00 |    0.21 |
|                                LowCostLinqWithStructWhere |           [50] |    131.18 ns |   0.0366 ns |     0.0342 ns |    131.19 ns |  0.55 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    121.88 ns |   0.0221 ns |     0.0207 ns |    121.87 ns |  0.51 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,304.40 ns |   2.4515 ns |     2.1732 ns |  1,304.68 ns |  5.50 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,317.95 ns |  24.4981 ns |    22.9155 ns |  1,318.16 ns |  5.56 |    0.10 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    543.46 ns |   0.6093 ns |     0.5088 ns |    543.40 ns |  2.29 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    495.39 ns |   0.1539 ns |     0.1440 ns |    495.41 ns |  2.09 |    0.00 |
|                                                 LinqCount |           [50] |    562.59 ns |   1.5721 ns |     1.4705 ns |    562.29 ns |  2.37 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    512.27 ns |   3.0791 ns |     2.4040 ns |    512.21 ns |  2.16 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    601.40 ns |  15.0888 ns |    44.4897 ns |    580.34 ns |  2.60 |    0.21 |
|                           LowCostLinqWithStructWhereCount |           [50] |     72.70 ns |   0.0129 ns |     0.0121 ns |     72.70 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     71.55 ns |   0.0200 ns |     0.0178 ns |     71.55 ns |  0.30 |    0.00 |
|                                               LinqToArray |           [50] |    868.54 ns |   2.0261 ns |     1.8952 ns |    868.26 ns |  3.66 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    811.92 ns |   6.9888 ns |     6.5373 ns |    813.33 ns |  3.42 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    735.53 ns |   1.8746 ns |     1.7535 ns |    735.40 ns |  3.10 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    222.76 ns |   0.2441 ns |     0.2283 ns |    222.76 ns |  0.94 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    215.99 ns |   0.1549 ns |     0.1373 ns |    215.97 ns |  0.91 |    0.00 |
|                                                      Take |           [50] |    519.53 ns |   1.1766 ns |     1.1006 ns |    519.25 ns |  2.19 |    0.00 |
|                                               LowCostTake |           [50] |    287.75 ns |   4.5823 ns |     3.5776 ns |    286.76 ns |  1.21 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    295.75 ns |   6.6901 ns |    19.3024 ns |    284.20 ns |  1.25 |    0.10 |
|                                     LowCostTakeWithStruct |           [50] |    105.13 ns |   0.0102 ns |     0.0085 ns |    105.13 ns |  0.44 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    101.06 ns |   0.0153 ns |     0.0143 ns |    101.05 ns |  0.43 |    0.00 |
|                                            SkipTakeSingle |           [50] |    422.83 ns |   0.6373 ns |     0.5962 ns |    422.98 ns |  1.78 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    334.07 ns |   0.7427 ns |     0.6584 ns |    334.04 ns |  1.41 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    360.61 ns |   8.2744 ns |    24.2673 ns |    359.30 ns |  1.48 |    0.08 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    144.92 ns |   0.0572 ns |     0.0535 ns |    144.90 ns |  0.61 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    149.50 ns |   0.0290 ns |     0.0271 ns |    149.49 ns |  0.63 |    0.00 |
|                                           ForeachDelegate |           [50] |    506.29 ns |   0.0913 ns |     0.0810 ns |    506.31 ns |  2.14 |    0.00 |
|                                                   Foreach |           [50] |    237.09 ns |   0.0627 ns |     0.0556 ns |    237.08 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **189.69 ns** |   **0.3104 ns** |     **0.2903 ns** |    **189.62 ns** |  **5.53** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     92.98 ns |   1.8821 ns |     5.2777 ns |     90.81 ns |  2.76 |    0.14 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    134.03 ns |   3.8488 ns |    11.3482 ns |    139.15 ns |  3.96 |    0.28 |
|                                  LowCostLinqWithDelegate2 |            [5] |    127.78 ns |   1.4327 ns |     1.2700 ns |    127.23 ns |  3.72 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    138.75 ns |   1.3586 ns |     1.2709 ns |    138.50 ns |  4.05 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |     60.55 ns |   0.0075 ns |     0.0063 ns |     60.54 ns |  1.76 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     59.13 ns |   0.0077 ns |     0.0068 ns |     59.13 ns |  1.72 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    249.11 ns |   0.2520 ns |     0.2357 ns |    249.11 ns |  7.26 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    242.63 ns |   0.4561 ns |     0.4267 ns |    242.62 ns |  7.07 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    156.54 ns |   0.0673 ns |     0.0525 ns |    156.54 ns |  4.56 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    143.38 ns |   0.0417 ns |     0.0390 ns |    143.40 ns |  4.18 |    0.00 |
|                                                 LinqCount |            [5] |    165.79 ns |   0.0854 ns |     0.0799 ns |    165.76 ns |  4.83 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     92.65 ns |   0.7678 ns |     0.7182 ns |     92.65 ns |  2.70 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     94.89 ns |   1.9092 ns |     4.1505 ns |     94.43 ns |  2.76 |    0.12 |
|                           LowCostLinqWithStructWhereCount |            [5] |     48.31 ns |   0.0056 ns |     0.0053 ns |     48.31 ns |  1.41 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     49.63 ns |   0.0208 ns |     0.0194 ns |     49.63 ns |  1.45 |    0.00 |
|                                               LinqToArray |            [5] |    230.89 ns |   0.1753 ns |     0.1640 ns |    230.91 ns |  6.73 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    142.57 ns |   0.3485 ns |     0.3260 ns |    142.59 ns |  4.15 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    133.95 ns |   0.2306 ns |     0.2157 ns |    133.86 ns |  3.90 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     89.49 ns |   0.2176 ns |     0.2035 ns |     89.56 ns |  2.61 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     89.11 ns |   0.0247 ns |     0.0231 ns |     89.11 ns |  2.60 |    0.00 |
|                                                      Take |            [5] |    268.49 ns |   0.7441 ns |     0.6960 ns |    268.29 ns |  7.83 |    0.02 |
|                                               LowCostTake |            [5] |    120.09 ns |   2.4249 ns |     4.8984 ns |    118.59 ns |  3.51 |    0.15 |
|                                  LowCostTakeWithoutChecks |            [5] |    103.55 ns |   0.5345 ns |     0.5000 ns |    103.47 ns |  3.02 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |     75.94 ns |   0.0113 ns |     0.0106 ns |     75.94 ns |  2.21 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     72.60 ns |   0.0091 ns |     0.0085 ns |     72.60 ns |  2.12 |    0.00 |
|                                            SkipTakeSingle |            [5] |    239.76 ns |   0.0979 ns |     0.0915 ns |    239.74 ns |  6.99 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    142.09 ns |   0.7544 ns |     0.6687 ns |    141.97 ns |  4.14 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    137.18 ns |   2.5940 ns |     2.7756 ns |    135.71 ns |  4.01 |    0.09 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     91.34 ns |   0.0443 ns |     0.0415 ns |     91.34 ns |  2.66 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     92.50 ns |   0.0196 ns |     0.0183 ns |     92.50 ns |  2.70 |    0.00 |
|                                           ForeachDelegate |            [5] |     66.24 ns |   0.0365 ns |     0.0341 ns |     66.24 ns |  1.93 |    0.00 |
|                                                   Foreach |            [5] |     34.31 ns |   0.0170 ns |     0.0151 ns |     34.31 ns |  1.00 |    0.00 |
