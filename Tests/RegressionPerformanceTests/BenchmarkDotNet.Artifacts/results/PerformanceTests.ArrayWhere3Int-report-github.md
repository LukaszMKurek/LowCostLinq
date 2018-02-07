``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |              **0** |     **79.338 ns** |  **0.0408 ns** |  **0.0382 ns** |  **27.57** |     **0.02** |
|                      LowCostLinqWithDelegate |              0 |     22.796 ns |  0.0061 ns |  0.0044 ns |   7.92 |     0.00 |
|                     LowCostLinqWithDelegate2 |              0 |     47.080 ns |  0.0031 ns |  0.0027 ns |  16.36 |     0.01 |
|                   LowCostLinqWithStructWhere |              0 |     34.824 ns |  0.0097 ns |  0.0091 ns |  12.10 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |     58.001 ns |  0.0495 ns |  0.0463 ns |  20.15 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |     36.949 ns |  0.1081 ns |  0.1012 ns |  12.84 |     0.03 |
|                                    LinqCount |              0 |     78.427 ns |  0.0231 ns |  0.0216 ns |  27.25 |     0.01 |
|                 LowCostLinqWithDelegateCount |              0 |     25.349 ns |  0.0168 ns |  0.0157 ns |   8.81 |     0.01 |
|              LowCostLinqWithStructWhereCount |              0 |     27.957 ns |  0.0007 ns |  0.0007 ns |   9.71 |     0.00 |
|                                  LinqToArray |              0 |     93.364 ns |  0.5209 ns |  0.4873 ns |  32.44 |     0.16 |
|               LowCostLinqWithDelegateToArray |              0 |     28.077 ns |  0.0388 ns |  0.0363 ns |   9.76 |     0.01 |
|                 LowCostLinqWithStructToArray |              0 |     31.209 ns |  0.0211 ns |  0.0197 ns |  10.84 |     0.01 |
|                                         Take |              0 |    116.163 ns |  0.0587 ns |  0.0549 ns |  40.36 |     0.03 |
|                                  LowCostTake |              0 |     32.223 ns |  0.0083 ns |  0.0074 ns |  11.20 |     0.01 |
|                        LowCostTakeWithStruct |              0 |     41.955 ns |  0.0051 ns |  0.0043 ns |  14.58 |     0.01 |
|                               SkipTakeSingle |              0 |    138.196 ns |  0.0201 ns |  0.0178 ns |  48.02 |     0.02 |
|                        LowCostSkipTakeSingle |              0 |     41.685 ns |  0.0034 ns |  0.0030 ns |  14.48 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              0 |     47.444 ns |  0.0016 ns |  0.0015 ns |  16.49 |     0.01 |
|                              ForeachDelegate |              0 |      6.844 ns |  0.0033 ns |  0.0031 ns |   2.38 |     0.00 |
|                                      Foreach |              0 |      2.881 ns |  0.0015 ns |  0.0013 ns |   1.00 |     0.00 |
|                                          For |              0 |      2.878 ns |  0.0015 ns |  0.0013 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |           **1000** |  **9,230.608 ns** |  **4.5714 ns** |  **4.0524 ns** |  **36.88** |     **0.02** |
|                      LowCostLinqWithDelegate |           1000 |  7,659.921 ns |  0.4716 ns |  0.3682 ns |  30.61 |     0.00 |
|                     LowCostLinqWithDelegate2 |           1000 |  8,230.284 ns | 28.0410 ns | 24.8576 ns |  32.88 |     0.10 |
|                   LowCostLinqWithStructWhere |           1000 |  1,474.357 ns |  0.1388 ns |  0.1230 ns |   5.89 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 17,259.626 ns | 13.9229 ns | 11.6262 ns |  68.96 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,343.091 ns |  0.8414 ns |  0.6569 ns |  25.34 |     0.00 |
|                                    LinqCount |           1000 |  6,095.331 ns |  3.7247 ns |  3.4841 ns |  24.35 |     0.01 |
|                 LowCostLinqWithDelegateCount |           1000 |  6,941.476 ns |  0.1939 ns |  0.1814 ns |  27.74 |     0.00 |
|              LowCostLinqWithStructWhereCount |           1000 |  1,346.679 ns |  0.2036 ns |  0.1700 ns |   5.38 |     0.00 |
|                                  LinqToArray |           1000 |  7,621.809 ns |  5.4652 ns |  4.8448 ns |  30.45 |     0.02 |
|               LowCostLinqWithDelegateToArray |           1000 |  8,532.119 ns | 17.8070 ns | 16.6567 ns |  34.09 |     0.06 |
|                 LowCostLinqWithStructToArray |           1000 |  2,222.196 ns |  3.9022 ns |  3.4592 ns |   8.88 |     0.01 |
|                                         Take |           1000 |    411.431 ns |  0.4530 ns |  0.4238 ns |   1.64 |     0.00 |
|                                  LowCostTake |           1000 |    181.648 ns |  0.0543 ns |  0.0481 ns |   0.73 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |     87.200 ns |  0.0533 ns |  0.0445 ns |   0.35 |     0.00 |
|                               SkipTakeSingle |           1000 |    344.755 ns |  0.0731 ns |  0.0648 ns |   1.38 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    207.873 ns |  0.0966 ns |  0.0904 ns |   0.83 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |     69.596 ns |  0.0939 ns |  0.0878 ns |   0.28 |     0.00 |
|                              ForeachDelegate |           1000 |  4,478.979 ns | 48.3011 ns | 45.1809 ns |  17.90 |     0.17 |
|                                      Foreach |           1000 |    335.511 ns |  0.2240 ns |  0.1985 ns |   1.34 |     0.00 |
|                                          For |           1000 |    250.277 ns |  0.0400 ns |  0.0355 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |              **5** |    **135.649 ns** |  **0.0266 ns** |  **0.0236 ns** |  **32.22** |     **0.04** |
|                      LowCostLinqWithDelegate |              5 |     57.321 ns |  0.0521 ns |  0.0488 ns |  13.62 |     0.02 |
|                     LowCostLinqWithDelegate2 |              5 |     80.445 ns |  0.0371 ns |  0.0329 ns |  19.11 |     0.03 |
|                   LowCostLinqWithStructWhere |              5 |     42.140 ns |  0.0058 ns |  0.0051 ns |  10.01 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    144.844 ns |  0.1285 ns |  0.1139 ns |  34.40 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |     68.086 ns |  0.0499 ns |  0.0443 ns |  16.17 |     0.02 |
|                                    LinqCount |              5 |    117.237 ns |  0.0970 ns |  0.0907 ns |  27.85 |     0.04 |
|                 LowCostLinqWithDelegateCount |              5 |     56.731 ns |  0.0092 ns |  0.0072 ns |  13.48 |     0.02 |
|              LowCostLinqWithStructWhereCount |              5 |     30.420 ns |  0.0196 ns |  0.0174 ns |   7.23 |     0.01 |
|                                  LinqToArray |              5 |    176.753 ns |  0.0667 ns |  0.0624 ns |  41.98 |     0.06 |
|               LowCostLinqWithDelegateToArray |              5 |     98.401 ns |  0.0993 ns |  0.0929 ns |  23.37 |     0.04 |
|                 LowCostLinqWithStructToArray |              5 |     68.854 ns |  0.1163 ns |  0.1088 ns |  16.35 |     0.03 |
|                                         Take |              5 |    206.932 ns |  0.1774 ns |  0.1572 ns |  49.15 |     0.08 |
|                                  LowCostTake |              5 |     70.506 ns |  0.0040 ns |  0.0031 ns |  16.75 |     0.02 |
|                        LowCostTakeWithStruct |              5 |     50.129 ns |  0.0540 ns |  0.0505 ns |  11.91 |     0.02 |
|                               SkipTakeSingle |              5 |    191.010 ns |  0.0514 ns |  0.0480 ns |  45.37 |     0.06 |
|                        LowCostSkipTakeSingle |              5 |     67.237 ns |  0.0888 ns |  0.0831 ns |  15.97 |     0.03 |
|              LowCostSkipTakeSingleWithStruct |              5 |     52.319 ns |  0.0059 ns |  0.0046 ns |  12.43 |     0.02 |
|                              ForeachDelegate |              5 |     28.945 ns |  0.0137 ns |  0.0114 ns |   6.88 |     0.01 |
|                                      Foreach |              5 |      4.272 ns |  0.0049 ns |  0.0046 ns |   1.01 |     0.00 |
|                                          For |              5 |      4.210 ns |  0.0064 ns |  0.0060 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |             **50** |    **561.714 ns** |  **0.5384 ns** |  **0.5036 ns** |  **35.01** |     **0.03** |
|                      LowCostLinqWithDelegate |             50 |    415.711 ns |  0.0365 ns |  0.0305 ns |  25.91 |     0.01 |
|                     LowCostLinqWithDelegate2 |             50 |    454.015 ns |  0.0492 ns |  0.0436 ns |  28.30 |     0.01 |
|                   LowCostLinqWithStructWhere |             50 |    105.403 ns |  0.0201 ns |  0.0168 ns |   6.57 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |    927.059 ns |  0.5818 ns |  0.5157 ns |  57.78 |     0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |    360.048 ns |  0.0847 ns |  0.0707 ns |  22.44 |     0.01 |
|                                    LinqCount |             50 |    390.020 ns |  0.5279 ns |  0.4680 ns |  24.31 |     0.03 |
|                 LowCostLinqWithDelegateCount |             50 |    372.423 ns |  0.0208 ns |  0.0138 ns |  23.21 |     0.01 |
|              LowCostLinqWithStructWhereCount |             50 |     77.788 ns |  0.0612 ns |  0.0573 ns |   4.85 |     0.00 |
|                                  LinqToArray |             50 |    679.274 ns |  0.3158 ns |  0.2954 ns |  42.34 |     0.03 |
|               LowCostLinqWithDelegateToArray |             50 |    555.326 ns |  0.8240 ns |  0.7707 ns |  34.61 |     0.05 |
|                 LowCostLinqWithStructToArray |             50 |    214.340 ns |  0.2452 ns |  0.2294 ns |  13.36 |     0.01 |
|                                         Take |             50 |    411.361 ns |  0.4365 ns |  0.4083 ns |  25.64 |     0.03 |
|                                  LowCostTake |             50 |    180.845 ns |  0.0702 ns |  0.0622 ns |  11.27 |     0.01 |
|                        LowCostTakeWithStruct |             50 |     74.555 ns |  0.0394 ns |  0.0350 ns |   4.65 |     0.00 |
|                               SkipTakeSingle |             50 |    345.058 ns |  0.1124 ns |  0.1052 ns |  21.51 |     0.01 |
|                        LowCostSkipTakeSingle |             50 |    207.201 ns |  0.2318 ns |  0.2168 ns |  12.91 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |             50 |     70.110 ns |  0.0406 ns |  0.0360 ns |   4.37 |     0.00 |
|                              ForeachDelegate |             50 |    238.193 ns |  0.0279 ns |  0.0261 ns |  14.85 |     0.01 |
|                                      Foreach |             50 |     18.602 ns |  0.0255 ns |  0.0238 ns |   1.16 |     0.00 |
|                                          For |             50 |     16.044 ns |  0.0075 ns |  0.0070 ns |   1.00 |     0.00 |
