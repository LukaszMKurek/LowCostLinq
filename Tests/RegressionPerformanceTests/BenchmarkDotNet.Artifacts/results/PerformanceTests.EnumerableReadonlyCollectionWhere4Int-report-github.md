``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **146.72 ns** |   **0.0843 ns** |     **0.0747 ns** |    **146.70 ns** |  **8.11** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     54.46 ns |   0.0194 ns |     0.0162 ns |     54.45 ns |  3.01 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     51.89 ns |   0.0195 ns |     0.0182 ns |     51.89 ns |  2.87 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     81.62 ns |   0.0130 ns |     0.0116 ns |     81.61 ns |  4.51 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     77.69 ns |   0.0179 ns |     0.0158 ns |     77.69 ns |  4.29 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     66.27 ns |   0.0291 ns |     0.0272 ns |     66.27 ns |  3.66 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     61.57 ns |   0.0260 ns |     0.0230 ns |     61.57 ns |  3.40 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    138.44 ns |   0.2796 ns |     0.2479 ns |    138.51 ns |  7.65 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    129.89 ns |   0.0502 ns |     0.0470 ns |    129.89 ns |  7.18 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    129.84 ns |   0.0940 ns |     0.0834 ns |    129.84 ns |  7.17 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    116.92 ns |   0.0574 ns |     0.0537 ns |    116.90 ns |  6.46 |    0.01 |
|                                                 LinqCount |            [0] |    146.08 ns |   0.4428 ns |     0.4142 ns |    146.24 ns |  8.07 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [0] |     58.29 ns |   0.0555 ns |     0.0519 ns |     58.27 ns |  3.22 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     56.25 ns |   0.0262 ns |     0.0245 ns |     56.25 ns |  3.11 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     57.67 ns |   0.0250 ns |     0.0222 ns |     57.66 ns |  3.19 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     57.98 ns |   0.0230 ns |     0.0204 ns |     57.99 ns |  3.20 |    0.00 |
|                                               LinqToArray |            [0] |    158.08 ns |   0.0500 ns |     0.0467 ns |    158.09 ns |  8.73 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     71.47 ns |   0.0624 ns |     0.0584 ns |     71.48 ns |  3.95 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     69.33 ns |   0.0691 ns |     0.0647 ns |     69.33 ns |  3.83 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     68.22 ns |   0.0254 ns |     0.0225 ns |     68.22 ns |  3.77 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     69.15 ns |   0.0301 ns |     0.0282 ns |     69.14 ns |  3.82 |    0.00 |
|                                                      Take |            [0] |    185.40 ns |   0.1318 ns |     0.1029 ns |    185.39 ns | 10.24 |    0.01 |
|                                               LowCostTake |            [0] |     70.12 ns |   0.0565 ns |     0.0528 ns |     70.14 ns |  3.87 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     64.77 ns |   0.0309 ns |     0.0289 ns |     64.78 ns |  3.58 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     77.27 ns |   0.0260 ns |     0.0230 ns |     77.27 ns |  4.27 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     74.32 ns |   0.0272 ns |     0.0255 ns |     74.33 ns |  4.11 |    0.00 |
|                                            SkipTakeSingle |            [0] |    205.66 ns |   0.0640 ns |     0.0599 ns |    205.66 ns | 11.36 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     93.51 ns |   0.0422 ns |     0.0395 ns |     93.53 ns |  5.17 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     93.67 ns |   0.0257 ns |     0.0228 ns |     93.68 ns |  5.18 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     94.91 ns |   0.0273 ns |     0.0255 ns |     94.91 ns |  5.24 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     95.01 ns |   0.0242 ns |     0.0215 ns |     95.01 ns |  5.25 |    0.00 |
|                                           ForeachDelegate |            [0] |     22.06 ns |   0.0136 ns |     0.0121 ns |     22.07 ns |  1.22 |    0.00 |
|                                                   Foreach |            [0] |     18.10 ns |   0.0106 ns |     0.0099 ns |     18.10 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **20,049.31 ns** | **391.2394 ns** |   **674.8688 ns** | **19,807.49 ns** |  **3.64** |    **0.13** |
|                                   LowCostLinqWithDelegate |         [1000] | 15,532.04 ns |  99.3832 ns |    82.9894 ns | 15,544.53 ns |  2.81 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 17,096.32 ns | 504.7109 ns |   673.7746 ns | 16,803.97 ns |  3.11 |    0.13 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 16,875.30 ns | 357.9395 ns |   793.1691 ns | 16,437.62 ns |  3.03 |    0.11 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 18,605.53 ns | 394.8543 ns | 1,151.8085 ns | 17,850.58 ns |  3.32 |    0.19 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,558.20 ns |   3.3364 ns |     2.9577 ns |  6,558.42 ns |  1.19 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,530.81 ns |   2.6317 ns |     2.3330 ns |  6,530.12 ns |  1.18 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 30,838.98 ns | 616.0878 ns | 1,244.5277 ns | 30,086.69 ns |  5.62 |    0.27 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 30,220.12 ns | 555.1149 ns |   463.5461 ns | 30,085.74 ns |  5.47 |    0.08 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 14,278.70 ns |   5.0768 ns |     4.5004 ns | 14,278.44 ns |  2.58 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 12,835.46 ns |   4.9001 ns |     4.5835 ns | 12,834.59 ns |  2.32 |    0.00 |
|                                                 LinqCount |         [1000] | 15,630.33 ns | 304.4597 ns |   325.7685 ns | 15,569.71 ns |  2.83 |    0.06 |
|                              LowCostLinqWithDelegateCount |         [1000] | 15,512.67 ns | 343.8431 ns | 1,013.8291 ns | 15,350.12 ns |  2.82 |    0.17 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 14,202.60 ns |  47.3221 ns |    44.2652 ns | 14,184.90 ns |  2.57 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,044.02 ns |   1.6475 ns |     1.5411 ns |  6,044.02 ns |  1.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,572.64 ns |   3.0702 ns |     2.5637 ns |  5,573.27 ns |  1.01 |    0.00 |
|                                               LinqToArray |         [1000] | 17,328.81 ns |  76.8980 ns |    71.9305 ns | 17,331.32 ns |  3.14 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 17,449.69 ns |  43.5589 ns |    40.7451 ns | 17,447.69 ns |  3.16 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 17,094.58 ns |  60.3311 ns |    56.4338 ns | 17,092.87 ns |  3.09 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,315.71 ns |   3.9103 ns |     3.6577 ns |  7,315.66 ns |  1.32 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,334.31 ns |   9.0117 ns |     7.9886 ns |  7,336.02 ns |  1.33 |    0.00 |
|                                                      Take |         [1000] |    656.02 ns |   0.7725 ns |     0.7226 ns |    655.94 ns |  0.12 |    0.00 |
|                                               LowCostTake |         [1000] |    415.32 ns |   8.1488 ns |    10.0075 ns |    413.27 ns |  0.08 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    423.96 ns |   8.2989 ns |     8.8797 ns |    418.32 ns |  0.08 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    238.03 ns |   0.0885 ns |     0.0828 ns |    238.03 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    226.13 ns |   0.0634 ns |     0.0593 ns |    226.13 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    592.28 ns |   0.6173 ns |     0.5774 ns |    592.16 ns |  0.11 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    457.69 ns |   9.0838 ns |     9.7195 ns |    451.70 ns |  0.08 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    475.41 ns |   2.4588 ns |     2.1797 ns |    475.28 ns |  0.09 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    265.30 ns |   0.0751 ns |     0.0665 ns |    265.31 ns |  0.05 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    266.40 ns |   0.0649 ns |     0.0608 ns |    266.41 ns |  0.05 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,963.67 ns |   3.4927 ns |     3.2670 ns | 10,964.70 ns |  1.98 |    0.00 |
|                                                   Foreach |         [1000] |  5,526.56 ns |   1.2062 ns |     1.1283 ns |  5,526.59 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |  **1,116.38 ns** |   **7.9640 ns** |     **7.4496 ns** |  **1,112.42 ns** |  **3.65** |    **0.02** |
|                                   LowCostLinqWithDelegate |           [50] |    878.11 ns |  17.4604 ns |    37.5853 ns |    868.23 ns |  2.86 |    0.14 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    889.09 ns |  14.2321 ns |    11.8844 ns |    885.42 ns |  2.91 |    0.04 |
|                                  LowCostLinqWithDelegate2 |           [50] |    904.79 ns |   2.1642 ns |     1.6896 ns |    904.80 ns |  2.96 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    965.91 ns |   5.5276 ns |     4.3156 ns |    964.57 ns |  3.16 |    0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    414.37 ns |   0.0991 ns |     0.0927 ns |    414.36 ns |  1.36 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    385.40 ns |   0.0920 ns |     0.0860 ns |    385.39 ns |  1.26 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,645.16 ns |   3.2108 ns |     2.8463 ns |  1,645.89 ns |  5.38 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,651.30 ns |  28.6946 ns |    26.8409 ns |  1,644.85 ns |  5.41 |    0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    853.56 ns |   0.3120 ns |     0.2918 ns |    853.58 ns |  2.79 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    767.20 ns |   0.2289 ns |     0.1912 ns |    767.21 ns |  2.51 |    0.00 |
|                                                 LinqCount |           [50] |    905.80 ns |   3.2676 ns |     3.0566 ns |    906.15 ns |  2.97 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    816.81 ns |  16.7969 ns |    33.1555 ns |    800.61 ns |  2.67 |    0.10 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    810.62 ns |  16.1796 ns |    27.9090 ns |    804.18 ns |  2.64 |    0.09 |
|                           LowCostLinqWithStructWhereCount |           [50] |    364.44 ns |   0.0882 ns |     0.0825 ns |    364.45 ns |  1.19 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    347.42 ns |   0.1033 ns |     0.0966 ns |    347.39 ns |  1.14 |    0.00 |
|                                               LinqToArray |           [50] |  1,234.09 ns |   2.5831 ns |     2.4162 ns |  1,234.07 ns |  4.04 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |  1,060.72 ns |   2.8749 ns |     2.6892 ns |  1,060.72 ns |  3.47 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |  1,028.48 ns |   3.5263 ns |     3.2985 ns |  1,026.84 ns |  3.37 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    529.83 ns |   0.2945 ns |     0.2755 ns |    529.88 ns |  1.73 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    529.19 ns |   0.3606 ns |     0.3373 ns |    529.18 ns |  1.73 |    0.00 |
|                                                      Take |           [50] |    657.80 ns |   1.0139 ns |     0.9484 ns |    657.85 ns |  2.15 |    0.00 |
|                                               LowCostTake |           [50] |    411.15 ns |   7.9282 ns |     7.4161 ns |    407.22 ns |  1.34 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    416.26 ns |   0.9863 ns |     0.9226 ns |    416.11 ns |  1.36 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    236.84 ns |   0.0469 ns |     0.0439 ns |    236.84 ns |  0.78 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    224.57 ns |   0.0748 ns |     0.0700 ns |    224.57 ns |  0.74 |    0.00 |
|                                            SkipTakeSingle |           [50] |    593.12 ns |   0.5924 ns |     0.5541 ns |    593.08 ns |  1.94 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    452.14 ns |   5.1122 ns |     4.7819 ns |    449.72 ns |  1.48 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    475.60 ns |   5.8309 ns |     5.1690 ns |    473.24 ns |  1.56 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    272.15 ns |   0.0499 ns |     0.0443 ns |    272.16 ns |  0.89 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    266.71 ns |   0.0638 ns |     0.0596 ns |    266.70 ns |  0.87 |    0.00 |
|                                           ForeachDelegate |           [50] |    582.83 ns |   0.0550 ns |     0.0459 ns |    582.85 ns |  1.91 |    0.00 |
|                                                   Foreach |           [50] |    305.52 ns |   0.1007 ns |     0.0841 ns |    305.47 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **260.42 ns** |   **0.2609 ns** |     **0.2312 ns** |    **260.36 ns** |  **5.77** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    146.49 ns |   0.6959 ns |     0.6509 ns |    146.16 ns |  3.25 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    146.21 ns |   0.2679 ns |     0.2237 ns |    146.20 ns |  3.24 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    176.20 ns |   1.2322 ns |     1.1526 ns |    175.82 ns |  3.90 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    177.68 ns |   0.8424 ns |     0.7880 ns |    177.27 ns |  3.93 |    0.02 |
|                                LowCostLinqWithStructWhere |            [5] |     90.21 ns |   0.0267 ns |     0.0249 ns |     90.21 ns |  2.00 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     87.23 ns |   0.0533 ns |     0.0498 ns |     87.24 ns |  1.93 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    303.27 ns |   0.1717 ns |     0.1606 ns |    303.25 ns |  6.72 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    290.96 ns |   0.3591 ns |     0.3359 ns |    290.99 ns |  6.45 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    211.68 ns |   0.0718 ns |     0.0672 ns |    211.68 ns |  4.69 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    194.23 ns |   0.0428 ns |     0.0379 ns |    194.22 ns |  4.30 |    0.00 |
|                                                 LinqCount |            [5] |    238.95 ns |   0.0670 ns |     0.0627 ns |    238.96 ns |  5.29 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    137.67 ns |   0.8745 ns |     0.8180 ns |    137.42 ns |  3.05 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    142.47 ns |   0.3472 ns |     0.2711 ns |    142.41 ns |  3.16 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     86.63 ns |   0.0577 ns |     0.0540 ns |     86.62 ns |  1.92 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     86.89 ns |   0.0609 ns |     0.0540 ns |     86.90 ns |  1.92 |    0.00 |
|                                               LinqToArray |            [5] |    303.88 ns |   0.4105 ns |     0.3840 ns |    303.78 ns |  6.73 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    190.06 ns |   0.2264 ns |     0.2118 ns |    190.14 ns |  4.21 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    189.76 ns |   0.1659 ns |     0.1552 ns |    189.81 ns |  4.20 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    132.35 ns |   0.0371 ns |     0.0310 ns |    132.35 ns |  2.93 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    134.02 ns |   0.0425 ns |     0.0397 ns |    134.03 ns |  2.97 |    0.00 |
|                                                      Take |            [5] |    314.31 ns |   0.0692 ns |     0.0614 ns |    314.30 ns |  6.96 |    0.00 |
|                                               LowCostTake |            [5] |    165.99 ns |   0.7831 ns |     0.7325 ns |    166.04 ns |  3.68 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [5] |    163.03 ns |   0.3126 ns |     0.2771 ns |    163.07 ns |  3.61 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |    116.99 ns |   0.0427 ns |     0.0357 ns |    117.00 ns |  2.59 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    104.85 ns |   0.0860 ns |     0.0804 ns |    104.87 ns |  2.32 |    0.00 |
|                                            SkipTakeSingle |            [5] |    313.38 ns |   0.1454 ns |     0.1360 ns |    313.37 ns |  6.94 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    184.77 ns |   0.9795 ns |     0.8683 ns |    185.07 ns |  4.09 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    191.46 ns |   0.1261 ns |     0.1053 ns |    191.49 ns |  4.24 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    131.41 ns |   0.0300 ns |     0.0250 ns |    131.41 ns |  2.91 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    132.91 ns |   0.0332 ns |     0.0295 ns |    132.91 ns |  2.94 |    0.00 |
|                                           ForeachDelegate |            [5] |     77.35 ns |   0.0301 ns |     0.0267 ns |     77.36 ns |  1.71 |    0.00 |
|                                                   Foreach |            [5] |     45.15 ns |   0.0348 ns |     0.0309 ns |     45.14 ns |  1.00 |    0.00 |
