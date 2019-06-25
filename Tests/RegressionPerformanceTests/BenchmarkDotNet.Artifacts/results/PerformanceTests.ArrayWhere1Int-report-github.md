``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **20.011 ns** |  **0.0042 ns** |  **0.0035 ns** |    **20.011 ns** |  **5.62** |    **0.00** |
|                      LowCostLinqWithDelegate |            [0] |    20.889 ns |  0.0046 ns |  0.0043 ns |    20.886 ns |  5.87 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |    27.973 ns |  0.0058 ns |  0.0051 ns |    27.974 ns |  7.86 |    0.00 |
|                   LowCostLinqWithStructWhere |            [0] |    21.322 ns |  0.0024 ns |  0.0021 ns |    21.322 ns |  5.99 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    39.850 ns |  0.0220 ns |  0.0195 ns |    39.846 ns | 11.19 |    0.00 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    43.654 ns |  0.0202 ns |  0.0189 ns |    43.649 ns | 12.26 |    0.01 |
|                                    LinqCount |            [0] |    24.327 ns |  0.0088 ns |  0.0078 ns |    24.328 ns |  6.83 |    0.00 |
|                 LowCostLinqWithDelegateCount |            [0] |    15.877 ns |  0.0053 ns |  0.0049 ns |    15.877 ns |  4.46 |    0.00 |
|              LowCostLinqWithStructWhereCount |            [0] |    15.882 ns |  0.0046 ns |  0.0043 ns |    15.880 ns |  4.46 |    0.00 |
|                                  LinqToArray |            [0] |    22.836 ns |  0.0073 ns |  0.0068 ns |    22.836 ns |  6.41 |    0.00 |
|               LowCostLinqWithDelegateToArray |            [0] |    21.033 ns |  0.0446 ns |  0.0417 ns |    21.020 ns |  5.91 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |    20.109 ns |  0.1574 ns |  0.1472 ns |    20.110 ns |  5.64 |    0.04 |
|                                         Take |            [0] |    24.519 ns |  0.0161 ns |  0.0151 ns |    24.515 ns |  6.89 |    0.00 |
|                                  LowCostTake |            [0] |    26.464 ns |  0.2674 ns |  0.2502 ns |    26.285 ns |  7.45 |    0.07 |
|                        LowCostTakeWithStruct |            [0] |    28.659 ns |  0.0425 ns |  0.0397 ns |    28.641 ns |  8.05 |    0.01 |
|                               SkipTakeSingle |            [0] |    35.951 ns |  0.0168 ns |  0.0157 ns |    35.951 ns | 10.10 |    0.00 |
|                        LowCostSkipTakeSingle |            [0] |    35.033 ns |  0.0513 ns |  0.0480 ns |    35.043 ns |  9.84 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    33.057 ns |  0.4809 ns |  0.4498 ns |    32.688 ns |  9.31 |    0.13 |
|                              ForeachDelegate |            [0] |     6.862 ns |  0.0014 ns |  0.0013 ns |     6.862 ns |  1.93 |    0.00 |
|                                      Foreach |            [0] |     3.790 ns |  0.0018 ns |  0.0017 ns |     3.791 ns |  1.06 |    0.00 |
|                                          For |            [0] |     3.560 ns |  0.0007 ns |  0.0006 ns |     3.560 ns |  1.00 |    0.00 |
|                                              |                |              |            |            |              |       |         |
|                                         **Linq** |         **[1000]** | **5,814.198 ns** |  **1.5104 ns** |  **1.4128 ns** | **5,814.413 ns** | **23.05** |    **0.01** |
|                      LowCostLinqWithDelegate |         [1000] | 2,949.784 ns |  6.1036 ns |  5.7093 ns | 2,949.210 ns | 11.69 |    0.02 |
|                     LowCostLinqWithDelegate2 |         [1000] | 3,155.271 ns |  0.9559 ns |  0.8941 ns | 3,155.518 ns | 12.51 |    0.00 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,208.673 ns |  0.3076 ns |  0.2568 ns | 1,208.772 ns |  4.79 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 8,745.578 ns | 19.6425 ns | 18.3736 ns | 8,743.248 ns | 34.67 |    0.07 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 6,031.240 ns |  1.3534 ns |  1.2660 ns | 6,031.480 ns | 23.91 |    0.01 |
|                                    LinqCount |         [1000] | 1,749.158 ns | 26.6141 ns | 24.8948 ns | 1,733.294 ns |  6.94 |    0.10 |
|                 LowCostLinqWithDelegateCount |         [1000] | 2,408.305 ns |  0.5717 ns |  0.5348 ns | 2,408.523 ns |  9.55 |    0.00 |
|              LowCostLinqWithStructWhereCount |         [1000] |   518.578 ns |  0.1114 ns |  0.0987 ns |   518.572 ns |  2.06 |    0.00 |
|                                  LinqToArray |         [1000] | 2,875.267 ns |  0.7429 ns |  0.6949 ns | 2,875.284 ns | 11.40 |    0.00 |
|               LowCostLinqWithDelegateToArray |         [1000] | 3,875.110 ns |  6.4876 ns |  6.0685 ns | 3,874.635 ns | 15.36 |    0.02 |
|                 LowCostLinqWithStructToArray |         [1000] | 2,151.303 ns |  1.4500 ns |  1.3563 ns | 2,151.594 ns |  8.53 |    0.01 |
|                                         Take |         [1000] |   288.950 ns |  0.0690 ns |  0.0646 ns |   288.971 ns |  1.15 |    0.00 |
|                                  LowCostTake |         [1000] |    91.944 ns |  0.0497 ns |  0.0440 ns |    91.925 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStruct |         [1000] |    56.251 ns |  0.0137 ns |  0.0122 ns |    56.250 ns |  0.22 |    0.00 |
|                               SkipTakeSingle |         [1000] |   185.601 ns |  0.0718 ns |  0.0599 ns |   185.604 ns |  0.74 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    97.832 ns |  0.0343 ns |  0.0321 ns |    97.826 ns |  0.39 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    59.915 ns |  0.0159 ns |  0.0148 ns |    59.910 ns |  0.24 |    0.00 |
|                              ForeachDelegate |         [1000] | 1,684.730 ns |  0.3130 ns |  0.2928 ns | 1,684.848 ns |  6.68 |    0.00 |
|                                      Foreach |         [1000] |   478.959 ns |  3.1552 ns |  2.9514 ns |   479.467 ns |  1.90 |    0.01 |
|                                          For |         [1000] |   252.213 ns |  0.0806 ns |  0.0715 ns |   252.180 ns |  1.00 |    0.00 |
|                                              |                |              |            |            |              |       |         |
|                                         **Linq** |           **[50]** |   **329.010 ns** |  **0.1354 ns** |  **0.1130 ns** |   **329.033 ns** | **21.63** |    **0.02** |
|                      LowCostLinqWithDelegate |           [50] |   163.536 ns |  0.2060 ns |  0.1826 ns |   163.588 ns | 10.75 |    0.01 |
|                     LowCostLinqWithDelegate2 |           [50] |   185.470 ns |  0.1963 ns |  0.1836 ns |   185.450 ns | 12.19 |    0.02 |
|                   LowCostLinqWithStructWhere |           [50] |    86.186 ns |  0.0169 ns |  0.0158 ns |    86.183 ns |  5.67 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   520.949 ns |  0.4411 ns |  0.4126 ns |   520.897 ns | 34.25 |    0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   349.402 ns |  0.1076 ns |  0.0954 ns |   349.437 ns | 22.97 |    0.02 |
|                                    LinqCount |           [50] |   128.266 ns |  0.6118 ns |  0.5723 ns |   128.254 ns |  8.43 |    0.04 |
|                 LowCostLinqWithDelegateCount |           [50] |   140.656 ns |  0.0201 ns |  0.0188 ns |   140.646 ns |  9.25 |    0.01 |
|              LowCostLinqWithStructWhereCount |           [50] |    42.233 ns |  0.0171 ns |  0.0160 ns |    42.232 ns |  2.78 |    0.00 |
|                                  LinqToArray |           [50] |   350.900 ns |  0.0395 ns |  0.0350 ns |   350.901 ns | 23.07 |    0.02 |
|               LowCostLinqWithDelegateToArray |           [50] |   291.651 ns |  0.3575 ns |  0.3344 ns |   291.560 ns | 19.18 |    0.03 |
|                 LowCostLinqWithStructToArray |           [50] |   194.441 ns |  0.1161 ns |  0.1086 ns |   194.459 ns | 12.78 |    0.01 |
|                                         Take |           [50] |   289.295 ns |  0.3484 ns |  0.3259 ns |   289.107 ns | 19.02 |    0.03 |
|                                  LowCostTake |           [50] |    91.543 ns |  0.0104 ns |  0.0097 ns |    91.543 ns |  6.02 |    0.00 |
|                        LowCostTakeWithStruct |           [50] |    54.301 ns |  0.0053 ns |  0.0049 ns |    54.303 ns |  3.57 |    0.00 |
|                               SkipTakeSingle |           [50] |   186.840 ns |  0.4860 ns |  0.4546 ns |   186.789 ns | 12.28 |    0.03 |
|                        LowCostSkipTakeSingle |           [50] |    97.908 ns |  0.0258 ns |  0.0241 ns |    97.911 ns |  6.44 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    58.601 ns |  0.0071 ns |  0.0066 ns |    58.602 ns |  3.85 |    0.00 |
|                              ForeachDelegate |           [50] |    96.295 ns |  0.0030 ns |  0.0024 ns |    96.295 ns |  6.33 |    0.00 |
|                                      Foreach |           [50] |    26.630 ns |  0.0335 ns |  0.0314 ns |    26.635 ns |  1.75 |    0.00 |
|                                          For |           [50] |    15.209 ns |  0.0125 ns |  0.0117 ns |    15.212 ns |  1.00 |    0.00 |
|                                              |                |              |            |            |              |       |         |
|                                         **Linq** |            **[5]** |    **59.990 ns** |  **0.0256 ns** |  **0.0227 ns** |    **59.996 ns** | **11.93** |    **0.01** |
|                      LowCostLinqWithDelegate |            [5] |    34.097 ns |  0.6054 ns |  0.5663 ns |    33.659 ns |  6.78 |    0.11 |
|                     LowCostLinqWithDelegate2 |            [5] |    45.374 ns |  0.0690 ns |  0.0645 ns |    45.394 ns |  9.02 |    0.01 |
|                   LowCostLinqWithStructWhere |            [5] |    26.375 ns |  0.0108 ns |  0.0096 ns |    26.376 ns |  5.25 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    86.444 ns |  1.7052 ns |  1.8953 ns |    85.057 ns | 17.27 |    0.39 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    73.874 ns |  0.0830 ns |  0.0776 ns |    73.838 ns | 14.69 |    0.02 |
|                                    LinqCount |            [5] |    41.647 ns |  0.0297 ns |  0.0277 ns |    41.647 ns |  8.28 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |    28.751 ns |  0.0301 ns |  0.0267 ns |    28.750 ns |  5.72 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [5] |    18.611 ns |  0.2960 ns |  0.2768 ns |    18.437 ns |  3.70 |    0.05 |
|                                  LinqToArray |            [5] |    97.705 ns |  0.0504 ns |  0.0447 ns |    97.707 ns | 19.43 |    0.01 |
|               LowCostLinqWithDelegateToArray |            [5] |    65.502 ns |  0.0281 ns |  0.0234 ns |    65.496 ns | 13.03 |    0.01 |
|                 LowCostLinqWithStructToArray |            [5] |    55.100 ns |  0.1406 ns |  0.1174 ns |    55.057 ns | 10.96 |    0.02 |
|                                         Take |            [5] |   119.130 ns |  0.0462 ns |  0.0432 ns |   119.140 ns | 23.69 |    0.02 |
|                                  LowCostTake |            [5] |    42.170 ns |  0.0041 ns |  0.0038 ns |    42.169 ns |  8.39 |    0.01 |
|                        LowCostTakeWithStruct |            [5] |    35.655 ns |  0.0188 ns |  0.0176 ns |    35.658 ns |  7.09 |    0.01 |
|                               SkipTakeSingle |            [5] |   110.540 ns |  0.3523 ns |  0.3295 ns |   110.454 ns | 21.98 |    0.06 |
|                        LowCostSkipTakeSingle |            [5] |    45.914 ns |  0.0078 ns |  0.0073 ns |    45.914 ns |  9.13 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    37.346 ns |  0.0084 ns |  0.0079 ns |    37.346 ns |  7.43 |    0.01 |
|                              ForeachDelegate |            [5] |    14.846 ns |  0.0029 ns |  0.0027 ns |    14.846 ns |  2.95 |    0.00 |
|                                      Foreach |            [5] |     5.772 ns |  0.0177 ns |  0.0165 ns |     5.777 ns |  1.15 |    0.00 |
|                                          For |            [5] |     5.028 ns |  0.0036 ns |  0.0033 ns |     5.030 ns |  1.00 |    0.00 |
