``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **48.30 ns** |   **0.0220 ns** |   **0.0195 ns** |     **48.30 ns** |  **2.65** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     45.23 ns |   0.0171 ns |   0.0152 ns |     45.22 ns |  2.48 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     37.32 ns |   0.0439 ns |   0.0343 ns |     37.31 ns |  2.05 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     47.54 ns |   0.0166 ns |   0.0155 ns |     47.54 ns |  2.61 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     43.97 ns |   0.0205 ns |   0.0192 ns |     43.97 ns |  2.41 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     47.71 ns |   0.9296 ns |   0.8241 ns |     47.13 ns |  2.62 |    0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     41.11 ns |   0.0348 ns |   0.0309 ns |     41.09 ns |  2.25 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     49.70 ns |   0.0369 ns |   0.0328 ns |     49.69 ns |  2.73 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     49.70 ns |   0.9990 ns |   1.0689 ns |     48.99 ns |  2.74 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     52.38 ns |   0.0151 ns |   0.0134 ns |     52.38 ns |  2.87 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     53.98 ns |   0.0188 ns |   0.0176 ns |     53.98 ns |  2.96 |    0.00 |
|                                                 LinqCount |            [0] |     48.63 ns |   0.0289 ns |   0.0270 ns |     48.62 ns |  2.67 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     43.40 ns |   0.0177 ns |   0.0165 ns |     43.40 ns |  2.38 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     44.06 ns |   0.0239 ns |   0.0223 ns |     44.06 ns |  2.42 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.09 ns |   0.7475 ns |   0.7342 ns |     36.88 ns |  2.04 |    0.04 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.70 ns |   0.0234 ns |   0.0219 ns |     36.70 ns |  2.01 |    0.00 |
|                                               LinqToArray |            [0] |     65.49 ns |   0.0651 ns |   0.0609 ns |     65.49 ns |  3.59 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     56.44 ns |   0.0224 ns |   0.0199 ns |     56.44 ns |  3.09 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     55.88 ns |   0.0171 ns |   0.0160 ns |     55.87 ns |  3.06 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     49.95 ns |   0.0212 ns |   0.0198 ns |     49.95 ns |  2.74 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     48.97 ns |   0.0360 ns |   0.0319 ns |     48.98 ns |  2.69 |    0.00 |
|                                                      Take |            [0] |     85.14 ns |   0.0474 ns |   0.0420 ns |     85.14 ns |  4.67 |    0.00 |
|                                               LowCostTake |            [0] |     50.03 ns |   0.0166 ns |   0.0155 ns |     50.02 ns |  2.74 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     47.40 ns |   0.0302 ns |   0.0268 ns |     47.40 ns |  2.60 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     52.64 ns |   0.7734 ns |   0.7234 ns |     52.22 ns |  2.88 |    0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     47.89 ns |   0.0169 ns |   0.0158 ns |     47.89 ns |  2.63 |    0.00 |
|                                            SkipTakeSingle |            [0] |    109.40 ns |   0.0305 ns |   0.0285 ns |    109.40 ns |  6.00 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     61.55 ns |   0.1797 ns |   0.1681 ns |     61.57 ns |  3.37 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     56.94 ns |   0.0307 ns |   0.0273 ns |     56.94 ns |  3.12 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     55.12 ns |   0.0203 ns |   0.0169 ns |     55.12 ns |  3.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     55.38 ns |   0.0098 ns |   0.0082 ns |     55.38 ns |  3.04 |    0.00 |
|                                           ForeachDelegate |            [0] |     20.35 ns |   0.0567 ns |   0.0442 ns |     20.34 ns |  1.12 |    0.00 |
|                                                   Foreach |            [0] |     18.24 ns |   0.0169 ns |   0.0149 ns |     18.23 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **11,579.23 ns** |   **6.6227 ns** |   **5.8709 ns** | **11,580.91 ns** |  **2.10** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  9,130.25 ns |   2.1641 ns |   2.0243 ns |  9,130.18 ns |  1.65 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,501.07 ns | 164.4782 ns | 153.8530 ns |  8,416.07 ns |  1.54 |    0.03 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,654.61 ns |   3.8229 ns |   3.5760 ns |  8,655.74 ns |  1.57 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,427.35 ns |   7.4068 ns |   6.5659 ns |  8,428.71 ns |  1.53 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,287.93 ns |  96.3549 ns |  90.1304 ns |  7,287.55 ns |  1.32 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  6,979.04 ns |   6.6506 ns |   5.8956 ns |  6,978.06 ns |  1.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 11,347.28 ns |   6.6566 ns |   6.2266 ns | 11,346.25 ns |  2.06 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 11,595.54 ns |  26.3795 ns |  24.6754 ns | 11,586.12 ns |  2.10 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,766.19 ns | 151.8587 ns | 142.0487 ns |  9,784.38 ns |  1.77 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,942.90 ns |  28.0774 ns |  26.2636 ns |  8,934.95 ns |  1.62 |    0.00 |
|                                                 LinqCount |         [1000] |  7,258.77 ns |   2.3557 ns |   2.2035 ns |  7,259.15 ns |  1.32 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,511.87 ns |   2.0211 ns |   1.8905 ns |  6,511.08 ns |  1.18 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,959.94 ns |   2.3813 ns |   1.9885 ns |  6,959.90 ns |  1.26 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  5,548.57 ns |   1.3332 ns |   1.1819 ns |  5,548.26 ns |  1.01 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  5,542.66 ns |   1.0643 ns |   0.9435 ns |  5,542.92 ns |  1.00 |    0.00 |
|                                               LinqToArray |         [1000] |  9,635.15 ns | 184.5485 ns | 197.4648 ns |  9,526.49 ns |  1.76 |    0.04 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,722.58 ns |   4.4052 ns |   4.1206 ns |  8,722.04 ns |  1.58 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,986.39 ns |   6.1823 ns |   5.7829 ns |  8,984.63 ns |  1.63 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  6,795.00 ns |   3.6913 ns |   3.2722 ns |  6,795.65 ns |  1.23 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,035.44 ns |   4.8610 ns |   4.3092 ns |  7,034.77 ns |  1.28 |    0.00 |
|                                                      Take |         [1000] |    429.65 ns |   0.1807 ns |   0.1509 ns |    429.64 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    241.48 ns |   0.5270 ns |   0.4929 ns |    241.32 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    244.11 ns |   4.6813 ns |   5.0089 ns |    243.75 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    199.93 ns |   0.0580 ns |   0.0543 ns |    199.92 ns |  0.04 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    190.45 ns |   0.0682 ns |   0.0604 ns |    190.46 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    323.69 ns |   0.1312 ns |   0.1163 ns |    323.66 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    257.01 ns |   0.0558 ns |   0.0466 ns |    257.02 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    239.40 ns |   0.1133 ns |   0.1004 ns |    239.40 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    195.08 ns |   0.2829 ns |   0.2646 ns |    195.09 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    194.81 ns |   0.1032 ns |   0.0862 ns |    194.83 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,719.47 ns |   1.4744 ns |   1.3070 ns |  6,719.66 ns |  1.22 |    0.00 |
|                                                   Foreach |         [1000] |  5,516.87 ns |   0.9471 ns |   0.8396 ns |  5,516.67 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **641.70 ns** |   **0.2000 ns** |   **0.1773 ns** |    **641.73 ns** |  **2.10** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    517.09 ns |   8.2902 ns |   7.7547 ns |    520.29 ns |  1.70 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    471.72 ns |   0.1911 ns |   0.1694 ns |    471.70 ns |  1.55 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    490.54 ns |   0.1223 ns |   0.1084 ns |    490.54 ns |  1.61 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    476.09 ns |   0.1109 ns |   0.0983 ns |    476.06 ns |  1.56 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    415.82 ns |   4.7005 ns |   4.1668 ns |    413.78 ns |  1.36 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    394.25 ns |   0.1043 ns |   0.0976 ns |    394.23 ns |  1.29 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    630.01 ns |   0.2121 ns |   0.1984 ns |    630.04 ns |  2.07 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    645.08 ns |  14.2112 ns |  13.2931 ns |    637.65 ns |  2.11 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    547.36 ns |   0.2051 ns |   0.1919 ns |    547.31 ns |  1.80 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    509.95 ns |   0.1880 ns |   0.1758 ns |    509.93 ns |  1.67 |    0.00 |
|                                                 LinqCount |           [50] |    416.83 ns |   0.1873 ns |   0.1564 ns |    416.78 ns |  1.37 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    383.21 ns |   5.4152 ns |   5.0654 ns |    379.37 ns |  1.26 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    399.23 ns |   0.0884 ns |   0.0827 ns |    399.22 ns |  1.31 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    325.02 ns |   0.0796 ns |   0.0706 ns |    325.03 ns |  1.07 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    326.98 ns |   0.0956 ns |   0.0848 ns |    326.95 ns |  1.07 |    0.00 |
|                                               LinqToArray |           [50] |    716.55 ns |   0.7123 ns |   0.5948 ns |    716.48 ns |  2.35 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    607.99 ns |   0.6182 ns |   0.5783 ns |    608.13 ns |  1.99 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    612.03 ns |   0.4933 ns |   0.4373 ns |    612.02 ns |  2.01 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    508.24 ns |   0.2124 ns |   0.1987 ns |    508.28 ns |  1.67 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    516.76 ns |   0.7141 ns |   0.5575 ns |    516.75 ns |  1.70 |    0.00 |
|                                                      Take |           [50] |    430.15 ns |   0.1617 ns |   0.1513 ns |    430.16 ns |  1.41 |    0.00 |
|                                               LowCostTake |           [50] |    241.29 ns |   0.2341 ns |   0.1955 ns |    241.29 ns |  0.79 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    240.05 ns |   0.0897 ns |   0.0839 ns |    240.07 ns |  0.79 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    199.46 ns |   0.1915 ns |   0.1495 ns |    199.43 ns |  0.65 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    190.25 ns |   0.2340 ns |   0.2189 ns |    190.29 ns |  0.62 |    0.00 |
|                                            SkipTakeSingle |           [50] |    323.89 ns |   0.1189 ns |   0.1113 ns |    323.88 ns |  1.06 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    256.21 ns |   0.0840 ns |   0.0745 ns |    256.21 ns |  0.84 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    239.45 ns |   0.0810 ns |   0.0758 ns |    239.43 ns |  0.79 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    194.71 ns |   0.1421 ns |   0.1259 ns |    194.73 ns |  0.64 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    194.84 ns |   0.0534 ns |   0.0417 ns |    194.85 ns |  0.64 |    0.00 |
|                                           ForeachDelegate |           [50] |    370.02 ns |   6.2476 ns |   5.8440 ns |    365.31 ns |  1.21 |    0.02 |
|                                                   Foreach |           [50] |    304.86 ns |   0.0699 ns |   0.0619 ns |    304.86 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **107.45 ns** |   **0.0459 ns** |   **0.0407 ns** |    **107.44 ns** |  **2.35** |    **0.05** |
|                                   LowCostLinqWithDelegate |            [5] |     85.25 ns |   0.0628 ns |   0.0588 ns |     85.24 ns |  1.86 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     81.55 ns |   0.0575 ns |   0.0537 ns |     81.54 ns |  1.78 |    0.04 |
|                                  LowCostLinqWithDelegate2 |            [5] |     89.23 ns |   0.0395 ns |   0.0369 ns |     89.24 ns |  1.95 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     83.69 ns |   0.0664 ns |   0.0621 ns |     83.68 ns |  1.83 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |     77.16 ns |   1.5193 ns |   1.4922 ns |     76.66 ns |  1.69 |    0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     71.74 ns |   0.0746 ns |   0.0698 ns |     71.73 ns |  1.57 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    109.81 ns |   0.0358 ns |   0.0317 ns |    109.82 ns |  2.40 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    108.42 ns |   2.0859 ns |   2.2319 ns |    106.95 ns |  2.38 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    102.40 ns |   0.0347 ns |   0.0308 ns |    102.39 ns |  2.23 |    0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    100.54 ns |   0.0327 ns |   0.0290 ns |    100.55 ns |  2.19 |    0.05 |
|                                                 LinqCount |            [5] |     86.45 ns |   1.7500 ns |   2.0832 ns |     85.16 ns |  1.90 |    0.05 |
|                              LowCostLinqWithDelegateCount |            [5] |     76.22 ns |   0.0610 ns |   0.0541 ns |     76.21 ns |  1.66 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     80.56 ns |   0.0280 ns |   0.0262 ns |     80.55 ns |  1.76 |    0.04 |
|                           LowCostLinqWithStructWhereCount |            [5] |     63.61 ns |   0.0428 ns |   0.0401 ns |     63.61 ns |  1.39 |    0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     64.89 ns |   1.2783 ns |   1.4721 ns |     63.75 ns |  1.43 |    0.04 |
|                                               LinqToArray |            [5] |    166.12 ns |   0.0624 ns |   0.0584 ns |    166.13 ns |  3.63 |    0.08 |
|                            LowCostLinqWithDelegateToArray |            [5] |    140.67 ns |   0.0695 ns |   0.0616 ns |    140.65 ns |  3.07 |    0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    140.34 ns |   0.0493 ns |   0.0461 ns |    140.33 ns |  3.07 |    0.06 |
|                              LowCostLinqWithStructToArray |            [5] |    128.11 ns |   2.4953 ns |   2.3341 ns |    127.07 ns |  2.80 |    0.09 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    125.24 ns |   0.1309 ns |   0.1161 ns |    125.22 ns |  2.73 |    0.06 |
|                                                      Take |            [5] |    182.36 ns |   0.0771 ns |   0.0684 ns |    182.37 ns |  3.98 |    0.08 |
|                                               LowCostTake |            [5] |     97.69 ns |   1.5553 ns |   1.4549 ns |     96.86 ns |  2.13 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [5] |     87.26 ns |   0.0604 ns |   0.0536 ns |     87.28 ns |  1.90 |    0.04 |
|                                     LowCostTakeWithStruct |            [5] |     85.64 ns |   0.0528 ns |   0.0494 ns |     85.65 ns |  1.87 |    0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     77.68 ns |   0.1007 ns |   0.0942 ns |     77.64 ns |  1.70 |    0.03 |
|                                            SkipTakeSingle |            [5] |    161.71 ns |   0.0701 ns |   0.0655 ns |    161.71 ns |  3.53 |    0.07 |
|                                     LowCostSkipTakeSingle |            [5] |     99.16 ns |   0.0436 ns |   0.0386 ns |     99.15 ns |  2.16 |    0.05 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     96.36 ns |   0.0586 ns |   0.0548 ns |     96.35 ns |  2.11 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     84.88 ns |   1.3975 ns |   1.3073 ns |     83.86 ns |  1.86 |    0.06 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     82.81 ns |   0.1065 ns |   0.0996 ns |     82.81 ns |  1.81 |    0.04 |
|                                           ForeachDelegate |            [5] |     54.59 ns |   0.0225 ns |   0.0200 ns |     54.59 ns |  1.19 |    0.03 |
|                                                   Foreach |            [5] |     45.69 ns |   0.9113 ns |   0.9358 ns |     45.00 ns |  1.00 |    0.00 |
