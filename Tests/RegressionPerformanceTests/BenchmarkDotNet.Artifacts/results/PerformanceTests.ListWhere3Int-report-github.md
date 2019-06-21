``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **94.061 ns** |   **0.0422 ns** |   **0.0374 ns** |     **94.054 ns** | **23.78** |    **0.04** |
|                                   LowCostLinqWithDelegate |            [0] |     31.542 ns |   0.0147 ns |   0.0137 ns |     31.539 ns |  7.97 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     22.735 ns |   0.0054 ns |   0.0048 ns |     22.736 ns |  5.75 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     55.482 ns |   0.3994 ns |   0.3736 ns |     55.217 ns | 14.03 |    0.10 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     47.516 ns |   0.0085 ns |   0.0080 ns |     47.516 ns | 12.01 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |     42.082 ns |   0.0103 ns |   0.0092 ns |     42.081 ns | 10.64 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     36.090 ns |   0.4053 ns |   0.3791 ns |     35.839 ns |  9.12 |    0.09 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     71.772 ns |   0.0333 ns |   0.0295 ns |     71.774 ns | 18.14 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     66.509 ns |   0.0489 ns |   0.0457 ns |     66.494 ns | 16.81 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     67.132 ns |   0.0272 ns |   0.0255 ns |     67.126 ns | 16.97 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     60.449 ns |   0.0291 ns |   0.0272 ns |     60.454 ns | 15.28 |    0.02 |
|                                                 LinqCount |            [0] |     92.876 ns |   0.0569 ns |   0.0504 ns |     92.858 ns | 23.48 |    0.04 |
|                              LowCostLinqWithDelegateCount |            [0] |     27.192 ns |   0.0635 ns |   0.0594 ns |     27.195 ns |  6.87 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     24.993 ns |   0.0882 ns |   0.0825 ns |     25.013 ns |  6.32 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     36.472 ns |   0.0176 ns |   0.0156 ns |     36.470 ns |  9.22 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     28.421 ns |   0.0181 ns |   0.0169 ns |     28.413 ns |  7.19 |    0.01 |
|                                               LinqToArray |            [0] |    118.035 ns |   0.0378 ns |   0.0335 ns |    118.029 ns | 29.84 |    0.05 |
|                            LowCostLinqWithDelegateToArray |            [0] |     30.460 ns |   0.0173 ns |   0.0162 ns |     30.460 ns |  7.70 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     29.719 ns |   0.5604 ns |   0.5242 ns |     29.703 ns |  7.51 |    0.13 |
|                              LowCostLinqWithStructToArray |            [0] |     39.062 ns |   0.0172 ns |   0.0161 ns |     39.059 ns |  9.88 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     31.999 ns |   0.0198 ns |   0.0186 ns |     31.996 ns |  8.09 |    0.01 |
|                                                      Take |            [0] |    132.599 ns |   0.0773 ns |   0.0723 ns |    132.589 ns | 33.52 |    0.06 |
|                                               LowCostTake |            [0] |     37.071 ns |   0.5947 ns |   0.5563 ns |     36.907 ns |  9.37 |    0.14 |
|                                  LowCostTakeWithoutChecks |            [0] |     31.701 ns |   0.0198 ns |   0.0185 ns |     31.693 ns |  8.01 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     49.311 ns |   0.0192 ns |   0.0180 ns |     49.306 ns | 12.47 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     42.313 ns |   0.0104 ns |   0.0098 ns |     42.312 ns | 10.70 |    0.02 |
|                                            SkipTakeSingle |            [0] |    154.601 ns |   0.4761 ns |   0.3717 ns |    154.542 ns | 39.09 |    0.13 |
|                                     LowCostSkipTakeSingle |            [0] |     43.395 ns |   0.0188 ns |   0.0157 ns |     43.398 ns | 10.97 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     42.138 ns |   0.0200 ns |   0.0187 ns |     42.138 ns | 10.65 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     56.193 ns |   0.4564 ns |   0.4269 ns |     55.931 ns | 14.21 |    0.12 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     48.421 ns |   0.0252 ns |   0.0235 ns |     48.415 ns | 12.24 |    0.02 |
|                                           ForeachDelegate |            [0] |     16.263 ns |   0.0284 ns |   0.0266 ns |     16.262 ns |  4.11 |    0.01 |
|                                                   Foreach |            [0] |     12.608 ns |   0.2386 ns |   0.2232 ns |     12.488 ns |  3.19 |    0.06 |
|                                                       For |            [0] |      3.955 ns |   0.0064 ns |   0.0060 ns |      3.955 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** | **12,559.585 ns** |  **46.4940 ns** |  **43.4905 ns** | **12,555.341 ns** | **49.56** |    **0.59** |
|                                   LowCostLinqWithDelegate |         [1000] |  8,418.741 ns | 166.8254 ns | 198.5938 ns |  8,492.514 ns | 33.44 |    0.83 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  7,919.600 ns | 154.6286 ns | 171.8693 ns |  7,832.127 ns | 31.30 |    0.69 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,837.677 ns | 174.8368 ns | 214.7153 ns |  8,785.601 ns | 34.76 |    0.82 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,722.308 ns | 148.1169 ns | 138.5487 ns |  8,692.497 ns | 34.42 |    0.60 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,849.664 ns |  15.3822 ns |  13.6360 ns |  1,842.041 ns |  7.29 |    0.12 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,738.939 ns |   0.3976 ns |   0.3524 ns |  1,738.947 ns |  6.86 |    0.08 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,992.666 ns | 153.2092 ns | 135.8159 ns | 19,993.100 ns | 78.83 |    1.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,326.252 ns | 188.2628 ns | 176.1011 ns | 19,265.475 ns | 76.26 |    1.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,995.471 ns |   1.2427 ns |   0.9702 ns |  6,995.250 ns | 27.53 |    0.31 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  6,280.642 ns |   1.3812 ns |   1.2920 ns |  6,280.805 ns | 24.78 |    0.28 |
|                                                 LinqCount |         [1000] |  6,401.328 ns |  43.7162 ns |  40.8922 ns |  6,400.400 ns | 25.26 |    0.33 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,194.122 ns | 159.1954 ns | 238.2762 ns |  8,087.939 ns | 32.69 |    1.45 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,150.217 ns | 162.2545 ns | 205.2000 ns |  8,189.038 ns | 32.35 |    0.87 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,750.478 ns |   0.4758 ns |   0.4450 ns |  1,750.548 ns |  6.91 |    0.08 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,222.515 ns |  10.8897 ns |  10.1863 ns |  1,216.663 ns |  4.82 |    0.08 |
|                                               LinqToArray |         [1000] |  8,850.513 ns |  12.0232 ns |  11.2465 ns |  8,853.419 ns | 34.92 |    0.40 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,549.032 ns |   6.9335 ns |   6.1463 ns |  9,549.749 ns | 37.65 |    0.42 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 10,372.925 ns |   8.5221 ns |   7.9716 ns | 10,376.305 ns | 40.93 |    0.46 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,426.152 ns |  56.9738 ns |  53.2933 ns |  3,414.312 ns | 13.52 |    0.31 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,530.881 ns |   2.4943 ns |   2.0828 ns |  2,530.272 ns |  9.97 |    0.11 |
|                                                      Take |         [1000] |    477.378 ns |   0.3411 ns |   0.3191 ns |    477.283 ns |  1.88 |    0.02 |
|                                               LowCostTake |         [1000] |    235.130 ns |   3.8972 ns |   3.6455 ns |    235.603 ns |  0.93 |    0.02 |
|                                  LowCostTakeWithoutChecks |         [1000] |    181.986 ns |   3.2595 ns |   2.8894 ns |    182.196 ns |  0.72 |    0.02 |
|                                     LowCostTakeWithStruct |         [1000] |    101.114 ns |   0.1124 ns |   0.1051 ns |    101.137 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     82.855 ns |   0.1244 ns |   0.1103 ns |     82.781 ns |  0.33 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    395.967 ns |   7.8689 ns |   8.4196 ns |    390.029 ns |  1.57 |    0.05 |
|                                     LowCostSkipTakeSingle |         [1000] |    252.459 ns |   4.3120 ns |   3.8225 ns |    251.530 ns |  1.00 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    231.505 ns |   0.6646 ns |   0.5892 ns |    231.706 ns |  0.91 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    111.207 ns |   0.2213 ns |   0.1728 ns |    111.116 ns |  0.44 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     77.602 ns |   0.0695 ns |   0.0650 ns |     77.615 ns |  0.31 |    0.00 |
|                                           ForeachDelegate |         [1000] |  5,986.319 ns |   0.6942 ns |   0.6154 ns |  5,986.158 ns | 23.60 |    0.27 |
|                                                   Foreach |         [1000] |  1,695.711 ns |   1.0781 ns |   1.0085 ns |  1,695.289 ns |  6.69 |    0.08 |
|                                                       For |         [1000] |    253.464 ns |   3.0656 ns |   2.8676 ns |    254.392 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **721.095 ns** |   **0.8488 ns** |   **0.7524 ns** |    **721.261 ns** | **41.36** |    **0.46** |
|                                   LowCostLinqWithDelegate |           [50] |    445.063 ns |   5.1228 ns |   4.2778 ns |    445.096 ns | 25.55 |    0.40 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    414.995 ns |   9.7025 ns |  11.1734 ns |    410.768 ns | 23.88 |    0.57 |
|                                  LowCostLinqWithDelegate2 |           [50] |    482.135 ns |   8.9025 ns |   8.3274 ns |    479.213 ns | 27.61 |    0.45 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    526.008 ns |   9.9419 ns |  10.2096 ns |    526.706 ns | 30.12 |    0.75 |
|                                LowCostLinqWithStructWhere |           [50] |    141.770 ns |   0.0374 ns |   0.0332 ns |    141.767 ns |  8.13 |    0.09 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    125.697 ns |   2.0413 ns |   1.9095 ns |    124.818 ns |  7.20 |    0.17 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,079.484 ns |   1.3817 ns |   1.2924 ns |  1,079.212 ns | 61.82 |    0.76 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,032.117 ns |   1.4028 ns |   1.3122 ns |  1,032.364 ns | 59.11 |    0.70 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    419.134 ns |   0.1319 ns |   0.1233 ns |    419.099 ns | 24.00 |    0.29 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    384.934 ns |   6.3829 ns |   5.9705 ns |    380.742 ns | 22.05 |    0.54 |
|                                                 LinqCount |           [50] |    411.291 ns |   0.2680 ns |   0.2507 ns |    411.263 ns | 23.55 |    0.28 |
|                              LowCostLinqWithDelegateCount |           [50] |    447.766 ns |   7.5870 ns |   7.0969 ns |    445.734 ns | 25.64 |    0.38 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    434.694 ns |   8.5242 ns |  11.0839 ns |    431.085 ns | 25.05 |    0.93 |
|                           LowCostLinqWithStructWhereCount |           [50] |    128.150 ns |   0.1139 ns |   0.1065 ns |    128.116 ns |  7.34 |    0.09 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     82.835 ns |   0.0238 ns |   0.0223 ns |     82.831 ns |  4.74 |    0.06 |
|                                               LinqToArray |           [50] |    754.422 ns |  14.4726 ns |  15.4856 ns |    743.963 ns | 43.33 |    0.98 |
|                            LowCostLinqWithDelegateToArray |           [50] |    613.504 ns |   0.4608 ns |   0.4311 ns |    613.395 ns | 35.14 |    0.42 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    642.796 ns |   0.6389 ns |   0.5976 ns |    642.877 ns | 36.81 |    0.42 |
|                              LowCostLinqWithStructToArray |           [50] |    269.596 ns |   0.1225 ns |   0.1086 ns |    269.611 ns | 15.46 |    0.16 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    223.461 ns |   3.8586 ns |   3.6093 ns |    220.784 ns | 12.80 |    0.34 |
|                                                      Take |           [50] |    477.799 ns |   0.3260 ns |   0.3049 ns |    477.666 ns | 27.36 |    0.32 |
|                                               LowCostTake |           [50] |    227.188 ns |   0.0572 ns |   0.0446 ns |    227.196 ns | 13.06 |    0.12 |
|                                  LowCostTakeWithoutChecks |           [50] |    181.801 ns |   3.1686 ns |   2.6459 ns |    182.870 ns | 10.44 |    0.16 |
|                                     LowCostTakeWithStruct |           [50] |     90.048 ns |   0.0351 ns |   0.0329 ns |     90.056 ns |  5.16 |    0.06 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     81.849 ns |   0.0319 ns |   0.0267 ns |     81.844 ns |  4.70 |    0.05 |
|                                            SkipTakeSingle |           [50] |    389.808 ns |   0.1853 ns |   0.1643 ns |    389.807 ns | 22.36 |    0.24 |
|                                     LowCostSkipTakeSingle |           [50] |    255.184 ns |   4.9795 ns |   6.8160 ns |    254.946 ns | 14.76 |    0.54 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    233.610 ns |   2.0796 ns |   1.9452 ns |    233.078 ns | 13.38 |    0.21 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    114.314 ns |   0.0546 ns |   0.0426 ns |    114.310 ns |  6.57 |    0.06 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     77.198 ns |   0.2551 ns |   0.2386 ns |     77.286 ns |  4.42 |    0.06 |
|                                           ForeachDelegate |           [50] |    319.426 ns |   0.0938 ns |   0.0878 ns |    319.410 ns | 18.29 |    0.22 |
|                                                   Foreach |           [50] |    102.843 ns |   0.0761 ns |   0.0712 ns |    102.842 ns |  5.89 |    0.07 |
|                                                       For |           [50] |     17.463 ns |   0.2235 ns |   0.2091 ns |     17.358 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **158.018 ns** |   **0.0674 ns** |   **0.0631 ns** |    **158.042 ns** | **28.46** |    **0.03** |
|                                   LowCostLinqWithDelegate |            [5] |     71.696 ns |   0.8368 ns |   0.7418 ns |     71.545 ns | 12.91 |    0.14 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     58.536 ns |   1.3568 ns |   1.3326 ns |     58.055 ns | 10.54 |    0.25 |
|                                  LowCostLinqWithDelegate2 |            [5] |     95.672 ns |   1.8945 ns |   1.8606 ns |     95.557 ns | 17.24 |    0.35 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     88.840 ns |   1.1972 ns |   1.1198 ns |     88.889 ns | 16.00 |    0.21 |
|                                LowCostLinqWithStructWhere |            [5] |     52.861 ns |   0.0113 ns |   0.0100 ns |     52.861 ns |  9.52 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     45.254 ns |   0.3099 ns |   0.2899 ns |     45.092 ns |  8.15 |    0.06 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    179.478 ns |   0.0939 ns |   0.0833 ns |    179.462 ns | 32.33 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    162.458 ns |   0.0852 ns |   0.0797 ns |    162.447 ns | 29.26 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     99.845 ns |   0.0431 ns |   0.0403 ns |     99.846 ns | 17.98 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     91.828 ns |   0.0349 ns |   0.0327 ns |     91.828 ns | 16.54 |    0.02 |
|                                                 LinqCount |            [5] |    124.827 ns |   0.1289 ns |   0.1142 ns |    124.799 ns | 22.48 |    0.03 |
|                              LowCostLinqWithDelegateCount |            [5] |     69.427 ns |   1.4348 ns |   1.3422 ns |     69.270 ns | 12.51 |    0.24 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     62.903 ns |   1.1079 ns |   1.0363 ns |     62.884 ns | 11.33 |    0.19 |
|                           LowCostLinqWithStructWhereCount |            [5] |     44.600 ns |   0.0098 ns |   0.0077 ns |     44.602 ns |  8.03 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     33.001 ns |   0.0346 ns |   0.0289 ns |     33.010 ns |  5.94 |    0.01 |
|                                               LinqToArray |            [5] |    202.297 ns |   0.5423 ns |   0.5072 ns |    202.115 ns | 36.44 |    0.10 |
|                            LowCostLinqWithDelegateToArray |            [5] |    104.155 ns |   2.1141 ns |   2.0763 ns |    102.763 ns | 18.77 |    0.39 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    105.275 ns |   0.0576 ns |   0.0510 ns |    105.262 ns | 18.96 |    0.02 |
|                              LowCostLinqWithStructToArray |            [5] |     81.234 ns |   0.0640 ns |   0.0598 ns |     81.239 ns | 14.63 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     68.284 ns |   0.0468 ns |   0.0391 ns |     68.277 ns | 12.30 |    0.01 |
|                                                      Take |            [5] |    233.007 ns |   0.2726 ns |   0.2550 ns |    232.958 ns | 41.97 |    0.05 |
|                                               LowCostTake |            [5] |     76.537 ns |   0.6565 ns |   0.5819 ns |     76.748 ns | 13.79 |    0.10 |
|                                  LowCostTakeWithoutChecks |            [5] |     69.000 ns |   1.1337 ns |   1.0605 ns |     69.115 ns | 12.43 |    0.19 |
|                                     LowCostTakeWithStruct |            [5] |     60.223 ns |   0.0109 ns |   0.0102 ns |     60.224 ns | 10.85 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     52.410 ns |   0.4917 ns |   0.4600 ns |     52.119 ns |  9.44 |    0.09 |
|                                            SkipTakeSingle |            [5] |    206.447 ns |   0.0448 ns |   0.0398 ns |    206.448 ns | 37.18 |    0.04 |
|                                     LowCostSkipTakeSingle |            [5] |     83.705 ns |   1.1537 ns |   1.0228 ns |     83.575 ns | 15.08 |    0.18 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     75.350 ns |   0.8777 ns |   0.7329 ns |     75.364 ns | 13.57 |    0.13 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     66.428 ns |   0.1659 ns |   0.1552 ns |     66.519 ns | 11.97 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.097 ns |   0.0791 ns |   0.0740 ns |     55.094 ns |  9.92 |    0.01 |
|                                           ForeachDelegate |            [5] |     45.138 ns |   0.0334 ns |   0.0312 ns |     45.145 ns |  8.13 |    0.01 |
|                                                   Foreach |            [5] |     20.731 ns |   0.2049 ns |   0.1916 ns |     20.588 ns |  3.73 |    0.04 |
|                                                       For |            [5] |      5.552 ns |   0.0055 ns |   0.0052 ns |      5.551 ns |  1.00 |    0.00 |
