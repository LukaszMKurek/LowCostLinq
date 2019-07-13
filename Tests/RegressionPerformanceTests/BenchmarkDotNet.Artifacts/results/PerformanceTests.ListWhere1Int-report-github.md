``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **35.402 ns** |  **0.0528 ns** |  **0.0494 ns** |    **35.390 ns** |  **8.81** |    **0.17** |
|                                   LowCostLinqWithDelegate |            [0] |    25.582 ns |  0.3284 ns |  0.3072 ns |    25.364 ns |  6.37 |    0.12 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    19.110 ns |  0.0046 ns |  0.0041 ns |    19.110 ns |  4.75 |    0.09 |
|                                  LowCostLinqWithDelegate2 |            [0] |    31.643 ns |  0.0058 ns |  0.0049 ns |    31.643 ns |  7.85 |    0.15 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    27.728 ns |  0.0632 ns |  0.0493 ns |    27.712 ns |  6.88 |    0.13 |
|                                LowCostLinqWithStructWhere |            [0] |    29.382 ns |  0.0061 ns |  0.0057 ns |    29.379 ns |  7.31 |    0.14 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    21.213 ns |  0.0027 ns |  0.0026 ns |    21.213 ns |  5.28 |    0.10 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    35.819 ns |  0.0292 ns |  0.0273 ns |    35.827 ns |  8.91 |    0.16 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    32.192 ns |  0.0404 ns |  0.0337 ns |    32.180 ns |  7.99 |    0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    37.748 ns |  0.0555 ns |  0.0519 ns |    37.738 ns |  9.39 |    0.17 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    34.229 ns |  0.0537 ns |  0.0503 ns |    34.206 ns |  8.52 |    0.16 |
|                                                 LinqCount |            [0] |    32.497 ns |  0.0187 ns |  0.0166 ns |    32.500 ns |  8.08 |    0.15 |
|                              LowCostLinqWithDelegateCount |            [0] |    28.887 ns |  0.0188 ns |  0.0167 ns |    28.886 ns |  7.18 |    0.13 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    20.881 ns |  0.0040 ns |  0.0035 ns |    20.881 ns |  5.19 |    0.10 |
|                           LowCostLinqWithStructWhereCount |            [0] |    23.368 ns |  0.0495 ns |  0.0463 ns |    23.365 ns |  5.81 |    0.11 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    15.629 ns |  0.0058 ns |  0.0051 ns |    15.629 ns |  3.88 |    0.07 |
|                                               LinqToArray |            [0] |    45.007 ns |  0.0212 ns |  0.0177 ns |    45.008 ns | 11.17 |    0.21 |
|                            LowCostLinqWithDelegateToArray |            [0] |    33.233 ns |  0.0224 ns |  0.0199 ns |    33.229 ns |  8.26 |    0.16 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    25.487 ns |  0.0074 ns |  0.0062 ns |    25.487 ns |  6.33 |    0.12 |
|                              LowCostLinqWithStructToArray |            [0] |    27.227 ns |  0.4419 ns |  0.4134 ns |    26.937 ns |  6.78 |    0.19 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    19.283 ns |  0.0321 ns |  0.0301 ns |    19.282 ns |  4.80 |    0.09 |
|                                                      Take |            [0] |    71.534 ns |  0.0163 ns |  0.0145 ns |    71.538 ns | 17.78 |    0.34 |
|                                               LowCostTake |            [0] |    34.180 ns |  0.0095 ns |  0.0089 ns |    34.181 ns |  8.51 |    0.16 |
|                                  LowCostTakeWithoutChecks |            [0] |    26.245 ns |  0.0079 ns |  0.0074 ns |    26.244 ns |  6.53 |    0.12 |
|                                     LowCostTakeWithStruct |            [0] |    36.263 ns |  0.0032 ns |  0.0028 ns |    36.264 ns |  9.01 |    0.17 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    28.459 ns |  0.0057 ns |  0.0051 ns |    28.458 ns |  7.07 |    0.13 |
|                                            SkipTakeSingle |            [0] |    92.989 ns |  1.8016 ns |  1.6852 ns |    91.620 ns | 23.13 |    0.29 |
|                                     LowCostSkipTakeSingle |            [0] |    36.396 ns |  0.0039 ns |  0.0034 ns |    36.395 ns |  9.05 |    0.17 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    34.698 ns |  0.0037 ns |  0.0035 ns |    34.699 ns |  8.63 |    0.16 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    39.722 ns |  0.0102 ns |  0.0095 ns |    39.719 ns |  9.88 |    0.18 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    32.527 ns |  0.4128 ns |  0.3861 ns |    32.524 ns |  8.09 |    0.18 |
|                                           ForeachDelegate |            [0] |    15.263 ns |  0.0266 ns |  0.0248 ns |    15.262 ns |  3.80 |    0.07 |
|                                                   Foreach |            [0] |    12.460 ns |  0.0372 ns |  0.0348 ns |    12.449 ns |  3.10 |    0.06 |
|                                                       For |            [0] |     4.020 ns |  0.0806 ns |  0.0754 ns |     3.990 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |         **[1000]** | **7,545.464 ns** |  **5.8301 ns** |  **5.1682 ns** | **7,543.398 ns** | **30.09** |    **0.03** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,613.787 ns |  0.8981 ns |  0.7961 ns | 3,613.682 ns | 14.41 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,267.018 ns | 64.1922 ns | 68.6849 ns | 3,255.818 ns | 13.05 |    0.29 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 3,852.241 ns |  2.1241 ns |  1.9868 ns | 3,851.151 ns | 15.36 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,166.907 ns | 14.7624 ns | 13.8087 ns | 3,167.440 ns | 12.63 |    0.06 |
|                                LowCostLinqWithStructWhere |         [1000] | 2,181.023 ns |  0.4448 ns |  0.4161 ns | 2,180.965 ns |  8.70 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,360.115 ns |  1.0866 ns |  0.8484 ns | 1,359.877 ns |  5.42 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,984.404 ns |  1.3862 ns |  1.2288 ns | 6,984.129 ns | 27.85 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 6,493.636 ns |  1.9559 ns |  1.7339 ns | 6,493.298 ns | 25.90 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 4,668.168 ns | 75.6527 ns | 70.7655 ns | 4,706.743 ns | 18.62 |    0.28 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 4,100.864 ns |  2.1245 ns |  1.9873 ns | 4,101.252 ns | 16.35 |    0.01 |
|                                                 LinqCount |         [1000] | 1,720.404 ns |  2.8994 ns |  2.7121 ns | 1,720.293 ns |  6.86 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,112.708 ns |  5.6761 ns |  5.0317 ns | 3,112.758 ns | 12.41 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 1,695.871 ns |  0.2446 ns |  0.2169 ns | 1,695.900 ns |  6.76 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] | 1,703.333 ns |  1.2804 ns |  1.1977 ns | 1,702.956 ns |  6.79 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   620.471 ns |  0.1307 ns |  0.1223 ns |   620.460 ns |  2.47 |    0.00 |
|                                               LinqToArray |         [1000] | 3,166.167 ns |  1.4023 ns |  1.2431 ns | 3,166.292 ns | 12.63 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 3,892.990 ns |  9.8155 ns |  9.1814 ns | 3,896.761 ns | 15.53 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 3,132.013 ns |  1.9820 ns |  1.6551 ns | 3,131.274 ns | 12.49 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] | 3,151.632 ns | 60.3759 ns | 59.2972 ns | 3,111.682 ns | 12.58 |    0.24 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,891.837 ns |  5.3703 ns |  5.0234 ns | 1,892.566 ns |  7.54 |    0.02 |
|                                                      Take |         [1000] |   310.109 ns |  0.1401 ns |  0.1242 ns |   310.109 ns |  1.24 |    0.00 |
|                                               LowCostTake |         [1000] |   119.965 ns |  0.0945 ns |  0.0838 ns |   119.937 ns |  0.48 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    97.398 ns |  0.0669 ns |  0.0558 ns |    97.416 ns |  0.39 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    77.870 ns |  0.0156 ns |  0.0130 ns |    77.870 ns |  0.31 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    60.630 ns |  0.0759 ns |  0.0710 ns |    60.642 ns |  0.24 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   227.418 ns |  1.2499 ns |  0.9759 ns |   227.156 ns |  0.91 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   123.989 ns |  0.1493 ns |  0.1396 ns |   124.014 ns |  0.49 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   105.220 ns |  0.0978 ns |  0.0867 ns |   105.211 ns |  0.42 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    82.733 ns |  0.0344 ns |  0.0305 ns |    82.731 ns |  0.33 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    60.144 ns |  0.8253 ns |  0.7720 ns |    59.771 ns |  0.24 |    0.00 |
|                                           ForeachDelegate |         [1000] | 3,099.511 ns | 57.5180 ns | 56.4904 ns | 3,114.570 ns | 12.36 |    0.23 |
|                                                   Foreach |         [1000] | 1,695.717 ns |  2.8301 ns |  2.6472 ns | 1,696.180 ns |  6.76 |    0.01 |
|                                                       For |         [1000] |   250.743 ns |  0.0921 ns |  0.0861 ns |   250.702 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |           **[50]** |   **417.270 ns** |  **0.1466 ns** |  **0.1145 ns** |   **417.269 ns** | **25.52** |    **0.05** |
|                                   LowCostLinqWithDelegate |           [50] |   209.513 ns |  0.1079 ns |  0.1009 ns |   209.494 ns | 12.81 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   173.791 ns |  1.3954 ns |  1.3053 ns |   173.954 ns | 10.62 |    0.07 |
|                                  LowCostLinqWithDelegate2 |           [50] |   233.204 ns |  0.0607 ns |  0.0507 ns |   233.204 ns | 14.26 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   187.970 ns |  0.5296 ns |  0.4954 ns |   188.010 ns | 11.50 |    0.04 |
|                                LowCostLinqWithStructWhere |           [50] |   139.922 ns |  0.0338 ns |  0.0316 ns |   139.918 ns |  8.56 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    99.655 ns |  1.0696 ns |  1.0005 ns |    98.971 ns |  6.10 |    0.07 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   389.351 ns |  0.1500 ns |  0.1403 ns |   389.365 ns | 23.81 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   364.452 ns |  0.2713 ns |  0.2538 ns |   364.478 ns | 22.29 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   274.049 ns |  0.0796 ns |  0.0706 ns |   274.044 ns | 16.76 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   247.688 ns |  0.1041 ns |  0.0812 ns |   247.659 ns | 15.15 |    0.03 |
|                                                 LinqCount |           [50] |   123.580 ns |  0.1538 ns |  0.1439 ns |   123.640 ns |  7.56 |    0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |   186.370 ns |  0.9838 ns |  0.9202 ns |   186.639 ns | 11.39 |    0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   110.475 ns |  0.0843 ns |  0.0704 ns |   110.454 ns |  6.76 |    0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |   117.032 ns |  0.1021 ns |  0.0955 ns |   117.013 ns |  7.16 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    45.849 ns |  0.0628 ns |  0.0588 ns |    45.850 ns |  2.80 |    0.01 |
|                                               LinqToArray |           [50] |   374.538 ns |  0.1437 ns |  0.1122 ns |   374.517 ns | 22.91 |    0.04 |
|                            LowCostLinqWithDelegateToArray |           [50] |   327.702 ns |  6.5426 ns |  7.2721 ns |   322.694 ns | 19.93 |    0.38 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   261.739 ns |  0.0672 ns |  0.0595 ns |   261.727 ns | 16.01 |    0.03 |
|                              LowCostLinqWithStructToArray |           [50] |   261.832 ns |  0.1420 ns |  0.1259 ns |   261.837 ns | 16.01 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   189.371 ns |  0.1378 ns |  0.1289 ns |   189.366 ns | 11.58 |    0.03 |
|                                                      Take |           [50] |   316.688 ns |  6.2946 ns |  6.1821 ns |   314.295 ns | 19.41 |    0.40 |
|                                               LowCostTake |           [50] |   119.733 ns |  0.0578 ns |  0.0541 ns |   119.741 ns |  7.32 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    97.498 ns |  0.0432 ns |  0.0404 ns |    97.489 ns |  5.96 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    83.738 ns |  0.0173 ns |  0.0162 ns |    83.737 ns |  5.12 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    59.795 ns |  1.1297 ns |  1.0568 ns |    60.181 ns |  3.66 |    0.06 |
|                                            SkipTakeSingle |           [50] |   227.498 ns |  0.1177 ns |  0.1101 ns |   227.515 ns | 13.91 |    0.03 |
|                                     LowCostSkipTakeSingle |           [50] |   123.925 ns |  0.0875 ns |  0.0776 ns |   123.923 ns |  7.58 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   105.412 ns |  0.1016 ns |  0.0950 ns |   105.444 ns |  6.45 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    83.217 ns |  0.0433 ns |  0.0362 ns |    83.232 ns |  5.09 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    59.426 ns |  0.0965 ns |  0.0806 ns |    59.419 ns |  3.63 |    0.01 |
|                                           ForeachDelegate |           [50] |   174.392 ns |  0.2439 ns |  0.2163 ns |   174.381 ns | 10.66 |    0.03 |
|                                                   Foreach |           [50] |   107.724 ns |  1.0232 ns |  0.9571 ns |   107.207 ns |  6.58 |    0.05 |
|                                                       For |           [50] |    16.352 ns |  0.0355 ns |  0.0315 ns |    16.346 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |            **[5]** |    **71.848 ns** |  **0.0240 ns** |  **0.0212 ns** |    **71.843 ns** | **12.94** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    47.612 ns |  0.0701 ns |  0.0621 ns |    47.606 ns |  8.58 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    36.118 ns |  0.4857 ns |  0.4544 ns |    36.187 ns |  6.51 |    0.08 |
|                                  LowCostLinqWithDelegate2 |            [5] |    51.800 ns |  0.0212 ns |  0.0188 ns |    51.799 ns |  9.33 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    45.723 ns |  0.0197 ns |  0.0184 ns |    45.721 ns |  8.24 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |    41.698 ns |  0.1097 ns |  0.0916 ns |    41.652 ns |  7.51 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    29.271 ns |  0.0267 ns |  0.0250 ns |    29.271 ns |  5.27 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    69.690 ns |  0.0314 ns |  0.0278 ns |    69.681 ns | 12.56 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    65.333 ns |  0.0387 ns |  0.0343 ns |    65.327 ns | 11.77 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    61.858 ns |  0.0522 ns |  0.0436 ns |    61.862 ns | 11.15 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    54.650 ns |  1.0811 ns |  1.1102 ns |    53.909 ns |  9.87 |    0.21 |
|                                                 LinqCount |            [5] |    42.511 ns |  0.0241 ns |  0.0201 ns |    42.512 ns |  7.66 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |    44.375 ns |  0.0423 ns |  0.0375 ns |    44.371 ns |  7.99 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    29.337 ns |  0.5964 ns |  0.7324 ns |    28.828 ns |  5.34 |    0.13 |
|                           LowCostLinqWithStructWhereCount |            [5] |    32.326 ns |  0.1128 ns |  0.1055 ns |    32.318 ns |  5.82 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    19.201 ns |  0.0238 ns |  0.0211 ns |    19.198 ns |  3.46 |    0.00 |
|                                               LinqToArray |            [5] |   101.310 ns |  0.0298 ns |  0.0248 ns |   101.312 ns | 18.25 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    92.062 ns |  0.0282 ns |  0.0250 ns |    92.059 ns | 16.59 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    81.062 ns |  0.0403 ns |  0.0377 ns |    81.055 ns | 14.61 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    81.353 ns |  0.0283 ns |  0.0264 ns |    81.352 ns | 14.66 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    68.008 ns |  1.4127 ns |  1.6269 ns |    66.838 ns | 12.28 |    0.31 |
|                                                      Take |            [5] |   135.683 ns |  0.0613 ns |  0.0574 ns |   135.674 ns | 24.45 |    0.02 |
|                                               LowCostTake |            [5] |    55.492 ns |  0.0302 ns |  0.0267 ns |    55.495 ns | 10.00 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    44.613 ns |  0.0146 ns |  0.0130 ns |    44.613 ns |  8.04 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |    47.564 ns |  0.0113 ns |  0.0094 ns |    47.563 ns |  8.57 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    36.843 ns |  0.0331 ns |  0.0277 ns |    36.838 ns |  6.64 |    0.01 |
|                                            SkipTakeSingle |            [5] |   123.140 ns |  0.0481 ns |  0.0449 ns |   123.145 ns | 22.19 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    55.061 ns |  0.0254 ns |  0.0198 ns |    55.063 ns |  9.92 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    47.332 ns |  0.0497 ns |  0.0465 ns |    47.337 ns |  8.53 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    49.142 ns |  0.0200 ns |  0.0167 ns |    49.141 ns |  8.85 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    36.857 ns |  0.0844 ns |  0.0789 ns |    36.820 ns |  6.64 |    0.02 |
|                                           ForeachDelegate |            [5] |    30.140 ns |  0.4690 ns |  0.4387 ns |    30.158 ns |  5.43 |    0.08 |
|                                                   Foreach |            [5] |    21.140 ns |  0.0168 ns |  0.0131 ns |    21.140 ns |  3.81 |    0.00 |
|                                                       For |            [5] |     5.550 ns |  0.0034 ns |  0.0032 ns |     5.549 ns |  1.00 |    0.00 |
