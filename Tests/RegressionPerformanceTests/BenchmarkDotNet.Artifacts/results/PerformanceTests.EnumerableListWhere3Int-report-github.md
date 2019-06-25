``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **97.62 ns** |   **0.1831 ns** |     **0.1624 ns** |     **97.58 ns** |  **5.68** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     37.97 ns |   0.0145 ns |     0.0121 ns |     37.97 ns |  2.21 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     30.21 ns |   0.0068 ns |     0.0064 ns |     30.21 ns |  1.76 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     60.80 ns |   0.0725 ns |     0.0678 ns |     60.81 ns |  3.54 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     52.84 ns |   0.0187 ns |     0.0166 ns |     52.84 ns |  3.07 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     49.27 ns |   0.0067 ns |     0.0063 ns |     49.27 ns |  2.87 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     41.59 ns |   0.0075 ns |     0.0070 ns |     41.59 ns |  2.42 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    111.86 ns |   0.1145 ns |     0.1071 ns |    111.82 ns |  6.51 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     98.96 ns |   0.1408 ns |     0.1317 ns |     98.92 ns |  5.76 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     97.72 ns |   0.0619 ns |     0.0549 ns |     97.71 ns |  5.69 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     85.25 ns |   0.0500 ns |     0.0468 ns |     85.24 ns |  4.96 |    0.00 |
|                                                 LinqCount |            [0] |     95.64 ns |   0.0677 ns |     0.0634 ns |     95.60 ns |  5.56 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     38.24 ns |   0.0121 ns |     0.0113 ns |     38.24 ns |  2.22 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     35.03 ns |   0.0189 ns |     0.0177 ns |     35.03 ns |  2.04 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     44.47 ns |   0.0108 ns |     0.0095 ns |     44.47 ns |  2.59 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.62 ns |   0.0101 ns |     0.0089 ns |     36.63 ns |  2.13 |    0.00 |
|                                               LinqToArray |            [0] |    108.43 ns |   0.1334 ns |     0.1182 ns |    108.45 ns |  6.31 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     49.71 ns |   0.0599 ns |     0.0561 ns |     49.70 ns |  2.89 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     47.73 ns |   0.0326 ns |     0.0305 ns |     47.72 ns |  2.78 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     54.68 ns |   0.0093 ns |     0.0083 ns |     54.68 ns |  3.18 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     47.82 ns |   0.0257 ns |     0.0227 ns |     47.82 ns |  2.78 |    0.00 |
|                                                      Take |            [0] |    133.94 ns |   0.3233 ns |     0.3024 ns |    133.85 ns |  7.79 |    0.02 |
|                                               LowCostTake |            [0] |     44.45 ns |   0.0874 ns |     0.0818 ns |     44.40 ns |  2.59 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     38.88 ns |   0.0091 ns |     0.0085 ns |     38.88 ns |  2.26 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     55.20 ns |   0.0122 ns |     0.0108 ns |     55.20 ns |  3.21 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     49.53 ns |   0.0112 ns |     0.0105 ns |     49.53 ns |  2.88 |    0.00 |
|                                            SkipTakeSingle |            [0] |    166.31 ns |   0.0597 ns |     0.0559 ns |    166.32 ns |  9.68 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     55.55 ns |   0.0171 ns |     0.0160 ns |     55.56 ns |  3.23 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     53.68 ns |   0.0156 ns |     0.0146 ns |     53.68 ns |  3.12 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     66.24 ns |   0.0146 ns |     0.0136 ns |     66.24 ns |  3.85 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     58.60 ns |   0.0876 ns |     0.0820 ns |     58.62 ns |  3.41 |    0.00 |
|                                           ForeachDelegate |            [0] |     20.38 ns |   0.0122 ns |     0.0114 ns |     20.38 ns |  1.19 |    0.00 |
|                                                   Foreach |            [0] |     17.19 ns |   0.0061 ns |     0.0057 ns |     17.19 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **13,092.23 ns** | **259.6697 ns** |   **404.2745 ns** | **12,837.04 ns** |  **2.39** |    **0.08** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,312.26 ns | 224.3458 ns |   562.8397 ns | 10,924.47 ns |  2.02 |    0.10 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  9,788.13 ns |  80.9286 ns |    75.7007 ns |  9,770.65 ns |  1.77 |    0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 10,708.38 ns | 212.9960 ns |   467.5314 ns | 10,676.81 ns |  1.95 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 13,511.57 ns | 749.3967 ns | 2,209.6131 ns | 14,775.56 ns |  2.74 |    0.05 |
|                                LowCostLinqWithStructWhere |         [1000] |  3,145.71 ns |  15.7646 ns |    14.7462 ns |  3,153.27 ns |  0.57 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,421.52 ns |   0.3798 ns |     0.3171 ns |  1,421.50 ns |  0.26 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,418.54 ns | 462.7302 ns |   747.2230 ns | 23,104.94 ns |  4.27 |    0.15 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 21,453.57 ns |  58.2343 ns |    48.6283 ns | 21,455.42 ns |  3.88 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,940.02 ns |   7.8838 ns |     7.3745 ns |  9,941.88 ns |  1.80 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,200.88 ns |   2.5694 ns |     2.4034 ns |  9,200.75 ns |  1.66 |    0.00 |
|                                                 LinqCount |         [1000] |  6,281.00 ns |  28.9332 ns |    24.1605 ns |  6,270.09 ns |  1.14 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  9,570.83 ns | 250.4974 ns |   738.5972 ns |  9,252.83 ns |  1.74 |    0.13 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,582.69 ns | 185.9538 ns |   164.8432 ns |  7,510.08 ns |  1.37 |    0.03 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,722.72 ns |   0.7156 ns |     0.6693 ns |  1,722.66 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    743.62 ns |   1.0269 ns |     0.9606 ns |    743.43 ns |  0.13 |    0.00 |
|                                               LinqToArray |         [1000] |  7,678.23 ns |  12.2598 ns |    10.8680 ns |  7,676.02 ns |  1.39 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,148.67 ns |   7.9981 ns |     7.4814 ns | 11,147.72 ns |  2.02 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,634.18 ns |  15.9003 ns |    14.8732 ns |  8,628.03 ns |  1.56 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,861.17 ns |   8.0207 ns |     7.5026 ns |  3,865.01 ns |  0.70 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,632.90 ns |   2.0392 ns |     1.9075 ns |  2,632.81 ns |  0.48 |    0.00 |
|                                                      Take |         [1000] |    462.94 ns |   0.1328 ns |     0.1109 ns |    462.96 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    385.68 ns |   7.2350 ns |     6.7676 ns |    386.32 ns |  0.07 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    211.81 ns |   4.2359 ns |     9.9846 ns |    210.09 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    119.43 ns |   0.0294 ns |     0.0275 ns |    119.42 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     86.76 ns |   0.0136 ns |     0.0127 ns |     86.77 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    395.60 ns |   0.1681 ns |     0.1490 ns |    395.58 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    283.57 ns |   5.6577 ns |    14.1940 ns |    282.14 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    257.89 ns |   4.7797 ns |     4.2371 ns |    256.08 ns |  0.05 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    129.00 ns |   0.0849 ns |     0.0752 ns |    129.00 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     87.01 ns |   0.0783 ns |     0.0732 ns |     87.00 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,653.63 ns |   2.0588 ns |     1.9258 ns |  9,653.59 ns |  1.75 |    0.00 |
|                                                   Foreach |         [1000] |  5,529.96 ns |   3.0659 ns |     2.7178 ns |  5,531.17 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **732.49 ns** |   **3.3600 ns** |     **3.1429 ns** |    **731.49 ns** |  **2.44** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    582.30 ns |  19.9567 ns |    22.1819 ns |    570.46 ns |  1.95 |    0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    523.69 ns |  10.4569 ns |    28.9761 ns |    519.74 ns |  1.77 |    0.08 |
|                                  LowCostLinqWithDelegate2 |           [50] |    826.78 ns |  53.1651 ns |   156.7586 ns |    923.29 ns |  3.02 |    0.30 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    554.62 ns |  11.0965 ns |    32.7183 ns |    539.49 ns |  1.83 |    0.11 |
|                                LowCostLinqWithStructWhere |           [50] |    203.88 ns |   0.0629 ns |     0.0588 ns |    203.88 ns |  0.68 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    119.51 ns |   0.0351 ns |     0.0328 ns |    119.51 ns |  0.40 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,417.56 ns |   9.3375 ns |     8.7343 ns |  1,417.61 ns |  4.72 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,190.22 ns |  14.9026 ns |    13.9399 ns |  1,187.80 ns |  3.97 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    605.35 ns |   0.1613 ns |     0.1509 ns |    605.33 ns |  2.02 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    550.51 ns |   0.1930 ns |     0.1611 ns |    550.53 ns |  1.83 |    0.00 |
|                                                 LinqCount |           [50] |    409.24 ns |   1.4965 ns |     1.3998 ns |    408.78 ns |  1.36 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    711.02 ns |  47.7907 ns |   140.9121 ns |    802.25 ns |  2.72 |    0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    432.91 ns |   8.6465 ns |    21.3721 ns |    433.55 ns |  1.40 |    0.06 |
|                           LowCostLinqWithStructWhereCount |           [50] |    134.03 ns |   0.2739 ns |     0.2562 ns |    134.14 ns |  0.45 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     68.14 ns |   0.0863 ns |     0.0807 ns |     68.15 ns |  0.23 |    0.00 |
|                                               LinqToArray |           [50] |    703.48 ns |   8.2188 ns |     7.6879 ns |    705.75 ns |  2.34 |    0.03 |
|                            LowCostLinqWithDelegateToArray |           [50] |    707.28 ns |   0.8455 ns |     0.7909 ns |    707.32 ns |  2.36 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    554.49 ns |   0.8904 ns |     0.8329 ns |    554.18 ns |  1.85 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    320.06 ns |   0.2234 ns |     0.2089 ns |    320.11 ns |  1.07 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    239.12 ns |   0.1551 ns |     0.1451 ns |    239.12 ns |  0.80 |    0.00 |
|                                                      Take |           [50] |    466.33 ns |   0.3289 ns |     0.2916 ns |    466.41 ns |  1.55 |    0.00 |
|                                               LowCostTake |           [50] |    267.54 ns |   6.0007 ns |    17.6931 ns |    255.60 ns |  0.94 |    0.06 |
|                                  LowCostTakeWithoutChecks |           [50] |    222.99 ns |   1.2568 ns |     1.1756 ns |    222.76 ns |  0.74 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    119.86 ns |   0.0201 ns |     0.0188 ns |    119.86 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     88.61 ns |   0.0161 ns |     0.0150 ns |     88.61 ns |  0.30 |    0.00 |
|                                            SkipTakeSingle |           [50] |    395.79 ns |   0.3901 ns |     0.3649 ns |    395.69 ns |  1.32 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    290.36 ns |   3.1808 ns |     2.9753 ns |    290.38 ns |  0.97 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    261.63 ns |   4.9898 ns |     4.9006 ns |    259.05 ns |  0.87 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    128.96 ns |   0.0857 ns |     0.0801 ns |    128.97 ns |  0.43 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     85.81 ns |   0.0303 ns |     0.0283 ns |     85.80 ns |  0.29 |    0.00 |
|                                           ForeachDelegate |           [50] |    515.76 ns |   0.2658 ns |     0.2486 ns |    515.78 ns |  1.72 |    0.00 |
|                                                   Foreach |           [50] |    300.12 ns |   0.0733 ns |     0.0649 ns |    300.12 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **160.38 ns** |   **0.0707 ns** |     **0.0626 ns** |    **160.39 ns** |  **3.54** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     88.57 ns |   1.0292 ns |     0.8594 ns |     88.05 ns |  1.96 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     73.51 ns |   1.4966 ns |     2.8110 ns |     71.93 ns |  1.65 |    0.05 |
|                                  LowCostLinqWithDelegate2 |            [5] |    118.57 ns |   1.0009 ns |     0.9363 ns |    118.45 ns |  2.62 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     94.80 ns |   1.9039 ns |     4.1390 ns |     93.78 ns |  2.07 |    0.09 |
|                                LowCostLinqWithStructWhere |            [5] |     60.45 ns |   0.0071 ns |     0.0063 ns |     60.45 ns |  1.34 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     49.62 ns |   0.0195 ns |     0.0173 ns |     49.61 ns |  1.10 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    241.26 ns |   1.0615 ns |     0.9929 ns |    241.67 ns |  5.33 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    218.98 ns |   0.1916 ns |     0.1793 ns |    219.00 ns |  4.84 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    150.96 ns |   0.0524 ns |     0.0490 ns |    150.94 ns |  3.34 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    132.45 ns |   0.1823 ns |     0.1705 ns |    132.38 ns |  2.93 |    0.01 |
|                                                 LinqCount |            [5] |    127.86 ns |   0.1361 ns |     0.1273 ns |    127.84 ns |  2.83 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     82.52 ns |   1.7258 ns |     1.9875 ns |     81.61 ns |  1.83 |    0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     93.00 ns |   4.5777 ns |    13.4975 ns |    100.88 ns |  2.28 |    0.07 |
|                           LowCostLinqWithStructWhereCount |            [5] |     52.45 ns |   0.0060 ns |     0.0053 ns |     52.45 ns |  1.16 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     39.23 ns |   0.0078 ns |     0.0073 ns |     39.23 ns |  0.87 |    0.00 |
|                                               LinqToArray |            [5] |    194.01 ns |   0.1360 ns |     0.1272 ns |    194.02 ns |  4.29 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    129.07 ns |   0.0954 ns |     0.0797 ns |    129.07 ns |  2.85 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    116.77 ns |   0.2470 ns |     0.2310 ns |    116.76 ns |  2.58 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     97.19 ns |   0.0475 ns |     0.0444 ns |     97.19 ns |  2.15 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     84.87 ns |   0.1842 ns |     0.1723 ns |     84.90 ns |  1.88 |    0.00 |
|                                                      Take |            [5] |    229.33 ns |   0.0535 ns |     0.0501 ns |    229.31 ns |  5.07 |    0.01 |
|                                               LowCostTake |            [5] |    129.11 ns |   2.3763 ns |     2.2228 ns |    129.38 ns |  2.85 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [5] |     81.22 ns |   1.6389 ns |     4.2012 ns |     80.55 ns |  1.83 |    0.09 |
|                                     LowCostTakeWithStruct |            [5] |     71.61 ns |   0.1424 ns |     0.1332 ns |     71.66 ns |  1.58 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     59.81 ns |   0.0129 ns |     0.0114 ns |     59.81 ns |  1.32 |    0.00 |
|                                            SkipTakeSingle |            [5] |    212.76 ns |   0.3234 ns |     0.3025 ns |    212.58 ns |  4.70 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    105.35 ns |   2.1082 ns |     4.4928 ns |    103.28 ns |  2.33 |    0.09 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     98.08 ns |   1.8878 ns |     1.6735 ns |     97.40 ns |  2.17 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     78.64 ns |   0.0678 ns |     0.0634 ns |     78.63 ns |  1.74 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     63.69 ns |   0.0196 ns |     0.0184 ns |     63.70 ns |  1.41 |    0.00 |
|                                           ForeachDelegate |            [5] |     70.72 ns |   0.0391 ns |     0.0346 ns |     70.70 ns |  1.56 |    0.00 |
|                                                   Foreach |            [5] |     45.26 ns |   0.0854 ns |     0.0757 ns |     45.22 ns |  1.00 |    0.00 |
