``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |     Error |    StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|----------:|----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **61.50 ns** |  **0.012 ns** |  **0.011 ns** |     **61.50 ns** |  **4.16** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     36.97 ns |  0.071 ns |  0.059 ns |     37.00 ns |  2.50 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     28.76 ns |  0.010 ns |  0.009 ns |     28.76 ns |  1.95 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     49.52 ns |  0.014 ns |  0.013 ns |     49.52 ns |  3.35 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     47.73 ns |  0.008 ns |  0.007 ns |     47.73 ns |  3.23 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     48.56 ns |  0.014 ns |  0.013 ns |     48.56 ns |  3.28 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     42.30 ns |  0.012 ns |  0.010 ns |     42.29 ns |  2.86 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     42.64 ns |  0.029 ns |  0.025 ns |     42.63 ns |  2.88 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     41.85 ns |  0.014 ns |  0.012 ns |     41.84 ns |  2.83 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     39.88 ns |  0.007 ns |  0.006 ns |     39.88 ns |  2.70 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     37.71 ns |  0.010 ns |  0.008 ns |     37.70 ns |  2.55 |    0.00 |
|                                                 LinqCount |            [0] |     59.41 ns |  0.008 ns |  0.006 ns |     59.41 ns |  4.02 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     28.31 ns |  0.021 ns |  0.016 ns |     28.30 ns |  1.91 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     30.53 ns |  0.369 ns |  0.346 ns |     30.33 ns |  2.06 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     33.07 ns |  0.014 ns |  0.012 ns |     33.07 ns |  2.24 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     33.41 ns |  0.025 ns |  0.021 ns |     33.42 ns |  2.26 |    0.00 |
|                                               LinqToArray |            [0] |     58.52 ns |  0.044 ns |  0.039 ns |     58.51 ns |  3.96 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     31.40 ns |  0.109 ns |  0.102 ns |     31.44 ns |  2.12 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     30.88 ns |  0.018 ns |  0.014 ns |     30.87 ns |  2.09 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     35.35 ns |  0.031 ns |  0.029 ns |     35.34 ns |  2.39 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     36.79 ns |  0.017 ns |  0.015 ns |     36.80 ns |  2.49 |    0.00 |
|                                                      Take |            [0] |     84.99 ns |  0.029 ns |  0.025 ns |     84.99 ns |  5.75 |    0.00 |
|                                               LowCostTake |            [0] |     40.44 ns |  0.008 ns |  0.007 ns |     40.44 ns |  2.74 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     36.90 ns |  0.003 ns |  0.003 ns |     36.90 ns |  2.50 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     54.86 ns |  0.007 ns |  0.006 ns |     54.86 ns |  3.71 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     52.57 ns |  0.062 ns |  0.055 ns |     52.59 ns |  3.56 |    0.00 |
|                                            SkipTakeSingle |            [0] |    103.97 ns |  0.020 ns |  0.017 ns |    103.97 ns |  7.03 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     43.94 ns |  0.052 ns |  0.046 ns |     43.96 ns |  2.97 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     42.26 ns |  0.007 ns |  0.006 ns |     42.26 ns |  2.86 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     50.55 ns |  0.026 ns |  0.023 ns |     50.55 ns |  3.42 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     50.75 ns |  0.012 ns |  0.010 ns |     50.75 ns |  3.43 |    0.00 |
|                                           ForeachDelegate |            [0] |     15.82 ns |  0.014 ns |  0.012 ns |     15.81 ns |  1.07 |    0.00 |
|                                                   Foreach |            [0] |     14.78 ns |  0.006 ns |  0.005 ns |     14.78 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |              |       |         |
|                                                      **Linq** |         **[1000]** | **14,217.84 ns** |  **4.096 ns** |  **3.631 ns** | **14,215.58 ns** |  **2.28** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 10,594.61 ns |  2.114 ns |  1.874 ns | 10,594.01 ns |  1.70 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,108.61 ns |  1.383 ns |  1.080 ns | 10,108.64 ns |  1.62 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 10,539.39 ns |  9.448 ns |  8.838 ns | 10,539.30 ns |  1.69 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 10,370.63 ns |  4.116 ns |  3.649 ns | 10,369.14 ns |  1.67 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,249.40 ns |  3.307 ns |  2.762 ns |  7,248.16 ns |  1.16 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  7,735.23 ns |  2.976 ns |  2.638 ns |  7,736.12 ns |  1.24 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 12,937.88 ns |  2.042 ns |  1.811 ns | 12,938.26 ns |  2.08 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 12,469.28 ns |  4.459 ns |  3.953 ns | 12,468.98 ns |  2.00 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,855.65 ns |  2.338 ns |  2.073 ns |  9,855.76 ns |  1.58 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,846.74 ns |  3.144 ns |  2.787 ns |  9,846.25 ns |  1.58 |    0.00 |
|                                                 LinqCount |         [1000] | 10,835.16 ns |  4.113 ns |  3.646 ns | 10,835.92 ns |  1.74 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  9,588.91 ns |  9.749 ns |  7.612 ns |  9,589.29 ns |  1.54 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  9,589.88 ns |  1.495 ns |  1.325 ns |  9,589.57 ns |  1.54 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,477.68 ns |  3.091 ns |  2.581 ns |  6,477.50 ns |  1.04 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,479.55 ns |  3.073 ns |  2.724 ns |  6,478.76 ns |  1.04 |    0.00 |
|                                               LinqToArray |         [1000] | 11,799.97 ns | 20.179 ns | 18.876 ns | 11,800.09 ns |  1.90 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,399.50 ns |  4.519 ns |  4.006 ns | 11,399.48 ns |  1.83 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,395.39 ns |  4.428 ns |  3.698 ns | 11,396.38 ns |  1.83 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,286.81 ns | 10.808 ns | 10.110 ns |  7,288.14 ns |  1.17 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,282.02 ns |  8.816 ns |  8.246 ns |  7,283.30 ns |  1.17 |    0.00 |
|                                                      Take |         [1000] |    457.95 ns |  0.111 ns |  0.093 ns |    457.95 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    245.28 ns |  0.143 ns |  0.127 ns |    245.27 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    250.86 ns |  0.111 ns |  0.092 ns |    250.85 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    200.39 ns |  0.117 ns |  0.104 ns |    200.35 ns |  0.03 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    188.10 ns |  0.056 ns |  0.049 ns |    188.09 ns |  0.03 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    378.61 ns |  0.056 ns |  0.047 ns |    378.61 ns |  0.06 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    252.42 ns |  0.095 ns |  0.084 ns |    252.43 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    250.29 ns |  0.098 ns |  0.087 ns |    250.28 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    194.41 ns |  0.050 ns |  0.039 ns |    194.42 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    191.56 ns |  0.074 ns |  0.066 ns |    191.56 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] |  9,322.75 ns |  0.389 ns |  0.344 ns |  9,322.71 ns |  1.50 |    0.00 |
|                                                   Foreach |         [1000] |  6,225.07 ns |  0.467 ns |  0.414 ns |  6,225.07 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |              |       |         |
|                                                      **Linq** |           **[50]** |    **774.15 ns** |  **0.161 ns** |  **0.142 ns** |    **774.17 ns** |  **2.34** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    562.86 ns |  0.154 ns |  0.136 ns |    562.86 ns |  1.70 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    542.66 ns |  0.144 ns |  0.127 ns |    542.62 ns |  1.64 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    563.82 ns |  0.129 ns |  0.114 ns |    563.83 ns |  1.71 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    575.46 ns |  1.003 ns |  0.938 ns |    574.86 ns |  1.74 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    406.28 ns |  0.081 ns |  0.068 ns |    406.29 ns |  1.23 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    416.19 ns |  0.056 ns |  0.047 ns |    416.19 ns |  1.26 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    694.20 ns |  0.127 ns |  0.112 ns |    694.18 ns |  2.10 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    668.73 ns |  0.213 ns |  0.189 ns |    668.72 ns |  2.02 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    548.98 ns |  0.276 ns |  0.245 ns |    548.98 ns |  1.66 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    544.86 ns |  0.310 ns |  0.275 ns |    544.78 ns |  1.65 |    0.00 |
|                                                 LinqCount |           [50] |    604.18 ns |  0.670 ns |  0.594 ns |    604.27 ns |  1.83 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    527.21 ns |  0.179 ns |  0.150 ns |    527.24 ns |  1.60 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    530.97 ns |  0.129 ns |  0.108 ns |    530.99 ns |  1.61 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    356.01 ns |  0.246 ns |  0.230 ns |    355.91 ns |  1.08 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    356.60 ns |  0.412 ns |  0.386 ns |    356.59 ns |  1.08 |    0.00 |
|                                               LinqToArray |           [50] |    753.62 ns |  0.362 ns |  0.302 ns |    753.64 ns |  2.28 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    639.06 ns |  0.510 ns |  0.452 ns |    639.07 ns |  1.93 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    632.11 ns |  0.530 ns |  0.470 ns |    632.10 ns |  1.91 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    490.93 ns |  0.694 ns |  0.649 ns |    490.60 ns |  1.49 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    458.21 ns |  0.094 ns |  0.083 ns |    458.21 ns |  1.39 |    0.00 |
|                                                      Take |           [50] |    457.97 ns |  0.065 ns |  0.054 ns |    457.97 ns |  1.39 |    0.00 |
|                                               LowCostTake |           [50] |    245.47 ns |  0.134 ns |  0.119 ns |    245.49 ns |  0.74 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    251.00 ns |  0.215 ns |  0.191 ns |    250.97 ns |  0.76 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    204.95 ns |  0.032 ns |  0.028 ns |    204.95 ns |  0.62 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    191.12 ns |  0.039 ns |  0.034 ns |    191.11 ns |  0.58 |    0.00 |
|                                            SkipTakeSingle |           [50] |    382.06 ns |  0.067 ns |  0.056 ns |    382.07 ns |  1.16 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    252.37 ns |  0.076 ns |  0.067 ns |    252.38 ns |  0.76 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    251.69 ns |  0.133 ns |  0.118 ns |    251.67 ns |  0.76 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    191.85 ns |  0.080 ns |  0.071 ns |    191.86 ns |  0.58 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    191.14 ns |  0.094 ns |  0.083 ns |    191.13 ns |  0.58 |    0.00 |
|                                           ForeachDelegate |           [50] |    475.43 ns |  0.124 ns |  0.110 ns |    475.45 ns |  1.44 |    0.00 |
|                                                   Foreach |           [50] |    330.29 ns |  0.056 ns |  0.050 ns |    330.27 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |              |       |         |
|                                                      **Linq** |            **[5]** |    **143.97 ns** |  **0.036 ns** |  **0.032 ns** |    **143.97 ns** |  **3.12** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     91.73 ns |  0.030 ns |  0.025 ns |     91.72 ns |  1.99 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     87.05 ns |  0.023 ns |  0.021 ns |     87.05 ns |  1.89 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    101.94 ns |  0.099 ns |  0.092 ns |    101.90 ns |  2.21 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    105.28 ns |  0.060 ns |  0.053 ns |    105.27 ns |  2.28 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     72.05 ns |  0.021 ns |  0.017 ns |     72.05 ns |  1.56 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     68.49 ns |  0.065 ns |  0.060 ns |     68.50 ns |  1.49 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    104.59 ns |  0.075 ns |  0.070 ns |    104.59 ns |  2.27 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    104.44 ns |  0.082 ns |  0.069 ns |    104.42 ns |  2.27 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     95.27 ns |  0.113 ns |  0.106 ns |     95.29 ns |  2.07 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     88.67 ns |  0.143 ns |  0.133 ns |     88.67 ns |  1.92 |    0.00 |
|                                                 LinqCount |            [5] |    120.74 ns |  0.045 ns |  0.035 ns |    120.73 ns |  2.62 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     76.12 ns |  0.027 ns |  0.023 ns |     76.12 ns |  1.65 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     79.23 ns |  0.091 ns |  0.085 ns |     79.22 ns |  1.72 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     62.39 ns |  0.263 ns |  0.246 ns |     62.26 ns |  1.35 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     61.38 ns |  0.069 ns |  0.061 ns |     61.38 ns |  1.33 |    0.00 |
|                                               LinqToArray |            [5] |    157.03 ns |  0.157 ns |  0.147 ns |    157.01 ns |  3.41 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    107.29 ns |  0.072 ns |  0.064 ns |    107.27 ns |  2.33 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    107.42 ns |  0.070 ns |  0.062 ns |    107.41 ns |  2.33 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     96.79 ns |  0.032 ns |  0.029 ns |     96.78 ns |  2.10 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     95.31 ns |  0.017 ns |  0.013 ns |     95.31 ns |  2.07 |    0.00 |
|                                                      Take |            [5] |    186.65 ns |  0.040 ns |  0.034 ns |    186.64 ns |  4.05 |    0.00 |
|                                               LowCostTake |            [5] |     91.68 ns |  0.083 ns |  0.073 ns |     91.68 ns |  1.99 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     91.45 ns |  0.115 ns |  0.102 ns |     91.49 ns |  1.98 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     78.79 ns |  0.070 ns |  0.062 ns |     78.77 ns |  1.71 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     77.17 ns |  0.032 ns |  0.028 ns |     77.16 ns |  1.67 |    0.00 |
|                                            SkipTakeSingle |            [5] |    178.81 ns |  0.305 ns |  0.286 ns |    178.86 ns |  3.88 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     90.62 ns |  1.211 ns |  1.073 ns |     90.96 ns |  1.97 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     88.44 ns |  1.796 ns |  4.163 ns |     85.22 ns |  1.91 |    0.09 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     78.73 ns |  0.667 ns |  0.624 ns |     78.39 ns |  1.71 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     82.62 ns |  0.051 ns |  0.045 ns |     82.62 ns |  1.79 |    0.00 |
|                                           ForeachDelegate |            [5] |     61.28 ns |  0.135 ns |  0.126 ns |     61.29 ns |  1.33 |    0.00 |
|                                                   Foreach |            [5] |     46.11 ns |  0.044 ns |  0.041 ns |     46.10 ns |  1.00 |    0.00 |
