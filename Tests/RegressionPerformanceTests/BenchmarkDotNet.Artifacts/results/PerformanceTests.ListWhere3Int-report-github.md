``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **88.723 ns** |   **0.1147 ns** |   **0.1017 ns** |  **31.90** |     **0.04** |
|                                   LowCostLinqWithDelegate |              0 |     32.230 ns |   0.0343 ns |   0.0321 ns |  11.59 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     22.686 ns |   0.0013 ns |   0.0011 ns |   8.16 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     52.621 ns |   0.0060 ns |   0.0047 ns |  18.92 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     48.034 ns |   0.0024 ns |   0.0020 ns |  17.27 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     41.562 ns |   0.0397 ns |   0.0371 ns |  14.94 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     35.286 ns |   0.0006 ns |   0.0005 ns |  12.69 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     62.912 ns |   0.0861 ns |   0.0805 ns |  22.62 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     58.593 ns |   0.0543 ns |   0.0453 ns |  21.06 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     57.606 ns |   0.0526 ns |   0.0466 ns |  20.71 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     50.267 ns |   0.0230 ns |   0.0216 ns |  18.07 |     0.01 |
|                                                 LinqCount |              0 |     86.351 ns |   0.1585 ns |   0.1483 ns |  31.04 |     0.05 |
|                              LowCostLinqWithDelegateCount |              0 |     25.996 ns |   0.0140 ns |   0.0131 ns |   9.35 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     24.849 ns |   0.0044 ns |   0.0039 ns |   8.93 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     35.090 ns |   0.0057 ns |   0.0051 ns |  12.62 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     27.453 ns |   0.0057 ns |   0.0053 ns |   9.87 |     0.00 |
|                                               LinqToArray |              0 |     98.294 ns |   0.0677 ns |   0.0633 ns |  35.34 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              0 |     30.550 ns |   0.0402 ns |   0.0376 ns |  10.98 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     27.692 ns |   0.0163 ns |   0.0127 ns |   9.96 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     37.790 ns |   0.0187 ns |   0.0175 ns |  13.59 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     30.687 ns |   0.0088 ns |   0.0078 ns |  11.03 |     0.00 |
|                                                      Take |              0 |    126.174 ns |   0.2670 ns |   0.2498 ns |  45.36 |     0.09 |
|                                               LowCostTake |              0 |     36.550 ns |   0.0056 ns |   0.0050 ns |  13.14 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     32.468 ns |   0.0229 ns |   0.0214 ns |  11.67 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     48.892 ns |   0.0026 ns |   0.0023 ns |  17.58 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     41.768 ns |   0.0079 ns |   0.0070 ns |  15.02 |     0.00 |
|                                            SkipTakeSingle |              0 |    148.283 ns |   0.0224 ns |   0.0187 ns |  53.31 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     43.856 ns |   0.0111 ns |   0.0093 ns |  15.77 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     41.311 ns |   0.0025 ns |   0.0022 ns |  14.85 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     55.349 ns |   0.0031 ns |   0.0028 ns |  19.90 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     47.245 ns |   0.0022 ns |   0.0021 ns |  16.98 |     0.00 |
|                                           ForeachDelegate |              0 |     15.645 ns |   0.0021 ns |   0.0017 ns |   5.62 |     0.00 |
|                                                   Foreach |              0 |     11.280 ns |   0.0021 ns |   0.0019 ns |   4.06 |     0.00 |
|                                                       For |              0 |      2.782 ns |   0.0007 ns |   0.0006 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |        |          |
|                                                      **Linq** |           **1000** | **11,957.565 ns** |  **19.4014 ns** |  **18.1480 ns** |  **47.80** |     **0.07** |
|                                   LowCostLinqWithDelegate |           1000 |  8,684.358 ns |   7.2232 ns |   5.6394 ns |  34.71 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  7,191.225 ns |   2.6067 ns |   2.4383 ns |  28.74 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           1000 |  9,132.549 ns |  14.7938 ns |  11.5500 ns |  36.50 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  7,627.722 ns |  72.6020 ns |  67.9120 ns |  30.49 |     0.26 |
|                                LowCostLinqWithStructWhere |           1000 |  1,855.523 ns |   0.3579 ns |   0.2794 ns |   7.42 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,736.850 ns |   0.8846 ns |   0.8275 ns |   6.94 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 19,850.114 ns | 385.1402 ns | 539.9127 ns |  79.34 |     2.12 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 17,528.184 ns |  18.2911 ns |  17.1095 ns |  70.06 |     0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,825.548 ns |   8.6291 ns |   8.0717 ns |  27.28 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  5,792.218 ns |   4.2328 ns |   3.9593 ns |  23.15 |     0.02 |
|                                                 LinqCount |           1000 |  6,567.074 ns |   3.3204 ns |   3.1059 ns |  26.25 |     0.01 |
|                              LowCostLinqWithDelegateCount |           1000 |  8,289.388 ns |  18.5269 ns |  17.3301 ns |  33.13 |     0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  7,187.545 ns |   1.0639 ns |   0.8884 ns |  28.73 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,754.222 ns |   0.9920 ns |   0.9279 ns |   7.01 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,216.546 ns |   0.0445 ns |   0.0372 ns |   4.86 |     0.00 |
|                                               LinqToArray |           1000 |  8,384.372 ns |  21.4103 ns |  20.0272 ns |  33.51 |     0.08 |
|                            LowCostLinqWithDelegateToArray |           1000 | 10,051.685 ns |   6.8622 ns |   5.3576 ns |  40.18 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  8,834.555 ns |  14.4646 ns |  13.5302 ns |  35.31 |     0.05 |
|                              LowCostLinqWithStructToArray |           1000 |  3,163.287 ns |   4.8975 ns |   4.3415 ns |  12.64 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,350.144 ns |   6.5672 ns |   6.1429 ns |   9.39 |     0.02 |
|                                                      Take |           1000 |    482.324 ns |   0.1268 ns |   0.1186 ns |   1.93 |     0.00 |
|                                               LowCostTake |           1000 |    230.978 ns |   0.0269 ns |   0.0239 ns |   0.92 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    188.693 ns |   0.0370 ns |   0.0328 ns |   0.75 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     89.243 ns |   0.0775 ns |   0.0725 ns |   0.36 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     80.580 ns |   0.0188 ns |   0.0176 ns |   0.32 |     0.00 |
|                                            SkipTakeSingle |           1000 |    375.028 ns |   0.1602 ns |   0.1251 ns |   1.50 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    263.539 ns |   0.2870 ns |   0.2685 ns |   1.05 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    212.656 ns |   0.2707 ns |   0.2532 ns |   0.85 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    110.694 ns |   0.0640 ns |   0.0598 ns |   0.44 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     74.614 ns |   0.0106 ns |   0.0094 ns |   0.30 |     0.00 |
|                                           ForeachDelegate |           1000 |  5,887.738 ns | 103.6164 ns |  96.9228 ns |  23.53 |     0.37 |
|                                                   Foreach |           1000 |  1,690.985 ns |   2.2710 ns |   2.1243 ns |   6.76 |     0.01 |
|                                                       For |           1000 |    250.180 ns |   0.0232 ns |   0.0168 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |        |          |
|                                                      **Linq** |              **5** |    **149.957 ns** |   **0.1379 ns** |   **0.1290 ns** |  **36.66** |     **0.07** |
|                                   LowCostLinqWithDelegate |              5 |     68.101 ns |   0.0129 ns |   0.0101 ns |  16.65 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     54.097 ns |   0.0227 ns |   0.0212 ns |  13.22 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              5 |     89.889 ns |   0.0458 ns |   0.0331 ns |  21.97 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     79.812 ns |   0.0421 ns |   0.0394 ns |  19.51 |     0.03 |
|                                LowCostLinqWithStructWhere |              5 |     55.723 ns |   0.0259 ns |   0.0242 ns |  13.62 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     44.731 ns |   0.0167 ns |   0.0156 ns |  10.93 |     0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    170.343 ns |   0.0837 ns |   0.0699 ns |  41.64 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    148.845 ns |   0.2473 ns |   0.2193 ns |  36.38 |     0.08 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |     93.789 ns |   0.0466 ns |   0.0436 ns |  22.93 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |     78.708 ns |   0.0496 ns |   0.0464 ns |  19.24 |     0.03 |
|                                                 LinqCount |              5 |    118.463 ns |   0.1601 ns |   0.1498 ns |  28.96 |     0.06 |
|                              LowCostLinqWithDelegateCount |              5 |     66.146 ns |   0.0549 ns |   0.0487 ns |  16.17 |     0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     58.841 ns |   0.0658 ns |   0.0583 ns |  14.38 |     0.03 |
|                           LowCostLinqWithStructWhereCount |              5 |     43.462 ns |   0.0291 ns |   0.0273 ns |  10.62 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     31.933 ns |   0.0312 ns |   0.0292 ns |   7.81 |     0.01 |
|                                               LinqToArray |              5 |    184.724 ns |   0.2473 ns |   0.2192 ns |  45.15 |     0.09 |
|                            LowCostLinqWithDelegateToArray |              5 |    110.209 ns |   0.1019 ns |   0.0953 ns |  26.94 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    101.715 ns |   0.0577 ns |   0.0540 ns |  24.86 |     0.04 |
|                              LowCostLinqWithStructToArray |              5 |     82.713 ns |   0.0869 ns |   0.0770 ns |  20.22 |     0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     69.655 ns |   0.0353 ns |   0.0330 ns |  17.03 |     0.03 |
|                                                      Take |              5 |    228.429 ns |   0.1148 ns |   0.0959 ns |  55.84 |     0.09 |
|                                               LowCostTake |              5 |     75.680 ns |   0.0792 ns |   0.0741 ns |  18.50 |     0.04 |
|                                  LowCostTakeWithoutChecks |              5 |     62.612 ns |   0.0130 ns |   0.0115 ns |  15.31 |     0.03 |
|                                     LowCostTakeWithStruct |              5 |     60.707 ns |   0.0469 ns |   0.0439 ns |  14.84 |     0.03 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     52.656 ns |   0.0436 ns |   0.0408 ns |  12.87 |     0.02 |
|                                            SkipTakeSingle |              5 |    202.908 ns |   0.0315 ns |   0.0246 ns |  49.60 |     0.08 |
|                                     LowCostSkipTakeSingle |              5 |     83.038 ns |   0.0725 ns |   0.0678 ns |  20.30 |     0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     68.112 ns |   0.0623 ns |   0.0552 ns |  16.65 |     0.03 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     65.628 ns |   0.0264 ns |   0.0247 ns |  16.04 |     0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     53.027 ns |   0.0557 ns |   0.0521 ns |  12.96 |     0.02 |
|                                           ForeachDelegate |              5 |     45.088 ns |   0.0111 ns |   0.0103 ns |  11.02 |     0.02 |
|                                                   Foreach |              5 |     19.720 ns |   0.0263 ns |   0.0246 ns |   4.82 |     0.01 |
|                                                       For |              5 |      4.091 ns |   0.0075 ns |   0.0070 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |        |          |
|                                                      **Linq** |             **50** |    **688.998 ns** |   **0.2056 ns** |   **0.1823 ns** |  **44.32** |     **0.01** |
|                                   LowCostLinqWithDelegate |             50 |    461.139 ns |   0.0533 ns |   0.0499 ns |  29.66 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    382.179 ns |   0.0138 ns |   0.0115 ns |  24.58 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    497.205 ns |   0.4391 ns |   0.4107 ns |  31.98 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    432.389 ns |   0.2709 ns |   0.2115 ns |  27.81 |     0.01 |
|                                LowCostLinqWithStructWhere |             50 |    138.604 ns |   0.0377 ns |   0.0335 ns |   8.92 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    124.373 ns |   0.0116 ns |   0.0097 ns |   8.00 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,052.016 ns |   1.4841 ns |   1.3156 ns |  67.67 |     0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    939.416 ns |   0.9628 ns |   0.9006 ns |  60.43 |     0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    398.793 ns |   0.1013 ns |   0.0898 ns |  25.65 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    343.765 ns |   0.2253 ns |   0.1881 ns |  22.11 |     0.01 |
|                                                 LinqCount |             50 |    415.041 ns |   0.1219 ns |   0.1140 ns |  26.70 |     0.01 |
|                              LowCostLinqWithDelegateCount |             50 |    444.971 ns |   0.3371 ns |   0.3154 ns |  28.62 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    386.444 ns |   0.1083 ns |   0.1013 ns |  24.86 |     0.01 |
|                           LowCostLinqWithStructWhereCount |             50 |    133.336 ns |   0.1086 ns |   0.1016 ns |   8.58 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     81.838 ns |   0.0061 ns |   0.0057 ns |   5.26 |     0.00 |
|                                               LinqToArray |             50 |    722.289 ns |   0.3439 ns |   0.3217 ns |  46.46 |     0.02 |
|                            LowCostLinqWithDelegateToArray |             50 |    638.281 ns |   0.9739 ns |   0.9110 ns |  41.06 |     0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    572.159 ns |   0.3779 ns |   0.3535 ns |  36.81 |     0.02 |
|                              LowCostLinqWithStructToArray |             50 |    270.988 ns |   0.2648 ns |   0.2348 ns |  17.43 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    221.664 ns |   0.2724 ns |   0.2548 ns |  14.26 |     0.02 |
|                                                      Take |             50 |    483.646 ns |   0.4938 ns |   0.4619 ns |  31.11 |     0.03 |
|                                               LowCostTake |             50 |    231.940 ns |   0.0493 ns |   0.0385 ns |  14.92 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    188.961 ns |   0.0129 ns |   0.0114 ns |  12.16 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |     99.285 ns |   0.0476 ns |   0.0445 ns |   6.39 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     95.595 ns |   0.1145 ns |   0.1071 ns |   6.15 |     0.01 |
|                                            SkipTakeSingle |             50 |    374.963 ns |   0.4864 ns |   0.4550 ns |  24.12 |     0.03 |
|                                     LowCostSkipTakeSingle |             50 |    258.272 ns |   0.1131 ns |   0.1058 ns |  16.61 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    212.968 ns |   0.0843 ns |   0.0747 ns |  13.70 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    110.474 ns |   0.0348 ns |   0.0325 ns |   7.11 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     74.725 ns |   0.0669 ns |   0.0626 ns |   4.81 |     0.00 |
|                                           ForeachDelegate |             50 |    320.034 ns |   0.0542 ns |   0.0453 ns |  20.59 |     0.00 |
|                                                   Foreach |             50 |    102.735 ns |   0.0499 ns |   0.0467 ns |   6.61 |     0.00 |
|                                                       For |             50 |     15.545 ns |   0.0026 ns |   0.0023 ns |   1.00 |     0.00 |
