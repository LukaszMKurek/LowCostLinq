``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |     **46.919 ns** |   **0.0167 ns** |   **0.0156 ns** |     **46.917 ns** | **13.59** |    **0.01** |
|                      LowCostLinqWithDelegate |            [0] |     20.057 ns |   0.0177 ns |   0.0138 ns |     20.054 ns |  5.81 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |     37.773 ns |   0.0046 ns |   0.0043 ns |     37.773 ns | 10.94 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |     27.705 ns |   0.0106 ns |   0.0099 ns |     27.701 ns |  8.03 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     59.525 ns |   0.0206 ns |   0.0192 ns |     59.521 ns | 17.24 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     48.892 ns |   0.9608 ns |   0.8987 ns |     48.221 ns | 14.18 |    0.26 |
|                                    LinqCount |            [0] |     48.401 ns |   0.1079 ns |   0.1009 ns |     48.347 ns | 14.02 |    0.03 |
|                 LowCostLinqWithDelegateCount |            [0] |     23.427 ns |   0.0315 ns |   0.0295 ns |     23.429 ns |  6.79 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     21.291 ns |   0.0029 ns |   0.0023 ns |     21.290 ns |  6.17 |    0.00 |
|                                  LinqToArray |            [0] |     61.975 ns |   0.0202 ns |   0.0179 ns |     61.978 ns | 17.95 |    0.01 |
|               LowCostLinqWithDelegateToArray |            [0] |     28.145 ns |   0.0327 ns |   0.0290 ns |     28.146 ns |  8.15 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |     25.073 ns |   0.4389 ns |   0.4105 ns |     24.804 ns |  7.25 |    0.11 |
|                                         Take |            [0] |     86.291 ns |   0.0196 ns |   0.0183 ns |     86.289 ns | 25.00 |    0.02 |
|                                  LowCostTake |            [0] |     29.402 ns |   0.0082 ns |   0.0068 ns |     29.402 ns |  8.52 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |     36.030 ns |   0.0046 ns |   0.0041 ns |     36.030 ns | 10.44 |    0.01 |
|                               SkipTakeSingle |            [0] |    109.582 ns |   1.9968 ns |   1.8678 ns |    108.183 ns | 31.78 |    0.54 |
|                        LowCostSkipTakeSingle |            [0] |     37.471 ns |   0.0081 ns |   0.0067 ns |     37.471 ns | 10.85 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     40.436 ns |   0.0099 ns |   0.0088 ns |     40.436 ns | 11.71 |    0.01 |
|                              ForeachDelegate |            [0] |      6.582 ns |   0.0025 ns |   0.0024 ns |      6.582 ns |  1.91 |    0.00 |
|                                      Foreach |            [0] |      3.645 ns |   0.0009 ns |   0.0008 ns |      3.645 ns |  1.06 |    0.00 |
|                                          For |            [0] |      3.452 ns |   0.0022 ns |   0.0020 ns |      3.452 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |         **[1000]** |  **7,738.354 ns** |   **4.4755 ns** |   **4.1864 ns** |  **7,738.754 ns** | **30.89** |    **0.02** |
|                      LowCostLinqWithDelegate |         [1000] |  5,440.921 ns | 107.8561 ns | 266.5937 ns |  5,451.432 ns | 22.54 |    0.99 |
|                     LowCostLinqWithDelegate2 |         [1000] |  6,211.067 ns | 122.5606 ns | 141.1409 ns |  6,181.711 ns | 24.88 |    0.57 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,466.937 ns |   0.2939 ns |   0.2606 ns |  1,466.898 ns |  5.86 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 16,385.826 ns | 178.2049 ns | 166.6930 ns | 16,361.252 ns | 65.41 |    0.67 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,788.731 ns |   2.4294 ns |   2.2725 ns |  5,788.907 ns | 23.11 |    0.01 |
|                                    LinqCount |         [1000] |  3,689.620 ns |  46.2455 ns |  43.2580 ns |  3,663.822 ns | 14.73 |    0.17 |
|                 LowCostLinqWithDelegateCount |         [1000] |  5,761.055 ns | 114.8028 ns | 242.1582 ns |  5,743.964 ns | 23.48 |    0.85 |
|              LowCostLinqWithStructWhereCount |         [1000] |  1,334.796 ns |   8.7050 ns |   8.1426 ns |  1,330.199 ns |  5.33 |    0.03 |
|                                  LinqToArray |         [1000] |  4,874.668 ns |   4.5272 ns |   4.0133 ns |  4,874.430 ns | 19.46 |    0.02 |
|               LowCostLinqWithDelegateToArray |         [1000] |  7,460.298 ns |   5.0422 ns |   4.7165 ns |  7,460.480 ns | 29.78 |    0.02 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,395.734 ns |   5.7876 ns |   5.1306 ns |  2,396.151 ns |  9.56 |    0.02 |
|                                         Take |         [1000] |    359.736 ns |   0.0840 ns |   0.0745 ns |    359.719 ns |  1.44 |    0.00 |
|                                  LowCostTake |         [1000] |    145.057 ns |   2.7874 ns |   6.2916 ns |    144.819 ns |  0.59 |    0.02 |
|                        LowCostTakeWithStruct |         [1000] |     71.904 ns |   0.7045 ns |   0.6590 ns |     71.398 ns |  0.29 |    0.00 |
|                               SkipTakeSingle |         [1000] |    255.144 ns |   0.0701 ns |   0.0586 ns |    255.132 ns |  1.02 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    150.850 ns |   2.9908 ns |   4.0938 ns |    150.336 ns |  0.61 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     64.509 ns |   0.1168 ns |   0.1092 ns |     64.494 ns |  0.26 |    0.00 |
|                              ForeachDelegate |         [1000] |  3,223.965 ns |  54.3970 ns |  48.2215 ns |  3,217.525 ns | 12.87 |    0.19 |
|                                      Foreach |         [1000] |    442.827 ns |   8.4743 ns |   7.5122 ns |    442.296 ns |  1.77 |    0.03 |
|                                          For |         [1000] |    250.529 ns |   0.0387 ns |   0.0362 ns |    250.529 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |           **[50]** |    **456.547 ns** |   **8.3303 ns** |   **7.7922 ns** |    **451.117 ns** | **28.13** |    **0.38** |
|                      LowCostLinqWithDelegate |           [50] |    294.777 ns |   5.8856 ns |  16.3090 ns |    293.925 ns | 18.65 |    0.97 |
|                     LowCostLinqWithDelegate2 |           [50] |    345.987 ns |   6.7691 ns |   6.3318 ns |    344.745 ns | 21.32 |    0.33 |
|                   LowCostLinqWithStructWhere |           [50] |     99.052 ns |   0.0269 ns |   0.0225 ns |     99.049 ns |  6.12 |    0.08 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    871.680 ns |   0.7592 ns |   0.7102 ns |    871.490 ns | 53.71 |    0.77 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    347.554 ns |   2.3724 ns |   2.1031 ns |    348.007 ns | 21.43 |    0.35 |
|                                    LinqCount |           [50] |    245.443 ns |   0.1846 ns |   0.1636 ns |    245.428 ns | 15.13 |    0.22 |
|                 LowCostLinqWithDelegateCount |           [50] |    316.637 ns |   6.2830 ns |   9.2095 ns |    316.435 ns | 19.69 |    0.47 |
|              LowCostLinqWithStructWhereCount |           [50] |     71.335 ns |   0.6237 ns |   0.5834 ns |     71.031 ns |  4.40 |    0.05 |
|                                  LinqToArray |           [50] |    502.292 ns |   0.1934 ns |   0.1715 ns |    502.314 ns | 30.97 |    0.44 |
|               LowCostLinqWithDelegateToArray |           [50] |    489.786 ns |   0.5249 ns |   0.4910 ns |    489.717 ns | 30.18 |    0.42 |
|                 LowCostLinqWithStructToArray |           [50] |    201.094 ns |   0.0924 ns |   0.0819 ns |    201.078 ns | 12.40 |    0.18 |
|                                         Take |           [50] |    363.189 ns |   5.9536 ns |   5.5690 ns |    359.829 ns | 22.38 |    0.30 |
|                                  LowCostTake |           [50] |    143.251 ns |   2.8279 ns |   3.5764 ns |    143.933 ns |  8.83 |    0.29 |
|                        LowCostTakeWithStruct |           [50] |     71.401 ns |   0.0307 ns |   0.0288 ns |     71.397 ns |  4.40 |    0.06 |
|                               SkipTakeSingle |           [50] |    255.303 ns |   0.1272 ns |   0.1128 ns |    255.263 ns | 15.74 |    0.23 |
|                        LowCostSkipTakeSingle |           [50] |    146.404 ns |   1.2087 ns |   1.0094 ns |    146.017 ns |  9.04 |    0.14 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     64.367 ns |   0.1324 ns |   0.1174 ns |     64.351 ns |  3.97 |    0.06 |
|                              ForeachDelegate |           [50] |    168.780 ns |   0.9043 ns |   0.8459 ns |    168.534 ns | 10.40 |    0.15 |
|                                      Foreach |           [50] |     26.471 ns |   0.1523 ns |   0.1425 ns |     26.436 ns |  1.63 |    0.03 |
|                                          For |           [50] |     16.232 ns |   0.2432 ns |   0.2275 ns |     16.263 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |            **[5]** |     **96.967 ns** |   **0.0418 ns** |   **0.0391 ns** |     **96.976 ns** | **20.16** |    **0.02** |
|                      LowCostLinqWithDelegate |            [5] |     45.366 ns |   0.5760 ns |   0.5388 ns |     45.279 ns |  9.42 |    0.11 |
|                     LowCostLinqWithDelegate2 |            [5] |     67.549 ns |   1.0177 ns |   0.9520 ns |     67.681 ns | 14.04 |    0.20 |
|                   LowCostLinqWithStructWhere |            [5] |     36.196 ns |   0.3761 ns |   0.3518 ns |     36.049 ns |  7.53 |    0.07 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    140.532 ns |   0.0655 ns |   0.0613 ns |    140.517 ns | 29.22 |    0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     79.730 ns |   1.5867 ns |   2.3258 ns |     79.922 ns | 16.65 |    0.48 |
|                                    LinqCount |            [5] |     80.580 ns |   1.5667 ns |   1.6089 ns |     79.264 ns | 16.74 |    0.34 |
|                 LowCostLinqWithDelegateCount |            [5] |     51.644 ns |   1.2050 ns |   1.8401 ns |     51.523 ns | 10.69 |    0.42 |
|              LowCostLinqWithStructWhereCount |            [5] |     23.880 ns |   0.0101 ns |   0.0079 ns |     23.879 ns |  4.96 |    0.00 |
|                                  LinqToArray |            [5] |    140.978 ns |   0.0273 ns |   0.0242 ns |    140.984 ns | 29.31 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [5] |     89.232 ns |   0.0319 ns |   0.0299 ns |     89.232 ns | 18.55 |    0.01 |
|                 LowCostLinqWithStructToArray |            [5] |     58.448 ns |   0.0348 ns |   0.0308 ns |     58.454 ns | 12.15 |    0.01 |
|                                         Take |            [5] |    167.536 ns |   2.8333 ns |   2.6503 ns |    166.028 ns | 34.77 |    0.53 |
|                                  LowCostTake |            [5] |     58.986 ns |   1.1950 ns |   2.3589 ns |     59.145 ns | 12.44 |    0.29 |
|                        LowCostTakeWithStruct |            [5] |     45.863 ns |   0.0367 ns |   0.0343 ns |     45.865 ns |  9.53 |    0.01 |
|                               SkipTakeSingle |            [5] |    151.440 ns |   2.7499 ns |   2.5722 ns |    149.983 ns | 31.41 |    0.48 |
|                        LowCostSkipTakeSingle |            [5] |     58.090 ns |   0.8738 ns |   0.8174 ns |     58.294 ns | 12.08 |    0.17 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     46.232 ns |   0.0581 ns |   0.0543 ns |     46.223 ns |  9.61 |    0.01 |
|                              ForeachDelegate |            [5] |     23.207 ns |   0.1361 ns |   0.1273 ns |     23.187 ns |  4.82 |    0.02 |
|                                      Foreach |            [5] |      5.527 ns |   0.0180 ns |   0.0169 ns |      5.531 ns |  1.15 |    0.00 |
|                                          For |            [5] |      4.810 ns |   0.0034 ns |   0.0030 ns |      4.810 ns |  1.00 |    0.00 |
