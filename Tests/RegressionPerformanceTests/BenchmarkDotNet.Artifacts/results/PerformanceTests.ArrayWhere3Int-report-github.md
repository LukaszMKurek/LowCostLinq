``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |     **81.161 ns** |   **1.2674 ns** |   **1.1235 ns** |     **80.609 ns** | **23.50** |    **0.33** |
|                      LowCostLinqWithDelegate |            [0] |     22.714 ns |   0.0048 ns |   0.0045 ns |     22.713 ns |  6.58 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |     47.255 ns |   0.0102 ns |   0.0096 ns |     47.252 ns | 13.69 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |     35.852 ns |   0.0081 ns |   0.0064 ns |     35.852 ns | 10.38 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     65.574 ns |   0.0299 ns |   0.0265 ns |     65.576 ns | 18.99 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     42.966 ns |   0.0217 ns |   0.0203 ns |     42.969 ns | 12.44 |    0.01 |
|                                    LinqCount |            [0] |     79.671 ns |   0.0333 ns |   0.0312 ns |     79.668 ns | 23.07 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [0] |     25.025 ns |   0.2760 ns |   0.2582 ns |     24.844 ns |  7.25 |    0.07 |
|              LowCostLinqWithStructWhereCount |            [0] |     28.429 ns |   0.0113 ns |   0.0100 ns |     28.430 ns |  8.23 |    0.01 |
|                                  LinqToArray |            [0] |     98.611 ns |   0.1504 ns |   0.1406 ns |     98.547 ns | 28.56 |    0.04 |
|               LowCostLinqWithDelegateToArray |            [0] |     28.517 ns |   0.0214 ns |   0.0200 ns |     28.514 ns |  8.26 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |     32.396 ns |   0.4460 ns |   0.4171 ns |     32.468 ns |  9.38 |    0.12 |
|                                         Take |            [0] |    120.137 ns |   0.0552 ns |   0.0490 ns |    120.137 ns | 34.79 |    0.03 |
|                                  LowCostTake |            [0] |     31.981 ns |   0.0053 ns |   0.0050 ns |     31.981 ns |  9.26 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |     42.051 ns |   0.0110 ns |   0.0098 ns |     42.052 ns | 12.18 |    0.01 |
|                               SkipTakeSingle |            [0] |    139.224 ns |   0.8434 ns |   0.7043 ns |    138.927 ns | 40.32 |    0.21 |
|                        LowCostSkipTakeSingle |            [0] |     41.321 ns |   0.0144 ns |   0.0134 ns |     41.322 ns | 11.97 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     48.188 ns |   0.0033 ns |   0.0031 ns |     48.188 ns | 13.96 |    0.01 |
|                              ForeachDelegate |            [0] |      7.310 ns |   0.0111 ns |   0.0098 ns |      7.308 ns |  2.12 |    0.00 |
|                                      Foreach |            [0] |      3.662 ns |   0.0558 ns |   0.0522 ns |      3.665 ns |  1.06 |    0.02 |
|                                          For |            [0] |      3.453 ns |   0.0023 ns |   0.0022 ns |      3.454 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |         **[1000]** | **10,478.117 ns** |  **54.1794 ns** |  **45.2423 ns** | **10,481.552 ns** | **41.82** |    **0.18** |
|                      LowCostLinqWithDelegate |         [1000] |  7,914.844 ns | 113.7964 ns | 106.4452 ns |  7,998.186 ns | 31.64 |    0.44 |
|                     LowCostLinqWithDelegate2 |         [1000] |  7,978.297 ns | 162.2724 ns | 222.1203 ns |  8,016.837 ns | 32.05 |    0.81 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,475.639 ns |   0.3463 ns |   0.3070 ns |  1,475.548 ns |  5.89 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 18,637.366 ns | 266.0665 ns | 235.8610 ns | 18,613.411 ns | 74.31 |    0.93 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,780.443 ns |   2.1085 ns |   1.6462 ns |  5,780.591 ns | 23.07 |    0.01 |
|                                    LinqCount |         [1000] |  7,122.442 ns |  34.3629 ns |  32.1431 ns |  7,130.109 ns | 28.42 |    0.14 |
|                 LowCostLinqWithDelegateCount |         [1000] |  6,478.268 ns | 128.4222 ns | 120.1262 ns |  6,481.286 ns | 25.88 |    0.51 |
|              LowCostLinqWithStructWhereCount |         [1000] |  1,344.758 ns |   0.6793 ns |   0.6354 ns |  1,344.892 ns |  5.37 |    0.00 |
|                                  LinqToArray |         [1000] |  8,063.019 ns |  16.3389 ns |  15.2834 ns |  8,070.041 ns | 32.20 |    0.05 |
|               LowCostLinqWithDelegateToArray |         [1000] |  9,381.974 ns |  11.7908 ns |   9.8459 ns |  9,382.210 ns | 37.45 |    0.04 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,433.805 ns |   2.2108 ns |   2.0680 ns |  2,433.219 ns |  9.71 |    0.01 |
|                                         Take |         [1000] |    429.073 ns |   0.2311 ns |   0.1930 ns |    428.979 ns |  1.71 |    0.00 |
|                                  LowCostTake |         [1000] |    186.848 ns |   2.1886 ns |   1.9401 ns |    186.506 ns |  0.75 |    0.01 |
|                        LowCostTakeWithStruct |         [1000] |     75.796 ns |   0.0178 ns |   0.0139 ns |     75.796 ns |  0.30 |    0.00 |
|                               SkipTakeSingle |         [1000] |    348.025 ns |   0.1838 ns |   0.1719 ns |    347.983 ns |  1.39 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    206.046 ns |   3.9403 ns |   4.2161 ns |    205.813 ns |  0.82 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     72.728 ns |   0.1620 ns |   0.1516 ns |     72.763 ns |  0.29 |    0.00 |
|                              ForeachDelegate |         [1000] |  4,302.089 ns |   0.9149 ns |   0.8110 ns |  4,301.882 ns | 17.17 |    0.01 |
|                                      Foreach |         [1000] |    464.973 ns |   5.9498 ns |   5.5654 ns |    462.820 ns |  1.86 |    0.02 |
|                                          For |         [1000] |    250.548 ns |   0.0687 ns |   0.0573 ns |    250.541 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |           **[50]** |    **613.120 ns** |   **0.3485 ns** |   **0.3260 ns** |    **613.097 ns** | **38.48** |    **0.06** |
|                      LowCostLinqWithDelegate |           [50] |    425.572 ns |   8.4232 ns |   7.8790 ns |    424.336 ns | 26.71 |    0.50 |
|                     LowCostLinqWithDelegate2 |           [50] |    454.891 ns |   6.4281 ns |   6.0128 ns |    457.138 ns | 28.55 |    0.39 |
|                   LowCostLinqWithStructWhere |           [50] |    105.750 ns |   0.0811 ns |   0.0759 ns |    105.732 ns |  6.64 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    994.435 ns |   1.2459 ns |   1.1654 ns |    994.004 ns | 62.40 |    0.07 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    341.007 ns |   6.1705 ns |   5.7719 ns |    340.430 ns | 21.40 |    0.37 |
|                                    LinqCount |           [50] |    441.299 ns |   0.3539 ns |   0.3310 ns |    441.251 ns | 27.69 |    0.05 |
|                 LowCostLinqWithDelegateCount |           [50] |    347.618 ns |   7.4283 ns |   6.9484 ns |    348.816 ns | 21.81 |    0.45 |
|              LowCostLinqWithStructWhereCount |           [50] |     78.731 ns |   0.1096 ns |   0.0971 ns |     78.704 ns |  4.94 |    0.01 |
|                                  LinqToArray |           [50] |    690.259 ns |   1.0195 ns |   0.9536 ns |    690.095 ns | 43.32 |    0.09 |
|               LowCostLinqWithDelegateToArray |           [50] |    590.342 ns |   0.6321 ns |   0.5278 ns |    590.333 ns | 37.05 |    0.06 |
|                 LowCostLinqWithStructToArray |           [50] |    211.579 ns |   0.5725 ns |   0.5355 ns |    211.790 ns | 13.28 |    0.04 |
|                                         Take |           [50] |    442.622 ns |   8.8078 ns |   8.2388 ns |    437.022 ns | 27.78 |    0.52 |
|                                  LowCostTake |           [50] |    189.445 ns |   2.3034 ns |   2.1546 ns |    189.322 ns | 11.89 |    0.14 |
|                        LowCostTakeWithStruct |           [50] |     75.919 ns |   0.1522 ns |   0.1424 ns |     75.985 ns |  4.76 |    0.01 |
|                               SkipTakeSingle |           [50] |    352.755 ns |   7.0360 ns |   7.8205 ns |    347.272 ns | 22.23 |    0.52 |
|                        LowCostSkipTakeSingle |           [50] |    205.560 ns |   3.9637 ns |   3.7076 ns |    205.595 ns | 12.90 |    0.22 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     70.782 ns |   0.0911 ns |   0.0852 ns |     70.763 ns |  4.44 |    0.01 |
|                              ForeachDelegate |           [50] |    227.358 ns |   1.9056 ns |   1.7825 ns |    226.369 ns | 14.27 |    0.12 |
|                                      Foreach |           [50] |     26.353 ns |   0.2354 ns |   0.1966 ns |     26.420 ns |  1.65 |    0.01 |
|                                          For |           [50] |     15.935 ns |   0.0250 ns |   0.0234 ns |     15.942 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |            **[5]** |    **139.718 ns** |   **0.0594 ns** |   **0.0555 ns** |    **139.718 ns** | **29.05** |    **0.03** |
|                      LowCostLinqWithDelegate |            [5] |     61.194 ns |   1.2861 ns |   2.1489 ns |     60.508 ns | 13.03 |    0.50 |
|                     LowCostLinqWithDelegate2 |            [5] |     85.707 ns |   0.9433 ns |   0.8823 ns |     85.492 ns | 17.82 |    0.18 |
|                   LowCostLinqWithStructWhere |            [5] |     43.489 ns |   0.0112 ns |   0.0093 ns |     43.489 ns |  9.04 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    162.018 ns |   3.1434 ns |   4.0873 ns |    159.780 ns | 34.01 |    0.96 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     71.615 ns |   0.0535 ns |   0.0500 ns |     71.617 ns | 14.89 |    0.01 |
|                                    LinqCount |            [5] |    123.501 ns |   0.0661 ns |   0.0618 ns |    123.520 ns | 25.68 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [5] |     56.680 ns |   0.7687 ns |   0.7191 ns |     56.624 ns | 11.78 |    0.15 |
|              LowCostLinqWithStructWhereCount |            [5] |     31.687 ns |   0.0932 ns |   0.0826 ns |     31.649 ns |  6.59 |    0.02 |
|                                  LinqToArray |            [5] |    182.892 ns |   0.0718 ns |   0.0637 ns |    182.900 ns | 38.03 |    0.03 |
|               LowCostLinqWithDelegateToArray |            [5] |     99.091 ns |   0.0391 ns |   0.0366 ns |     99.087 ns | 20.60 |    0.02 |
|                 LowCostLinqWithStructToArray |            [5] |     66.988 ns |   1.2955 ns |   1.2118 ns |     66.192 ns | 13.93 |    0.26 |
|                                         Take |            [5] |    215.672 ns |   0.5930 ns |   0.5547 ns |    215.559 ns | 44.84 |    0.12 |
|                                  LowCostTake |            [5] |     66.929 ns |   1.3452 ns |   1.3814 ns |     66.682 ns | 13.90 |    0.29 |
|                        LowCostTakeWithStruct |            [5] |     51.473 ns |   0.0189 ns |   0.0158 ns |     51.469 ns | 10.70 |    0.01 |
|                               SkipTakeSingle |            [5] |    196.123 ns |   0.9183 ns |   0.7668 ns |    195.824 ns | 40.78 |    0.16 |
|                        LowCostSkipTakeSingle |            [5] |     72.395 ns |   1.1936 ns |   1.1164 ns |     72.748 ns | 15.05 |    0.23 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     52.987 ns |   0.0248 ns |   0.0232 ns |     52.980 ns | 11.02 |    0.01 |
|                              ForeachDelegate |            [5] |     30.860 ns |   0.6229 ns |   0.7877 ns |     30.586 ns |  6.47 |    0.18 |
|                                      Foreach |            [5] |      5.528 ns |   0.0121 ns |   0.0113 ns |      5.525 ns |  1.15 |    0.00 |
|                                          For |            [5] |      4.810 ns |   0.0043 ns |   0.0041 ns |      4.810 ns |  1.00 |    0.00 |
