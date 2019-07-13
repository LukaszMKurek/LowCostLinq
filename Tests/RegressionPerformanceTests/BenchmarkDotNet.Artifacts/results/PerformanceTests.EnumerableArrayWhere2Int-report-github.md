``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |        Mean |       Error |      StdDev |      Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |------------:|------------:|------------:|------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **49.47 ns** |   **0.0242 ns** |   **0.0215 ns** |    **49.47 ns** |  **4.41** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |    37.69 ns |   0.7091 ns |   0.6633 ns |    37.70 ns |  3.37 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    29.86 ns |   0.0092 ns |   0.0082 ns |    29.86 ns |  2.66 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |    47.17 ns |   0.0365 ns |   0.0342 ns |    47.15 ns |  4.21 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    46.32 ns |   0.5973 ns |   0.5587 ns |    45.94 ns |  4.14 |    0.05 |
|                                LowCostLinqWithStructWhere |            [0] |    40.76 ns |   0.0173 ns |   0.0162 ns |    40.76 ns |  3.64 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    38.12 ns |   0.0178 ns |   0.0167 ns |    38.12 ns |  3.40 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    47.17 ns |   0.0732 ns |   0.0572 ns |    47.16 ns |  4.21 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    44.10 ns |   0.0284 ns |   0.0266 ns |    44.10 ns |  3.93 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    38.69 ns |   0.0626 ns |   0.0586 ns |    38.70 ns |  3.45 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    38.85 ns |   0.0199 ns |   0.0186 ns |    38.85 ns |  3.47 |    0.00 |
|                                                 LinqCount |            [0] |    49.36 ns |   1.0005 ns |   1.0705 ns |    48.71 ns |  4.42 |    0.10 |
|                              LowCostLinqWithDelegateCount |            [0] |    33.22 ns |   0.0384 ns |   0.0341 ns |    33.22 ns |  2.96 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    33.47 ns |   0.0445 ns |   0.0416 ns |    33.46 ns |  2.99 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |    30.15 ns |   0.0063 ns |   0.0056 ns |    30.15 ns |  2.69 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    30.92 ns |   0.4608 ns |   0.4310 ns |    30.59 ns |  2.76 |    0.04 |
|                                               LinqToArray |            [0] |    62.97 ns |   0.0355 ns |   0.0297 ns |    62.96 ns |  5.62 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |    45.07 ns |   0.0358 ns |   0.0317 ns |    45.07 ns |  4.02 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    46.32 ns |   0.0710 ns |   0.0665 ns |    46.31 ns |  4.13 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |    39.14 ns |   0.0134 ns |   0.0125 ns |    39.14 ns |  3.49 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    39.47 ns |   0.0369 ns |   0.0345 ns |    39.45 ns |  3.52 |    0.00 |
|                                                      Take |            [0] |    82.56 ns |   0.0216 ns |   0.0202 ns |    82.56 ns |  7.36 |    0.01 |
|                                               LowCostTake |            [0] |    40.38 ns |   0.6501 ns |   0.6081 ns |    39.89 ns |  3.60 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [0] |    37.44 ns |   0.0480 ns |   0.0449 ns |    37.44 ns |  3.34 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |    47.00 ns |   0.0069 ns |   0.0064 ns |    47.00 ns |  4.19 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    45.76 ns |   0.0169 ns |   0.0158 ns |    45.76 ns |  4.08 |    0.00 |
|                                            SkipTakeSingle |            [0] |   108.12 ns |   0.0380 ns |   0.0317 ns |   108.11 ns |  9.65 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |    49.37 ns |   0.0153 ns |   0.0135 ns |    49.37 ns |  4.40 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    49.38 ns |   0.0190 ns |   0.0169 ns |    49.37 ns |  4.40 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    52.38 ns |   0.0084 ns |   0.0079 ns |    52.38 ns |  4.67 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    54.57 ns |   0.0064 ns |   0.0057 ns |    54.57 ns |  4.87 |    0.00 |
|                                           ForeachDelegate |            [0] |    14.17 ns |   0.0074 ns |   0.0066 ns |    14.17 ns |  1.26 |    0.00 |
|                                                   Foreach |            [0] |    11.21 ns |   0.0087 ns |   0.0077 ns |    11.21 ns |  1.00 |    0.00 |
|                                                           |                |             |             |             |             |       |         |
|                                                      **Linq** |         **[1000]** | **7,498.40 ns** |   **3.5540 ns** |   **3.3244 ns** | **7,497.21 ns** |  **1.74** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 5,840.38 ns | 107.4272 ns | 100.4875 ns | 5,823.71 ns |  1.35 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 6,046.14 ns | 119.8310 ns | 179.3574 ns | 6,025.39 ns |  1.41 |    0.05 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 6,020.47 ns |  89.2457 ns |  83.4804 ns | 6,010.37 ns |  1.39 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 5,732.91 ns | 107.6191 ns | 100.6669 ns | 5,737.87 ns |  1.33 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,475.51 ns |   0.7323 ns |   0.6492 ns | 1,475.55 ns |  0.34 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,280.87 ns |   0.5662 ns |   0.5019 ns | 1,280.97 ns |  0.30 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 8,330.61 ns |  79.4828 ns |  74.3482 ns | 8,319.22 ns |  1.93 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 8,651.36 ns | 121.4935 ns | 113.6451 ns | 8,653.16 ns |  2.00 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 4,581.72 ns |  12.1742 ns |   9.5048 ns | 4,578.15 ns |  1.06 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 4,584.96 ns |   2.2604 ns |   2.1143 ns | 4,585.54 ns |  1.06 |    0.00 |
|                                                 LinqCount |         [1000] | 3,898.86 ns |   4.3117 ns |   4.0332 ns | 3,897.55 ns |  0.90 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 4,845.86 ns |  70.4840 ns |  65.9308 ns | 4,845.61 ns |  1.12 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 5,144.81 ns | 107.9023 ns | 158.1618 ns | 5,125.64 ns |  1.21 |    0.04 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   572.49 ns |   0.1211 ns |   0.1074 ns |   572.49 ns |  0.13 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   571.61 ns |   0.1684 ns |   0.1575 ns |   571.57 ns |  0.13 |    0.00 |
|                                               LinqToArray |         [1000] | 5,116.15 ns |   3.4112 ns |   3.1908 ns | 5,116.93 ns |  1.19 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 6,422.70 ns |  12.6444 ns |  11.8276 ns | 6,422.84 ns |  1.49 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 5,646.15 ns |   6.4826 ns |   5.4133 ns | 5,647.53 ns |  1.31 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,705.32 ns |   2.1666 ns |   1.9207 ns | 1,705.15 ns |  0.40 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,891.96 ns |   2.3690 ns |   2.1000 ns | 1,891.25 ns |  0.44 |    0.00 |
|                                                      Take |         [1000] |   359.28 ns |   0.1235 ns |   0.1095 ns |   359.30 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |   171.55 ns |   3.4366 ns |   3.3752 ns |   171.81 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |   155.92 ns |   3.9509 ns |   4.2274 ns |   155.14 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    85.81 ns |   0.0198 ns |   0.0185 ns |    85.81 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    75.31 ns |   0.1376 ns |   0.1287 ns |    75.34 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   273.31 ns |   0.1633 ns |   0.1275 ns |   273.34 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   171.27 ns |   2.0029 ns |   1.7755 ns |   171.36 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   169.18 ns |   3.3294 ns |   3.7006 ns |   168.23 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    76.16 ns |   0.0795 ns |   0.0743 ns |    76.18 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    78.82 ns |   0.0708 ns |   0.0662 ns |    78.81 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] | 7,248.80 ns |   1.6167 ns |   1.4332 ns | 7,249.13 ns |  1.68 |    0.00 |
|                                                   Foreach |         [1000] | 4,317.24 ns |   1.8268 ns |   1.7087 ns | 4,317.85 ns |  1.00 |    0.00 |
|                                                           |                |             |             |             |             |       |         |
|                                                      **Linq** |           **[50]** |   **442.11 ns** |   **7.1565 ns** |   **6.6942 ns** |   **437.26 ns** |  **1.87** |    **0.03** |
|                                   LowCostLinqWithDelegate |           [50] |   333.09 ns |   6.5852 ns |   6.4676 ns |   330.08 ns |  1.40 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   345.69 ns |   5.9876 ns |   5.6008 ns |   345.52 ns |  1.46 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |   343.66 ns |   7.3353 ns |   6.8614 ns |   341.24 ns |  1.45 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   341.72 ns |   6.7637 ns |   8.3065 ns |   339.46 ns |  1.44 |    0.04 |
|                                LowCostLinqWithStructWhere |           [50] |   115.04 ns |   0.0832 ns |   0.0778 ns |   115.04 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   106.80 ns |   1.0743 ns |   1.0049 ns |   106.27 ns |  0.45 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   461.69 ns |   0.5596 ns |   0.5235 ns |   461.61 ns |  1.95 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   469.10 ns |   0.2975 ns |   0.2783 ns |   469.09 ns |  1.98 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   272.80 ns |   0.0838 ns |   0.0784 ns |   272.82 ns |  1.15 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   280.08 ns |   5.0747 ns |   4.7469 ns |   277.35 ns |  1.18 |    0.02 |
|                                                 LinqCount |           [50] |   256.61 ns |   0.2301 ns |   0.2152 ns |   256.61 ns |  1.08 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |   291.97 ns |   5.7133 ns |   8.7248 ns |   290.16 ns |  1.22 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   296.21 ns |   5.4312 ns |   4.8146 ns |   296.93 ns |  1.25 |    0.02 |
|                           LowCostLinqWithStructWhereCount |           [50] |    58.82 ns |   0.8521 ns |   0.7553 ns |    58.34 ns |  0.25 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    56.88 ns |   0.0386 ns |   0.0361 ns |    56.87 ns |  0.24 |    0.00 |
|                                               LinqToArray |           [50] |   507.33 ns |   0.2956 ns |   0.2621 ns |   507.37 ns |  2.14 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |   478.49 ns |   0.2702 ns |   0.2395 ns |   478.50 ns |  2.02 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   449.12 ns |   9.4249 ns |  11.2196 ns |   443.07 ns |  1.92 |    0.05 |
|                              LowCostLinqWithStructToArray |           [50] |   198.82 ns |   0.0984 ns |   0.0921 ns |   198.81 ns |  0.84 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   208.85 ns |   0.2511 ns |   0.2348 ns |   208.82 ns |  0.88 |    0.00 |
|                                                      Take |           [50] |   357.67 ns |   0.1222 ns |   0.1143 ns |   357.66 ns |  1.51 |    0.00 |
|                                               LowCostTake |           [50] |   164.45 ns |   0.7004 ns |   0.5468 ns |   164.32 ns |  0.69 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |   159.55 ns |   3.1875 ns |   2.9816 ns |   158.84 ns |  0.68 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    86.54 ns |   0.8258 ns |   0.7321 ns |    86.11 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    74.37 ns |   0.0517 ns |   0.0458 ns |    74.37 ns |  0.31 |    0.00 |
|                                            SkipTakeSingle |           [50] |   266.15 ns |   0.0872 ns |   0.0728 ns |   266.16 ns |  1.12 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |   175.16 ns |   3.4113 ns |   3.1910 ns |   175.73 ns |  0.74 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   165.64 ns |   2.8739 ns |   2.3999 ns |   165.08 ns |  0.70 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    77.01 ns |   0.0931 ns |   0.0825 ns |    77.02 ns |  0.33 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    75.79 ns |   0.0995 ns |   0.0931 ns |    75.78 ns |  0.32 |    0.00 |
|                                           ForeachDelegate |           [50] |   391.70 ns |   0.1737 ns |   0.1625 ns |   391.69 ns |  1.66 |    0.00 |
|                                                   Foreach |           [50] |   236.68 ns |   0.0592 ns |   0.0462 ns |   236.68 ns |  1.00 |    0.00 |
|                                                           |                |             |             |             |             |       |         |
|                                                      **Linq** |            **[5]** |    **98.02 ns** |   **0.0384 ns** |   **0.0359 ns** |    **98.01 ns** |  **2.83** |    **0.06** |
|                                   LowCostLinqWithDelegate |            [5] |    61.31 ns |   1.0938 ns |   1.0232 ns |    60.77 ns |  1.77 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    57.94 ns |   0.9661 ns |   0.9037 ns |    57.71 ns |  1.67 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |    75.42 ns |   0.8059 ns |   0.7144 ns |    75.26 ns |  2.18 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    71.18 ns |   1.1343 ns |   1.0610 ns |    71.43 ns |  2.05 |    0.06 |
|                                LowCostLinqWithStructWhere |            [5] |    46.63 ns |   0.0418 ns |   0.0391 ns |    46.62 ns |  1.34 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    46.01 ns |   0.4633 ns |   0.4334 ns |    45.66 ns |  1.33 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    87.39 ns |   0.0564 ns |   0.0527 ns |    87.40 ns |  2.52 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    86.15 ns |   0.0519 ns |   0.0460 ns |    86.16 ns |  2.49 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    61.55 ns |   0.1488 ns |   0.1392 ns |    61.46 ns |  1.77 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    62.70 ns |   1.2184 ns |   1.1396 ns |    63.33 ns |  1.81 |    0.06 |
|                                                 LinqCount |            [5] |    80.47 ns |   0.0257 ns |   0.0228 ns |    80.47 ns |  2.33 |    0.04 |
|                              LowCostLinqWithDelegateCount |            [5] |    56.76 ns |   0.6690 ns |   0.6257 ns |    56.62 ns |  1.64 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    58.33 ns |   0.4620 ns |   0.4322 ns |    58.06 ns |  1.68 |    0.04 |
|                           LowCostLinqWithStructWhereCount |            [5] |    32.75 ns |   0.0074 ns |   0.0066 ns |    32.75 ns |  0.95 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    33.13 ns |   0.0302 ns |   0.0268 ns |    33.14 ns |  0.96 |    0.02 |
|                                               LinqToArray |            [5] |   144.70 ns |   0.1172 ns |   0.1039 ns |   144.70 ns |  4.18 |    0.08 |
|                            LowCostLinqWithDelegateToArray |            [5] |   120.32 ns |   0.0649 ns |   0.0607 ns |   120.32 ns |  3.47 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |   120.44 ns |   2.4343 ns |   2.9895 ns |   118.18 ns |  3.49 |    0.08 |
|                              LowCostLinqWithStructToArray |            [5] |    83.38 ns |   0.0413 ns |   0.0387 ns |    83.38 ns |  2.40 |    0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    86.97 ns |   0.0620 ns |   0.0580 ns |    86.98 ns |  2.51 |    0.05 |
|                                                      Take |            [5] |   163.17 ns |   0.0977 ns |   0.0866 ns |   163.15 ns |  4.71 |    0.09 |
|                                               LowCostTake |            [5] |    67.45 ns |   1.2537 ns |   1.1727 ns |    67.31 ns |  1.94 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [5] |    64.80 ns |   1.2560 ns |   1.3961 ns |    64.69 ns |  1.87 |    0.05 |
|                                     LowCostTakeWithStruct |            [5] |    55.96 ns |   0.0574 ns |   0.0509 ns |    55.97 ns |  1.62 |    0.03 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    52.11 ns |   0.0998 ns |   0.0833 ns |    52.10 ns |  1.51 |    0.03 |
|                                            SkipTakeSingle |            [5] |   153.84 ns |   0.0806 ns |   0.0715 ns |   153.84 ns |  4.44 |    0.08 |
|                                     LowCostSkipTakeSingle |            [5] |    72.62 ns |   0.6290 ns |   0.5884 ns |    72.46 ns |  2.09 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    71.63 ns |   1.2426 ns |   1.1623 ns |    71.62 ns |  2.07 |    0.06 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    56.42 ns |   0.8418 ns |   0.7875 ns |    55.91 ns |  1.63 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    55.98 ns |   0.0136 ns |   0.0127 ns |    55.98 ns |  1.61 |    0.03 |
|                                           ForeachDelegate |            [5] |    53.71 ns |   0.0686 ns |   0.0642 ns |    53.74 ns |  1.55 |    0.03 |
|                                                   Foreach |            [5] |    34.75 ns |   0.7162 ns |   0.7034 ns |    34.23 ns |  1.00 |    0.00 |
