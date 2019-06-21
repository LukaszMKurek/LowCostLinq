``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **80.63 ns** |   **0.0250 ns** |   **0.0222 ns** |     **80.63 ns** |  **4.49** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     51.66 ns |   0.0855 ns |   0.0800 ns |     51.65 ns |  2.88 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     45.67 ns |   0.0201 ns |   0.0168 ns |     45.66 ns |  2.54 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     58.04 ns |   0.0202 ns |   0.0189 ns |     58.03 ns |  3.23 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     59.78 ns |   0.0316 ns |   0.0264 ns |     59.77 ns |  3.33 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     53.62 ns |   0.0318 ns |   0.0249 ns |     53.62 ns |  2.99 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     50.49 ns |   0.0238 ns |   0.0185 ns |     50.50 ns |  2.81 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    120.69 ns |   0.0275 ns |   0.0229 ns |    120.69 ns |  6.72 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    112.14 ns |   0.0325 ns |   0.0288 ns |    112.14 ns |  6.25 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    107.33 ns |   0.0442 ns |   0.0345 ns |    107.34 ns |  5.98 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     98.68 ns |   0.0450 ns |   0.0421 ns |     98.67 ns |  5.50 |    0.00 |
|                                                 LinqCount |            [0] |     83.11 ns |   0.0401 ns |   0.0375 ns |     83.10 ns |  4.63 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     49.04 ns |   0.9932 ns |   0.9755 ns |     48.37 ns |  2.74 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     47.92 ns |   0.0315 ns |   0.0279 ns |     47.91 ns |  2.67 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     41.92 ns |   0.0194 ns |   0.0172 ns |     41.91 ns |  2.33 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     42.46 ns |   0.5083 ns |   0.4245 ns |     42.30 ns |  2.36 |    0.02 |
|                                               LinqToArray |            [0] |     96.03 ns |   0.0289 ns |   0.0270 ns |     96.04 ns |  5.35 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     62.70 ns |   0.0295 ns |   0.0261 ns |     62.70 ns |  3.49 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     63.23 ns |   0.0206 ns |   0.0193 ns |     63.23 ns |  3.52 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     53.82 ns |   0.9597 ns |   0.8977 ns |     53.22 ns |  3.00 |    0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     53.15 ns |   0.0146 ns |   0.0129 ns |     53.15 ns |  2.96 |    0.00 |
|                                                      Take |            [0] |    117.21 ns |   0.0629 ns |   0.0588 ns |    117.22 ns |  6.53 |    0.00 |
|                                               LowCostTake |            [0] |     52.50 ns |   0.0376 ns |   0.0314 ns |     52.50 ns |  2.92 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     52.41 ns |   0.0207 ns |   0.0194 ns |     52.41 ns |  2.92 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     59.89 ns |   0.0242 ns |   0.0214 ns |     59.88 ns |  3.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     58.44 ns |   0.7555 ns |   0.7067 ns |     57.95 ns |  3.26 |    0.04 |
|                                            SkipTakeSingle |            [0] |    138.80 ns |   0.0446 ns |   0.0417 ns |    138.81 ns |  7.73 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     63.10 ns |   0.1089 ns |   0.1019 ns |     63.13 ns |  3.51 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     64.56 ns |   0.0183 ns |   0.0171 ns |     64.56 ns |  3.60 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     64.57 ns |   1.3771 ns |   1.2882 ns |     63.82 ns |  3.59 |    0.07 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     65.35 ns |   0.0462 ns |   0.0361 ns |     65.35 ns |  3.64 |    0.00 |
|                                           ForeachDelegate |            [0] |     21.14 ns |   0.0088 ns |   0.0083 ns |     21.14 ns |  1.18 |    0.00 |
|                                                   Foreach |            [0] |     17.96 ns |   0.0047 ns |   0.0041 ns |     17.96 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **14,410.10 ns** | **205.8483 ns** | **192.5506 ns** | **14,294.37 ns** |  **2.61** |    **0.04** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,126.48 ns | 134.4080 ns | 125.7253 ns | 11,126.82 ns |  2.02 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,955.26 ns | 107.2275 ns | 100.3007 ns | 10,944.29 ns |  1.99 |    0.02 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 12,349.19 ns | 236.8777 ns | 272.7887 ns | 12,349.03 ns |  2.22 |    0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 10,967.87 ns | 111.7700 ns | 104.5497 ns | 10,917.50 ns |  1.99 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,124.57 ns |  90.1189 ns |  84.2973 ns |  7,131.91 ns |  1.29 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,278.06 ns |  15.5318 ns |  14.5284 ns |  6,286.82 ns |  1.14 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 24,567.96 ns | 181.7064 ns | 169.9683 ns | 24,571.56 ns |  4.45 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 24,816.97 ns | 105.6946 ns |  93.6955 ns | 24,806.83 ns |  4.50 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 13,265.64 ns |   5.4626 ns |   5.1098 ns | 13,263.87 ns |  2.40 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 13,777.21 ns |  16.5216 ns |  15.4543 ns | 13,779.67 ns |  2.50 |    0.00 |
|                                                 LinqCount |         [1000] |  8,925.64 ns |   5.3811 ns |   5.0335 ns |  8,926.41 ns |  1.62 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,395.20 ns |  89.3537 ns |  83.5816 ns | 10,399.14 ns |  1.88 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,936.37 ns | 212.5616 ns | 208.7639 ns | 10,927.33 ns |  1.98 |    0.04 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,037.10 ns |   8.2681 ns |   7.7340 ns |  6,038.86 ns |  1.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,542.43 ns |   1.9569 ns |   1.8305 ns |  5,542.66 ns |  1.00 |    0.00 |
|                                               LinqToArray |         [1000] | 10,974.87 ns |   8.3594 ns |   7.8194 ns | 10,976.41 ns |  1.99 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 10,755.12 ns | 214.7355 ns | 238.6779 ns | 10,596.41 ns |  1.96 |    0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 12,005.54 ns |  19.1388 ns |  17.9025 ns | 12,013.13 ns |  2.18 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,530.41 ns |   6.7158 ns |   6.2819 ns |  7,529.87 ns |  1.36 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,599.74 ns | 116.3061 ns | 108.7928 ns |  7,525.33 ns |  1.38 |    0.02 |
|                                                      Take |         [1000] |    517.28 ns |   1.4205 ns |   1.3287 ns |    517.57 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |    285.77 ns |   0.3746 ns |   0.3504 ns |    285.65 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    253.53 ns |   0.2349 ns |   0.2198 ns |    253.57 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    210.55 ns |   2.4668 ns |   2.3074 ns |    208.78 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    203.69 ns |   0.3522 ns |   0.3294 ns |    203.80 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    400.19 ns |   0.0725 ns |   0.0643 ns |    400.18 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    305.71 ns |   0.1939 ns |   0.1719 ns |    305.72 ns |  0.06 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    304.86 ns |   0.2584 ns |   0.2417 ns |    304.89 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    205.73 ns |   0.0695 ns |   0.0650 ns |    205.70 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    202.88 ns |   0.1184 ns |   0.1108 ns |    202.89 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,780.54 ns | 144.2237 ns | 134.9069 ns |  8,682.11 ns |  1.59 |    0.02 |
|                                                   Foreach |         [1000] |  5,516.47 ns |   0.5773 ns |   0.5117 ns |  5,516.32 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **801.21 ns** |   **0.3102 ns** |   **0.2902 ns** |    **801.29 ns** |  **2.62** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    600.25 ns |   0.8890 ns |   0.8316 ns |    600.27 ns |  1.96 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    616.53 ns |   0.8094 ns |   0.7571 ns |    616.40 ns |  2.01 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    637.13 ns |   1.2260 ns |   1.1468 ns |    636.76 ns |  2.08 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    602.73 ns |   0.9980 ns |   0.8847 ns |    602.64 ns |  1.97 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    416.78 ns |   4.6823 ns |   4.3798 ns |    414.11 ns |  1.36 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    364.74 ns |   0.0837 ns |   0.0783 ns |    364.75 ns |  1.19 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,342.25 ns |   0.6769 ns |   0.6001 ns |  1,342.03 ns |  4.39 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,366.62 ns |   1.0100 ns |   0.8434 ns |  1,366.80 ns |  4.46 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    796.16 ns |  13.6846 ns |  12.8005 ns |    785.69 ns |  2.60 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    797.95 ns |   0.1143 ns |   0.1013 ns |    797.97 ns |  2.61 |    0.00 |
|                                                 LinqCount |           [50] |    542.83 ns |   0.1554 ns |   0.1454 ns |    542.75 ns |  1.77 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    564.85 ns |   0.7648 ns |   0.7154 ns |    564.71 ns |  1.85 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    587.12 ns |  11.0832 ns |  10.3672 ns |    588.60 ns |  1.92 |    0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |    347.63 ns |   0.0722 ns |   0.0676 ns |    347.62 ns |  1.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    324.21 ns |   0.0325 ns |   0.0288 ns |    324.21 ns |  1.06 |    0.00 |
|                                               LinqToArray |           [50] |    858.96 ns |   1.4006 ns |   1.3101 ns |    859.19 ns |  2.81 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    735.53 ns |   0.3685 ns |   0.3447 ns |    735.62 ns |  2.40 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    777.30 ns |   0.4443 ns |   0.4156 ns |    777.38 ns |  2.54 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    536.55 ns |   0.4385 ns |   0.4102 ns |    536.67 ns |  1.75 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    545.39 ns |   3.6697 ns |   3.0644 ns |    544.38 ns |  1.78 |    0.01 |
|                                                      Take |           [50] |    513.43 ns |   0.1241 ns |   0.1036 ns |    513.42 ns |  1.68 |    0.00 |
|                                               LowCostTake |           [50] |    285.30 ns |   0.3438 ns |   0.3215 ns |    285.35 ns |  0.93 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    257.78 ns |   0.2739 ns |   0.2562 ns |    257.73 ns |  0.84 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    208.80 ns |   0.1420 ns |   0.1328 ns |    208.79 ns |  0.68 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    203.02 ns |   0.1307 ns |   0.1222 ns |    202.96 ns |  0.66 |    0.00 |
|                                            SkipTakeSingle |           [50] |    401.26 ns |   0.0636 ns |   0.0595 ns |    401.26 ns |  1.31 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    305.30 ns |   0.3767 ns |   0.3339 ns |    305.30 ns |  1.00 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    309.89 ns |   6.1284 ns |   7.2954 ns |    305.07 ns |  1.02 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    204.32 ns |   0.0677 ns |   0.0633 ns |    204.31 ns |  0.67 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    203.38 ns |   0.0785 ns |   0.0734 ns |    203.38 ns |  0.66 |    0.00 |
|                                           ForeachDelegate |           [50] |    462.61 ns |   0.1282 ns |   0.1001 ns |    462.63 ns |  1.51 |    0.00 |
|                                                   Foreach |           [50] |    306.02 ns |   0.5271 ns |   0.4930 ns |    306.14 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **157.13 ns** |   **0.0368 ns** |   **0.0327 ns** |    **157.13 ns** |  **3.48** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    114.96 ns |   1.9739 ns |   1.8463 ns |    113.70 ns |  2.56 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    108.44 ns |   0.0348 ns |   0.0308 ns |    108.43 ns |  2.40 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    118.61 ns |   0.0551 ns |   0.0488 ns |    118.62 ns |  2.63 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    120.47 ns |   0.0454 ns |   0.0425 ns |    120.49 ns |  2.67 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     86.17 ns |   1.4934 ns |   1.3969 ns |     85.88 ns |  1.92 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     77.10 ns |   0.0542 ns |   0.0481 ns |     77.10 ns |  1.71 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    256.11 ns |   0.3931 ns |   0.3677 ns |    256.20 ns |  5.68 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    253.11 ns |   0.1801 ns |   0.1685 ns |    253.12 ns |  5.61 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    189.06 ns |   3.6684 ns |   3.6028 ns |    186.56 ns |  4.21 |    0.08 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    179.19 ns |   0.0329 ns |   0.0307 ns |    179.18 ns |  3.97 |    0.00 |
|                                                 LinqCount |            [5] |    132.52 ns |   0.0629 ns |   0.0588 ns |    132.52 ns |  2.94 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    100.20 ns |   0.0464 ns |   0.0388 ns |    100.20 ns |  2.22 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    101.67 ns |   0.0523 ns |   0.0489 ns |    101.69 ns |  2.25 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     71.69 ns |   0.0364 ns |   0.0341 ns |     71.69 ns |  1.59 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     68.75 ns |   0.0577 ns |   0.0511 ns |     68.76 ns |  1.52 |    0.00 |
|                                               LinqToArray |            [5] |    211.52 ns |   4.2359 ns |   4.1602 ns |    208.58 ns |  4.71 |    0.10 |
|                            LowCostLinqWithDelegateToArray |            [5] |    149.42 ns |   0.0506 ns |   0.0449 ns |    149.43 ns |  3.31 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    151.36 ns |   0.0601 ns |   0.0533 ns |    151.36 ns |  3.36 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    121.26 ns |   0.0478 ns |   0.0447 ns |    121.26 ns |  2.69 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    120.96 ns |   2.4338 ns |   2.8973 ns |    119.13 ns |  2.72 |    0.06 |
|                                                      Take |            [5] |    235.37 ns |   0.1369 ns |   0.1144 ns |    235.34 ns |  5.22 |    0.00 |
|                                               LowCostTake |            [5] |    121.15 ns |   0.0692 ns |   0.0647 ns |    121.12 ns |  2.69 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    107.81 ns |   1.9209 ns |   1.7968 ns |    106.52 ns |  2.40 |    0.04 |
|                                     LowCostTakeWithStruct |            [5] |     89.71 ns |   0.1045 ns |   0.0977 ns |     89.74 ns |  1.99 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     88.08 ns |   0.0464 ns |   0.0434 ns |     88.07 ns |  1.95 |    0.00 |
|                                            SkipTakeSingle |            [5] |    217.55 ns |   4.1694 ns |   4.0949 ns |    214.59 ns |  4.84 |    0.10 |
|                                     LowCostSkipTakeSingle |            [5] |    115.76 ns |   0.0356 ns |   0.0315 ns |    115.77 ns |  2.57 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    115.95 ns |   0.0652 ns |   0.0578 ns |    115.94 ns |  2.57 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     93.13 ns |   1.2674 ns |   1.1855 ns |     92.49 ns |  2.07 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     92.55 ns |   0.0467 ns |   0.0414 ns |     92.56 ns |  2.05 |    0.00 |
|                                           ForeachDelegate |            [5] |     64.50 ns |   0.1529 ns |   0.1430 ns |     64.43 ns |  1.43 |    0.00 |
|                                                   Foreach |            [5] |     45.11 ns |   0.0316 ns |   0.0247 ns |     45.12 ns |  1.00 |    0.00 |
