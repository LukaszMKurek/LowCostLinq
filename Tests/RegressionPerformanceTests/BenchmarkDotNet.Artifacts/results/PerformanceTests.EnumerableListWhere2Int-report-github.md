``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|
|                                                      **Linq** |              **0** |     **64.51 ns** |  **0.0161 ns** |  **0.0126 ns** |   **3.89** |
|                                   LowCostLinqWithDelegate |              0 |     37.68 ns |  0.0008 ns |  0.0007 ns |   2.27 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     30.57 ns |  0.0148 ns |  0.0139 ns |   1.84 |
|                                  LowCostLinqWithDelegate2 |              0 |     50.28 ns |  0.0043 ns |  0.0036 ns |   3.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     47.08 ns |  0.0078 ns |  0.0073 ns |   2.84 |
|                                LowCostLinqWithStructWhere |              0 |     43.01 ns |  0.0052 ns |  0.0043 ns |   2.59 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     40.09 ns |  0.0041 ns |  0.0035 ns |   2.42 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     90.61 ns |  0.0768 ns |  0.0719 ns |   5.46 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     85.67 ns |  0.0116 ns |  0.0097 ns |   5.16 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     80.89 ns |  0.0972 ns |  0.0909 ns |   4.88 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     71.88 ns |  0.0317 ns |  0.0281 ns |   4.33 |
|                                                 LinqCount |              0 |     61.04 ns |  0.0605 ns |  0.0566 ns |   3.68 |
|                              LowCostLinqWithDelegateCount |              0 |     36.29 ns |  0.0178 ns |  0.0166 ns |   2.19 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     34.22 ns |  0.0115 ns |  0.0096 ns |   2.06 |
|                           LowCostLinqWithStructWhereCount |              0 |     37.27 ns |  0.0022 ns |  0.0018 ns |   2.25 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     29.67 ns |  0.0088 ns |  0.0082 ns |   1.79 |
|                                               LinqToArray |              0 |     72.46 ns |  0.1218 ns |  0.1139 ns |   4.37 |
|                            LowCostLinqWithDelegateToArray |              0 |     48.27 ns |  0.0495 ns |  0.0463 ns |   2.91 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     45.02 ns |  0.0342 ns |  0.0320 ns |   2.71 |
|                              LowCostLinqWithStructToArray |              0 |     46.08 ns |  0.0262 ns |  0.0232 ns |   2.78 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     38.67 ns |  0.0153 ns |  0.0136 ns |   2.33 |
|                                                      Take |              0 |     98.20 ns |  0.1394 ns |  0.1304 ns |   5.92 |
|                                               LowCostTake |              0 |     43.10 ns |  0.0029 ns |  0.0024 ns |   2.60 |
|                                  LowCostTakeWithoutChecks |              0 |     40.71 ns |  0.0026 ns |  0.0023 ns |   2.45 |
|                                     LowCostTakeWithStruct |              0 |     49.64 ns |  0.0090 ns |  0.0085 ns |   2.99 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     45.82 ns |  0.0032 ns |  0.0026 ns |   2.76 |
|                                            SkipTakeSingle |              0 |    121.01 ns |  0.1901 ns |  0.1778 ns |   7.30 |
|                                     LowCostSkipTakeSingle |              0 |     51.10 ns |  0.0057 ns |  0.0047 ns |   3.08 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     49.03 ns |  0.0075 ns |  0.0054 ns |   2.96 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     59.81 ns |  0.0187 ns |  0.0156 ns |   3.61 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     51.76 ns |  0.0126 ns |  0.0105 ns |   3.12 |
|                                           ForeachDelegate |              0 |     18.84 ns |  0.0050 ns |  0.0041 ns |   1.14 |
|                                                   Foreach |              0 |     16.59 ns |  0.0183 ns |  0.0172 ns |   1.00 |
|                                                           |                |              |            |            |        |
|                                                      **Linq** |           **1000** |  **9,827.17 ns** | **10.2379 ns** |  **9.5766 ns** |   **1.86** |
|                                   LowCostLinqWithDelegate |           1000 |  7,318.38 ns | 16.8965 ns | 14.1094 ns |   1.39 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,301.52 ns |  8.6397 ns |  8.0816 ns |   1.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  7,415.95 ns | 28.3523 ns | 26.5208 ns |   1.40 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  5,068.15 ns |  2.1236 ns |  1.7733 ns |   0.96 |
|                                LowCostLinqWithStructWhere |           1000 |  2,687.58 ns |  2.0762 ns |  1.8405 ns |   0.51 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,747.49 ns |  0.3454 ns |  0.2884 ns |   0.33 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 19,641.68 ns | 19.5642 ns | 18.3003 ns |   3.72 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 18,279.18 ns | 17.5558 ns | 16.4217 ns |   3.46 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  9,185.37 ns |  7.6142 ns |  7.1223 ns |   1.74 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,945.25 ns |  4.8650 ns |  4.5507 ns |   1.69 |
|                                                 LinqCount |           1000 |  3,668.19 ns |  3.9303 ns |  3.6764 ns |   0.69 |
|                              LowCostLinqWithDelegateCount |           1000 |  5,541.49 ns |  2.1380 ns |  1.8953 ns |   1.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  5,010.63 ns | 16.4796 ns | 15.4150 ns |   0.95 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,740.07 ns |  1.1275 ns |  1.0547 ns |   0.33 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,219.51 ns |  0.0482 ns |  0.0376 ns |   0.23 |
|                                               LinqToArray |           1000 |  5,899.31 ns |  4.9772 ns |  3.8859 ns |   1.12 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,686.47 ns | 12.8876 ns | 12.0551 ns |   1.46 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  6,119.29 ns | 12.5404 ns | 11.7303 ns |   1.16 |
|                              LowCostLinqWithStructToArray |           1000 |  3,394.53 ns |  9.5077 ns |  8.8935 ns |   0.64 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,373.20 ns |  1.8876 ns |  1.4737 ns |   0.45 |
|                                                      Take |           1000 |    371.60 ns |  0.2830 ns |  0.2647 ns |   0.07 |
|                                               LowCostTake |           1000 |    211.06 ns |  0.0753 ns |  0.0668 ns |   0.04 |
|                                  LowCostTakeWithoutChecks |           1000 |    164.26 ns |  0.0286 ns |  0.0239 ns |   0.03 |
|                                     LowCostTakeWithStruct |           1000 |    123.37 ns |  0.0533 ns |  0.0472 ns |   0.02 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     97.71 ns |  0.0191 ns |  0.0170 ns |   0.02 |
|                                            SkipTakeSingle |           1000 |    301.33 ns |  0.2244 ns |  0.2099 ns |   0.06 |
|                                     LowCostSkipTakeSingle |           1000 |    189.12 ns |  0.0864 ns |  0.0766 ns |   0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    166.32 ns |  0.0817 ns |  0.0682 ns |   0.03 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    100.61 ns |  0.0700 ns |  0.0655 ns |   0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     73.07 ns |  0.0425 ns |  0.0398 ns |   0.01 |
|                                           ForeachDelegate |           1000 |  8,620.96 ns |  1.8415 ns |  1.4377 ns |   1.63 |
|                                                   Foreach |           1000 |  5,278.97 ns |  3.5556 ns |  3.3259 ns |   1.00 |
|                                                           |                |              |            |            |        |
|                                                      **Linq** |              **5** |    **114.57 ns** |  **0.0296 ns** |  **0.0248 ns** |   **2.68** |
|                                   LowCostLinqWithDelegate |              5 |     68.51 ns |  0.0466 ns |  0.0308 ns |   1.60 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     53.35 ns |  0.0332 ns |  0.0310 ns |   1.25 |
|                                  LowCostLinqWithDelegate2 |              5 |     79.20 ns |  0.0386 ns |  0.0361 ns |   1.86 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     71.16 ns |  0.0764 ns |  0.0715 ns |   1.67 |
|                                LowCostLinqWithStructWhere |              5 |     56.73 ns |  0.0259 ns |  0.0229 ns |   1.33 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     60.42 ns |  0.0418 ns |  0.0391 ns |   1.42 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    202.24 ns |  0.1792 ns |  0.1589 ns |   4.74 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    189.39 ns |  0.0760 ns |  0.0711 ns |   4.44 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    128.74 ns |  0.2558 ns |  0.2393 ns |   3.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    117.95 ns |  0.1083 ns |  0.1013 ns |   2.76 |
|                                                 LinqCount |              5 |     79.09 ns |  0.1337 ns |  0.1251 ns |   1.85 |
|                              LowCostLinqWithDelegateCount |              5 |     63.76 ns |  0.0219 ns |  0.0194 ns |   1.49 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     58.46 ns |  0.0620 ns |  0.0517 ns |   1.37 |
|                           LowCostLinqWithStructWhereCount |              5 |     45.84 ns |  0.0127 ns |  0.0106 ns |   1.07 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     33.28 ns |  0.0247 ns |  0.0231 ns |   0.78 |
|                                               LinqToArray |              5 |    139.96 ns |  0.1584 ns |  0.1481 ns |   3.28 |
|                            LowCostLinqWithDelegateToArray |              5 |    116.56 ns |  0.1164 ns |  0.1089 ns |   2.73 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    106.13 ns |  0.0969 ns |  0.0906 ns |   2.49 |
|                              LowCostLinqWithStructToArray |              5 |     92.97 ns |  0.0755 ns |  0.0706 ns |   2.18 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     82.10 ns |  0.0511 ns |  0.0453 ns |   1.92 |
|                                                      Take |              5 |    178.72 ns |  0.0732 ns |  0.0685 ns |   4.19 |
|                                               LowCostTake |              5 |     75.68 ns |  0.0616 ns |  0.0546 ns |   1.77 |
|                                  LowCostTakeWithoutChecks |              5 |     65.43 ns |  0.0490 ns |  0.0435 ns |   1.53 |
|                                     LowCostTakeWithStruct |              5 |     64.56 ns |  0.0813 ns |  0.0761 ns |   1.51 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     58.49 ns |  0.0468 ns |  0.0438 ns |   1.37 |
|                                            SkipTakeSingle |              5 |    163.39 ns |  0.0260 ns |  0.0217 ns |   3.83 |
|                                     LowCostSkipTakeSingle |              5 |     78.58 ns |  0.0263 ns |  0.0246 ns |   1.84 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     68.97 ns |  0.0528 ns |  0.0494 ns |   1.62 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     69.28 ns |  0.0503 ns |  0.0470 ns |   1.62 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     55.26 ns |  0.0123 ns |  0.0103 ns |   1.29 |
|                                           ForeachDelegate |              5 |     62.02 ns |  0.0246 ns |  0.0230 ns |   1.45 |
|                                                   Foreach |              5 |     42.69 ns |  0.0062 ns |  0.0055 ns |   1.00 |
|                                                           |                |              |            |            |        |
|                                                      **Linq** |             **50** |    **561.78 ns** |  **0.6166 ns** |  **0.5768 ns** |   **1.95** |
|                                   LowCostLinqWithDelegate |             50 |    409.29 ns |  0.0363 ns |  0.0262 ns |   1.42 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    304.60 ns |  0.0806 ns |  0.0754 ns |   1.06 |
|                                  LowCostLinqWithDelegate2 |             50 |    431.59 ns |  0.0645 ns |  0.0504 ns |   1.50 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    309.45 ns |  0.1804 ns |  0.1687 ns |   1.08 |
|                                LowCostLinqWithStructWhere |             50 |    179.10 ns |  0.0780 ns |  0.0729 ns |   0.62 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    138.24 ns |  0.0306 ns |  0.0255 ns |   0.48 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,086.21 ns |  1.0864 ns |  1.0163 ns |   3.78 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,006.38 ns |  0.5413 ns |  0.5064 ns |   3.50 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    544.31 ns |  0.4883 ns |  0.4328 ns |   1.89 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    524.00 ns |  0.1554 ns |  0.1378 ns |   1.82 |
|                                                 LinqCount |             50 |    247.34 ns |  0.0345 ns |  0.0269 ns |   0.86 |
|                              LowCostLinqWithDelegateCount |             50 |    318.32 ns |  0.1557 ns |  0.1456 ns |   1.11 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    287.16 ns |  0.2411 ns |  0.2138 ns |   1.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    129.71 ns |  0.0566 ns |  0.0529 ns |   0.45 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     82.34 ns |  0.0156 ns |  0.0122 ns |   0.29 |
|                                               LinqToArray |             50 |    545.33 ns |  0.7257 ns |  0.6788 ns |   1.90 |
|                            LowCostLinqWithDelegateToArray |             50 |    539.51 ns |  0.2366 ns |  0.2097 ns |   1.88 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    456.82 ns |  0.4793 ns |  0.4249 ns |   1.59 |
|                              LowCostLinqWithStructToArray |             50 |    293.12 ns |  0.1062 ns |  0.0887 ns |   1.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    234.03 ns |  0.4286 ns |  0.4009 ns |   0.81 |
|                                                      Take |             50 |    371.58 ns |  0.0490 ns |  0.0409 ns |   1.29 |
|                                               LowCostTake |             50 |    213.07 ns |  0.0618 ns |  0.0516 ns |   0.74 |
|                                  LowCostTakeWithoutChecks |             50 |    164.39 ns |  0.0811 ns |  0.0758 ns |   0.57 |
|                                     LowCostTakeWithStruct |             50 |    114.71 ns |  0.0849 ns |  0.0795 ns |   0.40 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     97.69 ns |  0.0224 ns |  0.0210 ns |   0.34 |
|                                            SkipTakeSingle |             50 |    301.22 ns |  0.1008 ns |  0.0842 ns |   1.05 |
|                                     LowCostSkipTakeSingle |             50 |    188.89 ns |  0.1060 ns |  0.0992 ns |   0.66 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    165.03 ns |  0.0787 ns |  0.0698 ns |   0.57 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    100.11 ns |  0.0255 ns |  0.0238 ns |   0.35 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     74.12 ns |  0.0175 ns |  0.0164 ns |   0.26 |
|                                           ForeachDelegate |             50 |    451.24 ns |  0.3541 ns |  0.3139 ns |   1.57 |
|                                                   Foreach |             50 |    287.70 ns |  0.0383 ns |  0.0340 ns |   1.00 |
