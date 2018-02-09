``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **21.05 ns** |  **0.0083 ns** |  **0.0078 ns** |   **1.75** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     32.61 ns |  0.0088 ns |  0.0078 ns |   2.71 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     31.48 ns |  0.0014 ns |  0.0011 ns |   2.62 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     40.66 ns |  0.0168 ns |  0.0140 ns |   3.38 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     42.72 ns |  0.0973 ns |  0.0910 ns |   3.55 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     37.42 ns |  0.0879 ns |  0.0822 ns |   3.11 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     34.00 ns |  0.0098 ns |  0.0092 ns |   2.83 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     72.01 ns |  0.0123 ns |  0.0102 ns |   5.99 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     72.51 ns |  0.0207 ns |  0.0161 ns |   6.03 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     72.37 ns |  0.0428 ns |  0.0357 ns |   6.02 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     69.98 ns |  0.0675 ns |  0.0598 ns |   5.82 |     0.01 |
|                                                 LinqCount |              0 |     24.98 ns |  0.0184 ns |  0.0163 ns |   2.08 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     23.35 ns |  0.0040 ns |  0.0029 ns |   1.94 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     23.54 ns |  0.0116 ns |  0.0090 ns |   1.96 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     22.92 ns |  0.0130 ns |  0.0115 ns |   1.91 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     24.14 ns |  0.5097 ns |  0.7310 ns |   2.01 |     0.06 |
|                                               LinqToArray |              0 |     23.79 ns |  0.0707 ns |  0.0627 ns |   1.98 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |     35.77 ns |  0.0615 ns |  0.0546 ns |   2.98 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     36.71 ns |  0.2063 ns |  0.1929 ns |   3.05 |     0.02 |
|                              LowCostLinqWithStructToArray |              0 |     32.95 ns |  0.1118 ns |  0.1045 ns |   2.74 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     37.41 ns |  0.0138 ns |  0.0115 ns |   3.11 |     0.00 |
|                                                      Take |              0 |     25.64 ns |  0.0327 ns |  0.0305 ns |   2.13 |     0.00 |
|                                               LowCostTake |              0 |     41.52 ns |  0.0061 ns |  0.0054 ns |   3.45 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     41.42 ns |  0.1051 ns |  0.0983 ns |   3.45 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     41.93 ns |  0.0061 ns |  0.0048 ns |   3.49 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     44.41 ns |  0.0134 ns |  0.0125 ns |   3.69 |     0.00 |
|                                            SkipTakeSingle |              0 |     38.63 ns |  0.1067 ns |  0.0998 ns |   3.21 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     41.43 ns |  0.0907 ns |  0.0849 ns |   3.45 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     41.37 ns |  0.0028 ns |  0.0023 ns |   3.44 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     43.92 ns |  0.0243 ns |  0.0227 ns |   3.65 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     43.69 ns |  0.0031 ns |  0.0028 ns |   3.63 |     0.00 |
|                                           ForeachDelegate |              0 |     14.69 ns |  0.0475 ns |  0.0397 ns |   1.22 |     0.00 |
|                                                   Foreach |              0 |     12.02 ns |  0.0046 ns |  0.0039 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** |  **5,523.66 ns** |  **2.0709 ns** |  **1.8358 ns** |   **1.21** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  4,167.00 ns | 90.2489 ns | 84.4189 ns |   0.92 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  3,238.12 ns | 11.1831 ns |  9.9135 ns |   0.71 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  3,900.66 ns | 12.6011 ns | 11.1706 ns |   0.86 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  3,687.83 ns |  7.7177 ns |  6.4446 ns |   0.81 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  1,726.68 ns |  0.9235 ns |  0.7712 ns |   0.38 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,552.57 ns |  0.6322 ns |  0.5279 ns |   0.34 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 10,325.46 ns | 21.0328 ns | 19.6741 ns |   2.27 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 10,409.85 ns | 20.1706 ns | 16.8434 ns |   2.29 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,090.66 ns | 60.4889 ns | 56.5814 ns |   1.78 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,011.53 ns |  5.4126 ns |  4.7981 ns |   1.76 |     0.00 |
|                                                 LinqCount |           1000 |  1,716.91 ns |  1.6560 ns |  1.5490 ns |   0.38 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  2,412.94 ns |  0.4805 ns |  0.4495 ns |   0.53 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  2,411.85 ns |  0.0953 ns |  0.0845 ns |   0.53 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,334.10 ns |  0.0704 ns |  0.0624 ns |   0.29 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,336.16 ns |  0.1920 ns |  0.1603 ns |   0.29 |     0.00 |
|                                               LinqToArray |           1000 |  3,405.81 ns |  0.8738 ns |  0.6822 ns |   0.75 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  3,885.52 ns |  3.3364 ns |  2.7860 ns |   0.85 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  3,907.55 ns |  7.9422 ns |  7.4292 ns |   0.86 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,258.30 ns |  5.1108 ns |  4.7806 ns |   0.50 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,247.93 ns |  5.1453 ns |  4.8129 ns |   0.49 |     0.00 |
|                                                      Take |           1000 |    285.78 ns |  0.1412 ns |  0.1252 ns |   0.06 |     0.00 |
|                                               LowCostTake |           1000 |    126.33 ns |  0.0830 ns |  0.0776 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    121.90 ns |  0.0670 ns |  0.0594 ns |   0.03 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     98.40 ns |  0.0271 ns |  0.0240 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     85.89 ns |  0.0173 ns |  0.0162 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    185.33 ns |  0.1145 ns |  0.1015 ns |   0.04 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    107.04 ns |  0.0491 ns |  0.0436 ns |   0.02 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    105.08 ns |  0.0561 ns |  0.0497 ns |   0.02 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     71.95 ns |  0.0465 ns |  0.0412 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     65.89 ns |  0.0597 ns |  0.0559 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |           1000 |  5,279.21 ns |  3.2459 ns |  3.0362 ns |   1.16 |     0.00 |
|                                                   Foreach |           1000 |  4,551.42 ns |  0.2838 ns |  0.2516 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |     **60.07 ns** |  **0.0357 ns** |  **0.0298 ns** |   **1.70** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     49.19 ns |  0.0128 ns |  0.0107 ns |   1.39 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     47.31 ns |  0.3157 ns |  0.2953 ns |   1.34 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |     57.73 ns |  0.0214 ns |  0.0167 ns |   1.64 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     58.74 ns |  0.0304 ns |  0.0284 ns |   1.66 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     47.41 ns |  0.0098 ns |  0.0076 ns |   1.34 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     43.85 ns |  0.0829 ns |  0.0776 ns |   1.24 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    126.01 ns |  0.0494 ns |  0.0386 ns |   3.57 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    125.20 ns |  0.1146 ns |  0.0957 ns |   3.55 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    116.90 ns |  0.1177 ns |  0.1101 ns |   3.31 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    110.67 ns |  0.0447 ns |  0.0418 ns |   3.13 |     0.00 |
|                                                 LinqCount |              5 |     42.11 ns |  0.0472 ns |  0.0368 ns |   1.19 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     36.10 ns |  0.0193 ns |  0.0161 ns |   1.02 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     35.36 ns |  0.0142 ns |  0.0102 ns |   1.00 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     25.98 ns |  0.0672 ns |  0.0628 ns |   0.74 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     25.90 ns |  0.0096 ns |  0.0080 ns |   0.73 |     0.00 |
|                                               LinqToArray |              5 |     97.81 ns |  0.0498 ns |  0.0360 ns |   2.77 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |     84.46 ns |  0.0218 ns |  0.0170 ns |   2.39 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     84.12 ns |  0.0219 ns |  0.0183 ns |   2.38 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     71.15 ns |  0.2194 ns |  0.2052 ns |   2.02 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     72.71 ns |  0.0236 ns |  0.0209 ns |   2.06 |     0.00 |
|                                                      Take |              5 |    122.71 ns |  0.0411 ns |  0.0321 ns |   3.48 |     0.00 |
|                                               LowCostTake |              5 |     61.34 ns |  0.0191 ns |  0.0159 ns |   1.74 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     59.53 ns |  0.1788 ns |  0.1673 ns |   1.69 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     65.13 ns |  0.0221 ns |  0.0196 ns |   1.84 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     54.84 ns |  0.0040 ns |  0.0035 ns |   1.55 |     0.00 |
|                                            SkipTakeSingle |              5 |    112.86 ns |  0.0161 ns |  0.0126 ns |   3.20 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     52.13 ns |  0.0899 ns |  0.0797 ns |   1.48 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     52.21 ns |  0.0055 ns |  0.0046 ns |   1.48 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     46.81 ns |  0.0290 ns |  0.0271 ns |   1.33 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     46.81 ns |  0.0206 ns |  0.0172 ns |   1.33 |     0.00 |
|                                           ForeachDelegate |              5 |     42.52 ns |  0.1539 ns |  0.1364 ns |   1.20 |     0.00 |
|                                                   Foreach |              5 |     35.30 ns |  0.0111 ns |  0.0099 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **317.95 ns** |  **0.2527 ns** |  **0.1973 ns** |   **1.28** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    260.08 ns |  0.2525 ns |  0.2362 ns |   1.05 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    196.71 ns |  0.3037 ns |  0.2692 ns |   0.79 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    236.80 ns |  0.3093 ns |  0.2742 ns |   0.96 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    223.70 ns |  0.1634 ns |  0.1365 ns |   0.90 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    131.61 ns |  0.0125 ns |  0.0111 ns |   0.53 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    120.33 ns |  0.0300 ns |  0.0250 ns |   0.49 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    594.35 ns |  0.2740 ns |  0.2288 ns |   2.40 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    598.15 ns |  0.2149 ns |  0.1905 ns |   2.42 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    477.20 ns |  0.2361 ns |  0.1843 ns |   1.93 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    473.18 ns |  0.1869 ns |  0.1657 ns |   1.91 |     0.00 |
|                                                 LinqCount |             50 |    122.74 ns |  0.0858 ns |  0.0760 ns |   0.50 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    147.68 ns |  0.0497 ns |  0.0441 ns |   0.60 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    147.20 ns |  0.0224 ns |  0.0175 ns |   0.59 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |     77.25 ns |  0.0112 ns |  0.0099 ns |   0.31 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     77.22 ns |  0.0197 ns |  0.0175 ns |   0.31 |     0.00 |
|                                               LinqToArray |             50 |    375.12 ns |  0.6195 ns |  0.5795 ns |   1.52 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    315.93 ns |  0.4767 ns |  0.4459 ns |   1.28 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    315.06 ns |  0.0743 ns |  0.0621 ns |   1.27 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    219.63 ns |  0.3889 ns |  0.3447 ns |   0.89 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    220.86 ns |  0.0746 ns |  0.0661 ns |   0.89 |     0.00 |
|                                                      Take |             50 |    285.70 ns |  0.1327 ns |  0.1241 ns |   1.15 |     0.00 |
|                                               LowCostTake |             50 |    128.97 ns |  0.0069 ns |  0.0058 ns |   0.52 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    118.92 ns |  0.0636 ns |  0.0564 ns |   0.48 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    100.05 ns |  0.0140 ns |  0.0117 ns |   0.40 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     81.65 ns |  0.0117 ns |  0.0092 ns |   0.33 |     0.00 |
|                                            SkipTakeSingle |             50 |    185.51 ns |  0.2174 ns |  0.2033 ns |   0.75 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    106.17 ns |  0.0140 ns |  0.0117 ns |   0.43 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    105.37 ns |  0.0312 ns |  0.0261 ns |   0.43 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     66.72 ns |  0.0733 ns |  0.0685 ns |   0.27 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     67.34 ns |  0.0382 ns |  0.0357 ns |   0.27 |     0.00 |
|                                           ForeachDelegate |             50 |    287.46 ns |  0.0845 ns |  0.0749 ns |   1.16 |     0.00 |
|                                                   Foreach |             50 |    247.52 ns |  0.0488 ns |  0.0381 ns |   1.00 |     0.00 |
