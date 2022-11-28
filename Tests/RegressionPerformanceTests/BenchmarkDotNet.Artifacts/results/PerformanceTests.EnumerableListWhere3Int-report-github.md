``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **74.81 ns** |   **0.012 ns** |   **0.011 ns** |  **5.38** |    **0.06** |
|                                   LowCostLinqWithDelegate |            [0] |     22.76 ns |   0.000 ns |   0.000 ns |  1.64 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     17.14 ns |   0.002 ns |   0.002 ns |  1.23 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     55.47 ns |   0.023 ns |   0.018 ns |  3.98 |    0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     46.46 ns |   0.006 ns |   0.006 ns |  3.34 |    0.04 |
|                                LowCostLinqWithStructWhere |            [0] |     43.04 ns |   0.006 ns |   0.006 ns |  3.09 |    0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     37.97 ns |   0.014 ns |   0.012 ns |  2.73 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     44.70 ns |   0.012 ns |   0.011 ns |  3.21 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     31.44 ns |   0.004 ns |   0.003 ns |  2.26 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     43.14 ns |   0.005 ns |   0.004 ns |  3.10 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     32.10 ns |   0.004 ns |   0.004 ns |  2.31 |    0.03 |
|                                                 LinqCount |            [0] |     66.51 ns |   0.016 ns |   0.013 ns |  4.78 |    0.06 |
|                              LowCostLinqWithDelegateCount |            [0] |     16.15 ns |   0.001 ns |   0.001 ns |  1.16 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     19.70 ns |   0.007 ns |   0.006 ns |  1.42 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     28.65 ns |   0.002 ns |   0.002 ns |  2.06 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     28.26 ns |   0.001 ns |   0.001 ns |  2.03 |    0.02 |
|                                               LinqToArray |            [0] |     74.40 ns |   0.348 ns |   0.325 ns |  5.35 |    0.07 |
|                            LowCostLinqWithDelegateToArray |            [0] |     24.63 ns |   0.150 ns |   0.140 ns |  1.77 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     16.35 ns |   0.008 ns |   0.006 ns |  1.17 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     36.62 ns |   0.005 ns |   0.005 ns |  2.63 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     30.29 ns |   0.022 ns |   0.021 ns |  2.18 |    0.02 |
|                                                      Take |            [0] |    107.60 ns |   0.047 ns |   0.044 ns |  7.73 |    0.09 |
|                                               LowCostTake |            [0] |     37.28 ns |   0.015 ns |   0.014 ns |  2.68 |    0.03 |
|                                  LowCostTakeWithoutChecks |            [0] |     32.05 ns |   0.003 ns |   0.002 ns |  2.30 |    0.03 |
|                                     LowCostTakeWithStruct |            [0] |     49.98 ns |   0.001 ns |   0.001 ns |  3.59 |    0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     45.89 ns |   0.024 ns |   0.023 ns |  3.30 |    0.04 |
|                                            SkipTakeSingle |            [0] |    116.16 ns |   0.014 ns |   0.011 ns |  8.34 |    0.10 |
|                                     LowCostSkipTakeSingle |            [0] |     32.29 ns |   0.004 ns |   0.003 ns |  2.32 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     31.58 ns |   0.002 ns |   0.002 ns |  2.27 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     46.79 ns |   0.001 ns |   0.001 ns |  3.36 |    0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     45.87 ns |   0.002 ns |   0.001 ns |  3.30 |    0.04 |
|                                           ForeachDelegate |            [0] |     15.54 ns |   0.077 ns |   0.072 ns |  1.12 |    0.01 |
|                                                   Foreach |            [0] |     13.92 ns |   0.175 ns |   0.164 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |         **[1000]** | **12,601.37 ns** | **251.713 ns** | **722.212 ns** |  **2.07** |    **0.08** |
|                                   LowCostLinqWithDelegate |         [1000] |  5,566.60 ns |   0.697 ns |   0.582 ns |  0.89 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,558.99 ns |   2.986 ns |   2.793 ns |  0.89 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,066.29 ns |   3.486 ns |   3.261 ns |  0.98 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,060.07 ns |   1.840 ns |   1.721 ns |  0.97 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,824.90 ns |   1.193 ns |   1.116 ns |  0.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,502.26 ns |   0.611 ns |   0.571 ns |  0.24 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  8,422.41 ns |   4.246 ns |   3.764 ns |  1.35 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  7,691.99 ns |   2.801 ns |   2.483 ns |  1.24 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,644.71 ns |   7.304 ns |   6.833 ns |  0.59 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,379.48 ns |   1.259 ns |   1.116 ns |  0.54 |    0.00 |
|                                                 LinqCount |         [1000] |  8,928.33 ns | 209.975 ns | 615.821 ns |  1.46 |    0.09 |
|                              LowCostLinqWithDelegateCount |         [1000] |  5,037.49 ns |   1.567 ns |   1.389 ns |  0.81 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,269.75 ns |   0.979 ns |   0.868 ns |  0.85 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    518.80 ns |   0.550 ns |   0.515 ns |  0.08 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    512.76 ns |   0.094 ns |   0.083 ns |  0.08 |    0.00 |
|                                               LinqToArray |         [1000] |  8,838.73 ns | 162.489 ns | 166.864 ns |  1.42 |    0.03 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  6,663.31 ns |   3.900 ns |   3.457 ns |  1.07 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,603.83 ns |   6.473 ns |   6.054 ns |  1.06 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,640.84 ns |   0.691 ns |   0.539 ns |  0.26 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,612.32 ns |   1.024 ns |   0.800 ns |  0.26 |    0.00 |
|                                                      Take |         [1000] |    417.98 ns |   3.305 ns |   3.092 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    153.19 ns |   0.048 ns |   0.040 ns |  0.02 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    148.23 ns |   0.023 ns |   0.019 ns |  0.02 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     90.42 ns |   0.007 ns |   0.006 ns |  0.01 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     87.31 ns |   0.009 ns |   0.008 ns |  0.01 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    326.95 ns |   2.439 ns |   2.281 ns |  0.05 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    154.71 ns |   0.223 ns |   0.198 ns |  0.02 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    152.54 ns |   0.189 ns |   0.176 ns |  0.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     71.83 ns |   0.086 ns |   0.080 ns |  0.01 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     69.43 ns |   0.036 ns |   0.030 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,753.03 ns |   1.055 ns |   0.935 ns |  1.73 |    0.00 |
|                                                   Foreach |         [1000] |  6,221.34 ns |   0.726 ns |   0.644 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |           **[50]** |    **682.47 ns** |  **13.176 ns** |  **15.173 ns** |  **2.07** |    **0.05** |
|                                   LowCostLinqWithDelegate |           [50] |    314.64 ns |   0.029 ns |   0.027 ns |  0.96 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    298.60 ns |   0.212 ns |   0.199 ns |  0.91 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    354.81 ns |   0.116 ns |   0.102 ns |  1.08 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    341.78 ns |   0.035 ns |   0.033 ns |  1.04 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    137.68 ns |   0.018 ns |   0.016 ns |  0.42 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    119.51 ns |   0.014 ns |   0.012 ns |  0.36 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    461.43 ns |   0.516 ns |   0.483 ns |  1.40 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    432.44 ns |   0.299 ns |   0.279 ns |  1.31 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    235.08 ns |   0.219 ns |   0.205 ns |  0.71 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    216.09 ns |   0.038 ns |   0.031 ns |  0.66 |    0.00 |
|                                                 LinqCount |           [50] |    443.54 ns |   7.472 ns |   6.989 ns |  1.35 |    0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |    274.88 ns |   0.095 ns |   0.088 ns |  0.84 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    279.99 ns |   0.105 ns |   0.093 ns |  0.85 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     54.78 ns |   0.071 ns |   0.060 ns |  0.17 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     51.66 ns |   0.038 ns |   0.036 ns |  0.16 |    0.00 |
|                                               LinqToArray |           [50] |    582.05 ns |   4.299 ns |   3.590 ns |  1.77 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    434.76 ns |   0.428 ns |   0.380 ns |  1.32 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    412.17 ns |   0.169 ns |   0.150 ns |  1.25 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    154.54 ns |   0.679 ns |   0.635 ns |  0.47 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    152.56 ns |   0.264 ns |   0.247 ns |  0.46 |    0.00 |
|                                                      Take |           [50] |    419.41 ns |   1.859 ns |   1.648 ns |  1.27 |    0.00 |
|                                               LowCostTake |           [50] |    151.37 ns |   0.054 ns |   0.042 ns |  0.46 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    147.78 ns |   0.063 ns |   0.059 ns |  0.45 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |     90.45 ns |   0.019 ns |   0.018 ns |  0.27 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     81.31 ns |   0.025 ns |   0.024 ns |  0.25 |    0.00 |
|                                            SkipTakeSingle |           [50] |    329.86 ns |   2.973 ns |   2.781 ns |  1.00 |    0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    155.32 ns |   0.112 ns |   0.105 ns |  0.47 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    152.36 ns |   0.239 ns |   0.223 ns |  0.46 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     71.13 ns |   0.096 ns |   0.090 ns |  0.22 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     70.64 ns |   0.012 ns |   0.009 ns |  0.21 |    0.00 |
|                                           ForeachDelegate |           [50] |    549.09 ns |   1.000 ns |   0.886 ns |  1.67 |    0.00 |
|                                                   Foreach |           [50] |    329.03 ns |   0.026 ns |   0.023 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |            **[5]** |    **132.42 ns** |   **0.365 ns** |   **0.305 ns** |  **2.94** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     51.81 ns |   0.051 ns |   0.048 ns |  1.15 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     47.75 ns |   0.031 ns |   0.028 ns |  1.06 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     82.58 ns |   0.044 ns |   0.039 ns |  1.83 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     72.02 ns |   0.065 ns |   0.061 ns |  1.60 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     53.34 ns |   0.020 ns |   0.019 ns |  1.18 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     51.02 ns |   0.023 ns |   0.022 ns |  1.13 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |     86.46 ns |   0.134 ns |   0.119 ns |  1.92 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     71.43 ns |   0.082 ns |   0.064 ns |  1.59 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     63.04 ns |   0.034 ns |   0.029 ns |  1.40 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     48.39 ns |   0.034 ns |   0.031 ns |  1.07 |    0.00 |
|                                                 LinqCount |            [5] |    103.08 ns |   0.329 ns |   0.307 ns |  2.29 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     40.07 ns |   0.052 ns |   0.049 ns |  0.89 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     39.29 ns |   0.083 ns |   0.065 ns |  0.87 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     32.40 ns |   0.007 ns |   0.006 ns |  0.72 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     29.61 ns |   0.003 ns |   0.002 ns |  0.66 |    0.00 |
|                                               LinqToArray |            [5] |    137.77 ns |   0.386 ns |   0.361 ns |  3.06 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |     82.79 ns |   0.243 ns |   0.227 ns |  1.84 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     72.15 ns |   0.061 ns |   0.054 ns |  1.60 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     60.65 ns |   0.049 ns |   0.041 ns |  1.35 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     58.23 ns |   0.018 ns |   0.014 ns |  1.29 |    0.00 |
|                                                      Take |            [5] |    194.52 ns |   0.313 ns |   0.292 ns |  4.32 |    0.01 |
|                                               LowCostTake |            [5] |     59.90 ns |   0.072 ns |   0.060 ns |  1.33 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     54.01 ns |   0.025 ns |   0.023 ns |  1.20 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     60.56 ns |   0.015 ns |   0.012 ns |  1.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     55.98 ns |   0.009 ns |   0.008 ns |  1.24 |    0.00 |
|                                            SkipTakeSingle |            [5] |    166.00 ns |   0.476 ns |   0.445 ns |  3.68 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     54.64 ns |   0.035 ns |   0.031 ns |  1.21 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     52.67 ns |   0.024 ns |   0.022 ns |  1.17 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     54.37 ns |   0.021 ns |   0.020 ns |  1.21 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     50.43 ns |   0.003 ns |   0.002 ns |  1.12 |    0.00 |
|                                           ForeachDelegate |            [5] |     68.72 ns |   0.114 ns |   0.101 ns |  1.53 |    0.00 |
|                                                   Foreach |            [5] |     45.05 ns |   0.033 ns |   0.031 ns |  1.00 |    0.00 |
