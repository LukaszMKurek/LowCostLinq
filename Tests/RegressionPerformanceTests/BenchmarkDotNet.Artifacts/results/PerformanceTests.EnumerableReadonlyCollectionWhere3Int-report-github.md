``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **89.45 ns** |   **0.027 ns** |   **0.023 ns** |  **6.05** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |     32.57 ns |   0.002 ns |   0.002 ns |  2.20 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     29.87 ns |   0.013 ns |   0.012 ns |  2.02 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     62.67 ns |   0.210 ns |   0.196 ns |  4.24 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     60.41 ns |   0.012 ns |   0.011 ns |  4.08 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     52.56 ns |   0.017 ns |   0.015 ns |  3.55 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     49.13 ns |   0.006 ns |   0.005 ns |  3.32 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     46.47 ns |   0.026 ns |   0.022 ns |  3.14 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     49.97 ns |   0.051 ns |   0.048 ns |  3.38 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     43.98 ns |   0.022 ns |   0.018 ns |  2.97 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     43.86 ns |   0.005 ns |   0.004 ns |  2.97 |    0.00 |
|                                                 LinqCount |            [0] |     80.37 ns |   0.014 ns |   0.012 ns |  5.43 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     28.91 ns |   0.015 ns |   0.013 ns |  1.95 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.35 ns |   0.162 ns |   0.151 ns |  2.25 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     38.88 ns |   0.014 ns |   0.012 ns |  2.63 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     39.65 ns |   0.072 ns |   0.067 ns |  2.68 |    0.00 |
|                                               LinqToArray |            [0] |     90.05 ns |   0.026 ns |   0.023 ns |  6.09 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     33.21 ns |   0.113 ns |   0.100 ns |  2.25 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     35.41 ns |   0.011 ns |   0.009 ns |  2.39 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     41.97 ns |   0.007 ns |   0.006 ns |  2.84 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     41.73 ns |   0.005 ns |   0.004 ns |  2.82 |    0.00 |
|                                                      Take |            [0] |    113.79 ns |   0.019 ns |   0.017 ns |  7.69 |    0.01 |
|                                               LowCostTake |            [0] |     46.82 ns |   0.025 ns |   0.022 ns |  3.16 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     41.35 ns |   0.010 ns |   0.008 ns |  2.80 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     58.67 ns |   0.017 ns |   0.015 ns |  3.97 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     55.86 ns |   0.011 ns |   0.009 ns |  3.78 |    0.00 |
|                                            SkipTakeSingle |            [0] |    130.18 ns |   0.025 ns |   0.021 ns |  8.80 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     42.13 ns |   0.018 ns |   0.016 ns |  2.85 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     43.80 ns |   0.030 ns |   0.025 ns |  2.96 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     59.91 ns |   0.587 ns |   0.549 ns |  4.05 |    0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     57.93 ns |   0.014 ns |   0.012 ns |  3.92 |    0.00 |
|                                           ForeachDelegate |            [0] |     16.27 ns |   0.020 ns |   0.019 ns |  1.10 |    0.00 |
|                                                   Foreach |            [0] |     14.79 ns |   0.018 ns |   0.017 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |         **[1000]** | **19,830.29 ns** | **389.717 ns** | **731.982 ns** |  **3.21** |    **0.12** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,549.40 ns |   3.861 ns |   3.422 ns |  1.86 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 11,535.27 ns |   4.395 ns |   4.112 ns |  1.85 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,811.09 ns |   2.430 ns |   2.154 ns |  1.90 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 12,268.10 ns |   5.365 ns |   4.756 ns |  1.97 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,252.13 ns |   1.933 ns |   1.614 ns |  1.16 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  7,344.64 ns |  21.260 ns |  19.887 ns |  1.18 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 14,392.90 ns |   5.669 ns |   5.025 ns |  2.31 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 14,376.73 ns |   2.845 ns |   2.522 ns |  2.31 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,858.29 ns |   4.925 ns |   4.366 ns |  1.58 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,858.22 ns |   4.530 ns |   4.016 ns |  1.58 |    0.00 |
|                                                 LinqCount |         [1000] | 16,507.24 ns | 325.325 ns | 779.458 ns |  2.66 |    0.11 |
|                              LowCostLinqWithDelegateCount |         [1000] | 11,018.72 ns |   3.957 ns |   3.508 ns |  1.77 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 11,032.53 ns |   3.845 ns |   3.597 ns |  1.77 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,502.91 ns |   2.142 ns |   1.899 ns |  1.04 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,483.34 ns |   2.319 ns |   2.056 ns |  1.04 |    0.00 |
|                                               LinqToArray |         [1000] | 15,989.30 ns | 178.735 ns | 167.189 ns |  2.57 |    0.03 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,928.20 ns |   6.551 ns |   5.808 ns |  1.92 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,938.06 ns |   9.931 ns |   8.804 ns |  1.92 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,752.07 ns |   6.396 ns |   5.670 ns |  1.25 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,273.56 ns |   6.530 ns |   6.108 ns |  1.17 |    0.00 |
|                                                      Take |         [1000] |    556.66 ns |   5.586 ns |   5.226 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |    285.38 ns |   0.100 ns |   0.088 ns |  0.05 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    287.17 ns |   0.171 ns |   0.152 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    202.29 ns |   0.148 ns |   0.132 ns |  0.03 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    198.45 ns |   0.035 ns |   0.031 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    469.49 ns |   2.481 ns |   2.320 ns |  0.08 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    289.20 ns |   0.144 ns |   0.128 ns |  0.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    289.44 ns |   0.125 ns |   0.104 ns |  0.05 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    202.79 ns |   0.118 ns |   0.104 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    203.99 ns |   0.179 ns |   0.159 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,752.27 ns |   0.558 ns |   0.495 ns |  1.73 |    0.00 |
|                                                   Foreach |         [1000] |  6,225.35 ns |   0.185 ns |   0.164 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |           **[50]** |  **1,009.91 ns** |  **20.185 ns** |  **24.789 ns** |  **3.05** |    **0.07** |
|                                   LowCostLinqWithDelegate |           [50] |    611.34 ns |   0.470 ns |   0.417 ns |  1.85 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    618.61 ns |   0.240 ns |   0.200 ns |  1.87 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    663.91 ns |   0.106 ns |   0.088 ns |  2.01 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    662.05 ns |   0.219 ns |   0.194 ns |  2.00 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    427.62 ns |   0.152 ns |   0.127 ns |  1.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    409.92 ns |   0.121 ns |   0.107 ns |  1.24 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    759.67 ns |   0.493 ns |   0.385 ns |  2.30 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    759.33 ns |   0.097 ns |   0.086 ns |  2.30 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    522.32 ns |   0.107 ns |   0.095 ns |  1.58 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    522.91 ns |   0.116 ns |   0.097 ns |  1.58 |    0.00 |
|                                                 LinqCount |           [50] |    827.53 ns |  12.623 ns |  11.190 ns |  2.50 |    0.03 |
|                              LowCostLinqWithDelegateCount |           [50] |    559.30 ns |   0.066 ns |   0.055 ns |  1.69 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    562.81 ns |   0.177 ns |   0.157 ns |  1.70 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    363.15 ns |   0.137 ns |   0.122 ns |  1.10 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    362.19 ns |   0.074 ns |   0.065 ns |  1.10 |    0.00 |
|                                               LinqToArray |           [50] |    950.68 ns |   7.508 ns |   7.023 ns |  2.88 |    0.02 |
|                            LowCostLinqWithDelegateToArray |           [50] |    728.47 ns |   0.462 ns |   0.386 ns |  2.21 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    732.18 ns |   0.633 ns |   0.592 ns |  2.22 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    466.34 ns |   0.844 ns |   0.789 ns |  1.41 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    468.01 ns |   2.617 ns |   2.448 ns |  1.42 |    0.01 |
|                                                      Take |           [50] |    552.45 ns |   4.725 ns |   4.420 ns |  1.67 |    0.01 |
|                                               LowCostTake |           [50] |    288.72 ns |   0.067 ns |   0.060 ns |  0.87 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    286.34 ns |   0.079 ns |   0.070 ns |  0.87 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    202.62 ns |   0.111 ns |   0.098 ns |  0.61 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    198.76 ns |   0.054 ns |   0.048 ns |  0.60 |    0.00 |
|                                            SkipTakeSingle |           [50] |    477.60 ns |   2.834 ns |   2.512 ns |  1.45 |    0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    291.42 ns |   0.116 ns |   0.103 ns |  0.88 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    289.31 ns |   0.134 ns |   0.119 ns |  0.88 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    203.09 ns |   0.127 ns |   0.113 ns |  0.61 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    203.22 ns |   0.118 ns |   0.104 ns |  0.62 |    0.00 |
|                                           ForeachDelegate |           [50] |    551.36 ns |   0.105 ns |   0.082 ns |  1.67 |    0.00 |
|                                                   Foreach |           [50] |    330.23 ns |   0.057 ns |   0.048 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |            **[5]** |    **178.75 ns** |   **0.422 ns** |   **0.374 ns** |  **3.88** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     98.91 ns |   0.036 ns |   0.032 ns |  2.15 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     96.46 ns |   0.038 ns |   0.034 ns |  2.09 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    129.93 ns |   0.039 ns |   0.032 ns |  2.82 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    115.45 ns |   0.060 ns |   0.056 ns |  2.50 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     80.80 ns |   0.083 ns |   0.078 ns |  1.75 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     76.84 ns |   0.052 ns |   0.046 ns |  1.67 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    133.03 ns |   0.079 ns |   0.070 ns |  2.89 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    132.41 ns |   0.738 ns |   0.691 ns |  2.87 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     89.83 ns |   0.013 ns |   0.012 ns |  1.95 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     91.64 ns |   0.140 ns |   0.131 ns |  1.99 |    0.00 |
|                                                 LinqCount |            [5] |    159.20 ns |   0.370 ns |   0.346 ns |  3.45 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     90.29 ns |   0.155 ns |   0.145 ns |  1.96 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     94.39 ns |   0.027 ns |   0.022 ns |  2.05 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     66.68 ns |   0.087 ns |   0.081 ns |  1.45 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     67.00 ns |   0.233 ns |   0.218 ns |  1.45 |    0.01 |
|                                               LinqToArray |            [5] |    199.30 ns |   0.399 ns |   0.374 ns |  4.32 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    119.09 ns |   0.065 ns |   0.051 ns |  2.58 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    120.04 ns |   0.177 ns |   0.157 ns |  2.60 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    100.15 ns |   0.025 ns |   0.021 ns |  2.17 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    101.57 ns |   0.026 ns |   0.023 ns |  2.20 |    0.00 |
|                                                      Take |            [5] |    233.11 ns |   0.507 ns |   0.474 ns |  5.06 |    0.01 |
|                                               LowCostTake |            [5] |    106.78 ns |   0.113 ns |   0.106 ns |  2.32 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    103.32 ns |   0.103 ns |   0.096 ns |  2.24 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     86.78 ns |   0.016 ns |   0.012 ns |  1.88 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     82.54 ns |   0.043 ns |   0.038 ns |  1.79 |    0.00 |
|                                            SkipTakeSingle |            [5] |    225.50 ns |   0.221 ns |   0.196 ns |  4.89 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     94.60 ns |   0.071 ns |   0.067 ns |  2.05 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     93.28 ns |   0.064 ns |   0.060 ns |  2.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     87.99 ns |   0.027 ns |   0.022 ns |  1.91 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     86.52 ns |   0.049 ns |   0.044 ns |  1.88 |    0.00 |
|                                           ForeachDelegate |            [5] |     69.92 ns |   0.071 ns |   0.056 ns |  1.52 |    0.00 |
|                                                   Foreach |            [5] |     46.09 ns |   0.061 ns |   0.057 ns |  1.00 |    0.00 |
