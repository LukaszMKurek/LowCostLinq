``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **119.54 ns** |   **0.0624 ns** |  **0.0521 ns** |   **6.93** |     **0.03** |
|                                   LowCostLinqWithDelegate |              0 |     45.77 ns |   0.0043 ns |  0.0036 ns |   2.65 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     42.91 ns |   0.0047 ns |  0.0039 ns |   2.49 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     80.00 ns |   0.0044 ns |  0.0041 ns |   4.64 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     77.28 ns |   0.0085 ns |  0.0067 ns |   4.48 |     0.02 |
|                                LowCostLinqWithStructWhere |              0 |     63.23 ns |   0.0119 ns |  0.0105 ns |   3.67 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     62.32 ns |   0.0029 ns |  0.0024 ns |   3.61 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    102.62 ns |   0.2119 ns |  0.1878 ns |   5.95 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     99.96 ns |   0.0739 ns |  0.0655 ns |   5.80 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     99.65 ns |   0.1172 ns |  0.1096 ns |   5.78 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     94.19 ns |   0.0650 ns |  0.0576 ns |   5.46 |     0.02 |
|                                                 LinqCount |              0 |    116.74 ns |   0.0464 ns |  0.0387 ns |   6.77 |     0.03 |
|                              LowCostLinqWithDelegateCount |              0 |     44.23 ns |   0.0102 ns |  0.0085 ns |   2.56 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     41.30 ns |   0.0297 ns |  0.0278 ns |   2.39 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     52.60 ns |   0.0062 ns |  0.0052 ns |   3.05 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     45.75 ns |   0.0081 ns |  0.0072 ns |   2.65 |     0.01 |
|                                               LinqToArray |              0 |    127.03 ns |   0.1583 ns |  0.1481 ns |   7.37 |     0.03 |
|                            LowCostLinqWithDelegateToArray |              0 |     51.36 ns |   0.0238 ns |  0.0186 ns |   2.98 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     50.13 ns |   0.0325 ns |  0.0288 ns |   2.91 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     67.61 ns |   0.0250 ns |  0.0234 ns |   3.92 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     64.67 ns |   0.0555 ns |  0.0519 ns |   3.75 |     0.01 |
|                                                      Take |              0 |    152.77 ns |   0.2452 ns |  0.2293 ns |   8.86 |     0.04 |
|                                               LowCostTake |              0 |     57.67 ns |   0.0105 ns |  0.0088 ns |   3.34 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     55.67 ns |   0.0089 ns |  0.0083 ns |   3.23 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     72.41 ns |   0.0065 ns |  0.0058 ns |   4.20 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     65.59 ns |   0.0553 ns |  0.0517 ns |   3.80 |     0.01 |
|                                            SkipTakeSingle |              0 |    178.50 ns |   0.1390 ns |  0.1161 ns |  10.35 |     0.04 |
|                                     LowCostSkipTakeSingle |              0 |     79.39 ns |   0.0388 ns |  0.0303 ns |   4.60 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     77.43 ns |   0.0259 ns |  0.0242 ns |   4.49 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     79.62 ns |   0.0180 ns |  0.0151 ns |   4.62 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     78.36 ns |   0.0035 ns |  0.0031 ns |   4.54 |     0.02 |
|                                           ForeachDelegate |              0 |     21.64 ns |   0.0180 ns |  0.0160 ns |   1.25 |     0.00 |
|                                                   Foreach |              0 |     17.25 ns |   0.0729 ns |  0.0682 ns |   1.00 |     0.00 |
|                                                           |                |              |             |            |        |          |
|                                                      **Linq** |           **1000** | **15,239.21 ns** |  **30.6616 ns** | **28.6809 ns** |   **2.89** |     **0.01** |
|                                   LowCostLinqWithDelegate |           1000 | 12,713.09 ns |   5.1826 ns |  4.8478 ns |   2.41 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 10,565.24 ns |   7.5185 ns |  7.0328 ns |   2.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 12,386.46 ns |  12.8593 ns | 11.3994 ns |   2.35 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 12,031.74 ns |   2.1498 ns |  1.7952 ns |   2.28 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,699.95 ns |   2.2130 ns |  1.9618 ns |   0.51 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,759.70 ns |   0.5131 ns |  0.4800 ns |   0.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 24,192.46 ns |  88.3685 ns | 73.7917 ns |   4.58 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 23,668.93 ns |  80.8472 ns | 75.6245 ns |   4.48 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  9,451.93 ns |  10.1804 ns |  9.5228 ns |   1.79 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,005.69 ns |   5.6133 ns |  4.9760 ns |   1.52 |     0.00 |
|                                                 LinqCount |           1000 |  9,496.47 ns |   6.3880 ns |  5.6628 ns |   1.80 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 | 10,446.44 ns |  92.6467 ns | 86.6618 ns |   1.98 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 10,845.90 ns |   3.6098 ns |  3.2000 ns |   2.06 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,789.05 ns |   1.1402 ns |  1.0666 ns |   0.34 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,234.51 ns |   0.1736 ns |  0.1539 ns |   0.23 |     0.00 |
|                                               LinqToArray |           1000 | 11,319.88 ns |  21.0910 ns | 19.7286 ns |   2.14 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 | 14,032.45 ns |  13.7029 ns | 11.4425 ns |   2.66 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 10,910.10 ns |   3.2995 ns |  2.7552 ns |   2.07 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,214.29 ns |   5.3480 ns |  4.7409 ns |   0.61 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,383.92 ns |   6.6786 ns |  6.2471 ns |   0.45 |     0.00 |
|                                                      Take |           1000 |    537.35 ns |   0.4882 ns |  0.4567 ns |   0.10 |     0.00 |
|                                               LowCostTake |           1000 |    351.97 ns |   0.0528 ns |  0.0494 ns |   0.07 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    275.30 ns |   0.0566 ns |  0.0473 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    138.04 ns |   0.0398 ns |  0.0353 ns |   0.03 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    110.82 ns |   0.1285 ns |  0.1139 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    483.60 ns |   0.3030 ns |  0.2834 ns |   0.09 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    350.76 ns |   0.2619 ns |  0.2450 ns |   0.07 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    342.45 ns |   0.0679 ns |  0.0567 ns |   0.06 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    171.84 ns |   0.0580 ns |  0.0514 ns |   0.03 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    146.83 ns |   0.0927 ns |  0.0867 ns |   0.03 |     0.00 |
|                                           ForeachDelegate |           1000 | 10,995.29 ns | 105.2476 ns | 98.4486 ns |   2.08 |     0.02 |
|                                                   Foreach |           1000 |  5,277.45 ns |   2.9345 ns |  2.7449 ns |   1.00 |     0.00 |
|                                                           |                |              |             |            |        |          |
|                                                      **Linq** |              **5** |    **206.06 ns** |   **0.2772 ns** |  **0.2593 ns** |   **4.68** |     **0.01** |
|                                   LowCostLinqWithDelegate |              5 |    111.48 ns |   0.0423 ns |  0.0396 ns |   2.53 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     87.72 ns |   0.0220 ns |  0.0195 ns |   1.99 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    139.93 ns |   0.1180 ns |  0.1104 ns |   3.18 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    134.02 ns |   0.1305 ns |  0.1220 ns |   3.05 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     70.94 ns |   0.0589 ns |  0.0551 ns |   1.61 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     60.86 ns |   0.0466 ns |  0.0413 ns |   1.38 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    248.52 ns |   1.9863 ns |  1.8580 ns |   5.65 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    227.93 ns |   0.2162 ns |  0.2022 ns |   5.18 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    149.16 ns |   0.1576 ns |  0.1474 ns |   3.39 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    135.21 ns |   0.0851 ns |  0.0796 ns |   3.07 |     0.00 |
|                                                 LinqCount |              5 |    163.78 ns |   0.5956 ns |  0.5280 ns |   3.72 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     93.76 ns |   0.0573 ns |  0.0536 ns |   2.13 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     91.41 ns |   0.0471 ns |  0.0441 ns |   2.08 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     61.14 ns |   0.0529 ns |  0.0495 ns |   1.39 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     48.74 ns |   0.3152 ns |  0.2948 ns |   1.11 |     0.01 |
|                                               LinqToArray |              5 |    224.43 ns |   0.1509 ns |  0.1260 ns |   5.10 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    151.43 ns |   0.1569 ns |  0.1468 ns |   3.44 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    132.15 ns |   0.0886 ns |  0.0829 ns |   3.00 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |    107.43 ns |   0.0165 ns |  0.0138 ns |   2.44 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     94.40 ns |   0.0747 ns |  0.0699 ns |   2.15 |     0.00 |
|                                                      Take |              5 |    261.42 ns |   0.3577 ns |  0.3346 ns |   5.94 |     0.01 |
|                                               LowCostTake |              5 |    134.26 ns |   0.1106 ns |  0.1035 ns |   3.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |    100.16 ns |   0.0574 ns |  0.0537 ns |   2.28 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     87.00 ns |   0.0161 ns |  0.0143 ns |   1.98 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     81.22 ns |   0.0517 ns |  0.0458 ns |   1.85 |     0.00 |
|                                            SkipTakeSingle |              5 |    258.55 ns |   0.1230 ns |  0.1028 ns |   5.88 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |    140.96 ns |   0.1604 ns |  0.1500 ns |   3.20 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    135.54 ns |   0.0878 ns |  0.0821 ns |   3.08 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |    103.84 ns |   0.0310 ns |  0.0242 ns |   2.36 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     88.74 ns |   0.0103 ns |  0.0097 ns |   2.02 |     0.00 |
|                                           ForeachDelegate |              5 |     77.93 ns |   2.1740 ns |  2.0335 ns |   1.77 |     0.04 |
|                                                   Foreach |              5 |     43.99 ns |   0.0282 ns |  0.0264 ns |   1.00 |     0.00 |
|                                                           |                |              |             |            |        |          |
|                                                      **Linq** |             **50** |    **883.80 ns** |   **0.8363 ns** |  **0.7823 ns** |   **3.07** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    685.14 ns |   0.0856 ns |  0.0801 ns |   2.38 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    566.44 ns |   0.0621 ns |  0.0485 ns |   1.97 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    715.97 ns |   0.0992 ns |  0.0774 ns |   2.49 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    670.94 ns |   0.1295 ns |  0.1011 ns |   2.33 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    191.29 ns |   0.0512 ns |  0.0479 ns |   0.66 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    143.72 ns |   0.0118 ns |  0.0110 ns |   0.50 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,410.73 ns |   3.1805 ns |  2.9751 ns |   4.90 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,281.46 ns |   1.4694 ns |  1.3745 ns |   4.45 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    573.46 ns |   0.0799 ns |  0.0476 ns |   1.99 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    498.14 ns |   0.0775 ns |  0.0687 ns |   1.73 |     0.00 |
|                                                 LinqCount |             50 |    590.02 ns |   1.3598 ns |  1.1355 ns |   2.05 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    574.55 ns |   0.1451 ns |  0.1358 ns |   2.00 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    583.28 ns |   0.3302 ns |  0.2927 ns |   2.03 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    158.00 ns |   0.2143 ns |  0.2004 ns |   0.55 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    102.52 ns |   0.0145 ns |  0.0135 ns |   0.36 |     0.00 |
|                                               LinqToArray |             50 |    884.05 ns |   0.6290 ns |  0.5253 ns |   3.07 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    899.83 ns |   1.0171 ns |  0.9514 ns |   3.13 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    730.85 ns |   1.0516 ns |  0.9837 ns |   2.54 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    298.41 ns |   0.0606 ns |  0.0506 ns |   1.04 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    250.54 ns |   0.2813 ns |  0.2631 ns |   0.87 |     0.00 |
|                                                      Take |             50 |    532.69 ns |   0.5044 ns |  0.4718 ns |   1.85 |     0.00 |
|                                               LowCostTake |             50 |    345.24 ns |   0.1310 ns |  0.1161 ns |   1.20 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    274.79 ns |   0.0631 ns |  0.0590 ns |   0.95 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    144.77 ns |   0.0264 ns |  0.0234 ns |   0.50 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    112.38 ns |   0.0447 ns |  0.0396 ns |   0.39 |     0.00 |
|                                            SkipTakeSingle |             50 |    474.60 ns |   0.5025 ns |  0.4700 ns |   1.65 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    349.90 ns |   0.0595 ns |  0.0497 ns |   1.22 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    342.26 ns |   0.1020 ns |  0.0954 ns |   1.19 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    171.83 ns |   0.1251 ns |  0.1171 ns |   0.60 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    141.10 ns |   0.0720 ns |  0.0638 ns |   0.49 |     0.00 |
|                                           ForeachDelegate |             50 |    582.25 ns |   0.4088 ns |  0.3624 ns |   2.02 |     0.00 |
|                                                   Foreach |             50 |    287.86 ns |   0.0884 ns |  0.0784 ns |   1.00 |     0.00 |
