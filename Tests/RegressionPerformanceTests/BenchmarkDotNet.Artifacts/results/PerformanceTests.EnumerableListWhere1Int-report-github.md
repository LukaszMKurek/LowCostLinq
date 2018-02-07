``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **37.16 ns** |  **0.0234 ns** |  **0.0219 ns** |   **2.20** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     36.66 ns |  0.0040 ns |  0.0035 ns |   2.17 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     28.45 ns |  0.0249 ns |  0.0233 ns |   1.68 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     43.38 ns |  0.0168 ns |  0.0157 ns |   2.57 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     37.35 ns |  0.0069 ns |  0.0064 ns |   2.21 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     37.07 ns |  0.0075 ns |  0.0067 ns |   2.19 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     35.89 ns |  0.0314 ns |  0.0293 ns |   2.12 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     74.39 ns |  0.0257 ns |  0.0240 ns |   4.40 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     69.34 ns |  0.0606 ns |  0.0567 ns |   4.10 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     75.11 ns |  0.1572 ns |  0.1470 ns |   4.44 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     68.55 ns |  0.0246 ns |  0.0218 ns |   4.05 |     0.01 |
|                                                 LinqCount |              0 |     34.77 ns |  0.0121 ns |  0.0107 ns |   2.06 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     31.38 ns |  0.0155 ns |  0.0137 ns |   1.86 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     29.68 ns |  0.0062 ns |  0.0058 ns |   1.76 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     29.57 ns |  0.0068 ns |  0.0064 ns |   1.75 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     21.54 ns |  0.0024 ns |  0.0021 ns |   1.27 |     0.00 |
|                                               LinqToArray |              0 |     45.88 ns |  0.0096 ns |  0.0080 ns |   2.71 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     42.59 ns |  0.0414 ns |  0.0387 ns |   2.52 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     41.06 ns |  0.0088 ns |  0.0078 ns |   2.43 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     39.13 ns |  0.0351 ns |  0.0329 ns |   2.31 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     31.21 ns |  0.0336 ns |  0.0315 ns |   1.85 |     0.00 |
|                                                      Take |              0 |     72.21 ns |  0.0317 ns |  0.0264 ns |   4.27 |     0.01 |
|                                               LowCostTake |              0 |     41.60 ns |  0.0033 ns |  0.0031 ns |   2.46 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     37.84 ns |  0.0092 ns |  0.0086 ns |   2.24 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     52.33 ns |  0.0044 ns |  0.0036 ns |   3.09 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     39.58 ns |  0.0057 ns |  0.0044 ns |   2.34 |     0.00 |
|                                            SkipTakeSingle |              0 |     95.14 ns |  0.0224 ns |  0.0187 ns |   5.63 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     46.84 ns |  0.0019 ns |  0.0017 ns |   2.77 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     46.10 ns |  0.0493 ns |  0.0461 ns |   2.73 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     49.82 ns |  0.0018 ns |  0.0015 ns |   2.95 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     42.23 ns |  0.0106 ns |  0.0099 ns |   2.50 |     0.00 |
|                                           ForeachDelegate |              0 |     19.33 ns |  0.0145 ns |  0.0113 ns |   1.14 |     0.00 |
|                                                   Foreach |              0 |     16.91 ns |  0.0337 ns |  0.0316 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** |  **7,374.93 ns** |  **6.5005 ns** |  **5.7625 ns** |   **1.34** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  5,126.86 ns | 99.4596 ns | 93.0346 ns |   0.93 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  3,144.63 ns |  4.4539 ns |  4.1662 ns |   0.57 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  4,583.15 ns |  2.5016 ns |  2.3400 ns |   0.83 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  3,410.89 ns |  4.1757 ns |  3.9060 ns |   0.62 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,908.43 ns |  1.9205 ns |  1.7965 ns |   0.53 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,751.81 ns |  0.8502 ns |  0.7100 ns |   0.32 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 11,339.72 ns | 13.5164 ns | 12.6432 ns |   2.06 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 |  9,690.03 ns | 10.8103 ns | 10.1119 ns |   1.76 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,472.61 ns |  6.7191 ns |  6.2851 ns |   1.54 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,489.45 ns |  6.1019 ns |  5.7077 ns |   1.36 |     0.00 |
|                                                 LinqCount |           1000 |  1,481.44 ns |  2.2768 ns |  2.1297 ns |   0.27 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  3,618.45 ns |  2.4445 ns |  2.1670 ns |   0.66 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  2,421.93 ns |  0.1071 ns |  0.0949 ns |   0.44 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,729.10 ns |  0.8544 ns |  0.7992 ns |   0.31 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,212.03 ns |  0.0536 ns |  0.0418 ns |   0.22 |     0.00 |
|                                               LinqToArray |           1000 |  3,456.59 ns |  6.4925 ns |  6.0730 ns |   0.63 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  5,818.09 ns |  7.7803 ns |  7.2777 ns |   1.05 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  3,953.48 ns |  4.2626 ns |  3.7787 ns |   0.72 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,201.03 ns |  5.4646 ns |  4.8442 ns |   0.58 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,296.03 ns |  3.9392 ns |  3.6847 ns |   0.42 |     0.00 |
|                                                      Take |           1000 |    307.54 ns |  0.0812 ns |  0.0759 ns |   0.06 |     0.00 |
|                                               LowCostTake |           1000 |    148.28 ns |  0.0170 ns |  0.0133 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    113.23 ns |  0.0188 ns |  0.0167 ns |   0.02 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    115.92 ns |  0.0445 ns |  0.0416 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     84.76 ns |  0.0381 ns |  0.0356 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    233.34 ns |  0.1616 ns |  0.1433 ns |   0.04 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    147.08 ns |  0.0248 ns |  0.0232 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    110.03 ns |  0.1338 ns |  0.1252 ns |   0.02 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     96.72 ns |  0.0412 ns |  0.0365 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     61.41 ns |  0.0834 ns |  0.0781 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |           1000 |  6,713.40 ns |  2.8807 ns |  2.5537 ns |   1.22 |     0.00 |
|                                                   Foreach |           1000 |  5,517.02 ns |  2.3958 ns |  2.1238 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |     **74.75 ns** |  **0.0184 ns** |  **0.0172 ns** |   **1.70** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     55.56 ns |  0.3549 ns |  0.3320 ns |   1.26 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     45.60 ns |  0.0155 ns |  0.0145 ns |   1.04 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     63.41 ns |  0.0182 ns |  0.0170 ns |   1.44 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     56.98 ns |  0.0150 ns |  0.0140 ns |   1.29 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     51.85 ns |  0.0138 ns |  0.0129 ns |   1.18 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     42.64 ns |  0.0144 ns |  0.0128 ns |   0.97 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    132.21 ns |  0.1152 ns |  0.1077 ns |   3.00 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    118.96 ns |  0.0431 ns |  0.0403 ns |   2.70 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    119.49 ns |  0.2070 ns |  0.1936 ns |   2.71 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    108.35 ns |  0.0486 ns |  0.0454 ns |   2.46 |     0.00 |
|                                                 LinqCount |              5 |     42.15 ns |  0.0682 ns |  0.0638 ns |   0.96 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     51.31 ns |  0.1876 ns |  0.1755 ns |   1.17 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     43.35 ns |  0.0217 ns |  0.0203 ns |   0.98 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     37.99 ns |  0.0132 ns |  0.0123 ns |   0.86 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     25.58 ns |  0.0427 ns |  0.0378 ns |   0.58 |     0.00 |
|                                               LinqToArray |              5 |     95.67 ns |  0.0432 ns |  0.0404 ns |   2.17 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    101.01 ns |  0.0441 ns |  0.0413 ns |   2.29 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     92.53 ns |  0.0866 ns |  0.0723 ns |   2.10 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     84.58 ns |  0.1101 ns |  0.1030 ns |   1.92 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     69.95 ns |  0.0641 ns |  0.0599 ns |   1.59 |     0.00 |
|                                                      Take |              5 |    131.28 ns |  0.1178 ns |  0.1102 ns |   2.98 |     0.00 |
|                                               LowCostTake |              5 |     65.13 ns |  0.0324 ns |  0.0303 ns |   1.48 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     57.17 ns |  0.0569 ns |  0.0532 ns |   1.30 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     59.75 ns |  0.1742 ns |  0.1630 ns |   1.36 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     52.43 ns |  0.0284 ns |  0.0237 ns |   1.19 |     0.00 |
|                                            SkipTakeSingle |              5 |    125.80 ns |  0.1531 ns |  0.1357 ns |   2.86 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     65.08 ns |  0.0300 ns |  0.0266 ns |   1.48 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     58.49 ns |  0.0287 ns |  0.0254 ns |   1.33 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     59.18 ns |  0.0265 ns |  0.0248 ns |   1.34 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     46.27 ns |  0.0148 ns |  0.0138 ns |   1.05 |     0.00 |
|                                           ForeachDelegate |              5 |     52.75 ns |  0.0538 ns |  0.0503 ns |   1.20 |     0.00 |
|                                                   Foreach |              5 |     44.02 ns |  0.0062 ns |  0.0058 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **413.86 ns** |  **0.4375 ns** |  **0.4092 ns** |   **1.37** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    304.23 ns |  0.2869 ns |  0.2543 ns |   1.01 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    191.16 ns |  0.0607 ns |  0.0507 ns |   0.63 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    272.90 ns |  0.0282 ns |  0.0264 ns |   0.91 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    214.05 ns |  0.0975 ns |  0.0912 ns |   0.71 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    185.41 ns |  0.0167 ns |  0.0157 ns |   0.62 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    127.69 ns |  0.1309 ns |  0.1224 ns |   0.42 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    645.19 ns |  0.2157 ns |  0.1912 ns |   2.14 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    561.86 ns |  0.2143 ns |  0.1673 ns |   1.86 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    503.22 ns |  0.1427 ns |  0.1265 ns |   1.67 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    453.21 ns |  0.1078 ns |  0.0956 ns |   1.50 |     0.00 |
|                                                 LinqCount |             50 |    113.81 ns |  0.2168 ns |  0.2028 ns |   0.38 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    219.87 ns |  0.0459 ns |  0.0429 ns |   0.73 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    156.96 ns |  0.0774 ns |  0.0724 ns |   0.52 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    123.06 ns |  0.0379 ns |  0.0336 ns |   0.41 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     74.81 ns |  0.0580 ns |  0.0542 ns |   0.25 |     0.00 |
|                                               LinqToArray |             50 |    370.01 ns |  0.1630 ns |  0.1525 ns |   1.23 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    436.64 ns |  0.4906 ns |  0.4589 ns |   1.45 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    327.37 ns |  0.3329 ns |  0.3114 ns |   1.09 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    283.56 ns |  0.6806 ns |  0.6367 ns |   0.94 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    225.86 ns |  0.1726 ns |  0.1615 ns |   0.75 |     0.00 |
|                                                      Take |             50 |    308.49 ns |  0.2371 ns |  0.2102 ns |   1.02 |     0.00 |
|                                               LowCostTake |             50 |    156.22 ns |  0.0077 ns |  0.0072 ns |   0.52 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    113.48 ns |  0.0347 ns |  0.0290 ns |   0.38 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    111.73 ns |  0.0070 ns |  0.0062 ns |   0.37 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     84.52 ns |  0.0210 ns |  0.0197 ns |   0.28 |     0.00 |
|                                            SkipTakeSingle |             50 |    233.00 ns |  0.0439 ns |  0.0411 ns |   0.77 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    136.49 ns |  0.1585 ns |  0.1483 ns |   0.45 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    108.94 ns |  0.0532 ns |  0.0472 ns |   0.36 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     92.09 ns |  0.0692 ns |  0.0648 ns |   0.31 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     64.69 ns |  0.0582 ns |  0.0545 ns |   0.21 |     0.00 |
|                                           ForeachDelegate |             50 |    361.55 ns |  0.4701 ns |  0.4397 ns |   1.20 |     0.00 |
|                                                   Foreach |             50 |    301.45 ns |  0.0356 ns |  0.0333 ns |   1.00 |     0.00 |
