``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **50.93 ns** |   **0.0188 ns** |   **0.0176 ns** |     **50.94 ns** |  **4.51** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     34.99 ns |   0.0083 ns |   0.0077 ns |     34.99 ns |  3.10 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     28.18 ns |   0.0085 ns |   0.0079 ns |     28.18 ns |  2.49 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     48.27 ns |   0.0209 ns |   0.0196 ns |     48.27 ns |  4.27 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     45.65 ns |   0.0103 ns |   0.0081 ns |     45.65 ns |  4.04 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     40.67 ns |   0.0173 ns |   0.0162 ns |     40.67 ns |  3.60 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     38.52 ns |   0.0079 ns |   0.0074 ns |     38.52 ns |  3.41 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    103.49 ns |   0.0325 ns |   0.0304 ns |    103.49 ns |  9.16 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     90.08 ns |   0.1329 ns |   0.1243 ns |     90.07 ns |  7.98 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     87.24 ns |   0.0421 ns |   0.0394 ns |     87.25 ns |  7.72 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     77.11 ns |   0.0441 ns |   0.0413 ns |     77.09 ns |  6.83 |    0.00 |
|                                                 LinqCount |            [0] |     49.98 ns |   0.0514 ns |   0.0456 ns |     49.97 ns |  4.43 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     33.26 ns |   0.0122 ns |   0.0114 ns |     33.26 ns |  2.94 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.72 ns |   0.0132 ns |   0.0117 ns |     33.72 ns |  2.99 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     30.15 ns |   0.0055 ns |   0.0049 ns |     30.15 ns |  2.67 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     30.30 ns |   0.0434 ns |   0.0406 ns |     30.31 ns |  2.68 |    0.00 |
|                                               LinqToArray |            [0] |     64.50 ns |   0.0847 ns |   0.0751 ns |     64.47 ns |  5.71 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     46.47 ns |   0.0434 ns |   0.0405 ns |     46.47 ns |  4.11 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     45.82 ns |   0.0191 ns |   0.0170 ns |     45.82 ns |  4.06 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     40.85 ns |   0.0218 ns |   0.0182 ns |     40.85 ns |  3.62 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     40.91 ns |   0.0229 ns |   0.0203 ns |     40.91 ns |  3.62 |    0.00 |
|                                                      Take |            [0] |     84.48 ns |   0.0435 ns |   0.0407 ns |     84.49 ns |  7.48 |    0.00 |
|                                               LowCostTake |            [0] |     43.22 ns |   0.0068 ns |   0.0061 ns |     43.23 ns |  3.83 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     37.63 ns |   0.0782 ns |   0.0732 ns |     37.59 ns |  3.33 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     49.00 ns |   0.0067 ns |   0.0063 ns |     49.00 ns |  4.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     43.71 ns |   0.0087 ns |   0.0072 ns |     43.71 ns |  3.87 |    0.00 |
|                                            SkipTakeSingle |            [0] |    108.12 ns |   0.1619 ns |   0.1514 ns |    108.04 ns |  9.57 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     49.68 ns |   0.0150 ns |   0.0133 ns |     49.68 ns |  4.40 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     49.50 ns |   0.0169 ns |   0.0158 ns |     49.49 ns |  4.38 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     52.65 ns |   0.0165 ns |   0.0154 ns |     52.66 ns |  4.66 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     52.67 ns |   0.0171 ns |   0.0160 ns |     52.67 ns |  4.66 |    0.00 |
|                                           ForeachDelegate |            [0] |     14.55 ns |   0.0064 ns |   0.0060 ns |     14.55 ns |  1.29 |    0.00 |
|                                                   Foreach |            [0] |     11.29 ns |   0.0024 ns |   0.0023 ns |     11.29 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** |  **7,507.57 ns** |   **3.8556 ns** |   **3.6066 ns** |  **7,507.57 ns** |  **1.74** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  5,570.49 ns | 110.4352 ns | 318.6309 ns |  5,561.29 ns |  1.26 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,384.10 ns | 176.6807 ns | 156.6229 ns |  5,310.07 ns |  1.25 |    0.04 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,224.27 ns | 123.8850 ns | 353.4509 ns |  6,224.97 ns |  1.46 |    0.10 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,370.66 ns |  26.5219 ns |  20.7066 ns |  6,367.93 ns |  1.47 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,470.39 ns |   2.6590 ns |   2.4872 ns |  1,469.32 ns |  0.34 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,282.63 ns |   0.2223 ns |   0.1856 ns |  1,282.66 ns |  0.30 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,787.55 ns |  27.9534 ns |  24.7800 ns | 19,780.61 ns |  4.58 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,840.85 ns | 387.1236 ns | 646.7966 ns | 19,688.65 ns |  4.66 |    0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,481.15 ns |   2.7107 ns |   2.4030 ns |  8,481.43 ns |  1.96 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,488.38 ns |   2.8879 ns |   2.4115 ns |  8,488.08 ns |  1.96 |    0.00 |
|                                                 LinqCount |         [1000] |  3,913.04 ns |   5.0407 ns |   4.7151 ns |  3,914.33 ns |  0.91 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  5,199.49 ns | 103.7277 ns | 278.6577 ns |  5,065.53 ns |  1.21 |    0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,476.00 ns |  33.8828 ns |  30.0362 ns |  5,469.55 ns |  1.27 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    529.30 ns |   0.1165 ns |   0.1090 ns |    529.30 ns |  0.12 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    523.38 ns |   0.1228 ns |   0.1148 ns |    523.38 ns |  0.12 |    0.00 |
|                                               LinqToArray |         [1000] |  5,112.51 ns |   3.9575 ns |   3.7018 ns |  5,112.85 ns |  1.18 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  6,782.24 ns |  16.4603 ns |  15.3970 ns |  6,783.71 ns |  1.57 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,760.87 ns |  13.7082 ns |  12.8227 ns |  6,754.71 ns |  1.56 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,188.35 ns |   3.0999 ns |   2.5885 ns |  2,187.87 ns |  0.51 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,265.48 ns |   3.2642 ns |   2.7257 ns |  2,265.07 ns |  0.52 |    0.00 |
|                                                      Take |         [1000] |    359.14 ns |   0.1130 ns |   0.1002 ns |    359.15 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    172.88 ns |   1.0843 ns |   1.0142 ns |    172.74 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    160.02 ns |   3.2282 ns |   5.0259 ns |    159.53 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     85.85 ns |   0.0066 ns |   0.0062 ns |     85.85 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     73.89 ns |   0.0147 ns |   0.0137 ns |     73.89 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    268.34 ns |   0.0930 ns |   0.0870 ns |    268.33 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    179.77 ns |   1.7864 ns |   1.4917 ns |    179.82 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    208.95 ns |   8.7149 ns |  25.6962 ns |    224.53 ns |  0.05 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     77.08 ns |   0.1345 ns |   0.1258 ns |     77.04 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     77.11 ns |   0.1294 ns |   0.1080 ns |     77.06 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  7,259.79 ns |   1.3057 ns |   1.1575 ns |  7,259.57 ns |  1.68 |    0.00 |
|                                                   Foreach |         [1000] |  4,320.19 ns |   1.5607 ns |   1.4599 ns |  4,320.00 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **439.01 ns** |   **0.1296 ns** |   **0.1149 ns** |    **438.99 ns** |  **1.85** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    321.15 ns |   3.0043 ns |   2.8102 ns |    321.90 ns |  1.35 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    311.14 ns |   7.1943 ns |   9.0985 ns |    305.98 ns |  1.32 |    0.04 |
|                                  LowCostLinqWithDelegate2 |           [50] |    484.47 ns |   4.3710 ns |   4.0886 ns |    485.22 ns |  2.04 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    383.88 ns |   7.6815 ns |  17.1807 ns |    378.59 ns |  1.65 |    0.07 |
|                                LowCostLinqWithStructWhere |           [50] |    114.15 ns |   0.1593 ns |   0.1490 ns |    114.21 ns |  0.48 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    106.47 ns |   0.0204 ns |   0.0191 ns |    106.47 ns |  0.45 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,196.26 ns |   1.6227 ns |   1.4385 ns |  1,196.14 ns |  5.04 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,063.74 ns |   6.6856 ns |   6.2537 ns |  1,061.09 ns |  4.48 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    521.23 ns |   0.8960 ns |   0.8381 ns |    521.34 ns |  2.20 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    512.05 ns |   0.2392 ns |   0.2237 ns |    512.10 ns |  2.16 |    0.00 |
|                                                 LinqCount |           [50] |    258.93 ns |   0.1819 ns |   0.1613 ns |    258.93 ns |  1.09 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    293.06 ns |   5.8541 ns |  13.7987 ns |    283.79 ns |  1.26 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    287.52 ns |   5.5603 ns |   5.9494 ns |    284.41 ns |  1.22 |    0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |     56.09 ns |   0.0831 ns |   0.0777 ns |     56.10 ns |  0.24 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     54.08 ns |   0.0101 ns |   0.0094 ns |     54.08 ns |  0.23 |    0.00 |
|                                               LinqToArray |           [50] |    507.56 ns |   0.1478 ns |   0.1382 ns |    507.58 ns |  2.14 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    474.69 ns |   0.4324 ns |   0.4045 ns |    474.66 ns |  2.00 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    467.11 ns |   0.3257 ns |   0.3047 ns |    467.14 ns |  1.97 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    210.17 ns |   0.2621 ns |   0.2451 ns |    210.20 ns |  0.89 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    216.68 ns |   0.0883 ns |   0.0826 ns |    216.70 ns |  0.91 |    0.00 |
|                                                      Take |           [50] |    359.18 ns |   0.1184 ns |   0.1107 ns |    359.20 ns |  1.51 |    0.00 |
|                                               LowCostTake |           [50] |    172.74 ns |   1.1316 ns |   1.0032 ns |    172.97 ns |  0.73 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    151.38 ns |   3.1621 ns |   4.3283 ns |    149.78 ns |  0.64 |    0.02 |
|                                     LowCostTakeWithStruct |           [50] |     85.35 ns |   0.0295 ns |   0.0261 ns |     85.36 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     73.71 ns |   0.0257 ns |   0.0240 ns |     73.70 ns |  0.31 |    0.00 |
|                                            SkipTakeSingle |           [50] |    267.30 ns |   0.1053 ns |   0.0985 ns |    267.27 ns |  1.13 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    188.86 ns |   0.9085 ns |   0.8498 ns |    188.86 ns |  0.80 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    165.24 ns |   0.6032 ns |   0.4709 ns |    165.16 ns |  0.70 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     76.09 ns |   0.0082 ns |   0.0077 ns |     76.09 ns |  0.32 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     76.23 ns |   0.1056 ns |   0.0988 ns |     76.29 ns |  0.32 |    0.00 |
|                                           ForeachDelegate |           [50] |    392.58 ns |   0.0912 ns |   0.0854 ns |    392.57 ns |  1.66 |    0.00 |
|                                                   Foreach |           [50] |    237.18 ns |   0.1362 ns |   0.1274 ns |    237.18 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |     **98.84 ns** |   **0.0328 ns** |   **0.0307 ns** |     **98.84 ns** |  **2.88** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     63.23 ns |   1.2826 ns |   2.0711 ns |     61.83 ns |  1.83 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     58.66 ns |   0.5737 ns |   0.5085 ns |     58.68 ns |  1.71 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |     75.92 ns |   1.5355 ns |   3.0665 ns |     73.70 ns |  2.26 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     84.20 ns |   2.6501 ns |   7.8139 ns |     89.33 ns |  2.31 |    0.19 |
|                                LowCostLinqWithStructWhere |            [5] |     46.65 ns |   0.0103 ns |   0.0092 ns |     46.65 ns |  1.36 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     44.37 ns |   0.0130 ns |   0.0122 ns |     44.37 ns |  1.29 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    215.60 ns |   0.1132 ns |   0.1059 ns |    215.57 ns |  6.28 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    194.33 ns |   0.2666 ns |   0.2494 ns |    194.33 ns |  5.66 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    133.27 ns |   0.0683 ns |   0.0570 ns |    133.28 ns |  3.88 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    123.13 ns |   0.0503 ns |   0.0471 ns |    123.12 ns |  3.59 |    0.00 |
|                                                 LinqCount |            [5] |     81.97 ns |   0.0569 ns |   0.0504 ns |     81.98 ns |  2.39 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     58.75 ns |   1.1898 ns |   1.5047 ns |     58.11 ns |  1.72 |    0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     61.34 ns |   0.3357 ns |   0.3141 ns |     61.20 ns |  1.79 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     32.55 ns |   0.0142 ns |   0.0126 ns |     32.55 ns |  0.95 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     32.64 ns |   0.0058 ns |   0.0054 ns |     32.63 ns |  0.95 |    0.00 |
|                                               LinqToArray |            [5] |    142.88 ns |   0.0594 ns |   0.0555 ns |    142.90 ns |  4.16 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    107.04 ns |   0.0971 ns |   0.0861 ns |    107.07 ns |  3.12 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    104.85 ns |   0.0650 ns |   0.0608 ns |    104.84 ns |  3.05 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     73.24 ns |   0.0109 ns |   0.0085 ns |     73.24 ns |  2.13 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     72.77 ns |   0.1344 ns |   0.1257 ns |     72.71 ns |  2.12 |    0.00 |
|                                                      Take |            [5] |    163.52 ns |   0.0424 ns |   0.0376 ns |    163.52 ns |  4.76 |    0.00 |
|                                               LowCostTake |            [5] |     70.37 ns |   1.4110 ns |   2.9139 ns |     70.15 ns |  2.13 |    0.06 |
|                                  LowCostTakeWithoutChecks |            [5] |     65.98 ns |   1.3380 ns |   2.2720 ns |     64.97 ns |  1.95 |    0.07 |
|                                     LowCostTakeWithStruct |            [5] |     57.83 ns |   0.0196 ns |   0.0183 ns |     57.83 ns |  1.68 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     52.12 ns |   0.0299 ns |   0.0280 ns |     52.11 ns |  1.52 |    0.00 |
|                                            SkipTakeSingle |            [5] |    155.16 ns |   0.0462 ns |   0.0432 ns |    155.15 ns |  4.52 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     74.68 ns |   1.2606 ns |   1.1791 ns |     74.71 ns |  2.17 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     84.23 ns |   2.4794 ns |   7.3106 ns |     88.34 ns |  2.58 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     56.81 ns |   0.0232 ns |   0.0217 ns |     56.80 ns |  1.66 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     56.22 ns |   0.0294 ns |   0.0275 ns |     56.22 ns |  1.64 |    0.00 |
|                                           ForeachDelegate |            [5] |     53.50 ns |   0.0483 ns |   0.0429 ns |     53.48 ns |  1.56 |    0.00 |
|                                                   Foreach |            [5] |     34.33 ns |   0.0196 ns |   0.0174 ns |     34.32 ns |  1.00 |    0.00 |
