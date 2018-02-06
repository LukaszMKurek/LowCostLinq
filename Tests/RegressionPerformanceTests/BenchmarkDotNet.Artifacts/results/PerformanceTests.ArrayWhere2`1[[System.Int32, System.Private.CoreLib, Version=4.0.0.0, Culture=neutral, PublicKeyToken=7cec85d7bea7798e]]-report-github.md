``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev |        Median | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|--------------:|-------:|---------:|
|                                         **Linq** |              **0** |     **51.664 ns** |  **0.4575 ns** |  **0.4280 ns** |     **51.405 ns** |  **17.88** |     **0.14** |
|                      LowCostLinqWithDelegate |              0 |     19.855 ns |  0.0019 ns |  0.0017 ns |     19.855 ns |   6.87 |     0.00 |
|                     LowCostLinqWithDelegate2 |              0 |     37.960 ns |  0.0070 ns |  0.0065 ns |     37.962 ns |  13.14 |     0.00 |
|                   LowCostLinqWithStructWhere |              0 |     26.983 ns |  0.0019 ns |  0.0015 ns |     26.982 ns |   9.34 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |     53.111 ns |  0.0391 ns |  0.0305 ns |     53.107 ns |  18.38 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |     35.925 ns |  0.0625 ns |  0.0585 ns |     35.899 ns |  12.43 |     0.02 |
|                                    LinqCount |              0 |     49.233 ns |  0.0137 ns |  0.0114 ns |     49.231 ns |  17.04 |     0.00 |
|                 LowCostLinqWithDelegateCount |              0 |     22.915 ns |  0.0083 ns |  0.0073 ns |     22.916 ns |   7.93 |     0.00 |
|              LowCostLinqWithStructWhereCount |              0 |     20.541 ns |  0.0015 ns |  0.0014 ns |     20.540 ns |   7.11 |     0.00 |
|                                  LinqToArray |              0 |     59.938 ns |  0.3514 ns |  0.3287 ns |     59.901 ns |  20.74 |     0.11 |
|               LowCostLinqWithDelegateToArray |              0 |     26.598 ns |  0.1937 ns |  0.1717 ns |     26.481 ns |   9.20 |     0.06 |
|                 LowCostLinqWithStructToArray |              0 |     23.879 ns |  0.0105 ns |  0.0082 ns |     23.881 ns |   8.26 |     0.00 |
|                                         Take |              0 |     85.010 ns |  0.0889 ns |  0.0831 ns |     84.961 ns |  29.42 |     0.03 |
|                                  LowCostTake |              0 |     29.256 ns |  0.1463 ns |  0.1368 ns |     29.147 ns |  10.12 |     0.05 |
|                        LowCostTakeWithStruct |              0 |     35.052 ns |  0.0015 ns |  0.0014 ns |     35.052 ns |  12.13 |     0.00 |
|                               SkipTakeSingle |              0 |    108.599 ns |  0.0322 ns |  0.0269 ns |    108.592 ns |  37.58 |     0.01 |
|                        LowCostSkipTakeSingle |              0 |     37.219 ns |  0.0023 ns |  0.0019 ns |     37.219 ns |  12.88 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |              0 |     40.397 ns |  0.0959 ns |  0.0897 ns |     40.343 ns |  13.98 |     0.03 |
|                              ForeachDelegate |              0 |      6.912 ns |  0.0033 ns |  0.0030 ns |      6.913 ns |   2.39 |     0.00 |
|                                      Foreach |              0 |      2.862 ns |  0.0022 ns |  0.0021 ns |      2.863 ns |   0.99 |     0.00 |
|                                          For |              0 |      2.890 ns |  0.0007 ns |  0.0006 ns |      2.890 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |           **1000** |  **7,723.164 ns** |  **2.5997 ns** |  **2.1709 ns** |  **7,723.764 ns** |  **30.84** |     **0.02** |
|                      LowCostLinqWithDelegate |           1000 |  5,469.631 ns | 63.3456 ns | 59.2535 ns |  5,506.404 ns |  21.84 |     0.23 |
|                     LowCostLinqWithDelegate2 |           1000 |  6,060.007 ns | 11.5538 ns | 10.2422 ns |  6,055.524 ns |  24.20 |     0.04 |
|                   LowCostLinqWithStructWhere |           1000 |  1,467.679 ns |  0.0889 ns |  0.0831 ns |  1,467.679 ns |   5.86 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 16,358.884 ns | 38.5512 ns | 36.0608 ns | 16,355.072 ns |  65.33 |     0.14 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,346.943 ns | 10.0102 ns |  8.3590 ns |  6,343.845 ns |  25.35 |     0.03 |
|                                    LinqCount |           1000 |  3,901.184 ns |  4.5116 ns |  4.2202 ns |  3,900.410 ns |  15.58 |     0.02 |
|                 LowCostLinqWithDelegateCount |           1000 |  4,081.084 ns |  0.9958 ns |  0.8828 ns |  4,080.777 ns |  16.30 |     0.01 |
|              LowCostLinqWithStructWhereCount |           1000 |  1,326.904 ns |  0.0948 ns |  0.0791 ns |  1,326.908 ns |   5.30 |     0.00 |
|                                  LinqToArray |           1000 |  4,808.303 ns | 49.8630 ns | 46.6418 ns |  4,809.272 ns |  19.20 |     0.18 |
|               LowCostLinqWithDelegateToArray |           1000 |  5,823.540 ns | 10.6842 ns |  9.4713 ns |  5,823.076 ns |  23.26 |     0.04 |
|                 LowCostLinqWithStructToArray |           1000 |  2,221.898 ns |  3.8887 ns |  3.4473 ns |  2,220.386 ns |   8.87 |     0.01 |
|                                         Take |           1000 |    351.901 ns |  0.1524 ns |  0.1425 ns |    351.890 ns |   1.41 |     0.00 |
|                                  LowCostTake |           1000 |    149.440 ns |  0.8386 ns |  0.7845 ns |    148.885 ns |   0.60 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |     70.116 ns |  0.1144 ns |  0.1070 ns |     70.056 ns |   0.28 |     0.00 |
|                               SkipTakeSingle |           1000 |    265.984 ns |  0.0469 ns |  0.0416 ns |    265.974 ns |   1.06 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    143.548 ns |  0.1955 ns |  0.1829 ns |    143.476 ns |   0.57 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |     63.381 ns |  0.3071 ns |  0.2873 ns |     63.345 ns |   0.25 |     0.00 |
|                              ForeachDelegate |           1000 |  2,635.353 ns |  0.7180 ns |  0.5995 ns |  2,635.587 ns |  10.52 |     0.01 |
|                                      Foreach |           1000 |    335.848 ns |  0.1243 ns |  0.1102 ns |    335.796 ns |   1.34 |     0.00 |
|                                          For |           1000 |    250.416 ns |  0.1318 ns |  0.1168 ns |    250.452 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |              **5** |     **95.641 ns** |  **0.0860 ns** |  **0.0804 ns** |     **95.673 ns** |  **23.02** |     **0.04** |
|                      LowCostLinqWithDelegate |              5 |     43.874 ns |  0.0136 ns |  0.0114 ns |     43.873 ns |  10.56 |     0.02 |
|                     LowCostLinqWithDelegate2 |              5 |     61.661 ns |  0.0428 ns |  0.0400 ns |     61.647 ns |  14.84 |     0.02 |
|                   LowCostLinqWithStructWhere |              5 |     35.594 ns |  0.0096 ns |  0.0080 ns |     35.590 ns |   8.57 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    133.613 ns |  0.0900 ns |  0.0842 ns |    133.626 ns |  32.16 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |     68.703 ns |  0.0323 ns |  0.0287 ns |     68.698 ns |  16.54 |     0.03 |
|                                    LinqCount |              5 |     78.236 ns |  0.0224 ns |  0.0175 ns |     78.238 ns |  18.83 |     0.03 |
|                 LowCostLinqWithDelegateCount |              5 |     43.821 ns |  0.0736 ns |  0.0614 ns |     43.820 ns |  10.55 |     0.02 |
|              LowCostLinqWithStructWhereCount |              5 |     23.652 ns |  0.0072 ns |  0.0060 ns |     23.650 ns |   5.69 |     0.01 |
|                                  LinqToArray |              5 |    134.105 ns |  0.5021 ns |  0.4696 ns |    134.063 ns |  32.28 |     0.12 |
|               LowCostLinqWithDelegateToArray |              5 |     83.596 ns |  0.1195 ns |  0.1118 ns |     83.643 ns |  20.12 |     0.04 |
|                 LowCostLinqWithStructToArray |              5 |     61.963 ns |  0.5733 ns |  0.5362 ns |     61.975 ns |  14.92 |     0.13 |
|                                         Take |              5 |    159.284 ns |  0.1273 ns |  0.1191 ns |    159.321 ns |  38.34 |     0.06 |
|                                  LowCostTake |              5 |     54.831 ns |  0.0220 ns |  0.0195 ns |     54.820 ns |  13.20 |     0.02 |
|                        LowCostTakeWithStruct |              5 |     44.130 ns |  0.0484 ns |  0.0429 ns |     44.142 ns |  10.62 |     0.02 |
|                               SkipTakeSingle |              5 |    149.198 ns |  0.1416 ns |  0.1324 ns |    149.248 ns |  35.91 |     0.06 |
|                        LowCostSkipTakeSingle |              5 |     53.727 ns |  0.0528 ns |  0.0493 ns |     53.724 ns |  12.93 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |              5 |     44.442 ns |  0.0406 ns |  0.0380 ns |     44.465 ns |  10.70 |     0.02 |
|                              ForeachDelegate |              5 |     19.626 ns |  0.0070 ns |  0.0066 ns |     19.627 ns |   4.72 |     0.01 |
|                                      Foreach |              5 |      4.173 ns |  0.0088 ns |  0.0083 ns |      4.175 ns |   1.00 |     0.00 |
|                                          For |              5 |      4.154 ns |  0.0069 ns |  0.0064 ns |      4.151 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |             **50** |    **447.399 ns** |  **0.6785 ns** |  **0.6346 ns** |    **446.895 ns** |  **27.76** |     **0.04** |
|                      LowCostLinqWithDelegate |             50 |    305.101 ns |  0.2071 ns |  0.1938 ns |    305.082 ns |  18.93 |     0.01 |
|                     LowCostLinqWithDelegate2 |             50 |    340.631 ns |  0.1140 ns |  0.1066 ns |    340.621 ns |  21.14 |     0.01 |
|                   LowCostLinqWithStructWhere |             50 |     99.470 ns |  0.5612 ns |  0.5249 ns |     99.136 ns |   6.17 |     0.03 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |    878.952 ns |  0.6687 ns |  0.6255 ns |    879.060 ns |  54.55 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |    360.129 ns |  0.0582 ns |  0.0516 ns |    360.146 ns |  22.35 |     0.01 |
|                                    LinqCount |             50 |    253.829 ns |  0.1864 ns |  0.1744 ns |    253.863 ns |  15.75 |     0.01 |
|                 LowCostLinqWithDelegateCount |             50 |    230.544 ns |  0.1647 ns |  0.1540 ns |    230.513 ns |  14.31 |     0.01 |
|              LowCostLinqWithStructWhereCount |             50 |     70.314 ns |  0.0100 ns |  0.0083 ns |     70.312 ns |   4.36 |     0.00 |
|                                  LinqToArray |             50 |    499.701 ns |  0.2743 ns |  0.2432 ns |    499.702 ns |  31.01 |     0.02 |
|               LowCostLinqWithDelegateToArray |             50 |    421.861 ns |  2.0744 ns |  1.9404 ns |    420.942 ns |  26.18 |     0.12 |
|                 LowCostLinqWithStructToArray |             50 |    206.257 ns |  0.1352 ns |  0.1265 ns |    206.263 ns |  12.80 |     0.01 |
|                                         Take |             50 |    352.832 ns |  0.2913 ns |  0.2725 ns |    352.730 ns |  21.90 |     0.02 |
|                                  LowCostTake |             50 |    148.808 ns |  0.0745 ns |  0.0697 ns |    148.800 ns |   9.23 |     0.01 |
|                        LowCostTakeWithStruct |             50 |     70.551 ns |  0.0527 ns |  0.0411 ns |     70.559 ns |   4.38 |     0.00 |
|                               SkipTakeSingle |             50 |    259.335 ns |  0.0711 ns |  0.0593 ns |    259.317 ns |  16.09 |     0.01 |
|                        LowCostSkipTakeSingle |             50 |    143.461 ns |  0.1381 ns |  0.1292 ns |    143.451 ns |   8.90 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |             50 |     62.702 ns |  0.0350 ns |  0.0328 ns |     62.700 ns |   3.89 |     0.00 |
|                              ForeachDelegate |             50 |    143.350 ns |  1.0776 ns |  1.0080 ns |    143.342 ns |   8.90 |     0.06 |
|                                      Foreach |             50 |     18.062 ns |  0.0305 ns |  0.0286 ns |     18.064 ns |   1.12 |     0.00 |
|                                          For |             50 |     16.114 ns |  0.0098 ns |  0.0082 ns |     16.117 ns |   1.00 |     0.00 |
