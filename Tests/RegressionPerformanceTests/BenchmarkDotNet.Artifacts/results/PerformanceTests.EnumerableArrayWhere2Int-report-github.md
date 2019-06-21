``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **49.44 ns** |   **0.0189 ns** |   **0.0177 ns** |     **49.43 ns** |  **4.41** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     35.01 ns |   0.0105 ns |   0.0098 ns |     35.01 ns |  3.13 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     33.66 ns |   0.0178 ns |   0.0139 ns |     33.67 ns |  3.01 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     45.85 ns |   0.0202 ns |   0.0189 ns |     45.85 ns |  4.09 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     49.85 ns |   0.0182 ns |   0.0171 ns |     49.85 ns |  4.45 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     41.20 ns |   0.4298 ns |   0.4020 ns |     40.92 ns |  3.68 |    0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     41.41 ns |   0.0169 ns |   0.0158 ns |     41.41 ns |  3.70 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    104.46 ns |   0.0674 ns |   0.0631 ns |    104.46 ns |  9.32 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     95.49 ns |   0.0588 ns |   0.0550 ns |     95.47 ns |  8.52 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     89.08 ns |   0.1839 ns |   0.1720 ns |     89.06 ns |  7.95 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     83.02 ns |   0.0516 ns |   0.0483 ns |     83.01 ns |  7.41 |    0.00 |
|                                                 LinqCount |            [0] |     49.66 ns |   0.0638 ns |   0.0597 ns |     49.67 ns |  4.43 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     33.25 ns |   0.5054 ns |   0.4727 ns |     33.18 ns |  2.97 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.05 ns |   0.0383 ns |   0.0358 ns |     33.05 ns |  2.95 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     30.15 ns |   0.0083 ns |   0.0077 ns |     30.15 ns |  2.69 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     30.06 ns |   0.0531 ns |   0.0496 ns |     30.08 ns |  2.68 |    0.00 |
|                                               LinqToArray |            [0] |     63.95 ns |   0.0201 ns |   0.0178 ns |     63.95 ns |  5.71 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     46.45 ns |   0.0186 ns |   0.0174 ns |     46.45 ns |  4.15 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     44.89 ns |   0.0268 ns |   0.0251 ns |     44.90 ns |  4.01 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     39.55 ns |   0.0687 ns |   0.0609 ns |     39.56 ns |  3.53 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     40.31 ns |   0.6535 ns |   0.6112 ns |     39.79 ns |  3.60 |    0.05 |
|                                                      Take |            [0] |     82.61 ns |   0.0344 ns |   0.0322 ns |     82.60 ns |  7.38 |    0.00 |
|                                               LowCostTake |            [0] |     42.70 ns |   0.0290 ns |   0.0257 ns |     42.70 ns |  3.81 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     42.43 ns |   0.0164 ns |   0.0137 ns |     42.43 ns |  3.79 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     46.79 ns |   0.0110 ns |   0.0092 ns |     46.79 ns |  4.18 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     47.38 ns |   0.0041 ns |   0.0039 ns |     47.38 ns |  4.23 |    0.00 |
|                                            SkipTakeSingle |            [0] |    107.87 ns |   0.0305 ns |   0.0285 ns |    107.86 ns |  9.63 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     49.56 ns |   0.0110 ns |   0.0103 ns |     49.55 ns |  4.42 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     49.43 ns |   0.0170 ns |   0.0142 ns |     49.43 ns |  4.41 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     52.15 ns |   0.0115 ns |   0.0108 ns |     52.15 ns |  4.66 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     51.86 ns |   0.0089 ns |   0.0079 ns |     51.86 ns |  4.63 |    0.00 |
|                                           ForeachDelegate |            [0] |     14.18 ns |   0.0034 ns |   0.0030 ns |     14.18 ns |  1.27 |    0.00 |
|                                                   Foreach |            [0] |     11.20 ns |   0.0038 ns |   0.0034 ns |     11.20 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** |  **7,496.68 ns** |   **3.8227 ns** |   **3.3887 ns** |  **7,497.48 ns** |  **1.74** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  6,384.70 ns | 122.8830 ns | 120.6876 ns |  6,359.00 ns |  1.48 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,805.76 ns | 136.1099 ns | 252.2885 ns |  6,770.38 ns |  1.57 |    0.07 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  7,163.51 ns | 143.0787 ns | 140.5224 ns |  7,148.96 ns |  1.66 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,664.64 ns | 132.9236 ns | 271.5278 ns |  6,692.15 ns |  1.56 |    0.05 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,729.07 ns |   2.6881 ns |   2.5145 ns |  1,728.74 ns |  0.40 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,575.57 ns |  22.9930 ns |  21.5077 ns |  1,561.94 ns |  0.37 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,331.64 ns |  20.6094 ns |  17.2098 ns | 19,329.76 ns |  4.48 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 20,233.37 ns | 306.2754 ns | 286.4902 ns | 20,201.50 ns |  4.69 |    0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,965.12 ns |   6.8247 ns |   6.0499 ns |  8,964.79 ns |  2.08 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,477.79 ns |   2.7475 ns |   2.5700 ns |  8,477.37 ns |  1.97 |    0.00 |
|                                                 LinqCount |         [1000] |  3,913.45 ns |   7.5404 ns |   7.0533 ns |  3,913.87 ns |  0.91 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  4,926.08 ns |  97.5592 ns | 165.6630 ns |  4,968.85 ns |  1.15 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  4,656.47 ns |  59.2473 ns |  52.5212 ns |  4,643.67 ns |  1.08 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,384.45 ns |  12.1910 ns |  11.4034 ns |  1,384.31 ns |  0.32 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,358.79 ns |   5.0692 ns |   4.7418 ns |  1,360.69 ns |  0.32 |    0.00 |
|                                               LinqToArray |         [1000] |  5,091.56 ns |   3.1401 ns |   2.9373 ns |  5,091.19 ns |  1.18 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,394.96 ns |   6.2653 ns |   4.8915 ns |  7,394.33 ns |  1.71 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,560.64 ns |   7.2608 ns |   6.4365 ns |  6,560.59 ns |  1.52 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,446.28 ns |   6.8737 ns |   6.4296 ns |  2,448.81 ns |  0.57 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,428.81 ns |   4.8264 ns |   4.5146 ns |  2,429.09 ns |  0.56 |    0.00 |
|                                                      Take |         [1000] |    364.08 ns |   5.8509 ns |   5.4730 ns |    359.54 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    182.87 ns |   3.4664 ns |   3.5597 ns |    182.54 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    155.86 ns |   2.5316 ns |   2.3680 ns |    154.73 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     98.17 ns |   0.8367 ns |   0.7827 ns |     97.78 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     88.99 ns |   0.0213 ns |   0.0189 ns |     88.99 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    265.68 ns |   0.0545 ns |   0.0483 ns |    265.66 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    181.40 ns |   4.1659 ns |   4.2781 ns |    179.21 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    173.21 ns |   3.4672 ns |   4.8606 ns |    172.96 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     74.16 ns |   0.3207 ns |   0.3000 ns |     74.10 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     72.08 ns |   0.1140 ns |   0.1066 ns |     72.11 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  7,280.61 ns |   7.0536 ns |   5.5070 ns |  7,279.97 ns |  1.69 |    0.00 |
|                                                   Foreach |         [1000] |  4,312.19 ns |   1.7968 ns |   1.6807 ns |  4,311.60 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **437.50 ns** |   **0.2455 ns** |   **0.2297 ns** |    **437.55 ns** |  **1.85** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    367.92 ns |   7.0227 ns |   8.0874 ns |    367.58 ns |  1.55 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    344.04 ns |   6.2770 ns |   5.8715 ns |    340.06 ns |  1.45 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |    402.46 ns |   5.7618 ns |   5.1077 ns |    401.72 ns |  1.70 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    358.50 ns |   5.3984 ns |   4.7856 ns |    358.85 ns |  1.52 |    0.02 |
|                                LowCostLinqWithStructWhere |           [50] |    134.51 ns |   0.0324 ns |   0.0271 ns |    134.51 ns |  0.57 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    126.35 ns |   0.1271 ns |   0.1189 ns |    126.34 ns |  0.53 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,075.38 ns |   1.3027 ns |   1.1548 ns |  1,075.38 ns |  4.55 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,082.17 ns |   1.2985 ns |   1.2146 ns |  1,082.05 ns |  4.58 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    542.44 ns |   0.2588 ns |   0.2421 ns |    542.38 ns |  2.29 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    535.34 ns |   6.7016 ns |   6.2687 ns |    536.65 ns |  2.26 |    0.03 |
|                                                 LinqCount |           [50] |    256.09 ns |   0.1415 ns |   0.1324 ns |    256.07 ns |  1.08 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    269.70 ns |   5.1914 ns |   4.8560 ns |    270.40 ns |  1.14 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    280.13 ns |   5.5308 ns |   7.5706 ns |    282.48 ns |  1.20 |    0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |     85.26 ns |   0.7951 ns |   0.7438 ns |     85.01 ns |  0.36 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     83.87 ns |   0.0455 ns |   0.0426 ns |     83.88 ns |  0.35 |    0.00 |
|                                               LinqToArray |           [50] |    508.29 ns |   0.2344 ns |   0.2193 ns |    508.31 ns |  2.15 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    498.96 ns |   0.6611 ns |   0.6184 ns |    498.76 ns |  2.11 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    471.37 ns |   8.6543 ns |   8.0952 ns |    465.73 ns |  2.00 |    0.03 |
|                              LowCostLinqWithStructToArray |           [50] |    216.89 ns |   0.2446 ns |   0.2288 ns |    216.96 ns |  0.92 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    219.87 ns |   0.2693 ns |   0.2103 ns |    219.92 ns |  0.93 |    0.00 |
|                                                      Take |           [50] |    359.36 ns |   4.6907 ns |   4.1582 ns |    357.33 ns |  1.52 |    0.02 |
|                                               LowCostTake |           [50] |    179.31 ns |   2.7304 ns |   2.4204 ns |    178.75 ns |  0.76 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    165.38 ns |   3.2636 ns |   5.0810 ns |    164.52 ns |  0.70 |    0.02 |
|                                     LowCostTakeWithStruct |           [50] |     97.97 ns |   0.1475 ns |   0.1232 ns |     98.00 ns |  0.41 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     88.67 ns |   0.0385 ns |   0.0360 ns |     88.67 ns |  0.38 |    0.00 |
|                                            SkipTakeSingle |           [50] |    266.23 ns |   0.0842 ns |   0.0703 ns |    266.22 ns |  1.13 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    187.68 ns |   3.6730 ns |   4.9033 ns |    186.65 ns |  0.80 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    164.97 ns |   0.6159 ns |   0.5460 ns |    165.10 ns |  0.70 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     73.03 ns |   0.1158 ns |   0.1083 ns |     73.05 ns |  0.31 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     72.50 ns |   0.1940 ns |   0.1815 ns |     72.51 ns |  0.31 |    0.00 |
|                                           ForeachDelegate |           [50] |    391.43 ns |   0.1757 ns |   0.1372 ns |    391.41 ns |  1.66 |    0.00 |
|                                                   Foreach |           [50] |    236.44 ns |   0.0252 ns |   0.0223 ns |    236.44 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |     **97.96 ns** |   **0.0721 ns** |   **0.0639 ns** |     **97.97 ns** |  **2.86** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     64.87 ns |   1.2935 ns |   1.9360 ns |     64.83 ns |  1.90 |    0.07 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     59.96 ns |   0.7542 ns |   0.6686 ns |     59.77 ns |  1.75 |    0.02 |
|                                  LowCostLinqWithDelegate2 |            [5] |     77.61 ns |   1.3302 ns |   1.2442 ns |     77.03 ns |  2.27 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     77.33 ns |   1.3626 ns |   1.2746 ns |     76.74 ns |  2.26 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |     55.45 ns |   0.0243 ns |   0.0215 ns |     55.44 ns |  1.62 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     50.37 ns |   0.0712 ns |   0.0666 ns |     50.40 ns |  1.47 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    214.40 ns |   4.7051 ns |   5.2297 ns |    211.24 ns |  6.28 |    0.16 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    201.83 ns |   0.1917 ns |   0.1793 ns |    201.83 ns |  5.90 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    135.80 ns |   0.0598 ns |   0.0560 ns |    135.81 ns |  3.97 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    129.96 ns |   0.0490 ns |   0.0434 ns |    129.96 ns |  3.80 |    0.00 |
|                                                 LinqCount |            [5] |     81.40 ns |   1.8736 ns |   1.7525 ns |     80.40 ns |  2.38 |    0.05 |
|                              LowCostLinqWithDelegateCount |            [5] |     57.30 ns |   0.8665 ns |   0.7681 ns |     57.17 ns |  1.67 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     56.56 ns |   0.5815 ns |   0.5155 ns |     56.57 ns |  1.65 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     33.80 ns |   0.6154 ns |   0.5756 ns |     33.47 ns |  0.99 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     33.00 ns |   0.0062 ns |   0.0052 ns |     33.00 ns |  0.96 |    0.00 |
|                                               LinqToArray |            [5] |    143.72 ns |   0.0751 ns |   0.0702 ns |    143.73 ns |  4.20 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    108.07 ns |   0.0327 ns |   0.0306 ns |    108.08 ns |  3.16 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    103.49 ns |   0.0343 ns |   0.0320 ns |    103.49 ns |  3.03 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     74.86 ns |   0.0478 ns |   0.0424 ns |     74.87 ns |  2.19 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     75.98 ns |   0.0842 ns |   0.0787 ns |     76.00 ns |  2.22 |    0.00 |
|                                                      Take |            [5] |    165.02 ns |   3.0531 ns |   2.8558 ns |    165.20 ns |  4.82 |    0.08 |
|                                               LowCostTake |            [5] |     72.70 ns |   1.4296 ns |   2.0955 ns |     72.82 ns |  2.14 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [5] |     69.41 ns |   1.3130 ns |   1.1640 ns |     68.82 ns |  2.03 |    0.03 |
|                                     LowCostTakeWithStruct |            [5] |     59.49 ns |   0.0411 ns |   0.0384 ns |     59.48 ns |  1.74 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     61.50 ns |   0.5639 ns |   0.5274 ns |     61.62 ns |  1.80 |    0.02 |
|                                            SkipTakeSingle |            [5] |    153.80 ns |   0.3795 ns |   0.3550 ns |    153.56 ns |  4.50 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     72.88 ns |   0.5635 ns |   0.5271 ns |     72.74 ns |  2.13 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     75.01 ns |   1.5020 ns |   1.4751 ns |     75.08 ns |  2.19 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     55.64 ns |   0.0070 ns |   0.0062 ns |     55.64 ns |  1.63 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.84 ns |   0.0068 ns |   0.0064 ns |     55.84 ns |  1.63 |    0.00 |
|                                           ForeachDelegate |            [5] |     53.34 ns |   0.1382 ns |   0.1154 ns |     53.31 ns |  1.56 |    0.00 |
|                                                   Foreach |            [5] |     34.21 ns |   0.0189 ns |   0.0176 ns |     34.22 ns |  1.00 |    0.00 |
