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
|                                         **Linq** |              **0** |     **51.226 ns** |  **0.0574 ns** |  **0.0509 ns** |  **17.76** |     **0.02** |
|                      LowCostLinqWithDelegate |              0 |     19.880 ns |  0.0016 ns |  0.0013 ns |   6.89 |     0.00 |
|                     LowCostLinqWithDelegate2 |              0 |     37.213 ns |  0.0027 ns |  0.0023 ns |  12.90 |     0.00 |
|                   LowCostLinqWithStructWhere |              0 |     27.274 ns |  0.0054 ns |  0.0042 ns |   9.46 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |     51.517 ns |  0.0212 ns |  0.0198 ns |  17.86 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |     40.220 ns |  0.0045 ns |  0.0039 ns |  13.95 |     0.00 |
|                                    LinqCount |              0 |     50.178 ns |  0.0536 ns |  0.0502 ns |  17.40 |     0.02 |
|                 LowCostLinqWithDelegateCount |              0 |     22.696 ns |  0.0112 ns |  0.0100 ns |   7.87 |     0.00 |
|              LowCostLinqWithStructWhereCount |              0 |     31.943 ns |  0.0010 ns |  0.0009 ns |  11.08 |     0.00 |
|                                  LinqToArray |              0 |     63.228 ns |  0.0415 ns |  0.0368 ns |  21.93 |     0.01 |
|               LowCostLinqWithDelegateToArray |              0 |     27.009 ns |  0.0108 ns |  0.0096 ns |   9.37 |     0.00 |
|                 LowCostLinqWithStructToArray |              0 |     24.773 ns |  0.0081 ns |  0.0059 ns |   8.59 |     0.00 |
|                                         Take |              0 |     85.684 ns |  0.0950 ns |  0.0889 ns |  29.71 |     0.03 |
|                                  LowCostTake |              0 |     29.124 ns |  0.0012 ns |  0.0010 ns |  10.10 |     0.00 |
|                        LowCostTakeWithStruct |              0 |     36.728 ns |  0.0021 ns |  0.0019 ns |  12.74 |     0.00 |
|                               SkipTakeSingle |              0 |    109.479 ns |  0.0109 ns |  0.0096 ns |  37.96 |     0.01 |
|                        LowCostSkipTakeSingle |              0 |     37.300 ns |  0.0074 ns |  0.0062 ns |  12.93 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |              0 |     39.847 ns |  0.0012 ns |  0.0010 ns |  13.82 |     0.00 |
|                              ForeachDelegate |              0 |      6.420 ns |  0.0018 ns |  0.0016 ns |   2.23 |     0.00 |
|                                      Foreach |              0 |      2.720 ns |  0.0010 ns |  0.0009 ns |   0.94 |     0.00 |
|                                          For |              0 |      2.884 ns |  0.0010 ns |  0.0009 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |           **1000** |  **7,265.723 ns** |  **8.0605 ns** |  **7.5398 ns** |  **29.02** |     **0.03** |
|                      LowCostLinqWithDelegate |           1000 |  5,006.839 ns | 45.3801 ns | 42.4486 ns |  20.00 |     0.16 |
|                     LowCostLinqWithDelegate2 |           1000 |  5,395.466 ns | 15.7555 ns | 14.7377 ns |  21.55 |     0.06 |
|                   LowCostLinqWithStructWhere |           1000 |  1,472.323 ns |  0.2711 ns |  0.2117 ns |   5.88 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 16,923.331 ns | 18.5759 ns | 17.3759 ns |  67.59 |     0.07 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,308.415 ns |  2.9303 ns |  2.7410 ns |  25.20 |     0.01 |
|                                    LinqCount |           1000 |  4,330.471 ns | 21.6787 ns | 20.2782 ns |  17.30 |     0.08 |
|                 LowCostLinqWithDelegateCount |           1000 |  4,564.095 ns |  4.8140 ns |  4.5031 ns |  18.23 |     0.02 |
|              LowCostLinqWithStructWhereCount |           1000 |  1,326.536 ns |  0.0584 ns |  0.0488 ns |   5.30 |     0.00 |
|                                  LinqToArray |           1000 |  5,058.141 ns |  5.1858 ns |  4.5971 ns |  20.20 |     0.02 |
|               LowCostLinqWithDelegateToArray |           1000 |  6,077.668 ns | 11.1277 ns | 10.4088 ns |  24.28 |     0.04 |
|                 LowCostLinqWithStructToArray |           1000 |  2,241.191 ns |  1.0401 ns |  0.9220 ns |   8.95 |     0.00 |
|                                         Take |           1000 |    361.057 ns |  0.2456 ns |  0.2297 ns |   1.44 |     0.00 |
|                                  LowCostTake |           1000 |    143.794 ns |  0.0253 ns |  0.0211 ns |   0.57 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |     70.045 ns |  0.0087 ns |  0.0068 ns |   0.28 |     0.00 |
|                               SkipTakeSingle |           1000 |    265.180 ns |  0.0778 ns |  0.0563 ns |   1.06 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    143.451 ns |  0.1528 ns |  0.1430 ns |   0.57 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |     63.531 ns |  0.0340 ns |  0.0302 ns |   0.25 |     0.00 |
|                              ForeachDelegate |           1000 |  3,198.704 ns |  0.7734 ns |  0.6458 ns |  12.78 |     0.00 |
|                                      Foreach |           1000 |    485.156 ns |  0.0295 ns |  0.0230 ns |   1.94 |     0.00 |
|                                          For |           1000 |    250.365 ns |  0.0740 ns |  0.0692 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |              **5** |     **98.282 ns** |  **0.0352 ns** |  **0.0312 ns** |  **23.17** |     **0.01** |
|                      LowCostLinqWithDelegate |              5 |     41.321 ns |  0.0538 ns |  0.0504 ns |   9.74 |     0.01 |
|                     LowCostLinqWithDelegate2 |              5 |     62.783 ns |  0.0538 ns |  0.0503 ns |  14.80 |     0.01 |
|                   LowCostLinqWithStructWhere |              5 |     34.205 ns |  0.0113 ns |  0.0106 ns |   8.06 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    138.973 ns |  0.0799 ns |  0.0748 ns |  32.76 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |     72.740 ns |  0.0274 ns |  0.0229 ns |  17.15 |     0.01 |
|                                    LinqCount |              5 |     81.600 ns |  0.0444 ns |  0.0321 ns |  19.24 |     0.01 |
|                 LowCostLinqWithDelegateCount |              5 |     44.779 ns |  0.0530 ns |  0.0496 ns |  10.56 |     0.01 |
|              LowCostLinqWithStructWhereCount |              5 |     23.884 ns |  0.0171 ns |  0.0160 ns |   5.63 |     0.00 |
|                                  LinqToArray |              5 |    137.546 ns |  0.0346 ns |  0.0270 ns |  32.42 |     0.01 |
|               LowCostLinqWithDelegateToArray |              5 |     84.111 ns |  0.1010 ns |  0.0945 ns |  19.83 |     0.02 |
|                 LowCostLinqWithStructToArray |              5 |     62.712 ns |  0.1115 ns |  0.1043 ns |  14.78 |     0.02 |
|                                         Take |              5 |    160.962 ns |  0.0246 ns |  0.0218 ns |  37.94 |     0.01 |
|                                  LowCostTake |              5 |     51.677 ns |  0.0046 ns |  0.0038 ns |  12.18 |     0.00 |
|                        LowCostTakeWithStruct |              5 |     44.056 ns |  0.0199 ns |  0.0186 ns |  10.39 |     0.01 |
|                               SkipTakeSingle |              5 |    151.551 ns |  0.1832 ns |  0.1714 ns |  35.73 |     0.04 |
|                        LowCostSkipTakeSingle |              5 |     54.049 ns |  0.0442 ns |  0.0345 ns |  12.74 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              5 |     45.429 ns |  0.0057 ns |  0.0053 ns |  10.71 |     0.00 |
|                              ForeachDelegate |              5 |     22.775 ns |  0.0041 ns |  0.0038 ns |   5.37 |     0.00 |
|                                      Foreach |              5 |      5.421 ns |  0.0038 ns |  0.0032 ns |   1.28 |     0.00 |
|                                          For |              5 |      4.242 ns |  0.0018 ns |  0.0014 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |             **50** |    **438.818 ns** |  **0.3794 ns** |  **0.3364 ns** |  **24.38** |     **0.06** |
|                      LowCostLinqWithDelegate |             50 |    276.499 ns |  0.0541 ns |  0.0452 ns |  15.36 |     0.03 |
|                     LowCostLinqWithDelegate2 |             50 |    317.826 ns |  0.1265 ns |  0.1122 ns |  17.66 |     0.04 |
|                   LowCostLinqWithStructWhere |             50 |     98.433 ns |  0.0120 ns |  0.0087 ns |   5.47 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |    896.637 ns |  0.5628 ns |  0.4989 ns |  49.82 |     0.11 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |    364.673 ns |  0.0897 ns |  0.0795 ns |  20.26 |     0.04 |
|                                    LinqCount |             50 |    279.848 ns |  0.0720 ns |  0.0638 ns |  15.55 |     0.03 |
|                 LowCostLinqWithDelegateCount |             50 |    253.490 ns |  0.0423 ns |  0.0330 ns |  14.08 |     0.03 |
|              LowCostLinqWithStructWhereCount |             50 |     70.112 ns |  0.0062 ns |  0.0045 ns |   3.90 |     0.01 |
|                                  LinqToArray |             50 |    505.350 ns |  0.3857 ns |  0.3608 ns |  28.08 |     0.06 |
|               LowCostLinqWithDelegateToArray |             50 |    433.445 ns |  0.2802 ns |  0.2340 ns |  24.08 |     0.05 |
|                 LowCostLinqWithStructToArray |             50 |    207.350 ns |  0.0816 ns |  0.0681 ns |  11.52 |     0.03 |
|                                         Take |             50 |    360.766 ns |  0.2337 ns |  0.1952 ns |  20.04 |     0.04 |
|                                  LowCostTake |             50 |    144.378 ns |  0.0472 ns |  0.0442 ns |   8.02 |     0.02 |
|                        LowCostTakeWithStruct |             50 |     73.254 ns |  0.0218 ns |  0.0204 ns |   4.07 |     0.01 |
|                               SkipTakeSingle |             50 |    265.168 ns |  0.3170 ns |  0.2965 ns |  14.73 |     0.04 |
|                        LowCostSkipTakeSingle |             50 |    143.296 ns |  0.0194 ns |  0.0140 ns |   7.96 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |             50 |     63.677 ns |  0.0234 ns |  0.0195 ns |   3.54 |     0.01 |
|                              ForeachDelegate |             50 |    170.858 ns |  0.0747 ns |  0.0624 ns |   9.49 |     0.02 |
|                                      Foreach |             50 |     27.183 ns |  0.0028 ns |  0.0026 ns |   1.51 |     0.00 |
|                                          For |             50 |     17.998 ns |  0.0435 ns |  0.0407 ns |   1.00 |     0.00 |
