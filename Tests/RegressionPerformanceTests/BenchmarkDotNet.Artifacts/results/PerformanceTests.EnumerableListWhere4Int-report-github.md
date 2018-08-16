``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |    **108.97 ns** |   **0.0384 ns** |   **0.0359 ns** |    **108.95 ns** |   **7.23** |     **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |     45.67 ns |   0.0086 ns |   0.0071 ns |     45.67 ns |   3.03 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     45.43 ns |   0.0165 ns |   0.0154 ns |     45.43 ns |   3.01 |     0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     73.62 ns |   0.7822 ns |   0.7317 ns |     73.65 ns |   4.88 |     0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     69.41 ns |   0.0030 ns |   0.0028 ns |     69.41 ns |   4.60 |     0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     57.49 ns |   0.0025 ns |   0.0021 ns |     57.49 ns |   3.81 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     53.16 ns |   0.0033 ns |   0.0029 ns |     53.16 ns |   3.53 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    109.84 ns |   0.0242 ns |   0.0202 ns |    109.83 ns |   7.29 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    105.56 ns |   0.0422 ns |   0.0374 ns |    105.55 ns |   7.00 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     97.04 ns |   0.2246 ns |   0.2101 ns |     97.11 ns |   6.44 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     92.65 ns |   0.0551 ns |   0.0515 ns |     92.64 ns |   6.15 |     0.02 |
|                                                 LinqCount |            [0] |    106.99 ns |   0.0304 ns |   0.0284 ns |    106.99 ns |   7.10 |     0.02 |
|                              LowCostLinqWithDelegateCount |            [0] |     43.15 ns |   0.0165 ns |   0.0146 ns |     43.15 ns |   2.86 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     41.73 ns |   0.8365 ns |   0.7825 ns |     41.35 ns |   2.77 |     0.05 |
|                           LowCostLinqWithStructWhereCount |            [0] |     52.80 ns |   0.0022 ns |   0.0020 ns |     52.80 ns |   3.50 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     44.90 ns |   0.0137 ns |   0.0115 ns |     44.91 ns |   2.98 |     0.01 |
|                                               LinqToArray |            [0] |    131.71 ns |   2.1639 ns |   2.0241 ns |    132.43 ns |   8.74 |     0.13 |
|                            LowCostLinqWithDelegateToArray |            [0] |     52.28 ns |   0.0354 ns |   0.0331 ns |     52.28 ns |   3.47 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     50.11 ns |   0.0150 ns |   0.0133 ns |     50.11 ns |   3.32 |     0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     62.01 ns |   0.9952 ns |   0.9310 ns |     62.06 ns |   4.11 |     0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     53.44 ns |   0.0167 ns |   0.0156 ns |     53.44 ns |   3.55 |     0.01 |
|                                                      Take |            [0] |    143.99 ns |   0.0332 ns |   0.0311 ns |    143.99 ns |   9.55 |     0.03 |
|                                               LowCostTake |            [0] |     57.97 ns |   0.4829 ns |   0.4517 ns |     57.64 ns |   3.85 |     0.03 |
|                                  LowCostTakeWithoutChecks |            [0] |     56.80 ns |   0.3555 ns |   0.3152 ns |     56.71 ns |   3.77 |     0.02 |
|                                     LowCostTakeWithStruct |            [0] |     70.84 ns |   0.2926 ns |   0.2737 ns |     70.73 ns |   4.70 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     75.12 ns |   0.3025 ns |   0.2830 ns |     75.17 ns |   4.98 |     0.02 |
|                                            SkipTakeSingle |            [0] |    168.08 ns |   1.4227 ns |   1.1881 ns |    168.01 ns |  11.15 |     0.08 |
|                                     LowCostSkipTakeSingle |            [0] |     77.77 ns |   0.4048 ns |   0.3787 ns |     77.85 ns |   5.16 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     77.69 ns |   0.3056 ns |   0.2858 ns |     77.74 ns |   5.15 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     84.14 ns |   0.1777 ns |   0.1388 ns |     84.14 ns |   5.58 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     78.13 ns |   0.0914 ns |   0.0810 ns |     78.11 ns |   5.18 |     0.02 |
|                                           ForeachDelegate |            [0] |     20.28 ns |   0.1502 ns |   0.1405 ns |     20.28 ns |   1.35 |     0.01 |
|                                                   Foreach |            [0] |     15.07 ns |   0.0530 ns |   0.0470 ns |     15.06 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **14,618.58 ns** | **394.2070 ns** | **453.9693 ns** | **14,388.55 ns** |   **2.76** |     **0.08** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,490.26 ns |  81.6526 ns |  76.3779 ns | 11,477.78 ns |   2.17 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 11,058.55 ns |  52.6661 ns |  49.2639 ns | 11,060.31 ns |   2.09 |     0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 12,864.12 ns | 253.6547 ns | 338.6217 ns | 12,722.37 ns |   2.43 |     0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 11,283.33 ns | 114.9929 ns | 107.5644 ns | 11,243.81 ns |   2.13 |     0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,718.87 ns |  16.8216 ns |  14.0468 ns |  2,716.71 ns |   0.51 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,794.36 ns |  36.6118 ns |  42.1622 ns |  1,776.60 ns |   0.34 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 25,457.99 ns | 172.6043 ns | 161.4542 ns | 25,423.67 ns |   4.81 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 23,929.05 ns | 201.5998 ns | 188.5766 ns | 23,926.46 ns |   4.52 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,511.87 ns | 225.4349 ns | 344.2629 ns |  9,336.94 ns |   1.80 |     0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,758.66 ns |  36.1266 ns |  33.7929 ns |  8,740.92 ns |   1.65 |     0.01 |
|                                                 LinqCount |         [1000] |  8,922.34 ns |  31.5668 ns |  29.5276 ns |  8,932.63 ns |   1.69 |     0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  9,990.63 ns |  88.3877 ns |  82.6779 ns | 10,017.12 ns |   1.89 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  9,905.07 ns | 182.9490 ns | 171.1305 ns |  9,853.98 ns |   1.87 |     0.03 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,792.78 ns |   3.5867 ns |   2.9950 ns |  1,793.21 ns |   0.34 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,239.42 ns |   2.6145 ns |   2.3177 ns |  1,238.95 ns |   0.23 |     0.00 |
|                                               LinqToArray |         [1000] | 10,218.33 ns | 210.6594 ns | 295.3150 ns | 10,118.29 ns |   1.93 |     0.06 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 12,286.08 ns | 142.6519 ns | 133.4366 ns | 12,244.09 ns |   2.32 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 12,319.81 ns |  58.1544 ns |  54.3977 ns | 12,312.83 ns |   2.33 |     0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,349.12 ns |  42.3698 ns |  33.0795 ns |  3,346.27 ns |   0.63 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,406.32 ns |  24.4266 ns |  22.8486 ns |  2,395.15 ns |   0.45 |     0.00 |
|                                                      Take |         [1000] |    543.27 ns |   4.2793 ns |   3.7935 ns |    542.46 ns |   0.10 |     0.00 |
|                                               LowCostTake |         [1000] |    332.17 ns |   2.0051 ns |   1.8756 ns |    332.42 ns |   0.06 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    283.56 ns |   1.0149 ns |   0.8475 ns |    283.12 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    139.09 ns |   0.4680 ns |   0.4149 ns |    139.09 ns |   0.03 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    115.49 ns |   0.4820 ns |   0.4509 ns |    115.52 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    469.31 ns |   3.9576 ns |   3.7020 ns |    469.68 ns |   0.09 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    386.05 ns |   2.9213 ns |   2.7326 ns |    386.02 ns |   0.07 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    334.81 ns |   1.9852 ns |   1.8569 ns |    335.21 ns |   0.06 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    168.47 ns |   3.3910 ns |   4.0368 ns |    165.80 ns |   0.03 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    147.72 ns |   0.4111 ns |   0.3433 ns |    147.64 ns |   0.03 |     0.00 |
|                                           ForeachDelegate |         [1000] | 10,527.22 ns |  32.2040 ns |  30.1236 ns | 10,525.22 ns |   1.99 |     0.01 |
|                                                   Foreach |         [1000] |  5,292.35 ns |  24.9640 ns |  23.3514 ns |  5,286.86 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **846.69 ns** |   **4.0536 ns** |   **3.7917 ns** |    **846.92 ns** |   **2.91** |     **0.02** |
|                                   LowCostLinqWithDelegate |           [50] |    624.86 ns |   1.9721 ns |   1.5397 ns |    624.57 ns |   2.15 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    594.80 ns |   6.1925 ns |   5.7925 ns |    595.49 ns |   2.05 |     0.02 |
|                                  LowCostLinqWithDelegate2 |           [50] |    732.57 ns |  14.4552 ns |  17.2079 ns |    724.61 ns |   2.52 |     0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    638.32 ns |   1.8529 ns |   1.7332 ns |    637.77 ns |   2.20 |     0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    192.91 ns |   0.2644 ns |   0.2344 ns |    192.87 ns |   0.66 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    146.56 ns |   2.8596 ns |   3.7183 ns |    144.45 ns |   0.50 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,400.71 ns |   9.4638 ns |   8.8524 ns |  1,401.43 ns |   4.82 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,307.80 ns |   4.0147 ns |   3.7553 ns |  1,308.18 ns |   4.50 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    569.33 ns |   1.0973 ns |   1.0264 ns |    569.06 ns |   1.96 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    541.22 ns |   2.5754 ns |   2.0107 ns |    540.36 ns |   1.86 |     0.01 |
|                                                 LinqCount |           [50] |    565.73 ns |   3.6686 ns |   3.4316 ns |    565.24 ns |   1.95 |     0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    552.59 ns |   1.3468 ns |   1.2598 ns |    552.80 ns |   1.90 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    524.83 ns |   1.1981 ns |   1.1207 ns |    524.94 ns |   1.81 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |    151.93 ns |   3.1505 ns |   4.6180 ns |    149.49 ns |   0.52 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    100.58 ns |   0.1568 ns |   0.1390 ns |    100.55 ns |   0.35 |     0.00 |
|                                               LinqToArray |           [50] |    854.08 ns |  11.0335 ns |  10.3207 ns |    857.91 ns |   2.94 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           [50] |    803.57 ns |  17.6582 ns |  23.5732 ns |    791.96 ns |   2.77 |     0.08 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    789.53 ns |   5.6598 ns |   5.2942 ns |    789.07 ns |   2.72 |     0.02 |
|                              LowCostLinqWithStructToArray |           [50] |    286.95 ns |   4.4736 ns |   4.1847 ns |    284.42 ns |   0.99 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    244.40 ns |   6.8030 ns |   9.9717 ns |    240.24 ns |   0.84 |     0.03 |
|                                                      Take |           [50] |    541.79 ns |   4.3075 ns |   4.0292 ns |    541.63 ns |   1.86 |     0.02 |
|                                               LowCostTake |           [50] |    333.85 ns |   0.8849 ns |   0.8278 ns |    333.71 ns |   1.15 |     0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    288.79 ns |   2.6377 ns |   2.4673 ns |    289.14 ns |   0.99 |     0.01 |
|                                     LowCostTakeWithStruct |           [50] |    139.71 ns |   1.0356 ns |   0.8086 ns |    139.65 ns |   0.48 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    118.42 ns |   0.6048 ns |   0.5658 ns |    118.56 ns |   0.41 |     0.00 |
|                                            SkipTakeSingle |           [50] |    469.33 ns |   2.7539 ns |   2.4412 ns |    469.49 ns |   1.62 |     0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    383.75 ns |   7.5466 ns |   7.7498 ns |    378.72 ns |   1.32 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    335.94 ns |   1.5649 ns |   1.4638 ns |    335.80 ns |   1.16 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    166.79 ns |   0.6155 ns |   0.5456 ns |    166.89 ns |   0.57 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    150.79 ns |   1.6526 ns |   1.5459 ns |    150.76 ns |   0.52 |     0.01 |
|                                           ForeachDelegate |           [50] |    568.70 ns |   9.8787 ns |   8.7572 ns |    565.44 ns |   1.96 |     0.03 |
|                                                   Foreach |           [50] |    290.58 ns |   1.4145 ns |   1.2539 ns |    290.27 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |    **194.52 ns** |   **0.0871 ns** |   **0.0772 ns** |    **194.50 ns** |   **4.77** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    104.65 ns |   1.8866 ns |   1.7648 ns |    103.40 ns |   2.57 |     0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     99.34 ns |   0.1523 ns |   0.1425 ns |     99.31 ns |   2.44 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    139.60 ns |   0.0478 ns |   0.0447 ns |    139.58 ns |   3.42 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    129.17 ns |   0.2779 ns |   0.2599 ns |    129.23 ns |   3.17 |     0.01 |
|                                LowCostLinqWithStructWhere |            [5] |     74.35 ns |   0.7699 ns |   0.7202 ns |     74.21 ns |   1.82 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     61.94 ns |   0.0254 ns |   0.0237 ns |     61.93 ns |   1.52 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    256.93 ns |   0.2963 ns |   0.2771 ns |    256.93 ns |   6.30 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    233.38 ns |   0.3282 ns |   0.3070 ns |    233.47 ns |   5.72 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    147.93 ns |   2.3102 ns |   2.1609 ns |    148.46 ns |   3.63 |     0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    138.17 ns |   0.2224 ns |   0.2080 ns |    138.19 ns |   3.39 |     0.01 |
|                                                 LinqCount |            [5] |    154.27 ns |   0.3679 ns |   0.3441 ns |    154.09 ns |   3.78 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     92.64 ns |   0.0135 ns |   0.0105 ns |     92.64 ns |   2.27 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     88.23 ns |   1.3840 ns |   1.2946 ns |     87.51 ns |   2.16 |     0.03 |
|                           LowCostLinqWithStructWhereCount |            [5] |     60.88 ns |   0.0191 ns |   0.0179 ns |     60.88 ns |   1.49 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     47.84 ns |   0.0102 ns |   0.0085 ns |     47.84 ns |   1.17 |     0.00 |
|                                               LinqToArray |            [5] |    224.53 ns |   0.0701 ns |   0.0656 ns |    224.55 ns |   5.51 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    139.26 ns |   0.0516 ns |   0.0458 ns |    139.26 ns |   3.41 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    143.22 ns |   0.0462 ns |   0.0432 ns |    143.21 ns |   3.51 |     0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    103.01 ns |   0.0254 ns |   0.0198 ns |    103.01 ns |   2.53 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     88.91 ns |   1.3127 ns |   1.2279 ns |     88.00 ns |   2.18 |     0.03 |
|                                                      Take |            [5] |    255.42 ns |   0.1559 ns |   0.1382 ns |    255.42 ns |   6.26 |     0.01 |
|                                               LowCostTake |            [5] |    127.92 ns |   0.3133 ns |   0.2931 ns |    127.78 ns |   3.14 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    108.33 ns |   0.0324 ns |   0.0303 ns |    108.33 ns |   2.66 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     92.67 ns |   0.0700 ns |   0.0621 ns |     92.67 ns |   2.27 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     77.27 ns |   0.0325 ns |   0.0271 ns |     77.26 ns |   1.89 |     0.00 |
|                                            SkipTakeSingle |            [5] |    246.55 ns |   0.6546 ns |   0.5803 ns |    246.76 ns |   6.05 |     0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    146.78 ns |   0.2545 ns |   0.2381 ns |    146.73 ns |   3.60 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    135.78 ns |   1.4363 ns |   1.3435 ns |    134.94 ns |   3.33 |     0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     95.65 ns |   0.0141 ns |   0.0125 ns |     95.65 ns |   2.35 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     91.70 ns |   0.1669 ns |   0.1561 ns |     91.75 ns |   2.25 |     0.00 |
|                                           ForeachDelegate |            [5] |     73.12 ns |   0.0242 ns |   0.0226 ns |     73.12 ns |   1.79 |     0.00 |
|                                                   Foreach |            [5] |     40.78 ns |   0.0283 ns |   0.0265 ns |     40.79 ns |   1.00 |     0.00 |
