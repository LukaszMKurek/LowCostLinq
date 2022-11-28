``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **83.508 ns** |   **0.0208 ns** |   **0.0174 ns** | **11.13** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     30.905 ns |   0.0053 ns |   0.0050 ns |  4.12 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     30.074 ns |   0.0019 ns |   0.0017 ns |  4.01 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     57.222 ns |   0.0047 ns |   0.0044 ns |  7.63 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     56.412 ns |   0.0087 ns |   0.0082 ns |  7.52 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     42.989 ns |   0.0025 ns |   0.0022 ns |  5.73 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     42.845 ns |   0.0427 ns |   0.0333 ns |  5.71 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     38.667 ns |   0.0145 ns |   0.0121 ns |  5.16 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     37.577 ns |   0.0200 ns |   0.0177 ns |  5.01 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     36.659 ns |   0.0116 ns |   0.0103 ns |  4.89 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     36.751 ns |   0.0032 ns |   0.0025 ns |  4.90 |    0.00 |
|                                                 LinqCount |            [0] |     79.065 ns |   0.0142 ns |   0.0126 ns | 10.54 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     19.196 ns |   0.0008 ns |   0.0008 ns |  2.56 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     19.373 ns |   0.0008 ns |   0.0007 ns |  2.58 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     32.876 ns |   0.0089 ns |   0.0079 ns |  4.38 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     32.804 ns |   0.0041 ns |   0.0036 ns |  4.37 |    0.00 |
|                                               LinqToArray |            [0] |     85.184 ns |   0.0359 ns |   0.0319 ns | 11.36 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     20.404 ns |   0.0008 ns |   0.0007 ns |  2.72 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     20.580 ns |   0.0012 ns |   0.0010 ns |  2.74 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     35.418 ns |   0.0007 ns |   0.0006 ns |  4.72 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     35.199 ns |   0.0020 ns |   0.0018 ns |  4.69 |    0.00 |
|                                                      Take |            [0] |    107.660 ns |   0.0180 ns |   0.0159 ns | 14.36 |    0.01 |
|                                               LowCostTake |            [0] |     40.158 ns |   0.0209 ns |   0.0196 ns |  5.35 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     37.840 ns |   0.0080 ns |   0.0075 ns |  5.05 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     54.788 ns |   0.0450 ns |   0.0421 ns |  7.31 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     54.428 ns |   0.0038 ns |   0.0035 ns |  7.26 |    0.00 |
|                                            SkipTakeSingle |            [0] |    128.288 ns |   0.0183 ns |   0.0143 ns | 17.11 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     38.369 ns |   0.0033 ns |   0.0030 ns |  5.12 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     38.324 ns |   0.0094 ns |   0.0088 ns |  5.11 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     52.892 ns |   0.0025 ns |   0.0023 ns |  7.05 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     53.451 ns |   0.0033 ns |   0.0029 ns |  7.13 |    0.00 |
|                                           ForeachDelegate |            [0] |      8.954 ns |   0.0050 ns |   0.0047 ns |  1.19 |    0.00 |
|                                                   Foreach |            [0] |      7.500 ns |   0.0040 ns |   0.0038 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |       |         |
|                                                      **Linq** |         **[1000]** | **17,212.193 ns** | **340.8913 ns** | **748.2646 ns** |  **4.78** |    **0.12** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,245.047 ns |   2.9224 ns |   2.7336 ns |  2.02 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  7,000.605 ns |   2.6192 ns |   2.4500 ns |  1.95 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  7,245.457 ns |   1.7746 ns |   1.6599 ns |  2.02 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  7,257.290 ns |   1.5332 ns |   1.3592 ns |  2.02 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,246.232 ns |   0.5848 ns |   0.5470 ns |  0.35 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,244.732 ns |   0.5862 ns |   0.5483 ns |  0.35 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  9,590.789 ns |   1.1794 ns |   1.0455 ns |  2.67 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  9,371.985 ns |   0.9931 ns |   0.8292 ns |  2.61 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,621.227 ns |   0.4672 ns |   0.4141 ns |  1.01 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,621.711 ns |   0.3925 ns |   0.3479 ns |  1.01 |    0.00 |
|                                                 LinqCount |         [1000] | 12,508.374 ns | 253.3565 ns | 747.0273 ns |  3.46 |    0.25 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,517.169 ns |   0.3548 ns |   0.3319 ns |  1.81 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,521.516 ns |   1.4921 ns |   1.3957 ns |  1.81 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    510.860 ns |   0.4192 ns |   0.3922 ns |  0.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    510.052 ns |   0.3025 ns |   0.2830 ns |  0.14 |    0.00 |
|                                               LinqToArray |         [1000] | 12,136.335 ns | 241.6208 ns | 390.1726 ns |  3.39 |    0.09 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,995.326 ns |   4.1788 ns |   3.4895 ns |  2.22 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,973.955 ns |   2.5924 ns |   2.2981 ns |  2.22 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,612.334 ns |   0.5660 ns |   0.5017 ns |  0.45 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,605.961 ns |   0.4242 ns |   0.3543 ns |  0.45 |    0.00 |
|                                                      Take |         [1000] |    482.077 ns |   9.3000 ns |   9.5504 ns |  0.13 |    0.00 |
|                                               LowCostTake |         [1000] |    203.778 ns |   0.3433 ns |   0.3211 ns |  0.06 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    201.463 ns |   0.4646 ns |   0.4345 ns |  0.06 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     81.895 ns |   0.0073 ns |   0.0065 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     82.499 ns |   0.0238 ns |   0.0211 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    392.524 ns |   5.4546 ns |   5.1022 ns |  0.11 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    221.602 ns |   0.1281 ns |   0.1198 ns |  0.06 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    222.127 ns |   1.5633 ns |   1.4623 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    101.555 ns |   0.0180 ns |   0.0169 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    101.851 ns |   0.0466 ns |   0.0435 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,566.804 ns |   1.8613 ns |   1.6500 ns |  2.66 |    0.00 |
|                                                   Foreach |         [1000] |  3,593.711 ns |   1.4685 ns |   1.3018 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |       |         |
|                                                      **Linq** |           **[50]** |    **840.067 ns** |  **16.7048 ns** |  **27.9100 ns** |  **4.55** |    **0.12** |
|                                   LowCostLinqWithDelegate |           [50] |    378.091 ns |   0.0421 ns |   0.0394 ns |  2.05 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    389.554 ns |   0.0234 ns |   0.0195 ns |  2.11 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    417.211 ns |   0.0320 ns |   0.0299 ns |  2.26 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    413.757 ns |   0.0542 ns |   0.0507 ns |  2.24 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    106.990 ns |   0.0304 ns |   0.0270 ns |  0.58 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    107.268 ns |   0.0415 ns |   0.0388 ns |  0.58 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    511.365 ns |   0.1199 ns |   0.1063 ns |  2.77 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    510.523 ns |   0.2362 ns |   0.2094 ns |  2.76 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    210.305 ns |   0.0650 ns |   0.0576 ns |  1.14 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    208.579 ns |   0.0544 ns |   0.0454 ns |  1.13 |    0.00 |
|                                                 LinqCount |           [50] |    634.190 ns |  12.7065 ns |  28.1567 ns |  3.39 |    0.13 |
|                              LowCostLinqWithDelegateCount |           [50] |    344.504 ns |   0.1232 ns |   0.1092 ns |  1.86 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    343.854 ns |   0.1222 ns |   0.1084 ns |  1.86 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     51.485 ns |   0.0279 ns |   0.0261 ns |  0.28 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     52.335 ns |   0.0293 ns |   0.0274 ns |  0.28 |    0.00 |
|                                               LinqToArray |           [50] |    751.556 ns |  14.2531 ns |  13.3324 ns |  4.07 |    0.07 |
|                            LowCostLinqWithDelegateToArray |           [50] |    471.880 ns |   0.4420 ns |   0.4134 ns |  2.55 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    469.187 ns |   2.6854 ns |   2.5119 ns |  2.54 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    156.836 ns |   0.0998 ns |   0.0885 ns |  0.85 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    151.910 ns |   0.0571 ns |   0.0477 ns |  0.82 |    0.00 |
|                                                      Take |           [50] |    481.848 ns |   8.1930 ns |   7.6637 ns |  2.60 |    0.04 |
|                                               LowCostTake |           [50] |    202.869 ns |   0.3144 ns |   0.2941 ns |  1.10 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    200.952 ns |   0.5107 ns |   0.4527 ns |  1.09 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |     82.770 ns |   0.0375 ns |   0.0351 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     82.886 ns |   0.0256 ns |   0.0227 ns |  0.45 |    0.00 |
|                                            SkipTakeSingle |           [50] |    396.149 ns |   5.4692 ns |   5.1159 ns |  2.14 |    0.03 |
|                                     LowCostSkipTakeSingle |           [50] |    221.498 ns |   0.0338 ns |   0.0299 ns |  1.20 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    222.016 ns |   1.2825 ns |   1.0710 ns |  1.20 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    101.016 ns |   0.0458 ns |   0.0429 ns |  0.55 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    100.996 ns |   0.0577 ns |   0.0539 ns |  0.55 |    0.00 |
|                                           ForeachDelegate |           [50] |    507.011 ns |   0.1264 ns |   0.1120 ns |  2.74 |    0.00 |
|                                                   Foreach |           [50] |    184.826 ns |   0.0231 ns |   0.0204 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |       |         |
|                                                      **Linq** |            **[5]** |    **151.478 ns** |   **0.7171 ns** |   **0.6707 ns** |  **5.44** |    **0.03** |
|                                   LowCostLinqWithDelegate |            [5] |     61.724 ns |   0.0566 ns |   0.0530 ns |  2.22 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     58.931 ns |   0.0814 ns |   0.0762 ns |  2.12 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     87.732 ns |   0.0385 ns |   0.0360 ns |  3.15 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     90.249 ns |   0.0386 ns |   0.0343 ns |  3.24 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     49.529 ns |   0.0022 ns |   0.0020 ns |  1.78 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     48.907 ns |   0.0011 ns |   0.0009 ns |  1.76 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |     84.887 ns |   0.0522 ns |   0.0463 ns |  3.05 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     84.351 ns |   0.0621 ns |   0.0551 ns |  3.03 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     50.398 ns |   0.0195 ns |   0.0173 ns |  1.81 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     50.892 ns |   0.0116 ns |   0.0097 ns |  1.83 |    0.00 |
|                                                 LinqCount |            [5] |    134.577 ns |   0.4362 ns |   0.4080 ns |  4.83 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |     48.790 ns |   0.0377 ns |   0.0353 ns |  1.75 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     48.307 ns |   0.0536 ns |   0.0475 ns |  1.73 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     34.529 ns |   0.0075 ns |   0.0070 ns |  1.24 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     34.309 ns |   0.0035 ns |   0.0033 ns |  1.23 |    0.00 |
|                                               LinqToArray |            [5] |    168.459 ns |   0.2009 ns |   0.1880 ns |  6.05 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |     82.541 ns |   0.0793 ns |   0.0703 ns |  2.96 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     82.344 ns |   0.3386 ns |   0.3167 ns |  2.96 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     63.234 ns |   0.0144 ns |   0.0120 ns |  2.27 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     63.255 ns |   0.0087 ns |   0.0077 ns |  2.27 |    0.00 |
|                                                      Take |            [5] |    203.859 ns |   0.4303 ns |   0.3815 ns |  7.32 |    0.01 |
|                                               LowCostTake |            [5] |     72.351 ns |   0.1819 ns |   0.1701 ns |  2.60 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |     69.896 ns |   0.0608 ns |   0.0507 ns |  2.51 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     61.565 ns |   0.0047 ns |   0.0042 ns |  2.21 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     62.589 ns |   0.0105 ns |   0.0093 ns |  2.25 |    0.00 |
|                                            SkipTakeSingle |            [5] |    201.276 ns |   0.7445 ns |   0.6964 ns |  7.23 |    0.03 |
|                                     LowCostSkipTakeSingle |            [5] |     74.111 ns |   0.0638 ns |   0.0597 ns |  2.66 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     74.366 ns |   0.0363 ns |   0.0339 ns |  2.67 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     61.461 ns |   0.0163 ns |   0.0145 ns |  2.21 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     60.730 ns |   0.0136 ns |   0.0121 ns |  2.18 |    0.00 |
|                                           ForeachDelegate |            [5] |     60.221 ns |   0.0511 ns |   0.0478 ns |  2.16 |    0.00 |
|                                                   Foreach |            [5] |     27.853 ns |   0.0285 ns |   0.0267 ns |  1.00 |    0.00 |
