``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **20.59 ns** |   **0.0284 ns** |   **0.0252 ns** |     **20.58 ns** |  **1.84** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     31.76 ns |   0.4454 ns |   0.4166 ns |     31.45 ns |  2.82 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     30.29 ns |   0.0042 ns |   0.0035 ns |     30.29 ns |  2.70 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     38.82 ns |   0.0243 ns |   0.0227 ns |     38.83 ns |  3.46 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     41.21 ns |   0.2903 ns |   0.2715 ns |     41.01 ns |  3.67 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |     37.11 ns |   0.0183 ns |   0.0153 ns |     37.12 ns |  3.31 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     33.32 ns |   0.0117 ns |   0.0092 ns |     33.32 ns |  2.97 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     79.83 ns |   0.0518 ns |   0.0484 ns |     79.81 ns |  7.12 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     75.82 ns |   0.0277 ns |   0.0245 ns |     75.82 ns |  6.77 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     81.48 ns |   0.0143 ns |   0.0127 ns |     81.48 ns |  7.27 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     76.86 ns |   0.0333 ns |   0.0295 ns |     76.86 ns |  6.86 |    0.00 |
|                                                 LinqCount |            [0] |     25.71 ns |   0.1144 ns |   0.1070 ns |     25.72 ns |  2.30 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     22.96 ns |   0.0544 ns |   0.0509 ns |     22.96 ns |  2.05 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     22.68 ns |   0.2380 ns |   0.2226 ns |     22.57 ns |  2.03 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     22.11 ns |   0.0094 ns |   0.0088 ns |     22.11 ns |  1.97 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     25.08 ns |   0.0011 ns |   0.0009 ns |     25.08 ns |  2.24 |    0.00 |
|                                               LinqToArray |            [0] |     21.79 ns |   0.3377 ns |   0.3159 ns |     21.58 ns |  1.95 |    0.03 |
|                            LowCostLinqWithDelegateToArray |            [0] |     34.58 ns |   0.0302 ns |   0.0267 ns |     34.58 ns |  3.09 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     34.19 ns |   0.0175 ns |   0.0163 ns |     34.19 ns |  3.05 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     31.65 ns |   0.0104 ns |   0.0087 ns |     31.65 ns |  2.82 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     31.65 ns |   0.0824 ns |   0.0643 ns |     31.63 ns |  2.82 |    0.01 |
|                                                      Take |            [0] |     24.07 ns |   0.0774 ns |   0.0724 ns |     24.06 ns |  2.15 |    0.01 |
|                                               LowCostTake |            [0] |     39.12 ns |   0.0051 ns |   0.0045 ns |     39.12 ns |  3.49 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     40.63 ns |   0.3879 ns |   0.3628 ns |     40.38 ns |  3.62 |    0.03 |
|                                     LowCostTakeWithStruct |            [0] |     41.24 ns |   0.0126 ns |   0.0118 ns |     41.24 ns |  3.68 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     44.95 ns |   0.0082 ns |   0.0073 ns |     44.95 ns |  4.01 |    0.00 |
|                                            SkipTakeSingle |            [0] |     37.62 ns |   0.0377 ns |   0.0315 ns |     37.61 ns |  3.36 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     40.56 ns |   0.4020 ns |   0.3761 ns |     40.32 ns |  3.62 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     40.36 ns |   0.0030 ns |   0.0027 ns |     40.36 ns |  3.60 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     42.47 ns |   0.0068 ns |   0.0057 ns |     42.47 ns |  3.79 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     42.64 ns |   0.3548 ns |   0.3319 ns |     42.45 ns |  3.80 |    0.02 |
|                                           ForeachDelegate |            [0] |     13.45 ns |   0.0176 ns |   0.0156 ns |     13.45 ns |  1.20 |    0.00 |
|                                                   Foreach |            [0] |     11.21 ns |   0.0065 ns |   0.0055 ns |     11.21 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** |  **5,766.44 ns** |   **1.1137 ns** |   **1.0418 ns** |  **5,766.49 ns** |  **1.34** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  3,613.86 ns |   2.1904 ns |   1.8290 ns |  3,612.98 ns |  0.84 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  3,611.12 ns |   2.2961 ns |   2.1477 ns |  3,610.95 ns |  0.84 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  3,867.11 ns |  27.1237 ns |  24.0444 ns |  3,865.00 ns |  0.90 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  3,849.81 ns |  49.4951 ns |  46.2978 ns |  3,819.90 ns |  0.89 |    0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,039.73 ns |  35.0675 ns |  32.8022 ns |  2,034.09 ns |  0.47 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,547.93 ns |   1.1339 ns |   1.0607 ns |  1,548.18 ns |  0.36 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 10,402.47 ns |  17.3663 ns |  16.2445 ns | 10,397.78 ns |  2.41 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 10,254.62 ns | 121.4946 ns | 107.7018 ns | 10,234.32 ns |  2.38 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  7,997.02 ns |  12.6546 ns |  11.8371 ns |  7,993.60 ns |  1.85 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,232.13 ns |   2.2518 ns |   1.9961 ns |  8,232.23 ns |  1.91 |    0.00 |
|                                                 LinqCount |         [1000] |  1,474.86 ns |   2.2811 ns |   2.1338 ns |  1,475.69 ns |  0.34 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  2,679.19 ns |  34.8091 ns |  32.5604 ns |  2,665.14 ns |  0.62 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  2,412.17 ns |   0.4115 ns |   0.3849 ns |  2,412.11 ns |  0.56 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,345.89 ns |   0.9623 ns |   0.8036 ns |  1,345.48 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,345.75 ns |   1.0120 ns |   0.8971 ns |  1,345.25 ns |  0.31 |    0.00 |
|                                               LinqToArray |         [1000] |  2,904.53 ns |   7.0778 ns |   5.5259 ns |  2,902.57 ns |  0.67 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  4,086.90 ns |   6.8903 ns |   6.4452 ns |  4,086.92 ns |  0.95 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  3,898.36 ns |  18.2247 ns |  17.0474 ns |  3,905.67 ns |  0.90 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,423.06 ns |   5.0870 ns |   4.7584 ns |  2,421.17 ns |  0.56 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,467.32 ns |  47.8754 ns |  53.2134 ns |  2,429.17 ns |  0.57 |    0.01 |
|                                                      Take |         [1000] |    292.85 ns |   0.1094 ns |   0.0970 ns |    292.80 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    131.38 ns |   0.2111 ns |   0.1974 ns |    131.36 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    121.42 ns |   0.0711 ns |   0.0594 ns |    121.45 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     97.45 ns |   1.1546 ns |   1.0801 ns |     96.70 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     83.46 ns |   0.0355 ns |   0.0332 ns |     83.45 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    183.70 ns |   0.0320 ns |   0.0299 ns |    183.70 ns |  0.04 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |     98.58 ns |   0.3400 ns |   0.2839 ns |     98.68 ns |  0.02 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    102.45 ns |   0.0239 ns |   0.0223 ns |    102.45 ns |  0.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     62.90 ns |   0.2548 ns |   0.2383 ns |     62.93 ns |  0.01 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     62.49 ns |   0.1038 ns |   0.0867 ns |     62.50 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] |  5,567.87 ns |  65.8242 ns |  61.5720 ns |  5,539.54 ns |  1.29 |    0.01 |
|                                                   Foreach |         [1000] |  4,312.94 ns |   2.0896 ns |   1.9546 ns |  4,313.69 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **327.66 ns** |   **0.0576 ns** |   **0.0511 ns** |    **327.67 ns** |  **1.39** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    212.15 ns |   0.1233 ns |   0.1153 ns |    212.15 ns |  0.90 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    213.89 ns |   0.0694 ns |   0.0649 ns |    213.89 ns |  0.90 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    233.20 ns |   0.5543 ns |   0.5185 ns |    233.38 ns |  0.99 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    233.70 ns |   2.3909 ns |   2.2364 ns |    232.08 ns |  0.99 |    0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    140.10 ns |   0.5819 ns |   0.5443 ns |    140.01 ns |  0.59 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    119.63 ns |   0.0749 ns |   0.0585 ns |    119.63 ns |  0.51 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    618.74 ns |   0.1647 ns |   0.1540 ns |    618.71 ns |  2.62 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    597.10 ns |   0.1838 ns |   0.1719 ns |    597.09 ns |  2.53 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    492.92 ns |   3.5336 ns |   2.9507 ns |    491.73 ns |  2.09 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    490.71 ns |   0.1046 ns |   0.0927 ns |    490.72 ns |  2.08 |    0.00 |
|                                                 LinqCount |           [50] |    108.67 ns |   0.0606 ns |   0.0566 ns |    108.67 ns |  0.46 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    158.99 ns |   0.2181 ns |   0.2040 ns |    158.95 ns |  0.67 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    148.23 ns |   2.1404 ns |   2.0021 ns |    147.04 ns |  0.63 |    0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |     76.53 ns |   0.1042 ns |   0.0974 ns |     76.53 ns |  0.32 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     76.07 ns |   0.0752 ns |   0.0703 ns |     76.08 ns |  0.32 |    0.00 |
|                                               LinqToArray |           [50] |    356.16 ns |   0.0968 ns |   0.0858 ns |    356.15 ns |  1.51 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    315.65 ns |   0.3605 ns |   0.3010 ns |    315.56 ns |  1.34 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    306.89 ns |   0.1044 ns |   0.0976 ns |    306.86 ns |  1.30 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    220.79 ns |   0.1661 ns |   0.1554 ns |    220.84 ns |  0.93 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    220.19 ns |   5.1403 ns |   5.0484 ns |    218.62 ns |  0.93 |    0.02 |
|                                                      Take |           [50] |    294.71 ns |   1.0636 ns |   0.9949 ns |    294.98 ns |  1.25 |    0.00 |
|                                               LowCostTake |           [50] |    132.67 ns |   0.1636 ns |   0.1278 ns |    132.68 ns |  0.56 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    120.87 ns |   0.1162 ns |   0.1030 ns |    120.83 ns |  0.51 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |     95.48 ns |   0.0640 ns |   0.0598 ns |     95.47 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     84.38 ns |   0.1267 ns |   0.1058 ns |     84.41 ns |  0.36 |    0.00 |
|                                            SkipTakeSingle |           [50] |    183.61 ns |   0.0501 ns |   0.0468 ns |    183.60 ns |  0.78 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |     98.94 ns |   0.8590 ns |   0.7615 ns |     98.49 ns |  0.42 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    102.26 ns |   0.0096 ns |   0.0085 ns |    102.26 ns |  0.43 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     63.73 ns |   0.0828 ns |   0.0734 ns |     63.71 ns |  0.27 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     62.61 ns |   0.2260 ns |   0.2114 ns |     62.58 ns |  0.26 |    0.00 |
|                                           ForeachDelegate |           [50] |    308.09 ns |   5.4922 ns |   5.1374 ns |    308.79 ns |  1.31 |    0.02 |
|                                                   Foreach |           [50] |    236.40 ns |   0.0456 ns |   0.0381 ns |    236.40 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |     **59.92 ns** |   **0.0660 ns** |   **0.0617 ns** |     **59.94 ns** |  **1.74** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     50.45 ns |   0.0566 ns |   0.0442 ns |     50.46 ns |  1.46 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     49.11 ns |   0.0105 ns |   0.0098 ns |     49.11 ns |  1.43 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     57.80 ns |   0.0124 ns |   0.0104 ns |     57.80 ns |  1.68 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     60.36 ns |   0.0217 ns |   0.0169 ns |     60.35 ns |  1.75 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     47.68 ns |   0.4457 ns |   0.4169 ns |     47.40 ns |  1.38 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     44.21 ns |   0.0405 ns |   0.0338 ns |     44.22 ns |  1.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    139.22 ns |   0.0479 ns |   0.0425 ns |    139.22 ns |  4.04 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    130.71 ns |   0.2329 ns |   0.2178 ns |    130.59 ns |  3.79 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    126.86 ns |   2.1537 ns |   2.0146 ns |    125.55 ns |  3.69 |    0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    118.57 ns |   0.0883 ns |   0.0783 ns |    118.57 ns |  3.44 |    0.01 |
|                                                 LinqCount |            [5] |     38.86 ns |   0.0211 ns |   0.0187 ns |     38.86 ns |  1.13 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     35.99 ns |   0.0573 ns |   0.0536 ns |     35.98 ns |  1.04 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     34.95 ns |   0.4437 ns |   0.4151 ns |     34.71 ns |  1.02 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     24.92 ns |   0.0515 ns |   0.0481 ns |     24.89 ns |  0.72 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     26.11 ns |   0.0047 ns |   0.0042 ns |     26.10 ns |  0.76 |    0.00 |
|                                               LinqToArray |            [5] |     99.65 ns |   1.7205 ns |   1.5252 ns |     98.59 ns |  2.90 |    0.05 |
|                            LowCostLinqWithDelegateToArray |            [5] |     81.46 ns |   0.1228 ns |   0.1089 ns |     81.48 ns |  2.36 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     82.73 ns |   0.0249 ns |   0.0233 ns |     82.73 ns |  2.40 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     69.23 ns |   0.0289 ns |   0.0270 ns |     69.22 ns |  2.01 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     69.64 ns |   1.2815 ns |   1.1987 ns |     68.95 ns |  2.02 |    0.03 |
|                                                      Take |            [5] |    123.63 ns |   0.1271 ns |   0.1189 ns |    123.65 ns |  3.59 |    0.01 |
|                                               LowCostTake |            [5] |     59.93 ns |   0.0225 ns |   0.0211 ns |     59.93 ns |  1.74 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     62.03 ns |   0.0330 ns |   0.0276 ns |     62.03 ns |  1.80 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     57.21 ns |   0.5761 ns |   0.5389 ns |     56.89 ns |  1.66 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     54.15 ns |   0.0655 ns |   0.0613 ns |     54.16 ns |  1.57 |    0.00 |
|                                            SkipTakeSingle |            [5] |    112.36 ns |   0.0095 ns |   0.0088 ns |    112.36 ns |  3.26 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     52.36 ns |   0.5036 ns |   0.4711 ns |     51.99 ns |  1.52 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     51.47 ns |   0.0050 ns |   0.0047 ns |     51.47 ns |  1.49 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     46.48 ns |   0.0089 ns |   0.0084 ns |     46.48 ns |  1.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.91 ns |   0.4918 ns |   0.4600 ns |     46.53 ns |  1.36 |    0.01 |
|                                           ForeachDelegate |            [5] |     44.49 ns |   0.1450 ns |   0.1211 ns |     44.49 ns |  1.29 |    0.00 |
|                                                   Foreach |            [5] |     34.45 ns |   0.0814 ns |   0.0680 ns |     34.43 ns |  1.00 |    0.00 |
