``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **36.47 ns** |   **0.0403 ns** |   **0.0377 ns** |   **2.20** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     34.43 ns |   0.0072 ns |   0.0052 ns |   2.08 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     28.62 ns |   0.0010 ns |   0.0008 ns |   1.73 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     52.37 ns |   0.0069 ns |   0.0065 ns |   3.16 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     37.70 ns |   0.0075 ns |   0.0058 ns |   2.28 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     36.41 ns |   0.0243 ns |   0.0216 ns |   2.20 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     30.76 ns |   0.0010 ns |   0.0008 ns |   1.86 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     73.06 ns |   0.0253 ns |   0.0211 ns |   4.41 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     68.17 ns |   0.0180 ns |   0.0150 ns |   4.12 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     73.87 ns |   0.0430 ns |   0.0402 ns |   4.46 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     66.69 ns |   0.0808 ns |   0.0756 ns |   4.03 |     0.00 |
|                                                 LinqCount |              0 |     32.43 ns |   0.0613 ns |   0.0573 ns |   1.96 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     31.40 ns |   0.0131 ns |   0.0116 ns |   1.90 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     29.82 ns |   0.0122 ns |   0.0114 ns |   1.80 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     29.60 ns |   0.0077 ns |   0.0069 ns |   1.79 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     21.66 ns |   0.0143 ns |   0.0134 ns |   1.31 |     0.00 |
|                                               LinqToArray |              0 |     45.94 ns |   0.0269 ns |   0.0225 ns |   2.77 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     42.55 ns |   0.0198 ns |   0.0186 ns |   2.57 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     40.79 ns |   0.0167 ns |   0.0148 ns |   2.46 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     40.23 ns |   0.0272 ns |   0.0241 ns |   2.43 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     31.88 ns |   0.0085 ns |   0.0075 ns |   1.92 |     0.00 |
|                                                      Take |              0 |     70.56 ns |   0.0066 ns |   0.0048 ns |   4.26 |     0.00 |
|                                               LowCostTake |              0 |     41.55 ns |   0.0080 ns |   0.0071 ns |   2.51 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     38.12 ns |   0.0027 ns |   0.0021 ns |   2.30 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     43.58 ns |   0.0085 ns |   0.0080 ns |   2.63 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     39.03 ns |   0.0047 ns |   0.0042 ns |   2.36 |     0.00 |
|                                            SkipTakeSingle |              0 |     95.01 ns |   0.0756 ns |   0.0707 ns |   5.74 |     0.00 |
|                                     LowCostSkipTakeSingle |              0 |     48.00 ns |   0.0083 ns |   0.0078 ns |   2.90 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     46.30 ns |   0.0144 ns |   0.0135 ns |   2.80 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     49.87 ns |   0.0021 ns |   0.0018 ns |   3.01 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     42.26 ns |   0.0023 ns |   0.0020 ns |   2.55 |     0.00 |
|                                           ForeachDelegate |              0 |     19.08 ns |   0.0160 ns |   0.0134 ns |   1.15 |     0.00 |
|                                                   Foreach |              0 |     16.56 ns |   0.0040 ns |   0.0032 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |           **1000** |  **7,278.24 ns** |  **12.0163 ns** |  **11.2400 ns** |   **1.38** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  5,197.90 ns | 100.3116 ns | 123.1917 ns |   0.99 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  3,382.50 ns |   0.6352 ns |   0.5304 ns |   0.64 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  4,841.22 ns |   9.1222 ns |   8.0866 ns |   0.92 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  3,405.99 ns |   5.3226 ns |   4.9787 ns |   0.65 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,682.97 ns |   2.5972 ns |   2.3024 ns |   0.51 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,742.87 ns |   0.3890 ns |   0.3037 ns |   0.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 10,983.82 ns |  48.7008 ns |  45.5548 ns |   2.08 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 10,154.63 ns |  16.1852 ns |  14.3478 ns |   1.92 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  9,178.07 ns |   5.1402 ns |   4.5567 ns |   1.74 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,264.04 ns |   4.7591 ns |   3.9741 ns |   1.57 |     0.00 |
|                                                 LinqCount |           1000 |  1,481.27 ns |   2.0966 ns |   1.8586 ns |   0.28 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  3,851.49 ns |   1.3093 ns |   1.0933 ns |   0.73 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  2,424.06 ns |   1.9228 ns |   1.7986 ns |   0.46 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,729.92 ns |   0.3291 ns |   0.2748 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,214.33 ns |   2.7641 ns |   2.5855 ns |   0.23 |     0.00 |
|                                               LinqToArray |           1000 |  3,150.99 ns |   1.1433 ns |   1.0135 ns |   0.60 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  4,884.16 ns |  10.9666 ns |  10.2582 ns |   0.93 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  4,369.18 ns |   6.8424 ns |   5.7137 ns |   0.83 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,217.81 ns |  13.6284 ns |  12.7480 ns |   0.61 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,300.42 ns |   1.2802 ns |   1.0691 ns |   0.44 |     0.00 |
|                                                      Take |           1000 |    325.15 ns |   0.0870 ns |   0.0727 ns |   0.06 |     0.00 |
|                                               LowCostTake |           1000 |    144.81 ns |   0.0275 ns |   0.0215 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    116.04 ns |   0.2268 ns |   0.2122 ns |   0.02 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    111.15 ns |   0.0575 ns |   0.0480 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     84.09 ns |   0.0070 ns |   0.0051 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    227.44 ns |   0.0419 ns |   0.0350 ns |   0.04 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    135.36 ns |   0.0920 ns |   0.0718 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    113.21 ns |   0.0350 ns |   0.0292 ns |   0.02 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     91.15 ns |   0.0304 ns |   0.0284 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     62.14 ns |   0.0367 ns |   0.0307 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |           1000 |  7,150.22 ns |  50.9635 ns |  47.6713 ns |   1.36 |     0.01 |
|                                                   Foreach |           1000 |  5,276.22 ns |   2.6844 ns |   2.3797 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |              **5** |     **73.24 ns** |   **0.0580 ns** |   **0.0543 ns** |   **1.71** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     56.29 ns |   0.0157 ns |   0.0131 ns |   1.31 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     45.74 ns |   0.0138 ns |   0.0129 ns |   1.07 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     62.56 ns |   0.0153 ns |   0.0143 ns |   1.46 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     62.42 ns |   0.0134 ns |   0.0119 ns |   1.46 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     52.19 ns |   0.0392 ns |   0.0366 ns |   1.22 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     42.90 ns |   0.0426 ns |   0.0399 ns |   1.00 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    129.51 ns |   0.0427 ns |   0.0379 ns |   3.02 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    120.61 ns |   0.0393 ns |   0.0307 ns |   2.82 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    122.68 ns |   0.1520 ns |   0.1422 ns |   2.87 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    109.45 ns |   0.0469 ns |   0.0416 ns |   2.56 |     0.00 |
|                                                 LinqCount |              5 |     40.31 ns |   0.0388 ns |   0.0363 ns |   0.94 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     51.78 ns |   0.2405 ns |   0.2250 ns |   1.21 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     42.84 ns |   0.0473 ns |   0.0395 ns |   1.00 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     38.07 ns |   0.0338 ns |   0.0316 ns |   0.89 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     24.99 ns |   0.0183 ns |   0.0171 ns |   0.58 |     0.00 |
|                                               LinqToArray |              5 |     97.33 ns |   0.0391 ns |   0.0326 ns |   2.27 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |     96.82 ns |   0.0806 ns |   0.0754 ns |   2.26 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     93.40 ns |   0.0391 ns |   0.0305 ns |   2.18 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     86.23 ns |   0.1052 ns |   0.0984 ns |   2.01 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     70.73 ns |   0.0240 ns |   0.0200 ns |   1.65 |     0.00 |
|                                                      Take |              5 |    133.51 ns |   0.0300 ns |   0.0250 ns |   3.12 |     0.00 |
|                                               LowCostTake |              5 |     70.51 ns |   0.0177 ns |   0.0157 ns |   1.65 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     57.28 ns |   0.0404 ns |   0.0378 ns |   1.34 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     59.52 ns |   0.0357 ns |   0.0334 ns |   1.39 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     62.30 ns |   0.0109 ns |   0.0096 ns |   1.46 |     0.00 |
|                                            SkipTakeSingle |              5 |    127.11 ns |   0.0343 ns |   0.0268 ns |   2.97 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     69.78 ns |   0.0481 ns |   0.0450 ns |   1.63 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     56.80 ns |   0.0310 ns |   0.0259 ns |   1.33 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     59.21 ns |   0.0318 ns |   0.0297 ns |   1.38 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     46.31 ns |   0.0062 ns |   0.0055 ns |   1.08 |     0.00 |
|                                           ForeachDelegate |              5 |     54.76 ns |   0.0452 ns |   0.0423 ns |   1.28 |     0.00 |
|                                                   Foreach |              5 |     42.81 ns |   0.0180 ns |   0.0150 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |        |          |
|                                                      **Linq** |             **50** |    **407.76 ns** |   **0.1936 ns** |   **0.1617 ns** |   **1.41** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    307.18 ns |   0.1776 ns |   0.1661 ns |   1.06 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    204.97 ns |   0.0585 ns |   0.0519 ns |   0.71 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    280.70 ns |   0.1203 ns |   0.1125 ns |   0.97 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    210.95 ns |   0.0088 ns |   0.0082 ns |   0.73 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    175.39 ns |   0.0780 ns |   0.0691 ns |   0.61 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    126.56 ns |   0.0196 ns |   0.0164 ns |   0.44 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    627.54 ns |   0.8236 ns |   0.7301 ns |   2.17 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    585.47 ns |   0.1590 ns |   0.1410 ns |   2.03 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    550.20 ns |   0.1439 ns |   0.1346 ns |   1.91 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    483.14 ns |   0.4622 ns |   0.4324 ns |   1.67 |     0.00 |
|                                                 LinqCount |             50 |    113.36 ns |   0.1142 ns |   0.0891 ns |   0.39 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    230.74 ns |   0.1867 ns |   0.1655 ns |   0.80 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    156.31 ns |   0.0255 ns |   0.0199 ns |   0.54 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    122.59 ns |   0.0302 ns |   0.0235 ns |   0.42 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     73.76 ns |   0.0225 ns |   0.0188 ns |   0.26 |     0.00 |
|                                               LinqToArray |             50 |    370.18 ns |   0.1659 ns |   0.1385 ns |   1.28 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    393.73 ns |   0.2363 ns |   0.1973 ns |   1.36 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    348.55 ns |   0.0806 ns |   0.0673 ns |   1.21 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    282.54 ns |   0.8782 ns |   0.8215 ns |   0.98 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    226.71 ns |   0.0516 ns |   0.0403 ns |   0.79 |     0.00 |
|                                                      Take |             50 |    325.08 ns |   0.2268 ns |   0.2121 ns |   1.13 |     0.00 |
|                                               LowCostTake |             50 |    144.49 ns |   0.0389 ns |   0.0325 ns |   0.50 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    114.57 ns |   0.2266 ns |   0.2119 ns |   0.40 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    111.53 ns |   0.0337 ns |   0.0315 ns |   0.39 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     83.68 ns |   0.0221 ns |   0.0173 ns |   0.29 |     0.00 |
|                                            SkipTakeSingle |             50 |    227.49 ns |   0.0643 ns |   0.0570 ns |   0.79 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    134.96 ns |   0.1338 ns |   0.1186 ns |   0.47 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    119.25 ns |   0.0410 ns |   0.0364 ns |   0.41 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     90.90 ns |   0.0307 ns |   0.0272 ns |   0.31 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     63.02 ns |   0.0366 ns |   0.0286 ns |   0.22 |     0.00 |
|                                           ForeachDelegate |             50 |    388.15 ns |   0.1946 ns |   0.1725 ns |   1.34 |     0.00 |
|                                                   Foreach |             50 |    288.69 ns |   0.6723 ns |   0.6289 ns |   1.00 |     0.00 |
