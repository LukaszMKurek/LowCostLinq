``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |        Mean |      Error |     StdDev |      Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |------------:|-----------:|-----------:|------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **20.74 ns** |  **0.3891 ns** |  **0.3450 ns** |    **20.57 ns** |  **1.85** |    **0.03** |
|                                   LowCostLinqWithDelegate |            [0] |    33.88 ns |  0.0246 ns |  0.0205 ns |    33.88 ns |  3.02 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    25.55 ns |  0.0110 ns |  0.0097 ns |    25.55 ns |  2.28 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |    37.64 ns |  0.0476 ns |  0.0422 ns |    37.64 ns |  3.36 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    34.90 ns |  0.0069 ns |  0.0062 ns |    34.90 ns |  3.11 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |    35.67 ns |  0.0132 ns |  0.0123 ns |    35.67 ns |  3.18 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    32.24 ns |  0.0052 ns |  0.0048 ns |    32.23 ns |  2.88 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    31.65 ns |  0.0134 ns |  0.0118 ns |    31.65 ns |  2.82 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    32.79 ns |  0.6681 ns |  0.7694 ns |    32.31 ns |  2.96 |    0.08 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    35.09 ns |  0.0227 ns |  0.0213 ns |    35.09 ns |  3.13 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    34.91 ns |  0.0236 ns |  0.0221 ns |    34.91 ns |  3.12 |    0.00 |
|                                                 LinqCount |            [0] |    25.56 ns |  0.1299 ns |  0.1152 ns |    25.59 ns |  2.28 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |    26.76 ns |  0.0181 ns |  0.0160 ns |    26.76 ns |  2.39 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    28.25 ns |  0.0082 ns |  0.0077 ns |    28.25 ns |  2.52 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |    22.55 ns |  0.3650 ns |  0.3414 ns |    22.36 ns |  2.00 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    24.15 ns |  0.0138 ns |  0.0129 ns |    24.15 ns |  2.16 |    0.00 |
|                                               LinqToArray |            [0] |    21.58 ns |  0.0467 ns |  0.0437 ns |    21.59 ns |  1.93 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |    39.64 ns |  0.8229 ns |  0.9146 ns |    39.01 ns |  3.55 |    0.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    39.12 ns |  0.0195 ns |  0.0182 ns |    39.12 ns |  3.49 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |    32.06 ns |  0.1199 ns |  0.1062 ns |    32.05 ns |  2.86 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    32.67 ns |  0.0337 ns |  0.0281 ns |    32.67 ns |  2.92 |    0.00 |
|                                                      Take |            [0] |    24.02 ns |  0.0746 ns |  0.0661 ns |    24.01 ns |  2.14 |    0.01 |
|                                               LowCostTake |            [0] |    38.40 ns |  0.0078 ns |  0.0069 ns |    38.40 ns |  3.43 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |    34.80 ns |  0.0119 ns |  0.0111 ns |    34.80 ns |  3.11 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |    41.19 ns |  0.3553 ns |  0.3323 ns |    40.96 ns |  3.67 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    39.40 ns |  0.0249 ns |  0.0233 ns |    39.40 ns |  3.52 |    0.00 |
|                                            SkipTakeSingle |            [0] |    37.64 ns |  0.0680 ns |  0.0636 ns |    37.62 ns |  3.36 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |    45.58 ns |  0.0097 ns |  0.0091 ns |    45.58 ns |  4.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    45.94 ns |  0.6084 ns |  0.5691 ns |    45.62 ns |  4.11 |    0.05 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    43.04 ns |  0.0081 ns |  0.0076 ns |    43.04 ns |  3.84 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    43.51 ns |  0.0058 ns |  0.0048 ns |    43.51 ns |  3.88 |    0.00 |
|                                           ForeachDelegate |            [0] |    13.46 ns |  0.0106 ns |  0.0094 ns |    13.46 ns |  1.20 |    0.00 |
|                                                   Foreach |            [0] |    11.20 ns |  0.0075 ns |  0.0059 ns |    11.20 ns |  1.00 |    0.00 |
|                                                           |                |             |            |            |             |       |         |
|                                                      **Linq** |         **[1000]** | **5,768.97 ns** |  **1.8374 ns** |  **1.5343 ns** | **5,768.95 ns** |  **1.34** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,137.38 ns |  2.2807 ns |  1.7806 ns | 3,137.59 ns |  0.73 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,133.17 ns |  0.6233 ns |  0.5831 ns | 3,133.17 ns |  0.73 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 3,381.25 ns |  2.2749 ns |  2.1279 ns | 3,380.97 ns |  0.78 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,417.88 ns | 48.2946 ns | 45.1748 ns | 3,386.61 ns |  0.79 |    0.01 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,263.79 ns |  0.7520 ns |  0.6667 ns | 1,263.89 ns |  0.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,246.23 ns |  0.4842 ns |  0.4293 ns | 1,246.06 ns |  0.29 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,145.37 ns | 46.4575 ns | 43.4563 ns | 6,149.76 ns |  1.43 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 5,803.30 ns |  1.0612 ns |  0.8862 ns | 5,803.43 ns |  1.35 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,862.08 ns |  1.2156 ns |  1.0776 ns | 3,862.10 ns |  0.90 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 4,119.89 ns |  0.9608 ns |  0.8987 ns | 4,119.79 ns |  0.96 |    0.00 |
|                                                 LinqCount |         [1000] | 1,475.40 ns |  5.6031 ns |  5.2411 ns | 1,475.61 ns |  0.34 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 1,715.75 ns | 20.6033 ns | 19.2723 ns | 1,701.04 ns |  0.40 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 1,466.17 ns |  0.2986 ns |  0.2794 ns | 1,466.14 ns |  0.34 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   563.56 ns |  0.1333 ns |  0.1181 ns |   563.53 ns |  0.13 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   565.90 ns |  0.7070 ns |  0.6613 ns |   566.07 ns |  0.13 |    0.00 |
|                                               LinqToArray |         [1000] | 2,913.57 ns |  3.3746 ns |  2.9915 ns | 2,912.57 ns |  0.68 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 2,929.33 ns |  7.1979 ns |  6.3807 ns | 2,930.89 ns |  0.68 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 3,149.58 ns |  2.9082 ns |  2.7204 ns | 3,148.58 ns |  0.73 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,839.15 ns |  2.4063 ns |  1.8786 ns | 1,838.54 ns |  0.43 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,889.21 ns |  1.2673 ns |  1.0583 ns | 1,889.08 ns |  0.44 |    0.00 |
|                                                      Take |         [1000] |   293.29 ns |  0.1188 ns |  0.1053 ns |   293.25 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |   120.11 ns |  1.8011 ns |  1.6848 ns |   118.77 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |   109.41 ns |  0.0377 ns |  0.0315 ns |   109.41 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    82.34 ns |  0.0257 ns |  0.0228 ns |    82.33 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    71.36 ns |  0.0485 ns |  0.0430 ns |    71.36 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   184.61 ns |  0.0736 ns |  0.0653 ns |   184.59 ns |  0.04 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   101.84 ns |  0.0759 ns |  0.0592 ns |   101.86 ns |  0.02 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   102.37 ns |  0.0449 ns |  0.0420 ns |   102.37 ns |  0.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    66.42 ns |  0.0719 ns |  0.0638 ns |    66.43 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    66.18 ns |  0.1461 ns |  0.1366 ns |    66.15 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] | 5,534.80 ns |  7.1599 ns |  6.6974 ns | 5,536.53 ns |  1.28 |    0.00 |
|                                                   Foreach |         [1000] | 4,311.05 ns |  0.7301 ns |  0.6097 ns | 4,310.89 ns |  1.00 |    0.00 |
|                                                           |                |             |            |            |             |       |         |
|                                                      **Linq** |           **[50]** |   **331.86 ns** |  **6.2975 ns** |  **6.1850 ns** |   **328.23 ns** |  **1.40** |    **0.03** |
|                                   LowCostLinqWithDelegate |           [50] |   186.67 ns |  0.0393 ns |  0.0328 ns |   186.67 ns |  0.79 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   184.53 ns |  0.0680 ns |  0.0636 ns |   184.52 ns |  0.78 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |   207.79 ns |  3.9741 ns |  3.9031 ns |   204.97 ns |  0.88 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   202.82 ns |  0.0774 ns |  0.0724 ns |   202.83 ns |  0.85 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |   107.97 ns |  0.0540 ns |  0.0505 ns |   107.96 ns |  0.45 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   102.40 ns |  1.1037 ns |  1.0324 ns |   101.69 ns |  0.43 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   342.74 ns |  0.0396 ns |  0.0331 ns |   342.73 ns |  1.44 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   331.52 ns |  0.1015 ns |  0.0900 ns |   331.51 ns |  1.39 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   237.73 ns |  4.4733 ns |  4.5937 ns |   234.77 ns |  1.00 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   249.53 ns |  0.1444 ns |  0.1206 ns |   249.49 ns |  1.05 |    0.00 |
|                                                 LinqCount |           [50] |   108.77 ns |  0.0546 ns |  0.0511 ns |   108.79 ns |  0.46 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |   114.34 ns |  0.0298 ns |  0.0264 ns |   114.33 ns |  0.48 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   107.96 ns |  0.0294 ns |  0.0275 ns |   107.95 ns |  0.45 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    49.48 ns |  0.0264 ns |  0.0234 ns |    49.48 ns |  0.21 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    50.16 ns |  0.0769 ns |  0.0681 ns |    50.17 ns |  0.21 |    0.00 |
|                                               LinqToArray |           [50] |   357.50 ns |  0.1277 ns |  0.1194 ns |   357.49 ns |  1.50 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |   272.68 ns |  0.0638 ns |  0.0566 ns |   272.69 ns |  1.15 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   282.89 ns |  0.0828 ns |  0.0692 ns |   282.89 ns |  1.19 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |   212.49 ns |  4.1669 ns |  3.8977 ns |   209.67 ns |  0.89 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   208.31 ns |  0.2063 ns |  0.1828 ns |   208.29 ns |  0.88 |    0.00 |
|                                                      Take |           [50] |   293.30 ns |  0.0752 ns |  0.0703 ns |   293.29 ns |  1.23 |    0.00 |
|                                               LowCostTake |           [50] |   117.67 ns |  0.0515 ns |  0.0402 ns |   117.66 ns |  0.49 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |   112.59 ns |  0.0297 ns |  0.0263 ns |   112.59 ns |  0.47 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    82.74 ns |  0.2017 ns |  0.1887 ns |    82.68 ns |  0.35 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    72.75 ns |  0.0477 ns |  0.0447 ns |    72.73 ns |  0.31 |    0.00 |
|                                            SkipTakeSingle |           [50] |   186.44 ns |  3.6835 ns |  3.7827 ns |   183.75 ns |  0.79 |    0.02 |
|                                     LowCostSkipTakeSingle |           [50] |   102.86 ns |  0.0814 ns |  0.0722 ns |   102.86 ns |  0.43 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   103.05 ns |  0.1940 ns |  0.1815 ns |   103.09 ns |  0.43 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    67.52 ns |  1.3689 ns |  1.2804 ns |    66.64 ns |  0.28 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    66.05 ns |  0.1382 ns |  0.1293 ns |    66.04 ns |  0.28 |    0.00 |
|                                           ForeachDelegate |           [50] |   303.04 ns |  0.0439 ns |  0.0410 ns |   303.05 ns |  1.27 |    0.00 |
|                                                   Foreach |           [50] |   237.76 ns |  0.1536 ns |  0.1361 ns |   237.71 ns |  1.00 |    0.00 |
|                                                           |                |             |            |            |             |       |         |
|                                                      **Linq** |            **[5]** |    **60.17 ns** |  **0.0804 ns** |  **0.0752 ns** |    **60.18 ns** |  **1.76** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    46.65 ns |  0.6835 ns |  0.6393 ns |    46.59 ns |  1.36 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    42.00 ns |  0.1419 ns |  0.1327 ns |    42.05 ns |  1.23 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    52.65 ns |  0.0221 ns |  0.0196 ns |    52.64 ns |  1.54 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    51.38 ns |  0.6297 ns |  0.5890 ns |    50.94 ns |  1.50 |    0.02 |
|                                LowCostLinqWithStructWhere |            [5] |    42.66 ns |  0.1337 ns |  0.1186 ns |    42.68 ns |  1.25 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    38.42 ns |  0.0406 ns |  0.0380 ns |    38.44 ns |  1.12 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    61.39 ns |  0.0669 ns |  0.0593 ns |    61.39 ns |  1.80 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    62.91 ns |  0.0390 ns |  0.0305 ns |    62.92 ns |  1.84 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    54.29 ns |  0.0995 ns |  0.0882 ns |    54.29 ns |  1.59 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    55.06 ns |  0.0174 ns |  0.0163 ns |    55.06 ns |  1.61 |    0.00 |
|                                                 LinqCount |            [5] |    38.95 ns |  0.0440 ns |  0.0390 ns |    38.94 ns |  1.14 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    34.44 ns |  0.0151 ns |  0.0141 ns |    34.44 ns |  1.01 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    35.16 ns |  0.0196 ns |  0.0183 ns |    35.16 ns |  1.03 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |    27.65 ns |  0.3411 ns |  0.3190 ns |    27.48 ns |  0.81 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    24.97 ns |  0.0119 ns |  0.0111 ns |    24.97 ns |  0.73 |    0.00 |
|                                               LinqToArray |            [5] |    99.31 ns |  0.0464 ns |  0.0388 ns |    99.30 ns |  2.90 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    95.42 ns |  1.9163 ns |  1.9679 ns |    94.05 ns |  2.80 |    0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    95.72 ns |  0.0225 ns |  0.0199 ns |    95.72 ns |  2.80 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    84.49 ns |  0.0270 ns |  0.0253 ns |    84.49 ns |  2.47 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    84.23 ns |  0.3758 ns |  0.3138 ns |    84.11 ns |  2.46 |    0.01 |
|                                                      Take |            [5] |   124.05 ns |  0.0513 ns |  0.0480 ns |   124.05 ns |  3.63 |    0.00 |
|                                               LowCostTake |            [5] |    57.81 ns |  0.0203 ns |  0.0169 ns |    57.81 ns |  1.69 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    53.28 ns |  0.0351 ns |  0.0274 ns |    53.29 ns |  1.56 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |    54.42 ns |  0.0221 ns |  0.0196 ns |    54.42 ns |  1.59 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    47.93 ns |  0.0324 ns |  0.0253 ns |    47.94 ns |  1.40 |    0.00 |
|                                            SkipTakeSingle |            [5] |   112.76 ns |  0.0192 ns |  0.0150 ns |   112.76 ns |  3.30 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    56.40 ns |  0.0523 ns |  0.0489 ns |    56.39 ns |  1.65 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    56.84 ns |  0.0760 ns |  0.0711 ns |    56.85 ns |  1.66 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    47.73 ns |  0.9315 ns |  0.9148 ns |    47.07 ns |  1.40 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    47.01 ns |  0.0050 ns |  0.0039 ns |    47.01 ns |  1.37 |    0.00 |
|                                           ForeachDelegate |            [5] |    44.02 ns |  0.1081 ns |  0.0958 ns |    44.00 ns |  1.29 |    0.00 |
|                                                   Foreach |            [5] |    34.19 ns |  0.0236 ns |  0.0221 ns |    34.20 ns |  1.00 |    0.00 |
