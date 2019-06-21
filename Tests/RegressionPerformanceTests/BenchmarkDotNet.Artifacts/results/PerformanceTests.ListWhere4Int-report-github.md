``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **150.515 ns** |   **0.0782 ns** |   **0.0732 ns** |    **150.484 ns** | **37.97** |    **0.03** |
|                                   LowCostLinqWithDelegate |            [0] |     38.871 ns |   0.0076 ns |   0.0071 ns |     38.872 ns |  9.80 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     32.042 ns |   0.0086 ns |   0.0072 ns |     32.039 ns |  8.08 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     66.079 ns |   0.0144 ns |   0.0128 ns |     66.082 ns | 16.67 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     57.546 ns |   0.0109 ns |   0.0102 ns |     57.543 ns | 14.52 |    0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     49.379 ns |   0.3940 ns |   0.3686 ns |     49.098 ns | 12.45 |    0.09 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     42.605 ns |   0.0060 ns |   0.0056 ns |     42.603 ns | 10.75 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     79.055 ns |   0.0717 ns |   0.0560 ns |     79.064 ns | 19.94 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     76.594 ns |   0.0337 ns |   0.0315 ns |     76.585 ns | 19.32 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     81.420 ns |   1.2398 ns |   1.1597 ns |     80.676 ns | 20.54 |    0.30 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     78.032 ns |   0.0182 ns |   0.0171 ns |     78.025 ns | 19.68 |    0.01 |
|                                                 LinqCount |            [0] |    123.173 ns |   0.0559 ns |   0.0496 ns |    123.172 ns | 31.07 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     31.209 ns |   0.0095 ns |   0.0089 ns |     31.207 ns |  7.87 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     29.793 ns |   0.4821 ns |   0.4510 ns |     29.759 ns |  7.51 |    0.11 |
|                           LowCostLinqWithStructWhereCount |            [0] |     44.027 ns |   0.0059 ns |   0.0055 ns |     44.024 ns | 11.11 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.774 ns |   0.0072 ns |   0.0067 ns |     36.773 ns |  9.28 |    0.00 |
|                                               LinqToArray |            [0] |    135.106 ns |   0.0480 ns |   0.0449 ns |    135.109 ns | 34.08 |    0.02 |
|                            LowCostLinqWithDelegateToArray |            [0] |     35.264 ns |   0.5972 ns |   0.5586 ns |     35.692 ns |  8.89 |    0.14 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     33.305 ns |   0.0125 ns |   0.0111 ns |     33.307 ns |  8.40 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     47.896 ns |   0.0081 ns |   0.0068 ns |     47.896 ns | 12.08 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     40.505 ns |   0.7844 ns |   0.7337 ns |     40.060 ns | 10.22 |    0.19 |
|                                                      Take |            [0] |    162.476 ns |   0.0476 ns |   0.0445 ns |    162.465 ns | 40.98 |    0.02 |
|                                               LowCostTake |            [0] |     52.363 ns |   0.0112 ns |   0.0104 ns |     52.362 ns | 13.21 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     44.549 ns |   0.3243 ns |   0.2875 ns |     44.408 ns | 11.24 |    0.07 |
|                                     LowCostTakeWithStruct |            [0] |     62.851 ns |   0.0115 ns |   0.0096 ns |     62.854 ns | 15.85 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     56.243 ns |   0.0070 ns |   0.0065 ns |     56.246 ns | 14.19 |    0.01 |
|                                            SkipTakeSingle |            [0] |    186.192 ns |   0.0584 ns |   0.0546 ns |    186.184 ns | 46.96 |    0.02 |
|                                     LowCostSkipTakeSingle |            [0] |     62.036 ns |   0.7855 ns |   0.7348 ns |     61.559 ns | 15.65 |    0.19 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     59.410 ns |   0.0060 ns |   0.0050 ns |     59.409 ns | 14.98 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     69.291 ns |   0.0173 ns |   0.0162 ns |     69.294 ns | 17.48 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     67.171 ns |   0.0037 ns |   0.0033 ns |     67.170 ns | 16.94 |    0.01 |
|                                           ForeachDelegate |            [0] |     16.531 ns |   0.2233 ns |   0.2089 ns |     16.384 ns |  4.17 |    0.05 |
|                                                   Foreach |            [0] |     12.618 ns |   0.0195 ns |   0.0182 ns |     12.616 ns |  3.18 |    0.01 |
|                                                       For |            [0] |      3.965 ns |   0.0017 ns |   0.0016 ns |      3.965 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** | **14,730.771 ns** | **215.6415 ns** | **180.0704 ns** | **14,670.087 ns** | **58.66** |    **0.72** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,553.661 ns |  43.5059 ns |  33.9666 ns | 11,557.436 ns | 46.01 |    0.14 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,876.623 ns | 510.6934 ns | 501.5692 ns | 10,622.628 ns | 43.38 |    2.05 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,507.465 ns | 321.6316 ns | 943.2897 ns | 11,521.643 ns | 46.69 |    3.71 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 11,515.024 ns | 312.1730 ns | 920.4491 ns | 11,387.827 ns | 45.59 |    2.46 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,854.129 ns |   0.2656 ns |   0.2484 ns |  1,854.103 ns |  7.38 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,745.063 ns |   0.3118 ns |   0.2917 ns |  1,745.202 ns |  6.95 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 22,760.415 ns | 449.8961 ns | 939.1007 ns | 22,511.237 ns | 92.34 |    4.33 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,864.618 ns |  83.4084 ns |  65.1198 ns | 19,838.104 ns | 79.10 |    0.25 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,355.225 ns |  70.2664 ns |  65.7272 ns |  6,319.762 ns | 25.31 |    0.26 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  5,588.265 ns |   4.4160 ns |   4.1307 ns |  5,588.293 ns | 22.25 |    0.02 |
|                                                 LinqCount |         [1000] |  9,951.292 ns | 196.0227 ns | 343.3180 ns | 10,079.475 ns | 39.71 |    1.30 |
|                              LowCostLinqWithDelegateCount |         [1000] | 11,137.426 ns | 222.3009 ns | 549.4728 ns | 11,373.660 ns | 45.85 |    2.23 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 11,257.505 ns | 278.8595 ns | 817.8467 ns | 11,575.227 ns | 43.81 |    3.28 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,743.931 ns |   0.5995 ns |   0.5314 ns |  1,743.930 ns |  6.94 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,225.168 ns |   0.6011 ns |   0.5329 ns |  1,225.294 ns |  4.88 |    0.00 |
|                                               LinqToArray |         [1000] | 11,162.662 ns | 217.1106 ns | 304.3588 ns | 10,991.960 ns | 45.02 |    1.39 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 13,430.686 ns |  56.1757 ns |  52.5468 ns | 13,413.969 ns | 53.48 |    0.20 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 13,066.145 ns |  11.0662 ns |  10.3513 ns | 13,068.040 ns | 52.03 |    0.05 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,388.409 ns |   0.6866 ns |   0.6086 ns |  3,388.394 ns | 13.49 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,509.768 ns |   0.9427 ns |   0.8357 ns |  2,509.917 ns |  9.99 |    0.00 |
|                                                      Take |         [1000] |    542.719 ns |   1.2355 ns |   1.1557 ns |    542.604 ns |  2.16 |    0.01 |
|                                               LowCostTake |         [1000] |    331.508 ns |   6.6494 ns |   9.1017 ns |    333.426 ns |  1.32 |    0.04 |
|                                  LowCostTakeWithoutChecks |         [1000] |    307.151 ns |   6.1689 ns |  14.7804 ns |    312.483 ns |  1.16 |    0.07 |
|                                     LowCostTakeWithStruct |         [1000] |    112.089 ns |   0.0230 ns |   0.0216 ns |    112.096 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     98.052 ns |   0.0103 ns |   0.0097 ns |     98.051 ns |  0.39 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    479.554 ns |   9.3848 ns |  10.4312 ns |    473.126 ns |  1.91 |    0.04 |
|                                     LowCostSkipTakeSingle |         [1000] |    336.106 ns |   0.6315 ns |   0.5274 ns |    336.087 ns |  1.34 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    318.555 ns |   4.2666 ns |   3.3311 ns |    317.190 ns |  1.27 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    146.124 ns |   0.0130 ns |   0.0115 ns |    146.122 ns |  0.58 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    121.463 ns |   1.2543 ns |   1.1733 ns |    121.802 ns |  0.48 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,947.295 ns |   2.0772 ns |   1.9430 ns |  6,947.105 ns | 27.66 |    0.01 |
|                                                   Foreach |         [1000] |  1,690.635 ns |   0.0477 ns |   0.0372 ns |  1,690.631 ns |  6.73 |    0.00 |
|                                                       For |         [1000] |    251.131 ns |   0.0574 ns |   0.0537 ns |    251.120 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **882.773 ns** |   **3.3303 ns** |   **3.1151 ns** |    **882.924 ns** | **50.85** |    **0.63** |
|                                   LowCostLinqWithDelegate |           [50] |    633.312 ns |  12.5031 ns |  25.2569 ns |    640.544 ns | 36.86 |    1.57 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    595.051 ns |  13.8838 ns |  40.7189 ns |    607.119 ns | 35.14 |    1.40 |
|                                  LowCostLinqWithDelegate2 |           [50] |    653.169 ns |  14.9514 ns |  42.4147 ns |    658.981 ns | 36.90 |    2.84 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    588.565 ns |   9.0876 ns |   7.0950 ns |    587.487 ns | 33.83 |    0.63 |
|                                LowCostLinqWithStructWhere |           [50] |    148.560 ns |   0.0107 ns |   0.0089 ns |    148.561 ns |  8.55 |    0.10 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    129.052 ns |   0.0497 ns |   0.0440 ns |    129.062 ns |  7.43 |    0.09 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,215.280 ns |  23.4243 ns |  23.0058 ns |  1,223.965 ns | 69.93 |    1.75 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,092.717 ns |  13.4780 ns |  11.9479 ns |  1,087.772 ns | 62.90 |    0.88 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    423.278 ns |   0.0716 ns |   0.0670 ns |    423.290 ns | 24.38 |    0.29 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    361.181 ns |   0.4816 ns |   0.4021 ns |    361.069 ns | 20.78 |    0.26 |
|                                                 LinqCount |           [50] |    586.648 ns |   1.0382 ns |   0.8669 ns |    586.659 ns | 33.75 |    0.40 |
|                              LowCostLinqWithDelegateCount |           [50] |    606.418 ns |  12.1393 ns |  29.7779 ns |    612.653 ns | 34.23 |    1.93 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    551.853 ns |  20.1839 ns |  25.5262 ns |    538.766 ns | 32.22 |    1.34 |
|                           LowCostLinqWithStructWhereCount |           [50] |    136.306 ns |   0.0607 ns |   0.0568 ns |    136.259 ns |  7.85 |    0.09 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     92.703 ns |   0.1646 ns |   0.1540 ns |     92.764 ns |  5.34 |    0.06 |
|                                               LinqToArray |           [50] |    927.830 ns |   1.6690 ns |   1.3937 ns |    928.206 ns | 53.38 |    0.63 |
|                            LowCostLinqWithDelegateToArray |           [50] |    793.770 ns |   1.9811 ns |   1.8531 ns |    793.070 ns | 45.73 |    0.52 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    800.666 ns |   2.2067 ns |   2.0642 ns |    801.177 ns | 46.12 |    0.50 |
|                              LowCostLinqWithStructToArray |           [50] |    282.321 ns |   4.9940 ns |   4.6714 ns |    279.437 ns | 16.26 |    0.11 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    233.440 ns |   0.0910 ns |   0.0760 ns |    233.419 ns | 13.43 |    0.16 |
|                                                      Take |           [50] |    542.668 ns |   1.3844 ns |   1.2950 ns |    541.870 ns | 31.26 |    0.32 |
|                                               LowCostTake |           [50] |    329.240 ns |   6.5842 ns |  18.5709 ns |    333.773 ns | 19.25 |    0.67 |
|                                  LowCostTakeWithoutChecks |           [50] |    310.802 ns |   8.7826 ns |  25.7577 ns |    308.722 ns | 17.17 |    0.56 |
|                                     LowCostTakeWithStruct |           [50] |    113.358 ns |   0.0153 ns |   0.0135 ns |    113.359 ns |  6.53 |    0.08 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     99.901 ns |   0.0131 ns |   0.0109 ns |     99.898 ns |  5.75 |    0.07 |
|                                            SkipTakeSingle |           [50] |    473.510 ns |   0.7622 ns |   0.6365 ns |    473.368 ns | 27.24 |    0.33 |
|                                     LowCostSkipTakeSingle |           [50] |    344.545 ns |   8.8705 ns |  15.3011 ns |    336.863 ns | 19.93 |    0.96 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    317.162 ns |   0.9950 ns |   0.7769 ns |    317.184 ns | 18.23 |    0.21 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    148.411 ns |   1.7127 ns |   1.6021 ns |    148.344 ns |  8.55 |    0.17 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    120.449 ns |   0.0787 ns |   0.0698 ns |    120.438 ns |  6.93 |    0.08 |
|                                           ForeachDelegate |           [50] |    370.076 ns |   0.1209 ns |   0.1131 ns |    370.048 ns | 21.32 |    0.26 |
|                                                   Foreach |           [50] |    102.872 ns |   0.0451 ns |   0.0400 ns |    102.855 ns |  5.92 |    0.07 |
|                                                       For |           [50] |     17.362 ns |   0.2219 ns |   0.2076 ns |     17.239 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **233.922 ns** |   **0.0594 ns** |   **0.0527 ns** |    **233.926 ns** | **42.06** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |     96.670 ns |   2.9858 ns |   3.0662 ns |     95.075 ns | 17.37 |    0.56 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     83.360 ns |   2.2310 ns |   6.5431 ns |     81.638 ns | 15.10 |    1.30 |
|                                  LowCostLinqWithDelegate2 |            [5] |    130.256 ns |   3.0202 ns |   6.6295 ns |    126.108 ns | 23.49 |    0.97 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    115.498 ns |   2.5382 ns |   7.4839 ns |    115.587 ns | 19.79 |    0.77 |
|                                LowCostLinqWithStructWhere |            [5] |     58.662 ns |   0.0166 ns |   0.0139 ns |     58.662 ns | 10.55 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     52.039 ns |   0.4993 ns |   0.4671 ns |     51.762 ns |  9.34 |    0.07 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    198.715 ns |   0.1743 ns |   0.1630 ns |    198.726 ns | 35.74 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    188.249 ns |   0.3761 ns |   0.3334 ns |    188.301 ns | 33.85 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    113.905 ns |   2.1046 ns |   1.9687 ns |    112.525 ns | 20.52 |    0.37 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    104.877 ns |   0.0511 ns |   0.0478 ns |    104.880 ns | 18.86 |    0.01 |
|                                                 LinqCount |            [5] |    170.747 ns |   0.0798 ns |   0.0666 ns |    170.755 ns | 30.70 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |     86.623 ns |   1.7416 ns |   3.5577 ns |     87.882 ns | 16.05 |    0.37 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    113.249 ns |   8.2254 ns |  24.2527 ns |    127.972 ns | 22.17 |    2.96 |
|                           LowCostLinqWithStructWhereCount |            [5] |     51.990 ns |   0.0128 ns |   0.0113 ns |     51.993 ns |  9.35 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     40.540 ns |   0.0629 ns |   0.0588 ns |     40.550 ns |  7.29 |    0.00 |
|                                               LinqToArray |            [5] |    249.507 ns |   3.6369 ns |   3.4019 ns |    247.956 ns | 44.91 |    0.64 |
|                            LowCostLinqWithDelegateToArray |            [5] |    129.600 ns |   0.1939 ns |   0.1719 ns |    129.631 ns | 23.31 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    123.921 ns |   0.1266 ns |   0.1184 ns |    123.918 ns | 22.28 |    0.02 |
|                              LowCostLinqWithStructToArray |            [5] |     89.153 ns |   0.0376 ns |   0.0352 ns |     89.158 ns | 16.03 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     75.255 ns |   0.0232 ns |   0.0194 ns |     75.254 ns | 13.53 |    0.00 |
|                                                      Take |            [5] |    276.886 ns |   0.2084 ns |   0.1949 ns |    276.814 ns | 49.79 |    0.04 |
|                                               LowCostTake |            [5] |    113.671 ns |   2.2964 ns |   3.7083 ns |    114.192 ns | 20.27 |    0.69 |
|                                  LowCostTakeWithoutChecks |            [5] |    116.935 ns |   1.3581 ns |   1.2704 ns |    116.897 ns | 20.99 |    0.22 |
|                                     LowCostTakeWithStruct |            [5] |     76.343 ns |   0.0182 ns |   0.0171 ns |     76.341 ns | 13.73 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     69.085 ns |   0.0129 ns |   0.0121 ns |     69.087 ns | 12.42 |    0.00 |
|                                            SkipTakeSingle |            [5] |    267.256 ns |   5.1250 ns |   6.1010 ns |    263.365 ns | 48.51 |    1.19 |
|                                     LowCostSkipTakeSingle |            [5] |    146.158 ns |   2.9481 ns |   5.8192 ns |    148.363 ns | 26.63 |    0.24 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    117.922 ns |   2.1397 ns |   1.7867 ns |    116.885 ns | 21.20 |    0.32 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     85.309 ns |   0.0349 ns |   0.0327 ns |     85.303 ns | 15.34 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     78.294 ns |   0.1721 ns |   0.1610 ns |     78.211 ns | 14.07 |    0.02 |
|                                           ForeachDelegate |            [5] |     50.498 ns |   0.0384 ns |   0.0360 ns |     50.487 ns |  9.08 |    0.01 |
|                                                   Foreach |            [5] |     21.067 ns |   0.4412 ns |   0.4531 ns |     21.017 ns |  3.81 |    0.08 |
|                                                       For |            [5] |      5.561 ns |   0.0018 ns |   0.0015 ns |      5.561 ns |  1.00 |    0.00 |
