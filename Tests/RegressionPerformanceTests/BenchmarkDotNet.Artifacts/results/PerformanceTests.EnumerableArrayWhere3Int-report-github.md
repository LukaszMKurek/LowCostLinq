``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **77.34 ns** |   **0.0407 ns** |   **0.0340 ns** |     **77.33 ns** |   **6.71** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     35.74 ns |   0.0114 ns |   0.0089 ns |     35.74 ns |   3.10 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     37.07 ns |   0.0042 ns |   0.0039 ns |     37.07 ns |   3.22 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     70.78 ns |   0.0027 ns |   0.0025 ns |     70.78 ns |   6.14 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     59.44 ns |   0.0047 ns |   0.0042 ns |     59.44 ns |   5.16 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     47.35 ns |   0.1010 ns |   0.0945 ns |     47.29 ns |   4.11 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     47.53 ns |   0.0010 ns |   0.0009 ns |     47.53 ns |   4.12 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     99.94 ns |   0.0537 ns |   0.0476 ns |     99.93 ns |   8.67 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     94.99 ns |   0.1530 ns |   0.1357 ns |     95.02 ns |   8.24 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     84.76 ns |   0.8323 ns |   0.7378 ns |     84.39 ns |   7.35 |     0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     81.64 ns |   0.0847 ns |   0.0793 ns |     81.63 ns |   7.08 |     0.01 |
|                                                 LinqCount |            [0] |     76.73 ns |   0.0464 ns |   0.0412 ns |     76.74 ns |   6.66 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     37.75 ns |   0.0024 ns |   0.0021 ns |     37.75 ns |   3.27 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     36.89 ns |   0.3861 ns |   0.3612 ns |     36.70 ns |   3.20 |     0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.83 ns |   0.0014 ns |   0.0011 ns |     37.83 ns |   3.28 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     37.34 ns |   0.0145 ns |   0.0135 ns |     37.34 ns |   3.24 |     0.00 |
|                                               LinqToArray |            [0] |     92.16 ns |   0.0201 ns |   0.0178 ns |     92.16 ns |   8.00 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     48.41 ns |   0.0976 ns |   0.0913 ns |     48.44 ns |   4.20 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     48.27 ns |   0.0111 ns |   0.0104 ns |     48.27 ns |   4.19 |     0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     47.53 ns |   0.6499 ns |   0.6079 ns |     47.10 ns |   4.12 |     0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     48.96 ns |   0.0133 ns |   0.0124 ns |     48.96 ns |   4.25 |     0.00 |
|                                                      Take |            [0] |    109.17 ns |   0.0347 ns |   0.0325 ns |    109.17 ns |   9.47 |     0.00 |
|                                               LowCostTake |            [0] |     46.35 ns |   0.5210 ns |   0.4873 ns |     45.97 ns |   4.02 |     0.04 |
|                                  LowCostTakeWithoutChecks |            [0] |     44.87 ns |   0.0225 ns |   0.0210 ns |     44.87 ns |   3.89 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     53.86 ns |   0.0049 ns |   0.0041 ns |     53.86 ns |   4.67 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     57.63 ns |   0.0061 ns |   0.0054 ns |     57.63 ns |   5.00 |     0.00 |
|                                            SkipTakeSingle |            [0] |    133.22 ns |   0.0278 ns |   0.0246 ns |    133.22 ns |  11.56 |     0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     54.77 ns |   0.0063 ns |   0.0059 ns |     54.77 ns |   4.75 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     56.65 ns |   0.0062 ns |   0.0052 ns |     56.65 ns |   4.91 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     59.70 ns |   0.8505 ns |   0.7956 ns |     59.85 ns |   5.18 |     0.07 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     59.02 ns |   0.0037 ns |   0.0033 ns |     59.02 ns |   5.12 |     0.00 |
|                                           ForeachDelegate |            [0] |     14.99 ns |   0.0073 ns |   0.0061 ns |     14.99 ns |   1.30 |     0.00 |
|                                                   Foreach |            [0] |     11.53 ns |   0.0005 ns |   0.0004 ns |     11.53 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **10,849.78 ns** | **159.9445 ns** | **149.6121 ns** | **10,785.57 ns** |   **2.67** |     **0.04** |
|                                   LowCostLinqWithDelegate |         [1000] |  9,004.67 ns |  21.0857 ns |  19.7235 ns |  9,011.07 ns |   2.21 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,934.33 ns |  23.3507 ns |  21.8422 ns |  8,939.20 ns |   2.20 |     0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,308.85 ns |  32.1438 ns |  30.0673 ns |  8,302.46 ns |   2.04 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,260.38 ns |  27.0221 ns |  25.2765 ns |  8,262.34 ns |   2.03 |     0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,966.91 ns |  33.7904 ns |  31.6076 ns |  1,971.72 ns |   0.48 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,560.14 ns |   0.2444 ns |   0.2041 ns |  1,560.03 ns |   0.38 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 21,905.82 ns |  30.7059 ns |  28.7223 ns | 21,904.65 ns |   5.39 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 20,957.33 ns |  94.4947 ns |  83.7671 ns | 20,925.44 ns |   5.16 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  7,921.39 ns |  65.7648 ns |  58.2988 ns |  7,897.41 ns |   1.95 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,032.64 ns |  18.4379 ns |  17.2468 ns |  8,028.93 ns |   1.98 |     0.00 |
|                                                 LinqCount |         [1000] |  6,613.97 ns |  21.5263 ns |  17.9755 ns |  6,616.30 ns |   1.63 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,051.86 ns |  85.0614 ns |  79.5665 ns |  7,000.79 ns |   1.73 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,977.32 ns |   0.3392 ns |   0.3173 ns |  6,977.23 ns |   1.72 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,381.72 ns |   7.1161 ns |   6.6564 ns |  1,385.55 ns |   0.34 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,370.62 ns |   0.0641 ns |   0.0599 ns |  1,370.62 ns |   0.34 |     0.00 |
|                                               LinqToArray |         [1000] |  8,125.21 ns |   6.0537 ns |   5.0551 ns |  8,124.22 ns |   2.00 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,175.56 ns |   3.0793 ns |   2.7297 ns |  9,175.97 ns |   2.26 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,606.77 ns |   4.2094 ns |   3.7315 ns |  8,606.69 ns |   2.12 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,235.48 ns |   0.6427 ns |   0.6012 ns |  2,235.54 ns |   0.55 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,285.01 ns |  36.1357 ns |  33.8014 ns |  2,284.73 ns |   0.56 |     0.01 |
|                                                      Take |         [1000] |    415.87 ns |   0.1063 ns |   0.0994 ns |    415.87 ns |   0.10 |     0.00 |
|                                               LowCostTake |         [1000] |    231.24 ns |   0.5321 ns |   0.4977 ns |    231.44 ns |   0.06 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    211.06 ns |   4.0033 ns |   3.7447 ns |    208.59 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    108.36 ns |   0.0320 ns |   0.0299 ns |    108.37 ns |   0.03 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     96.19 ns |   0.0175 ns |   0.0164 ns |     96.19 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    344.22 ns |   5.1386 ns |   4.8067 ns |    340.56 ns |   0.08 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    244.13 ns |   0.0108 ns |   0.0101 ns |    244.13 ns |   0.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    230.52 ns |   0.1335 ns |   0.1248 ns |    230.55 ns |   0.06 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     83.98 ns |   0.0378 ns |   0.0353 ns |     83.97 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     84.42 ns |   0.0271 ns |   0.0240 ns |     84.42 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |         [1000] |  7,946.31 ns |   3.7949 ns |   2.9628 ns |  7,946.71 ns |   1.95 |     0.00 |
|                                                   Foreach |         [1000] |  4,065.32 ns |   0.3519 ns |   0.3292 ns |  4,065.30 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **624.72 ns** |   **0.1844 ns** |   **0.1724 ns** |    **624.69 ns** |   **2.80** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    490.64 ns |   5.0688 ns |   4.4934 ns |    492.03 ns |   2.20 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    490.36 ns |   0.9210 ns |   0.8615 ns |    489.90 ns |   2.20 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    475.19 ns |   0.3764 ns |   0.3520 ns |    475.17 ns |   2.13 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    472.26 ns |   0.0353 ns |   0.0276 ns |    472.27 ns |   2.11 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    150.67 ns |   1.5241 ns |   1.4256 ns |    150.40 ns |   0.67 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    131.79 ns |   0.0271 ns |   0.0212 ns |    131.79 ns |   0.59 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,207.16 ns |   2.3108 ns |   2.1615 ns |  1,207.20 ns |   5.41 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,154.73 ns |   3.7555 ns |   3.5129 ns |  1,153.82 ns |   5.17 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    486.38 ns |   0.1089 ns |   0.1018 ns |    486.40 ns |   2.18 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    484.72 ns |   1.1588 ns |   0.9676 ns |    484.31 ns |   2.17 |     0.00 |
|                                                 LinqCount |           [50] |    409.58 ns |   0.1873 ns |   0.1660 ns |    409.56 ns |   1.83 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    385.36 ns |   0.0183 ns |   0.0153 ns |    385.36 ns |   1.73 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    388.66 ns |   4.7352 ns |   4.4293 ns |    385.82 ns |   1.74 |     0.02 |
|                           LowCostLinqWithStructWhereCount |           [50] |    101.38 ns |   1.1417 ns |   1.0680 ns |    101.89 ns |   0.45 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    101.06 ns |   1.2535 ns |   1.1725 ns |    101.73 ns |   0.45 |     0.01 |
|                                               LinqToArray |           [50] |    682.50 ns |   0.3949 ns |   0.3297 ns |    682.56 ns |   3.06 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    597.28 ns |   0.3520 ns |   0.3293 ns |    597.19 ns |   2.67 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    562.21 ns |   0.3623 ns |   0.3212 ns |    562.31 ns |   2.52 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    216.04 ns |   0.0666 ns |   0.0520 ns |    216.04 ns |   0.97 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    215.90 ns |   3.6535 ns |   3.4175 ns |    213.41 ns |   0.97 |     0.01 |
|                                                      Take |           [50] |    417.58 ns |   0.4948 ns |   0.4629 ns |    417.78 ns |   1.87 |     0.00 |
|                                               LowCostTake |           [50] |    230.54 ns |   0.1029 ns |   0.0963 ns |    230.50 ns |   1.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    209.00 ns |   0.5232 ns |   0.4369 ns |    209.21 ns |   0.94 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    106.07 ns |   0.0117 ns |   0.0109 ns |    106.07 ns |   0.47 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     95.11 ns |   0.0349 ns |   0.0326 ns |     95.11 ns |   0.43 |     0.00 |
|                                            SkipTakeSingle |           [50] |    342.06 ns |   5.0741 ns |   4.7464 ns |    339.61 ns |   1.53 |     0.02 |
|                                     LowCostSkipTakeSingle |           [50] |    244.76 ns |   0.5258 ns |   0.4918 ns |    245.04 ns |   1.10 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    230.65 ns |   0.0183 ns |   0.0152 ns |    230.65 ns |   1.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     85.19 ns |   0.0678 ns |   0.0634 ns |     85.19 ns |   0.38 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     84.37 ns |   0.0967 ns |   0.0857 ns |     84.40 ns |   0.38 |     0.00 |
|                                           ForeachDelegate |           [50] |    425.80 ns |   0.7144 ns |   0.6683 ns |    425.69 ns |   1.91 |     0.00 |
|                                                   Foreach |           [50] |    223.32 ns |   0.0664 ns |   0.0519 ns |    223.32 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |    **136.70 ns** |   **2.4838 ns** |   **2.3234 ns** |    **137.49 ns** |   **4.28** |     **0.07** |
|                                   LowCostLinqWithDelegate |            [5] |     79.34 ns |   0.0384 ns |   0.0300 ns |     79.33 ns |   2.48 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     75.39 ns |   0.0674 ns |   0.0630 ns |     75.39 ns |   2.36 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    100.35 ns |   0.0953 ns |   0.0845 ns |    100.34 ns |   3.14 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     94.57 ns |   0.0638 ns |   0.0565 ns |     94.53 ns |   2.96 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     58.12 ns |   0.0308 ns |   0.0288 ns |     58.12 ns |   1.82 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     57.39 ns |   0.0334 ns |   0.0261 ns |     57.40 ns |   1.80 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    222.33 ns |   0.0977 ns |   0.0866 ns |    222.33 ns |   6.96 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    210.65 ns |   0.1871 ns |   0.1750 ns |    210.60 ns |   6.60 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    124.83 ns |   0.0312 ns |   0.0243 ns |    124.83 ns |   3.91 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    123.20 ns |   2.1211 ns |   1.9840 ns |    123.20 ns |   3.86 |     0.06 |
|                                                 LinqCount |            [5] |    115.99 ns |   0.0238 ns |   0.0211 ns |    115.99 ns |   3.63 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     69.34 ns |   0.0357 ns |   0.0298 ns |     69.35 ns |   2.17 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     69.25 ns |   0.1990 ns |   0.1861 ns |     69.29 ns |   2.17 |     0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     41.55 ns |   0.5172 ns |   0.4838 ns |     41.25 ns |   1.30 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     40.98 ns |   0.0249 ns |   0.0233 ns |     40.98 ns |   1.28 |     0.00 |
|                                               LinqToArray |            [5] |    176.67 ns |   0.0848 ns |   0.0662 ns |    176.69 ns |   5.53 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    118.00 ns |   0.0603 ns |   0.0534 ns |    117.99 ns |   3.70 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    117.97 ns |   1.5351 ns |   1.4360 ns |    117.12 ns |   3.69 |     0.04 |
|                              LowCostLinqWithStructToArray |            [5] |     81.73 ns |   0.0107 ns |   0.0095 ns |     81.73 ns |   2.56 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     80.65 ns |   0.0271 ns |   0.0211 ns |     80.66 ns |   2.53 |     0.00 |
|                                                      Take |            [5] |    202.10 ns |   0.1244 ns |   0.0971 ns |    202.11 ns |   6.33 |     0.01 |
|                                               LowCostTake |            [5] |     82.06 ns |   0.0113 ns |   0.0088 ns |     82.06 ns |   2.57 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     78.94 ns |   0.0674 ns |   0.0630 ns |     78.91 ns |   2.47 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     67.48 ns |   0.0398 ns |   0.0332 ns |     67.49 ns |   2.11 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     66.98 ns |   0.4141 ns |   0.3873 ns |     66.74 ns |   2.10 |     0.01 |
|                                            SkipTakeSingle |            [5] |    185.39 ns |   0.0472 ns |   0.0441 ns |    185.38 ns |   5.81 |     0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     97.81 ns |   0.0711 ns |   0.0665 ns |     97.78 ns |   3.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     89.63 ns |   0.0886 ns |   0.0692 ns |     89.61 ns |   2.81 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     64.61 ns |   0.7466 ns |   0.6983 ns |     64.62 ns |   2.02 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     63.70 ns |   0.0536 ns |   0.0448 ns |     63.67 ns |   1.99 |     0.00 |
|                                           ForeachDelegate |            [5] |     56.07 ns |   0.0077 ns |   0.0065 ns |     56.06 ns |   1.76 |     0.00 |
|                                                   Foreach |            [5] |     31.93 ns |   0.0250 ns |   0.0234 ns |     31.92 ns |   1.00 |     0.00 |
