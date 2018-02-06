``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **35.787 ns** |  **0.0541 ns** |  **0.0452 ns** |  **12.98** |     **0.02** |
|                                   LowCostLinqWithDelegate |              0 |    25.379 ns |  0.1037 ns |  0.0970 ns |   9.20 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |    18.629 ns |  0.0018 ns |  0.0015 ns |   6.76 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |    33.621 ns |  0.0124 ns |  0.0104 ns |  12.19 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |    27.709 ns |  0.0014 ns |  0.0012 ns |  10.05 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |    29.850 ns |  0.0031 ns |  0.0027 ns |  10.83 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |    20.751 ns |  0.0017 ns |  0.0015 ns |   7.53 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    39.410 ns |  0.0439 ns |  0.0411 ns |  14.29 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    34.905 ns |  0.3289 ns |  0.3076 ns |  12.66 |     0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |    40.313 ns |  0.0351 ns |  0.0311 ns |  14.62 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |    36.075 ns |  0.0409 ns |  0.0362 ns |  13.08 |     0.01 |
|                                                 LinqCount |              0 |    30.578 ns |  0.0366 ns |  0.0342 ns |  11.09 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |    24.976 ns |  0.0095 ns |  0.0089 ns |   9.06 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |    22.639 ns |  0.0025 ns |  0.0023 ns |   8.21 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |    21.991 ns |  0.0067 ns |  0.0056 ns |   7.98 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |    15.545 ns |  0.0725 ns |  0.0678 ns |   5.64 |     0.02 |
|                                               LinqToArray |              0 |    42.509 ns |  0.0343 ns |  0.0268 ns |  15.42 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |    26.753 ns |  0.0395 ns |  0.0369 ns |   9.70 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |    26.991 ns |  0.0339 ns |  0.0265 ns |   9.79 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |    24.857 ns |  0.0277 ns |  0.0259 ns |   9.01 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |    17.929 ns |  0.0212 ns |  0.0198 ns |   6.50 |     0.01 |
|                                                      Take |              0 |    70.186 ns |  0.7338 ns |  0.6864 ns |  25.45 |     0.24 |
|                                               LowCostTake |              0 |    34.361 ns |  0.0077 ns |  0.0068 ns |  12.46 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |    27.462 ns |  0.0009 ns |  0.0009 ns |   9.96 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |    36.284 ns |  0.0036 ns |  0.0032 ns |  13.16 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |    27.420 ns |  0.0030 ns |  0.0027 ns |   9.94 |     0.00 |
|                                            SkipTakeSingle |              0 |    91.607 ns |  0.0501 ns |  0.0469 ns |  33.22 |     0.02 |
|                                     LowCostSkipTakeSingle |              0 |    35.723 ns |  0.0014 ns |  0.0011 ns |  12.96 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |    34.507 ns |  0.1697 ns |  0.1588 ns |  12.51 |     0.06 |
|                           LowCostSkipTakeSingleWithStruct |              0 |    38.902 ns |  0.0048 ns |  0.0043 ns |  14.11 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |    31.040 ns |  0.0062 ns |  0.0058 ns |  11.26 |     0.00 |
|                                           ForeachDelegate |              0 |    15.202 ns |  0.0121 ns |  0.0113 ns |   5.51 |     0.00 |
|                                                   Foreach |              0 |    12.198 ns |  0.0150 ns |  0.0125 ns |   4.42 |     0.00 |
|                                                       For |              0 |     2.757 ns |  0.0013 ns |  0.0012 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **7,656.348 ns** |  **7.2935 ns** |  **6.4655 ns** |  **30.61** |     **0.02** |
|                                   LowCostLinqWithDelegate |           1000 | 3,630.151 ns | 25.5414 ns | 23.8915 ns |  14.51 |     0.09 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 2,888.070 ns |  0.7299 ns |  0.6471 ns |  11.55 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 3,984.714 ns |  5.0705 ns |  4.4949 ns |  15.93 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 3,151.530 ns |  0.2956 ns |  0.2621 ns |  12.60 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 | 1,830.623 ns |  0.7739 ns |  0.7239 ns |   7.32 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 | 1,722.571 ns |  0.1211 ns |  0.1012 ns |   6.89 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 9,196.452 ns |  6.8040 ns |  6.0316 ns |  36.76 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 8,315.326 ns | 80.2327 ns | 75.0497 ns |  33.24 |     0.29 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 6,895.087 ns |  2.4810 ns |  2.1994 ns |  27.56 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 6,215.625 ns |  3.4216 ns |  3.0332 ns |  24.85 |     0.01 |
|                                                 LinqCount |           1000 | 1,487.852 ns | 14.7660 ns | 13.8122 ns |   5.95 |     0.05 |
|                              LowCostLinqWithDelegateCount |           1000 | 3,612.207 ns |  1.9953 ns |  1.7688 ns |  14.44 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 2,659.450 ns |  0.3229 ns |  0.2696 ns |  10.63 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 | 1,733.303 ns |  1.6468 ns |  1.3751 ns |   6.93 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 | 1,206.151 ns |  0.0514 ns |  0.0481 ns |   4.82 |     0.00 |
|                                               LinqToArray |           1000 | 3,349.830 ns |  4.3732 ns |  4.0907 ns |  13.39 |     0.02 |
|                            LowCostLinqWithDelegateToArray |           1000 | 4,847.703 ns |  4.2814 ns |  3.5752 ns |  19.38 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 3,953.562 ns | 35.3833 ns | 33.0975 ns |  15.80 |     0.13 |
|                              LowCostLinqWithStructToArray |           1000 | 3,171.769 ns |  6.8998 ns |  6.1165 ns |  12.68 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 | 2,299.459 ns |  8.2211 ns |  7.6900 ns |   9.19 |     0.03 |
|                                                      Take |           1000 |   324.118 ns |  0.0815 ns |  0.0680 ns |   1.30 |     0.00 |
|                                               LowCostTake |           1000 |   116.812 ns |  0.8733 ns |  0.8169 ns |   0.47 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    99.160 ns |  0.0649 ns |  0.0607 ns |   0.40 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    77.440 ns |  0.0207 ns |  0.0161 ns |   0.31 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    66.595 ns |  0.1538 ns |  0.1284 ns |   0.27 |     0.00 |
|                                            SkipTakeSingle |           1000 |   226.319 ns |  0.0464 ns |  0.0387 ns |   0.90 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |   119.345 ns |  0.0344 ns |  0.0287 ns |   0.48 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |   113.894 ns |  0.0267 ns |  0.0223 ns |   0.46 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    80.635 ns |  0.6311 ns |  0.5903 ns |   0.32 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    58.503 ns |  0.0322 ns |  0.0301 ns |   0.23 |     0.00 |
|                                           ForeachDelegate |           1000 | 2,888.625 ns |  0.7948 ns |  0.6637 ns |  11.55 |     0.00 |
|                                                   Foreach |           1000 | 1,695.170 ns |  7.6473 ns |  6.3858 ns |   6.78 |     0.02 |
|                                                       For |           1000 |   250.156 ns |  0.0152 ns |  0.0127 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **72.697 ns** |  **0.0590 ns** |  **0.0552 ns** |  **18.15** |     **0.04** |
|                                   LowCostLinqWithDelegate |              5 |    44.192 ns |  0.3125 ns |  0.2923 ns |  11.03 |     0.07 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |    35.038 ns |  0.0164 ns |  0.0145 ns |   8.75 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              5 |    55.464 ns |  0.1044 ns |  0.0977 ns |  13.85 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    44.536 ns |  0.0061 ns |  0.0051 ns |  11.12 |     0.02 |
|                                LowCostLinqWithStructWhere |              5 |    39.413 ns |  0.0356 ns |  0.0333 ns |   9.84 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |    29.822 ns |  0.0034 ns |  0.0028 ns |   7.45 |     0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    87.268 ns |  0.0806 ns |  0.0754 ns |  21.79 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    77.486 ns |  0.0866 ns |  0.0810 ns |  19.35 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    74.594 ns |  0.0734 ns |  0.0687 ns |  18.62 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    66.748 ns |  0.0343 ns |  0.0321 ns |  16.67 |     0.03 |
|                                                 LinqCount |              5 |    37.779 ns |  0.0296 ns |  0.0262 ns |   9.43 |     0.02 |
|                              LowCostLinqWithDelegateCount |              5 |    44.888 ns |  0.2111 ns |  0.1974 ns |  11.21 |     0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    36.491 ns |  0.0264 ns |  0.0247 ns |   9.11 |     0.02 |
|                           LowCostLinqWithStructWhereCount |              5 |    30.343 ns |  0.0090 ns |  0.0084 ns |   7.58 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |    21.148 ns |  0.0258 ns |  0.0241 ns |   5.28 |     0.01 |
|                                               LinqToArray |              5 |    97.299 ns |  0.8825 ns |  0.8255 ns |  24.29 |     0.21 |
|                            LowCostLinqWithDelegateToArray |              5 |    81.960 ns |  0.1099 ns |  0.1028 ns |  20.46 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    74.910 ns |  0.0694 ns |  0.0580 ns |  18.70 |     0.04 |
|                              LowCostLinqWithStructToArray |              5 |    71.243 ns |  0.0397 ns |  0.0372 ns |  17.79 |     0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    57.230 ns |  0.4687 ns |  0.4384 ns |  14.29 |     0.11 |
|                                                      Take |              5 |   136.353 ns |  0.0751 ns |  0.0666 ns |  34.04 |     0.07 |
|                                               LowCostTake |              5 |    55.168 ns |  0.0179 ns |  0.0150 ns |  13.77 |     0.03 |
|                                  LowCostTakeWithoutChecks |              5 |    42.758 ns |  0.0141 ns |  0.0110 ns |  10.68 |     0.02 |
|                                     LowCostTakeWithStruct |              5 |    47.115 ns |  0.2030 ns |  0.1899 ns |  11.76 |     0.05 |
|                        LowCostTakeWithStructWithoutChecks |              5 |    37.318 ns |  0.0240 ns |  0.0213 ns |   9.32 |     0.02 |
|                                            SkipTakeSingle |              5 |   123.222 ns |  0.1194 ns |  0.1117 ns |  30.77 |     0.07 |
|                                     LowCostSkipTakeSingle |              5 |    59.499 ns |  0.0463 ns |  0.0433 ns |  14.86 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    45.945 ns |  0.0082 ns |  0.0064 ns |  11.47 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              5 |    48.105 ns |  0.0312 ns |  0.0292 ns |  12.01 |     0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |    43.441 ns |  0.0244 ns |  0.0216 ns |  10.85 |     0.02 |
|                                           ForeachDelegate |              5 |    29.659 ns |  0.1625 ns |  0.1520 ns |   7.41 |     0.04 |
|                                                   Foreach |              5 |    19.680 ns |  0.0085 ns |  0.0076 ns |   4.91 |     0.01 |
|                                                       For |              5 |     4.005 ns |  0.0090 ns |  0.0084 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |   **423.012 ns** |  **0.5602 ns** |  **0.4678 ns** |  **27.22** |     **0.03** |
|                                   LowCostLinqWithDelegate |             50 |   208.187 ns |  0.0116 ns |  0.0103 ns |  13.40 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |   170.922 ns |  0.0200 ns |  0.0167 ns |  11.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |   234.744 ns |  0.0601 ns |  0.0502 ns |  15.11 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |   187.995 ns |  0.1316 ns |  0.1231 ns |  12.10 |     0.01 |
|                                LowCostLinqWithStructWhere |             50 |   126.931 ns |  0.0205 ns |  0.0181 ns |   8.17 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |   107.680 ns |  0.0131 ns |  0.0123 ns |   6.93 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |   511.644 ns |  1.2766 ns |  1.0660 ns |  32.93 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |   456.862 ns |  0.2535 ns |  0.2117 ns |  29.40 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |   390.751 ns |  0.1736 ns |  0.1539 ns |  25.15 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |   352.632 ns |  1.5763 ns |  1.3974 ns |  22.69 |     0.09 |
|                                                 LinqCount |             50 |   109.330 ns |  0.1699 ns |  0.1589 ns |   7.04 |     0.01 |
|                              LowCostLinqWithDelegateCount |             50 |   213.893 ns |  0.0103 ns |  0.0080 ns |  13.76 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |   160.669 ns |  0.0609 ns |  0.0570 ns |  10.34 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |   114.720 ns |  0.0354 ns |  0.0314 ns |   7.38 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    70.980 ns |  0.0137 ns |  0.0114 ns |   4.57 |     0.00 |
|                                               LinqToArray |             50 |   370.328 ns |  0.4408 ns |  0.4123 ns |  23.83 |     0.03 |
|                            LowCostLinqWithDelegateToArray |             50 |   378.774 ns |  2.7309 ns |  2.4208 ns |  24.38 |     0.15 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |   310.747 ns |  0.2953 ns |  0.2617 ns |  20.00 |     0.02 |
|                              LowCostLinqWithStructToArray |             50 |   264.545 ns |  0.3887 ns |  0.3636 ns |  17.02 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |   216.180 ns |  0.1189 ns |  0.0993 ns |  13.91 |     0.01 |
|                                                      Take |             50 |   323.697 ns |  0.2739 ns |  0.2287 ns |  20.83 |     0.02 |
|                                               LowCostTake |             50 |   118.048 ns |  0.0145 ns |  0.0121 ns |   7.60 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    96.140 ns |  0.0112 ns |  0.0099 ns |   6.19 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    77.039 ns |  0.5489 ns |  0.5134 ns |   4.96 |     0.03 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    66.248 ns |  0.1508 ns |  0.1410 ns |   4.26 |     0.01 |
|                                            SkipTakeSingle |             50 |   223.851 ns |  0.1683 ns |  0.1405 ns |  14.41 |     0.01 |
|                                     LowCostSkipTakeSingle |             50 |   121.022 ns |  0.0292 ns |  0.0259 ns |   7.79 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |   105.834 ns |  0.6193 ns |  0.5793 ns |   6.81 |     0.04 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    81.697 ns |  0.0468 ns |  0.0438 ns |   5.26 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    56.488 ns |  0.0198 ns |  0.0185 ns |   3.64 |     0.00 |
|                                           ForeachDelegate |             50 |   165.660 ns |  0.9559 ns |  0.8941 ns |  10.66 |     0.06 |
|                                                   Foreach |             50 |   103.219 ns |  0.0149 ns |  0.0132 ns |   6.64 |     0.00 |
|                                                       For |             50 |    15.539 ns |  0.0047 ns |  0.0040 ns |   1.00 |     0.00 |
