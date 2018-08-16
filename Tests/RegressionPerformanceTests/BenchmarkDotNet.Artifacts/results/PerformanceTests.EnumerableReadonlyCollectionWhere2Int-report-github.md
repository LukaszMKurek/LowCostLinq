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
|                                                      **Linq** |            **[0]** |     **75.91 ns** |   **0.0351 ns** |   **0.0311 ns** |     **75.90 ns** |   **4.68** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     50.32 ns |   0.0194 ns |   0.0182 ns |     50.31 ns |   3.10 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     44.45 ns |   0.0132 ns |   0.0117 ns |     44.45 ns |   2.74 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     55.40 ns |   0.0125 ns |   0.0105 ns |     55.40 ns |   3.42 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     57.91 ns |   0.0057 ns |   0.0051 ns |     57.91 ns |   3.57 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     51.82 ns |   0.1677 ns |   0.1401 ns |     51.77 ns |   3.20 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     53.17 ns |   0.0225 ns |   0.0211 ns |     53.17 ns |   3.28 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    108.55 ns |   0.1138 ns |   0.1009 ns |    108.51 ns |   6.69 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    106.18 ns |   1.2605 ns |   1.1791 ns |    105.32 ns |   6.55 |     0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     95.13 ns |   0.0350 ns |   0.0310 ns |     95.12 ns |   5.87 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     87.18 ns |   0.0186 ns |   0.0155 ns |     87.18 ns |   5.38 |     0.01 |
|                                                 LinqCount |            [0] |     75.23 ns |   0.0183 ns |   0.0143 ns |     75.23 ns |   4.64 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     47.80 ns |   0.0174 ns |   0.0136 ns |     47.80 ns |   2.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     47.84 ns |   0.0219 ns |   0.0205 ns |     47.84 ns |   2.95 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     51.86 ns |   0.0109 ns |   0.0097 ns |     51.86 ns |   3.20 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     40.74 ns |   0.0094 ns |   0.0088 ns |     40.75 ns |   2.51 |     0.00 |
|                                               LinqToArray |            [0] |     88.80 ns |   0.3354 ns |   0.3137 ns |     88.65 ns |   5.48 |     0.02 |
|                            LowCostLinqWithDelegateToArray |            [0] |     60.12 ns |   0.0393 ns |   0.0367 ns |     60.12 ns |   3.71 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     59.76 ns |   0.0283 ns |   0.0265 ns |     59.75 ns |   3.68 |     0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     49.95 ns |   0.0260 ns |   0.0243 ns |     49.95 ns |   3.08 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     50.69 ns |   0.0204 ns |   0.0170 ns |     50.69 ns |   3.13 |     0.00 |
|                                                      Take |            [0] |    110.74 ns |   0.4901 ns |   0.3827 ns |    110.68 ns |   6.83 |     0.02 |
|                                               LowCostTake |            [0] |     50.13 ns |   0.0204 ns |   0.0159 ns |     50.13 ns |   3.09 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     49.33 ns |   0.0083 ns |   0.0078 ns |     49.33 ns |   3.04 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     58.41 ns |   0.6065 ns |   0.5673 ns |     58.01 ns |   3.60 |     0.03 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     57.32 ns |   0.0096 ns |   0.0090 ns |     57.32 ns |   3.53 |     0.00 |
|                                            SkipTakeSingle |            [0] |    132.71 ns |   0.0401 ns |   0.0335 ns |    132.71 ns |   8.18 |     0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     65.06 ns |   0.0125 ns |   0.0117 ns |     65.06 ns |   4.01 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     60.32 ns |   0.0215 ns |   0.0190 ns |     60.32 ns |   3.72 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     63.54 ns |   0.9444 ns |   0.8834 ns |     62.90 ns |   3.92 |     0.05 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     62.75 ns |   0.0435 ns |   0.0385 ns |     62.74 ns |   3.87 |     0.00 |
|                                           ForeachDelegate |            [0] |     20.73 ns |   0.0168 ns |   0.0157 ns |     20.73 ns |   1.28 |     0.00 |
|                                                   Foreach |            [0] |     16.22 ns |   0.0188 ns |   0.0166 ns |     16.22 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **12,796.67 ns** |   **3.7570 ns** |   **2.9332 ns** | **12,796.28 ns** |   **2.43** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 10,628.09 ns |  33.8594 ns |  31.6721 ns | 10,622.42 ns |   2.02 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,579.36 ns |  12.0501 ns |  10.6821 ns | 10,574.11 ns |   2.01 |     0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 10,441.80 ns |  46.4964 ns |  43.4927 ns | 10,432.47 ns |   1.98 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 12,680.11 ns |  43.2628 ns |  40.4680 ns | 12,693.79 ns |   2.41 |     0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,549.56 ns |   7.5181 ns |   7.0325 ns |  6,545.98 ns |   1.24 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,027.85 ns |   2.5375 ns |   2.3736 ns |  6,026.97 ns |   1.14 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 24,651.24 ns | 314.1594 ns | 293.8649 ns | 24,479.61 ns |   4.68 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 25,038.76 ns |  41.2338 ns |  38.5701 ns | 25,038.62 ns |   4.76 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 13,072.61 ns |  19.7551 ns |  18.4789 ns | 13,073.69 ns |   2.48 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 13,135.73 ns | 122.1493 ns | 114.2585 ns | 13,051.41 ns |   2.49 |     0.02 |
|                                                 LinqCount |         [1000] |  8,731.31 ns |   2.7452 ns |   2.5678 ns |  8,731.36 ns |   1.66 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,944.89 ns |  17.7735 ns |  16.6253 ns |  8,952.21 ns |   1.70 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  9,158.45 ns |  10.0868 ns |   7.8751 ns |  9,157.80 ns |   1.74 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,357.15 ns |  58.8235 ns |  55.0235 ns |  5,316.52 ns |   1.02 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,134.63 ns |   2.1768 ns |   2.0362 ns |  5,134.42 ns |   0.98 |     0.00 |
|                                               LinqToArray |         [1000] | 10,022.14 ns |   5.7461 ns |   5.3749 ns | 10,022.66 ns |   1.90 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,204.71 ns |   9.6022 ns |   8.9819 ns | 11,205.62 ns |   2.13 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,279.41 ns | 216.8638 ns | 202.8545 ns | 11,121.70 ns |   2.14 |     0.04 |
|                              LowCostLinqWithStructToArray |         [1000] |  6,597.82 ns |   8.5944 ns |   8.0392 ns |  6,600.35 ns |   1.25 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  6,585.41 ns |   5.6539 ns |   5.2886 ns |  6,585.81 ns |   1.25 |     0.00 |
|                                                      Take |         [1000] |    477.56 ns |   7.5463 ns |   7.0588 ns |    472.82 ns |   0.09 |     0.00 |
|                                               LowCostTake |         [1000] |    302.97 ns |   0.0962 ns |   0.0853 ns |    302.96 ns |   0.06 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    258.03 ns |   0.5316 ns |   0.4973 ns |    257.80 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    200.23 ns |   0.0340 ns |   0.0318 ns |    200.22 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    193.59 ns |   0.0561 ns |   0.0438 ns |    193.60 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    382.61 ns |   3.0969 ns |   2.8968 ns |    382.61 ns |   0.07 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    299.96 ns |   0.0770 ns |   0.0601 ns |    299.94 ns |   0.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    289.98 ns |   0.0570 ns |   0.0505 ns |    289.98 ns |   0.06 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    185.54 ns |   0.3729 ns |   0.3488 ns |    185.35 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    204.57 ns |   4.1143 ns |   7.8279 ns |    204.34 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |         [1000] |  8,049.87 ns |  13.7674 ns |  12.8780 ns |  8,053.97 ns |   1.53 |     0.00 |
|                                                   Foreach |         [1000] |  5,264.94 ns |   2.8924 ns |   2.7056 ns |  5,264.60 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **734.08 ns** |   **0.0899 ns** |   **0.0797 ns** |    **734.12 ns** |   **2.55** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    583.69 ns |   8.0428 ns |   7.5232 ns |    579.10 ns |   2.03 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    573.63 ns |   0.0602 ns |   0.0534 ns |    573.61 ns |   2.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    586.21 ns |   1.6102 ns |   1.4274 ns |    585.54 ns |   2.04 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    675.69 ns |   0.3415 ns |   0.3027 ns |    675.61 ns |   2.35 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    383.30 ns |   4.5408 ns |   4.2474 ns |    380.06 ns |   1.33 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    352.39 ns |   0.0754 ns |   0.0669 ns |    352.39 ns |   1.23 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,342.16 ns |   0.2750 ns |   0.2438 ns |  1,342.14 ns |   4.67 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,364.32 ns |   1.4468 ns |   1.3533 ns |  1,364.20 ns |   4.75 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    766.95 ns |   0.4331 ns |   0.3382 ns |    767.09 ns |   2.67 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    753.57 ns |   0.1449 ns |   0.1355 ns |    753.59 ns |   2.62 |     0.00 |
|                                                 LinqCount |           [50] |    519.97 ns |   0.2870 ns |   0.2684 ns |    520.04 ns |   1.81 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    506.47 ns |   0.0742 ns |   0.0658 ns |    506.44 ns |   1.76 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    531.96 ns |   8.1646 ns |   7.6372 ns |    531.22 ns |   1.85 |     0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |    309.93 ns |   0.0678 ns |   0.0635 ns |    309.94 ns |   1.08 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    307.90 ns |   0.3140 ns |   0.2783 ns |    308.01 ns |   1.07 |     0.00 |
|                                               LinqToArray |           [50] |    773.33 ns |   0.3055 ns |   0.2708 ns |    773.37 ns |   2.69 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    760.21 ns |   8.8046 ns |   8.2358 ns |    756.63 ns |   2.64 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    740.59 ns |   0.2476 ns |   0.2195 ns |    740.53 ns |   2.58 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    489.42 ns |   0.1684 ns |   0.1493 ns |    489.46 ns |   1.70 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    487.87 ns |   0.2112 ns |   0.1976 ns |    487.85 ns |   1.70 |     0.00 |
|                                                      Take |           [50] |    476.46 ns |   6.3901 ns |   5.9773 ns |    472.61 ns |   1.66 |     0.02 |
|                                               LowCostTake |           [50] |    303.08 ns |   0.2025 ns |   0.1894 ns |    303.17 ns |   1.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    258.79 ns |   0.0476 ns |   0.0372 ns |    258.79 ns |   0.90 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    204.07 ns |   0.0764 ns |   0.0714 ns |    204.06 ns |   0.71 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    200.72 ns |   0.0358 ns |   0.0317 ns |    200.72 ns |   0.70 |     0.00 |
|                                            SkipTakeSingle |           [50] |    381.84 ns |   0.2889 ns |   0.2702 ns |    381.90 ns |   1.33 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    296.44 ns |   0.4220 ns |   0.3294 ns |    296.55 ns |   1.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    295.06 ns |   0.1263 ns |   0.1181 ns |    295.02 ns |   1.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    185.30 ns |   0.0217 ns |   0.0203 ns |    185.30 ns |   0.64 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    195.00 ns |   0.4685 ns |   0.4382 ns |    194.76 ns |   0.68 |     0.00 |
|                                           ForeachDelegate |           [50] |    430.37 ns |   0.2811 ns |   0.2630 ns |    430.36 ns |   1.50 |     0.00 |
|                                                   Foreach |           [50] |    287.43 ns |   0.0643 ns |   0.0537 ns |    287.43 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |    **141.89 ns** |   **0.0389 ns** |   **0.0345 ns** |    **141.90 ns** |   **3.37** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    108.13 ns |   0.0395 ns |   0.0330 ns |    108.13 ns |   2.57 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    105.07 ns |   1.2186 ns |   1.1399 ns |    104.39 ns |   2.50 |     0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |    114.43 ns |   0.1187 ns |   0.1110 ns |    114.46 ns |   2.72 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    124.79 ns |   0.0781 ns |   0.0730 ns |    124.75 ns |   2.97 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     81.23 ns |   0.0489 ns |   0.0408 ns |     81.23 ns |   1.93 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     79.34 ns |   0.0280 ns |   0.0262 ns |     79.34 ns |   1.89 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    244.97 ns |   0.0540 ns |   0.0478 ns |    244.97 ns |   5.82 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    248.88 ns |   0.2106 ns |   0.1970 ns |    248.83 ns |   5.91 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    174.51 ns |   0.1009 ns |   0.0944 ns |    174.53 ns |   4.15 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    165.97 ns |   2.2832 ns |   2.1357 ns |    164.20 ns |   3.94 |     0.05 |
|                                                 LinqCount |            [5] |    132.42 ns |   0.2953 ns |   0.2762 ns |    132.43 ns |   3.15 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     94.27 ns |   0.0190 ns |   0.0158 ns |     94.28 ns |   2.24 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     95.22 ns |   0.0827 ns |   0.0774 ns |     95.23 ns |   2.26 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     64.91 ns |   0.0579 ns |   0.0452 ns |     64.92 ns |   1.54 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     66.33 ns |   0.0756 ns |   0.0590 ns |     66.35 ns |   1.58 |     0.00 |
|                                               LinqToArray |            [5] |    195.48 ns |   0.0406 ns |   0.0380 ns |    195.48 ns |   4.65 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    148.21 ns |   0.4456 ns |   0.4168 ns |    148.33 ns |   3.52 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    146.10 ns |   1.8695 ns |   1.7487 ns |    145.09 ns |   3.47 |     0.04 |
|                              LowCostLinqWithStructToArray |            [5] |    111.33 ns |   0.0371 ns |   0.0329 ns |    111.33 ns |   2.65 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    109.85 ns |   0.0241 ns |   0.0213 ns |    109.84 ns |   2.61 |     0.00 |
|                                                      Take |            [5] |    226.13 ns |   1.7901 ns |   1.6745 ns |    225.93 ns |   5.37 |     0.04 |
|                                               LowCostTake |            [5] |    118.82 ns |   0.0410 ns |   0.0384 ns |    118.81 ns |   2.82 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    105.45 ns |   0.0396 ns |   0.0351 ns |    105.45 ns |   2.51 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     86.84 ns |   0.0299 ns |   0.0250 ns |     86.83 ns |   2.06 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     85.73 ns |   0.0190 ns |   0.0168 ns |     85.72 ns |   2.04 |     0.00 |
|                                            SkipTakeSingle |            [5] |    204.45 ns |   0.0481 ns |   0.0376 ns |    204.46 ns |   4.86 |     0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    113.02 ns |   0.0374 ns |   0.0332 ns |    113.03 ns |   2.69 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    110.15 ns |   0.0414 ns |   0.0387 ns |    110.14 ns |   2.62 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     84.41 ns |   0.0275 ns |   0.0258 ns |     84.41 ns |   2.01 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     86.19 ns |   0.2002 ns |   0.1873 ns |     86.07 ns |   2.05 |     0.00 |
|                                           ForeachDelegate |            [5] |     61.88 ns |   0.9397 ns |   0.8790 ns |     61.16 ns |   1.47 |     0.02 |
|                                                   Foreach |            [5] |     42.08 ns |   0.0540 ns |   0.0505 ns |     42.07 ns |   1.00 |     0.00 |
