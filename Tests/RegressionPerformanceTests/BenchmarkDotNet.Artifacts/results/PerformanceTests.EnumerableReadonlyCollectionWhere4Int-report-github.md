``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |      Error |       StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **112.35 ns** |   **0.016 ns** |     **0.014 ns** |    **112.36 ns** |  **7.38** |    **0.09** |
|                                   LowCostLinqWithDelegate |            [0] |     45.51 ns |   0.012 ns |     0.011 ns |     45.51 ns |  2.99 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     41.25 ns |   0.012 ns |     0.011 ns |     41.24 ns |  2.71 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [0] |     72.16 ns |   0.019 ns |     0.016 ns |     72.15 ns |  4.74 |    0.06 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     67.54 ns |   0.021 ns |     0.018 ns |     67.54 ns |  4.43 |    0.06 |
|                                LowCostLinqWithStructWhere |            [0] |     62.68 ns |   0.017 ns |     0.015 ns |     62.68 ns |  4.11 |    0.05 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     56.98 ns |   0.012 ns |     0.011 ns |     56.98 ns |  3.74 |    0.05 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     56.10 ns |   0.013 ns |     0.011 ns |     56.10 ns |  3.68 |    0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     55.81 ns |   0.014 ns |     0.013 ns |     55.82 ns |  3.66 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     51.13 ns |   0.024 ns |     0.022 ns |     51.12 ns |  3.36 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     51.34 ns |   0.009 ns |     0.008 ns |     51.34 ns |  3.37 |    0.04 |
|                                                 LinqCount |            [0] |    102.74 ns |   0.080 ns |     0.075 ns |    102.70 ns |  6.75 |    0.09 |
|                              LowCostLinqWithDelegateCount |            [0] |     34.45 ns |   0.005 ns |     0.005 ns |     34.45 ns |  2.26 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.69 ns |   0.005 ns |     0.004 ns |     33.69 ns |  2.21 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |     47.13 ns |   0.017 ns |     0.015 ns |     47.13 ns |  3.09 |    0.04 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     46.88 ns |   0.006 ns |     0.005 ns |     46.88 ns |  3.08 |    0.04 |
|                                               LinqToArray |            [0] |    109.43 ns |   0.041 ns |     0.034 ns |    109.43 ns |  7.19 |    0.09 |
|                            LowCostLinqWithDelegateToArray |            [0] |     36.93 ns |   0.009 ns |     0.008 ns |     36.93 ns |  2.42 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     35.76 ns |   0.010 ns |     0.008 ns |     35.76 ns |  2.35 |    0.03 |
|                              LowCostLinqWithStructToArray |            [0] |     50.61 ns |   0.985 ns |     0.873 ns |     50.52 ns |  3.32 |    0.07 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     50.12 ns |   0.343 ns |     0.268 ns |     49.99 ns |  3.29 |    0.04 |
|                                                      Take |            [0] |    136.11 ns |   1.101 ns |     0.919 ns |    135.71 ns |  8.94 |    0.14 |
|                                               LowCostTake |            [0] |     55.02 ns |   0.385 ns |     0.360 ns |     55.01 ns |  3.62 |    0.06 |
|                                  LowCostTakeWithoutChecks |            [0] |     50.36 ns |   0.335 ns |     0.314 ns |     50.37 ns |  3.31 |    0.05 |
|                                     LowCostTakeWithStruct |            [0] |     71.61 ns |   0.095 ns |     0.088 ns |     71.60 ns |  4.70 |    0.06 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     74.09 ns |   0.671 ns |     0.628 ns |     74.04 ns |  4.87 |    0.05 |
|                                            SkipTakeSingle |            [0] |    154.78 ns |   1.395 ns |     1.305 ns |    154.66 ns | 10.17 |    0.15 |
|                                     LowCostSkipTakeSingle |            [0] |     50.88 ns |   0.103 ns |     0.080 ns |     50.88 ns |  3.34 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     51.15 ns |   0.100 ns |     0.084 ns |     51.16 ns |  3.36 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     67.05 ns |   0.625 ns |     0.584 ns |     66.82 ns |  4.40 |    0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     67.14 ns |   0.236 ns |     0.209 ns |     67.14 ns |  4.41 |    0.06 |
|                                           ForeachDelegate |            [0] |     16.52 ns |   0.130 ns |     0.115 ns |     16.47 ns |  1.08 |    0.02 |
|                                                   Foreach |            [0] |     15.22 ns |   0.208 ns |     0.195 ns |     15.23 ns |  1.00 |    0.00 |
|                                                           |                |              |            |              |              |       |         |
|                                                      **Linq** |         **[1000]** | **22,136.60 ns** | **439.173 ns** | **1,060.653 ns** | **22,197.25 ns** |  **3.61** |    **0.17** |
|                                   LowCostLinqWithDelegate |         [1000] | 13,244.79 ns |  33.071 ns |    30.935 ns | 13,230.07 ns |  2.13 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 13,499.80 ns |  50.280 ns |    44.572 ns | 13,489.86 ns |  2.17 |    0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 13,967.66 ns |   2.991 ns |     2.335 ns | 13,968.55 ns |  2.24 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 13,974.65 ns |  10.512 ns |     9.319 ns | 13,976.29 ns |  2.24 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  7,058.82 ns |  19.641 ns |    17.412 ns |  7,055.48 ns |  1.13 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  7,506.04 ns |   3.957 ns |     3.508 ns |  7,506.59 ns |  1.21 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 15,587.21 ns |  16.960 ns |    15.035 ns | 15,579.41 ns |  2.50 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 16,069.02 ns |  17.995 ns |    15.027 ns | 16,066.58 ns |  2.58 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,627.88 ns |   2.802 ns |     2.340 ns |  9,627.20 ns |  1.55 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  9,627.29 ns |   6.046 ns |     5.049 ns |  9,625.94 ns |  1.55 |    0.00 |
|                                                 LinqCount |         [1000] | 19,225.99 ns | 551.557 ns | 1,626.279 ns | 19,144.06 ns |  3.26 |    0.24 |
|                              LowCostLinqWithDelegateCount |         [1000] | 12,774.80 ns |   5.610 ns |     4.973 ns | 12,774.84 ns |  2.05 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 12,761.13 ns |  12.816 ns |    10.006 ns | 12,759.05 ns |  2.05 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  6,494.57 ns |   1.665 ns |     1.476 ns |  6,494.26 ns |  1.04 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  6,504.09 ns |  11.922 ns |     9.955 ns |  6,499.28 ns |  1.04 |    0.00 |
|                                               LinqToArray |         [1000] | 18,435.76 ns | 361.697 ns |   573.690 ns | 18,504.73 ns |  2.98 |    0.10 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 13,931.26 ns |  77.812 ns |    72.786 ns | 13,946.59 ns |  2.24 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 14,048.70 ns | 273.535 ns |   268.648 ns | 13,901.05 ns |  2.26 |    0.04 |
|                              LowCostLinqWithStructToArray |         [1000] |  7,503.22 ns |  62.581 ns |    58.538 ns |  7,508.74 ns |  1.21 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  7,464.94 ns |  61.123 ns |    54.184 ns |  7,468.27 ns |  1.20 |    0.01 |
|                                                      Take |         [1000] |    624.22 ns |   6.427 ns |     6.012 ns |    623.99 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    357.05 ns |   3.048 ns |     2.852 ns |    356.86 ns |  0.06 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    344.79 ns |   1.590 ns |     1.410 ns |    343.89 ns |  0.06 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    212.68 ns |   0.731 ns |     0.683 ns |    212.73 ns |  0.03 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    218.69 ns |   1.599 ns |     1.496 ns |    218.19 ns |  0.04 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    550.14 ns |   9.851 ns |     8.733 ns |    546.27 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    363.97 ns |   1.632 ns |     1.526 ns |    363.33 ns |  0.06 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    363.41 ns |   1.345 ns |     1.258 ns |    363.46 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    260.11 ns |   2.007 ns |     1.877 ns |    260.07 ns |  0.04 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    260.33 ns |   4.282 ns |     4.006 ns |    259.66 ns |  0.04 |    0.00 |
|                                           ForeachDelegate |         [1000] | 12,577.55 ns | 122.427 ns |   114.518 ns | 12,582.08 ns |  2.02 |    0.02 |
|                                                   Foreach |         [1000] |  6,226.86 ns |   5.664 ns |     4.730 ns |  6,224.51 ns |  1.00 |    0.00 |
|                                                           |                |              |            |              |              |       |         |
|                                                      **Linq** |           **[50]** |  **1,139.79 ns** |  **21.854 ns** |    **24.291 ns** |  **1,135.19 ns** |  **3.43** |    **0.06** |
|                                   LowCostLinqWithDelegate |           [50] |    742.21 ns |   2.020 ns |     1.889 ns |    741.76 ns |  2.24 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    733.20 ns |  12.013 ns |    11.237 ns |    723.43 ns |  2.22 |    0.03 |
|                                  LowCostLinqWithDelegate2 |           [50] |    764.81 ns |   5.057 ns |     4.730 ns |    765.91 ns |  2.31 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    767.67 ns |   0.356 ns |     0.297 ns |    767.60 ns |  2.32 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    415.65 ns |   1.436 ns |     1.343 ns |    415.75 ns |  1.26 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    419.84 ns |   3.435 ns |     3.045 ns |    419.35 ns |  1.27 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    843.93 ns |   3.284 ns |     2.742 ns |    843.42 ns |  2.55 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    854.15 ns |  14.435 ns |    13.502 ns |    845.55 ns |  2.57 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    581.44 ns |   4.600 ns |     4.303 ns |    579.11 ns |  1.76 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    575.31 ns |   0.689 ns |     0.611 ns |    575.12 ns |  1.74 |    0.00 |
|                                                 LinqCount |           [50] |  1,049.99 ns |  21.027 ns |    39.494 ns |  1,056.73 ns |  3.09 |    0.09 |
|                              LowCostLinqWithDelegateCount |           [50] |    677.85 ns |   3.855 ns |     3.606 ns |    676.74 ns |  2.05 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    668.44 ns |   4.444 ns |     4.157 ns |    668.73 ns |  2.02 |    0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |    371.68 ns |   2.127 ns |     1.886 ns |    370.93 ns |  1.12 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    370.46 ns |   0.399 ns |     0.311 ns |    370.39 ns |  1.12 |    0.00 |
|                                               LinqToArray |           [50] |  1,106.82 ns |  17.324 ns |    16.205 ns |  1,105.29 ns |  3.34 |    0.05 |
|                            LowCostLinqWithDelegateToArray |           [50] |    836.30 ns |   2.265 ns |     1.892 ns |    835.37 ns |  2.53 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    846.53 ns |   5.358 ns |     5.012 ns |    845.65 ns |  2.56 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    491.89 ns |   6.802 ns |     6.363 ns |    491.80 ns |  1.49 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    490.69 ns |   7.182 ns |     6.718 ns |    491.83 ns |  1.49 |    0.02 |
|                                                      Take |           [50] |    635.49 ns |  10.279 ns |     9.615 ns |    634.45 ns |  1.92 |    0.03 |
|                                               LowCostTake |           [50] |    358.39 ns |   2.132 ns |     1.994 ns |    357.32 ns |  1.08 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    344.66 ns |   0.364 ns |     0.304 ns |    344.68 ns |  1.04 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    213.10 ns |   0.268 ns |     0.251 ns |    213.07 ns |  0.64 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    214.56 ns |   0.137 ns |     0.114 ns |    214.54 ns |  0.65 |    0.00 |
|                                            SkipTakeSingle |           [50] |    553.28 ns |   8.858 ns |     8.286 ns |    554.41 ns |  1.67 |    0.03 |
|                                     LowCostSkipTakeSingle |           [50] |    364.27 ns |   0.177 ns |     0.148 ns |    364.24 ns |  1.10 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    360.34 ns |   0.523 ns |     0.489 ns |    360.33 ns |  1.09 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    257.25 ns |   2.674 ns |     2.501 ns |    257.45 ns |  0.78 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    254.20 ns |   0.188 ns |     0.157 ns |    254.24 ns |  0.77 |    0.00 |
|                                           ForeachDelegate |           [50] |    630.99 ns |   0.852 ns |     0.755 ns |    631.01 ns |  1.91 |    0.00 |
|                                                   Foreach |           [50] |    331.09 ns |   0.101 ns |     0.085 ns |    331.06 ns |  1.00 |    0.00 |
|                                                           |                |              |            |              |              |       |         |
|                                                      **Linq** |            **[5]** |    **218.65 ns** |   **1.063 ns** |     **0.887 ns** |    **218.67 ns** |  **4.74** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |    114.99 ns |   0.478 ns |     0.447 ns |    114.98 ns |  2.50 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    115.01 ns |   0.610 ns |     0.509 ns |    115.12 ns |  2.50 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |    144.82 ns |   0.916 ns |     0.765 ns |    144.80 ns |  3.14 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    143.23 ns |   2.192 ns |     2.051 ns |    142.27 ns |  3.11 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |     86.98 ns |   0.628 ns |     0.525 ns |     86.76 ns |  1.89 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     84.58 ns |   1.134 ns |     1.061 ns |     84.42 ns |  1.84 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    158.40 ns |   1.784 ns |     1.669 ns |    158.55 ns |  3.44 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    157.46 ns |   0.988 ns |     0.925 ns |    157.46 ns |  3.42 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    111.03 ns |   1.433 ns |     1.270 ns |    111.23 ns |  2.41 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    100.15 ns |   0.015 ns |     0.012 ns |    100.14 ns |  2.17 |    0.00 |
|                                                 LinqCount |            [5] |    197.93 ns |   0.297 ns |     0.278 ns |    197.86 ns |  4.30 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |    105.36 ns |   0.098 ns |     0.082 ns |    105.34 ns |  2.29 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    107.04 ns |   0.034 ns |     0.030 ns |    107.04 ns |  2.32 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     74.25 ns |   0.020 ns |     0.018 ns |     74.25 ns |  1.61 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     74.17 ns |   0.166 ns |     0.155 ns |     74.19 ns |  1.61 |    0.00 |
|                                               LinqToArray |            [5] |    243.15 ns |   0.755 ns |     0.706 ns |    243.05 ns |  5.28 |    0.02 |
|                            LowCostLinqWithDelegateToArray |            [5] |    131.76 ns |   0.132 ns |     0.123 ns |    131.72 ns |  2.86 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    134.88 ns |   0.094 ns |     0.083 ns |    134.89 ns |  2.93 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    113.20 ns |   0.031 ns |     0.026 ns |    113.21 ns |  2.46 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    107.61 ns |   0.031 ns |     0.028 ns |    107.61 ns |  2.34 |    0.00 |
|                                                      Take |            [5] |    273.19 ns |   1.433 ns |     1.197 ns |    273.39 ns |  5.93 |    0.03 |
|                                               LowCostTake |            [5] |    139.23 ns |   0.118 ns |     0.105 ns |    139.18 ns |  3.02 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    121.62 ns |   0.174 ns |     0.163 ns |    121.58 ns |  2.64 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     96.84 ns |   0.054 ns |     0.050 ns |     96.84 ns |  2.10 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     96.06 ns |   0.035 ns |     0.031 ns |     96.05 ns |  2.08 |    0.00 |
|                                            SkipTakeSingle |            [5] |    257.85 ns |   0.806 ns |     0.673 ns |    257.84 ns |  5.60 |    0.02 |
|                                     LowCostSkipTakeSingle |            [5] |    127.79 ns |   0.079 ns |     0.070 ns |    127.78 ns |  2.77 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    125.96 ns |   0.033 ns |     0.029 ns |    125.96 ns |  2.73 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    104.47 ns |   0.162 ns |     0.152 ns |    104.52 ns |  2.27 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    104.34 ns |   0.076 ns |     0.071 ns |    104.33 ns |  2.26 |    0.00 |
|                                           ForeachDelegate |            [5] |     83.51 ns |   0.248 ns |     0.232 ns |     83.57 ns |  1.81 |    0.01 |
|                                                   Foreach |            [5] |     46.08 ns |   0.050 ns |     0.047 ns |     46.08 ns |  1.00 |    0.00 |
