``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |     **81.024 ns** |   **0.0365 ns** |   **0.0342 ns** |     **81.015 ns** | **23.47** |    **0.02** |
|                      LowCostLinqWithDelegate |            [0] |     23.125 ns |   0.2572 ns |   0.2406 ns |     22.948 ns |  6.70 |    0.07 |
|                     LowCostLinqWithDelegate2 |            [0] |     47.883 ns |   0.0132 ns |   0.0117 ns |     47.882 ns | 13.87 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |     36.675 ns |   0.0507 ns |   0.0449 ns |     36.686 ns | 10.62 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     53.541 ns |   0.1257 ns |   0.0982 ns |     53.594 ns | 15.51 |    0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     33.740 ns |   0.0249 ns |   0.0233 ns |     33.735 ns |  9.77 |    0.01 |
|                                    LinqCount |            [0] |     79.047 ns |   0.0283 ns |   0.0251 ns |     79.042 ns | 22.89 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |     25.165 ns |   0.0306 ns |   0.0272 ns |     25.161 ns |  7.29 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     29.260 ns |   0.4057 ns |   0.3795 ns |     29.162 ns |  8.47 |    0.12 |
|                                  LinqToArray |            [0] |     94.581 ns |   0.0500 ns |   0.0468 ns |     94.580 ns | 27.39 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [0] |     28.944 ns |   0.0547 ns |   0.0485 ns |     28.945 ns |  8.38 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |     31.776 ns |   0.0094 ns |   0.0087 ns |     31.772 ns |  9.20 |    0.01 |
|                                         Take |            [0] |    122.587 ns |   2.4410 ns |   2.9059 ns |    120.208 ns | 35.19 |    0.77 |
|                                  LowCostTake |            [0] |     31.803 ns |   0.0081 ns |   0.0068 ns |     31.804 ns |  9.21 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |     42.987 ns |   0.0074 ns |   0.0069 ns |     42.985 ns | 12.45 |    0.01 |
|                               SkipTakeSingle |            [0] |    137.982 ns |   0.0589 ns |   0.0551 ns |    137.982 ns | 39.96 |    0.03 |
|                        LowCostSkipTakeSingle |            [0] |     43.270 ns |   0.7435 ns |   0.6955 ns |     42.744 ns | 12.54 |    0.20 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     48.868 ns |   0.0087 ns |   0.0081 ns |     48.864 ns | 14.15 |    0.01 |
|                              ForeachDelegate |            [0] |      7.329 ns |   0.0060 ns |   0.0056 ns |      7.328 ns |  2.12 |    0.00 |
|                                      Foreach |            [0] |      3.632 ns |   0.0012 ns |   0.0009 ns |      3.632 ns |  1.05 |    0.00 |
|                                          For |            [0] |      3.453 ns |   0.0024 ns |   0.0022 ns |      3.453 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |         **[1000]** | **10,601.532 ns** |  **91.1383 ns** |  **80.7918 ns** | **10,580.089 ns** | **42.31** |    **0.32** |
|                      LowCostLinqWithDelegate |         [1000] |  8,332.207 ns | 177.4857 ns | 248.8101 ns |  8,310.724 ns | 33.03 |    0.83 |
|                     LowCostLinqWithDelegate2 |         [1000] |  9,085.927 ns | 402.5732 ns | 479.2347 ns |  8,917.076 ns | 36.77 |    2.05 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,202.699 ns |   1.4356 ns |   1.3429 ns |  1,203.341 ns |  4.80 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 16,588.842 ns | 261.3663 ns | 244.4822 ns | 16,616.776 ns | 66.20 |    0.98 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,861.337 ns |   0.5125 ns |   0.4544 ns |  3,861.264 ns | 15.41 |    0.00 |
|                                    LinqCount |         [1000] |  7,134.956 ns |  49.1676 ns |  45.9914 ns |  7,131.236 ns | 28.47 |    0.18 |
|                 LowCostLinqWithDelegateCount |         [1000] |  8,972.758 ns | 174.8906 ns | 287.3503 ns |  8,883.273 ns | 36.05 |    1.37 |
|              LowCostLinqWithStructWhereCount |         [1000] |    569.502 ns |   0.1196 ns |   0.1118 ns |    569.518 ns |  2.27 |    0.00 |
|                                  LinqToArray |         [1000] |  8,172.638 ns | 194.1351 ns | 245.5187 ns |  8,037.053 ns | 32.91 |    1.12 |
|               LowCostLinqWithDelegateToArray |         [1000] |  8,991.031 ns |   6.0992 ns |   5.7052 ns |  8,989.159 ns | 35.88 |    0.02 |
|                 LowCostLinqWithStructToArray |         [1000] |  1,887.678 ns |   0.8324 ns |   0.6499 ns |  1,887.643 ns |  7.53 |    0.00 |
|                                         Take |         [1000] |    429.031 ns |   0.1248 ns |   0.1168 ns |    429.024 ns |  1.71 |    0.00 |
|                                  LowCostTake |         [1000] |    201.800 ns |   2.5629 ns |   2.1401 ns |    203.112 ns |  0.81 |    0.01 |
|                        LowCostTakeWithStruct |         [1000] |     68.504 ns |   0.0180 ns |   0.0168 ns |     68.504 ns |  0.27 |    0.00 |
|                               SkipTakeSingle |         [1000] |    347.424 ns |   0.2529 ns |   0.2242 ns |    347.484 ns |  1.39 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    245.420 ns |   4.3198 ns |   4.0407 ns |    244.039 ns |  0.98 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     75.671 ns |   0.0362 ns |   0.0302 ns |     75.660 ns |  0.30 |    0.00 |
|                              ForeachDelegate |         [1000] |  4,302.299 ns |   0.8820 ns |   0.8250 ns |  4,302.133 ns | 17.17 |    0.01 |
|                                      Foreach |         [1000] |    449.265 ns |   8.4769 ns |   7.9293 ns |    448.288 ns |  1.79 |    0.03 |
|                                          For |         [1000] |    250.580 ns |   0.0576 ns |   0.0539 ns |    250.571 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |           **[50]** |    **611.015 ns** |   **1.8081 ns** |   **1.4117 ns** |    **610.568 ns** | **40.03** |    **0.12** |
|                      LowCostLinqWithDelegate |           [50] |    441.258 ns |   8.0742 ns |   7.5526 ns |    441.438 ns | 28.91 |    0.53 |
|                     LowCostLinqWithDelegate2 |           [50] |    505.026 ns |   9.8874 ns |  15.9663 ns |    505.601 ns | 33.22 |    1.19 |
|                   LowCostLinqWithStructWhere |           [50] |     98.380 ns |   0.1355 ns |   0.1131 ns |     98.378 ns |  6.44 |    0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    866.656 ns |   3.2199 ns |   2.8544 ns |    866.945 ns | 56.78 |    0.27 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    233.558 ns |   0.0670 ns |   0.0627 ns |    233.543 ns | 15.30 |    0.04 |
|                                    LinqCount |           [50] |    441.758 ns |   0.5369 ns |   0.5022 ns |    441.674 ns | 28.94 |    0.08 |
|                 LowCostLinqWithDelegateCount |           [50] |    467.658 ns |   9.3265 ns |  12.1271 ns |    470.370 ns | 30.74 |    0.77 |
|              LowCostLinqWithStructWhereCount |           [50] |     55.379 ns |   0.0147 ns |   0.0137 ns |     55.371 ns |  3.63 |    0.01 |
|                                  LinqToArray |           [50] |    704.626 ns |  15.2566 ns |  19.2947 ns |    694.382 ns | 46.54 |    1.47 |
|               LowCostLinqWithDelegateToArray |           [50] |    586.751 ns |   0.3556 ns |   0.3327 ns |    586.703 ns | 38.44 |    0.11 |
|                 LowCostLinqWithStructToArray |           [50] |    195.784 ns |   0.1425 ns |   0.1264 ns |    195.802 ns | 12.83 |    0.04 |
|                                         Take |           [50] |    434.945 ns |   8.6644 ns |   9.6304 ns |    428.768 ns | 28.61 |    0.68 |
|                                  LowCostTake |           [50] |    215.705 ns |   4.3157 ns |   7.8915 ns |    215.276 ns | 14.04 |    0.48 |
|                        LowCostTakeWithStruct |           [50] |     68.117 ns |   0.0848 ns |   0.0662 ns |     68.092 ns |  4.46 |    0.01 |
|                               SkipTakeSingle |           [50] |    347.026 ns |   0.0853 ns |   0.0798 ns |    347.065 ns | 22.74 |    0.06 |
|                        LowCostSkipTakeSingle |           [50] |    243.079 ns |   4.7574 ns |   4.4501 ns |    240.248 ns | 15.93 |    0.29 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     73.733 ns |   0.0436 ns |   0.0386 ns |     73.729 ns |  4.83 |    0.01 |
|                              ForeachDelegate |           [50] |    226.007 ns |   0.2904 ns |   0.2425 ns |    226.086 ns | 14.80 |    0.04 |
|                                      Foreach |           [50] |     26.562 ns |   0.0712 ns |   0.0666 ns |     26.583 ns |  1.74 |    0.01 |
|                                          For |           [50] |     15.263 ns |   0.0439 ns |   0.0411 ns |     15.260 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |            **[5]** |    **139.386 ns** |   **2.7568 ns** |   **3.3856 ns** |    **137.389 ns** | **29.70** |    **0.80** |
|                      LowCostLinqWithDelegate |            [5] |     62.894 ns |   1.2638 ns |   2.8266 ns |     63.016 ns | 13.30 |    0.61 |
|                     LowCostLinqWithDelegate2 |            [5] |     87.691 ns |   1.7519 ns |   2.3387 ns |     87.397 ns | 18.44 |    0.47 |
|                   LowCostLinqWithStructWhere |            [5] |     40.979 ns |   0.0067 ns |   0.0063 ns |     40.979 ns |  8.66 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    136.096 ns |   0.2549 ns |   0.2385 ns |    136.143 ns | 28.77 |    0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     51.989 ns |   0.0278 ns |   0.0260 ns |     51.986 ns | 10.99 |    0.01 |
|                                    LinqCount |            [5] |    128.910 ns |   0.1301 ns |   0.1016 ns |    128.905 ns | 27.24 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [5] |     66.542 ns |   1.3186 ns |   1.6676 ns |     66.674 ns | 14.09 |    0.38 |
|              LowCostLinqWithStructWhereCount |            [5] |     31.426 ns |   0.0114 ns |   0.0107 ns |     31.425 ns |  6.64 |    0.01 |
|                                  LinqToArray |            [5] |    182.982 ns |   0.1676 ns |   0.1486 ns |    182.956 ns | 38.67 |    0.03 |
|               LowCostLinqWithDelegateToArray |            [5] |    110.903 ns |   0.0711 ns |   0.0665 ns |    110.889 ns | 23.43 |    0.02 |
|                 LowCostLinqWithStructToArray |            [5] |     73.244 ns |   0.0289 ns |   0.0271 ns |     73.251 ns | 15.48 |    0.01 |
|                                         Take |            [5] |    212.836 ns |   0.2769 ns |   0.2312 ns |    212.768 ns | 44.98 |    0.05 |
|                                  LowCostTake |            [5] |     65.597 ns |   1.0083 ns |   0.9432 ns |     65.480 ns | 13.88 |    0.20 |
|                        LowCostTakeWithStruct |            [5] |     49.353 ns |   0.0093 ns |   0.0087 ns |     49.352 ns | 10.43 |    0.01 |
|                               SkipTakeSingle |            [5] |    195.170 ns |   0.0990 ns |   0.0926 ns |    195.143 ns | 41.24 |    0.03 |
|                        LowCostSkipTakeSingle |            [5] |     78.364 ns |   1.5704 ns |   2.4449 ns |     78.563 ns | 16.76 |    0.55 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     54.493 ns |   0.0417 ns |   0.0391 ns |     54.481 ns | 11.52 |    0.01 |
|                              ForeachDelegate |            [5] |     30.151 ns |   0.3782 ns |   0.3538 ns |     30.252 ns |  6.37 |    0.08 |
|                                      Foreach |            [5] |      5.526 ns |   0.0136 ns |   0.0106 ns |      5.529 ns |  1.17 |    0.00 |
|                                          For |            [5] |      4.732 ns |   0.0032 ns |   0.0029 ns |      4.733 ns |  1.00 |    0.00 |
