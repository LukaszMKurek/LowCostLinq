``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |      Error |     StdDev |        Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|-----------:|-----------:|--------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **63.527 ns** |  **0.1293 ns** |  **0.1209 ns** |     **63.497 ns** |  **22.31** |     **0.04** |
|                                   LowCostLinqWithDelegate |              0 |     27.691 ns |  0.0025 ns |  0.0021 ns |     27.690 ns |   9.72 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     19.837 ns |  0.0015 ns |  0.0012 ns |     19.837 ns |   6.97 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     41.050 ns |  0.0038 ns |  0.0032 ns |     41.049 ns |  14.42 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     37.219 ns |  0.0018 ns |  0.0017 ns |     37.220 ns |  13.07 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     35.539 ns |  0.0011 ns |  0.0010 ns |     35.539 ns |  12.48 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     27.251 ns |  0.0042 ns |  0.0035 ns |     27.250 ns |   9.57 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     56.984 ns |  0.0524 ns |  0.0490 ns |     56.971 ns |  20.01 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     51.790 ns |  0.0719 ns |  0.0673 ns |     51.823 ns |  18.19 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     55.110 ns |  0.0448 ns |  0.0397 ns |     55.089 ns |  19.35 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     39.649 ns |  0.0619 ns |  0.0579 ns |     39.673 ns |  13.92 |     0.02 |
|                                                 LinqCount |              0 |     60.186 ns |  0.0352 ns |  0.0312 ns |     60.184 ns |  21.13 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     25.079 ns |  0.0150 ns |  0.0133 ns |     25.083 ns |   8.81 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     23.113 ns |  0.0052 ns |  0.0044 ns |     23.112 ns |   8.12 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     28.404 ns |  0.0024 ns |  0.0022 ns |     28.404 ns |   9.97 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     22.636 ns |  0.0013 ns |  0.0011 ns |     22.635 ns |   7.95 |     0.00 |
|                                               LinqToArray |              0 |     71.175 ns |  0.0989 ns |  0.0925 ns |     71.158 ns |  24.99 |     0.03 |
|                            LowCostLinqWithDelegateToArray |              0 |     27.448 ns |  0.0146 ns |  0.0130 ns |     27.451 ns |   9.64 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     28.148 ns |  0.1274 ns |  0.1192 ns |     28.104 ns |   9.88 |     0.04 |
|                              LowCostLinqWithStructToArray |              0 |     31.210 ns |  0.0568 ns |  0.0504 ns |     31.203 ns |  10.96 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     23.781 ns |  0.0065 ns |  0.0058 ns |     23.780 ns |   8.35 |     0.00 |
|                                                      Take |              0 |    100.515 ns |  0.5947 ns |  0.5272 ns |    100.479 ns |  35.30 |     0.18 |
|                                               LowCostTake |              0 |     38.686 ns |  0.0346 ns |  0.0324 ns |     38.673 ns |  13.59 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     29.357 ns |  0.0025 ns |  0.0023 ns |     29.357 ns |  10.31 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     41.507 ns |  0.0027 ns |  0.0021 ns |     41.508 ns |  14.58 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     36.022 ns |  0.0012 ns |  0.0010 ns |     36.022 ns |  12.65 |     0.00 |
|                                            SkipTakeSingle |              0 |    121.927 ns |  0.0913 ns |  0.0854 ns |    121.934 ns |  42.82 |     0.03 |
|                                     LowCostSkipTakeSingle |              0 |     44.162 ns |  0.0068 ns |  0.0063 ns |     44.159 ns |  15.51 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     36.991 ns |  0.0015 ns |  0.0013 ns |     36.991 ns |  12.99 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     47.264 ns |  0.0052 ns |  0.0046 ns |     47.263 ns |  16.60 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     39.954 ns |  0.0942 ns |  0.0881 ns |     40.014 ns |  14.03 |     0.03 |
|                                           ForeachDelegate |              0 |     15.793 ns |  0.0193 ns |  0.0180 ns |     15.793 ns |   5.55 |     0.01 |
|                                                   Foreach |              0 |     12.210 ns |  0.0083 ns |  0.0078 ns |     12.213 ns |   4.29 |     0.00 |
|                                                       For |              0 |      2.848 ns |  0.0007 ns |  0.0006 ns |      2.848 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |           **1000** |  **9,301.587 ns** |  **8.1719 ns** |  **7.6440 ns** |  **9,302.818 ns** |  **37.11** |     **0.03** |
|                                   LowCostLinqWithDelegate |           1000 |  6,239.748 ns |  6.2364 ns |  5.8335 ns |  6,242.588 ns |  24.90 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,045.021 ns |  2.1887 ns |  1.4477 ns |  5,044.995 ns |  20.13 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           1000 |  5,848.324 ns |  6.9697 ns |  6.5195 ns |  5,850.063 ns |  23.34 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  4,858.841 ns |  2.1717 ns |  2.0314 ns |  4,858.188 ns |  19.39 |     0.01 |
|                                LowCostLinqWithStructWhere |           1000 |  1,842.483 ns |  1.6439 ns |  1.5377 ns |  1,842.226 ns |   7.35 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,728.379 ns |  0.1106 ns |  0.1034 ns |  1,728.357 ns |   6.90 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 17,769.243 ns | 14.6096 ns | 13.6658 ns | 17,772.023 ns |  70.90 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 15,817.193 ns |  2.9351 ns |  2.6019 ns | 15,816.645 ns |  63.11 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,489.677 ns |  3.2843 ns |  2.7425 ns |  6,489.770 ns |  25.89 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  5,694.774 ns | 10.3082 ns |  9.6423 ns |  5,695.875 ns |  22.72 |     0.04 |
|                                                 LinqCount |           1000 |  3,910.226 ns |  2.9526 ns |  2.4656 ns |  3,910.672 ns |  15.60 |     0.01 |
|                              LowCostLinqWithDelegateCount |           1000 |  5,924.788 ns | 40.8072 ns | 38.1711 ns |  5,908.967 ns |  23.64 |     0.15 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,575.118 ns |  2.7020 ns |  2.5275 ns |  4,575.497 ns |  18.25 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,731.485 ns |  1.3244 ns |  1.2389 ns |  1,731.847 ns |   6.91 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,210.935 ns |  0.0904 ns |  0.0706 ns |  1,210.919 ns |   4.83 |     0.00 |
|                                               LinqToArray |           1000 |  5,511.868 ns | 10.6745 ns |  9.9849 ns |  5,510.586 ns |  21.99 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,790.094 ns | 12.5356 ns | 11.7258 ns |  7,792.277 ns |  31.08 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  6,081.340 ns |  6.1867 ns |  5.4844 ns |  6,080.935 ns |  24.26 |     0.02 |
|                              LowCostLinqWithStructToArray |           1000 |  3,353.864 ns |  6.2862 ns |  5.5725 ns |  3,353.470 ns |  13.38 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,339.431 ns |  7.9410 ns |  7.4280 ns |  2,340.014 ns |   9.33 |     0.03 |
|                                                      Take |           1000 |    392.157 ns |  0.3684 ns |  0.3446 ns |    392.294 ns |   1.56 |     0.00 |
|                                               LowCostTake |           1000 |    177.246 ns |  0.0211 ns |  0.0187 ns |    177.246 ns |   0.71 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    147.875 ns |  0.1124 ns |  0.1051 ns |    147.942 ns |   0.59 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     82.067 ns |  0.0192 ns |  0.0170 ns |     82.065 ns |   0.33 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     84.098 ns |  0.0293 ns |  0.0229 ns |     84.100 ns |   0.34 |     0.00 |
|                                            SkipTakeSingle |           1000 |    305.353 ns |  0.0827 ns |  0.0773 ns |    305.360 ns |   1.22 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    185.406 ns |  0.0546 ns |  0.0484 ns |    185.399 ns |   0.74 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    158.032 ns |  0.1452 ns |  0.1358 ns |    158.017 ns |   0.63 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     88.583 ns |  0.0720 ns |  0.0673 ns |     88.611 ns |   0.35 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     65.666 ns |  0.0300 ns |  0.0281 ns |     65.669 ns |   0.26 |     0.00 |
|                                           ForeachDelegate |           1000 |  4,790.755 ns |  2.6992 ns |  2.5248 ns |  4,791.590 ns |  19.12 |     0.01 |
|                                                   Foreach |           1000 |  1,689.747 ns |  1.2662 ns |  1.1844 ns |  1,689.369 ns |   6.74 |     0.01 |
|                                                       For |           1000 |    250.623 ns |  0.1009 ns |  0.0895 ns |    250.618 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |              **5** |    **113.210 ns** |  **0.3550 ns** |  **0.3321 ns** |    **113.132 ns** |  **27.74** |     **0.10** |
|                                   LowCostLinqWithDelegate |              5 |     54.623 ns |  0.0302 ns |  0.0268 ns |     54.605 ns |  13.38 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     42.262 ns |  0.0104 ns |  0.0093 ns |     42.262 ns |  10.35 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              5 |     69.584 ns |  0.1022 ns |  0.0906 ns |     69.567 ns |  17.05 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     63.786 ns |  0.0752 ns |  0.0704 ns |     63.778 ns |  15.63 |     0.04 |
|                                LowCostLinqWithStructWhere |              5 |     46.535 ns |  0.0161 ns |  0.0151 ns |     46.532 ns |  11.40 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     37.725 ns |  0.0363 ns |  0.0322 ns |     37.728 ns |   9.24 |     0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    146.853 ns |  0.1487 ns |  0.1390 ns |    146.809 ns |  35.98 |     0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    132.374 ns |  0.3453 ns |  0.3230 ns |    132.573 ns |  32.43 |     0.10 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |     79.634 ns |  0.0379 ns |  0.0354 ns |     79.629 ns |  19.51 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |     68.476 ns |  0.0598 ns |  0.0560 ns |     68.497 ns |  16.78 |     0.04 |
|                                                 LinqCount |              5 |     80.203 ns |  0.0885 ns |  0.0827 ns |     80.221 ns |  19.65 |     0.04 |
|                              LowCostLinqWithDelegateCount |              5 |     55.366 ns |  0.0970 ns |  0.0908 ns |     55.416 ns |  13.57 |     0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     45.970 ns |  0.0506 ns |  0.0473 ns |     45.952 ns |  11.26 |     0.03 |
|                           LowCostLinqWithStructWhereCount |              5 |     36.524 ns |  0.0096 ns |  0.0075 ns |     36.522 ns |   8.95 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     24.808 ns |  0.0502 ns |  0.0469 ns |     24.834 ns |   6.08 |     0.02 |
|                                               LinqToArray |              5 |    140.562 ns |  0.0913 ns |  0.0854 ns |    140.533 ns |  34.44 |     0.07 |
|                            LowCostLinqWithDelegateToArray |              5 |     94.681 ns |  0.0769 ns |  0.0720 ns |     94.707 ns |  23.20 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     85.791 ns |  0.1330 ns |  0.1244 ns |     85.791 ns |  21.02 |     0.05 |
|                              LowCostLinqWithStructToArray |              5 |     74.663 ns |  0.2247 ns |  0.2102 ns |     74.819 ns |  18.29 |     0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     62.873 ns |  0.0477 ns |  0.0446 ns |     62.858 ns |  15.40 |     0.03 |
|                                                      Take |              5 |    175.034 ns |  0.2011 ns |  0.1881 ns |    175.112 ns |  42.89 |     0.10 |
|                                               LowCostTake |              5 |     61.693 ns |  0.0094 ns |  0.0078 ns |     61.689 ns |  15.12 |     0.03 |
|                                  LowCostTakeWithoutChecks |              5 |     52.514 ns |  0.0223 ns |  0.0174 ns |     52.510 ns |  12.87 |     0.03 |
|                                     LowCostTakeWithStruct |              5 |     52.500 ns |  0.0181 ns |  0.0170 ns |     52.500 ns |  12.86 |     0.03 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     45.169 ns |  0.0093 ns |  0.0087 ns |     45.167 ns |  11.07 |     0.02 |
|                                            SkipTakeSingle |              5 |    165.516 ns |  0.0676 ns |  0.0633 ns |    165.503 ns |  40.55 |     0.08 |
|                                     LowCostSkipTakeSingle |              5 |     64.141 ns |  0.0242 ns |  0.0160 ns |     64.144 ns |  15.72 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     55.922 ns |  0.0677 ns |  0.0633 ns |     55.928 ns |  13.70 |     0.03 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     56.811 ns |  0.0109 ns |  0.0096 ns |     56.815 ns |  13.92 |     0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     45.569 ns |  0.0183 ns |  0.0162 ns |     45.567 ns |  11.16 |     0.02 |
|                                           ForeachDelegate |              5 |     38.992 ns |  0.3866 ns |  0.3617 ns |     38.997 ns |   9.55 |     0.09 |
|                                                   Foreach |              5 |     19.701 ns |  0.0234 ns |  0.0219 ns |     19.699 ns |   4.83 |     0.01 |
|                                                       For |              5 |      4.081 ns |  0.0090 ns |  0.0084 ns |      4.082 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |             **50** |    **547.383 ns** |  **0.1522 ns** |  **0.1271 ns** |    **547.414 ns** |  **35.17** |     **0.04** |
|                                   LowCostLinqWithDelegate |             50 |    338.849 ns |  0.9001 ns |  0.8420 ns |    339.277 ns |  21.77 |     0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    278.193 ns |  5.3127 ns |  5.2178 ns |    273.852 ns |  17.88 |     0.33 |
|                                  LowCostLinqWithDelegate2 |             50 |    336.010 ns |  0.2140 ns |  0.2001 ns |    336.058 ns |  21.59 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    281.699 ns |  0.1925 ns |  0.1800 ns |    281.594 ns |  18.10 |     0.02 |
|                                LowCostLinqWithStructWhere |             50 |    133.315 ns |  0.2443 ns |  0.2286 ns |    133.261 ns |   8.57 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    112.967 ns |  0.0369 ns |  0.0345 ns |    112.963 ns |   7.26 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    953.492 ns |  1.4489 ns |  1.3553 ns |    953.348 ns |  61.27 |     0.10 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    849.118 ns |  0.7992 ns |  0.7475 ns |    849.123 ns |  54.56 |     0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    376.897 ns |  0.3234 ns |  0.2866 ns |    376.778 ns |  24.22 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    335.591 ns |  0.0563 ns |  0.0526 ns |    335.579 ns |  21.57 |     0.02 |
|                                                 LinqCount |             50 |    259.200 ns |  0.5527 ns |  0.5170 ns |    258.864 ns |  16.66 |     0.04 |
|                              LowCostLinqWithDelegateCount |             50 |    321.295 ns |  0.0805 ns |  0.0713 ns |    321.322 ns |  20.65 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    255.197 ns |  0.0662 ns |  0.0587 ns |    255.194 ns |  16.40 |     0.02 |
|                           LowCostLinqWithStructWhereCount |             50 |    118.742 ns |  0.0180 ns |  0.0159 ns |    118.742 ns |   7.63 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     76.009 ns |  0.0074 ns |  0.0062 ns |     76.006 ns |   4.88 |     0.01 |
|                                               LinqToArray |             50 |    535.069 ns |  0.8563 ns |  0.8010 ns |    534.724 ns |  34.38 |     0.06 |
|                            LowCostLinqWithDelegateToArray |             50 |    523.585 ns |  0.4730 ns |  0.4193 ns |    523.392 ns |  33.65 |     0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    433.252 ns |  0.3980 ns |  0.3723 ns |    433.205 ns |  27.84 |     0.04 |
|                              LowCostLinqWithStructToArray |             50 |    271.499 ns |  0.1815 ns |  0.1698 ns |    271.473 ns |  17.45 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    218.552 ns |  0.2804 ns |  0.2623 ns |    218.510 ns |  14.04 |     0.02 |
|                                                      Take |             50 |    390.820 ns |  0.2108 ns |  0.1760 ns |    390.860 ns |  25.11 |     0.03 |
|                                               LowCostTake |             50 |    167.968 ns |  0.0169 ns |  0.0141 ns |    167.963 ns |  10.79 |     0.01 |
|                                  LowCostTakeWithoutChecks |             50 |    147.956 ns |  0.0396 ns |  0.0370 ns |    147.966 ns |   9.51 |     0.01 |
|                                     LowCostTakeWithStruct |             50 |     95.741 ns |  0.0108 ns |  0.0101 ns |     95.740 ns |   6.15 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     87.424 ns |  0.0180 ns |  0.0168 ns |     87.425 ns |   5.62 |     0.01 |
|                                            SkipTakeSingle |             50 |    305.745 ns |  0.1126 ns |  0.0879 ns |    305.759 ns |  19.65 |     0.02 |
|                                     LowCostSkipTakeSingle |             50 |    185.392 ns |  0.0925 ns |  0.0865 ns |    185.360 ns |  11.91 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    157.738 ns |  0.1456 ns |  0.1137 ns |    157.725 ns |  10.14 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     88.485 ns |  0.0236 ns |  0.0221 ns |     88.485 ns |   5.69 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     71.411 ns |  0.0480 ns |  0.0449 ns |     71.408 ns |   4.59 |     0.01 |
|                                           ForeachDelegate |             50 |    259.157 ns |  0.2546 ns |  0.2382 ns |    259.259 ns |  16.65 |     0.02 |
|                                                   Foreach |             50 |    102.997 ns |  0.0150 ns |  0.0133 ns |    102.998 ns |   6.62 |     0.01 |
|                                                       For |             50 |     15.562 ns |  0.0176 ns |  0.0165 ns |     15.564 ns |   1.00 |     0.00 |
