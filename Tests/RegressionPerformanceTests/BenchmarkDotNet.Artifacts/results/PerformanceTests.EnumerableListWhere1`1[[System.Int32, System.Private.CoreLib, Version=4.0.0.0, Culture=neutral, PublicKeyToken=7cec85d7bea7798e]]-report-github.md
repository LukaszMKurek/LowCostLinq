``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **36.92 ns** |  **0.0179 ns** |  **0.0168 ns** |   **2.21** |     **0.02** |
|                                   LowCostLinqWithDelegate |              0 |     33.75 ns |  0.2582 ns |  0.2415 ns |   2.02 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     28.43 ns |  0.0011 ns |  0.0009 ns |   1.71 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     41.18 ns |  0.0061 ns |  0.0051 ns |   2.47 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     37.53 ns |  0.0094 ns |  0.0088 ns |   2.25 |     0.02 |
|                                LowCostLinqWithStructWhere |              0 |     37.62 ns |  0.0052 ns |  0.0043 ns |   2.26 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     30.47 ns |  0.0018 ns |  0.0015 ns |   1.83 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     74.96 ns |  0.0725 ns |  0.0566 ns |   4.50 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     68.54 ns |  0.0863 ns |  0.0807 ns |   4.11 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     75.53 ns |  0.0964 ns |  0.0901 ns |   4.53 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     68.64 ns |  0.0802 ns |  0.0669 ns |   4.12 |     0.03 |
|                                                 LinqCount |              0 |     34.12 ns |  0.1632 ns |  0.1527 ns |   2.05 |     0.02 |
|                              LowCostLinqWithDelegateCount |              0 |     31.09 ns |  0.0231 ns |  0.0216 ns |   1.86 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     29.47 ns |  0.0179 ns |  0.0167 ns |   1.77 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     29.60 ns |  0.0056 ns |  0.0050 ns |   1.78 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     21.66 ns |  0.1388 ns |  0.1231 ns |   1.30 |     0.01 |
|                                               LinqToArray |              0 |     44.58 ns |  0.0757 ns |  0.0708 ns |   2.67 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              0 |     42.28 ns |  0.0427 ns |  0.0400 ns |   2.54 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     41.63 ns |  0.3512 ns |  0.3285 ns |   2.50 |     0.03 |
|                              LowCostLinqWithStructToArray |              0 |     39.06 ns |  0.0927 ns |  0.0867 ns |   2.34 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     31.36 ns |  0.0442 ns |  0.0414 ns |   1.88 |     0.01 |
|                                                      Take |              0 |     71.00 ns |  0.0768 ns |  0.0718 ns |   4.26 |     0.03 |
|                                               LowCostTake |              0 |     41.74 ns |  0.1845 ns |  0.1636 ns |   2.50 |     0.02 |
|                                  LowCostTakeWithoutChecks |              0 |     37.83 ns |  0.0062 ns |  0.0055 ns |   2.27 |     0.02 |
|                                     LowCostTakeWithStruct |              0 |     52.57 ns |  0.0042 ns |  0.0035 ns |   3.15 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     39.55 ns |  0.0092 ns |  0.0077 ns |   2.37 |     0.02 |
|                                            SkipTakeSingle |              0 |     95.53 ns |  0.0832 ns |  0.0778 ns |   5.73 |     0.04 |
|                                     LowCostSkipTakeSingle |              0 |     46.82 ns |  0.0040 ns |  0.0033 ns |   2.81 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     44.90 ns |  0.0085 ns |  0.0075 ns |   2.69 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     50.28 ns |  0.0028 ns |  0.0023 ns |   3.02 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     42.48 ns |  0.0266 ns |  0.0249 ns |   2.55 |     0.02 |
|                                           ForeachDelegate |              0 |     19.00 ns |  0.0199 ns |  0.0186 ns |   1.14 |     0.01 |
|                                                   Foreach |              0 |     16.67 ns |  0.1299 ns |  0.1215 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** |  **7,393.04 ns** |  **5.0646 ns** |  **4.7375 ns** |   **1.47** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  4,832.05 ns |  4.4424 ns |  4.1555 ns |   0.96 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  3,140.27 ns |  3.1899 ns |  2.9839 ns |   0.62 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  4,382.44 ns | 41.9175 ns | 39.2096 ns |   0.87 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  3,404.24 ns |  0.5343 ns |  0.3534 ns |   0.68 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,676.85 ns |  3.5353 ns |  3.1340 ns |   0.53 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,745.80 ns |  2.9191 ns |  2.4376 ns |   0.35 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 11,108.54 ns | 12.1605 ns | 10.7800 ns |   2.20 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 |  9,677.60 ns | 16.4077 ns | 15.3477 ns |   1.92 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,471.34 ns |  8.7347 ns |  8.1705 ns |   1.68 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,536.09 ns | 67.2733 ns | 62.9274 ns |   1.49 |     0.01 |
|                                                 LinqCount |           1000 |  1,482.08 ns |  1.9828 ns |  1.8547 ns |   0.29 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  3,621.27 ns |  2.6519 ns |  2.4806 ns |   0.72 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  2,440.36 ns | 18.8545 ns | 17.6365 ns |   0.48 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,731.31 ns |  1.3893 ns |  1.2995 ns |   0.34 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,212.79 ns |  0.1345 ns |  0.1123 ns |   0.24 |     0.00 |
|                                               LinqToArray |           1000 |  3,436.53 ns |  2.5775 ns |  2.0124 ns |   0.68 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  5,609.93 ns |  9.9778 ns |  9.3332 ns |   1.11 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  3,959.93 ns |  7.8750 ns |  6.9810 ns |   0.79 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,174.60 ns |  7.4049 ns |  6.5643 ns |   0.63 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,299.58 ns | 28.6865 ns | 26.8334 ns |   0.46 |     0.01 |
|                                                      Take |           1000 |    307.08 ns |  0.1492 ns |  0.1323 ns |   0.06 |     0.00 |
|                                               LowCostTake |           1000 |    144.26 ns |  0.0822 ns |  0.0769 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    114.70 ns |  0.0144 ns |  0.0135 ns |   0.02 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    109.73 ns |  0.0609 ns |  0.0569 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     84.22 ns |  0.0266 ns |  0.0248 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    229.61 ns |  0.1302 ns |  0.1217 ns |   0.05 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    135.26 ns |  1.3443 ns |  1.2574 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    113.28 ns |  0.0687 ns |  0.0573 ns |   0.02 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     90.86 ns |  0.0385 ns |  0.0341 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     62.06 ns |  0.2678 ns |  0.2374 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |           1000 |  6,241.35 ns |  3.1642 ns |  2.9598 ns |   1.24 |     0.00 |
|                                                   Foreach |           1000 |  5,041.61 ns |  3.3412 ns |  3.1254 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |     **73.01 ns** |  **0.0294 ns** |  **0.0261 ns** |   **1.71** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     55.31 ns |  0.0219 ns |  0.0205 ns |   1.29 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     45.96 ns |  0.2989 ns |  0.2796 ns |   1.07 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |     62.63 ns |  0.0358 ns |  0.0335 ns |   1.46 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     56.71 ns |  0.0169 ns |  0.0158 ns |   1.32 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     60.33 ns |  0.1816 ns |  0.1698 ns |   1.41 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     42.70 ns |  0.0209 ns |  0.0174 ns |   1.00 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    131.75 ns |  0.1541 ns |  0.1366 ns |   3.08 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    117.97 ns |  0.0522 ns |  0.0463 ns |   2.76 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    118.85 ns |  0.0836 ns |  0.0741 ns |   2.78 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    108.39 ns |  0.1419 ns |  0.1328 ns |   2.53 |     0.00 |
|                                                 LinqCount |              5 |     41.31 ns |  0.0323 ns |  0.0287 ns |   0.97 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     50.61 ns |  0.0128 ns |  0.0120 ns |   1.18 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     43.24 ns |  0.0169 ns |  0.0158 ns |   1.01 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     38.10 ns |  0.0216 ns |  0.0180 ns |   0.89 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     25.77 ns |  0.0194 ns |  0.0182 ns |   0.60 |     0.00 |
|                                               LinqToArray |              5 |     95.76 ns |  1.0790 ns |  1.0093 ns |   2.24 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              5 |    101.12 ns |  0.1210 ns |  0.1132 ns |   2.36 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     92.74 ns |  0.1158 ns |  0.1083 ns |   2.17 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     85.12 ns |  0.9637 ns |  0.9014 ns |   1.99 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     73.03 ns |  0.0661 ns |  0.0618 ns |   1.71 |     0.00 |
|                                                      Take |              5 |    129.92 ns |  0.0462 ns |  0.0433 ns |   3.04 |     0.00 |
|                                               LowCostTake |              5 |     66.30 ns |  0.0174 ns |  0.0136 ns |   1.55 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     57.32 ns |  0.2664 ns |  0.2361 ns |   1.34 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     59.58 ns |  0.0116 ns |  0.0109 ns |   1.39 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     54.62 ns |  0.0215 ns |  0.0201 ns |   1.28 |     0.00 |
|                                            SkipTakeSingle |              5 |    125.00 ns |  0.1704 ns |  0.1593 ns |   2.92 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     65.37 ns |  0.6872 ns |  0.6428 ns |   1.53 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     57.40 ns |  0.0113 ns |  0.0101 ns |   1.34 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     66.56 ns |  0.0334 ns |  0.0312 ns |   1.56 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     46.09 ns |  0.0119 ns |  0.0093 ns |   1.08 |     0.00 |
|                                           ForeachDelegate |              5 |     51.47 ns |  0.0803 ns |  0.0712 ns |   1.20 |     0.00 |
|                                                   Foreach |              5 |     42.80 ns |  0.0129 ns |  0.0121 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **412.70 ns** |  **0.1425 ns** |  **0.1333 ns** |   **1.49** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    275.60 ns |  2.1317 ns |  1.9940 ns |   1.00 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    191.29 ns |  0.0482 ns |  0.0450 ns |   0.69 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    258.75 ns |  0.0148 ns |  0.0123 ns |   0.94 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    213.69 ns |  0.0918 ns |  0.0813 ns |   0.77 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    176.69 ns |  0.0609 ns |  0.0509 ns |   0.64 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    126.63 ns |  0.0428 ns |  0.0358 ns |   0.46 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    635.42 ns |  0.3211 ns |  0.2846 ns |   2.30 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    560.35 ns |  0.1132 ns |  0.1004 ns |   2.03 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    505.59 ns |  3.2407 ns |  3.0313 ns |   1.83 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    452.84 ns |  0.0884 ns |  0.0738 ns |   1.64 |     0.00 |
|                                                 LinqCount |             50 |    112.35 ns |  0.1269 ns |  0.1187 ns |   0.41 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    219.96 ns |  0.2047 ns |  0.1598 ns |   0.80 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    156.95 ns |  0.0875 ns |  0.0818 ns |   0.57 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    123.34 ns |  0.0277 ns |  0.0246 ns |   0.45 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     75.70 ns |  0.0358 ns |  0.0335 ns |   0.27 |     0.00 |
|                                               LinqToArray |             50 |    373.70 ns |  0.4603 ns |  0.3844 ns |   1.35 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    425.60 ns |  0.2142 ns |  0.1788 ns |   1.54 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    328.71 ns |  0.5577 ns |  0.5216 ns |   1.19 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    282.82 ns |  3.3870 ns |  3.1682 ns |   1.02 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    225.24 ns |  0.3705 ns |  0.3466 ns |   0.81 |     0.00 |
|                                                      Take |             50 |    308.02 ns |  0.1009 ns |  0.0895 ns |   1.11 |     0.00 |
|                                               LowCostTake |             50 |    144.21 ns |  0.0418 ns |  0.0391 ns |   0.52 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    114.82 ns |  0.0572 ns |  0.0507 ns |   0.42 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    109.64 ns |  0.0656 ns |  0.0613 ns |   0.40 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     86.12 ns |  0.0268 ns |  0.0251 ns |   0.31 |     0.00 |
|                                            SkipTakeSingle |             50 |    229.50 ns |  0.1272 ns |  0.1062 ns |   0.83 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    134.12 ns |  0.0216 ns |  0.0168 ns |   0.49 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    110.61 ns |  0.0357 ns |  0.0317 ns |   0.40 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     90.87 ns |  0.0656 ns |  0.0512 ns |   0.33 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     63.49 ns |  0.0512 ns |  0.0454 ns |   0.23 |     0.00 |
|                                           ForeachDelegate |             50 |    342.77 ns |  0.0744 ns |  0.0660 ns |   1.24 |     0.00 |
|                                                   Foreach |             50 |    276.44 ns |  0.1625 ns |  0.1520 ns |   1.00 |     0.00 |
