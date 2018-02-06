``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **63.63 ns** |  **0.6187 ns** |  **0.5788 ns** |     **63.35 ns** |   **3.82** |     **0.04** |
|                                   LowCostLinqWithDelegate |              0 |     38.17 ns |  0.0114 ns |  0.0095 ns |     38.17 ns |   2.29 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     31.41 ns |  0.0134 ns |  0.0119 ns |     31.41 ns |   1.89 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     55.93 ns |  0.0078 ns |  0.0065 ns |     55.93 ns |   3.36 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     47.67 ns |  0.1715 ns |  0.1604 ns |     47.57 ns |   2.86 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     43.02 ns |  0.0113 ns |  0.0100 ns |     43.02 ns |   2.58 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     38.41 ns |  0.0020 ns |  0.0017 ns |     38.41 ns |   2.31 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     92.08 ns |  0.8861 ns |  0.8288 ns |     91.63 ns |   5.53 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     85.28 ns |  0.0480 ns |  0.0375 ns |     85.27 ns |   5.12 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     75.01 ns |  0.0291 ns |  0.0258 ns |     75.00 ns |   4.51 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     68.55 ns |  0.1743 ns |  0.1630 ns |     68.47 ns |   4.12 |     0.02 |
|                                                 LinqCount |              0 |     61.72 ns |  0.5041 ns |  0.4715 ns |     61.35 ns |   3.71 |     0.03 |
|                              LowCostLinqWithDelegateCount |              0 |     35.71 ns |  0.0168 ns |  0.0131 ns |     35.72 ns |   2.15 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     34.63 ns |  0.0273 ns |  0.0255 ns |     34.62 ns |   2.08 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     42.54 ns |  0.0076 ns |  0.0071 ns |     42.54 ns |   2.56 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     29.80 ns |  0.1764 ns |  0.1650 ns |     29.66 ns |   1.79 |     0.01 |
|                                               LinqToArray |              0 |     72.66 ns |  0.1161 ns |  0.1086 ns |     72.64 ns |   4.37 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              0 |     46.80 ns |  0.0327 ns |  0.0306 ns |     46.79 ns |   2.81 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     44.85 ns |  0.0445 ns |  0.0417 ns |     44.84 ns |   2.69 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     45.73 ns |  0.0102 ns |  0.0085 ns |     45.73 ns |   2.75 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     38.65 ns |  0.0405 ns |  0.0379 ns |     38.63 ns |   2.32 |     0.01 |
|                                                      Take |              0 |    102.80 ns |  0.0085 ns |  0.0066 ns |    102.80 ns |   6.18 |     0.02 |
|                                               LowCostTake |              0 |     47.42 ns |  0.1580 ns |  0.1400 ns |     47.35 ns |   2.85 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     39.37 ns |  0.0039 ns |  0.0035 ns |     39.37 ns |   2.36 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     48.56 ns |  0.0101 ns |  0.0073 ns |     48.56 ns |   2.92 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     47.43 ns |  0.1069 ns |  0.1000 ns |     47.41 ns |   2.85 |     0.01 |
|                                            SkipTakeSingle |              0 |    121.95 ns |  0.1681 ns |  0.1490 ns |    121.90 ns |   7.33 |     0.03 |
|                                     LowCostSkipTakeSingle |              0 |     51.62 ns |  0.0049 ns |  0.0041 ns |     51.62 ns |   3.10 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     49.00 ns |  0.0331 ns |  0.0277 ns |     48.99 ns |   2.94 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     59.32 ns |  0.0136 ns |  0.0121 ns |     59.32 ns |   3.56 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     52.73 ns |  0.0103 ns |  0.0091 ns |     52.73 ns |   3.17 |     0.01 |
|                                           ForeachDelegate |              0 |     18.83 ns |  0.0106 ns |  0.0088 ns |     18.83 ns |   1.13 |     0.00 |
|                                                   Foreach |              0 |     16.65 ns |  0.0632 ns |  0.0560 ns |     16.63 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **1000** |  **9,694.11 ns** | **10.6322 ns** |  **9.4252 ns** |  **9,689.00 ns** |   **1.92** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  6,743.54 ns | 46.0362 ns | 43.0623 ns |  6,752.06 ns |   1.34 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,255.47 ns | 42.4498 ns | 39.7076 ns |  5,237.31 ns |   1.04 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           1000 |  7,201.32 ns |  4.1402 ns |  3.8727 ns |  7,201.84 ns |   1.43 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  6,256.20 ns |  1.6739 ns |  1.3977 ns |  6,255.52 ns |   1.24 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,692.39 ns | 17.0395 ns | 15.9388 ns |  2,684.83 ns |   0.53 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,747.49 ns |  0.4267 ns |  0.3563 ns |  1,747.58 ns |   0.35 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 19,003.22 ns | 12.0799 ns | 11.2995 ns | 19,004.57 ns |   3.77 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 18,395.24 ns | 90.9236 ns | 85.0500 ns | 18,406.89 ns |   3.65 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,464.32 ns |  7.4518 ns |  6.6058 ns |  8,463.75 ns |   1.68 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,498.20 ns |  2.9030 ns |  2.5735 ns |  7,497.88 ns |   1.49 |     0.00 |
|                                                 LinqCount |           1000 |  3,908.32 ns |  6.2613 ns |  5.8568 ns |  3,905.59 ns |   0.77 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  5,290.62 ns | 28.4022 ns | 26.5674 ns |  5,289.90 ns |   1.05 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  5,013.72 ns | 16.6082 ns | 15.5353 ns |  5,012.75 ns |   0.99 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,738.02 ns |  0.9882 ns |  0.9244 ns |  1,738.08 ns |   0.34 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,226.62 ns |  0.0538 ns |  0.0420 ns |  1,226.62 ns |   0.24 |     0.00 |
|                                               LinqToArray |           1000 |  5,955.33 ns | 29.0057 ns | 27.1319 ns |  5,941.80 ns |   1.18 |     0.01 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,689.84 ns | 10.2229 ns |  9.0623 ns |  7,687.16 ns |   1.52 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  5,635.52 ns |  5.1928 ns |  4.6033 ns |  5,636.61 ns |   1.12 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,202.74 ns |  8.0352 ns |  7.5162 ns |  3,200.39 ns |   0.63 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,359.12 ns |  4.7682 ns |  4.2269 ns |  2,359.92 ns |   0.47 |     0.00 |
|                                                      Take |           1000 |    396.82 ns |  0.0818 ns |  0.0765 ns |    396.81 ns |   0.08 |     0.00 |
|                                               LowCostTake |           1000 |    185.36 ns |  0.1222 ns |  0.1143 ns |    185.39 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    162.80 ns |  0.8289 ns |  0.7754 ns |    162.90 ns |   0.03 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    115.02 ns |  0.0363 ns |  0.0303 ns |    115.02 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    102.28 ns |  0.0184 ns |  0.0172 ns |    102.28 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    305.50 ns |  2.1830 ns |  2.0420 ns |    305.70 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    177.37 ns |  0.0222 ns |  0.0186 ns |    177.37 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    172.66 ns |  0.0404 ns |  0.0359 ns |    172.66 ns |   0.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    101.24 ns |  0.0319 ns |  0.0298 ns |    101.24 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     73.69 ns |  0.4697 ns |  0.4394 ns |     73.42 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |           1000 |  8,373.19 ns | 29.1409 ns | 25.8327 ns |  8,373.58 ns |   1.66 |     0.01 |
|                                                   Foreach |           1000 |  5,044.58 ns |  6.2174 ns |  5.8157 ns |  5,045.97 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |              **5** |    **112.57 ns** |  **0.0988 ns** |  **0.0825 ns** |    **112.55 ns** |   **2.67** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     68.21 ns |  0.0745 ns |  0.0697 ns |     68.18 ns |   1.62 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     54.07 ns |  0.0417 ns |  0.0326 ns |     54.06 ns |   1.28 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     78.80 ns |  0.0476 ns |  0.0446 ns |     78.80 ns |   1.87 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     72.60 ns |  0.0775 ns |  0.0687 ns |     72.61 ns |   1.72 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     56.01 ns |  0.0052 ns |  0.0040 ns |     56.01 ns |   1.33 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     49.54 ns |  0.0251 ns |  0.0235 ns |     49.54 ns |   1.17 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    199.78 ns |  0.2334 ns |  0.1822 ns |    199.76 ns |   4.73 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    190.09 ns |  0.0905 ns |  0.0847 ns |    190.06 ns |   4.50 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    120.56 ns |  1.7617 ns |  1.5617 ns |    120.39 ns |   2.86 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    108.34 ns |  0.0603 ns |  0.0534 ns |    108.33 ns |   2.57 |     0.00 |
|                                                 LinqCount |              5 |     80.95 ns |  0.2335 ns |  0.2184 ns |     80.94 ns |   1.92 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     62.27 ns |  0.1219 ns |  0.1140 ns |     62.21 ns |   1.48 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     57.82 ns |  0.0248 ns |  0.0232 ns |     57.82 ns |   1.37 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     45.89 ns |  0.0140 ns |  0.0117 ns |     45.89 ns |   1.09 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     33.25 ns |  0.0145 ns |  0.0136 ns |     33.24 ns |   0.79 |     0.00 |
|                                               LinqToArray |              5 |    143.59 ns |  1.4262 ns |  1.3340 ns |    144.08 ns |   3.40 |     0.03 |
|                            LowCostLinqWithDelegateToArray |              5 |    112.52 ns |  0.0955 ns |  0.0893 ns |    112.56 ns |   2.67 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    103.47 ns |  0.2213 ns |  0.1962 ns |    103.45 ns |   2.45 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     91.15 ns |  1.4030 ns |  1.3124 ns |     90.36 ns |   2.16 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     83.88 ns |  0.1183 ns |  0.1107 ns |     83.83 ns |   1.99 |     0.00 |
|                                                      Take |              5 |    174.12 ns |  0.1235 ns |  0.1155 ns |    174.09 ns |   4.13 |     0.00 |
|                                               LowCostTake |              5 |     72.72 ns |  0.0623 ns |  0.0583 ns |     72.74 ns |   1.72 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     77.77 ns |  0.3934 ns |  0.3680 ns |     77.84 ns |   1.84 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     64.49 ns |  0.0098 ns |  0.0087 ns |     64.49 ns |   1.53 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     58.11 ns |  0.0355 ns |  0.0332 ns |     58.10 ns |   1.38 |     0.00 |
|                                            SkipTakeSingle |              5 |    163.51 ns |  0.2415 ns |  0.2259 ns |    163.59 ns |   3.87 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |     75.91 ns |  0.0095 ns |  0.0079 ns |     75.91 ns |   1.80 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     79.77 ns |  0.0186 ns |  0.0174 ns |     79.77 ns |   1.89 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     68.60 ns |  0.0179 ns |  0.0140 ns |     68.60 ns |   1.63 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     55.79 ns |  0.3252 ns |  0.3042 ns |     55.61 ns |   1.32 |     0.01 |
|                                           ForeachDelegate |              5 |     60.37 ns |  0.0527 ns |  0.0467 ns |     60.38 ns |   1.43 |     0.00 |
|                                                   Foreach |              5 |     42.21 ns |  0.0207 ns |  0.0173 ns |     42.21 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |             **50** |    **555.37 ns** |  **0.4834 ns** |  **0.4522 ns** |    **555.57 ns** |   **2.01** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    386.61 ns |  2.6448 ns |  2.4740 ns |    386.55 ns |   1.40 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    294.19 ns |  0.0904 ns |  0.0755 ns |    294.20 ns |   1.06 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    398.20 ns |  0.1569 ns |  0.1391 ns |    398.18 ns |   1.44 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    357.94 ns |  0.0847 ns |  0.0613 ns |    357.93 ns |   1.29 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    179.86 ns |  0.0266 ns |  0.0236 ns |    179.85 ns |   0.65 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    132.68 ns |  0.0462 ns |  0.0409 ns |    132.69 ns |   0.48 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,049.50 ns |  0.4312 ns |  0.4033 ns |  1,049.51 ns |   3.79 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,020.61 ns |  1.7360 ns |  1.6239 ns |  1,020.85 ns |   3.69 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    505.21 ns |  3.6626 ns |  3.2468 ns |    503.31 ns |   1.83 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    452.92 ns |  0.1489 ns |  0.1393 ns |    452.97 ns |   1.64 |     0.00 |
|                                                 LinqCount |             50 |    259.19 ns |  0.2107 ns |  0.1971 ns |    259.06 ns |   0.94 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    303.80 ns |  0.3184 ns |  0.2659 ns |    303.83 ns |   1.10 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    287.70 ns |  1.6152 ns |  1.4318 ns |    287.07 ns |   1.04 |     0.01 |
|                           LowCostLinqWithStructWhereCount |             50 |    128.63 ns |  0.0444 ns |  0.0393 ns |    128.63 ns |   0.46 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     82.81 ns |  0.0241 ns |  0.0160 ns |     82.80 ns |   0.30 |     0.00 |
|                                               LinqToArray |             50 |    552.05 ns |  0.7819 ns |  0.7314 ns |    551.67 ns |   2.00 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    521.01 ns |  4.6576 ns |  4.3568 ns |    518.42 ns |   1.88 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    436.84 ns |  0.2763 ns |  0.2585 ns |    436.88 ns |   1.58 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    291.88 ns |  0.3639 ns |  0.3404 ns |    291.93 ns |   1.06 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    236.91 ns |  0.1437 ns |  0.1274 ns |    236.87 ns |   0.86 |     0.00 |
|                                                      Take |             50 |    399.85 ns |  3.8577 ns |  3.6085 ns |    397.85 ns |   1.45 |     0.01 |
|                                               LowCostTake |             50 |    185.02 ns |  0.0677 ns |  0.0565 ns |    185.03 ns |   0.67 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    161.48 ns |  0.0173 ns |  0.0153 ns |    161.48 ns |   0.58 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    119.75 ns |  0.9899 ns |  0.9259 ns |    119.24 ns |   0.43 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     89.92 ns |  0.0253 ns |  0.0237 ns |     89.92 ns |   0.33 |     0.00 |
|                                            SkipTakeSingle |             50 |    299.71 ns |  0.3225 ns |  0.2859 ns |    299.65 ns |   1.08 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    187.03 ns |  0.0272 ns |  0.0241 ns |    187.03 ns |   0.68 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    172.85 ns |  0.8889 ns |  0.8314 ns |    172.53 ns |   0.62 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     99.88 ns |  0.0135 ns |  0.0120 ns |     99.87 ns |   0.36 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     76.79 ns |  0.0274 ns |  0.0228 ns |     76.79 ns |   0.28 |     0.00 |
|                                           ForeachDelegate |             50 |    441.76 ns |  3.7455 ns |  3.5036 ns |    439.82 ns |   1.60 |     0.01 |
|                                                   Foreach |             50 |    276.67 ns |  0.2240 ns |  0.2096 ns |    276.55 ns |   1.00 |     0.00 |
