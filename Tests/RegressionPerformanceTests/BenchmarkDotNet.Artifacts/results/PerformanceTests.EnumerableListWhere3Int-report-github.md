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
|                                                      **Linq** |              **0** |     **91.17 ns** |  **0.0183 ns** |  **0.0143 ns** |   **5.45** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     37.68 ns |  0.0195 ns |  0.0183 ns |   2.25 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     32.98 ns |  0.0070 ns |  0.0062 ns |   1.97 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     61.07 ns |  0.0121 ns |  0.0107 ns |   3.65 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     59.56 ns |  0.0064 ns |  0.0060 ns |   3.56 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     50.54 ns |  0.0135 ns |  0.0113 ns |   3.02 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     45.24 ns |  0.0294 ns |  0.0275 ns |   2.71 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     99.04 ns |  0.0326 ns |  0.0305 ns |   5.92 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     93.65 ns |  0.0758 ns |  0.0709 ns |   5.60 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     87.87 ns |  0.0714 ns |  0.0668 ns |   5.25 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     78.43 ns |  0.1186 ns |  0.1109 ns |   4.69 |     0.01 |
|                                                 LinqCount |              0 |     87.11 ns |  0.0522 ns |  0.0463 ns |   5.21 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     38.57 ns |  0.0039 ns |  0.0033 ns |   2.31 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     34.66 ns |  0.0196 ns |  0.0163 ns |   2.07 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     44.17 ns |  0.0028 ns |  0.0022 ns |   2.64 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     36.53 ns |  0.0074 ns |  0.0061 ns |   2.18 |     0.00 |
|                                               LinqToArray |              0 |     99.77 ns |  0.0627 ns |  0.0523 ns |   5.97 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     47.66 ns |  0.1033 ns |  0.0916 ns |   2.85 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     46.20 ns |  0.0683 ns |  0.0639 ns |   2.76 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     53.52 ns |  0.0299 ns |  0.0280 ns |   3.20 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     45.84 ns |  0.0350 ns |  0.0327 ns |   2.74 |     0.00 |
|                                                      Take |              0 |    126.35 ns |  0.0614 ns |  0.0513 ns |   7.56 |     0.00 |
|                                               LowCostTake |              0 |     45.71 ns |  0.0103 ns |  0.0092 ns |   2.73 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     41.67 ns |  0.0181 ns |  0.0160 ns |   2.49 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     55.97 ns |  0.0050 ns |  0.0041 ns |   3.35 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     52.53 ns |  0.0084 ns |  0.0078 ns |   3.14 |     0.00 |
|                                            SkipTakeSingle |              0 |    147.68 ns |  0.0443 ns |  0.0393 ns |   8.83 |     0.00 |
|                                     LowCostSkipTakeSingle |              0 |     55.17 ns |  0.0143 ns |  0.0119 ns |   3.30 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     55.05 ns |  0.0483 ns |  0.0404 ns |   3.29 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     72.75 ns |  0.0455 ns |  0.0425 ns |   4.35 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     57.74 ns |  0.0121 ns |  0.0101 ns |   3.45 |     0.00 |
|                                           ForeachDelegate |              0 |     20.57 ns |  0.0064 ns |  0.0057 ns |   1.23 |     0.00 |
|                                                   Foreach |              0 |     16.72 ns |  0.0082 ns |  0.0073 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **12,420.56 ns** |  **6.9163 ns** |  **6.4695 ns** |   **2.35** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  8,842.44 ns | 27.2632 ns | 25.5020 ns |   1.68 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  7,940.91 ns | 13.2788 ns | 11.7713 ns |   1.50 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  9,705.20 ns | 63.1216 ns | 59.0439 ns |   1.84 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  9,032.44 ns | 73.0063 ns | 68.2901 ns |   1.71 |     0.01 |
|                                LowCostLinqWithStructWhere |           1000 |  2,699.54 ns |  1.2823 ns |  1.0011 ns |   0.51 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,759.08 ns |  0.8957 ns |  0.7940 ns |   0.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 22,544.61 ns | 49.4200 ns | 46.2275 ns |   4.27 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 20,824.87 ns | 13.7198 ns | 12.8335 ns |   3.95 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,954.58 ns |  8.2660 ns |  7.3276 ns |   1.70 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,707.08 ns |  5.5542 ns |  4.9236 ns |   1.65 |     0.00 |
|                                                 LinqCount |           1000 |  6,333.79 ns |  7.6774 ns |  7.1814 ns |   1.20 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  8,471.44 ns |  6.3171 ns |  5.5999 ns |   1.61 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  6,496.26 ns |  1.1122 ns |  0.9859 ns |   1.23 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,766.87 ns |  0.7815 ns |  0.6927 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,227.80 ns |  0.1632 ns |  0.1527 ns |   0.23 |     0.00 |
|                                               LinqToArray |           1000 |  7,412.28 ns |  8.0432 ns |  7.5236 ns |   1.40 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  9,975.05 ns | 10.1090 ns |  8.9613 ns |   1.89 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  8,508.50 ns |  4.4817 ns |  3.9729 ns |   1.61 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,402.44 ns |  8.0717 ns |  7.5502 ns |   0.64 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,365.73 ns |  1.3130 ns |  1.0965 ns |   0.45 |     0.00 |
|                                                      Take |           1000 |    474.99 ns |  0.1831 ns |  0.1529 ns |   0.09 |     0.00 |
|                                               LowCostTake |           1000 |    229.93 ns |  0.1626 ns |  0.1521 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    207.67 ns |  0.1221 ns |  0.1142 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    128.59 ns |  0.0807 ns |  0.0755 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     96.63 ns |  0.0196 ns |  0.0174 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    389.56 ns |  0.1596 ns |  0.1333 ns |   0.07 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    290.68 ns |  0.2078 ns |  0.1944 ns |   0.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    225.05 ns |  0.2495 ns |  0.2334 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    120.08 ns |  0.0633 ns |  0.0561 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     84.74 ns |  0.0221 ns |  0.0196 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 | 10,181.94 ns |  0.5764 ns |  0.3430 ns |   1.93 |     0.00 |
|                                                   Foreach |           1000 |  5,278.09 ns |  4.8118 ns |  4.5010 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **154.15 ns** |  **0.0475 ns** |  **0.0397 ns** |   **3.59** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     77.84 ns |  0.0337 ns |  0.0299 ns |   1.81 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     66.03 ns |  0.0296 ns |  0.0247 ns |   1.54 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    109.18 ns |  0.0955 ns |  0.0894 ns |   2.55 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     98.05 ns |  0.0709 ns |  0.0663 ns |   2.29 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     62.32 ns |  0.0312 ns |  0.0276 ns |   1.45 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     54.09 ns |  0.0150 ns |  0.0140 ns |   1.26 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    222.13 ns |  0.1144 ns |  0.1070 ns |   5.18 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    208.48 ns |  0.1725 ns |  0.1530 ns |   4.86 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    134.14 ns |  0.1301 ns |  0.1217 ns |   3.13 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    126.71 ns |  0.1402 ns |  0.1242 ns |   2.95 |     0.00 |
|                                                 LinqCount |              5 |    124.31 ns |  0.1095 ns |  0.0970 ns |   2.90 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     78.77 ns |  0.0652 ns |  0.0578 ns |   1.84 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     66.33 ns |  0.0532 ns |  0.0498 ns |   1.55 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     52.78 ns |  0.0149 ns |  0.0125 ns |   1.23 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     39.85 ns |  0.0112 ns |  0.0099 ns |   0.93 |     0.00 |
|                                               LinqToArray |              5 |    178.28 ns |  0.1953 ns |  0.1827 ns |   4.16 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    127.98 ns |  0.1391 ns |  0.1301 ns |   2.98 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    120.93 ns |  0.1389 ns |  0.1299 ns |   2.82 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     97.31 ns |  0.0403 ns |  0.0357 ns |   2.27 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     85.26 ns |  0.0637 ns |  0.0596 ns |   1.99 |     0.00 |
|                                                      Take |              5 |    228.45 ns |  0.1402 ns |  0.1312 ns |   5.33 |     0.00 |
|                                               LowCostTake |              5 |     83.95 ns |  0.0143 ns |  0.0103 ns |   1.96 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     74.72 ns |  0.1306 ns |  0.1158 ns |   1.74 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     73.85 ns |  0.0311 ns |  0.0260 ns |   1.72 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     64.16 ns |  0.0476 ns |  0.0446 ns |   1.50 |     0.00 |
|                                            SkipTakeSingle |              5 |    208.82 ns |  0.0853 ns |  0.0798 ns |   4.87 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |    100.93 ns |  0.0646 ns |  0.0604 ns |   2.35 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     88.37 ns |  0.0666 ns |  0.0623 ns |   2.06 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     76.23 ns |  0.0553 ns |  0.0517 ns |   1.78 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     62.61 ns |  0.0525 ns |  0.0491 ns |   1.46 |     0.00 |
|                                           ForeachDelegate |              5 |     71.65 ns |  1.3558 ns |  1.1322 ns |   1.67 |     0.03 |
|                                                   Foreach |              5 |     42.89 ns |  0.0268 ns |  0.0237 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **717.26 ns** |  **0.5689 ns** |  **0.5322 ns** |   **2.49** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    478.82 ns |  0.0861 ns |  0.0806 ns |   1.66 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    426.42 ns |  0.1556 ns |  0.1455 ns |   1.48 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    551.88 ns |  0.0571 ns |  0.0446 ns |   1.92 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    516.94 ns |  0.3897 ns |  0.3645 ns |   1.80 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    189.91 ns |  0.0244 ns |  0.0203 ns |   0.66 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    138.17 ns |  0.0220 ns |  0.0206 ns |   0.48 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,233.58 ns |  2.4826 ns |  2.3223 ns |   4.28 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,142.81 ns |  1.0586 ns |  0.9384 ns |   3.97 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    539.27 ns |  0.1196 ns |  0.1060 ns |   1.87 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    521.95 ns |  0.2031 ns |  0.1800 ns |   1.81 |     0.00 |
|                                                 LinqCount |             50 |    404.97 ns |  0.1832 ns |  0.1530 ns |   1.41 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    472.85 ns |  0.1879 ns |  0.1758 ns |   1.64 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    363.41 ns |  0.0823 ns |  0.0730 ns |   1.26 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    141.84 ns |  0.9790 ns |  0.9158 ns |   0.49 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     90.18 ns |  0.0186 ns |  0.0165 ns |   0.31 |     0.00 |
|                                               LinqToArray |             50 |    689.19 ns |  1.0190 ns |  0.9532 ns |   2.39 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    654.95 ns |  0.4158 ns |  0.3686 ns |   2.27 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    582.76 ns |  0.7112 ns |  0.6652 ns |   2.02 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    299.43 ns |  0.1893 ns |  0.1678 ns |   1.04 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    239.69 ns |  0.1352 ns |  0.1199 ns |   0.83 |     0.00 |
|                                                      Take |             50 |    470.20 ns |  0.0617 ns |  0.0482 ns |   1.63 |     0.00 |
|                                               LowCostTake |             50 |    229.64 ns |  0.0952 ns |  0.0891 ns |   0.80 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    207.14 ns |  0.1783 ns |  0.1581 ns |   0.72 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    121.19 ns |  0.0643 ns |  0.0602 ns |   0.42 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     95.66 ns |  0.0621 ns |  0.0581 ns |   0.33 |     0.00 |
|                                            SkipTakeSingle |             50 |    386.95 ns |  0.1948 ns |  0.1727 ns |   1.34 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    275.44 ns |  0.2571 ns |  0.2405 ns |   0.96 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    225.78 ns |  0.3611 ns |  0.3378 ns |   0.78 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    119.62 ns |  0.0853 ns |  0.0798 ns |   0.42 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     84.45 ns |  0.0470 ns |  0.0393 ns |   0.29 |     0.00 |
|                                           ForeachDelegate |             50 |    535.38 ns |  0.1738 ns |  0.1541 ns |   1.86 |     0.00 |
|                                                   Foreach |             50 |    287.92 ns |  0.2262 ns |  0.2116 ns |   1.00 |     0.00 |
