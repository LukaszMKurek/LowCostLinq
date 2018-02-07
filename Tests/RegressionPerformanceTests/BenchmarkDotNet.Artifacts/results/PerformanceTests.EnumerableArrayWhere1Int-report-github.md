``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|
|                                                      **Linq** |              **0** |     **22.14 ns** |  **0.0060 ns** |  **0.0056 ns** |   **1.72** |
|                                   LowCostLinqWithDelegate |              0 |     33.25 ns |  0.0096 ns |  0.0069 ns |   2.58 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     31.53 ns |  0.0015 ns |  0.0014 ns |   2.45 |
|                                  LowCostLinqWithDelegate2 |              0 |     51.42 ns |  0.0065 ns |  0.0054 ns |   4.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     41.48 ns |  0.0384 ns |  0.0320 ns |   3.22 |
|                                LowCostLinqWithStructWhere |              0 |     36.67 ns |  0.0359 ns |  0.0336 ns |   2.85 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     33.91 ns |  0.0014 ns |  0.0013 ns |   2.64 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     73.93 ns |  0.0753 ns |  0.0705 ns |   5.75 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     73.58 ns |  0.0446 ns |  0.0396 ns |   5.72 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     73.78 ns |  0.0880 ns |  0.0687 ns |   5.73 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     72.42 ns |  0.0259 ns |  0.0242 ns |   5.63 |
|                                                 LinqCount |              0 |     26.13 ns |  0.0066 ns |  0.0055 ns |   2.03 |
|                              LowCostLinqWithDelegateCount |              0 |     23.96 ns |  0.0065 ns |  0.0058 ns |   1.86 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     23.83 ns |  0.0144 ns |  0.0113 ns |   1.85 |
|                           LowCostLinqWithStructWhereCount |              0 |     22.90 ns |  0.0030 ns |  0.0025 ns |   1.78 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     24.34 ns |  0.0056 ns |  0.0044 ns |   1.89 |
|                                               LinqToArray |              0 |     23.73 ns |  0.0071 ns |  0.0067 ns |   1.84 |
|                            LowCostLinqWithDelegateToArray |              0 |     35.81 ns |  0.0427 ns |  0.0379 ns |   2.78 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     35.91 ns |  0.0058 ns |  0.0048 ns |   2.79 |
|                              LowCostLinqWithStructToArray |              0 |     32.89 ns |  0.0541 ns |  0.0506 ns |   2.56 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     32.42 ns |  0.0227 ns |  0.0201 ns |   2.52 |
|                                                      Take |              0 |     25.73 ns |  0.0076 ns |  0.0067 ns |   2.00 |
|                                               LowCostTake |              0 |     41.91 ns |  0.0038 ns |  0.0032 ns |   3.26 |
|                                  LowCostTakeWithoutChecks |              0 |     45.85 ns |  0.0030 ns |  0.0025 ns |   3.56 |
|                                     LowCostTakeWithStruct |              0 |     46.73 ns |  0.0025 ns |  0.0021 ns |   3.63 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     43.91 ns |  0.0102 ns |  0.0096 ns |   3.41 |
|                                            SkipTakeSingle |              0 |     38.16 ns |  0.0181 ns |  0.0160 ns |   2.97 |
|                                     LowCostSkipTakeSingle |              0 |     41.33 ns |  0.0016 ns |  0.0013 ns |   3.21 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     41.33 ns |  0.0021 ns |  0.0018 ns |   3.21 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     43.91 ns |  0.0039 ns |  0.0036 ns |   3.41 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     45.28 ns |  0.0072 ns |  0.0067 ns |   3.52 |
|                                           ForeachDelegate |              0 |     15.60 ns |  0.0020 ns |  0.0019 ns |   1.21 |
|                                                   Foreach |              0 |     12.87 ns |  0.0047 ns |  0.0044 ns |   1.00 |
|                                                           |                |              |            |            |        |
|                                                      **Linq** |           **1000** |  **5,448.60 ns** |  **2.8406 ns** |  **2.5181 ns** |   **1.26** |
|                                   LowCostLinqWithDelegate |           1000 |  3,865.31 ns |  5.9505 ns |  5.5661 ns |   0.90 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  3,142.29 ns |  2.7539 ns |  2.5760 ns |   0.73 |
|                                  LowCostLinqWithDelegate2 |           1000 |  3,636.77 ns | 43.7258 ns | 40.9012 ns |   0.84 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  3,156.91 ns |  1.2716 ns |  1.1895 ns |   0.73 |
|                                LowCostLinqWithStructWhere |           1000 |  1,958.71 ns |  0.8332 ns |  0.6505 ns |   0.45 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,546.06 ns |  0.5406 ns |  0.4792 ns |   0.36 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 10,396.71 ns | 14.2642 ns | 13.3427 ns |   2.41 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 |  9,845.66 ns | 42.4555 ns | 39.7129 ns |   2.28 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  7,755.61 ns |  8.4065 ns |  7.8635 ns |   1.80 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,491.64 ns |  5.5292 ns |  5.1720 ns |   1.74 |
|                                                 LinqCount |           1000 |  1,714.76 ns |  3.2963 ns |  3.0833 ns |   0.40 |
|                              LowCostLinqWithDelegateCount |           1000 |  2,174.86 ns |  0.1653 ns |  0.1546 ns |   0.50 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  2,414.83 ns |  0.7100 ns |  0.6294 ns |   0.56 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,335.02 ns |  0.2104 ns |  0.1757 ns |   0.31 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,336.73 ns |  1.3115 ns |  1.2267 ns |   0.31 |
|                                               LinqToArray |           1000 |  3,361.32 ns | 13.4392 ns | 12.5710 ns |   0.78 |
|                            LowCostLinqWithDelegateToArray |           1000 |  3,927.94 ns |  2.8674 ns |  2.5418 ns |   0.91 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  3,653.64 ns |  6.8081 ns |  6.3683 ns |   0.85 |
|                              LowCostLinqWithStructToArray |           1000 |  2,259.03 ns |  2.8041 ns |  2.6229 ns |   0.52 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,257.89 ns |  3.2093 ns |  2.5056 ns |   0.52 |
|                                                      Take |           1000 |    267.15 ns |  0.1407 ns |  0.1317 ns |   0.06 |
|                                               LowCostTake |           1000 |    130.80 ns |  0.1222 ns |  0.1143 ns |   0.03 |
|                                  LowCostTakeWithoutChecks |           1000 |    115.04 ns |  0.1312 ns |  0.1227 ns |   0.03 |
|                                     LowCostTakeWithStruct |           1000 |     94.05 ns |  0.0136 ns |  0.0127 ns |   0.02 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     82.88 ns |  0.0176 ns |  0.0138 ns |   0.02 |
|                                            SkipTakeSingle |           1000 |    191.12 ns |  0.0551 ns |  0.0488 ns |   0.04 |
|                                     LowCostSkipTakeSingle |           1000 |    100.02 ns |  0.0472 ns |  0.0442 ns |   0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    114.39 ns |  0.0728 ns |  0.0681 ns |   0.03 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     73.03 ns |  0.0721 ns |  0.0675 ns |   0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     64.43 ns |  0.0402 ns |  0.0356 ns |   0.01 |
|                                           ForeachDelegate |           1000 |  5,037.89 ns |  2.1879 ns |  2.0465 ns |   1.17 |
|                                                   Foreach |           1000 |  4,313.67 ns |  0.2545 ns |  0.2125 ns |   1.00 |
|                                                           |                |              |            |            |        |
|                                                      **Linq** |              **5** |     **61.07 ns** |  **0.0775 ns** |  **0.0687 ns** |   **1.77** |
|                                   LowCostLinqWithDelegate |              5 |     54.42 ns |  0.0181 ns |  0.0169 ns |   1.57 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     49.20 ns |  0.1311 ns |  0.1226 ns |   1.42 |
|                                  LowCostLinqWithDelegate2 |              5 |     59.06 ns |  0.0307 ns |  0.0287 ns |   1.71 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     58.40 ns |  0.0134 ns |  0.0112 ns |   1.69 |
|                                LowCostLinqWithStructWhere |              5 |     49.47 ns |  0.0270 ns |  0.0226 ns |   1.43 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     43.63 ns |  0.0136 ns |  0.0127 ns |   1.26 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    127.34 ns |  0.1182 ns |  0.1106 ns |   3.68 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    124.09 ns |  0.0497 ns |  0.0465 ns |   3.59 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    115.47 ns |  0.2346 ns |  0.2194 ns |   3.34 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    111.69 ns |  0.1055 ns |  0.0987 ns |   3.23 |
|                                                 LinqCount |              5 |     42.60 ns |  0.0239 ns |  0.0224 ns |   1.23 |
|                              LowCostLinqWithDelegateCount |              5 |     35.43 ns |  0.0081 ns |  0.0072 ns |   1.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     36.02 ns |  0.0150 ns |  0.0125 ns |   1.04 |
|                           LowCostLinqWithStructWhereCount |              5 |     25.93 ns |  0.0104 ns |  0.0097 ns |   0.75 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     26.15 ns |  0.0103 ns |  0.0096 ns |   0.76 |
|                                               LinqToArray |              5 |     97.43 ns |  0.0350 ns |  0.0327 ns |   2.82 |
|                            LowCostLinqWithDelegateToArray |              5 |     83.65 ns |  0.1004 ns |  0.0890 ns |   2.42 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     82.95 ns |  0.0346 ns |  0.0324 ns |   2.40 |
|                              LowCostLinqWithStructToArray |              5 |     70.93 ns |  0.0688 ns |  0.0644 ns |   2.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     70.96 ns |  0.0139 ns |  0.0108 ns |   2.05 |
|                                                      Take |              5 |    119.65 ns |  0.0333 ns |  0.0295 ns |   3.46 |
|                                               LowCostTake |              5 |     60.32 ns |  0.0047 ns |  0.0039 ns |   1.74 |
|                                  LowCostTakeWithoutChecks |              5 |     59.33 ns |  0.1830 ns |  0.1712 ns |   1.72 |
|                                     LowCostTakeWithStruct |              5 |     59.12 ns |  0.0197 ns |  0.0184 ns |   1.71 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     54.01 ns |  0.0178 ns |  0.0167 ns |   1.56 |
|                                            SkipTakeSingle |              5 |    111.62 ns |  0.0246 ns |  0.0218 ns |   3.23 |
|                                     LowCostSkipTakeSingle |              5 |     51.46 ns |  0.0079 ns |  0.0066 ns |   1.49 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     51.79 ns |  0.0075 ns |  0.0058 ns |   1.50 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     46.99 ns |  0.0126 ns |  0.0118 ns |   1.36 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     46.77 ns |  0.0141 ns |  0.0118 ns |   1.35 |
|                                           ForeachDelegate |              5 |     41.81 ns |  0.0106 ns |  0.0099 ns |   1.21 |
|                                                   Foreach |              5 |     34.57 ns |  0.0085 ns |  0.0079 ns |   1.00 |
|                                                           |                |              |            |            |        |
|                                                      **Linq** |             **50** |    **317.65 ns** |  **0.0689 ns** |  **0.0611 ns** |   **1.34** |
|                                   LowCostLinqWithDelegate |             50 |    227.07 ns |  1.9264 ns |  1.8020 ns |   0.96 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    193.96 ns |  0.0484 ns |  0.0404 ns |   0.82 |
|                                  LowCostLinqWithDelegate2 |             50 |    222.12 ns |  0.2813 ns |  0.2631 ns |   0.94 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    205.12 ns |  0.0305 ns |  0.0270 ns |   0.87 |
|                                LowCostLinqWithStructWhere |             50 |    137.71 ns |  0.0688 ns |  0.0497 ns |   0.58 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    123.75 ns |  0.0228 ns |  0.0213 ns |   0.52 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    600.88 ns |  0.0897 ns |  0.0796 ns |   2.54 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    571.42 ns |  0.2179 ns |  0.1932 ns |   2.42 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    470.66 ns |  0.3725 ns |  0.3485 ns |   1.99 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    451.40 ns |  0.0808 ns |  0.0675 ns |   1.91 |
|                                                 LinqCount |             50 |    123.49 ns |  0.1594 ns |  0.1491 ns |   0.52 |
|                              LowCostLinqWithDelegateCount |             50 |    136.28 ns |  0.0177 ns |  0.0148 ns |   0.58 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    147.59 ns |  0.0553 ns |  0.0462 ns |   0.62 |
|                           LowCostLinqWithStructWhereCount |             50 |     77.16 ns |  0.1297 ns |  0.1214 ns |   0.33 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     77.87 ns |  0.0091 ns |  0.0076 ns |   0.33 |
|                                               LinqToArray |             50 |    406.22 ns |  1.3057 ns |  1.1574 ns |   1.72 |
|                            LowCostLinqWithDelegateToArray |             50 |    317.04 ns |  0.1117 ns |  0.0990 ns |   1.34 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    304.75 ns |  0.2173 ns |  0.1926 ns |   1.29 |
|                              LowCostLinqWithStructToArray |             50 |    225.14 ns |  0.2662 ns |  0.2490 ns |   0.95 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    220.90 ns |  0.2991 ns |  0.2797 ns |   0.93 |
|                                                      Take |             50 |    266.78 ns |  0.0835 ns |  0.0697 ns |   1.13 |
|                                               LowCostTake |             50 |    130.49 ns |  0.1327 ns |  0.1241 ns |   0.55 |
|                                  LowCostTakeWithoutChecks |             50 |    121.29 ns |  0.1981 ns |  0.1853 ns |   0.51 |
|                                     LowCostTakeWithStruct |             50 |     95.87 ns |  0.0262 ns |  0.0205 ns |   0.41 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     81.74 ns |  0.0283 ns |  0.0251 ns |   0.35 |
|                                            SkipTakeSingle |             50 |    187.72 ns |  0.0679 ns |  0.0602 ns |   0.79 |
|                                     LowCostSkipTakeSingle |             50 |     99.65 ns |  0.0228 ns |  0.0178 ns |   0.42 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    114.64 ns |  0.2335 ns |  0.2184 ns |   0.49 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     64.74 ns |  0.0262 ns |  0.0245 ns |   0.27 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     64.03 ns |  0.0346 ns |  0.0324 ns |   0.27 |
|                                           ForeachDelegate |             50 |    274.67 ns |  0.1378 ns |  0.1151 ns |   1.16 |
|                                                   Foreach |             50 |    236.27 ns |  0.2426 ns |  0.2269 ns |   1.00 |
