``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |      Error |     StdDev |        Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|-----------:|-----------:|--------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **82.841 ns** |  **0.0266 ns** |  **0.0235 ns** |     **82.843 ns** |  **22.50** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     32.430 ns |  0.0066 ns |  0.0058 ns |     32.430 ns |   8.81 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     22.743 ns |  0.0009 ns |  0.0008 ns |     22.743 ns |   6.18 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     53.291 ns |  0.0017 ns |  0.0016 ns |     53.290 ns |  14.47 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     48.314 ns |  0.0065 ns |  0.0054 ns |     48.316 ns |  13.12 |     0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     54.201 ns |  0.0020 ns |  0.0018 ns |     54.201 ns |  14.72 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     35.840 ns |  0.0011 ns |  0.0010 ns |     35.840 ns |   9.73 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     62.976 ns |  0.0270 ns |  0.0240 ns |     62.978 ns |  17.10 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     58.264 ns |  0.0384 ns |  0.0359 ns |     58.262 ns |  15.82 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     59.828 ns |  0.8351 ns |  0.7812 ns |     59.509 ns |  16.25 |     0.21 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     52.163 ns |  0.0432 ns |  0.0404 ns |     52.171 ns |  14.17 |     0.01 |
|                                                 LinqCount |            [0] |     82.332 ns |  0.1761 ns |  0.1648 ns |     82.385 ns |  22.36 |     0.04 |
|                              LowCostLinqWithDelegateCount |            [0] |     26.723 ns |  0.2807 ns |  0.2626 ns |     26.568 ns |   7.26 |     0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     25.350 ns |  0.0208 ns |  0.0195 ns |     25.349 ns |   6.88 |     0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     35.849 ns |  0.0012 ns |  0.0011 ns |     35.849 ns |   9.74 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     28.352 ns |  0.0672 ns |  0.0525 ns |     28.350 ns |   7.70 |     0.01 |
|                                               LinqToArray |            [0] |     95.164 ns |  0.0448 ns |  0.0419 ns |     95.164 ns |  25.84 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     31.422 ns |  0.0158 ns |  0.0148 ns |     31.421 ns |   8.53 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     29.743 ns |  0.0147 ns |  0.0131 ns |     29.746 ns |   8.08 |     0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     39.541 ns |  0.4417 ns |  0.4131 ns |     39.205 ns |  10.74 |     0.11 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     32.470 ns |  0.0050 ns |  0.0046 ns |     32.470 ns |   8.82 |     0.00 |
|                                                      Take |            [0] |    120.127 ns |  0.0304 ns |  0.0269 ns |    120.131 ns |  32.62 |     0.01 |
|                                               LowCostTake |            [0] |     36.917 ns |  0.0578 ns |  0.0541 ns |     36.935 ns |  10.03 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     32.994 ns |  0.4292 ns |  0.4015 ns |     32.713 ns |   8.96 |     0.11 |
|                                     LowCostTakeWithStruct |            [0] |     51.596 ns |  0.0111 ns |  0.0104 ns |     51.596 ns |  14.01 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     49.221 ns |  0.0097 ns |  0.0091 ns |     49.222 ns |  13.37 |     0.01 |
|                                            SkipTakeSingle |            [0] |    140.356 ns |  0.3503 ns |  0.3105 ns |    140.457 ns |  38.12 |     0.08 |
|                                     LowCostSkipTakeSingle |            [0] |     43.438 ns |  0.0012 ns |  0.0011 ns |     43.438 ns |  11.80 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     42.569 ns |  0.0098 ns |  0.0087 ns |     42.569 ns |  11.56 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     55.726 ns |  0.0023 ns |  0.0021 ns |     55.726 ns |  15.13 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     48.022 ns |  0.0024 ns |  0.0018 ns |     48.023 ns |  13.04 |     0.01 |
|                                           ForeachDelegate |            [0] |     17.147 ns |  0.0502 ns |  0.0469 ns |     17.125 ns |   4.66 |     0.01 |
|                                                   Foreach |            [0] |     12.634 ns |  0.0092 ns |  0.0086 ns |     12.634 ns |   3.43 |     0.00 |
|                                                       For |            [0] |      3.682 ns |  0.0016 ns |  0.0015 ns |      3.682 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |         **[1000]** | **11,907.770 ns** | **47.0374 ns** | **43.9988 ns** | **11,901.495 ns** |  **46.72** |     **0.63** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,972.155 ns | 18.9670 ns | 17.7417 ns |  7,978.755 ns |  31.28 |     0.41 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  7,498.849 ns | 86.4044 ns | 80.8228 ns |  7,451.661 ns |  29.42 |     0.49 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,143.555 ns | 20.1118 ns | 18.8126 ns |  9,133.250 ns |  35.87 |     0.47 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  7,789.726 ns |  5.7987 ns |  5.4241 ns |  7,788.859 ns |  30.56 |     0.40 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,845.580 ns |  1.1653 ns |  1.0330 ns |  1,845.594 ns |   7.24 |     0.09 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,751.402 ns | 18.3748 ns | 17.1878 ns |  1,739.137 ns |   6.87 |     0.11 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 18,868.149 ns | 74.3219 ns | 69.5207 ns | 18,882.929 ns |  74.03 |     0.99 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 18,058.317 ns | 22.7932 ns | 21.3207 ns | 18,052.458 ns |  70.85 |     0.92 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,271.459 ns |  1.7587 ns |  1.4686 ns |  6,271.024 ns |  24.61 |     0.32 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  6,031.735 ns |  0.4448 ns |  0.3473 ns |  6,031.738 ns |  23.67 |     0.31 |
|                                                 LinqCount |         [1000] |  6,764.110 ns | 18.3764 ns | 17.1893 ns |  6,760.744 ns |  26.54 |     0.35 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,419.167 ns | 42.0973 ns | 37.3181 ns |  7,409.656 ns |  29.11 |     0.40 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,389.474 ns | 38.0872 ns | 35.6268 ns |  6,384.307 ns |  25.07 |     0.35 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,738.301 ns |  0.4118 ns |  0.3650 ns |  1,738.200 ns |   6.82 |     0.09 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,222.611 ns |  2.3041 ns |  2.1552 ns |  1,223.548 ns |   4.80 |     0.06 |
|                                               LinqToArray |         [1000] |  7,543.934 ns | 38.6415 ns | 32.2674 ns |  7,534.313 ns |  29.60 |     0.40 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,434.645 ns |  5.0450 ns |  4.7191 ns |  9,433.006 ns |  37.02 |     0.48 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,926.313 ns |  7.4190 ns |  6.9398 ns |  7,927.587 ns |  31.10 |     0.40 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,185.080 ns |  2.4436 ns |  2.0405 ns |  3,184.390 ns |  12.50 |     0.16 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,324.992 ns |  1.4657 ns |  1.2993 ns |  2,325.632 ns |   9.12 |     0.12 |
|                                                      Take |         [1000] |    471.319 ns |  0.1237 ns |  0.1096 ns |    471.291 ns |   1.85 |     0.02 |
|                                               LowCostTake |         [1000] |    208.925 ns |  0.0235 ns |  0.0209 ns |    208.925 ns |   0.82 |     0.01 |
|                                  LowCostTakeWithoutChecks |         [1000] |    190.197 ns |  0.0111 ns |  0.0104 ns |    190.199 ns |   0.75 |     0.01 |
|                                     LowCostTakeWithStruct |         [1000] |     90.538 ns |  0.0061 ns |  0.0047 ns |     90.540 ns |   0.36 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     80.912 ns |  0.0164 ns |  0.0145 ns |     80.911 ns |   0.32 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    382.887 ns |  6.2264 ns |  5.8241 ns |    378.214 ns |   1.50 |     0.03 |
|                                     LowCostSkipTakeSingle |         [1000] |    237.460 ns |  0.1578 ns |  0.1476 ns |    237.403 ns |   0.93 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    203.534 ns |  0.1442 ns |  0.1348 ns |    203.578 ns |   0.80 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    109.618 ns |  0.0528 ns |  0.0412 ns |    109.616 ns |   0.43 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     77.730 ns |  0.2959 ns |  0.2768 ns |     77.825 ns |   0.30 |     0.00 |
|                                           ForeachDelegate |         [1000] |  5,312.937 ns |  9.7395 ns |  9.1104 ns |  5,311.065 ns |  20.84 |     0.27 |
|                                                   Foreach |         [1000] |  1,693.917 ns |  0.4538 ns |  0.4023 ns |  1,693.896 ns |   6.65 |     0.09 |
|                                                       For |         [1000] |    254.922 ns |  3.6503 ns |  3.4145 ns |    256.666 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |           **[50]** |    **681.010 ns** |  **0.7921 ns** |  **0.7022 ns** |    **681.002 ns** |  **38.44** |     **0.05** |
|                                   LowCostLinqWithDelegate |           [50] |    431.770 ns |  0.3071 ns |  0.2873 ns |    431.744 ns |  24.37 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    402.846 ns |  5.7388 ns |  5.3681 ns |    399.864 ns |  22.74 |     0.29 |
|                                  LowCostLinqWithDelegate2 |           [50] |    507.395 ns |  1.1030 ns |  1.0317 ns |    507.889 ns |  28.64 |     0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    452.833 ns |  0.3237 ns |  0.3028 ns |    452.930 ns |  25.56 |     0.03 |
|                                LowCostLinqWithStructWhere |           [50] |    141.267 ns |  0.0630 ns |  0.0590 ns |    141.300 ns |   7.97 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    121.685 ns |  1.0344 ns |  0.9676 ns |    121.959 ns |   6.87 |     0.05 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,054.250 ns |  3.8740 ns |  3.6238 ns |  1,055.052 ns |  59.50 |     0.20 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    971.448 ns |  0.9788 ns |  0.9155 ns |    971.809 ns |  54.83 |     0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    375.271 ns |  0.2552 ns |  0.2262 ns |    375.340 ns |  21.18 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    361.817 ns |  4.9598 ns |  4.6394 ns |    359.078 ns |  20.42 |     0.25 |
|                                                 LinqCount |           [50] |    421.485 ns |  0.2870 ns |  0.2684 ns |    421.342 ns |  23.79 |     0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |    409.547 ns |  0.4864 ns |  0.4550 ns |    409.691 ns |  23.11 |     0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    353.926 ns |  0.4475 ns |  0.4185 ns |    353.966 ns |  19.98 |     0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |    127.895 ns |  0.0170 ns |  0.0133 ns |    127.891 ns |   7.22 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     82.987 ns |  0.0043 ns |  0.0040 ns |     82.987 ns |   4.68 |     0.00 |
|                                               LinqToArray |           [50] |    650.801 ns |  0.7478 ns |  0.6629 ns |    650.852 ns |  36.73 |     0.05 |
|                            LowCostLinqWithDelegateToArray |           [50] |    624.349 ns |  7.9262 ns |  7.4142 ns |    619.996 ns |  35.24 |     0.41 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    512.428 ns |  1.3036 ns |  1.2194 ns |    511.993 ns |  28.92 |     0.07 |
|                              LowCostLinqWithStructToArray |           [50] |    258.660 ns |  0.2551 ns |  0.2386 ns |    258.701 ns |  14.60 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    208.158 ns |  0.1936 ns |  0.1716 ns |    208.189 ns |  11.75 |     0.01 |
|                                                      Take |           [50] |    476.447 ns |  7.4469 ns |  6.9658 ns |    471.647 ns |  26.89 |     0.38 |
|                                               LowCostTake |           [50] |    208.529 ns |  0.0176 ns |  0.0147 ns |    208.534 ns |  11.77 |     0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    190.776 ns |  0.0140 ns |  0.0117 ns |    190.777 ns |  10.77 |     0.01 |
|                                     LowCostTakeWithStruct |           [50] |     90.223 ns |  0.7253 ns |  0.6785 ns |     89.858 ns |   5.09 |     0.04 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     80.990 ns |  0.0188 ns |  0.0176 ns |     80.993 ns |   4.57 |     0.00 |
|                                            SkipTakeSingle |           [50] |    378.963 ns |  0.6851 ns |  0.6409 ns |    379.250 ns |  21.39 |     0.04 |
|                                     LowCostSkipTakeSingle |           [50] |    237.560 ns |  0.1061 ns |  0.0992 ns |    237.549 ns |  13.41 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    203.440 ns |  0.1264 ns |  0.1121 ns |    203.476 ns |  11.48 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    109.299 ns |  0.0940 ns |  0.0785 ns |    109.316 ns |   6.17 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     77.940 ns |  0.2964 ns |  0.2772 ns |     78.043 ns |   4.40 |     0.02 |
|                                           ForeachDelegate |           [50] |    293.221 ns |  2.8329 ns |  2.6499 ns |    293.753 ns |  16.55 |     0.15 |
|                                                   Foreach |           [50] |    103.257 ns |  0.0864 ns |  0.0808 ns |    103.287 ns |   5.83 |     0.01 |
|                                                       For |           [50] |     17.718 ns |  0.0153 ns |  0.0143 ns |     17.719 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |            **[5]** |    **146.211 ns** |  **0.2407 ns** |  **0.2251 ns** |    **146.247 ns** |  **27.00** |     **0.06** |
|                                   LowCostLinqWithDelegate |            [5] |     67.269 ns |  0.0321 ns |  0.0250 ns |     67.262 ns |  12.42 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     56.979 ns |  0.0379 ns |  0.0355 ns |     56.981 ns |  10.52 |     0.02 |
|                                  LowCostLinqWithDelegate2 |            [5] |     94.285 ns |  0.0053 ns |  0.0041 ns |     94.284 ns |  17.41 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     86.394 ns |  0.3370 ns |  0.2631 ns |     86.478 ns |  15.96 |     0.05 |
|                                LowCostLinqWithStructWhere |            [5] |     52.860 ns |  0.0119 ns |  0.0100 ns |     52.857 ns |   9.76 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     45.565 ns |  0.0045 ns |  0.0040 ns |     45.564 ns |   8.42 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    169.800 ns |  2.4933 ns |  2.3322 ns |    169.262 ns |  31.36 |     0.42 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    150.263 ns |  0.1773 ns |  0.1658 ns |    150.233 ns |  27.75 |     0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     87.453 ns |  0.0358 ns |  0.0317 ns |     87.442 ns |  16.15 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     82.093 ns |  0.0549 ns |  0.0514 ns |     82.100 ns |  15.16 |     0.03 |
|                                                 LinqCount |            [5] |    117.432 ns |  0.0815 ns |  0.0680 ns |    117.420 ns |  21.69 |     0.04 |
|                              LowCostLinqWithDelegateCount |            [5] |     64.668 ns |  0.0429 ns |  0.0401 ns |     64.651 ns |  11.94 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     59.151 ns |  0.0596 ns |  0.0557 ns |     59.146 ns |  10.92 |     0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |     44.457 ns |  0.0110 ns |  0.0103 ns |     44.456 ns |   8.21 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     33.963 ns |  0.1904 ns |  0.1688 ns |     33.973 ns |   6.27 |     0.03 |
|                                               LinqToArray |            [5] |    181.334 ns |  0.0637 ns |  0.0596 ns |    181.347 ns |  33.49 |     0.05 |
|                            LowCostLinqWithDelegateToArray |            [5] |    102.248 ns |  0.0660 ns |  0.0617 ns |    102.219 ns |  18.88 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     95.516 ns |  1.5934 ns |  1.4905 ns |     94.422 ns |  17.64 |     0.27 |
|                              LowCostLinqWithStructToArray |            [5] |     78.885 ns |  0.0176 ns |  0.0156 ns |     78.879 ns |  14.57 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     65.970 ns |  0.0435 ns |  0.0406 ns |     65.968 ns |  12.18 |     0.02 |
|                                                      Take |            [5] |    222.266 ns |  0.1219 ns |  0.0952 ns |    222.250 ns |  41.05 |     0.07 |
|                                               LowCostTake |            [5] |     74.663 ns |  0.1047 ns |  0.0928 ns |     74.679 ns |  13.79 |     0.03 |
|                                  LowCostTakeWithoutChecks |            [5] |     69.883 ns |  0.0053 ns |  0.0044 ns |     69.882 ns |  12.91 |     0.02 |
|                                     LowCostTakeWithStruct |            [5] |     64.638 ns |  0.0167 ns |  0.0156 ns |     64.640 ns |  11.94 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     52.005 ns |  0.0149 ns |  0.0132 ns |     52.005 ns |   9.61 |     0.01 |
|                                            SkipTakeSingle |            [5] |    197.092 ns |  0.0589 ns |  0.0522 ns |    197.085 ns |  36.40 |     0.06 |
|                                     LowCostSkipTakeSingle |            [5] |     80.842 ns |  0.0711 ns |  0.0665 ns |     80.867 ns |  14.93 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     77.935 ns |  0.0579 ns |  0.0513 ns |     77.905 ns |  14.39 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     66.474 ns |  0.2185 ns |  0.1706 ns |     66.532 ns |  12.28 |     0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     54.695 ns |  0.1728 ns |  0.1617 ns |     54.740 ns |  10.10 |     0.03 |
|                                           ForeachDelegate |            [5] |     44.205 ns |  0.0156 ns |  0.0146 ns |     44.204 ns |   8.16 |     0.01 |
|                                                   Foreach |            [5] |     20.758 ns |  0.0326 ns |  0.0305 ns |     20.767 ns |   3.83 |     0.01 |
|                                                       For |            [5] |      5.414 ns |  0.0097 ns |  0.0086 ns |      5.417 ns |   1.00 |     0.00 |
