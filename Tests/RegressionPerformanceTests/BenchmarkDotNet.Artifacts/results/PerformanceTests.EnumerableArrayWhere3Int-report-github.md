``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **79.73 ns** |   **0.0288 ns** |   **0.0255 ns** |     **79.73 ns** |  **7.10** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     36.19 ns |   0.0553 ns |   0.0431 ns |     36.19 ns |  3.22 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     36.30 ns |   0.0269 ns |   0.0239 ns |     36.30 ns |  3.23 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     58.41 ns |   0.0164 ns |   0.0146 ns |     58.40 ns |  5.20 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     59.24 ns |   0.0124 ns |   0.0097 ns |     59.24 ns |  5.28 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     48.74 ns |   0.0684 ns |   0.0571 ns |     48.71 ns |  4.34 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     46.88 ns |   0.0069 ns |   0.0065 ns |     46.88 ns |  4.17 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    109.82 ns |   0.0417 ns |   0.0370 ns |    109.81 ns |  9.78 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    108.63 ns |   0.0457 ns |   0.0405 ns |    108.63 ns |  9.67 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     96.63 ns |   0.0412 ns |   0.0386 ns |     96.64 ns |  8.60 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     94.49 ns |   0.0578 ns |   0.0513 ns |     94.49 ns |  8.41 |    0.01 |
|                                                 LinqCount |            [0] |     81.01 ns |   0.0283 ns |   0.0251 ns |     81.02 ns |  7.21 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     35.55 ns |   0.0294 ns |   0.0275 ns |     35.55 ns |  3.17 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     34.93 ns |   0.0340 ns |   0.0318 ns |     34.93 ns |  3.11 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     36.79 ns |   0.0086 ns |   0.0072 ns |     36.79 ns |  3.28 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     37.38 ns |   0.0168 ns |   0.0140 ns |     37.39 ns |  3.33 |    0.00 |
|                                               LinqToArray |            [0] |     92.82 ns |   0.0322 ns |   0.0286 ns |     92.81 ns |  8.26 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     48.30 ns |   0.0269 ns |   0.0252 ns |     48.31 ns |  4.30 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     46.89 ns |   0.0229 ns |   0.0214 ns |     46.89 ns |  4.17 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     46.84 ns |   0.0184 ns |   0.0172 ns |     46.84 ns |  4.17 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     46.79 ns |   0.0074 ns |   0.0057 ns |     46.79 ns |  4.17 |    0.00 |
|                                                      Take |            [0] |    119.87 ns |   0.0628 ns |   0.0557 ns |    119.86 ns | 10.67 |    0.01 |
|                                               LowCostTake |            [0] |     43.87 ns |   0.0140 ns |   0.0117 ns |     43.87 ns |  3.91 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     44.22 ns |   0.0189 ns |   0.0177 ns |     44.22 ns |  3.94 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     54.57 ns |   0.5267 ns |   0.4926 ns |     54.21 ns |  4.86 |    0.05 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     54.58 ns |   0.1524 ns |   0.1425 ns |     54.61 ns |  4.86 |    0.01 |
|                                            SkipTakeSingle |            [0] |    139.57 ns |   0.1142 ns |   0.0954 ns |    139.56 ns | 12.43 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     54.81 ns |   0.5074 ns |   0.4746 ns |     54.79 ns |  4.88 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     54.10 ns |   0.0320 ns |   0.0267 ns |     54.09 ns |  4.82 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     58.49 ns |   0.0091 ns |   0.0085 ns |     58.49 ns |  5.21 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     58.60 ns |   0.0220 ns |   0.0195 ns |     58.60 ns |  5.22 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.95 ns |   0.2631 ns |   0.2461 ns |     15.78 ns |  1.42 |    0.02 |
|                                                   Foreach |            [0] |     11.23 ns |   0.0073 ns |   0.0065 ns |     11.23 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **11,496.33 ns** |  **60.0171 ns** |  **53.2036 ns** | **11,505.78 ns** |  **2.67** |    **0.01** |
|                                   LowCostLinqWithDelegate |         [1000] |  9,455.90 ns | 188.4392 ns | 224.3235 ns |  9,402.09 ns |  2.21 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  9,186.25 ns | 183.5331 ns | 188.4749 ns |  9,166.45 ns |  2.13 |    0.04 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  7,633.97 ns | 120.9580 ns | 107.2262 ns |  7,625.15 ns |  1.77 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,285.06 ns |  78.4938 ns |  69.5827 ns |  8,263.42 ns |  1.92 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,964.43 ns |   1.6888 ns |   1.4102 ns |  1,964.05 ns |  0.46 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,560.54 ns |   1.2244 ns |   1.0854 ns |  1,560.72 ns |  0.36 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 21,755.47 ns | 253.1300 ns | 236.7780 ns | 21,775.53 ns |  5.04 |    0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 21,441.55 ns | 265.2629 ns | 248.1271 ns | 21,431.21 ns |  4.97 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,064.97 ns | 103.2702 ns |  96.5990 ns |  8,989.05 ns |  2.10 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,196.16 ns |   1.9021 ns |   1.5883 ns |  9,195.82 ns |  2.13 |    0.00 |
|                                                 LinqCount |         [1000] |  5,906.33 ns |  25.9524 ns |  24.2758 ns |  5,907.69 ns |  1.37 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,873.30 ns | 130.2450 ns | 115.4588 ns |  7,864.38 ns |  1.83 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,468.67 ns | 148.2573 ns | 197.9193 ns |  7,524.32 ns |  1.75 |    0.04 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,362.48 ns |   0.7121 ns |   0.6661 ns |  1,362.63 ns |  0.32 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,366.29 ns |   0.5020 ns |   0.4450 ns |  1,366.47 ns |  0.32 |    0.00 |
|                                               LinqToArray |         [1000] |  7,887.58 ns |  13.2937 ns |  12.4349 ns |  7,882.77 ns |  1.83 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,257.69 ns | 177.5056 ns | 217.9928 ns |  9,132.68 ns |  2.16 |    0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,309.41 ns |  10.8015 ns |  10.1037 ns |  8,311.41 ns |  1.93 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,456.37 ns |   1.7577 ns |   1.6442 ns |  2,456.37 ns |  0.57 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,454.16 ns |   2.7627 ns |   2.4490 ns |  2,454.95 ns |  0.57 |    0.00 |
|                                                      Take |         [1000] |    419.03 ns |   9.0731 ns |   8.4870 ns |    414.22 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    227.30 ns |   3.3888 ns |   3.1699 ns |    228.39 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    217.38 ns |   3.6668 ns |   3.4299 ns |    217.81 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    105.71 ns |   0.0559 ns |   0.0495 ns |    105.72 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     94.80 ns |   0.0620 ns |   0.0549 ns |     94.79 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    349.39 ns |   0.1509 ns |   0.1412 ns |    349.41 ns |  0.08 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    236.26 ns |   4.5588 ns |   4.2643 ns |    234.39 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    237.04 ns |   2.0722 ns |   1.9384 ns |    237.49 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     83.26 ns |   0.1393 ns |   0.1303 ns |     83.25 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     84.65 ns |   1.0767 ns |   1.0071 ns |     83.87 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,085.83 ns |  15.8255 ns |  14.8032 ns |  8,083.90 ns |  1.87 |    0.00 |
|                                                   Foreach |         [1000] |  4,312.44 ns |   2.4438 ns |   2.1663 ns |  4,311.77 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **659.99 ns** |   **0.4696 ns** |   **0.4163 ns** |    **659.91 ns** |  **2.79** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    523.10 ns |  10.3043 ns |  11.4532 ns |    522.70 ns |  2.20 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    488.53 ns |   7.0725 ns |   6.6157 ns |    486.56 ns |  2.06 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |    450.41 ns |   7.3809 ns |   6.5430 ns |    451.72 ns |  1.90 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    474.08 ns |   4.0084 ns |   3.3472 ns |    475.25 ns |  2.00 |    0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    147.33 ns |   0.1032 ns |   0.0915 ns |    147.30 ns |  0.62 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    129.94 ns |   0.0435 ns |   0.0407 ns |    129.94 ns |  0.55 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,197.60 ns |   2.1874 ns |   1.9391 ns |  1,197.33 ns |  5.06 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,167.42 ns |   1.1944 ns |   1.0588 ns |  1,167.50 ns |  4.93 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    549.87 ns |   0.1746 ns |   0.1633 ns |    549.81 ns |  2.32 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    563.23 ns |   8.2770 ns |   7.7423 ns |    557.57 ns |  2.38 |    0.03 |
|                                                 LinqCount |           [50] |    381.97 ns |   0.2881 ns |   0.2695 ns |    381.95 ns |  1.61 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    431.52 ns |   4.9779 ns |   4.6563 ns |    432.01 ns |  1.82 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    419.29 ns |  10.0988 ns |   9.9184 ns |    414.45 ns |  1.77 |    0.04 |
|                           LowCostLinqWithStructWhereCount |           [50] |     98.09 ns |   0.0515 ns |   0.0482 ns |     98.08 ns |  0.41 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     98.22 ns |   0.0797 ns |   0.0745 ns |     98.20 ns |  0.41 |    0.00 |
|                                               LinqToArray |           [50] |    696.11 ns |   1.0186 ns |   0.8506 ns |    695.99 ns |  2.94 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    598.83 ns |   0.5524 ns |   0.5167 ns |    599.03 ns |  2.53 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    559.35 ns |   0.8300 ns |   0.7358 ns |    559.47 ns |  2.36 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    229.69 ns |   0.9728 ns |   0.9100 ns |    229.76 ns |  0.97 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    232.73 ns |   2.5958 ns |   2.3011 ns |    231.71 ns |  0.98 |    0.01 |
|                                                      Take |           [50] |    414.12 ns |   0.6196 ns |   0.5796 ns |    414.02 ns |  1.75 |    0.00 |
|                                               LowCostTake |           [50] |    223.59 ns |   3.4611 ns |   3.2375 ns |    223.80 ns |  0.94 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    218.01 ns |   4.4604 ns |   4.9577 ns |    216.05 ns |  0.92 |    0.02 |
|                                     LowCostTakeWithStruct |           [50] |    105.88 ns |   0.1713 ns |   0.1602 ns |    105.80 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     94.63 ns |   0.0603 ns |   0.0535 ns |     94.62 ns |  0.40 |    0.00 |
|                                            SkipTakeSingle |           [50] |    349.49 ns |   0.4727 ns |   0.3691 ns |    349.45 ns |  1.48 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    237.99 ns |   4.7216 ns |   5.2481 ns |    239.08 ns |  1.01 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    235.56 ns |   1.3736 ns |   1.0724 ns |    236.04 ns |  1.00 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     83.97 ns |   1.4289 ns |   1.3366 ns |     83.07 ns |  0.35 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     84.37 ns |   0.0758 ns |   0.0672 ns |     84.36 ns |  0.36 |    0.00 |
|                                           ForeachDelegate |           [50] |    430.98 ns |   0.3150 ns |   0.2946 ns |    431.00 ns |  1.82 |    0.00 |
|                                                   Foreach |           [50] |    236.75 ns |   0.2245 ns |   0.1875 ns |    236.71 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **146.74 ns** |   **2.8855 ns** |   **3.3230 ns** |    **144.23 ns** |  **4.25** |    **0.16** |
|                                   LowCostLinqWithDelegate |            [5] |     79.98 ns |   1.3617 ns |   1.2737 ns |     79.90 ns |  2.30 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     75.60 ns |   0.9961 ns |   0.9318 ns |     75.86 ns |  2.18 |    0.04 |
|                                  LowCostLinqWithDelegate2 |            [5] |     97.19 ns |   0.9114 ns |   0.8080 ns |     96.75 ns |  2.79 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     95.27 ns |   1.1944 ns |   1.0588 ns |     95.42 ns |  2.74 |    0.06 |
|                                LowCostLinqWithStructWhere |            [5] |     57.56 ns |   0.1038 ns |   0.0971 ns |     57.53 ns |  1.66 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     56.81 ns |   0.0406 ns |   0.0380 ns |     56.81 ns |  1.63 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    231.69 ns |   3.7344 ns |   3.4932 ns |    229.32 ns |  6.67 |    0.12 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    224.42 ns |   0.1806 ns |   0.1601 ns |    224.40 ns |  6.45 |    0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    142.64 ns |   0.0549 ns |   0.0487 ns |    142.64 ns |  4.10 |    0.07 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    140.45 ns |   0.0922 ns |   0.0720 ns |    140.43 ns |  4.03 |    0.07 |
|                                                 LinqCount |            [5] |    119.61 ns |   0.0679 ns |   0.0602 ns |    119.60 ns |  3.44 |    0.06 |
|                              LowCostLinqWithDelegateCount |            [5] |     71.97 ns |   1.1320 ns |   1.0588 ns |     71.75 ns |  2.07 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     69.68 ns |   1.0288 ns |   0.9623 ns |     69.51 ns |  2.01 |    0.05 |
|                           LowCostLinqWithStructWhereCount |            [5] |     39.87 ns |   0.0075 ns |   0.0058 ns |     39.87 ns |  1.14 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     39.91 ns |   0.0292 ns |   0.0259 ns |     39.92 ns |  1.15 |    0.02 |
|                                               LinqToArray |            [5] |    192.84 ns |   0.0616 ns |   0.0576 ns |    192.82 ns |  5.55 |    0.09 |
|                            LowCostLinqWithDelegateToArray |            [5] |    120.20 ns |   0.0828 ns |   0.0774 ns |    120.20 ns |  3.46 |    0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    115.97 ns |   0.0434 ns |   0.0406 ns |    115.98 ns |  3.34 |    0.06 |
|                              LowCostLinqWithStructToArray |            [5] |     82.06 ns |   0.0274 ns |   0.0243 ns |     82.06 ns |  2.36 |    0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     84.38 ns |   0.0133 ns |   0.0118 ns |     84.38 ns |  2.43 |    0.04 |
|                                                      Take |            [5] |    209.04 ns |   0.3166 ns |   0.2806 ns |    209.12 ns |  6.01 |    0.10 |
|                                               LowCostTake |            [5] |     81.24 ns |   1.5892 ns |   1.7004 ns |     80.63 ns |  2.34 |    0.04 |
|                                  LowCostTakeWithoutChecks |            [5] |     80.54 ns |   1.5196 ns |   1.4214 ns |     80.47 ns |  2.32 |    0.04 |
|                                     LowCostTakeWithStruct |            [5] |     67.75 ns |   0.0481 ns |   0.0376 ns |     67.74 ns |  1.94 |    0.03 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     65.75 ns |   0.1588 ns |   0.1485 ns |     65.77 ns |  1.89 |    0.03 |
|                                            SkipTakeSingle |            [5] |    192.84 ns |   0.0464 ns |   0.0362 ns |    192.85 ns |  5.53 |    0.10 |
|                                     LowCostSkipTakeSingle |            [5] |     91.55 ns |   1.8323 ns |   1.6243 ns |     90.63 ns |  2.63 |    0.07 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     91.67 ns |   0.8931 ns |   0.7917 ns |     91.78 ns |  2.64 |    0.05 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     63.90 ns |   0.6484 ns |   0.6065 ns |     64.18 ns |  1.84 |    0.05 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     65.01 ns |   1.4876 ns |   2.6054 ns |     63.79 ns |  1.88 |    0.09 |
|                                           ForeachDelegate |            [5] |     57.11 ns |   0.0703 ns |   0.0623 ns |     57.09 ns |  1.64 |    0.03 |
|                                                   Foreach |            [5] |     34.76 ns |   0.6304 ns |   0.5897 ns |     34.37 ns |  1.00 |    0.00 |
