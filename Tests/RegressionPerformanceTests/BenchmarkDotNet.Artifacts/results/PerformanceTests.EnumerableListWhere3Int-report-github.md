``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |         Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|--------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **96.25 ns** |     **0.1064 ns** |     **0.0944 ns** |     **96.21 ns** |  **5.75** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     38.69 ns |     0.0246 ns |     0.0192 ns |     38.69 ns |  2.31 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     33.92 ns |     0.3562 ns |     0.3332 ns |     33.77 ns |  2.02 |    0.02 |
|                                  LowCostLinqWithDelegate2 |            [0] |     63.13 ns |     0.0667 ns |     0.0557 ns |     63.16 ns |  3.77 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     56.75 ns |     0.0159 ns |     0.0141 ns |     56.75 ns |  3.39 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     49.69 ns |     0.4741 ns |     0.4434 ns |     49.42 ns |  2.97 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     43.56 ns |     0.0147 ns |     0.0123 ns |     43.56 ns |  2.60 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    112.80 ns |     0.9207 ns |     0.8612 ns |    112.76 ns |  6.74 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    105.82 ns |     0.6191 ns |     0.4834 ns |    105.58 ns |  6.33 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     97.99 ns |     0.0306 ns |     0.0256 ns |     97.99 ns |  5.86 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     93.04 ns |     0.0249 ns |     0.0233 ns |     93.04 ns |  5.56 |    0.01 |
|                                                 LinqCount |            [0] |     93.99 ns |     0.2498 ns |     0.2086 ns |     93.91 ns |  5.62 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [0] |     38.46 ns |     0.0745 ns |     0.0697 ns |     38.45 ns |  2.30 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     34.79 ns |     0.0240 ns |     0.0213 ns |     34.79 ns |  2.08 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     44.25 ns |     0.0232 ns |     0.0194 ns |     44.26 ns |  2.65 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.64 ns |     0.3758 ns |     0.3515 ns |     36.37 ns |  2.19 |    0.02 |
|                                               LinqToArray |            [0] |    105.76 ns |     0.0326 ns |     0.0272 ns |    105.76 ns |  6.32 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     48.59 ns |     0.0513 ns |     0.0479 ns |     48.59 ns |  2.90 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     47.11 ns |     0.7769 ns |     0.7268 ns |     46.58 ns |  2.82 |    0.05 |
|                              LowCostLinqWithStructToArray |            [0] |     53.64 ns |     0.0511 ns |     0.0453 ns |     53.62 ns |  3.21 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     46.04 ns |     0.0609 ns |     0.0508 ns |     46.03 ns |  2.75 |    0.01 |
|                                                      Take |            [0] |    134.25 ns |     0.0511 ns |     0.0399 ns |    134.25 ns |  8.03 |    0.01 |
|                                               LowCostTake |            [0] |     45.32 ns |     0.0448 ns |     0.0397 ns |     45.30 ns |  2.71 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     42.39 ns |     0.1264 ns |     0.1183 ns |     42.46 ns |  2.54 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     57.00 ns |     0.6673 ns |     0.5916 ns |     56.72 ns |  3.41 |    0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     52.75 ns |     0.0746 ns |     0.0623 ns |     52.73 ns |  3.15 |    0.00 |
|                                            SkipTakeSingle |            [0] |    154.08 ns |     0.1603 ns |     0.1421 ns |    154.07 ns |  9.21 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     56.16 ns |     0.7278 ns |     0.6808 ns |     55.71 ns |  3.36 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     54.05 ns |     0.0066 ns |     0.0059 ns |     54.05 ns |  3.23 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     65.78 ns |     0.0370 ns |     0.0347 ns |     65.80 ns |  3.93 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     57.88 ns |     0.0028 ns |     0.0023 ns |     57.88 ns |  3.46 |    0.00 |
|                                           ForeachDelegate |            [0] |     19.76 ns |     0.0083 ns |     0.0065 ns |     19.76 ns |  1.18 |    0.00 |
|                                                   Foreach |            [0] |     16.72 ns |     0.0271 ns |     0.0227 ns |     16.72 ns |  1.00 |    0.00 |
|                                                           |                |              |               |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **16,287.32 ns** | **1,011.8573 ns** | **2,983.4841 ns** | **18,563.68 ns** |  **3.38** |    **0.21** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,608.77 ns |   257.8191 ns |   683.6997 ns | 11,574.60 ns |  2.10 |    0.13 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,367.33 ns |   214.1995 ns |   624.8299 ns | 10,610.22 ns |  1.94 |    0.09 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,472.43 ns |   251.1701 ns |   740.5806 ns |  9,532.04 ns |  1.69 |    0.15 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,799.26 ns |   257.4659 ns |   759.1440 ns |  8,591.51 ns |  1.61 |    0.11 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,695.01 ns |     0.9817 ns |     0.8198 ns |  2,694.92 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,755.68 ns |     0.8680 ns |     0.7249 ns |  1,755.73 ns |  0.32 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,714.75 ns |   470.7213 ns | 1,100.2958 ns | 23,362.40 ns |  4.21 |    0.16 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 22,310.75 ns |   219.7354 ns |   194.7898 ns | 22,292.56 ns |  4.04 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,724.73 ns |     7.5578 ns |     6.3111 ns |  9,722.41 ns |  1.76 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,468.74 ns |    10.1847 ns |     7.9515 ns |  9,466.37 ns |  1.71 |    0.00 |
|                                                 LinqCount |         [1000] |  6,421.68 ns |   124.1113 ns |   137.9494 ns |  6,374.45 ns |  1.16 |    0.03 |
|                              LowCostLinqWithDelegateCount |         [1000] |  9,267.76 ns |   138.8170 ns |   129.8495 ns |  9,253.00 ns |  1.68 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,170.31 ns |    86.8262 ns |    76.9692 ns |  8,136.38 ns |  1.48 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,803.60 ns |    34.1982 ns |    31.9890 ns |  1,784.11 ns |  0.33 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,228.18 ns |     0.2921 ns |     0.2439 ns |  1,228.16 ns |  0.22 |    0.00 |
|                                               LinqToArray |         [1000] |  8,290.92 ns |   161.5933 ns |   192.3654 ns |  8,342.19 ns |  1.49 |    0.04 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,066.53 ns |    21.5624 ns |    19.1145 ns | 11,060.38 ns |  2.00 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  9,312.26 ns |   184.2908 ns |   275.8378 ns |  9,169.12 ns |  1.72 |    0.06 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,473.11 ns |     7.2008 ns |     6.7356 ns |  3,473.93 ns |  0.63 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,617.29 ns |     8.9618 ns |     8.3829 ns |  2,614.30 ns |  0.47 |    0.00 |
|                                                      Take |         [1000] |    474.16 ns |     9.2902 ns |     8.6900 ns |    467.99 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |    296.54 ns |     5.8600 ns |    12.8628 ns |    300.02 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    213.73 ns |     4.2422 ns |     6.4783 ns |    210.80 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    124.19 ns |     0.1125 ns |     0.0998 ns |    124.20 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     99.40 ns |     0.0282 ns |     0.0264 ns |     99.39 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    401.89 ns |     2.5118 ns |     2.2267 ns |    402.32 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    287.58 ns |     8.5855 ns |    10.2204 ns |    284.26 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    475.08 ns |     9.0791 ns |     8.9169 ns |    474.77 ns |  0.09 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    124.00 ns |     0.0655 ns |     0.0512 ns |    124.01 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     85.51 ns |     0.3545 ns |     0.3143 ns |     85.61 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,395.88 ns |    32.8757 ns |    27.4527 ns |  9,386.48 ns |  1.70 |    0.00 |
|                                                   Foreach |         [1000] |  5,528.14 ns |     1.2294 ns |     1.0266 ns |  5,528.21 ns |  1.00 |    0.00 |
|                                                           |                |              |               |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **758.06 ns** |    **17.5103 ns** |    **22.1449 ns** |    **757.67 ns** |  **2.51** |    **0.07** |
|                                   LowCostLinqWithDelegate |           [50] |    564.69 ns |    11.2504 ns |    11.0494 ns |    559.10 ns |  1.85 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    749.81 ns |    46.4074 ns |   134.6364 ns |    819.23 ns |  2.61 |    0.30 |
|                                  LowCostLinqWithDelegate2 |           [50] |    934.31 ns |    77.8305 ns |   229.4850 ns |  1,047.07 ns |  2.55 |    0.96 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    464.76 ns |     9.1603 ns |     9.4069 ns |    459.58 ns |  1.52 |    0.03 |
|                                LowCostLinqWithStructWhere |           [50] |    184.95 ns |     0.0490 ns |     0.0435 ns |    184.93 ns |  0.60 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    137.62 ns |     0.0420 ns |     0.0372 ns |    137.62 ns |  0.45 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,284.78 ns |    14.8910 ns |    13.9291 ns |  1,278.21 ns |  4.20 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,252.14 ns |    28.6428 ns |    39.2066 ns |  1,232.56 ns |  4.10 |    0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    594.92 ns |     0.2662 ns |     0.2360 ns |    594.91 ns |  1.95 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    571.91 ns |     0.1677 ns |     0.1568 ns |    571.95 ns |  1.87 |    0.00 |
|                                                 LinqCount |           [50] |    434.75 ns |    12.3771 ns |    14.2535 ns |    430.03 ns |  1.43 |    0.05 |
|                              LowCostLinqWithDelegateCount |           [50] |    498.99 ns |     9.9109 ns |     9.2707 ns |    495.75 ns |  1.63 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    766.10 ns |    12.8266 ns |    11.9980 ns |    765.11 ns |  2.50 |    0.04 |
|                           LowCostLinqWithStructWhereCount |           [50] |    138.10 ns |     0.1839 ns |     0.1720 ns |    138.10 ns |  0.45 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     92.70 ns |     0.2368 ns |     0.1849 ns |     92.75 ns |  0.30 |    0.00 |
|                                               LinqToArray |           [50] |    686.96 ns |     1.0319 ns |     0.9652 ns |    686.96 ns |  2.25 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    746.83 ns |    11.0709 ns |    10.3557 ns |    750.38 ns |  2.45 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    593.17 ns |    14.1207 ns |    19.7952 ns |    582.43 ns |  1.97 |    0.08 |
|                              LowCostLinqWithStructToArray |           [50] |    297.38 ns |     1.2433 ns |     1.0382 ns |    297.72 ns |  0.97 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    237.61 ns |     0.4283 ns |     0.3797 ns |    237.54 ns |  0.78 |    0.00 |
|                                                      Take |           [50] |    483.31 ns |     0.4778 ns |     0.4236 ns |    483.27 ns |  1.58 |    0.00 |
|                                               LowCostTake |           [50] |    258.11 ns |     5.3813 ns |     8.9909 ns |    254.09 ns |  0.86 |    0.04 |
|                                  LowCostTakeWithoutChecks |           [50] |    245.61 ns |     4.8872 ns |    10.6244 ns |    248.08 ns |  0.81 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    122.87 ns |     0.1253 ns |     0.1111 ns |    122.89 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     97.67 ns |     0.0288 ns |     0.0255 ns |     97.68 ns |  0.32 |    0.00 |
|                                            SkipTakeSingle |           [50] |    405.87 ns |     0.6605 ns |     0.6178 ns |    405.74 ns |  1.33 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    286.35 ns |     5.2277 ns |     4.8900 ns |    285.48 ns |  0.94 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    414.64 ns |    30.5101 ns |    89.9596 ns |    459.62 ns |  1.40 |    0.33 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    124.03 ns |     0.0699 ns |     0.0620 ns |    124.01 ns |  0.41 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     85.83 ns |     0.0464 ns |     0.0434 ns |     85.83 ns |  0.28 |    0.00 |
|                                           ForeachDelegate |           [50] |    514.95 ns |     0.2342 ns |     0.2076 ns |    514.94 ns |  1.68 |    0.00 |
|                                                   Foreach |           [50] |    305.79 ns |     0.1338 ns |     0.1186 ns |    305.81 ns |  1.00 |    0.00 |
|                                                           |                |              |               |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **159.82 ns** |     **0.1448 ns** |     **0.1355 ns** |    **159.82 ns** |  **3.61** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    101.82 ns |     2.0502 ns |     2.8742 ns |    102.34 ns |  2.29 |    0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     73.52 ns |     1.4795 ns |     1.5193 ns |     73.49 ns |  1.66 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |    157.54 ns |     8.2753 ns |    24.1395 ns |    169.30 ns |  3.65 |    0.51 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     96.90 ns |     1.9350 ns |     2.3764 ns |     96.88 ns |  2.20 |    0.05 |
|                                LowCostLinqWithStructWhere |            [5] |     63.38 ns |     0.2962 ns |     0.2312 ns |     63.44 ns |  1.43 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     53.72 ns |     0.0291 ns |     0.0227 ns |     53.71 ns |  1.21 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    241.52 ns |     0.2322 ns |     0.1939 ns |    241.55 ns |  5.46 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    224.86 ns |     0.6334 ns |     0.5615 ns |    224.85 ns |  5.08 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    151.68 ns |     2.9650 ns |     3.7497 ns |    149.95 ns |  3.45 |    0.10 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    141.62 ns |     0.8897 ns |     0.7887 ns |    141.45 ns |  3.20 |    0.02 |
|                                                 LinqCount |            [5] |    123.90 ns |     0.2097 ns |     0.1962 ns |    123.81 ns |  2.80 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     89.09 ns |     1.7137 ns |     4.3929 ns |     90.05 ns |  1.97 |    0.10 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     76.71 ns |     1.5611 ns |     2.3840 ns |     77.11 ns |  1.74 |    0.05 |
|                           LowCostLinqWithStructWhereCount |            [5] |     52.70 ns |     0.0910 ns |     0.0851 ns |     52.66 ns |  1.19 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     40.88 ns |     0.3265 ns |     0.3054 ns |     40.68 ns |  0.92 |    0.01 |
|                                               LinqToArray |            [5] |    187.09 ns |     0.0574 ns |     0.0479 ns |    187.08 ns |  4.23 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    129.34 ns |     0.3068 ns |     0.2562 ns |    129.34 ns |  2.92 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    117.07 ns |     0.1068 ns |     0.0892 ns |    117.05 ns |  2.65 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     98.37 ns |     2.2143 ns |     2.2739 ns |     96.85 ns |  2.22 |    0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     85.86 ns |     1.7250 ns |     2.3612 ns |     84.66 ns |  1.95 |    0.07 |
|                                                      Take |            [5] |    235.54 ns |     4.5128 ns |     4.0005 ns |    234.47 ns |  5.32 |    0.09 |
|                                               LowCostTake |            [5] |     94.61 ns |     1.9176 ns |     2.7501 ns |     94.39 ns |  2.14 |    0.06 |
|                                  LowCostTakeWithoutChecks |            [5] |    111.32 ns |     8.1707 ns |    24.0914 ns |    129.43 ns |  2.69 |    0.47 |
|                                     LowCostTakeWithStruct |            [5] |     72.53 ns |     0.2266 ns |     0.2120 ns |     72.47 ns |  1.64 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     64.78 ns |     0.1901 ns |     0.1779 ns |     64.85 ns |  1.46 |    0.00 |
|                                            SkipTakeSingle |            [5] |    211.95 ns |     0.0630 ns |     0.0558 ns |    211.94 ns |  4.79 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    151.47 ns |     2.0744 ns |     1.9404 ns |    151.85 ns |  3.42 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     95.61 ns |     1.9217 ns |     4.5297 ns |     93.62 ns |  2.15 |    0.09 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     76.62 ns |     0.0831 ns |     0.0737 ns |     76.59 ns |  1.73 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     64.37 ns |     0.0257 ns |     0.0241 ns |     64.36 ns |  1.46 |    0.00 |
|                                           ForeachDelegate |            [5] |     68.44 ns |     1.3819 ns |     1.4786 ns |     68.10 ns |  1.55 |    0.03 |
|                                                   Foreach |            [5] |     44.23 ns |     0.0447 ns |     0.0418 ns |     44.23 ns |  1.00 |    0.00 |
