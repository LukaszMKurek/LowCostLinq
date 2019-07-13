``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **142.44 ns** |   **0.1978 ns** |     **0.1753 ns** |    **142.50 ns** |  **7.91** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |     56.79 ns |   0.0149 ns |     0.0140 ns |     56.79 ns |  3.15 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     52.48 ns |   0.0163 ns |     0.0152 ns |     52.48 ns |  2.91 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     83.01 ns |   0.0324 ns |     0.0287 ns |     83.01 ns |  4.61 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     77.36 ns |   0.0280 ns |     0.0248 ns |     77.36 ns |  4.30 |    0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     64.01 ns |   0.0134 ns |     0.0126 ns |     64.01 ns |  3.55 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     61.66 ns |   0.0459 ns |     0.0429 ns |     61.67 ns |  3.42 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     85.24 ns |   0.0399 ns |     0.0373 ns |     85.23 ns |  4.73 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     88.88 ns |   0.0399 ns |     0.0374 ns |     88.87 ns |  4.94 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     79.52 ns |   0.0368 ns |     0.0344 ns |     79.52 ns |  4.42 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     78.87 ns |   0.0522 ns |     0.0488 ns |     78.87 ns |  4.38 |    0.01 |
|                                                 LinqCount |            [0] |    142.88 ns |   0.0689 ns |     0.0611 ns |    142.89 ns |  7.93 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [0] |     57.70 ns |   0.0843 ns |     0.0789 ns |     57.73 ns |  3.20 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     56.46 ns |   0.0400 ns |     0.0374 ns |     56.46 ns |  3.14 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     58.31 ns |   0.0225 ns |     0.0211 ns |     58.31 ns |  3.24 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     62.00 ns |   0.0138 ns |     0.0107 ns |     62.00 ns |  3.44 |    0.01 |
|                                               LinqToArray |            [0] |    156.44 ns |   0.0775 ns |     0.0725 ns |    156.42 ns |  8.69 |    0.02 |
|                            LowCostLinqWithDelegateToArray |            [0] |     68.47 ns |   0.0286 ns |     0.0267 ns |     68.47 ns |  3.80 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     70.52 ns |   0.0265 ns |     0.0235 ns |     70.52 ns |  3.92 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     68.72 ns |   0.1322 ns |     0.1172 ns |     68.74 ns |  3.82 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     68.71 ns |   0.0262 ns |     0.0245 ns |     68.70 ns |  3.82 |    0.01 |
|                                                      Take |            [0] |    180.43 ns |   0.0528 ns |     0.0494 ns |    180.41 ns | 10.02 |    0.03 |
|                                               LowCostTake |            [0] |     69.14 ns |   0.0222 ns |     0.0207 ns |     69.14 ns |  3.84 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     64.93 ns |   0.0786 ns |     0.0697 ns |     64.95 ns |  3.61 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     77.23 ns |   0.0503 ns |     0.0470 ns |     77.21 ns |  4.29 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     74.04 ns |   0.0253 ns |     0.0237 ns |     74.04 ns |  4.11 |    0.01 |
|                                            SkipTakeSingle |            [0] |    202.91 ns |   0.0780 ns |     0.0730 ns |    202.90 ns | 11.27 |    0.03 |
|                                     LowCostSkipTakeSingle |            [0] |     94.25 ns |   0.0597 ns |     0.0559 ns |     94.25 ns |  5.23 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     93.94 ns |   0.0224 ns |     0.0209 ns |     93.94 ns |  5.22 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     94.51 ns |   0.0660 ns |     0.0618 ns |     94.52 ns |  5.25 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     94.56 ns |   0.0254 ns |     0.0225 ns |     94.57 ns |  5.25 |    0.01 |
|                                           ForeachDelegate |            [0] |     21.94 ns |   0.0449 ns |     0.0420 ns |     21.95 ns |  1.22 |    0.00 |
|                                                   Foreach |            [0] |     18.01 ns |   0.0478 ns |     0.0447 ns |     17.98 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **19,326.28 ns** |  **90.7006 ns** |    **84.8414 ns** | **19,348.83 ns** |  **3.48** |    **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] | 17,570.82 ns | 358.7389 ns |   866.3948 ns | 17,059.18 ns |  3.18 |    0.15 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 18,511.18 ns | 365.8588 ns |   803.0690 ns | 18,032.89 ns |  3.36 |    0.15 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 17,655.23 ns | 190.5778 ns |   168.9422 ns | 17,620.87 ns |  3.18 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 16,567.40 ns | 328.0973 ns |   684.8612 ns | 16,125.48 ns |  2.97 |    0.12 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,093.53 ns |   8.6942 ns |     7.7071 ns |  7,095.14 ns |  1.28 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,771.82 ns |   1.6974 ns |     1.5878 ns |  6,771.08 ns |  1.22 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 25,958.39 ns | 131.7937 ns |   123.2799 ns | 25,955.19 ns |  4.68 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 26,109.17 ns | 505.7651 ns |   787.4153 ns | 26,304.86 ns |  4.73 |    0.12 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,212.43 ns |   6.2976 ns |     5.8908 ns |  9,211.94 ns |  1.66 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,233.96 ns |  42.5899 ns |    39.8386 ns |  9,220.52 ns |  1.66 |    0.01 |
|                                                 LinqCount |         [1000] | 16,163.96 ns | 157.0148 ns |   131.1145 ns | 16,191.47 ns |  2.91 |    0.02 |
|                              LowCostLinqWithDelegateCount |         [1000] | 15,550.56 ns | 389.1613 ns | 1,147.4508 ns | 14,859.50 ns |  2.75 |    0.16 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 15,204.47 ns | 303.4287 ns |   732.8145 ns | 14,994.33 ns |  2.78 |    0.13 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,575.71 ns |   1.7277 ns |     1.6160 ns |  5,575.08 ns |  1.00 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,591.91 ns |   9.4709 ns |     8.8591 ns |  5,595.01 ns |  1.01 |    0.00 |
|                                               LinqToArray |         [1000] | 17,282.25 ns |  37.9652 ns |    35.5127 ns | 17,284.12 ns |  3.11 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 16,884.83 ns |  65.4014 ns |    61.1765 ns | 16,877.08 ns |  3.04 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 15,904.92 ns |  25.3478 ns |    23.7103 ns | 15,900.83 ns |  2.87 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,115.27 ns |   6.0618 ns |     5.6702 ns |  7,113.30 ns |  1.28 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,314.49 ns |   5.3191 ns |     4.7153 ns |  7,315.50 ns |  1.32 |    0.00 |
|                                                      Take |         [1000] |    680.37 ns |   1.7114 ns |     1.6008 ns |    679.78 ns |  0.12 |    0.00 |
|                                               LowCostTake |         [1000] |    438.79 ns |   8.4978 ns |     8.3460 ns |    442.27 ns |  0.08 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    434.23 ns |   1.8274 ns |     1.7094 ns |    433.72 ns |  0.08 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    231.70 ns |   0.1416 ns |     0.1324 ns |    231.70 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    223.25 ns |   0.0603 ns |     0.0564 ns |    223.24 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    589.94 ns |   0.6083 ns |     0.5690 ns |    589.86 ns |  0.11 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    496.49 ns |   9.7581 ns |    10.4411 ns |    490.59 ns |  0.09 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    480.95 ns |   3.0393 ns |     2.8429 ns |    480.53 ns |  0.09 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    270.72 ns |   0.0958 ns |     0.0896 ns |    270.73 ns |  0.05 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    273.20 ns |   0.0638 ns |     0.0597 ns |    273.19 ns |  0.05 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,963.84 ns |   3.4974 ns |     3.2715 ns | 10,963.26 ns |  1.98 |    0.00 |
|                                                   Foreach |         [1000] |  5,550.73 ns |   1.4333 ns |     1.3407 ns |  5,550.44 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |  **1,116.50 ns** |   **4.3755 ns** |     **4.0928 ns** |  **1,116.49 ns** |  **3.65** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    955.99 ns |  19.0636 ns |    37.6297 ns |    942.55 ns |  3.17 |    0.13 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    952.45 ns |  18.0924 ns |    17.7692 ns |    943.05 ns |  3.12 |    0.06 |
|                                  LowCostLinqWithDelegate2 |           [50] |    941.28 ns |  18.5920 ns |    31.0630 ns |    935.21 ns |  3.09 |    0.13 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    914.78 ns |  17.8781 ns |    24.4718 ns |    897.34 ns |  3.00 |    0.08 |
|                                LowCostLinqWithStructWhere |           [50] |    422.08 ns |   0.0973 ns |     0.0910 ns |    422.07 ns |  1.38 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    404.79 ns |   0.1097 ns |     0.1026 ns |    404.78 ns |  1.32 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,470.37 ns |  11.2728 ns |    10.5446 ns |  1,468.39 ns |  4.81 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,339.81 ns |  17.1021 ns |    15.9973 ns |  1,333.14 ns |  4.38 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    549.81 ns |   0.5282 ns |     0.4941 ns |    549.74 ns |  1.80 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    558.16 ns |   0.5215 ns |     0.4878 ns |    558.21 ns |  1.83 |    0.00 |
|                                                 LinqCount |           [50] |    910.66 ns |   5.0044 ns |     4.6811 ns |    908.23 ns |  2.98 |    0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |    853.25 ns |  15.4145 ns |    12.8718 ns |    857.91 ns |  2.79 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    816.26 ns |  16.1050 ns |    20.9411 ns |    808.27 ns |  2.65 |    0.06 |
|                           LowCostLinqWithStructWhereCount |           [50] |    348.65 ns |   0.0917 ns |     0.0813 ns |    348.62 ns |  1.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    346.29 ns |   0.0682 ns |     0.0638 ns |    346.27 ns |  1.13 |    0.00 |
|                                               LinqToArray |           [50] |  1,241.15 ns |   1.6676 ns |     1.5599 ns |  1,241.32 ns |  4.06 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    994.10 ns |   1.7251 ns |     1.6137 ns |    993.86 ns |  3.25 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |  1,047.17 ns |   2.9535 ns |     2.6182 ns |  1,047.08 ns |  3.42 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    532.06 ns |   0.2478 ns |     0.2318 ns |    532.07 ns |  1.74 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    545.18 ns |   1.9526 ns |     1.8265 ns |    545.76 ns |  1.78 |    0.01 |
|                                                      Take |           [50] |    655.64 ns |   1.1269 ns |     0.9410 ns |    655.47 ns |  2.14 |    0.00 |
|                                               LowCostTake |           [50] |    429.31 ns |   6.9861 ns |     6.5348 ns |    427.61 ns |  1.40 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    434.99 ns |   8.4828 ns |    11.0300 ns |    433.65 ns |  1.43 |    0.04 |
|                                     LowCostTakeWithStruct |           [50] |    226.80 ns |   0.1312 ns |     0.1163 ns |    226.76 ns |  0.74 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    223.64 ns |   0.0516 ns |     0.0483 ns |    223.64 ns |  0.73 |    0.00 |
|                                            SkipTakeSingle |           [50] |    593.83 ns |   0.8038 ns |     0.7519 ns |    594.15 ns |  1.94 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    492.76 ns |   4.4976 ns |     3.9870 ns |    491.39 ns |  1.61 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    561.90 ns |   4.5287 ns |     4.2362 ns |    561.88 ns |  1.84 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    269.97 ns |   0.0951 ns |     0.0890 ns |    269.97 ns |  0.88 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    274.42 ns |   0.2483 ns |     0.2323 ns |    274.47 ns |  0.90 |    0.00 |
|                                           ForeachDelegate |           [50] |    582.56 ns |   0.1709 ns |     0.1598 ns |    582.55 ns |  1.91 |    0.00 |
|                                                   Foreach |           [50] |    305.75 ns |   0.0763 ns |     0.0714 ns |    305.74 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **250.75 ns** |   **0.0910 ns** |     **0.0851 ns** |    **250.73 ns** |  **5.56** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    153.58 ns |   0.3940 ns |     0.3685 ns |    153.73 ns |  3.41 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    157.04 ns |   0.2099 ns |     0.1860 ns |    157.06 ns |  3.48 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    193.71 ns |   0.6906 ns |     0.6460 ns |    193.63 ns |  4.30 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    175.54 ns |   0.8138 ns |     0.7612 ns |    175.51 ns |  3.89 |    0.02 |
|                                LowCostLinqWithStructWhere |            [5] |     93.66 ns |   0.0407 ns |     0.0361 ns |     93.66 ns |  2.08 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     86.27 ns |   0.0323 ns |     0.0270 ns |     86.26 ns |  1.91 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    219.80 ns |   0.1527 ns |     0.1429 ns |    219.76 ns |  4.88 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    229.90 ns |   0.4715 ns |     0.4410 ns |    229.90 ns |  5.10 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    125.74 ns |   0.0641 ns |     0.0600 ns |    125.73 ns |  2.79 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    124.47 ns |   0.0926 ns |     0.0866 ns |    124.48 ns |  2.76 |    0.00 |
|                                                 LinqCount |            [5] |    245.11 ns |   0.1070 ns |     0.1001 ns |    245.08 ns |  5.44 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    152.53 ns |   2.7260 ns |     2.5499 ns |    153.11 ns |  3.38 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    138.73 ns |   0.7384 ns |     0.6907 ns |    138.98 ns |  3.08 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |     86.04 ns |   0.1329 ns |     0.1243 ns |     86.06 ns |  1.91 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     84.87 ns |   0.0382 ns |     0.0357 ns |     84.87 ns |  1.88 |    0.00 |
|                                               LinqToArray |            [5] |    305.47 ns |   0.3333 ns |     0.3118 ns |    305.44 ns |  6.78 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    197.58 ns |   0.1498 ns |     0.1402 ns |    197.62 ns |  4.38 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    203.63 ns |   0.1813 ns |     0.1696 ns |    203.67 ns |  4.52 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    143.77 ns |   0.0639 ns |     0.0598 ns |    143.74 ns |  3.19 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    145.44 ns |   0.0438 ns |     0.0410 ns |    145.44 ns |  3.23 |    0.00 |
|                                                      Take |            [5] |    311.48 ns |   0.0922 ns |     0.0862 ns |    311.49 ns |  6.91 |    0.00 |
|                                               LowCostTake |            [5] |    167.34 ns |   0.4385 ns |     0.3888 ns |    167.24 ns |  3.71 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    165.87 ns |   0.7079 ns |     0.6621 ns |    165.92 ns |  3.68 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |    117.36 ns |   0.0682 ns |     0.0604 ns |    117.34 ns |  2.60 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    104.12 ns |   0.0289 ns |     0.0257 ns |    104.13 ns |  2.31 |    0.00 |
|                                            SkipTakeSingle |            [5] |    311.54 ns |   0.1078 ns |     0.1008 ns |    311.54 ns |  6.91 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    197.78 ns |   0.5591 ns |     0.4956 ns |    197.65 ns |  4.39 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    184.86 ns |   0.7144 ns |     0.6683 ns |    184.82 ns |  4.10 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    133.42 ns |   0.0767 ns |     0.0680 ns |    133.41 ns |  2.96 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    133.41 ns |   0.0461 ns |     0.0431 ns |    133.40 ns |  2.96 |    0.00 |
|                                           ForeachDelegate |            [5] |     77.40 ns |   0.1819 ns |     0.1702 ns |     77.44 ns |  1.72 |    0.00 |
|                                                   Foreach |            [5] |     45.07 ns |   0.0215 ns |     0.0191 ns |     45.07 ns |  1.00 |    0.00 |
