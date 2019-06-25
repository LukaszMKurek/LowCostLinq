``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **95.853 ns** |   **0.0297 ns** |   **0.0277 ns** |     **95.853 ns** | **23.13** |    **0.04** |
|                                   LowCostLinqWithDelegate |            [0] |     31.577 ns |   0.0028 ns |   0.0027 ns |     31.577 ns |  7.62 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     22.965 ns |   0.0044 ns |   0.0039 ns |     22.964 ns |  5.54 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     57.168 ns |   0.0478 ns |   0.0447 ns |     57.179 ns | 13.79 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     47.597 ns |   0.0121 ns |   0.0108 ns |     47.595 ns | 11.48 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |     42.221 ns |   0.0067 ns |   0.0063 ns |     42.222 ns | 10.19 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     35.863 ns |   0.0069 ns |   0.0065 ns |     35.861 ns |  8.65 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     72.362 ns |   0.0278 ns |   0.0260 ns |     72.359 ns | 17.46 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     67.400 ns |   0.1203 ns |   0.1126 ns |     67.356 ns | 16.26 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     67.825 ns |   0.0185 ns |   0.0164 ns |     67.825 ns | 16.37 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     61.051 ns |   0.0266 ns |   0.0249 ns |     61.050 ns | 14.73 |    0.02 |
|                                                 LinqCount |            [0] |     95.799 ns |   0.0451 ns |   0.0422 ns |     95.797 ns | 23.12 |    0.04 |
|                              LowCostLinqWithDelegateCount |            [0] |     27.559 ns |   0.0271 ns |   0.0253 ns |     27.567 ns |  6.65 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     25.048 ns |   0.0199 ns |   0.0186 ns |     25.050 ns |  6.04 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     36.512 ns |   0.0101 ns |   0.0094 ns |     36.511 ns |  8.81 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     28.743 ns |   0.0120 ns |   0.0107 ns |     28.742 ns |  6.94 |    0.01 |
|                                               LinqToArray |            [0] |    117.215 ns |   0.0658 ns |   0.0616 ns |    117.222 ns | 28.28 |    0.05 |
|                            LowCostLinqWithDelegateToArray |            [0] |     31.327 ns |   0.0243 ns |   0.0227 ns |     31.335 ns |  7.56 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     30.310 ns |   0.0277 ns |   0.0259 ns |     30.308 ns |  7.31 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     40.576 ns |   0.0564 ns |   0.0528 ns |     40.557 ns |  9.79 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     33.854 ns |   0.0176 ns |   0.0164 ns |     33.858 ns |  8.17 |    0.01 |
|                                                      Take |            [0] |    133.730 ns |   0.0603 ns |   0.0534 ns |    133.740 ns | 32.27 |    0.04 |
|                                               LowCostTake |            [0] |     36.657 ns |   0.0084 ns |   0.0079 ns |     36.657 ns |  8.84 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     32.619 ns |   0.0129 ns |   0.0114 ns |     32.617 ns |  7.87 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     48.545 ns |   0.0133 ns |   0.0124 ns |     48.543 ns | 11.71 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     43.273 ns |   0.0086 ns |   0.0080 ns |     43.272 ns | 10.44 |    0.01 |
|                                            SkipTakeSingle |            [0] |    153.247 ns |   0.0614 ns |   0.0574 ns |    153.249 ns | 36.98 |    0.05 |
|                                     LowCostSkipTakeSingle |            [0] |     44.022 ns |   0.0080 ns |   0.0075 ns |     44.021 ns | 10.62 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     41.858 ns |   0.0140 ns |   0.0124 ns |     41.855 ns | 10.10 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     56.275 ns |   0.0979 ns |   0.0916 ns |     56.314 ns | 13.58 |    0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     48.605 ns |   0.0145 ns |   0.0135 ns |     48.607 ns | 11.73 |    0.02 |
|                                           ForeachDelegate |            [0] |     16.289 ns |   0.0124 ns |   0.0116 ns |     16.292 ns |  3.93 |    0.01 |
|                                                   Foreach |            [0] |     12.631 ns |   0.0197 ns |   0.0184 ns |     12.633 ns |  3.05 |    0.01 |
|                                                       For |            [0] |      4.144 ns |   0.0062 ns |   0.0058 ns |      4.145 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** | **13,246.311 ns** | **263.9673 ns** | **550.9980 ns** | **12,885.156 ns** | **53.88** |    **2.55** |
|                                   LowCostLinqWithDelegate |         [1000] |  8,551.361 ns |  63.2353 ns |  52.8043 ns |  8,527.240 ns | 33.94 |    0.22 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,232.400 ns | 164.1698 ns | 441.0315 ns |  7,969.738 ns | 32.56 |    1.57 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,698.450 ns | 193.7066 ns | 539.9765 ns |  9,514.934 ns | 38.16 |    1.98 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  9,887.474 ns | 197.4625 ns | 429.2672 ns |  9,986.359 ns | 39.15 |    1.63 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,844.224 ns |   0.3803 ns |   0.3176 ns |  1,844.320 ns |  7.32 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,385.928 ns |   1.6820 ns |   1.5734 ns |  1,386.131 ns |  5.50 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 20,766.817 ns | 409.6421 ns | 706.6124 ns | 20,650.769 ns | 82.80 |    3.30 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,971.538 ns | 393.8264 ns | 647.0681 ns | 20,181.271 ns | 79.41 |    2.71 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  7,007.717 ns |   2.6661 ns |   2.4939 ns |  7,008.012 ns | 27.81 |    0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  6,720.817 ns |   4.1921 ns |   3.9213 ns |  6,721.792 ns | 26.67 |    0.06 |
|                                                 LinqCount |         [1000] |  6,648.818 ns | 126.8237 ns | 118.6309 ns |  6,646.140 ns | 26.39 |    0.50 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,918.345 ns | 180.3584 ns | 531.7909 ns |  8,669.086 ns | 35.78 |    2.52 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,390.785 ns | 204.0559 ns | 601.6635 ns |  8,426.083 ns | 32.75 |    2.32 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,715.882 ns |   0.2589 ns |   0.2295 ns |  1,715.857 ns |  6.81 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    742.991 ns |   0.8928 ns |   0.8351 ns |    743.129 ns |  2.95 |    0.01 |
|                                               LinqToArray |         [1000] |  8,938.366 ns |  36.0766 ns |  31.9810 ns |  8,938.078 ns | 35.48 |    0.15 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,600.396 ns |  13.9809 ns |  13.0777 ns |  9,599.657 ns | 38.10 |    0.12 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 10,071.605 ns |  24.5460 ns |  22.9604 ns | 10,073.407 ns | 39.97 |    0.15 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,351.672 ns |   3.7373 ns |   3.3130 ns |  3,350.770 ns | 13.30 |    0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,142.929 ns |   6.6235 ns |   5.8716 ns |  2,141.223 ns |  8.51 |    0.03 |
|                                                      Take |         [1000] |    496.241 ns |   1.0190 ns |   0.9033 ns |    496.487 ns |  1.97 |    0.01 |
|                                               LowCostTake |         [1000] |    258.339 ns |   2.5603 ns |   2.3949 ns |    258.357 ns |  1.03 |    0.01 |
|                                  LowCostTakeWithoutChecks |         [1000] |    207.316 ns |   4.4735 ns |  13.1902 ns |    200.637 ns |  0.83 |    0.06 |
|                                     LowCostTakeWithStruct |         [1000] |     89.156 ns |   0.0042 ns |   0.0039 ns |     89.153 ns |  0.35 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     72.673 ns |   0.0230 ns |   0.0215 ns |     72.669 ns |  0.29 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    392.558 ns |   0.4167 ns |   0.3898 ns |    392.382 ns |  1.56 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    245.113 ns |   2.8107 ns |   2.3471 ns |    244.299 ns |  0.97 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    240.718 ns |   4.8393 ns |  13.9626 ns |    231.349 ns |  0.99 |    0.06 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    110.735 ns |   0.0509 ns |   0.0476 ns |    110.754 ns |  0.44 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     76.940 ns |   0.0203 ns |   0.0180 ns |     76.939 ns |  0.31 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,140.899 ns |  11.5820 ns |  10.8338 ns |  6,144.061 ns | 24.37 |    0.07 |
|                                                   Foreach |         [1000] |  1,690.715 ns |   0.5875 ns |   0.4906 ns |  1,690.597 ns |  6.71 |    0.01 |
|                                                       For |         [1000] |    251.977 ns |   0.5645 ns |   0.5281 ns |    252.278 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **725.705 ns** |   **1.7901 ns** |   **1.6745 ns** |    **725.452 ns** | **40.96** |    **0.10** |
|                                   LowCostLinqWithDelegate |           [50] |    768.913 ns |  12.3602 ns |  11.5617 ns |    771.546 ns | 43.40 |    0.64 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    449.767 ns |   8.9931 ns |  24.3134 ns |    443.836 ns | 25.09 |    1.31 |
|                                  LowCostLinqWithDelegate2 |           [50] |    521.154 ns |  10.6162 ns |  31.3020 ns |    503.241 ns | 29.38 |    1.76 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    518.104 ns |  13.8142 ns |  40.7316 ns |    488.845 ns | 29.76 |    2.33 |
|                                LowCostLinqWithStructWhere |           [50] |    140.024 ns |   0.0369 ns |   0.0345 ns |    140.025 ns |  7.90 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    113.235 ns |   0.0097 ns |   0.0086 ns |    113.237 ns |  6.39 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,129.845 ns |   5.8068 ns |   5.4317 ns |  1,129.684 ns | 63.77 |    0.35 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,053.993 ns |  11.6677 ns |  10.9140 ns |  1,049.678 ns | 59.49 |    0.60 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    420.976 ns |   0.0702 ns |   0.0622 ns |    420.987 ns | 23.75 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    382.780 ns |   0.1816 ns |   0.1418 ns |    382.723 ns | 21.60 |    0.01 |
|                                                 LinqCount |           [50] |    424.467 ns |   2.4218 ns |   2.2653 ns |    424.831 ns | 23.96 |    0.13 |
|                              LowCostLinqWithDelegateCount |           [50] |    473.631 ns |   9.4660 ns |  26.3875 ns |    456.100 ns | 26.19 |    1.23 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    643.196 ns |  35.0280 ns | 100.5019 ns |    693.662 ns | 39.58 |    0.97 |
|                           LowCostLinqWithStructWhereCount |           [50] |    125.570 ns |   0.0313 ns |   0.0261 ns |    125.574 ns |  7.09 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     62.055 ns |   0.0129 ns |   0.0120 ns |     62.050 ns |  3.50 |    0.00 |
|                                               LinqToArray |           [50] |    738.787 ns |   0.7148 ns |   0.6336 ns |    738.944 ns | 41.69 |    0.05 |
|                            LowCostLinqWithDelegateToArray |           [50] |    620.560 ns |   1.1680 ns |   1.0926 ns |    620.074 ns | 35.03 |    0.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    620.708 ns |   0.7827 ns |   0.7322 ns |    620.780 ns | 35.03 |    0.07 |
|                              LowCostLinqWithStructToArray |           [50] |    285.687 ns |   0.0859 ns |   0.0671 ns |    285.691 ns | 16.12 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    202.464 ns |   0.0977 ns |   0.0763 ns |    202.476 ns | 11.42 |    0.01 |
|                                                      Take |           [50] |    480.829 ns |   0.5534 ns |   0.5176 ns |    480.886 ns | 27.14 |    0.04 |
|                                               LowCostTake |           [50] |    369.596 ns |   7.3054 ns |   8.1200 ns |    369.563 ns | 20.79 |    0.45 |
|                                  LowCostTakeWithoutChecks |           [50] |    206.314 ns |   4.1516 ns |  11.7096 ns |    199.647 ns | 11.51 |    0.53 |
|                                     LowCostTakeWithStruct |           [50] |     90.998 ns |   0.1298 ns |   0.1215 ns |     91.014 ns |  5.14 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     73.078 ns |   0.0134 ns |   0.0126 ns |     73.079 ns |  4.12 |    0.01 |
|                                            SkipTakeSingle |           [50] |    391.935 ns |   0.2769 ns |   0.2454 ns |    391.867 ns | 22.11 |    0.02 |
|                                     LowCostSkipTakeSingle |           [50] |    249.141 ns |   6.2434 ns |   8.3347 ns |    244.728 ns | 14.25 |    0.54 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    230.184 ns |   0.5507 ns |   0.4599 ns |    230.189 ns | 12.99 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    110.649 ns |   0.0496 ns |   0.0464 ns |    110.637 ns |  6.25 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     76.645 ns |   0.0182 ns |   0.0162 ns |     76.643 ns |  4.32 |    0.00 |
|                                           ForeachDelegate |           [50] |    331.012 ns |   0.0579 ns |   0.0541 ns |    331.018 ns | 18.68 |    0.02 |
|                                                   Foreach |           [50] |    104.919 ns |   0.0272 ns |   0.0255 ns |    104.918 ns |  5.92 |    0.01 |
|                                                       For |           [50] |     17.718 ns |   0.0241 ns |   0.0225 ns |     17.721 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **160.601 ns** |   **0.3111 ns** |   **0.2910 ns** |    **160.445 ns** | **27.85** |    **0.05** |
|                                   LowCostLinqWithDelegate |            [5] |     93.153 ns |   5.5815 ns |  16.4571 ns |    104.260 ns | 18.03 |    1.36 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     65.069 ns |   1.3252 ns |   3.8023 ns |     63.466 ns | 11.46 |    0.76 |
|                                  LowCostLinqWithDelegate2 |            [5] |     96.669 ns |   3.7421 ns |   3.3173 ns |     95.230 ns | 16.77 |    0.57 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     94.732 ns |   1.9193 ns |   5.1230 ns |     93.430 ns | 16.76 |    0.85 |
|                                LowCostLinqWithStructWhere |            [5] |     52.944 ns |   0.0155 ns |   0.0145 ns |     52.940 ns |  9.18 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     44.915 ns |   0.0895 ns |   0.0838 ns |     44.928 ns |  7.79 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    180.894 ns |   0.1158 ns |   0.1083 ns |    180.874 ns | 31.37 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    175.736 ns |   0.9266 ns |   0.8668 ns |    175.924 ns | 30.48 |    0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    100.171 ns |   0.0330 ns |   0.0309 ns |    100.167 ns | 17.37 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     94.644 ns |   0.0346 ns |   0.0323 ns |     94.638 ns | 16.41 |    0.01 |
|                                                 LinqCount |            [5] |    138.774 ns |   0.5578 ns |   0.5218 ns |    138.736 ns | 24.07 |    0.09 |
|                              LowCostLinqWithDelegateCount |            [5] |    101.604 ns |   2.0497 ns |   3.1301 ns |    102.049 ns | 17.55 |    0.69 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     62.824 ns |   1.2684 ns |   2.1880 ns |     61.677 ns | 10.89 |    0.42 |
|                           LowCostLinqWithStructWhereCount |            [5] |     44.405 ns |   0.0105 ns |   0.0093 ns |     44.406 ns |  7.70 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     31.243 ns |   0.0261 ns |   0.0232 ns |     31.243 ns |  5.42 |    0.00 |
|                                               LinqToArray |            [5] |    216.147 ns |   2.7733 ns |   2.5942 ns |    217.184 ns | 37.49 |    0.45 |
|                            LowCostLinqWithDelegateToArray |            [5] |    107.145 ns |   0.6859 ns |   0.6416 ns |    107.202 ns | 18.58 |    0.11 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    102.769 ns |   0.0694 ns |   0.0649 ns |    102.785 ns | 17.82 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     80.926 ns |   0.0478 ns |   0.0424 ns |     80.908 ns | 14.03 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     65.168 ns |   0.1430 ns |   0.1338 ns |     65.086 ns | 11.30 |    0.02 |
|                                                      Take |            [5] |    233.941 ns |   0.1538 ns |   0.1439 ns |    233.902 ns | 40.57 |    0.03 |
|                                               LowCostTake |            [5] |     82.395 ns |   1.6153 ns |   1.4320 ns |     81.815 ns | 14.29 |    0.25 |
|                                  LowCostTakeWithoutChecks |            [5] |     74.492 ns |   0.7894 ns |   0.6997 ns |     74.569 ns | 12.92 |    0.12 |
|                                     LowCostTakeWithStruct |            [5] |     60.318 ns |   0.0146 ns |   0.0137 ns |     60.317 ns | 10.46 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     51.271 ns |   0.0086 ns |   0.0080 ns |     51.273 ns |  8.89 |    0.00 |
|                                            SkipTakeSingle |            [5] |    207.812 ns |   0.0447 ns |   0.0396 ns |    207.803 ns | 36.04 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     86.752 ns |   1.7501 ns |   1.6371 ns |     87.112 ns | 15.04 |    0.28 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     79.935 ns |   1.6145 ns |   4.6582 ns |     78.498 ns | 13.49 |    0.71 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     66.445 ns |   0.0459 ns |   0.0429 ns |     66.441 ns | 11.52 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     54.874 ns |   0.0122 ns |   0.0114 ns |     54.871 ns |  9.52 |    0.00 |
|                                           ForeachDelegate |            [5] |     45.850 ns |   0.0098 ns |   0.0087 ns |     45.848 ns |  7.95 |    0.00 |
|                                                   Foreach |            [5] |     20.734 ns |   0.0324 ns |   0.0303 ns |     20.733 ns |  3.60 |    0.01 |
|                                                       For |            [5] |      5.766 ns |   0.0017 ns |   0.0016 ns |      5.766 ns |  1.00 |    0.00 |
