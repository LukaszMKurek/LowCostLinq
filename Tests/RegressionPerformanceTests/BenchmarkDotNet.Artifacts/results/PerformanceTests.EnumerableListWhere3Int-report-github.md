``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **96.14 ns** |   **0.0584 ns** |   **0.0546 ns** |     **96.15 ns** |  **5.62** |    **0.09** |
|                                   LowCostLinqWithDelegate |            [0] |     37.99 ns |   0.0086 ns |   0.0081 ns |     38.00 ns |  2.22 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     30.10 ns |   0.0157 ns |   0.0147 ns |     30.10 ns |  1.76 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [0] |     61.26 ns |   0.0205 ns |   0.0192 ns |     61.26 ns |  3.58 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     52.97 ns |   0.0085 ns |   0.0080 ns |     52.97 ns |  3.09 |    0.05 |
|                                LowCostLinqWithStructWhere |            [0] |     48.62 ns |   0.0171 ns |   0.0160 ns |     48.62 ns |  2.84 |    0.05 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     41.12 ns |   0.0053 ns |   0.0050 ns |     41.12 ns |  2.40 |    0.04 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     71.48 ns |   0.0342 ns |   0.0320 ns |     71.47 ns |  4.18 |    0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     59.57 ns |   0.0351 ns |   0.0328 ns |     59.56 ns |  3.48 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     58.70 ns |   0.0122 ns |   0.0114 ns |     58.70 ns |  3.43 |    0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     48.45 ns |   0.0178 ns |   0.0148 ns |     48.46 ns |  2.83 |    0.05 |
|                                                 LinqCount |            [0] |     93.98 ns |   0.1336 ns |   0.1250 ns |     93.90 ns |  5.49 |    0.09 |
|                              LowCostLinqWithDelegateCount |            [0] |     38.04 ns |   0.0400 ns |   0.0374 ns |     38.04 ns |  2.22 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     35.70 ns |   0.0076 ns |   0.0063 ns |     35.70 ns |  2.08 |    0.04 |
|                           LowCostLinqWithStructWhereCount |            [0] |     44.43 ns |   0.0116 ns |   0.0103 ns |     44.43 ns |  2.59 |    0.04 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.77 ns |   0.0103 ns |   0.0096 ns |     36.77 ns |  2.15 |    0.04 |
|                                               LinqToArray |            [0] |    113.54 ns |   0.0769 ns |   0.0682 ns |    113.55 ns |  6.63 |    0.11 |
|                            LowCostLinqWithDelegateToArray |            [0] |     47.20 ns |   0.0147 ns |   0.0137 ns |     47.19 ns |  2.76 |    0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     46.71 ns |   0.0219 ns |   0.0205 ns |     46.71 ns |  2.73 |    0.05 |
|                              LowCostLinqWithStructToArray |            [0] |     53.30 ns |   0.0246 ns |   0.0231 ns |     53.30 ns |  3.11 |    0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     45.63 ns |   0.0101 ns |   0.0094 ns |     45.63 ns |  2.67 |    0.04 |
|                                                      Take |            [0] |    134.26 ns |   0.0465 ns |   0.0412 ns |    134.25 ns |  7.84 |    0.14 |
|                                               LowCostTake |            [0] |     44.86 ns |   0.0067 ns |   0.0059 ns |     44.86 ns |  2.62 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [0] |     38.84 ns |   0.0099 ns |   0.0088 ns |     38.84 ns |  2.27 |    0.04 |
|                                     LowCostTakeWithStruct |            [0] |     55.27 ns |   0.0075 ns |   0.0070 ns |     55.27 ns |  3.23 |    0.05 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     49.28 ns |   0.0071 ns |   0.0063 ns |     49.28 ns |  2.88 |    0.05 |
|                                            SkipTakeSingle |            [0] |    155.13 ns |   0.0691 ns |   0.0647 ns |    155.13 ns |  9.06 |    0.15 |
|                                     LowCostSkipTakeSingle |            [0] |     55.71 ns |   0.0151 ns |   0.0141 ns |     55.72 ns |  3.26 |    0.05 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     54.19 ns |   0.0140 ns |   0.0124 ns |     54.20 ns |  3.16 |    0.06 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     66.18 ns |   0.0055 ns |   0.0049 ns |     66.18 ns |  3.87 |    0.07 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     60.51 ns |   0.0137 ns |   0.0128 ns |     60.51 ns |  3.54 |    0.06 |
|                                           ForeachDelegate |            [0] |     19.77 ns |   0.0077 ns |   0.0068 ns |     19.77 ns |  1.15 |    0.02 |
|                                                   Foreach |            [0] |     17.12 ns |   0.3082 ns |   0.2883 ns |     17.01 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **12,610.39 ns** | **138.6689 ns** | **122.9264 ns** | **12,561.21 ns** |  **2.28** |    **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] | 10,127.49 ns | 202.5015 ns | 547.4745 ns | 10,195.12 ns |  1.82 |    0.10 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,551.40 ns | 208.0549 ns | 583.4082 ns |  8,323.86 ns |  1.50 |    0.09 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 10,408.32 ns |  60.8886 ns |  50.8447 ns | 10,400.34 ns |  1.88 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,744.00 ns | 174.5121 ns | 327.7760 ns |  8,594.95 ns |  1.59 |    0.06 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,920.54 ns |   1.9191 ns |   1.7952 ns |  2,920.66 ns |  0.53 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,415.58 ns |   0.2034 ns |   0.1903 ns |  1,415.59 ns |  0.26 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,284.00 ns | 307.6739 ns | 240.2115 ns | 19,359.87 ns |  3.49 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 16,627.93 ns | 279.3082 ns | 233.2350 ns | 16,530.53 ns |  3.01 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,099.60 ns |   2.4306 ns |   2.2736 ns |  5,099.13 ns |  0.92 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  4,599.43 ns |   2.0518 ns |   1.9193 ns |  4,598.77 ns |  0.83 |    0.00 |
|                                                 LinqCount |         [1000] |  8,762.93 ns | 173.7006 ns | 373.9088 ns |  8,835.55 ns |  1.60 |    0.04 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,010.25 ns | 262.7592 ns | 770.6272 ns |  9,888.00 ns |  1.81 |    0.11 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,043.28 ns | 160.7254 ns | 171.9743 ns |  8,067.95 ns |  1.45 |    0.04 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,723.88 ns |   0.2873 ns |   0.2547 ns |  1,723.80 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    637.27 ns |   0.1954 ns |   0.1827 ns |    637.27 ns |  0.12 |    0.00 |
|                                               LinqToArray |         [1000] |  7,674.51 ns |   8.9297 ns |   8.3528 ns |  7,672.94 ns |  1.39 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,636.75 ns |  27.7352 ns |  25.9435 ns |  9,641.05 ns |  1.74 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,981.90 ns |   7.9055 ns |   7.3948 ns |  8,985.24 ns |  1.63 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,923.49 ns |   1.9864 ns |   1.6588 ns |  2,924.16 ns |  0.53 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,809.31 ns |   1.9195 ns |   1.7016 ns |  1,809.06 ns |  0.33 |    0.00 |
|                                                      Take |         [1000] |    474.84 ns |   0.1793 ns |   0.1497 ns |    474.82 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |    261.22 ns |   0.8635 ns |   0.7654 ns |    261.01 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    314.53 ns |   4.2208 ns |   3.9481 ns |    314.04 ns |  0.06 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    120.70 ns |   0.1136 ns |   0.1007 ns |    120.76 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     88.28 ns |   0.0529 ns |   0.0495 ns |     88.27 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    394.44 ns |   0.1676 ns |   0.1568 ns |    394.43 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    371.20 ns |  13.1769 ns |  38.8524 ns |    389.40 ns |  0.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    257.27 ns |   5.1618 ns |  13.7778 ns |    257.67 ns |  0.05 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    123.70 ns |   0.1809 ns |   0.1693 ns |    123.70 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     87.58 ns |   0.0315 ns |   0.0294 ns |     87.59 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,510.97 ns |  28.0513 ns |  26.2392 ns |  9,517.15 ns |  1.72 |    0.00 |
|                                                   Foreach |         [1000] |  5,526.50 ns |   1.5287 ns |   1.3552 ns |  5,526.12 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **724.24 ns** |   **1.5399 ns** |   **1.4405 ns** |    **725.10 ns** |  **2.38** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    559.77 ns |   5.5651 ns |   5.2056 ns |    558.52 ns |  1.84 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    467.60 ns |   9.3238 ns |  25.6805 ns |    465.95 ns |  1.50 |    0.06 |
|                                  LowCostLinqWithDelegate2 |           [50] |    628.06 ns |  13.6474 ns |  40.2396 ns |    625.03 ns |  2.06 |    0.14 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    478.83 ns |   2.9494 ns |   2.6146 ns |    478.20 ns |  1.57 |    0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    193.52 ns |   0.0298 ns |   0.0264 ns |    193.52 ns |  0.64 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    120.29 ns |   0.0574 ns |   0.0509 ns |    120.26 ns |  0.39 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,028.43 ns |   6.2043 ns |   5.8035 ns |  1,029.09 ns |  3.38 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    907.49 ns |   9.4455 ns |   8.8353 ns |    902.30 ns |  2.98 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    319.85 ns |   0.0688 ns |   0.0643 ns |    319.84 ns |  1.05 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    283.50 ns |   0.0875 ns |   0.0818 ns |    283.50 ns |  0.93 |    0.00 |
|                                                 LinqCount |           [50] |    406.21 ns |   0.9786 ns |   0.9154 ns |    406.05 ns |  1.33 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    524.69 ns |  10.4198 ns |  28.6991 ns |    520.95 ns |  1.72 |    0.09 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    405.56 ns |   1.6600 ns |   1.4716 ns |    405.58 ns |  1.33 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    132.73 ns |   0.0663 ns |   0.0553 ns |    132.76 ns |  0.44 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     64.10 ns |   0.0171 ns |   0.0160 ns |     64.09 ns |  0.21 |    0.00 |
|                                               LinqToArray |           [50] |    683.83 ns |   0.6111 ns |   0.5418 ns |    683.66 ns |  2.25 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    645.64 ns |   1.1410 ns |   1.0673 ns |    645.64 ns |  2.12 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    597.68 ns |   1.7079 ns |   1.5976 ns |    597.44 ns |  1.96 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    276.90 ns |   0.0807 ns |   0.0755 ns |    276.87 ns |  0.91 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    212.78 ns |   0.2447 ns |   0.2169 ns |    212.84 ns |  0.70 |    0.00 |
|                                                      Take |           [50] |    466.75 ns |   0.2511 ns |   0.2097 ns |    466.71 ns |  1.53 |    0.00 |
|                                               LowCostTake |           [50] |    269.85 ns |   0.9640 ns |   0.8049 ns |    269.97 ns |  0.89 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    216.45 ns |   4.4770 ns |  13.2005 ns |    213.47 ns |  0.70 |    0.04 |
|                                     LowCostTakeWithStruct |           [50] |    121.82 ns |   0.0428 ns |   0.0400 ns |    121.81 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     89.35 ns |   0.0288 ns |   0.0269 ns |     89.34 ns |  0.29 |    0.00 |
|                                            SkipTakeSingle |           [50] |    402.07 ns |   0.5959 ns |   0.5283 ns |    402.03 ns |  1.32 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    296.18 ns |   5.8798 ns |  13.6274 ns |    301.67 ns |  0.96 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    260.03 ns |   4.4464 ns |   4.1592 ns |    261.00 ns |  0.85 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    123.76 ns |   0.0612 ns |   0.0572 ns |    123.77 ns |  0.41 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     87.05 ns |   0.0150 ns |   0.0117 ns |     87.05 ns |  0.29 |    0.00 |
|                                           ForeachDelegate |           [50] |    508.67 ns |   0.4859 ns |   0.4307 ns |    508.72 ns |  1.67 |    0.00 |
|                                                   Foreach |           [50] |    304.60 ns |   0.0716 ns |   0.0670 ns |    304.60 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **158.29 ns** |   **0.0562 ns** |   **0.0526 ns** |    **158.28 ns** |  **3.59** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     85.93 ns |   1.7251 ns |   3.9981 ns |     84.09 ns |  1.95 |    0.10 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     97.47 ns |   1.0584 ns |   0.9900 ns |     97.85 ns |  2.21 |    0.02 |
|                                  LowCostLinqWithDelegate2 |            [5] |    123.02 ns |   2.4998 ns |   7.0915 ns |    123.98 ns |  2.83 |    0.12 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     96.00 ns |   0.5142 ns |   0.4558 ns |     95.95 ns |  2.18 |    0.01 |
|                                LowCostLinqWithStructWhere |            [5] |     63.29 ns |   0.0159 ns |   0.0148 ns |     63.29 ns |  1.44 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     50.73 ns |   0.0280 ns |   0.0262 ns |     50.73 ns |  1.15 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    165.37 ns |   0.0664 ns |   0.0589 ns |    165.37 ns |  3.75 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    143.61 ns |   0.2523 ns |   0.2360 ns |    143.67 ns |  3.26 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     84.86 ns |   0.0267 ns |   0.0250 ns |     84.86 ns |  1.93 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     68.15 ns |   0.0173 ns |   0.0162 ns |     68.15 ns |  1.55 |    0.00 |
|                                                 LinqCount |            [5] |    124.64 ns |   0.2256 ns |   0.2000 ns |    124.54 ns |  2.83 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     93.99 ns |   1.8724 ns |   3.4705 ns |     92.58 ns |  2.15 |    0.09 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     76.12 ns |   1.5966 ns |   3.2972 ns |     75.54 ns |  1.72 |    0.09 |
|                           LowCostLinqWithStructWhereCount |            [5] |     52.84 ns |   0.0149 ns |   0.0139 ns |     52.84 ns |  1.20 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     39.58 ns |   0.0122 ns |   0.0115 ns |     39.58 ns |  0.90 |    0.00 |
|                                               LinqToArray |            [5] |    187.88 ns |   0.0709 ns |   0.0629 ns |    187.88 ns |  4.27 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    139.31 ns |   0.1389 ns |   0.1300 ns |    139.32 ns |  3.16 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    130.01 ns |   0.0711 ns |   0.0665 ns |    130.02 ns |  2.95 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    107.50 ns |   0.0247 ns |   0.0231 ns |    107.51 ns |  2.44 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     90.49 ns |   0.0153 ns |   0.0144 ns |     90.50 ns |  2.05 |    0.00 |
|                                                      Take |            [5] |    231.72 ns |   0.4730 ns |   0.4424 ns |    231.80 ns |  5.26 |    0.01 |
|                                               LowCostTake |            [5] |    100.12 ns |   2.0057 ns |   4.2306 ns |    100.84 ns |  2.34 |    0.06 |
|                                  LowCostTakeWithoutChecks |            [5] |     82.74 ns |   0.2843 ns |   0.2520 ns |     82.68 ns |  1.88 |    0.01 |
|                                     LowCostTakeWithStruct |            [5] |     70.77 ns |   0.0243 ns |   0.0227 ns |     70.77 ns |  1.61 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     60.03 ns |   0.0160 ns |   0.0150 ns |     60.03 ns |  1.36 |    0.00 |
|                                            SkipTakeSingle |            [5] |    212.15 ns |   0.0756 ns |   0.0707 ns |    212.15 ns |  4.82 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    106.81 ns |   2.1050 ns |   3.4585 ns |    106.50 ns |  2.40 |    0.07 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     97.50 ns |   0.7665 ns |   0.7170 ns |     97.54 ns |  2.21 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     77.03 ns |   0.0086 ns |   0.0072 ns |     77.03 ns |  1.75 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     65.80 ns |   0.0328 ns |   0.0307 ns |     65.81 ns |  1.49 |    0.00 |
|                                           ForeachDelegate |            [5] |     66.48 ns |   0.0417 ns |   0.0390 ns |     66.48 ns |  1.51 |    0.00 |
|                                                   Foreach |            [5] |     44.04 ns |   0.0294 ns |   0.0275 ns |     44.04 ns |  1.00 |    0.00 |
