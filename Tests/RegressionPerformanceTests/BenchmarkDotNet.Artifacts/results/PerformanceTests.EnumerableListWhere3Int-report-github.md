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
|                                                      **Linq** |              **0** |     **94.83 ns** |  **0.0877 ns** |  **0.0778 ns** |   **5.58** |     **0.05** |
|                                   LowCostLinqWithDelegate |              0 |     37.55 ns |  0.0038 ns |  0.0034 ns |   2.21 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     32.87 ns |  0.1318 ns |  0.1233 ns |   1.93 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              0 |     60.67 ns |  0.0030 ns |  0.0025 ns |   3.57 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     57.08 ns |  0.0104 ns |  0.0087 ns |   3.36 |     0.03 |
|                                LowCostLinqWithStructWhere |              0 |     59.00 ns |  0.0054 ns |  0.0050 ns |   3.47 |     0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     50.36 ns |  0.0028 ns |  0.0025 ns |   2.96 |     0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     99.38 ns |  0.1476 ns |  0.1380 ns |   5.85 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     94.13 ns |  0.0606 ns |  0.0566 ns |   5.54 |     0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     87.12 ns |  0.0393 ns |  0.0368 ns |   5.12 |     0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     78.16 ns |  0.0516 ns |  0.0482 ns |   4.60 |     0.04 |
|                                                 LinqCount |              0 |     88.02 ns |  0.0206 ns |  0.0161 ns |   5.18 |     0.05 |
|                              LowCostLinqWithDelegateCount |              0 |     37.18 ns |  0.0080 ns |  0.0067 ns |   2.19 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     34.87 ns |  0.0107 ns |  0.0089 ns |   2.05 |     0.02 |
|                           LowCostLinqWithStructWhereCount |              0 |     44.62 ns |  0.0142 ns |  0.0126 ns |   2.62 |     0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     37.16 ns |  0.0489 ns |  0.0457 ns |   2.19 |     0.02 |
|                                               LinqToArray |              0 |    100.72 ns |  0.0702 ns |  0.0657 ns |   5.92 |     0.06 |
|                            LowCostLinqWithDelegateToArray |              0 |     47.79 ns |  0.0700 ns |  0.0655 ns |   2.81 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     46.04 ns |  0.0176 ns |  0.0156 ns |   2.71 |     0.03 |
|                              LowCostLinqWithStructToArray |              0 |     52.95 ns |  0.0217 ns |  0.0192 ns |   3.11 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     46.16 ns |  0.0359 ns |  0.0336 ns |   2.72 |     0.03 |
|                                                      Take |              0 |    127.94 ns |  0.0378 ns |  0.0335 ns |   7.53 |     0.07 |
|                                               LowCostTake |              0 |     54.35 ns |  0.0166 ns |  0.0147 ns |   3.20 |     0.03 |
|                                  LowCostTakeWithoutChecks |              0 |     42.39 ns |  0.0024 ns |  0.0021 ns |   2.49 |     0.02 |
|                                     LowCostTakeWithStruct |              0 |     55.66 ns |  0.0124 ns |  0.0097 ns |   3.27 |     0.03 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     52.57 ns |  0.0038 ns |  0.0036 ns |   3.09 |     0.03 |
|                                            SkipTakeSingle |              0 |    153.17 ns |  0.1349 ns |  0.1053 ns |   9.01 |     0.09 |
|                                     LowCostSkipTakeSingle |              0 |     56.79 ns |  0.0077 ns |  0.0060 ns |   3.34 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     55.29 ns |  0.0202 ns |  0.0158 ns |   3.25 |     0.03 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     65.45 ns |  0.0041 ns |  0.0038 ns |   3.85 |     0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     58.11 ns |  0.0230 ns |  0.0215 ns |   3.42 |     0.03 |
|                                           ForeachDelegate |              0 |     20.68 ns |  0.0086 ns |  0.0080 ns |   1.22 |     0.01 |
|                                                   Foreach |              0 |     17.00 ns |  0.1818 ns |  0.1700 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **12,346.19 ns** | **22.7786 ns** | **21.3071 ns** |   **2.24** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  9,465.15 ns | 55.7463 ns | 52.1452 ns |   1.72 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  8,793.38 ns | 29.0505 ns | 27.1739 ns |   1.59 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 10,813.50 ns |  3.1425 ns |  2.7857 ns |   1.96 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  8,129.23 ns | 29.2190 ns | 27.3315 ns |   1.47 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,703.80 ns |  3.5548 ns |  3.3251 ns |   0.49 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,752.11 ns |  0.2318 ns |  0.1810 ns |   0.32 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 22,002.73 ns | 39.9107 ns | 37.3325 ns |   3.99 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 20,399.26 ns | 40.2982 ns | 35.7233 ns |   3.70 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  9,094.62 ns | 40.7179 ns | 38.0875 ns |   1.65 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,218.40 ns |  2.6436 ns |  2.4728 ns |   1.49 |     0.00 |
|                                                 LinqCount |           1000 |  6,457.27 ns | 18.6772 ns | 17.4706 ns |   1.17 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  9,128.48 ns |  0.5762 ns |  0.4811 ns |   1.65 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  7,808.49 ns |  2.9289 ns |  2.5964 ns |   1.42 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,769.15 ns |  0.3980 ns |  0.3529 ns |   0.32 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,223.30 ns |  0.0373 ns |  0.0349 ns |   0.22 |     0.00 |
|                                               LinqToArray |           1000 |  7,138.33 ns |  4.9948 ns |  4.4277 ns |   1.29 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 | 10,676.41 ns |  8.7205 ns |  8.1572 ns |   1.94 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 10,265.46 ns |  7.4037 ns |  5.7803 ns |   1.86 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,214.40 ns |  4.8559 ns |  4.3046 ns |   0.58 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,333.43 ns |  3.9694 ns |  3.7130 ns |   0.42 |     0.00 |
|                                                      Take |           1000 |    455.23 ns |  0.5809 ns |  0.5434 ns |   0.08 |     0.00 |
|                                               LowCostTake |           1000 |    266.83 ns |  0.1519 ns |  0.1421 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    204.17 ns |  0.0202 ns |  0.0158 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    122.82 ns |  0.0313 ns |  0.0278 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     96.13 ns |  0.0234 ns |  0.0208 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    377.29 ns |  0.1422 ns |  0.1330 ns |   0.07 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    273.43 ns |  0.0405 ns |  0.0316 ns |   0.05 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    242.31 ns |  0.0414 ns |  0.0387 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    127.12 ns |  0.0517 ns |  0.0484 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     83.50 ns |  0.0265 ns |  0.0248 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  9,563.53 ns | 36.7603 ns | 32.5870 ns |   1.73 |     0.01 |
|                                                   Foreach |           1000 |  5,517.12 ns |  2.3747 ns |  2.2213 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **153.39 ns** |  **0.1157 ns** |  **0.1082 ns** |   **3.49** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     83.83 ns |  0.0131 ns |  0.0110 ns |   1.90 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     71.02 ns |  0.0341 ns |  0.0302 ns |   1.61 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    116.94 ns |  0.0928 ns |  0.0868 ns |   2.66 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     91.66 ns |  0.0708 ns |  0.0553 ns |   2.08 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     68.63 ns |  0.0131 ns |  0.0123 ns |   1.56 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     54.48 ns |  0.0192 ns |  0.0170 ns |   1.24 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    222.86 ns |  0.3073 ns |  0.2724 ns |   5.06 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    206.52 ns |  0.2015 ns |  0.1786 ns |   4.69 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    132.89 ns |  0.0720 ns |  0.0638 ns |   3.02 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    118.88 ns |  0.0783 ns |  0.0733 ns |   2.70 |     0.00 |
|                                                 LinqCount |              5 |    120.85 ns |  0.2680 ns |  0.2507 ns |   2.75 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     80.90 ns |  0.0630 ns |  0.0589 ns |   1.84 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     70.84 ns |  0.0204 ns |  0.0170 ns |   1.61 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     52.72 ns |  0.0096 ns |  0.0085 ns |   1.20 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     39.89 ns |  0.0432 ns |  0.0404 ns |   0.91 |     0.00 |
|                                               LinqToArray |              5 |    175.04 ns |  0.0943 ns |  0.0882 ns |   3.98 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    131.11 ns |  0.0459 ns |  0.0407 ns |   2.98 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    126.09 ns |  0.0972 ns |  0.0862 ns |   2.87 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     97.22 ns |  0.1180 ns |  0.1103 ns |   2.21 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     89.29 ns |  0.0436 ns |  0.0387 ns |   2.03 |     0.00 |
|                                                      Take |              5 |    228.55 ns |  3.5860 ns |  3.3544 ns |   5.19 |     0.07 |
|                                               LowCostTake |              5 |     90.76 ns |  0.0568 ns |  0.0443 ns |   2.06 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     74.89 ns |  0.0647 ns |  0.0605 ns |   1.70 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     74.40 ns |  0.0259 ns |  0.0243 ns |   1.69 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     63.88 ns |  0.0354 ns |  0.0331 ns |   1.45 |     0.00 |
|                                            SkipTakeSingle |              5 |    203.57 ns |  0.0187 ns |  0.0156 ns |   4.63 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     99.40 ns |  0.0378 ns |  0.0353 ns |   2.26 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     92.22 ns |  0.0751 ns |  0.0703 ns |   2.10 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     75.98 ns |  0.0161 ns |  0.0151 ns |   1.73 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     62.48 ns |  0.0364 ns |  0.0323 ns |   1.42 |     0.00 |
|                                           ForeachDelegate |              5 |     68.50 ns |  0.0139 ns |  0.0124 ns |   1.56 |     0.00 |
|                                                   Foreach |              5 |     44.01 ns |  0.0107 ns |  0.0089 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **711.25 ns** |  **0.3691 ns** |  **0.3272 ns** |   **2.36** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    544.75 ns |  0.6768 ns |  0.6000 ns |   1.81 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    481.46 ns |  0.2729 ns |  0.2552 ns |   1.60 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    602.45 ns |  0.0636 ns |  0.0564 ns |   2.00 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    466.06 ns |  0.5361 ns |  0.5014 ns |   1.55 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    185.15 ns |  0.0280 ns |  0.0234 ns |   0.61 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    138.50 ns |  0.0253 ns |  0.0224 ns |   0.46 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,226.45 ns |  3.9810 ns |  3.7238 ns |   4.07 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,108.07 ns |  1.1723 ns |  1.0966 ns |   3.68 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    548.71 ns |  0.0864 ns |  0.0766 ns |   1.82 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    493.02 ns |  0.2517 ns |  0.2354 ns |   1.64 |     0.00 |
|                                                 LinqCount |             50 |    415.95 ns |  0.3376 ns |  0.2993 ns |   1.38 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    496.88 ns |  0.1483 ns |  0.1072 ns |   1.65 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    424.19 ns |  0.3160 ns |  0.2956 ns |   1.41 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    147.25 ns |  0.2363 ns |  0.2210 ns |   0.49 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     90.40 ns |  0.1449 ns |  0.1356 ns |   0.30 |     0.00 |
|                                               LinqToArray |             50 |    659.09 ns |  1.0015 ns |  0.9368 ns |   2.19 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    693.37 ns |  0.2574 ns |  0.2408 ns |   2.30 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    661.55 ns |  0.2927 ns |  0.2116 ns |   2.19 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    294.16 ns |  0.7357 ns |  0.6882 ns |   0.98 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    238.71 ns |  0.1373 ns |  0.1217 ns |   0.79 |     0.00 |
|                                                      Take |             50 |    453.27 ns |  0.1163 ns |  0.1031 ns |   1.50 |     0.00 |
|                                               LowCostTake |             50 |    261.96 ns |  0.0820 ns |  0.0767 ns |   0.87 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    208.86 ns |  0.0362 ns |  0.0283 ns |   0.69 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    122.88 ns |  0.0392 ns |  0.0366 ns |   0.41 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     97.34 ns |  0.0194 ns |  0.0182 ns |   0.32 |     0.00 |
|                                            SkipTakeSingle |             50 |    377.05 ns |  0.0739 ns |  0.0655 ns |   1.25 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    271.92 ns |  0.0169 ns |  0.0132 ns |   0.90 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    242.32 ns |  0.0262 ns |  0.0245 ns |   0.80 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    126.35 ns |  0.0354 ns |  0.0331 ns |   0.42 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     83.26 ns |  0.0264 ns |  0.0247 ns |   0.28 |     0.00 |
|                                           ForeachDelegate |             50 |    505.48 ns |  0.1165 ns |  0.1032 ns |   1.68 |     0.00 |
|                                                   Foreach |             50 |    301.47 ns |  0.0330 ns |  0.0276 ns |   1.00 |     0.00 |
