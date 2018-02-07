``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |     Error |    StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |-------------:|----------:|----------:|-------:|---------:|
|                                         **Linq** |              **0** |    **21.446 ns** | **0.0692 ns** | **0.0647 ns** |   **7.33** |     **0.08** |
|                      LowCostLinqWithDelegate |              0 |    18.663 ns | 0.0026 ns | 0.0023 ns |   6.38 |     0.07 |
|                     LowCostLinqWithDelegate2 |              0 |    27.246 ns | 0.0106 ns | 0.0099 ns |   9.31 |     0.10 |
|                   LowCostLinqWithStructWhere |              0 |    20.516 ns | 0.0015 ns | 0.0014 ns |   7.01 |     0.07 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |    35.203 ns | 0.1277 ns | 0.1194 ns |  12.04 |     0.13 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |    35.976 ns | 0.0136 ns | 0.0114 ns |  12.30 |     0.13 |
|                                    LinqCount |              0 |    24.301 ns | 0.0080 ns | 0.0071 ns |   8.31 |     0.09 |
|                 LowCostLinqWithDelegateCount |              0 |    14.864 ns | 0.0054 ns | 0.0048 ns |   5.08 |     0.05 |
|              LowCostLinqWithStructWhereCount |              0 |    15.188 ns | 0.0014 ns | 0.0012 ns |   5.19 |     0.05 |
|                                  LinqToArray |              0 |    22.571 ns | 0.0272 ns | 0.0241 ns |   7.72 |     0.08 |
|               LowCostLinqWithDelegateToArray |              0 |    19.846 ns | 0.2838 ns | 0.2516 ns |   6.79 |     0.11 |
|                 LowCostLinqWithStructToArray |              0 |    19.328 ns | 0.3048 ns | 0.2702 ns |   6.61 |     0.11 |
|                                         Take |              0 |    25.843 ns | 0.2817 ns | 0.2635 ns |   8.84 |     0.13 |
|                                  LowCostTake |              0 |    26.106 ns | 0.1083 ns | 0.1013 ns |   8.93 |     0.10 |
|                        LowCostTakeWithStruct |              0 |    27.508 ns | 0.0845 ns | 0.0749 ns |   9.40 |     0.10 |
|                               SkipTakeSingle |              0 |    37.994 ns | 0.3574 ns | 0.3168 ns |  12.99 |     0.17 |
|                        LowCostSkipTakeSingle |              0 |    29.243 ns | 0.1164 ns | 0.1032 ns |  10.00 |     0.11 |
|              LowCostSkipTakeSingleWithStruct |              0 |    38.467 ns | 0.2179 ns | 0.2039 ns |  13.15 |     0.15 |
|                              ForeachDelegate |              0 |     5.980 ns | 0.1286 ns | 0.1203 ns |   2.04 |     0.04 |
|                                      Foreach |              0 |     2.890 ns | 0.0125 ns | 0.0104 ns |   0.99 |     0.01 |
|                                          For |              0 |     2.925 ns | 0.0349 ns | 0.0310 ns |   1.00 |     0.00 |
|                                              |                |              |           |           |        |          |
|                                         **Linq** |           **1000** | **6,122.808 ns** | **3.7478 ns** | **3.5057 ns** |  **24.47** |     **0.01** |
|                      LowCostLinqWithDelegate |           1000 | 2,650.713 ns | 0.7449 ns | 0.5816 ns |  10.59 |     0.00 |
|                     LowCostLinqWithDelegate2 |           1000 | 3,179.229 ns | 6.9844 ns | 6.5333 ns |  12.70 |     0.03 |
|                   LowCostLinqWithStructWhere |           1000 | 1,463.228 ns | 0.3929 ns | 0.3483 ns |   5.85 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 8,033.211 ns | 1.3885 ns | 1.2988 ns |  32.10 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 6,346.288 ns | 3.9124 ns | 3.4682 ns |  25.36 |     0.01 |
|                                    LinqCount |           1000 | 1,482.030 ns | 1.3835 ns | 1.2941 ns |   5.92 |     0.01 |
|                 LowCostLinqWithDelegateCount |           1000 | 2,405.177 ns | 0.5540 ns | 0.4911 ns |   9.61 |     0.00 |
|              LowCostLinqWithStructWhereCount |           1000 | 1,324.593 ns | 0.0740 ns | 0.0618 ns |   5.29 |     0.00 |
|                                  LinqToArray |           1000 | 3,008.447 ns | 2.7909 ns | 2.6106 ns |  12.02 |     0.01 |
|               LowCostLinqWithDelegateToArray |           1000 | 4,136.553 ns | 5.4538 ns | 4.8347 ns |  16.53 |     0.02 |
|                 LowCostLinqWithStructToArray |           1000 | 2,217.907 ns | 3.5054 ns | 3.1074 ns |   8.86 |     0.01 |
|                                         Take |           1000 |   294.129 ns | 0.0560 ns | 0.0496 ns |   1.18 |     0.00 |
|                                  LowCostTake |           1000 |    96.931 ns | 0.0184 ns | 0.0144 ns |   0.39 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |    61.057 ns | 0.0351 ns | 0.0329 ns |   0.24 |     0.00 |
|                               SkipTakeSingle |           1000 |   183.923 ns | 0.1073 ns | 0.1004 ns |   0.73 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    88.370 ns | 0.0800 ns | 0.0709 ns |   0.35 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |    54.649 ns | 0.0183 ns | 0.0172 ns |   0.22 |     0.00 |
|                              ForeachDelegate |           1000 | 1,441.366 ns | 0.0881 ns | 0.0735 ns |   5.76 |     0.00 |
|                                      Foreach |           1000 |   335.034 ns | 0.1180 ns | 0.1104 ns |   1.34 |     0.00 |
|                                          For |           1000 |   250.246 ns | 0.0236 ns | 0.0209 ns |   1.00 |     0.00 |
|                                              |                |              |           |           |        |          |
|                                         **Linq** |              **5** |    **65.548 ns** | **1.2786 ns** | **1.5221 ns** |  **15.57** |     **0.35** |
|                      LowCostLinqWithDelegate |              5 |    33.332 ns | 0.3390 ns | 0.3171 ns |   7.92 |     0.07 |
|                     LowCostLinqWithDelegate2 |              5 |    43.758 ns | 0.7746 ns | 0.7246 ns |  10.39 |     0.17 |
|                   LowCostLinqWithStructWhere |              5 |    27.864 ns | 0.0285 ns | 0.0238 ns |   6.62 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    76.860 ns | 1.1583 ns | 1.0268 ns |  18.25 |     0.24 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |    68.129 ns | 0.0689 ns | 0.0576 ns |  16.18 |     0.02 |
|                                    LinqCount |              5 |    39.470 ns | 0.1275 ns | 0.1193 ns |   9.37 |     0.03 |
|                 LowCostLinqWithDelegateCount |              5 |    27.616 ns | 0.0155 ns | 0.0121 ns |   6.56 |     0.01 |
|              LowCostLinqWithStructWhereCount |              5 |    18.180 ns | 0.0112 ns | 0.0099 ns |   4.32 |     0.00 |
|                                  LinqToArray |              5 |    97.089 ns | 0.3408 ns | 0.3188 ns |  23.06 |     0.08 |
|               LowCostLinqWithDelegateToArray |              5 |    68.237 ns | 0.0671 ns | 0.0627 ns |  16.21 |     0.02 |
|                 LowCostLinqWithStructToArray |              5 |    56.556 ns | 0.2233 ns | 0.2089 ns |  13.43 |     0.05 |
|                                         Take |              5 |   124.077 ns | 0.0519 ns | 0.0485 ns |  29.47 |     0.03 |
|                                  LowCostTake |              5 |    41.139 ns | 0.0119 ns | 0.0111 ns |   9.77 |     0.01 |
|                        LowCostTakeWithStruct |              5 |    36.120 ns | 0.0457 ns | 0.0428 ns |   8.58 |     0.01 |
|                               SkipTakeSingle |              5 |   111.245 ns | 0.1254 ns | 0.1173 ns |  26.42 |     0.04 |
|                        LowCostSkipTakeSingle |              5 |    39.177 ns | 0.0047 ns | 0.0044 ns |   9.30 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              5 |    36.217 ns | 0.0031 ns | 0.0027 ns |   8.60 |     0.01 |
|                              ForeachDelegate |              5 |    13.019 ns | 0.0023 ns | 0.0020 ns |   3.09 |     0.00 |
|                                      Foreach |              5 |     4.275 ns | 0.0041 ns | 0.0039 ns |   1.02 |     0.00 |
|                                          For |              5 |     4.211 ns | 0.0045 ns | 0.0042 ns |   1.00 |     0.00 |
|                                              |                |              |           |           |        |          |
|                                         **Linq** |             **50** |   **345.953 ns** | **0.0929 ns** | **0.0776 ns** |  **20.83** |     **0.01** |
|                      LowCostLinqWithDelegate |             50 |   156.276 ns | 0.1144 ns | 0.1014 ns |   9.41 |     0.01 |
|                     LowCostLinqWithDelegate2 |             50 |   188.137 ns | 0.0231 ns | 0.0193 ns |  11.33 |     0.00 |
|                   LowCostLinqWithStructWhere |             50 |    92.122 ns | 0.1118 ns | 0.1046 ns |   5.55 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |   444.392 ns | 0.2139 ns | 0.2001 ns |  26.76 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |   360.574 ns | 0.2675 ns | 0.2502 ns |  21.71 |     0.02 |
|                                    LinqCount |             50 |   116.782 ns | 0.1419 ns | 0.1328 ns |   7.03 |     0.01 |
|                 LowCostLinqWithDelegateCount |             50 |   139.682 ns | 0.1613 ns | 0.1509 ns |   8.41 |     0.01 |
|              LowCostLinqWithStructWhereCount |             50 |    66.306 ns | 0.0051 ns | 0.0046 ns |   3.99 |     0.00 |
|                                  LinqToArray |             50 |   367.412 ns | 0.4541 ns | 0.4026 ns |  22.12 |     0.02 |
|               LowCostLinqWithDelegateToArray |             50 |   321.512 ns | 0.6031 ns | 0.5036 ns |  19.36 |     0.03 |
|                 LowCostLinqWithStructToArray |             50 |   204.544 ns | 0.5155 ns | 0.4822 ns |  12.32 |     0.03 |
|                                         Take |             50 |   294.183 ns | 0.0422 ns | 0.0374 ns |  17.71 |     0.00 |
|                                  LowCostTake |             50 |    94.260 ns | 0.0552 ns | 0.0461 ns |   5.68 |     0.00 |
|                        LowCostTakeWithStruct |             50 |    61.052 ns | 0.0129 ns | 0.0108 ns |   3.68 |     0.00 |
|                               SkipTakeSingle |             50 |   184.148 ns | 0.3385 ns | 0.3166 ns |  11.09 |     0.02 |
|                        LowCostSkipTakeSingle |             50 |    89.662 ns | 0.0125 ns | 0.0110 ns |   5.40 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |             50 |    53.740 ns | 0.0193 ns | 0.0181 ns |   3.24 |     0.00 |
|                              ForeachDelegate |             50 |    81.544 ns | 0.0213 ns | 0.0178 ns |   4.91 |     0.00 |
|                                      Foreach |             50 |    18.094 ns | 0.0840 ns | 0.0786 ns |   1.09 |     0.00 |
|                                          For |             50 |    16.607 ns | 0.0056 ns | 0.0044 ns |   1.00 |     0.00 |
