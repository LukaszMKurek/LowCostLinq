``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |         Error |        StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|--------------:|--------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **112.353 ns** |     **0.0294 ns** |     **0.0275 ns** |    **112.358 ns** | **32.52** |    **0.02** |
|                      LowCostLinqWithDelegate |            [0] |     34.476 ns |     0.0056 ns |     0.0053 ns |     34.476 ns |  9.98 |    0.01 |
|                     LowCostLinqWithDelegate2 |            [0] |     58.244 ns |     0.0083 ns |     0.0070 ns |     58.242 ns | 16.86 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |     42.718 ns |     0.3014 ns |     0.2819 ns |     42.538 ns | 12.37 |    0.08 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     75.820 ns |     0.0434 ns |     0.0385 ns |     75.808 ns | 21.95 |    0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     74.107 ns |     0.0199 ns |     0.0186 ns |     74.101 ns | 21.45 |    0.02 |
|                                    LinqCount |            [0] |    112.825 ns |     0.0784 ns |     0.0654 ns |    112.811 ns | 32.66 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [0] |     29.465 ns |     0.0085 ns |     0.0079 ns |     29.469 ns |  8.53 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     37.503 ns |     0.0070 ns |     0.0065 ns |     37.503 ns | 10.86 |    0.01 |
|                                  LinqToArray |            [0] |    129.035 ns |     0.1027 ns |     0.0911 ns |    129.011 ns | 37.35 |    0.03 |
|               LowCostLinqWithDelegateToArray |            [0] |     33.349 ns |     0.0160 ns |     0.0141 ns |     33.349 ns |  9.65 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |     39.887 ns |     0.0206 ns |     0.0192 ns |     39.889 ns | 11.55 |    0.01 |
|                                         Take |            [0] |    150.722 ns |     0.0324 ns |     0.0303 ns |    150.722 ns | 43.63 |    0.03 |
|                                  LowCostTake |            [0] |     44.447 ns |     0.0055 ns |     0.0052 ns |     44.445 ns | 12.87 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |     56.181 ns |     0.5767 ns |     0.5394 ns |     55.849 ns | 16.26 |    0.16 |
|                               SkipTakeSingle |            [0] |    173.473 ns |     0.0320 ns |     0.0299 ns |    173.462 ns | 50.22 |    0.03 |
|                        LowCostSkipTakeSingle |            [0] |     60.889 ns |     0.0234 ns |     0.0182 ns |     60.891 ns | 17.63 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     67.228 ns |     0.0109 ns |     0.0102 ns |     67.224 ns | 19.46 |    0.01 |
|                              ForeachDelegate |            [0] |      7.382 ns |     0.1113 ns |     0.1041 ns |      7.408 ns |  2.14 |    0.03 |
|                                      Foreach |            [0] |      3.680 ns |     0.0002 ns |     0.0002 ns |      3.680 ns |  1.07 |    0.00 |
|                                          For |            [0] |      3.455 ns |     0.0025 ns |     0.0023 ns |      3.455 ns |  1.00 |    0.00 |
|                                              |                |               |               |               |               |       |         |
|                                         **Linq** |         **[1000]** | **13,967.385 ns** |   **277.1771 ns** |   **360.4085 ns** | **14,019.514 ns** | **55.75** |    **1.58** |
|                      LowCostLinqWithDelegate |         [1000] | 12,959.317 ns |   381.0013 ns | 1,123.3910 ns | 13,539.067 ns | 54.54 |    4.41 |
|                     LowCostLinqWithDelegate2 |         [1000] | 12,970.002 ns |   254.4528 ns |   508.1698 ns | 13,147.699 ns | 51.80 |    1.92 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,486.554 ns |     0.7778 ns |     0.7275 ns |  1,486.850 ns |  5.93 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 22,615.549 ns |   452.0100 ns | 1,282.2773 ns | 22,979.410 ns | 92.53 |    5.40 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,160.242 ns |   109.9323 ns |   102.8308 ns |  6,087.508 ns | 24.56 |    0.41 |
|                                    LinqCount |         [1000] | 10,127.250 ns |   199.6232 ns |   259.5666 ns | 10,209.833 ns | 40.21 |    1.24 |
|                 LowCostLinqWithDelegateCount |         [1000] | 17,090.516 ns | 1,356.3964 ns | 3,999.3653 ns | 19,620.110 ns | 76.31 |   11.58 |
|              LowCostLinqWithStructWhereCount |         [1000] |  1,354.992 ns |     1.1480 ns |     1.0738 ns |  1,355.087 ns |  5.40 |    0.00 |
|                                  LinqToArray |         [1000] | 10,489.642 ns |    63.9241 ns |    49.9077 ns | 10,500.809 ns | 41.81 |    0.20 |
|               LowCostLinqWithDelegateToArray |         [1000] | 11,309.202 ns |    18.6063 ns |    17.4044 ns | 11,311.378 ns | 45.08 |    0.07 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,457.158 ns |    19.0226 ns |    15.8847 ns |  2,450.763 ns |  9.79 |    0.06 |
|                                         Take |         [1000] |    495.651 ns |     2.1069 ns |     1.7593 ns |    494.869 ns |  1.98 |    0.01 |
|                                  LowCostTake |         [1000] |    294.521 ns |     5.9071 ns |    14.1531 ns |    299.491 ns |  1.18 |    0.05 |
|                        LowCostTakeWithStruct |         [1000] |     92.311 ns |     0.0089 ns |     0.0075 ns |     92.313 ns |  0.37 |    0.00 |
|                               SkipTakeSingle |         [1000] |    444.232 ns |    10.0359 ns |    10.3061 ns |    438.408 ns |  1.77 |    0.04 |
|                        LowCostSkipTakeSingle |         [1000] |    334.830 ns |     6.6571 ns |    11.1225 ns |    338.809 ns |  1.34 |    0.04 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    123.042 ns |     0.0632 ns |     0.0591 ns |    123.061 ns |  0.49 |    0.00 |
|                              ForeachDelegate |         [1000] |  6,247.532 ns |    53.2613 ns |    49.8206 ns |  6,219.091 ns | 24.90 |    0.20 |
|                                      Foreach |         [1000] |    460.514 ns |     2.6288 ns |     2.3303 ns |    460.055 ns |  1.84 |    0.01 |
|                                          For |         [1000] |    250.867 ns |     0.0620 ns |     0.0580 ns |    250.886 ns |  1.00 |    0.00 |
|                                              |                |               |               |               |               |       |         |
|                                         **Linq** |           **[50]** |    **898.732 ns** |     **4.4475 ns** |     **4.1602 ns** |    **899.920 ns** | **58.90** |    **0.30** |
|                      LowCostLinqWithDelegate |           [50] |    619.770 ns |    12.1952 ns |    32.5514 ns |    634.572 ns | 41.06 |    1.50 |
|                     LowCostLinqWithDelegate2 |           [50] |    752.917 ns |    18.7822 ns |    55.3798 ns |    778.244 ns | 51.36 |    4.16 |
|                   LowCostLinqWithStructWhere |           [50] |    112.423 ns |     0.0244 ns |     0.0229 ns |    112.426 ns |  7.37 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,399.315 ns |    55.7598 ns |   164.4089 ns |  1,499.763 ns | 98.98 |    1.11 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    387.825 ns |     5.9118 ns |     5.5299 ns |    383.756 ns | 25.47 |    0.37 |
|                                    LinqCount |           [50] |    601.576 ns |     4.5230 ns |     4.2308 ns |    602.583 ns | 39.49 |    0.25 |
|                 LowCostLinqWithDelegateCount |           [50] |    596.121 ns |    15.6458 ns |    46.1321 ns |    600.421 ns | 39.11 |    2.23 |
|              LowCostLinqWithStructWhereCount |           [50] |     89.476 ns |     0.0150 ns |     0.0141 ns |     89.474 ns |  5.86 |    0.00 |
|                                  LinqToArray |           [50] |    827.088 ns |    19.0263 ns |    22.6495 ns |    814.375 ns | 54.46 |    1.69 |
|               LowCostLinqWithDelegateToArray |           [50] |    697.423 ns |     3.6047 ns |     3.3718 ns |    696.974 ns | 45.74 |    0.22 |
|                 LowCostLinqWithStructToArray |           [50] |    217.543 ns |     0.1204 ns |     0.1126 ns |    217.590 ns | 14.26 |    0.01 |
|                                         Take |           [50] |    504.450 ns |     9.8783 ns |    12.1315 ns |    495.180 ns | 32.90 |    0.80 |
|                                  LowCostTake |           [50] |    404.465 ns |    33.2653 ns |    98.0834 ns |    475.559 ns | 27.48 |    6.88 |
|                        LowCostTakeWithStruct |           [50] |     92.996 ns |     0.8576 ns |     0.8022 ns |     92.337 ns |  6.10 |    0.05 |
|                               SkipTakeSingle |           [50] |    432.523 ns |     1.0281 ns |     0.9617 ns |    432.776 ns | 28.34 |    0.06 |
|                        LowCostSkipTakeSingle |           [50] |    328.518 ns |     6.5578 ns |    10.9567 ns |    323.941 ns | 21.76 |    0.73 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    123.324 ns |     0.1147 ns |     0.0957 ns |    123.368 ns |  8.08 |    0.01 |
|                              ForeachDelegate |           [50] |    321.704 ns |     0.0441 ns |     0.0412 ns |    321.718 ns | 21.09 |    0.00 |
|                                      Foreach |           [50] |     26.538 ns |     0.0414 ns |     0.0388 ns |     26.543 ns |  1.74 |    0.00 |
|                                          For |           [50] |     15.257 ns |     0.0029 ns |     0.0024 ns |     15.257 ns |  1.00 |    0.00 |
|                                              |                |               |               |               |               |       |         |
|                                         **Linq** |            **[5]** |    **186.147 ns** |     **0.0911 ns** |     **0.0808 ns** |    **186.139 ns** | **38.85** |    **0.02** |
|                      LowCostLinqWithDelegate |            [5] |     83.364 ns |     1.6849 ns |     4.7799 ns |     85.623 ns | 17.04 |    0.94 |
|                     LowCostLinqWithDelegate2 |            [5] |    126.534 ns |     2.5039 ns |     3.8237 ns |    126.835 ns | 26.54 |    0.89 |
|                   LowCostLinqWithStructWhere |            [5] |     50.841 ns |     0.7407 ns |     0.6928 ns |     50.354 ns | 10.61 |    0.14 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    200.402 ns |     2.3897 ns |     2.2353 ns |    201.222 ns | 41.82 |    0.47 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    108.065 ns |     0.1966 ns |     0.1743 ns |    108.098 ns | 22.55 |    0.03 |
|                                    LinqCount |            [5] |    169.849 ns |     3.6685 ns |     4.8974 ns |    167.025 ns | 35.87 |    1.14 |
|                 LowCostLinqWithDelegateCount |            [5] |     77.266 ns |     0.3472 ns |     0.2899 ns |     77.277 ns | 16.12 |    0.06 |
|              LowCostLinqWithStructWhereCount |            [5] |     39.177 ns |     0.0199 ns |     0.0186 ns |     39.176 ns |  8.18 |    0.00 |
|                                  LinqToArray |            [5] |    224.046 ns |     0.0584 ns |     0.0456 ns |    224.037 ns | 46.75 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [5] |    113.085 ns |     0.0989 ns |     0.0926 ns |    113.119 ns | 23.60 |    0.02 |
|                 LowCostLinqWithStructToArray |            [5] |     73.685 ns |     0.0497 ns |     0.0465 ns |     73.683 ns | 15.38 |    0.01 |
|                                         Take |            [5] |    253.667 ns |     0.0853 ns |     0.0756 ns |    253.647 ns | 52.94 |    0.02 |
|                                  LowCostTake |            [5] |     97.182 ns |     1.9485 ns |     3.6597 ns |     98.082 ns | 19.96 |    0.70 |
|                        LowCostTakeWithStruct |            [5] |     65.212 ns |     0.0119 ns |     0.0111 ns |     65.214 ns | 13.61 |    0.01 |
|                               SkipTakeSingle |            [5] |    242.984 ns |     0.2089 ns |     0.1744 ns |    242.946 ns | 50.71 |    0.04 |
|                        LowCostSkipTakeSingle |            [5] |    114.692 ns |     0.3456 ns |     0.2698 ns |    114.637 ns | 23.93 |    0.05 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     78.969 ns |     0.0069 ns |     0.0065 ns |     78.970 ns | 16.48 |    0.01 |
|                              ForeachDelegate |            [5] |     37.840 ns |     0.0086 ns |     0.0081 ns |     37.839 ns |  7.90 |    0.00 |
|                                      Foreach |            [5] |      5.557 ns |     0.0136 ns |     0.0127 ns |      5.561 ns |  1.16 |    0.00 |
|                                          For |            [5] |      4.792 ns |     0.0022 ns |     0.0021 ns |      4.792 ns |  1.00 |    0.00 |
