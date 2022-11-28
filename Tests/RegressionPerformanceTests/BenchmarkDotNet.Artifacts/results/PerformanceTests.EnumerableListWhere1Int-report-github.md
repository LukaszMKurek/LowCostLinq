``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |        Mean |    Error |   StdDev | Ratio |
|---------------------------------------------------------- |--------------- |------------:|---------:|---------:|------:|
|                                                      **Linq** |            **[0]** |    **26.23 ns** | **0.041 ns** | **0.038 ns** |  **1.90** |
|                                   LowCostLinqWithDelegate |            [0] |    19.01 ns | 0.004 ns | 0.004 ns |  1.38 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    14.74 ns | 0.016 ns | 0.014 ns |  1.07 |
|                                  LowCostLinqWithDelegate2 |            [0] |    32.12 ns | 0.003 ns | 0.003 ns |  2.33 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    24.88 ns | 0.006 ns | 0.006 ns |  1.81 |
|                                LowCostLinqWithStructWhere |            [0] |    29.88 ns | 0.002 ns | 0.002 ns |  2.17 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    26.32 ns | 0.008 ns | 0.007 ns |  1.91 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    35.40 ns | 0.005 ns | 0.005 ns |  2.57 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    23.04 ns | 0.011 ns | 0.009 ns |  1.67 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    33.28 ns | 0.005 ns | 0.005 ns |  2.42 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    21.86 ns | 0.003 ns | 0.003 ns |  1.59 |
|                                                 LinqCount |            [0] |    22.80 ns | 0.023 ns | 0.022 ns |  1.65 |
|                              LowCostLinqWithDelegateCount |            [0] |    15.55 ns | 0.015 ns | 0.013 ns |  1.13 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    15.05 ns | 0.018 ns | 0.017 ns |  1.09 |
|                           LowCostLinqWithStructWhereCount |            [0] |    16.38 ns | 0.018 ns | 0.015 ns |  1.19 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    15.61 ns | 0.005 ns | 0.004 ns |  1.13 |
|                                               LinqToArray |            [0] |    24.09 ns | 0.008 ns | 0.006 ns |  1.75 |
|                            LowCostLinqWithDelegateToArray |            [0] |    19.29 ns | 0.010 ns | 0.008 ns |  1.40 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    18.29 ns | 0.024 ns | 0.020 ns |  1.33 |
|                              LowCostLinqWithStructToArray |            [0] |    25.03 ns | 0.023 ns | 0.021 ns |  1.82 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    17.87 ns | 0.005 ns | 0.005 ns |  1.30 |
|                                                      Take |            [0] |    52.14 ns | 0.047 ns | 0.037 ns |  3.79 |
|                                               LowCostTake |            [0] |    27.33 ns | 0.001 ns | 0.001 ns |  1.98 |
|                                  LowCostTakeWithoutChecks |            [0] |    21.81 ns | 0.001 ns | 0.001 ns |  1.58 |
|                                     LowCostTakeWithStruct |            [0] |    36.86 ns | 0.001 ns | 0.001 ns |  2.68 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    31.41 ns | 0.002 ns | 0.002 ns |  2.28 |
|                                            SkipTakeSingle |            [0] |    67.01 ns | 0.037 ns | 0.031 ns |  4.87 |
|                                     LowCostSkipTakeSingle |            [0] |    29.72 ns | 0.002 ns | 0.002 ns |  2.16 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    28.88 ns | 0.002 ns | 0.001 ns |  2.10 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    33.34 ns | 0.001 ns | 0.001 ns |  2.42 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    33.22 ns | 0.005 ns | 0.004 ns |  2.41 |
|                                           ForeachDelegate |            [0] |    14.48 ns | 0.004 ns | 0.003 ns |  1.05 |
|                                                   Foreach |            [0] |    13.78 ns | 0.013 ns | 0.012 ns |  1.00 |
|                                                           |                |             |          |          |       |
|                                                      **Linq** |         **[1000]** | **5,538.59 ns** | **6.308 ns** | **5.900 ns** | **0.890** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,169.58 ns | 2.450 ns | 2.292 ns | 0.509 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 2,931.13 ns | 5.271 ns | 4.930 ns | 0.471 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 3,184.64 ns | 7.229 ns | 6.762 ns | 0.512 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,165.46 ns | 2.585 ns | 2.418 ns | 0.509 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,980.99 ns | 1.372 ns | 1.216 ns | 0.318 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,733.05 ns | 1.402 ns | 1.171 ns | 0.279 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 5,308.49 ns | 4.699 ns | 4.396 ns | 0.853 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 4,812.74 ns | 1.608 ns | 1.425 ns | 0.774 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,442.66 ns | 8.171 ns | 7.643 ns | 0.553 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,368.60 ns | 1.204 ns | 1.067 ns | 0.541 |
|                                                 LinqCount |         [1000] | 1,951.19 ns | 5.356 ns | 5.010 ns | 0.314 |
|                              LowCostLinqWithDelegateCount |         [1000] | 1,690.20 ns | 1.059 ns | 0.991 ns | 0.272 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 1,926.72 ns | 0.261 ns | 0.231 ns | 0.310 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   619.15 ns | 0.553 ns | 0.462 ns | 0.100 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   499.86 ns | 0.287 ns | 0.240 ns | 0.080 |
|                                               LinqToArray |         [1000] | 3,061.45 ns | 1.873 ns | 1.660 ns | 0.492 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 2,581.25 ns | 5.139 ns | 4.807 ns | 0.415 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 2,823.56 ns | 3.503 ns | 3.105 ns | 0.454 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,846.68 ns | 1.146 ns | 1.072 ns | 0.297 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,605.40 ns | 0.847 ns | 0.661 ns | 0.258 |
|                                                      Take |         [1000] |   240.37 ns | 0.027 ns | 0.024 ns | 0.039 |
|                                               LowCostTake |         [1000] |    90.54 ns | 0.026 ns | 0.022 ns | 0.015 |
|                                  LowCostTakeWithoutChecks |         [1000] |    78.26 ns | 0.238 ns | 0.223 ns | 0.013 |
|                                     LowCostTakeWithStruct |         [1000] |    77.18 ns | 0.031 ns | 0.029 ns | 0.012 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    73.39 ns | 0.020 ns | 0.019 ns | 0.012 |
|                                            SkipTakeSingle |         [1000] |   170.32 ns | 0.045 ns | 0.038 ns | 0.027 |
|                                     LowCostSkipTakeSingle |         [1000] |    85.59 ns | 0.228 ns | 0.202 ns | 0.014 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    75.58 ns | 0.027 ns | 0.025 ns | 0.012 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    56.98 ns | 0.045 ns | 0.037 ns | 0.009 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    55.96 ns | 0.044 ns | 0.041 ns | 0.009 |
|                                           ForeachDelegate |         [1000] | 7,656.18 ns | 2.199 ns | 1.949 ns | 1.231 |
|                                                   Foreach |         [1000] | 6,221.22 ns | 0.132 ns | 0.117 ns | 1.000 |
|                                                           |                |             |          |          |       |
|                                                      **Linq** |           **[50]** |   **297.56 ns** | **0.052 ns** | **0.046 ns** |  **0.89** |
|                                   LowCostLinqWithDelegate |           [50] |   182.53 ns | 0.292 ns | 0.273 ns |  0.54 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   169.24 ns | 0.149 ns | 0.125 ns |  0.50 |
|                                  LowCostLinqWithDelegate2 |           [50] |   190.63 ns | 0.080 ns | 0.067 ns |  0.57 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   160.74 ns | 0.034 ns | 0.032 ns |  0.48 |
|                                LowCostLinqWithStructWhere |           [50] |   130.94 ns | 0.028 ns | 0.025 ns |  0.39 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   112.26 ns | 0.017 ns | 0.016 ns |  0.33 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   307.49 ns | 0.074 ns | 0.066 ns |  0.92 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   271.46 ns | 0.066 ns | 0.058 ns |  0.81 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   220.71 ns | 0.089 ns | 0.079 ns |  0.66 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   205.59 ns | 0.028 ns | 0.025 ns |  0.61 |
|                                                 LinqCount |           [50] |   124.11 ns | 0.038 ns | 0.032 ns |  0.37 |
|                              LowCostLinqWithDelegateCount |           [50] |   104.36 ns | 0.020 ns | 0.018 ns |  0.31 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   102.84 ns | 0.149 ns | 0.117 ns |  0.31 |
|                           LowCostLinqWithStructWhereCount |           [50] |    47.27 ns | 0.051 ns | 0.043 ns |  0.14 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    40.18 ns | 0.045 ns | 0.040 ns |  0.12 |
|                                               LinqToArray |           [50] |   254.89 ns | 0.289 ns | 0.256 ns |  0.76 |
|                            LowCostLinqWithDelegateToArray |           [50] |   199.49 ns | 0.253 ns | 0.225 ns |  0.59 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   205.75 ns | 0.264 ns | 0.247 ns |  0.61 |
|                              LowCostLinqWithStructToArray |           [50] |   156.62 ns | 0.355 ns | 0.332 ns |  0.47 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   137.25 ns | 0.336 ns | 0.314 ns |  0.41 |
|                                                      Take |           [50] |   241.43 ns | 0.053 ns | 0.047 ns |  0.72 |
|                                               LowCostTake |           [50] |    90.19 ns | 0.030 ns | 0.027 ns |  0.27 |
|                                  LowCostTakeWithoutChecks |           [50] |    78.21 ns | 0.223 ns | 0.208 ns |  0.23 |
|                                     LowCostTakeWithStruct |           [50] |    77.35 ns | 0.028 ns | 0.026 ns |  0.23 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    67.55 ns | 0.005 ns | 0.004 ns |  0.20 |
|                                            SkipTakeSingle |           [50] |   170.96 ns | 0.067 ns | 0.059 ns |  0.51 |
|                                     LowCostSkipTakeSingle |           [50] |    85.18 ns | 0.090 ns | 0.084 ns |  0.25 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    76.01 ns | 0.046 ns | 0.043 ns |  0.23 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    55.88 ns | 0.042 ns | 0.039 ns |  0.17 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    56.03 ns | 0.056 ns | 0.047 ns |  0.17 |
|                                           ForeachDelegate |           [50] |   402.27 ns | 0.154 ns | 0.136 ns |  1.20 |
|                                                   Foreach |           [50] |   336.02 ns | 0.067 ns | 0.056 ns |  1.00 |
|                                                           |                |             |          |          |       |
|                                                      **Linq** |            **[5]** |    **55.70 ns** | **0.043 ns** | **0.040 ns** |  **1.23** |
|                                   LowCostLinqWithDelegate |            [5] |    36.78 ns | 0.323 ns | 0.302 ns |  0.82 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    30.00 ns | 0.063 ns | 0.059 ns |  0.66 |
|                                  LowCostLinqWithDelegate2 |            [5] |    48.09 ns | 0.056 ns | 0.047 ns |  1.07 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    41.47 ns | 0.013 ns | 0.012 ns |  0.92 |
|                                LowCostLinqWithStructWhere |            [5] |    42.74 ns | 0.024 ns | 0.022 ns |  0.95 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    37.36 ns | 0.018 ns | 0.017 ns |  0.83 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    61.01 ns | 0.205 ns | 0.191 ns |  1.35 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    48.15 ns | 0.034 ns | 0.030 ns |  1.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    52.13 ns | 0.035 ns | 0.033 ns |  1.16 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    39.78 ns | 0.025 ns | 0.023 ns |  0.88 |
|                                                 LinqCount |            [5] |    31.25 ns | 0.020 ns | 0.018 ns |  0.69 |
|                              LowCostLinqWithDelegateCount |            [5] |    25.03 ns | 0.025 ns | 0.023 ns |  0.55 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    26.33 ns | 0.015 ns | 0.013 ns |  0.58 |
|                           LowCostLinqWithStructWhereCount |            [5] |    18.96 ns | 0.002 ns | 0.002 ns |  0.42 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    20.30 ns | 0.007 ns | 0.007 ns |  0.45 |
|                                               LinqToArray |            [5] |    63.19 ns | 0.069 ns | 0.064 ns |  1.40 |
|                            LowCostLinqWithDelegateToArray |            [5] |    58.29 ns | 0.037 ns | 0.033 ns |  1.29 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    56.34 ns | 0.178 ns | 0.167 ns |  1.25 |
|                              LowCostLinqWithStructToArray |            [5] |    57.51 ns | 0.072 ns | 0.067 ns |  1.27 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    47.36 ns | 0.011 ns | 0.009 ns |  1.05 |
|                                                      Take |            [5] |    99.70 ns | 0.044 ns | 0.039 ns |  2.21 |
|                                               LowCostTake |            [5] |    43.11 ns | 0.006 ns | 0.005 ns |  0.96 |
|                                  LowCostTakeWithoutChecks |            [5] |    36.20 ns | 0.033 ns | 0.031 ns |  0.80 |
|                                     LowCostTakeWithStruct |            [5] |    47.86 ns | 0.032 ns | 0.030 ns |  1.06 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    42.08 ns | 0.024 ns | 0.021 ns |  0.93 |
|                                            SkipTakeSingle |            [5] |    92.73 ns | 0.067 ns | 0.060 ns |  2.05 |
|                                     LowCostSkipTakeSingle |            [5] |    38.04 ns | 0.023 ns | 0.021 ns |  0.84 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    36.67 ns | 0.024 ns | 0.022 ns |  0.81 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    37.59 ns | 0.002 ns | 0.002 ns |  0.83 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    37.29 ns | 0.009 ns | 0.007 ns |  0.83 |
|                                           ForeachDelegate |            [5] |    53.02 ns | 0.033 ns | 0.030 ns |  1.17 |
|                                                   Foreach |            [5] |    45.12 ns | 0.035 ns | 0.033 ns |  1.00 |
