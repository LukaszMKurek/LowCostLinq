``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **119.132 ns** |   **0.1884 ns** |   **0.1762 ns** |  **39.83** |     **0.06** |
|                                   LowCostLinqWithDelegate |              0 |     39.525 ns |   0.0387 ns |   0.0362 ns |  13.21 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     34.761 ns |   0.0192 ns |   0.0180 ns |  11.62 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     70.841 ns |   0.0062 ns |   0.0048 ns |  23.68 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     63.299 ns |   0.0037 ns |   0.0029 ns |  21.16 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     48.434 ns |   0.0131 ns |   0.0116 ns |  16.19 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     42.275 ns |   0.0207 ns |   0.0173 ns |  14.13 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     71.486 ns |   0.0600 ns |   0.0561 ns |  23.90 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     64.444 ns |   0.0446 ns |   0.0395 ns |  21.55 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     67.009 ns |   0.0244 ns |   0.0216 ns |  22.40 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     60.752 ns |   0.1026 ns |   0.0959 ns |  20.31 |     0.03 |
|                                                 LinqCount |              0 |    115.963 ns |   0.0965 ns |   0.0806 ns |  38.77 |     0.03 |
|                              LowCostLinqWithDelegateCount |              0 |     30.874 ns |   0.0262 ns |   0.0246 ns |  10.32 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     28.727 ns |   0.0029 ns |   0.0027 ns |   9.60 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     43.161 ns |   0.0259 ns |   0.0242 ns |  14.43 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     34.850 ns |   0.0051 ns |   0.0040 ns |  11.65 |     0.00 |
|                                               LinqToArray |              0 |    125.372 ns |   0.1445 ns |   0.1352 ns |  41.92 |     0.04 |
|                            LowCostLinqWithDelegateToArray |              0 |     33.432 ns |   0.0078 ns |   0.0065 ns |  11.18 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     31.804 ns |   0.0167 ns |   0.0139 ns |  10.63 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     45.190 ns |   0.0092 ns |   0.0086 ns |  15.11 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     38.493 ns |   0.0064 ns |   0.0050 ns |  12.87 |     0.00 |
|                                                      Take |              0 |    154.649 ns |   0.1985 ns |   0.1857 ns |  51.70 |     0.06 |
|                                               LowCostTake |              0 |     52.926 ns |   0.1781 ns |   0.1666 ns |  17.69 |     0.05 |
|                                  LowCostTakeWithoutChecks |              0 |     44.968 ns |   0.0167 ns |   0.0156 ns |  15.03 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     63.133 ns |   0.0090 ns |   0.0080 ns |  21.11 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     55.983 ns |   0.0089 ns |   0.0074 ns |  18.72 |     0.00 |
|                                            SkipTakeSingle |              0 |    176.483 ns |   0.2212 ns |   0.2069 ns |  59.00 |     0.07 |
|                                     LowCostSkipTakeSingle |              0 |     61.635 ns |   0.0082 ns |   0.0072 ns |  20.61 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     60.129 ns |   0.0090 ns |   0.0085 ns |  20.10 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     74.153 ns |   0.0070 ns |   0.0065 ns |  24.79 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     66.332 ns |   0.0521 ns |   0.0487 ns |  22.18 |     0.02 |
|                                           ForeachDelegate |              0 |     16.894 ns |   0.0081 ns |   0.0075 ns |   5.65 |     0.00 |
|                                                   Foreach |              0 |     11.937 ns |   0.0076 ns |   0.0071 ns |   3.99 |     0.00 |
|                                                       For |              0 |      2.991 ns |   0.0009 ns |   0.0007 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |        |          |
|                                                      **Linq** |           **1000** | **14,611.944 ns** |  **37.5133 ns** |  **35.0900 ns** |  **58.35** |     **0.14** |
|                                   LowCostLinqWithDelegate |           1000 | 10,989.311 ns |   3.4275 ns |   2.6759 ns |  43.88 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 10,107.614 ns |  36.2122 ns |  32.1012 ns |  40.36 |     0.12 |
|                                  LowCostLinqWithDelegate2 |           1000 | 12,472.614 ns |   1.6144 ns |   1.5101 ns |  49.80 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 10,889.999 ns |   9.0958 ns |   8.0632 ns |  43.48 |     0.03 |
|                                LowCostLinqWithStructWhere |           1000 |  1,855.589 ns |   1.3845 ns |   1.2951 ns |   7.41 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,744.765 ns |   0.2075 ns |   0.1839 ns |   6.97 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 21,465.108 ns | 162.4434 ns | 151.9496 ns |  85.71 |     0.59 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 19,980.450 ns |  36.1650 ns |  33.8287 ns |  79.78 |     0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  7,085.763 ns |   4.7269 ns |   4.4215 ns |  28.29 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  6,328.902 ns |   5.5315 ns |   4.9036 ns |  25.27 |     0.02 |
|                                                 LinqCount |           1000 |  9,023.914 ns |  10.2381 ns |   9.0758 ns |  36.03 |     0.04 |
|                              LowCostLinqWithDelegateCount |           1000 | 10,938.347 ns |  14.7430 ns |  13.7906 ns |  43.68 |     0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 10,565.213 ns |  18.7726 ns |  17.5599 ns |  42.19 |     0.07 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,744.481 ns |   1.0588 ns |   0.9904 ns |   6.97 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,224.125 ns |   0.0370 ns |   0.0346 ns |   4.89 |     0.00 |
|                                               LinqToArray |           1000 | 11,057.524 ns |   9.9439 ns |   8.8150 ns |  44.15 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           1000 | 11,893.172 ns |  13.0771 ns |  12.2323 ns |  47.49 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 11,144.896 ns |  32.5030 ns |  30.4033 ns |  44.50 |     0.12 |
|                              LowCostLinqWithStructToArray |           1000 |  3,211.001 ns |   5.1161 ns |   4.2721 ns |  12.82 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,359.889 ns |   1.4030 ns |   1.0144 ns |   9.42 |     0.00 |
|                                                      Take |           1000 |    532.799 ns |   0.5898 ns |   0.5517 ns |   2.13 |     0.00 |
|                                               LowCostTake |           1000 |    307.545 ns |   0.0808 ns |   0.0631 ns |   1.23 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    257.641 ns |   0.1062 ns |   0.0994 ns |   1.03 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    111.560 ns |   0.0177 ns |   0.0165 ns |   0.45 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    101.803 ns |   0.0158 ns |   0.0148 ns |   0.41 |     0.00 |
|                                            SkipTakeSingle |           1000 |    461.065 ns |   0.3860 ns |   0.3611 ns |   1.84 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    336.085 ns |   0.7858 ns |   0.7351 ns |   1.34 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    317.501 ns |   0.1208 ns |   0.1071 ns |   1.27 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    165.268 ns |   0.0998 ns |   0.0933 ns |   0.66 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    133.054 ns |   0.1897 ns |   0.1584 ns |   0.53 |     0.00 |
|                                           ForeachDelegate |           1000 |  7,277.036 ns |   2.4067 ns |   2.1335 ns |  29.06 |     0.01 |
|                                                   Foreach |           1000 |  1,691.850 ns |   0.8941 ns |   0.8364 ns |   6.76 |     0.00 |
|                                                       For |           1000 |    250.437 ns |   0.0644 ns |   0.0602 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |        |          |
|                                                      **Linq** |              **5** |    **202.248 ns** |   **0.0668 ns** |   **0.0592 ns** |  **46.73** |     **0.02** |
|                                   LowCostLinqWithDelegate |              5 |     93.866 ns |   0.0265 ns |   0.0235 ns |  21.69 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     74.173 ns |   0.0227 ns |   0.0212 ns |  17.14 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |    131.507 ns |   0.1697 ns |   0.1587 ns |  30.38 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    103.518 ns |   0.0287 ns |   0.0255 ns |  23.92 |     0.01 |
|                                LowCostLinqWithStructWhere |              5 |     58.396 ns |   0.0384 ns |   0.0320 ns |  13.49 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     51.736 ns |   0.0215 ns |   0.0179 ns |  11.95 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    189.435 ns |   0.0922 ns |   0.0862 ns |  43.77 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    177.251 ns |   0.1571 ns |   0.1469 ns |  40.95 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    100.319 ns |   0.0774 ns |   0.0724 ns |  23.18 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |     90.146 ns |   0.0428 ns |   0.0379 ns |  20.83 |     0.01 |
|                                                 LinqCount |              5 |    160.709 ns |   0.3104 ns |   0.2904 ns |  37.13 |     0.07 |
|                              LowCostLinqWithDelegateCount |              5 |     81.775 ns |   0.0533 ns |   0.0498 ns |  18.89 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     76.584 ns |   0.0372 ns |   0.0329 ns |  17.69 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              5 |     50.951 ns |   0.0261 ns |   0.0231 ns |  11.77 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     38.899 ns |   0.0324 ns |   0.0303 ns |   8.99 |     0.01 |
|                                               LinqToArray |              5 |    221.821 ns |   0.2788 ns |   0.2608 ns |  51.25 |     0.06 |
|                            LowCostLinqWithDelegateToArray |              5 |    123.930 ns |   0.1431 ns |   0.1339 ns |  28.63 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    117.079 ns |   0.1161 ns |   0.1086 ns |  27.05 |     0.02 |
|                              LowCostLinqWithStructToArray |              5 |     91.478 ns |   0.0224 ns |   0.0175 ns |  21.13 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     80.240 ns |   0.0849 ns |   0.0794 ns |  18.54 |     0.02 |
|                                                      Take |              5 |    265.760 ns |   0.2276 ns |   0.2129 ns |  61.40 |     0.05 |
|                                               LowCostTake |              5 |    110.450 ns |   0.2732 ns |   0.2133 ns |  25.52 |     0.05 |
|                                  LowCostTakeWithoutChecks |              5 |     89.626 ns |   0.0220 ns |   0.0172 ns |  20.71 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     81.059 ns |   0.0106 ns |   0.0094 ns |  18.73 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     66.704 ns |   0.0213 ns |   0.0178 ns |  15.41 |     0.00 |
|                                            SkipTakeSingle |              5 |    254.111 ns |   0.2558 ns |   0.2393 ns |  58.71 |     0.05 |
|                                     LowCostSkipTakeSingle |              5 |    123.489 ns |   0.0603 ns |   0.0564 ns |  28.53 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    113.827 ns |   0.1017 ns |   0.0951 ns |  26.30 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     91.656 ns |   0.0780 ns |   0.0730 ns |  21.18 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     78.494 ns |   0.0155 ns |   0.0129 ns |  18.13 |     0.00 |
|                                           ForeachDelegate |              5 |     52.241 ns |   0.0200 ns |   0.0187 ns |  12.07 |     0.00 |
|                                                   Foreach |              5 |     19.697 ns |   0.0222 ns |   0.0207 ns |   4.55 |     0.00 |
|                                                       For |              5 |      4.328 ns |   0.0009 ns |   0.0008 ns |   1.00 |     0.00 |
|                                                           |                |               |             |             |        |          |
|                                                      **Linq** |             **50** |    **852.548 ns** |   **0.9149 ns** |   **0.8558 ns** |  **50.86** |     **0.06** |
|                                   LowCostLinqWithDelegate |             50 |    583.108 ns |   0.8027 ns |   0.7509 ns |  34.78 |     0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    533.661 ns |   0.0719 ns |   0.0520 ns |  31.83 |     0.02 |
|                                  LowCostLinqWithDelegate2 |             50 |    690.265 ns |   0.2011 ns |   0.1882 ns |  41.18 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    599.465 ns |   0.7739 ns |   0.7239 ns |  35.76 |     0.05 |
|                                LowCostLinqWithStructWhere |             50 |    153.410 ns |   0.0734 ns |   0.0651 ns |   9.15 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    127.572 ns |   0.0291 ns |   0.0227 ns |   7.61 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,190.944 ns |   2.3469 ns |   2.1953 ns |  71.04 |     0.14 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,076.465 ns |   1.6431 ns |   1.5369 ns |  64.21 |     0.10 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    419.245 ns |   0.1111 ns |   0.0867 ns |  25.01 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    381.746 ns |   0.3637 ns |   0.3402 ns |  22.77 |     0.03 |
|                                                 LinqCount |             50 |    570.323 ns |   2.6649 ns |   2.4928 ns |  34.02 |     0.15 |
|                              LowCostLinqWithDelegateCount |             50 |    590.628 ns |   0.3963 ns |   0.3707 ns |  35.23 |     0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    545.110 ns |   0.4743 ns |   0.4437 ns |  32.52 |     0.04 |
|                           LowCostLinqWithStructWhereCount |             50 |    134.615 ns |   0.0239 ns |   0.0200 ns |   8.03 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     88.091 ns |   0.0168 ns |   0.0140 ns |   5.25 |     0.00 |
|                                               LinqToArray |             50 |    880.381 ns |   1.2685 ns |   1.1866 ns |  52.52 |     0.08 |
|                            LowCostLinqWithDelegateToArray |             50 |    780.714 ns |   0.5198 ns |   0.4862 ns |  46.57 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    725.168 ns |   0.3075 ns |   0.2567 ns |  43.26 |     0.04 |
|                              LowCostLinqWithStructToArray |             50 |    284.847 ns |   0.1636 ns |   0.1366 ns |  16.99 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    237.862 ns |   0.3166 ns |   0.2961 ns |  14.19 |     0.02 |
|                                                      Take |             50 |    532.717 ns |   1.0716 ns |   1.0023 ns |  31.78 |     0.06 |
|                                               LowCostTake |             50 |    312.361 ns |   0.2353 ns |   0.2201 ns |  18.63 |     0.02 |
|                                  LowCostTakeWithoutChecks |             50 |    260.217 ns |   0.0270 ns |   0.0239 ns |  15.52 |     0.01 |
|                                     LowCostTakeWithStruct |             50 |    111.674 ns |   0.0202 ns |   0.0158 ns |   6.66 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     97.039 ns |   0.0228 ns |   0.0202 ns |   5.79 |     0.00 |
|                                            SkipTakeSingle |             50 |    458.685 ns |   0.1831 ns |   0.1429 ns |  27.36 |     0.02 |
|                                     LowCostSkipTakeSingle |             50 |    335.668 ns |   0.4290 ns |   0.4013 ns |  20.02 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    323.049 ns |   0.0797 ns |   0.0576 ns |  19.27 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    160.073 ns |   0.1238 ns |   0.1158 ns |   9.55 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    133.511 ns |   0.0896 ns |   0.0700 ns |   7.96 |     0.01 |
|                                           ForeachDelegate |             50 |    385.213 ns |   0.2473 ns |   0.2193 ns |  22.98 |     0.02 |
|                                                   Foreach |             50 |    102.378 ns |   0.0112 ns |   0.0094 ns |   6.11 |     0.00 |
|                                                       For |             50 |     16.764 ns |   0.0159 ns |   0.0132 ns |   1.00 |     0.00 |
