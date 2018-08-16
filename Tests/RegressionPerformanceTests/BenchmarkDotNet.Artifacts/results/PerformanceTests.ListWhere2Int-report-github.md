``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |     StdDev |        Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|-----------:|--------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **59.609 ns** |   **0.0585 ns** |  **0.0519 ns** |     **59.587 ns** |  **15.88** |     **0.14** |
|                                   LowCostLinqWithDelegate |            [0] |     27.465 ns |   0.0014 ns |  0.0012 ns |     27.465 ns |   7.32 |     0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     20.151 ns |   0.0059 ns |  0.0046 ns |     20.150 ns |   5.37 |     0.05 |
|                                  LowCostLinqWithDelegate2 |            [0] |     41.970 ns |   0.0150 ns |  0.0133 ns |     41.973 ns |  11.18 |     0.10 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     37.807 ns |   0.1249 ns |  0.1107 ns |     37.753 ns |  10.07 |     0.09 |
|                                LowCostLinqWithStructWhere |            [0] |     38.274 ns |   0.0029 ns |  0.0027 ns |     38.273 ns |  10.20 |     0.09 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     33.486 ns |   0.0011 ns |  0.0010 ns |     33.486 ns |   8.92 |     0.08 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     57.352 ns |   0.0210 ns |  0.0175 ns |     57.350 ns |  15.28 |     0.13 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     55.693 ns |   0.0367 ns |  0.0326 ns |     55.691 ns |  14.84 |     0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     55.141 ns |   0.0394 ns |  0.0329 ns |     55.134 ns |  14.69 |     0.13 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     43.361 ns |   0.0199 ns |  0.0176 ns |     43.364 ns |  11.55 |     0.10 |
|                                                 LinqCount |            [0] |     56.747 ns |   0.0650 ns |  0.0576 ns |     56.726 ns |  15.12 |     0.13 |
|                              LowCostLinqWithDelegateCount |            [0] |     25.811 ns |   0.2667 ns |  0.2495 ns |     25.651 ns |   6.88 |     0.09 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     24.249 ns |   0.0144 ns |  0.0135 ns |     24.252 ns |   6.46 |     0.06 |
|                           LowCostLinqWithStructWhereCount |            [0] |     28.821 ns |   0.0562 ns |  0.0526 ns |     28.843 ns |   7.68 |     0.07 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     22.933 ns |   0.0019 ns |  0.0015 ns |     22.933 ns |   6.11 |     0.05 |
|                                               LinqToArray |            [0] |     67.004 ns |   0.0319 ns |  0.0249 ns |     67.008 ns |  17.85 |     0.15 |
|                            LowCostLinqWithDelegateToArray |            [0] |     30.278 ns |   0.0115 ns |  0.0107 ns |     30.278 ns |   8.07 |     0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     28.667 ns |   0.0952 ns |  0.0890 ns |     28.716 ns |   7.64 |     0.07 |
|                              LowCostLinqWithStructToArray |            [0] |     31.996 ns |   0.0098 ns |  0.0092 ns |     31.994 ns |   8.52 |     0.07 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     30.482 ns |   0.0473 ns |  0.0395 ns |     30.464 ns |   8.12 |     0.07 |
|                                                      Take |            [0] |     95.993 ns |   0.0302 ns |  0.0252 ns |     95.986 ns |  25.58 |     0.22 |
|                                               LowCostTake |            [0] |     35.534 ns |   0.0711 ns |  0.0665 ns |     35.561 ns |   9.47 |     0.08 |
|                                  LowCostTakeWithoutChecks |            [0] |     30.064 ns |   0.3783 ns |  0.3539 ns |     30.070 ns |   8.01 |     0.11 |
|                                     LowCostTakeWithStruct |            [0] |     42.069 ns |   0.0022 ns |  0.0020 ns |     42.068 ns |  11.21 |     0.10 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     36.921 ns |   0.0023 ns |  0.0019 ns |     36.921 ns |   9.84 |     0.08 |
|                                            SkipTakeSingle |            [0] |    116.518 ns |   0.2734 ns |  0.2558 ns |    116.624 ns |  31.04 |     0.28 |
|                                     LowCostSkipTakeSingle |            [0] |     39.371 ns |   0.0017 ns |  0.0014 ns |     39.372 ns |  10.49 |     0.09 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     37.267 ns |   0.0079 ns |  0.0074 ns |     37.270 ns |   9.93 |     0.09 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     48.372 ns |   0.0035 ns |  0.0031 ns |     48.372 ns |  12.89 |     0.11 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     40.902 ns |   0.2455 ns |  0.2296 ns |     40.704 ns |  10.90 |     0.11 |
|                                           ForeachDelegate |            [0] |     16.264 ns |   0.0396 ns |  0.0370 ns |     16.244 ns |   4.33 |     0.04 |
|                                                   Foreach |            [0] |     12.637 ns |   0.0095 ns |  0.0089 ns |     12.637 ns |   3.37 |     0.03 |
|                                                       For |            [0] |      3.754 ns |   0.0363 ns |  0.0340 ns |      3.735 ns |   1.00 |     0.00 |
|                                                           |                |               |             |            |               |        |          |
|                                                      **Linq** |         **[1000]** | **10,342.747 ns** |  **22.9207 ns** | **21.4401 ns** | **10,348.900 ns** |  **41.18** |     **0.08** |
|                                   LowCostLinqWithDelegate |         [1000] |  5,943.239 ns |   8.6093 ns |  7.6320 ns |  5,945.063 ns |  23.66 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,353.621 ns |   1.3837 ns |  1.2943 ns |  5,353.481 ns |  21.31 |     0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,585.775 ns |  96.1321 ns | 89.9220 ns |  6,523.269 ns |  26.22 |     0.35 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  5,585.356 ns |   1.1539 ns |  1.0793 ns |  5,585.420 ns |  22.24 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,838.913 ns |   1.1908 ns |  1.0556 ns |  1,838.391 ns |   7.32 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,744.005 ns |  18.1019 ns | 16.9325 ns |  1,732.866 ns |   6.94 |     0.07 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 17,640.222 ns | 101.4059 ns | 94.8551 ns | 17,602.401 ns |  70.23 |     0.36 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 15,896.702 ns |  25.4713 ns | 23.8258 ns | 15,885.978 ns |  63.29 |     0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,283.544 ns |  12.9769 ns | 12.1386 ns |  6,277.962 ns |  25.02 |     0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  5,495.534 ns |  62.8438 ns | 58.7842 ns |  5,463.325 ns |  21.88 |     0.23 |
|                                                 LinqCount |         [1000] |  4,142.407 ns |   4.7987 ns |  4.2539 ns |  4,142.122 ns |  16.49 |     0.02 |
|                              LowCostLinqWithDelegateCount |         [1000] |  5,877.035 ns |  97.2805 ns | 90.9962 ns |  5,900.385 ns |  23.40 |     0.35 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,056.562 ns |   3.7005 ns |  3.2804 ns |  5,057.405 ns |  20.13 |     0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,737.659 ns |   2.6327 ns |  2.4626 ns |  1,738.027 ns |   6.92 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,211.748 ns |   0.0411 ns |  0.0385 ns |  1,211.747 ns |   4.82 |     0.00 |
|                                               LinqToArray |         [1000] |  5,477.963 ns |   7.2503 ns |  6.7819 ns |  5,478.994 ns |  21.81 |     0.03 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,254.677 ns |   4.7977 ns |  4.2531 ns |  8,254.153 ns |  32.86 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,190.463 ns |   3.3796 ns |  3.1613 ns |  7,190.432 ns |  28.63 |     0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,179.135 ns |   1.6395 ns |  1.5336 ns |  3,179.479 ns |  12.66 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,336.558 ns |   1.7019 ns |  1.5919 ns |  2,337.161 ns |   9.30 |     0.01 |
|                                                      Take |         [1000] |    380.280 ns |   2.5714 ns |  2.4053 ns |    381.157 ns |   1.51 |     0.01 |
|                                               LowCostTake |         [1000] |    161.536 ns |   0.2566 ns |  0.2400 ns |    161.615 ns |   0.64 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    146.015 ns |   0.0422 ns |  0.0374 ns |    146.020 ns |   0.58 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     83.157 ns |   0.0320 ns |  0.0300 ns |     83.167 ns |   0.33 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     74.817 ns |   0.0132 ns |  0.0117 ns |     74.818 ns |   0.30 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    286.173 ns |   0.4133 ns |  0.3866 ns |    286.252 ns |   1.14 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    179.594 ns |   0.0724 ns |  0.0642 ns |    179.596 ns |   0.71 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    138.289 ns |   0.1856 ns |  0.1736 ns |    138.395 ns |   0.55 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     88.840 ns |   0.0299 ns |  0.0265 ns |     88.839 ns |   0.35 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     67.039 ns |   0.1232 ns |  0.1152 ns |     67.058 ns |   0.27 |     0.00 |
|                                           ForeachDelegate |         [1000] |  4,087.814 ns |   1.8826 ns |  1.4698 ns |  4,087.273 ns |  16.27 |     0.01 |
|                                                   Foreach |         [1000] |  1,704.289 ns |  17.9977 ns | 16.8350 ns |  1,692.141 ns |   6.79 |     0.06 |
|                                                       For |         [1000] |    251.182 ns |   0.0197 ns |  0.0174 ns |    251.174 ns |   1.00 |     0.00 |
|                                                           |                |               |             |            |               |        |          |
|                                                      **Linq** |           **[50]** |    **581.302 ns** |   **0.1105 ns** |  **0.0923 ns** |    **581.291 ns** |  **34.87** |     **0.06** |
|                                   LowCostLinqWithDelegate |           [50] |    334.135 ns |   0.3254 ns |  0.3044 ns |    334.125 ns |  20.05 |     0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    289.986 ns |   3.7891 ns |  3.5443 ns |    290.654 ns |  17.40 |     0.21 |
|                                  LowCostLinqWithDelegate2 |           [50] |    369.070 ns |   0.0742 ns |  0.0657 ns |    369.088 ns |  22.14 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    326.468 ns |   0.0902 ns |  0.0844 ns |    326.466 ns |  19.59 |     0.03 |
|                                LowCostLinqWithStructWhere |           [50] |    134.576 ns |   0.2645 ns |  0.2474 ns |    134.431 ns |   8.07 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    113.254 ns |   0.0226 ns |  0.0200 ns |    113.247 ns |   6.79 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    951.690 ns |   5.1522 ns |  4.8194 ns |    950.477 ns |  57.09 |     0.29 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    854.473 ns |   0.6582 ns |  0.5835 ns |    854.376 ns |  51.26 |     0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    374.507 ns |   5.3170 ns |  4.9735 ns |    372.027 ns |  22.47 |     0.29 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    327.896 ns |   0.0257 ns |  0.0215 ns |    327.895 ns |  19.67 |     0.03 |
|                                                 LinqCount |           [50] |    269.484 ns |   0.8491 ns |  0.7943 ns |    269.409 ns |  16.17 |     0.05 |
|                              LowCostLinqWithDelegateCount |           [50] |    325.807 ns |   0.4092 ns |  0.3828 ns |    325.850 ns |  19.55 |     0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    282.531 ns |   3.1369 ns |  2.9343 ns |    280.286 ns |  16.95 |     0.17 |
|                           LowCostLinqWithStructWhereCount |           [50] |    121.241 ns |   0.0132 ns |  0.0124 ns |    121.244 ns |   7.27 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     76.637 ns |   0.0995 ns |  0.0931 ns |     76.668 ns |   4.60 |     0.01 |
|                                               LinqToArray |           [50] |    518.266 ns |   1.7659 ns |  1.6519 ns |    517.663 ns |  31.09 |     0.11 |
|                            LowCostLinqWithDelegateToArray |           [50] |    526.982 ns |   0.2761 ns |  0.2583 ns |    526.986 ns |  31.61 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    465.590 ns |   0.7030 ns |  0.5870 ns |    465.747 ns |  27.93 |     0.06 |
|                              LowCostLinqWithStructToArray |           [50] |    253.033 ns |   0.2349 ns |  0.2082 ns |    253.061 ns |  15.18 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    212.295 ns |   0.1627 ns |  0.1522 ns |    212.341 ns |  12.74 |     0.02 |
|                                                      Take |           [50] |    386.153 ns |   5.8575 ns |  5.4791 ns |    381.882 ns |  23.17 |     0.32 |
|                                               LowCostTake |           [50] |    156.398 ns |   0.0365 ns |  0.0324 ns |    156.390 ns |   9.38 |     0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    148.355 ns |   0.0128 ns |  0.0120 ns |    148.354 ns |   8.90 |     0.01 |
|                                     LowCostTakeWithStruct |           [50] |     82.965 ns |   0.0070 ns |  0.0055 ns |     82.967 ns |   4.98 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     76.352 ns |   0.0100 ns |  0.0083 ns |     76.353 ns |   4.58 |     0.01 |
|                                            SkipTakeSingle |           [50] |    285.115 ns |   0.0662 ns |  0.0553 ns |    285.105 ns |  17.10 |     0.03 |
|                                     LowCostSkipTakeSingle |           [50] |    179.630 ns |   0.0462 ns |  0.0410 ns |    179.649 ns |  10.78 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    138.683 ns |   0.0901 ns |  0.0752 ns |    138.662 ns |   8.32 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     88.862 ns |   0.0198 ns |  0.0165 ns |     88.854 ns |   5.33 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     66.932 ns |   0.1415 ns |  0.1323 ns |     66.862 ns |   4.02 |     0.01 |
|                                           ForeachDelegate |           [50] |    229.882 ns |   0.0613 ns |  0.0574 ns |    229.875 ns |  13.79 |     0.02 |
|                                                   Foreach |           [50] |    103.950 ns |   0.9908 ns |  0.9268 ns |    103.240 ns |   6.24 |     0.05 |
|                                                       For |           [50] |     16.669 ns |   0.0294 ns |  0.0275 ns |     16.681 ns |   1.00 |     0.00 |
|                                                           |                |               |             |            |               |        |          |
|                                                      **Linq** |            **[5]** |    **110.191 ns** |   **0.0431 ns** |  **0.0403 ns** |    **110.189 ns** |  **20.36** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     55.696 ns |   0.5882 ns |  0.5502 ns |     55.317 ns |  10.29 |     0.10 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     45.019 ns |   0.0168 ns |  0.0157 ns |     45.020 ns |   8.32 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     76.040 ns |   0.1489 ns |  0.1393 ns |     76.060 ns |  14.05 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     66.480 ns |   0.0243 ns |  0.0203 ns |     66.485 ns |  12.28 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     46.767 ns |   0.0093 ns |  0.0087 ns |     46.771 ns |   8.64 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     37.490 ns |   0.0078 ns |  0.0073 ns |     37.493 ns |   6.93 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    146.143 ns |   0.4220 ns |  0.3947 ns |    146.236 ns |  27.00 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    138.382 ns |   2.6816 ns |  2.5084 ns |    138.441 ns |  25.56 |     0.45 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     84.252 ns |   0.0464 ns |  0.0434 ns |     84.249 ns |  15.56 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     71.192 ns |   0.0206 ns |  0.0193 ns |     71.193 ns |  13.15 |     0.00 |
|                                                 LinqCount |            [5] |     79.430 ns |   0.1817 ns |  0.1700 ns |     79.433 ns |  14.67 |     0.03 |
|                              LowCostLinqWithDelegateCount |            [5] |     55.834 ns |   0.6981 ns |  0.6530 ns |     55.444 ns |  10.31 |     0.12 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     48.798 ns |   0.0326 ns |  0.0305 ns |     48.801 ns |   9.01 |     0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     37.466 ns |   0.0227 ns |  0.0212 ns |     37.467 ns |   6.92 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     26.420 ns |   0.2178 ns |  0.2037 ns |     26.320 ns |   4.88 |     0.04 |
|                                               LinqToArray |            [5] |    137.260 ns |   0.0448 ns |  0.0397 ns |    137.247 ns |  25.36 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |     97.706 ns |   0.0629 ns |  0.0589 ns |     97.713 ns |  18.05 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     86.568 ns |   0.2562 ns |  0.2000 ns |     86.642 ns |  15.99 |     0.04 |
|                              LowCostLinqWithStructToArray |            [5] |     71.349 ns |   0.0224 ns |  0.0210 ns |     71.345 ns |  13.18 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     58.322 ns |   0.2257 ns |  0.2111 ns |     58.193 ns |  10.77 |     0.04 |
|                                                      Take |            [5] |    173.181 ns |   0.0431 ns |  0.0382 ns |    173.169 ns |  31.99 |     0.01 |
|                                               LowCostTake |            [5] |     69.212 ns |   0.1330 ns |  0.1244 ns |     69.135 ns |  12.79 |     0.02 |
|                                  LowCostTakeWithoutChecks |            [5] |     55.401 ns |   0.0266 ns |  0.0236 ns |     55.403 ns |  10.23 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     53.188 ns |   0.0177 ns |  0.0157 ns |     53.186 ns |   9.83 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     46.080 ns |   0.0094 ns |  0.0088 ns |     46.079 ns |   8.51 |     0.00 |
|                                            SkipTakeSingle |            [5] |    157.630 ns |   0.0605 ns |  0.0473 ns |    157.618 ns |  29.12 |     0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     65.565 ns |   0.0323 ns |  0.0286 ns |     65.548 ns |  12.11 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     58.442 ns |   0.0152 ns |  0.0142 ns |     58.436 ns |  10.80 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     58.135 ns |   0.6577 ns |  0.6152 ns |     57.711 ns |  10.74 |     0.11 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     45.319 ns |   0.0051 ns |  0.0045 ns |     45.318 ns |   8.37 |     0.00 |
|                                           ForeachDelegate |            [5] |     37.799 ns |   0.0161 ns |  0.0151 ns |     37.801 ns |   6.98 |     0.00 |
|                                                   Foreach |            [5] |     20.749 ns |   0.2830 ns |  0.2647 ns |     20.584 ns |   3.83 |     0.05 |
|                                                       For |            [5] |      5.413 ns |   0.0014 ns |  0.0013 ns |      5.414 ns |   1.00 |     0.00 |
