``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **112.21 ns** |   **0.0536 ns** |     **0.0501 ns** |    **112.22 ns** |  **6.18** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     49.94 ns |   0.0364 ns |     0.0322 ns |     49.94 ns |  2.75 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     45.33 ns |   0.0156 ns |     0.0146 ns |     45.33 ns |  2.50 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     69.54 ns |   0.0156 ns |     0.0138 ns |     69.54 ns |  3.83 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     63.92 ns |   0.0295 ns |     0.0262 ns |     63.92 ns |  3.52 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     58.24 ns |   0.0167 ns |     0.0156 ns |     58.23 ns |  3.21 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     55.67 ns |   0.0230 ns |     0.0215 ns |     55.66 ns |  3.07 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     77.14 ns |   0.1776 ns |     0.1661 ns |     77.21 ns |  4.25 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     77.29 ns |   0.0381 ns |     0.0357 ns |     77.29 ns |  4.26 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     65.74 ns |   0.0857 ns |     0.0716 ns |     65.74 ns |  3.62 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     62.61 ns |   0.0296 ns |     0.0277 ns |     62.60 ns |  3.45 |    0.00 |
|                                                 LinqCount |            [0] |    112.31 ns |   0.2048 ns |     0.1815 ns |    112.33 ns |  6.19 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     50.78 ns |   0.0337 ns |     0.0315 ns |     50.77 ns |  2.80 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     51.55 ns |   0.0186 ns |     0.0174 ns |     51.55 ns |  2.84 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     49.22 ns |   0.0172 ns |     0.0161 ns |     49.23 ns |  2.71 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     49.67 ns |   0.0179 ns |     0.0168 ns |     49.67 ns |  2.74 |    0.00 |
|                                               LinqToArray |            [0] |    123.95 ns |   0.0469 ns |     0.0438 ns |    123.94 ns |  6.83 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     62.88 ns |   0.0276 ns |     0.0258 ns |     62.88 ns |  3.47 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     65.18 ns |   0.0380 ns |     0.0355 ns |     65.17 ns |  3.59 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     58.06 ns |   0.0361 ns |     0.0337 ns |     58.07 ns |  3.20 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     58.68 ns |   0.0228 ns |     0.0213 ns |     58.68 ns |  3.23 |    0.00 |
|                                                      Take |            [0] |    149.66 ns |   0.0746 ns |     0.0698 ns |    149.66 ns |  8.25 |    0.00 |
|                                               LowCostTake |            [0] |     54.17 ns |   0.0131 ns |     0.0116 ns |     54.17 ns |  2.98 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     50.98 ns |   0.0249 ns |     0.0233 ns |     50.98 ns |  2.81 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     66.77 ns |   0.0272 ns |     0.0255 ns |     66.78 ns |  3.68 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     62.42 ns |   0.0141 ns |     0.0132 ns |     62.42 ns |  3.44 |    0.00 |
|                                            SkipTakeSingle |            [0] |    171.29 ns |   0.1365 ns |     0.1276 ns |    171.24 ns |  9.44 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     71.99 ns |   0.0219 ns |     0.0205 ns |     71.99 ns |  3.97 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     71.77 ns |   0.0335 ns |     0.0313 ns |     71.78 ns |  3.95 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     71.28 ns |   0.0174 ns |     0.0163 ns |     71.28 ns |  3.93 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     76.86 ns |   0.0264 ns |     0.0247 ns |     76.85 ns |  4.24 |    0.00 |
|                                           ForeachDelegate |            [0] |     21.07 ns |   0.0069 ns |     0.0065 ns |     21.07 ns |  1.16 |    0.00 |
|                                                   Foreach |            [0] |     18.15 ns |   0.0087 ns |     0.0082 ns |     18.15 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **17,593.40 ns** | **305.0854 ns** |   **285.3770 ns** | **17,713.10 ns** |  **3.18** |    **0.05** |
|                                   LowCostLinqWithDelegate |         [1000] | 13,512.54 ns |  76.6188 ns |    59.8189 ns | 13,531.58 ns |  2.44 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 14,370.38 ns | 286.9671 ns |   770.9184 ns | 14,020.43 ns |  2.59 |    0.13 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 15,596.74 ns | 357.7454 ns | 1,054.8204 ns | 15,532.68 ns |  2.92 |    0.21 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 15,156.76 ns | 324.4816 ns |   909.8812 ns | 15,422.95 ns |  2.71 |    0.18 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,528.81 ns |   1.9567 ns |     1.7346 ns |  6,528.91 ns |  1.18 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,755.12 ns |   2.4533 ns |     2.1748 ns |  6,755.31 ns |  1.22 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,984.64 ns | 100.6984 ns |    94.1934 ns | 23,989.49 ns |  4.34 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 23,459.45 ns | 466.6913 ns |   638.8124 ns | 23,375.03 ns |  4.25 |    0.12 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,724.62 ns |  10.2059 ns |     9.5466 ns |  9,722.45 ns |  1.76 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,896.15 ns |   4.2306 ns |     3.9573 ns |  9,895.94 ns |  1.79 |    0.00 |
|                                                 LinqCount |         [1000] | 12,335.82 ns | 240.0115 ns |   200.4205 ns | 12,249.23 ns |  2.23 |    0.04 |
|                              LowCostLinqWithDelegateCount |         [1000] | 13,649.31 ns | 282.2145 ns |   832.1158 ns | 13,408.70 ns |  2.53 |    0.18 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 12,982.95 ns | 258.5041 ns |   550.8932 ns | 12,951.51 ns |  2.35 |    0.12 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,813.17 ns |   3.0277 ns |     2.8321 ns |  5,814.10 ns |  1.05 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,571.20 ns |   1.5362 ns |     1.4370 ns |  5,570.97 ns |  1.01 |    0.00 |
|                                               LinqToArray |         [1000] | 14,463.56 ns |  29.7093 ns |    26.3365 ns | 14,473.06 ns |  2.62 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 13,282.16 ns |  20.5277 ns |    19.2016 ns | 13,277.71 ns |  2.40 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 14,869.52 ns |  17.2632 ns |    16.1480 ns | 14,872.33 ns |  2.69 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,042.01 ns |   4.3100 ns |     3.8207 ns |  7,042.00 ns |  1.27 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  6,800.88 ns |   3.0920 ns |     2.7410 ns |  6,800.63 ns |  1.23 |    0.00 |
|                                                      Take |         [1000] |    588.43 ns |   0.5208 ns |     0.4872 ns |    588.44 ns |  0.11 |    0.00 |
|                                               LowCostTake |         [1000] |    362.18 ns |   2.0446 ns |     1.7073 ns |    361.57 ns |  0.07 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    389.48 ns |   6.2641 ns |     5.8594 ns |    390.54 ns |  0.07 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    215.92 ns |   0.0788 ns |     0.0737 ns |    215.89 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    197.10 ns |   0.0650 ns |     0.0608 ns |    197.09 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    500.63 ns |   0.8351 ns |     0.7403 ns |    500.49 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    416.05 ns |   1.7379 ns |     1.4512 ns |    416.47 ns |  0.08 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    372.56 ns |   4.8238 ns |     4.5122 ns |    370.23 ns |  0.07 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    217.59 ns |   0.2726 ns |     0.2550 ns |    217.64 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    220.36 ns |   0.0357 ns |     0.0298 ns |    220.36 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,397.60 ns |  16.0369 ns |    15.0009 ns |  9,398.56 ns |  1.70 |    0.00 |
|                                                   Foreach |         [1000] |  5,526.38 ns |   0.9590 ns |     0.8971 ns |  5,526.34 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **964.19 ns** |   **2.6463 ns** |     **2.4754 ns** |    **963.87 ns** |  **3.14** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    776.01 ns |  15.1470 ns |    14.8764 ns |    778.56 ns |  2.52 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    726.30 ns |   1.7556 ns |     1.6422 ns |    726.39 ns |  2.37 |    0.01 |
|                                  LowCostLinqWithDelegate2 |           [50] |    832.92 ns |  16.4300 ns |    26.9950 ns |    825.85 ns |  2.71 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    765.04 ns |   5.1103 ns |     4.5302 ns |    763.63 ns |  2.49 |    0.02 |
|                                LowCostLinqWithStructWhere |           [50] |    390.89 ns |   0.5979 ns |     0.5301 ns |    391.02 ns |  1.27 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    399.04 ns |   0.1552 ns |     0.1452 ns |    399.07 ns |  1.30 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,248.93 ns |   8.6885 ns |     8.1272 ns |  1,247.28 ns |  4.07 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,252.05 ns |   5.6103 ns |     5.2479 ns |  1,254.67 ns |  4.08 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    562.04 ns |   0.1293 ns |     0.1146 ns |    562.03 ns |  1.83 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    569.67 ns |   0.2384 ns |     0.2114 ns |    569.66 ns |  1.86 |    0.00 |
|                                                 LinqCount |           [50] |    732.64 ns |   2.6035 ns |     2.4353 ns |    731.66 ns |  2.39 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    736.91 ns |   6.2260 ns |     5.8238 ns |    735.82 ns |  2.40 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    701.54 ns |  14.4199 ns |    19.2502 ns |    702.70 ns |  2.28 |    0.06 |
|                           LowCostLinqWithStructWhereCount |           [50] |    350.07 ns |   0.1719 ns |     0.1524 ns |    350.09 ns |  1.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    338.41 ns |   0.0994 ns |     0.0930 ns |    338.41 ns |  1.10 |    0.00 |
|                                               LinqToArray |           [50] |  1,060.21 ns |   0.8411 ns |     0.7456 ns |  1,060.25 ns |  3.45 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    887.66 ns |   1.9171 ns |     1.7932 ns |    887.39 ns |  2.89 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    895.56 ns |   0.5636 ns |     0.5272 ns |    895.47 ns |  2.92 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    521.65 ns |   0.1796 ns |     0.1680 ns |    521.67 ns |  1.70 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    506.33 ns |   0.4126 ns |     0.3657 ns |    506.43 ns |  1.65 |    0.00 |
|                                                      Take |           [50] |    587.83 ns |   0.8249 ns |     0.7313 ns |    587.83 ns |  1.91 |    0.00 |
|                                               LowCostTake |           [50] |    367.52 ns |   4.2547 ns |     3.9799 ns |    365.25 ns |  1.20 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    392.10 ns |   2.7518 ns |     2.5740 ns |    392.29 ns |  1.28 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    215.13 ns |   0.0583 ns |     0.0546 ns |    215.14 ns |  0.70 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    197.05 ns |   0.0666 ns |     0.0623 ns |    197.05 ns |  0.64 |    0.00 |
|                                            SkipTakeSingle |           [50] |    500.51 ns |   0.4724 ns |     0.4188 ns |    500.52 ns |  1.63 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    374.73 ns |   2.5378 ns |     2.2497 ns |    373.99 ns |  1.22 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    380.43 ns |   1.3434 ns |     1.2566 ns |    380.32 ns |  1.24 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    216.63 ns |   0.0704 ns |     0.0658 ns |    216.63 ns |  0.71 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    221.73 ns |   0.1517 ns |     0.1419 ns |    221.77 ns |  0.72 |    0.00 |
|                                           ForeachDelegate |           [50] |    501.10 ns |   0.4646 ns |     0.4346 ns |    501.17 ns |  1.63 |    0.00 |
|                                                   Foreach |           [50] |    306.97 ns |   0.1509 ns |     0.1412 ns |    306.99 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **211.05 ns** |   **0.0626 ns** |     **0.0585 ns** |    **211.04 ns** |  **4.68** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    129.88 ns |   0.1520 ns |     0.1269 ns |    129.87 ns |  2.88 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    126.17 ns |   0.5868 ns |     0.5201 ns |    126.21 ns |  2.80 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |    155.37 ns |   0.7899 ns |     0.7389 ns |    154.95 ns |  3.45 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    144.46 ns |   0.4782 ns |     0.4473 ns |    144.38 ns |  3.20 |    0.01 |
|                                LowCostLinqWithStructWhere |            [5] |     83.64 ns |   0.0480 ns |     0.0449 ns |     83.62 ns |  1.86 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     83.47 ns |   0.0485 ns |     0.0453 ns |     83.45 ns |  1.85 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    205.91 ns |   1.7228 ns |     1.6115 ns |    206.91 ns |  4.57 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    200.91 ns |   0.2330 ns |     0.2179 ns |    200.91 ns |  4.46 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    112.94 ns |   0.0465 ns |     0.0435 ns |    112.95 ns |  2.51 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    113.19 ns |   0.1294 ns |     0.1210 ns |    113.24 ns |  2.51 |    0.00 |
|                                                 LinqCount |            [5] |    188.71 ns |   0.0873 ns |     0.0774 ns |    188.70 ns |  4.19 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    127.30 ns |   0.3360 ns |     0.3143 ns |    127.38 ns |  2.82 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    127.29 ns |   0.4260 ns |     0.3984 ns |    127.24 ns |  2.82 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     76.59 ns |   0.0255 ns |     0.0239 ns |     76.58 ns |  1.70 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     77.40 ns |   0.0151 ns |     0.0126 ns |     77.40 ns |  1.72 |    0.00 |
|                                               LinqToArray |            [5] |    255.00 ns |   0.2456 ns |     0.2297 ns |    254.93 ns |  5.66 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    173.52 ns |   0.1811 ns |     0.1605 ns |    173.55 ns |  3.85 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    176.43 ns |   0.1115 ns |     0.0988 ns |    176.44 ns |  3.91 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    132.27 ns |   0.1241 ns |     0.1161 ns |    132.32 ns |  2.93 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    132.29 ns |   0.0427 ns |     0.0379 ns |    132.29 ns |  2.93 |    0.00 |
|                                                      Take |            [5] |    286.08 ns |   0.0941 ns |     0.0881 ns |    286.06 ns |  6.35 |    0.00 |
|                                               LowCostTake |            [5] |    138.81 ns |   0.8263 ns |     0.7729 ns |    138.58 ns |  3.08 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [5] |    136.28 ns |   0.7113 ns |     0.6653 ns |    135.87 ns |  3.02 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |     94.36 ns |   0.0222 ns |     0.0197 ns |     94.36 ns |  2.09 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     89.27 ns |   0.0646 ns |     0.0604 ns |     89.27 ns |  1.98 |    0.00 |
|                                            SkipTakeSingle |            [5] |    260.81 ns |   0.1328 ns |     0.1242 ns |    260.81 ns |  5.78 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    146.16 ns |   0.4317 ns |     0.4039 ns |    146.04 ns |  3.24 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    144.05 ns |   0.1729 ns |     0.1533 ns |    144.05 ns |  3.20 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    102.14 ns |   0.0365 ns |     0.0342 ns |    102.14 ns |  2.27 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    103.18 ns |   0.0255 ns |     0.0239 ns |    103.18 ns |  2.29 |    0.00 |
|                                           ForeachDelegate |            [5] |     67.66 ns |   0.0183 ns |     0.0171 ns |     67.66 ns |  1.50 |    0.00 |
|                                                   Foreach |            [5] |     45.09 ns |   0.0189 ns |     0.0177 ns |     45.08 ns |  1.00 |    0.00 |
