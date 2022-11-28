``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |      Error |       StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **93.04 ns** |   **0.017 ns** |     **0.015 ns** |  **6.76** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     37.07 ns |   0.011 ns |     0.011 ns |  2.69 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     32.01 ns |   0.028 ns |     0.026 ns |  2.32 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     63.39 ns |   0.052 ns |     0.049 ns |  4.60 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     58.10 ns |   0.031 ns |     0.029 ns |  4.22 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     49.20 ns |   0.002 ns |     0.002 ns |  3.57 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     44.99 ns |   0.006 ns |     0.006 ns |  3.27 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     51.70 ns |   0.015 ns |     0.013 ns |  3.75 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     40.93 ns |   0.007 ns |     0.006 ns |  2.97 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     52.32 ns |   0.009 ns |     0.008 ns |  3.80 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     39.29 ns |   0.003 ns |     0.002 ns |  2.85 |    0.00 |
|                                                 LinqCount |            [0] |     88.85 ns |   0.021 ns |     0.019 ns |  6.45 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     23.85 ns |   0.002 ns |     0.002 ns |  1.73 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     22.97 ns |   0.008 ns |     0.008 ns |  1.67 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     35.54 ns |   0.001 ns |     0.001 ns |  2.58 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     35.36 ns |   0.002 ns |     0.002 ns |  2.57 |    0.00 |
|                                               LinqToArray |            [0] |     95.50 ns |   0.024 ns |     0.021 ns |  6.93 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     25.53 ns |   0.002 ns |     0.001 ns |  1.85 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     24.24 ns |   0.002 ns |     0.002 ns |  1.76 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     46.52 ns |   0.035 ns |     0.033 ns |  3.38 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     40.73 ns |   0.006 ns |     0.006 ns |  2.96 |    0.00 |
|                                                      Take |            [0] |    122.21 ns |   0.136 ns |     0.127 ns |  8.87 |    0.01 |
|                                               LowCostTake |            [0] |     44.98 ns |   0.018 ns |     0.017 ns |  3.27 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     39.93 ns |   0.018 ns |     0.017 ns |  2.90 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     61.23 ns |   0.005 ns |     0.005 ns |  4.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     56.39 ns |   0.004 ns |     0.003 ns |  4.09 |    0.00 |
|                                            SkipTakeSingle |            [0] |    141.57 ns |   0.021 ns |     0.018 ns | 10.28 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     39.66 ns |   0.003 ns |     0.002 ns |  2.88 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     40.20 ns |   0.020 ns |     0.019 ns |  2.92 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     56.59 ns |   0.012 ns |     0.010 ns |  4.11 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     55.23 ns |   0.002 ns |     0.002 ns |  4.01 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.54 ns |   0.016 ns |     0.014 ns |  1.13 |    0.00 |
|                                                   Foreach |            [0] |     13.77 ns |   0.007 ns |     0.006 ns |  1.00 |    0.00 |
|                                                           |                |              |            |              |       |         |
|                                                      **Linq** |         **[1000]** | **17,726.91 ns** | **354.110 ns** | **1,027.337 ns** |  **2.86** |    **0.20** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,494.64 ns |   2.278 ns |     2.131 ns |  1.20 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  7,488.63 ns |   1.054 ns |     0.880 ns |  1.20 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  7,994.51 ns |   2.725 ns |     2.549 ns |  1.28 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  7,810.97 ns |  27.167 ns |    24.083 ns |  1.26 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,833.08 ns |   0.879 ns |     0.822 ns |  0.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,720.62 ns |   2.906 ns |     2.718 ns |  0.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  9,865.05 ns |   2.628 ns |     2.194 ns |  1.59 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  9,843.86 ns |   2.269 ns |     2.012 ns |  1.58 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,641.83 ns |   3.873 ns |     3.623 ns |  0.59 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,383.95 ns |   1.716 ns |     1.605 ns |  0.54 |    0.00 |
|                                                 LinqCount |         [1000] | 12,489.74 ns | 276.252 ns |   814.536 ns |  2.02 |    0.10 |
|                              LowCostLinqWithDelegateCount |         [1000] |  7,018.36 ns |   1.141 ns |     1.067 ns |  1.13 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,758.82 ns |   0.899 ns |     0.841 ns |  1.09 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    524.02 ns |   0.486 ns |     0.406 ns |  0.08 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    516.65 ns |   0.123 ns |     0.115 ns |  0.08 |    0.00 |
|                                               LinqToArray |         [1000] | 12,661.41 ns | 250.877 ns |   534.640 ns |  2.03 |    0.08 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,020.85 ns |   4.420 ns |     3.919 ns |  1.29 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,234.49 ns |   3.148 ns |     2.790 ns |  1.32 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,646.22 ns |   0.593 ns |     0.526 ns |  0.26 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,612.66 ns |   1.343 ns |     1.256 ns |  0.26 |    0.00 |
|                                                      Take |         [1000] |    486.01 ns |   5.306 ns |     4.963 ns |  0.08 |    0.00 |
|                                               LowCostTake |         [1000] |    224.80 ns |   0.074 ns |     0.062 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    217.57 ns |   1.781 ns |     1.666 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    101.96 ns |   0.004 ns |     0.004 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     92.18 ns |   0.019 ns |     0.017 ns |  0.01 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    418.17 ns |   6.881 ns |     6.436 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    223.55 ns |   0.188 ns |     0.167 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    232.71 ns |   0.060 ns |     0.056 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    113.87 ns |   0.571 ns |     0.535 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    110.61 ns |   0.092 ns |     0.082 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] | 12,429.73 ns |   3.211 ns |     2.847 ns |  2.00 |    0.00 |
|                                                   Foreach |         [1000] |  6,221.45 ns |   0.191 ns |     0.170 ns |  1.00 |    0.00 |
|                                                           |                |              |            |              |       |         |
|                                                      **Linq** |           **[50]** |    **822.39 ns** |  **15.986 ns** |    **21.340 ns** |  **2.49** |    **0.07** |
|                                   LowCostLinqWithDelegate |           [50] |    408.69 ns |   0.048 ns |     0.037 ns |  1.24 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    410.90 ns |   0.392 ns |     0.367 ns |  1.25 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    459.86 ns |   0.079 ns |     0.074 ns |  1.40 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    429.17 ns |   0.030 ns |     0.028 ns |  1.30 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    143.81 ns |   0.027 ns |     0.025 ns |  0.44 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    122.72 ns |   0.107 ns |     0.089 ns |  0.37 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    539.50 ns |   0.245 ns |     0.217 ns |  1.64 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    523.51 ns |   0.163 ns |     0.136 ns |  1.59 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    241.93 ns |   0.082 ns |     0.073 ns |  0.74 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    224.91 ns |   0.031 ns |     0.026 ns |  0.68 |    0.00 |
|                                                 LinqCount |           [50] |    615.45 ns |  12.200 ns |    16.287 ns |  1.88 |    0.06 |
|                              LowCostLinqWithDelegateCount |           [50] |    370.47 ns |   0.211 ns |     0.197 ns |  1.13 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    360.67 ns |   0.122 ns |     0.102 ns |  1.10 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     59.46 ns |   0.078 ns |     0.069 ns |  0.18 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     57.73 ns |   0.007 ns |     0.006 ns |  0.18 |    0.00 |
|                                               LinqToArray |           [50] |    757.30 ns |  15.049 ns |    14.076 ns |  2.30 |    0.04 |
|                            LowCostLinqWithDelegateToArray |           [50] |    493.08 ns |   0.502 ns |     0.445 ns |  1.50 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    477.96 ns |   0.386 ns |     0.342 ns |  1.45 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    161.62 ns |   0.284 ns |     0.265 ns |  0.49 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    156.29 ns |   0.076 ns |     0.064 ns |  0.48 |    0.00 |
|                                                      Take |           [50] |    482.67 ns |   5.667 ns |     5.301 ns |  1.47 |    0.02 |
|                                               LowCostTake |           [50] |    224.61 ns |   0.178 ns |     0.158 ns |  0.68 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    220.05 ns |   1.297 ns |     1.214 ns |  0.67 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    101.69 ns |   0.007 ns |     0.007 ns |  0.31 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     92.26 ns |   0.028 ns |     0.026 ns |  0.28 |    0.00 |
|                                            SkipTakeSingle |           [50] |    401.32 ns |   2.897 ns |     2.710 ns |  1.22 |    0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    223.28 ns |   0.123 ns |     0.109 ns |  0.68 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    233.74 ns |   0.035 ns |     0.033 ns |  0.71 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    113.82 ns |   0.034 ns |     0.031 ns |  0.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    110.06 ns |   0.069 ns |     0.064 ns |  0.33 |    0.00 |
|                                           ForeachDelegate |           [50] |    628.30 ns |   0.082 ns |     0.073 ns |  1.91 |    0.00 |
|                                                   Foreach |           [50] |    328.96 ns |   0.043 ns |     0.038 ns |  1.00 |    0.00 |
|                                                           |                |              |            |              |       |         |
|                                                      **Linq** |            **[5]** |    **170.02 ns** |   **0.417 ns** |     **0.390 ns** |  **3.76** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     67.89 ns |   0.072 ns |     0.068 ns |  1.50 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     60.72 ns |   0.067 ns |     0.062 ns |  1.34 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     96.16 ns |   0.023 ns |     0.021 ns |  2.13 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     91.65 ns |   0.032 ns |     0.030 ns |  2.03 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     60.40 ns |   0.024 ns |     0.023 ns |  1.34 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     53.82 ns |   0.004 ns |     0.003 ns |  1.19 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    101.64 ns |   0.053 ns |     0.050 ns |  2.25 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     88.28 ns |   0.051 ns |     0.045 ns |  1.95 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     66.69 ns |   0.079 ns |     0.066 ns |  1.48 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     54.48 ns |   0.005 ns |     0.004 ns |  1.21 |    0.00 |
|                                                 LinqCount |            [5] |    138.32 ns |   0.373 ns |     0.349 ns |  3.06 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     55.89 ns |   0.038 ns |     0.036 ns |  1.24 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     53.34 ns |   0.032 ns |     0.030 ns |  1.18 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     38.85 ns |   0.013 ns |     0.011 ns |  0.86 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     38.85 ns |   0.013 ns |     0.011 ns |  0.86 |    0.00 |
|                                               LinqToArray |            [5] |    176.26 ns |   0.287 ns |     0.269 ns |  3.90 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |     87.09 ns |   0.084 ns |     0.079 ns |  1.93 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     83.14 ns |   0.070 ns |     0.066 ns |  1.84 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     71.70 ns |   0.025 ns |     0.022 ns |  1.59 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     66.49 ns |   0.013 ns |     0.011 ns |  1.47 |    0.00 |
|                                                      Take |            [5] |    221.49 ns |   0.965 ns |     0.902 ns |  4.90 |    0.02 |
|                                               LowCostTake |            [5] |     82.09 ns |   0.088 ns |     0.073 ns |  1.82 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     76.43 ns |   0.049 ns |     0.046 ns |  1.69 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     71.52 ns |   0.015 ns |     0.013 ns |  1.58 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     65.92 ns |   0.014 ns |     0.011 ns |  1.46 |    0.00 |
|                                            SkipTakeSingle |            [5] |    210.18 ns |   0.368 ns |     0.345 ns |  4.65 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     77.00 ns |   0.058 ns |     0.054 ns |  1.70 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     77.94 ns |   0.066 ns |     0.062 ns |  1.72 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     65.96 ns |   0.014 ns |     0.013 ns |  1.46 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     64.44 ns |   0.026 ns |     0.023 ns |  1.43 |    0.00 |
|                                           ForeachDelegate |            [5] |     81.87 ns |   0.029 ns |     0.025 ns |  1.81 |    0.00 |
|                                                   Foreach |            [5] |     45.20 ns |   0.028 ns |     0.025 ns |  1.00 |    0.00 |
