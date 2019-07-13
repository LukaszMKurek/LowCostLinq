``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **47.836 ns** |   **0.0842 ns** |   **0.0787 ns** |    **47.819 ns** | **13.81** |    **0.02** |
|                      LowCostLinqWithDelegate |            [0] |    20.377 ns |   0.0030 ns |   0.0026 ns |    20.377 ns |  5.88 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |    38.442 ns |   0.3392 ns |   0.3007 ns |    38.452 ns | 11.10 |    0.09 |
|                   LowCostLinqWithStructWhere |            [0] |    28.283 ns |   0.0101 ns |   0.0094 ns |    28.286 ns |  8.16 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    45.024 ns |   0.0110 ns |   0.0091 ns |    45.021 ns | 13.00 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    38.038 ns |   0.0135 ns |   0.0127 ns |    38.035 ns | 10.98 |    0.01 |
|                                    LinqCount |            [0] |    47.883 ns |   0.9535 ns |   1.1351 ns |    47.219 ns | 13.92 |    0.36 |
|                 LowCostLinqWithDelegateCount |            [0] |    23.903 ns |   0.0360 ns |   0.0336 ns |    23.909 ns |  6.90 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |    21.271 ns |   0.0039 ns |   0.0035 ns |    21.270 ns |  6.14 |    0.00 |
|                                  LinqToArray |            [0] |    62.212 ns |   1.2728 ns |   1.5631 ns |    61.137 ns | 18.11 |    0.49 |
|               LowCostLinqWithDelegateToArray |            [0] |    26.141 ns |   0.0205 ns |   0.0192 ns |    26.146 ns |  7.55 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |    24.567 ns |   0.0067 ns |   0.0063 ns |    24.566 ns |  7.09 |    0.00 |
|                                         Take |            [0] |    86.478 ns |   0.0990 ns |   0.0773 ns |    86.457 ns | 24.96 |    0.03 |
|                                  LowCostTake |            [0] |    29.725 ns |   0.0090 ns |   0.0080 ns |    29.725 ns |  8.58 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |    35.847 ns |   0.0160 ns |   0.0150 ns |    35.851 ns | 10.35 |    0.01 |
|                               SkipTakeSingle |            [0] |   107.980 ns |   0.0314 ns |   0.0262 ns |   107.980 ns | 31.17 |    0.02 |
|                        LowCostSkipTakeSingle |            [0] |    37.982 ns |   0.3884 ns |   0.3633 ns |    38.020 ns | 10.97 |    0.10 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    42.294 ns |   0.0472 ns |   0.0441 ns |    42.280 ns | 12.21 |    0.01 |
|                              ForeachDelegate |            [0] |     6.594 ns |   0.0030 ns |   0.0027 ns |     6.593 ns |  1.90 |    0.00 |
|                                      Foreach |            [0] |     3.615 ns |   0.0048 ns |   0.0045 ns |     3.614 ns |  1.04 |    0.00 |
|                                          For |            [0] |     3.465 ns |   0.0024 ns |   0.0021 ns |     3.465 ns |  1.00 |    0.00 |
|                                              |                |              |             |             |              |       |         |
|                                         **Linq** |         **[1000]** | **7,737.721 ns** |   **4.5732 ns** |   **4.2778 ns** | **7,739.108 ns** | **30.88** |    **0.02** |
|                      LowCostLinqWithDelegate |         [1000] | 4,766.078 ns |  70.6268 ns |  62.6089 ns | 4,781.276 ns | 19.02 |    0.25 |
|                     LowCostLinqWithDelegate2 |         [1000] | 6,599.744 ns | 142.7953 ns | 213.7293 ns | 6,533.313 ns | 26.08 |    0.62 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,212.452 ns |   2.5294 ns |   2.3660 ns | 1,213.424 ns |  4.84 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 8,066.522 ns | 160.3857 ns | 157.5202 ns | 8,056.752 ns | 32.20 |    0.65 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 4,344.537 ns |   0.8539 ns |   0.7987 ns | 4,344.408 ns | 17.34 |    0.01 |
|                                    LinqCount |         [1000] | 3,657.106 ns |   5.0484 ns |   3.9414 ns | 3,657.663 ns | 14.60 |    0.02 |
|                 LowCostLinqWithDelegateCount |         [1000] | 4,730.365 ns |  36.6368 ns |  32.4776 ns | 4,737.306 ns | 18.88 |    0.13 |
|              LowCostLinqWithStructWhereCount |         [1000] |   563.452 ns |   0.1718 ns |   0.1523 ns |   563.452 ns |  2.25 |    0.00 |
|                                  LinqToArray |         [1000] | 4,909.449 ns |   6.0017 ns |   5.6140 ns | 4,908.001 ns | 19.59 |    0.02 |
|               LowCostLinqWithDelegateToArray |         [1000] | 6,389.098 ns |   6.5182 ns |   5.7782 ns | 6,389.431 ns | 25.50 |    0.02 |
|                 LowCostLinqWithStructToArray |         [1000] | 1,672.693 ns |   4.3496 ns |   3.6321 ns | 1,673.742 ns |  6.68 |    0.01 |
|                                         Take |         [1000] |   362.120 ns |   0.3435 ns |   0.3213 ns |   362.038 ns |  1.45 |    0.00 |
|                                  LowCostTake |         [1000] |   141.876 ns |   2.9887 ns |   4.6530 ns |   140.290 ns |  0.58 |    0.02 |
|                        LowCostTakeWithStruct |         [1000] |    61.954 ns |   0.0262 ns |   0.0232 ns |    61.957 ns |  0.25 |    0.00 |
|                               SkipTakeSingle |         [1000] |   265.883 ns |   0.1527 ns |   0.1429 ns |   265.915 ns |  1.06 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |   143.243 ns |   2.8364 ns |   3.2664 ns |   142.655 ns |  0.57 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    70.955 ns |   0.7589 ns |   0.6728 ns |    70.552 ns |  0.28 |    0.00 |
|                              ForeachDelegate |         [1000] | 3,196.839 ns |  30.6212 ns |  28.6431 ns | 3,196.308 ns | 12.76 |    0.11 |
|                                      Foreach |         [1000] |   377.742 ns |   7.2400 ns |   6.7723 ns |   378.457 ns |  1.51 |    0.03 |
|                                          For |         [1000] |   250.557 ns |   0.0646 ns |   0.0604 ns |   250.562 ns |  1.00 |    0.00 |
|                                              |                |              |             |             |              |       |         |
|                                         **Linq** |           **[50]** |   **451.774 ns** |   **0.2131 ns** |   **0.1994 ns** |   **451.808 ns** | **29.03** |    **0.67** |
|                      LowCostLinqWithDelegate |           [50] |   271.579 ns |   5.4423 ns |   9.0929 ns |   272.810 ns | 17.51 |    0.81 |
|                     LowCostLinqWithDelegate2 |           [50] |   337.600 ns |   4.4367 ns |   4.1501 ns |   336.149 ns | 21.69 |    0.50 |
|                   LowCostLinqWithStructWhere |           [50] |    94.880 ns |   0.0563 ns |   0.0499 ns |    94.873 ns |  6.10 |    0.14 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   453.297 ns |   1.8755 ns |   1.7544 ns |   453.248 ns | 29.13 |    0.75 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   260.168 ns |   0.0658 ns |   0.0616 ns |   260.166 ns | 16.72 |    0.38 |
|                                    LinqCount |           [50] |   250.749 ns |   4.9067 ns |   4.5898 ns |   251.364 ns | 16.11 |    0.20 |
|                 LowCostLinqWithDelegateCount |           [50] |   274.604 ns |   4.7558 ns |   4.4486 ns |   273.801 ns | 17.65 |    0.55 |
|              LowCostLinqWithStructWhereCount |           [50] |    48.866 ns |   0.0176 ns |   0.0164 ns |    48.870 ns |  3.14 |    0.07 |
|                                  LinqToArray |           [50] |   504.370 ns |   0.2999 ns |   0.2658 ns |   504.416 ns | 32.45 |    0.76 |
|               LowCostLinqWithDelegateToArray |           [50] |   454.470 ns |   0.2026 ns |   0.1692 ns |   454.464 ns | 29.27 |    0.71 |
|                 LowCostLinqWithStructToArray |           [50] |   180.720 ns |   0.1360 ns |   0.1272 ns |   180.755 ns | 11.61 |    0.27 |
|                                         Take |           [50] |   359.712 ns |   0.2061 ns |   0.1928 ns |   359.639 ns | 23.12 |    0.53 |
|                                  LowCostTake |           [50] |   140.179 ns |   2.8051 ns |   4.9130 ns |   138.748 ns |  9.16 |    0.32 |
|                        LowCostTakeWithStruct |           [50] |    61.916 ns |   0.0217 ns |   0.0169 ns |    61.913 ns |  4.00 |    0.09 |
|                               SkipTakeSingle |           [50] |   256.968 ns |   0.0847 ns |   0.0792 ns |   256.972 ns | 16.51 |    0.38 |
|                        LowCostSkipTakeSingle |           [50] |   143.846 ns |   1.8474 ns |   1.5426 ns |   144.615 ns |  9.26 |    0.20 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    70.138 ns |   0.0450 ns |   0.0420 ns |    70.122 ns |  4.51 |    0.10 |
|                              ForeachDelegate |           [50] |   168.633 ns |   0.9009 ns |   0.7986 ns |   168.607 ns | 10.85 |    0.24 |
|                                      Foreach |           [50] |    24.906 ns |   0.2644 ns |   0.2344 ns |    24.941 ns |  1.60 |    0.04 |
|                                          For |           [50] |    15.502 ns |   0.3365 ns |   0.3601 ns |    15.440 ns |  1.00 |    0.00 |
|                                              |                |              |             |             |              |       |         |
|                                         **Linq** |            **[5]** |    **97.778 ns** |   **0.0482 ns** |   **0.0451 ns** |    **97.789 ns** | **20.34** |    **0.02** |
|                      LowCostLinqWithDelegate |            [5] |    46.138 ns |   0.9418 ns |   1.1910 ns |    45.912 ns |  9.59 |    0.26 |
|                     LowCostLinqWithDelegate2 |            [5] |    70.104 ns |   1.3824 ns |   1.8922 ns |    69.817 ns | 14.51 |    0.40 |
|                   LowCostLinqWithStructWhere |            [5] |    33.417 ns |   0.0068 ns |   0.0060 ns |    33.416 ns |  6.95 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    84.388 ns |   0.0379 ns |   0.0336 ns |    84.385 ns | 17.56 |    0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    58.942 ns |   0.0380 ns |   0.0356 ns |    58.942 ns | 12.26 |    0.01 |
|                                    LinqCount |            [5] |    81.126 ns |   1.5847 ns |   1.9461 ns |    79.884 ns | 17.00 |    0.45 |
|                 LowCostLinqWithDelegateCount |            [5] |    47.267 ns |   0.6608 ns |   0.6181 ns |    47.078 ns |  9.83 |    0.13 |
|              LowCostLinqWithStructWhereCount |            [5] |    23.882 ns |   0.0026 ns |   0.0023 ns |    23.882 ns |  4.97 |    0.00 |
|                                  LinqToArray |            [5] |   144.410 ns |   2.9604 ns |   3.2905 ns |   141.779 ns | 30.17 |    0.72 |
|               LowCostLinqWithDelegateToArray |            [5] |    96.691 ns |   0.0159 ns |   0.0141 ns |    96.690 ns | 20.12 |    0.02 |
|                 LowCostLinqWithStructToArray |            [5] |    67.030 ns |   0.0239 ns |   0.0224 ns |    67.032 ns | 13.94 |    0.01 |
|                                         Take |            [5] |   165.333 ns |   0.0426 ns |   0.0333 ns |   165.328 ns | 34.40 |    0.04 |
|                                  LowCostTake |            [5] |    55.707 ns |   0.5083 ns |   0.4244 ns |    55.852 ns | 11.59 |    0.08 |
|                        LowCostTakeWithStruct |            [5] |    42.707 ns |   0.0088 ns |   0.0078 ns |    42.705 ns |  8.88 |    0.01 |
|                               SkipTakeSingle |            [5] |   150.397 ns |   0.0367 ns |   0.0343 ns |   150.396 ns | 31.29 |    0.03 |
|                        LowCostSkipTakeSingle |            [5] |    61.048 ns |   1.2469 ns |   2.3421 ns |    61.266 ns | 12.54 |    0.42 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    45.195 ns |   0.0231 ns |   0.0216 ns |    45.186 ns |  9.40 |    0.01 |
|                              ForeachDelegate |            [5] |    23.315 ns |   0.1134 ns |   0.1061 ns |    23.321 ns |  4.85 |    0.02 |
|                                      Foreach |            [5] |     5.529 ns |   0.0151 ns |   0.0134 ns |     5.528 ns |  1.15 |    0.00 |
|                                          For |            [5] |     4.807 ns |   0.0046 ns |   0.0043 ns |     4.808 ns |  1.00 |    0.00 |
