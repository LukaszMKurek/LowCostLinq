``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |              **0** |     **79.742 ns** |  **0.0698 ns** |  **0.0619 ns** |  **27.71** |     **0.03** |
|                      LowCostLinqWithDelegate |              0 |     22.756 ns |  0.0192 ns |  0.0179 ns |   7.91 |     0.01 |
|                     LowCostLinqWithDelegate2 |              0 |     52.678 ns |  0.0020 ns |  0.0017 ns |  18.30 |     0.01 |
|                   LowCostLinqWithStructWhere |              0 |     35.767 ns |  0.0012 ns |  0.0010 ns |  12.43 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |     58.773 ns |  0.0921 ns |  0.0861 ns |  20.42 |     0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |     36.128 ns |  0.0379 ns |  0.0296 ns |  12.55 |     0.01 |
|                                    LinqCount |              0 |     79.231 ns |  0.1512 ns |  0.1414 ns |  27.53 |     0.05 |
|                 LowCostLinqWithDelegateCount |              0 |     26.079 ns |  0.0032 ns |  0.0028 ns |   9.06 |     0.01 |
|              LowCostLinqWithStructWhereCount |              0 |     27.961 ns |  0.0038 ns |  0.0029 ns |   9.72 |     0.01 |
|                                  LinqToArray |              0 |     91.404 ns |  0.0245 ns |  0.0204 ns |  31.76 |     0.03 |
|               LowCostLinqWithDelegateToArray |              0 |     28.162 ns |  0.0168 ns |  0.0141 ns |   9.79 |     0.01 |
|                 LowCostLinqWithStructToArray |              0 |     31.266 ns |  0.0046 ns |  0.0036 ns |  10.86 |     0.01 |
|                                         Take |              0 |    116.788 ns |  0.1434 ns |  0.1341 ns |  40.58 |     0.06 |
|                                  LowCostTake |              0 |     32.218 ns |  0.0067 ns |  0.0059 ns |  11.19 |     0.01 |
|                        LowCostTakeWithStruct |              0 |     41.969 ns |  0.0040 ns |  0.0035 ns |  14.58 |     0.01 |
|                               SkipTakeSingle |              0 |    140.593 ns |  0.0261 ns |  0.0203 ns |  48.85 |     0.04 |
|                        LowCostSkipTakeSingle |              0 |     43.006 ns |  0.0074 ns |  0.0069 ns |  14.94 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              0 |     47.463 ns |  0.0374 ns |  0.0350 ns |  16.49 |     0.02 |
|                              ForeachDelegate |              0 |      6.498 ns |  0.0103 ns |  0.0096 ns |   2.26 |     0.00 |
|                                      Foreach |              0 |      2.725 ns |  0.0065 ns |  0.0060 ns |   0.95 |     0.00 |
|                                          For |              0 |      2.878 ns |  0.0027 ns |  0.0023 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |           **1000** |  **9,682.205 ns** |  **5.5445 ns** |  **4.9150 ns** |  **38.70** |     **0.02** |
|                      LowCostLinqWithDelegate |           1000 |  7,761.199 ns | 55.4232 ns | 51.8429 ns |  31.02 |     0.20 |
|                     LowCostLinqWithDelegate2 |           1000 |  7,376.262 ns | 10.5352 ns |  9.8546 ns |  29.48 |     0.04 |
|                   LowCostLinqWithStructWhere |           1000 |  1,476.864 ns |  0.7291 ns |  0.6820 ns |   5.90 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 17,305.529 ns | 17.7529 ns | 16.6061 ns |  69.17 |     0.06 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  5,507.149 ns |  4.7031 ns |  4.3992 ns |  22.01 |     0.02 |
|                                    LinqCount |           1000 |  6,575.169 ns | 13.5803 ns | 12.0386 ns |  26.28 |     0.05 |
|                 LowCostLinqWithDelegateCount |           1000 |  7,413.032 ns |  1.2139 ns |  1.0760 ns |  29.63 |     0.00 |
|              LowCostLinqWithStructWhereCount |           1000 |  1,343.454 ns |  0.2497 ns |  0.2336 ns |   5.37 |     0.00 |
|                                  LinqToArray |           1000 |  7,437.271 ns | 12.3223 ns | 11.5263 ns |  29.73 |     0.04 |
|               LowCostLinqWithDelegateToArray |           1000 |  8,485.028 ns |  7.5205 ns |  6.6667 ns |  33.92 |     0.03 |
|                 LowCostLinqWithStructToArray |           1000 |  2,206.646 ns |  3.2853 ns |  2.9124 ns |   8.82 |     0.01 |
|                                         Take |           1000 |    419.402 ns |  0.0975 ns |  0.0865 ns |   1.68 |     0.00 |
|                                  LowCostTake |           1000 |    200.221 ns |  0.0711 ns |  0.0630 ns |   0.80 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |     75.192 ns |  0.1755 ns |  0.1642 ns |   0.30 |     0.00 |
|                               SkipTakeSingle |           1000 |    333.964 ns |  0.4528 ns |  0.4236 ns |   1.33 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    203.089 ns |  0.0585 ns |  0.0518 ns |   0.81 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |     70.850 ns |  0.0519 ns |  0.0486 ns |   0.28 |     0.00 |
|                              ForeachDelegate |           1000 |  4,780.717 ns |  0.2052 ns |  0.1714 ns |  19.11 |     0.00 |
|                                      Foreach |           1000 |    485.359 ns |  0.1188 ns |  0.1111 ns |   1.94 |     0.00 |
|                                          For |           1000 |    250.182 ns |  0.0134 ns |  0.0112 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |              **5** |    **134.131 ns** |  **0.3433 ns** |  **0.3211 ns** |  **31.55** |     **0.07** |
|                      LowCostLinqWithDelegate |              5 |     56.408 ns |  0.0334 ns |  0.0279 ns |  13.27 |     0.01 |
|                     LowCostLinqWithDelegate2 |              5 |     79.682 ns |  0.0465 ns |  0.0435 ns |  18.74 |     0.01 |
|                   LowCostLinqWithStructWhere |              5 |     42.219 ns |  0.0127 ns |  0.0113 ns |   9.93 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    146.635 ns |  0.1801 ns |  0.1685 ns |  34.49 |     0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |     63.844 ns |  0.1214 ns |  0.1076 ns |  15.02 |     0.03 |
|                                    LinqCount |              5 |    120.757 ns |  0.0936 ns |  0.0830 ns |  28.41 |     0.02 |
|                 LowCostLinqWithDelegateCount |              5 |     59.295 ns |  0.0375 ns |  0.0313 ns |  13.95 |     0.01 |
|              LowCostLinqWithStructWhereCount |              5 |     30.455 ns |  0.0344 ns |  0.0322 ns |   7.16 |     0.01 |
|                                  LinqToArray |              5 |    174.443 ns |  0.2457 ns |  0.2299 ns |  41.03 |     0.06 |
|               LowCostLinqWithDelegateToArray |              5 |     97.765 ns |  0.0650 ns |  0.0576 ns |  23.00 |     0.02 |
|                 LowCostLinqWithStructToArray |              5 |     69.249 ns |  0.0632 ns |  0.0528 ns |  16.29 |     0.01 |
|                                         Take |              5 |    207.860 ns |  0.2328 ns |  0.2063 ns |  48.89 |     0.05 |
|                                  LowCostTake |              5 |     62.825 ns |  0.0265 ns |  0.0222 ns |  14.78 |     0.01 |
|                        LowCostTakeWithStruct |              5 |     49.500 ns |  0.0077 ns |  0.0068 ns |  11.64 |     0.01 |
|                               SkipTakeSingle |              5 |    188.456 ns |  0.3493 ns |  0.3268 ns |  44.33 |     0.08 |
|                        LowCostSkipTakeSingle |              5 |     66.146 ns |  0.0689 ns |  0.0645 ns |  15.56 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |              5 |     52.009 ns |  0.0153 ns |  0.0136 ns |  12.23 |     0.01 |
|                              ForeachDelegate |              5 |     30.222 ns |  0.0064 ns |  0.0056 ns |   7.11 |     0.00 |
|                                      Foreach |              5 |      5.455 ns |  0.0021 ns |  0.0018 ns |   1.28 |     0.00 |
|                                          For |              5 |      4.251 ns |  0.0028 ns |  0.0023 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |             **50** |    **571.103 ns** |  **0.2018 ns** |  **0.1685 ns** |  **35.51** |     **0.11** |
|                      LowCostLinqWithDelegate |             50 |    417.536 ns |  1.1041 ns |  1.0328 ns |  25.96 |     0.10 |
|                     LowCostLinqWithDelegate2 |             50 |    403.966 ns |  0.2302 ns |  0.2040 ns |  25.12 |     0.08 |
|                   LowCostLinqWithStructWhere |             50 |    105.430 ns |  0.1022 ns |  0.0956 ns |   6.56 |     0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |    939.288 ns |  0.5345 ns |  0.5000 ns |  58.40 |     0.19 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |    322.776 ns |  0.1436 ns |  0.1344 ns |  20.07 |     0.06 |
|                                    LinqCount |             50 |    414.004 ns |  0.1256 ns |  0.0980 ns |  25.74 |     0.08 |
|                 LowCostLinqWithDelegateCount |             50 |    397.180 ns |  0.0804 ns |  0.0713 ns |  24.70 |     0.08 |
|              LowCostLinqWithStructWhereCount |             50 |     77.422 ns |  0.0085 ns |  0.0080 ns |   4.81 |     0.02 |
|                                  LinqToArray |             50 |    671.751 ns |  0.4369 ns |  0.3873 ns |  41.77 |     0.14 |
|               LowCostLinqWithDelegateToArray |             50 |    557.506 ns |  0.2908 ns |  0.2428 ns |  34.66 |     0.11 |
|                 LowCostLinqWithStructToArray |             50 |    214.587 ns |  0.4406 ns |  0.3906 ns |  13.34 |     0.05 |
|                                         Take |             50 |    420.095 ns |  0.4964 ns |  0.4643 ns |  26.12 |     0.09 |
|                                  LowCostTake |             50 |    199.976 ns |  0.0088 ns |  0.0073 ns |  12.43 |     0.04 |
|                        LowCostTakeWithStruct |             50 |     79.961 ns |  0.0121 ns |  0.0101 ns |   4.97 |     0.02 |
|                               SkipTakeSingle |             50 |    333.668 ns |  0.3881 ns |  0.3630 ns |  20.75 |     0.07 |
|                        LowCostSkipTakeSingle |             50 |    202.891 ns |  0.1647 ns |  0.1541 ns |  12.62 |     0.04 |
|              LowCostSkipTakeSingleWithStruct |             50 |     71.336 ns |  0.1043 ns |  0.0975 ns |   4.44 |     0.02 |
|                              ForeachDelegate |             50 |    249.895 ns |  0.0413 ns |  0.0386 ns |  15.54 |     0.05 |
|                                      Foreach |             50 |     27.447 ns |  0.0042 ns |  0.0035 ns |   1.71 |     0.01 |
|                                          For |             50 |     16.083 ns |  0.0568 ns |  0.0532 ns |   1.00 |     0.00 |
