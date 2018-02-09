``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |         Error |        StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|--------------:|--------------:|-------------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **113.18 ns** |     **0.1153 ns** |     **0.1079 ns** |    **113.17 ns** |   **6.45** |     **0.01** |
|                                   LowCostLinqWithDelegate |              0 |     46.46 ns |     0.0451 ns |     0.0421 ns |     46.46 ns |   2.65 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     47.53 ns |     0.0170 ns |     0.0150 ns |     47.53 ns |   2.71 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     67.60 ns |     0.0161 ns |     0.0143 ns |     67.60 ns |   3.85 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     77.88 ns |     0.0752 ns |     0.0703 ns |     77.92 ns |   4.44 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     57.50 ns |     0.0134 ns |     0.0125 ns |     57.50 ns |   3.28 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     54.67 ns |     0.0112 ns |     0.0105 ns |     54.67 ns |   3.12 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    113.47 ns |     0.1437 ns |     0.1274 ns |    113.39 ns |   6.47 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    116.76 ns |     0.5942 ns |     0.5558 ns |    116.83 ns |   6.65 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |    101.32 ns |     0.0331 ns |     0.0309 ns |    101.32 ns |   5.77 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     92.77 ns |     0.0369 ns |     0.0327 ns |     92.77 ns |   5.29 |     0.00 |
|                                                 LinqCount |              0 |    109.38 ns |     2.1246 ns |     1.9874 ns |    108.67 ns |   6.23 |     0.11 |
|                              LowCostLinqWithDelegateCount |              0 |     50.61 ns |     0.4299 ns |     0.4021 ns |     50.39 ns |   2.88 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     49.86 ns |     0.0143 ns |     0.0085 ns |     49.85 ns |   2.84 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     48.10 ns |     0.0218 ns |     0.0182 ns |     48.10 ns |   2.74 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     47.86 ns |     0.0440 ns |     0.0412 ns |     47.85 ns |   2.73 |     0.00 |
|                                               LinqToArray |              0 |    125.03 ns |     0.0501 ns |     0.0444 ns |    125.03 ns |   7.12 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     61.18 ns |     0.0258 ns |     0.0229 ns |     61.18 ns |   3.49 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     61.94 ns |     0.0788 ns |     0.0738 ns |     61.95 ns |   3.53 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     56.81 ns |     0.0117 ns |     0.0109 ns |     56.81 ns |   3.24 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     56.84 ns |     0.0114 ns |     0.0107 ns |     56.83 ns |   3.24 |     0.00 |
|                                                      Take |              0 |    144.21 ns |     0.0298 ns |     0.0216 ns |    144.21 ns |   8.22 |     0.00 |
|                                               LowCostTake |              0 |     55.84 ns |     0.0483 ns |     0.0451 ns |     55.86 ns |   3.18 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     52.60 ns |     0.0122 ns |     0.0114 ns |     52.60 ns |   3.00 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     63.56 ns |     0.0181 ns |     0.0141 ns |     63.56 ns |   3.62 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     61.93 ns |     0.0108 ns |     0.0096 ns |     61.94 ns |   3.53 |     0.00 |
|                                            SkipTakeSingle |              0 |    171.95 ns |     0.0759 ns |     0.0634 ns |    171.96 ns |   9.80 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     66.73 ns |     0.0293 ns |     0.0274 ns |     66.74 ns |   3.80 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     66.16 ns |     0.0223 ns |     0.0208 ns |     66.17 ns |   3.77 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     69.68 ns |     0.0464 ns |     0.0434 ns |     69.68 ns |   3.97 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     69.90 ns |     0.0230 ns |     0.0179 ns |     69.89 ns |   3.98 |     0.00 |
|                                           ForeachDelegate |              0 |     21.73 ns |     0.0124 ns |     0.0110 ns |     21.73 ns |   1.24 |     0.00 |
|                                                   Foreach |              0 |     17.55 ns |     0.0093 ns |     0.0087 ns |     17.55 ns |   1.00 |     0.00 |
|                                                           |                |              |               |               |              |        |          |
|                                                      **Linq** |           **1000** | **16,329.71 ns** |    **11.8405 ns** |    **11.0756 ns** | **16,329.21 ns** |   **3.09** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 | 12,924.39 ns |    48.2738 ns |    45.1554 ns | 12,938.35 ns |   2.45 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 13,188.87 ns |    14.7876 ns |    13.8324 ns | 13,185.00 ns |   2.50 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 13,498.56 ns |    33.2643 ns |    31.1154 ns | 13,488.38 ns |   2.56 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 14,271.85 ns |   110.9144 ns |   103.7494 ns | 14,357.36 ns |   2.70 |     0.02 |
|                                LowCostLinqWithStructWhere |           1000 |  9,076.63 ns | 1,134.9691 ns | 3,346.4820 ns |  7,042.81 ns |   1.72 |     0.63 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  6,586.28 ns |     4.4396 ns |     4.1528 ns |  6,586.33 ns |   1.25 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 27,460.58 ns |    53.5024 ns |    47.4285 ns | 27,469.02 ns |   5.20 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 25,943.01 ns |   117.7051 ns |   110.1015 ns | 25,885.59 ns |   4.91 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 13,021.42 ns |     6.3869 ns |     5.9744 ns | 13,021.51 ns |   2.47 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 13,465.94 ns |    18.1501 ns |    16.9776 ns | 13,461.99 ns |   2.55 |     0.00 |
|                                                 LinqCount |           1000 | 12,470.48 ns |    23.0059 ns |    20.3941 ns | 12,463.33 ns |   2.36 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 | 12,691.80 ns |    13.9136 ns |    13.0147 ns | 12,689.93 ns |   2.40 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 12,026.72 ns |    15.2666 ns |    13.5334 ns | 12,022.13 ns |   2.28 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  5,551.66 ns |     3.7322 ns |     3.4911 ns |  5,551.24 ns |   1.05 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  5,551.16 ns |     2.8920 ns |     2.7052 ns |  5,551.45 ns |   1.05 |     0.00 |
|                                               LinqToArray |           1000 | 14,126.68 ns |    11.5203 ns |    10.7761 ns | 14,130.59 ns |   2.68 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 | 13,924.06 ns |    14.8385 ns |    13.8800 ns | 13,923.28 ns |   2.64 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 14,290.71 ns |     3.2401 ns |     2.8722 ns | 14,290.86 ns |   2.71 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  6,858.07 ns |     7.9294 ns |     7.0292 ns |  6,856.78 ns |   1.30 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  6,867.06 ns |     7.5984 ns |     7.1076 ns |  6,866.75 ns |   1.30 |     0.00 |
|                                                      Take |           1000 |    557.39 ns |     0.2605 ns |     0.2436 ns |    557.38 ns |   0.11 |     0.00 |
|                                               LowCostTake |           1000 |    329.30 ns |     0.3149 ns |     0.2945 ns |    329.17 ns |   0.06 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    334.37 ns |     0.1846 ns |     0.1727 ns |    334.27 ns |   0.06 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    217.66 ns |     0.0836 ns |     0.0782 ns |    217.65 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    190.70 ns |     0.0495 ns |     0.0413 ns |    190.69 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |           1000 |    491.08 ns |     1.3018 ns |     1.1540 ns |    490.59 ns |   0.09 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    376.67 ns |     0.0600 ns |     0.0468 ns |    376.68 ns |   0.07 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    355.36 ns |     0.2036 ns |     0.1805 ns |    355.37 ns |   0.07 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    215.02 ns |     0.0290 ns |     0.0242 ns |    215.02 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    218.87 ns |     0.1256 ns |     0.1175 ns |    218.86 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |           1000 | 10,188.26 ns |     2.2099 ns |     1.8454 ns | 10,188.06 ns |   1.93 |     0.00 |
|                                                   Foreach |           1000 |  5,279.26 ns |     6.3853 ns |     5.9728 ns |  5,278.80 ns |   1.00 |     0.00 |
|                                                           |                |              |               |               |              |        |          |
|                                                      **Linq** |              **5** |    **201.06 ns** |     **0.2256 ns** |     **0.2110 ns** |    **200.99 ns** |   **4.60** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |    119.20 ns |     0.0216 ns |     0.0180 ns |    119.20 ns |   2.73 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |    114.36 ns |     0.0321 ns |     0.0268 ns |    114.36 ns |   2.62 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    140.79 ns |     0.0355 ns |     0.0296 ns |    140.79 ns |   3.22 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    148.24 ns |     0.0478 ns |     0.0373 ns |    148.25 ns |   3.39 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     89.00 ns |     1.8033 ns |     2.9629 ns |     87.28 ns |   2.04 |     0.07 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     81.17 ns |     0.0487 ns |     0.0431 ns |     81.16 ns |   1.86 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    259.95 ns |     0.2983 ns |     0.2644 ns |    259.97 ns |   5.95 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    263.28 ns |     0.1965 ns |     0.1741 ns |    263.22 ns |   6.03 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    174.95 ns |     0.0452 ns |     0.0377 ns |    174.96 ns |   4.01 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    173.34 ns |     0.0610 ns |     0.0571 ns |    173.35 ns |   3.97 |     0.00 |
|                                                 LinqCount |              5 |    175.99 ns |     0.1621 ns |     0.1516 ns |    175.93 ns |   4.03 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |    122.02 ns |     0.1187 ns |     0.1052 ns |    122.01 ns |   2.79 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    118.40 ns |     0.1147 ns |     0.1017 ns |    118.40 ns |   2.71 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     72.40 ns |     0.0248 ns |     0.0220 ns |     72.39 ns |   1.66 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     74.15 ns |     0.0223 ns |     0.0209 ns |     74.15 ns |   1.70 |     0.00 |
|                                               LinqToArray |              5 |    256.71 ns |     0.1125 ns |     0.0814 ns |    256.69 ns |   5.88 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    161.78 ns |     0.1725 ns |     0.1614 ns |    161.87 ns |   3.70 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    167.51 ns |     0.0827 ns |     0.0733 ns |    167.52 ns |   3.84 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |    123.25 ns |     0.0629 ns |     0.0557 ns |    123.26 ns |   2.82 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    125.37 ns |     0.0209 ns |     0.0163 ns |    125.37 ns |   2.87 |     0.00 |
|                                                      Take |              5 |    266.16 ns |     0.0846 ns |     0.0750 ns |    266.14 ns |   6.09 |     0.00 |
|                                               LowCostTake |              5 |    124.37 ns |     0.1711 ns |     0.1600 ns |    124.37 ns |   2.85 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |    126.95 ns |     0.1342 ns |     0.1189 ns |    126.92 ns |   2.91 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     91.00 ns |     0.0625 ns |     0.0585 ns |     91.00 ns |   2.08 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |    103.36 ns |     0.0798 ns |     0.0747 ns |    103.32 ns |   2.37 |     0.00 |
|                                            SkipTakeSingle |              5 |    251.90 ns |     0.3581 ns |     0.3350 ns |    251.93 ns |   5.77 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |    143.95 ns |     0.1054 ns |     0.0934 ns |    143.91 ns |   3.30 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    138.35 ns |     0.0481 ns |     0.0426 ns |    138.34 ns |   3.17 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |    107.96 ns |     0.0523 ns |     0.0464 ns |    107.94 ns |   2.47 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |    101.53 ns |     0.0504 ns |     0.0447 ns |    101.51 ns |   2.32 |     0.00 |
|                                           ForeachDelegate |              5 |     71.60 ns |     0.0663 ns |     0.0518 ns |     71.58 ns |   1.64 |     0.00 |
|                                                   Foreach |              5 |     43.67 ns |     0.0154 ns |     0.0144 ns |     43.67 ns |   1.00 |     0.00 |
|                                                           |                |              |               |               |              |        |          |
|                                                      **Linq** |             **50** |    **932.07 ns** |     **1.2295 ns** |     **1.1501 ns** |    **931.49 ns** |   **3.22** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    695.95 ns |     0.2716 ns |     0.2408 ns |    695.93 ns |   2.41 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    711.56 ns |     0.1486 ns |     0.1318 ns |    711.52 ns |   2.46 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    743.49 ns |     0.6715 ns |     0.6281 ns |    743.37 ns |   2.57 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    767.27 ns |     0.2270 ns |     0.2123 ns |    767.30 ns |   2.65 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    367.26 ns |     0.2346 ns |     0.2195 ns |    367.19 ns |   1.27 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    389.82 ns |     0.2367 ns |     0.2214 ns |    389.88 ns |   1.35 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,496.98 ns |     1.5389 ns |     1.4394 ns |  1,496.90 ns |   5.18 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,422.86 ns |     0.8799 ns |     0.7347 ns |  1,422.89 ns |   4.92 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    762.82 ns |     0.3003 ns |     0.2508 ns |    762.72 ns |   2.64 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    783.79 ns |     0.1859 ns |     0.1451 ns |    783.75 ns |   2.71 |     0.00 |
|                                                 LinqCount |             50 |    720.90 ns |     0.3312 ns |     0.2766 ns |    720.84 ns |   2.49 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    688.00 ns |     0.8266 ns |     0.7732 ns |    687.71 ns |   2.38 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    653.12 ns |     0.5538 ns |     0.5180 ns |    653.26 ns |   2.26 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    331.53 ns |     0.1244 ns |     0.1102 ns |    331.55 ns |   1.15 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    332.12 ns |     0.0560 ns |     0.0496 ns |    332.10 ns |   1.15 |     0.00 |
|                                               LinqToArray |             50 |  1,044.98 ns |     2.3905 ns |     2.2361 ns |  1,044.86 ns |   3.61 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |    910.82 ns |     0.2439 ns |     0.2282 ns |    910.88 ns |   3.15 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    934.60 ns |     0.4853 ns |     0.4539 ns |    934.41 ns |   3.23 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    512.96 ns |     0.6308 ns |     0.5901 ns |    512.95 ns |   1.77 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    521.44 ns |     0.3848 ns |     0.3600 ns |    521.58 ns |   1.80 |     0.00 |
|                                                      Take |             50 |    556.98 ns |     0.1889 ns |     0.1674 ns |    556.97 ns |   1.93 |     0.00 |
|                                               LowCostTake |             50 |    330.25 ns |     0.1798 ns |     0.1594 ns |    330.22 ns |   1.14 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    334.49 ns |     0.0576 ns |     0.0510 ns |    334.50 ns |   1.16 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    229.48 ns |     0.0311 ns |     0.0185 ns |    229.47 ns |   0.79 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    190.80 ns |     0.0396 ns |     0.0371 ns |    190.80 ns |   0.66 |     0.00 |
|                                            SkipTakeSingle |             50 |    485.19 ns |     0.1012 ns |     0.0947 ns |    485.20 ns |   1.68 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    378.08 ns |     0.1197 ns |     0.1120 ns |    378.12 ns |   1.31 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    357.75 ns |     0.1449 ns |     0.1284 ns |    357.77 ns |   1.24 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    214.81 ns |     0.1399 ns |     0.1309 ns |    214.81 ns |   0.74 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    218.43 ns |     0.0931 ns |     0.0871 ns |    218.43 ns |   0.76 |     0.00 |
|                                           ForeachDelegate |             50 |    536.49 ns |     0.2681 ns |     0.2508 ns |    536.46 ns |   1.86 |     0.00 |
|                                                   Foreach |             50 |    289.07 ns |     0.0759 ns |     0.0673 ns |    289.07 ns |   1.00 |     0.00 |
