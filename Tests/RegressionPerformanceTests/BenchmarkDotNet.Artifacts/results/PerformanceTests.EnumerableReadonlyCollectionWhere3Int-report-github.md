``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **116.71 ns** |   **0.0666 ns** |     **0.0623 ns** |    **116.71 ns** |  **6.30** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     49.95 ns |   0.0176 ns |     0.0147 ns |     49.94 ns |  2.70 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     45.42 ns |   0.0097 ns |     0.0091 ns |     45.42 ns |  2.45 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     71.42 ns |   0.0281 ns |     0.0263 ns |     71.42 ns |  3.85 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     63.94 ns |   0.0135 ns |     0.0126 ns |     63.94 ns |  3.45 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     57.70 ns |   0.0150 ns |     0.0140 ns |     57.69 ns |  3.11 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     53.70 ns |   0.0257 ns |     0.0240 ns |     53.69 ns |  2.90 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    130.01 ns |   0.0795 ns |     0.0744 ns |    130.01 ns |  7.02 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    116.37 ns |   0.2052 ns |     0.1714 ns |    116.30 ns |  6.28 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    115.11 ns |   0.0503 ns |     0.0470 ns |    115.13 ns |  6.21 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    101.74 ns |   0.0361 ns |     0.0338 ns |    101.74 ns |  5.49 |    0.00 |
|                                                 LinqCount |            [0] |    113.06 ns |   0.0315 ns |     0.0263 ns |    113.07 ns |  6.10 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     51.99 ns |   0.2934 ns |     0.2744 ns |     52.00 ns |  2.80 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     50.35 ns |   0.0147 ns |     0.0138 ns |     50.35 ns |  2.72 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     49.73 ns |   0.0271 ns |     0.0240 ns |     49.73 ns |  2.68 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     50.25 ns |   0.1102 ns |     0.1031 ns |     50.30 ns |  2.71 |    0.01 |
|                                               LinqToArray |            [0] |    128.65 ns |   0.0364 ns |     0.0340 ns |    128.65 ns |  6.94 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     66.59 ns |   0.0921 ns |     0.0862 ns |     66.59 ns |  3.59 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     65.98 ns |   0.0408 ns |     0.0381 ns |     65.97 ns |  3.56 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     60.06 ns |   0.0468 ns |     0.0438 ns |     60.06 ns |  3.24 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     60.37 ns |   0.0259 ns |     0.0229 ns |     60.37 ns |  3.26 |    0.00 |
|                                                      Take |            [0] |    153.00 ns |   0.1328 ns |     0.1242 ns |    153.02 ns |  8.26 |    0.01 |
|                                               LowCostTake |            [0] |     55.44 ns |   0.3285 ns |     0.3073 ns |     55.29 ns |  2.99 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [0] |     56.44 ns |   0.0413 ns |     0.0386 ns |     56.43 ns |  3.05 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     65.01 ns |   0.0137 ns |     0.0114 ns |     65.01 ns |  3.51 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     62.33 ns |   0.0689 ns |     0.0645 ns |     62.35 ns |  3.36 |    0.00 |
|                                            SkipTakeSingle |            [0] |    171.90 ns |   0.0566 ns |     0.0529 ns |    171.92 ns |  9.28 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     72.72 ns |   0.0386 ns |     0.0361 ns |     72.71 ns |  3.93 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     70.98 ns |   0.0196 ns |     0.0164 ns |     70.98 ns |  3.83 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     72.33 ns |   0.0766 ns |     0.0716 ns |     72.34 ns |  3.90 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     71.93 ns |   0.0213 ns |     0.0200 ns |     71.93 ns |  3.88 |    0.00 |
|                                           ForeachDelegate |            [0] |     21.61 ns |   0.0058 ns |     0.0054 ns |     21.61 ns |  1.17 |    0.00 |
|                                                   Foreach |            [0] |     18.53 ns |   0.0118 ns |     0.0104 ns |     18.52 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **17,168.78 ns** | **217.4623 ns** |   **181.5909 ns** | **17,072.85 ns** |  **3.11** |    **0.03** |
|                                   LowCostLinqWithDelegate |         [1000] | 20,886.81 ns | 300.7740 ns |   281.3442 ns | 20,877.77 ns |  3.78 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 14,700.96 ns | 334.4400 ns |   398.1270 ns | 14,492.60 ns |  2.66 |    0.06 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 15,605.05 ns | 305.4417 ns |   299.9845 ns | 15,683.81 ns |  2.82 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 15,644.46 ns | 308.8225 ns |   594.9961 ns | 15,268.70 ns |  2.90 |    0.12 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,011.11 ns |   1.6985 ns |     1.5888 ns |  7,011.00 ns |  1.27 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,766.51 ns |   5.2446 ns |     4.6492 ns |  6,766.31 ns |  1.22 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 34,083.50 ns | 363.4692 ns |   339.9893 ns | 34,142.33 ns |  6.17 |    0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 27,757.12 ns | 548.4063 ns | 1,016.5063 ns | 27,188.82 ns |  5.05 |    0.20 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 14,560.83 ns |   3.3985 ns |     3.1789 ns | 14,561.24 ns |  2.64 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 14,243.67 ns |   6.5267 ns |     6.1051 ns | 14,243.22 ns |  2.58 |    0.00 |
|                                                 LinqCount |         [1000] | 17,107.04 ns | 154.4311 ns |   144.4549 ns | 17,105.17 ns |  3.10 |    0.03 |
|                              LowCostLinqWithDelegateCount |         [1000] | 13,407.34 ns | 263.7069 ns |   600.5940 ns | 13,243.71 ns |  2.41 |    0.11 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 19,573.21 ns | 349.3336 ns |   326.7669 ns | 19,642.80 ns |  3.54 |    0.06 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,567.07 ns |   1.0602 ns |     0.9917 ns |  5,567.57 ns |  1.01 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,045.04 ns |  14.1126 ns |    13.2010 ns |  6,038.20 ns |  1.09 |    0.00 |
|                                               LinqToArray |         [1000] | 14,840.14 ns |  18.8242 ns |    17.6082 ns | 14,836.79 ns |  2.69 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 14,883.82 ns |  83.6311 ns |    74.1368 ns | 14,905.36 ns |  2.69 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 14,443.85 ns |  13.8623 ns |    12.9668 ns | 14,441.20 ns |  2.61 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,549.26 ns |   5.2642 ns |     4.9242 ns |  7,546.61 ns |  1.37 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,315.41 ns |  11.4883 ns |    10.7462 ns |  7,314.45 ns |  1.32 |    0.00 |
|                                                      Take |         [1000] |    590.58 ns |   0.6454 ns |     0.6037 ns |    590.72 ns |  0.11 |    0.00 |
|                                               LowCostTake |         [1000] |    368.21 ns |   7.2801 ns |     7.1500 ns |    369.02 ns |  0.07 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    334.33 ns |   3.4619 ns |     3.2383 ns |    334.63 ns |  0.06 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    212.94 ns |   0.1424 ns |     0.1332 ns |    212.88 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    205.71 ns |   0.0536 ns |     0.0475 ns |    205.71 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    505.40 ns |   3.3070 ns |     3.0933 ns |    506.40 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    374.13 ns |   4.7357 ns |     4.4298 ns |    373.70 ns |  0.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    380.17 ns |   2.3833 ns |     2.2294 ns |    379.81 ns |  0.07 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    219.09 ns |   0.0904 ns |     0.0802 ns |    219.07 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    220.41 ns |   0.1677 ns |     0.1569 ns |    220.35 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,654.29 ns |   2.2114 ns |     1.9603 ns |  9,654.20 ns |  1.75 |    0.00 |
|                                                   Foreach |         [1000] |  5,525.59 ns |   0.9990 ns |     0.9344 ns |  5,525.76 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **971.32 ns** |   **3.9011 ns** |     **3.6491 ns** |    **972.72 ns** |  **3.22** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    813.71 ns |  13.2900 ns |    12.4315 ns |    809.49 ns |  2.69 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    905.53 ns |  24.7334 ns |    72.9270 ns |    947.07 ns |  3.16 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |    819.63 ns |  16.4044 ns |    18.2334 ns |    806.47 ns |  2.70 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    882.06 ns |   7.7731 ns |     7.2709 ns |    881.83 ns |  2.93 |    0.03 |
|                                LowCostLinqWithStructWhere |           [50] |    408.21 ns |   0.1826 ns |     0.1708 ns |    408.15 ns |  1.35 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    394.76 ns |   0.1164 ns |     0.1032 ns |    394.75 ns |  1.31 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,531.69 ns |  21.8153 ns |    20.4061 ns |  1,535.17 ns |  5.08 |    0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,485.49 ns |  12.7749 ns |    11.9497 ns |  1,479.87 ns |  4.93 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    858.92 ns |   0.2864 ns |     0.2392 ns |    858.86 ns |  2.85 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    825.18 ns |   0.2529 ns |     0.2366 ns |    825.21 ns |  2.74 |    0.00 |
|                                                 LinqCount |           [50] |    741.80 ns |   1.4259 ns |     1.1907 ns |    742.09 ns |  2.46 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    728.82 ns |  14.3349 ns |    17.0647 ns |    730.46 ns |  2.43 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    740.52 ns |   7.0626 ns |     6.6063 ns |    741.56 ns |  2.46 |    0.02 |
|                           LowCostLinqWithStructWhereCount |           [50] |    338.64 ns |   0.0667 ns |     0.0624 ns |    338.62 ns |  1.12 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    356.93 ns |   0.0830 ns |     0.0736 ns |    356.95 ns |  1.18 |    0.00 |
|                                               LinqToArray |           [50] |  1,071.96 ns |   1.3470 ns |     1.2600 ns |  1,071.68 ns |  3.56 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    909.86 ns |   1.3548 ns |     1.2010 ns |    910.37 ns |  3.02 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    896.55 ns |   1.3658 ns |     1.2776 ns |    896.30 ns |  2.98 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    543.12 ns |   0.1970 ns |     0.1843 ns |    543.20 ns |  1.80 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    521.07 ns |   0.3236 ns |     0.3027 ns |    521.17 ns |  1.73 |    0.00 |
|                                                      Take |           [50] |    588.82 ns |   0.7701 ns |     0.7203 ns |    588.89 ns |  1.95 |    0.00 |
|                                               LowCostTake |           [50] |    366.86 ns |   7.2123 ns |     6.7464 ns |    365.54 ns |  1.22 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    332.87 ns |   2.4397 ns |     2.0373 ns |    332.54 ns |  1.10 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    213.19 ns |   0.0821 ns |     0.0728 ns |    213.18 ns |  0.71 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    207.07 ns |   0.1113 ns |     0.1041 ns |    207.05 ns |  0.69 |    0.00 |
|                                            SkipTakeSingle |           [50] |    495.05 ns |   0.7949 ns |     0.7435 ns |    494.74 ns |  1.64 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    367.31 ns |   4.3427 ns |     4.0622 ns |    365.26 ns |  1.22 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    377.97 ns |   7.2862 ns |     8.3908 ns |    377.70 ns |  1.26 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    221.19 ns |   0.0708 ns |     0.0663 ns |    221.19 ns |  0.73 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    220.06 ns |   0.0480 ns |     0.0449 ns |    220.07 ns |  0.73 |    0.00 |
|                                           ForeachDelegate |           [50] |    512.56 ns |   0.1275 ns |     0.1192 ns |    512.57 ns |  1.70 |    0.00 |
|                                                   Foreach |           [50] |    301.36 ns |   0.0606 ns |     0.0506 ns |    301.36 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **212.78 ns** |   **0.0498 ns** |     **0.0466 ns** |    **212.78 ns** |  **4.57** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    133.68 ns |   0.2785 ns |     0.2606 ns |    133.63 ns |  2.87 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    130.39 ns |   0.1551 ns |     0.1451 ns |    130.37 ns |  2.80 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    156.12 ns |   0.2181 ns |     0.2040 ns |    156.11 ns |  3.35 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    158.37 ns |   2.9793 ns |     2.7868 ns |    159.00 ns |  3.40 |    0.06 |
|                                LowCostLinqWithStructWhere |            [5] |     83.39 ns |   0.1299 ns |     0.1215 ns |     83.43 ns |  1.79 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     81.88 ns |   0.0422 ns |     0.0395 ns |     81.89 ns |  1.76 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    279.14 ns |   0.2728 ns |     0.2552 ns |    279.16 ns |  5.99 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    277.05 ns |   0.2209 ns |     0.1958 ns |    277.00 ns |  5.95 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    200.74 ns |   0.0546 ns |     0.0510 ns |    200.75 ns |  4.31 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    182.77 ns |   0.2562 ns |     0.2271 ns |    182.66 ns |  3.92 |    0.01 |
|                                                 LinqCount |            [5] |    187.65 ns |   0.0524 ns |     0.0490 ns |    187.66 ns |  4.03 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    125.98 ns |   0.5070 ns |     0.4742 ns |    125.80 ns |  2.71 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    125.22 ns |   0.9310 ns |     0.8708 ns |    124.89 ns |  2.69 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |     76.44 ns |   0.0691 ns |     0.0646 ns |     76.44 ns |  1.64 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     77.86 ns |   0.0386 ns |     0.0361 ns |     77.85 ns |  1.67 |    0.00 |
|                                               LinqToArray |            [5] |    256.11 ns |   0.0865 ns |     0.0810 ns |    256.10 ns |  5.50 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    165.87 ns |   0.0761 ns |     0.0712 ns |    165.88 ns |  3.56 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    163.37 ns |   0.2048 ns |     0.1915 ns |    163.35 ns |  3.51 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    124.47 ns |   0.0310 ns |     0.0290 ns |    124.47 ns |  2.67 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    124.64 ns |   0.0290 ns |     0.0272 ns |    124.63 ns |  2.68 |    0.00 |
|                                                      Take |            [5] |    281.83 ns |   0.2733 ns |     0.2557 ns |    281.74 ns |  6.05 |    0.01 |
|                                               LowCostTake |            [5] |    139.69 ns |   0.2259 ns |     0.2002 ns |    139.67 ns |  3.00 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    139.24 ns |   0.3772 ns |     0.3528 ns |    139.30 ns |  2.99 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |     93.71 ns |   0.0241 ns |     0.0214 ns |     93.71 ns |  2.01 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     90.55 ns |   0.0212 ns |     0.0188 ns |     90.55 ns |  1.94 |    0.00 |
|                                            SkipTakeSingle |            [5] |    260.74 ns |   0.5307 ns |     0.4964 ns |    260.49 ns |  5.60 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    147.56 ns |   0.6969 ns |     0.6519 ns |    147.46 ns |  3.17 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    144.75 ns |   0.2619 ns |     0.2187 ns |    144.68 ns |  3.11 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    104.10 ns |   0.0822 ns |     0.0729 ns |    104.12 ns |  2.24 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    104.14 ns |   0.0933 ns |     0.0729 ns |    104.13 ns |  2.24 |    0.00 |
|                                           ForeachDelegate |            [5] |     69.89 ns |   0.0214 ns |     0.0200 ns |     69.89 ns |  1.50 |    0.00 |
|                                                   Foreach |            [5] |     46.57 ns |   0.0282 ns |     0.0264 ns |     46.56 ns |  1.00 |    0.00 |
