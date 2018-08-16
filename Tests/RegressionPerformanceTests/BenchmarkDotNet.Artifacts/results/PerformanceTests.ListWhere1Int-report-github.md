``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |    **34.823 ns** |  **0.5311 ns** |  **0.4968 ns** |    **34.811 ns** |   **9.48** |     **0.13** |
|                                   LowCostLinqWithDelegate |            [0] |    24.829 ns |  0.0061 ns |  0.0051 ns |    24.828 ns |   6.76 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    18.882 ns |  0.0007 ns |  0.0006 ns |    18.881 ns |   5.14 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |    32.354 ns |  0.0047 ns |  0.0039 ns |    32.356 ns |   8.81 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    28.399 ns |  0.2234 ns |  0.2089 ns |    28.246 ns |   7.73 |     0.06 |
|                                LowCostLinqWithStructWhere |            [0] |    28.924 ns |  0.0007 ns |  0.0005 ns |    28.924 ns |   7.87 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    27.319 ns |  0.0010 ns |  0.0010 ns |    27.318 ns |   7.43 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    39.770 ns |  0.0188 ns |  0.0166 ns |    39.767 ns |  10.82 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    37.025 ns |  0.0321 ns |  0.0285 ns |    37.023 ns |  10.08 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    43.376 ns |  0.1188 ns |  0.1112 ns |    43.443 ns |  11.81 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    39.192 ns |  0.0166 ns |  0.0155 ns |    39.191 ns |  10.67 |     0.01 |
|                                                 LinqCount |            [0] |    31.826 ns |  0.0158 ns |  0.0132 ns |    31.827 ns |   8.66 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |    25.837 ns |  0.0193 ns |  0.0181 ns |    25.833 ns |   7.03 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    23.874 ns |  0.0873 ns |  0.0816 ns |    23.903 ns |   6.50 |     0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |    22.897 ns |  0.2355 ns |  0.2203 ns |    22.775 ns |   6.23 |     0.06 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    15.852 ns |  0.0024 ns |  0.0021 ns |    15.852 ns |   4.31 |     0.00 |
|                                               LinqToArray |            [0] |    44.741 ns |  0.0426 ns |  0.0399 ns |    44.731 ns |  12.18 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |    29.099 ns |  0.0614 ns |  0.0574 ns |    29.118 ns |   7.92 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    27.574 ns |  0.4004 ns |  0.3746 ns |    27.368 ns |   7.50 |     0.10 |
|                              LowCostLinqWithStructToArray |            [0] |    28.164 ns |  0.0338 ns |  0.0316 ns |    28.154 ns |   7.67 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    19.298 ns |  0.0050 ns |  0.0047 ns |    19.298 ns |   5.25 |     0.00 |
|                                                      Take |            [0] |    65.460 ns |  0.1391 ns |  0.1233 ns |    65.498 ns |  17.82 |     0.03 |
|                                               LowCostTake |            [0] |    34.300 ns |  0.2549 ns |  0.2384 ns |    34.159 ns |   9.34 |     0.06 |
|                                  LowCostTakeWithoutChecks |            [0] |    26.138 ns |  0.0074 ns |  0.0069 ns |    26.140 ns |   7.11 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |    36.561 ns |  0.0020 ns |  0.0018 ns |    36.561 ns |   9.95 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    28.231 ns |  0.1523 ns |  0.1350 ns |    28.169 ns |   7.68 |     0.04 |
|                                            SkipTakeSingle |            [0] |    92.063 ns |  1.7596 ns |  1.6459 ns |    92.183 ns |  25.06 |     0.43 |
|                                     LowCostSkipTakeSingle |            [0] |    36.310 ns |  0.0025 ns |  0.0022 ns |    36.310 ns |   9.88 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    39.341 ns |  0.0023 ns |  0.0021 ns |    39.341 ns |  10.71 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    40.002 ns |  0.3833 ns |  0.3586 ns |    39.951 ns |  10.89 |     0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    31.897 ns |  0.0022 ns |  0.0020 ns |    31.897 ns |   8.68 |     0.01 |
|                                           ForeachDelegate |            [0] |    15.862 ns |  0.0129 ns |  0.0115 ns |    15.858 ns |   4.32 |     0.00 |
|                                                   Foreach |            [0] |    12.645 ns |  0.0093 ns |  0.0083 ns |    12.643 ns |   3.44 |     0.00 |
|                                                       For |            [0] |     3.674 ns |  0.0029 ns |  0.0023 ns |     3.674 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |         **[1000]** | **6,511.190 ns** |  **3.6633 ns** |  **3.4267 ns** | **6,510.070 ns** |  **25.92** |     **0.01** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,853.279 ns |  1.1918 ns |  0.9952 ns | 3,853.566 ns |  15.34 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,146.776 ns | 27.7736 ns | 25.9794 ns | 3,126.682 ns |  12.53 |     0.10 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 4,098.048 ns |  2.8944 ns |  2.4169 ns | 4,098.620 ns |  16.32 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,373.948 ns |  0.2796 ns |  0.2615 ns | 3,373.858 ns |  13.43 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,832.367 ns |  0.3444 ns |  0.2876 ns | 1,832.247 ns |   7.30 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,725.735 ns |  0.4787 ns |  0.4478 ns | 1,725.580 ns |   6.87 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 9,302.541 ns | 37.4816 ns | 35.0603 ns | 9,319.193 ns |  37.04 |     0.13 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 8,412.499 ns |  0.8741 ns |  0.8176 ns | 8,412.166 ns |  33.49 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 6,340.876 ns | 73.7307 ns | 68.9677 ns | 6,298.464 ns |  25.25 |     0.27 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 5,306.475 ns |  0.3407 ns |  0.3187 ns | 5,306.428 ns |  21.13 |     0.00 |
|                                                 LinqCount |         [1000] | 1,721.834 ns |  2.4331 ns |  2.2759 ns | 1,721.103 ns |   6.86 |     0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,643.096 ns | 40.6330 ns | 38.0082 ns | 3,617.960 ns |  14.50 |     0.15 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 2,411.493 ns |  0.5778 ns |  0.4511 ns | 2,411.299 ns |   9.60 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] | 1,732.523 ns |  2.2152 ns |  2.0721 ns | 1,733.120 ns |   6.90 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] | 1,207.962 ns |  0.1015 ns |  0.0949 ns | 1,207.935 ns |   4.81 |     0.00 |
|                                               LinqToArray |         [1000] | 3,052.512 ns | 33.3622 ns | 31.2070 ns | 3,035.925 ns |  12.15 |     0.12 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 5,705.365 ns |  3.1687 ns |  2.9640 ns | 5,706.369 ns |  22.72 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 3,920.805 ns |  8.1670 ns |  7.6394 ns | 3,922.700 ns |  15.61 |     0.03 |
|                              LowCostLinqWithStructToArray |         [1000] | 3,179.708 ns | 37.4133 ns | 34.9964 ns | 3,159.219 ns |  12.66 |     0.13 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 2,269.194 ns |  1.5880 ns |  1.4854 ns | 2,268.851 ns |   9.03 |     0.01 |
|                                                      Take |         [1000] |   301.679 ns |  0.0482 ns |  0.0451 ns |   301.684 ns |   1.20 |     0.00 |
|                                               LowCostTake |         [1000] |   120.491 ns |  0.2445 ns |  0.2287 ns |   120.602 ns |   0.48 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    98.608 ns |  0.0131 ns |  0.0102 ns |    98.606 ns |   0.39 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    78.256 ns |  0.0351 ns |  0.0328 ns |    78.271 ns |   0.31 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    66.564 ns |  0.1821 ns |  0.1704 ns |    66.468 ns |   0.27 |     0.00 |
|                                            SkipTakeSingle |         [1000] |   225.537 ns |  0.0218 ns |  0.0193 ns |   225.538 ns |   0.90 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   130.936 ns |  1.7014 ns |  1.5915 ns |   131.330 ns |   0.52 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   104.868 ns |  0.0262 ns |  0.0232 ns |   104.861 ns |   0.42 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    80.733 ns |  0.2027 ns |  0.1896 ns |    80.625 ns |   0.32 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    57.568 ns |  0.0076 ns |  0.0068 ns |    57.567 ns |   0.23 |     0.00 |
|                                           ForeachDelegate |         [1000] | 2,653.716 ns |  6.2343 ns |  5.2059 ns | 2,650.660 ns |  10.57 |     0.02 |
|                                                   Foreach |         [1000] | 1,691.360 ns |  1.4120 ns |  1.3208 ns | 1,690.562 ns |   6.73 |     0.01 |
|                                                       For |         [1000] |   251.167 ns |  0.0106 ns |  0.0088 ns |   251.170 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **[50]** |   **373.074 ns** |  **4.7041 ns** |  **4.4002 ns** |   **370.823 ns** |  **22.43** |     **0.26** |
|                                   LowCostLinqWithDelegate |           [50] |   222.049 ns |  0.0123 ns |  0.0109 ns |   222.048 ns |  13.35 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   177.926 ns |  0.0261 ns |  0.0244 ns |   177.924 ns |  10.70 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           [50] |   242.130 ns |  0.0177 ns |  0.0138 ns |   242.132 ns |  14.56 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   198.210 ns |  0.0296 ns |  0.0231 ns |   198.202 ns |  11.92 |     0.01 |
|                                LowCostLinqWithStructWhere |           [50] |   127.523 ns |  0.3101 ns |  0.2900 ns |   127.319 ns |   7.67 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   106.198 ns |  0.0250 ns |  0.0222 ns |   106.194 ns |   6.38 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   514.305 ns |  0.8874 ns |  0.8301 ns |   514.512 ns |  30.92 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   462.854 ns |  0.0699 ns |  0.0583 ns |   462.829 ns |  27.83 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   360.898 ns |  0.1701 ns |  0.1591 ns |   360.946 ns |  21.70 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   311.198 ns |  0.0774 ns |  0.0724 ns |   311.183 ns |  18.71 |     0.02 |
|                                                 LinqCount |           [50] |   124.724 ns |  0.9331 ns |  0.8729 ns |   124.300 ns |   7.50 |     0.05 |
|                              LowCostLinqWithDelegateCount |           [50] |   213.732 ns |  0.0207 ns |  0.0194 ns |   213.731 ns |  12.85 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   148.466 ns |  0.0862 ns |  0.0807 ns |   148.509 ns |   8.93 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |   116.149 ns |  0.0114 ns |  0.0106 ns |   116.148 ns |   6.98 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    71.300 ns |  0.1930 ns |  0.1507 ns |    71.399 ns |   4.29 |     0.01 |
|                                               LinqToArray |           [50] |   355.504 ns |  0.1620 ns |  0.1516 ns |   355.507 ns |  21.37 |     0.02 |
|                            LowCostLinqWithDelegateToArray |           [50] |   405.240 ns |  0.5451 ns |  0.5099 ns |   405.414 ns |  24.36 |     0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   299.275 ns |  0.0713 ns |  0.0632 ns |   299.284 ns |  17.99 |     0.02 |
|                              LowCostLinqWithStructToArray |           [50] |   254.001 ns |  0.7836 ns |  0.6946 ns |   254.324 ns |  15.27 |     0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   198.348 ns |  0.1792 ns |  0.1588 ns |   198.381 ns |  11.92 |     0.02 |
|                                                      Take |           [50] |   301.980 ns |  0.1434 ns |  0.1341 ns |   302.019 ns |  18.15 |     0.02 |
|                                               LowCostTake |           [50] |   120.455 ns |  0.0150 ns |  0.0126 ns |   120.454 ns |   7.24 |     0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    98.296 ns |  0.1734 ns |  0.1622 ns |    98.350 ns |   5.91 |     0.01 |
|                                     LowCostTakeWithStruct |           [50] |    77.912 ns |  0.0066 ns |  0.0059 ns |    77.911 ns |   4.68 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    66.453 ns |  0.0193 ns |  0.0180 ns |    66.458 ns |   3.99 |     0.00 |
|                                            SkipTakeSingle |           [50] |   227.599 ns |  2.6309 ns |  2.4609 ns |   226.640 ns |  13.68 |     0.14 |
|                                     LowCostSkipTakeSingle |           [50] |   126.244 ns |  0.0353 ns |  0.0330 ns |   126.257 ns |   7.59 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   104.812 ns |  0.0249 ns |  0.0233 ns |   104.817 ns |   6.30 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    81.431 ns |  0.0277 ns |  0.0259 ns |    81.426 ns |   4.90 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    57.541 ns |  0.0537 ns |  0.0502 ns |    57.539 ns |   3.46 |     0.00 |
|                                           ForeachDelegate |           [50] |   154.211 ns |  0.0087 ns |  0.0077 ns |   154.209 ns |   9.27 |     0.01 |
|                                                   Foreach |           [50] |   103.111 ns |  0.0226 ns |  0.0201 ns |   103.113 ns |   6.20 |     0.01 |
|                                                       For |           [50] |    16.634 ns |  0.0186 ns |  0.0174 ns |    16.632 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |            **[5]** |    **66.574 ns** |  **0.0110 ns** |  **0.0086 ns** |    **66.573 ns** |  **12.30** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    46.940 ns |  0.0045 ns |  0.0040 ns |    46.940 ns |   8.67 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    38.191 ns |  0.3762 ns |  0.3519 ns |    38.037 ns |   7.05 |     0.06 |
|                                  LowCostLinqWithDelegate2 |            [5] |    53.875 ns |  0.0085 ns |  0.0075 ns |    53.875 ns |   9.95 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    45.285 ns |  0.0107 ns |  0.0095 ns |    45.282 ns |   8.36 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |    40.014 ns |  0.0101 ns |  0.0084 ns |    40.016 ns |   7.39 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    30.127 ns |  0.0093 ns |  0.0078 ns |    30.125 ns |   5.56 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    85.252 ns |  0.0621 ns |  0.0550 ns |    85.269 ns |  15.75 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    79.282 ns |  0.2582 ns |  0.2415 ns |    79.310 ns |  14.64 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    74.879 ns |  0.0499 ns |  0.0390 ns |    74.867 ns |  13.83 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    65.612 ns |  0.0285 ns |  0.0238 ns |    65.608 ns |  12.12 |     0.01 |
|                                                 LinqCount |            [5] |    41.332 ns |  0.0266 ns |  0.0236 ns |    41.338 ns |   7.63 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    45.821 ns |  0.0335 ns |  0.0313 ns |    45.811 ns |   8.46 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    36.936 ns |  0.3228 ns |  0.3020 ns |    36.749 ns |   6.82 |     0.05 |
|                           LowCostLinqWithStructWhereCount |            [5] |    31.226 ns |  0.0395 ns |  0.0369 ns |    31.226 ns |   5.77 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    21.386 ns |  0.1176 ns |  0.1100 ns |    21.326 ns |   3.95 |     0.02 |
|                                               LinqToArray |            [5] |    98.138 ns |  0.2277 ns |  0.2130 ns |    98.123 ns |  18.13 |     0.04 |
|                            LowCostLinqWithDelegateToArray |            [5] |    82.736 ns |  1.2912 ns |  1.2078 ns |    82.176 ns |  15.28 |     0.22 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    72.029 ns |  0.0417 ns |  0.0390 ns |    72.034 ns |  13.30 |     0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    70.203 ns |  0.0377 ns |  0.0315 ns |    70.201 ns |  12.97 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    54.751 ns |  0.1403 ns |  0.1096 ns |    54.718 ns |  10.11 |     0.02 |
|                                                      Take |            [5] |   126.746 ns |  0.0575 ns |  0.0480 ns |   126.741 ns |  23.41 |     0.01 |
|                                               LowCostTake |            [5] |    58.787 ns |  0.0057 ns |  0.0050 ns |    58.787 ns |  10.86 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    48.939 ns |  0.0031 ns |  0.0027 ns |    48.938 ns |   9.04 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |    48.310 ns |  0.0194 ns |  0.0162 ns |    48.301 ns |   8.92 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    39.442 ns |  0.0112 ns |  0.0105 ns |    39.439 ns |   7.29 |     0.00 |
|                                            SkipTakeSingle |            [5] |   120.703 ns |  0.3197 ns |  0.2991 ns |   120.870 ns |  22.29 |     0.05 |
|                                     LowCostSkipTakeSingle |            [5] |    54.985 ns |  0.4792 ns |  0.4483 ns |    54.732 ns |  10.16 |     0.08 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    47.084 ns |  0.0157 ns |  0.0147 ns |    47.091 ns |   8.70 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    49.026 ns |  0.0162 ns |  0.0152 ns |    49.019 ns |   9.06 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    37.414 ns |  0.0999 ns |  0.0934 ns |    37.436 ns |   6.91 |     0.02 |
|                                           ForeachDelegate |            [5] |    29.479 ns |  0.0155 ns |  0.0121 ns |    29.475 ns |   5.44 |     0.00 |
|                                                   Foreach |            [5] |    20.606 ns |  0.0134 ns |  0.0119 ns |    20.602 ns |   3.81 |     0.00 |
|                                                       For |            [5] |     5.414 ns |  0.0015 ns |  0.0014 ns |     5.414 ns |   1.00 |     0.00 |
