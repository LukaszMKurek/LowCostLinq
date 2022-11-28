``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |     Error |    StdDev | Ratio |
|---------------------------------------------------------- |--------------- |-------------:|----------:|----------:|------:|
|                                                      **Linq** |            **[0]** |    **12.635 ns** | **0.0009 ns** | **0.0008 ns** |  **1.69** |
|                                   LowCostLinqWithDelegate |            [0] |    17.283 ns | 0.0005 ns | 0.0004 ns |  2.31 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    13.749 ns | 0.0007 ns | 0.0006 ns |  1.83 |
|                                  LowCostLinqWithDelegate2 |            [0] |    25.021 ns | 0.0492 ns | 0.0460 ns |  3.34 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    24.463 ns | 0.0006 ns | 0.0006 ns |  3.26 |
|                                LowCostLinqWithStructWhere |            [0] |    24.610 ns | 0.0058 ns | 0.0051 ns |  3.28 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    24.102 ns | 0.0056 ns | 0.0052 ns |  3.22 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    21.803 ns | 0.0486 ns | 0.0455 ns |  2.91 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    20.758 ns | 0.0361 ns | 0.0320 ns |  2.77 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    18.330 ns | 0.0031 ns | 0.0026 ns |  2.45 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    19.564 ns | 0.0065 ns | 0.0054 ns |  2.61 |
|                                                 LinqCount |            [0] |    12.886 ns | 0.0212 ns | 0.0198 ns |  1.72 |
|                              LowCostLinqWithDelegateCount |            [0] |    12.524 ns | 0.0183 ns | 0.0171 ns |  1.67 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    12.516 ns | 0.0128 ns | 0.0114 ns |  1.67 |
|                           LowCostLinqWithStructWhereCount |            [0] |    12.804 ns | 0.0006 ns | 0.0006 ns |  1.71 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    12.797 ns | 0.0010 ns | 0.0009 ns |  1.71 |
|                                               LinqToArray |            [0] |     7.893 ns | 0.0098 ns | 0.0091 ns |  1.05 |
|                            LowCostLinqWithDelegateToArray |            [0] |    15.691 ns | 0.0115 ns | 0.0102 ns |  2.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    16.447 ns | 0.0119 ns | 0.0105 ns |  2.19 |
|                              LowCostLinqWithStructToArray |            [0] |    14.947 ns | 0.0383 ns | 0.0320 ns |  1.99 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    14.929 ns | 0.0033 ns | 0.0026 ns |  1.99 |
|                                                      Take |            [0] |    15.986 ns | 0.0261 ns | 0.0244 ns |  2.13 |
|                                               LowCostTake |            [0] |    24.531 ns | 0.0051 ns | 0.0047 ns |  3.27 |
|                                  LowCostTakeWithoutChecks |            [0] |    20.203 ns | 0.0045 ns | 0.0038 ns |  2.70 |
|                                     LowCostTakeWithStruct |            [0] |    30.328 ns | 0.0008 ns | 0.0007 ns |  4.05 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    30.045 ns | 0.0056 ns | 0.0052 ns |  4.01 |
|                                            SkipTakeSingle |            [0] |    22.934 ns | 0.0214 ns | 0.0200 ns |  3.06 |
|                                     LowCostSkipTakeSingle |            [0] |    26.464 ns | 0.0141 ns | 0.0131 ns |  3.53 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    26.468 ns | 0.0143 ns | 0.0134 ns |  3.53 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    30.882 ns | 0.0253 ns | 0.0237 ns |  4.12 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    31.307 ns | 0.0025 ns | 0.0022 ns |  4.18 |
|                                           ForeachDelegate |            [0] |     7.300 ns | 0.0054 ns | 0.0051 ns |  0.97 |
|                                                   Foreach |            [0] |     7.496 ns | 0.0040 ns | 0.0037 ns |  1.00 |
|                                                           |                |              |           |           |       |
|                                                      **Linq** |         **[1000]** | **5,281.559 ns** | **0.4855 ns** | **0.4054 ns** |  **1.47** |
|                                   LowCostLinqWithDelegate |         [1000] | 2,450.050 ns | 2.1625 ns | 2.0228 ns |  0.68 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 2,692.770 ns | 1.4265 ns | 1.3343 ns |  0.75 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 2,455.681 ns | 1.8453 ns | 1.7260 ns |  0.68 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 2,450.522 ns | 2.2672 ns | 2.1207 ns |  0.68 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,291.704 ns | 0.2479 ns | 0.2319 ns |  0.36 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,287.633 ns | 0.3296 ns | 0.3083 ns |  0.36 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 4,804.904 ns | 1.2602 ns | 1.1172 ns |  1.34 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 4,803.927 ns | 1.8045 ns | 1.5996 ns |  1.34 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,600.981 ns | 1.9176 ns | 1.6013 ns |  1.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,364.688 ns | 1.2198 ns | 1.0186 ns |  0.94 |
|                                                 LinqCount |         [1000] | 1,698.855 ns | 4.1024 ns | 3.8374 ns |  0.47 |
|                              LowCostLinqWithDelegateCount |         [1000] | 1,922.814 ns | 0.0583 ns | 0.0517 ns |  0.54 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 1,922.956 ns | 0.0817 ns | 0.0682 ns |  0.54 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   490.459 ns | 0.0264 ns | 0.0247 ns |  0.14 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   490.377 ns | 0.0311 ns | 0.0291 ns |  0.14 |
|                                               LinqToArray |         [1000] | 2,555.003 ns | 2.8384 ns | 2.6550 ns |  0.71 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 2,593.989 ns | 2.1371 ns | 1.9990 ns |  0.72 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 2,818.253 ns | 2.9125 ns | 2.5818 ns |  0.78 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,385.283 ns | 0.7810 ns | 0.6923 ns |  0.39 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,383.169 ns | 0.7414 ns | 0.5788 ns |  0.38 |
|                                                      Take |         [1000] |   224.182 ns | 0.0923 ns | 0.0818 ns |  0.06 |
|                                               LowCostTake |         [1000] |    74.944 ns | 0.0220 ns | 0.0195 ns |  0.02 |
|                                  LowCostTakeWithoutChecks |         [1000] |    70.860 ns | 0.2463 ns | 0.2304 ns |  0.02 |
|                                     LowCostTakeWithStruct |         [1000] |    59.554 ns | 0.0383 ns | 0.0359 ns |  0.02 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    57.736 ns | 0.0191 ns | 0.0178 ns |  0.02 |
|                                            SkipTakeSingle |         [1000] |   154.051 ns | 0.0369 ns | 0.0327 ns |  0.04 |
|                                     LowCostSkipTakeSingle |         [1000] |    78.592 ns | 0.2190 ns | 0.2049 ns |  0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    80.108 ns | 0.4466 ns | 0.4178 ns |  0.02 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    54.963 ns | 0.0460 ns | 0.0430 ns |  0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    54.896 ns | 0.0330 ns | 0.0308 ns |  0.02 |
|                                           ForeachDelegate |         [1000] | 5,509.082 ns | 0.2156 ns | 0.1911 ns |  1.53 |
|                                                   Foreach |         [1000] | 3,593.457 ns | 1.5430 ns | 1.3678 ns |  1.00 |
|                                                           |                |              |           |           |       |
|                                                      **Linq** |           **[50]** |   **292.119 ns** | **0.0905 ns** | **0.0803 ns** |  **1.58** |
|                                   LowCostLinqWithDelegate |           [50] |   143.636 ns | 0.0380 ns | 0.0356 ns |  0.78 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   152.845 ns | 0.1280 ns | 0.1198 ns |  0.83 |
|                                  LowCostLinqWithDelegate2 |           [50] |   145.081 ns | 0.0395 ns | 0.0329 ns |  0.78 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   153.134 ns | 0.0382 ns | 0.0319 ns |  0.83 |
|                                LowCostLinqWithStructWhere |           [50] |    89.058 ns | 0.0836 ns | 0.0782 ns |  0.48 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    92.823 ns | 0.1265 ns | 0.1183 ns |  0.50 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   279.913 ns | 0.0764 ns | 0.0638 ns |  1.51 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   267.766 ns | 0.0533 ns | 0.0473 ns |  1.45 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   191.324 ns | 0.0446 ns | 0.0395 ns |  1.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   191.854 ns | 0.0318 ns | 0.0282 ns |  1.04 |
|                                                 LinqCount |           [50] |   107.000 ns | 0.0160 ns | 0.0133 ns |  0.58 |
|                              LowCostLinqWithDelegateCount |           [50] |   112.478 ns | 0.1660 ns | 0.1553 ns |  0.61 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   112.308 ns | 0.0387 ns | 0.0343 ns |  0.61 |
|                           LowCostLinqWithStructWhereCount |           [50] |    34.455 ns | 0.0320 ns | 0.0284 ns |  0.19 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    34.668 ns | 0.0532 ns | 0.0497 ns |  0.19 |
|                                               LinqToArray |           [50] |   242.976 ns | 0.5533 ns | 0.5175 ns |  1.31 |
|                            LowCostLinqWithDelegateToArray |           [50] |   197.209 ns | 0.2943 ns | 0.2753 ns |  1.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   202.544 ns | 0.2181 ns | 0.2040 ns |  1.10 |
|                              LowCostLinqWithStructToArray |           [50] |   131.757 ns | 0.1684 ns | 0.1493 ns |  0.71 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   132.644 ns | 0.2950 ns | 0.2759 ns |  0.72 |
|                                                      Take |           [50] |   224.776 ns | 0.2293 ns | 0.2145 ns |  1.22 |
|                                               LowCostTake |           [50] |    74.756 ns | 0.0188 ns | 0.0176 ns |  0.40 |
|                                  LowCostTakeWithoutChecks |           [50] |    71.106 ns | 0.2292 ns | 0.2144 ns |  0.38 |
|                                     LowCostTakeWithStruct |           [50] |    58.376 ns | 0.0653 ns | 0.0611 ns |  0.32 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    57.258 ns | 0.0326 ns | 0.0305 ns |  0.31 |
|                                            SkipTakeSingle |           [50] |   154.933 ns | 0.0518 ns | 0.0460 ns |  0.84 |
|                                     LowCostSkipTakeSingle |           [50] |    79.813 ns | 0.5221 ns | 0.4883 ns |  0.43 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    79.189 ns | 0.1515 ns | 0.1417 ns |  0.43 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    55.037 ns | 0.0317 ns | 0.0281 ns |  0.30 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    56.550 ns | 0.0544 ns | 0.0509 ns |  0.31 |
|                                           ForeachDelegate |           [50] |   267.241 ns | 0.0388 ns | 0.0344 ns |  1.45 |
|                                                   Foreach |           [50] |   184.830 ns | 0.0341 ns | 0.0303 ns |  1.00 |
|                                                           |                |              |           |           |       |
|                                                      **Linq** |            **[5]** |    **47.799 ns** | **0.0467 ns** | **0.0364 ns** |  **1.71** |
|                                   LowCostLinqWithDelegate |            [5] |    29.715 ns | 0.0508 ns | 0.0475 ns |  1.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    24.969 ns | 0.0223 ns | 0.0208 ns |  0.89 |
|                                  LowCostLinqWithDelegate2 |            [5] |    36.073 ns | 0.0183 ns | 0.0171 ns |  1.29 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    36.699 ns | 0.0019 ns | 0.0017 ns |  1.31 |
|                                LowCostLinqWithStructWhere |            [5] |    30.755 ns | 0.0495 ns | 0.0463 ns |  1.10 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    29.770 ns | 0.0121 ns | 0.0107 ns |  1.06 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    45.877 ns | 0.0216 ns | 0.0192 ns |  1.64 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    44.991 ns | 0.1216 ns | 0.1078 ns |  1.61 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    34.484 ns | 0.0431 ns | 0.0403 ns |  1.23 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    36.835 ns | 0.0332 ns | 0.0311 ns |  1.32 |
|                                                 LinqCount |            [5] |    28.432 ns | 0.0305 ns | 0.0270 ns |  1.02 |
|                              LowCostLinqWithDelegateCount |            [5] |    21.736 ns | 0.0290 ns | 0.0272 ns |  0.78 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    22.781 ns | 0.0180 ns | 0.0168 ns |  0.81 |
|                           LowCostLinqWithStructWhereCount |            [5] |    14.626 ns | 0.0013 ns | 0.0011 ns |  0.52 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    14.655 ns | 0.0011 ns | 0.0010 ns |  0.52 |
|                                               LinqToArray |            [5] |    59.802 ns | 0.3290 ns | 0.3077 ns |  2.14 |
|                            LowCostLinqWithDelegateToArray |            [5] |    56.157 ns | 0.0258 ns | 0.0229 ns |  2.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    56.740 ns | 0.0443 ns | 0.0370 ns |  2.03 |
|                              LowCostLinqWithStructToArray |            [5] |    47.270 ns | 0.0096 ns | 0.0085 ns |  1.69 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    46.104 ns | 0.0100 ns | 0.0089 ns |  1.65 |
|                                                      Take |            [5] |    87.507 ns | 0.0742 ns | 0.0694 ns |  3.13 |
|                                               LowCostTake |            [5] |    36.959 ns | 0.0047 ns | 0.0042 ns |  1.32 |
|                                  LowCostTakeWithoutChecks |            [5] |    31.872 ns | 0.1061 ns | 0.0992 ns |  1.14 |
|                                     LowCostTakeWithStruct |            [5] |    39.872 ns | 0.0016 ns | 0.0014 ns |  1.43 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    37.411 ns | 0.0153 ns | 0.0136 ns |  1.34 |
|                                            SkipTakeSingle |            [5] |    80.532 ns | 0.0195 ns | 0.0173 ns |  2.88 |
|                                     LowCostSkipTakeSingle |            [5] |    33.687 ns | 0.0073 ns | 0.0064 ns |  1.20 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    33.973 ns | 0.0044 ns | 0.0041 ns |  1.22 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    34.196 ns | 0.0008 ns | 0.0007 ns |  1.22 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    34.312 ns | 0.0008 ns | 0.0007 ns |  1.23 |
|                                           ForeachDelegate |            [5] |    35.762 ns | 0.0454 ns | 0.0425 ns |  1.28 |
|                                                   Foreach |            [5] |    27.958 ns | 0.0354 ns | 0.0276 ns |  1.00 |
