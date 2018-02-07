``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **35.742 ns** |  **0.0158 ns** |  **0.0140 ns** |  **12.57** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |    25.339 ns |  0.0034 ns |  0.0031 ns |   8.91 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |    18.625 ns |  0.0013 ns |  0.0012 ns |   6.55 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |    33.811 ns |  0.0054 ns |  0.0039 ns |  11.89 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |    27.211 ns |  0.0008 ns |  0.0008 ns |   9.57 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |    28.930 ns |  0.0324 ns |  0.0304 ns |  10.17 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |    20.724 ns |  0.0005 ns |  0.0004 ns |   7.29 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    38.759 ns |  0.0421 ns |  0.0393 ns |  13.63 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    33.772 ns |  0.0164 ns |  0.0146 ns |  11.87 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |    40.169 ns |  0.0146 ns |  0.0122 ns |  14.12 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |    34.942 ns |  0.0661 ns |  0.0618 ns |  12.28 |     0.02 |
|                                                 LinqCount |              0 |    31.866 ns |  0.0784 ns |  0.0733 ns |  11.20 |     0.02 |
|                              LowCostLinqWithDelegateCount |              0 |    24.912 ns |  0.0100 ns |  0.0094 ns |   8.76 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |    22.647 ns |  0.0098 ns |  0.0091 ns |   7.96 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |    21.986 ns |  0.0009 ns |  0.0008 ns |   7.73 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |    15.394 ns |  0.0033 ns |  0.0029 ns |   5.41 |     0.00 |
|                                               LinqToArray |              0 |    43.623 ns |  0.0549 ns |  0.0514 ns |  15.34 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              0 |    26.856 ns |  0.0453 ns |  0.0424 ns |   9.44 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |    25.887 ns |  0.0082 ns |  0.0073 ns |   9.10 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |    24.984 ns |  0.0098 ns |  0.0087 ns |   8.78 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |    18.092 ns |  0.0216 ns |  0.0202 ns |   6.36 |     0.01 |
|                                                      Take |              0 |    70.634 ns |  0.0585 ns |  0.0548 ns |  24.83 |     0.02 |
|                                               LowCostTake |              0 |    37.246 ns |  0.0023 ns |  0.0022 ns |  13.09 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |    25.793 ns |  0.0008 ns |  0.0008 ns |   9.07 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |    36.772 ns |  0.0085 ns |  0.0080 ns |  12.93 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |    27.429 ns |  0.0007 ns |  0.0006 ns |   9.64 |     0.00 |
|                                            SkipTakeSingle |              0 |    91.937 ns |  0.0232 ns |  0.0194 ns |  32.32 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |    35.719 ns |  0.0029 ns |  0.0025 ns |  12.56 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |    33.659 ns |  0.0024 ns |  0.0023 ns |  11.83 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |    39.367 ns |  0.0018 ns |  0.0016 ns |  13.84 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |    30.873 ns |  0.0018 ns |  0.0017 ns |  10.85 |     0.00 |
|                                           ForeachDelegate |              0 |    15.197 ns |  0.0140 ns |  0.0131 ns |   5.34 |     0.00 |
|                                                   Foreach |              0 |    12.183 ns |  0.0042 ns |  0.0040 ns |   4.28 |     0.00 |
|                                                       For |              0 |     2.844 ns |  0.0004 ns |  0.0004 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **7,550.005 ns** | **13.1584 ns** | **12.3084 ns** |  **30.18** |     **0.05** |
|                                   LowCostLinqWithDelegate |           1000 | 3,848.274 ns |  0.4428 ns |  0.2929 ns |  15.38 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 2,894.588 ns |  0.2645 ns |  0.2474 ns |  11.57 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 4,105.563 ns |  0.9817 ns |  0.9183 ns |  16.41 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 3,143.677 ns |  0.6431 ns |  0.5701 ns |  12.57 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 | 1,831.151 ns |  0.2050 ns |  0.1711 ns |   7.32 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 | 1,722.872 ns |  0.0838 ns |  0.0743 ns |   6.89 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 9,233.762 ns |  1.6993 ns |  1.3267 ns |  36.91 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 8,232.800 ns |  2.2751 ns |  2.0168 ns |  32.91 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 7,001.299 ns |  2.9748 ns |  2.7826 ns |  27.99 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 6,070.258 ns |  3.8667 ns |  3.6169 ns |  24.27 |     0.01 |
|                                                 LinqCount |           1000 | 1,479.158 ns |  2.1451 ns |  2.0065 ns |   5.91 |     0.01 |
|                              LowCostLinqWithDelegateCount |           1000 | 3,823.442 ns |  1.4964 ns |  1.3265 ns |  15.28 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 2,651.970 ns |  0.5027 ns |  0.4702 ns |  10.60 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 | 1,723.728 ns |  0.2167 ns |  0.1810 ns |   6.89 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 | 1,204.963 ns |  0.0730 ns |  0.0683 ns |   4.82 |     0.00 |
|                                               LinqToArray |           1000 | 3,472.485 ns | 44.0322 ns | 39.0334 ns |  13.88 |     0.15 |
|                            LowCostLinqWithDelegateToArray |           1000 | 5,653.995 ns |  5.9220 ns |  4.9452 ns |  22.60 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 3,685.516 ns |  4.3564 ns |  3.8619 ns |  14.73 |     0.01 |
|                              LowCostLinqWithStructToArray |           1000 | 3,279.431 ns |  6.5037 ns |  5.7653 ns |  13.11 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 | 2,276.412 ns |  2.7192 ns |  2.4105 ns |   9.10 |     0.01 |
|                                                      Take |           1000 |   325.137 ns |  0.2197 ns |  0.2055 ns |   1.30 |     0.00 |
|                                               LowCostTake |           1000 |   116.213 ns |  0.0562 ns |  0.0498 ns |   0.46 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    95.172 ns |  0.0094 ns |  0.0083 ns |   0.38 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    77.416 ns |  0.0280 ns |  0.0234 ns |   0.31 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    66.023 ns |  0.0705 ns |  0.0659 ns |   0.26 |     0.00 |
|                                            SkipTakeSingle |           1000 |   223.217 ns |  0.0591 ns |  0.0524 ns |   0.89 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |   120.126 ns |  0.0261 ns |  0.0232 ns |   0.48 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |   105.439 ns |  0.0488 ns |  0.0408 ns |   0.42 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    79.737 ns |  0.0535 ns |  0.0500 ns |   0.32 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    64.181 ns |  0.0257 ns |  0.0228 ns |   0.26 |     0.00 |
|                                           ForeachDelegate |           1000 | 3,126.007 ns |  1.8977 ns |  1.6823 ns |  12.50 |     0.01 |
|                                                   Foreach |           1000 | 1,689.784 ns |  1.7926 ns |  1.6768 ns |   6.75 |     0.01 |
|                                                       For |           1000 |   250.162 ns |  0.0207 ns |  0.0194 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **73.348 ns** |  **0.0737 ns** |  **0.0653 ns** |  **18.02** |     **0.04** |
|                                   LowCostLinqWithDelegate |              5 |    43.712 ns |  0.0164 ns |  0.0153 ns |  10.74 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |    34.940 ns |  0.0107 ns |  0.0100 ns |   8.59 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              5 |    55.260 ns |  0.0148 ns |  0.0138 ns |  13.58 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    43.947 ns |  0.0140 ns |  0.0131 ns |  10.80 |     0.02 |
|                                LowCostLinqWithStructWhere |              5 |    40.080 ns |  0.0169 ns |  0.0150 ns |   9.85 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |    30.027 ns |  0.0315 ns |  0.0294 ns |   7.38 |     0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    86.259 ns |  0.0378 ns |  0.0353 ns |  21.20 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    76.908 ns |  0.0798 ns |  0.0747 ns |  18.90 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    74.945 ns |  0.0365 ns |  0.0342 ns |  18.42 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    67.027 ns |  0.0364 ns |  0.0322 ns |  16.47 |     0.03 |
|                                                 LinqCount |              5 |    40.074 ns |  0.0161 ns |  0.0142 ns |   9.85 |     0.02 |
|                              LowCostLinqWithDelegateCount |              5 |    44.878 ns |  0.0309 ns |  0.0289 ns |  11.03 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    36.277 ns |  0.0317 ns |  0.0297 ns |   8.91 |     0.02 |
|                           LowCostLinqWithStructWhereCount |              5 |    30.385 ns |  0.0166 ns |  0.0138 ns |   7.47 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |    19.832 ns |  0.0159 ns |  0.0149 ns |   4.87 |     0.01 |
|                                               LinqToArray |              5 |    97.270 ns |  0.2211 ns |  0.2068 ns |  23.90 |     0.07 |
|                            LowCostLinqWithDelegateToArray |              5 |    83.819 ns |  0.0473 ns |  0.0443 ns |  20.60 |     0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    76.157 ns |  0.0587 ns |  0.0549 ns |  18.71 |     0.04 |
|                              LowCostLinqWithStructToArray |              5 |    70.282 ns |  0.0642 ns |  0.0601 ns |  17.27 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    57.476 ns |  0.1069 ns |  0.1000 ns |  14.12 |     0.04 |
|                                                      Take |              5 |   137.054 ns |  0.0650 ns |  0.0608 ns |  33.68 |     0.06 |
|                                               LowCostTake |              5 |    54.454 ns |  0.0142 ns |  0.0125 ns |  13.38 |     0.02 |
|                                  LowCostTakeWithoutChecks |              5 |    45.320 ns |  0.0099 ns |  0.0092 ns |  11.14 |     0.02 |
|                                     LowCostTakeWithStruct |              5 |    47.070 ns |  0.1623 ns |  0.1518 ns |  11.57 |     0.04 |
|                        LowCostTakeWithStructWithoutChecks |              5 |    37.309 ns |  0.0291 ns |  0.0272 ns |   9.17 |     0.02 |
|                                            SkipTakeSingle |              5 |   125.604 ns |  0.0194 ns |  0.0172 ns |  30.86 |     0.06 |
|                                     LowCostSkipTakeSingle |              5 |    53.754 ns |  0.0415 ns |  0.0389 ns |  13.21 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    53.293 ns |  0.0118 ns |  0.0098 ns |  13.10 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              5 |    48.064 ns |  0.0382 ns |  0.0358 ns |  11.81 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |    37.318 ns |  0.0212 ns |  0.0198 ns |   9.17 |     0.02 |
|                                           ForeachDelegate |              5 |    30.037 ns |  0.3094 ns |  0.2583 ns |   7.38 |     0.06 |
|                                                   Foreach |              5 |    19.695 ns |  0.0298 ns |  0.0279 ns |   4.84 |     0.01 |
|                                                       For |              5 |     4.070 ns |  0.0087 ns |  0.0077 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |   **422.885 ns** |  **2.6013 ns** |  **2.3060 ns** |  **27.21** |     **0.14** |
|                                   LowCostLinqWithDelegate |             50 |   218.720 ns |  0.1740 ns |  0.1628 ns |  14.07 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |   168.243 ns |  0.1652 ns |  0.1379 ns |  10.83 |     0.01 |
|                                  LowCostLinqWithDelegate2 |             50 |   239.003 ns |  0.2451 ns |  0.2293 ns |  15.38 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |   187.363 ns |  0.0131 ns |  0.0102 ns |  12.06 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |   126.731 ns |  0.1010 ns |  0.0945 ns |   8.16 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |   106.015 ns |  0.1066 ns |  0.0997 ns |   6.82 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |   508.432 ns |  0.3660 ns |  0.3424 ns |  32.72 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |   452.826 ns |  0.0973 ns |  0.0910 ns |  29.14 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |   396.054 ns |  0.3660 ns |  0.3424 ns |  25.49 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |   347.508 ns |  0.1510 ns |  0.1412 ns |  22.36 |     0.01 |
|                                                 LinqCount |             50 |   111.268 ns |  0.0348 ns |  0.0251 ns |   7.16 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |   221.327 ns |  0.0502 ns |  0.0445 ns |  14.24 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |   159.806 ns |  0.0430 ns |  0.0402 ns |  10.28 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |   115.622 ns |  0.0465 ns |  0.0435 ns |   7.44 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    70.738 ns |  0.0035 ns |  0.0032 ns |   4.55 |     0.00 |
|                                               LinqToArray |             50 |   407.551 ns |  0.3035 ns |  0.2195 ns |  26.23 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |   401.612 ns |  0.3706 ns |  0.3467 ns |  25.84 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |   303.745 ns |  0.2683 ns |  0.2240 ns |  19.55 |     0.01 |
|                              LowCostLinqWithStructToArray |             50 |   268.718 ns |  0.0471 ns |  0.0393 ns |  17.29 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |   213.294 ns |  0.5285 ns |  0.4944 ns |  13.73 |     0.03 |
|                                                      Take |             50 |   325.017 ns |  0.0612 ns |  0.0572 ns |  20.92 |     0.00 |
|                                               LowCostTake |             50 |   116.510 ns |  0.0214 ns |  0.0167 ns |   7.50 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    96.527 ns |  0.0101 ns |  0.0079 ns |   6.21 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    76.913 ns |  0.0695 ns |  0.0650 ns |   4.95 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    65.936 ns |  0.0562 ns |  0.0498 ns |   4.24 |     0.00 |
|                                            SkipTakeSingle |             50 |   221.110 ns |  0.1326 ns |  0.1240 ns |  14.23 |     0.01 |
|                                     LowCostSkipTakeSingle |             50 |   121.761 ns |  0.0291 ns |  0.0227 ns |   7.84 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |   100.595 ns |  0.0731 ns |  0.0648 ns |   6.47 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    79.544 ns |  0.0299 ns |  0.0279 ns |   5.12 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    57.163 ns |  0.0354 ns |  0.0331 ns |   3.68 |     0.00 |
|                                           ForeachDelegate |             50 |   175.893 ns |  0.0802 ns |  0.0750 ns |  11.32 |     0.01 |
|                                                   Foreach |             50 |   102.410 ns |  0.0086 ns |  0.0080 ns |   6.59 |     0.00 |
|                                                       For |             50 |    15.540 ns |  0.0029 ns |  0.0027 ns |   1.00 |     0.00 |
