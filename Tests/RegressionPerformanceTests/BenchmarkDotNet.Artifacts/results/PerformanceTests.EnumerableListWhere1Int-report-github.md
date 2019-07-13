``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |------------:|-----------:|-----------:|------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **35.98 ns** |  **0.0182 ns** |  **0.0170 ns** |    **35.99 ns** |  **2.15** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |    32.06 ns |  0.0329 ns |  0.0292 ns |    32.06 ns |  1.92 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    23.42 ns |  0.0065 ns |  0.0057 ns |    23.42 ns |  1.40 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |    39.65 ns |  0.5578 ns |  0.5218 ns |    39.57 ns |  2.38 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    30.75 ns |  0.0113 ns |  0.0105 ns |    30.75 ns |  1.84 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |    36.99 ns |  0.0210 ns |  0.0175 ns |    36.99 ns |  2.21 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    28.18 ns |  0.0055 ns |  0.0049 ns |    28.18 ns |  1.68 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    43.87 ns |  0.0186 ns |  0.0174 ns |    43.87 ns |  2.62 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    33.58 ns |  0.0121 ns |  0.0108 ns |    33.58 ns |  2.01 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    46.29 ns |  0.0218 ns |  0.0204 ns |    46.29 ns |  2.77 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    35.03 ns |  0.0229 ns |  0.0191 ns |    35.03 ns |  2.09 |    0.00 |
|                                                 LinqCount |            [0] |    32.53 ns |  0.0386 ns |  0.0361 ns |    32.53 ns |  1.94 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |    34.78 ns |  0.0243 ns |  0.0215 ns |    34.78 ns |  2.08 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    27.58 ns |  0.0104 ns |  0.0093 ns |    27.59 ns |  1.65 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |    30.77 ns |  0.6131 ns |  0.5735 ns |    30.65 ns |  1.84 |    0.04 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    21.88 ns |  0.0093 ns |  0.0082 ns |    21.88 ns |  1.31 |    0.00 |
|                                               LinqToArray |            [0] |    44.97 ns |  0.0174 ns |  0.0154 ns |    44.97 ns |  2.69 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |    47.33 ns |  0.5421 ns |  0.4805 ns |    47.11 ns |  2.82 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    39.28 ns |  0.0106 ns |  0.0094 ns |    39.29 ns |  2.35 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |    40.16 ns |  0.0547 ns |  0.0512 ns |    40.16 ns |  2.40 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    32.23 ns |  0.1905 ns |  0.1782 ns |    32.16 ns |  1.93 |    0.01 |
|                                                      Take |            [0] |    69.74 ns |  1.4086 ns |  1.3834 ns |    69.77 ns |  4.20 |    0.08 |
|                                               LowCostTake |            [0] |    40.64 ns |  0.0377 ns |  0.0353 ns |    40.65 ns |  2.43 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |    32.67 ns |  0.0233 ns |  0.0218 ns |    32.68 ns |  1.95 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |    42.67 ns |  0.0144 ns |  0.0112 ns |    42.67 ns |  2.55 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    36.06 ns |  0.0130 ns |  0.0109 ns |    36.06 ns |  2.16 |    0.00 |
|                                            SkipTakeSingle |            [0] |    92.68 ns |  0.0451 ns |  0.0422 ns |    92.68 ns |  5.54 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |    47.64 ns |  0.0341 ns |  0.0319 ns |    47.64 ns |  2.85 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    45.60 ns |  0.6140 ns |  0.5743 ns |    45.18 ns |  2.72 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    50.07 ns |  0.0069 ns |  0.0064 ns |    50.07 ns |  2.99 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    42.26 ns |  0.0061 ns |  0.0054 ns |    42.26 ns |  2.53 |    0.00 |
|                                           ForeachDelegate |            [0] |    19.09 ns |  0.0092 ns |  0.0082 ns |    19.08 ns |  1.14 |    0.00 |
|                                                   Foreach |            [0] |    16.74 ns |  0.0090 ns |  0.0070 ns |    16.73 ns |  1.00 |    0.00 |
|                                                           |                |             |            |            |             |       |         |
|                                                      **Linq** |         **[1000]** | **6,752.52 ns** |  **5.2117 ns** |  **4.8751 ns** | **6,752.08 ns** |  **1.22** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 5,046.08 ns |  3.0630 ns |  2.8652 ns | 5,045.59 ns |  0.91 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,415.06 ns | 40.0853 ns | 37.4958 ns | 3,391.74 ns |  0.62 |    0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 4,578.40 ns |  3.4879 ns |  3.2626 ns | 4,577.91 ns |  0.83 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,622.14 ns |  0.9523 ns |  0.8908 ns | 3,622.43 ns |  0.66 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] | 2,670.64 ns |  5.9511 ns |  5.5666 ns | 2,670.85 ns |  0.48 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,470.37 ns |  0.7860 ns |  0.6968 ns | 1,470.15 ns |  0.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,753.36 ns |  6.7454 ns |  6.3096 ns | 6,754.12 ns |  1.22 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 6,491.28 ns |  2.4226 ns |  2.2661 ns | 6,491.33 ns |  1.18 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 4,903.83 ns | 77.2814 ns | 72.2891 ns | 4,901.93 ns |  0.89 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,862.70 ns |  1.6298 ns |  1.5245 ns | 3,862.33 ns |  0.70 |    0.00 |
|                                                 LinqCount |         [1000] | 2,025.24 ns |  9.1885 ns |  8.5949 ns | 2,024.28 ns |  0.37 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 2,960.39 ns |  8.2664 ns |  7.3279 ns | 2,961.52 ns |  0.54 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 1,967.94 ns | 27.8884 ns | 26.0868 ns | 1,948.85 ns |  0.36 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] | 1,710.23 ns |  0.4184 ns |  0.3709 ns | 1,710.20 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   622.23 ns |  0.0810 ns |  0.0718 ns |   622.25 ns |  0.11 |    0.00 |
|                                               LinqToArray |         [1000] | 3,199.81 ns |  6.0654 ns |  5.3768 ns | 3,198.29 ns |  0.58 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 4,195.62 ns | 82.0505 ns | 84.2598 ns | 4,138.44 ns |  0.76 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 2,902.17 ns |  1.2737 ns |  0.9944 ns | 2,902.30 ns |  0.53 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] | 3,015.33 ns |  1.3965 ns |  1.2380 ns | 3,015.69 ns |  0.55 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,906.22 ns |  1.3565 ns |  1.2025 ns | 1,906.17 ns |  0.35 |    0.00 |
|                                                      Take |         [1000] |   331.55 ns |  0.1604 ns |  0.1340 ns |   331.56 ns |  0.06 |    0.00 |
|                                               LowCostTake |         [1000] |   145.21 ns |  0.1723 ns |  0.1612 ns |   145.17 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |   114.06 ns |  0.0878 ns |  0.0822 ns |   114.06 ns |  0.02 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |   108.10 ns |  0.0609 ns |  0.0540 ns |   108.10 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    77.71 ns |  0.1034 ns |  0.0807 ns |    77.68 ns |  0.01 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   227.96 ns |  2.3766 ns |  1.8555 ns |   228.08 ns |  0.04 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   136.40 ns |  2.9483 ns |  2.7579 ns |   134.42 ns |  0.02 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   119.09 ns |  0.1506 ns |  0.1409 ns |   119.12 ns |  0.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    92.67 ns |  0.0498 ns |  0.0416 ns |    92.66 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    67.13 ns |  0.5986 ns |  0.5600 ns |    67.37 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] | 6,717.60 ns | 21.6566 ns | 16.9080 ns | 6,712.01 ns |  1.22 |    0.00 |
|                                                   Foreach |         [1000] | 5,522.43 ns |  2.0160 ns |  1.6834 ns | 5,522.94 ns |  1.00 |    0.00 |
|                                                           |                |             |            |            |             |       |         |
|                                                      **Linq** |           **[50]** |   **403.08 ns** |  **0.4422 ns** |  **0.4136 ns** |   **403.00 ns** |  **1.33** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |   286.43 ns |  4.1393 ns |  3.8719 ns |   284.10 ns |  0.94 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   197.46 ns |  0.0869 ns |  0.0813 ns |   197.43 ns |  0.65 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |   273.93 ns |  0.1405 ns |  0.1314 ns |   273.91 ns |  0.90 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   215.87 ns |  0.0905 ns |  0.0847 ns |   215.89 ns |  0.71 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |   175.99 ns |  0.1293 ns |  0.1010 ns |   175.94 ns |  0.58 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   110.10 ns |  0.1315 ns |  0.1230 ns |   110.07 ns |  0.36 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   389.94 ns |  0.1022 ns |  0.0906 ns |   389.93 ns |  1.29 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   364.98 ns |  0.2695 ns |  0.2104 ns |   364.98 ns |  1.20 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   296.76 ns |  0.0827 ns |  0.0733 ns |   296.76 ns |  0.98 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   234.55 ns |  0.0779 ns |  0.0729 ns |   234.55 ns |  0.77 |    0.00 |
|                                                 LinqCount |           [50] |   136.01 ns |  0.0826 ns |  0.0645 ns |   136.02 ns |  0.45 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |   194.69 ns |  0.1247 ns |  0.1167 ns |   194.72 ns |  0.64 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   127.18 ns |  0.0644 ns |  0.0571 ns |   127.16 ns |  0.42 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |   122.86 ns |  0.0674 ns |  0.0597 ns |   122.86 ns |  0.40 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    51.72 ns |  0.0471 ns |  0.0441 ns |    51.72 ns |  0.17 |    0.00 |
|                                               LinqToArray |           [50] |   364.71 ns |  0.1384 ns |  0.1294 ns |   364.70 ns |  1.20 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |   351.18 ns |  0.1021 ns |  0.0955 ns |   351.21 ns |  1.16 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   267.73 ns |  0.1455 ns |  0.1215 ns |   267.75 ns |  0.88 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |   278.12 ns |  5.5682 ns |  5.9579 ns |   276.47 ns |  0.92 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   203.60 ns |  0.3557 ns |  0.3153 ns |   203.62 ns |  0.67 |    0.00 |
|                                                      Take |           [50] |   332.73 ns |  0.1624 ns |  0.1520 ns |   332.76 ns |  1.10 |    0.00 |
|                                               LowCostTake |           [50] |   145.25 ns |  1.5097 ns |  1.3383 ns |   144.62 ns |  0.48 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |   113.77 ns |  0.1778 ns |  0.1664 ns |   113.77 ns |  0.37 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |   107.96 ns |  0.0752 ns |  0.0667 ns |   107.96 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    77.74 ns |  0.0737 ns |  0.0576 ns |    77.73 ns |  0.26 |    0.00 |
|                                            SkipTakeSingle |           [50] |   225.16 ns |  0.0735 ns |  0.0688 ns |   225.15 ns |  0.74 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |   135.05 ns |  0.0755 ns |  0.0706 ns |   135.04 ns |  0.45 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   118.50 ns |  0.1319 ns |  0.1233 ns |   118.55 ns |  0.39 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    93.95 ns |  1.4193 ns |  1.3276 ns |    93.11 ns |  0.31 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    66.46 ns |  0.4124 ns |  0.3858 ns |    66.39 ns |  0.22 |    0.00 |
|                                           ForeachDelegate |           [50] |   364.36 ns |  0.1099 ns |  0.0975 ns |   364.35 ns |  1.20 |    0.00 |
|                                                   Foreach |           [50] |   303.40 ns |  0.0793 ns |  0.0742 ns |   303.42 ns |  1.00 |    0.00 |
|                                                           |                |             |            |            |             |       |         |
|                                                      **Linq** |            **[5]** |    **73.88 ns** |  **1.4532 ns** |  **1.3593 ns** |    **72.73 ns** |  **1.66** |    **0.06** |
|                                   LowCostLinqWithDelegate |            [5] |    55.75 ns |  0.0314 ns |  0.0278 ns |    55.76 ns |  1.25 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    42.61 ns |  0.0497 ns |  0.0465 ns |    42.60 ns |  0.96 |    0.02 |
|                                  LowCostLinqWithDelegate2 |            [5] |    60.20 ns |  0.0543 ns |  0.0481 ns |    60.21 ns |  1.35 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    51.37 ns |  0.0300 ns |  0.0234 ns |    51.37 ns |  1.15 |    0.03 |
|                                LowCostLinqWithStructWhere |            [5] |    50.64 ns |  0.1447 ns |  0.1354 ns |    50.66 ns |  1.14 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    37.79 ns |  0.0685 ns |  0.0607 ns |    37.78 ns |  0.85 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    78.50 ns |  1.5431 ns |  1.9515 ns |    77.30 ns |  1.77 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    67.93 ns |  0.0447 ns |  0.0374 ns |    67.93 ns |  1.52 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    70.47 ns |  0.0810 ns |  0.0758 ns |    70.48 ns |  1.58 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    54.30 ns |  0.0209 ns |  0.0185 ns |    54.29 ns |  1.22 |    0.03 |
|                                                 LinqCount |            [5] |    42.33 ns |  0.0261 ns |  0.0244 ns |    42.33 ns |  0.95 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |    51.88 ns |  0.0879 ns |  0.0779 ns |    51.90 ns |  1.16 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    35.75 ns |  0.0252 ns |  0.0224 ns |    35.74 ns |  0.80 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |    39.14 ns |  0.6053 ns |  0.5662 ns |    39.08 ns |  0.88 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    24.54 ns |  0.0122 ns |  0.0114 ns |    24.54 ns |  0.55 |    0.01 |
|                                               LinqToArray |            [5] |   100.15 ns |  0.0470 ns |  0.0440 ns |   100.16 ns |  2.25 |    0.06 |
|                            LowCostLinqWithDelegateToArray |            [5] |   108.44 ns |  2.1682 ns |  2.4099 ns |   107.01 ns |  2.44 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    95.15 ns |  0.0350 ns |  0.0292 ns |    95.16 ns |  2.13 |    0.06 |
|                              LowCostLinqWithStructToArray |            [5] |    97.89 ns |  0.0465 ns |  0.0412 ns |    97.88 ns |  2.19 |    0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    80.30 ns |  1.6563 ns |  1.7009 ns |    78.86 ns |  1.81 |    0.07 |
|                                                      Take |            [5] |   134.64 ns |  0.1121 ns |  0.1049 ns |   134.65 ns |  3.02 |    0.08 |
|                                               LowCostTake |            [5] |    65.77 ns |  0.1102 ns |  0.0977 ns |    65.74 ns |  1.47 |    0.04 |
|                                  LowCostTakeWithoutChecks |            [5] |    53.30 ns |  0.0253 ns |  0.0211 ns |    53.29 ns |  1.19 |    0.03 |
|                                     LowCostTakeWithStruct |            [5] |    60.01 ns |  1.3106 ns |  1.3459 ns |    59.98 ns |  1.35 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    48.17 ns |  0.0397 ns |  0.0371 ns |    48.16 ns |  1.08 |    0.03 |
|                                            SkipTakeSingle |            [5] |   122.74 ns |  0.0548 ns |  0.0485 ns |   122.72 ns |  2.75 |    0.07 |
|                                     LowCostSkipTakeSingle |            [5] |    65.04 ns |  0.0296 ns |  0.0277 ns |    65.04 ns |  1.46 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    58.02 ns |  0.1192 ns |  0.1115 ns |    58.00 ns |  1.30 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    59.94 ns |  0.0308 ns |  0.0273 ns |    59.94 ns |  1.34 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    46.80 ns |  0.0211 ns |  0.0187 ns |    46.79 ns |  1.05 |    0.03 |
|                                           ForeachDelegate |            [5] |    53.17 ns |  0.0246 ns |  0.0218 ns |    53.17 ns |  1.19 |    0.03 |
|                                                   Foreach |            [5] |    44.33 ns |  0.8884 ns |  1.0575 ns |    43.68 ns |  1.00 |    0.00 |
