``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **20.289 ns** |   **0.0274 ns** |   **0.0256 ns** |    **20.286 ns** |  **5.88** |    **0.01** |
|                      LowCostLinqWithDelegate |            [0] |    19.398 ns |   0.3058 ns |   0.2861 ns |    19.250 ns |  5.62 |    0.08 |
|                     LowCostLinqWithDelegate2 |            [0] |    29.612 ns |   0.0055 ns |   0.0052 ns |    29.612 ns |  8.58 |    0.00 |
|                   LowCostLinqWithStructWhere |            [0] |    21.290 ns |   0.0040 ns |   0.0033 ns |    21.289 ns |  6.17 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    32.217 ns |   0.0208 ns |   0.0173 ns |    32.215 ns |  9.33 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    33.715 ns |   0.0332 ns |   0.0310 ns |    33.705 ns |  9.77 |    0.01 |
|                                    LinqCount |            [0] |    23.799 ns |   0.0254 ns |   0.0238 ns |    23.804 ns |  6.89 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |    21.427 ns |   0.0044 ns |   0.0041 ns |    21.427 ns |  6.21 |    0.00 |
|              LowCostLinqWithStructWhereCount |            [0] |    15.641 ns |   0.0081 ns |   0.0067 ns |    15.639 ns |  4.53 |    0.00 |
|                                  LinqToArray |            [0] |    22.576 ns |   0.0370 ns |   0.0346 ns |    22.585 ns |  6.54 |    0.01 |
|               LowCostLinqWithDelegateToArray |            [0] |    24.740 ns |   0.0125 ns |   0.0117 ns |    24.737 ns |  7.17 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |    20.373 ns |   0.4831 ns |   1.2210 ns |    20.230 ns |  5.78 |    0.51 |
|                                         Take |            [0] |    24.203 ns |   0.0698 ns |   0.0652 ns |    24.216 ns |  7.01 |    0.02 |
|                                  LowCostTake |            [0] |    26.337 ns |   0.0370 ns |   0.0346 ns |    26.348 ns |  7.63 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |    28.639 ns |   0.0214 ns |   0.0167 ns |    28.637 ns |  8.30 |    0.01 |
|                               SkipTakeSingle |            [0] |    35.217 ns |   0.0912 ns |   0.0853 ns |    35.222 ns | 10.20 |    0.02 |
|                        LowCostSkipTakeSingle |            [0] |    34.225 ns |   0.0069 ns |   0.0064 ns |    34.224 ns |  9.91 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    32.950 ns |   0.0503 ns |   0.0470 ns |    32.968 ns |  9.54 |    0.01 |
|                              ForeachDelegate |            [0] |     6.372 ns |   0.0016 ns |   0.0014 ns |     6.372 ns |  1.85 |    0.00 |
|                                      Foreach |            [0] |     3.576 ns |   0.0030 ns |   0.0028 ns |     3.576 ns |  1.04 |    0.00 |
|                                          For |            [0] |     3.452 ns |   0.0017 ns |   0.0016 ns |     3.453 ns |  1.00 |    0.00 |
|                                              |                |              |             |             |              |       |         |
|                                         **Linq** |         **[1000]** | **5,802.252 ns** |   **1.1519 ns** |   **1.0775 ns** | **5,802.206 ns** | **23.05** |    **0.05** |
|                      LowCostLinqWithDelegate |         [1000] | 3,403.612 ns |   8.4921 ns |   6.6301 ns | 3,403.768 ns | 13.51 |    0.03 |
|                     LowCostLinqWithDelegate2 |         [1000] | 3,142.666 ns |   3.2212 ns |   3.0131 ns | 3,142.509 ns | 12.48 |    0.03 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,205.802 ns |   0.5720 ns |   0.5351 ns | 1,205.880 ns |  4.79 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,429.163 ns | 145.2838 ns | 208.3617 ns | 6,325.504 ns | 25.90 |    0.99 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,892.151 ns |  23.8547 ns |  21.1466 ns | 3,882.647 ns | 15.46 |    0.08 |
|                                    LinqCount |         [1000] | 1,752.895 ns |  16.6777 ns |  14.7843 ns | 1,747.494 ns |  6.96 |    0.06 |
|                 LowCostLinqWithDelegateCount |         [1000] | 1,762.491 ns |  34.3353 ns |  46.9986 ns | 1,743.031 ns |  7.06 |    0.20 |
|              LowCostLinqWithStructWhereCount |         [1000] |   562.367 ns |   0.6068 ns |   0.4737 ns |   562.469 ns |  2.23 |    0.00 |
|                                  LinqToArray |         [1000] | 2,981.378 ns |  41.2202 ns |  38.5574 ns | 2,973.137 ns | 11.84 |    0.16 |
|               LowCostLinqWithDelegateToArray |         [1000] | 2,912.343 ns |  56.5836 ns |  82.9394 ns | 2,881.965 ns | 11.72 |    0.40 |
|                 LowCostLinqWithStructToArray |         [1000] | 1,744.049 ns |   6.1283 ns |   5.4326 ns | 1,744.824 ns |  6.93 |    0.03 |
|                                         Take |         [1000] |   287.640 ns |   0.1574 ns |   0.1315 ns |   287.616 ns |  1.14 |    0.00 |
|                                  LowCostTake |         [1000] |    91.764 ns |   0.0369 ns |   0.0345 ns |    91.768 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStruct |         [1000] |    54.300 ns |   0.0244 ns |   0.0216 ns |    54.291 ns |  0.22 |    0.00 |
|                               SkipTakeSingle |         [1000] |   184.307 ns |   0.3142 ns |   0.2939 ns |   184.155 ns |  0.73 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |   100.878 ns |   0.0680 ns |   0.0636 ns |   100.895 ns |  0.40 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    61.229 ns |   0.0791 ns |   0.0740 ns |    61.230 ns |  0.24 |    0.00 |
|                              ForeachDelegate |         [1000] | 1,682.534 ns |   0.4261 ns |   0.3986 ns | 1,682.604 ns |  6.68 |    0.01 |
|                                      Foreach |         [1000] |   445.903 ns |   8.9089 ns |   9.5325 ns |   444.367 ns |  1.78 |    0.04 |
|                                          For |         [1000] |   251.731 ns |   0.5872 ns |   0.5206 ns |   251.922 ns |  1.00 |    0.00 |
|                                              |                |              |             |             |              |       |         |
|                                         **Linq** |           **[50]** |   **327.636 ns** |   **0.0898 ns** |   **0.0840 ns** |   **327.636 ns** | **19.57** |    **0.02** |
|                      LowCostLinqWithDelegate |           [50] |   191.486 ns |   0.4967 ns |   0.4148 ns |   191.426 ns | 11.44 |    0.03 |
|                     LowCostLinqWithDelegate2 |           [50] |   186.744 ns |   1.3500 ns |   1.2628 ns |   186.717 ns | 11.15 |    0.07 |
|                   LowCostLinqWithStructWhere |           [50] |    86.017 ns |   0.0585 ns |   0.0547 ns |    86.033 ns |  5.14 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   352.237 ns |   0.1533 ns |   0.1359 ns |   352.233 ns | 21.04 |    0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   233.735 ns |   0.0949 ns |   0.0741 ns |   233.735 ns | 13.96 |    0.02 |
|                                    LinqCount |           [50] |   133.562 ns |   1.5830 ns |   1.4808 ns |   133.601 ns |  7.98 |    0.08 |
|                 LowCostLinqWithDelegateCount |           [50] |   116.968 ns |   0.1728 ns |   0.1616 ns |   116.979 ns |  6.99 |    0.01 |
|              LowCostLinqWithStructWhereCount |           [50] |    43.498 ns |   0.5904 ns |   0.5522 ns |    43.064 ns |  2.60 |    0.03 |
|                                  LinqToArray |           [50] |   353.504 ns |   0.1148 ns |   0.1074 ns |   353.536 ns | 21.12 |    0.02 |
|               LowCostLinqWithDelegateToArray |           [50] |   248.406 ns |   0.0818 ns |   0.0683 ns |   248.396 ns | 14.84 |    0.01 |
|                 LowCostLinqWithStructToArray |           [50] |   182.786 ns |   0.1610 ns |   0.1428 ns |   182.837 ns | 10.92 |    0.02 |
|                                         Take |           [50] |   290.437 ns |   4.4731 ns |   4.1841 ns |   287.646 ns | 17.35 |    0.25 |
|                                  LowCostTake |           [50] |    91.733 ns |   0.0144 ns |   0.0135 ns |    91.733 ns |  5.48 |    0.00 |
|                        LowCostTakeWithStruct |           [50] |    54.217 ns |   0.0155 ns |   0.0130 ns |    54.216 ns |  3.24 |    0.00 |
|                               SkipTakeSingle |           [50] |   186.440 ns |   3.6938 ns |   4.1057 ns |   183.767 ns | 11.18 |    0.26 |
|                        LowCostSkipTakeSingle |           [50] |   100.747 ns |   0.0306 ns |   0.0255 ns |   100.752 ns |  6.02 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    61.709 ns |   0.0662 ns |   0.0553 ns |    61.715 ns |  3.69 |    0.01 |
|                              ForeachDelegate |           [50] |    95.739 ns |   0.0217 ns |   0.0203 ns |    95.735 ns |  5.72 |    0.01 |
|                                      Foreach |           [50] |    26.473 ns |   0.1540 ns |   0.1441 ns |    26.511 ns |  1.58 |    0.01 |
|                                          For |           [50] |    16.742 ns |   0.0164 ns |   0.0153 ns |    16.739 ns |  1.00 |    0.00 |
|                                              |                |              |             |             |              |       |         |
|                                         **Linq** |            **[5]** |    **58.914 ns** |   **0.0378 ns** |   **0.0316 ns** |    **58.912 ns** | **12.25** |    **0.01** |
|                      LowCostLinqWithDelegate |            [5] |    33.754 ns |   0.1066 ns |   0.0997 ns |    33.777 ns |  7.02 |    0.02 |
|                     LowCostLinqWithDelegate2 |            [5] |    44.673 ns |   0.0297 ns |   0.0248 ns |    44.668 ns |  9.29 |    0.01 |
|                   LowCostLinqWithStructWhere |            [5] |    26.348 ns |   0.0055 ns |   0.0049 ns |    26.348 ns |  5.48 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    62.939 ns |   0.0326 ns |   0.0289 ns |    62.934 ns | 13.09 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    52.704 ns |   1.0553 ns |   1.0837 ns |    51.967 ns | 10.98 |    0.23 |
|                                    LinqCount |            [5] |    41.115 ns |   0.0317 ns |   0.0281 ns |    41.116 ns |  8.55 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |    29.732 ns |   0.0368 ns |   0.0344 ns |    29.735 ns |  6.18 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [5] |    18.586 ns |   0.0062 ns |   0.0055 ns |    18.586 ns |  3.86 |    0.00 |
|                                  LinqToArray |            [5] |    98.603 ns |   0.0571 ns |   0.0506 ns |    98.601 ns | 20.50 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [5] |    79.374 ns |   0.0533 ns |   0.0445 ns |    79.387 ns | 16.50 |    0.01 |
|                 LowCostLinqWithStructToArray |            [5] |    65.980 ns |   0.0677 ns |   0.0633 ns |    65.984 ns | 13.72 |    0.02 |
|                                         Take |            [5] |   118.276 ns |   0.0774 ns |   0.0686 ns |   118.268 ns | 24.59 |    0.02 |
|                                  LowCostTake |            [5] |    42.051 ns |   0.0073 ns |   0.0064 ns |    42.051 ns |  8.74 |    0.01 |
|                        LowCostTakeWithStruct |            [5] |    35.557 ns |   0.0247 ns |   0.0193 ns |    35.549 ns |  7.39 |    0.01 |
|                               SkipTakeSingle |            [5] |   109.328 ns |   0.2417 ns |   0.2261 ns |   109.187 ns | 22.73 |    0.05 |
|                        LowCostSkipTakeSingle |            [5] |    46.032 ns |   0.9095 ns |   0.8508 ns |    45.596 ns |  9.57 |    0.17 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    36.757 ns |   0.0098 ns |   0.0082 ns |    36.760 ns |  7.64 |    0.01 |
|                              ForeachDelegate |            [5] |    14.454 ns |   0.0260 ns |   0.0243 ns |    14.453 ns |  3.00 |    0.00 |
|                                      Foreach |            [5] |     5.591 ns |   0.0797 ns |   0.0745 ns |     5.541 ns |  1.16 |    0.02 |
|                                          For |            [5] |     4.810 ns |   0.0032 ns |   0.0030 ns |     4.810 ns |  1.00 |    0.00 |
