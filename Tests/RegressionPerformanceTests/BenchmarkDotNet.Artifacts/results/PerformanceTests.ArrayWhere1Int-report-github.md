``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |              **0** |    **20.328 ns** |  **0.0275 ns** |  **0.0244 ns** |   **7.07** |     **0.01** |
|                      LowCostLinqWithDelegate |              0 |    18.679 ns |  0.0127 ns |  0.0119 ns |   6.49 |     0.01 |
|                     LowCostLinqWithDelegate2 |              0 |    27.270 ns |  0.0207 ns |  0.0183 ns |   9.48 |     0.02 |
|                   LowCostLinqWithStructWhere |              0 |    20.563 ns |  0.0527 ns |  0.0493 ns |   7.15 |     0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |    34.504 ns |  0.0419 ns |  0.0392 ns |  11.99 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |    36.229 ns |  0.0482 ns |  0.0402 ns |  12.59 |     0.02 |
|                                    LinqCount |              0 |    24.605 ns |  0.0832 ns |  0.0778 ns |   8.55 |     0.03 |
|                 LowCostLinqWithDelegateCount |              0 |    15.166 ns |  0.0420 ns |  0.0372 ns |   5.27 |     0.02 |
|              LowCostLinqWithStructWhereCount |              0 |    15.213 ns |  0.0242 ns |  0.0226 ns |   5.29 |     0.01 |
|                                  LinqToArray |              0 |    23.058 ns |  0.0282 ns |  0.0250 ns |   8.01 |     0.02 |
|               LowCostLinqWithDelegateToArray |              0 |    19.906 ns |  0.0605 ns |  0.0566 ns |   6.92 |     0.02 |
|                 LowCostLinqWithStructToArray |              0 |    18.450 ns |  0.0671 ns |  0.0628 ns |   6.41 |     0.02 |
|                                         Take |              0 |    24.408 ns |  0.0359 ns |  0.0319 ns |   8.48 |     0.02 |
|                                  LowCostTake |              0 |    25.807 ns |  0.0240 ns |  0.0213 ns |   8.97 |     0.02 |
|                        LowCostTakeWithStruct |              0 |    33.307 ns |  0.0098 ns |  0.0092 ns |  11.58 |     0.02 |
|                               SkipTakeSingle |              0 |    37.826 ns |  0.0461 ns |  0.0409 ns |  13.15 |     0.03 |
|                        LowCostSkipTakeSingle |              0 |    29.181 ns |  0.0996 ns |  0.0931 ns |  10.14 |     0.04 |
|              LowCostSkipTakeSingleWithStruct |              0 |    31.028 ns |  0.0041 ns |  0.0036 ns |  10.78 |     0.02 |
|                              ForeachDelegate |              0 |     5.874 ns |  0.0165 ns |  0.0154 ns |   2.04 |     0.01 |
|                                      Foreach |              0 |     2.728 ns |  0.0140 ns |  0.0124 ns |   0.95 |     0.00 |
|                                          For |              0 |     2.877 ns |  0.0054 ns |  0.0048 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |        |          |
|                                         **Linq** |           **1000** | **5,157.825 ns** | **73.8549 ns** | **69.0839 ns** |  **20.52** |     **0.27** |
|                      LowCostLinqWithDelegate |           1000 | 2,689.320 ns |  4.9380 ns |  4.1234 ns |  10.70 |     0.02 |
|                     LowCostLinqWithDelegate2 |           1000 | 2,933.969 ns |  7.9713 ns |  7.4563 ns |  11.67 |     0.03 |
|                   LowCostLinqWithStructWhere |           1000 | 1,481.786 ns |  0.9019 ns |  0.7041 ns |   5.89 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 7,496.390 ns | 10.4323 ns |  8.7114 ns |  29.82 |     0.06 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 5,541.925 ns | 14.5691 ns | 12.9151 ns |  22.05 |     0.06 |
|                                    LinqCount |           1000 | 1,490.658 ns |  1.8349 ns |  1.7164 ns |   5.93 |     0.01 |
|                 LowCostLinqWithDelegateCount |           1000 | 2,205.828 ns |  1.6457 ns |  1.3742 ns |   8.77 |     0.01 |
|              LowCostLinqWithStructWhereCount |           1000 | 1,328.615 ns |  0.3020 ns |  0.2677 ns |   5.29 |     0.01 |
|                                  LinqToArray |           1000 | 2,864.356 ns | 21.8868 ns | 20.4729 ns |  11.39 |     0.08 |
|               LowCostLinqWithDelegateToArray |           1000 | 3,959.281 ns |  7.2707 ns |  6.8010 ns |  15.75 |     0.04 |
|                 LowCostLinqWithStructToArray |           1000 | 2,269.767 ns | 15.1197 ns | 14.1430 ns |   9.03 |     0.06 |
|                                         Take |           1000 |   292.459 ns |  0.3652 ns |  0.3238 ns |   1.16 |     0.00 |
|                                  LowCostTake |           1000 |    92.406 ns |  0.5786 ns |  0.5412 ns |   0.37 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |    61.544 ns |  0.0995 ns |  0.0882 ns |   0.24 |     0.00 |
|                               SkipTakeSingle |           1000 |   187.139 ns |  0.3540 ns |  0.3311 ns |   0.74 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    89.985 ns |  0.1190 ns |  0.0994 ns |   0.36 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |    55.423 ns |  0.0721 ns |  0.0639 ns |   0.22 |     0.00 |
|                              ForeachDelegate |           1000 | 1,687.191 ns |  1.9071 ns |  1.5925 ns |   6.71 |     0.01 |
|                                      Foreach |           1000 |   488.193 ns |  0.6908 ns |  0.5768 ns |   1.94 |     0.00 |
|                                          For |           1000 |   251.387 ns |  0.4514 ns |  0.4002 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |        |          |
|                                         **Linq** |              **5** |    **62.218 ns** |  **0.7309 ns** |  **0.6479 ns** |  **14.61** |     **0.15** |
|                      LowCostLinqWithDelegate |              5 |    33.589 ns |  0.0692 ns |  0.0614 ns |   7.89 |     0.02 |
|                     LowCostLinqWithDelegate2 |              5 |    42.853 ns |  0.1226 ns |  0.1147 ns |  10.07 |     0.03 |
|                   LowCostLinqWithStructWhere |              5 |    27.872 ns |  0.0546 ns |  0.0484 ns |   6.55 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    74.114 ns |  0.2279 ns |  0.2132 ns |  17.41 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |    65.025 ns |  0.3239 ns |  0.3030 ns |  15.27 |     0.07 |
|                                    LinqCount |              5 |    41.390 ns |  0.1826 ns |  0.1708 ns |   9.72 |     0.04 |
|                 LowCostLinqWithDelegateCount |              5 |    27.335 ns |  0.1031 ns |  0.0861 ns |   6.42 |     0.02 |
|              LowCostLinqWithStructWhereCount |              5 |    18.293 ns |  0.0271 ns |  0.0253 ns |   4.30 |     0.01 |
|                                  LinqToArray |              5 |    96.475 ns |  0.4087 ns |  0.3623 ns |  22.66 |     0.08 |
|               LowCostLinqWithDelegateToArray |              5 |    69.691 ns |  0.4290 ns |  0.4013 ns |  16.37 |     0.09 |
|                 LowCostLinqWithStructToArray |              5 |    58.229 ns |  0.2736 ns |  0.2425 ns |  13.68 |     0.06 |
|                                         Take |              5 |   127.173 ns |  0.8404 ns |  0.7861 ns |  29.87 |     0.18 |
|                                  LowCostTake |              5 |    41.585 ns |  0.1187 ns |  0.1110 ns |   9.77 |     0.03 |
|                        LowCostTakeWithStruct |              5 |    50.482 ns |  0.0584 ns |  0.0546 ns |  11.86 |     0.02 |
|                               SkipTakeSingle |              5 |   112.337 ns |  0.4323 ns |  0.3610 ns |  26.38 |     0.08 |
|                        LowCostSkipTakeSingle |              5 |    39.451 ns |  0.1267 ns |  0.1185 ns |   9.27 |     0.03 |
|              LowCostSkipTakeSingleWithStruct |              5 |    36.382 ns |  0.0757 ns |  0.0709 ns |   8.55 |     0.02 |
|                              ForeachDelegate |              5 |    14.010 ns |  0.0993 ns |  0.0929 ns |   3.29 |     0.02 |
|                                      Foreach |              5 |     5.502 ns |  0.0181 ns |  0.0161 ns |   1.29 |     0.00 |
|                                          For |              5 |     4.258 ns |  0.0045 ns |  0.0037 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |        |          |
|                                         **Linq** |             **50** |   **308.299 ns** |  **1.1797 ns** |  **1.1035 ns** |  **18.85** |     **0.15** |
|                      LowCostLinqWithDelegate |             50 |   154.925 ns |  0.7800 ns |  0.6915 ns |   9.47 |     0.08 |
|                     LowCostLinqWithDelegate2 |             50 |   179.197 ns |  0.8647 ns |  0.7665 ns |  10.96 |     0.09 |
|                   LowCostLinqWithStructWhere |             50 |    91.260 ns |  0.2691 ns |  0.2517 ns |   5.58 |     0.04 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |   420.429 ns |  3.5624 ns |  3.1580 ns |  25.71 |     0.26 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |   328.490 ns |  4.5452 ns |  4.0292 ns |  20.09 |     0.28 |
|                                    LinqCount |             50 |   117.365 ns |  0.3859 ns |  0.3421 ns |   7.18 |     0.06 |
|                 LowCostLinqWithDelegateCount |             50 |   129.503 ns |  0.5164 ns |  0.4312 ns |   7.92 |     0.06 |
|              LowCostLinqWithStructWhereCount |             50 |    67.165 ns |  0.0237 ns |  0.0185 ns |   4.11 |     0.03 |
|                                  LinqToArray |             50 |   360.752 ns |  1.1746 ns |  1.0988 ns |  22.06 |     0.17 |
|               LowCostLinqWithDelegateToArray |             50 |   300.905 ns |  2.3831 ns |  2.1125 ns |  18.40 |     0.18 |
|                 LowCostLinqWithStructToArray |             50 |   207.061 ns |  2.3219 ns |  2.0583 ns |  12.66 |     0.15 |
|                                         Take |             50 |   291.570 ns |  1.2940 ns |  1.0806 ns |  17.83 |     0.14 |
|                                  LowCostTake |             50 |    92.227 ns |  0.0667 ns |  0.0591 ns |   5.64 |     0.04 |
|                        LowCostTakeWithStruct |             50 |    61.141 ns |  0.0697 ns |  0.0582 ns |   3.74 |     0.03 |
|                               SkipTakeSingle |             50 |   186.924 ns |  2.0708 ns |  1.8358 ns |  11.43 |     0.14 |
|                        LowCostSkipTakeSingle |             50 |    90.188 ns |  0.1680 ns |  0.1489 ns |   5.52 |     0.04 |
|              LowCostSkipTakeSingleWithStruct |             50 |    54.934 ns |  0.1243 ns |  0.1102 ns |   3.36 |     0.03 |
|                              ForeachDelegate |             50 |    94.644 ns |  0.0883 ns |  0.0737 ns |   5.79 |     0.04 |
|                                      Foreach |             50 |    27.445 ns |  0.1064 ns |  0.0995 ns |   1.68 |     0.01 |
|                                          For |             50 |    16.354 ns |  0.1479 ns |  0.1235 ns |   1.00 |     0.00 |
