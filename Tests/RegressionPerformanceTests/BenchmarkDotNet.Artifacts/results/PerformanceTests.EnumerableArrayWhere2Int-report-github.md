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
|                                                      **Linq** |              **0** |     **51.70 ns** |  **0.0170 ns** |  **0.0150 ns** |   **4.02** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     41.25 ns |  0.0023 ns |  0.0019 ns |   3.21 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     36.03 ns |  0.0168 ns |  0.0149 ns |   2.80 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     51.07 ns |  0.0135 ns |  0.0120 ns |   3.97 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     50.07 ns |  0.1016 ns |  0.0950 ns |   3.89 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     44.12 ns |  0.0100 ns |  0.0089 ns |   3.43 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     42.26 ns |  0.0017 ns |  0.0015 ns |   3.28 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     90.84 ns |  0.0415 ns |  0.0368 ns |   7.06 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     88.66 ns |  0.0779 ns |  0.0729 ns |   6.89 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     77.18 ns |  0.0393 ns |  0.0328 ns |   6.00 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     72.42 ns |  0.0600 ns |  0.0532 ns |   5.63 |     0.00 |
|                                                 LinqCount |              0 |     50.57 ns |  0.0507 ns |  0.0474 ns |   3.93 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     35.20 ns |  0.0112 ns |  0.0105 ns |   2.74 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     35.42 ns |  0.0204 ns |  0.0191 ns |   2.75 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     30.87 ns |  0.0027 ns |  0.0024 ns |   2.40 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     30.86 ns |  0.0087 ns |  0.0073 ns |   2.40 |     0.00 |
|                                               LinqToArray |              0 |     66.62 ns |  0.0981 ns |  0.0918 ns |   5.18 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |     45.71 ns |  0.0802 ns |  0.0750 ns |   3.55 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     45.66 ns |  0.0147 ns |  0.0115 ns |   3.55 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     40.35 ns |  0.0082 ns |  0.0069 ns |   3.14 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     40.05 ns |  0.0081 ns |  0.0072 ns |   3.11 |     0.00 |
|                                                      Take |              0 |     86.82 ns |  0.0163 ns |  0.0152 ns |   6.75 |     0.00 |
|                                               LowCostTake |              0 |     41.69 ns |  0.0013 ns |  0.0011 ns |   3.24 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     43.96 ns |  0.0184 ns |  0.0133 ns |   3.42 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     48.30 ns |  0.0159 ns |  0.0149 ns |   3.75 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     54.52 ns |  0.0024 ns |  0.0023 ns |   4.24 |     0.00 |
|                                            SkipTakeSingle |              0 |    112.31 ns |  0.1509 ns |  0.1411 ns |   8.73 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     51.14 ns |  0.0037 ns |  0.0033 ns |   3.98 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     50.87 ns |  0.0026 ns |  0.0023 ns |   3.95 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     52.82 ns |  0.0055 ns |  0.0043 ns |   4.11 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     52.65 ns |  0.0030 ns |  0.0028 ns |   4.09 |     0.00 |
|                                           ForeachDelegate |              0 |     15.47 ns |  0.0056 ns |  0.0050 ns |   1.20 |     0.00 |
|                                                   Foreach |              0 |     12.87 ns |  0.0078 ns |  0.0065 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** |  **7,826.76 ns** |  **7.4975 ns** |  **7.0132 ns** |   **1.81** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  5,655.55 ns | 81.5716 ns | 76.3022 ns |   1.31 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,144.71 ns | 21.2386 ns | 18.8275 ns |   1.19 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  6,442.96 ns | 12.9752 ns | 12.1370 ns |   1.49 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  6,519.46 ns |  2.9887 ns |  2.7957 ns |   1.51 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  1,729.23 ns |  1.3429 ns |  1.2562 ns |   0.40 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,561.54 ns |  0.5811 ns |  0.5152 ns |   0.36 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 18,425.13 ns | 76.2447 ns | 71.3193 ns |   4.27 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 18,244.47 ns | 71.0929 ns | 63.0220 ns |   4.23 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,016.49 ns |  8.6450 ns |  8.0865 ns |   1.86 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,013.38 ns |  6.0745 ns |  5.6821 ns |   1.86 |     0.00 |
|                                                 LinqCount |           1000 |  4,144.88 ns |  6.2584 ns |  5.5479 ns |   0.96 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  4,095.65 ns |  1.3637 ns |  1.1387 ns |   0.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,572.51 ns |  0.6741 ns |  0.5975 ns |   1.06 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,342.30 ns |  0.0938 ns |  0.0832 ns |   0.31 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,347.18 ns |  0.1453 ns |  0.1288 ns |   0.31 |     0.00 |
|                                               LinqToArray |           1000 |  5,228.41 ns |  6.3549 ns |  5.9444 ns |   1.21 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,721.68 ns |  5.6775 ns |  5.3107 ns |   1.79 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  5,673.93 ns | 13.7847 ns | 12.8942 ns |   1.32 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,283.27 ns |  3.4762 ns |  3.2517 ns |   0.53 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,232.45 ns |  1.3044 ns |  1.1563 ns |   0.52 |     0.00 |
|                                                      Take |           1000 |    350.70 ns |  0.1260 ns |  0.1178 ns |   0.08 |     0.00 |
|                                               LowCostTake |           1000 |    163.35 ns |  0.1342 ns |  0.1190 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    171.01 ns |  0.1496 ns |  0.1399 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    102.32 ns |  0.0355 ns |  0.0332 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     93.42 ns |  0.0258 ns |  0.0242 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    261.74 ns |  0.3577 ns |  0.3346 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    160.71 ns |  0.1022 ns |  0.0906 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    161.21 ns |  0.0321 ns |  0.0268 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     73.93 ns |  0.0161 ns |  0.0142 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     74.04 ns |  0.0289 ns |  0.0257 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  7,130.33 ns |  0.6699 ns |  0.5938 ns |   1.65 |     0.00 |
|                                                   Foreach |           1000 |  4,313.32 ns |  0.4048 ns |  0.3787 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |     **99.39 ns** |  **0.0172 ns** |  **0.0144 ns** |   **2.87** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     60.95 ns |  0.0271 ns |  0.0240 ns |   1.76 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     56.60 ns |  0.0189 ns |  0.0168 ns |   1.64 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     75.83 ns |  0.1640 ns |  0.1534 ns |   2.19 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     75.51 ns |  0.0803 ns |  0.0751 ns |   2.18 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     56.74 ns |  0.0225 ns |  0.0188 ns |   1.64 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     64.20 ns |  0.0224 ns |  0.0210 ns |   1.86 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    196.09 ns |  0.1385 ns |  0.1296 ns |   5.67 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    195.54 ns |  0.2843 ns |  0.2659 ns |   5.65 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    117.45 ns |  0.0776 ns |  0.0726 ns |   3.39 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    114.75 ns |  0.0197 ns |  0.0164 ns |   3.32 |     0.00 |
|                                                 LinqCount |              5 |     81.06 ns |  0.1222 ns |  0.1143 ns |   2.34 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     55.48 ns |  0.1528 ns |  0.1354 ns |   1.60 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     56.33 ns |  0.0254 ns |  0.0237 ns |   1.63 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     34.48 ns |  0.0180 ns |  0.0168 ns |   1.00 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     34.33 ns |  0.0116 ns |  0.0103 ns |   0.99 |     0.00 |
|                                               LinqToArray |              5 |    138.55 ns |  0.0329 ns |  0.0275 ns |   4.00 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    112.16 ns |  0.1285 ns |  0.1202 ns |   3.24 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    104.84 ns |  0.0604 ns |  0.0565 ns |   3.03 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     77.87 ns |  0.0296 ns |  0.0247 ns |   2.25 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     78.04 ns |  0.0508 ns |  0.0450 ns |   2.26 |     0.00 |
|                                                      Take |              5 |    160.46 ns |  0.0648 ns |  0.0541 ns |   4.64 |     0.00 |
|                                               LowCostTake |              5 |     69.11 ns |  0.0455 ns |  0.0426 ns |   2.00 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     66.80 ns |  0.0065 ns |  0.0054 ns |   1.93 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     59.46 ns |  0.0250 ns |  0.0234 ns |   1.72 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     62.02 ns |  0.0176 ns |  0.0156 ns |   1.79 |     0.00 |
|                                            SkipTakeSingle |              5 |    154.42 ns |  0.2398 ns |  0.2243 ns |   4.46 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |     74.34 ns |  0.0293 ns |  0.0274 ns |   2.15 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     70.67 ns |  0.0429 ns |  0.0401 ns |   2.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     56.49 ns |  0.0295 ns |  0.0230 ns |   1.63 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     60.47 ns |  0.0611 ns |  0.0572 ns |   1.75 |     0.00 |
|                                           ForeachDelegate |              5 |     52.80 ns |  0.0606 ns |  0.0567 ns |   1.53 |     0.00 |
|                                                   Foreach |              5 |     34.60 ns |  0.0255 ns |  0.0238 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **459.71 ns** |  **0.1519 ns** |  **0.1347 ns** |   **1.95** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    316.44 ns |  0.3138 ns |  0.2782 ns |   1.34 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    291.24 ns |  0.1105 ns |  0.0923 ns |   1.23 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    364.04 ns |  0.0930 ns |  0.0870 ns |   1.54 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    372.95 ns |  0.2707 ns |  0.2532 ns |   1.58 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    135.89 ns |  0.0278 ns |  0.0232 ns |   0.58 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    129.71 ns |  0.0209 ns |  0.0196 ns |   0.55 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,039.22 ns |  1.1388 ns |  1.0652 ns |   4.40 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,036.14 ns |  1.4419 ns |  1.2041 ns |   4.39 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    480.18 ns |  0.1454 ns |  0.1360 ns |   2.03 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    478.36 ns |  0.3793 ns |  0.3363 ns |   2.03 |     0.00 |
|                                                 LinqCount |             50 |    267.54 ns |  0.1083 ns |  0.0960 ns |   1.13 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    242.86 ns |  0.1201 ns |  0.1123 ns |   1.03 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    264.91 ns |  0.0225 ns |  0.0210 ns |   1.12 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |     85.77 ns |  0.0114 ns |  0.0106 ns |   0.36 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     85.82 ns |  0.0159 ns |  0.0132 ns |   0.36 |     0.00 |
|                                               LinqToArray |             50 |    516.13 ns |  0.1924 ns |  0.1705 ns |   2.19 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    531.54 ns |  0.2991 ns |  0.2798 ns |   2.25 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    432.18 ns |  0.5777 ns |  0.5404 ns |   1.83 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    225.92 ns |  0.0871 ns |  0.0772 ns |   0.96 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    228.10 ns |  0.4348 ns |  0.4067 ns |   0.97 |     0.00 |
|                                                      Take |             50 |    350.91 ns |  0.3426 ns |  0.3205 ns |   1.49 |     0.00 |
|                                               LowCostTake |             50 |    162.65 ns |  0.3130 ns |  0.2928 ns |   0.69 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    170.54 ns |  0.1903 ns |  0.1780 ns |   0.72 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    104.64 ns |  0.0645 ns |  0.0503 ns |   0.44 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     90.27 ns |  0.0128 ns |  0.0120 ns |   0.38 |     0.00 |
|                                            SkipTakeSingle |             50 |    261.59 ns |  0.2046 ns |  0.1914 ns |   1.11 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    160.11 ns |  0.0629 ns |  0.0557 ns |   0.68 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    161.51 ns |  0.0189 ns |  0.0158 ns |   0.68 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     74.14 ns |  0.0168 ns |  0.0149 ns |   0.31 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     73.83 ns |  0.0191 ns |  0.0179 ns |   0.31 |     0.00 |
|                                           ForeachDelegate |             50 |    379.99 ns |  0.0432 ns |  0.0383 ns |   1.61 |     0.00 |
|                                                   Foreach |             50 |    236.07 ns |  0.0914 ns |  0.0811 ns |   1.00 |     0.00 |
