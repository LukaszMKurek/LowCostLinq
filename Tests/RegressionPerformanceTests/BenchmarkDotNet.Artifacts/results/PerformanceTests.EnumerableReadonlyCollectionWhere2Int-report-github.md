``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **80.96 ns** |   **0.0571 ns** |   **0.0477 ns** |     **80.95 ns** |  **4.38** |    **0.10** |
|                                   LowCostLinqWithDelegate |            [0] |     50.48 ns |   0.0114 ns |   0.0095 ns |     50.48 ns |  2.73 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     40.37 ns |   0.0196 ns |   0.0183 ns |     40.36 ns |  2.19 |    0.05 |
|                                  LowCostLinqWithDelegate2 |            [0] |     56.15 ns |   0.0762 ns |   0.0595 ns |     56.13 ns |  3.05 |    0.07 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     55.49 ns |   0.0148 ns |   0.0131 ns |     55.49 ns |  3.01 |    0.07 |
|                                LowCostLinqWithStructWhere |            [0] |     52.40 ns |   0.0211 ns |   0.0197 ns |     52.40 ns |  2.85 |    0.07 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     47.77 ns |   0.0567 ns |   0.0503 ns |     47.76 ns |  2.59 |    0.06 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     73.73 ns |   0.0541 ns |   0.0452 ns |     73.73 ns |  3.99 |    0.09 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     71.72 ns |   0.0806 ns |   0.0754 ns |     71.71 ns |  3.89 |    0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     60.00 ns |   0.0386 ns |   0.0361 ns |     59.99 ns |  3.26 |    0.08 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     59.82 ns |   0.0629 ns |   0.0526 ns |     59.82 ns |  3.24 |    0.07 |
|                                                 LinqCount |            [0] |     82.83 ns |   1.6381 ns |   1.8208 ns |     81.68 ns |  4.52 |    0.13 |
|                              LowCostLinqWithDelegateCount |            [0] |     47.62 ns |   0.1924 ns |   0.1799 ns |     47.50 ns |  2.59 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     49.53 ns |   0.0133 ns |   0.0124 ns |     49.53 ns |  2.69 |    0.06 |
|                           LowCostLinqWithStructWhereCount |            [0] |     43.29 ns |   0.8595 ns |   0.8826 ns |     42.61 ns |  2.36 |    0.07 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     42.56 ns |   0.0141 ns |   0.0125 ns |     42.56 ns |  2.31 |    0.05 |
|                                               LinqToArray |            [0] |     95.28 ns |   0.0398 ns |   0.0353 ns |     95.28 ns |  5.16 |    0.12 |
|                            LowCostLinqWithDelegateToArray |            [0] |     64.11 ns |   0.0602 ns |   0.0503 ns |     64.10 ns |  3.47 |    0.08 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     62.39 ns |   0.0217 ns |   0.0203 ns |     62.39 ns |  3.39 |    0.08 |
|                              LowCostLinqWithStructToArray |            [0] |     52.00 ns |   0.0086 ns |   0.0076 ns |     52.00 ns |  2.82 |    0.07 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     53.30 ns |   0.0660 ns |   0.0585 ns |     53.31 ns |  2.89 |    0.07 |
|                                                      Take |            [0] |    118.86 ns |   0.0535 ns |   0.0447 ns |    118.84 ns |  6.43 |    0.15 |
|                                               LowCostTake |            [0] |     51.40 ns |   0.0217 ns |   0.0203 ns |     51.39 ns |  2.79 |    0.07 |
|                                  LowCostTakeWithoutChecks |            [0] |     47.39 ns |   0.0266 ns |   0.0249 ns |     47.39 ns |  2.57 |    0.06 |
|                                     LowCostTakeWithStruct |            [0] |     57.66 ns |   0.0587 ns |   0.0520 ns |     57.65 ns |  3.13 |    0.08 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     54.44 ns |   0.0100 ns |   0.0094 ns |     54.44 ns |  2.96 |    0.07 |
|                                            SkipTakeSingle |            [0] |    140.57 ns |   0.0299 ns |   0.0233 ns |    140.57 ns |  7.62 |    0.17 |
|                                     LowCostSkipTakeSingle |            [0] |     63.78 ns |   0.0321 ns |   0.0300 ns |     63.78 ns |  3.46 |    0.08 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     64.33 ns |   1.2865 ns |   1.5800 ns |     63.35 ns |  3.52 |    0.09 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     66.26 ns |   0.0236 ns |   0.0209 ns |     66.25 ns |  3.59 |    0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     64.28 ns |   0.0180 ns |   0.0150 ns |     64.28 ns |  3.48 |    0.08 |
|                                           ForeachDelegate |            [0] |     21.11 ns |   0.0038 ns |   0.0036 ns |     21.11 ns |  1.15 |    0.03 |
|                                                   Foreach |            [0] |     18.33 ns |   0.3861 ns |   0.4291 ns |     18.01 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **14,258.19 ns** |   **7.3626 ns** |   **6.8870 ns** | **14,258.04 ns** |  **2.58** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,149.71 ns | 213.6305 ns | 246.0172 ns | 11,112.54 ns |  2.03 |    0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 11,174.01 ns | 263.8160 ns | 282.2802 ns | 11,077.92 ns |  2.04 |    0.06 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 12,196.74 ns | 215.7828 ns | 201.8434 ns | 12,234.64 ns |  2.21 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 11,859.97 ns | 127.7661 ns | 119.5124 ns | 11,827.04 ns |  2.15 |    0.02 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,829.48 ns |  89.7668 ns |  83.9679 ns |  6,777.34 ns |  1.24 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,507.64 ns |   2.3543 ns |   2.2022 ns |  6,507.35 ns |  1.18 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 20,490.92 ns | 269.3396 ns | 251.9404 ns | 20,447.01 ns |  3.71 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,794.46 ns | 180.1273 ns | 168.4912 ns | 19,767.03 ns |  3.59 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,461.30 ns | 118.2594 ns | 110.6199 ns |  9,392.00 ns |  1.72 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,717.04 ns |  20.7010 ns |  19.3637 ns |  8,718.62 ns |  1.58 |    0.00 |
|                                                 LinqCount |         [1000] |  8,927.07 ns |   7.3863 ns |   6.9091 ns |  8,928.08 ns |  1.62 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,809.64 ns | 149.1918 ns | 139.5541 ns | 10,784.59 ns |  1.96 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,792.30 ns | 211.4102 ns | 309.8823 ns | 10,734.05 ns |  1.96 |    0.07 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,027.20 ns |   6.3772 ns |   5.6532 ns |  6,024.68 ns |  1.09 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,575.05 ns |   1.6425 ns |   1.4560 ns |  5,575.61 ns |  1.01 |    0.00 |
|                                               LinqToArray |         [1000] | 11,130.46 ns | 219.5030 ns | 252.7799 ns | 10,972.12 ns |  2.04 |    0.05 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 10,989.52 ns |   7.0470 ns |   6.5918 ns | 10,991.35 ns |  1.99 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 10,733.10 ns |   5.4903 ns |   5.1356 ns | 10,733.92 ns |  1.95 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,038.07 ns |   8.6442 ns |   6.7488 ns |  7,037.02 ns |  1.28 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  6,806.44 ns |   6.1391 ns |   5.4422 ns |  6,807.89 ns |  1.23 |    0.00 |
|                                                      Take |         [1000] |    513.56 ns |   0.1298 ns |   0.1214 ns |    513.54 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |    287.86 ns |   0.4124 ns |   0.3858 ns |    287.77 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    280.25 ns |   5.5246 ns |   7.5622 ns |    275.52 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    197.60 ns |   0.1054 ns |   0.0934 ns |    197.58 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    198.90 ns |   0.0479 ns |   0.0448 ns |    198.90 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    405.68 ns |   7.9097 ns |   9.1088 ns |    400.24 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    291.23 ns |   0.2246 ns |   0.2101 ns |    291.26 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    281.55 ns |   0.3984 ns |   0.3727 ns |    281.62 ns |  0.05 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    206.21 ns |   0.3621 ns |   0.3387 ns |    206.33 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    205.62 ns |   0.0521 ns |   0.0435 ns |    205.63 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,672.49 ns |   3.7227 ns |   3.3001 ns |  8,673.08 ns |  1.57 |    0.00 |
|                                                   Foreach |         [1000] |  5,516.39 ns |   0.6164 ns |   0.5148 ns |  5,516.45 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **807.88 ns** |  **12.6974 ns** |  **11.8771 ns** |    **798.46 ns** |  **2.65** |    **0.04** |
|                                   LowCostLinqWithDelegate |           [50] |    600.86 ns |   0.4233 ns |   0.3752 ns |    600.77 ns |  1.97 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    598.18 ns |   0.8123 ns |   0.7598 ns |    598.34 ns |  1.96 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    641.02 ns |   0.9080 ns |   0.7582 ns |    641.10 ns |  2.10 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    646.74 ns |  12.6117 ns |  16.8363 ns |    637.36 ns |  2.14 |    0.06 |
|                                LowCostLinqWithStructWhere |           [50] |    399.34 ns |   0.0907 ns |   0.0804 ns |    399.35 ns |  1.31 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    381.96 ns |   0.1069 ns |   0.1000 ns |    381.98 ns |  1.25 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,100.87 ns |  21.5292 ns |  23.0360 ns |  1,096.34 ns |  3.62 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,054.96 ns |   0.9274 ns |   0.8675 ns |  1,054.88 ns |  3.46 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    535.64 ns |   0.1244 ns |   0.1103 ns |    535.63 ns |  1.75 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    519.86 ns |   0.8641 ns |   0.8083 ns |    519.54 ns |  1.70 |    0.00 |
|                                                 LinqCount |           [50] |    543.93 ns |   0.1244 ns |   0.0972 ns |    543.95 ns |  1.78 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    586.88 ns |   1.2659 ns |   1.0571 ns |    586.56 ns |  1.92 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    569.02 ns |   0.7572 ns |   0.7083 ns |    569.04 ns |  1.86 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    351.81 ns |   0.0623 ns |   0.0553 ns |    351.82 ns |  1.15 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    330.81 ns |   0.1584 ns |   0.1322 ns |    330.80 ns |  1.08 |    0.00 |
|                                               LinqToArray |           [50] |    855.12 ns |   2.0377 ns |   1.9060 ns |    854.34 ns |  2.80 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    751.45 ns |   0.3168 ns |   0.2808 ns |    751.56 ns |  2.46 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    735.39 ns |   0.3295 ns |   0.3082 ns |    735.39 ns |  2.41 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    528.66 ns |  10.4352 ns |  11.1655 ns |    525.64 ns |  1.74 |    0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    498.15 ns |   0.8580 ns |   0.8026 ns |    497.89 ns |  1.63 |    0.00 |
|                                                      Take |           [50] |    515.40 ns |   0.1753 ns |   0.1554 ns |    515.37 ns |  1.69 |    0.00 |
|                                               LowCostTake |           [50] |    287.81 ns |   0.3194 ns |   0.2988 ns |    287.83 ns |  0.94 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    275.09 ns |   0.1460 ns |   0.1219 ns |    275.13 ns |  0.90 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    198.73 ns |   0.0935 ns |   0.0829 ns |    198.70 ns |  0.65 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    199.73 ns |   0.0506 ns |   0.0473 ns |    199.72 ns |  0.65 |    0.00 |
|                                            SkipTakeSingle |           [50] |    400.47 ns |   0.0969 ns |   0.0907 ns |    400.45 ns |  1.31 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    290.93 ns |   0.2091 ns |   0.1633 ns |    290.93 ns |  0.95 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    281.02 ns |   0.4759 ns |   0.4452 ns |    281.06 ns |  0.92 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    205.41 ns |   0.0701 ns |   0.0656 ns |    205.43 ns |  0.67 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    208.42 ns |   3.8884 ns |   3.6372 ns |    206.10 ns |  0.68 |    0.01 |
|                                           ForeachDelegate |           [50] |    462.78 ns |   0.1281 ns |   0.1135 ns |    462.79 ns |  1.52 |    0.00 |
|                                                   Foreach |           [50] |    305.24 ns |   0.0697 ns |   0.0652 ns |    305.23 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **152.93 ns** |   **0.0567 ns** |   **0.0503 ns** |    **152.93 ns** |  **3.40** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    108.02 ns |   0.0657 ns |   0.0549 ns |    108.03 ns |  2.40 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    104.74 ns |   0.0399 ns |   0.0373 ns |    104.73 ns |  2.33 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    119.78 ns |   0.0940 ns |   0.0880 ns |    119.79 ns |  2.66 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    120.37 ns |   0.8461 ns |   0.7915 ns |    120.48 ns |  2.68 |    0.02 |
|                                LowCostLinqWithStructWhere |            [5] |     83.78 ns |   0.1216 ns |   0.1016 ns |     83.78 ns |  1.86 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     74.64 ns |   0.0651 ns |   0.0609 ns |     74.64 ns |  1.66 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    184.95 ns |   0.1479 ns |   0.1311 ns |    184.97 ns |  4.11 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    181.97 ns |   3.6158 ns |   3.8689 ns |    179.11 ns |  4.06 |    0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    107.69 ns |   0.0419 ns |   0.0392 ns |    107.69 ns |  2.40 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    107.34 ns |   0.0175 ns |   0.0155 ns |    107.34 ns |  2.39 |    0.00 |
|                                                 LinqCount |            [5] |    133.36 ns |   2.5787 ns |   2.8662 ns |    131.38 ns |  2.97 |    0.07 |
|                              LowCostLinqWithDelegateCount |            [5] |    100.30 ns |   0.0543 ns |   0.0508 ns |    100.31 ns |  2.23 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    101.60 ns |   0.0299 ns |   0.0279 ns |    101.61 ns |  2.26 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     72.62 ns |   1.1839 ns |   1.1074 ns |     72.04 ns |  1.62 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     68.01 ns |   0.0583 ns |   0.0487 ns |     68.03 ns |  1.51 |    0.00 |
|                                               LinqToArray |            [5] |    208.94 ns |   0.0596 ns |   0.0528 ns |    208.95 ns |  4.65 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    161.65 ns |   0.0607 ns |   0.0568 ns |    161.64 ns |  3.60 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    162.34 ns |   2.3991 ns |   2.0034 ns |    161.60 ns |  3.61 |    0.04 |
|                              LowCostLinqWithStructToArray |            [5] |    129.20 ns |   0.0537 ns |   0.0476 ns |    129.20 ns |  2.87 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    131.31 ns |   1.3598 ns |   1.2720 ns |    131.49 ns |  2.92 |    0.03 |
|                                                      Take |            [5] |    233.93 ns |   0.0968 ns |   0.0808 ns |    233.95 ns |  5.20 |    0.00 |
|                                               LowCostTake |            [5] |    119.97 ns |   0.0908 ns |   0.0805 ns |    119.98 ns |  2.67 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    106.51 ns |   0.1209 ns |   0.1131 ns |    106.47 ns |  2.37 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     87.01 ns |   0.0705 ns |   0.0659 ns |     87.01 ns |  1.94 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     86.34 ns |   1.4181 ns |   1.3265 ns |     85.23 ns |  1.92 |    0.03 |
|                                            SkipTakeSingle |            [5] |    214.48 ns |   0.0747 ns |   0.0662 ns |    214.48 ns |  4.77 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    114.44 ns |   0.0305 ns |   0.0286 ns |    114.44 ns |  2.55 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    111.23 ns |   0.1223 ns |   0.1021 ns |    111.23 ns |  2.47 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     94.48 ns |   0.0891 ns |   0.0833 ns |     94.49 ns |  2.10 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     95.64 ns |   0.0342 ns |   0.0303 ns |     95.65 ns |  2.13 |    0.00 |
|                                           ForeachDelegate |            [5] |     65.19 ns |   1.2158 ns |   1.1373 ns |     64.43 ns |  1.45 |    0.03 |
|                                                   Foreach |            [5] |     44.96 ns |   0.0327 ns |   0.0306 ns |     44.96 ns |  1.00 |    0.00 |
