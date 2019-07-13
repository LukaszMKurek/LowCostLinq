``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **66.00 ns** |   **0.0995 ns** |   **0.0931 ns** |     **66.02 ns** |  **3.93** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     37.66 ns |   0.0304 ns |   0.0284 ns |     37.65 ns |  2.24 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     25.80 ns |   0.0043 ns |   0.0040 ns |     25.80 ns |  1.54 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     46.97 ns |   0.0354 ns |   0.0296 ns |     46.95 ns |  2.80 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     43.56 ns |   0.0217 ns |   0.0203 ns |     43.56 ns |  2.60 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     42.64 ns |   0.0145 ns |   0.0128 ns |     42.63 ns |  2.54 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     36.13 ns |   0.3389 ns |   0.3170 ns |     35.91 ns |  2.15 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     60.77 ns |   0.0236 ns |   0.0220 ns |     60.77 ns |  3.62 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     52.01 ns |   0.0325 ns |   0.0304 ns |     52.00 ns |  3.10 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     46.56 ns |   1.0787 ns |   1.0090 ns |     46.02 ns |  2.77 |    0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     38.85 ns |   0.0146 ns |   0.0137 ns |     38.85 ns |  2.32 |    0.00 |
|                                                 LinqCount |            [0] |     64.13 ns |   0.1351 ns |   0.1264 ns |     64.15 ns |  3.82 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     34.95 ns |   0.0169 ns |   0.0158 ns |     34.95 ns |  2.08 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.89 ns |   0.0260 ns |   0.0243 ns |     33.89 ns |  2.02 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.70 ns |   0.0082 ns |   0.0077 ns |     37.70 ns |  2.25 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     29.89 ns |   0.0057 ns |   0.0050 ns |     29.89 ns |  1.78 |    0.00 |
|                                               LinqToArray |            [0] |     78.42 ns |   0.0521 ns |   0.0462 ns |     78.42 ns |  4.67 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     47.66 ns |   0.9113 ns |   0.8524 ns |     47.15 ns |  2.83 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     45.50 ns |   0.3253 ns |   0.2716 ns |     45.40 ns |  2.71 |    0.02 |
|                              LowCostLinqWithStructToArray |            [0] |     45.99 ns |   0.0067 ns |   0.0056 ns |     45.99 ns |  2.74 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     38.92 ns |   0.0128 ns |   0.0114 ns |     38.91 ns |  2.32 |    0.00 |
|                                                      Take |            [0] |    104.19 ns |   2.0585 ns |   2.2880 ns |    102.77 ns |  6.24 |    0.15 |
|                                               LowCostTake |            [0] |     41.73 ns |   0.0091 ns |   0.0080 ns |     41.73 ns |  2.49 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     36.79 ns |   0.0331 ns |   0.0276 ns |     36.79 ns |  2.19 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     49.30 ns |   0.5104 ns |   0.4524 ns |     49.00 ns |  2.94 |    0.03 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     40.99 ns |   0.0117 ns |   0.0097 ns |     40.99 ns |  2.44 |    0.00 |
|                                            SkipTakeSingle |            [0] |    126.66 ns |   0.0426 ns |   0.0398 ns |    126.66 ns |  7.55 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     50.92 ns |   0.0129 ns |   0.0108 ns |     50.92 ns |  3.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     49.47 ns |   0.0251 ns |   0.0222 ns |     49.47 ns |  2.95 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     60.13 ns |   0.0123 ns |   0.0109 ns |     60.13 ns |  3.58 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     52.28 ns |   0.0633 ns |   0.0592 ns |     52.30 ns |  3.12 |    0.00 |
|                                           ForeachDelegate |            [0] |     20.21 ns |   0.4244 ns |   0.4717 ns |     19.85 ns |  1.21 |    0.03 |
|                                                   Foreach |            [0] |     16.78 ns |   0.0071 ns |   0.0063 ns |     16.78 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** |  **8,932.32 ns** |   **4.3329 ns** |   **4.0530 ns** |  **8,931.39 ns** |  **1.62** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  6,899.03 ns | 133.0351 ns | 195.0012 ns |  6,838.57 ns |  1.25 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,109.87 ns | 121.6670 ns | 107.8546 ns |  6,108.72 ns |  1.11 |    0.02 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  7,438.67 ns | 141.4805 ns | 151.3825 ns |  7,436.56 ns |  1.35 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,730.22 ns | 131.3789 ns | 188.4197 ns |  6,732.11 ns |  1.23 |    0.04 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,442.14 ns |   3.2113 ns |   3.0039 ns |  2,441.42 ns |  0.44 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,473.23 ns |   0.1450 ns |   0.1356 ns |  1,473.22 ns |  0.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 15,660.67 ns | 181.2364 ns | 160.6613 ns | 15,649.08 ns |  2.84 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 15,120.18 ns | 204.1008 ns | 180.9300 ns | 15,051.22 ns |  2.74 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,545.63 ns |   2.6567 ns |   2.3551 ns |  5,545.84 ns |  1.01 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  4,603.81 ns |   5.3859 ns |   5.0380 ns |  4,604.59 ns |  0.83 |    0.00 |
|                                                 LinqCount |         [1000] |  3,912.44 ns |   3.6511 ns |   3.4152 ns |  3,912.72 ns |  0.71 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,577.24 ns | 128.6733 ns | 196.4977 ns |  6,488.90 ns |  1.20 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,470.44 ns |  98.3194 ns |  91.9680 ns |  5,441.44 ns |  0.99 |    0.02 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,712.72 ns |   1.1309 ns |   1.0025 ns |  1,712.36 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    631.07 ns |   0.1224 ns |   0.1145 ns |    631.04 ns |  0.11 |    0.00 |
|                                               LinqToArray |         [1000] |  5,365.82 ns |  11.4255 ns |  10.6874 ns |  5,368.20 ns |  0.97 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,436.35 ns |  10.0215 ns |   9.3741 ns |  7,437.07 ns |  1.35 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,564.32 ns |   4.4254 ns |   3.6954 ns |  6,564.32 ns |  1.19 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,113.97 ns |   1.3673 ns |   1.2120 ns |  3,114.03 ns |  0.56 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,912.18 ns |   1.2027 ns |   1.0662 ns |  1,911.95 ns |  0.35 |    0.00 |
|                                                      Take |         [1000] |    401.11 ns |   7.8059 ns |   8.3522 ns |    395.39 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    202.13 ns |   4.3844 ns |   4.8732 ns |    202.01 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    162.46 ns |   3.1411 ns |   3.0850 ns |    162.96 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    113.85 ns |   1.4355 ns |   1.3428 ns |    112.95 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     79.57 ns |   0.0512 ns |   0.0453 ns |     79.58 ns |  0.01 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    313.81 ns |   0.1374 ns |   0.1147 ns |    313.79 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    203.20 ns |   4.0321 ns |   5.0993 ns |    203.20 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    177.34 ns |   3.2733 ns |   3.0618 ns |    176.69 ns |  0.03 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    102.24 ns |   0.0345 ns |   0.0306 ns |    102.25 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     78.95 ns |   0.3592 ns |   0.3000 ns |     78.93 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,672.26 ns |   3.2187 ns |   3.0108 ns |  8,671.64 ns |  1.57 |    0.00 |
|                                                   Foreach |         [1000] |  5,517.15 ns |   0.9204 ns |   0.8610 ns |  5,517.26 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **521.23 ns** |   **0.3770 ns** |   **0.3526 ns** |    **521.15 ns** |  **1.72** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    407.07 ns |   8.4243 ns |  16.4310 ns |    401.14 ns |  1.35 |    0.07 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    341.04 ns |   6.5104 ns |   6.0898 ns |    340.31 ns |  1.12 |    0.02 |
|                                  LowCostLinqWithDelegate2 |           [50] |    427.66 ns |   8.5808 ns |  12.5776 ns |    428.83 ns |  1.43 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    366.49 ns |   5.1385 ns |   4.5551 ns |    366.39 ns |  1.21 |    0.02 |
|                                LowCostLinqWithStructWhere |           [50] |    169.65 ns |   0.2682 ns |   0.2509 ns |    169.65 ns |  0.56 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    117.32 ns |   0.0661 ns |   0.0516 ns |    117.30 ns |  0.39 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    838.96 ns |   1.5295 ns |   1.4307 ns |    839.38 ns |  2.76 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    804.02 ns |   0.7615 ns |   0.7123 ns |    803.94 ns |  2.65 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    336.35 ns |   6.6738 ns |   6.5545 ns |    332.84 ns |  1.11 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    274.98 ns |   0.1303 ns |   0.1219 ns |    274.94 ns |  0.91 |    0.00 |
|                                                 LinqCount |           [50] |    268.51 ns |   0.3760 ns |   0.3517 ns |    268.59 ns |  0.88 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    377.37 ns |   6.8530 ns |   8.6668 ns |    377.05 ns |  1.25 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    319.67 ns |   6.3259 ns |   6.7686 ns |    318.77 ns |  1.05 |    0.02 |
|                           LowCostLinqWithStructWhereCount |           [50] |    127.38 ns |   0.1083 ns |   0.1013 ns |    127.37 ns |  0.42 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     59.41 ns |   0.0705 ns |   0.0660 ns |     59.39 ns |  0.20 |    0.00 |
|                                               LinqToArray |           [50] |    522.17 ns |   0.2001 ns |   0.1872 ns |    522.20 ns |  1.72 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    535.86 ns |  10.5160 ns |  14.0386 ns |    526.88 ns |  1.78 |    0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    481.40 ns |   0.5624 ns |   0.5261 ns |    481.30 ns |  1.58 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    272.17 ns |   0.1191 ns |   0.1056 ns |    272.17 ns |  0.90 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    210.49 ns |   0.2457 ns |   0.2298 ns |    210.53 ns |  0.69 |    0.00 |
|                                                      Take |           [50] |    394.62 ns |   0.0995 ns |   0.0931 ns |    394.58 ns |  1.30 |    0.00 |
|                                               LowCostTake |           [50] |    192.27 ns |   2.5884 ns |   2.4212 ns |    191.35 ns |  0.63 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    162.73 ns |   3.2368 ns |   3.4633 ns |    162.64 ns |  0.53 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    113.70 ns |   0.0512 ns |   0.0479 ns |    113.71 ns |  0.37 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     79.22 ns |   0.0352 ns |   0.0294 ns |     79.21 ns |  0.26 |    0.00 |
|                                            SkipTakeSingle |           [50] |    314.54 ns |   0.1569 ns |   0.1468 ns |    314.52 ns |  1.04 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    206.57 ns |   4.3084 ns |   5.1288 ns |    205.17 ns |  0.68 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    176.36 ns |   1.9177 ns |   1.7939 ns |    175.40 ns |  0.58 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    101.63 ns |   0.0294 ns |   0.0230 ns |    101.64 ns |  0.33 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     78.16 ns |   0.7141 ns |   0.6680 ns |     77.85 ns |  0.26 |    0.00 |
|                                           ForeachDelegate |           [50] |    461.60 ns |   0.0779 ns |   0.0729 ns |    461.58 ns |  1.52 |    0.00 |
|                                                   Foreach |           [50] |    303.83 ns |   0.1270 ns |   0.1188 ns |    303.84 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **110.56 ns** |   **0.0910 ns** |   **0.0760 ns** |    **110.58 ns** |  **2.52** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     70.37 ns |   1.3672 ns |   1.6276 ns |     70.04 ns |  1.61 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     54.27 ns |   0.5354 ns |   0.5008 ns |     53.99 ns |  1.24 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |     80.09 ns |   1.5426 ns |   1.6506 ns |     80.46 ns |  1.83 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     70.89 ns |   0.8013 ns |   0.7496 ns |     70.50 ns |  1.62 |    0.02 |
|                                LowCostLinqWithStructWhere |            [5] |     54.44 ns |   0.0439 ns |   0.0410 ns |     54.45 ns |  1.24 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     45.68 ns |   0.0191 ns |   0.0179 ns |     45.67 ns |  1.04 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    137.85 ns |   0.0657 ns |   0.0513 ns |    137.85 ns |  3.15 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    126.10 ns |   0.0835 ns |   0.0781 ns |    126.08 ns |  2.88 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     73.62 ns |   0.0452 ns |   0.0423 ns |     73.61 ns |  1.68 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     60.80 ns |   0.0396 ns |   0.0370 ns |     60.79 ns |  1.39 |    0.00 |
|                                                 LinqCount |            [5] |     86.91 ns |   1.6896 ns |   1.7350 ns |     85.60 ns |  1.99 |    0.04 |
|                              LowCostLinqWithDelegateCount |            [5] |     68.11 ns |   1.3674 ns |   1.4631 ns |     68.30 ns |  1.56 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     61.12 ns |   1.2364 ns |   1.3229 ns |     60.92 ns |  1.39 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [5] |     45.68 ns |   0.0729 ns |   0.0682 ns |     45.64 ns |  1.04 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     33.45 ns |   0.6269 ns |   0.5864 ns |     33.02 ns |  0.76 |    0.01 |
|                                               LinqToArray |            [5] |    146.28 ns |   0.0469 ns |   0.0439 ns |    146.28 ns |  3.34 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    125.57 ns |   0.0911 ns |   0.0852 ns |    125.56 ns |  2.87 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    116.77 ns |   0.0606 ns |   0.0506 ns |    116.75 ns |  2.67 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    100.57 ns |   2.0208 ns |   1.8903 ns |     99.09 ns |  2.30 |    0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     83.41 ns |   0.0381 ns |   0.0356 ns |     83.40 ns |  1.90 |    0.00 |
|                                                      Take |            [5] |    180.70 ns |   0.0595 ns |   0.0557 ns |    180.70 ns |  4.13 |    0.00 |
|                                               LowCostTake |            [5] |     74.50 ns |   0.5018 ns |   0.4694 ns |     74.19 ns |  1.70 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |     65.78 ns |   1.7939 ns |   1.6780 ns |     64.88 ns |  1.50 |    0.04 |
|                                     LowCostTakeWithStruct |            [5] |     63.99 ns |   0.0244 ns |   0.0228 ns |     63.99 ns |  1.46 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     54.43 ns |   0.0282 ns |   0.0264 ns |     54.43 ns |  1.24 |    0.00 |
|                                            SkipTakeSingle |            [5] |    169.47 ns |   0.0825 ns |   0.0732 ns |    169.47 ns |  3.87 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     84.06 ns |   1.6658 ns |   2.4932 ns |     83.63 ns |  1.95 |    0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     74.40 ns |   1.3377 ns |   1.2513 ns |     74.33 ns |  1.70 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     68.84 ns |   0.0289 ns |   0.0271 ns |     68.83 ns |  1.57 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     56.04 ns |   0.8503 ns |   0.7954 ns |     55.51 ns |  1.28 |    0.02 |
|                                           ForeachDelegate |            [5] |     63.10 ns |   0.0497 ns |   0.0465 ns |     63.09 ns |  1.44 |    0.00 |
|                                                   Foreach |            [5] |     43.80 ns |   0.0254 ns |   0.0226 ns |     43.80 ns |  1.00 |    0.00 |
