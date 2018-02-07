``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **50.69 ns** |  **0.0168 ns** |  **0.0157 ns** |     **50.69 ns** |   **2.84** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     41.54 ns |  0.0370 ns |  0.0309 ns |     41.55 ns |   2.33 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     38.19 ns |  0.0058 ns |  0.0049 ns |     38.19 ns |   2.14 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     48.37 ns |  0.0155 ns |  0.0137 ns |     48.37 ns |   2.71 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     47.21 ns |  0.0425 ns |  0.0397 ns |     47.19 ns |   2.64 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     44.10 ns |  0.0104 ns |  0.0092 ns |     44.10 ns |   2.47 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     41.23 ns |  0.0053 ns |  0.0050 ns |     41.23 ns |   2.31 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     87.12 ns |  0.0406 ns |  0.0379 ns |     87.12 ns |   4.88 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     86.22 ns |  0.0199 ns |  0.0177 ns |     86.21 ns |   4.83 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     87.95 ns |  0.0167 ns |  0.0148 ns |     87.95 ns |   4.93 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     84.34 ns |  0.1760 ns |  0.1647 ns |     84.42 ns |   4.72 |     0.01 |
|                                                 LinqCount |              0 |     49.29 ns |  0.0256 ns |  0.0214 ns |     49.28 ns |   2.76 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     45.31 ns |  0.0274 ns |  0.0256 ns |     45.31 ns |   2.54 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     44.77 ns |  0.0144 ns |  0.0135 ns |     44.77 ns |   2.51 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     35.75 ns |  0.0768 ns |  0.0718 ns |     35.75 ns |   2.00 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     36.08 ns |  0.0290 ns |  0.0271 ns |     36.08 ns |   2.02 |     0.00 |
|                                               LinqToArray |              0 |     60.23 ns |  0.1705 ns |  0.1595 ns |     60.23 ns |   3.37 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |     55.77 ns |  0.0234 ns |  0.0207 ns |     55.77 ns |   3.12 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     55.87 ns |  0.0090 ns |  0.0070 ns |     55.87 ns |   3.13 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     46.98 ns |  0.3790 ns |  0.3545 ns |     46.77 ns |   2.63 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     46.92 ns |  0.0543 ns |  0.0508 ns |     46.91 ns |   2.63 |     0.00 |
|                                                      Take |              0 |     87.73 ns |  0.0219 ns |  0.0183 ns |     87.74 ns |   4.91 |     0.01 |
|                                               LowCostTake |              0 |     48.87 ns |  0.0203 ns |  0.0180 ns |     48.87 ns |   2.74 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     47.52 ns |  0.0118 ns |  0.0105 ns |     47.52 ns |   2.66 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     50.48 ns |  0.0156 ns |  0.0146 ns |     50.47 ns |   2.83 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     49.84 ns |  0.0624 ns |  0.0584 ns |     49.87 ns |   2.79 |     0.00 |
|                                            SkipTakeSingle |              0 |    108.24 ns |  0.0342 ns |  0.0303 ns |    108.23 ns |   6.06 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     56.51 ns |  0.0380 ns |  0.0356 ns |     56.52 ns |   3.17 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     57.01 ns |  0.2860 ns |  0.2535 ns |     56.88 ns |   3.19 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     53.35 ns |  0.0483 ns |  0.0452 ns |     53.33 ns |   2.99 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     53.97 ns |  0.0086 ns |  0.0072 ns |     53.97 ns |   3.02 |     0.00 |
|                                           ForeachDelegate |              0 |     20.15 ns |  0.0122 ns |  0.0108 ns |     20.14 ns |   1.13 |     0.00 |
|                                                   Foreach |              0 |     17.86 ns |  0.0221 ns |  0.0207 ns |     17.86 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **1000** | **11,143.75 ns** |  **5.7593 ns** |  **5.1055 ns** | **11,142.39 ns** |   **2.02** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  8,658.55 ns |  5.5477 ns |  4.6325 ns |  8,659.99 ns |   1.57 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  8,546.94 ns |  4.1737 ns |  3.6999 ns |  8,546.14 ns |   1.55 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  9,076.87 ns | 62.5762 ns | 58.5338 ns |  9,075.51 ns |   1.64 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  7,940.40 ns |  6.6879 ns |  5.9287 ns |  7,941.52 ns |   1.44 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  6,509.89 ns |  4.4878 ns |  4.1979 ns |  6,510.31 ns |   1.18 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  6,496.60 ns |  3.5684 ns |  3.3379 ns |  6,496.56 ns |   1.18 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 15,171.23 ns |  6.8522 ns |  6.4096 ns | 15,169.33 ns |   2.75 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 14,673.03 ns |  6.4610 ns |  5.7275 ns | 14,672.77 ns |   2.66 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 12,534.92 ns |  6.5875 ns |  6.1620 ns | 12,534.70 ns |   2.27 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 12,522.10 ns |  5.0413 ns |  4.4690 ns | 12,522.21 ns |   2.27 |     0.00 |
|                                                 LinqCount |           1000 |  7,001.94 ns |  3.1911 ns |  2.6647 ns |  7,001.12 ns |   1.27 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  7,729.04 ns |  3.5393 ns |  3.1375 ns |  7,729.03 ns |   1.40 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  7,474.95 ns |  3.7148 ns |  3.4749 ns |  7,475.05 ns |   1.35 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  5,779.37 ns |  1.7918 ns |  1.4963 ns |  5,779.63 ns |   1.05 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  5,544.78 ns |  2.4108 ns |  2.0131 ns |  5,544.69 ns |   1.00 |     0.00 |
|                                               LinqToArray |           1000 |  8,982.91 ns |  9.6190 ns |  8.9976 ns |  8,981.58 ns |   1.63 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  9,259.88 ns | 12.2392 ns | 11.4485 ns |  9,258.90 ns |   1.68 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  9,319.66 ns | 31.0660 ns | 29.0592 ns |  9,335.13 ns |   1.69 |     0.01 |
|                              LowCostLinqWithStructToArray |           1000 |  7,311.58 ns |  8.3712 ns |  7.4209 ns |  7,313.98 ns |   1.32 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  7,141.90 ns | 12.6244 ns | 11.8089 ns |  7,146.05 ns |   1.29 |     0.00 |
|                                                      Take |           1000 |    395.42 ns |  0.0543 ns |  0.0508 ns |    395.40 ns |   0.07 |     0.00 |
|                                               LowCostTake |           1000 |    247.20 ns |  0.1560 ns |  0.1460 ns |    247.20 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    228.93 ns |  0.0454 ns |  0.0403 ns |    228.93 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    199.82 ns |  0.0235 ns |  0.0209 ns |    199.82 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    189.50 ns |  0.1474 ns |  0.1231 ns |    189.43 ns |   0.03 |     0.00 |
|                                            SkipTakeSingle |           1000 |    330.85 ns |  0.2987 ns |  0.2648 ns |    330.66 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    247.82 ns |  0.0638 ns |  0.0565 ns |    247.82 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    239.84 ns |  0.0515 ns |  0.0430 ns |    239.84 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    187.51 ns |  0.1437 ns |  0.1344 ns |    187.48 ns |   0.03 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    187.81 ns |  0.0267 ns |  0.0237 ns |    187.82 ns |   0.03 |     0.00 |
|                                           ForeachDelegate |           1000 |  6,711.86 ns |  2.1457 ns |  2.0071 ns |  6,711.62 ns |   1.22 |     0.00 |
|                                                   Foreach |           1000 |  5,519.03 ns |  2.1048 ns |  1.8659 ns |  5,519.33 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |              **5** |    **107.12 ns** |  **0.0171 ns** |  **0.0160 ns** |    **107.12 ns** |   **2.38** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     86.73 ns |  0.0496 ns |  0.0464 ns |     86.71 ns |   1.93 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     79.44 ns |  0.0211 ns |  0.0197 ns |     79.44 ns |   1.77 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     91.03 ns |  0.0983 ns |  0.0919 ns |     90.98 ns |   2.02 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     83.54 ns |  0.0220 ns |  0.0195 ns |     83.54 ns |   1.86 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     72.56 ns |  0.0896 ns |  0.0838 ns |     72.58 ns |   1.61 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     69.23 ns |  0.0398 ns |  0.0372 ns |     69.23 ns |   1.54 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    177.32 ns |  0.2863 ns |  0.2538 ns |    177.36 ns |   3.94 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    169.53 ns |  0.0819 ns |  0.0684 ns |    169.52 ns |   3.77 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    161.81 ns |  0.1734 ns |  0.1622 ns |    161.86 ns |   3.60 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    156.34 ns |  0.6729 ns |  0.6294 ns |    156.14 ns |   3.48 |     0.01 |
|                                                 LinqCount |              5 |     84.43 ns |  0.3729 ns |  0.3488 ns |     84.33 ns |   1.88 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     83.92 ns |  0.0439 ns |  0.0411 ns |     83.91 ns |   1.87 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     82.43 ns |  0.0261 ns |  0.0231 ns |     82.43 ns |   1.83 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     65.70 ns |  0.0677 ns |  0.0634 ns |     65.70 ns |   1.46 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     64.93 ns |  0.0240 ns |  0.0225 ns |     64.93 ns |   1.44 |     0.00 |
|                                               LinqToArray |              5 |    167.54 ns |  3.3309 ns |  3.1158 ns |    164.95 ns |   3.72 |     0.07 |
|                            LowCostLinqWithDelegateToArray |              5 |    132.10 ns |  0.0492 ns |  0.0437 ns |    132.09 ns |   2.94 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    132.36 ns |  0.2534 ns |  0.2370 ns |    132.24 ns |   2.94 |     0.01 |
|                              LowCostLinqWithStructToArray |              5 |    113.29 ns |  0.0475 ns |  0.0397 ns |    113.30 ns |   2.52 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    113.36 ns |  0.0453 ns |  0.0402 ns |    113.36 ns |   2.52 |     0.00 |
|                                                      Take |              5 |    177.91 ns |  0.1590 ns |  0.1488 ns |    177.82 ns |   3.96 |     0.00 |
|                                               LowCostTake |              5 |     93.35 ns |  0.0379 ns |  0.0336 ns |     93.34 ns |   2.08 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     86.38 ns |  0.0402 ns |  0.0356 ns |     86.38 ns |   1.92 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     82.61 ns |  0.0845 ns |  0.0790 ns |     82.59 ns |   1.84 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     77.22 ns |  0.0366 ns |  0.0325 ns |     77.21 ns |   1.72 |     0.00 |
|                                            SkipTakeSingle |              5 |    161.66 ns |  0.0285 ns |  0.0238 ns |    161.65 ns |   3.59 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |    103.44 ns |  0.0232 ns |  0.0206 ns |    103.43 ns |   2.30 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     95.64 ns |  0.0867 ns |  0.0811 ns |     95.62 ns |   2.13 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     81.21 ns |  0.0883 ns |  0.0826 ns |     81.24 ns |   1.81 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     78.73 ns |  0.0217 ns |  0.0193 ns |     78.74 ns |   1.75 |     0.00 |
|                                           ForeachDelegate |              5 |     53.84 ns |  0.0276 ns |  0.0245 ns |     53.85 ns |   1.20 |     0.00 |
|                                                   Foreach |              5 |     44.98 ns |  0.0073 ns |  0.0065 ns |     44.98 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |             **50** |    **624.17 ns** |  **0.6249 ns** |  **0.5846 ns** |    **624.51 ns** |   **2.06** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    481.29 ns |  0.0928 ns |  0.0823 ns |    481.27 ns |   1.59 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    470.20 ns |  0.3280 ns |  0.3068 ns |    470.13 ns |   1.55 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    507.24 ns |  0.1570 ns |  0.1469 ns |    507.21 ns |   1.68 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    443.65 ns |  0.5744 ns |  0.5373 ns |    443.96 ns |   1.47 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    377.67 ns |  0.0765 ns |  0.0715 ns |    377.67 ns |   1.25 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    365.51 ns |  0.1663 ns |  0.1474 ns |    365.50 ns |   1.21 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    862.33 ns |  0.1928 ns |  0.1610 ns |    862.32 ns |   2.85 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    830.75 ns |  1.0998 ns |  1.0288 ns |    831.28 ns |   2.75 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    728.05 ns |  0.2697 ns |  0.2523 ns |    727.95 ns |   2.41 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    717.68 ns |  0.3845 ns |  0.3596 ns |    717.76 ns |   2.37 |     0.00 |
|                                                 LinqCount |             50 |    404.75 ns |  0.0393 ns |  0.0284 ns |    404.75 ns |   1.34 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    443.66 ns |  0.1940 ns |  0.1815 ns |    443.57 ns |   1.47 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    432.33 ns |  0.2781 ns |  0.2602 ns |    432.31 ns |   1.43 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    333.05 ns |  0.3254 ns |  0.3043 ns |    333.08 ns |   1.10 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    322.75 ns |  0.3804 ns |  0.3558 ns |    322.92 ns |   1.07 |     0.00 |
|                                               LinqToArray |             50 |    720.71 ns |  3.4916 ns |  3.2661 ns |    722.50 ns |   2.38 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |    632.87 ns |  0.2285 ns |  0.2025 ns |    632.84 ns |   2.09 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    636.69 ns |  0.3232 ns |  0.2337 ns |    636.75 ns |   2.10 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    528.62 ns |  0.4311 ns |  0.4033 ns |    528.59 ns |   1.75 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    524.01 ns |  0.2706 ns |  0.2532 ns |    523.89 ns |   1.73 |     0.00 |
|                                                      Take |             50 |    395.33 ns |  0.0432 ns |  0.0361 ns |    395.32 ns |   1.31 |     0.00 |
|                                               LowCostTake |             50 |    246.98 ns |  0.0821 ns |  0.0728 ns |    246.97 ns |   0.82 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    230.99 ns |  0.1084 ns |  0.0961 ns |    230.95 ns |   0.76 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    204.22 ns |  0.0677 ns |  0.0633 ns |    204.20 ns |   0.67 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    186.26 ns |  0.1132 ns |  0.1003 ns |    186.21 ns |   0.62 |     0.00 |
|                                            SkipTakeSingle |             50 |    330.49 ns |  0.2040 ns |  0.1808 ns |    330.47 ns |   1.09 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    253.05 ns |  0.0415 ns |  0.0347 ns |    253.04 ns |   0.84 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    239.46 ns |  0.0571 ns |  0.0506 ns |    239.47 ns |   0.79 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    186.62 ns |  0.0672 ns |  0.0596 ns |    186.61 ns |   0.62 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    187.22 ns |  0.0887 ns |  0.0786 ns |    187.18 ns |   0.62 |     0.00 |
|                                           ForeachDelegate |             50 |    362.10 ns |  0.0507 ns |  0.0474 ns |    362.09 ns |   1.20 |     0.00 |
|                                                   Foreach |             50 |    302.57 ns |  0.0407 ns |  0.0381 ns |    302.58 ns |   1.00 |     0.00 |
