``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **66.346 ns** |   **0.0306 ns** |   **0.0271 ns** |     **66.341 ns** | **15.78** |    **0.29** |
|                                   LowCostLinqWithDelegate |            [0] |     27.508 ns |   0.0040 ns |   0.0037 ns |     27.509 ns |  6.55 |    0.12 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     20.322 ns |   0.0040 ns |   0.0038 ns |     20.321 ns |  4.84 |    0.09 |
|                                  LowCostLinqWithDelegate2 |            [0] |     41.354 ns |   0.0058 ns |   0.0055 ns |     41.355 ns |  9.85 |    0.18 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     38.272 ns |   0.0103 ns |   0.0096 ns |     38.275 ns |  9.11 |    0.17 |
|                                LowCostLinqWithStructWhere |            [0] |     36.328 ns |   0.0080 ns |   0.0075 ns |     36.332 ns |  8.65 |    0.16 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     28.219 ns |   0.0056 ns |   0.0052 ns |     28.219 ns |  6.72 |    0.12 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     64.675 ns |   0.0311 ns |   0.0275 ns |     64.683 ns | 15.39 |    0.29 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     60.094 ns |   0.0292 ns |   0.0273 ns |     60.083 ns | 14.31 |    0.26 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     58.510 ns |   0.0761 ns |   0.0712 ns |     58.481 ns | 13.93 |    0.24 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     49.150 ns |   0.0233 ns |   0.0206 ns |     49.145 ns | 11.69 |    0.22 |
|                                                 LinqCount |            [0] |     64.090 ns |   0.0265 ns |   0.0235 ns |     64.090 ns | 15.25 |    0.28 |
|                              LowCostLinqWithDelegateCount |            [0] |     25.901 ns |   0.0128 ns |   0.0120 ns |     25.902 ns |  6.17 |    0.11 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     23.956 ns |   0.0088 ns |   0.0082 ns |     23.956 ns |  5.70 |    0.10 |
|                           LowCostLinqWithStructWhereCount |            [0] |     29.170 ns |   0.0077 ns |   0.0072 ns |     29.170 ns |  6.95 |    0.13 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     21.051 ns |   0.0079 ns |   0.0070 ns |     21.052 ns |  5.01 |    0.09 |
|                                               LinqToArray |            [0] |     76.795 ns |   0.2302 ns |   0.1922 ns |     76.683 ns | 18.28 |    0.33 |
|                            LowCostLinqWithDelegateToArray |            [0] |     30.242 ns |   0.0243 ns |   0.0216 ns |     30.241 ns |  7.19 |    0.14 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     27.545 ns |   0.0074 ns |   0.0065 ns |     27.544 ns |  6.55 |    0.12 |
|                              LowCostLinqWithStructToArray |            [0] |     33.652 ns |   0.0225 ns |   0.0211 ns |     33.654 ns |  8.01 |    0.14 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     26.201 ns |   0.0319 ns |   0.0299 ns |     26.192 ns |  6.24 |    0.11 |
|                                                      Take |            [0] |    103.068 ns |   0.0254 ns |   0.0212 ns |    103.062 ns | 24.53 |    0.47 |
|                                               LowCostTake |            [0] |     34.717 ns |   0.0085 ns |   0.0080 ns |     34.716 ns |  8.27 |    0.15 |
|                                  LowCostTakeWithoutChecks |            [0] |     29.671 ns |   0.0060 ns |   0.0056 ns |     29.669 ns |  7.07 |    0.13 |
|                                     LowCostTakeWithStruct |            [0] |     42.089 ns |   0.0050 ns |   0.0047 ns |     42.088 ns | 10.02 |    0.18 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     34.990 ns |   0.0151 ns |   0.0134 ns |     34.990 ns |  8.32 |    0.16 |
|                                            SkipTakeSingle |            [0] |    123.134 ns |   0.2104 ns |   0.1968 ns |    123.183 ns | 29.32 |    0.53 |
|                                     LowCostSkipTakeSingle |            [0] |     43.434 ns |   0.0061 ns |   0.0057 ns |     43.434 ns | 10.34 |    0.19 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     38.029 ns |   0.0028 ns |   0.0026 ns |     38.029 ns |  9.06 |    0.16 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     48.431 ns |   0.0094 ns |   0.0088 ns |     48.433 ns | 11.53 |    0.21 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     42.185 ns |   0.0109 ns |   0.0102 ns |     42.185 ns | 10.05 |    0.18 |
|                                           ForeachDelegate |            [0] |     15.863 ns |   0.0146 ns |   0.0136 ns |     15.860 ns |  3.78 |    0.07 |
|                                                   Foreach |            [0] |     12.654 ns |   0.0375 ns |   0.0351 ns |     12.665 ns |  3.01 |    0.05 |
|                                                       For |            [0] |      4.201 ns |   0.0824 ns |   0.0770 ns |      4.174 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** |  **9,364.213 ns** |  **10.0395 ns** |   **9.3909 ns** |  **9,363.795 ns** | **37.29** |    **0.04** |
|                                   LowCostLinqWithDelegate |         [1000] |  6,542.551 ns |  33.4248 ns |  31.2656 ns |  6,549.639 ns | 26.05 |    0.12 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  7,119.215 ns | 302.6657 ns | 892.4166 ns |  7,678.912 ns | 30.54 |    1.88 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,713.896 ns | 100.6026 ns |  89.1816 ns |  6,678.469 ns | 26.73 |    0.36 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,688.088 ns |  53.6783 ns |  50.2107 ns |  6,677.944 ns | 26.63 |    0.20 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,841.433 ns |   0.4229 ns |   0.3955 ns |  1,841.527 ns |  7.33 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,369.453 ns |   0.1837 ns |   0.1718 ns |  1,369.367 ns |  5.45 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 18,842.262 ns | 184.0882 ns | 153.7220 ns | 18,837.015 ns | 75.03 |    0.62 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 17,500.007 ns | 145.4575 ns | 128.9443 ns | 17,503.995 ns | 69.68 |    0.52 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,518.864 ns |   2.5988 ns |   2.4309 ns |  6,517.989 ns | 25.96 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  6,326.866 ns |  73.4911 ns |  68.7436 ns |  6,358.744 ns | 25.19 |    0.28 |
|                                                 LinqCount |         [1000] |  4,153.712 ns |   3.3742 ns |   3.1563 ns |  4,153.246 ns | 16.54 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,627.597 ns | 132.5336 ns | 136.1022 ns |  6,672.363 ns | 26.43 |    0.56 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,103.399 ns | 101.8495 ns | 217.0496 ns |  4,995.544 ns | 20.25 |    0.96 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,710.284 ns |   0.4884 ns |   0.4568 ns |  1,710.435 ns |  6.81 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    626.158 ns |   0.0716 ns |   0.0670 ns |    626.145 ns |  2.49 |    0.00 |
|                                               LinqToArray |         [1000] |  5,352.581 ns |   4.5483 ns |   4.2545 ns |  5,352.674 ns | 21.31 |    0.02 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,914.126 ns |  38.0464 ns |  35.5886 ns |  7,927.884 ns | 31.51 |    0.14 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,242.721 ns |   5.6967 ns |   5.3287 ns |  7,242.361 ns | 28.84 |    0.02 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,582.686 ns |   2.2863 ns |   2.0268 ns |  3,582.115 ns | 14.27 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,155.024 ns |   6.4704 ns |   6.0524 ns |  2,156.494 ns |  8.58 |    0.02 |
|                                                      Take |         [1000] |    414.373 ns |   0.3731 ns |   0.3490 ns |    414.225 ns |  1.65 |    0.00 |
|                                               LowCostTake |         [1000] |    166.268 ns |   3.2939 ns |   4.9301 ns |    162.590 ns |  0.67 |    0.02 |
|                                  LowCostTakeWithoutChecks |         [1000] |    197.545 ns |   3.5009 ns |   3.2748 ns |    197.318 ns |  0.79 |    0.01 |
|                                     LowCostTakeWithStruct |         [1000] |     83.586 ns |   0.0226 ns |   0.0212 ns |     83.587 ns |  0.33 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     66.280 ns |   0.1473 ns |   0.1378 ns |     66.310 ns |  0.26 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    306.630 ns |   0.1208 ns |   0.1130 ns |    306.626 ns |  1.22 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    247.890 ns |   2.9617 ns |   2.7704 ns |    247.738 ns |  0.99 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    153.598 ns |   3.0881 ns |   3.6761 ns |    152.603 ns |  0.61 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     93.919 ns |   0.0363 ns |   0.0340 ns |     93.923 ns |  0.37 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     68.245 ns |   0.0268 ns |   0.0251 ns |     68.236 ns |  0.27 |    0.00 |
|                                           ForeachDelegate |         [1000] |  4,265.708 ns |   0.4561 ns |   0.4043 ns |  4,265.781 ns | 16.98 |    0.00 |
|                                                   Foreach |         [1000] |  1,690.806 ns |   0.3634 ns |   0.2837 ns |  1,690.828 ns |  6.73 |    0.00 |
|                                                       For |         [1000] |    251.148 ns |   0.0547 ns |   0.0511 ns |    251.157 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **554.896 ns** |   **0.2409 ns** |   **0.2254 ns** |    **554.943 ns** | **34.77** |    **0.02** |
|                                   LowCostLinqWithDelegate |           [50] |    339.111 ns |   6.5857 ns |   9.0145 ns |    336.352 ns | 21.18 |    0.59 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    316.024 ns |   7.3503 ns |  11.0016 ns |    310.879 ns | 19.68 |    0.54 |
|                                  LowCostLinqWithDelegate2 |           [50] |    379.852 ns |   7.5514 ns |  11.5319 ns |    372.832 ns | 23.71 |    0.74 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    343.746 ns |   9.4011 ns |   8.3338 ns |    340.316 ns | 21.54 |    0.53 |
|                                LowCostLinqWithStructWhere |           [50] |    133.899 ns |   0.0235 ns |   0.0220 ns |    133.894 ns |  8.39 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    105.244 ns |   0.0207 ns |   0.0173 ns |    105.245 ns |  6.59 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,010.091 ns |   8.4905 ns |   7.9421 ns |  1,009.867 ns | 63.29 |    0.50 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    917.132 ns |  17.4604 ns |  17.9306 ns |    905.344 ns | 57.57 |    1.17 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    389.477 ns |   0.0625 ns |   0.0554 ns |    389.474 ns | 24.40 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    379.545 ns |   0.4754 ns |   0.4447 ns |    379.369 ns | 23.78 |    0.03 |
|                                                 LinqCount |           [50] |    276.818 ns |   0.1848 ns |   0.1638 ns |    276.782 ns | 17.34 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    337.290 ns |   0.9212 ns |   0.8617 ns |    337.196 ns | 21.13 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    282.761 ns |   5.5544 ns |   9.4319 ns |    278.108 ns | 17.74 |    0.66 |
|                           LowCostLinqWithStructWhereCount |           [50] |    119.499 ns |   0.0476 ns |   0.0445 ns |    119.510 ns |  7.49 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     52.769 ns |   0.0589 ns |   0.0522 ns |     52.754 ns |  3.31 |    0.00 |
|                                               LinqToArray |           [50] |    524.113 ns |   0.1594 ns |   0.1413 ns |    524.088 ns | 32.84 |    0.02 |
|                            LowCostLinqWithDelegateToArray |           [50] |    524.011 ns |   0.3327 ns |   0.2779 ns |    523.973 ns | 32.83 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    483.474 ns |   0.3729 ns |   0.3488 ns |    483.477 ns | 30.29 |    0.03 |
|                              LowCostLinqWithStructToArray |           [50] |    289.300 ns |   0.0657 ns |   0.0615 ns |    289.293 ns | 18.13 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    203.147 ns |   0.0758 ns |   0.0672 ns |    203.147 ns | 12.73 |    0.01 |
|                                                      Take |           [50] |    411.574 ns |   0.1218 ns |   0.1139 ns |    411.553 ns | 25.79 |    0.01 |
|                                               LowCostTake |           [50] |    173.570 ns |   3.4245 ns |   5.5299 ns |    170.572 ns | 10.95 |    0.38 |
|                                  LowCostTakeWithoutChecks |           [50] |    136.419 ns |   2.4299 ns |   1.8971 ns |    135.480 ns |  8.55 |    0.12 |
|                                     LowCostTakeWithStruct |           [50] |     96.901 ns |   0.0176 ns |   0.0156 ns |     96.899 ns |  6.07 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     65.625 ns |   0.0177 ns |   0.0165 ns |     65.631 ns |  4.11 |    0.00 |
|                                            SkipTakeSingle |           [50] |    306.679 ns |   0.0937 ns |   0.0876 ns |    306.689 ns | 19.22 |    0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    180.908 ns |   3.5313 ns |   3.4682 ns |    179.816 ns | 11.33 |    0.22 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    152.296 ns |   3.0228 ns |   5.6776 ns |    148.620 ns |  9.57 |    0.37 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     93.928 ns |   0.0424 ns |   0.0376 ns |     93.933 ns |  5.89 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     68.223 ns |   0.0164 ns |   0.0153 ns |     68.216 ns |  4.27 |    0.00 |
|                                           ForeachDelegate |           [50] |    234.754 ns |   0.0413 ns |   0.0386 ns |    234.746 ns | 14.71 |    0.01 |
|                                                   Foreach |           [50] |    104.414 ns |   0.0181 ns |   0.0169 ns |    104.408 ns |  6.54 |    0.00 |
|                                                       For |           [50] |     15.960 ns |   0.0086 ns |   0.0081 ns |     15.959 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **116.713 ns** |   **0.0248 ns** |   **0.0220 ns** |    **116.715 ns** | **20.24** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     56.936 ns |   1.0054 ns |   0.8395 ns |     56.417 ns |  9.87 |    0.14 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     49.762 ns |   1.0112 ns |   1.9960 ns |     48.445 ns |  8.79 |    0.35 |
|                                  LowCostLinqWithDelegate2 |            [5] |     88.264 ns |   0.3127 ns |   0.2772 ns |     88.242 ns | 15.31 |    0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     68.937 ns |   1.3702 ns |   1.9651 ns |     68.646 ns | 11.96 |    0.34 |
|                                LowCostLinqWithStructWhere |            [5] |     46.637 ns |   0.0469 ns |   0.0366 ns |     46.626 ns |  8.09 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     36.451 ns |   0.1107 ns |   0.1036 ns |     36.464 ns |  6.32 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    159.221 ns |   0.1778 ns |   0.1663 ns |    159.166 ns | 27.61 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    143.078 ns |   0.1431 ns |   0.1338 ns |    143.026 ns | 24.81 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     91.351 ns |   0.0253 ns |   0.0237 ns |     91.355 ns | 15.84 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     81.222 ns |   0.0738 ns |   0.0654 ns |     81.189 ns | 14.09 |    0.01 |
|                                                 LinqCount |            [5] |     86.357 ns |   0.1702 ns |   0.1592 ns |     86.392 ns | 14.98 |    0.03 |
|                              LowCostLinqWithDelegateCount |            [5] |     58.622 ns |   1.4237 ns |   1.6396 ns |     57.906 ns | 10.21 |    0.32 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     49.080 ns |   1.0021 ns |   1.9546 ns |     48.341 ns |  8.52 |    0.38 |
|                           LowCostLinqWithStructWhereCount |            [5] |     37.062 ns |   0.0164 ns |   0.0153 ns |     37.057 ns |  6.43 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     24.185 ns |   0.0048 ns |   0.0044 ns |     24.184 ns |  4.19 |    0.00 |
|                                               LinqToArray |            [5] |    146.522 ns |   0.4333 ns |   0.4053 ns |    146.489 ns | 25.41 |    0.07 |
|                            LowCostLinqWithDelegateToArray |            [5] |     99.312 ns |   0.0515 ns |   0.0457 ns |     99.303 ns | 17.22 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     90.228 ns |   0.0388 ns |   0.0344 ns |     90.228 ns | 15.65 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     73.075 ns |   0.1518 ns |   0.1420 ns |     73.032 ns | 12.67 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     59.808 ns |   0.0211 ns |   0.0198 ns |     59.806 ns | 10.37 |    0.01 |
|                                                      Take |            [5] |    198.052 ns |   0.2083 ns |   0.1949 ns |    197.989 ns | 34.35 |    0.03 |
|                                               LowCostTake |            [5] |     65.947 ns |   1.7918 ns |   1.6761 ns |     65.044 ns | 11.44 |    0.29 |
|                                  LowCostTakeWithoutChecks |            [5] |     59.223 ns |   1.2089 ns |   1.9522 ns |     58.980 ns | 10.30 |    0.36 |
|                                     LowCostTakeWithStruct |            [5] |     52.831 ns |   0.0111 ns |   0.0104 ns |     52.830 ns |  9.16 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     43.564 ns |   0.0169 ns |   0.0141 ns |     43.563 ns |  7.55 |    0.01 |
|                                            SkipTakeSingle |            [5] |    169.428 ns |   0.2283 ns |   0.2135 ns |    169.303 ns | 29.38 |    0.04 |
|                                     LowCostSkipTakeSingle |            [5] |     70.013 ns |   1.3746 ns |   1.8351 ns |     70.139 ns | 12.08 |    0.38 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     59.695 ns |   0.1149 ns |   0.1019 ns |     59.689 ns | 10.35 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     57.840 ns |   0.0194 ns |   0.0182 ns |     57.841 ns | 10.03 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     45.581 ns |   0.0214 ns |   0.0200 ns |     45.575 ns |  7.90 |    0.00 |
|                                           ForeachDelegate |            [5] |     36.565 ns |   0.0169 ns |   0.0150 ns |     36.564 ns |  6.34 |    0.00 |
|                                                   Foreach |            [5] |     20.545 ns |   0.0268 ns |   0.0251 ns |     20.536 ns |  3.56 |    0.00 |
|                                                       For |            [5] |      5.766 ns |   0.0031 ns |   0.0029 ns |      5.767 ns |  1.00 |    0.00 |
