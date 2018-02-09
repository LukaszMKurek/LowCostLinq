``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **81.07 ns** |   **0.0286 ns** |   **0.0206 ns** |     **81.07 ns** |   **4.62** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     46.60 ns |   0.0123 ns |   0.0096 ns |     46.60 ns |   2.66 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     41.68 ns |   0.0134 ns |   0.0104 ns |     41.68 ns |   2.38 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     58.11 ns |   0.0120 ns |   0.0106 ns |     58.10 ns |   3.31 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     59.77 ns |   0.0165 ns |   0.0138 ns |     59.77 ns |   3.41 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     50.83 ns |   0.0255 ns |   0.0213 ns |     50.83 ns |   2.90 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     49.77 ns |   0.0220 ns |   0.0159 ns |     49.77 ns |   2.84 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    102.48 ns |   0.0225 ns |   0.0200 ns |    102.48 ns |   5.84 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     99.98 ns |   0.0523 ns |   0.0489 ns |    100.01 ns |   5.70 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     93.69 ns |   0.0178 ns |   0.0158 ns |     93.68 ns |   5.34 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     88.15 ns |   0.0599 ns |   0.0500 ns |     88.15 ns |   5.03 |     0.01 |
|                                                 LinqCount |              0 |     77.88 ns |   0.0557 ns |   0.0465 ns |     77.87 ns |   4.44 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     49.51 ns |   0.1017 ns |   0.0951 ns |     49.49 ns |   2.82 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     48.08 ns |   0.0853 ns |   0.0798 ns |     48.10 ns |   2.74 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     45.75 ns |   0.0479 ns |   0.0425 ns |     45.73 ns |   2.61 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     41.31 ns |   0.0354 ns |   0.0313 ns |     41.31 ns |   2.36 |     0.00 |
|                                               LinqToArray |              0 |     94.50 ns |   1.9532 ns |   3.6204 ns |     92.62 ns |   5.39 |     0.20 |
|                            LowCostLinqWithDelegateToArray |              0 |     61.59 ns |   0.0407 ns |   0.0361 ns |     61.58 ns |   3.51 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     59.84 ns |   0.0208 ns |   0.0184 ns |     59.85 ns |   3.41 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     49.66 ns |   0.0480 ns |   0.0425 ns |     49.66 ns |   2.83 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     51.06 ns |   0.0685 ns |   0.0641 ns |     51.02 ns |   2.91 |     0.00 |
|                                                      Take |              0 |    115.25 ns |   0.0955 ns |   0.0893 ns |    115.27 ns |   6.57 |     0.01 |
|                                               LowCostTake |              0 |     50.74 ns |   0.0102 ns |   0.0079 ns |     50.73 ns |   2.89 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     49.18 ns |   0.0150 ns |   0.0133 ns |     49.18 ns |   2.80 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     55.91 ns |   0.0081 ns |   0.0068 ns |     55.91 ns |   3.19 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     63.21 ns |   0.0203 ns |   0.0159 ns |     63.21 ns |   3.60 |     0.00 |
|                                            SkipTakeSingle |              0 |    136.02 ns |   0.0691 ns |   0.0577 ns |    136.02 ns |   7.75 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     60.91 ns |   0.0273 ns |   0.0255 ns |     60.92 ns |   3.47 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     61.06 ns |   0.0335 ns |   0.0314 ns |     61.05 ns |   3.48 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     62.23 ns |   0.0626 ns |   0.0585 ns |     62.27 ns |   3.55 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     62.90 ns |   0.0788 ns |   0.0737 ns |     62.95 ns |   3.59 |     0.01 |
|                                           ForeachDelegate |              0 |     19.85 ns |   0.0212 ns |   0.0198 ns |     19.85 ns |   1.13 |     0.00 |
|                                                   Foreach |              0 |     17.54 ns |   0.0197 ns |   0.0184 ns |     17.55 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **1000** | **13,820.56 ns** |  **10.2581 ns** |   **9.5954 ns** | **13,819.74 ns** |   **2.62** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 | 11,276.86 ns |   6.1873 ns |   5.7876 ns | 11,276.60 ns |   2.14 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 10,577.94 ns |  12.8970 ns |  12.0639 ns | 10,583.53 ns |   2.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 | 11,159.81 ns | 118.9222 ns | 111.2399 ns | 11,179.41 ns |   2.11 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 10,332.45 ns |   9.7379 ns |   8.6324 ns | 10,333.69 ns |   1.96 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  6,523.43 ns |   4.3285 ns |   4.0489 ns |  6,524.30 ns |   1.24 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  6,514.12 ns |   8.1692 ns |   7.6415 ns |  6,517.34 ns |   1.23 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 23,569.65 ns |  14.8553 ns |  13.1689 ns | 23,571.33 ns |   4.46 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 24,396.22 ns |  80.8798 ns |  75.6550 ns | 24,429.17 ns |   4.62 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 13,041.92 ns |   5.9652 ns |   4.9812 ns | 13,042.98 ns |   2.47 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 13,506.22 ns |  13.2125 ns |  12.3590 ns | 13,510.04 ns |   2.56 |     0.00 |
|                                                 LinqCount |           1000 |  9,394.85 ns |  31.1578 ns |  27.6205 ns |  9,401.79 ns |   1.78 |     0.01 |
|                              LowCostLinqWithDelegateCount |           1000 | 10,100.17 ns |   4.1533 ns |   3.8850 ns | 10,100.05 ns |   1.91 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 10,472.12 ns |  88.9335 ns |  83.1884 ns | 10,454.06 ns |   1.98 |     0.02 |
|                           LowCostLinqWithStructWhereCount |           1000 |  5,787.98 ns |   6.5018 ns |   6.0818 ns |  5,790.11 ns |   1.10 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  5,550.21 ns |   5.7564 ns |   5.3846 ns |  5,547.16 ns |   1.05 |     0.00 |
|                                               LinqToArray |           1000 | 10,813.47 ns |  16.4325 ns |  15.3710 ns | 10,817.00 ns |   2.05 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 | 12,833.32 ns |  61.9371 ns |  57.9360 ns | 12,810.84 ns |   2.43 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 11,737.41 ns |  15.9690 ns |  14.9374 ns | 11,740.63 ns |   2.22 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  7,685.28 ns |   4.2546 ns |   3.9797 ns |  7,684.88 ns |   1.46 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  7,337.35 ns |   6.5439 ns |   6.1212 ns |  7,337.62 ns |   1.39 |     0.00 |
|                                                      Take |           1000 |    472.65 ns |   0.0616 ns |   0.0481 ns |    472.65 ns |   0.09 |     0.00 |
|                                               LowCostTake |           1000 |    307.72 ns |   0.2272 ns |   0.1897 ns |    307.68 ns |   0.06 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    282.32 ns |   0.0761 ns |   0.0636 ns |    282.30 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    205.90 ns |   0.1382 ns |   0.1293 ns |    205.92 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    191.61 ns |   0.0336 ns |   0.0281 ns |    191.62 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |           1000 |    399.54 ns |   0.0606 ns |   0.0567 ns |    399.53 ns |   0.08 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    295.87 ns |   0.3986 ns |   0.3729 ns |    296.06 ns |   0.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    289.96 ns |   0.0524 ns |   0.0409 ns |    289.96 ns |   0.05 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    202.11 ns |   0.0633 ns |   0.0592 ns |    202.13 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    196.52 ns |   0.1197 ns |   0.0999 ns |    196.49 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |           1000 |  8,634.97 ns |   8.3073 ns |   7.7707 ns |  8,636.58 ns |   1.64 |     0.00 |
|                                                   Foreach |           1000 |  5,280.46 ns |   4.6225 ns |   4.3239 ns |  5,280.40 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |              **5** |    **150.19 ns** |   **0.0244 ns** |   **0.0204 ns** |    **150.19 ns** |   **3.44** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |    105.43 ns |   0.0740 ns |   0.0618 ns |    105.43 ns |   2.42 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     98.10 ns |   0.0544 ns |   0.0482 ns |     98.09 ns |   2.25 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    113.03 ns |   0.0365 ns |   0.0305 ns |    113.03 ns |   2.59 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    114.48 ns |   0.0927 ns |   0.0867 ns |    114.45 ns |   2.62 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     77.63 ns |   0.0677 ns |   0.0633 ns |     77.65 ns |   1.78 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     75.61 ns |   0.0130 ns |   0.0122 ns |     75.61 ns |   1.73 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    237.21 ns |   0.2688 ns |   0.2515 ns |    237.16 ns |   5.43 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    237.11 ns |   0.1213 ns |   0.1013 ns |    237.10 ns |   5.43 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    170.00 ns |   0.1719 ns |   0.1608 ns |    170.09 ns |   3.89 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    169.52 ns |   0.0500 ns |   0.0468 ns |    169.51 ns |   3.88 |     0.00 |
|                                                 LinqCount |              5 |    124.67 ns |   0.1011 ns |   0.0946 ns |    124.70 ns |   2.86 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     99.61 ns |   0.2588 ns |   0.2420 ns |     99.61 ns |   2.28 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    101.71 ns |   0.0752 ns |   0.0703 ns |    101.70 ns |   2.33 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     67.31 ns |   0.0276 ns |   0.0231 ns |     67.30 ns |   1.54 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     69.42 ns |   0.4193 ns |   0.3923 ns |     69.34 ns |   1.59 |     0.01 |
|                                               LinqToArray |              5 |    211.70 ns |   2.8530 ns |   2.6687 ns |    213.28 ns |   4.85 |     0.06 |
|                            LowCostLinqWithDelegateToArray |              5 |    154.36 ns |   0.2459 ns |   0.2300 ns |    154.39 ns |   3.54 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    148.50 ns |   0.0404 ns |   0.0338 ns |    148.51 ns |   3.40 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |    119.26 ns |   0.0427 ns |   0.0357 ns |    119.25 ns |   2.73 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    121.39 ns |   0.0185 ns |   0.0155 ns |    121.40 ns |   2.78 |     0.00 |
|                                                      Take |              5 |    226.41 ns |   0.2663 ns |   0.2491 ns |    226.53 ns |   5.19 |     0.01 |
|                                               LowCostTake |              5 |    116.38 ns |   0.0439 ns |   0.0367 ns |    116.36 ns |   2.67 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |    105.87 ns |   0.0726 ns |   0.0644 ns |    105.85 ns |   2.43 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     85.72 ns |   0.0231 ns |   0.0180 ns |     85.73 ns |   1.96 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     82.26 ns |   0.0614 ns |   0.0513 ns |     82.23 ns |   1.88 |     0.00 |
|                                            SkipTakeSingle |              5 |    212.97 ns |   0.0596 ns |   0.0497 ns |    212.98 ns |   4.88 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |    113.19 ns |   0.0571 ns |   0.0477 ns |    113.18 ns |   2.59 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    112.41 ns |   0.1227 ns |   0.1148 ns |    112.45 ns |   2.58 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     90.66 ns |   0.0774 ns |   0.0646 ns |     90.65 ns |   2.08 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     87.18 ns |   0.0322 ns |   0.0269 ns |     87.18 ns |   2.00 |     0.00 |
|                                           ForeachDelegate |              5 |     62.91 ns |   0.0168 ns |   0.0149 ns |     62.91 ns |   1.44 |     0.00 |
|                                                   Foreach |              5 |     43.65 ns |   0.0573 ns |   0.0536 ns |     43.62 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |             **50** |    **779.09 ns** |   **0.5355 ns** |   **0.4747 ns** |    **778.87 ns** |   **2.70** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    611.28 ns |   0.3571 ns |   0.2982 ns |    611.22 ns |   2.12 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    578.62 ns |   0.0889 ns |   0.0788 ns |    578.61 ns |   2.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    605.03 ns |   0.4520 ns |   0.4228 ns |    604.89 ns |   2.10 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    570.63 ns |   0.4284 ns |   0.4008 ns |    570.43 ns |   1.98 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    385.02 ns |   0.2402 ns |   0.2247 ns |    385.03 ns |   1.33 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    372.63 ns |   0.0407 ns |   0.0381 ns |    372.64 ns |   1.29 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,299.68 ns |   1.2899 ns |   1.2066 ns |  1,299.45 ns |   4.50 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,332.40 ns |   1.4969 ns |   1.4002 ns |  1,332.66 ns |   4.62 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    749.84 ns |   0.1851 ns |   0.1641 ns |    749.85 ns |   2.60 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    783.03 ns |   0.1450 ns |   0.1285 ns |    783.02 ns |   2.71 |     0.00 |
|                                                 LinqCount |             50 |    555.63 ns |   0.8140 ns |   0.7614 ns |    555.95 ns |   1.93 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    565.53 ns |   0.2006 ns |   0.1675 ns |    565.53 ns |   1.96 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    583.82 ns |   0.1478 ns |   0.1069 ns |    583.86 ns |   2.02 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    331.81 ns |   0.0716 ns |   0.0559 ns |    331.81 ns |   1.15 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    324.92 ns |   0.0642 ns |   0.0501 ns |    324.91 ns |   1.13 |     0.00 |
|                                               LinqToArray |             50 |    834.73 ns |   1.6935 ns |   1.5841 ns |    834.96 ns |   2.89 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |    843.26 ns |   0.2666 ns |   0.2494 ns |    843.30 ns |   2.92 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    794.51 ns |   0.4591 ns |   0.4294 ns |    794.66 ns |   2.75 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    547.23 ns |   0.1212 ns |   0.1075 ns |    547.28 ns |   1.90 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    535.98 ns |   0.7414 ns |   0.6935 ns |    536.27 ns |   1.86 |     0.00 |
|                                                      Take |             50 |    471.10 ns |   0.0377 ns |   0.0294 ns |    471.10 ns |   1.63 |     0.00 |
|                                               LowCostTake |             50 |    307.50 ns |   0.1282 ns |   0.1199 ns |    307.52 ns |   1.07 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    284.08 ns |   0.0379 ns |   0.0317 ns |    284.08 ns |   0.98 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    204.36 ns |   0.1989 ns |   0.1861 ns |    204.45 ns |   0.71 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    197.52 ns |   0.0908 ns |   0.0805 ns |    197.48 ns |   0.68 |     0.00 |
|                                            SkipTakeSingle |             50 |    399.06 ns |   0.1683 ns |   0.1574 ns |    399.01 ns |   1.38 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    301.14 ns |   0.2720 ns |   0.2545 ns |    301.11 ns |   1.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    290.30 ns |   0.1822 ns |   0.1704 ns |    290.27 ns |   1.01 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    199.08 ns |   0.0404 ns |   0.0359 ns |    199.07 ns |   0.69 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    196.83 ns |   0.0471 ns |   0.0393 ns |    196.83 ns |   0.68 |     0.00 |
|                                           ForeachDelegate |             50 |    451.37 ns |   0.0792 ns |   0.0741 ns |    451.35 ns |   1.56 |     0.00 |
|                                                   Foreach |             50 |    288.62 ns |   0.0555 ns |   0.0464 ns |    288.62 ns |   1.00 |     0.00 |
