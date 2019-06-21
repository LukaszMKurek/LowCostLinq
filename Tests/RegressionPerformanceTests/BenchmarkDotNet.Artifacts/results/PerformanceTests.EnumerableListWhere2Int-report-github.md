``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **66.00 ns** |   **0.0270 ns** |   **0.0239 ns** |     **66.00 ns** |  **3.96** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     38.73 ns |   0.0281 ns |   0.0263 ns |     38.74 ns |  2.32 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     30.86 ns |   0.3083 ns |   0.2733 ns |     30.94 ns |  1.85 |    0.02 |
|                                  LowCostLinqWithDelegate2 |            [0] |     48.20 ns |   0.0164 ns |   0.0145 ns |     48.20 ns |  2.89 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     45.88 ns |   0.0071 ns |   0.0059 ns |     45.88 ns |  2.75 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     43.47 ns |   0.0072 ns |   0.0068 ns |     43.47 ns |  2.61 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     38.29 ns |   0.0189 ns |   0.0158 ns |     38.30 ns |  2.30 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    106.69 ns |   0.0788 ns |   0.0737 ns |    106.70 ns |  6.40 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     93.22 ns |   0.0615 ns |   0.0545 ns |     93.20 ns |  5.59 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     91.93 ns |   1.6908 ns |   1.5816 ns |     90.69 ns |  5.51 |    0.09 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     82.13 ns |   0.0371 ns |   0.0347 ns |     82.12 ns |  4.93 |    0.00 |
|                                                 LinqCount |            [0] |     63.92 ns |   0.0462 ns |   0.0410 ns |     63.91 ns |  3.83 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     34.98 ns |   0.0475 ns |   0.0421 ns |     34.99 ns |  2.10 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.74 ns |   0.3950 ns |   0.3695 ns |     33.80 ns |  2.02 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.52 ns |   0.0105 ns |   0.0098 ns |     37.52 ns |  2.25 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     29.90 ns |   0.0076 ns |   0.0071 ns |     29.89 ns |  1.79 |    0.00 |
|                                               LinqToArray |            [0] |     78.03 ns |   0.0348 ns |   0.0308 ns |     78.03 ns |  4.68 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     48.29 ns |   0.7155 ns |   0.6693 ns |     47.78 ns |  2.90 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     45.11 ns |   0.0221 ns |   0.0207 ns |     45.11 ns |  2.71 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     46.31 ns |   0.0278 ns |   0.0260 ns |     46.31 ns |  2.78 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     39.14 ns |   0.0257 ns |   0.0201 ns |     39.13 ns |  2.35 |    0.00 |
|                                                      Take |            [0] |    102.51 ns |   0.0403 ns |   0.0377 ns |    102.51 ns |  6.15 |    0.00 |
|                                               LowCostTake |            [0] |     43.49 ns |   0.0112 ns |   0.0105 ns |     43.49 ns |  2.61 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     39.18 ns |   0.4409 ns |   0.4124 ns |     39.14 ns |  2.35 |    0.02 |
|                                     LowCostTakeWithStruct |            [0] |     49.92 ns |   0.0111 ns |   0.0104 ns |     49.91 ns |  2.99 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     44.78 ns |   0.0052 ns |   0.0049 ns |     44.78 ns |  2.69 |    0.00 |
|                                            SkipTakeSingle |            [0] |    125.35 ns |   0.0386 ns |   0.0361 ns |    125.36 ns |  7.52 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     51.32 ns |   0.0184 ns |   0.0144 ns |     51.32 ns |  3.08 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     49.17 ns |   0.0116 ns |   0.0109 ns |     49.17 ns |  2.95 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     59.20 ns |   0.0231 ns |   0.0181 ns |     59.19 ns |  3.55 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     54.18 ns |   0.4897 ns |   0.4581 ns |     53.84 ns |  3.25 |    0.03 |
|                                           ForeachDelegate |            [0] |     19.97 ns |   0.0080 ns |   0.0075 ns |     19.97 ns |  1.20 |    0.00 |
|                                                   Foreach |            [0] |     16.67 ns |   0.0095 ns |   0.0089 ns |     16.67 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** |  **8,934.67 ns** |   **6.9392 ns** |   **6.1514 ns** |  **8,935.52 ns** |  **1.62** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,578.67 ns | 147.0094 ns | 206.0866 ns |  7,582.08 ns |  1.38 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,231.61 ns | 121.7264 ns | 107.9073 ns |  6,235.48 ns |  1.13 |    0.02 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,836.12 ns | 173.4562 ns | 350.3900 ns |  8,796.39 ns |  1.58 |    0.07 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,444.73 ns | 128.5216 ns | 126.2254 ns |  6,391.45 ns |  1.17 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,680.37 ns |   3.2549 ns |   3.0446 ns |  2,679.40 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,736.53 ns |   0.7326 ns |   0.6117 ns |  1,736.54 ns |  0.31 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 20,930.76 ns | 403.3381 ns | 431.5672 ns | 20,935.06 ns |  3.79 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 20,296.34 ns | 212.1945 ns | 198.4869 ns | 20,282.41 ns |  3.68 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,727.00 ns |  93.7887 ns |  87.7300 ns |  9,682.79 ns |  1.76 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,949.96 ns |   5.9156 ns |   5.5335 ns |  8,950.49 ns |  1.62 |    0.00 |
|                                                 LinqCount |         [1000] |  3,911.92 ns |   3.3183 ns |   3.1039 ns |  3,911.99 ns |  0.71 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,061.48 ns | 119.6451 ns | 155.5724 ns |  6,021.57 ns |  1.10 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,141.17 ns | 100.6096 ns | 178.8335 ns |  5,146.61 ns |  0.94 |    0.02 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,748.17 ns |   0.7875 ns |   0.6981 ns |  1,748.23 ns |  0.32 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,226.64 ns |   8.7221 ns |   8.1587 ns |  1,222.74 ns |  0.22 |    0.00 |
|                                               LinqToArray |         [1000] |  5,324.86 ns |   4.2009 ns |   3.7240 ns |  5,325.36 ns |  0.96 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,538.20 ns |   5.0338 ns |   4.4624 ns |  7,539.10 ns |  1.37 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,955.49 ns | 133.8292 ns | 143.1957 ns |  6,868.05 ns |  1.26 |    0.03 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,434.53 ns |   6.3026 ns |   5.5871 ns |  3,435.78 ns |  0.62 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,567.48 ns |   2.6744 ns |   2.5016 ns |  2,568.04 ns |  0.47 |    0.00 |
|                                                      Take |         [1000] |    394.85 ns |   0.1078 ns |   0.0900 ns |    394.83 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    192.34 ns |   3.4442 ns |   3.2217 ns |    191.79 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    169.62 ns |   3.3246 ns |   5.3685 ns |    169.28 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    115.12 ns |   1.2656 ns |   1.1838 ns |    114.32 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     90.82 ns |   0.0805 ns |   0.0753 ns |     90.79 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    312.85 ns |   0.0698 ns |   0.0619 ns |    312.86 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    212.27 ns |   4.2569 ns |   4.3715 ns |    211.98 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    171.71 ns |   3.4232 ns |   3.0346 ns |    170.98 ns |  0.03 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    100.69 ns |   0.1110 ns |   0.1039 ns |    100.65 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     86.33 ns |   0.0386 ns |   0.0342 ns |     86.33 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,720.79 ns |  92.1640 ns |  86.2103 ns |  8,673.50 ns |  1.58 |    0.02 |
|                                                   Foreach |         [1000] |  5,518.17 ns |   1.8963 ns |   1.6811 ns |  5,518.32 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **521.94 ns** |   **0.2699 ns** |   **0.2525 ns** |    **521.92 ns** |  **1.72** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    400.79 ns |   7.9074 ns |   7.3966 ns |    399.60 ns |  1.32 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    358.63 ns |   7.0796 ns |  12.7661 ns |    357.29 ns |  1.18 |    0.04 |
|                                  LowCostLinqWithDelegate2 |           [50] |    472.24 ns |   5.9370 ns |   5.5535 ns |    470.66 ns |  1.55 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    391.80 ns |   7.8084 ns |  11.6873 ns |    391.55 ns |  1.28 |    0.03 |
|                                LowCostLinqWithStructWhere |           [50] |    179.57 ns |   0.3687 ns |   0.3449 ns |    179.78 ns |  0.59 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    133.71 ns |   0.0533 ns |   0.0499 ns |    133.71 ns |  0.44 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,140.61 ns |  22.2503 ns |  22.8494 ns |  1,124.87 ns |  3.76 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,105.13 ns |   1.5699 ns |   1.3917 ns |  1,105.49 ns |  3.63 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    580.59 ns |   0.1391 ns |   0.1301 ns |    580.63 ns |  1.91 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    546.39 ns |   0.1448 ns |   0.1283 ns |    546.37 ns |  1.80 |    0.00 |
|                                                 LinqCount |           [50] |    273.02 ns |   5.3876 ns |   6.2044 ns |    268.68 ns |  0.90 |    0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |    342.47 ns |   6.7536 ns |   9.0158 ns |    342.13 ns |  1.14 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    296.10 ns |   5.8631 ns |   9.4678 ns |    296.96 ns |  0.98 |    0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |    131.38 ns |   2.0798 ns |   1.9454 ns |    131.27 ns |  0.43 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     82.25 ns |   0.4523 ns |   0.4231 ns |     82.04 ns |  0.27 |    0.00 |
|                                               LinqToArray |           [50] |    520.86 ns |   0.1344 ns |   0.1257 ns |    520.84 ns |  1.71 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    517.78 ns |   0.2202 ns |   0.2060 ns |    517.69 ns |  1.70 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    488.51 ns |   0.5006 ns |   0.4180 ns |    488.58 ns |  1.61 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    283.45 ns |   0.2017 ns |   0.1788 ns |    283.49 ns |  0.93 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    234.10 ns |   0.1420 ns |   0.1259 ns |    234.11 ns |  0.77 |    0.00 |
|                                                      Take |           [50] |    394.44 ns |   0.0698 ns |   0.0619 ns |    394.45 ns |  1.30 |    0.00 |
|                                               LowCostTake |           [50] |    191.22 ns |   3.5733 ns |   3.3425 ns |    190.70 ns |  0.63 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    170.94 ns |   3.4420 ns |   6.1182 ns |    170.86 ns |  0.57 |    0.02 |
|                                     LowCostTakeWithStruct |           [50] |    117.38 ns |   1.2468 ns |   1.1663 ns |    116.61 ns |  0.39 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     90.93 ns |   0.0458 ns |   0.0383 ns |     90.93 ns |  0.30 |    0.00 |
|                                            SkipTakeSingle |           [50] |    312.59 ns |   0.0531 ns |   0.0443 ns |    312.60 ns |  1.03 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    208.08 ns |   4.8549 ns |   4.9856 ns |    206.74 ns |  0.69 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    171.72 ns |   3.2759 ns |   3.2173 ns |    170.93 ns |  0.57 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    100.19 ns |   0.0302 ns |   0.0283 ns |    100.19 ns |  0.33 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     76.99 ns |   0.1779 ns |   0.1664 ns |     76.94 ns |  0.25 |    0.00 |
|                                           ForeachDelegate |           [50] |    461.34 ns |   0.1517 ns |   0.1419 ns |    461.35 ns |  1.52 |    0.00 |
|                                                   Foreach |           [50] |    304.03 ns |   0.0608 ns |   0.0539 ns |    304.04 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **110.26 ns** |   **0.0307 ns** |   **0.0272 ns** |    **110.27 ns** |  **2.52** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     72.16 ns |   1.4535 ns |   2.0377 ns |     71.85 ns |  1.66 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     59.79 ns |   1.2317 ns |   1.1522 ns |     59.89 ns |  1.37 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |     80.57 ns |   1.1426 ns |   1.0688 ns |     80.53 ns |  1.84 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     76.35 ns |   1.5255 ns |   1.5666 ns |     76.15 ns |  1.75 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |     57.42 ns |   0.0732 ns |   0.0611 ns |     57.44 ns |  1.31 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     50.36 ns |   0.0680 ns |   0.0568 ns |     50.37 ns |  1.15 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    220.33 ns |   0.0928 ns |   0.0823 ns |    220.33 ns |  5.04 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    203.00 ns |   0.1540 ns |   0.1440 ns |    203.00 ns |  4.65 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    142.05 ns |   0.2768 ns |   0.2454 ns |    142.09 ns |  3.25 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    131.17 ns |   0.0355 ns |   0.0332 ns |    131.17 ns |  3.00 |    0.00 |
|                                                 LinqCount |            [5] |     85.72 ns |   0.0459 ns |   0.0359 ns |     85.70 ns |  1.96 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     66.64 ns |   1.2897 ns |   1.3244 ns |     67.23 ns |  1.53 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     57.31 ns |   0.2686 ns |   0.2381 ns |     57.26 ns |  1.31 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     45.95 ns |   0.0182 ns |   0.0142 ns |     45.95 ns |  1.05 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     33.04 ns |   0.0389 ns |   0.0325 ns |     33.02 ns |  0.76 |    0.00 |
|                                               LinqToArray |            [5] |    146.04 ns |   0.0546 ns |   0.0484 ns |    146.04 ns |  3.34 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    114.02 ns |   0.0317 ns |   0.0296 ns |    114.02 ns |  2.61 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    109.46 ns |   2.1941 ns |   2.0523 ns |    107.93 ns |  2.51 |    0.05 |
|                              LowCostLinqWithStructToArray |            [5] |     90.58 ns |   0.0514 ns |   0.0481 ns |     90.60 ns |  2.07 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     76.23 ns |   0.0161 ns |   0.0151 ns |     76.22 ns |  1.74 |    0.00 |
|                                                      Take |            [5] |    181.38 ns |   0.2575 ns |   0.2010 ns |    181.33 ns |  4.15 |    0.00 |
|                                               LowCostTake |            [5] |     75.75 ns |   0.6991 ns |   0.5838 ns |     75.73 ns |  1.73 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |     72.43 ns |   1.3125 ns |   1.2277 ns |     72.68 ns |  1.66 |    0.03 |
|                                     LowCostTakeWithStruct |            [5] |     67.41 ns |   0.2531 ns |   0.2368 ns |     67.29 ns |  1.54 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     57.94 ns |   0.5268 ns |   0.4670 ns |     57.70 ns |  1.33 |    0.01 |
|                                            SkipTakeSingle |            [5] |    168.11 ns |   0.0472 ns |   0.0442 ns |    168.10 ns |  3.85 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     83.21 ns |   1.6765 ns |   1.6465 ns |     83.40 ns |  1.90 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     71.21 ns |   1.2662 ns |   1.1844 ns |     70.93 ns |  1.63 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     68.47 ns |   0.0231 ns |   0.0181 ns |     68.48 ns |  1.57 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.36 ns |   0.0102 ns |   0.0095 ns |     55.36 ns |  1.27 |    0.00 |
|                                           ForeachDelegate |            [5] |     63.10 ns |   0.0276 ns |   0.0258 ns |     63.10 ns |  1.44 |    0.00 |
|                                                   Foreach |            [5] |     43.69 ns |   0.0182 ns |   0.0161 ns |     43.69 ns |  1.00 |    0.00 |
