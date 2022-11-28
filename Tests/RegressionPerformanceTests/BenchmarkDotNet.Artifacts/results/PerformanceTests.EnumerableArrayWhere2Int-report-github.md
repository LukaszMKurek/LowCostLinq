``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |         Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|----------:|----------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **36.490 ns** | **0.0494 ns** | **0.0462 ns** |  **4.87** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |    21.540 ns | 0.0011 ns | 0.0010 ns |  2.87 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    15.028 ns | 0.0046 ns | 0.0043 ns |  2.00 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |    34.255 ns | 0.0044 ns | 0.0039 ns |  4.57 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    34.319 ns | 0.0022 ns | 0.0021 ns |  4.58 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |    29.520 ns | 0.0009 ns | 0.0008 ns |  3.94 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    30.577 ns | 0.0032 ns | 0.0028 ns |  4.08 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    25.413 ns | 0.0075 ns | 0.0062 ns |  3.39 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    25.774 ns | 0.0129 ns | 0.0108 ns |  3.44 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    24.394 ns | 0.0054 ns | 0.0042 ns |  3.25 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    24.709 ns | 0.0205 ns | 0.0182 ns |  3.30 |    0.00 |
|                                                 LinqCount |            [0] |    33.249 ns | 0.0619 ns | 0.0549 ns |  4.44 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |    10.182 ns | 0.0010 ns | 0.0009 ns |  1.36 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    10.858 ns | 0.2307 ns | 0.2158 ns |  1.45 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |    18.554 ns | 0.0006 ns | 0.0006 ns |  2.48 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    18.995 ns | 0.0016 ns | 0.0015 ns |  2.53 |    0.00 |
|                                               LinqToArray |            [0] |    35.278 ns | 0.0095 ns | 0.0084 ns |  4.71 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |    12.658 ns | 0.0264 ns | 0.0247 ns |  1.69 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    12.745 ns | 0.0217 ns | 0.0203 ns |  1.70 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |    21.375 ns | 0.0020 ns | 0.0019 ns |  2.85 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    21.154 ns | 0.0028 ns | 0.0025 ns |  2.82 |    0.00 |
|                                                      Take |            [0] |    57.051 ns | 0.0277 ns | 0.0246 ns |  7.61 |    0.00 |
|                                               LowCostTake |            [0] |    27.053 ns | 0.0004 ns | 0.0004 ns |  3.61 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |    22.552 ns | 0.0004 ns | 0.0003 ns |  3.01 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |    36.915 ns | 0.0008 ns | 0.0007 ns |  4.92 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    36.643 ns | 0.0039 ns | 0.0036 ns |  4.89 |    0.00 |
|                                            SkipTakeSingle |            [0] |    79.393 ns | 0.0591 ns | 0.0524 ns | 10.59 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |    29.785 ns | 0.0023 ns | 0.0018 ns |  3.97 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    29.642 ns | 0.0061 ns | 0.0057 ns |  3.95 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    38.080 ns | 0.0020 ns | 0.0018 ns |  5.08 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    37.381 ns | 0.0023 ns | 0.0021 ns |  4.99 |    0.00 |
|                                           ForeachDelegate |            [0] |     7.697 ns | 0.0099 ns | 0.0093 ns |  1.03 |    0.00 |
|                                                   Foreach |            [0] |     7.496 ns | 0.0034 ns | 0.0031 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |       |         |
|                                                      **Linq** |         **[1000]** | **8,008.064 ns** | **4.0575 ns** | **3.5968 ns** |  **2.23** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,888.377 ns | 0.2194 ns | 0.2052 ns |  1.08 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,872.567 ns | 2.6961 ns | 2.5219 ns |  1.08 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 3,885.925 ns | 2.4244 ns | 2.2677 ns |  1.08 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,889.645 ns | 1.7931 ns | 1.6772 ns |  1.08 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,288.138 ns | 0.3960 ns | 0.3704 ns |  0.36 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,311.343 ns | 0.2525 ns | 0.2362 ns |  0.37 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 6,478.833 ns | 1.1423 ns | 0.9539 ns |  1.80 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 6,477.740 ns | 0.8027 ns | 0.7116 ns |  1.80 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,610.173 ns | 0.3019 ns | 0.2521 ns |  1.00 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,611.051 ns | 0.4097 ns | 0.3632 ns |  1.01 |    0.00 |
|                                                 LinqCount |         [1000] | 4,113.823 ns | 5.1197 ns | 4.5385 ns |  1.15 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,348.938 ns | 0.1278 ns | 0.1133 ns |  0.93 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 3,349.180 ns | 0.1493 ns | 0.1247 ns |  0.93 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   382.094 ns | 0.0178 ns | 0.0158 ns |  0.11 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   381.761 ns | 0.0226 ns | 0.0211 ns |  0.11 |    0.00 |
|                                               LinqToArray |         [1000] | 5,492.274 ns | 6.5113 ns | 6.0907 ns |  1.53 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 4,433.808 ns | 3.8570 ns | 3.4191 ns |  1.23 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 4,578.283 ns | 4.2697 ns | 3.3335 ns |  1.27 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,385.705 ns | 1.2073 ns | 1.0082 ns |  0.39 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,388.130 ns | 0.7079 ns | 0.6276 ns |  0.39 |    0.00 |
|                                                      Take |         [1000] |   314.456 ns | 0.1105 ns | 0.0922 ns |  0.09 |    0.00 |
|                                               LowCostTake |         [1000] |   108.767 ns | 0.0807 ns | 0.0716 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |   104.416 ns | 0.0245 ns | 0.0229 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    65.136 ns | 0.0147 ns | 0.0138 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    64.293 ns | 0.0043 ns | 0.0041 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   235.196 ns | 0.0655 ns | 0.0581 ns |  0.07 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   114.702 ns | 0.0385 ns | 0.0360 ns |  0.03 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   114.676 ns | 0.0279 ns | 0.0247 ns |  0.03 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    62.794 ns | 0.0096 ns | 0.0075 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    63.613 ns | 0.0420 ns | 0.0393 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] | 6,704.921 ns | 0.1495 ns | 0.1325 ns |  1.87 |    0.00 |
|                                                   Foreach |         [1000] | 3,592.614 ns | 1.3340 ns | 1.1825 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |       |         |
|                                                      **Linq** |           **[50]** |   **435.709 ns** | **0.2995 ns** | **0.2802 ns** |  **2.36** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |   217.623 ns | 0.0771 ns | 0.0721 ns |  1.18 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   209.493 ns | 0.0212 ns | 0.0188 ns |  1.13 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |   229.086 ns | 0.0321 ns | 0.0300 ns |  1.24 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   238.141 ns | 0.0194 ns | 0.0181 ns |  1.29 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    97.017 ns | 0.0472 ns | 0.0441 ns |  0.52 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |   101.407 ns | 0.0379 ns | 0.0336 ns |  0.55 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   353.291 ns | 0.0722 ns | 0.0640 ns |  1.91 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   352.324 ns | 0.0560 ns | 0.0497 ns |  1.91 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   208.309 ns | 0.1259 ns | 0.1052 ns |  1.13 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   207.706 ns | 0.1410 ns | 0.1250 ns |  1.12 |    0.00 |
|                                                 LinqCount |           [50] |   249.164 ns | 0.2022 ns | 0.1689 ns |  1.35 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |   182.038 ns | 0.0396 ns | 0.0370 ns |  0.98 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   182.215 ns | 0.0896 ns | 0.0794 ns |  0.99 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    37.908 ns | 0.0244 ns | 0.0204 ns |  0.21 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    37.287 ns | 0.0196 ns | 0.0164 ns |  0.20 |    0.00 |
|                                               LinqToArray |           [50] |   391.512 ns | 0.3362 ns | 0.3145 ns |  2.12 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |   294.515 ns | 0.3374 ns | 0.3156 ns |  1.59 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   293.800 ns | 0.2040 ns | 0.1593 ns |  1.59 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |   132.780 ns | 0.0425 ns | 0.0332 ns |  0.72 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   134.100 ns | 0.0458 ns | 0.0382 ns |  0.73 |    0.00 |
|                                                      Take |           [50] |   314.279 ns | 0.0560 ns | 0.0468 ns |  1.70 |    0.00 |
|                                               LowCostTake |           [50] |   108.798 ns | 0.1245 ns | 0.1165 ns |  0.59 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |   103.929 ns | 0.0257 ns | 0.0214 ns |  0.56 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    65.142 ns | 0.0113 ns | 0.0106 ns |  0.35 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    65.280 ns | 0.0100 ns | 0.0084 ns |  0.35 |    0.00 |
|                                            SkipTakeSingle |           [50] |   230.901 ns | 0.1776 ns | 0.1574 ns |  1.25 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |   114.676 ns | 0.0384 ns | 0.0360 ns |  0.62 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   116.193 ns | 0.0266 ns | 0.0236 ns |  0.63 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    62.777 ns | 0.0959 ns | 0.0897 ns |  0.34 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    63.534 ns | 0.0509 ns | 0.0476 ns |  0.34 |    0.00 |
|                                           ForeachDelegate |           [50] |   343.190 ns | 0.0807 ns | 0.0716 ns |  1.86 |    0.00 |
|                                                   Foreach |           [50] |   184.839 ns | 0.0270 ns | 0.0239 ns |  1.00 |    0.00 |
|                                                           |                |              |           |           |       |         |
|                                                      **Linq** |            **[5]** |    **81.666 ns** | **0.0278 ns** | **0.0246 ns** |  **2.92** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    38.556 ns | 0.0474 ns | 0.0443 ns |  1.38 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    34.157 ns | 0.0321 ns | 0.0300 ns |  1.22 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    50.309 ns | 0.0467 ns | 0.0414 ns |  1.80 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    51.360 ns | 0.0201 ns | 0.0188 ns |  1.84 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |    36.981 ns | 0.0021 ns | 0.0017 ns |  1.32 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    37.023 ns | 0.0057 ns | 0.0048 ns |  1.33 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    57.833 ns | 0.0356 ns | 0.0333 ns |  2.07 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    58.191 ns | 0.0726 ns | 0.0679 ns |  2.08 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    39.865 ns | 0.0765 ns | 0.0639 ns |  1.43 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    40.627 ns | 0.0349 ns | 0.0326 ns |  1.45 |    0.00 |
|                                                 LinqCount |            [5] |    64.295 ns | 0.0323 ns | 0.0269 ns |  2.30 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    26.767 ns | 0.0302 ns | 0.0283 ns |  0.96 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    26.932 ns | 0.0241 ns | 0.0226 ns |  0.96 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |    20.564 ns | 0.0009 ns | 0.0007 ns |  0.74 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    20.525 ns | 0.0009 ns | 0.0008 ns |  0.73 |    0.00 |
|                                               LinqToArray |            [5] |    96.065 ns | 0.0650 ns | 0.0608 ns |  3.44 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    61.263 ns | 0.0480 ns | 0.0426 ns |  2.19 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    61.526 ns | 0.0419 ns | 0.0371 ns |  2.20 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    49.122 ns | 0.0142 ns | 0.0126 ns |  1.76 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    48.930 ns | 0.0079 ns | 0.0070 ns |  1.75 |    0.00 |
|                                                      Take |            [5] |   130.751 ns | 0.1254 ns | 0.1112 ns |  4.68 |    0.01 |
|                                               LowCostTake |            [5] |    42.869 ns | 0.0319 ns | 0.0282 ns |  1.53 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    39.675 ns | 0.0374 ns | 0.0350 ns |  1.42 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |    45.253 ns | 0.0022 ns | 0.0020 ns |  1.62 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    44.343 ns | 0.0019 ns | 0.0017 ns |  1.59 |    0.00 |
|                                            SkipTakeSingle |            [5] |   117.870 ns | 0.0628 ns | 0.0557 ns |  4.22 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    43.458 ns | 0.0400 ns | 0.0354 ns |  1.56 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    43.536 ns | 0.0513 ns | 0.0479 ns |  1.56 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    41.014 ns | 0.0009 ns | 0.0008 ns |  1.47 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    41.217 ns | 0.0019 ns | 0.0017 ns |  1.48 |    0.00 |
|                                           ForeachDelegate |            [5] |    45.271 ns | 0.2028 ns | 0.1897 ns |  1.62 |    0.01 |
|                                                   Foreach |            [5] |    27.941 ns | 0.0304 ns | 0.0285 ns |  1.00 |    0.00 |
