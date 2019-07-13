``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **81.94 ns** |   **0.0880 ns** |   **0.0823 ns** |     **81.94 ns** |  **7.27** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     34.87 ns |   0.0076 ns |   0.0067 ns |     34.87 ns |  3.09 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     33.49 ns |   0.0164 ns |   0.0153 ns |     33.50 ns |  2.97 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     58.32 ns |   0.0119 ns |   0.0111 ns |     58.33 ns |  5.17 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     54.75 ns |   0.0111 ns |   0.0092 ns |     54.75 ns |  4.86 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     49.06 ns |   0.0090 ns |   0.0084 ns |     49.06 ns |  4.35 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     44.02 ns |   0.0052 ns |   0.0049 ns |     44.02 ns |  3.90 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     60.10 ns |   0.0364 ns |   0.0341 ns |     60.09 ns |  5.33 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     58.40 ns |   0.0353 ns |   0.0313 ns |     58.40 ns |  5.18 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     49.16 ns |   0.0133 ns |   0.0124 ns |     49.16 ns |  4.36 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     48.74 ns |   0.0273 ns |   0.0242 ns |     48.75 ns |  4.32 |    0.00 |
|                                                 LinqCount |            [0] |     81.90 ns |   0.1245 ns |   0.1165 ns |     81.83 ns |  7.26 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     36.06 ns |   0.0608 ns |   0.0569 ns |     36.03 ns |  3.20 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     35.84 ns |   0.0108 ns |   0.0101 ns |     35.84 ns |  3.18 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.13 ns |   0.0051 ns |   0.0042 ns |     37.13 ns |  3.29 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     37.21 ns |   0.0861 ns |   0.0805 ns |     37.26 ns |  3.30 |    0.01 |
|                                               LinqToArray |            [0] |    102.34 ns |   2.6706 ns |   2.4980 ns |    100.96 ns |  9.09 |    0.23 |
|                            LowCostLinqWithDelegateToArray |            [0] |     45.81 ns |   0.0144 ns |   0.0135 ns |     45.81 ns |  4.06 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     46.65 ns |   0.0088 ns |   0.0082 ns |     46.65 ns |  4.14 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     46.39 ns |   0.0242 ns |   0.0226 ns |     46.39 ns |  4.11 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     46.93 ns |   0.0186 ns |   0.0155 ns |     46.93 ns |  4.16 |    0.00 |
|                                                      Take |            [0] |    118.81 ns |   0.0535 ns |   0.0501 ns |    118.81 ns | 10.54 |    0.00 |
|                                               LowCostTake |            [0] |     43.66 ns |   0.0126 ns |   0.0118 ns |     43.66 ns |  3.87 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     40.29 ns |   0.0098 ns |   0.0092 ns |     40.29 ns |  3.57 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     54.05 ns |   0.0042 ns |   0.0035 ns |     54.05 ns |  4.79 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     50.83 ns |   0.0052 ns |   0.0049 ns |     50.82 ns |  4.51 |    0.00 |
|                                            SkipTakeSingle |            [0] |    140.85 ns |   0.0962 ns |   0.0900 ns |    140.86 ns | 12.49 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     54.20 ns |   0.0250 ns |   0.0234 ns |     54.20 ns |  4.81 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     55.54 ns |   0.0184 ns |   0.0172 ns |     55.54 ns |  4.93 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     60.33 ns |   0.0117 ns |   0.0110 ns |     60.34 ns |  5.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     58.84 ns |   0.0083 ns |   0.0074 ns |     58.84 ns |  5.22 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.09 ns |   0.0136 ns |   0.0128 ns |     15.09 ns |  1.34 |    0.00 |
|                                                   Foreach |            [0] |     11.27 ns |   0.0041 ns |   0.0037 ns |     11.27 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **11,810.79 ns** | **268.3249 ns** | **367.2861 ns** | **11,639.54 ns** |  **2.74** |    **0.10** |
|                                   LowCostLinqWithDelegate |         [1000] |  9,016.72 ns | 193.2334 ns | 569.7531 ns |  8,988.70 ns |  2.06 |    0.13 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,366.96 ns | 203.4060 ns | 596.5547 ns |  8,291.07 ns |  1.89 |    0.16 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,199.11 ns | 235.7354 ns | 322.6773 ns |  9,060.33 ns |  2.15 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  9,414.51 ns |  97.7108 ns |  91.3987 ns |  9,389.47 ns |  2.18 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,285.70 ns |   0.6595 ns |   0.6169 ns |  1,285.69 ns |  0.30 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,313.26 ns |   0.8241 ns |   0.7709 ns |  1,313.47 ns |  0.30 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 18,145.55 ns | 224.3825 ns | 209.8876 ns | 18,097.58 ns |  4.19 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 17,006.17 ns | 335.3983 ns | 646.1986 ns | 16,620.18 ns |  4.04 |    0.18 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  4,367.45 ns |   3.4779 ns |   3.2532 ns |  4,367.33 ns |  1.01 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  4,601.47 ns |   2.0668 ns |   1.9333 ns |  4,602.19 ns |  1.07 |    0.00 |
|                                                 LinqCount |         [1000] |  5,958.79 ns |  27.6514 ns |  25.8652 ns |  5,957.19 ns |  1.38 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,263.19 ns | 180.9480 ns | 530.6890 ns |  8,128.94 ns |  1.91 |    0.15 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,091.29 ns |  50.1685 ns |  41.8930 ns |  7,096.96 ns |  1.64 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    579.46 ns |   0.4124 ns |   0.3858 ns |    579.57 ns |  0.13 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    580.17 ns |   0.0732 ns |   0.0611 ns |    580.16 ns |  0.13 |    0.00 |
|                                               LinqToArray |         [1000] |  7,957.58 ns |  13.3578 ns |  12.4949 ns |  7,957.79 ns |  1.84 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,560.27 ns |   6.2005 ns |   5.7999 ns |  8,559.66 ns |  1.98 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  9,002.86 ns |   9.2860 ns |   7.7542 ns |  9,002.75 ns |  2.08 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,926.15 ns |   0.5241 ns |   0.4646 ns |  1,926.20 ns |  0.45 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,952.39 ns |   6.2485 ns |   5.8449 ns |  1,954.15 ns |  0.45 |    0.00 |
|                                                      Take |         [1000] |    416.75 ns |   0.5797 ns |   0.5422 ns |    416.76 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    356.75 ns |   4.5955 ns |   4.2987 ns |    357.70 ns |  0.08 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    216.84 ns |   4.2364 ns |   6.2096 ns |    213.51 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     94.53 ns |   0.0205 ns |   0.0182 ns |     94.53 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     82.14 ns |   0.0194 ns |   0.0181 ns |     82.15 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    354.95 ns |   0.5354 ns |   0.5008 ns |    355.00 ns |  0.08 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    251.12 ns |   6.2650 ns |   5.2316 ns |    249.46 ns |  0.06 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    275.02 ns |   6.1180 ns |  18.0391 ns |    268.82 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     84.07 ns |   0.0338 ns |   0.0316 ns |     84.06 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     84.36 ns |   0.0160 ns |   0.0134 ns |     84.36 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,120.97 ns |   5.9159 ns |   5.5338 ns |  8,119.39 ns |  1.88 |    0.00 |
|                                                   Foreach |         [1000] |  4,319.27 ns |   0.9759 ns |   0.8149 ns |  4,319.16 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **669.43 ns** |   **2.4044 ns** |   **2.2491 ns** |    **669.12 ns** |  **2.81** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    715.99 ns |  12.8290 ns |  12.0002 ns |    718.76 ns |  3.00 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    444.07 ns |   9.2207 ns |  26.1577 ns |    433.43 ns |  1.88 |    0.12 |
|                                  LowCostLinqWithDelegate2 |           [50] |    512.75 ns |   2.0506 ns |   1.9182 ns |    513.19 ns |  2.15 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    732.90 ns |   9.4388 ns |   8.8290 ns |    732.86 ns |  3.07 |    0.04 |
|                                LowCostLinqWithStructWhere |           [50] |    114.60 ns |   0.0238 ns |   0.0211 ns |    114.60 ns |  0.48 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    113.27 ns |   0.0286 ns |   0.0267 ns |    113.27 ns |  0.48 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    924.80 ns |  17.5987 ns |  16.4619 ns |    914.97 ns |  3.88 |    0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    899.25 ns |   9.7441 ns |   9.1147 ns |    895.12 ns |  3.77 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    271.33 ns |   0.0859 ns |   0.0804 ns |    271.34 ns |  1.14 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    282.70 ns |   0.0906 ns |   0.0848 ns |    282.68 ns |  1.19 |    0.00 |
|                                                 LinqCount |           [50] |    390.61 ns |   1.0465 ns |   0.9789 ns |    390.75 ns |  1.64 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    466.01 ns |  10.2672 ns |  28.6208 ns |    470.27 ns |  1.96 |    0.13 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    427.99 ns |  10.3071 ns |  28.9022 ns |    424.01 ns |  1.78 |    0.11 |
|                           LowCostLinqWithStructWhereCount |           [50] |     64.57 ns |   0.0170 ns |   0.0151 ns |     64.56 ns |  0.27 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     64.52 ns |   0.0175 ns |   0.0155 ns |     64.52 ns |  0.27 |    0.00 |
|                                               LinqToArray |           [50] |    697.74 ns |   0.5185 ns |   0.4850 ns |    697.69 ns |  2.93 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    582.67 ns |   0.9563 ns |   0.8477 ns |    582.82 ns |  2.44 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    600.60 ns |   1.2684 ns |   1.1865 ns |    600.17 ns |  2.52 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    216.00 ns |   0.1378 ns |   0.1289 ns |    215.98 ns |  0.91 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    219.72 ns |   0.2439 ns |   0.2162 ns |    219.76 ns |  0.92 |    0.00 |
|                                                      Take |           [50] |    428.71 ns |   0.9980 ns |   0.9336 ns |    428.46 ns |  1.80 |    0.00 |
|                                               LowCostTake |           [50] |    239.83 ns |   4.8029 ns |  12.8198 ns |    238.00 ns |  0.99 |    0.04 |
|                                  LowCostTakeWithoutChecks |           [50] |    226.98 ns |   1.3988 ns |   1.3085 ns |    227.21 ns |  0.95 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |     96.32 ns |   0.0162 ns |   0.0127 ns |     96.33 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     84.21 ns |   0.0198 ns |   0.0185 ns |     84.21 ns |  0.35 |    0.00 |
|                                            SkipTakeSingle |           [50] |    383.43 ns |   0.4325 ns |   0.4045 ns |    383.41 ns |  1.61 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    265.52 ns |   5.3167 ns |  14.1913 ns |    258.16 ns |  1.11 |    0.07 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    272.43 ns |   5.7444 ns |  16.9375 ns |    262.28 ns |  1.13 |    0.07 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     84.06 ns |   0.0260 ns |   0.0231 ns |     84.07 ns |  0.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     84.35 ns |   0.0103 ns |   0.0091 ns |     84.35 ns |  0.35 |    0.00 |
|                                           ForeachDelegate |           [50] |    431.22 ns |   0.2747 ns |   0.2569 ns |    431.16 ns |  1.81 |    0.00 |
|                                                   Foreach |           [50] |    238.42 ns |   0.1405 ns |   0.1314 ns |    238.47 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **144.52 ns** |   **0.0863 ns** |   **0.0721 ns** |    **144.51 ns** |  **4.21** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    105.81 ns |   1.3239 ns |   1.2383 ns |    105.72 ns |  3.08 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     74.19 ns |   1.6509 ns |   4.7632 ns |     72.87 ns |  2.17 |    0.15 |
|                                  LowCostLinqWithDelegate2 |            [5] |    111.26 ns |   2.2310 ns |   6.5078 ns |    109.76 ns |  3.19 |    0.18 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    124.10 ns |   2.4929 ns |   5.7776 ns |    125.45 ns |  3.67 |    0.08 |
|                                LowCostLinqWithStructWhere |            [5] |     54.14 ns |   0.0140 ns |   0.0131 ns |     54.14 ns |  1.58 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     49.47 ns |   0.0076 ns |   0.0067 ns |     49.47 ns |  1.44 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    145.80 ns |   0.3560 ns |   0.3330 ns |    145.86 ns |  4.25 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    142.01 ns |   0.2474 ns |   0.2193 ns |    141.94 ns |  4.14 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     66.80 ns |   0.0742 ns |   0.0620 ns |     66.81 ns |  1.95 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     67.07 ns |   0.0770 ns |   0.0721 ns |     67.03 ns |  1.96 |    0.00 |
|                                                 LinqCount |            [5] |    154.37 ns |   0.1739 ns |   0.1627 ns |    154.37 ns |  4.50 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     75.82 ns |   1.5321 ns |   3.3949 ns |     76.07 ns |  2.17 |    0.10 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     70.49 ns |   0.3187 ns |   0.2488 ns |     70.41 ns |  2.05 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     39.72 ns |   0.0060 ns |   0.0050 ns |     39.72 ns |  1.16 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     39.72 ns |   0.0059 ns |   0.0055 ns |     39.72 ns |  1.16 |    0.00 |
|                                               LinqToArray |            [5] |    202.39 ns |   0.0990 ns |   0.0926 ns |    202.39 ns |  5.90 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    128.69 ns |   0.2209 ns |   0.2066 ns |    128.71 ns |  3.75 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    129.60 ns |   0.1930 ns |   0.1805 ns |    129.58 ns |  3.78 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     92.13 ns |   0.0534 ns |   0.0417 ns |     92.14 ns |  2.69 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     92.40 ns |   0.0550 ns |   0.0487 ns |     92.41 ns |  2.69 |    0.00 |
|                                                      Take |            [5] |    209.90 ns |   0.1445 ns |   0.1352 ns |    209.91 ns |  6.12 |    0.00 |
|                                               LowCostTake |            [5] |    110.49 ns |   1.5750 ns |   1.4733 ns |    110.38 ns |  3.22 |    0.04 |
|                                  LowCostTakeWithoutChecks |            [5] |     84.15 ns |   1.7053 ns |   4.5222 ns |     83.77 ns |  2.41 |    0.13 |
|                                     LowCostTakeWithStruct |            [5] |     64.49 ns |   0.1460 ns |   0.1366 ns |     64.42 ns |  1.88 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     62.16 ns |   0.0288 ns |   0.0269 ns |     62.16 ns |  1.81 |    0.00 |
|                                            SkipTakeSingle |            [5] |    194.28 ns |   0.0617 ns |   0.0577 ns |    194.28 ns |  5.66 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    100.80 ns |   2.0324 ns |   4.2871 ns |    100.18 ns |  2.94 |    0.15 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     96.36 ns |   1.8600 ns |   1.9101 ns |     95.56 ns |  2.82 |    0.06 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     63.63 ns |   0.0258 ns |   0.0241 ns |     63.63 ns |  1.85 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     63.94 ns |   0.0278 ns |   0.0246 ns |     63.94 ns |  1.86 |    0.00 |
|                                           ForeachDelegate |            [5] |     57.19 ns |   0.0367 ns |   0.0343 ns |     57.20 ns |  1.67 |    0.00 |
|                                                   Foreach |            [5] |     34.31 ns |   0.0204 ns |   0.0181 ns |     34.31 ns |  1.00 |    0.00 |
