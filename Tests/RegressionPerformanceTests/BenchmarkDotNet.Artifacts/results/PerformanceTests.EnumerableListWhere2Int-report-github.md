``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |        Mean |     Error |   StdDev | Ratio |
|---------------------------------------------------------- |--------------- |------------:|----------:|---------:|------:|
|                                                      **Linq** |            **[0]** |    **49.81 ns** |  **0.025 ns** | **0.021 ns** |  **3.61** |
|                                   LowCostLinqWithDelegate |            [0] |    23.48 ns |  0.001 ns | 0.001 ns |  1.70 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    16.85 ns |  0.004 ns | 0.004 ns |  1.22 |
|                                  LowCostLinqWithDelegate2 |            [0] |    40.51 ns |  0.002 ns | 0.002 ns |  2.94 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    35.61 ns |  0.001 ns | 0.001 ns |  2.58 |
|                                LowCostLinqWithStructWhere |            [0] |    36.47 ns |  0.006 ns | 0.005 ns |  2.65 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    31.05 ns |  0.002 ns | 0.001 ns |  2.25 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    39.01 ns |  0.025 ns | 0.022 ns |  2.83 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    27.57 ns |  0.005 ns | 0.004 ns |  2.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    37.09 ns |  0.004 ns | 0.004 ns |  2.69 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    26.46 ns |  0.006 ns | 0.005 ns |  1.92 |
|                                                 LinqCount |            [0] |    48.87 ns |  0.008 ns | 0.007 ns |  3.54 |
|                              LowCostLinqWithDelegateCount |            [0] |    14.73 ns |  0.006 ns | 0.005 ns |  1.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    12.95 ns |  0.005 ns | 0.005 ns |  0.94 |
|                           LowCostLinqWithStructWhereCount |            [0] |    21.96 ns |  0.001 ns | 0.001 ns |  1.59 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    21.59 ns |  0.001 ns | 0.001 ns |  1.57 |
|                                               LinqToArray |            [0] |    49.64 ns |  0.012 ns | 0.011 ns |  3.60 |
|                            LowCostLinqWithDelegateToArray |            [0] |    16.68 ns |  0.020 ns | 0.018 ns |  1.21 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    15.72 ns |  0.032 ns | 0.029 ns |  1.14 |
|                              LowCostLinqWithStructToArray |            [0] |    25.70 ns |  0.006 ns | 0.006 ns |  1.86 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    24.24 ns |  0.001 ns | 0.001 ns |  1.76 |
|                                                      Take |            [0] |    78.57 ns |  0.020 ns | 0.015 ns |  5.70 |
|                                               LowCostTake |            [0] |    32.05 ns |  0.002 ns | 0.002 ns |  2.32 |
|                                  LowCostTakeWithoutChecks |            [0] |    25.21 ns |  0.002 ns | 0.002 ns |  1.83 |
|                                     LowCostTakeWithStruct |            [0] |    43.61 ns |  0.002 ns | 0.002 ns |  3.16 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    38.45 ns |  0.003 ns | 0.003 ns |  2.79 |
|                                            SkipTakeSingle |            [0] |    92.56 ns |  0.051 ns | 0.045 ns |  6.71 |
|                                     LowCostSkipTakeSingle |            [0] |    32.98 ns |  0.004 ns | 0.004 ns |  2.39 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    31.96 ns |  0.010 ns | 0.009 ns |  2.32 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    40.43 ns |  0.001 ns | 0.001 ns |  2.93 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    39.68 ns |  0.001 ns | 0.001 ns |  2.88 |
|                                           ForeachDelegate |            [0] |    14.33 ns |  0.020 ns | 0.017 ns |  1.04 |
|                                                   Foreach |            [0] |    13.79 ns |  0.023 ns | 0.018 ns |  1.00 |
|                                                           |                |             |           |          |       |
|                                                      **Linq** |         **[1000]** | **8,430.35 ns** | **10.619 ns** | **9.414 ns** |  **1.36** |
|                                   LowCostLinqWithDelegate |         [1000] | 4,607.73 ns |  0.452 ns | 0.377 ns |  0.74 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 4,600.73 ns |  5.008 ns | 4.685 ns |  0.74 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 4,377.20 ns |  1.893 ns | 1.771 ns |  0.70 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 4,367.47 ns |  1.626 ns | 1.441 ns |  0.70 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,824.50 ns |  0.422 ns | 0.395 ns |  0.29 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,729.70 ns |  9.120 ns | 8.531 ns |  0.28 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,620.09 ns |  6.126 ns | 5.431 ns |  1.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 6,490.30 ns |  0.836 ns | 0.741 ns |  1.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,400.03 ns |  5.787 ns | 5.413 ns |  0.55 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,614.80 ns |  0.408 ns | 0.362 ns |  0.58 |
|                                                 LinqCount |         [1000] | 4,121.83 ns |  3.616 ns | 3.205 ns |  0.66 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,599.96 ns |  0.127 ns | 0.113 ns |  0.58 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 3,826.71 ns |  0.141 ns | 0.118 ns |  0.62 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   509.47 ns |  0.583 ns | 0.545 ns |  0.08 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   505.67 ns |  0.221 ns | 0.196 ns |  0.08 |
|                                               LinqToArray |         [1000] | 5,498.09 ns |  5.847 ns | 5.469 ns |  0.88 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 5,051.05 ns |  2.754 ns | 2.300 ns |  0.81 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 4,574.32 ns |  2.447 ns | 2.043 ns |  0.74 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,621.81 ns |  3.166 ns | 2.962 ns |  0.26 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,549.92 ns |  0.413 ns | 0.366 ns |  0.25 |
|                                                      Take |         [1000] |   320.91 ns |  0.058 ns | 0.051 ns |  0.05 |
|                                               LowCostTake |         [1000] |   124.45 ns |  0.045 ns | 0.042 ns |  0.02 |
|                                  LowCostTakeWithoutChecks |         [1000] |   119.02 ns |  0.016 ns | 0.015 ns |  0.02 |
|                                     LowCostTakeWithStruct |         [1000] |    83.95 ns |  0.032 ns | 0.030 ns |  0.01 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    73.08 ns |  0.007 ns | 0.006 ns |  0.01 |
|                                            SkipTakeSingle |         [1000] |   244.83 ns |  0.364 ns | 0.341 ns |  0.04 |
|                                     LowCostSkipTakeSingle |         [1000] |   120.29 ns |  0.021 ns | 0.020 ns |  0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   112.79 ns |  0.038 ns | 0.032 ns |  0.02 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    64.27 ns |  0.063 ns | 0.056 ns |  0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    63.64 ns |  0.063 ns | 0.053 ns |  0.01 |
|                                           ForeachDelegate |         [1000] | 9,321.06 ns |  2.816 ns | 2.352 ns |  1.50 |
|                                                   Foreach |         [1000] | 6,221.43 ns |  0.804 ns | 0.672 ns |  1.00 |
|                                                           |                |             |           |          |       |
|                                                      **Linq** |           **[50]** |   **442.85 ns** |  **0.118 ns** | **0.099 ns** |  **1.35** |
|                                   LowCostLinqWithDelegate |           [50] |   233.02 ns |  0.082 ns | 0.073 ns |  0.71 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   235.13 ns |  0.024 ns | 0.021 ns |  0.71 |
|                                  LowCostLinqWithDelegate2 |           [50] |   272.23 ns |  0.144 ns | 0.135 ns |  0.83 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   237.77 ns |  0.030 ns | 0.028 ns |  0.72 |
|                                LowCostLinqWithStructWhere |           [50] |   131.48 ns |  0.022 ns | 0.020 ns |  0.40 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   118.61 ns |  0.197 ns | 0.164 ns |  0.36 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   390.38 ns |  0.494 ns | 0.462 ns |  1.19 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   345.82 ns |  0.086 ns | 0.076 ns |  1.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   225.28 ns |  0.025 ns | 0.022 ns |  0.68 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   212.98 ns |  0.192 ns | 0.170 ns |  0.65 |
|                                                 LinqCount |           [50] |   256.50 ns |  0.322 ns | 0.301 ns |  0.78 |
|                              LowCostLinqWithDelegateCount |           [50] |   199.52 ns |  0.177 ns | 0.166 ns |  0.61 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   201.00 ns |  0.041 ns | 0.037 ns |  0.61 |
|                           LowCostLinqWithStructWhereCount |           [50] |    49.78 ns |  0.051 ns | 0.042 ns |  0.15 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    44.91 ns |  0.017 ns | 0.015 ns |  0.14 |
|                                               LinqToArray |           [50] |   416.08 ns |  0.337 ns | 0.315 ns |  1.26 |
|                            LowCostLinqWithDelegateToArray |           [50] |   324.34 ns |  0.388 ns | 0.363 ns |  0.99 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   297.07 ns |  0.305 ns | 0.285 ns |  0.90 |
|                              LowCostLinqWithStructToArray |           [50] |   150.91 ns |  0.609 ns | 0.540 ns |  0.46 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   143.90 ns |  0.209 ns | 0.195 ns |  0.44 |
|                                                      Take |           [50] |   324.19 ns |  0.038 ns | 0.029 ns |  0.98 |
|                                               LowCostTake |           [50] |   124.31 ns |  0.040 ns | 0.035 ns |  0.38 |
|                                  LowCostTakeWithoutChecks |           [50] |   118.69 ns |  0.014 ns | 0.013 ns |  0.36 |
|                                     LowCostTakeWithStruct |           [50] |    84.34 ns |  0.036 ns | 0.033 ns |  0.26 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    73.07 ns |  0.008 ns | 0.006 ns |  0.22 |
|                                            SkipTakeSingle |           [50] |   237.80 ns |  0.072 ns | 0.060 ns |  0.72 |
|                                     LowCostSkipTakeSingle |           [50] |   119.09 ns |  0.059 ns | 0.056 ns |  0.36 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   113.74 ns |  0.042 ns | 0.037 ns |  0.35 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    64.21 ns |  0.069 ns | 0.065 ns |  0.20 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    64.57 ns |  0.042 ns | 0.037 ns |  0.20 |
|                                           ForeachDelegate |           [50] |   473.67 ns |  0.087 ns | 0.077 ns |  1.44 |
|                                                   Foreach |           [50] |   329.13 ns |  0.070 ns | 0.062 ns |  1.00 |
|                                                           |                |             |           |          |       |
|                                                      **Linq** |            **[5]** |    **90.89 ns** |  **0.072 ns** | **0.067 ns** |  **2.02** |
|                                   LowCostLinqWithDelegate |            [5] |    43.17 ns |  0.041 ns | 0.038 ns |  0.96 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    36.37 ns |  0.033 ns | 0.031 ns |  0.81 |
|                                  LowCostLinqWithDelegate2 |            [5] |    61.34 ns |  0.041 ns | 0.037 ns |  1.36 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    53.41 ns |  0.024 ns | 0.021 ns |  1.18 |
|                                LowCostLinqWithStructWhere |            [5] |    50.16 ns |  0.005 ns | 0.004 ns |  1.11 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    40.52 ns |  0.307 ns | 0.287 ns |  0.90 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    74.25 ns |  0.261 ns | 0.244 ns |  1.65 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    59.41 ns |  0.033 ns | 0.029 ns |  1.32 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    57.11 ns |  0.172 ns | 0.161 ns |  1.27 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    42.87 ns |  0.027 ns | 0.024 ns |  0.95 |
|                                                 LinqCount |            [5] |    66.79 ns |  0.030 ns | 0.024 ns |  1.48 |
|                              LowCostLinqWithDelegateCount |            [5] |    31.77 ns |  0.087 ns | 0.081 ns |  0.70 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    29.93 ns |  0.040 ns | 0.037 ns |  0.66 |
|                           LowCostLinqWithStructWhereCount |            [5] |    24.84 ns |  0.000 ns | 0.000 ns |  0.55 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    23.44 ns |  0.001 ns | 0.001 ns |  0.52 |
|                                               LinqToArray |            [5] |   103.06 ns |  0.087 ns | 0.073 ns |  2.29 |
|                            LowCostLinqWithDelegateToArray |            [5] |    67.17 ns |  0.209 ns | 0.196 ns |  1.49 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    61.37 ns |  0.147 ns | 0.131 ns |  1.36 |
|                              LowCostLinqWithStructToArray |            [5] |    58.95 ns |  0.064 ns | 0.060 ns |  1.31 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    52.98 ns |  0.010 ns | 0.009 ns |  1.18 |
|                                                      Take |            [5] |   141.57 ns |  0.041 ns | 0.036 ns |  3.14 |
|                                               LowCostTake |            [5] |    53.61 ns |  0.027 ns | 0.025 ns |  1.19 |
|                                  LowCostTakeWithoutChecks |            [5] |    43.99 ns |  0.023 ns | 0.022 ns |  0.98 |
|                                     LowCostTakeWithStruct |            [5] |    54.64 ns |  0.023 ns | 0.022 ns |  1.21 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    47.67 ns |  0.021 ns | 0.019 ns |  1.06 |
|                                            SkipTakeSingle |            [5] |   128.86 ns |  0.057 ns | 0.050 ns |  2.86 |
|                                     LowCostSkipTakeSingle |            [5] |    46.31 ns |  0.030 ns | 0.028 ns |  1.03 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    45.75 ns |  0.043 ns | 0.040 ns |  1.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    44.23 ns |  0.004 ns | 0.004 ns |  0.98 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    43.72 ns |  0.001 ns | 0.001 ns |  0.97 |
|                                           ForeachDelegate |            [5] |    60.09 ns |  0.053 ns | 0.050 ns |  1.33 |
|                                                   Foreach |            [5] |    45.08 ns |  0.024 ns | 0.022 ns |  1.00 |
