``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |    **108.317 ns** |   **0.0718 ns** |   **0.0561 ns** |    **108.307 ns** |  **29.09** |     **0.45** |
|                                   LowCostLinqWithDelegate |            [0] |     42.208 ns |   0.3116 ns |   0.2762 ns |     42.039 ns |  11.33 |     0.19 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     32.302 ns |   0.0062 ns |   0.0049 ns |     32.302 ns |   8.67 |     0.14 |
|                                  LowCostLinqWithDelegate2 |            [0] |     66.332 ns |   0.0036 ns |   0.0032 ns |     66.332 ns |  17.81 |     0.28 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     61.216 ns |   0.0023 ns |   0.0021 ns |     61.217 ns |  16.44 |     0.26 |
|                                LowCostLinqWithStructWhere |            [0] |     49.233 ns |   0.0033 ns |   0.0027 ns |     49.234 ns |  13.22 |     0.21 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     45.025 ns |   0.0043 ns |   0.0038 ns |     45.024 ns |  12.09 |     0.19 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     75.248 ns |   0.0528 ns |   0.0494 ns |     75.250 ns |  20.21 |     0.32 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     70.788 ns |   0.0474 ns |   0.0420 ns |     70.780 ns |  19.01 |     0.30 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     68.809 ns |   0.0484 ns |   0.0405 ns |     68.802 ns |  18.48 |     0.29 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     63.860 ns |   0.0602 ns |   0.0503 ns |     63.847 ns |  17.15 |     0.27 |
|                                                 LinqCount |            [0] |    107.503 ns |   0.0288 ns |   0.0255 ns |    107.498 ns |  28.87 |     0.45 |
|                              LowCostLinqWithDelegateCount |            [0] |     31.156 ns |   0.0049 ns |   0.0045 ns |     31.154 ns |   8.37 |     0.13 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     29.217 ns |   0.0025 ns |   0.0021 ns |     29.216 ns |   7.85 |     0.12 |
|                           LowCostLinqWithStructWhereCount |            [0] |     43.691 ns |   0.0034 ns |   0.0030 ns |     43.691 ns |  11.73 |     0.18 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.958 ns |   0.0721 ns |   0.0674 ns |     36.985 ns |   9.92 |     0.16 |
|                                               LinqToArray |            [0] |    134.249 ns |   0.3109 ns |   0.2908 ns |    134.289 ns |  36.05 |     0.57 |
|                            LowCostLinqWithDelegateToArray |            [0] |     35.135 ns |   0.0247 ns |   0.0231 ns |     35.134 ns |   9.43 |     0.15 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     32.892 ns |   0.0144 ns |   0.0120 ns |     32.888 ns |   8.83 |     0.14 |
|                              LowCostLinqWithStructToArray |            [0] |     47.013 ns |   0.0127 ns |   0.0119 ns |     47.014 ns |  12.62 |     0.20 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     39.374 ns |   0.0108 ns |   0.0101 ns |     39.373 ns |  10.57 |     0.16 |
|                                                      Take |            [0] |    146.878 ns |   2.4905 ns |   2.3296 ns |    147.435 ns |  39.44 |     0.86 |
|                                               LowCostTake |            [0] |     52.114 ns |   0.0021 ns |   0.0018 ns |     52.115 ns |  13.99 |     0.22 |
|                                  LowCostTakeWithoutChecks |            [0] |     44.506 ns |   0.0085 ns |   0.0080 ns |     44.504 ns |  11.95 |     0.19 |
|                                     LowCostTakeWithStruct |            [0] |     63.096 ns |   0.0029 ns |   0.0026 ns |     63.096 ns |  16.94 |     0.26 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     61.829 ns |   0.4020 ns |   0.3760 ns |     61.901 ns |  16.60 |     0.28 |
|                                            SkipTakeSingle |            [0] |    167.427 ns |   0.1076 ns |   0.1007 ns |    167.393 ns |  44.96 |     0.70 |
|                                     LowCostSkipTakeSingle |            [0] |     61.797 ns |   0.0258 ns |   0.0215 ns |     61.793 ns |  16.59 |     0.26 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     59.563 ns |   0.0080 ns |   0.0062 ns |     59.560 ns |  15.99 |     0.25 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     68.988 ns |   0.0042 ns |   0.0037 ns |     68.987 ns |  18.53 |     0.29 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     74.491 ns |   0.1740 ns |   0.1543 ns |     74.383 ns |  20.00 |     0.31 |
|                                           ForeachDelegate |            [0] |     16.777 ns |   0.0049 ns |   0.0046 ns |     16.777 ns |   4.51 |     0.07 |
|                                                   Foreach |            [0] |     12.631 ns |   0.0125 ns |   0.0117 ns |     12.632 ns |   3.39 |     0.05 |
|                                                       For |            [0] |      3.725 ns |   0.0655 ns |   0.0613 ns |      3.687 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |               |        |          |
|                                                      **Linq** |         **[1000]** | **14,315.294 ns** |  **23.0634 ns** |  **21.5735 ns** | **14,321.756 ns** |  **56.52** |     **0.14** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,279.699 ns |   5.9890 ns |   5.6021 ns | 11,277.793 ns |  44.53 |     0.09 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,664.802 ns | 128.5953 ns | 120.2882 ns | 10,566.065 ns |  42.11 |     0.47 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 10,170.084 ns |   3.9921 ns |   3.7342 ns | 10,170.530 ns |  40.15 |     0.08 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 11,512.302 ns |  17.8176 ns |  16.6666 ns | 11,520.002 ns |  45.45 |     0.11 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,853.099 ns |   1.0403 ns |   0.9731 ns |  1,853.565 ns |   7.32 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,747.149 ns |   0.8563 ns |   0.8010 ns |  1,747.490 ns |   6.90 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 21,395.448 ns |  23.8639 ns |  22.3223 ns | 21,389.255 ns |  84.47 |     0.19 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 20,509.391 ns |  42.9888 ns |  40.2118 ns | 20,516.773 ns |  80.97 |     0.22 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,361.431 ns |  77.6942 ns |  72.6752 ns |  6,303.825 ns |  25.12 |     0.28 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  5,573.174 ns |   3.0651 ns |   2.8671 ns |  5,574.579 ns |  22.00 |     0.05 |
|                                                 LinqCount |         [1000] |  9,238.168 ns |   2.7422 ns |   2.4309 ns |  9,237.952 ns |  36.47 |     0.07 |
|                              LowCostLinqWithDelegateCount |         [1000] | 11,549.087 ns |  23.6370 ns |  22.1101 ns | 11,562.368 ns |  45.60 |     0.12 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  9,614.917 ns |   4.9443 ns |   3.8602 ns |  9,616.388 ns |  37.96 |     0.08 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,746.595 ns |   1.6235 ns |   1.4392 ns |  1,746.860 ns |   6.90 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,224.869 ns |   0.0712 ns |   0.0595 ns |  1,224.856 ns |   4.84 |     0.01 |
|                                               LinqToArray |         [1000] | 11,187.645 ns | 152.4864 ns | 142.6359 ns | 11,075.488 ns |  44.17 |     0.55 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,894.770 ns |   2.9305 ns |   2.7412 ns | 11,894.859 ns |  46.96 |     0.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,805.247 ns |  17.9052 ns |  16.7485 ns | 11,802.126 ns |  46.61 |     0.11 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,214.525 ns |  49.1656 ns |  45.9896 ns |  3,187.541 ns |  12.69 |     0.18 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,354.547 ns |   1.8030 ns |   1.6866 ns |  2,355.179 ns |   9.30 |     0.02 |
|                                                      Take |         [1000] |    529.892 ns |   0.1020 ns |   0.0904 ns |    529.899 ns |   2.09 |     0.00 |
|                                               LowCostTake |         [1000] |    307.981 ns |   0.7021 ns |   0.6568 ns |    308.358 ns |   1.22 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    297.978 ns |   3.0318 ns |   2.8360 ns |    296.354 ns |   1.18 |     0.01 |
|                                     LowCostTakeWithStruct |         [1000] |    112.093 ns |   0.0341 ns |   0.0319 ns |    112.108 ns |   0.44 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     97.625 ns |   0.0083 ns |   0.0074 ns |     97.624 ns |   0.39 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    469.637 ns |   0.8170 ns |   0.7243 ns |    469.798 ns |   1.85 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    360.685 ns |   0.0850 ns |   0.0754 ns |    360.675 ns |   1.42 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    323.702 ns |   0.3345 ns |   0.3129 ns |    323.863 ns |   1.28 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    155.127 ns |   0.2652 ns |   0.2481 ns |    155.117 ns |   0.61 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    133.832 ns |   0.4296 ns |   0.4018 ns |    134.000 ns |   0.53 |     0.00 |
|                                           ForeachDelegate |         [1000] |  6,890.792 ns |  34.2571 ns |  32.0441 ns |  6,898.441 ns |  27.21 |     0.13 |
|                                                   Foreach |         [1000] |  1,692.549 ns |   0.9526 ns |   0.8911 ns |  1,692.320 ns |   6.68 |     0.01 |
|                                                       For |         [1000] |    253.286 ns |   0.5569 ns |   0.5209 ns |    252.947 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |               |        |          |
|                                                      **Linq** |           **[50]** |    **838.714 ns** |  **14.5901 ns** |  **13.6476 ns** |    **829.915 ns** |  **46.77** |     **0.87** |
|                                   LowCostLinqWithDelegate |           [50] |    603.983 ns |   1.1741 ns |   1.0982 ns |    603.349 ns |  33.68 |     0.34 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    570.204 ns |   0.1037 ns |   0.0970 ns |    570.185 ns |  31.80 |     0.32 |
|                                  LowCostLinqWithDelegate2 |           [50] |    578.801 ns |   0.1331 ns |   0.1039 ns |    578.802 ns |  32.28 |     0.32 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    645.310 ns |   9.8903 ns |   9.2514 ns |    638.257 ns |  35.99 |     0.62 |
|                                LowCostLinqWithStructWhere |           [50] |    147.878 ns |   0.0182 ns |   0.0152 ns |    147.872 ns |   8.25 |     0.08 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    129.095 ns |   0.0134 ns |   0.0112 ns |    129.095 ns |   7.20 |     0.07 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,128.083 ns |   1.7812 ns |   1.6661 ns |  1,128.109 ns |  62.91 |     0.64 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,135.336 ns |  14.5441 ns |  12.8930 ns |  1,127.935 ns |  63.31 |     0.94 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    394.796 ns |   0.2387 ns |   0.1994 ns |    394.748 ns |  22.02 |     0.22 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    350.412 ns |   0.0533 ns |   0.0499 ns |    350.410 ns |  19.54 |     0.20 |
|                                                 LinqCount |           [50] |    574.229 ns |   0.1312 ns |   0.1025 ns |    574.223 ns |  32.02 |     0.32 |
|                              LowCostLinqWithDelegateCount |           [50] |    618.335 ns |  10.7002 ns |  10.0090 ns |    618.910 ns |  34.48 |     0.64 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    511.843 ns |   1.0814 ns |   1.0115 ns |    511.238 ns |  28.54 |     0.29 |
|                           LowCostLinqWithStructWhereCount |           [50] |    135.050 ns |   0.0211 ns |   0.0187 ns |    135.046 ns |   7.53 |     0.08 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     89.892 ns |   0.0079 ns |   0.0062 ns |     89.890 ns |   5.01 |     0.05 |
|                                               LinqToArray |           [50] |    882.750 ns |  13.8483 ns |  12.9537 ns |    873.884 ns |  49.23 |     0.85 |
|                            LowCostLinqWithDelegateToArray |           [50] |    749.575 ns |   0.2816 ns |   0.2352 ns |    749.566 ns |  41.80 |     0.42 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    721.673 ns |   0.2995 ns |   0.2655 ns |    721.568 ns |  40.24 |     0.40 |
|                              LowCostLinqWithStructToArray |           [50] |    272.471 ns |   4.4406 ns |   4.1537 ns |    272.618 ns |  15.19 |     0.27 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    216.515 ns |   0.1436 ns |   0.1343 ns |    216.523 ns |  12.07 |     0.12 |
|                                                      Take |           [50] |    531.552 ns |   0.6586 ns |   0.6160 ns |    531.687 ns |  29.64 |     0.30 |
|                                               LowCostTake |           [50] |    307.569 ns |   0.1053 ns |   0.0985 ns |    307.545 ns |  17.15 |     0.17 |
|                                  LowCostTakeWithoutChecks |           [50] |    295.375 ns |   0.7650 ns |   0.5973 ns |    295.162 ns |  16.47 |     0.17 |
|                                     LowCostTakeWithStruct |           [50] |    112.150 ns |   0.0133 ns |   0.0118 ns |    112.146 ns |   6.25 |     0.06 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     98.021 ns |   0.0345 ns |   0.0322 ns |     98.032 ns |   5.47 |     0.05 |
|                                            SkipTakeSingle |           [50] |    473.748 ns |   8.0396 ns |   7.5202 ns |    468.382 ns |  26.42 |     0.48 |
|                                     LowCostSkipTakeSingle |           [50] |    362.216 ns |   0.6318 ns |   0.5601 ns |    362.413 ns |  20.20 |     0.20 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    323.098 ns |   0.0182 ns |   0.0161 ns |    323.100 ns |  18.02 |     0.18 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    153.839 ns |   0.3455 ns |   0.3062 ns |    153.950 ns |   8.58 |     0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    129.174 ns |   0.5379 ns |   0.5031 ns |    129.261 ns |   7.20 |     0.08 |
|                                           ForeachDelegate |           [50] |    371.680 ns |   0.1221 ns |   0.1143 ns |    371.679 ns |  20.73 |     0.21 |
|                                                   Foreach |           [50] |    104.329 ns |   0.0569 ns |   0.0532 ns |    104.347 ns |   5.82 |     0.06 |
|                                                       For |           [50] |     17.934 ns |   0.1992 ns |   0.1863 ns |     17.990 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |               |        |          |
|                                                      **Linq** |            **[5]** |    **194.524 ns** |   **0.0957 ns** |   **0.0895 ns** |    **194.501 ns** |  **35.93** |     **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |     99.172 ns |   0.0147 ns |   0.0131 ns |     99.173 ns |  18.32 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     87.617 ns |   0.1396 ns |   0.1237 ns |     87.617 ns |  16.18 |     0.02 |
|                                  LowCostLinqWithDelegate2 |            [5] |    124.825 ns |   0.0749 ns |   0.0585 ns |    124.796 ns |  23.06 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    106.246 ns |   0.0459 ns |   0.0430 ns |    106.224 ns |  19.62 |     0.01 |
|                                LowCostLinqWithStructWhere |            [5] |     59.494 ns |   0.2406 ns |   0.2251 ns |     59.604 ns |  10.99 |     0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     53.406 ns |   0.0370 ns |   0.0346 ns |     53.406 ns |   9.86 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    190.557 ns |   0.1925 ns |   0.1707 ns |    190.627 ns |  35.20 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    187.843 ns |   0.0682 ns |   0.0638 ns |    187.840 ns |  34.69 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    101.612 ns |   0.0294 ns |   0.0275 ns |    101.608 ns |  18.77 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     92.459 ns |   1.0541 ns |   0.9860 ns |     92.000 ns |  17.08 |     0.18 |
|                                                 LinqCount |            [5] |    158.288 ns |   0.3815 ns |   0.3569 ns |    158.446 ns |  29.24 |     0.06 |
|                              LowCostLinqWithDelegateCount |            [5] |     85.901 ns |   0.0513 ns |   0.0400 ns |     85.883 ns |  15.87 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     74.249 ns |   0.1207 ns |   0.0942 ns |     74.238 ns |  13.71 |     0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |     52.469 ns |   0.0164 ns |   0.0146 ns |     52.469 ns |   9.69 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     40.166 ns |   0.1025 ns |   0.0959 ns |     40.194 ns |   7.42 |     0.02 |
|                                               LinqToArray |            [5] |    230.601 ns |   0.1180 ns |   0.0985 ns |    230.563 ns |  42.59 |     0.02 |
|                            LowCostLinqWithDelegateToArray |            [5] |    120.873 ns |   0.0265 ns |   0.0207 ns |    120.869 ns |  22.33 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    113.299 ns |   0.0393 ns |   0.0367 ns |    113.298 ns |  20.93 |     0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     85.430 ns |   0.0872 ns |   0.0815 ns |     85.411 ns |  15.78 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     73.904 ns |   0.2147 ns |   0.1676 ns |     73.835 ns |  13.65 |     0.03 |
|                                                      Take |            [5] |    257.139 ns |   0.0505 ns |   0.0448 ns |    257.139 ns |  47.49 |     0.02 |
|                                               LowCostTake |            [5] |    109.424 ns |   0.0434 ns |   0.0385 ns |    109.424 ns |  20.21 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |     91.667 ns |   0.0284 ns |   0.0222 ns |     91.657 ns |  16.93 |     0.01 |
|                                     LowCostTakeWithStruct |            [5] |     76.289 ns |   0.0036 ns |   0.0032 ns |     76.288 ns |  14.09 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     68.696 ns |   0.0122 ns |   0.0108 ns |     68.696 ns |  12.69 |     0.00 |
|                                            SkipTakeSingle |            [5] |    247.700 ns |   0.0885 ns |   0.0739 ns |    247.686 ns |  45.75 |     0.02 |
|                                     LowCostSkipTakeSingle |            [5] |    129.280 ns |   0.0093 ns |   0.0073 ns |    129.281 ns |  23.88 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    116.250 ns |   0.3139 ns |   0.2936 ns |    116.097 ns |  21.47 |     0.05 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     86.588 ns |   0.0137 ns |   0.0122 ns |     86.588 ns |  15.99 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     77.828 ns |   0.0227 ns |   0.0177 ns |     77.821 ns |  14.37 |     0.01 |
|                                           ForeachDelegate |            [5] |     51.543 ns |   0.4472 ns |   0.4183 ns |     51.307 ns |   9.52 |     0.07 |
|                                                   Foreach |            [5] |     20.554 ns |   0.0111 ns |   0.0104 ns |     20.556 ns |   3.80 |     0.00 |
|                                                       For |            [5] |      5.414 ns |   0.0018 ns |   0.0016 ns |      5.414 ns |   1.00 |     0.00 |
