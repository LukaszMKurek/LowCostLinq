``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |          Mean |       Error |        StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **58.983 ns** |   **0.0195 ns** |     **0.0173 ns** |  **7.87** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     21.333 ns |   0.0005 ns |     0.0005 ns |  2.85 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     16.749 ns |   0.0058 ns |     0.0052 ns |  2.23 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     46.665 ns |   0.0040 ns |     0.0037 ns |  6.22 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     45.008 ns |   0.0016 ns |     0.0015 ns |  6.00 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     35.274 ns |   0.0125 ns |     0.0111 ns |  4.71 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     35.955 ns |   0.0050 ns |     0.0046 ns |  4.80 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     31.423 ns |   0.0092 ns |     0.0077 ns |  4.19 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     30.025 ns |   0.0294 ns |     0.0245 ns |  4.00 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     30.129 ns |   0.0168 ns |     0.0149 ns |  4.02 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     29.775 ns |   0.0046 ns |     0.0036 ns |  3.97 |    0.00 |
|                                                 LinqCount |            [0] |     58.509 ns |   0.0334 ns |     0.0296 ns |  7.80 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     13.401 ns |   0.0014 ns |     0.0014 ns |  1.79 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     13.534 ns |   0.0024 ns |     0.0019 ns |  1.81 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     25.943 ns |   0.0583 ns |     0.0517 ns |  3.46 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     25.954 ns |   0.0552 ns |     0.0461 ns |  3.46 |    0.01 |
|                                               LinqToArray |            [0] |     58.612 ns |   0.2707 ns |     0.2261 ns |  7.82 |    0.03 |
|                            LowCostLinqWithDelegateToArray |            [0] |     13.966 ns |   0.0089 ns |     0.0083 ns |  1.86 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     14.132 ns |   0.1236 ns |     0.0965 ns |  1.89 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     28.137 ns |   0.0251 ns |     0.0210 ns |  3.75 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     28.072 ns |   0.0072 ns |     0.0056 ns |  3.74 |    0.00 |
|                                                      Take |            [0] |     81.889 ns |   0.0277 ns |     0.0216 ns | 10.92 |    0.01 |
|                                               LowCostTake |            [0] |     30.765 ns |   0.0091 ns |     0.0076 ns |  4.10 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     29.484 ns |   0.0146 ns |     0.0122 ns |  3.93 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     42.725 ns |   0.0039 ns |     0.0032 ns |  5.70 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     43.191 ns |   0.0203 ns |     0.0190 ns |  5.76 |    0.00 |
|                                            SkipTakeSingle |            [0] |    103.257 ns |   0.0163 ns |     0.0144 ns | 13.77 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     28.122 ns |   0.0025 ns |     0.0021 ns |  3.75 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     27.751 ns |   0.0027 ns |     0.0023 ns |  3.70 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     44.785 ns |   0.0017 ns |     0.0016 ns |  5.97 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     44.461 ns |   0.0018 ns |     0.0017 ns |  5.93 |    0.00 |
|                                           ForeachDelegate |            [0] |      9.257 ns |   0.0103 ns |     0.0096 ns |  1.23 |    0.00 |
|                                                   Foreach |            [0] |      7.497 ns |   0.0044 ns |     0.0041 ns |  1.00 |    0.00 |
|                                                           |                |               |             |               |       |         |
|                                                      **Linq** |         **[1000]** | **12,554.059 ns** | **248.4148 ns** |   **663.0695 ns** |  **3.46** |    **0.21** |
|                                   LowCostLinqWithDelegate |         [1000] |  5,317.069 ns |   0.7925 ns |     0.7413 ns |  1.48 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,544.339 ns |   0.3943 ns |     0.3078 ns |  1.54 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  5,812.729 ns |   1.3713 ns |     1.1451 ns |  1.62 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  5,334.057 ns |   1.5971 ns |     1.4939 ns |  1.48 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,253.242 ns |   0.8495 ns |     0.7947 ns |  0.35 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,244.049 ns |   0.2368 ns |     0.2215 ns |  0.35 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  7,692.656 ns |   1.6896 ns |     1.4978 ns |  2.14 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  7,696.727 ns |   4.8064 ns |     4.2608 ns |  2.14 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,142.378 ns |   0.2773 ns |     0.2165 ns |  0.87 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,142.269 ns |   1.7862 ns |     1.5834 ns |  0.87 |    0.00 |
|                                                 LinqCount |         [1000] |  8,919.825 ns | 196.2670 ns |   578.6976 ns |  2.44 |    0.17 |
|                              LowCostLinqWithDelegateCount |         [1000] |  4,786.545 ns |   0.2565 ns |     0.2399 ns |  1.33 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  4,786.406 ns |   0.1969 ns |     0.1746 ns |  1.33 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    503.526 ns |   0.4830 ns |     0.4518 ns |  0.14 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    502.602 ns |   0.3337 ns |     0.3121 ns |  0.14 |    0.00 |
|                                               LinqToArray |         [1000] |  8,366.830 ns | 163.9776 ns |   175.4542 ns |  2.32 |    0.05 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  6,309.448 ns |   4.7611 ns |     4.4535 ns |  1.76 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  8,299.162 ns | 491.6483 ns | 1,449.6362 ns |  2.16 |    0.40 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,574.001 ns |   0.6443 ns |     0.5712 ns |  0.44 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,641.700 ns |   0.8308 ns |     0.6937 ns |  0.46 |    0.00 |
|                                                      Take |         [1000] |    406.560 ns |   2.6097 ns |     2.4411 ns |  0.11 |    0.00 |
|                                               LowCostTake |         [1000] |    141.159 ns |   0.0303 ns |     0.0269 ns |  0.04 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    144.420 ns |   0.0622 ns |     0.0582 ns |  0.04 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     71.539 ns |   0.0028 ns |     0.0024 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     70.438 ns |   0.0234 ns |     0.0219 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    311.107 ns |   2.3525 ns |     2.2005 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    145.288 ns |   0.2203 ns |     0.2061 ns |  0.04 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    146.054 ns |   0.2033 ns |     0.1901 ns |  0.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     65.620 ns |   0.0820 ns |     0.0767 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     66.142 ns |   0.0896 ns |     0.0838 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  7,895.468 ns |   0.4987 ns |     0.4165 ns |  2.20 |    0.00 |
|                                                   Foreach |         [1000] |  3,593.158 ns |   1.8924 ns |     1.7702 ns |  1.00 |    0.00 |
|                                                           |                |               |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **685.194 ns** |  **13.4734 ns** |    **20.1663 ns** |  **3.67** |    **0.13** |
|                                   LowCostLinqWithDelegate |           [50] |    285.479 ns |   0.0418 ns |     0.0391 ns |  1.54 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    295.761 ns |   0.1659 ns |     0.1552 ns |  1.60 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    333.725 ns |   0.2892 ns |     0.2705 ns |  1.80 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    313.945 ns |   0.0463 ns |     0.0433 ns |  1.70 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    105.618 ns |   0.0309 ns |     0.0289 ns |  0.57 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    103.352 ns |   0.0396 ns |     0.0370 ns |  0.56 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    422.005 ns |   0.0742 ns |     0.0658 ns |  2.28 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    422.780 ns |   0.1191 ns |     0.0930 ns |  2.28 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    191.435 ns |   0.0312 ns |     0.0276 ns |  1.03 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    189.659 ns |   0.0311 ns |     0.0259 ns |  1.02 |    0.00 |
|                                                 LinqCount |           [50] |    455.400 ns |   8.9055 ns |    10.6013 ns |  2.45 |    0.06 |
|                              LowCostLinqWithDelegateCount |           [50] |    267.325 ns |   0.0160 ns |     0.0142 ns |  1.44 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    267.504 ns |   0.0178 ns |     0.0139 ns |  1.44 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     46.924 ns |   0.0389 ns |     0.0364 ns |  0.25 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     45.713 ns |   0.0416 ns |     0.0369 ns |  0.25 |    0.00 |
|                                               LinqToArray |           [50] |    578.345 ns |   7.3309 ns |     6.8573 ns |  3.12 |    0.04 |
|                            LowCostLinqWithDelegateToArray |           [50] |    368.713 ns |   0.3612 ns |     0.3379 ns |  1.99 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    368.597 ns |   0.1037 ns |     0.0920 ns |  1.99 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    146.159 ns |   0.1050 ns |     0.0820 ns |  0.79 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    146.803 ns |   0.0671 ns |     0.0560 ns |  0.79 |    0.00 |
|                                                      Take |           [50] |    408.566 ns |   3.0807 ns |     2.8817 ns |  2.21 |    0.02 |
|                                               LowCostTake |           [50] |    141.965 ns |   0.1883 ns |     0.1761 ns |  0.77 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    141.391 ns |   0.0956 ns |     0.0894 ns |  0.76 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |     71.272 ns |   0.0025 ns |     0.0023 ns |  0.38 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     70.816 ns |   0.0214 ns |     0.0200 ns |  0.38 |    0.00 |
|                                            SkipTakeSingle |           [50] |    310.665 ns |   3.9012 ns |     3.6492 ns |  1.68 |    0.02 |
|                                     LowCostSkipTakeSingle |           [50] |    145.134 ns |   0.1971 ns |     0.1844 ns |  0.78 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    145.561 ns |   0.1887 ns |     0.1575 ns |  0.79 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     67.003 ns |   0.0882 ns |     0.0825 ns |  0.36 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     66.140 ns |   0.0995 ns |     0.0931 ns |  0.36 |    0.00 |
|                                           ForeachDelegate |           [50] |    410.309 ns |   0.0689 ns |     0.0611 ns |  2.22 |    0.00 |
|                                                   Foreach |           [50] |    185.144 ns |   0.0726 ns |     0.0643 ns |  1.00 |    0.00 |
|                                                           |                |               |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **119.954 ns** |   **0.2982 ns** |     **0.2789 ns** |  **4.29** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     48.600 ns |   0.0443 ns |     0.0392 ns |  1.74 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     43.304 ns |   0.0370 ns |     0.0328 ns |  1.55 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     70.614 ns |   0.1875 ns |     0.1754 ns |  2.53 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     67.616 ns |   0.0560 ns |     0.0496 ns |  2.42 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     41.935 ns |   0.0012 ns |     0.0011 ns |  1.50 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     42.163 ns |   0.0020 ns |     0.0016 ns |  1.51 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |     68.503 ns |   0.0684 ns |     0.0639 ns |  2.45 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     69.034 ns |   0.2514 ns |     0.2352 ns |  2.47 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     44.278 ns |   0.0215 ns |     0.0191 ns |  1.58 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     45.738 ns |   0.0974 ns |     0.0911 ns |  1.64 |    0.00 |
|                                                 LinqCount |            [5] |     99.527 ns |   0.3322 ns |     0.2945 ns |  3.56 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     37.201 ns |   0.0514 ns |     0.0481 ns |  1.33 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     37.612 ns |   0.0752 ns |     0.0704 ns |  1.35 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     27.549 ns |   0.0010 ns |     0.0009 ns |  0.99 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     27.561 ns |   0.0007 ns |     0.0006 ns |  0.99 |    0.00 |
|                                               LinqToArray |            [5] |    137.374 ns |   0.4023 ns |     0.3763 ns |  4.92 |    0.02 |
|                            LowCostLinqWithDelegateToArray |            [5] |     68.988 ns |   0.0611 ns |     0.0572 ns |  2.47 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     69.555 ns |   0.1433 ns |     0.1341 ns |  2.49 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     56.261 ns |   0.0111 ns |     0.0099 ns |  2.01 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     56.219 ns |   0.0409 ns |     0.0362 ns |  2.01 |    0.00 |
|                                                      Take |            [5] |    170.055 ns |   0.4352 ns |     0.4071 ns |  6.09 |    0.02 |
|                                               LowCostTake |            [5] |     51.646 ns |   0.0615 ns |     0.0545 ns |  1.85 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     51.427 ns |   0.0408 ns |     0.0382 ns |  1.84 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     51.923 ns |   0.0029 ns |     0.0027 ns |  1.86 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     51.100 ns |   0.0015 ns |     0.0014 ns |  1.83 |    0.00 |
|                                            SkipTakeSingle |            [5] |    152.012 ns |   0.2622 ns |     0.2325 ns |  5.44 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     50.438 ns |   0.0404 ns |     0.0358 ns |  1.81 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     51.325 ns |   0.1456 ns |     0.1216 ns |  1.84 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     47.304 ns |   0.0010 ns |     0.0009 ns |  1.69 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     47.062 ns |   0.0016 ns |     0.0014 ns |  1.68 |    0.00 |
|                                           ForeachDelegate |            [5] |     50.062 ns |   0.0385 ns |     0.0360 ns |  1.79 |    0.00 |
|                                                   Foreach |            [5] |     27.931 ns |   0.0589 ns |     0.0551 ns |  1.00 |    0.00 |
