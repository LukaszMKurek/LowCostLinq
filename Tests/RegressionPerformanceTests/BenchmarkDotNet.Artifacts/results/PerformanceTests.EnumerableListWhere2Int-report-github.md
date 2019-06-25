``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **66.35 ns** |   **0.0305 ns** |   **0.0271 ns** |     **66.34 ns** |  **3.86** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     37.96 ns |   0.0071 ns |   0.0063 ns |     37.96 ns |  2.21 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     25.99 ns |   0.0071 ns |   0.0067 ns |     25.98 ns |  1.51 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     47.65 ns |   0.0146 ns |   0.0136 ns |     47.65 ns |  2.77 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     43.80 ns |   0.0185 ns |   0.0173 ns |     43.80 ns |  2.55 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     43.76 ns |   0.0138 ns |   0.0130 ns |     43.76 ns |  2.54 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     35.74 ns |   0.0059 ns |   0.0055 ns |     35.74 ns |  2.08 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    106.93 ns |   0.0322 ns |   0.0301 ns |    106.92 ns |  6.22 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     87.64 ns |   0.0383 ns |   0.0320 ns |     87.65 ns |  5.09 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     90.90 ns |   0.0333 ns |   0.0311 ns |     90.92 ns |  5.28 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     75.09 ns |   0.0266 ns |   0.0249 ns |     75.10 ns |  4.36 |    0.00 |
|                                                 LinqCount |            [0] |     65.10 ns |   0.0423 ns |   0.0375 ns |     65.09 ns |  3.78 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     35.69 ns |   0.5185 ns |   0.4850 ns |     35.83 ns |  2.07 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.60 ns |   0.0101 ns |   0.0084 ns |     33.60 ns |  1.95 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.82 ns |   0.0092 ns |   0.0086 ns |     37.82 ns |  2.20 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     30.20 ns |   0.0083 ns |   0.0078 ns |     30.19 ns |  1.76 |    0.00 |
|                                               LinqToArray |            [0] |     77.90 ns |   0.1555 ns |   0.1455 ns |     77.98 ns |  4.53 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     48.14 ns |   0.0469 ns |   0.0416 ns |     48.12 ns |  2.80 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     46.10 ns |   0.0260 ns |   0.0243 ns |     46.10 ns |  2.68 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     47.61 ns |   0.0555 ns |   0.0519 ns |     47.59 ns |  2.77 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     40.44 ns |   0.0117 ns |   0.0104 ns |     40.43 ns |  2.35 |    0.00 |
|                                                      Take |            [0] |    102.48 ns |   0.0249 ns |   0.0233 ns |    102.48 ns |  5.96 |    0.00 |
|                                               LowCostTake |            [0] |     41.89 ns |   0.0072 ns |   0.0068 ns |     41.89 ns |  2.43 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     35.74 ns |   0.0114 ns |   0.0107 ns |     35.74 ns |  2.08 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     48.64 ns |   0.0469 ns |   0.0439 ns |     48.64 ns |  2.83 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     41.16 ns |   0.0063 ns |   0.0059 ns |     41.16 ns |  2.39 |    0.00 |
|                                            SkipTakeSingle |            [0] |    129.03 ns |   0.0643 ns |   0.0602 ns |    129.04 ns |  7.50 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     51.39 ns |   0.0149 ns |   0.0132 ns |     51.39 ns |  2.99 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     50.25 ns |   0.0115 ns |   0.0107 ns |     50.25 ns |  2.92 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     59.52 ns |   0.0183 ns |   0.0162 ns |     59.52 ns |  3.46 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     52.09 ns |   0.0118 ns |   0.0110 ns |     52.09 ns |  3.03 |    0.00 |
|                                           ForeachDelegate |            [0] |     20.58 ns |   0.0087 ns |   0.0081 ns |     20.58 ns |  1.20 |    0.00 |
|                                                   Foreach |            [0] |     17.20 ns |   0.0077 ns |   0.0068 ns |     17.21 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |         **[1000]** |  **9,188.53 ns** |   **6.0210 ns** |   **5.6321 ns** |  **9,187.21 ns** |  **1.66** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,143.46 ns | 142.2038 ns | 312.1407 ns |  7,088.70 ns |  1.26 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,869.05 ns |  51.3154 ns |  40.0637 ns |  5,869.46 ns |  1.06 |    0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  8,310.50 ns | 165.2567 ns | 452.3876 ns |  8,063.91 ns |  1.51 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,515.14 ns | 143.0921 ns | 289.0530 ns |  6,386.00 ns |  1.19 |    0.07 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,682.86 ns |   2.1904 ns |   2.0489 ns |  2,682.67 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,475.40 ns |   0.2384 ns |   0.2114 ns |  1,475.40 ns |  0.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 21,831.57 ns | 204.2872 ns | 191.0904 ns | 21,813.06 ns |  3.95 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,715.50 ns | 386.7053 ns | 516.2404 ns | 19,393.97 ns |  3.60 |    0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,458.35 ns |   4.4619 ns |   4.1736 ns |  9,460.77 ns |  1.71 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,728.82 ns |   3.9647 ns |   3.7085 ns |  8,728.80 ns |  1.58 |    0.00 |
|                                                 LinqCount |         [1000] |  3,922.26 ns |   4.2923 ns |   4.0150 ns |  3,923.51 ns |  0.71 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,649.59 ns | 131.6644 ns | 355.9624 ns |  6,579.34 ns |  1.20 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  4,642.49 ns |  18.0782 ns |  16.9103 ns |  4,646.25 ns |  0.84 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,716.99 ns |   0.3903 ns |   0.3651 ns |  1,717.12 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    630.92 ns |   0.0817 ns |   0.0724 ns |    630.91 ns |  0.11 |    0.00 |
|                                               LinqToArray |         [1000] |  5,345.87 ns |   3.2078 ns |   2.8437 ns |  5,347.45 ns |  0.97 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,698.21 ns |  15.0823 ns |  14.1080 ns |  7,694.58 ns |  1.39 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,900.02 ns |   9.1968 ns |   8.1527 ns |  6,899.53 ns |  1.25 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,437.18 ns |  11.6205 ns |  10.8698 ns |  3,436.80 ns |  0.62 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,654.71 ns |   2.0219 ns |   1.8913 ns |  2,654.30 ns |  0.48 |    0.00 |
|                                                      Take |         [1000] |    396.90 ns |   0.0915 ns |   0.0855 ns |    396.88 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    205.60 ns |   4.0193 ns |   6.6038 ns |    204.76 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    149.11 ns |   1.6923 ns |   1.4132 ns |    148.55 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    113.25 ns |   0.0172 ns |   0.0161 ns |    113.25 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     81.91 ns |   0.3437 ns |   0.3215 ns |     81.73 ns |  0.01 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    315.71 ns |   0.0715 ns |   0.0669 ns |    315.72 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    207.52 ns |   0.2448 ns |   0.2170 ns |    207.50 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    185.19 ns |   3.7167 ns |   7.9206 ns |    183.45 ns |  0.03 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    107.00 ns |   0.0570 ns |   0.0533 ns |    107.02 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     78.05 ns |   0.0328 ns |   0.0291 ns |     78.06 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] |  8,783.07 ns |   3.4267 ns |   3.2053 ns |  8,784.03 ns |  1.59 |    0.00 |
|                                                   Foreach |         [1000] |  5,525.68 ns |   1.8282 ns |   1.7101 ns |  5,525.37 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |           **[50]** |    **533.69 ns** |   **0.1038 ns** |   **0.0920 ns** |    **533.68 ns** |  **1.78** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    516.70 ns |  15.5207 ns |  44.2815 ns |    534.55 ns |  1.60 |    0.20 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    343.93 ns |   6.8573 ns |   9.8346 ns |    340.64 ns |  1.15 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |    455.36 ns |   8.4276 ns |   7.0374 ns |    453.13 ns |  1.52 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    368.27 ns |   7.4378 ns |  21.9305 ns |    355.30 ns |  1.24 |    0.08 |
|                                LowCostLinqWithStructWhere |           [50] |    176.71 ns |   0.0846 ns |   0.0792 ns |    176.71 ns |  0.59 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    117.32 ns |   0.0226 ns |   0.0211 ns |    117.33 ns |  0.39 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,156.54 ns |   1.9749 ns |   1.5419 ns |  1,156.63 ns |  3.86 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,066.45 ns |   2.7907 ns |   2.3303 ns |  1,066.93 ns |  3.55 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    570.06 ns |   0.3220 ns |   0.3012 ns |    569.96 ns |  1.90 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    519.45 ns |   0.1744 ns |   0.1632 ns |    519.42 ns |  1.73 |    0.00 |
|                                                 LinqCount |           [50] |    268.34 ns |   0.2358 ns |   0.2205 ns |    268.42 ns |  0.89 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    370.36 ns |   2.3359 ns |   2.1850 ns |    370.49 ns |  1.23 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    273.29 ns |   2.4882 ns |   1.9427 ns |    272.76 ns |  0.91 |    0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |    127.34 ns |   0.0258 ns |   0.0229 ns |    127.34 ns |  0.42 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     59.53 ns |   0.0506 ns |   0.0473 ns |     59.56 ns |  0.20 |    0.00 |
|                                               LinqToArray |           [50] |    523.89 ns |   0.1658 ns |   0.1551 ns |    523.96 ns |  1.75 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    530.33 ns |   0.3424 ns |   0.3203 ns |    530.34 ns |  1.77 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    487.46 ns |   0.7139 ns |   0.6677 ns |    487.42 ns |  1.62 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    295.82 ns |   0.1807 ns |   0.1602 ns |    295.86 ns |  0.99 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    234.62 ns |   0.0816 ns |   0.0763 ns |    234.61 ns |  0.78 |    0.00 |
|                                                      Take |           [50] |    395.83 ns |   0.1301 ns |   0.1153 ns |    395.83 ns |  1.32 |    0.00 |
|                                               LowCostTake |           [50] |    196.62 ns |   0.3403 ns |   0.2657 ns |    196.55 ns |  0.66 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    150.79 ns |   2.1136 ns |   1.6502 ns |    149.81 ns |  0.50 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    113.25 ns |   0.0170 ns |   0.0159 ns |    113.25 ns |  0.38 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     79.57 ns |   0.0313 ns |   0.0292 ns |     79.57 ns |  0.27 |    0.00 |
|                                            SkipTakeSingle |           [50] |    315.74 ns |   0.0638 ns |   0.0566 ns |    315.74 ns |  1.05 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    214.99 ns |   4.2859 ns |   4.4013 ns |    215.66 ns |  0.72 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    178.73 ns |   3.2612 ns |   2.8910 ns |    176.98 ns |  0.60 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    104.33 ns |   0.0706 ns |   0.0660 ns |    104.32 ns |  0.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     77.45 ns |   0.0372 ns |   0.0330 ns |     77.47 ns |  0.26 |    0.00 |
|                                           ForeachDelegate |           [50] |    462.63 ns |   0.3886 ns |   0.3635 ns |    462.68 ns |  1.54 |    0.00 |
|                                                   Foreach |           [50] |    300.02 ns |   0.0768 ns |   0.0718 ns |    300.01 ns |  1.00 |    0.00 |
|                                                           |                |              |             |             |              |       |         |
|                                                      **Linq** |            **[5]** |    **112.15 ns** |   **0.0476 ns** |   **0.0422 ns** |    **112.16 ns** |  **2.48** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     72.17 ns |   1.4667 ns |   2.4505 ns |     71.53 ns |  1.60 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     54.64 ns |   0.2933 ns |   0.2743 ns |     54.64 ns |  1.21 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |     82.87 ns |   1.6705 ns |   1.7875 ns |     82.65 ns |  1.83 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     70.38 ns |   1.8369 ns |   1.8864 ns |     69.34 ns |  1.56 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |     54.70 ns |   0.0500 ns |   0.0443 ns |     54.72 ns |  1.21 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     45.52 ns |   0.0078 ns |   0.0073 ns |     45.52 ns |  1.01 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    223.89 ns |   0.3467 ns |   0.3073 ns |    223.79 ns |  4.95 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    194.36 ns |   0.1365 ns |   0.1210 ns |    194.35 ns |  4.30 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    141.51 ns |   0.3046 ns |   0.2849 ns |    141.56 ns |  3.13 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    122.13 ns |   0.0568 ns |   0.0531 ns |    122.14 ns |  2.70 |    0.00 |
|                                                 LinqCount |            [5] |     85.71 ns |   0.0774 ns |   0.0686 ns |     85.68 ns |  1.89 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     67.42 ns |   1.3552 ns |   1.5607 ns |     68.14 ns |  1.48 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     56.56 ns |   0.1132 ns |   0.0883 ns |     56.55 ns |  1.25 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     45.74 ns |   0.0156 ns |   0.0146 ns |     45.73 ns |  1.01 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     32.82 ns |   0.0286 ns |   0.0267 ns |     32.81 ns |  0.73 |    0.00 |
|                                               LinqToArray |            [5] |    145.92 ns |   0.0543 ns |   0.0508 ns |    145.91 ns |  3.22 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    113.40 ns |   0.0432 ns |   0.0404 ns |    113.39 ns |  2.51 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    107.71 ns |   0.1141 ns |   0.0953 ns |    107.68 ns |  2.38 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     89.76 ns |   0.0239 ns |   0.0224 ns |     89.77 ns |  1.98 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     76.32 ns |   0.0432 ns |   0.0404 ns |     76.32 ns |  1.69 |    0.00 |
|                                                      Take |            [5] |    181.44 ns |   0.0981 ns |   0.0869 ns |    181.44 ns |  4.01 |    0.00 |
|                                               LowCostTake |            [5] |     78.88 ns |   1.5944 ns |   2.9947 ns |     77.49 ns |  1.72 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [5] |     65.13 ns |   1.3242 ns |   2.1756 ns |     63.58 ns |  1.47 |    0.05 |
|                                     LowCostTakeWithStruct |            [5] |     63.89 ns |   0.0287 ns |   0.0269 ns |     63.89 ns |  1.41 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     52.45 ns |   0.0158 ns |   0.0148 ns |     52.45 ns |  1.16 |    0.00 |
|                                            SkipTakeSingle |            [5] |    170.98 ns |   0.2288 ns |   0.2140 ns |    170.89 ns |  3.78 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     83.66 ns |   1.6548 ns |   1.8393 ns |     82.59 ns |  1.85 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     73.57 ns |   1.9976 ns |   1.9620 ns |     72.60 ns |  1.63 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     68.90 ns |   0.0165 ns |   0.0154 ns |     68.91 ns |  1.52 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.74 ns |   0.0251 ns |   0.0235 ns |     55.74 ns |  1.23 |    0.00 |
|                                           ForeachDelegate |            [5] |     63.70 ns |   0.0199 ns |   0.0187 ns |     63.69 ns |  1.41 |    0.00 |
|                                                   Foreach |            [5] |     45.25 ns |   0.0376 ns |   0.0352 ns |     45.24 ns |  1.00 |    0.00 |
