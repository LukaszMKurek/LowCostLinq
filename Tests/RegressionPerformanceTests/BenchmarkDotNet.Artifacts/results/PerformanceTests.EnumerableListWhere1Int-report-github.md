``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **38.15 ns** |  **0.3782 ns** |  **0.3538 ns** |     **38.24 ns** |  **2.22** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |     32.20 ns |  0.0112 ns |  0.0105 ns |     32.21 ns |  1.87 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     23.48 ns |  0.0075 ns |  0.0070 ns |     23.47 ns |  1.37 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     39.49 ns |  0.1389 ns |  0.1231 ns |     39.43 ns |  2.30 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     33.98 ns |  0.5854 ns |  0.5476 ns |     34.02 ns |  1.98 |    0.03 |
|                                LowCostLinqWithStructWhere |            [0] |     37.33 ns |  0.0734 ns |  0.0651 ns |     37.34 ns |  2.17 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     30.20 ns |  0.0085 ns |  0.0075 ns |     30.20 ns |  1.76 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     84.51 ns |  0.3642 ns |  0.3406 ns |     84.30 ns |  4.92 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     69.46 ns |  1.4196 ns |  1.9901 ns |     68.37 ns |  4.10 |    0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     87.02 ns |  0.0773 ns |  0.0685 ns |     87.01 ns |  5.07 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     67.74 ns |  0.0311 ns |  0.0291 ns |     67.74 ns |  3.94 |    0.00 |
|                                                 LinqCount |            [0] |     33.77 ns |  0.0442 ns |  0.0414 ns |     33.79 ns |  1.97 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     31.60 ns |  0.1076 ns |  0.0840 ns |     31.59 ns |  1.84 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     28.74 ns |  0.0288 ns |  0.0269 ns |     28.73 ns |  1.67 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     29.80 ns |  0.0134 ns |  0.0119 ns |     29.80 ns |  1.73 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     21.90 ns |  0.0010 ns |  0.0008 ns |     21.90 ns |  1.28 |    0.00 |
|                                               LinqToArray |            [0] |     45.01 ns |  0.0467 ns |  0.0365 ns |     45.00 ns |  2.62 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     43.47 ns |  0.0512 ns |  0.0454 ns |     43.48 ns |  2.53 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     41.28 ns |  0.0270 ns |  0.0253 ns |     41.28 ns |  2.40 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     40.06 ns |  0.0207 ns |  0.0173 ns |     40.06 ns |  2.33 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     33.09 ns |  0.0282 ns |  0.0250 ns |     33.09 ns |  1.93 |    0.00 |
|                                                      Take |            [0] |     69.99 ns |  0.0326 ns |  0.0305 ns |     69.99 ns |  4.07 |    0.00 |
|                                               LowCostTake |            [0] |     40.74 ns |  0.0136 ns |  0.0127 ns |     40.74 ns |  2.37 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     32.69 ns |  0.0173 ns |  0.0161 ns |     32.69 ns |  1.90 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     42.85 ns |  0.0246 ns |  0.0230 ns |     42.85 ns |  2.49 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     36.22 ns |  0.0842 ns |  0.0787 ns |     36.26 ns |  2.11 |    0.00 |
|                                            SkipTakeSingle |            [0] |     93.41 ns |  0.1737 ns |  0.1450 ns |     93.43 ns |  5.44 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     46.63 ns |  0.0102 ns |  0.0095 ns |     46.63 ns |  2.71 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     45.25 ns |  0.0215 ns |  0.0201 ns |     45.26 ns |  2.63 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     50.16 ns |  0.0111 ns |  0.0103 ns |     50.16 ns |  2.92 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     42.80 ns |  0.0055 ns |  0.0049 ns |     42.80 ns |  2.49 |    0.00 |
|                                           ForeachDelegate |            [0] |     19.89 ns |  0.0505 ns |  0.0447 ns |     19.88 ns |  1.16 |    0.00 |
|                                                   Foreach |            [0] |     17.18 ns |  0.0094 ns |  0.0087 ns |     17.18 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |         **[1000]** |  **6,799.90 ns** |  **3.0302 ns** |  **2.8345 ns** |  **6,800.21 ns** |  **1.23** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  4,339.09 ns |  1.0325 ns |  0.9658 ns |  4,338.94 ns |  0.79 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  3,381.26 ns |  3.3419 ns |  3.1261 ns |  3,381.81 ns |  0.61 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  4,532.23 ns | 10.0714 ns |  9.4208 ns |  4,536.54 ns |  0.82 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  3,623.20 ns |  0.4385 ns |  0.3887 ns |  3,623.29 ns |  0.66 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,438.01 ns |  3.5963 ns |  3.3640 ns |  2,437.99 ns |  0.44 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,474.08 ns |  0.2067 ns |  0.1933 ns |  1,474.05 ns |  0.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 11,168.66 ns | 18.0139 ns | 16.8502 ns | 11,172.40 ns |  2.02 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 10,854.66 ns |  6.3962 ns |  5.9830 ns | 10,855.28 ns |  1.97 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,928.21 ns |  7.7019 ns |  7.2043 ns |  9,929.94 ns |  1.80 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,705.69 ns |  3.6317 ns |  3.3971 ns |  8,706.00 ns |  1.58 |    0.00 |
|                                                 LinqCount |         [1000] |  2,009.60 ns | 18.0602 ns | 16.8935 ns |  2,012.61 ns |  0.36 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  3,623.55 ns |  9.6374 ns |  9.0149 ns |  3,617.55 ns |  0.66 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  2,421.66 ns |  0.5170 ns |  0.4836 ns |  2,421.73 ns |  0.44 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,711.28 ns |  0.1229 ns |  0.1089 ns |  1,711.25 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    625.48 ns |  0.7232 ns |  0.6764 ns |    625.41 ns |  0.11 |    0.00 |
|                                               LinqToArray |         [1000] |  3,356.05 ns |  3.2965 ns |  3.0836 ns |  3,356.77 ns |  0.61 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  5,290.52 ns |  3.2938 ns |  2.9199 ns |  5,291.10 ns |  0.96 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  4,119.94 ns |  4.7143 ns |  4.1791 ns |  4,119.75 ns |  0.75 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,729.47 ns |  8.2506 ns |  7.3140 ns |  3,730.77 ns |  0.68 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,390.08 ns |  1.6528 ns |  1.5460 ns |  2,390.34 ns |  0.43 |    0.00 |
|                                                      Take |         [1000] |    339.98 ns |  6.6702 ns |  6.5510 ns |    335.20 ns |  0.06 |    0.00 |
|                                               LowCostTake |         [1000] |    150.84 ns |  0.1210 ns |  0.1132 ns |    150.78 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    115.69 ns |  0.0859 ns |  0.0803 ns |    115.64 ns |  0.02 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    108.46 ns |  1.4072 ns |  1.3163 ns |    107.49 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     78.31 ns |  0.0145 ns |  0.0135 ns |     78.30 ns |  0.01 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    225.55 ns |  0.0260 ns |  0.0230 ns |    225.55 ns |  0.04 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    143.18 ns |  0.1429 ns |  0.1337 ns |    143.17 ns |  0.03 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    116.05 ns |  0.0357 ns |  0.0334 ns |    116.05 ns |  0.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     92.79 ns |  0.0131 ns |  0.0122 ns |     92.78 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     65.57 ns |  0.0835 ns |  0.0697 ns |     65.57 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,966.39 ns |  1.0080 ns |  0.8935 ns |  6,966.24 ns |  1.26 |    0.00 |
|                                                   Foreach |         [1000] |  5,523.63 ns |  0.8272 ns |  0.7333 ns |  5,523.77 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |           **[50]** |    **391.13 ns** |  **0.0765 ns** |  **0.0716 ns** |    **391.13 ns** |  **1.30** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    254.00 ns |  0.0267 ns |  0.0237 ns |    253.99 ns |  0.85 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    196.69 ns |  0.0345 ns |  0.0306 ns |    196.69 ns |  0.66 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    266.88 ns |  0.1773 ns |  0.1384 ns |    266.81 ns |  0.89 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    215.58 ns |  0.0139 ns |  0.0116 ns |    215.59 ns |  0.72 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    163.57 ns |  0.1341 ns |  0.1254 ns |    163.56 ns |  0.55 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    110.45 ns |  0.0667 ns |  0.0624 ns |    110.44 ns |  0.37 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    661.81 ns |  0.3092 ns |  0.2582 ns |    661.84 ns |  2.21 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    622.29 ns |  0.2513 ns |  0.2351 ns |    622.22 ns |  2.07 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    589.26 ns |  0.3729 ns |  0.3306 ns |    589.25 ns |  1.96 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    508.04 ns |  0.1961 ns |  0.1739 ns |    507.98 ns |  1.69 |    0.00 |
|                                                 LinqCount |           [50] |    137.51 ns |  0.2451 ns |  0.2292 ns |    137.51 ns |  0.46 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    213.22 ns |  0.0799 ns |  0.0747 ns |    213.22 ns |  0.71 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    154.26 ns |  0.0731 ns |  0.0683 ns |    154.27 ns |  0.51 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    118.87 ns |  0.0214 ns |  0.0179 ns |    118.87 ns |  0.40 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     51.95 ns |  0.0727 ns |  0.0680 ns |     51.92 ns |  0.17 |    0.00 |
|                                               LinqToArray |           [50] |    361.73 ns |  0.0820 ns |  0.0727 ns |    361.71 ns |  1.21 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    389.36 ns |  0.2554 ns |  0.2389 ns |    389.34 ns |  1.30 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    318.98 ns |  0.2643 ns |  0.2343 ns |    318.89 ns |  1.06 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    305.70 ns |  0.1263 ns |  0.1119 ns |    305.70 ns |  1.02 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    217.71 ns |  0.4481 ns |  0.4192 ns |    217.48 ns |  0.73 |    0.00 |
|                                                      Take |           [50] |    333.44 ns |  0.1150 ns |  0.1020 ns |    333.45 ns |  1.11 |    0.00 |
|                                               LowCostTake |           [50] |    144.31 ns |  0.0341 ns |  0.0266 ns |    144.30 ns |  0.48 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    115.84 ns |  0.1367 ns |  0.1278 ns |    115.86 ns |  0.39 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    107.48 ns |  0.0596 ns |  0.0529 ns |    107.46 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     77.34 ns |  0.0088 ns |  0.0082 ns |     77.34 ns |  0.26 |    0.00 |
|                                            SkipTakeSingle |           [50] |    229.28 ns |  3.8925 ns |  3.6410 ns |    227.30 ns |  0.76 |    0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    143.74 ns |  0.4781 ns |  0.4473 ns |    143.97 ns |  0.48 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    116.41 ns |  0.0640 ns |  0.0599 ns |    116.41 ns |  0.39 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     92.43 ns |  0.0571 ns |  0.0534 ns |     92.45 ns |  0.31 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     66.12 ns |  0.0316 ns |  0.0296 ns |     66.11 ns |  0.22 |    0.00 |
|                                           ForeachDelegate |           [50] |    382.28 ns |  0.1278 ns |  0.1195 ns |    382.27 ns |  1.27 |    0.00 |
|                                                   Foreach |           [50] |    300.08 ns |  0.0705 ns |  0.0660 ns |    300.08 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |            **[5]** |     **73.10 ns** |  **0.0530 ns** |  **0.0496 ns** |     **73.09 ns** |  **1.61** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     55.27 ns |  0.0102 ns |  0.0080 ns |     55.28 ns |  1.22 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     42.10 ns |  0.0322 ns |  0.0269 ns |     42.10 ns |  0.93 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     61.69 ns |  0.0569 ns |  0.0476 ns |     61.68 ns |  1.36 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     51.08 ns |  0.1012 ns |  0.0845 ns |     51.05 ns |  1.12 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     50.85 ns |  0.0801 ns |  0.0749 ns |     50.81 ns |  1.12 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     38.57 ns |  0.5319 ns |  0.4976 ns |     38.42 ns |  0.85 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    148.58 ns |  0.0630 ns |  0.0558 ns |    148.58 ns |  3.27 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    124.47 ns |  0.0522 ns |  0.0489 ns |    124.47 ns |  2.74 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    140.19 ns |  0.0533 ns |  0.0473 ns |    140.18 ns |  3.09 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    116.78 ns |  2.2651 ns |  2.2246 ns |    115.35 ns |  2.58 |    0.05 |
|                                                 LinqCount |            [5] |     43.80 ns |  0.0704 ns |  0.0659 ns |     43.78 ns |  0.96 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     49.68 ns |  0.0138 ns |  0.0129 ns |     49.68 ns |  1.09 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     42.25 ns |  0.6284 ns |  0.5878 ns |     41.91 ns |  0.93 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     37.99 ns |  0.0343 ns |  0.0304 ns |     37.99 ns |  0.84 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     24.65 ns |  0.0541 ns |  0.0506 ns |     24.66 ns |  0.54 |    0.00 |
|                                               LinqToArray |            [5] |     98.96 ns |  0.0368 ns |  0.0327 ns |     98.96 ns |  2.18 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |     95.92 ns |  0.1614 ns |  0.1510 ns |     95.84 ns |  2.11 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     86.94 ns |  0.0368 ns |  0.0326 ns |     86.93 ns |  1.91 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     85.82 ns |  0.0431 ns |  0.0404 ns |     85.81 ns |  1.89 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     69.07 ns |  0.0257 ns |  0.0228 ns |     69.07 ns |  1.52 |    0.00 |
|                                                      Take |            [5] |    135.10 ns |  0.1757 ns |  0.1644 ns |    135.08 ns |  2.97 |    0.01 |
|                                               LowCostTake |            [5] |     65.69 ns |  0.0771 ns |  0.0721 ns |     65.69 ns |  1.45 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     53.56 ns |  0.0105 ns |  0.0093 ns |     53.56 ns |  1.18 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     59.31 ns |  0.1690 ns |  0.1581 ns |     59.28 ns |  1.31 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     47.94 ns |  0.0145 ns |  0.0128 ns |     47.94 ns |  1.06 |    0.00 |
|                                            SkipTakeSingle |            [5] |    123.21 ns |  0.0760 ns |  0.0711 ns |    123.20 ns |  2.71 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     65.44 ns |  0.0139 ns |  0.0130 ns |     65.44 ns |  1.44 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     58.82 ns |  0.0175 ns |  0.0164 ns |     58.82 ns |  1.29 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     59.55 ns |  0.0237 ns |  0.0210 ns |     59.56 ns |  1.31 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.86 ns |  0.0188 ns |  0.0176 ns |     46.85 ns |  1.03 |    0.00 |
|                                           ForeachDelegate |            [5] |     54.49 ns |  0.0075 ns |  0.0070 ns |     54.49 ns |  1.20 |    0.00 |
|                                                   Foreach |            [5] |     45.44 ns |  0.0801 ns |  0.0669 ns |     45.45 ns |  1.00 |    0.00 |
