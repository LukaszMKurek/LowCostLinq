``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **115.88 ns** |   **0.0533 ns** |   **0.0416 ns** |   **9.86** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     45.06 ns |   0.0388 ns |   0.0363 ns |   3.83 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     45.65 ns |   0.0077 ns |   0.0068 ns |   3.89 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     71.67 ns |   0.0086 ns |   0.0080 ns |   6.10 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     71.67 ns |   0.0053 ns |   0.0041 ns |   6.10 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     66.08 ns |   0.0044 ns |   0.0039 ns |   5.62 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     55.51 ns |   0.0030 ns |   0.0026 ns |   4.72 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    102.45 ns |   0.1667 ns |   0.1560 ns |   8.72 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    104.87 ns |   0.1267 ns |   0.1185 ns |   8.92 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     94.80 ns |   0.0530 ns |   0.0442 ns |   8.07 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     92.54 ns |   0.1583 ns |   0.1481 ns |   7.88 |     0.01 |
|                                                 LinqCount |              0 |    111.36 ns |   0.1107 ns |   0.1036 ns |   9.48 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     43.98 ns |   0.0126 ns |   0.0112 ns |   3.74 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     44.64 ns |   0.0183 ns |   0.0162 ns |   3.80 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     49.40 ns |   0.0120 ns |   0.0100 ns |   4.20 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     46.05 ns |   0.0089 ns |   0.0079 ns |   3.92 |     0.00 |
|                                               LinqToArray |              0 |    125.12 ns |   0.0484 ns |   0.0429 ns |  10.65 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     51.63 ns |   0.0291 ns |   0.0227 ns |   4.39 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     51.57 ns |   0.0239 ns |   0.0199 ns |   4.39 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     55.68 ns |   0.0399 ns |   0.0333 ns |   4.74 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     56.20 ns |   0.0142 ns |   0.0119 ns |   4.78 |     0.00 |
|                                                      Take |              0 |    148.08 ns |   0.0500 ns |   0.0391 ns |  12.60 |     0.00 |
|                                               LowCostTake |              0 |     56.24 ns |   0.0073 ns |   0.0061 ns |   4.79 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     65.34 ns |   0.0045 ns |   0.0038 ns |   5.56 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     67.92 ns |   0.0514 ns |   0.0481 ns |   5.78 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     68.07 ns |   0.0542 ns |   0.0507 ns |   5.79 |     0.00 |
|                                            SkipTakeSingle |              0 |    169.43 ns |   0.1206 ns |   0.1007 ns |  14.42 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     82.83 ns |   0.0323 ns |   0.0302 ns |   7.05 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     78.38 ns |   0.0357 ns |   0.0316 ns |   6.67 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     79.67 ns |   0.0069 ns |   0.0058 ns |   6.78 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     80.18 ns |   0.0051 ns |   0.0043 ns |   6.82 |     0.00 |
|                                           ForeachDelegate |              0 |     16.23 ns |   0.0119 ns |   0.0111 ns |   1.38 |     0.00 |
|                                                   Foreach |              0 |     11.75 ns |   0.0026 ns |   0.0022 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |           **1000** | **12,400.69 ns** |   **4.0156 ns** |   **3.5597 ns** |   **2.72** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 | 11,422.96 ns | 125.4108 ns | 117.3093 ns |   2.51 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 10,814.60 ns |  11.5795 ns |  10.8315 ns |   2.37 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 11,342.14 ns |  11.8133 ns |   9.8646 ns |   2.49 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 12,282.54 ns |   8.2807 ns |   7.7458 ns |   2.69 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  1,744.98 ns |   1.6834 ns |   1.5746 ns |   0.38 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,577.78 ns |   0.6444 ns |   0.5712 ns |   0.35 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 23,186.92 ns |  36.0444 ns |  33.7160 ns |   5.09 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 23,458.03 ns |  34.4723 ns |  28.7859 ns |   5.15 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,494.66 ns |   5.5238 ns |   5.1670 ns |   1.86 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,781.30 ns |   5.7979 ns |   5.4234 ns |   1.71 |     0.00 |
|                                                 LinqCount |           1000 |  9,943.26 ns |   9.1669 ns |   8.5748 ns |   2.18 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  9,856.74 ns |   3.2047 ns |   2.5021 ns |   2.16 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  9,875.88 ns |   4.1515 ns |   3.8833 ns |   2.17 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,373.98 ns |   0.0993 ns |   0.0880 ns |   0.30 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,375.54 ns |   0.1907 ns |   0.1592 ns |   0.30 |     0.00 |
|                                               LinqToArray |           1000 | 10,531.09 ns |  15.5384 ns |  14.5346 ns |   2.31 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 | 12,818.08 ns |   8.9575 ns |   8.3789 ns |   2.81 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 12,113.77 ns |   6.2664 ns |   5.2328 ns |   2.66 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,285.26 ns |   6.2830 ns |   5.8771 ns |   0.50 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,286.27 ns |   5.5080 ns |   4.8827 ns |   0.50 |     0.00 |
|                                                      Take |           1000 |    508.39 ns |   0.2206 ns |   0.1842 ns |   0.11 |     0.00 |
|                                               LowCostTake |           1000 |    321.43 ns |   0.2575 ns |   0.2408 ns |   0.07 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    282.79 ns |   0.0885 ns |   0.0691 ns |   0.06 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    124.60 ns |   0.0430 ns |   0.0381 ns |   0.03 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    110.91 ns |   0.0123 ns |   0.0109 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    430.74 ns |   0.1068 ns |   0.0892 ns |   0.09 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    330.73 ns |   0.1729 ns |   0.1617 ns |   0.07 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    341.65 ns |   0.0348 ns |   0.0290 ns |   0.07 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    154.66 ns |   0.0417 ns |   0.0390 ns |   0.03 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    138.64 ns |   0.0751 ns |   0.0703 ns |   0.03 |     0.00 |
|                                           ForeachDelegate |           1000 |  9,430.46 ns |   5.6841 ns |   4.7465 ns |   2.07 |     0.00 |
|                                                   Foreach |           1000 |  4,558.23 ns |   3.7114 ns |   3.4717 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |              **5** |    **175.26 ns** |   **0.1896 ns** |   **0.1773 ns** |   **4.97** |     **0.01** |
|                                   LowCostLinqWithDelegate |              5 |     99.98 ns |   0.0785 ns |   0.0735 ns |   2.84 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     99.07 ns |   0.0313 ns |   0.0278 ns |   2.81 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    133.91 ns |   0.1158 ns |   0.1083 ns |   3.80 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    139.31 ns |   0.0661 ns |   0.0552 ns |   3.95 |     0.01 |
|                                LowCostLinqWithStructWhere |              5 |     63.61 ns |   0.0396 ns |   0.0370 ns |   1.80 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     63.17 ns |   0.0119 ns |   0.0111 ns |   1.79 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    226.77 ns |   0.1632 ns |   0.1527 ns |   6.43 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    235.00 ns |   0.2466 ns |   0.2307 ns |   6.67 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    138.19 ns |   0.0889 ns |   0.0742 ns |   3.92 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    133.60 ns |   0.0297 ns |   0.0263 ns |   3.79 |     0.01 |
|                                                 LinqCount |              5 |    163.35 ns |   0.0877 ns |   0.0821 ns |   4.63 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     90.45 ns |   0.0647 ns |   0.0605 ns |   2.57 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     89.61 ns |   0.1352 ns |   0.1265 ns |   2.54 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     52.37 ns |   0.0192 ns |   0.0161 ns |   1.49 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     51.32 ns |   0.0352 ns |   0.0329 ns |   1.46 |     0.00 |
|                                               LinqToArray |              5 |    218.82 ns |   0.3111 ns |   0.2910 ns |   6.21 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              5 |    144.24 ns |   0.0994 ns |   0.0830 ns |   4.09 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    140.85 ns |   0.0772 ns |   0.0722 ns |   4.00 |     0.01 |
|                              LowCostLinqWithStructToArray |              5 |     95.02 ns |   0.0630 ns |   0.0590 ns |   2.70 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     94.97 ns |   0.1192 ns |   0.1115 ns |   2.69 |     0.00 |
|                                                      Take |              5 |    248.99 ns |   0.3569 ns |   0.3164 ns |   7.06 |     0.01 |
|                                               LowCostTake |              5 |    123.13 ns |   0.0252 ns |   0.0223 ns |   3.49 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |    110.52 ns |   0.0980 ns |   0.0917 ns |   3.14 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     82.64 ns |   0.0244 ns |   0.0190 ns |   2.34 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     78.95 ns |   0.0267 ns |   0.0237 ns |   2.24 |     0.00 |
|                                            SkipTakeSingle |              5 |    246.32 ns |   0.3483 ns |   0.3258 ns |   6.99 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |    133.44 ns |   0.1070 ns |   0.1001 ns |   3.79 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    136.69 ns |   0.0532 ns |   0.0472 ns |   3.88 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     91.07 ns |   0.0752 ns |   0.0703 ns |   2.58 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     94.40 ns |   0.0118 ns |   0.0098 ns |   2.68 |     0.00 |
|                                           ForeachDelegate |              5 |     64.05 ns |   0.0226 ns |   0.0211 ns |   1.82 |     0.00 |
|                                                   Foreach |              5 |     35.25 ns |   0.0513 ns |   0.0480 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |             **50** |    **735.11 ns** |   **0.6000 ns** |   **0.5613 ns** |   **2.97** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    621.78 ns |   0.5062 ns |   0.4735 ns |   2.51 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    590.22 ns |   0.1615 ns |   0.1349 ns |   2.38 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    639.04 ns |   0.4088 ns |   0.3624 ns |   2.58 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    684.79 ns |   0.2209 ns |   0.2067 ns |   2.76 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    145.81 ns |   0.0445 ns |   0.0394 ns |   0.59 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    137.39 ns |   0.0282 ns |   0.0220 ns |   0.55 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,270.44 ns |   2.3538 ns |   2.2018 ns |   5.12 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,278.49 ns |   2.7068 ns |   2.5319 ns |   5.16 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    522.91 ns |   0.1653 ns |   0.1465 ns |   2.11 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    492.35 ns |   0.4986 ns |   0.4664 ns |   1.99 |     0.00 |
|                                                 LinqCount |             50 |    607.82 ns |   1.1197 ns |   0.9926 ns |   2.45 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    535.12 ns |   0.0535 ns |   0.0417 ns |   2.16 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    535.93 ns |   0.1627 ns |   0.1522 ns |   2.16 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    107.33 ns |   0.0190 ns |   0.0169 ns |   0.43 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    106.57 ns |   0.0114 ns |   0.0089 ns |   0.43 |     0.00 |
|                                               LinqToArray |             50 |    846.44 ns |   0.4279 ns |   0.3794 ns |   3.41 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    827.67 ns |   0.4203 ns |   0.3931 ns |   3.34 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    791.77 ns |   0.3800 ns |   0.3555 ns |   3.19 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    244.56 ns |   0.3527 ns |   0.3299 ns |   0.99 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    244.84 ns |   0.4115 ns |   0.3849 ns |   0.99 |     0.00 |
|                                                      Take |             50 |    508.69 ns |   0.2564 ns |   0.2398 ns |   2.05 |     0.00 |
|                                               LowCostTake |             50 |    321.35 ns |   0.2397 ns |   0.2243 ns |   1.30 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    287.14 ns |   0.0935 ns |   0.0730 ns |   1.16 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    131.13 ns |   0.0476 ns |   0.0422 ns |   0.53 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    110.83 ns |   0.0106 ns |   0.0088 ns |   0.45 |     0.00 |
|                                            SkipTakeSingle |             50 |    439.28 ns |   0.1518 ns |   0.1268 ns |   1.77 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    332.05 ns |   0.1034 ns |   0.0863 ns |   1.34 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    340.58 ns |   0.0394 ns |   0.0308 ns |   1.37 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    147.55 ns |   0.0189 ns |   0.0158 ns |   0.60 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    136.68 ns |   0.0491 ns |   0.0410 ns |   0.55 |     0.00 |
|                                           ForeachDelegate |             50 |    488.44 ns |   0.1067 ns |   0.0946 ns |   1.97 |     0.00 |
|                                                   Foreach |             50 |    247.92 ns |   0.0339 ns |   0.0283 ns |   1.00 |     0.00 |
