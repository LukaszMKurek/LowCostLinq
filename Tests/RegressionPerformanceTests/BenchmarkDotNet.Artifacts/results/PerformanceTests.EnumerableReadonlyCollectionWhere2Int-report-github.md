``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **82.08 ns** |   **0.0336 ns** |   **0.0314 ns** |  **4.44** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     50.30 ns |   0.0107 ns |   0.0089 ns |  2.72 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     40.05 ns |   0.0160 ns |   0.0142 ns |  2.17 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     58.54 ns |   0.0915 ns |   0.0811 ns |  3.17 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     55.17 ns |   0.0291 ns |   0.0272 ns |  2.98 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     52.26 ns |   0.0121 ns |   0.0113 ns |  2.83 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     47.89 ns |   0.0545 ns |   0.0483 ns |  2.59 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    120.52 ns |   0.0481 ns |   0.0426 ns |  6.52 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    105.03 ns |   0.0746 ns |   0.0662 ns |  5.68 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    108.92 ns |   0.0513 ns |   0.0480 ns |  5.89 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     91.84 ns |   0.0266 ns |   0.0249 ns |  4.97 |    0.00 |
|                                                 LinqCount |            [0] |     82.46 ns |   0.0251 ns |   0.0235 ns |  4.46 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     48.23 ns |   0.0222 ns |   0.0208 ns |  2.61 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     48.82 ns |   0.0643 ns |   0.0602 ns |  2.64 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     42.36 ns |   0.0288 ns |   0.0269 ns |  2.29 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     42.77 ns |   0.0145 ns |   0.0136 ns |  2.31 |    0.00 |
|                                               LinqToArray |            [0] |     98.14 ns |   0.1786 ns |   0.1670 ns |  5.31 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     64.19 ns |   0.0441 ns |   0.0413 ns |  3.47 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     65.62 ns |   0.1108 ns |   0.1036 ns |  3.55 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     55.60 ns |   0.0235 ns |   0.0209 ns |  3.01 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     54.33 ns |   0.0213 ns |   0.0189 ns |  2.94 |    0.00 |
|                                                      Take |            [0] |    119.24 ns |   0.0548 ns |   0.0513 ns |  6.45 |    0.00 |
|                                               LowCostTake |            [0] |     51.87 ns |   0.0091 ns |   0.0081 ns |  2.80 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     47.35 ns |   0.0729 ns |   0.0682 ns |  2.56 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     58.67 ns |   0.0186 ns |   0.0165 ns |  3.17 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     53.99 ns |   0.0136 ns |   0.0128 ns |  2.92 |    0.00 |
|                                            SkipTakeSingle |            [0] |    140.04 ns |   0.0459 ns |   0.0407 ns |  7.57 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     62.57 ns |   0.0491 ns |   0.0459 ns |  3.38 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     63.44 ns |   0.0233 ns |   0.0217 ns |  3.43 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     64.32 ns |   0.0223 ns |   0.0186 ns |  3.48 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     65.30 ns |   0.0211 ns |   0.0198 ns |  3.53 |    0.00 |
|                                           ForeachDelegate |            [0] |     21.75 ns |   0.0343 ns |   0.0321 ns |  1.18 |    0.00 |
|                                                   Foreach |            [0] |     18.49 ns |   0.0121 ns |   0.0113 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |       |         |
|                                                      **Linq** |         **[1000]** | **14,280.08 ns** |   **3.0162 ns** |   **2.5187 ns** |  **2.58** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,310.94 ns | 223.5766 ns | 198.1948 ns |  2.05 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 14,057.17 ns | 273.3702 ns | 400.7025 ns |  2.54 |    0.08 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 14,624.86 ns | 150.1938 ns | 140.4914 ns |  2.65 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 12,609.85 ns | 237.2628 ns | 316.7391 ns |  2.26 |    0.05 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,515.48 ns |  13.2819 ns |  12.4239 ns |  1.36 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,518.39 ns |   2.1723 ns |   1.9257 ns |  1.18 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 26,295.35 ns | 518.6504 ns | 576.4786 ns |  4.74 |    0.10 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 24,627.16 ns |  62.9591 ns |  55.8116 ns |  4.46 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 13,042.49 ns |   4.5359 ns |   4.2428 ns |  2.36 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 13,519.88 ns |  11.1784 ns |  10.4562 ns |  2.45 |    0.00 |
|                                                 LinqCount |         [1000] |  9,316.33 ns |   3.6108 ns |   3.3776 ns |  1.69 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 11,218.58 ns |  88.1611 ns |  78.1525 ns |  2.03 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,515.31 ns |  54.3459 ns |  42.4297 ns |  1.90 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,803.12 ns |   1.9975 ns |   1.8684 ns |  1.05 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,563.17 ns |   1.5411 ns |   1.2869 ns |  1.01 |    0.00 |
|                                               LinqToArray |         [1000] | 11,568.91 ns |  10.3660 ns |   9.1891 ns |  2.09 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,753.22 ns |  20.6583 ns |  19.3238 ns |  2.13 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,653.59 ns |   4.6685 ns |   4.3669 ns |  2.11 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,562.21 ns |  11.7646 ns |  11.0046 ns |  1.37 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,520.83 ns |   8.3333 ns |   7.7950 ns |  1.36 |    0.00 |
|                                                      Take |         [1000] |    518.16 ns |   0.2668 ns |   0.2496 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |    301.65 ns |   0.5070 ns |   0.4743 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    299.73 ns |   5.9374 ns |  10.3988 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    206.18 ns |   0.0434 ns |   0.0406 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    194.30 ns |   0.3203 ns |   0.2996 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    401.92 ns |   0.0722 ns |   0.0675 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    326.90 ns |   1.6457 ns |   1.5394 ns |  0.06 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    316.91 ns |   0.2700 ns |   0.2255 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    205.38 ns |   0.1832 ns |   0.1624 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    205.50 ns |   0.0873 ns |   0.0817 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,797.00 ns |   3.8042 ns |   3.5585 ns |  1.59 |    0.00 |
|                                                   Foreach |         [1000] |  5,526.62 ns |   1.7015 ns |   1.5916 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |       |         |
|                                                      **Linq** |           **[50]** |    **801.18 ns** |   **0.2785 ns** |   **0.2605 ns** |  **2.66** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    602.59 ns |   7.7555 ns |   7.2545 ns |  2.00 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    659.27 ns |  12.7148 ns |  11.8934 ns |  2.19 |    0.04 |
|                                  LowCostLinqWithDelegate2 |           [50] |    667.14 ns |   1.1358 ns |   1.0625 ns |  2.21 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    684.22 ns |   1.3186 ns |   1.1011 ns |  2.27 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    431.31 ns |   0.0730 ns |   0.0647 ns |  1.43 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    381.28 ns |   0.1827 ns |   0.1709 ns |  1.26 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,466.50 ns |   6.7894 ns |   6.3508 ns |  4.86 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,367.05 ns |  11.6076 ns |  10.8578 ns |  4.53 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    771.00 ns |   1.3345 ns |   1.2483 ns |  2.56 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    777.13 ns |   0.1979 ns |   0.1851 ns |  2.58 |    0.00 |
|                                                 LinqCount |           [50] |    557.72 ns |   0.2740 ns |   0.2563 ns |  1.85 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    586.59 ns |   4.4004 ns |   4.1161 ns |  1.95 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    587.24 ns |   1.1184 ns |   0.9339 ns |  1.95 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    342.27 ns |   0.0722 ns |   0.0564 ns |  1.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    332.78 ns |   0.0923 ns |   0.0818 ns |  1.10 |    0.00 |
|                                               LinqToArray |           [50] |    867.48 ns |   3.3446 ns |   3.1286 ns |  2.88 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    750.81 ns |   0.1988 ns |   0.1860 ns |  2.49 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    763.60 ns |   0.2538 ns |   0.2374 ns |  2.53 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    529.82 ns |   0.2721 ns |   0.2545 ns |  1.76 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    530.51 ns |   0.7621 ns |   0.7129 ns |  1.76 |    0.00 |
|                                                      Take |           [50] |    514.75 ns |   0.2050 ns |   0.1918 ns |  1.71 |    0.00 |
|                                               LowCostTake |           [50] |    302.28 ns |   1.7130 ns |   1.6023 ns |  1.00 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    272.33 ns |   1.1974 ns |   0.9348 ns |  0.90 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    205.11 ns |   0.1945 ns |   0.1724 ns |  0.68 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    194.57 ns |   0.0701 ns |   0.0656 ns |  0.65 |    0.00 |
|                                            SkipTakeSingle |           [50] |    404.10 ns |   0.1231 ns |   0.1151 ns |  1.34 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    299.27 ns |   3.7597 ns |   3.5169 ns |  0.99 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    316.41 ns |   0.4482 ns |   0.3743 ns |  1.05 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    204.05 ns |   0.0558 ns |   0.0494 ns |  0.68 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    205.86 ns |   0.1436 ns |   0.1343 ns |  0.68 |    0.00 |
|                                           ForeachDelegate |           [50] |    463.85 ns |   0.2743 ns |   0.2566 ns |  1.54 |    0.00 |
|                                                   Foreach |           [50] |    301.46 ns |   0.0717 ns |   0.0670 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |       |         |
|                                                      **Linq** |            **[5]** |    **154.57 ns** |   **0.0584 ns** |   **0.0546 ns** |  **3.32** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    110.58 ns |   0.1457 ns |   0.1363 ns |  2.38 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    110.50 ns |   0.2622 ns |   0.2453 ns |  2.37 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |    124.03 ns |   0.2112 ns |   0.1975 ns |  2.66 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    126.15 ns |   0.1692 ns |   0.1582 ns |  2.71 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     86.17 ns |   0.0294 ns |   0.0275 ns |  1.85 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     75.55 ns |   0.0382 ns |   0.0358 ns |  1.62 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    265.75 ns |   0.1628 ns |   0.1523 ns |  5.71 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    240.43 ns |   0.2183 ns |   0.2042 ns |  5.16 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    189.97 ns |   0.8913 ns |   0.8337 ns |  4.08 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    171.07 ns |   0.0424 ns |   0.0354 ns |  3.67 |    0.00 |
|                                                 LinqCount |            [5] |    130.94 ns |   0.0383 ns |   0.0320 ns |  2.81 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    101.14 ns |   0.1848 ns |   0.1638 ns |  2.17 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    100.86 ns |   0.1061 ns |   0.0940 ns |  2.17 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     70.00 ns |   0.0311 ns |   0.0291 ns |  1.50 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     69.08 ns |   0.0321 ns |   0.0284 ns |  1.48 |    0.00 |
|                                               LinqToArray |            [5] |    210.44 ns |   0.0950 ns |   0.0889 ns |  4.52 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    147.76 ns |   0.0685 ns |   0.0641 ns |  3.17 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    150.98 ns |   0.0341 ns |   0.0302 ns |  3.24 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    119.52 ns |   0.0603 ns |   0.0503 ns |  2.57 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    120.19 ns |   0.0449 ns |   0.0420 ns |  2.58 |    0.00 |
|                                                      Take |            [5] |    235.69 ns |   0.0546 ns |   0.0511 ns |  5.06 |    0.00 |
|                                               LowCostTake |            [5] |    119.44 ns |   0.1911 ns |   0.1787 ns |  2.57 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    110.27 ns |   0.1884 ns |   0.1762 ns |  2.37 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     90.31 ns |   0.0846 ns |   0.0791 ns |  1.94 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     84.92 ns |   0.0337 ns |   0.0315 ns |  1.82 |    0.00 |
|                                            SkipTakeSingle |            [5] |    216.58 ns |   0.3420 ns |   0.3199 ns |  4.65 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    114.30 ns |   0.2556 ns |   0.2391 ns |  2.46 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    119.25 ns |   0.0875 ns |   0.0819 ns |  2.56 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     95.73 ns |   0.2001 ns |   0.1872 ns |  2.06 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     94.50 ns |   0.0281 ns |   0.0263 ns |  2.03 |    0.00 |
|                                           ForeachDelegate |            [5] |     64.99 ns |   0.0289 ns |   0.0270 ns |  1.40 |    0.00 |
|                                                   Foreach |            [5] |     46.56 ns |   0.0184 ns |   0.0172 ns |  1.00 |    0.00 |
