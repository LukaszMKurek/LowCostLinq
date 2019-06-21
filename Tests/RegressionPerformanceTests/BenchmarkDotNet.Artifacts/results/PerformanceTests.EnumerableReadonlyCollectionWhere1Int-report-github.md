``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **49.44 ns** |   **1.0093 ns** |   **1.0365 ns** |     **48.77 ns** |  **2.73** |    **0.06** |
|                                   LowCostLinqWithDelegate |            [0] |     48.38 ns |   0.0578 ns |   0.0513 ns |     48.38 ns |  2.66 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     39.87 ns |   0.0131 ns |   0.0123 ns |     39.87 ns |  2.20 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [0] |     51.71 ns |   0.7414 ns |   0.6935 ns |     51.18 ns |  2.85 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     48.53 ns |   0.0070 ns |   0.0058 ns |     48.53 ns |  2.67 |    0.04 |
|                                LowCostLinqWithStructWhere |            [0] |     45.16 ns |   0.0287 ns |   0.0269 ns |     45.15 ns |  2.49 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     43.11 ns |   0.4101 ns |   0.3425 ns |     42.98 ns |  2.37 |    0.04 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     96.78 ns |   0.0171 ns |   0.0151 ns |     96.78 ns |  5.33 |    0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     91.34 ns |   0.0289 ns |   0.0271 ns |     91.34 ns |  5.03 |    0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    100.08 ns |   0.0283 ns |   0.0264 ns |    100.08 ns |  5.51 |    0.07 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     92.19 ns |   0.0222 ns |   0.0208 ns |     92.18 ns |  5.08 |    0.07 |
|                                                 LinqCount |            [0] |     48.88 ns |   0.0183 ns |   0.0172 ns |     48.88 ns |  2.69 |    0.04 |
|                              LowCostLinqWithDelegateCount |            [0] |     46.77 ns |   0.0292 ns |   0.0273 ns |     46.77 ns |  2.58 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     46.08 ns |   0.1217 ns |   0.0950 ns |     46.08 ns |  2.53 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |     36.70 ns |   0.0272 ns |   0.0255 ns |     36.71 ns |  2.02 |    0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     35.98 ns |   0.0199 ns |   0.0177 ns |     35.98 ns |  1.98 |    0.03 |
|                                               LinqToArray |            [0] |     66.17 ns |   0.0587 ns |   0.0490 ns |     66.18 ns |  3.64 |    0.05 |
|                            LowCostLinqWithDelegateToArray |            [0] |     58.05 ns |   0.8170 ns |   0.7643 ns |     57.62 ns |  3.20 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     56.19 ns |   0.0096 ns |   0.0080 ns |     56.19 ns |  3.09 |    0.04 |
|                              LowCostLinqWithStructToArray |            [0] |     47.36 ns |   0.0199 ns |   0.0177 ns |     47.37 ns |  2.61 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     49.12 ns |   0.0730 ns |   0.0570 ns |     49.09 ns |  2.70 |    0.04 |
|                                                      Take |            [0] |     84.26 ns |   0.0150 ns |   0.0133 ns |     84.26 ns |  4.64 |    0.06 |
|                                               LowCostTake |            [0] |     50.71 ns |   0.0088 ns |   0.0078 ns |     50.71 ns |  2.79 |    0.04 |
|                                  LowCostTakeWithoutChecks |            [0] |     50.93 ns |   0.0358 ns |   0.0317 ns |     50.94 ns |  2.80 |    0.04 |
|                                     LowCostTakeWithStruct |            [0] |     52.93 ns |   0.0613 ns |   0.0573 ns |     52.95 ns |  2.92 |    0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     51.23 ns |   0.0193 ns |   0.0171 ns |     51.22 ns |  2.82 |    0.04 |
|                                            SkipTakeSingle |            [0] |    109.18 ns |   0.0377 ns |   0.0294 ns |    109.18 ns |  6.00 |    0.08 |
|                                     LowCostSkipTakeSingle |            [0] |     57.51 ns |   0.0279 ns |   0.0261 ns |     57.51 ns |  3.17 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     58.25 ns |   0.0096 ns |   0.0089 ns |     58.25 ns |  3.21 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     54.68 ns |   0.0276 ns |   0.0231 ns |     54.67 ns |  3.01 |    0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     55.06 ns |   0.0443 ns |   0.0393 ns |     55.07 ns |  3.03 |    0.04 |
|                                           ForeachDelegate |            [0] |     20.29 ns |   0.0119 ns |   0.0106 ns |     20.29 ns |  1.12 |    0.01 |
|                                                   Foreach |            [0] |     18.15 ns |   0.2595 ns |   0.2427 ns |     17.98 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **11,740.49 ns** | **192.4108 ns** | **179.9812 ns** | **11,669.59 ns** |  **2.13** |    **0.03** |
|                                   LowCostLinqWithDelegate |         [1000] |  8,857.89 ns |  38.8053 ns |  36.2985 ns |  8,850.04 ns |  1.61 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,663.52 ns |   3.2211 ns |   2.8554 ns |  8,662.87 ns |  1.57 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,117.34 ns |  93.2556 ns |  72.8078 ns |  9,149.10 ns |  1.65 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,890.87 ns |   2.7729 ns |   2.4581 ns |  8,891.74 ns |  1.61 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,522.97 ns |   7.4884 ns |   7.0047 ns |  6,525.69 ns |  1.18 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,972.81 ns |   2.0078 ns |   1.7798 ns |  6,972.37 ns |  1.26 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 15,418.55 ns |   9.8351 ns |   9.1997 ns | 15,415.70 ns |  2.80 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 15,619.52 ns | 234.2527 ns | 219.1201 ns | 15,468.84 ns |  2.83 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 13,015.87 ns |   4.8317 ns |   4.2832 ns | 13,015.67 ns |  2.36 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 13,732.35 ns |   5.6455 ns |   5.2808 ns | 13,731.88 ns |  2.49 |    0.00 |
|                                                 LinqCount |         [1000] |  7,330.66 ns | 116.2900 ns | 108.7778 ns |  7,262.24 ns |  1.33 |    0.02 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,703.30 ns |   1.6498 ns |   1.4625 ns |  7,703.71 ns |  1.40 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,234.57 ns |   1.5462 ns |   1.4463 ns |  7,234.46 ns |  1.31 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,538.18 ns |   3.5670 ns |   3.3366 ns |  5,536.61 ns |  1.00 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,080.87 ns |  86.3524 ns |  80.7741 ns |  6,016.94 ns |  1.10 |    0.01 |
|                                               LinqToArray |         [1000] |  9,453.67 ns |   6.2118 ns |   5.8105 ns |  9,452.80 ns |  1.71 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,988.96 ns |   4.7880 ns |   4.4787 ns |  8,989.64 ns |  1.63 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 10,054.05 ns |  22.3616 ns |  20.9171 ns | 10,054.24 ns |  1.82 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,889.92 ns | 135.1737 ns | 126.4416 ns |  7,924.69 ns |  1.43 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,585.62 ns |   8.2275 ns |   7.6960 ns |  7,586.96 ns |  1.38 |    0.00 |
|                                                      Take |         [1000] |    429.58 ns |   0.0884 ns |   0.0783 ns |    429.58 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    243.35 ns |   0.4260 ns |   0.3326 ns |    243.24 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    232.62 ns |   0.0491 ns |   0.0436 ns |    232.63 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    198.53 ns |   0.1103 ns |   0.1032 ns |    198.53 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    192.51 ns |   0.0679 ns |   0.0602 ns |    192.50 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    323.36 ns |   0.0818 ns |   0.0765 ns |    323.35 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    244.89 ns |   0.1526 ns |   0.1427 ns |    244.87 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    237.98 ns |   0.0797 ns |   0.0745 ns |    237.99 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    196.73 ns |   0.0482 ns |   0.0402 ns |    196.74 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    198.58 ns |   0.3573 ns |   0.3342 ns |    198.47 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,712.81 ns |   1.7470 ns |   1.6342 ns |  6,712.64 ns |  1.22 |    0.00 |
|                                                   Foreach |         [1000] |  5,516.10 ns |   0.6622 ns |   0.6194 ns |  5,516.06 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **645.70 ns** |   **8.6816 ns** |   **8.1207 ns** |    **640.62 ns** |  **2.12** |    **0.03** |
|                                   LowCostLinqWithDelegate |           [50] |    511.09 ns |   0.9313 ns |   0.8711 ns |    511.31 ns |  1.68 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    477.77 ns |   0.2289 ns |   0.2141 ns |    477.72 ns |  1.57 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    516.68 ns |   1.0902 ns |   1.0198 ns |    516.77 ns |  1.69 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    493.51 ns |   0.1838 ns |   0.1720 ns |    493.53 ns |  1.62 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    372.02 ns |   0.0316 ns |   0.0280 ns |    372.02 ns |  1.22 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    391.60 ns |   0.0837 ns |   0.0742 ns |    391.58 ns |  1.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    892.00 ns |   0.2109 ns |   0.1761 ns |    891.98 ns |  2.93 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    876.24 ns |   0.2456 ns |   0.2177 ns |    876.26 ns |  2.87 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    762.59 ns |   0.2049 ns |   0.1917 ns |    762.56 ns |  2.50 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    793.39 ns |   0.2175 ns |   0.1816 ns |    793.37 ns |  2.60 |    0.00 |
|                                                 LinqCount |           [50] |    416.27 ns |   0.1278 ns |   0.0998 ns |    416.25 ns |  1.37 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    437.77 ns |   0.1098 ns |   0.1027 ns |    437.75 ns |  1.44 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    414.82 ns |   0.1891 ns |   0.1676 ns |    414.74 ns |  1.36 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    318.92 ns |   0.0968 ns |   0.0858 ns |    318.90 ns |  1.05 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    344.62 ns |   0.0668 ns |   0.0592 ns |    344.61 ns |  1.13 |    0.00 |
|                                               LinqToArray |           [50] |    715.26 ns |   0.6568 ns |   0.6143 ns |    715.16 ns |  2.35 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    610.98 ns |   8.4984 ns |   7.9494 ns |    607.10 ns |  2.00 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    670.35 ns |   1.0464 ns |   0.9276 ns |    670.37 ns |  2.20 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    538.14 ns |   0.5241 ns |   0.4646 ns |    538.19 ns |  1.76 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    526.41 ns |   0.7032 ns |   0.6578 ns |    526.64 ns |  1.73 |    0.00 |
|                                                      Take |           [50] |    431.29 ns |   6.0047 ns |   5.6168 ns |    428.10 ns |  1.41 |    0.02 |
|                                               LowCostTake |           [50] |    243.20 ns |   0.0525 ns |   0.0491 ns |    243.19 ns |  0.80 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    232.02 ns |   0.0485 ns |   0.0454 ns |    232.00 ns |  0.76 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    199.88 ns |   2.1078 ns |   1.9716 ns |    198.55 ns |  0.66 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    191.97 ns |   0.0594 ns |   0.0555 ns |    191.95 ns |  0.63 |    0.00 |
|                                            SkipTakeSingle |           [50] |    326.45 ns |   0.1514 ns |   0.1416 ns |    326.40 ns |  1.07 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    245.46 ns |   0.2679 ns |   0.2506 ns |    245.33 ns |  0.80 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    240.01 ns |   3.8679 ns |   3.6180 ns |    237.48 ns |  0.79 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    196.78 ns |   0.0491 ns |   0.0460 ns |    196.79 ns |  0.65 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    198.01 ns |   0.3062 ns |   0.2864 ns |    197.96 ns |  0.65 |    0.00 |
|                                           ForeachDelegate |           [50] |    365.55 ns |   0.0895 ns |   0.0747 ns |    365.54 ns |  1.20 |    0.00 |
|                                                   Foreach |           [50] |    304.94 ns |   0.0951 ns |   0.0889 ns |    304.90 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **107.55 ns** |   **0.0368 ns** |   **0.0326 ns** |    **107.55 ns** |  **2.39** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     87.26 ns |   0.0481 ns |   0.0450 ns |     87.26 ns |  1.94 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     84.34 ns |   1.3628 ns |   1.2747 ns |     83.47 ns |  1.88 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |     94.03 ns |   0.0488 ns |   0.0457 ns |     94.04 ns |  2.09 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     88.74 ns |   0.0453 ns |   0.0424 ns |     88.73 ns |  1.97 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     74.06 ns |   0.1004 ns |   0.0890 ns |     74.08 ns |  1.65 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     72.57 ns |   0.0644 ns |   0.0537 ns |     72.57 ns |  1.62 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    191.17 ns |   0.0989 ns |   0.0877 ns |    191.18 ns |  4.25 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    179.20 ns |   0.0892 ns |   0.0834 ns |    179.19 ns |  3.99 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    177.02 ns |   2.8776 ns |   2.6917 ns |    175.29 ns |  3.93 |    0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    171.98 ns |   0.0669 ns |   0.0626 ns |    171.97 ns |  3.83 |    0.00 |
|                                                 LinqCount |            [5] |     85.31 ns |   0.0391 ns |   0.0366 ns |     85.32 ns |  1.90 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     86.05 ns |   0.0313 ns |   0.0293 ns |     86.06 ns |  1.92 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     84.60 ns |   1.4652 ns |   1.3705 ns |     83.54 ns |  1.88 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [5] |     63.34 ns |   0.0375 ns |   0.0332 ns |     63.33 ns |  1.41 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     67.10 ns |   0.0478 ns |   0.0424 ns |     67.11 ns |  1.49 |    0.00 |
|                                               LinqToArray |            [5] |    167.89 ns |   0.0896 ns |   0.0838 ns |    167.86 ns |  3.74 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    135.67 ns |   2.8316 ns |   2.9079 ns |    133.91 ns |  3.03 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    137.00 ns |   0.0458 ns |   0.0429 ns |    136.99 ns |  3.05 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    116.68 ns |   0.0370 ns |   0.0346 ns |    116.67 ns |  2.60 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    115.80 ns |   0.0406 ns |   0.0360 ns |    115.79 ns |  2.58 |    0.00 |
|                                                      Take |            [5] |    185.43 ns |   2.5216 ns |   2.3587 ns |    183.68 ns |  4.12 |    0.05 |
|                                               LowCostTake |            [5] |     96.45 ns |   0.0217 ns |   0.0181 ns |     96.45 ns |  2.15 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     90.67 ns |   0.0336 ns |   0.0298 ns |     90.67 ns |  2.02 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     87.07 ns |   0.0350 ns |   0.0328 ns |     87.08 ns |  1.94 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     80.53 ns |   0.1918 ns |   0.1794 ns |     80.63 ns |  1.79 |    0.00 |
|                                            SkipTakeSingle |            [5] |    163.74 ns |   0.1301 ns |   0.1217 ns |    163.70 ns |  3.64 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     97.84 ns |   0.0623 ns |   0.0552 ns |     97.85 ns |  2.18 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    100.56 ns |   1.3652 ns |   1.2770 ns |     99.72 ns |  2.24 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     82.68 ns |   0.0435 ns |   0.0407 ns |     82.67 ns |  1.84 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     83.03 ns |   0.0319 ns |   0.0298 ns |     83.03 ns |  1.85 |    0.00 |
|                                           ForeachDelegate |            [5] |     55.40 ns |   0.8528 ns |   0.7977 ns |     54.90 ns |  1.23 |    0.02 |
|                                                   Foreach |            [5] |     44.93 ns |   0.0423 ns |   0.0375 ns |     44.93 ns |  1.00 |    0.00 |
