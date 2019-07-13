``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **66.541 ns** |   **0.0222 ns** |   **0.0208 ns** |     **66.531 ns** | **16.82** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     27.439 ns |   0.0026 ns |   0.0024 ns |     27.439 ns |  6.94 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     20.278 ns |   0.0030 ns |   0.0028 ns |     20.277 ns |  5.13 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     41.399 ns |   0.0914 ns |   0.0810 ns |     41.450 ns | 10.47 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     38.177 ns |   0.0111 ns |   0.0103 ns |     38.180 ns |  9.65 |    0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     36.046 ns |   0.0051 ns |   0.0048 ns |     36.047 ns |  9.11 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     28.172 ns |   0.0045 ns |   0.0042 ns |     28.171 ns |  7.12 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     53.030 ns |   1.0129 ns |   0.9475 ns |     52.341 ns | 13.41 |    0.24 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     52.301 ns |   0.0115 ns |   0.0102 ns |     52.300 ns | 13.22 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     37.957 ns |   0.0215 ns |   0.0201 ns |     37.953 ns |  9.60 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     38.119 ns |   0.0223 ns |   0.0197 ns |     38.119 ns |  9.64 |    0.01 |
|                                                 LinqCount |            [0] |     63.658 ns |   0.0308 ns |   0.0273 ns |     63.653 ns | 16.09 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     25.745 ns |   0.0478 ns |   0.0447 ns |     25.759 ns |  6.51 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     23.776 ns |   0.0122 ns |   0.0108 ns |     23.779 ns |  6.01 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     29.433 ns |   0.5108 ns |   0.4778 ns |     29.118 ns |  7.44 |    0.12 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     21.014 ns |   0.0049 ns |   0.0043 ns |     21.012 ns |  5.31 |    0.00 |
|                                               LinqToArray |            [0] |     75.580 ns |   0.0858 ns |   0.0802 ns |     75.598 ns | 19.11 |    0.03 |
|                            LowCostLinqWithDelegateToArray |            [0] |     28.933 ns |   0.0988 ns |   0.0924 ns |     28.914 ns |  7.31 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     26.884 ns |   0.4560 ns |   0.4266 ns |     26.559 ns |  6.80 |    0.11 |
|                              LowCostLinqWithStructToArray |            [0] |     31.909 ns |   0.0047 ns |   0.0039 ns |     31.909 ns |  8.07 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     24.650 ns |   0.0054 ns |   0.0050 ns |     24.649 ns |  6.23 |    0.00 |
|                                                      Take |            [0] |    105.304 ns |   2.1053 ns |   2.0677 ns |    103.855 ns | 26.65 |    0.53 |
|                                               LowCostTake |            [0] |     34.916 ns |   0.0131 ns |   0.0116 ns |     34.918 ns |  8.83 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     29.596 ns |   0.0064 ns |   0.0060 ns |     29.595 ns |  7.48 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     42.714 ns |   0.0542 ns |   0.0507 ns |     42.729 ns | 10.80 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     35.656 ns |   0.3907 ns |   0.3463 ns |     35.631 ns |  9.01 |    0.09 |
|                                            SkipTakeSingle |            [0] |    123.133 ns |   0.0439 ns |   0.0410 ns |    123.128 ns | 31.13 |    0.03 |
|                                     LowCostSkipTakeSingle |            [0] |     39.366 ns |   0.0047 ns |   0.0044 ns |     39.366 ns |  9.95 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     37.473 ns |   0.0051 ns |   0.0047 ns |     37.473 ns |  9.47 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     48.633 ns |   0.0169 ns |   0.0132 ns |     48.628 ns | 12.29 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     40.887 ns |   0.0068 ns |   0.0064 ns |     40.886 ns | 10.34 |    0.01 |
|                                           ForeachDelegate |            [0] |     15.725 ns |   0.0163 ns |   0.0153 ns |     15.727 ns |  3.98 |    0.00 |
|                                                   Foreach |            [0] |     12.642 ns |   0.2591 ns |   0.2424 ns |     12.521 ns |  3.20 |    0.06 |
|                                                       For |            [0] |      3.956 ns |   0.0030 ns |   0.0028 ns |      3.956 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** |  **9,319.221 ns** |   **6.7329 ns** |   **5.6222 ns** |  **9,320.087 ns** | **37.17** |    **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] |  5,794.384 ns | 120.5769 ns | 123.8236 ns |  5,796.773 ns | 23.08 |    0.55 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,154.309 ns | 120.1918 ns | 179.8974 ns |  6,158.792 ns | 24.60 |    0.81 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,295.086 ns |  72.5396 ns |  64.3045 ns |  6,278.875 ns | 25.10 |    0.26 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,287.984 ns | 125.3226 ns | 198.7749 ns |  6,243.133 ns | 25.08 |    0.62 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,840.332 ns |   0.3433 ns |   0.3211 ns |  1,840.170 ns |  7.34 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,364.918 ns |   0.1637 ns |   0.1531 ns |  1,364.893 ns |  5.44 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 16,632.873 ns | 332.0040 ns | 355.2406 ns | 16,600.018 ns | 66.85 |    1.34 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 15,945.377 ns | 188.5811 ns | 176.3989 ns | 15,985.883 ns | 63.66 |    0.70 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  4,826.047 ns |   1.5400 ns |   1.3652 ns |  4,825.854 ns | 19.25 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  4,107.248 ns |   0.5679 ns |   0.5034 ns |  4,107.270 ns | 16.38 |    0.00 |
|                                                 LinqCount |         [1000] |  4,149.023 ns |   2.8086 ns |   2.4898 ns |  4,149.353 ns | 16.55 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,119.533 ns | 121.0021 ns | 124.2602 ns |  6,142.892 ns | 24.49 |    0.50 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,115.862 ns | 101.2548 ns | 108.3415 ns |  5,093.511 ns | 20.54 |    0.41 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,706.267 ns |   0.3659 ns |   0.3423 ns |  1,706.140 ns |  6.81 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    624.748 ns |   0.1419 ns |   0.1327 ns |    624.782 ns |  2.49 |    0.00 |
|                                               LinqToArray |         [1000] |  5,343.677 ns |   6.6531 ns |   6.2233 ns |  5,343.967 ns | 21.31 |    0.02 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  6,810.605 ns |   9.8776 ns |   8.7562 ns |  6,810.399 ns | 27.17 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,511.754 ns |  14.9695 ns |  12.5002 ns |  6,509.808 ns | 25.97 |    0.05 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,119.613 ns |   6.0279 ns |   5.6385 ns |  3,120.334 ns | 12.44 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,902.554 ns |   1.4371 ns |   1.1220 ns |  1,902.586 ns |  7.59 |    0.00 |
|                                                      Take |         [1000] |    417.828 ns |   7.9668 ns |   8.5244 ns |    412.052 ns |  1.66 |    0.03 |
|                                               LowCostTake |         [1000] |    163.297 ns |   3.1534 ns |   3.9881 ns |    163.571 ns |  0.65 |    0.02 |
|                                  LowCostTakeWithoutChecks |         [1000] |    144.945 ns |   2.8224 ns |   2.8984 ns |    143.997 ns |  0.58 |    0.01 |
|                                     LowCostTakeWithStruct |         [1000] |     84.018 ns |   0.0199 ns |   0.0176 ns |     84.022 ns |  0.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     67.189 ns |   0.0245 ns |   0.0204 ns |     67.183 ns |  0.27 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    305.155 ns |   0.1172 ns |   0.1039 ns |    305.171 ns |  1.22 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    179.145 ns |   3.5202 ns |   4.1906 ns |    178.710 ns |  0.71 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    162.682 ns |   3.1884 ns |   4.2565 ns |    162.369 ns |  0.65 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     91.683 ns |   0.0389 ns |   0.0344 ns |     91.682 ns |  0.37 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     68.518 ns |   0.0884 ns |   0.0827 ns |     68.504 ns |  0.27 |    0.00 |
|                                           ForeachDelegate |         [1000] |  4,387.904 ns |   1.1890 ns |   1.1122 ns |  4,387.608 ns | 17.50 |    0.01 |
|                                                   Foreach |         [1000] |  1,694.346 ns |   2.9201 ns |   2.7314 ns |  1,694.572 ns |  6.76 |    0.01 |
|                                                       For |         [1000] |    250.716 ns |   0.0493 ns |   0.0411 ns |    250.706 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **549.803 ns** |   **0.1941 ns** |   **0.1721 ns** |    **549.743 ns** | **33.61** |    **0.06** |
|                                   LowCostLinqWithDelegate |           [50] |    335.922 ns |   6.6459 ns |  12.3187 ns |    335.480 ns | 20.78 |    0.67 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    312.360 ns |   5.8930 ns |   5.5123 ns |    309.976 ns | 19.10 |    0.35 |
|                                  LowCostLinqWithDelegate2 |           [50] |    386.438 ns |   7.6635 ns |  13.2191 ns |    384.131 ns | 23.42 |    0.72 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    330.812 ns |   3.4517 ns |   3.2287 ns |    330.973 ns | 20.24 |    0.20 |
|                                LowCostLinqWithStructWhere |           [50] |    135.633 ns |   0.0538 ns |   0.0503 ns |    135.645 ns |  8.29 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    104.085 ns |   0.1189 ns |   0.1112 ns |    104.119 ns |  6.36 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    873.610 ns |   1.6933 ns |   1.5011 ns |    873.747 ns | 53.40 |    0.13 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    840.808 ns |   0.3339 ns |   0.2788 ns |    840.800 ns | 51.39 |    0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    285.146 ns |   0.1125 ns |   0.1053 ns |    285.156 ns | 17.43 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    255.673 ns |   4.7280 ns |   4.4226 ns |    255.816 ns | 15.65 |    0.26 |
|                                                 LinqCount |           [50] |    275.913 ns |   0.3422 ns |   0.3201 ns |    275.924 ns | 16.87 |    0.03 |
|                              LowCostLinqWithDelegateCount |           [50] |    340.400 ns |   6.7211 ns |   6.9021 ns |    337.895 ns | 20.86 |    0.46 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    281.101 ns |   5.6446 ns |   7.9130 ns |    279.000 ns | 17.29 |    0.42 |
|                           LowCostLinqWithStructWhereCount |           [50] |    120.309 ns |   0.2134 ns |   0.1782 ns |    120.316 ns |  7.35 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     53.542 ns |   0.1569 ns |   0.1468 ns |     53.585 ns |  3.27 |    0.01 |
|                                               LinqToArray |           [50] |    527.648 ns |   0.1936 ns |   0.1717 ns |    527.628 ns | 32.25 |    0.05 |
|                            LowCostLinqWithDelegateToArray |           [50] |    478.098 ns |   0.6912 ns |   0.6465 ns |    478.330 ns | 29.22 |    0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    468.787 ns |   0.2347 ns |   0.2195 ns |    468.760 ns | 28.66 |    0.04 |
|                              LowCostLinqWithStructToArray |           [50] |    256.788 ns |   0.1536 ns |   0.1437 ns |    256.780 ns | 15.70 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    197.668 ns |   0.0874 ns |   0.0775 ns |    197.668 ns | 12.08 |    0.02 |
|                                                      Take |           [50] |    418.709 ns |   7.9340 ns |   7.7922 ns |    413.625 ns | 25.65 |    0.48 |
|                                               LowCostTake |           [50] |    160.320 ns |   2.4349 ns |   2.2776 ns |    160.573 ns |  9.79 |    0.14 |
|                                  LowCostTakeWithoutChecks |           [50] |    145.632 ns |   2.8976 ns |   3.9663 ns |    144.362 ns |  8.93 |    0.28 |
|                                     LowCostTakeWithStruct |           [50] |     84.975 ns |   1.2892 ns |   1.2059 ns |     84.212 ns |  5.19 |    0.08 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     80.564 ns |   0.0441 ns |   0.0391 ns |     80.563 ns |  4.92 |    0.01 |
|                                            SkipTakeSingle |           [50] |    307.041 ns |   0.3490 ns |   0.3264 ns |    307.125 ns | 18.77 |    0.03 |
|                                     LowCostSkipTakeSingle |           [50] |    182.540 ns |   3.6278 ns |   4.5879 ns |    182.846 ns | 11.27 |    0.27 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    153.382 ns |   2.9122 ns |   2.5816 ns |    152.763 ns |  9.38 |    0.17 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     91.414 ns |   0.0379 ns |   0.0336 ns |     91.414 ns |  5.59 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     68.468 ns |   0.0708 ns |   0.0663 ns |     68.467 ns |  4.19 |    0.01 |
|                                           ForeachDelegate |           [50] |    240.314 ns |   0.1400 ns |   0.1310 ns |    240.283 ns | 14.69 |    0.02 |
|                                                   Foreach |           [50] |    144.974 ns |   0.0578 ns |   0.0540 ns |    144.987 ns |  8.86 |    0.01 |
|                                                       For |           [50] |     16.359 ns |   0.0298 ns |   0.0264 ns |     16.352 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **116.398 ns** |   **0.0238 ns** |   **0.0222 ns** |    **116.404 ns** | **20.97** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |     56.261 ns |   0.4101 ns |   0.3424 ns |     56.142 ns | 10.14 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     50.907 ns |   1.0083 ns |   0.9903 ns |     51.011 ns |  9.16 |    0.17 |
|                                  LowCostLinqWithDelegate2 |            [5] |     74.296 ns |   0.7410 ns |   0.6932 ns |     74.153 ns | 13.39 |    0.12 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     69.450 ns |   1.4124 ns |   1.6265 ns |     69.627 ns | 12.52 |    0.27 |
|                                LowCostLinqWithStructWhere |            [5] |     46.791 ns |   0.0170 ns |   0.0150 ns |     46.791 ns |  8.43 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     37.268 ns |   0.0438 ns |   0.0366 ns |     37.267 ns |  6.71 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    133.687 ns |   0.1589 ns |   0.1327 ns |    133.657 ns | 24.09 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    129.360 ns |   0.0564 ns |   0.0528 ns |    129.365 ns | 23.31 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     62.160 ns |   0.0332 ns |   0.0295 ns |     62.163 ns | 11.20 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     59.133 ns |   0.0291 ns |   0.0258 ns |     59.133 ns | 10.65 |    0.01 |
|                                                 LinqCount |            [5] |     85.499 ns |   0.0648 ns |   0.0606 ns |     85.488 ns | 15.40 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |     59.937 ns |   1.2104 ns |   2.0223 ns |     59.628 ns | 10.96 |    0.38 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     48.143 ns |   0.3728 ns |   0.3487 ns |     48.134 ns |  8.67 |    0.07 |
|                           LowCostLinqWithStructWhereCount |            [5] |     37.002 ns |   0.0154 ns |   0.0144 ns |     37.005 ns |  6.67 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     24.372 ns |   0.2925 ns |   0.2736 ns |     24.252 ns |  4.39 |    0.05 |
|                                               LinqToArray |            [5] |    145.464 ns |   0.0743 ns |   0.0658 ns |    145.452 ns | 26.21 |    0.02 |
|                            LowCostLinqWithDelegateToArray |            [5] |    106.755 ns |   0.0391 ns |   0.0366 ns |    106.748 ns | 19.23 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     98.921 ns |   0.0840 ns |   0.0702 ns |     98.907 ns | 17.82 |    0.02 |
|                              LowCostLinqWithStructToArray |            [5] |     85.166 ns |   0.0368 ns |   0.0326 ns |     85.181 ns | 15.34 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     68.447 ns |   0.0387 ns |   0.0362 ns |     68.451 ns | 12.33 |    0.01 |
|                                                      Take |            [5] |    198.614 ns |   0.0708 ns |   0.0628 ns |    198.616 ns | 35.78 |    0.03 |
|                                               LowCostTake |            [5] |     65.499 ns |   1.3449 ns |   2.0938 ns |     64.434 ns | 12.01 |    0.46 |
|                                  LowCostTakeWithoutChecks |            [5] |     57.954 ns |   1.0593 ns |   0.9909 ns |     58.246 ns | 10.44 |    0.18 |
|                                     LowCostTakeWithStruct |            [5] |     53.071 ns |   0.0164 ns |   0.0153 ns |     53.074 ns |  9.56 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     44.365 ns |   0.4510 ns |   0.3998 ns |     44.190 ns |  7.99 |    0.07 |
|                                            SkipTakeSingle |            [5] |    163.581 ns |   0.0594 ns |   0.0555 ns |    163.570 ns | 29.47 |    0.03 |
|                                     LowCostSkipTakeSingle |            [5] |     70.455 ns |   0.8949 ns |   0.8371 ns |     70.489 ns | 12.69 |    0.15 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     60.453 ns |   1.0616 ns |   0.9930 ns |     60.429 ns | 10.89 |    0.18 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     58.805 ns |   1.1585 ns |   1.0836 ns |     58.070 ns | 10.59 |    0.19 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     45.737 ns |   0.0278 ns |   0.0260 ns |     45.737 ns |  8.24 |    0.01 |
|                                           ForeachDelegate |            [5] |     37.153 ns |   0.5858 ns |   0.5480 ns |     37.180 ns |  6.69 |    0.10 |
|                                                   Foreach |            [5] |     20.818 ns |   0.2771 ns |   0.2592 ns |     20.632 ns |  3.75 |    0.05 |
|                                                       For |            [5] |      5.550 ns |   0.0048 ns |   0.0044 ns |      5.550 ns |  1.00 |    0.00 |
