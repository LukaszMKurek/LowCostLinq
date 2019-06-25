``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |        StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|--------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **152.787 ns** |   **0.0738 ns** |     **0.0616 ns** |    **152.798 ns** | **37.02** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |     39.834 ns |   0.0089 ns |     0.0083 ns |     39.832 ns |  9.65 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     32.741 ns |   0.0092 ns |     0.0086 ns |     32.740 ns |  7.93 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     66.452 ns |   0.0101 ns |     0.0089 ns |     66.454 ns | 16.10 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     57.662 ns |   0.0229 ns |     0.0215 ns |     57.658 ns | 13.97 |    0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     49.097 ns |   0.0140 ns |     0.0131 ns |     49.092 ns | 11.90 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     43.298 ns |   0.0610 ns |     0.0571 ns |     43.318 ns | 10.49 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     80.165 ns |   0.0522 ns |     0.0436 ns |     80.168 ns | 19.43 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     76.929 ns |   0.0314 ns |     0.0293 ns |     76.940 ns | 18.64 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     79.919 ns |   0.0675 ns |     0.0598 ns |     79.915 ns | 19.37 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     75.138 ns |   0.1817 ns |     0.1700 ns |     75.159 ns | 18.21 |    0.04 |
|                                                 LinqCount |            [0] |    124.715 ns |   0.0658 ns |     0.0584 ns |    124.724 ns | 30.22 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     31.194 ns |   0.0055 ns |     0.0051 ns |     31.195 ns |  7.56 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     29.333 ns |   0.0102 ns |     0.0095 ns |     29.337 ns |  7.11 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     46.121 ns |   0.9684 ns |     2.4473 ns |     44.839 ns | 11.62 |    0.83 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.145 ns |   0.0929 ns |     0.0869 ns |     36.102 ns |  8.76 |    0.02 |
|                                               LinqToArray |            [0] |    143.721 ns |   1.2488 ns |     1.1682 ns |    143.603 ns | 34.83 |    0.29 |
|                            LowCostLinqWithDelegateToArray |            [0] |     36.320 ns |   0.1146 ns |     0.0895 ns |     36.317 ns |  8.80 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     34.733 ns |   0.1316 ns |     0.1167 ns |     34.735 ns |  8.42 |    0.03 |
|                              LowCostLinqWithStructToArray |            [0] |     48.903 ns |   0.0790 ns |     0.0660 ns |     48.900 ns | 11.85 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     41.081 ns |   0.0735 ns |     0.0687 ns |     41.098 ns |  9.95 |    0.02 |
|                                                      Take |            [0] |    165.791 ns |   0.5628 ns |     0.5264 ns |    165.621 ns | 40.17 |    0.13 |
|                                               LowCostTake |            [0] |     52.084 ns |   0.0138 ns |     0.0129 ns |     52.084 ns | 12.62 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     44.986 ns |   0.0094 ns |     0.0083 ns |     44.989 ns | 10.90 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     63.211 ns |   0.0060 ns |     0.0053 ns |     63.212 ns | 15.32 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     54.893 ns |   0.1289 ns |     0.1205 ns |     54.974 ns | 13.30 |    0.03 |
|                                            SkipTakeSingle |            [0] |    188.734 ns |   0.0603 ns |     0.0564 ns |    188.729 ns | 45.73 |    0.02 |
|                                     LowCostSkipTakeSingle |            [0] |     61.152 ns |   0.0161 ns |     0.0135 ns |     61.150 ns | 14.82 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     60.138 ns |   0.2512 ns |     0.2349 ns |     59.987 ns | 14.57 |    0.06 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     69.406 ns |   0.0106 ns |     0.0099 ns |     69.407 ns | 16.82 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     71.869 ns |   0.0133 ns |     0.0118 ns |     71.874 ns | 17.42 |    0.01 |
|                                           ForeachDelegate |            [0] |     16.381 ns |   0.0087 ns |     0.0078 ns |     16.381 ns |  3.97 |    0.00 |
|                                                   Foreach |            [0] |     12.681 ns |   0.0344 ns |     0.0322 ns |     12.691 ns |  3.07 |    0.01 |
|                                                       For |            [0] |      4.127 ns |   0.0012 ns |     0.0011 ns |      4.127 ns |  1.00 |    0.00 |
|                                                           |                |               |             |               |               |       |         |
|                                                      **Linq** |         **[1000]** | **14,635.730 ns** |  **45.5524 ns** |    **35.5643 ns** | **14,634.024 ns** | **58.26** |    **0.14** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,924.352 ns | 365.5150 ns |   420.9276 ns | 11,733.538 ns | 47.72 |    1.88 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,770.696 ns |  68.6081 ns |    53.5647 ns | 10,758.525 ns | 42.88 |    0.21 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 10,724.227 ns | 208.7251 ns |   214.3453 ns | 10,611.292 ns | 42.77 |    0.88 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 10,788.923 ns | 141.2911 ns |   117.9845 ns | 10,745.232 ns | 42.95 |    0.47 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,854.758 ns |   0.3612 ns |     0.3202 ns |  1,854.855 ns |  7.38 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,381.369 ns |   0.1778 ns |     0.1663 ns |  1,381.376 ns |  5.50 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,255.025 ns | 462.0781 ns | 1,023.9332 ns | 23,241.501 ns | 93.31 |    3.54 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 21,507.823 ns | 396.4627 ns |   370.8515 ns | 21,342.731 ns | 85.62 |    1.48 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,320.554 ns |   2.0919 ns |     1.9567 ns |  6,320.186 ns | 25.16 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  5,603.727 ns |   6.2182 ns |     5.8165 ns |  5,605.788 ns | 22.31 |    0.02 |
|                                                 LinqCount |         [1000] |  9,984.506 ns | 199.0817 ns |   432.7873 ns |  9,825.299 ns | 40.65 |    1.68 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,761.074 ns |  57.1413 ns |    47.7155 ns | 10,770.181 ns | 42.84 |    0.19 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,253.880 ns | 274.1857 ns |   808.4426 ns |  9,738.878 ns | 39.91 |    2.60 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,721.956 ns |   0.5202 ns |     0.4343 ns |  1,721.980 ns |  6.86 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    751.726 ns |   0.1313 ns |     0.1164 ns |    751.721 ns |  2.99 |    0.00 |
|                                               LinqToArray |         [1000] | 10,998.685 ns |  25.9291 ns |    24.2541 ns | 10,989.769 ns | 43.79 |    0.10 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 12,801.873 ns |  34.4764 ns |    32.2493 ns | 12,799.403 ns | 50.96 |    0.13 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 12,150.297 ns |  17.5863 ns |    15.5898 ns | 12,148.569 ns | 48.37 |    0.06 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,360.015 ns |   2.0929 ns |     1.8553 ns |  3,359.924 ns | 13.38 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,369.197 ns |   1.0729 ns |     0.8960 ns |  2,369.216 ns |  9.43 |    0.00 |
|                                                      Take |         [1000] |    544.456 ns |   1.4453 ns |     1.2812 ns |    543.939 ns |  2.17 |    0.01 |
|                                               LowCostTake |         [1000] |    307.777 ns |   1.2915 ns |     1.0785 ns |    307.668 ns |  1.23 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    292.611 ns |   5.8769 ns |    15.7878 ns |    283.991 ns |  1.20 |    0.07 |
|                                     LowCostTakeWithStruct |         [1000] |    112.383 ns |   0.0248 ns |     0.0232 ns |    112.390 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     91.423 ns |   0.0154 ns |     0.0136 ns |     91.423 ns |  0.36 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    475.462 ns |   0.4586 ns |     0.4289 ns |    475.466 ns |  1.89 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    361.633 ns |   7.0979 ns |    11.8590 ns |    354.510 ns |  1.44 |    0.05 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    328.347 ns |   0.8535 ns |     0.7127 ns |    327.954 ns |  1.31 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    154.397 ns |   0.1233 ns |     0.1154 ns |    154.343 ns |  0.61 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    129.752 ns |   0.0879 ns |     0.0822 ns |    129.754 ns |  0.52 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,946.199 ns |   0.7297 ns |     0.6826 ns |  6,946.288 ns | 27.65 |    0.01 |
|                                                   Foreach |         [1000] |  1,690.678 ns |   0.1976 ns |     0.1650 ns |  1,690.630 ns |  6.73 |    0.00 |
|                                                       For |         [1000] |    251.192 ns |   0.0464 ns |     0.0434 ns |    251.177 ns |  1.00 |    0.00 |
|                                                           |                |               |             |               |               |       |         |
|                                                      **Linq** |           **[50]** |    **885.221 ns** |   **3.3274 ns** |     **3.1124 ns** |    **885.708 ns** | **53.32** |    **0.18** |
|                                   LowCostLinqWithDelegate |           [50] |    652.969 ns |  13.7077 ns |    39.5498 ns |    629.116 ns | 39.12 |    2.43 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    615.220 ns |  14.9129 ns |    43.7371 ns |    595.177 ns | 38.46 |    2.88 |
|                                  LowCostLinqWithDelegate2 |           [50] |    648.350 ns |  12.9255 ns |    37.0857 ns |    630.114 ns | 39.70 |    2.69 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    625.150 ns |  15.1074 ns |    43.5882 ns |    602.690 ns | 37.07 |    2.62 |
|                                LowCostLinqWithStructWhere |           [50] |    148.672 ns |   0.0207 ns |     0.0194 ns |    148.669 ns |  8.96 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    118.106 ns |   0.0297 ns |     0.0278 ns |    118.107 ns |  7.11 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,229.116 ns |  23.5083 ns |    23.0883 ns |  1,231.909 ns | 74.09 |    1.42 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,150.277 ns |   2.8907 ns |     2.5625 ns |  1,149.666 ns | 69.29 |    0.16 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    419.691 ns |   0.1504 ns |     0.1333 ns |    419.692 ns | 25.28 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    361.450 ns |   0.1685 ns |     0.1576 ns |    361.419 ns | 21.77 |    0.01 |
|                                                 LinqCount |           [50] |    594.065 ns |   1.2471 ns |     1.0414 ns |    593.847 ns | 35.79 |    0.06 |
|                              LowCostLinqWithDelegateCount |           [50] |    582.873 ns |  11.5853 ns |    25.1856 ns |    569.061 ns | 35.83 |    1.99 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    539.030 ns |  10.7628 ns |    26.4013 ns |    535.223 ns | 32.57 |    1.61 |
|                           LowCostLinqWithStructWhereCount |           [50] |    134.074 ns |   0.2427 ns |     0.2270 ns |    134.152 ns |  8.08 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     68.749 ns |   0.0179 ns |     0.0167 ns |     68.751 ns |  4.14 |    0.00 |
|                                               LinqToArray |           [50] |    921.810 ns |   1.2671 ns |     1.1232 ns |    921.825 ns | 55.53 |    0.07 |
|                            LowCostLinqWithDelegateToArray |           [50] |    797.624 ns |   2.2863 ns |     2.1386 ns |    796.624 ns | 48.04 |    0.13 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    758.759 ns |   1.3924 ns |     1.3024 ns |    759.005 ns | 45.70 |    0.08 |
|                              LowCostLinqWithStructToArray |           [50] |    289.917 ns |   0.0645 ns |     0.0572 ns |    289.939 ns | 17.46 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    219.605 ns |   0.2214 ns |     0.1962 ns |    219.628 ns | 13.23 |    0.01 |
|                                                      Take |           [50] |    543.894 ns |   0.6119 ns |     0.5723 ns |    543.769 ns | 32.76 |    0.04 |
|                                               LowCostTake |           [50] |    328.223 ns |   2.1892 ns |     2.0477 ns |    328.255 ns | 19.77 |    0.12 |
|                                  LowCostTakeWithoutChecks |           [50] |    286.630 ns |   5.7540 ns |    11.0861 ns |    280.427 ns | 17.30 |    0.69 |
|                                     LowCostTakeWithStruct |           [50] |    112.037 ns |   0.0363 ns |     0.0340 ns |    112.046 ns |  6.75 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     91.199 ns |   0.0212 ns |     0.0198 ns |     91.201 ns |  5.49 |    0.00 |
|                                            SkipTakeSingle |           [50] |    479.895 ns |   1.2815 ns |     1.1987 ns |    479.528 ns | 28.91 |    0.08 |
|                                     LowCostSkipTakeSingle |           [50] |    353.383 ns |   1.8220 ns |     1.4225 ns |    353.353 ns | 21.29 |    0.09 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    451.073 ns |   5.7306 ns |     5.3604 ns |    450.907 ns | 27.17 |    0.32 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    154.938 ns |   0.0274 ns |     0.0229 ns |    154.946 ns |  9.33 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    131.097 ns |   0.2603 ns |     0.2435 ns |    131.100 ns |  7.90 |    0.02 |
|                                           ForeachDelegate |           [50] |    370.120 ns |   0.0665 ns |     0.0556 ns |    370.107 ns | 22.30 |    0.01 |
|                                                   Foreach |           [50] |    103.108 ns |   0.0557 ns |     0.0521 ns |    103.117 ns |  6.21 |    0.00 |
|                                                       For |           [50] |     16.602 ns |   0.0079 ns |     0.0073 ns |     16.603 ns |  1.00 |    0.00 |
|                                                           |                |               |             |               |               |       |         |
|                                                      **Linq** |            **[5]** |    **239.465 ns** |   **0.0938 ns** |     **0.0877 ns** |    **239.485 ns** | **41.51** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |     98.096 ns |   1.9259 ns |     2.9984 ns |     98.452 ns | 17.10 |    0.54 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    107.276 ns |   1.8317 ns |     1.7133 ns |    107.952 ns | 18.59 |    0.29 |
|                                  LowCostLinqWithDelegate2 |            [5] |    139.151 ns |   0.6343 ns |     0.5934 ns |    139.214 ns | 24.12 |    0.10 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    110.475 ns |   2.3911 ns |     2.2366 ns |    109.533 ns | 19.15 |    0.39 |
|                                LowCostLinqWithStructWhere |            [5] |     58.194 ns |   0.0064 ns |     0.0057 ns |     58.192 ns | 10.09 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     51.794 ns |   0.0158 ns |     0.0140 ns |     51.795 ns |  8.98 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    200.427 ns |   0.2709 ns |     0.2534 ns |    200.456 ns | 34.74 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    195.713 ns |   0.3292 ns |     0.3079 ns |    195.816 ns | 33.92 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    113.230 ns |   0.2866 ns |     0.2681 ns |    113.284 ns | 19.63 |    0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    104.100 ns |   0.0652 ns |     0.0578 ns |    104.083 ns | 18.04 |    0.01 |
|                                                 LinqCount |            [5] |    175.810 ns |   0.1610 ns |     0.1506 ns |    175.793 ns | 30.47 |    0.03 |
|                              LowCostLinqWithDelegateCount |            [5] |     85.156 ns |   1.7079 ns |     3.0797 ns |     83.580 ns | 14.82 |    0.56 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     78.266 ns |   1.8509 ns |     5.4575 ns |     75.641 ns | 13.16 |    0.68 |
|                           LowCostLinqWithStructWhereCount |            [5] |     51.828 ns |   0.0119 ns |     0.0099 ns |     51.823 ns |  8.98 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     38.877 ns |   0.0079 ns |     0.0074 ns |     38.876 ns |  6.74 |    0.00 |
|                                               LinqToArray |            [5] |    242.339 ns |   0.8096 ns |     0.7573 ns |    242.380 ns | 42.00 |    0.13 |
|                            LowCostLinqWithDelegateToArray |            [5] |    123.186 ns |   0.1734 ns |     0.1622 ns |    123.185 ns | 21.35 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    117.596 ns |   0.1811 ns |     0.1694 ns |    117.599 ns | 20.38 |    0.03 |
|                              LowCostLinqWithStructToArray |            [5] |     87.651 ns |   0.0432 ns |     0.0383 ns |     87.655 ns | 15.19 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     72.920 ns |   0.0371 ns |     0.0309 ns |     72.924 ns | 12.64 |    0.01 |
|                                                      Take |            [5] |    274.024 ns |   0.1181 ns |     0.1047 ns |    274.035 ns | 47.50 |    0.03 |
|                                               LowCostTake |            [5] |    115.198 ns |   0.6529 ns |     0.6107 ns |    115.316 ns | 19.97 |    0.11 |
|                                  LowCostTakeWithoutChecks |            [5] |    100.740 ns |   2.0206 ns |     4.1275 ns |     99.710 ns | 17.50 |    0.78 |
|                                     LowCostTakeWithStruct |            [5] |     75.982 ns |   0.0257 ns |     0.0241 ns |     75.979 ns | 13.17 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     65.123 ns |   0.0182 ns |     0.0152 ns |     65.126 ns | 11.29 |    0.01 |
|                                            SkipTakeSingle |            [5] |    264.787 ns |   0.1774 ns |     0.1572 ns |    264.803 ns | 45.89 |    0.02 |
|                                     LowCostSkipTakeSingle |            [5] |    125.024 ns |   0.2308 ns |     0.2159 ns |    125.050 ns | 21.67 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    124.326 ns |   2.5042 ns |     5.6010 ns |    122.672 ns | 21.58 |    1.13 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     86.880 ns |   0.0357 ns |     0.0334 ns |     86.870 ns | 15.06 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     79.324 ns |   0.0133 ns |     0.0118 ns |     79.324 ns | 13.75 |    0.01 |
|                                           ForeachDelegate |            [5] |     50.600 ns |   0.0367 ns |     0.0343 ns |     50.610 ns |  8.77 |    0.01 |
|                                                   Foreach |            [5] |     20.609 ns |   0.0200 ns |     0.0187 ns |     20.611 ns |  3.57 |    0.00 |
|                                                       For |            [5] |      5.770 ns |   0.0026 ns |     0.0024 ns |      5.770 ns |  1.00 |    0.00 |
