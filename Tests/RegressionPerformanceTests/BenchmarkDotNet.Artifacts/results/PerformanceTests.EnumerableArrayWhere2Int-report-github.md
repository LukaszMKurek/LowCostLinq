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
|                                                      **Linq** |              **0** |     **55.96 ns** |  **0.0614 ns** |  **0.0545 ns** |   **4.62** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     36.32 ns |  0.0057 ns |  0.0048 ns |   3.00 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     42.08 ns |  0.0134 ns |  0.0104 ns |   3.47 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     49.43 ns |  0.0033 ns |  0.0029 ns |   4.08 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     50.51 ns |  0.0054 ns |  0.0045 ns |   4.17 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     42.05 ns |  0.0021 ns |  0.0019 ns |   3.47 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     42.93 ns |  0.0019 ns |  0.0014 ns |   3.54 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     90.40 ns |  0.1118 ns |  0.1046 ns |   7.46 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     90.10 ns |  0.0946 ns |  0.0884 ns |   7.43 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     80.55 ns |  0.0341 ns |  0.0303 ns |   6.64 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     74.97 ns |  0.0271 ns |  0.0211 ns |   6.18 |     0.00 |
|                                                 LinqCount |              0 |     51.50 ns |  0.0206 ns |  0.0183 ns |   4.25 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     35.91 ns |  0.0101 ns |  0.0090 ns |   2.96 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     36.07 ns |  0.0121 ns |  0.0113 ns |   2.98 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     30.83 ns |  0.0069 ns |  0.0061 ns |   2.54 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     31.14 ns |  0.0022 ns |  0.0020 ns |   2.57 |     0.00 |
|                                               LinqToArray |              0 |     65.87 ns |  0.0483 ns |  0.0452 ns |   5.43 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     46.39 ns |  0.0179 ns |  0.0159 ns |   3.83 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     46.12 ns |  0.0238 ns |  0.0186 ns |   3.80 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     45.52 ns |  0.0311 ns |  0.0291 ns |   3.75 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     40.00 ns |  0.0179 ns |  0.0149 ns |   3.30 |     0.00 |
|                                                      Take |              0 |     86.46 ns |  0.0130 ns |  0.0101 ns |   7.13 |     0.00 |
|                                               LowCostTake |              0 |     41.89 ns |  0.0071 ns |  0.0059 ns |   3.46 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     45.55 ns |  0.0072 ns |  0.0064 ns |   3.76 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     48.14 ns |  0.0319 ns |  0.0298 ns |   3.97 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     50.40 ns |  0.0046 ns |  0.0043 ns |   4.16 |     0.00 |
|                                            SkipTakeSingle |              0 |    109.72 ns |  0.1325 ns |  0.1174 ns |   9.05 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     50.68 ns |  0.0150 ns |  0.0140 ns |   4.18 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     51.22 ns |  0.0042 ns |  0.0035 ns |   4.22 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     52.83 ns |  0.0111 ns |  0.0098 ns |   4.36 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     53.34 ns |  0.0036 ns |  0.0034 ns |   4.40 |     0.00 |
|                                           ForeachDelegate |              0 |     14.87 ns |  0.0299 ns |  0.0280 ns |   1.23 |     0.00 |
|                                                   Foreach |              0 |     12.12 ns |  0.0016 ns |  0.0014 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** |  **7,661.81 ns** | **19.0993 ns** | **17.8655 ns** |   **1.68** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  6,013.43 ns |  6.1332 ns |  5.4370 ns |   1.32 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,586.93 ns | 10.3446 ns |  9.6764 ns |   1.23 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  5,850.95 ns | 11.2735 ns |  9.9937 ns |   1.28 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  4,866.74 ns |  7.0616 ns |  6.6054 ns |   1.07 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  1,778.21 ns |  5.9972 ns |  5.6098 ns |   0.39 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,564.41 ns |  1.5025 ns |  1.4054 ns |   0.34 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 20,179.06 ns | 13.6023 ns | 11.3586 ns |   4.43 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 18,287.16 ns |  8.3385 ns |  7.3919 ns |   4.01 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,004.01 ns | 11.1370 ns | 10.4175 ns |   1.76 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,714.74 ns |  7.4620 ns |  6.9800 ns |   1.91 |     0.00 |
|                                                 LinqCount |           1000 |  3,899.66 ns |  4.2818 ns |  4.0052 ns |   0.86 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  4,812.65 ns |  0.5223 ns |  0.4078 ns |   1.06 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,574.78 ns |  1.1341 ns |  1.0608 ns |   1.00 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,342.35 ns |  0.7801 ns |  0.7297 ns |   0.29 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,357.67 ns |  0.4489 ns |  0.3505 ns |   0.30 |     0.00 |
|                                               LinqToArray |           1000 |  5,286.65 ns | 11.6556 ns | 10.9026 ns |   1.16 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,188.21 ns | 12.7916 ns | 11.9652 ns |   1.58 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  6,089.05 ns |  9.1405 ns |  8.1028 ns |   1.34 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,250.65 ns |  6.0260 ns |  5.6367 ns |   0.49 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,258.32 ns |  6.8247 ns |  6.3839 ns |   0.50 |     0.00 |
|                                                      Take |           1000 |    337.01 ns |  0.1341 ns |  0.1189 ns |   0.07 |     0.00 |
|                                               LowCostTake |           1000 |    187.13 ns |  0.1149 ns |  0.1075 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    171.58 ns |  0.0794 ns |  0.0743 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     99.00 ns |  0.0144 ns |  0.0121 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     88.70 ns |  0.0179 ns |  0.0168 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    256.47 ns |  0.0702 ns |  0.0586 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    157.11 ns |  0.0769 ns |  0.0682 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    178.56 ns |  0.0073 ns |  0.0061 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     85.56 ns |  0.0158 ns |  0.0123 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     73.73 ns |  0.0154 ns |  0.0137 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  7,097.68 ns |  1.8381 ns |  1.5349 ns |   1.56 |     0.00 |
|                                                   Foreach |           1000 |  4,559.20 ns |  1.4248 ns |  1.0302 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **100.84 ns** |  **0.1085 ns** |  **0.1015 ns** |   **2.81** |     **0.01** |
|                                   LowCostLinqWithDelegate |              5 |     61.47 ns |  0.0712 ns |  0.0666 ns |   1.71 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     56.51 ns |  0.0278 ns |  0.0260 ns |   1.58 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     74.33 ns |  0.0513 ns |  0.0455 ns |   2.07 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     74.84 ns |  0.0918 ns |  0.0814 ns |   2.09 |     0.01 |
|                                LowCostLinqWithStructWhere |              5 |     51.40 ns |  0.0210 ns |  0.0197 ns |   1.43 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     52.48 ns |  0.0251 ns |  0.0235 ns |   1.46 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    197.88 ns |  0.2223 ns |  0.1856 ns |   5.52 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    192.62 ns |  0.1527 ns |  0.1428 ns |   5.37 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    122.84 ns |  0.0610 ns |  0.0570 ns |   3.43 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    119.81 ns |  0.0627 ns |  0.0586 ns |   3.34 |     0.01 |
|                                                 LinqCount |              5 |     80.96 ns |  0.0127 ns |  0.0092 ns |   2.26 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     59.14 ns |  0.0307 ns |  0.0203 ns |   1.65 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     56.69 ns |  0.0366 ns |  0.0343 ns |   1.58 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     38.93 ns |  0.0117 ns |  0.0109 ns |   1.09 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     33.75 ns |  0.0164 ns |  0.0137 ns |   0.94 |     0.00 |
|                                               LinqToArray |              5 |    136.94 ns |  0.2158 ns |  0.2018 ns |   3.82 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              5 |    109.19 ns |  0.0559 ns |  0.0496 ns |   3.05 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    106.00 ns |  0.0315 ns |  0.0279 ns |   2.96 |     0.01 |
|                              LowCostLinqWithStructToArray |              5 |     79.44 ns |  0.0181 ns |  0.0161 ns |   2.22 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     78.23 ns |  0.1102 ns |  0.1031 ns |   2.18 |     0.01 |
|                                                      Take |              5 |    159.06 ns |  0.0285 ns |  0.0238 ns |   4.44 |     0.01 |
|                                               LowCostTake |              5 |     69.29 ns |  0.0572 ns |  0.0535 ns |   1.93 |     0.01 |
|                                  LowCostTakeWithoutChecks |              5 |     67.52 ns |  0.0440 ns |  0.0411 ns |   1.88 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     62.00 ns |  0.0228 ns |  0.0178 ns |   1.73 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     69.45 ns |  0.0511 ns |  0.0478 ns |   1.94 |     0.01 |
|                                            SkipTakeSingle |              5 |    148.53 ns |  0.0232 ns |  0.0206 ns |   4.14 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |     68.41 ns |  0.0156 ns |  0.0138 ns |   1.91 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     72.12 ns |  0.0999 ns |  0.0935 ns |   2.01 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     56.33 ns |  0.0111 ns |  0.0086 ns |   1.57 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     57.03 ns |  0.0055 ns |  0.0046 ns |   1.59 |     0.00 |
|                                           ForeachDelegate |              5 |     51.40 ns |  0.0351 ns |  0.0328 ns |   1.43 |     0.00 |
|                                                   Foreach |              5 |     35.86 ns |  0.1199 ns |  0.1121 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **449.35 ns** |  **0.4396 ns** |  **0.4112 ns** |   **1.82** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    343.70 ns |  0.2767 ns |  0.2588 ns |   1.39 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    320.87 ns |  0.1762 ns |  0.1648 ns |   1.30 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    349.22 ns |  0.1452 ns |  0.1213 ns |   1.41 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    295.50 ns |  0.1559 ns |  0.1302 ns |   1.19 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    135.32 ns |  0.2171 ns |  0.2031 ns |   0.55 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    127.33 ns |  0.0316 ns |  0.0296 ns |   0.51 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,044.98 ns |  0.9099 ns |  0.8511 ns |   4.22 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,015.45 ns |  0.4738 ns |  0.3957 ns |   4.10 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    488.20 ns |  0.2993 ns |  0.2499 ns |   1.97 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    514.15 ns |  0.1137 ns |  0.0950 ns |   2.08 |     0.00 |
|                                                 LinqCount |             50 |    256.11 ns |  0.3622 ns |  0.3388 ns |   1.04 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    277.83 ns |  0.0226 ns |  0.0189 ns |   1.12 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    265.23 ns |  0.2131 ns |  0.1993 ns |   1.07 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |     85.41 ns |  0.0104 ns |  0.0098 ns |   0.35 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     85.73 ns |  0.0833 ns |  0.0779 ns |   0.35 |     0.00 |
|                                               LinqToArray |             50 |    515.86 ns |  0.1070 ns |  0.0948 ns |   2.08 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    501.59 ns |  0.6501 ns |  0.6081 ns |   2.03 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    456.38 ns |  0.4021 ns |  0.3761 ns |   1.84 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    227.26 ns |  0.2927 ns |  0.2738 ns |   0.92 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    230.44 ns |  0.4705 ns |  0.4401 ns |   0.93 |     0.00 |
|                                                      Take |             50 |    337.05 ns |  0.3704 ns |  0.3465 ns |   1.36 |     0.00 |
|                                               LowCostTake |             50 |    191.84 ns |  0.2525 ns |  0.2238 ns |   0.78 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    170.27 ns |  0.0647 ns |  0.0574 ns |   0.69 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |     98.60 ns |  0.0563 ns |  0.0499 ns |   0.40 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     88.47 ns |  0.1445 ns |  0.1128 ns |   0.36 |     0.00 |
|                                            SkipTakeSingle |             50 |    256.97 ns |  0.7753 ns |  0.6474 ns |   1.04 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    156.87 ns |  0.1179 ns |  0.1103 ns |   0.63 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    178.97 ns |  0.0511 ns |  0.0399 ns |   0.72 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     73.91 ns |  0.0289 ns |  0.0256 ns |   0.30 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     74.63 ns |  0.0306 ns |  0.0286 ns |   0.30 |     0.00 |
|                                           ForeachDelegate |             50 |    374.35 ns |  0.2822 ns |  0.2639 ns |   1.51 |     0.00 |
|                                                   Foreach |             50 |    247.43 ns |  0.0302 ns |  0.0268 ns |   1.00 |     0.00 |
