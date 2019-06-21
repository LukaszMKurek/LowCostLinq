``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **35.209 ns** |   **0.0084 ns** |   **0.0079 ns** |    **35.207 ns** |  **8.93** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |    24.841 ns |   0.0023 ns |   0.0021 ns |    24.841 ns |  6.30 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    19.092 ns |   0.2453 ns |   0.2295 ns |    18.967 ns |  4.84 |    0.06 |
|                                  LowCostLinqWithDelegate2 |            [0] |    32.272 ns |   0.0128 ns |   0.0119 ns |    32.272 ns |  8.19 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    27.687 ns |   0.0007 ns |   0.0006 ns |    27.687 ns |  7.03 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |    29.163 ns |   0.0114 ns |   0.0106 ns |    29.163 ns |  7.40 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    21.038 ns |   0.0061 ns |   0.0051 ns |    21.038 ns |  5.34 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    44.016 ns |   0.0173 ns |   0.0162 ns |    44.016 ns | 11.17 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    38.790 ns |   0.0262 ns |   0.0233 ns |    38.785 ns |  9.84 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    47.804 ns |   0.9327 ns |   0.9160 ns |    47.205 ns | 12.14 |    0.23 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    42.906 ns |   0.0454 ns |   0.0424 ns |    42.896 ns | 10.89 |    0.02 |
|                                                 LinqCount |            [0] |    32.526 ns |   0.0132 ns |   0.0117 ns |    32.525 ns |  8.25 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [0] |    24.789 ns |   0.0956 ns |   0.0894 ns |    24.795 ns |  6.29 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    23.002 ns |   0.0486 ns |   0.0455 ns |    22.995 ns |  5.84 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |    22.887 ns |   0.0685 ns |   0.0640 ns |    22.898 ns |  5.81 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    15.812 ns |   0.0057 ns |   0.0051 ns |    15.810 ns |  4.01 |    0.01 |
|                                               LinqToArray |            [0] |    45.549 ns |   0.7270 ns |   0.6800 ns |    45.156 ns | 11.56 |    0.19 |
|                            LowCostLinqWithDelegateToArray |            [0] |    28.714 ns |   0.0090 ns |   0.0080 ns |    28.716 ns |  7.29 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    26.664 ns |   0.0216 ns |   0.0192 ns |    26.664 ns |  6.77 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |    27.311 ns |   0.0157 ns |   0.0147 ns |    27.312 ns |  6.93 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    19.401 ns |   0.0204 ns |   0.0170 ns |    19.397 ns |  4.92 |    0.01 |
|                                                      Take |            [0] |    71.661 ns |   0.1550 ns |   0.1449 ns |    71.693 ns | 18.18 |    0.06 |
|                                               LowCostTake |            [0] |    34.441 ns |   0.0535 ns |   0.0500 ns |    34.445 ns |  8.74 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [0] |    26.428 ns |   0.2411 ns |   0.2255 ns |    26.279 ns |  6.71 |    0.06 |
|                                     LowCostTakeWithStruct |            [0] |    36.736 ns |   0.0025 ns |   0.0021 ns |    36.735 ns |  9.32 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    28.315 ns |   0.0042 ns |   0.0039 ns |    28.314 ns |  7.19 |    0.02 |
|                                            SkipTakeSingle |            [0] |    91.340 ns |   0.0421 ns |   0.0328 ns |    91.329 ns | 23.18 |    0.06 |
|                                     LowCostSkipTakeSingle |            [0] |    36.388 ns |   0.0166 ns |   0.0147 ns |    36.391 ns |  9.23 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    34.689 ns |   0.0317 ns |   0.0297 ns |    34.679 ns |  8.80 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    39.747 ns |   0.0740 ns |   0.0692 ns |    39.778 ns | 10.09 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    32.577 ns |   0.4106 ns |   0.3841 ns |    32.294 ns |  8.27 |    0.10 |
|                                           ForeachDelegate |            [0] |    15.299 ns |   0.0312 ns |   0.0292 ns |    15.301 ns |  3.88 |    0.01 |
|                                                   Foreach |            [0] |    12.461 ns |   0.0529 ns |   0.0495 ns |    12.460 ns |  3.16 |    0.01 |
|                                                       For |            [0] |     3.941 ns |   0.0093 ns |   0.0087 ns |     3.944 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **7,545.397 ns** |   **5.9745 ns** |   **5.5886 ns** | **7,542.988 ns** | **30.10** |    **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,843.446 ns |   1.3865 ns |   1.2969 ns | 3,843.878 ns | 15.33 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,129.445 ns |   6.7704 ns |   6.3330 ns | 3,133.918 ns | 12.48 |    0.03 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 4,154.205 ns |  66.9920 ns |  62.6644 ns | 4,110.460 ns | 16.51 |    0.19 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,369.861 ns |   0.3633 ns |   0.3398 ns | 3,369.710 ns | 13.44 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,830.181 ns |   0.1634 ns |   0.1449 ns | 1,830.149 ns |  7.30 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,734.250 ns |  17.6846 ns |  16.5422 ns | 1,722.095 ns |  6.91 |    0.07 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 9,132.832 ns |   2.5917 ns |   2.4243 ns | 9,132.309 ns | 36.43 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 8,170.963 ns |   4.4237 ns |   4.1379 ns | 8,171.384 ns | 32.59 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 6,502.026 ns |   1.8808 ns |   1.7593 ns | 6,501.524 ns | 25.94 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 5,597.846 ns |  64.4211 ns |  60.2595 ns | 5,567.513 ns | 22.36 |    0.24 |
|                                                 LinqCount |         [1000] | 1,724.867 ns |   5.0737 ns |   4.7459 ns | 1,724.739 ns |  6.88 |    0.02 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,959.757 ns |  11.7465 ns |  10.9877 ns | 3,961.233 ns | 15.79 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 2,412.627 ns |   0.1407 ns |   0.1175 ns | 2,412.620 ns |  9.62 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] | 1,734.246 ns |  24.5449 ns |  22.9593 ns | 1,722.166 ns |  6.92 |    0.10 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] | 1,206.838 ns |   0.1561 ns |   0.1460 ns | 1,206.832 ns |  4.81 |    0.00 |
|                                               LinqToArray |         [1000] | 3,160.567 ns |   1.2886 ns |   1.2053 ns | 3,160.814 ns | 12.61 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 5,999.473 ns | 110.0564 ns | 102.9468 ns | 5,933.936 ns | 23.98 |    0.42 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 4,078.964 ns |   2.6894 ns |   2.2457 ns | 4,079.234 ns | 16.27 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] | 3,359.267 ns |   5.0625 ns |   4.4878 ns | 3,358.326 ns | 13.40 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 2,475.893 ns |   0.5668 ns |   0.5025 ns | 2,475.922 ns |  9.88 |    0.00 |
|                                                      Take |         [1000] |   313.690 ns |   4.8458 ns |   4.5328 ns |   310.359 ns |  1.25 |    0.02 |
|                                               LowCostTake |         [1000] |   121.210 ns |   0.0928 ns |   0.0868 ns |   121.228 ns |  0.48 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    97.982 ns |   0.0099 ns |   0.0093 ns |    97.982 ns |  0.39 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    78.376 ns |   0.0194 ns |   0.0182 ns |    78.376 ns |  0.31 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    67.226 ns |   0.0199 ns |   0.0155 ns |    67.227 ns |  0.27 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   227.014 ns |   0.1756 ns |   0.1556 ns |   227.007 ns |  0.91 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   126.877 ns |   0.0924 ns |   0.0864 ns |   126.869 ns |  0.51 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   100.866 ns |   1.1119 ns |   1.0400 ns |   100.040 ns |  0.40 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    80.447 ns |   0.0365 ns |   0.0324 ns |    80.450 ns |  0.32 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    59.116 ns |   0.1789 ns |   0.1673 ns |    59.105 ns |  0.24 |    0.00 |
|                                           ForeachDelegate |         [1000] | 3,106.802 ns |   9.3469 ns |   8.7431 ns | 3,110.136 ns | 12.39 |    0.04 |
|                                                   Foreach |         [1000] | 1,695.842 ns |  15.8853 ns |  14.8592 ns | 1,687.390 ns |  6.77 |    0.06 |
|                                                       For |         [1000] |   250.704 ns |   0.0226 ns |   0.0189 ns |   250.699 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |   **417.270 ns** |   **0.0906 ns** |   **0.0847 ns** |   **417.256 ns** | **26.34** |    **0.04** |
|                                   LowCostLinqWithDelegate |           [50] |   222.373 ns |   1.9653 ns |   1.8384 ns |   220.943 ns | 14.04 |    0.12 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   177.757 ns |   0.1082 ns |   0.1013 ns |   177.743 ns | 11.22 |    0.02 |
|                                  LowCostLinqWithDelegate2 |           [50] |   241.191 ns |   0.0522 ns |   0.0488 ns |   241.168 ns | 15.23 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   200.054 ns |   0.0328 ns |   0.0307 ns |   200.052 ns | 12.63 |    0.02 |
|                                LowCostLinqWithStructWhere |           [50] |   129.599 ns |   1.4938 ns |   1.3973 ns |   129.959 ns |  8.18 |    0.09 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   108.051 ns |   0.1929 ns |   0.1804 ns |   108.114 ns |  6.82 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   507.091 ns |   0.1306 ns |   0.1222 ns |   507.095 ns | 32.01 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   452.823 ns |   0.2712 ns |   0.2404 ns |   452.920 ns | 28.58 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   377.985 ns |   0.0938 ns |   0.0831 ns |   377.989 ns | 23.86 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   333.755 ns |   0.0893 ns |   0.0746 ns |   333.760 ns | 21.07 |    0.03 |
|                                                 LinqCount |           [50] |   123.367 ns |   0.2596 ns |   0.2428 ns |   123.297 ns |  7.79 |    0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |   234.390 ns |   2.9000 ns |   2.7127 ns |   232.671 ns | 14.80 |    0.17 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   149.564 ns |   0.0267 ns |   0.0249 ns |   149.565 ns |  9.44 |    0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |   117.149 ns |   0.1926 ns |   0.1608 ns |   117.188 ns |  7.39 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    71.406 ns |   0.0362 ns |   0.0302 ns |    71.395 ns |  4.51 |    0.01 |
|                                               LinqToArray |           [50] |   372.596 ns |   0.0976 ns |   0.0815 ns |   372.585 ns | 23.52 |    0.03 |
|                            LowCostLinqWithDelegateToArray |           [50] |   410.260 ns |   0.4055 ns |   0.3793 ns |   410.196 ns | 25.90 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   313.540 ns |   0.2153 ns |   0.2014 ns |   313.595 ns | 19.79 |    0.03 |
|                              LowCostLinqWithStructToArray |           [50] |   267.249 ns |   5.2434 ns |   4.9047 ns |   263.639 ns | 16.87 |    0.31 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   210.995 ns |   0.0711 ns |   0.0594 ns |   211.005 ns | 13.32 |    0.02 |
|                                                      Take |           [50] |   309.708 ns |   0.1027 ns |   0.0911 ns |   309.708 ns | 19.55 |    0.03 |
|                                               LowCostTake |           [50] |   120.955 ns |   0.1192 ns |   0.1115 ns |   120.986 ns |  7.64 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    98.848 ns |   0.0200 ns |   0.0188 ns |    98.852 ns |  6.24 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    78.183 ns |   0.0155 ns |   0.0121 ns |    78.183 ns |  4.93 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    66.591 ns |   0.0246 ns |   0.0218 ns |    66.590 ns |  4.20 |    0.01 |
|                                            SkipTakeSingle |           [50] |   229.282 ns |   3.4798 ns |   3.2550 ns |   226.926 ns | 14.47 |    0.20 |
|                                     LowCostSkipTakeSingle |           [50] |   127.450 ns |   0.0714 ns |   0.0597 ns |   127.448 ns |  8.04 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   100.473 ns |   0.0248 ns |   0.0208 ns |   100.475 ns |  6.34 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    80.461 ns |   0.0072 ns |   0.0067 ns |    80.462 ns |  5.08 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    59.176 ns |   0.7362 ns |   0.6887 ns |    59.370 ns |  3.74 |    0.04 |
|                                           ForeachDelegate |           [50] |   174.377 ns |   0.2772 ns |   0.2593 ns |   174.341 ns | 11.01 |    0.02 |
|                                                   Foreach |           [50] |   102.911 ns |   0.0722 ns |   0.0676 ns |   102.934 ns |  6.50 |    0.01 |
|                                                       For |           [50] |    15.841 ns |   0.0256 ns |   0.0240 ns |    15.843 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **72.486 ns** |   **1.0896 ns** |   **1.0192 ns** |    **71.914 ns** | **13.05** |    **0.18** |
|                                   LowCostLinqWithDelegate |            [5] |    45.140 ns |   0.0244 ns |   0.0228 ns |    45.141 ns |  8.13 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    36.021 ns |   0.0230 ns |   0.0192 ns |    36.025 ns |  6.49 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |    54.875 ns |   0.5347 ns |   0.5001 ns |    54.550 ns |  9.88 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    46.001 ns |   0.0211 ns |   0.0187 ns |    45.999 ns |  8.28 |    0.01 |
|                                LowCostLinqWithStructWhere |            [5] |    40.203 ns |   0.0061 ns |   0.0054 ns |    40.202 ns |  7.24 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    30.098 ns |   0.0482 ns |   0.0403 ns |    30.105 ns |  5.42 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    90.971 ns |   1.7792 ns |   1.6643 ns |    89.756 ns | 16.38 |    0.30 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    80.514 ns |   0.0085 ns |   0.0071 ns |    80.514 ns | 14.50 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    80.165 ns |   0.0348 ns |   0.0325 ns |    80.165 ns | 14.44 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    71.141 ns |   0.0211 ns |   0.0198 ns |    71.136 ns | 12.81 |    0.01 |
|                                                 LinqCount |            [5] |    43.178 ns |   0.6897 ns |   0.6452 ns |    43.170 ns |  7.77 |    0.12 |
|                              LowCostLinqWithDelegateCount |            [5] |    45.679 ns |   0.0796 ns |   0.0745 ns |    45.692 ns |  8.23 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    36.451 ns |   0.0642 ns |   0.0601 ns |    36.439 ns |  6.56 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |    31.845 ns |   0.1810 ns |   0.1605 ns |    31.830 ns |  5.73 |    0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    21.268 ns |   0.1244 ns |   0.1164 ns |    21.250 ns |  3.83 |    0.02 |
|                                               LinqToArray |            [5] |   100.484 ns |   0.1404 ns |   0.1245 ns |   100.417 ns | 18.10 |    0.02 |
|                            LowCostLinqWithDelegateToArray |            [5] |    83.705 ns |   0.0350 ns |   0.0311 ns |    83.695 ns | 15.07 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    76.164 ns |   0.0176 ns |   0.0147 ns |    76.164 ns | 13.71 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    71.926 ns |   0.0096 ns |   0.0075 ns |    71.926 ns | 12.95 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    57.423 ns |   0.0098 ns |   0.0087 ns |    57.423 ns | 10.34 |    0.01 |
|                                                      Take |            [5] |   135.429 ns |   0.0381 ns |   0.0356 ns |   135.424 ns | 24.39 |    0.02 |
|                                               LowCostTake |            [5] |    55.764 ns |   0.0621 ns |   0.0485 ns |    55.767 ns | 10.04 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    43.633 ns |   0.0254 ns |   0.0225 ns |    43.629 ns |  7.86 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |    48.259 ns |   0.0082 ns |   0.0076 ns |    48.260 ns |  8.69 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    38.376 ns |   0.3670 ns |   0.3433 ns |    38.448 ns |  6.91 |    0.06 |
|                                            SkipTakeSingle |            [5] |   123.023 ns |   0.0244 ns |   0.0217 ns |   123.026 ns | 22.15 |    0.02 |
|                                     LowCostSkipTakeSingle |            [5] |    54.573 ns |   0.0294 ns |   0.0275 ns |    54.568 ns |  9.83 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    47.293 ns |   0.0343 ns |   0.0287 ns |    47.285 ns |  8.52 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    48.971 ns |   0.0276 ns |   0.0244 ns |    48.972 ns |  8.82 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    36.845 ns |   0.0441 ns |   0.0345 ns |    36.850 ns |  6.63 |    0.01 |
|                                           ForeachDelegate |            [5] |    29.794 ns |   0.1461 ns |   0.1220 ns |    29.761 ns |  5.36 |    0.02 |
|                                                   Foreach |            [5] |    20.651 ns |   0.1893 ns |   0.1678 ns |    20.598 ns |  3.72 |    0.03 |
|                                                       For |            [5] |     5.553 ns |   0.0053 ns |   0.0049 ns |     5.555 ns |  1.00 |    0.00 |
