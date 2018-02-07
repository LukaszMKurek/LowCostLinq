``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **77.96 ns** |   **0.0819 ns** |   **0.0766 ns** |   **4.35** |     **0.01** |
|                                   LowCostLinqWithDelegate |              0 |     46.97 ns |   0.0157 ns |   0.0147 ns |   2.62 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     41.58 ns |   0.0380 ns |   0.0355 ns |   2.32 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     56.82 ns |   0.0057 ns |   0.0048 ns |   3.17 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     56.63 ns |   0.0280 ns |   0.0248 ns |   3.16 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     50.89 ns |   0.0339 ns |   0.0317 ns |   2.84 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     49.45 ns |   0.0628 ns |   0.0587 ns |   2.76 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    104.08 ns |   0.0397 ns |   0.0352 ns |   5.81 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    100.64 ns |   0.2126 ns |   0.1989 ns |   5.62 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     93.09 ns |   0.0356 ns |   0.0315 ns |   5.20 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     85.99 ns |   0.0430 ns |   0.0381 ns |   4.80 |     0.01 |
|                                                 LinqCount |              0 |     77.10 ns |   0.0893 ns |   0.0835 ns |   4.31 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     47.31 ns |   0.0489 ns |   0.0458 ns |   2.64 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     48.99 ns |   0.0108 ns |   0.0095 ns |   2.74 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     40.50 ns |   0.0136 ns |   0.0120 ns |   2.26 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     40.75 ns |   0.0667 ns |   0.0624 ns |   2.28 |     0.01 |
|                                               LinqToArray |              0 |     90.53 ns |   0.0421 ns |   0.0394 ns |   5.06 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |     59.51 ns |   0.0278 ns |   0.0232 ns |   3.32 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     60.14 ns |   0.0436 ns |   0.0408 ns |   3.36 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     50.66 ns |   0.0498 ns |   0.0442 ns |   2.83 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     49.48 ns |   0.0145 ns |   0.0129 ns |   2.76 |     0.01 |
|                                                      Take |              0 |    114.10 ns |   0.1789 ns |   0.1673 ns |   6.37 |     0.02 |
|                                               LowCostTake |              0 |     50.79 ns |   0.0178 ns |   0.0166 ns |   2.84 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     51.61 ns |   0.0215 ns |   0.0201 ns |   2.88 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     56.16 ns |   0.0552 ns |   0.0431 ns |   3.14 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     55.48 ns |   0.0116 ns |   0.0103 ns |   3.10 |     0.01 |
|                                            SkipTakeSingle |              0 |    138.75 ns |   0.1001 ns |   0.0937 ns |   7.75 |     0.02 |
|                                     LowCostSkipTakeSingle |              0 |     61.66 ns |   0.0381 ns |   0.0338 ns |   3.44 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     60.38 ns |   0.0837 ns |   0.0783 ns |   3.37 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     62.75 ns |   0.0132 ns |   0.0123 ns |   3.50 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     62.36 ns |   0.0351 ns |   0.0328 ns |   3.48 |     0.01 |
|                                           ForeachDelegate |              0 |     20.24 ns |   0.0075 ns |   0.0067 ns |   1.13 |     0.00 |
|                                                   Foreach |              0 |     17.90 ns |   0.0428 ns |   0.0400 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |           **1000** | **13,423.08 ns** |   **7.1853 ns** |   **6.7211 ns** |   **2.43** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 | 11,029.49 ns | 130.5099 ns | 122.0791 ns |   2.00 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 10,420.78 ns |  43.7984 ns |  36.5736 ns |   1.89 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           1000 | 11,286.43 ns |   4.2351 ns |   3.7543 ns |   2.05 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 11,573.66 ns |  32.2512 ns |  30.1678 ns |   2.10 |     0.01 |
|                                LowCostLinqWithStructWhere |           1000 |  6,533.92 ns |  22.3917 ns |  20.9452 ns |   1.18 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  6,491.51 ns |   8.4948 ns |   7.9461 ns |   1.18 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 23,783.07 ns |  17.7694 ns |  15.7521 ns |   4.31 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 24,430.24 ns | 144.7070 ns | 135.3590 ns |   4.43 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 13,020.79 ns |   5.7287 ns |   5.0783 ns |   2.36 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 13,030.16 ns |  13.8215 ns |  12.9287 ns |   2.36 |     0.00 |
|                                                 LinqCount |           1000 |  9,496.57 ns |  12.9789 ns |  11.5055 ns |   1.72 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 | 10,555.37 ns |  60.5040 ns |  56.5955 ns |   1.91 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 11,513.20 ns |   1.8452 ns |   1.7260 ns |   2.09 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  5,558.17 ns |   6.9407 ns |   6.4923 ns |   1.01 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  5,784.50 ns |   3.5089 ns |   3.2822 ns |   1.05 |     0.00 |
|                                               LinqToArray |           1000 | 11,352.15 ns |  33.9025 ns |  31.7125 ns |   2.06 |     0.01 |
|                            LowCostLinqWithDelegateToArray |           1000 | 11,726.80 ns |  14.5495 ns |  13.6096 ns |   2.13 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 11,310.99 ns |   9.3667 ns |   8.3033 ns |   2.05 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  7,068.07 ns |   8.9208 ns |   7.4493 ns |   1.28 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  7,635.70 ns |  11.3246 ns |  10.5931 ns |   1.38 |     0.00 |
|                                                      Take |           1000 |    465.41 ns |   0.6191 ns |   0.5791 ns |   0.08 |     0.00 |
|                                               LowCostTake |           1000 |    279.87 ns |   0.0993 ns |   0.0929 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    266.11 ns |   0.7452 ns |   0.6971 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    201.40 ns |   0.0771 ns |   0.0684 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    192.42 ns |   0.1047 ns |   0.0980 ns |   0.03 |     0.00 |
|                                            SkipTakeSingle |           1000 |    396.13 ns |   0.0773 ns |   0.0685 ns |   0.07 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    299.94 ns |   0.8833 ns |   0.8263 ns |   0.05 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    299.67 ns |   0.0868 ns |   0.0725 ns |   0.05 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    200.93 ns |   0.0762 ns |   0.0636 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    197.94 ns |   0.0806 ns |   0.0754 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |           1000 |  8,435.09 ns | 143.1287 ns | 133.8827 ns |   1.53 |     0.02 |
|                                                   Foreach |           1000 |  5,517.81 ns |   2.1363 ns |   1.9983 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |              **5** |    **146.14 ns** |   **0.0482 ns** |   **0.0427 ns** |   **3.25** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |    105.45 ns |   0.2092 ns |   0.1956 ns |   2.34 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     96.65 ns |   0.0192 ns |   0.0170 ns |   2.15 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    112.54 ns |   0.0931 ns |   0.0871 ns |   2.50 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    113.90 ns |   0.0830 ns |   0.0736 ns |   2.53 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     77.00 ns |   0.1092 ns |   0.0968 ns |   1.71 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     75.69 ns |   0.0615 ns |   0.0575 ns |   1.68 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    236.09 ns |   0.2451 ns |   0.2292 ns |   5.25 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    284.46 ns |   5.6382 ns |   6.9243 ns |   6.32 |     0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    169.90 ns |   0.2193 ns |   0.1944 ns |   3.78 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    163.48 ns |   0.1308 ns |   0.1223 ns |   3.63 |     0.00 |
|                                                 LinqCount |              5 |    124.78 ns |   0.1671 ns |   0.1563 ns |   2.77 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |    100.64 ns |   0.0690 ns |   0.0645 ns |   2.24 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    106.55 ns |   0.0490 ns |   0.0459 ns |   2.37 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     67.87 ns |   0.0209 ns |   0.0174 ns |   1.51 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     66.97 ns |   0.0769 ns |   0.0719 ns |   1.49 |     0.00 |
|                                               LinqToArray |              5 |    209.65 ns |   2.9020 ns |   2.7145 ns |   4.66 |     0.06 |
|                            LowCostLinqWithDelegateToArray |              5 |    151.12 ns |   0.0996 ns |   0.0932 ns |   3.36 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    149.27 ns |   0.1082 ns |   0.0959 ns |   3.32 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |    117.83 ns |   0.0996 ns |   0.0832 ns |   2.62 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    121.02 ns |   0.0549 ns |   0.0487 ns |   2.69 |     0.00 |
|                                                      Take |              5 |    216.86 ns |   0.1662 ns |   0.1554 ns |   4.82 |     0.00 |
|                                               LowCostTake |              5 |    111.22 ns |   0.0141 ns |   0.0132 ns |   2.47 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |    102.90 ns |   0.0928 ns |   0.0868 ns |   2.29 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     83.95 ns |   0.0276 ns |   0.0245 ns |   1.87 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     86.05 ns |   0.0358 ns |   0.0335 ns |   1.91 |     0.00 |
|                                            SkipTakeSingle |              5 |    211.70 ns |   0.0171 ns |   0.0160 ns |   4.71 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |    113.53 ns |   0.0574 ns |   0.0415 ns |   2.52 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    114.59 ns |   0.0405 ns |   0.0379 ns |   2.55 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     90.81 ns |   0.0441 ns |   0.0344 ns |   2.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     92.34 ns |   0.1145 ns |   0.1015 ns |   2.05 |     0.00 |
|                                           ForeachDelegate |              5 |     63.01 ns |   0.0487 ns |   0.0455 ns |   1.40 |     0.00 |
|                                                   Foreach |              5 |     44.98 ns |   0.0101 ns |   0.0094 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |             **50** |    **764.41 ns** |   **0.6710 ns** |   **0.6276 ns** |   **2.53** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    592.26 ns |   0.1470 ns |   0.1227 ns |   1.96 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    567.76 ns |   0.8501 ns |   0.7952 ns |   1.88 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    613.74 ns |   0.1852 ns |   0.1641 ns |   2.03 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    637.04 ns |   0.3294 ns |   0.3081 ns |   2.11 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    376.00 ns |   0.4714 ns |   0.4410 ns |   1.24 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    372.54 ns |   0.0447 ns |   0.0418 ns |   1.23 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,306.02 ns |   0.8038 ns |   0.7519 ns |   4.32 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,341.16 ns |   0.7524 ns |   0.7038 ns |   4.43 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    754.67 ns |   0.7894 ns |   0.7384 ns |   2.49 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    750.50 ns |   0.0619 ns |   0.0484 ns |   2.48 |     0.00 |
|                                                 LinqCount |             50 |    556.85 ns |   0.2511 ns |   0.2349 ns |   1.84 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    586.17 ns |   0.3717 ns |   0.3477 ns |   1.94 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    628.71 ns |   0.6805 ns |   0.6365 ns |   2.08 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    325.60 ns |   0.0473 ns |   0.0420 ns |   1.08 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    332.10 ns |   0.1713 ns |   0.1602 ns |   1.10 |     0.00 |
|                                               LinqToArray |             50 |    851.46 ns |   3.0411 ns |   2.8446 ns |   2.81 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |    795.49 ns |   1.1338 ns |   1.0606 ns |   2.63 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    775.43 ns |   0.2941 ns |   0.2456 ns |   2.56 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    518.76 ns |   0.3340 ns |   0.2789 ns |   1.71 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    552.47 ns |   0.4474 ns |   0.3966 ns |   1.83 |     0.00 |
|                                                      Take |             50 |    465.20 ns |   0.0856 ns |   0.0759 ns |   1.54 |     0.00 |
|                                               LowCostTake |             50 |    279.08 ns |   0.0622 ns |   0.0581 ns |   0.92 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    264.35 ns |   0.0676 ns |   0.0599 ns |   0.87 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    201.37 ns |   0.0473 ns |   0.0395 ns |   0.67 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    193.39 ns |   0.0502 ns |   0.0445 ns |   0.64 |     0.00 |
|                                            SkipTakeSingle |             50 |    396.27 ns |   0.3100 ns |   0.2900 ns |   1.31 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    299.86 ns |   0.0390 ns |   0.0365 ns |   0.99 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    298.76 ns |   0.0325 ns |   0.0304 ns |   0.99 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    197.55 ns |   0.0397 ns |   0.0372 ns |   0.65 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    198.23 ns |   0.0312 ns |   0.0292 ns |   0.66 |     0.00 |
|                                           ForeachDelegate |             50 |    448.31 ns |   0.6655 ns |   0.5900 ns |   1.48 |     0.00 |
|                                                   Foreach |             50 |    302.62 ns |   0.0356 ns |   0.0333 ns |   1.00 |     0.00 |
