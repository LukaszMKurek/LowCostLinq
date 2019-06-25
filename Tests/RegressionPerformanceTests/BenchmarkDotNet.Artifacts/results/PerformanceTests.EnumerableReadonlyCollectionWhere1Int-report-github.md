``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **50.17 ns** |  **0.1779 ns** |  **0.1664 ns** |  **2.69** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     45.32 ns |  0.0253 ns |  0.0224 ns |  2.43 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     37.95 ns |  0.0433 ns |  0.0384 ns |  2.04 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     48.32 ns |  0.0346 ns |  0.0307 ns |  2.59 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     44.02 ns |  0.0310 ns |  0.0290 ns |  2.36 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     46.30 ns |  0.0605 ns |  0.0566 ns |  2.48 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     40.76 ns |  0.0160 ns |  0.0142 ns |  2.19 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     98.72 ns |  0.0408 ns |  0.0340 ns |  5.29 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     86.63 ns |  0.0318 ns |  0.0297 ns |  4.65 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    101.64 ns |  0.0274 ns |  0.0243 ns |  5.45 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     85.29 ns |  0.1524 ns |  0.1425 ns |  4.57 |    0.01 |
|                                                 LinqCount |            [0] |     51.35 ns |  1.5831 ns |  2.2193 ns |  2.78 |    0.13 |
|                              LowCostLinqWithDelegateCount |            [0] |     47.02 ns |  0.0538 ns |  0.0503 ns |  2.52 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     46.13 ns |  0.1147 ns |  0.1017 ns |  2.47 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.32 ns |  0.0644 ns |  0.0602 ns |  2.00 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.80 ns |  0.0294 ns |  0.0260 ns |  1.97 |    0.00 |
|                                               LinqToArray |            [0] |     63.12 ns |  0.0425 ns |  0.0332 ns |  3.38 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     59.53 ns |  0.0665 ns |  0.0555 ns |  3.19 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     57.93 ns |  0.0540 ns |  0.0479 ns |  3.11 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     49.45 ns |  0.1492 ns |  0.1396 ns |  2.65 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     50.80 ns |  0.0241 ns |  0.0213 ns |  2.72 |    0.00 |
|                                                      Take |            [0] |     85.96 ns |  0.1210 ns |  0.1132 ns |  4.61 |    0.01 |
|                                               LowCostTake |            [0] |     50.93 ns |  0.0512 ns |  0.0479 ns |  2.73 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     46.66 ns |  0.0237 ns |  0.0185 ns |  2.50 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     54.93 ns |  0.0318 ns |  0.0297 ns |  2.95 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     49.90 ns |  0.0581 ns |  0.0543 ns |  2.68 |    0.00 |
|                                            SkipTakeSingle |            [0] |    110.48 ns |  0.1282 ns |  0.1199 ns |  5.92 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     58.94 ns |  0.0293 ns |  0.0274 ns |  3.16 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     58.18 ns |  0.0284 ns |  0.0266 ns |  3.12 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     55.13 ns |  0.0245 ns |  0.0229 ns |  2.96 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     55.47 ns |  0.0167 ns |  0.0148 ns |  2.97 |    0.00 |
|                                           ForeachDelegate |            [0] |     21.34 ns |  0.0348 ns |  0.0325 ns |  1.14 |    0.00 |
|                                                   Foreach |            [0] |     18.65 ns |  0.0191 ns |  0.0178 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |         **[1000]** | **11,793.26 ns** |  **4.0555 ns** |  **3.7936 ns** |  **2.13** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  8,928.40 ns |  3.8847 ns |  3.6338 ns |  1.61 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,677.38 ns |  7.0103 ns |  6.5575 ns |  1.56 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,723.34 ns |  3.8314 ns |  3.5839 ns |  1.57 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,972.01 ns | 29.6955 ns | 27.7772 ns |  1.62 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,001.27 ns |  1.5319 ns |  1.3580 ns |  1.26 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,759.11 ns |  1.5544 ns |  1.4540 ns |  1.22 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 15,520.05 ns |  7.7128 ns |  7.2145 ns |  2.80 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 16,122.05 ns |  6.6773 ns |  6.2460 ns |  2.91 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 14,501.57 ns |  4.7376 ns |  4.4316 ns |  2.61 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 13,976.36 ns |  3.5600 ns |  3.1558 ns |  2.52 |    0.00 |
|                                                 LinqCount |         [1000] |  7,510.96 ns |  2.0840 ns |  1.8474 ns |  1.35 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,480.87 ns |  3.7284 ns |  3.4876 ns |  1.35 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,492.54 ns |  7.1515 ns |  6.6895 ns |  1.35 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,555.32 ns |  2.0331 ns |  1.9018 ns |  1.00 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,791.13 ns |  1.3211 ns |  1.2358 ns |  1.04 |    0.00 |
|                                               LinqToArray |         [1000] |  9,591.22 ns |  8.1075 ns |  7.5838 ns |  1.73 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,414.99 ns |  9.6589 ns |  9.0350 ns |  1.70 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  9,032.23 ns |  6.1537 ns |  5.1386 ns |  1.63 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,301.39 ns | 12.0343 ns | 11.2569 ns |  1.32 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,528.56 ns |  6.0934 ns |  5.6998 ns |  1.36 |    0.00 |
|                                                      Take |         [1000] |    429.52 ns |  0.1089 ns |  0.1019 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    244.62 ns |  0.2581 ns |  0.2414 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    238.35 ns |  0.1946 ns |  0.1821 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    206.61 ns |  0.3702 ns |  0.3463 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    191.61 ns |  0.0380 ns |  0.0355 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    328.31 ns |  0.6157 ns |  0.5759 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    250.11 ns |  0.0803 ns |  0.0712 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    243.60 ns |  0.3683 ns |  0.3445 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    194.76 ns |  0.2221 ns |  0.1734 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    194.36 ns |  0.1573 ns |  0.1472 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,973.72 ns |  0.5936 ns |  0.5262 ns |  1.26 |    0.00 |
|                                                   Foreach |         [1000] |  5,548.62 ns |  7.7333 ns |  7.2337 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |           **[50]** |    **647.58 ns** |  **0.3481 ns** |  **0.3256 ns** |  **2.15** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    498.42 ns |  0.0832 ns |  0.0778 ns |  1.65 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    484.50 ns |  0.1049 ns |  0.0981 ns |  1.61 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    495.77 ns |  0.1322 ns |  0.1236 ns |  1.64 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    498.98 ns |  0.1294 ns |  0.1211 ns |  1.66 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    399.87 ns |  0.1474 ns |  0.1307 ns |  1.33 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    386.77 ns |  0.0725 ns |  0.0678 ns |  1.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    905.18 ns |  0.2846 ns |  0.2663 ns |  3.00 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    903.90 ns |  0.2883 ns |  0.2697 ns |  3.00 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    838.04 ns |  0.1060 ns |  0.0992 ns |  2.78 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    798.25 ns |  0.1764 ns |  0.1563 ns |  2.65 |    0.00 |
|                                                 LinqCount |           [50] |    431.03 ns |  0.1639 ns |  0.1453 ns |  1.43 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    429.03 ns |  0.0941 ns |  0.0786 ns |  1.42 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    424.54 ns |  0.0839 ns |  0.0744 ns |  1.41 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    326.88 ns |  0.0591 ns |  0.0553 ns |  1.08 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    337.06 ns |  0.0507 ns |  0.0475 ns |  1.12 |    0.00 |
|                                               LinqToArray |           [50] |    723.78 ns |  1.9918 ns |  1.8632 ns |  2.40 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    615.32 ns |  0.7781 ns |  0.7278 ns |  2.04 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    614.02 ns |  0.3376 ns |  0.3158 ns |  2.04 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    506.86 ns |  0.2752 ns |  0.2574 ns |  1.68 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    520.44 ns |  0.9885 ns |  0.9246 ns |  1.73 |    0.00 |
|                                                      Take |           [50] |    429.53 ns |  0.3528 ns |  0.3300 ns |  1.43 |    0.00 |
|                                               LowCostTake |           [50] |    244.61 ns |  0.1248 ns |  0.1168 ns |  0.81 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    238.32 ns |  0.1314 ns |  0.1164 ns |  0.79 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    205.19 ns |  0.0507 ns |  0.0474 ns |  0.68 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    191.80 ns |  0.1431 ns |  0.1338 ns |  0.64 |    0.00 |
|                                            SkipTakeSingle |           [50] |    324.96 ns |  0.1247 ns |  0.1166 ns |  1.08 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    250.67 ns |  0.0697 ns |  0.0652 ns |  0.83 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    242.48 ns |  0.1798 ns |  0.1682 ns |  0.80 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    194.85 ns |  0.1477 ns |  0.1381 ns |  0.65 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    194.47 ns |  0.0388 ns |  0.0344 ns |  0.65 |    0.00 |
|                                           ForeachDelegate |           [50] |    382.46 ns |  0.0586 ns |  0.0548 ns |  1.27 |    0.00 |
|                                                   Foreach |           [50] |    301.42 ns |  0.0725 ns |  0.0643 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |            **[5]** |    **110.97 ns** |  **0.0637 ns** |  **0.0565 ns** |  **2.38** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     85.14 ns |  0.0615 ns |  0.0545 ns |  1.83 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     83.06 ns |  0.0449 ns |  0.0420 ns |  1.78 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     90.50 ns |  0.2891 ns |  0.2704 ns |  1.94 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     85.12 ns |  0.0573 ns |  0.0536 ns |  1.83 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     73.16 ns |  0.0310 ns |  0.0259 ns |  1.57 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     70.14 ns |  0.0284 ns |  0.0265 ns |  1.51 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    193.63 ns |  0.2503 ns |  0.2219 ns |  4.16 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    179.98 ns |  0.0749 ns |  0.0701 ns |  3.87 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    185.29 ns |  0.1981 ns |  0.1853 ns |  3.98 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    173.38 ns |  0.2449 ns |  0.2291 ns |  3.72 |    0.00 |
|                                                 LinqCount |            [5] |     87.14 ns |  0.0469 ns |  0.0366 ns |  1.87 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     86.78 ns |  1.6747 ns |  1.5665 ns |  1.86 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     84.14 ns |  0.0462 ns |  0.0386 ns |  1.81 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     64.81 ns |  0.0790 ns |  0.0700 ns |  1.39 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     64.70 ns |  0.0141 ns |  0.0132 ns |  1.39 |    0.00 |
|                                               LinqToArray |            [5] |    167.40 ns |  0.0587 ns |  0.0549 ns |  3.59 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    135.09 ns |  0.0680 ns |  0.0603 ns |  2.90 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    133.27 ns |  0.1354 ns |  0.1200 ns |  2.86 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    113.63 ns |  0.0333 ns |  0.0295 ns |  2.44 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    114.96 ns |  0.0414 ns |  0.0387 ns |  2.47 |    0.00 |
|                                                      Take |            [5] |    182.93 ns |  0.1869 ns |  0.1748 ns |  3.93 |    0.00 |
|                                               LowCostTake |            [5] |     97.45 ns |  0.0387 ns |  0.0343 ns |  2.09 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     90.05 ns |  0.0232 ns |  0.0217 ns |  1.93 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     88.62 ns |  0.0495 ns |  0.0463 ns |  1.90 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     77.07 ns |  0.0438 ns |  0.0388 ns |  1.66 |    0.00 |
|                                            SkipTakeSingle |            [5] |    162.93 ns |  0.0522 ns |  0.0436 ns |  3.50 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     99.73 ns |  0.0582 ns |  0.0516 ns |  2.14 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     99.52 ns |  0.0927 ns |  0.0774 ns |  2.14 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     83.28 ns |  0.0336 ns |  0.0281 ns |  1.79 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     83.84 ns |  0.1629 ns |  0.1524 ns |  1.80 |    0.00 |
|                                           ForeachDelegate |            [5] |     56.12 ns |  0.1015 ns |  0.0900 ns |  1.21 |    0.00 |
|                                                   Foreach |            [5] |     46.57 ns |  0.0201 ns |  0.0188 ns |  1.00 |    0.00 |
