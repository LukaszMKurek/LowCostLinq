``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **51.26 ns** |  **0.0122 ns** |  **0.0096 ns** |   **2.92** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     41.53 ns |  0.0139 ns |  0.0123 ns |   2.37 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     38.16 ns |  0.0089 ns |  0.0069 ns |   2.18 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     49.25 ns |  0.0430 ns |  0.0402 ns |   2.81 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     47.48 ns |  0.0061 ns |  0.0040 ns |   2.71 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     43.87 ns |  0.0381 ns |  0.0356 ns |   2.50 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     41.29 ns |  0.0053 ns |  0.0044 ns |   2.35 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     85.26 ns |  0.0711 ns |  0.0665 ns |   4.86 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     83.19 ns |  0.0293 ns |  0.0244 ns |   4.74 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     86.94 ns |  0.0720 ns |  0.0673 ns |   4.96 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     83.09 ns |  0.1012 ns |  0.0947 ns |   4.74 |     0.01 |
|                                                 LinqCount |              0 |     47.97 ns |  0.0469 ns |  0.0439 ns |   2.74 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     44.61 ns |  0.0053 ns |  0.0038 ns |   2.54 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     43.43 ns |  0.0139 ns |  0.0092 ns |   2.48 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     35.69 ns |  0.0263 ns |  0.0246 ns |   2.04 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     35.57 ns |  0.0096 ns |  0.0069 ns |   2.03 |     0.00 |
|                                               LinqToArray |              0 |     59.99 ns |  0.0696 ns |  0.0617 ns |   3.42 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     56.08 ns |  0.2113 ns |  0.1976 ns |   3.20 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     55.57 ns |  0.0592 ns |  0.0554 ns |   3.17 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     47.21 ns |  0.0363 ns |  0.0322 ns |   2.69 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     47.98 ns |  0.0881 ns |  0.0824 ns |   2.74 |     0.00 |
|                                                      Take |              0 |     85.95 ns |  0.0868 ns |  0.0812 ns |   4.90 |     0.01 |
|                                               LowCostTake |              0 |     49.04 ns |  0.0076 ns |  0.0064 ns |   2.80 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     47.42 ns |  0.0170 ns |  0.0133 ns |   2.70 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     50.78 ns |  0.0052 ns |  0.0043 ns |   2.90 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     50.07 ns |  0.0438 ns |  0.0388 ns |   2.86 |     0.00 |
|                                            SkipTakeSingle |              0 |    108.31 ns |  0.0164 ns |  0.0137 ns |   6.18 |     0.00 |
|                                     LowCostSkipTakeSingle |              0 |     56.41 ns |  0.0227 ns |  0.0212 ns |   3.22 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     56.33 ns |  0.0102 ns |  0.0085 ns |   3.21 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     53.70 ns |  0.0239 ns |  0.0199 ns |   3.06 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     53.69 ns |  0.0131 ns |  0.0116 ns |   3.06 |     0.00 |
|                                           ForeachDelegate |              0 |     19.81 ns |  0.0196 ns |  0.0183 ns |   1.13 |     0.00 |
|                                                   Foreach |              0 |     17.54 ns |  0.0115 ns |  0.0108 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **11,099.65 ns** | **16.9590 ns** | **15.0337 ns** |   **2.10** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  9,684.62 ns | 21.8257 ns | 20.4158 ns |   1.83 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  8,710.49 ns |  6.8132 ns |  6.3731 ns |   1.65 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  8,899.11 ns | 10.9484 ns | 10.2411 ns |   1.69 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  8,658.98 ns |  5.9191 ns |  5.2471 ns |   1.64 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  6,986.67 ns |  5.5336 ns |  5.1761 ns |   1.32 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  6,737.70 ns |  7.5560 ns |  7.0679 ns |   1.28 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 14,971.12 ns | 16.2674 ns | 15.2166 ns |   2.84 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 15,400.01 ns |  6.5523 ns |  5.8085 ns |   2.92 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 13,012.21 ns | 10.6737 ns |  9.9842 ns |   2.46 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 13,268.56 ns | 10.5319 ns |  9.8515 ns |   2.51 |     0.00 |
|                                                 LinqCount |           1000 |  7,318.05 ns | 25.5687 ns | 23.9170 ns |   1.39 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  7,466.58 ns |  2.4755 ns |  2.3156 ns |   1.41 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  8,140.96 ns | 14.2561 ns | 13.3351 ns |   1.54 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  5,775.87 ns |  1.1003 ns |  0.9754 ns |   1.09 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  5,783.24 ns |  2.3982 ns |  2.1259 ns |   1.10 |     0.00 |
|                                               LinqToArray |           1000 |  8,810.40 ns |  9.8744 ns |  9.2365 ns |   1.67 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  9,004.11 ns | 14.5488 ns | 13.6090 ns |   1.71 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  9,096.74 ns | 12.1018 ns | 11.3200 ns |   1.72 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  7,321.39 ns | 13.8779 ns | 12.9814 ns |   1.39 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  7,336.90 ns |  4.9115 ns |  4.1013 ns |   1.39 |     0.00 |
|                                                      Take |           1000 |    402.49 ns |  0.0688 ns |  0.0610 ns |   0.08 |     0.00 |
|                                               LowCostTake |           1000 |    242.04 ns |  0.2717 ns |  0.2541 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    229.04 ns |  0.0566 ns |  0.0501 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    201.27 ns |  0.0808 ns |  0.0756 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    181.54 ns |  0.0279 ns |  0.0218 ns |   0.03 |     0.00 |
|                                            SkipTakeSingle |           1000 |    321.13 ns |  0.0675 ns |  0.0564 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    234.93 ns |  0.0886 ns |  0.0740 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    239.06 ns |  0.1479 ns |  0.1311 ns |   0.05 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    188.58 ns |  0.0556 ns |  0.0520 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    199.55 ns |  0.2171 ns |  0.2031 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |           1000 |  7,139.66 ns | 51.9531 ns | 48.5970 ns |   1.35 |     0.01 |
|                                                   Foreach |           1000 |  5,279.36 ns |  3.8480 ns |  3.5995 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **106.00 ns** |  **0.1577 ns** |  **0.1475 ns** |   **2.41** |     **0.01** |
|                                   LowCostLinqWithDelegate |              5 |     86.90 ns |  0.0459 ns |  0.0304 ns |   1.97 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     81.31 ns |  0.0231 ns |  0.0205 ns |   1.85 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |     90.36 ns |  0.0169 ns |  0.0132 ns |   2.05 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     85.66 ns |  0.0169 ns |  0.0141 ns |   1.94 |     0.01 |
|                                LowCostLinqWithStructWhere |              5 |     70.65 ns |  0.0817 ns |  0.0764 ns |   1.60 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     69.07 ns |  0.1019 ns |  0.0851 ns |   1.57 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    171.01 ns |  0.1411 ns |  0.1320 ns |   3.88 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    169.87 ns |  0.0617 ns |  0.0515 ns |   3.86 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    166.55 ns |  0.1647 ns |  0.1540 ns |   3.78 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    159.86 ns |  0.1900 ns |  0.1777 ns |   3.63 |     0.01 |
|                                                 LinqCount |              5 |     84.24 ns |  0.0535 ns |  0.0501 ns |   1.91 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     82.18 ns |  0.0237 ns |  0.0198 ns |   1.87 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     84.85 ns |  0.0926 ns |  0.0866 ns |   1.93 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              5 |     65.39 ns |  0.0446 ns |  0.0417 ns |   1.48 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     64.93 ns |  0.0275 ns |  0.0230 ns |   1.47 |     0.00 |
|                                               LinqToArray |              5 |    168.65 ns |  0.1261 ns |  0.1053 ns |   3.83 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              5 |    131.32 ns |  0.0200 ns |  0.0145 ns |   2.98 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    131.63 ns |  0.0710 ns |  0.0630 ns |   2.99 |     0.01 |
|                              LowCostLinqWithStructToArray |              5 |    113.18 ns |  0.0176 ns |  0.0117 ns |   2.57 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    114.62 ns |  0.0740 ns |  0.0656 ns |   2.60 |     0.01 |
|                                                      Take |              5 |    176.47 ns |  0.2854 ns |  0.2383 ns |   4.01 |     0.01 |
|                                               LowCostTake |              5 |     90.18 ns |  0.1127 ns |  0.1054 ns |   2.05 |     0.01 |
|                                  LowCostTakeWithoutChecks |              5 |     93.09 ns |  0.0159 ns |  0.0124 ns |   2.11 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     87.42 ns |  0.0282 ns |  0.0220 ns |   1.98 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     78.18 ns |  0.0713 ns |  0.0667 ns |   1.77 |     0.01 |
|                                            SkipTakeSingle |              5 |    159.79 ns |  0.0361 ns |  0.0302 ns |   3.63 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |     95.33 ns |  0.1007 ns |  0.0942 ns |   2.16 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     97.28 ns |  0.0350 ns |  0.0310 ns |   2.21 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     79.78 ns |  0.0208 ns |  0.0174 ns |   1.81 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     80.85 ns |  0.0207 ns |  0.0173 ns |   1.83 |     0.01 |
|                                           ForeachDelegate |              5 |     57.61 ns |  1.1812 ns |  1.4938 ns |   1.31 |     0.03 |
|                                                   Foreach |              5 |     44.06 ns |  0.1484 ns |  0.1388 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **618.38 ns** |  **0.8760 ns** |  **0.7766 ns** |   **2.14** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    532.48 ns |  0.1725 ns |  0.1613 ns |   1.84 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    477.69 ns |  0.0810 ns |  0.0676 ns |   1.65 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    497.56 ns |  0.1630 ns |  0.1273 ns |   1.72 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    482.54 ns |  0.1023 ns |  0.0907 ns |   1.67 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    393.10 ns |  0.0880 ns |  0.0735 ns |   1.36 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    376.08 ns |  0.0783 ns |  0.0694 ns |   1.30 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    847.22 ns |  1.2655 ns |  1.1218 ns |   2.93 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    860.04 ns |  0.6023 ns |  0.5633 ns |   2.98 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    757.42 ns |  2.9874 ns |  2.7944 ns |   2.62 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    759.28 ns |  0.4794 ns |  0.4249 ns |   2.63 |     0.00 |
|                                                 LinqCount |             50 |    416.81 ns |  0.0549 ns |  0.0486 ns |   1.44 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    427.59 ns |  0.2354 ns |  0.2202 ns |   1.48 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    461.18 ns |  0.4245 ns |  0.3970 ns |   1.60 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    333.39 ns |  0.1410 ns |  0.1250 ns |   1.15 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    332.42 ns |  0.1040 ns |  0.0812 ns |   1.15 |     0.00 |
|                                               LinqToArray |             50 |    705.34 ns |  4.0497 ns |  3.7881 ns |   2.44 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |    614.27 ns |  0.7110 ns |  0.6651 ns |   2.13 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    624.40 ns |  0.2909 ns |  0.2429 ns |   2.16 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    528.36 ns |  0.7606 ns |  0.7115 ns |   1.83 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    529.37 ns |  0.3836 ns |  0.3401 ns |   1.83 |     0.00 |
|                                                      Take |             50 |    402.75 ns |  0.1345 ns |  0.1258 ns |   1.39 |     0.00 |
|                                               LowCostTake |             50 |    241.01 ns |  0.2373 ns |  0.2219 ns |   0.83 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    230.21 ns |  0.0512 ns |  0.0428 ns |   0.80 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    204.07 ns |  0.0932 ns |  0.0872 ns |   0.71 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    188.71 ns |  0.1543 ns |  0.1443 ns |   0.65 |     0.00 |
|                                            SkipTakeSingle |             50 |    320.57 ns |  0.1282 ns |  0.1136 ns |   1.11 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    235.84 ns |  0.1022 ns |  0.0906 ns |   0.82 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    239.79 ns |  0.0855 ns |  0.0714 ns |   0.83 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    190.73 ns |  0.1211 ns |  0.1132 ns |   0.66 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    199.49 ns |  0.0802 ns |  0.0750 ns |   0.69 |     0.00 |
|                                           ForeachDelegate |             50 |    388.52 ns |  0.2272 ns |  0.2125 ns |   1.35 |     0.00 |
|                                                   Foreach |             50 |    288.82 ns |  0.1974 ns |  0.1750 ns |   1.00 |     0.00 |
