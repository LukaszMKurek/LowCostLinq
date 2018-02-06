``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **63.249 ns** |  **0.1079 ns** |  **0.1009 ns** |  **22.94** |     **0.04** |
|                                   LowCostLinqWithDelegate |              0 |     27.562 ns |  0.1625 ns |  0.1520 ns |  10.00 |     0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     19.850 ns |  0.0046 ns |  0.0043 ns |   7.20 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     40.622 ns |  0.0048 ns |  0.0037 ns |  14.74 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     37.964 ns |  0.1054 ns |  0.0935 ns |  13.77 |     0.03 |
|                                LowCostLinqWithStructWhere |              0 |     35.781 ns |  0.0012 ns |  0.0010 ns |  12.98 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     27.226 ns |  0.0041 ns |  0.0039 ns |   9.88 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     57.187 ns |  0.0567 ns |  0.0503 ns |  20.74 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     52.095 ns |  0.0648 ns |  0.0606 ns |  18.90 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     40.604 ns |  0.0626 ns |  0.0586 ns |  14.73 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     36.185 ns |  0.0206 ns |  0.0193 ns |  13.13 |     0.01 |
|                                                 LinqCount |              0 |     60.777 ns |  0.5111 ns |  0.4781 ns |  22.05 |     0.17 |
|                              LowCostLinqWithDelegateCount |              0 |     24.693 ns |  0.0183 ns |  0.0171 ns |   8.96 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     23.115 ns |  0.0017 ns |  0.0015 ns |   8.38 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     28.179 ns |  0.0104 ns |  0.0097 ns |  10.22 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     20.753 ns |  0.0007 ns |  0.0006 ns |   7.53 |     0.01 |
|                                               LinqToArray |              0 |     72.725 ns |  0.1323 ns |  0.1237 ns |  26.38 |     0.05 |
|                            LowCostLinqWithDelegateToArray |              0 |     27.543 ns |  0.2912 ns |  0.2723 ns |   9.99 |     0.10 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     26.135 ns |  0.0189 ns |  0.0177 ns |   9.48 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     35.985 ns |  0.0064 ns |  0.0050 ns |  13.05 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     23.911 ns |  0.0349 ns |  0.0309 ns |   8.67 |     0.01 |
|                                                      Take |              0 |     98.084 ns |  0.0239 ns |  0.0187 ns |  35.58 |     0.03 |
|                                               LowCostTake |              0 |     34.907 ns |  0.0043 ns |  0.0038 ns |  12.66 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     29.114 ns |  0.0053 ns |  0.0050 ns |  10.56 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     41.607 ns |  0.1294 ns |  0.1210 ns |  15.09 |     0.04 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     36.079 ns |  0.0053 ns |  0.0044 ns |  13.09 |     0.01 |
|                                            SkipTakeSingle |              0 |    122.302 ns |  0.1955 ns |  0.1829 ns |  44.36 |     0.07 |
|                                     LowCostSkipTakeSingle |              0 |     38.913 ns |  0.0091 ns |  0.0071 ns |  14.12 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     37.180 ns |  0.2157 ns |  0.2017 ns |  13.49 |     0.07 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     52.717 ns |  0.0055 ns |  0.0046 ns |  19.12 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     40.304 ns |  0.0108 ns |  0.0096 ns |  14.62 |     0.01 |
|                                           ForeachDelegate |              0 |     15.619 ns |  0.0086 ns |  0.0081 ns |   5.67 |     0.00 |
|                                                   Foreach |              0 |     12.208 ns |  0.0021 ns |  0.0020 ns |   4.43 |     0.00 |
|                                                       For |              0 |      2.757 ns |  0.0022 ns |  0.0020 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |        |          |
|                                                      **Linq** |           **1000** |  **9,408.289 ns** |  **8.0007 ns** |  **7.0924 ns** |  **37.61** |     **0.03** |
|                                   LowCostLinqWithDelegate |           1000 |  6,021.212 ns | 28.9983 ns | 25.7062 ns |  24.07 |     0.10 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,012.580 ns |  3.9342 ns |  3.6801 ns |  20.04 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           1000 |  6,174.493 ns |  9.3902 ns |  8.3241 ns |  24.68 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  5,425.075 ns | 31.4032 ns | 29.3746 ns |  21.69 |     0.11 |
|                                LowCostLinqWithStructWhere |           1000 |  1,836.706 ns |  0.5498 ns |  0.4591 ns |   7.34 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,729.194 ns |  0.7025 ns |  0.6572 ns |   6.91 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 17,276.110 ns | 11.2600 ns | 10.5326 ns |  69.06 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 16,840.263 ns | 88.5909 ns | 78.5335 ns |  67.32 |     0.30 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,895.665 ns |  2.7929 ns |  2.6124 ns |  27.56 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  6,214.463 ns |  3.9210 ns |  3.6677 ns |  24.84 |     0.01 |
|                                                 LinqCount |           1000 |  3,925.713 ns | 29.7052 ns | 27.7863 ns |  15.69 |     0.11 |
|                              LowCostLinqWithDelegateCount |           1000 |  5,547.123 ns | 14.9624 ns | 13.9958 ns |  22.17 |     0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,559.067 ns |  0.2784 ns |  0.2468 ns |  18.22 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,728.760 ns |  1.2509 ns |  1.1701 ns |   6.91 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,211.968 ns |  3.4949 ns |  3.2691 ns |   4.84 |     0.01 |
|                                               LinqToArray |           1000 |  5,234.534 ns | 11.7706 ns | 11.0102 ns |  20.92 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,289.868 ns |  4.8131 ns |  4.0191 ns |  29.14 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  6,597.801 ns | 49.0888 ns | 45.9177 ns |  26.37 |     0.18 |
|                              LowCostLinqWithStructToArray |           1000 |  3,196.646 ns |  3.2480 ns |  2.3485 ns |  12.78 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,364.806 ns |  5.8911 ns |  5.2223 ns |   9.45 |     0.02 |
|                                                      Take |           1000 |    373.839 ns |  0.1210 ns |  0.1073 ns |   1.49 |     0.00 |
|                                               LowCostTake |           1000 |    153.905 ns |  0.0549 ns |  0.0513 ns |   0.62 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    144.751 ns |  0.0087 ns |  0.0073 ns |   0.58 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     82.335 ns |  0.0434 ns |  0.0362 ns |   0.33 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     74.232 ns |  0.0378 ns |  0.0295 ns |   0.30 |     0.00 |
|                                            SkipTakeSingle |           1000 |    303.723 ns |  0.2030 ns |  0.1899 ns |   1.21 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    170.497 ns |  0.1086 ns |  0.1016 ns |   0.68 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    148.560 ns |  0.0528 ns |  0.0382 ns |   0.59 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     98.285 ns |  0.3838 ns |  0.3590 ns |   0.39 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     66.213 ns |  0.0271 ns |  0.0254 ns |   0.26 |     0.00 |
|                                           ForeachDelegate |           1000 |  4,082.139 ns |  1.5210 ns |  1.3483 ns |  16.32 |     0.01 |
|                                                   Foreach |           1000 |  1,691.695 ns |  0.5445 ns |  0.3937 ns |   6.76 |     0.00 |
|                                                       For |           1000 |    250.164 ns |  0.0182 ns |  0.0162 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |        |          |
|                                                      **Linq** |              **5** |    **109.818 ns** |  **0.0966 ns** |  **0.0856 ns** |  **27.59** |     **0.03** |
|                                   LowCostLinqWithDelegate |              5 |     53.538 ns |  0.0389 ns |  0.0345 ns |  13.45 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     42.738 ns |  0.0370 ns |  0.0347 ns |  10.74 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |     70.161 ns |  0.0441 ns |  0.0413 ns |  17.63 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     63.701 ns |  0.0524 ns |  0.0490 ns |  16.00 |     0.02 |
|                                LowCostLinqWithStructWhere |              5 |     46.547 ns |  0.0265 ns |  0.0248 ns |  11.69 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     36.311 ns |  0.0283 ns |  0.0265 ns |   9.12 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    144.365 ns |  0.1907 ns |  0.1784 ns |  36.27 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    134.952 ns |  0.0505 ns |  0.0421 ns |  33.90 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |     74.480 ns |  0.0559 ns |  0.0522 ns |  18.71 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |     66.784 ns |  0.0476 ns |  0.0445 ns |  16.78 |     0.02 |
|                                                 LinqCount |              5 |     80.094 ns |  0.1220 ns |  0.1141 ns |  20.12 |     0.03 |
|                              LowCostLinqWithDelegateCount |              5 |     53.676 ns |  0.2223 ns |  0.2079 ns |  13.48 |     0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     46.816 ns |  0.0757 ns |  0.0708 ns |  11.76 |     0.02 |
|                           LowCostLinqWithStructWhereCount |              5 |     36.809 ns |  0.0345 ns |  0.0323 ns |   9.25 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     24.761 ns |  0.0177 ns |  0.0166 ns |   6.22 |     0.01 |
|                                               LinqToArray |              5 |    139.337 ns |  0.0746 ns |  0.0698 ns |  35.00 |     0.03 |
|                            LowCostLinqWithDelegateToArray |              5 |     95.308 ns |  0.0289 ns |  0.0270 ns |  23.94 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     87.516 ns |  0.0699 ns |  0.0654 ns |  21.99 |     0.02 |
|                              LowCostLinqWithStructToArray |              5 |     75.097 ns |  0.7312 ns |  0.6840 ns |  18.87 |     0.17 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     64.969 ns |  0.0665 ns |  0.0622 ns |  16.32 |     0.02 |
|                                                      Take |              5 |    169.993 ns |  0.0337 ns |  0.0299 ns |  42.71 |     0.03 |
|                                               LowCostTake |              5 |     63.348 ns |  0.4503 ns |  0.4212 ns |  15.91 |     0.10 |
|                                  LowCostTakeWithoutChecks |              5 |     52.697 ns |  0.2941 ns |  0.2751 ns |  13.24 |     0.07 |
|                                     LowCostTakeWithStruct |              5 |     52.501 ns |  0.0125 ns |  0.0111 ns |  13.19 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     45.216 ns |  0.0149 ns |  0.0139 ns |  11.36 |     0.01 |
|                                            SkipTakeSingle |              5 |    162.531 ns |  1.3713 ns |  1.2827 ns |  40.83 |     0.31 |
|                                     LowCostSkipTakeSingle |              5 |     63.555 ns |  0.0070 ns |  0.0059 ns |  15.97 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     56.140 ns |  0.0515 ns |  0.0456 ns |  14.10 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     61.974 ns |  0.1676 ns |  0.1568 ns |  15.57 |     0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     45.118 ns |  0.0272 ns |  0.0255 ns |  11.33 |     0.01 |
|                                           ForeachDelegate |              5 |     37.207 ns |  0.0289 ns |  0.0270 ns |   9.35 |     0.01 |
|                                                   Foreach |              5 |     19.982 ns |  0.0238 ns |  0.0211 ns |   5.02 |     0.01 |
|                                                       For |              5 |      3.981 ns |  0.0032 ns |  0.0029 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |        |          |
|                                                      **Linq** |             **50** |    **540.432 ns** |  **0.5012 ns** |  **0.4689 ns** |  **33.01** |     **0.03** |
|                                   LowCostLinqWithDelegate |             50 |    321.306 ns |  1.5844 ns |  1.3231 ns |  19.63 |     0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    267.704 ns |  2.0113 ns |  1.7830 ns |  16.35 |     0.10 |
|                                  LowCostLinqWithDelegate2 |             50 |    364.829 ns |  0.2026 ns |  0.1796 ns |  22.28 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    322.549 ns |  0.1441 ns |  0.1348 ns |  19.70 |     0.01 |
|                                LowCostLinqWithStructWhere |             50 |    134.134 ns |  0.0228 ns |  0.0213 ns |   8.19 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    115.706 ns |  0.7135 ns |  0.6325 ns |   7.07 |     0.04 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    927.629 ns |  0.4673 ns |  0.3648 ns |  56.66 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    883.044 ns |  1.0472 ns |  0.9796 ns |  53.94 |     0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    390.725 ns |  0.1048 ns |  0.0981 ns |  23.87 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    351.758 ns |  0.1497 ns |  0.1327 ns |  21.49 |     0.01 |
|                                                 LinqCount |             50 |    258.801 ns |  0.2584 ns |  0.2417 ns |  15.81 |     0.01 |
|                              LowCostLinqWithDelegateCount |             50 |    308.410 ns |  1.8135 ns |  1.6076 ns |  18.84 |     0.09 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    255.459 ns |  0.0118 ns |  0.0098 ns |  15.60 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    123.291 ns |  0.0197 ns |  0.0164 ns |   7.53 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     75.802 ns |  0.0078 ns |  0.0069 ns |   4.63 |     0.00 |
|                                               LinqToArray |             50 |    548.681 ns |  1.7104 ns |  1.5999 ns |  33.51 |     0.09 |
|                            LowCostLinqWithDelegateToArray |             50 |    512.523 ns |  5.4095 ns |  5.0601 ns |  31.31 |     0.30 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    456.366 ns |  0.3449 ns |  0.3226 ns |  27.88 |     0.02 |
|                              LowCostLinqWithStructToArray |             50 |    267.580 ns |  0.2510 ns |  0.2096 ns |  16.34 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    219.630 ns |  2.4908 ns |  2.3299 ns |  13.42 |     0.14 |
|                                                      Take |             50 |    373.173 ns |  0.0899 ns |  0.0841 ns |  22.79 |     0.01 |
|                                               LowCostTake |             50 |    154.126 ns |  0.0268 ns |  0.0237 ns |   9.41 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    144.754 ns |  0.0225 ns |  0.0188 ns |   8.84 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |     83.166 ns |  0.0058 ns |  0.0048 ns |   5.08 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     74.258 ns |  0.0371 ns |  0.0347 ns |   4.54 |     0.00 |
|                                            SkipTakeSingle |             50 |    299.287 ns |  0.2238 ns |  0.2093 ns |  18.28 |     0.01 |
|                                     LowCostSkipTakeSingle |             50 |    170.420 ns |  0.0978 ns |  0.0867 ns |  10.41 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    148.523 ns |  0.0408 ns |  0.0382 ns |   9.07 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     88.555 ns |  0.0456 ns |  0.0426 ns |   5.41 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     66.767 ns |  0.0198 ns |  0.0154 ns |   4.08 |     0.00 |
|                                           ForeachDelegate |             50 |    229.143 ns |  1.2580 ns |  1.1152 ns |  14.00 |     0.07 |
|                                                   Foreach |             50 |    103.256 ns |  0.0340 ns |  0.0318 ns |   6.31 |     0.00 |
|                                                       For |             50 |     16.371 ns |  0.0037 ns |  0.0027 ns |   1.00 |     0.00 |
