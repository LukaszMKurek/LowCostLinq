``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev |        Median | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|--------------:|-------:|---------:|
|                                         **Linq** |            **[0]** |     **47.466 ns** |  **0.0164 ns** |  **0.0153 ns** |     **47.463 ns** |  **12.93** |     **0.01** |
|                      LowCostLinqWithDelegate |            [0] |     20.075 ns |  0.0010 ns |  0.0009 ns |     20.075 ns |   5.47 |     0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |     37.975 ns |  0.2855 ns |  0.2671 ns |     37.812 ns |  10.34 |     0.07 |
|                   LowCostLinqWithStructWhere |            [0] |     27.898 ns |  0.0025 ns |  0.0021 ns |     27.898 ns |   7.60 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     55.416 ns |  0.0170 ns |  0.0159 ns |     55.413 ns |  15.09 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     42.899 ns |  0.1309 ns |  0.1160 ns |     42.816 ns |  11.68 |     0.03 |
|                                    LinqCount |            [0] |     46.658 ns |  0.0219 ns |  0.0194 ns |     46.653 ns |  12.70 |     0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |     23.415 ns |  0.0066 ns |  0.0062 ns |     23.413 ns |   6.38 |     0.00 |
|              LowCostLinqWithStructWhereCount |            [0] |     21.234 ns |  0.2079 ns |  0.1945 ns |     21.072 ns |   5.78 |     0.05 |
|                                  LinqToArray |            [0] |     62.032 ns |  0.0356 ns |  0.0278 ns |     62.021 ns |  16.89 |     0.01 |
|               LowCostLinqWithDelegateToArray |            [0] |     27.267 ns |  0.0121 ns |  0.0113 ns |     27.267 ns |   7.42 |     0.00 |
|                 LowCostLinqWithStructToArray |            [0] |     30.656 ns |  0.2722 ns |  0.2546 ns |     30.533 ns |   8.35 |     0.07 |
|                                         Take |            [0] |     83.145 ns |  0.0147 ns |  0.0123 ns |     83.147 ns |  22.64 |     0.01 |
|                                  LowCostTake |            [0] |     29.485 ns |  0.0066 ns |  0.0062 ns |     29.485 ns |   8.03 |     0.00 |
|                        LowCostTakeWithStruct |            [0] |     35.906 ns |  0.0020 ns |  0.0019 ns |     35.906 ns |   9.78 |     0.00 |
|                               SkipTakeSingle |            [0] |    105.989 ns |  1.0206 ns |  0.9547 ns |    105.331 ns |  28.86 |     0.25 |
|                        LowCostSkipTakeSingle |            [0] |     42.995 ns |  0.0019 ns |  0.0018 ns |     42.995 ns |  11.71 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     41.525 ns |  0.0107 ns |  0.0101 ns |     41.526 ns |  11.31 |     0.00 |
|                              ForeachDelegate |            [0] |      7.179 ns |  0.0024 ns |  0.0021 ns |      7.178 ns |   1.95 |     0.00 |
|                                      Foreach |            [0] |      3.744 ns |  0.0082 ns |  0.0077 ns |      3.748 ns |   1.02 |     0.00 |
|                                          For |            [0] |      3.672 ns |  0.0013 ns |  0.0012 ns |      3.672 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |         **[1000]** |  **7,281.607 ns** |  **6.8667 ns** |  **6.4231 ns** |  **7,280.955 ns** |  **29.05** |     **0.02** |
|                      LowCostLinqWithDelegate |         [1000] |  4,975.928 ns |  7.7220 ns |  6.8454 ns |  4,976.535 ns |  19.85 |     0.03 |
|                     LowCostLinqWithDelegate2 |         [1000] |  5,505.680 ns | 46.2720 ns | 43.2828 ns |  5,512.306 ns |  21.96 |     0.17 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,469.995 ns |  0.0839 ns |  0.0700 ns |  1,469.996 ns |   5.86 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 15,695.142 ns |  4.7185 ns |  4.4137 ns | 15,695.437 ns |  62.61 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,544.680 ns |  2.1635 ns |  1.8066 ns |  5,543.920 ns |  22.12 |     0.01 |
|                                    LinqCount |         [1000] |  4,355.942 ns |  5.3008 ns |  4.9583 ns |  4,357.592 ns |  17.38 |     0.02 |
|                 LowCostLinqWithDelegateCount |         [1000] |  4,570.021 ns |  0.5133 ns |  0.4286 ns |  4,569.974 ns |  18.23 |     0.00 |
|              LowCostLinqWithStructWhereCount |         [1000] |  1,333.374 ns |  0.0924 ns |  0.0864 ns |  1,333.323 ns |   5.32 |     0.00 |
|                                  LinqToArray |         [1000] |  5,164.839 ns |  3.1500 ns |  2.4593 ns |  5,164.640 ns |  20.60 |     0.01 |
|               LowCostLinqWithDelegateToArray |         [1000] |  6,643.064 ns |  4.3002 ns |  3.8120 ns |  6,642.414 ns |  26.50 |     0.01 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,204.049 ns |  1.8690 ns |  1.6569 ns |  2,203.672 ns |   8.79 |     0.01 |
|                                         Take |         [1000] |    337.451 ns |  4.1203 ns |  3.8541 ns |    335.340 ns |   1.35 |     0.01 |
|                                  LowCostTake |         [1000] |    146.274 ns |  0.0082 ns |  0.0064 ns |    146.275 ns |   0.58 |     0.00 |
|                        LowCostTakeWithStruct |         [1000] |     71.234 ns |  0.0148 ns |  0.0124 ns |     71.230 ns |   0.28 |     0.00 |
|                               SkipTakeSingle |         [1000] |    251.725 ns |  0.0357 ns |  0.0334 ns |    251.728 ns |   1.00 |     0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    141.123 ns |  0.0796 ns |  0.0621 ns |    141.112 ns |   0.56 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     66.164 ns |  0.5631 ns |  0.5267 ns |     65.746 ns |   0.26 |     0.00 |
|                              ForeachDelegate |         [1000] |  3,813.773 ns |  4.3796 ns |  4.0967 ns |  3,812.454 ns |  15.21 |     0.02 |
|                                      Foreach |         [1000] |    480.746 ns |  1.1429 ns |  1.0690 ns |    480.874 ns |   1.92 |     0.00 |
|                                          For |         [1000] |    250.691 ns |  0.0374 ns |  0.0292 ns |    250.683 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |           **[50]** |    **421.541 ns** |  **0.3228 ns** |  **0.2520 ns** |    **421.519 ns** |  **26.44** |     **0.02** |
|                      LowCostLinqWithDelegate |           [50] |    270.372 ns |  0.0875 ns |  0.0730 ns |    270.385 ns |  16.96 |     0.01 |
|                     LowCostLinqWithDelegate2 |           [50] |    304.003 ns |  0.1392 ns |  0.1302 ns |    304.017 ns |  19.07 |     0.01 |
|                   LowCostLinqWithStructWhere |           [50] |     97.871 ns |  0.0135 ns |  0.0113 ns |     97.872 ns |   6.14 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    853.131 ns |  8.7844 ns |  8.2170 ns |    847.345 ns |  53.52 |     0.50 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    324.313 ns |  0.1141 ns |  0.1068 ns |    324.349 ns |  20.35 |     0.01 |
|                                    LinqCount |           [50] |    273.486 ns |  0.1041 ns |  0.0974 ns |    273.508 ns |  17.16 |     0.01 |
|                 LowCostLinqWithDelegateCount |           [50] |    253.845 ns |  0.0179 ns |  0.0167 ns |    253.847 ns |  15.92 |     0.00 |
|              LowCostLinqWithStructWhereCount |           [50] |     71.195 ns |  0.5616 ns |  0.5253 ns |     70.832 ns |   4.47 |     0.03 |
|                                  LinqToArray |           [50] |    497.410 ns |  0.0549 ns |  0.0459 ns |    497.409 ns |  31.20 |     0.01 |
|               LowCostLinqWithDelegateToArray |           [50] |    455.467 ns |  0.1695 ns |  0.1503 ns |    455.465 ns |  28.57 |     0.01 |
|                 LowCostLinqWithStructToArray |           [50] |    192.238 ns |  3.6733 ns |  3.6076 ns |    189.851 ns |  12.06 |     0.22 |
|                                         Take |           [50] |    335.477 ns |  0.0720 ns |  0.0638 ns |    335.476 ns |  21.05 |     0.01 |
|                                  LowCostTake |           [50] |    146.315 ns |  0.0085 ns |  0.0079 ns |    146.312 ns |   9.18 |     0.00 |
|                        LowCostTakeWithStruct |           [50] |     71.041 ns |  0.0270 ns |  0.0226 ns |     71.031 ns |   4.46 |     0.00 |
|                               SkipTakeSingle |           [50] |    255.295 ns |  4.0446 ns |  3.7833 ns |    255.493 ns |  16.02 |     0.23 |
|                        LowCostSkipTakeSingle |           [50] |    146.599 ns |  0.3605 ns |  0.3372 ns |    146.422 ns |   9.20 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     64.849 ns |  0.0044 ns |  0.0037 ns |     64.850 ns |   4.07 |     0.00 |
|                              ForeachDelegate |           [50] |    200.034 ns |  0.2694 ns |  0.2250 ns |    200.025 ns |  12.55 |     0.01 |
|                                      Foreach |           [50] |     26.901 ns |  0.0205 ns |  0.0171 ns |     26.901 ns |   1.69 |     0.00 |
|                                          For |           [50] |     15.941 ns |  0.0035 ns |  0.0031 ns |     15.941 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |            **[5]** |     **91.474 ns** |  **0.0778 ns** |  **0.0690 ns** |     **91.471 ns** |  **20.28** |     **0.01** |
|                      LowCostLinqWithDelegate |            [5] |     44.086 ns |  0.6660 ns |  0.6230 ns |     43.624 ns |   9.78 |     0.13 |
|                     LowCostLinqWithDelegate2 |            [5] |     65.423 ns |  0.0319 ns |  0.0282 ns |     65.415 ns |  14.51 |     0.01 |
|                   LowCostLinqWithStructWhere |            [5] |     34.991 ns |  0.0092 ns |  0.0077 ns |     34.991 ns |   7.76 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    135.012 ns |  0.1148 ns |  0.1018 ns |    134.976 ns |  29.94 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     71.375 ns |  0.1606 ns |  0.1254 ns |     71.399 ns |  15.83 |     0.03 |
|                                    LinqCount |            [5] |     76.012 ns |  0.0086 ns |  0.0076 ns |     76.011 ns |  16.86 |     0.00 |
|                 LowCostLinqWithDelegateCount |            [5] |     45.430 ns |  0.0174 ns |  0.0163 ns |     45.435 ns |  10.07 |     0.00 |
|              LowCostLinqWithStructWhereCount |            [5] |     24.192 ns |  0.0155 ns |  0.0137 ns |     24.190 ns |   5.36 |     0.00 |
|                                  LinqToArray |            [5] |    134.466 ns |  0.2917 ns |  0.2728 ns |    134.547 ns |  29.82 |     0.06 |
|               LowCostLinqWithDelegateToArray |            [5] |     84.452 ns |  0.0121 ns |  0.0101 ns |     84.452 ns |  18.73 |     0.00 |
|                 LowCostLinqWithStructToArray |            [5] |     56.624 ns |  0.0762 ns |  0.0713 ns |     56.662 ns |  12.56 |     0.02 |
|                                         Take |            [5] |    150.941 ns |  0.0575 ns |  0.0538 ns |    150.935 ns |  33.47 |     0.01 |
|                                  LowCostTake |            [5] |     54.264 ns |  0.1111 ns |  0.1039 ns |     54.297 ns |  12.03 |     0.02 |
|                        LowCostTakeWithStruct |            [5] |     44.258 ns |  0.0274 ns |  0.0257 ns |     44.262 ns |   9.81 |     0.01 |
|                               SkipTakeSingle |            [5] |    145.577 ns |  0.0339 ns |  0.0317 ns |    145.576 ns |  32.28 |     0.01 |
|                        LowCostSkipTakeSingle |            [5] |     56.672 ns |  0.0334 ns |  0.0296 ns |     56.668 ns |  12.57 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     45.389 ns |  0.0836 ns |  0.0782 ns |     45.406 ns |  10.06 |     0.02 |
|                              ForeachDelegate |            [5] |     25.289 ns |  0.0299 ns |  0.0265 ns |     25.291 ns |   5.61 |     0.01 |
|                                      Foreach |            [5] |      5.648 ns |  0.0026 ns |  0.0024 ns |      5.649 ns |   1.25 |     0.00 |
|                                          For |            [5] |      4.510 ns |  0.0004 ns |  0.0003 ns |      4.510 ns |   1.00 |     0.00 |
