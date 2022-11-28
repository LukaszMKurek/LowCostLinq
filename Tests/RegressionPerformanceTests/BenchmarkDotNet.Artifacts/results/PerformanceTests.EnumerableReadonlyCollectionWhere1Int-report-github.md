``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |     Error |    StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|----------:|----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **41.08 ns** |  **0.058 ns** |  **0.054 ns** |     **41.05 ns** |  **2.78** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     30.43 ns |  0.006 ns |  0.005 ns |     30.43 ns |  2.06 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     26.86 ns |  0.014 ns |  0.011 ns |     26.85 ns |  1.82 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     42.78 ns |  0.005 ns |  0.004 ns |     42.78 ns |  2.90 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     36.75 ns |  0.010 ns |  0.009 ns |     36.75 ns |  2.49 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     46.31 ns |  0.014 ns |  0.011 ns |     46.31 ns |  3.14 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     36.44 ns |  0.015 ns |  0.013 ns |     36.44 ns |  2.47 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     37.66 ns |  0.190 ns |  0.177 ns |     37.75 ns |  2.55 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     36.70 ns |  0.328 ns |  0.307 ns |     36.90 ns |  2.48 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     34.54 ns |  0.008 ns |  0.006 ns |     34.54 ns |  2.34 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     34.31 ns |  0.006 ns |  0.005 ns |     34.31 ns |  2.32 |    0.00 |
|                                                 LinqCount |            [0] |     35.79 ns |  0.029 ns |  0.024 ns |     35.79 ns |  2.42 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     29.54 ns |  0.034 ns |  0.032 ns |     29.53 ns |  2.00 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     30.93 ns |  0.013 ns |  0.011 ns |     30.93 ns |  2.09 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     27.40 ns |  0.014 ns |  0.012 ns |     27.40 ns |  1.86 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     27.55 ns |  0.021 ns |  0.020 ns |     27.55 ns |  1.87 |    0.00 |
|                                               LinqToArray |            [0] |     38.12 ns |  0.010 ns |  0.009 ns |     38.12 ns |  2.58 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     33.68 ns |  0.012 ns |  0.010 ns |     33.67 ns |  2.28 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     34.44 ns |  0.302 ns |  0.282 ns |     34.46 ns |  2.33 |    0.02 |
|                              LowCostLinqWithStructToArray |            [0] |     31.25 ns |  0.025 ns |  0.021 ns |     31.26 ns |  2.12 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     29.61 ns |  0.007 ns |  0.006 ns |     29.60 ns |  2.01 |    0.00 |
|                                                      Take |            [0] |     60.52 ns |  0.096 ns |  0.090 ns |     60.47 ns |  4.10 |    0.01 |
|                                               LowCostTake |            [0] |     36.72 ns |  0.008 ns |  0.006 ns |     36.72 ns |  2.49 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     34.55 ns |  0.005 ns |  0.004 ns |     34.55 ns |  2.34 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     50.63 ns |  0.021 ns |  0.018 ns |     50.63 ns |  3.43 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     43.05 ns |  0.013 ns |  0.011 ns |     43.05 ns |  2.92 |    0.00 |
|                                            SkipTakeSingle |            [0] |     83.94 ns |  0.044 ns |  0.039 ns |     83.92 ns |  5.68 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     39.70 ns |  0.026 ns |  0.024 ns |     39.71 ns |  2.69 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     39.06 ns |  0.021 ns |  0.019 ns |     39.06 ns |  2.65 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     43.73 ns |  0.012 ns |  0.011 ns |     43.73 ns |  2.96 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     46.58 ns |  0.049 ns |  0.041 ns |     46.58 ns |  3.15 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.47 ns |  0.018 ns |  0.016 ns |     15.46 ns |  1.05 |    0.00 |
|                                                   Foreach |            [0] |     14.76 ns |  0.005 ns |  0.004 ns |     14.76 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |              |       |         |
|                                                      **Linq** |         **[1000]** | **11,286.76 ns** |  **1.773 ns** |  **1.571 ns** | **11,286.72 ns** |  **1.81** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  9,165.31 ns |  2.724 ns |  2.415 ns |  9,165.58 ns |  1.47 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  9,302.17 ns | 65.866 ns | 61.611 ns |  9,326.20 ns |  1.49 |    0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  9,160.88 ns |  4.679 ns |  4.148 ns |  9,159.26 ns |  1.47 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  9,154.20 ns |  3.520 ns |  3.121 ns |  9,153.81 ns |  1.47 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,945.54 ns | 28.951 ns | 27.081 ns |  7,956.18 ns |  1.28 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  7,955.76 ns |  2.803 ns |  2.622 ns |  7,956.36 ns |  1.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 11,278.06 ns |  3.348 ns |  2.796 ns | 11,278.89 ns |  1.81 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 11,262.21 ns |  1.652 ns |  1.380 ns | 11,261.91 ns |  1.81 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,383.28 ns |  2.579 ns |  2.287 ns |  9,383.25 ns |  1.51 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,609.26 ns |  3.361 ns |  2.980 ns |  9,609.61 ns |  1.54 |    0.00 |
|                                                 LinqCount |         [1000] |  8,426.62 ns |  3.670 ns |  3.253 ns |  8,424.96 ns |  1.35 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,304.39 ns |  0.521 ns |  0.462 ns |  8,304.47 ns |  1.33 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,298.98 ns |  1.340 ns |  1.188 ns |  8,299.14 ns |  1.33 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,487.09 ns |  0.947 ns |  0.840 ns |  6,487.31 ns |  1.04 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,488.56 ns |  1.858 ns |  1.647 ns |  6,488.01 ns |  1.04 |    0.00 |
|                                               LinqToArray |         [1000] |  9,120.32 ns | 10.597 ns |  8.849 ns |  9,119.88 ns |  1.47 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,177.84 ns |  6.415 ns |  5.687 ns |  9,178.18 ns |  1.47 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  9,178.99 ns |  7.473 ns |  6.625 ns |  9,180.59 ns |  1.47 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,750.56 ns |  5.180 ns |  4.592 ns |  7,751.13 ns |  1.25 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,745.16 ns |  5.807 ns |  5.148 ns |  7,744.66 ns |  1.24 |    0.00 |
|                                                      Take |         [1000] |    364.04 ns |  0.074 ns |  0.066 ns |    364.04 ns |  0.06 |    0.00 |
|                                               LowCostTake |         [1000] |    216.54 ns |  0.037 ns |  0.033 ns |    216.55 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    212.80 ns |  0.100 ns |  0.083 ns |    212.79 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    185.49 ns |  0.045 ns |  0.040 ns |    185.49 ns |  0.03 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    183.72 ns |  0.049 ns |  0.043 ns |    183.72 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    299.36 ns |  0.046 ns |  0.041 ns |    299.36 ns |  0.05 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    222.26 ns |  0.193 ns |  0.181 ns |    222.23 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    220.50 ns |  0.066 ns |  0.055 ns |    220.49 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    182.68 ns |  0.091 ns |  0.081 ns |    182.67 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    183.13 ns |  0.047 ns |  0.042 ns |    183.12 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] |  7,654.30 ns |  1.940 ns |  1.720 ns |  7,653.27 ns |  1.23 |    0.00 |
|                                                   Foreach |         [1000] |  6,223.62 ns |  0.229 ns |  0.203 ns |  6,223.67 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |              |       |         |
|                                                      **Linq** |           **[50]** |    **624.56 ns** |  **0.083 ns** |  **0.069 ns** |    **624.57 ns** |  **1.89** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    491.72 ns |  0.432 ns |  0.383 ns |    491.58 ns |  1.49 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    497.55 ns |  0.154 ns |  0.128 ns |    497.54 ns |  1.51 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    510.30 ns |  0.313 ns |  0.277 ns |    510.29 ns |  1.55 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    474.98 ns |  0.599 ns |  0.560 ns |    474.95 ns |  1.44 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    427.05 ns |  0.196 ns |  0.174 ns |    427.07 ns |  1.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    423.90 ns |  0.251 ns |  0.223 ns |    423.89 ns |  1.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    590.93 ns |  0.136 ns |  0.121 ns |    590.91 ns |  1.79 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    596.86 ns |  0.365 ns |  0.305 ns |    596.81 ns |  1.81 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    513.37 ns |  0.061 ns |  0.051 ns |    513.37 ns |  1.55 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    513.32 ns |  0.123 ns |  0.109 ns |    513.30 ns |  1.55 |    0.00 |
|                                                 LinqCount |           [50] |    459.24 ns |  0.074 ns |  0.057 ns |    459.24 ns |  1.39 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    453.16 ns |  0.108 ns |  0.090 ns |    453.19 ns |  1.37 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    451.36 ns |  0.078 ns |  0.069 ns |    451.35 ns |  1.37 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    355.76 ns |  2.102 ns |  1.966 ns |    355.09 ns |  1.08 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    355.45 ns |  1.750 ns |  1.637 ns |    354.40 ns |  1.08 |    0.01 |
|                                               LinqToArray |           [50] |    604.05 ns |  0.969 ns |  0.906 ns |    604.16 ns |  1.83 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    553.00 ns |  0.229 ns |  0.203 ns |    553.00 ns |  1.67 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    553.36 ns |  0.235 ns |  0.209 ns |    553.30 ns |  1.68 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    456.56 ns |  0.141 ns |  0.125 ns |    456.53 ns |  1.38 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    457.04 ns |  0.168 ns |  0.149 ns |    457.02 ns |  1.38 |    0.00 |
|                                                      Take |           [50] |    364.11 ns |  0.058 ns |  0.051 ns |    364.11 ns |  1.10 |    0.00 |
|                                               LowCostTake |           [50] |    217.70 ns |  0.038 ns |  0.034 ns |    217.69 ns |  0.66 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    210.70 ns |  0.102 ns |  0.090 ns |    210.71 ns |  0.64 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    195.63 ns |  0.098 ns |  0.087 ns |    195.63 ns |  0.59 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    183.22 ns |  0.040 ns |  0.035 ns |    183.21 ns |  0.55 |    0.00 |
|                                            SkipTakeSingle |           [50] |    298.93 ns |  0.077 ns |  0.064 ns |    298.93 ns |  0.91 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    222.34 ns |  0.142 ns |  0.133 ns |    222.41 ns |  0.67 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    224.34 ns |  0.056 ns |  0.050 ns |    224.33 ns |  0.68 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    184.35 ns |  0.055 ns |  0.049 ns |    184.35 ns |  0.56 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    184.00 ns |  0.100 ns |  0.084 ns |    184.00 ns |  0.56 |    0.00 |
|                                           ForeachDelegate |           [50] |    403.10 ns |  0.075 ns |  0.067 ns |    403.11 ns |  1.22 |    0.00 |
|                                                   Foreach |           [50] |    330.29 ns |  0.068 ns |  0.057 ns |    330.29 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |              |       |         |
|                                                      **Linq** |            **[5]** |     **98.33 ns** |  **0.049 ns** |  **0.044 ns** |     **98.33 ns** |  **2.13** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     70.56 ns |  0.188 ns |  0.176 ns |     70.54 ns |  1.53 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     70.52 ns |  0.021 ns |  0.018 ns |     70.52 ns |  1.53 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     78.93 ns |  0.075 ns |  0.071 ns |     78.93 ns |  1.71 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     70.53 ns |  0.071 ns |  0.066 ns |     70.54 ns |  1.53 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     67.94 ns |  0.065 ns |  0.061 ns |     67.93 ns |  1.47 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     65.04 ns |  0.066 ns |  0.062 ns |     65.02 ns |  1.41 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |     94.22 ns |  0.178 ns |  0.139 ns |     94.19 ns |  2.04 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     94.11 ns |  0.050 ns |  0.045 ns |     94.11 ns |  2.04 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     81.06 ns |  0.078 ns |  0.073 ns |     81.07 ns |  1.75 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     80.56 ns |  0.084 ns |  0.078 ns |     80.57 ns |  1.74 |    0.00 |
|                                                 LinqCount |            [5] |     79.81 ns |  0.036 ns |  0.032 ns |     79.82 ns |  1.73 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     72.62 ns |  0.132 ns |  0.123 ns |     72.64 ns |  1.57 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     73.38 ns |  0.094 ns |  0.083 ns |     73.35 ns |  1.59 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     60.82 ns |  1.255 ns |  2.477 ns |     60.22 ns |  1.31 |    0.05 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     60.69 ns |  1.241 ns |  2.206 ns |     59.03 ns |  1.33 |    0.05 |
|                                               LinqToArray |            [5] |    118.86 ns |  0.111 ns |  0.099 ns |    118.84 ns |  2.57 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    101.64 ns |  0.066 ns |  0.061 ns |    101.63 ns |  2.20 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    101.59 ns |  0.079 ns |  0.073 ns |    101.58 ns |  2.20 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     91.29 ns |  0.026 ns |  0.022 ns |     91.28 ns |  1.97 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     92.17 ns |  0.149 ns |  0.140 ns |     92.14 ns |  1.99 |    0.00 |
|                                                      Take |            [5] |    146.68 ns |  0.032 ns |  0.025 ns |    146.67 ns |  3.17 |    0.00 |
|                                               LowCostTake |            [5] |     75.15 ns |  0.075 ns |  0.071 ns |     75.12 ns |  1.63 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     72.52 ns |  0.114 ns |  0.106 ns |     72.51 ns |  1.57 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     71.92 ns |  0.073 ns |  0.068 ns |     71.90 ns |  1.56 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     69.38 ns |  0.016 ns |  0.014 ns |     69.38 ns |  1.50 |    0.00 |
|                                            SkipTakeSingle |            [5] |    131.09 ns |  0.086 ns |  0.076 ns |    131.11 ns |  2.83 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     77.90 ns |  0.028 ns |  0.025 ns |     77.90 ns |  1.68 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     77.08 ns |  0.132 ns |  0.124 ns |     77.04 ns |  1.67 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     69.73 ns |  0.076 ns |  0.071 ns |     69.73 ns |  1.51 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     69.78 ns |  0.043 ns |  0.036 ns |     69.78 ns |  1.51 |    0.00 |
|                                           ForeachDelegate |            [5] |     54.36 ns |  0.024 ns |  0.020 ns |     54.36 ns |  1.18 |    0.00 |
|                                                   Foreach |            [5] |     46.24 ns |  0.039 ns |  0.035 ns |     46.25 ns |  1.00 |    0.00 |
