``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |              **0** |     **51.860 ns** |  **0.0079 ns** |  **0.0066 ns** |  **18.01** |     **0.01** |
|                      LowCostLinqWithDelegate |              0 |     19.839 ns |  0.0009 ns |  0.0009 ns |   6.89 |     0.00 |
|                     LowCostLinqWithDelegate2 |              0 |     37.242 ns |  0.0026 ns |  0.0022 ns |  12.93 |     0.01 |
|                   LowCostLinqWithStructWhere |              0 |     27.212 ns |  0.0005 ns |  0.0005 ns |   9.45 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |     53.207 ns |  0.0468 ns |  0.0438 ns |  18.48 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |     44.482 ns |  0.0488 ns |  0.0456 ns |  15.45 |     0.02 |
|                                    LinqCount |              0 |     50.013 ns |  0.0135 ns |  0.0105 ns |  17.37 |     0.01 |
|                 LowCostLinqWithDelegateCount |              0 |     23.206 ns |  0.0015 ns |  0.0014 ns |   8.06 |     0.00 |
|              LowCostLinqWithStructWhereCount |              0 |     21.009 ns |  0.0039 ns |  0.0034 ns |   7.30 |     0.00 |
|                                  LinqToArray |              0 |     61.545 ns |  0.3872 ns |  0.3622 ns |  21.38 |     0.12 |
|               LowCostLinqWithDelegateToArray |              0 |     26.704 ns |  0.0091 ns |  0.0076 ns |   9.27 |     0.00 |
|                 LowCostLinqWithStructToArray |              0 |     29.537 ns |  0.0043 ns |  0.0036 ns |  10.26 |     0.00 |
|                                         Take |              0 |     85.386 ns |  0.1106 ns |  0.1035 ns |  29.66 |     0.04 |
|                                  LowCostTake |              0 |     29.167 ns |  0.0016 ns |  0.0014 ns |  10.13 |     0.00 |
|                        LowCostTakeWithStruct |              0 |     35.766 ns |  0.0014 ns |  0.0012 ns |  12.42 |     0.01 |
|                               SkipTakeSingle |              0 |    110.357 ns |  0.1529 ns |  0.1430 ns |  38.33 |     0.05 |
|                        LowCostSkipTakeSingle |              0 |     37.244 ns |  0.0008 ns |  0.0007 ns |  12.94 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              0 |     40.364 ns |  0.0431 ns |  0.0403 ns |  14.02 |     0.01 |
|                              ForeachDelegate |              0 |      6.905 ns |  0.0020 ns |  0.0016 ns |   2.40 |     0.00 |
|                                      Foreach |              0 |      2.882 ns |  0.0024 ns |  0.0020 ns |   1.00 |     0.00 |
|                                          For |              0 |      2.879 ns |  0.0014 ns |  0.0013 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |           **1000** |  **7,744.404 ns** | **11.2940 ns** | **10.0119 ns** |  **30.94** |     **0.04** |
|                      LowCostLinqWithDelegate |           1000 |  5,359.843 ns | 14.8270 ns | 12.3812 ns |  21.42 |     0.05 |
|                     LowCostLinqWithDelegate2 |           1000 |  6,037.098 ns |  3.2462 ns |  3.0365 ns |  24.12 |     0.01 |
|                   LowCostLinqWithStructWhere |           1000 |  1,468.985 ns |  0.0807 ns |  0.0716 ns |   5.87 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 16,084.696 ns | 14.5450 ns | 13.6054 ns |  64.27 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  5,973.832 ns |  8.7152 ns |  8.1522 ns |  23.87 |     0.03 |
|                                    LinqCount |           1000 |  3,899.416 ns |  4.3539 ns |  4.0727 ns |  15.58 |     0.02 |
|                 LowCostLinqWithDelegateCount |           1000 |  4,081.190 ns |  0.3858 ns |  0.3609 ns |  16.31 |     0.00 |
|              LowCostLinqWithStructWhereCount |           1000 |  1,329.837 ns |  0.4821 ns |  0.4026 ns |   5.31 |     0.00 |
|                                  LinqToArray |           1000 |  4,888.377 ns |  7.3787 ns |  6.5410 ns |  19.53 |     0.03 |
|               LowCostLinqWithDelegateToArray |           1000 |  5,843.688 ns | 12.4534 ns | 11.6489 ns |  23.35 |     0.05 |
|                 LowCostLinqWithStructToArray |           1000 |  2,198.740 ns |  3.0446 ns |  2.6990 ns |   8.78 |     0.01 |
|                                         Take |           1000 |    354.645 ns |  0.4792 ns |  0.4482 ns |   1.42 |     0.00 |
|                                  LowCostTake |           1000 |    148.781 ns |  0.0617 ns |  0.0577 ns |   0.59 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |     70.627 ns |  0.1586 ns |  0.1483 ns |   0.28 |     0.00 |
|                               SkipTakeSingle |           1000 |    261.121 ns |  0.0728 ns |  0.0681 ns |   1.04 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    148.054 ns |  0.1649 ns |  0.1543 ns |   0.59 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |     63.809 ns |  0.0161 ns |  0.0143 ns |   0.25 |     0.00 |
|                              ForeachDelegate |           1000 |  2,635.913 ns |  0.4821 ns |  0.4025 ns |  10.53 |     0.00 |
|                                      Foreach |           1000 |    334.455 ns |  0.1137 ns |  0.0949 ns |   1.34 |     0.00 |
|                                          For |           1000 |    250.284 ns |  0.0613 ns |  0.0574 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |              **5** |     **97.469 ns** |  **0.0475 ns** |  **0.0396 ns** |  **23.41** |     **0.03** |
|                      LowCostLinqWithDelegate |              5 |     43.724 ns |  0.0172 ns |  0.0144 ns |  10.50 |     0.01 |
|                     LowCostLinqWithDelegate2 |              5 |     62.555 ns |  0.0349 ns |  0.0326 ns |  15.02 |     0.02 |
|                   LowCostLinqWithStructWhere |              5 |     34.201 ns |  0.0114 ns |  0.0107 ns |   8.21 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    133.949 ns |  0.0819 ns |  0.0766 ns |  32.17 |     0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |     69.132 ns |  0.0340 ns |  0.0301 ns |  16.60 |     0.02 |
|                                    LinqCount |              5 |     79.804 ns |  0.1588 ns |  0.1486 ns |  19.17 |     0.04 |
|                 LowCostLinqWithDelegateCount |              5 |     44.232 ns |  0.0317 ns |  0.0281 ns |  10.62 |     0.01 |
|              LowCostLinqWithStructWhereCount |              5 |     23.635 ns |  0.0086 ns |  0.0077 ns |   5.68 |     0.01 |
|                                  LinqToArray |              5 |    134.469 ns |  0.2398 ns |  0.2243 ns |  32.30 |     0.06 |
|               LowCostLinqWithDelegateToArray |              5 |     83.894 ns |  0.0686 ns |  0.0609 ns |  20.15 |     0.03 |
|                 LowCostLinqWithStructToArray |              5 |     61.259 ns |  0.0550 ns |  0.0514 ns |  14.71 |     0.02 |
|                                         Take |              5 |    160.092 ns |  0.1973 ns |  0.1845 ns |  38.45 |     0.06 |
|                                  LowCostTake |              5 |     51.755 ns |  0.0556 ns |  0.0464 ns |  12.43 |     0.02 |
|                        LowCostTakeWithStruct |              5 |     44.097 ns |  0.0190 ns |  0.0178 ns |  10.59 |     0.01 |
|                               SkipTakeSingle |              5 |    150.564 ns |  0.0541 ns |  0.0506 ns |  36.16 |     0.04 |
|                        LowCostSkipTakeSingle |              5 |     54.390 ns |  0.0552 ns |  0.0490 ns |  13.06 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |              5 |     47.761 ns |  0.0048 ns |  0.0042 ns |  11.47 |     0.01 |
|                              ForeachDelegate |              5 |     19.662 ns |  0.0039 ns |  0.0036 ns |   4.72 |     0.01 |
|                                      Foreach |              5 |      4.276 ns |  0.0043 ns |  0.0040 ns |   1.03 |     0.00 |
|                                          For |              5 |      4.164 ns |  0.0061 ns |  0.0048 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |             **50** |    **448.755 ns** |  **0.1515 ns** |  **0.1418 ns** |  **27.98** |     **0.01** |
|                      LowCostLinqWithDelegate |             50 |    306.595 ns |  0.3361 ns |  0.3144 ns |  19.12 |     0.02 |
|                     LowCostLinqWithDelegate2 |             50 |    338.639 ns |  0.1129 ns |  0.1057 ns |  21.11 |     0.01 |
|                   LowCostLinqWithStructWhere |             50 |     99.132 ns |  0.0332 ns |  0.0310 ns |   6.18 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |    865.227 ns |  1.0866 ns |  1.0164 ns |  53.94 |     0.06 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |    348.246 ns |  0.0730 ns |  0.0610 ns |  21.71 |     0.01 |
|                                    LinqCount |             50 |    255.811 ns |  0.0611 ns |  0.0571 ns |  15.95 |     0.01 |
|                 LowCostLinqWithDelegateCount |             50 |    230.474 ns |  0.0873 ns |  0.0817 ns |  14.37 |     0.01 |
|              LowCostLinqWithStructWhereCount |             50 |     70.061 ns |  0.0086 ns |  0.0076 ns |   4.37 |     0.00 |
|                                  LinqToArray |             50 |    603.326 ns |  5.2458 ns |  3.7930 ns |  37.62 |     0.23 |
|               LowCostLinqWithDelegateToArray |             50 |    422.096 ns |  0.2314 ns |  0.2165 ns |  26.32 |     0.02 |
|                 LowCostLinqWithStructToArray |             50 |    211.674 ns |  0.3072 ns |  0.2874 ns |  13.20 |     0.02 |
|                                         Take |             50 |    353.322 ns |  0.1347 ns |  0.1194 ns |  22.03 |     0.01 |
|                                  LowCostTake |             50 |    149.000 ns |  0.1653 ns |  0.1546 ns |   9.29 |     0.01 |
|                        LowCostTakeWithStruct |             50 |     81.296 ns |  0.1536 ns |  0.1437 ns |   5.07 |     0.01 |
|                               SkipTakeSingle |             50 |    261.199 ns |  0.1895 ns |  0.1772 ns |  16.28 |     0.01 |
|                        LowCostSkipTakeSingle |             50 |    143.243 ns |  0.0751 ns |  0.0666 ns |   8.93 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |             50 |     66.729 ns |  0.0616 ns |  0.0577 ns |   4.16 |     0.00 |
|                              ForeachDelegate |             50 |    142.281 ns |  0.0247 ns |  0.0193 ns |   8.87 |     0.00 |
|                                      Foreach |             50 |     18.093 ns |  0.0574 ns |  0.0537 ns |   1.13 |     0.00 |
|                                          For |             50 |     16.039 ns |  0.0064 ns |  0.0057 ns |   1.00 |     0.00 |
