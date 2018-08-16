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
|                                                      **Linq** |            **[0]** |    **128.69 ns** |   **0.0608 ns** |   **0.0539 ns** |    **128.68 ns** |   **7.93** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     53.74 ns |   0.0106 ns |   0.0082 ns |     53.74 ns |   3.31 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     54.57 ns |   0.0096 ns |   0.0080 ns |     54.57 ns |   3.36 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     80.79 ns |   0.0247 ns |   0.0207 ns |     80.78 ns |   4.98 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     79.01 ns |   0.0208 ns |   0.0194 ns |     79.01 ns |   4.87 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     63.72 ns |   0.9101 ns |   0.8514 ns |     63.13 ns |   3.93 |     0.05 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     61.77 ns |   0.0063 ns |   0.0053 ns |     61.77 ns |   3.80 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    123.39 ns |   0.0342 ns |   0.0285 ns |    123.39 ns |   7.60 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    121.24 ns |   0.0484 ns |   0.0453 ns |    121.24 ns |   7.47 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    111.61 ns |   0.2522 ns |   0.2236 ns |    111.50 ns |   6.87 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    107.44 ns |   0.0257 ns |   0.0214 ns |    107.44 ns |   6.62 |     0.00 |
|                                                 LinqCount |            [0] |    129.39 ns |   0.0256 ns |   0.0214 ns |    129.39 ns |   7.97 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     55.94 ns |   0.0124 ns |   0.0116 ns |     55.94 ns |   3.45 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     56.34 ns |   0.0288 ns |   0.0270 ns |     56.33 ns |   3.47 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     56.19 ns |   0.0480 ns |   0.0375 ns |     56.19 ns |   3.46 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     58.36 ns |   0.7453 ns |   0.6972 ns |     57.97 ns |   3.59 |     0.04 |
|                                               LinqToArray |            [0] |    144.75 ns |   0.0984 ns |   0.0921 ns |    144.72 ns |   8.92 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     66.06 ns |   0.0289 ns |   0.0270 ns |     66.05 ns |   4.07 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     65.43 ns |   0.0379 ns |   0.0316 ns |     65.43 ns |   4.03 |     0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     65.77 ns |   0.0204 ns |   0.0180 ns |     65.77 ns |   4.05 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     65.02 ns |   0.0309 ns |   0.0289 ns |     65.02 ns |   4.00 |     0.00 |
|                                                      Take |            [0] |    167.89 ns |   0.0435 ns |   0.0407 ns |    167.88 ns |  10.34 |     0.01 |
|                                               LowCostTake |            [0] |     67.75 ns |   0.0198 ns |   0.0185 ns |     67.75 ns |   4.17 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     65.25 ns |   0.0145 ns |   0.0136 ns |     65.25 ns |   4.02 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     77.11 ns |   0.7235 ns |   0.6767 ns |     76.73 ns |   4.75 |     0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     77.24 ns |   0.0213 ns |   0.0178 ns |     77.24 ns |   4.76 |     0.00 |
|                                            SkipTakeSingle |            [0] |    188.90 ns |   0.0789 ns |   0.0738 ns |    188.92 ns |  11.64 |     0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     90.00 ns |   0.0729 ns |   0.0569 ns |     89.99 ns |   5.54 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     88.72 ns |   0.0276 ns |   0.0259 ns |     88.72 ns |   5.46 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     95.02 ns |   0.0352 ns |   0.0294 ns |     95.00 ns |   5.85 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     92.88 ns |   0.0315 ns |   0.0294 ns |     92.88 ns |   5.72 |     0.00 |
|                                           ForeachDelegate |            [0] |     21.62 ns |   0.0226 ns |   0.0212 ns |     21.63 ns |   1.33 |     0.00 |
|                                                   Foreach |            [0] |     16.24 ns |   0.0094 ns |   0.0088 ns |     16.24 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **17,504.80 ns** |  **25.7034 ns** |  **24.0430 ns** | **17,501.03 ns** |   **3.32** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 15,320.19 ns |  57.7582 ns |  45.0938 ns | 15,316.91 ns |   2.91 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 15,274.77 ns | 161.0551 ns | 150.6510 ns | 15,264.45 ns |   2.90 |     0.03 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 16,109.37 ns |  47.7188 ns |  44.6362 ns | 16,132.93 ns |   3.06 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 15,928.72 ns |  61.1691 ns |  57.2176 ns | 15,925.96 ns |   3.03 |     0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,319.82 ns |   3.5997 ns |   3.0059 ns |  6,320.59 ns |   1.20 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,051.95 ns |   4.1974 ns |   3.7209 ns |  6,051.94 ns |   1.15 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 30,230.58 ns | 144.8672 ns | 135.5088 ns | 30,250.13 ns |   5.74 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 28,596.93 ns |  96.4115 ns |  75.2718 ns | 28,593.45 ns |   5.43 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 12,802.79 ns |   2.3532 ns |   2.0861 ns | 12,803.25 ns |   2.43 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 12,820.55 ns |   3.5166 ns |   3.2895 ns | 12,819.42 ns |   2.43 |     0.00 |
|                                                 LinqCount |         [1000] | 13,857.44 ns | 172.0895 ns | 160.9727 ns | 13,761.26 ns |   2.63 |     0.03 |
|                              LowCostLinqWithDelegateCount |         [1000] | 15,343.76 ns |  51.5539 ns |  48.2235 ns | 15,335.37 ns |   2.91 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 14,053.40 ns |  14.9553 ns |  13.9892 ns | 14,054.97 ns |   2.67 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,339.94 ns |  12.5973 ns |  11.7835 ns |  5,345.76 ns |   1.01 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,196.56 ns |  81.0919 ns |  75.8534 ns |  5,168.78 ns |   0.99 |     0.01 |
|                                               LinqToArray |         [1000] | 15,697.78 ns |  10.0221 ns |   9.3747 ns | 15,695.11 ns |   2.98 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 15,744.23 ns |   5.8452 ns |   5.4676 ns | 15,742.62 ns |   2.99 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 16,438.31 ns |  12.3607 ns |  11.5622 ns | 16,439.03 ns |   3.12 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  6,918.95 ns | 101.4587 ns |  94.9046 ns |  6,861.37 ns |   1.31 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  6,869.41 ns |   6.6141 ns |   6.1868 ns |  6,870.14 ns |   1.30 |     0.00 |
|                                                      Take |         [1000] |    624.79 ns |   0.2441 ns |   0.2283 ns |    624.77 ns |   0.12 |     0.00 |
|                                               LowCostTake |         [1000] |    414.17 ns |   0.1503 ns |   0.1332 ns |    414.14 ns |   0.08 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    402.76 ns |   0.6129 ns |   0.5733 ns |    402.83 ns |   0.08 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    238.57 ns |   0.0869 ns |   0.0813 ns |    238.60 ns |   0.05 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    218.23 ns |   0.0548 ns |   0.0513 ns |    218.22 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    550.31 ns |   9.0040 ns |   8.4223 ns |    543.26 ns |   0.10 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    446.29 ns |   0.0411 ns |   0.0364 ns |    446.29 ns |   0.08 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    451.08 ns |   0.3000 ns |   0.2660 ns |    451.19 ns |   0.09 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    274.03 ns |   0.0833 ns |   0.0780 ns |    274.00 ns |   0.05 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    259.58 ns |   0.0575 ns |   0.0480 ns |    259.58 ns |   0.05 |     0.00 |
|                                           ForeachDelegate |         [1000] | 10,528.90 ns |  16.6166 ns |  15.5431 ns | 10,527.44 ns |   2.00 |     0.00 |
|                                                   Foreach |         [1000] |  5,265.27 ns |   2.9771 ns |   2.6392 ns |  5,264.86 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |  **1,007.95 ns** |   **0.4653 ns** |   **0.4124 ns** |  **1,007.81 ns** |   **3.50** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    810.47 ns |   0.1220 ns |   0.1082 ns |    810.47 ns |   2.82 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    821.12 ns |   0.2809 ns |   0.2627 ns |    821.13 ns |   2.85 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    908.64 ns |   0.0992 ns |   0.0879 ns |    908.61 ns |   3.16 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    865.69 ns |   2.6248 ns |   2.3268 ns |    864.62 ns |   3.01 |     0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    381.36 ns |   0.0767 ns |   0.0680 ns |    381.36 ns |   1.33 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    362.09 ns |   0.0857 ns |   0.0760 ns |    362.08 ns |   1.26 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,631.31 ns |   3.2758 ns |   2.9039 ns |  1,631.49 ns |   5.67 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,559.53 ns |   1.7063 ns |   1.4249 ns |  1,559.37 ns |   5.42 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    760.43 ns |   0.1637 ns |   0.1531 ns |    760.35 ns |   2.64 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    767.70 ns |  10.5874 ns |   9.9035 ns |    759.81 ns |   2.67 |     0.03 |
|                                                 LinqCount |           [50] |    824.97 ns |   0.2111 ns |   0.1871 ns |    824.93 ns |   2.87 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    827.38 ns |   1.3494 ns |   1.2622 ns |    827.58 ns |   2.88 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    781.61 ns |   9.7940 ns |   9.1613 ns |    774.68 ns |   2.72 |     0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |    326.09 ns |   0.1548 ns |   0.1372 ns |    326.12 ns |   1.13 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    319.35 ns |   0.1203 ns |   0.1125 ns |    319.36 ns |   1.11 |     0.00 |
|                                               LinqToArray |           [50] |  1,135.39 ns |   3.0317 ns |   2.8359 ns |  1,136.55 ns |   3.95 |     0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |  1,011.93 ns |  17.9370 ns |  16.7783 ns |  1,012.03 ns |   3.52 |     0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |  1,017.67 ns |   0.3985 ns |   0.3727 ns |  1,017.65 ns |   3.54 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    518.76 ns |   0.1344 ns |   0.1191 ns |    518.77 ns |   1.80 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    511.53 ns |   1.0348 ns |   0.9174 ns |    511.75 ns |   1.78 |     0.00 |
|                                                      Take |           [50] |    625.54 ns |   0.1371 ns |   0.1282 ns |    625.55 ns |   2.17 |     0.00 |
|                                               LowCostTake |           [50] |    413.32 ns |   0.1398 ns |   0.1308 ns |    413.26 ns |   1.44 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    408.72 ns |   0.3126 ns |   0.2924 ns |    408.80 ns |   1.42 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    236.50 ns |   0.0318 ns |   0.0266 ns |    236.50 ns |   0.82 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    218.71 ns |   0.0576 ns |   0.0539 ns |    218.71 ns |   0.76 |     0.00 |
|                                            SkipTakeSingle |           [50] |    540.03 ns |   0.1443 ns |   0.1349 ns |    540.07 ns |   1.88 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    449.36 ns |   0.7020 ns |   0.6223 ns |    449.59 ns |   1.56 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    448.67 ns |   0.0816 ns |   0.0723 ns |    448.67 ns |   1.56 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    273.49 ns |   0.0415 ns |   0.0347 ns |    273.48 ns |   0.95 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    259.16 ns |   0.0793 ns |   0.0742 ns |    259.17 ns |   0.90 |     0.00 |
|                                           ForeachDelegate |           [50] |    557.16 ns |   0.1419 ns |   0.1258 ns |    557.12 ns |   1.94 |     0.00 |
|                                                   Foreach |           [50] |    287.61 ns |   0.1114 ns |   0.1042 ns |    287.64 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |    **228.39 ns** |   **0.0475 ns** |   **0.0397 ns** |    **228.40 ns** |   **5.41** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    135.28 ns |   0.2541 ns |   0.2377 ns |    135.29 ns |   3.21 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    137.61 ns |   1.4170 ns |   1.3255 ns |    136.90 ns |   3.26 |     0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |    173.26 ns |   0.0714 ns |   0.0668 ns |    173.27 ns |   4.11 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    164.67 ns |   0.1279 ns |   0.1133 ns |    164.69 ns |   3.90 |     0.01 |
|                                LowCostLinqWithStructWhere |            [5] |     89.26 ns |   0.1595 ns |   0.1492 ns |     89.31 ns |   2.11 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     86.47 ns |   1.1983 ns |   1.1209 ns |     85.94 ns |   2.05 |     0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    301.50 ns |   0.2093 ns |   0.1748 ns |    301.51 ns |   7.14 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    279.42 ns |   0.3626 ns |   0.3392 ns |    279.29 ns |   6.62 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    187.28 ns |   0.3580 ns |   0.2990 ns |    187.34 ns |   4.44 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    183.19 ns |   2.5836 ns |   2.4167 ns |    181.24 ns |   4.34 |     0.06 |
|                                                 LinqCount |            [5] |    213.83 ns |   0.1081 ns |   0.1011 ns |    213.82 ns |   5.07 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |    140.46 ns |   0.0295 ns |   0.0261 ns |    140.46 ns |   3.33 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    133.87 ns |   0.2610 ns |   0.2313 ns |    133.95 ns |   3.17 |     0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     80.02 ns |   1.0914 ns |   1.0209 ns |     79.44 ns |   1.90 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     82.55 ns |   0.1321 ns |   0.1235 ns |     82.51 ns |   1.96 |     0.00 |
|                                               LinqToArray |            [5] |    281.27 ns |   0.3379 ns |   0.3161 ns |    281.30 ns |   6.66 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    185.02 ns |   0.0529 ns |   0.0469 ns |    185.02 ns |   4.38 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    184.48 ns |   0.4601 ns |   0.4303 ns |    184.25 ns |   4.37 |     0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    124.36 ns |   0.0318 ns |   0.0281 ns |    124.35 ns |   2.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    126.05 ns |   0.0594 ns |   0.0555 ns |    126.03 ns |   2.99 |     0.00 |
|                                                      Take |            [5] |    303.32 ns |   0.0725 ns |   0.0605 ns |    303.33 ns |   7.19 |     0.01 |
|                                               LowCostTake |            [5] |    155.04 ns |   0.0695 ns |   0.0580 ns |    155.04 ns |   3.67 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    146.75 ns |   0.0554 ns |   0.0491 ns |    146.75 ns |   3.48 |     0.01 |
|                                     LowCostTakeWithStruct |            [5] |    116.53 ns |   0.0637 ns |   0.0596 ns |    116.51 ns |   2.76 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    105.20 ns |   1.3295 ns |   1.2436 ns |    104.23 ns |   2.49 |     0.03 |
|                                            SkipTakeSingle |            [5] |    289.73 ns |   0.7673 ns |   0.7177 ns |    289.33 ns |   6.86 |     0.02 |
|                                     LowCostSkipTakeSingle |            [5] |    176.27 ns |   0.0465 ns |   0.0412 ns |    176.27 ns |   4.18 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    183.83 ns |   0.4142 ns |   0.3459 ns |    183.69 ns |   4.36 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    134.44 ns |   0.0348 ns |   0.0326 ns |    134.43 ns |   3.19 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    127.43 ns |   0.0313 ns |   0.0262 ns |    127.44 ns |   3.02 |     0.00 |
|                                           ForeachDelegate |            [5] |     75.09 ns |   0.0217 ns |   0.0192 ns |     75.09 ns |   1.78 |     0.00 |
|                                                   Foreach |            [5] |     42.21 ns |   0.0674 ns |   0.0630 ns |     42.22 ns |   1.00 |     0.00 |
