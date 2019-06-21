``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **66.083 ns** |   **0.0234 ns** |   **0.0195 ns** |     **66.083 ns** | **16.73** |    **0.04** |
|                                   LowCostLinqWithDelegate |            [0] |     27.691 ns |   0.0048 ns |   0.0042 ns |     27.690 ns |  7.01 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     20.116 ns |   0.0249 ns |   0.0233 ns |     20.122 ns |  5.09 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     41.530 ns |   0.0070 ns |   0.0066 ns |     41.528 ns | 10.52 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     37.653 ns |   0.0082 ns |   0.0072 ns |     37.654 ns |  9.53 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |     36.263 ns |   0.0072 ns |   0.0067 ns |     36.265 ns |  9.18 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     28.862 ns |   0.0153 ns |   0.0143 ns |     28.860 ns |  7.31 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     65.765 ns |   1.3043 ns |   1.5020 ns |     64.789 ns | 16.71 |    0.41 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     59.309 ns |   0.0418 ns |   0.0391 ns |     59.303 ns | 15.02 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     58.115 ns |   0.0123 ns |   0.0115 ns |     58.117 ns | 14.72 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     49.612 ns |   0.0187 ns |   0.0146 ns |     49.613 ns | 12.56 |    0.03 |
|                                                 LinqCount |            [0] |     63.364 ns |   0.0206 ns |   0.0183 ns |     63.360 ns | 16.05 |    0.04 |
|                              LowCostLinqWithDelegateCount |            [0] |     25.738 ns |   0.0406 ns |   0.0379 ns |     25.750 ns |  6.52 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     23.566 ns |   0.0257 ns |   0.0240 ns |     23.572 ns |  5.97 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     28.913 ns |   0.2982 ns |   0.2789 ns |     28.768 ns |  7.32 |    0.07 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     21.303 ns |   0.0057 ns |   0.0053 ns |     21.304 ns |  5.39 |    0.01 |
|                                               LinqToArray |            [0] |     75.463 ns |   0.0194 ns |   0.0182 ns |     75.461 ns | 19.11 |    0.04 |
|                            LowCostLinqWithDelegateToArray |            [0] |     29.737 ns |   0.0266 ns |   0.0236 ns |     29.727 ns |  7.53 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     27.646 ns |   0.0230 ns |   0.0192 ns |     27.640 ns |  7.00 |    0.02 |
|                              LowCostLinqWithStructToArray |            [0] |     32.429 ns |   0.0157 ns |   0.0139 ns |     32.433 ns |  8.21 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     24.936 ns |   0.0153 ns |   0.0143 ns |     24.938 ns |  6.31 |    0.01 |
|                                                      Take |            [0] |    105.348 ns |   1.8934 ns |   1.7711 ns |    104.059 ns | 26.68 |    0.42 |
|                                               LowCostTake |            [0] |     34.809 ns |   0.0112 ns |   0.0099 ns |     34.806 ns |  8.81 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [0] |     29.360 ns |   0.0066 ns |   0.0062 ns |     29.362 ns |  7.43 |    0.02 |
|                                     LowCostTakeWithStruct |            [0] |     43.184 ns |   0.0317 ns |   0.0296 ns |     43.175 ns | 10.94 |    0.03 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     36.612 ns |   0.2869 ns |   0.2684 ns |     36.626 ns |  9.27 |    0.07 |
|                                            SkipTakeSingle |            [0] |    123.643 ns |   0.0323 ns |   0.0302 ns |    123.651 ns | 31.31 |    0.07 |
|                                     LowCostSkipTakeSingle |            [0] |     39.371 ns |   0.0074 ns |   0.0069 ns |     39.370 ns |  9.97 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     37.734 ns |   0.0081 ns |   0.0076 ns |     37.736 ns |  9.55 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     48.746 ns |   0.4416 ns |   0.4131 ns |     48.474 ns | 12.34 |    0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     40.883 ns |   0.0449 ns |   0.0420 ns |     40.894 ns | 10.35 |    0.02 |
|                                           ForeachDelegate |            [0] |     15.721 ns |   0.0184 ns |   0.0172 ns |     15.725 ns |  3.98 |    0.01 |
|                                                   Foreach |            [0] |     12.675 ns |   0.1692 ns |   0.1583 ns |     12.618 ns |  3.21 |    0.04 |
|                                                       For |            [0] |      3.949 ns |   0.0092 ns |   0.0086 ns |      3.950 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** |  **9,350.886 ns** |   **5.0129 ns** |   **4.4438 ns** |  **9,351.803 ns** | **37.28** |    **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] |  6,522.803 ns | 141.2862 ns | 224.0949 ns |  6,535.949 ns | 25.96 |    0.66 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,630.136 ns | 116.4494 ns | 209.9823 ns |  5,595.871 ns | 22.30 |    0.86 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,583.677 ns | 128.3570 ns | 166.9003 ns |  6,616.221 ns | 26.44 |    0.68 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  5,672.919 ns | 111.6905 ns | 228.1540 ns |  5,639.649 ns | 22.96 |    1.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,837.242 ns |   0.2933 ns |   0.2743 ns |  1,837.229 ns |  7.33 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,727.908 ns |   0.2094 ns |   0.1749 ns |  1,727.871 ns |  6.89 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,155.643 ns | 296.1575 ns | 277.0259 ns | 19,146.780 ns | 76.46 |    1.10 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 17,628.958 ns | 375.8444 ns | 369.1295 ns | 17,642.265 ns | 70.36 |    1.56 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,270.795 ns |   2.6229 ns |   2.4534 ns |  6,271.336 ns | 25.00 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  6,263.223 ns |   2.2294 ns |   1.9763 ns |  6,262.918 ns | 24.97 |    0.01 |
|                                                 LinqCount |         [1000] |  4,148.287 ns |   3.6047 ns |   3.3719 ns |  4,149.158 ns | 16.54 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,316.024 ns | 125.1290 ns | 133.8866 ns |  6,299.791 ns | 25.30 |    0.53 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,378.485 ns | 144.8575 ns | 128.4124 ns |  5,321.906 ns | 21.45 |    0.51 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,728.302 ns |   0.4132 ns |   0.3865 ns |  1,728.236 ns |  6.89 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,218.874 ns |   9.6306 ns |   9.0085 ns |  1,212.329 ns |  4.86 |    0.04 |
|                                               LinqToArray |         [1000] |  5,343.334 ns |   5.3127 ns |   4.9695 ns |  5,343.698 ns | 21.31 |    0.02 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,318.496 ns |   6.2312 ns |   5.5238 ns |  8,317.797 ns | 33.17 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,362.083 ns |   3.5084 ns |   2.7391 ns |  6,362.817 ns | 25.37 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,374.272 ns |   3.9989 ns |   3.1221 ns |  3,373.869 ns | 13.45 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,544.102 ns |   0.8796 ns |   0.7345 ns |  2,543.979 ns | 10.14 |    0.00 |
|                                                      Take |         [1000] |    412.042 ns |   0.2929 ns |   0.2740 ns |    412.016 ns |  1.64 |    0.00 |
|                                               LowCostTake |         [1000] |    172.521 ns |   3.4169 ns |   6.8240 ns |    170.113 ns |  0.70 |    0.04 |
|                                  LowCostTakeWithoutChecks |         [1000] |    142.528 ns |   2.8585 ns |   3.1772 ns |    143.444 ns |  0.57 |    0.01 |
|                                     LowCostTakeWithStruct |         [1000] |     84.658 ns |   0.7971 ns |   0.7456 ns |     84.362 ns |  0.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     76.247 ns |   0.0304 ns |   0.0270 ns |     76.251 ns |  0.30 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    305.516 ns |   0.1275 ns |   0.1192 ns |    305.507 ns |  1.22 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    173.639 ns |   3.4963 ns |   3.2704 ns |    172.779 ns |  0.69 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    161.501 ns |   3.2200 ns |   6.1264 ns |    162.049 ns |  0.66 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     89.297 ns |   0.0377 ns |   0.0334 ns |     89.299 ns |  0.36 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     65.933 ns |   0.1191 ns |   0.1115 ns |     65.923 ns |  0.26 |    0.00 |
|                                           ForeachDelegate |         [1000] |  4,436.643 ns |  43.9929 ns |  41.1509 ns |  4,446.485 ns | 17.69 |    0.17 |
|                                                   Foreach |         [1000] |  1,688.594 ns |   1.6780 ns |   1.5696 ns |  1,687.675 ns |  6.73 |    0.01 |
|                                                       For |         [1000] |    250.799 ns |   0.0540 ns |   0.0479 ns |    250.805 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **547.161 ns** |   **0.1080 ns** |   **0.0958 ns** |    **547.149 ns** | **34.56** |    **0.15** |
|                                   LowCostLinqWithDelegate |           [50] |    344.583 ns |   6.7656 ns |   9.4844 ns |    345.601 ns | 21.94 |    0.61 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    318.718 ns |   6.3998 ns |  14.7046 ns |    316.927 ns | 20.04 |    1.06 |
|                                  LowCostLinqWithDelegate2 |           [50] |    365.888 ns |   7.6885 ns |   7.1918 ns |    367.422 ns | 23.04 |    0.36 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    327.738 ns |   6.4134 ns |  10.7154 ns |    327.490 ns | 20.81 |    0.71 |
|                                LowCostLinqWithStructWhere |           [50] |    135.904 ns |   0.1038 ns |   0.0971 ns |    135.905 ns |  8.58 |    0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    112.939 ns |   0.1492 ns |   0.1323 ns |    112.899 ns |  7.13 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    995.306 ns |   3.0698 ns |   2.8714 ns |    996.215 ns | 62.86 |    0.34 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    919.111 ns |   1.2021 ns |   1.0657 ns |    919.546 ns | 58.06 |    0.25 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    382.892 ns |   6.2811 ns |   5.8754 ns |    378.490 ns | 24.21 |    0.36 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    368.834 ns |   0.0783 ns |   0.0732 ns |    368.830 ns | 23.30 |    0.10 |
|                                                 LinqCount |           [50] |    275.698 ns |   0.0766 ns |   0.0639 ns |    275.699 ns | 17.41 |    0.07 |
|                              LowCostLinqWithDelegateCount |           [50] |    351.257 ns |   6.8582 ns |  10.0526 ns |    351.756 ns | 21.99 |    0.60 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    291.152 ns |   0.3325 ns |   0.2596 ns |    291.105 ns | 18.38 |    0.08 |
|                           LowCostLinqWithStructWhereCount |           [50] |    121.283 ns |   0.0867 ns |   0.0768 ns |    121.292 ns |  7.66 |    0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     76.353 ns |   0.0247 ns |   0.0231 ns |     76.357 ns |  4.82 |    0.02 |
|                                               LinqToArray |           [50] |    521.984 ns |   0.3885 ns |   0.3244 ns |    521.953 ns | 32.96 |    0.14 |
|                            LowCostLinqWithDelegateToArray |           [50] |    541.424 ns |   0.8470 ns |   0.7508 ns |    541.645 ns | 34.20 |    0.18 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    459.975 ns |   0.7801 ns |   0.7297 ns |    460.028 ns | 29.06 |    0.13 |
|                              LowCostLinqWithStructToArray |           [50] |    266.727 ns |   0.1782 ns |   0.1579 ns |    266.725 ns | 16.85 |    0.07 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    218.635 ns |   3.7339 ns |   3.4927 ns |    215.995 ns | 13.82 |    0.24 |
|                                                      Take |           [50] |    411.853 ns |   0.2597 ns |   0.2429 ns |    411.851 ns | 26.02 |    0.11 |
|                                               LowCostTake |           [50] |    165.830 ns |   2.4506 ns |   2.0464 ns |    166.281 ns | 10.47 |    0.16 |
|                                  LowCostTakeWithoutChecks |           [50] |    144.757 ns |   3.0313 ns |   4.6291 ns |    144.074 ns |  9.04 |    0.23 |
|                                     LowCostTakeWithStruct |           [50] |     84.776 ns |   0.0221 ns |   0.0207 ns |     84.775 ns |  5.36 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     76.805 ns |   0.0269 ns |   0.0224 ns |     76.807 ns |  4.85 |    0.02 |
|                                            SkipTakeSingle |           [50] |    307.248 ns |   0.1444 ns |   0.1351 ns |    307.193 ns | 19.41 |    0.08 |
|                                     LowCostSkipTakeSingle |           [50] |    173.608 ns |   3.4593 ns |   5.7797 ns |    172.261 ns | 11.10 |    0.37 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    165.287 ns |   3.3166 ns |   6.6237 ns |    166.162 ns | 10.41 |    0.36 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     88.811 ns |   0.0709 ns |   0.0629 ns |     88.809 ns |  5.61 |    0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     65.583 ns |   0.0196 ns |   0.0174 ns |     65.585 ns |  4.14 |    0.02 |
|                                           ForeachDelegate |           [50] |    240.336 ns |   0.0880 ns |   0.0780 ns |    240.349 ns | 15.18 |    0.06 |
|                                                   Foreach |           [50] |    104.316 ns |   0.9509 ns |   0.8895 ns |    103.626 ns |  6.59 |    0.07 |
|                                                       For |           [50] |     15.831 ns |   0.0755 ns |   0.0670 ns |     15.823 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **116.140 ns** |   **0.0190 ns** |   **0.0178 ns** |    **116.138 ns** | **20.93** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |     58.092 ns |   1.1623 ns |   1.1936 ns |     58.099 ns | 10.47 |    0.22 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     48.224 ns |   0.9663 ns |   1.6408 ns |     48.618 ns |  8.74 |    0.29 |
|                                  LowCostLinqWithDelegate2 |            [5] |     74.562 ns |   1.4144 ns |   1.3230 ns |     74.434 ns | 13.44 |    0.24 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     68.074 ns |   1.3582 ns |   1.9040 ns |     67.925 ns | 12.24 |    0.38 |
|                                LowCostLinqWithStructWhere |            [5] |     47.367 ns |   0.0151 ns |   0.0126 ns |     47.364 ns |  8.54 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     36.970 ns |   0.0687 ns |   0.0642 ns |     36.966 ns |  6.66 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    155.912 ns |   0.1575 ns |   0.1396 ns |    155.920 ns | 28.10 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    144.958 ns |   0.1295 ns |   0.1212 ns |    144.988 ns | 26.13 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     89.923 ns |   0.0334 ns |   0.0313 ns |     89.918 ns | 16.21 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     81.445 ns |   0.0196 ns |   0.0183 ns |     81.449 ns | 14.68 |    0.01 |
|                                                 LinqCount |            [5] |     85.363 ns |   0.0451 ns |   0.0422 ns |     85.364 ns | 15.39 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |     60.435 ns |   1.1854 ns |   1.2173 ns |     60.863 ns | 10.90 |    0.23 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     50.108 ns |   1.0035 ns |   1.3048 ns |     49.730 ns |  9.06 |    0.21 |
|                           LowCostLinqWithStructWhereCount |            [5] |     37.435 ns |   0.0066 ns |   0.0059 ns |     37.436 ns |  6.75 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     27.251 ns |   0.1017 ns |   0.0951 ns |     27.285 ns |  4.91 |    0.02 |
|                                               LinqToArray |            [5] |    147.638 ns |   2.9651 ns |   3.5297 ns |    144.966 ns | 26.79 |    0.67 |
|                            LowCostLinqWithDelegateToArray |            [5] |     98.674 ns |   0.0570 ns |   0.0533 ns |     98.665 ns | 17.78 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     85.743 ns |   0.0360 ns |   0.0337 ns |     85.736 ns | 15.45 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     75.017 ns |   1.3515 ns |   1.2642 ns |     75.217 ns | 13.52 |    0.23 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     62.159 ns |   0.0166 ns |   0.0155 ns |     62.167 ns | 11.20 |    0.01 |
|                                                      Take |            [5] |    199.271 ns |   0.0554 ns |   0.0491 ns |    199.264 ns | 35.91 |    0.03 |
|                                               LowCostTake |            [5] |     66.699 ns |   1.2128 ns |   1.1345 ns |     67.202 ns | 12.02 |    0.21 |
|                                  LowCostTakeWithoutChecks |            [5] |     57.484 ns |   1.1723 ns |   1.5243 ns |     56.678 ns | 10.37 |    0.29 |
|                                     LowCostTakeWithStruct |            [5] |     53.190 ns |   0.0090 ns |   0.0084 ns |     53.193 ns |  9.59 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     46.250 ns |   0.1323 ns |   0.1105 ns |     46.279 ns |  8.33 |    0.02 |
|                                            SkipTakeSingle |            [5] |    163.014 ns |   0.0397 ns |   0.0372 ns |    163.011 ns | 29.38 |    0.03 |
|                                     LowCostSkipTakeSingle |            [5] |     66.299 ns |   0.3279 ns |   0.2907 ns |     66.251 ns | 11.95 |    0.05 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     60.286 ns |   1.2426 ns |   1.2760 ns |     60.105 ns | 10.88 |    0.24 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     58.297 ns |   0.5044 ns |   0.4718 ns |     57.995 ns | 10.51 |    0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.542 ns |   0.0589 ns |   0.0551 ns |     46.546 ns |  8.39 |    0.01 |
|                                           ForeachDelegate |            [5] |     36.594 ns |   0.0536 ns |   0.0501 ns |     36.609 ns |  6.60 |    0.01 |
|                                                   Foreach |            [5] |     20.590 ns |   0.0265 ns |   0.0235 ns |     20.593 ns |  3.71 |    0.00 |
|                                                       For |            [5] |      5.548 ns |   0.0052 ns |   0.0049 ns |      5.549 ns |  1.00 |    0.00 |
