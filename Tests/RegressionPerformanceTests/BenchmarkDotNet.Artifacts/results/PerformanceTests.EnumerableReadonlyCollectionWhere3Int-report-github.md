``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **112.94 ns** |   **0.0785 ns** |   **0.0696 ns** |    **112.93 ns** |  **6.20** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     52.18 ns |   0.5916 ns |   0.5533 ns |     51.93 ns |  2.86 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     49.90 ns |   0.1240 ns |   0.1160 ns |     49.87 ns |  2.74 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     72.89 ns |   0.1195 ns |   0.1118 ns |     72.92 ns |  4.00 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     68.10 ns |   0.1503 ns |   0.1255 ns |     68.03 ns |  3.74 |    0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     58.48 ns |   0.0253 ns |   0.0211 ns |     58.48 ns |  3.21 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     57.17 ns |   0.0682 ns |   0.0605 ns |     57.14 ns |  3.14 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    128.86 ns |   0.1064 ns |   0.0995 ns |    128.84 ns |  7.07 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    126.55 ns |   2.0295 ns |   1.7991 ns |    126.06 ns |  6.94 |    0.10 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    113.55 ns |   0.0753 ns |   0.0668 ns |    113.54 ns |  6.23 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    109.64 ns |   0.0649 ns |   0.0542 ns |    109.62 ns |  6.02 |    0.00 |
|                                                 LinqCount |            [0] |    112.59 ns |   0.1728 ns |   0.1616 ns |    112.54 ns |  6.18 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     52.65 ns |   0.2208 ns |   0.1724 ns |     52.59 ns |  2.89 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     51.86 ns |   0.1010 ns |   0.0945 ns |     51.82 ns |  2.85 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     49.05 ns |   0.0195 ns |   0.0162 ns |     49.05 ns |  2.69 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     49.92 ns |   0.1910 ns |   0.1786 ns |     49.83 ns |  2.74 |    0.01 |
|                                               LinqToArray |            [0] |    127.36 ns |   0.1238 ns |   0.1033 ns |    127.38 ns |  6.99 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     65.00 ns |   0.0513 ns |   0.0454 ns |     64.99 ns |  3.57 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     63.38 ns |   0.1231 ns |   0.1028 ns |     63.33 ns |  3.48 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     59.06 ns |   0.5695 ns |   0.4755 ns |     58.86 ns |  3.24 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     58.69 ns |   0.1321 ns |   0.1103 ns |     58.67 ns |  3.22 |    0.01 |
|                                                      Take |            [0] |    149.89 ns |   0.0824 ns |   0.0643 ns |    149.87 ns |  8.22 |    0.01 |
|                                               LowCostTake |            [0] |     55.08 ns |   0.0535 ns |   0.0447 ns |     55.07 ns |  3.02 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     54.59 ns |   0.0871 ns |   0.0727 ns |     54.58 ns |  3.00 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     68.20 ns |   0.2234 ns |   0.2090 ns |     68.08 ns |  3.74 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     64.92 ns |   0.1808 ns |   0.1691 ns |     64.86 ns |  3.56 |    0.01 |
|                                            SkipTakeSingle |            [0] |    172.97 ns |   3.4843 ns |   4.0125 ns |    170.12 ns |  9.53 |    0.24 |
|                                     LowCostSkipTakeSingle |            [0] |     72.65 ns |   0.0424 ns |   0.0376 ns |     72.65 ns |  3.99 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     71.98 ns |   0.0648 ns |   0.0541 ns |     71.95 ns |  3.95 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     71.39 ns |   0.0383 ns |   0.0320 ns |     71.38 ns |  3.92 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     72.39 ns |   1.2915 ns |   1.2081 ns |     72.43 ns |  3.97 |    0.07 |
|                                           ForeachDelegate |            [0] |     21.23 ns |   0.0092 ns |   0.0086 ns |     21.23 ns |  1.16 |    0.00 |
|                                                   Foreach |            [0] |     18.22 ns |   0.0107 ns |   0.0100 ns |     18.22 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **19,530.14 ns** | **385.9185 ns** | **939.3791 ns** | **19,439.18 ns** |  **3.62** |    **0.22** |
|                                   LowCostLinqWithDelegate |         [1000] | 14,555.09 ns | 207.0433 ns | 193.6684 ns | 14,545.98 ns |  2.63 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 14,299.65 ns | 283.5076 ns | 518.4096 ns | 14,407.72 ns |  2.56 |    0.09 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 14,328.88 ns | 285.7488 ns | 777.4008 ns | 14,168.50 ns |  2.60 |    0.14 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 13,707.92 ns | 273.8653 ns | 514.3853 ns | 13,424.50 ns |  2.48 |    0.09 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,123.26 ns |  11.5367 ns |   9.0071 ns |  7,122.55 ns |  1.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,755.25 ns |   2.2693 ns |   2.1227 ns |  6,756.21 ns |  1.22 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 31,687.62 ns | 314.7519 ns | 279.0193 ns | 31,625.83 ns |  5.74 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 28,965.62 ns | 571.3421 ns | 586.7263 ns | 29,064.90 ns |  5.25 |    0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 13,780.19 ns |   4.4810 ns |   3.9723 ns | 13,780.69 ns |  2.49 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 14,796.82 ns |   2.4215 ns |   2.1466 ns | 14,797.16 ns |  2.68 |    0.00 |
|                                                 LinqCount |         [1000] | 12,704.18 ns | 250.5800 ns | 351.2782 ns | 12,716.87 ns |  2.30 |    0.08 |
|                              LowCostLinqWithDelegateCount |         [1000] | 19,823.70 ns | 385.5318 ns | 428.5176 ns | 19,938.93 ns |  3.58 |    0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 12,746.87 ns | 252.0175 ns | 467.1306 ns | 12,714.56 ns |  2.28 |    0.07 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,582.09 ns |   9.2681 ns |   8.6694 ns |  5,584.07 ns |  1.01 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,096.46 ns |  82.8280 ns |  77.4774 ns |  6,034.44 ns |  1.10 |    0.01 |
|                                               LinqToArray |         [1000] | 14,279.73 ns |  29.2546 ns |  27.3648 ns | 14,278.24 ns |  2.58 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 14,969.82 ns |  16.6828 ns |  15.6051 ns | 14,966.54 ns |  2.71 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 14,517.87 ns |  37.7717 ns |  33.4836 ns | 14,507.32 ns |  2.63 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,552.96 ns |   2.7421 ns |   2.5650 ns |  7,552.87 ns |  1.37 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,680.14 ns |   8.8949 ns |   7.8851 ns |  7,680.76 ns |  1.39 |    0.00 |
|                                                      Take |         [1000] |    600.22 ns |  11.7503 ns |  12.5727 ns |    590.03 ns |  0.11 |    0.00 |
|                                               LowCostTake |         [1000] |    345.62 ns |   0.7405 ns |   0.6183 ns |    345.58 ns |  0.06 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    348.07 ns |   6.8587 ns |   9.1562 ns |    352.73 ns |  0.06 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    220.39 ns |   2.9241 ns |   2.7352 ns |    218.45 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    206.79 ns |   0.1149 ns |   0.1074 ns |    206.81 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    490.30 ns |   0.5565 ns |   0.4933 ns |    490.14 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    378.75 ns |   5.1290 ns |   4.7977 ns |    379.14 ns |  0.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    373.10 ns |   6.1923 ns |   5.7922 ns |    376.90 ns |  0.07 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    231.24 ns |   0.0660 ns |   0.0618 ns |    231.22 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    230.55 ns |   0.1091 ns |   0.0852 ns |    230.53 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,379.10 ns |   5.1767 ns |   4.5890 ns |  9,379.64 ns |  1.70 |    0.00 |
|                                                   Foreach |         [1000] |  5,524.82 ns |   1.0562 ns |   0.9879 ns |  5,524.35 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **953.89 ns** |   **3.1185 ns** |   **2.9170 ns** |    **954.22 ns** |  **3.12** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    793.03 ns |  15.7487 ns |  24.9792 ns |    801.73 ns |  2.59 |    0.07 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    760.24 ns |  10.9151 ns |  10.2100 ns |    762.79 ns |  2.49 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |    779.30 ns |  15.3100 ns |  19.3622 ns |    780.84 ns |  2.55 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    728.36 ns |  13.0867 ns |  12.2413 ns |    720.70 ns |  2.38 |    0.04 |
|                                LowCostLinqWithStructWhere |           [50] |    416.68 ns |   0.4151 ns |   0.3680 ns |    416.74 ns |  1.36 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    397.65 ns |   5.3434 ns |   4.9982 ns |    393.75 ns |  1.30 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,511.38 ns |  20.6392 ns |  19.3059 ns |  1,510.58 ns |  4.94 |    0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,546.05 ns |   9.4087 ns |   8.8009 ns |  1,547.55 ns |  5.06 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    812.97 ns |   0.2087 ns |   0.1952 ns |    812.96 ns |  2.66 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    854.49 ns |   0.1333 ns |   0.1181 ns |    854.52 ns |  2.79 |    0.00 |
|                                                 LinqCount |           [50] |    733.55 ns |   2.5351 ns |   2.3713 ns |    733.84 ns |  2.40 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    661.91 ns |   1.5122 ns |   1.3405 ns |    661.42 ns |  2.16 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    701.17 ns |  13.8869 ns |  25.7403 ns |    710.78 ns |  2.28 |    0.09 |
|                           LowCostLinqWithStructWhereCount |           [50] |    332.14 ns |   0.0944 ns |   0.0883 ns |    332.16 ns |  1.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    352.36 ns |   0.2093 ns |   0.1856 ns |    352.33 ns |  1.15 |    0.00 |
|                                               LinqToArray |           [50] |  1,057.52 ns |   0.6991 ns |   0.6198 ns |  1,057.39 ns |  3.46 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    939.96 ns |   2.1683 ns |   2.0283 ns |    940.39 ns |  3.07 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    920.50 ns |   1.4384 ns |   1.3454 ns |    920.07 ns |  3.01 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    543.27 ns |   0.3611 ns |   0.3015 ns |    543.26 ns |  1.78 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    546.03 ns |   0.2344 ns |   0.2193 ns |    546.02 ns |  1.79 |    0.00 |
|                                                      Take |           [50] |    601.50 ns |   0.6902 ns |   0.6457 ns |    601.38 ns |  1.97 |    0.00 |
|                                               LowCostTake |           [50] |    356.70 ns |   5.4825 ns |   5.1283 ns |    359.20 ns |  1.17 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    434.22 ns |   2.5781 ns |   2.1528 ns |    433.80 ns |  1.42 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    216.35 ns |   0.0687 ns |   0.0642 ns |    216.34 ns |  0.71 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    208.36 ns |   0.0298 ns |   0.0265 ns |    208.36 ns |  0.68 |    0.00 |
|                                            SkipTakeSingle |           [50] |    509.09 ns |  10.1447 ns |  12.4587 ns |    503.95 ns |  1.68 |    0.04 |
|                                     LowCostSkipTakeSingle |           [50] |    411.68 ns |   8.1463 ns |  14.2676 ns |    417.55 ns |  1.36 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    377.04 ns |   4.0886 ns |   3.8244 ns |    375.36 ns |  1.23 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    229.63 ns |   0.0877 ns |   0.0820 ns |    229.59 ns |  0.75 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    233.01 ns |   0.0848 ns |   0.0752 ns |    232.99 ns |  0.76 |    0.00 |
|                                           ForeachDelegate |           [50] |    511.35 ns |  10.2296 ns |  11.3702 ns |    504.84 ns |  1.68 |    0.04 |
|                                                   Foreach |           [50] |    305.78 ns |   0.0582 ns |   0.0544 ns |    305.79 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **211.21 ns** |   **1.6853 ns** |   **1.4073 ns** |    **210.62 ns** |  **4.69** |    **0.03** |
|                                   LowCostLinqWithDelegate |            [5] |    129.79 ns |   0.3298 ns |   0.3085 ns |    129.80 ns |  2.88 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    124.85 ns |   2.3853 ns |   2.5522 ns |    123.38 ns |  2.78 |    0.06 |
|                                  LowCostLinqWithDelegate2 |            [5] |    148.66 ns |   0.8070 ns |   0.7549 ns |    148.88 ns |  3.30 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    135.25 ns |   0.9145 ns |   0.8554 ns |    134.81 ns |  3.00 |    0.02 |
|                                LowCostLinqWithStructWhere |            [5] |     85.73 ns |   0.0387 ns |   0.0362 ns |     85.72 ns |  1.90 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     86.46 ns |   1.2205 ns |   1.1417 ns |     86.38 ns |  1.92 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    275.24 ns |   0.2573 ns |   0.2406 ns |    275.32 ns |  6.11 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    280.40 ns |   1.2555 ns |   1.1130 ns |    280.59 ns |  6.22 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    192.01 ns |   0.0747 ns |   0.0623 ns |    192.00 ns |  4.26 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    191.80 ns |   3.1751 ns |   2.9700 ns |    190.12 ns |  4.26 |    0.07 |
|                                                 LinqCount |            [5] |    189.65 ns |   0.0565 ns |   0.0529 ns |    189.66 ns |  4.21 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    125.05 ns |   0.7082 ns |   0.6625 ns |    125.24 ns |  2.78 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    122.04 ns |   0.1383 ns |   0.1226 ns |    122.02 ns |  2.71 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     77.76 ns |   1.2643 ns |   1.1826 ns |     76.87 ns |  1.73 |    0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     77.21 ns |   0.0433 ns |   0.0384 ns |     77.22 ns |  1.71 |    0.00 |
|                                               LinqToArray |            [5] |    262.23 ns |   0.0760 ns |   0.0674 ns |    262.24 ns |  5.82 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    170.96 ns |   0.1574 ns |   0.1472 ns |    171.00 ns |  3.80 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    169.23 ns |   0.2575 ns |   0.2011 ns |    169.13 ns |  3.76 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    125.61 ns |   0.0250 ns |   0.0209 ns |    125.62 ns |  2.79 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    125.82 ns |   0.0369 ns |   0.0345 ns |    125.81 ns |  2.79 |    0.00 |
|                                                      Take |            [5] |    276.79 ns |   0.0779 ns |   0.0729 ns |    276.76 ns |  6.14 |    0.00 |
|                                               LowCostTake |            [5] |    142.46 ns |   2.6876 ns |   2.5140 ns |    142.40 ns |  3.16 |    0.06 |
|                                  LowCostTakeWithoutChecks |            [5] |    130.03 ns |   0.8175 ns |   0.7247 ns |    129.98 ns |  2.89 |    0.02 |
|                                     LowCostTakeWithStruct |            [5] |     95.17 ns |   0.0496 ns |   0.0464 ns |     95.16 ns |  2.11 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     93.10 ns |   0.0366 ns |   0.0306 ns |     93.08 ns |  2.07 |    0.00 |
|                                            SkipTakeSingle |            [5] |    267.82 ns |   5.2413 ns |   7.6827 ns |    263.74 ns |  6.06 |    0.19 |
|                                     LowCostSkipTakeSingle |            [5] |    147.87 ns |   0.6017 ns |   0.5628 ns |    147.63 ns |  3.28 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    154.03 ns |   0.3389 ns |   0.3170 ns |    154.09 ns |  3.42 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    105.72 ns |   1.5355 ns |   1.4363 ns |    104.72 ns |  2.35 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    106.04 ns |   0.0278 ns |   0.0260 ns |    106.05 ns |  2.35 |    0.00 |
|                                           ForeachDelegate |            [5] |     67.67 ns |   0.0238 ns |   0.0199 ns |     67.67 ns |  1.50 |    0.00 |
|                                                   Foreach |            [5] |     45.04 ns |   0.0111 ns |   0.0099 ns |     45.04 ns |  1.00 |    0.00 |
