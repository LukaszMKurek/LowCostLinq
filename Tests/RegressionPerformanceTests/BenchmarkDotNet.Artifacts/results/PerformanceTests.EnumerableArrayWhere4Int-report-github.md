``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **114.07 ns** |   **0.0763 ns** |     **0.0676 ns** |    **114.06 ns** | **10.16** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     43.73 ns |   0.0099 ns |     0.0088 ns |     43.73 ns |  3.90 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     41.74 ns |   0.0070 ns |     0.0065 ns |     41.74 ns |  3.72 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     70.35 ns |   0.1602 ns |     0.1499 ns |     70.44 ns |  6.27 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     66.28 ns |   0.0157 ns |     0.0147 ns |     66.28 ns |  5.90 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     54.88 ns |   0.0060 ns |     0.0057 ns |     54.88 ns |  4.89 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     51.50 ns |   0.0141 ns |     0.0132 ns |     51.50 ns |  4.59 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     67.02 ns |   0.0520 ns |     0.0461 ns |     67.00 ns |  5.97 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     66.38 ns |   0.0278 ns |     0.0232 ns |     66.37 ns |  5.91 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     63.35 ns |   0.0285 ns |     0.0266 ns |     63.35 ns |  5.64 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     61.65 ns |   0.0206 ns |     0.0193 ns |     61.65 ns |  5.49 |    0.00 |
|                                                 LinqCount |            [0] |    113.97 ns |   0.0519 ns |     0.0485 ns |    113.95 ns | 10.15 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     42.00 ns |   0.0209 ns |     0.0185 ns |     42.00 ns |  3.74 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     41.85 ns |   0.0052 ns |     0.0049 ns |     41.85 ns |  3.73 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     45.95 ns |   0.0132 ns |     0.0123 ns |     45.94 ns |  4.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     46.11 ns |   0.0093 ns |     0.0083 ns |     46.11 ns |  4.11 |    0.00 |
|                                               LinqToArray |            [0] |    126.05 ns |   0.0418 ns |     0.0391 ns |    126.04 ns | 11.23 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     50.22 ns |   0.0144 ns |     0.0135 ns |     50.22 ns |  4.47 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     50.66 ns |   0.0260 ns |     0.0244 ns |     50.66 ns |  4.51 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     53.97 ns |   0.0178 ns |     0.0166 ns |     53.97 ns |  4.81 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     55.66 ns |   0.0319 ns |     0.0298 ns |     55.64 ns |  4.96 |    0.00 |
|                                                      Take |            [0] |    146.44 ns |   0.0492 ns |     0.0460 ns |    146.44 ns | 13.04 |    0.01 |
|                                               LowCostTake |            [0] |     56.57 ns |   0.0174 ns |     0.0162 ns |     56.58 ns |  5.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     55.05 ns |   0.0140 ns |     0.0124 ns |     55.05 ns |  4.90 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     66.71 ns |   0.0172 ns |     0.0152 ns |     66.71 ns |  5.94 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     65.83 ns |   0.0131 ns |     0.0122 ns |     65.84 ns |  5.86 |    0.00 |
|                                            SkipTakeSingle |            [0] |    171.06 ns |   0.0620 ns |     0.0580 ns |    171.07 ns | 15.24 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     76.89 ns |   0.2186 ns |     0.2044 ns |     76.76 ns |  6.85 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     76.39 ns |   0.0167 ns |     0.0148 ns |     76.39 ns |  6.80 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     79.13 ns |   0.0161 ns |     0.0150 ns |     79.12 ns |  7.05 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     79.11 ns |   0.0276 ns |     0.0258 ns |     79.10 ns |  7.05 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.11 ns |   0.0094 ns |     0.0084 ns |     15.11 ns |  1.35 |    0.00 |
|                                                   Foreach |            [0] |     11.23 ns |   0.0017 ns |     0.0016 ns |     11.23 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **13,277.55 ns** | **270.4970 ns** |   **404.8671 ns** | **13,097.74 ns** |  **3.10** |    **0.11** |
|                                   LowCostLinqWithDelegate |         [1000] | 12,306.82 ns | 614.2009 ns |   630.7391 ns | 11,957.80 ns |  2.86 |    0.15 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 15,147.14 ns | 427.5148 ns | 1,260.5371 ns | 15,654.23 ns |  3.56 |    0.23 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,668.20 ns | 102.8223 ns |    96.1801 ns | 11,691.44 ns |  2.70 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 10,992.79 ns | 256.9366 ns |   716.2365 ns | 10,947.91 ns |  2.51 |    0.17 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,497.09 ns |   0.1843 ns |     0.1724 ns |  1,497.05 ns |  0.35 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,320.74 ns |   0.2051 ns |     0.1918 ns |  1,320.81 ns |  0.31 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,457.27 ns | 138.5414 ns |   129.5918 ns | 19,447.67 ns |  4.50 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,341.60 ns | 382.7217 ns |   680.2874 ns | 19,135.93 ns |  4.49 |    0.17 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,899.19 ns |   1.6517 ns |     1.5450 ns |  3,899.43 ns |  0.90 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,894.03 ns |   1.6718 ns |     1.4820 ns |  3,894.21 ns |  0.90 |    0.00 |
|                                                 LinqCount |         [1000] |  9,076.90 ns | 186.9966 ns |   268.1850 ns |  8,944.02 ns |  2.10 |    0.06 |
|                              LowCostLinqWithDelegateCount |         [1000] |  9,598.10 ns | 189.6755 ns |   168.1424 ns |  9,515.95 ns |  2.22 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,790.69 ns | 214.1840 ns |   579.0588 ns | 10,719.52 ns |  2.48 |    0.14 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    589.42 ns |   0.1153 ns |     0.1079 ns |    589.42 ns |  0.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    588.69 ns |   0.1061 ns |     0.0941 ns |    588.66 ns |  0.14 |    0.00 |
|                                               LinqToArray |         [1000] | 10,890.72 ns |  21.8938 ns |    20.4795 ns | 10,894.15 ns |  2.52 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 10,890.55 ns |  20.0639 ns |    18.7678 ns | 10,894.77 ns |  2.52 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,998.53 ns |  34.9586 ns |    32.7003 ns | 11,989.72 ns |  2.78 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,827.32 ns |   1.2119 ns |     1.0743 ns |  1,827.30 ns |  0.42 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,947.68 ns |   2.2529 ns |     2.1074 ns |  1,948.51 ns |  0.45 |    0.00 |
|                                                      Take |         [1000] |    512.07 ns |   0.7665 ns |     0.7170 ns |    512.11 ns |  0.12 |    0.00 |
|                                               LowCostTake |         [1000] |    320.36 ns |   6.4244 ns |    18.7403 ns |    309.89 ns |  0.07 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    297.81 ns |   6.9077 ns |    20.1500 ns |    294.34 ns |  0.07 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    105.48 ns |   0.0138 ns |     0.0115 ns |    105.48 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     97.90 ns |   0.0327 ns |     0.0290 ns |     97.90 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    422.17 ns |   0.3225 ns |     0.2859 ns |    422.20 ns |  0.10 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    361.16 ns |  14.3898 ns |    20.6374 ns |    349.75 ns |  0.08 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    336.50 ns |   6.7840 ns |    20.0027 ns |    324.82 ns |  0.08 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    141.83 ns |   0.0544 ns |     0.0509 ns |    141.82 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    141.91 ns |   0.0335 ns |     0.0297 ns |    141.91 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,618.80 ns |   2.1397 ns |     2.0015 ns |  9,618.18 ns |  2.23 |    0.00 |
|                                                   Foreach |         [1000] |  4,319.46 ns |   1.4008 ns |     1.3103 ns |  4,319.07 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **769.48 ns** |   **0.9335 ns** |     **0.7795 ns** |    **769.75 ns** |  **3.25** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    938.30 ns |  11.0948 ns |    10.3781 ns |    941.36 ns |  3.96 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    655.76 ns |  16.7328 ns |    47.1951 ns |    648.04 ns |  2.77 |    0.20 |
|                                  LowCostLinqWithDelegate2 |           [50] |    694.85 ns |  18.0444 ns |    51.7726 ns |    676.58 ns |  2.89 |    0.18 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    841.18 ns |  36.6477 ns |   108.0566 ns |    892.76 ns |  3.77 |    0.11 |
|                                LowCostLinqWithStructWhere |           [50] |    128.39 ns |   0.0575 ns |     0.0510 ns |    128.41 ns |  0.54 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    119.64 ns |   0.0269 ns |     0.0225 ns |    119.64 ns |  0.50 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,025.88 ns |   2.6349 ns |     2.4647 ns |  1,025.84 ns |  4.33 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,029.89 ns |  10.6863 ns |     9.9960 ns |  1,032.79 ns |  4.35 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    259.71 ns |   0.0814 ns |     0.0762 ns |    259.71 ns |  1.10 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    259.90 ns |   0.1640 ns |     0.1534 ns |    259.89 ns |  1.10 |    0.00 |
|                                                 LinqCount |           [50] |    565.85 ns |   2.7334 ns |     2.5568 ns |    566.59 ns |  2.39 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    560.58 ns |  11.2108 ns |    27.9189 ns |    552.60 ns |  2.32 |    0.11 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    722.68 ns |  28.4635 ns |    83.9252 ns |    765.39 ns |  3.16 |    0.30 |
|                           LowCostLinqWithStructWhereCount |           [50] |     74.07 ns |   0.0227 ns |     0.0212 ns |     74.07 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     73.75 ns |   0.1021 ns |     0.0955 ns |     73.76 ns |  0.31 |    0.00 |
|                                               LinqToArray |           [50] |    868.24 ns |   1.1206 ns |     0.9934 ns |    868.29 ns |  3.66 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    718.56 ns |   0.9399 ns |     0.7338 ns |    718.43 ns |  3.03 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    808.20 ns |   2.2075 ns |     2.0649 ns |    807.85 ns |  3.41 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    216.26 ns |   0.0974 ns |     0.0911 ns |    216.29 ns |  0.91 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    232.59 ns |   0.1816 ns |     0.1699 ns |    232.64 ns |  0.98 |    0.00 |
|                                                      Take |           [50] |    511.56 ns |   0.9667 ns |     0.9042 ns |    511.48 ns |  2.16 |    0.00 |
|                                               LowCostTake |           [50] |    432.38 ns |   8.6638 ns |     8.1041 ns |    433.13 ns |  1.82 |    0.03 |
|                                  LowCostTakeWithoutChecks |           [50] |    306.39 ns |   8.2319 ns |    24.2720 ns |    306.20 ns |  1.24 |    0.08 |
|                                     LowCostTakeWithStruct |           [50] |    106.08 ns |   0.0423 ns |     0.0396 ns |    106.10 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    100.30 ns |   0.0122 ns |     0.0114 ns |    100.30 ns |  0.42 |    0.00 |
|                                            SkipTakeSingle |           [50] |    425.98 ns |   1.0619 ns |     0.9933 ns |    426.33 ns |  1.80 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    381.53 ns |   8.3631 ns |    24.2629 ns |    378.62 ns |  1.55 |    0.09 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    343.70 ns |   7.4189 ns |    21.6413 ns |    334.57 ns |  1.45 |    0.09 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    144.26 ns |   0.3127 ns |     0.2925 ns |    144.31 ns |  0.61 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    141.91 ns |   0.0404 ns |     0.0358 ns |    141.92 ns |  0.60 |    0.00 |
|                                           ForeachDelegate |           [50] |    506.68 ns |   0.2408 ns |     0.2252 ns |    506.69 ns |  2.14 |    0.00 |
|                                                   Foreach |           [50] |    237.03 ns |   0.0632 ns |     0.0591 ns |    237.03 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **187.40 ns** |   **0.3971 ns** |     **0.3714 ns** |    **187.50 ns** |  **5.45** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    105.65 ns |   2.2275 ns |     3.0491 ns |    104.22 ns |  3.08 |    0.09 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    141.06 ns |   2.7433 ns |     2.5661 ns |    140.71 ns |  4.10 |    0.07 |
|                                  LowCostLinqWithDelegate2 |            [5] |    135.58 ns |   3.1310 ns |     9.1825 ns |    134.15 ns |  3.83 |    0.23 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    129.41 ns |   2.6095 ns |     5.6172 ns |    125.92 ns |  3.76 |    0.16 |
|                                LowCostLinqWithStructWhere |            [5] |     62.50 ns |   0.0585 ns |     0.0547 ns |     62.49 ns |  1.82 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     57.19 ns |   0.0229 ns |     0.0191 ns |     57.18 ns |  1.66 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    163.81 ns |   0.2718 ns |     0.2410 ns |    163.80 ns |  4.76 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    164.35 ns |   0.1663 ns |     0.1556 ns |    164.36 ns |  4.78 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     77.45 ns |   0.0384 ns |     0.0340 ns |     77.46 ns |  2.25 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     78.46 ns |   0.0741 ns |     0.0694 ns |     78.45 ns |  2.28 |    0.00 |
|                                                 LinqCount |            [5] |    166.42 ns |   0.6595 ns |     0.5846 ns |    166.53 ns |  4.84 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |     95.97 ns |   1.9324 ns |     5.5445 ns |     95.87 ns |  2.76 |    0.17 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     94.05 ns |   0.5084 ns |     0.4507 ns |     94.10 ns |  2.73 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     49.19 ns |   0.0095 ns |     0.0084 ns |     49.19 ns |  1.43 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     48.24 ns |   0.0075 ns |     0.0070 ns |     48.24 ns |  1.40 |    0.00 |
|                                               LinqToArray |            [5] |    239.09 ns |   0.2941 ns |     0.2751 ns |    239.03 ns |  6.95 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    145.31 ns |   0.2115 ns |     0.1978 ns |    145.25 ns |  4.23 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    150.01 ns |   0.2428 ns |     0.2271 ns |    149.90 ns |  4.36 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    100.00 ns |   0.0398 ns |     0.0353 ns |    100.01 ns |  2.91 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    102.31 ns |   0.0277 ns |     0.0231 ns |    102.31 ns |  2.98 |    0.00 |
|                                                      Take |            [5] |    259.31 ns |   0.1876 ns |     0.1755 ns |    259.31 ns |  7.54 |    0.01 |
|                                               LowCostTake |            [5] |    133.39 ns |   0.9222 ns |     0.8175 ns |    133.27 ns |  3.88 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [5] |    101.58 ns |   2.0486 ns |     3.9957 ns |     98.83 ns |  2.96 |    0.13 |
|                                     LowCostTakeWithStruct |            [5] |     77.74 ns |   0.0114 ns |     0.0107 ns |     77.74 ns |  2.26 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     73.61 ns |   0.0143 ns |     0.0134 ns |     73.61 ns |  2.14 |    0.00 |
|                                            SkipTakeSingle |            [5] |    240.81 ns |   0.1431 ns |     0.1339 ns |    240.83 ns |  7.00 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    145.09 ns |   2.9288 ns |     6.9605 ns |    140.55 ns |  4.23 |    0.18 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    133.97 ns |   0.2727 ns |     0.2418 ns |    133.92 ns |  3.90 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     91.07 ns |   0.0170 ns |     0.0150 ns |     91.06 ns |  2.65 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     91.53 ns |   0.0239 ns |     0.0224 ns |     91.53 ns |  2.66 |    0.00 |
|                                           ForeachDelegate |            [5] |     66.16 ns |   0.0554 ns |     0.0518 ns |     66.18 ns |  1.92 |    0.00 |
|                                                   Foreach |            [5] |     34.39 ns |   0.0153 ns |     0.0143 ns |     34.39 ns |  1.00 |    0.00 |
