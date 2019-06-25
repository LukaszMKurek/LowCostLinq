``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |        StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|--------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **113.927 ns** |   **0.2667 ns** |     **0.2495 ns** |    **113.797 ns** | **31.80** |    **0.07** |
|                      LowCostLinqWithDelegate |            [0] |     32.788 ns |   0.0077 ns |     0.0072 ns |     32.788 ns |  9.15 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |     57.573 ns |   0.0063 ns |     0.0059 ns |     57.571 ns | 16.07 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |     43.215 ns |   0.0078 ns |     0.0073 ns |     43.215 ns | 12.06 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     77.154 ns |   0.0354 ns |     0.0331 ns |     77.150 ns | 21.54 |    0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     77.557 ns |   0.0362 ns |     0.0338 ns |     77.566 ns | 21.65 |    0.01 |
|                                    LinqCount |            [0] |    114.223 ns |   0.0407 ns |     0.0380 ns |    114.227 ns | 31.89 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [0] |     29.954 ns |   0.0062 ns |     0.0058 ns |     29.955 ns |  8.36 |    0.00 |
|              LowCostLinqWithStructWhereCount |            [0] |     36.866 ns |   0.0075 ns |     0.0067 ns |     36.867 ns | 10.29 |    0.01 |
|                                  LinqToArray |            [0] |    129.476 ns |   0.0920 ns |     0.0816 ns |    129.446 ns | 36.14 |    0.03 |
|               LowCostLinqWithDelegateToArray |            [0] |     33.664 ns |   0.0203 ns |     0.0180 ns |     33.663 ns |  9.40 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |     41.318 ns |   0.0461 ns |     0.0432 ns |     41.309 ns | 11.53 |    0.01 |
|                                         Take |            [0] |    149.044 ns |   0.0664 ns |     0.0622 ns |    149.053 ns | 41.61 |    0.02 |
|                                  LowCostTake |            [0] |     44.919 ns |   0.0057 ns |     0.0053 ns |     44.920 ns | 12.54 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |     54.993 ns |   0.0112 ns |     0.0100 ns |     54.992 ns | 15.35 |    0.01 |
|                               SkipTakeSingle |            [0] |    174.710 ns |   0.0546 ns |     0.0484 ns |    174.722 ns | 48.77 |    0.03 |
|                        LowCostSkipTakeSingle |            [0] |     60.055 ns |   0.0157 ns |     0.0147 ns |     60.055 ns | 16.76 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     67.465 ns |   0.0098 ns |     0.0092 ns |     67.467 ns | 18.83 |    0.01 |
|                              ForeachDelegate |            [0] |      7.622 ns |   0.0052 ns |     0.0041 ns |      7.623 ns |  2.13 |    0.00 |
|                                      Foreach |            [0] |      3.790 ns |   0.0011 ns |     0.0010 ns |      3.790 ns |  1.06 |    0.00 |
|                                          For |            [0] |      3.582 ns |   0.0016 ns |     0.0015 ns |      3.582 ns |  1.00 |    0.00 |
|                                              |                |               |             |               |               |       |         |
|                                         **Linq** |         **[1000]** | **13,891.766 ns** | **277.4608 ns** |   **423.7120 ns** | **13,728.030 ns** | **55.13** |    **1.58** |
|                      LowCostLinqWithDelegate |         [1000] | 14,152.497 ns | 752.5255 ns | 2,218.8385 ns | 15,204.939 ns | 60.51 |    4.18 |
|                     LowCostLinqWithDelegate2 |         [1000] | 10,770.684 ns | 214.6520 ns |   480.1000 ns | 10,670.393 ns | 43.05 |    2.33 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,229.446 ns |   0.8057 ns |     0.7142 ns |  1,229.533 ns |  4.90 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,241.102 ns | 518.7090 ns | 1,529.4253 ns | 22,744.463 ns | 92.97 |    6.34 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,218.914 ns |   9.0041 ns |     8.4225 ns |  6,219.790 ns | 24.81 |    0.04 |
|                                    LinqCount |         [1000] | 14,761.981 ns | 731.0618 ns | 2,085.7605 ns | 15,589.612 ns | 62.27 |    1.31 |
|                 LowCostLinqWithDelegateCount |         [1000] | 10,735.064 ns | 214.0648 ns |   442.0810 ns | 10,523.409 ns | 42.95 |    1.83 |
|              LowCostLinqWithStructWhereCount |         [1000] |    574.101 ns |   1.7667 ns |     1.6525 ns |    573.916 ns |  2.29 |    0.01 |
|                                  LinqToArray |         [1000] |  9,726.353 ns |  20.2740 ns |    18.9643 ns |  9,726.518 ns | 38.80 |    0.08 |
|               LowCostLinqWithDelegateToArray |         [1000] | 12,705.661 ns |  55.5328 ns |    51.9454 ns | 12,693.407 ns | 50.68 |    0.22 |
|                 LowCostLinqWithStructToArray |         [1000] |  1,915.122 ns |   6.5821 ns |     6.1569 ns |  1,916.938 ns |  7.64 |    0.02 |
|                                         Take |         [1000] |    504.656 ns |   1.8407 ns |     1.7218 ns |    505.020 ns |  2.01 |    0.01 |
|                                  LowCostTake |         [1000] |    313.425 ns |   7.3613 ns |    21.7048 ns |    301.713 ns |  1.23 |    0.08 |
|                        LowCostTakeWithStruct |         [1000] |     89.817 ns |   0.0351 ns |     0.0329 ns |     89.813 ns |  0.36 |    0.00 |
|                               SkipTakeSingle |         [1000] |    438.616 ns |   7.0133 ns |     6.5602 ns |    440.392 ns |  1.75 |    0.03 |
|                        LowCostSkipTakeSingle |         [1000] |    357.266 ns |   7.1380 ns |    16.8251 ns |    346.072 ns |  1.48 |    0.07 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    123.742 ns |   0.3486 ns |     0.3261 ns |    123.742 ns |  0.49 |    0.00 |
|                              ForeachDelegate |         [1000] |  6,219.284 ns |   0.8871 ns |     0.7864 ns |  6,219.477 ns | 24.81 |    0.01 |
|                                      Foreach |         [1000] |    473.580 ns |   1.6355 ns |     1.4498 ns |    473.637 ns |  1.89 |    0.01 |
|                                          For |         [1000] |    250.702 ns |   0.0996 ns |     0.0932 ns |    250.707 ns |  1.00 |    0.00 |
|                                              |                |               |             |               |               |       |         |
|                                         **Linq** |           **[50]** |    **809.663 ns** |   **6.1158 ns** |     **5.7207 ns** |    **810.845 ns** | **53.01** |    **0.38** |
|                      LowCostLinqWithDelegate |           [50] |    538.009 ns |   2.7409 ns |     2.1399 ns |    538.137 ns | 35.22 |    0.13 |
|                     LowCostLinqWithDelegate2 |           [50] |    912.724 ns |  61.2409 ns |   180.5703 ns |    997.697 ns | 67.05 |    1.50 |
|                   LowCostLinqWithStructWhere |           [50] |    107.954 ns |   0.0166 ns |     0.0147 ns |    107.952 ns |  7.07 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,150.447 ns |  17.0892 ns |    15.9852 ns |  1,140.932 ns | 75.32 |    1.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    390.736 ns |   0.3072 ns |     0.2874 ns |    390.810 ns | 25.58 |    0.04 |
|                                    LinqCount |           [50] |    605.886 ns |   4.2093 ns |     3.9374 ns |    607.093 ns | 39.67 |    0.26 |
|                 LowCostLinqWithDelegateCount |           [50] |    598.644 ns |   7.7002 ns |     7.2028 ns |    599.824 ns | 39.19 |    0.44 |
|              LowCostLinqWithStructWhereCount |           [50] |     62.210 ns |   0.0283 ns |     0.0265 ns |     62.214 ns |  4.07 |    0.01 |
|                                  LinqToArray |           [50] |    878.571 ns |   2.9271 ns |     2.7380 ns |    878.375 ns | 57.52 |    0.18 |
|               LowCostLinqWithDelegateToArray |           [50] |    737.659 ns |   1.0669 ns |     0.9980 ns |    737.538 ns | 48.29 |    0.09 |
|                 LowCostLinqWithStructToArray |           [50] |    197.955 ns |   0.3861 ns |     0.3612 ns |    197.750 ns | 12.96 |    0.03 |
|                                         Take |           [50] |    497.396 ns |   0.9147 ns |     0.8556 ns |    497.221 ns | 32.56 |    0.06 |
|                                  LowCostTake |           [50] |    420.078 ns |  20.8105 ns |    60.0431 ns |    451.353 ns | 29.28 |    2.34 |
|                        LowCostTakeWithStruct |           [50] |     89.939 ns |   0.0099 ns |     0.0082 ns |     89.938 ns |  5.89 |    0.01 |
|                               SkipTakeSingle |           [50] |    420.566 ns |   0.4142 ns |     0.3459 ns |    420.496 ns | 27.53 |    0.04 |
|                        LowCostSkipTakeSingle |           [50] |    372.254 ns |   8.1732 ns |    24.0987 ns |    369.685 ns | 25.22 |    1.46 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    121.452 ns |   0.0537 ns |     0.0502 ns |    121.437 ns |  7.95 |    0.01 |
|                              ForeachDelegate |           [50] |    322.264 ns |   0.0369 ns |     0.0345 ns |    322.257 ns | 21.10 |    0.03 |
|                                      Foreach |           [50] |     26.475 ns |   0.0725 ns |     0.0678 ns |     26.464 ns |  1.73 |    0.00 |
|                                          For |           [50] |     15.274 ns |   0.0189 ns |     0.0176 ns |     15.275 ns |  1.00 |    0.00 |
|                                              |                |               |             |               |               |       |         |
|                                         **Linq** |            **[5]** |    **184.743 ns** |   **0.2835 ns** |     **0.2652 ns** |    **184.626 ns** | **36.73** |    **0.06** |
|                      LowCostLinqWithDelegate |            [5] |    109.622 ns |   4.5290 ns |    13.3540 ns |    114.566 ns | 22.62 |    1.95 |
|                     LowCostLinqWithDelegate2 |            [5] |    106.337 ns |   1.9275 ns |     1.8030 ns |    105.664 ns | 21.14 |    0.35 |
|                   LowCostLinqWithStructWhere |            [5] |     48.212 ns |   0.0062 ns |     0.0058 ns |     48.212 ns |  9.59 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    195.225 ns |   0.1740 ns |     0.1628 ns |    195.195 ns | 38.82 |    0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    106.416 ns |   0.2853 ns |     0.2668 ns |    106.457 ns | 21.16 |    0.05 |
|                                    LinqCount |            [5] |    167.672 ns |   0.0657 ns |     0.0615 ns |    167.675 ns | 33.34 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [5] |     79.504 ns |   1.5988 ns |     2.9635 ns |     78.563 ns | 15.92 |    0.55 |
|              LowCostLinqWithStructWhereCount |            [5] |     38.705 ns |   0.0086 ns |     0.0081 ns |     38.706 ns |  7.70 |    0.00 |
|                                  LinqToArray |            [5] |    226.491 ns |   0.2777 ns |     0.2597 ns |    226.400 ns | 45.04 |    0.06 |
|               LowCostLinqWithDelegateToArray |            [5] |    116.766 ns |   0.1212 ns |     0.1075 ns |    116.740 ns | 23.22 |    0.03 |
|                 LowCostLinqWithStructToArray |            [5] |     72.398 ns |   0.1101 ns |     0.1030 ns |     72.355 ns | 14.40 |    0.02 |
|                                         Take |            [5] |    253.858 ns |   0.1728 ns |     0.1617 ns |    253.847 ns | 50.48 |    0.04 |
|                                  LowCostTake |            [5] |    138.134 ns |   6.4281 ns |    18.9535 ns |    148.017 ns | 29.46 |    1.93 |
|                        LowCostTakeWithStruct |            [5] |     65.164 ns |   0.0078 ns |     0.0061 ns |     65.164 ns | 12.96 |    0.01 |
|                               SkipTakeSingle |            [5] |    243.262 ns |   0.0975 ns |     0.0814 ns |    243.266 ns | 48.37 |    0.04 |
|                        LowCostSkipTakeSingle |            [5] |    121.716 ns |   2.5765 ns |     3.7766 ns |    119.573 ns | 24.58 |    0.85 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     78.032 ns |   0.0139 ns |     0.0130 ns |     78.035 ns | 15.52 |    0.01 |
|                              ForeachDelegate |            [5] |     38.230 ns |   0.0050 ns |     0.0046 ns |     38.229 ns |  7.60 |    0.00 |
|                                      Foreach |            [5] |      5.763 ns |   0.0062 ns |     0.0058 ns |      5.762 ns |  1.15 |    0.00 |
|                                          For |            [5] |      5.029 ns |   0.0030 ns |     0.0028 ns |      5.030 ns |  1.00 |    0.00 |
