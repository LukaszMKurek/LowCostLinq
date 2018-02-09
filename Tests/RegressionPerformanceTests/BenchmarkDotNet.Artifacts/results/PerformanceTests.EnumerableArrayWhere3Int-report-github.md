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
|                                                      **Linq** |              **0** |     **82.83 ns** |  **0.0449 ns** |  **0.0398 ns** |   **7.00** |     **0.12** |
|                                   LowCostLinqWithDelegate |              0 |     36.11 ns |  0.0169 ns |  0.0150 ns |   3.05 |     0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     39.57 ns |  0.0197 ns |  0.0174 ns |   3.34 |     0.06 |
|                                  LowCostLinqWithDelegate2 |              0 |     60.89 ns |  0.0315 ns |  0.0294 ns |   5.15 |     0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     61.60 ns |  0.0061 ns |  0.0057 ns |   5.21 |     0.09 |
|                                LowCostLinqWithStructWhere |              0 |     50.74 ns |  0.0030 ns |  0.0028 ns |   4.29 |     0.08 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     48.03 ns |  0.0070 ns |  0.0062 ns |   4.06 |     0.07 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     98.07 ns |  0.0931 ns |  0.0871 ns |   8.29 |     0.15 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     97.18 ns |  0.0640 ns |  0.0599 ns |   8.21 |     0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     92.34 ns |  0.0683 ns |  0.0639 ns |   7.81 |     0.14 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     80.94 ns |  0.0984 ns |  0.0921 ns |   6.84 |     0.12 |
|                                                 LinqCount |              0 |     78.47 ns |  0.0280 ns |  0.0262 ns |   6.63 |     0.12 |
|                              LowCostLinqWithDelegateCount |              0 |     36.21 ns |  0.0160 ns |  0.0142 ns |   3.06 |     0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     36.41 ns |  0.0168 ns |  0.0157 ns |   3.08 |     0.05 |
|                           LowCostLinqWithStructWhereCount |              0 |     38.33 ns |  0.0314 ns |  0.0293 ns |   3.24 |     0.06 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     38.43 ns |  0.0302 ns |  0.0283 ns |   3.25 |     0.06 |
|                                               LinqToArray |              0 |     98.36 ns |  0.0356 ns |  0.0297 ns |   8.31 |     0.15 |
|                            LowCostLinqWithDelegateToArray |              0 |     46.58 ns |  0.1215 ns |  0.1136 ns |   3.94 |     0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     47.49 ns |  0.0310 ns |  0.0274 ns |   4.01 |     0.07 |
|                              LowCostLinqWithStructToArray |              0 |     47.25 ns |  0.0203 ns |  0.0169 ns |   3.99 |     0.07 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     47.26 ns |  0.0289 ns |  0.0270 ns |   3.99 |     0.07 |
|                                                      Take |              0 |    117.54 ns |  0.0773 ns |  0.0685 ns |   9.94 |     0.18 |
|                                               LowCostTake |              0 |     44.87 ns |  0.0223 ns |  0.0186 ns |   3.79 |     0.07 |
|                                  LowCostTakeWithoutChecks |              0 |     44.47 ns |  0.0183 ns |  0.0171 ns |   3.76 |     0.07 |
|                                     LowCostTakeWithStruct |              0 |     59.96 ns |  0.0132 ns |  0.0117 ns |   5.07 |     0.09 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     55.31 ns |  0.0104 ns |  0.0098 ns |   4.68 |     0.08 |
|                                            SkipTakeSingle |              0 |    140.94 ns |  0.1478 ns |  0.1383 ns |  11.91 |     0.21 |
|                                     LowCostSkipTakeSingle |              0 |     56.10 ns |  0.0317 ns |  0.0297 ns |   4.74 |     0.08 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     55.38 ns |  0.0142 ns |  0.0111 ns |   4.68 |     0.08 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     59.34 ns |  0.0096 ns |  0.0085 ns |   5.02 |     0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     59.19 ns |  0.0134 ns |  0.0125 ns |   5.00 |     0.09 |
|                                           ForeachDelegate |              0 |     16.70 ns |  0.0079 ns |  0.0070 ns |   1.41 |     0.03 |
|                                                   Foreach |              0 |     11.83 ns |  0.2750 ns |  0.2296 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **10,396.33 ns** |  **4.8934 ns** |  **4.0862 ns** |   **2.28** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  7,770.14 ns | 28.9548 ns | 25.6676 ns |   1.71 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  8,175.22 ns |  3.3556 ns |  3.1388 ns |   1.79 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  8,627.94 ns | 13.7487 ns | 12.1879 ns |   1.89 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  9,252.26 ns | 80.6246 ns | 75.4163 ns |   2.03 |     0.02 |
|                                LowCostLinqWithStructWhere |           1000 |  1,737.61 ns |  2.2821 ns |  2.1347 ns |   0.38 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,591.25 ns |  9.2805 ns |  8.6810 ns |   0.35 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 21,422.30 ns | 20.0931 ns | 17.8120 ns |   4.70 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 20,592.75 ns | 16.1558 ns | 14.3217 ns |   4.52 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,235.21 ns | 74.2763 ns | 69.4781 ns |   1.81 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,474.43 ns |  4.7969 ns |  4.4870 ns |   1.86 |     0.00 |
|                                                 LinqCount |           1000 |  6,326.34 ns |  5.3256 ns |  4.9816 ns |   1.39 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  6,976.38 ns |  1.4098 ns |  1.3187 ns |   1.53 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  6,265.57 ns |  1.3181 ns |  1.1007 ns |   1.38 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,466.09 ns |  1.5228 ns |  1.4244 ns |   0.32 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,543.62 ns |  1.4084 ns |  1.1761 ns |   0.34 |     0.00 |
|                                               LinqToArray |           1000 |  7,963.30 ns |  5.9021 ns |  5.2321 ns |   1.75 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  8,755.50 ns | 10.0166 ns |  9.3695 ns |   1.92 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  8,585.38 ns |  7.7732 ns |  6.8907 ns |   1.88 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,259.94 ns |  5.1131 ns |  4.7828 ns |   0.50 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,255.98 ns |  2.4623 ns |  2.1827 ns |   0.50 |     0.00 |
|                                                      Take |           1000 |    435.90 ns |  0.3394 ns |  0.3175 ns |   0.10 |     0.00 |
|                                               LowCostTake |           1000 |    212.53 ns |  0.1199 ns |  0.1122 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    210.22 ns |  0.2164 ns |  0.1919 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    108.28 ns |  0.1406 ns |  0.1315 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     98.92 ns |  0.0847 ns |  0.0793 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    351.33 ns |  0.1672 ns |  0.1306 ns |   0.08 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    254.62 ns |  0.0635 ns |  0.0563 ns |   0.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    227.31 ns |  0.1752 ns |  0.1639 ns |   0.05 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     84.94 ns |  0.0315 ns |  0.0295 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     88.74 ns |  0.0735 ns |  0.0688 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  8,295.87 ns |  9.3187 ns |  8.7167 ns |   1.82 |     0.00 |
|                                                   Foreach |           1000 |  4,556.54 ns |  2.6793 ns |  2.5062 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **136.69 ns** |  **0.0425 ns** |  **0.0398 ns** |   **3.84** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     72.93 ns |  0.0517 ns |  0.0483 ns |   2.05 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     70.94 ns |  0.0175 ns |  0.0146 ns |   1.99 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    101.46 ns |  0.0413 ns |  0.0386 ns |   2.85 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    100.85 ns |  0.0136 ns |  0.0121 ns |   2.84 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     63.51 ns |  0.0301 ns |  0.0267 ns |   1.79 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     58.60 ns |  0.0109 ns |  0.0085 ns |   1.65 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    215.78 ns |  0.1747 ns |  0.1635 ns |   6.07 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    210.92 ns |  0.1026 ns |  0.0960 ns |   5.93 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    128.05 ns |  0.0555 ns |  0.0519 ns |   3.60 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    126.86 ns |  0.0360 ns |  0.0301 ns |   3.57 |     0.00 |
|                                                 LinqCount |              5 |    118.14 ns |  0.2159 ns |  0.2019 ns |   3.32 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     68.13 ns |  0.0260 ns |  0.0217 ns |   1.92 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     67.57 ns |  0.0567 ns |  0.0503 ns |   1.90 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     52.14 ns |  0.0166 ns |  0.0138 ns |   1.47 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     41.50 ns |  0.0115 ns |  0.0096 ns |   1.17 |     0.00 |
|                                               LinqToArray |              5 |    182.58 ns |  0.0792 ns |  0.0702 ns |   5.13 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    119.79 ns |  0.1232 ns |  0.1153 ns |   3.37 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    120.67 ns |  0.0716 ns |  0.0670 ns |   3.39 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     91.82 ns |  0.1440 ns |  0.1277 ns |   2.58 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     86.20 ns |  0.0782 ns |  0.0732 ns |   2.42 |     0.00 |
|                                                      Take |              5 |    209.73 ns |  0.0857 ns |  0.0760 ns |   5.90 |     0.00 |
|                                               LowCostTake |              5 |     77.70 ns |  0.0829 ns |  0.0775 ns |   2.18 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     77.19 ns |  0.0618 ns |  0.0548 ns |   2.17 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     76.76 ns |  0.0037 ns |  0.0031 ns |   2.16 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     71.68 ns |  0.0376 ns |  0.0351 ns |   2.02 |     0.00 |
|                                            SkipTakeSingle |              5 |    191.42 ns |  0.1711 ns |  0.1600 ns |   5.38 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     95.32 ns |  0.0220 ns |  0.0206 ns |   2.68 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     96.92 ns |  0.0337 ns |  0.0298 ns |   2.73 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     69.99 ns |  0.0141 ns |  0.0132 ns |   1.97 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     66.68 ns |  0.0170 ns |  0.0142 ns |   1.87 |     0.00 |
|                                           ForeachDelegate |              5 |     59.11 ns |  0.0204 ns |  0.0171 ns |   1.66 |     0.00 |
|                                                   Foreach |              5 |     35.57 ns |  0.0133 ns |  0.0111 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **610.47 ns** |  **0.4813 ns** |  **0.4502 ns** |   **2.47** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    432.03 ns |  0.4240 ns |  0.3966 ns |   1.75 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    441.79 ns |  0.2768 ns |  0.2589 ns |   1.79 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    493.10 ns |  0.7121 ns |  0.5946 ns |   1.99 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    508.45 ns |  0.1378 ns |  0.1151 ns |   2.05 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    139.86 ns |  0.0756 ns |  0.0707 ns |   0.57 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    130.30 ns |  0.0422 ns |  0.0374 ns |   0.53 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,181.78 ns |  2.1370 ns |  1.9990 ns |   4.78 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,130.24 ns |  1.3608 ns |  1.2729 ns |   4.57 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    503.52 ns |  3.4761 ns |  3.2516 ns |   2.03 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    519.97 ns |  0.1353 ns |  0.1199 ns |   2.10 |     0.00 |
|                                                 LinqCount |             50 |    405.27 ns |  0.2071 ns |  0.1836 ns |   1.64 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    384.94 ns |  0.0809 ns |  0.0631 ns |   1.56 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    350.70 ns |  0.0812 ns |  0.0678 ns |   1.42 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |     99.82 ns |  0.0472 ns |  0.0441 ns |   0.40 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     97.35 ns |  0.0483 ns |  0.0452 ns |   0.39 |     0.00 |
|                                               LinqToArray |             50 |    698.36 ns |  0.4256 ns |  0.3772 ns |   2.82 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    590.39 ns |  0.7839 ns |  0.7332 ns |   2.39 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    584.13 ns |  0.7208 ns |  0.6742 ns |   2.36 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    233.76 ns |  0.1419 ns |  0.1327 ns |   0.94 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    237.76 ns |  0.4296 ns |  0.4019 ns |   0.96 |     0.00 |
|                                                      Take |             50 |    435.87 ns |  0.2439 ns |  0.2282 ns |   1.76 |     0.00 |
|                                               LowCostTake |             50 |    212.31 ns |  0.2949 ns |  0.2759 ns |   0.86 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    210.71 ns |  0.1146 ns |  0.1016 ns |   0.85 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    108.49 ns |  0.0252 ns |  0.0210 ns |   0.44 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     98.95 ns |  0.0688 ns |  0.0644 ns |   0.40 |     0.00 |
|                                            SkipTakeSingle |             50 |    345.16 ns |  0.2889 ns |  0.2702 ns |   1.39 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    254.36 ns |  0.0943 ns |  0.0788 ns |   1.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    229.10 ns |  0.0837 ns |  0.0699 ns |   0.93 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     84.36 ns |  0.0817 ns |  0.0764 ns |   0.34 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     87.62 ns |  0.0278 ns |  0.0233 ns |   0.35 |     0.00 |
|                                           ForeachDelegate |             50 |    437.86 ns |  0.1097 ns |  0.0973 ns |   1.77 |     0.00 |
|                                                   Foreach |             50 |    247.46 ns |  0.0399 ns |  0.0354 ns |   1.00 |     0.00 |
