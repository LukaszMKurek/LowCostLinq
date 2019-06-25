``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **81.76 ns** |   **0.0770 ns** |   **0.0721 ns** |     **81.77 ns** |  **7.24** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     37.10 ns |   0.0181 ns |   0.0169 ns |     37.10 ns |  3.29 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     34.23 ns |   0.0127 ns |   0.0119 ns |     34.23 ns |  3.03 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     58.96 ns |   0.0153 ns |   0.0143 ns |     58.97 ns |  5.22 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     54.68 ns |   0.0117 ns |   0.0109 ns |     54.68 ns |  4.84 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     46.77 ns |   0.0134 ns |   0.0125 ns |     46.77 ns |  4.14 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     45.97 ns |   0.0094 ns |   0.0088 ns |     45.97 ns |  4.07 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    109.31 ns |   0.1646 ns |   0.1540 ns |    109.26 ns |  9.68 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    101.69 ns |   0.0605 ns |   0.0566 ns |    101.69 ns |  9.01 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     95.76 ns |   0.0948 ns |   0.0740 ns |     95.76 ns |  8.48 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     88.71 ns |   1.4378 ns |   1.3449 ns |     87.80 ns |  7.86 |    0.12 |
|                                                 LinqCount |            [0] |     84.77 ns |   1.0636 ns |   0.8881 ns |     84.67 ns |  7.51 |    0.08 |
|                              LowCostLinqWithDelegateCount |            [0] |     35.77 ns |   0.0198 ns |   0.0165 ns |     35.77 ns |  3.17 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     35.51 ns |   0.0139 ns |   0.0130 ns |     35.51 ns |  3.15 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.71 ns |   0.0126 ns |   0.0112 ns |     37.71 ns |  3.34 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     37.09 ns |   0.0067 ns |   0.0060 ns |     37.09 ns |  3.29 |    0.00 |
|                                               LinqToArray |            [0] |     95.39 ns |   0.0570 ns |   0.0533 ns |     95.39 ns |  8.45 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     49.39 ns |   0.0718 ns |   0.0671 ns |     49.37 ns |  4.37 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     48.05 ns |   0.0595 ns |   0.0557 ns |     48.06 ns |  4.26 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     47.82 ns |   0.0234 ns |   0.0219 ns |     47.82 ns |  4.24 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     47.81 ns |   0.0565 ns |   0.0529 ns |     47.78 ns |  4.23 |    0.01 |
|                                                      Take |            [0] |    120.44 ns |   0.0387 ns |   0.0343 ns |    120.44 ns | 10.67 |    0.00 |
|                                               LowCostTake |            [0] |     42.84 ns |   0.0135 ns |   0.0126 ns |     42.85 ns |  3.79 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     40.86 ns |   0.0093 ns |   0.0087 ns |     40.86 ns |  3.62 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     54.15 ns |   0.0096 ns |   0.0090 ns |     54.14 ns |  4.80 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     51.15 ns |   0.0688 ns |   0.0644 ns |     51.17 ns |  4.53 |    0.01 |
|                                            SkipTakeSingle |            [0] |    141.21 ns |   0.0518 ns |   0.0484 ns |    141.20 ns | 12.51 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     54.85 ns |   0.0264 ns |   0.0247 ns |     54.86 ns |  4.86 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     56.02 ns |   0.0123 ns |   0.0115 ns |     56.02 ns |  4.96 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     59.11 ns |   0.0793 ns |   0.0741 ns |     59.13 ns |  5.24 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     59.29 ns |   0.0150 ns |   0.0140 ns |     59.29 ns |  5.25 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.31 ns |   0.0076 ns |   0.0071 ns |     15.31 ns |  1.36 |    0.00 |
|                                                   Foreach |            [0] |     11.29 ns |   0.0027 ns |   0.0025 ns |     11.29 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** | **11,387.80 ns** | **263.2543 ns** | **292.6064 ns** | **11,213.52 ns** |  **2.64** |    **0.07** |
|                                   LowCostLinqWithDelegate |         [1000] | 10,146.96 ns | 266.2113 ns | 784.9299 ns |  9,864.90 ns |  2.26 |    0.12 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,835.53 ns | 259.9275 ns | 217.0512 ns |  8,751.57 ns |  2.04 |    0.05 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,539.24 ns | 190.4275 ns | 537.1042 ns |  9,394.02 ns |  2.17 |    0.08 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  9,790.76 ns | 218.0101 ns | 642.8078 ns |  9,438.28 ns |  2.22 |    0.13 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,289.91 ns |   1.8123 ns |   1.6065 ns |  1,290.30 ns |  0.30 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,304.59 ns |   5.1883 ns |   4.8531 ns |  1,306.98 ns |  0.30 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 22,199.12 ns | 438.0586 ns | 707.3830 ns | 21,750.08 ns |  5.10 |    0.13 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 21,484.94 ns | 515.6113 ns | 529.4949 ns | 21,220.02 ns |  4.98 |    0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,982.92 ns |   3.7244 ns |   3.4838 ns |  8,983.72 ns |  2.08 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,956.86 ns |   2.9112 ns |   2.5807 ns |  8,956.75 ns |  2.07 |    0.00 |
|                                                 LinqCount |         [1000] |  6,002.94 ns |  57.7194 ns |  48.1983 ns |  5,986.22 ns |  1.39 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,023.28 ns |  78.5688 ns |  65.6085 ns |  8,010.50 ns |  1.85 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  7,059.30 ns |  32.2995 ns |  26.9716 ns |  7,056.87 ns |  1.63 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    640.08 ns |   0.2364 ns |   0.2211 ns |    640.00 ns |  0.15 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    580.73 ns |   2.3668 ns |   2.2139 ns |    580.76 ns |  0.13 |    0.00 |
|                                               LinqToArray |         [1000] |  7,937.99 ns |  11.0970 ns |   9.2665 ns |  7,938.09 ns |  1.84 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 10,078.06 ns | 200.0514 ns | 260.1234 ns |  9,912.23 ns |  2.35 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  9,762.87 ns |  26.5258 ns |  23.5145 ns |  9,766.50 ns |  2.26 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,149.06 ns |   5.9966 ns |   5.6092 ns |  2,150.43 ns |  0.50 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,160.07 ns |   2.3431 ns |   2.1917 ns |  2,160.20 ns |  0.50 |    0.00 |
|                                                      Take |         [1000] |    419.94 ns |   1.3474 ns |   1.2604 ns |    420.32 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    230.70 ns |   4.6315 ns |  11.0072 ns |    226.50 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    223.67 ns |   5.5607 ns |  16.3957 ns |    211.64 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     94.12 ns |   0.0343 ns |   0.0321 ns |     94.12 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     82.84 ns |   0.0057 ns |   0.0048 ns |     82.84 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    352.16 ns |   0.2599 ns |   0.2431 ns |    352.10 ns |  0.08 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    262.51 ns |   0.8257 ns |   0.7724 ns |    262.57 ns |  0.06 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    246.98 ns |   7.9982 ns |   8.2136 ns |    243.00 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     83.47 ns |   0.0258 ns |   0.0229 ns |     83.47 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     85.31 ns |   0.0344 ns |   0.0268 ns |     85.31 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,115.35 ns |   4.6969 ns |   4.3934 ns |  8,116.90 ns |  1.88 |    0.00 |
|                                                   Foreach |         [1000] |  4,325.63 ns |   1.0582 ns |   0.9899 ns |  4,325.56 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **666.41 ns** |   **2.5714 ns** |   **2.4052 ns** |    **665.45 ns** |  **2.81** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    557.48 ns |   7.0314 ns |   6.5771 ns |    558.07 ns |  2.35 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    487.36 ns |   9.6524 ns |  16.6498 ns |    475.51 ns |  2.06 |    0.07 |
|                                  LowCostLinqWithDelegate2 |           [50] |    523.53 ns |  12.2276 ns |  36.0535 ns |    500.51 ns |  2.28 |    0.17 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    538.96 ns |  10.7285 ns |  30.6091 ns |    530.32 ns |  2.22 |    0.09 |
|                                LowCostLinqWithStructWhere |           [50] |    115.74 ns |   0.0318 ns |   0.0298 ns |    115.74 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    113.40 ns |   0.0135 ns |   0.0113 ns |    113.40 ns |  0.48 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,215.26 ns |  12.3073 ns |  11.5123 ns |  1,207.63 ns |  5.12 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,177.31 ns |  17.8983 ns |  16.7421 ns |  1,165.78 ns |  4.97 |    0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    555.48 ns |   0.2946 ns |   0.2300 ns |    555.45 ns |  2.34 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    542.72 ns |   0.2593 ns |   0.2426 ns |    542.67 ns |  2.29 |    0.00 |
|                                                 LinqCount |           [50] |    387.93 ns |   0.6827 ns |   0.6386 ns |    387.79 ns |  1.64 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    637.86 ns |  32.0889 ns |  93.6047 ns |    672.57 ns |  2.69 |    0.39 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    401.52 ns |   8.0238 ns |   7.5055 ns |    398.77 ns |  1.69 |    0.03 |
|                           LowCostLinqWithStructWhereCount |           [50] |     62.44 ns |   0.0986 ns |   0.0923 ns |     62.40 ns |  0.26 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     63.88 ns |   0.0703 ns |   0.0657 ns |     63.86 ns |  0.27 |    0.00 |
|                                               LinqToArray |           [50] |    699.20 ns |   0.8791 ns |   0.8223 ns |    699.27 ns |  2.95 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    630.51 ns |   0.8581 ns |   0.7607 ns |    630.49 ns |  2.66 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    617.94 ns |   0.2859 ns |   0.2674 ns |    617.99 ns |  2.61 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    212.07 ns |   0.2675 ns |   0.2372 ns |    212.09 ns |  0.89 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    225.67 ns |   0.4262 ns |   0.3986 ns |    225.51 ns |  0.95 |    0.00 |
|                                                      Take |           [50] |    421.81 ns |   8.1799 ns |   9.4200 ns |    416.49 ns |  1.79 |    0.04 |
|                                               LowCostTake |           [50] |    240.49 ns |   5.8482 ns |  17.2435 ns |    240.47 ns |  1.05 |    0.08 |
|                                  LowCostTakeWithoutChecks |           [50] |    234.07 ns |   1.1370 ns |   1.0635 ns |    234.37 ns |  0.99 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |     94.95 ns |   0.0238 ns |   0.0222 ns |     94.96 ns |  0.40 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     82.51 ns |   0.0393 ns |   0.0367 ns |     82.52 ns |  0.35 |    0.00 |
|                                            SkipTakeSingle |           [50] |    353.49 ns |   0.2953 ns |   0.2762 ns |    353.50 ns |  1.49 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    261.17 ns |   0.3708 ns |   0.2895 ns |    261.21 ns |  1.10 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    256.92 ns |   5.3329 ns |  15.6405 ns |    252.60 ns |  1.07 |    0.08 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     83.37 ns |   0.0231 ns |   0.0193 ns |     83.37 ns |  0.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     85.73 ns |   0.0315 ns |   0.0295 ns |     85.73 ns |  0.36 |    0.00 |
|                                           ForeachDelegate |           [50] |    435.25 ns |   0.3469 ns |   0.3245 ns |    435.35 ns |  1.84 |    0.00 |
|                                                   Foreach |           [50] |    237.13 ns |   0.0486 ns |   0.0431 ns |    237.12 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **147.20 ns** |   **0.2665 ns** |   **0.2225 ns** |    **147.13 ns** |  **4.29** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     79.66 ns |   2.2946 ns |   2.1464 ns |     78.62 ns |  2.32 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     71.49 ns |   0.2256 ns |   0.1761 ns |     71.52 ns |  2.08 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |    111.72 ns |   2.3843 ns |   7.0303 ns |    110.67 ns |  3.35 |    0.20 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     91.04 ns |   2.0432 ns |   2.2710 ns |     89.92 ns |  2.67 |    0.07 |
|                                LowCostLinqWithStructWhere |            [5] |     52.50 ns |   0.0088 ns |   0.0083 ns |     52.49 ns |  1.53 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     49.43 ns |   0.0125 ns |   0.0104 ns |     49.43 ns |  1.44 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    231.68 ns |   0.3246 ns |   0.3036 ns |    231.79 ns |  6.76 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    217.25 ns |   0.2490 ns |   0.2329 ns |    217.21 ns |  6.34 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    141.97 ns |   0.0399 ns |   0.0373 ns |    141.98 ns |  4.14 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    132.36 ns |   0.0748 ns |   0.0700 ns |    132.38 ns |  3.86 |    0.00 |
|                                                 LinqCount |            [5] |    122.81 ns |   0.1008 ns |   0.0893 ns |    122.81 ns |  3.58 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     75.36 ns |   1.7657 ns |   2.3571 ns |     74.27 ns |  2.22 |    0.08 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     92.12 ns |   4.0352 ns |  11.8978 ns |     97.62 ns |  2.83 |    0.17 |
|                           LowCostLinqWithStructWhereCount |            [5] |     39.46 ns |   0.0108 ns |   0.0095 ns |     39.46 ns |  1.15 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     39.92 ns |   0.0083 ns |   0.0078 ns |     39.92 ns |  1.16 |    0.00 |
|                                               LinqToArray |            [5] |    194.61 ns |   0.0528 ns |   0.0468 ns |    194.61 ns |  5.68 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    123.46 ns |   0.1106 ns |   0.1035 ns |    123.45 ns |  3.60 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    122.38 ns |   0.1923 ns |   0.1799 ns |    122.38 ns |  3.57 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     82.28 ns |   0.0548 ns |   0.0458 ns |     82.28 ns |  2.40 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     82.26 ns |   0.0419 ns |   0.0392 ns |     82.26 ns |  2.40 |    0.00 |
|                                                      Take |            [5] |    208.67 ns |   0.1040 ns |   0.0973 ns |    208.64 ns |  6.09 |    0.00 |
|                                               LowCostTake |            [5] |    102.81 ns |   5.3511 ns |  15.7777 ns |    112.22 ns |  3.01 |    0.42 |
|                                  LowCostTakeWithoutChecks |            [5] |     80.35 ns |   1.9335 ns |   4.2034 ns |     77.73 ns |  2.39 |    0.14 |
|                                     LowCostTakeWithStruct |            [5] |     64.31 ns |   0.0202 ns |   0.0189 ns |     64.31 ns |  1.88 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     60.85 ns |   0.1883 ns |   0.1761 ns |     60.88 ns |  1.77 |    0.00 |
|                                            SkipTakeSingle |            [5] |    194.99 ns |   0.0662 ns |   0.0619 ns |    194.99 ns |  5.69 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    100.83 ns |   2.0304 ns |   3.1611 ns |    100.62 ns |  2.92 |    0.08 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     95.70 ns |   1.9284 ns |   3.4774 ns |     94.36 ns |  2.76 |    0.10 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     63.42 ns |   0.0386 ns |   0.0361 ns |     63.43 ns |  1.85 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     63.46 ns |   0.0275 ns |   0.0244 ns |     63.46 ns |  1.85 |    0.00 |
|                                           ForeachDelegate |            [5] |     57.77 ns |   0.0147 ns |   0.0137 ns |     57.77 ns |  1.68 |    0.00 |
|                                                   Foreach |            [5] |     34.29 ns |   0.0154 ns |   0.0144 ns |     34.29 ns |  1.00 |    0.00 |
