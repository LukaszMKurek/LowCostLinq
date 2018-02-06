``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |              **0** |    **21.180 ns** |  **0.0056 ns** |  **0.0053 ns** |   **6.70** |     **0.01** |
|                      LowCostLinqWithDelegate |              0 |    18.640 ns |  0.0009 ns |  0.0009 ns |   5.89 |     0.01 |
|                     LowCostLinqWithDelegate2 |              0 |    27.353 ns |  0.0506 ns |  0.0449 ns |   8.65 |     0.02 |
|                   LowCostLinqWithStructWhere |              0 |    20.513 ns |  0.0006 ns |  0.0005 ns |   6.48 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |    35.432 ns |  0.0182 ns |  0.0152 ns |  11.20 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |    36.124 ns |  0.2690 ns |  0.2516 ns |  11.42 |     0.08 |
|                                    LinqCount |              0 |    23.662 ns |  0.0811 ns |  0.0759 ns |   7.48 |     0.02 |
|                 LowCostLinqWithDelegateCount |              0 |    14.823 ns |  0.0078 ns |  0.0073 ns |   4.69 |     0.00 |
|              LowCostLinqWithStructWhereCount |              0 |    15.187 ns |  0.0021 ns |  0.0015 ns |   4.80 |     0.00 |
|                                  LinqToArray |              0 |    21.419 ns |  0.1563 ns |  0.1462 ns |   6.77 |     0.05 |
|               LowCostLinqWithDelegateToArray |              0 |    18.813 ns |  0.0061 ns |  0.0054 ns |   5.95 |     0.01 |
|                 LowCostLinqWithStructToArray |              0 |    17.911 ns |  0.0046 ns |  0.0039 ns |   5.66 |     0.01 |
|                                         Take |              0 |    24.943 ns |  0.1577 ns |  0.1475 ns |   7.88 |     0.05 |
|                                  LowCostTake |              0 |    25.797 ns |  0.0008 ns |  0.0007 ns |   8.15 |     0.01 |
|                        LowCostTakeWithStruct |              0 |    27.284 ns |  0.0022 ns |  0.0019 ns |   8.62 |     0.01 |
|                               SkipTakeSingle |              0 |    35.891 ns |  0.0100 ns |  0.0078 ns |  11.35 |     0.01 |
|                        LowCostSkipTakeSingle |              0 |    29.095 ns |  0.0104 ns |  0.0097 ns |   9.20 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              0 |    30.881 ns |  0.0026 ns |  0.0021 ns |   9.76 |     0.01 |
|                              ForeachDelegate |              0 |     5.819 ns |  0.0038 ns |  0.0034 ns |   1.84 |     0.00 |
|                                      Foreach |              0 |     2.866 ns |  0.0028 ns |  0.0023 ns |   0.91 |     0.00 |
|                                          For |              0 |     3.164 ns |  0.0033 ns |  0.0031 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |        |          |
|                                         **Linq** |           **1000** | **6,128.234 ns** |  **5.8978 ns** |  **4.9249 ns** |  **24.47** |     **0.02** |
|                      LowCostLinqWithDelegate |           1000 | 2,647.585 ns |  0.3976 ns |  0.3525 ns |  10.57 |     0.01 |
|                     LowCostLinqWithDelegate2 |           1000 | 3,156.307 ns |  3.7608 ns |  3.3338 ns |  12.60 |     0.01 |
|                   LowCostLinqWithStructWhere |           1000 | 1,485.216 ns | 10.5631 ns |  9.8808 ns |   5.93 |     0.04 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 8,039.864 ns |  5.9507 ns |  5.5663 ns |  32.10 |     0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 6,343.483 ns |  1.0849 ns |  1.0148 ns |  25.33 |     0.02 |
|                                    LinqCount |           1000 | 1,537.648 ns |  1.4258 ns |  1.2640 ns |   6.14 |     0.01 |
|                 LowCostLinqWithDelegateCount |           1000 | 2,416.419 ns | 17.2748 ns | 16.1588 ns |   9.65 |     0.06 |
|              LowCostLinqWithStructWhereCount |           1000 | 1,326.666 ns |  1.1681 ns |  1.0926 ns |   5.30 |     0.01 |
|                                  LinqToArray |           1000 | 3,114.281 ns |  3.5758 ns |  3.3448 ns |  12.43 |     0.01 |
|               LowCostLinqWithDelegateToArray |           1000 | 4,106.303 ns |  7.3401 ns |  6.8660 ns |  16.39 |     0.03 |
|                 LowCostLinqWithStructToArray |           1000 | 2,230.891 ns | 13.5092 ns | 11.9756 ns |   8.91 |     0.05 |
|                                         Take |           1000 |   293.431 ns |  0.2422 ns |  0.2265 ns |   1.17 |     0.00 |
|                                  LowCostTake |           1000 |    94.218 ns |  0.0213 ns |  0.0189 ns |   0.38 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |    64.678 ns |  0.1365 ns |  0.1277 ns |   0.26 |     0.00 |
|                               SkipTakeSingle |           1000 |   183.057 ns |  0.0805 ns |  0.0714 ns |   0.73 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    89.669 ns |  0.0615 ns |  0.0575 ns |   0.36 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |    54.602 ns |  0.0144 ns |  0.0135 ns |   0.22 |     0.00 |
|                              ForeachDelegate |           1000 | 1,446.527 ns |  8.4177 ns |  7.8739 ns |   5.78 |     0.03 |
|                                      Foreach |           1000 |   333.630 ns |  0.1719 ns |  0.1524 ns |   1.33 |     0.00 |
|                                          For |           1000 |   250.473 ns |  0.1687 ns |  0.1578 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |        |          |
|                                         **Linq** |              **5** |    **61.530 ns** |  **0.0310 ns** |  **0.0275 ns** |  **14.82** |     **0.02** |
|                      LowCostLinqWithDelegate |              5 |    32.905 ns |  0.1513 ns |  0.1341 ns |   7.93 |     0.03 |
|                     LowCostLinqWithDelegate2 |              5 |    42.525 ns |  0.0099 ns |  0.0088 ns |  10.24 |     0.01 |
|                   LowCostLinqWithStructWhere |              5 |    27.733 ns |  0.0086 ns |  0.0080 ns |   6.68 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    76.395 ns |  0.6785 ns |  0.6015 ns |  18.40 |     0.14 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |    68.665 ns |  0.0601 ns |  0.0533 ns |  16.54 |     0.02 |
|                                    LinqCount |              5 |    38.813 ns |  0.1959 ns |  0.1833 ns |   9.35 |     0.04 |
|                 LowCostLinqWithDelegateCount |              5 |    27.601 ns |  0.0060 ns |  0.0056 ns |   6.65 |     0.01 |
|              LowCostLinqWithStructWhereCount |              5 |    18.184 ns |  0.0129 ns |  0.0108 ns |   4.38 |     0.00 |
|                                  LinqToArray |              5 |    95.664 ns |  0.1157 ns |  0.1082 ns |  23.04 |     0.03 |
|               LowCostLinqWithDelegateToArray |              5 |    67.604 ns |  0.0530 ns |  0.0495 ns |  16.28 |     0.02 |
|                 LowCostLinqWithStructToArray |              5 |    57.644 ns |  0.6253 ns |  0.5849 ns |  13.88 |     0.14 |
|                                         Take |              5 |   123.245 ns |  0.0850 ns |  0.0795 ns |  29.68 |     0.03 |
|                                  LowCostTake |              5 |    41.109 ns |  0.0077 ns |  0.0068 ns |   9.90 |     0.01 |
|                        LowCostTakeWithStruct |              5 |    35.405 ns |  0.0147 ns |  0.0130 ns |   8.53 |     0.01 |
|                               SkipTakeSingle |              5 |   110.080 ns |  0.0133 ns |  0.0118 ns |  26.51 |     0.03 |
|                        LowCostSkipTakeSingle |              5 |    39.626 ns |  0.0059 ns |  0.0049 ns |   9.54 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              5 |    35.788 ns |  0.0031 ns |  0.0026 ns |   8.62 |     0.01 |
|                              ForeachDelegate |              5 |    12.900 ns |  0.0116 ns |  0.0097 ns |   3.11 |     0.00 |
|                                      Foreach |              5 |     4.164 ns |  0.0045 ns |  0.0043 ns |   1.00 |     0.00 |
|                                          For |              5 |     4.152 ns |  0.0046 ns |  0.0041 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |        |          |
|                                         **Linq** |             **50** |   **344.415 ns** |  **0.0510 ns** |  **0.0477 ns** |  **21.55** |     **0.01** |
|                      LowCostLinqWithDelegate |             50 |   158.512 ns |  0.0725 ns |  0.0678 ns |   9.92 |     0.01 |
|                     LowCostLinqWithDelegate2 |             50 |   191.404 ns |  0.0395 ns |  0.0330 ns |  11.98 |     0.00 |
|                   LowCostLinqWithStructWhere |             50 |    91.608 ns |  0.3647 ns |  0.3233 ns |   5.73 |     0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |   442.973 ns |  0.0560 ns |  0.0468 ns |  27.72 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |   360.861 ns |  0.1205 ns |  0.1127 ns |  22.58 |     0.01 |
|                                    LinqCount |             50 |   118.175 ns |  0.6036 ns |  0.5646 ns |   7.39 |     0.03 |
|                 LowCostLinqWithDelegateCount |             50 |   139.785 ns |  0.1636 ns |  0.1530 ns |   8.75 |     0.01 |
|              LowCostLinqWithStructWhereCount |             50 |    66.806 ns |  0.0117 ns |  0.0110 ns |   4.18 |     0.00 |
|                                  LinqToArray |             50 |   367.021 ns |  0.3121 ns |  0.2919 ns |  22.97 |     0.02 |
|               LowCostLinqWithDelegateToArray |             50 |   310.152 ns |  2.1335 ns |  1.9957 ns |  19.41 |     0.12 |
|                 LowCostLinqWithStructToArray |             50 |   204.436 ns |  0.2457 ns |  0.2178 ns |  12.79 |     0.01 |
|                                         Take |             50 |   293.040 ns |  0.1185 ns |  0.1108 ns |  18.34 |     0.01 |
|                                  LowCostTake |             50 |    94.261 ns |  0.0811 ns |  0.0677 ns |   5.90 |     0.00 |
|                        LowCostTakeWithStruct |             50 |    61.336 ns |  0.2280 ns |  0.2132 ns |   3.84 |     0.01 |
|                               SkipTakeSingle |             50 |   184.403 ns |  0.1793 ns |  0.1677 ns |  11.54 |     0.01 |
|                        LowCostSkipTakeSingle |             50 |    89.629 ns |  0.0469 ns |  0.0416 ns |   5.61 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |             50 |    54.739 ns |  0.2863 ns |  0.2678 ns |   3.43 |     0.02 |
|                              ForeachDelegate |             50 |    81.576 ns |  0.0122 ns |  0.0102 ns |   5.10 |     0.00 |
|                                      Foreach |             50 |    18.624 ns |  0.0254 ns |  0.0212 ns |   1.17 |     0.00 |
|                                          For |             50 |    15.981 ns |  0.0065 ns |  0.0054 ns |   1.00 |     0.00 |
