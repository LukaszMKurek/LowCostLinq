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
|                                                      **Linq** |            **[0]** |    **103.19 ns** |   **1.4840 ns** |   **1.3881 ns** |    **102.42 ns** |   **6.32** |     **0.08** |
|                                   LowCostLinqWithDelegate |            [0] |     48.64 ns |   0.0282 ns |   0.0250 ns |     48.64 ns |   2.98 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     47.06 ns |   0.0194 ns |   0.0172 ns |     47.06 ns |   2.88 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     69.22 ns |   0.9405 ns |   0.8797 ns |     69.28 ns |   4.24 |     0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     66.04 ns |   0.0119 ns |   0.0112 ns |     66.04 ns |   4.04 |     0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     57.03 ns |   0.0101 ns |   0.0095 ns |     57.03 ns |   3.49 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     55.98 ns |   0.0164 ns |   0.0137 ns |     55.98 ns |   3.43 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    114.31 ns |   0.5927 ns |   0.4949 ns |    114.14 ns |   7.00 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    108.92 ns |   0.1374 ns |   0.1218 ns |    108.88 ns |   6.67 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     98.30 ns |   0.2699 ns |   0.2524 ns |     98.17 ns |   6.02 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     95.31 ns |   0.2143 ns |   0.2005 ns |     95.20 ns |   5.84 |     0.01 |
|                                                 LinqCount |            [0] |    104.83 ns |   0.1312 ns |   0.1228 ns |    104.83 ns |   6.42 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     49.54 ns |   0.0242 ns |   0.0202 ns |     49.54 ns |   3.03 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     49.74 ns |   0.0242 ns |   0.0227 ns |     49.73 ns |   3.05 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     47.57 ns |   0.0213 ns |   0.0166 ns |     47.57 ns |   2.91 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     48.04 ns |   0.0145 ns |   0.0135 ns |     48.04 ns |   2.94 |     0.00 |
|                                               LinqToArray |            [0] |    117.40 ns |   0.0318 ns |   0.0298 ns |    117.40 ns |   7.19 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     61.30 ns |   0.0371 ns |   0.0347 ns |     61.30 ns |   3.75 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     62.63 ns |   0.0311 ns |   0.0291 ns |     62.64 ns |   3.84 |     0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     57.72 ns |   1.1244 ns |   1.0518 ns |     56.93 ns |   3.53 |     0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     58.60 ns |   0.0123 ns |   0.0109 ns |     58.60 ns |   3.59 |     0.01 |
|                                                      Take |            [0] |    136.31 ns |   0.0174 ns |   0.0163 ns |    136.31 ns |   8.35 |     0.01 |
|                                               LowCostTake |            [0] |     52.27 ns |   0.0325 ns |   0.0271 ns |     52.26 ns |   3.20 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     53.73 ns |   0.9125 ns |   0.8536 ns |     53.14 ns |   3.29 |     0.05 |
|                                     LowCostTakeWithStruct |            [0] |     63.49 ns |   0.1695 ns |   0.1585 ns |     63.58 ns |   3.89 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     62.63 ns |   0.0114 ns |   0.0107 ns |     62.63 ns |   3.83 |     0.01 |
|                                            SkipTakeSingle |            [0] |    161.39 ns |   0.2250 ns |   0.1995 ns |    161.46 ns |   9.88 |     0.02 |
|                                     LowCostSkipTakeSingle |            [0] |     69.41 ns |   1.1137 ns |   1.0417 ns |     69.76 ns |   4.25 |     0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     68.68 ns |   0.0931 ns |   0.0871 ns |     68.70 ns |   4.21 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     69.89 ns |   0.0125 ns |   0.0111 ns |     69.89 ns |   4.28 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     71.02 ns |   0.0702 ns |   0.0656 ns |     71.04 ns |   4.35 |     0.01 |
|                                           ForeachDelegate |            [0] |     21.08 ns |   0.3314 ns |   0.3100 ns |     20.82 ns |   1.29 |     0.02 |
|                                                   Foreach |            [0] |     16.33 ns |   0.0265 ns |   0.0248 ns |     16.33 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **14,973.64 ns** |  **10.2660 ns** |   **9.6028 ns** | **14,972.48 ns** |   **2.84** |     **0.01** |
|                                   LowCostLinqWithDelegate |         [1000] | 13,301.15 ns |  82.1314 ns |  76.8257 ns | 13,272.42 ns |   2.52 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 13,829.53 ns |  81.0999 ns |  75.8608 ns | 13,785.35 ns |   2.62 |     0.02 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 13,278.66 ns |  25.7192 ns |  24.0578 ns | 13,288.68 ns |   2.52 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 12,741.24 ns |   3.8729 ns |   3.2340 ns | 12,741.62 ns |   2.42 |     0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  6,321.52 ns |   7.2632 ns |   6.7940 ns |  6,320.54 ns |   1.20 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  5,799.83 ns |   0.6072 ns |   0.5070 ns |  5,799.78 ns |   1.10 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 28,585.03 ns | 123.4717 ns | 115.4955 ns | 28,589.18 ns |   5.42 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 25,980.94 ns |  48.0710 ns |  44.9656 ns | 25,986.28 ns |   4.92 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 12,624.96 ns |  20.4956 ns |  19.1716 ns | 12,625.92 ns |   2.39 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 12,561.39 ns |   4.7196 ns |   3.9410 ns | 12,561.65 ns |   2.38 |     0.01 |
|                                                 LinqCount |         [1000] | 11,383.77 ns |   5.9252 ns |   4.9478 ns | 11,382.57 ns |   2.16 |     0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 11,570.15 ns |   7.9817 ns |   7.4661 ns | 11,571.58 ns |   2.19 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 11,809.57 ns |  30.2344 ns |  28.2813 ns | 11,791.88 ns |   2.24 |     0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,372.62 ns |  60.0697 ns |  56.1892 ns |  5,339.09 ns |   1.02 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,082.88 ns |   1.9046 ns |   1.7816 ns |  5,083.70 ns |   0.96 |     0.00 |
|                                               LinqToArray |         [1000] | 13,350.25 ns |  12.2558 ns |  11.4641 ns | 13,350.86 ns |   2.53 |     0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 14,003.78 ns |  13.3393 ns |  11.8250 ns | 14,004.22 ns |   2.65 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 13,315.07 ns |   6.2794 ns |   5.5665 ns | 13,315.20 ns |   2.52 |     0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  6,613.01 ns |   7.4154 ns |   6.9364 ns |  6,612.76 ns |   1.25 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  6,895.62 ns |  84.2942 ns |  78.8489 ns |  6,844.29 ns |   1.31 |     0.01 |
|                                                      Take |         [1000] |    536.80 ns |   0.1516 ns |   0.1418 ns |    536.79 ns |   0.10 |     0.00 |
|                                               LowCostTake |         [1000] |    350.72 ns |   0.7380 ns |   0.6903 ns |    350.92 ns |   0.07 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    312.79 ns |   0.0853 ns |   0.0798 ns |    312.76 ns |   0.06 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    203.22 ns |   2.5775 ns |   2.4110 ns |    201.92 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    196.94 ns |   0.3269 ns |   0.3058 ns |    197.05 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    461.30 ns |   0.1642 ns |   0.1456 ns |    461.29 ns |   0.09 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    360.82 ns |   0.4014 ns |   0.3134 ns |    360.92 ns |   0.07 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    358.83 ns |   0.2451 ns |   0.2047 ns |    358.82 ns |   0.07 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    216.23 ns |   0.0504 ns |   0.0447 ns |    216.24 ns |   0.04 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    207.57 ns |   0.1436 ns |   0.1199 ns |    207.52 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |         [1000] |  9,237.22 ns |  32.7815 ns |  30.6638 ns |  9,226.24 ns |   1.75 |     0.01 |
|                                                   Foreach |         [1000] |  5,275.76 ns |  14.1055 ns |  13.1943 ns |  5,269.11 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **863.37 ns** |   **0.5897 ns** |   **0.4604 ns** |    **863.22 ns** |   **2.99** |     **0.03** |
|                                   LowCostLinqWithDelegate |           [50] |    726.57 ns |   0.7208 ns |   0.6743 ns |    726.85 ns |   2.51 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    750.75 ns |   0.2041 ns |   0.1909 ns |    750.74 ns |   2.60 |     0.02 |
|                                  LowCostLinqWithDelegate2 |           [50] |    750.00 ns |   9.6481 ns |   9.0249 ns |    743.59 ns |   2.59 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    699.51 ns |   0.0940 ns |   0.0833 ns |    699.52 ns |   2.42 |     0.02 |
|                                LowCostLinqWithStructWhere |           [50] |    370.95 ns |   0.2101 ns |   0.1965 ns |    371.03 ns |   1.28 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    346.89 ns |   0.0776 ns |   0.0688 ns |    346.87 ns |   1.20 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,558.07 ns |   4.2894 ns |   4.0123 ns |  1,558.33 ns |   5.39 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,417.69 ns |   1.2519 ns |   1.1097 ns |  1,417.72 ns |   4.90 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    742.69 ns |   0.4391 ns |   0.4107 ns |    742.87 ns |   2.57 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    751.74 ns |  10.5045 ns |   9.8259 ns |    744.11 ns |   2.60 |     0.04 |
|                                                 LinqCount |           [50] |    689.66 ns |   0.3476 ns |   0.3252 ns |    689.56 ns |   2.39 |     0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |    638.75 ns |   0.0981 ns |   0.0918 ns |    638.74 ns |   2.21 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    648.48 ns |   0.7171 ns |   0.6708 ns |    648.78 ns |   2.24 |     0.02 |
|                           LowCostLinqWithStructWhereCount |           [50] |    318.91 ns |   3.5593 ns |   3.3294 ns |    316.56 ns |   1.10 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    310.84 ns |   0.0548 ns |   0.0513 ns |    310.82 ns |   1.08 |     0.01 |
|                                               LinqToArray |           [50] |    990.91 ns |   1.0028 ns |   0.8890 ns |    991.13 ns |   3.43 |     0.03 |
|                            LowCostLinqWithDelegateToArray |           [50] |    890.60 ns |   0.2360 ns |   0.2092 ns |    890.55 ns |   3.08 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    853.89 ns |   0.2714 ns |   0.2539 ns |    853.91 ns |   2.95 |     0.03 |
|                              LowCostLinqWithStructToArray |           [50] |    496.74 ns |   0.7727 ns |   0.7228 ns |    497.10 ns |   1.72 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    492.14 ns |   0.3209 ns |   0.3002 ns |    492.09 ns |   1.70 |     0.02 |
|                                                      Take |           [50] |    538.04 ns |   0.2941 ns |   0.2751 ns |    537.96 ns |   1.86 |     0.02 |
|                                               LowCostTake |           [50] |    349.85 ns |   0.2493 ns |   0.2332 ns |    349.88 ns |   1.21 |     0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    313.43 ns |   0.3142 ns |   0.2939 ns |    313.58 ns |   1.08 |     0.01 |
|                                     LowCostTakeWithStruct |           [50] |    201.86 ns |   0.0534 ns |   0.0473 ns |    201.87 ns |   0.70 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    198.97 ns |   2.4282 ns |   2.2714 ns |    197.28 ns |   0.69 |     0.01 |
|                                            SkipTakeSingle |           [50] |    460.59 ns |   0.1826 ns |   0.1619 ns |    460.61 ns |   1.59 |     0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    361.29 ns |   0.4069 ns |   0.3607 ns |    361.41 ns |   1.25 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    359.49 ns |   3.8958 ns |   3.6442 ns |    357.19 ns |   1.24 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    215.35 ns |   0.2741 ns |   0.2564 ns |    215.41 ns |   0.74 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    207.91 ns |   0.0535 ns |   0.0474 ns |    207.91 ns |   0.72 |     0.01 |
|                                           ForeachDelegate |           [50] |    500.50 ns |   0.5496 ns |   0.5141 ns |    500.66 ns |   1.73 |     0.02 |
|                                                   Foreach |           [50] |    289.14 ns |   2.8852 ns |   2.6988 ns |    287.49 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |    **194.16 ns** |   **0.1131 ns** |   **0.1058 ns** |    **194.12 ns** |   **4.56** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    123.07 ns |   0.2728 ns |   0.2552 ns |    122.96 ns |   2.89 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    127.58 ns |   0.0997 ns |   0.0932 ns |    127.59 ns |   3.00 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    148.10 ns |   1.9996 ns |   1.8704 ns |    149.29 ns |   3.48 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    130.81 ns |   0.0459 ns |   0.0406 ns |    130.80 ns |   3.07 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     83.07 ns |   0.0465 ns |   0.0435 ns |     83.06 ns |   1.95 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     80.72 ns |   0.0413 ns |   0.0387 ns |     80.71 ns |   1.90 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    276.00 ns |   4.4109 ns |   4.1259 ns |    274.17 ns |   6.48 |     0.09 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    254.20 ns |   0.2580 ns |   0.2287 ns |    254.13 ns |   5.97 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    176.19 ns |   0.1568 ns |   0.1390 ns |    176.13 ns |   4.14 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    171.15 ns |   0.0496 ns |   0.0440 ns |    171.17 ns |   4.02 |     0.00 |
|                                                 LinqCount |            [5] |    175.53 ns |   2.7207 ns |   2.5449 ns |    174.31 ns |   4.12 |     0.06 |
|                              LowCostLinqWithDelegateCount |            [5] |    116.04 ns |   0.0261 ns |   0.0218 ns |    116.04 ns |   2.73 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    119.57 ns |   0.0159 ns |   0.0149 ns |    119.57 ns |   2.81 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     71.82 ns |   0.0195 ns |   0.0152 ns |     71.82 ns |   1.69 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     70.98 ns |   1.1003 ns |   1.0293 ns |     70.32 ns |   1.67 |     0.02 |
|                                               LinqToArray |            [5] |    240.05 ns |   0.1809 ns |   0.1412 ns |    240.10 ns |   5.64 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    162.79 ns |   0.0212 ns |   0.0177 ns |    162.79 ns |   3.82 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    158.46 ns |   0.0793 ns |   0.0619 ns |    158.44 ns |   3.72 |     0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    120.10 ns |   2.2687 ns |   2.1222 ns |    120.53 ns |   2.82 |     0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    114.60 ns |   0.0302 ns |   0.0267 ns |    114.59 ns |   2.69 |     0.00 |
|                                                      Take |            [5] |    259.17 ns |   0.0886 ns |   0.0829 ns |    259.16 ns |   6.09 |     0.01 |
|                                               LowCostTake |            [5] |    131.57 ns |   0.2036 ns |   0.1904 ns |    131.60 ns |   3.09 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    125.04 ns |   1.9065 ns |   1.7833 ns |    123.64 ns |   2.94 |     0.04 |
|                                     LowCostTakeWithStruct |            [5] |     91.59 ns |   0.0475 ns |   0.0444 ns |     91.57 ns |   2.15 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     93.29 ns |   0.0503 ns |   0.0446 ns |     93.29 ns |   2.19 |     0.00 |
|                                            SkipTakeSingle |            [5] |    247.52 ns |   0.0267 ns |   0.0250 ns |    247.51 ns |   5.81 |     0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    143.64 ns |   1.6225 ns |   1.5177 ns |    143.72 ns |   3.37 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    141.64 ns |   0.0429 ns |   0.0401 ns |    141.64 ns |   3.33 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     99.24 ns |   0.2046 ns |   0.1913 ns |     99.30 ns |   2.33 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     98.42 ns |   0.0274 ns |   0.0256 ns |     98.43 ns |   2.31 |     0.00 |
|                                           ForeachDelegate |            [5] |     67.65 ns |   0.0733 ns |   0.0572 ns |     67.67 ns |   1.59 |     0.00 |
|                                                   Foreach |            [5] |     42.58 ns |   0.0562 ns |   0.0525 ns |     42.57 ns |   1.00 |     0.00 |
