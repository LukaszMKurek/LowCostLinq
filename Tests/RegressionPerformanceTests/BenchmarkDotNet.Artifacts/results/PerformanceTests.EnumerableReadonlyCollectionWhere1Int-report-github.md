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
|                                                      **Linq** |            **[0]** |     **47.51 ns** |   **0.0171 ns** |   **0.0160 ns** |     **47.51 ns** |   **2.92** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     51.00 ns |   0.1238 ns |   0.1158 ns |     50.94 ns |   3.13 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     41.47 ns |   0.0141 ns |   0.0132 ns |     41.46 ns |   2.55 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     51.02 ns |   0.1399 ns |   0.1168 ns |     50.96 ns |   3.13 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     51.05 ns |   0.0114 ns |   0.0095 ns |     51.04 ns |   3.14 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     49.61 ns |   0.0202 ns |   0.0169 ns |     49.61 ns |   3.05 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     43.90 ns |   0.7766 ns |   0.7264 ns |     43.40 ns |   2.70 |     0.04 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     88.61 ns |   0.0327 ns |   0.0273 ns |     88.61 ns |   5.44 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     83.72 ns |   0.0148 ns |   0.0131 ns |     83.72 ns |   5.14 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     89.75 ns |   0.4400 ns |   0.4116 ns |     89.78 ns |   5.51 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     91.10 ns |   1.8229 ns |   3.6823 ns |     90.47 ns |   5.60 |     0.22 |
|                                                 LinqCount |            [0] |     48.03 ns |   0.0129 ns |   0.0114 ns |     48.03 ns |   2.95 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     45.12 ns |   0.0099 ns |   0.0082 ns |     45.12 ns |   2.77 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     44.90 ns |   0.0310 ns |   0.0274 ns |     44.90 ns |   2.76 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     34.61 ns |   0.3548 ns |   0.3319 ns |     34.40 ns |   2.13 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     35.29 ns |   0.4114 ns |   0.3848 ns |     35.24 ns |   2.17 |     0.02 |
|                                               LinqToArray |            [0] |     61.89 ns |   0.0280 ns |   0.0261 ns |     61.89 ns |   3.80 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     56.03 ns |   0.0275 ns |   0.0229 ns |     56.03 ns |   3.44 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     55.31 ns |   0.0474 ns |   0.0396 ns |     55.30 ns |   3.40 |     0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     47.04 ns |   0.1216 ns |   0.1137 ns |     47.09 ns |   2.89 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     47.74 ns |   0.0250 ns |   0.0234 ns |     47.74 ns |   2.93 |     0.00 |
|                                                      Take |            [0] |     81.93 ns |   0.0685 ns |   0.0641 ns |     81.95 ns |   5.03 |     0.00 |
|                                               LowCostTake |            [0] |     50.65 ns |   0.0167 ns |   0.0139 ns |     50.65 ns |   3.11 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     52.38 ns |   0.0108 ns |   0.0090 ns |     52.38 ns |   3.22 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     52.27 ns |   0.0135 ns |   0.0113 ns |     52.27 ns |   3.21 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     52.76 ns |   0.0562 ns |   0.0439 ns |     52.77 ns |   3.24 |     0.00 |
|                                            SkipTakeSingle |            [0] |    104.69 ns |   0.0232 ns |   0.0206 ns |    104.68 ns |   6.43 |     0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     57.79 ns |   0.7650 ns |   0.7156 ns |     57.51 ns |   3.55 |     0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     57.05 ns |   0.0165 ns |   0.0146 ns |     57.05 ns |   3.50 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     53.22 ns |   0.0247 ns |   0.0206 ns |     53.22 ns |   3.27 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     53.26 ns |   0.0089 ns |   0.0083 ns |     53.26 ns |   3.27 |     0.00 |
|                                           ForeachDelegate |            [0] |     18.77 ns |   0.0488 ns |   0.0433 ns |     18.74 ns |   1.15 |     0.00 |
|                                                   Foreach |            [0] |     16.28 ns |   0.0080 ns |   0.0070 ns |     16.28 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **10,130.18 ns** |   **2.9694 ns** |   **2.6323 ns** | **10,130.65 ns** |   **1.92** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,725.00 ns |   4.8281 ns |   4.5162 ns |  7,725.39 ns |   1.46 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  9,737.00 ns | 136.4193 ns | 127.6067 ns |  9,752.53 ns |   1.85 |     0.02 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,210.74 ns |   9.1535 ns |   8.5622 ns |  8,213.33 ns |   1.56 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  7,959.82 ns |   3.1786 ns |   2.4816 ns |  7,960.48 ns |   1.51 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,594.94 ns | 108.8349 ns | 101.8042 ns |  6,629.56 ns |   1.25 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  5,844.96 ns |  61.2446 ns |  57.2882 ns |  5,813.44 ns |   1.11 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 14,941.13 ns |   4.3704 ns |   3.6495 ns | 14,940.49 ns |   2.83 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 14,926.62 ns |   6.6633 ns |   5.5642 ns | 14,925.94 ns |   2.83 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 12,658.52 ns | 150.4157 ns | 140.6989 ns | 12,556.94 ns |   2.40 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 12,598.22 ns |  19.4645 ns |  18.2071 ns | 12,600.03 ns |   2.39 |     0.00 |
|                                                 LinqCount |         [1000] |  6,519.21 ns |   3.4454 ns |   2.8771 ns |  6,519.72 ns |   1.24 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,388.55 ns |  56.3056 ns |  52.6683 ns |  7,388.15 ns |   1.40 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,264.05 ns |   2.3053 ns |   2.0436 ns |  7,263.35 ns |   1.38 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,291.82 ns |   7.7183 ns |   7.2197 ns |  5,294.80 ns |   1.00 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,177.23 ns |  41.1876 ns |  38.5269 ns |  5,162.07 ns |   0.98 |     0.01 |
|                                               LinqToArray |         [1000] |  7,843.41 ns |   6.8219 ns |   6.3812 ns |  7,842.85 ns |   1.49 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,716.63 ns |   7.9513 ns |   7.4377 ns |  8,714.90 ns |   1.65 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,679.17 ns |   8.4140 ns |   7.8705 ns |  8,680.16 ns |   1.65 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,016.75 ns |   6.9386 ns |   6.4903 ns |  7,016.69 ns |   1.33 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  6,594.94 ns |   6.2428 ns |   5.8395 ns |  6,595.59 ns |   1.25 |     0.00 |
|                                                      Take |         [1000] |    382.89 ns |   0.0877 ns |   0.0777 ns |    382.88 ns |   0.07 |     0.00 |
|                                               LowCostTake |         [1000] |    238.16 ns |   0.4152 ns |   0.3884 ns |    238.29 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    220.31 ns |   2.5357 ns |   2.3719 ns |    218.64 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    197.19 ns |   0.1032 ns |   0.0965 ns |    197.25 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    187.34 ns |   0.0588 ns |   0.0491 ns |    187.33 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    294.38 ns |   0.1115 ns |   0.1043 ns |    294.39 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    246.65 ns |   2.7475 ns |   2.5700 ns |    244.94 ns |   0.05 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    237.73 ns |   0.0749 ns |   0.0626 ns |    237.71 ns |   0.05 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    185.95 ns |   0.5302 ns |   0.4960 ns |    185.70 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    182.75 ns |   0.5500 ns |   0.4592 ns |    182.64 ns |   0.03 |     0.00 |
|                                           ForeachDelegate |         [1000] |  6,848.08 ns |  11.5862 ns |  10.2708 ns |  6,849.04 ns |   1.30 |     0.00 |
|                                                   Foreach |         [1000] |  5,274.21 ns |   3.0206 ns |   2.5224 ns |  5,273.61 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **578.36 ns** |   **0.6746 ns** |   **0.5633 ns** |    **578.24 ns** |   **2.01** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    451.57 ns |   5.2133 ns |   4.8765 ns |    447.86 ns |   1.57 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    529.37 ns |   0.1718 ns |   0.1607 ns |    529.38 ns |   1.84 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    468.24 ns |   0.1154 ns |   0.1080 ns |    468.22 ns |   1.63 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    451.71 ns |   0.6193 ns |   0.4835 ns |    451.83 ns |   1.57 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    369.64 ns |   0.0986 ns |   0.0923 ns |    369.64 ns |   1.29 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    336.76 ns |   0.0242 ns |   0.0214 ns |    336.76 ns |   1.17 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    868.03 ns |  10.1022 ns |   9.4496 ns |    861.62 ns |   3.02 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    841.47 ns |   0.1643 ns |   0.1457 ns |    841.42 ns |   2.93 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    722.72 ns |   0.0960 ns |   0.0898 ns |    722.72 ns |   2.51 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    733.07 ns |   9.1317 ns |   8.5418 ns |    728.96 ns |   2.55 |     0.03 |
|                                                 LinqCount |           [50] |    377.32 ns |   0.1305 ns |   0.1156 ns |    377.28 ns |   1.31 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    424.81 ns |   0.8879 ns |   0.8306 ns |    424.34 ns |   1.48 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    423.37 ns |   4.5302 ns |   4.2376 ns |    420.51 ns |   1.47 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |    307.47 ns |   0.1152 ns |   0.1077 ns |    307.45 ns |   1.07 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    307.65 ns |   0.0402 ns |   0.0376 ns |    307.65 ns |   1.07 |     0.00 |
|                                               LinqToArray |           [50] |    634.68 ns |   1.8260 ns |   1.7080 ns |    633.94 ns |   2.21 |     0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    599.66 ns |   8.5472 ns |   7.9951 ns |    605.36 ns |   2.09 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    600.06 ns |   0.5672 ns |   0.4736 ns |    600.15 ns |   2.09 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    496.70 ns |   0.3925 ns |   0.3671 ns |    496.64 ns |   1.73 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    481.25 ns |   1.2499 ns |   1.1692 ns |    480.92 ns |   1.67 |     0.00 |
|                                                      Take |           [50] |    382.44 ns |   0.0776 ns |   0.0648 ns |    382.42 ns |   1.33 |     0.00 |
|                                               LowCostTake |           [50] |    236.76 ns |   0.0507 ns |   0.0474 ns |    236.75 ns |   0.82 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    218.52 ns |   0.1340 ns |   0.1253 ns |    218.46 ns |   0.76 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    197.30 ns |   0.0324 ns |   0.0271 ns |    197.30 ns |   0.69 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    192.21 ns |   0.5387 ns |   0.4499 ns |    192.13 ns |   0.67 |     0.00 |
|                                            SkipTakeSingle |           [50] |    294.37 ns |   0.1218 ns |   0.1080 ns |    294.39 ns |   1.02 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    245.94 ns |   0.5378 ns |   0.4768 ns |    246.12 ns |   0.86 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    236.62 ns |   0.0463 ns |   0.0387 ns |    236.63 ns |   0.82 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    188.10 ns |   2.1231 ns |   1.9859 ns |    186.64 ns |   0.65 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    177.83 ns |   0.0284 ns |   0.0237 ns |    177.83 ns |   0.62 |     0.00 |
|                                           ForeachDelegate |           [50] |    368.45 ns |   0.1099 ns |   0.1028 ns |    368.47 ns |   1.28 |     0.00 |
|                                                   Foreach |           [50] |    287.38 ns |   0.0992 ns |   0.0879 ns |    287.38 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |     **99.45 ns** |   **2.2736 ns** |   **2.1267 ns** |     **98.49 ns** |   **2.36** |     **0.05** |
|                                   LowCostLinqWithDelegate |            [5] |     81.49 ns |   0.0564 ns |   0.0500 ns |     81.50 ns |   1.93 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     84.07 ns |   0.0182 ns |   0.0170 ns |     84.07 ns |   2.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     92.81 ns |   1.5432 ns |   1.4435 ns |     91.72 ns |   2.20 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     83.60 ns |   0.0241 ns |   0.0225 ns |     83.61 ns |   1.98 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     74.22 ns |   0.0391 ns |   0.0346 ns |     74.21 ns |   1.76 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     68.08 ns |   0.0146 ns |   0.0130 ns |     68.08 ns |   1.62 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    182.28 ns |   0.3730 ns |   0.3489 ns |    182.25 ns |   4.33 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    170.74 ns |   0.0642 ns |   0.0601 ns |    170.73 ns |   4.05 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    164.69 ns |   0.0489 ns |   0.0457 ns |    164.69 ns |   3.91 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    160.31 ns |   2.9168 ns |   2.7284 ns |    160.03 ns |   3.81 |     0.06 |
|                                                 LinqCount |            [5] |     79.20 ns |   0.0853 ns |   0.0666 ns |     79.21 ns |   1.88 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     82.89 ns |   0.0482 ns |   0.0451 ns |     82.88 ns |   1.97 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     82.66 ns |   0.0526 ns |   0.0411 ns |     82.65 ns |   1.96 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     63.03 ns |   1.0825 ns |   1.0126 ns |     62.99 ns |   1.50 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     62.51 ns |   0.0310 ns |   0.0259 ns |     62.50 ns |   1.48 |     0.00 |
|                                               LinqToArray |            [5] |    152.24 ns |   0.2114 ns |   0.1977 ns |    152.22 ns |   3.61 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    129.52 ns |   0.3586 ns |   0.3355 ns |    129.32 ns |   3.08 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    130.91 ns |   0.0636 ns |   0.0595 ns |    130.89 ns |   3.11 |     0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    108.64 ns |   0.2913 ns |   0.2725 ns |    108.42 ns |   2.58 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    108.56 ns |   0.1073 ns |   0.1004 ns |    108.52 ns |   2.58 |     0.00 |
|                                                      Take |            [5] |    169.39 ns |   0.0367 ns |   0.0325 ns |    169.37 ns |   4.02 |     0.00 |
|                                               LowCostTake |            [5] |     91.70 ns |   0.2033 ns |   0.1902 ns |     91.60 ns |   2.18 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |     86.30 ns |   0.0415 ns |   0.0388 ns |     86.29 ns |   2.05 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     84.07 ns |   0.1632 ns |   0.1526 ns |     83.99 ns |   2.00 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     79.91 ns |   1.0847 ns |   1.0147 ns |     79.78 ns |   1.90 |     0.02 |
|                                            SkipTakeSingle |            [5] |    150.26 ns |   0.1291 ns |   0.1144 ns |    150.27 ns |   3.57 |     0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     99.01 ns |   0.0371 ns |   0.0329 ns |     99.01 ns |   2.35 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     94.90 ns |   0.0320 ns |   0.0250 ns |     94.90 ns |   2.25 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     76.05 ns |   0.0188 ns |   0.0176 ns |     76.05 ns |   1.81 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     78.45 ns |   0.1767 ns |   0.1652 ns |     78.39 ns |   1.86 |     0.00 |
|                                           ForeachDelegate |            [5] |     53.58 ns |   0.0158 ns |   0.0148 ns |     53.58 ns |   1.27 |     0.00 |
|                                                   Foreach |            [5] |     42.12 ns |   0.0550 ns |   0.0514 ns |     42.14 ns |   1.00 |     0.00 |
