``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **115.719 ns** |   **0.0366 ns** |   **0.0342 ns** |    **115.715 ns** | **33.53** |    **0.02** |
|                      LowCostLinqWithDelegate |            [0] |     33.680 ns |   0.0054 ns |   0.0050 ns |     33.680 ns |  9.76 |    0.01 |
|                     LowCostLinqWithDelegate2 |            [0] |     58.675 ns |   0.0120 ns |   0.0107 ns |     58.679 ns | 17.00 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |     43.029 ns |   0.0087 ns |   0.0077 ns |     43.032 ns | 12.47 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     65.819 ns |   0.0663 ns |   0.0517 ns |     65.822 ns | 19.07 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     59.486 ns |   0.0261 ns |   0.0244 ns |     59.482 ns | 17.24 |    0.01 |
|                                    LinqCount |            [0] |    112.767 ns |   0.0312 ns |   0.0260 ns |    112.773 ns | 32.68 |    0.02 |
|                 LowCostLinqWithDelegateCount |            [0] |     29.562 ns |   0.0087 ns |   0.0081 ns |     29.560 ns |  8.57 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     35.986 ns |   0.0040 ns |   0.0036 ns |     35.985 ns | 10.43 |    0.01 |
|                                  LinqToArray |            [0] |    124.774 ns |   0.0415 ns |   0.0388 ns |    124.773 ns | 36.16 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [0] |     32.485 ns |   0.0088 ns |   0.0082 ns |     32.482 ns |  9.41 |    0.00 |
|                 LowCostLinqWithStructToArray |            [0] |     38.542 ns |   0.0171 ns |   0.0160 ns |     38.542 ns | 11.17 |    0.01 |
|                                         Take |            [0] |    148.423 ns |   0.0668 ns |   0.0625 ns |    148.404 ns | 43.01 |    0.03 |
|                                  LowCostTake |            [0] |     44.942 ns |   0.0076 ns |   0.0071 ns |     44.938 ns | 13.02 |    0.01 |
|                        LowCostTakeWithStruct |            [0] |     55.337 ns |   0.0076 ns |   0.0071 ns |     55.340 ns | 16.03 |    0.01 |
|                               SkipTakeSingle |            [0] |    175.197 ns |   0.0785 ns |   0.0735 ns |    175.193 ns | 50.77 |    0.04 |
|                        LowCostSkipTakeSingle |            [0] |     60.691 ns |   0.0137 ns |   0.0122 ns |     60.693 ns | 17.59 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     67.670 ns |   0.0127 ns |   0.0119 ns |     67.670 ns | 19.61 |    0.01 |
|                              ForeachDelegate |            [0] |      7.250 ns |   0.0026 ns |   0.0024 ns |      7.250 ns |  2.10 |    0.00 |
|                                      Foreach |            [0] |      3.623 ns |   0.0007 ns |   0.0007 ns |      3.623 ns |  1.05 |    0.00 |
|                                          For |            [0] |      3.451 ns |   0.0017 ns |   0.0016 ns |      3.451 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |         **[1000]** | **13,821.203 ns** | **263.1525 ns** | **313.2644 ns** | **13,668.819 ns** | **55.29** |    **1.40** |
|                      LowCostLinqWithDelegate |         [1000] | 14,388.174 ns | 283.5489 ns | 278.4829 ns | 14,347.960 ns | 57.42 |    1.21 |
|                     LowCostLinqWithDelegate2 |         [1000] | 12,633.030 ns | 301.6800 ns | 840.9634 ns | 12,779.289 ns | 50.01 |    3.50 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,231.829 ns |   0.4136 ns |   0.3869 ns |  1,231.895 ns |  4.91 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 18,410.524 ns | 365.3033 ns | 686.1281 ns | 18,333.386 ns | 74.58 |    2.07 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  4,130.657 ns |   1.0683 ns |   0.9993 ns |  4,130.740 ns | 16.46 |    0.00 |
|                                    LinqCount |         [1000] | 10,487.153 ns |  73.0208 ns |  68.3037 ns | 10,478.049 ns | 41.77 |    0.28 |
|                 LowCostLinqWithDelegateCount |         [1000] | 10,612.397 ns | 222.1858 ns | 411.8356 ns | 10,369.762 ns | 42.09 |    1.07 |
|              LowCostLinqWithStructWhereCount |         [1000] |    579.489 ns |   0.2000 ns |   0.1871 ns |    579.432 ns |  2.31 |    0.00 |
|                                  LinqToArray |         [1000] |  9,771.207 ns |  33.1368 ns |  29.3750 ns |  9,763.522 ns | 38.93 |    0.12 |
|               LowCostLinqWithDelegateToArray |         [1000] | 11,462.687 ns |  33.5568 ns |  31.3890 ns | 11,452.011 ns | 45.68 |    0.13 |
|                 LowCostLinqWithStructToArray |         [1000] |  1,799.699 ns |   4.9595 ns |   4.1414 ns |  1,800.480 ns |  7.17 |    0.02 |
|                                         Take |         [1000] |    512.757 ns |   1.5696 ns |   1.4682 ns |    512.318 ns |  2.04 |    0.01 |
|                                  LowCostTake |         [1000] |    277.485 ns |   5.3253 ns |   6.1326 ns |    274.466 ns |  1.11 |    0.03 |
|                        LowCostTakeWithStruct |         [1000] |     89.755 ns |   0.0208 ns |   0.0184 ns |     89.760 ns |  0.36 |    0.00 |
|                               SkipTakeSingle |         [1000] |    468.418 ns |   5.6448 ns |   5.2802 ns |    470.154 ns |  1.86 |    0.02 |
|                        LowCostSkipTakeSingle |         [1000] |    340.929 ns |   6.8142 ns |  18.5384 ns |    336.556 ns |  1.39 |    0.08 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    125.624 ns |   0.0375 ns |   0.0351 ns |    125.623 ns |  0.50 |    0.00 |
|                              ForeachDelegate |         [1000] |  6,220.217 ns |   0.3849 ns |   0.3601 ns |  6,220.292 ns | 24.79 |    0.00 |
|                                      Foreach |         [1000] |    476.026 ns |   1.5274 ns |   1.3540 ns |    475.883 ns |  1.90 |    0.01 |
|                                          For |         [1000] |    250.942 ns |   0.0175 ns |   0.0146 ns |    250.938 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |           **[50]** |    **790.430 ns** |   **5.3794 ns** |   **5.0319 ns** |    **789.195 ns** | **49.68** |    **0.31** |
|                      LowCostLinqWithDelegate |           [50] |    553.545 ns |  11.0136 ns |  24.6334 ns |    538.826 ns | 35.26 |    1.73 |
|                     LowCostLinqWithDelegate2 |           [50] |    675.859 ns |   6.3759 ns |   5.9640 ns |    678.269 ns | 42.48 |    0.37 |
|                   LowCostLinqWithStructWhere |           [50] |    108.345 ns |   0.0178 ns |   0.0166 ns |    108.344 ns |  6.81 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    957.152 ns |   4.6695 ns |   3.6456 ns |    956.542 ns | 60.17 |    0.23 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    270.271 ns |   0.1031 ns |   0.0964 ns |    270.279 ns | 16.99 |    0.01 |
|                                    LinqCount |           [50] |    595.829 ns |   1.7894 ns |   1.5863 ns |    595.414 ns | 37.45 |    0.10 |
|                 LowCostLinqWithDelegateCount |           [50] |    590.832 ns |  15.0050 ns |  44.2427 ns |    578.831 ns | 35.87 |    2.04 |
|              LowCostLinqWithStructWhereCount |           [50] |     64.085 ns |   0.0062 ns |   0.0058 ns |     64.086 ns |  4.03 |    0.00 |
|                                  LinqToArray |           [50] |    816.108 ns |   1.4617 ns |   1.2957 ns |    816.292 ns | 51.30 |    0.08 |
|               LowCostLinqWithDelegateToArray |           [50] |    741.720 ns |   1.1312 ns |   0.9446 ns |    741.291 ns | 46.62 |    0.05 |
|                 LowCostLinqWithStructToArray |           [50] |    195.980 ns |   0.1371 ns |   0.1215 ns |    196.007 ns | 12.32 |    0.01 |
|                                         Take |           [50] |    517.906 ns |   1.3119 ns |   1.2272 ns |    517.930 ns | 32.55 |    0.08 |
|                                  LowCostTake |           [50] |    289.047 ns |   7.0833 ns |  20.8852 ns |    279.268 ns | 18.17 |    1.23 |
|                        LowCostTakeWithStruct |           [50] |     89.927 ns |   0.0099 ns |   0.0092 ns |     89.925 ns |  5.65 |    0.00 |
|                               SkipTakeSingle |           [50] |    437.942 ns |   0.9689 ns |   0.8589 ns |    437.677 ns | 27.53 |    0.06 |
|                        LowCostSkipTakeSingle |           [50] |    341.897 ns |   6.8635 ns |  19.5818 ns |    336.501 ns | 20.99 |    1.03 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    126.033 ns |   0.1701 ns |   0.1591 ns |    126.067 ns |  7.92 |    0.01 |
|                              ForeachDelegate |           [50] |    321.765 ns |   0.0600 ns |   0.0562 ns |    321.776 ns | 20.22 |    0.01 |
|                                      Foreach |           [50] |     26.536 ns |   0.0301 ns |   0.0282 ns |     26.548 ns |  1.67 |    0.00 |
|                                          For |           [50] |     15.910 ns |   0.0054 ns |   0.0051 ns |     15.909 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |            **[5]** |    **185.202 ns** |   **0.1930 ns** |   **0.1805 ns** |    **185.238 ns** | **38.47** |    **0.04** |
|                      LowCostLinqWithDelegate |            [5] |     79.580 ns |   1.6186 ns |   3.9704 ns |     79.145 ns | 16.00 |    0.55 |
|                     LowCostLinqWithDelegate2 |            [5] |    105.617 ns |   1.4675 ns |   1.2254 ns |    105.099 ns | 21.93 |    0.25 |
|                   LowCostLinqWithStructWhere |            [5] |     48.269 ns |   0.0109 ns |   0.0102 ns |     48.270 ns | 10.02 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    155.812 ns |   0.2359 ns |   0.2207 ns |    155.890 ns | 32.36 |    0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     77.251 ns |   0.0396 ns |   0.0351 ns |     77.251 ns | 16.04 |    0.01 |
|                                    LinqCount |            [5] |    170.844 ns |   0.8262 ns |   0.7324 ns |    171.015 ns | 35.48 |    0.15 |
|                 LowCostLinqWithDelegateCount |            [5] |     84.233 ns |   1.8151 ns |   5.3520 ns |     83.993 ns | 17.64 |    0.98 |
|              LowCostLinqWithStructWhereCount |            [5] |     38.934 ns |   0.0226 ns |   0.0211 ns |     38.937 ns |  8.09 |    0.00 |
|                                  LinqToArray |            [5] |    224.170 ns |   0.0903 ns |   0.0844 ns |    224.160 ns | 46.56 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [5] |    131.462 ns |   0.2963 ns |   0.2771 ns |    131.465 ns | 27.31 |    0.05 |
|                 LowCostLinqWithStructToArray |            [5] |     79.275 ns |   0.0191 ns |   0.0179 ns |     79.276 ns | 16.46 |    0.01 |
|                                         Take |            [5] |    270.885 ns |   0.2917 ns |   0.2729 ns |    270.877 ns | 56.25 |    0.06 |
|                                  LowCostTake |            [5] |    114.779 ns |   2.3959 ns |   6.8744 ns |    116.543 ns | 22.69 |    1.40 |
|                        LowCostTakeWithStruct |            [5] |     63.489 ns |   0.0127 ns |   0.0119 ns |     63.485 ns | 13.19 |    0.00 |
|                               SkipTakeSingle |            [5] |    243.063 ns |   0.1222 ns |   0.1021 ns |    243.069 ns | 50.48 |    0.03 |
|                        LowCostSkipTakeSingle |            [5] |    126.278 ns |   2.4848 ns |   6.6323 ns |    127.395 ns | 24.96 |    0.90 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     78.572 ns |   0.1040 ns |   0.0973 ns |     78.607 ns | 16.32 |    0.02 |
|                              ForeachDelegate |            [5] |     38.153 ns |   0.0078 ns |   0.0073 ns |     38.154 ns |  7.92 |    0.00 |
|                                      Foreach |            [5] |      5.541 ns |   0.0030 ns |   0.0028 ns |      5.540 ns |  1.15 |    0.00 |
|                                          For |            [5] |      4.815 ns |   0.0013 ns |   0.0012 ns |      4.815 ns |  1.00 |    0.00 |
