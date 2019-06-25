``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |     **85.053 ns** |   **0.0457 ns** |   **0.0405 ns** |     **85.058 ns** | **23.89** |    **0.01** |
|                      LowCostLinqWithDelegate |            [0] |     22.958 ns |   0.0025 ns |   0.0024 ns |     22.957 ns |  6.45 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |     49.306 ns |   0.0076 ns |   0.0071 ns |     49.304 ns | 13.85 |    0.00 |
|                   LowCostLinqWithStructWhere |            [0] |     36.252 ns |   0.0601 ns |   0.0562 ns |     36.271 ns | 10.18 |    0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     66.378 ns |   0.0385 ns |   0.0321 ns |     66.375 ns | 18.65 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     43.662 ns |   0.0390 ns |   0.0365 ns |     43.678 ns | 12.27 |    0.01 |
|                                    LinqCount |            [0] |     83.144 ns |   0.0439 ns |   0.0366 ns |     83.145 ns | 23.36 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |     25.168 ns |   0.0335 ns |   0.0314 ns |     25.174 ns |  7.07 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     28.731 ns |   0.0051 ns |   0.0048 ns |     28.733 ns |  8.07 |    0.00 |
|                                  LinqToArray |            [0] |     97.450 ns |   0.0318 ns |   0.0297 ns |     97.442 ns | 27.37 |    0.01 |
|               LowCostLinqWithDelegateToArray |            [0] |     29.764 ns |   0.0154 ns |   0.0136 ns |     29.762 ns |  8.36 |    0.00 |
|                 LowCostLinqWithStructToArray |            [0] |     33.241 ns |   0.0314 ns |   0.0279 ns |     33.236 ns |  9.34 |    0.01 |
|                                         Take |            [0] |    118.085 ns |   0.0425 ns |   0.0397 ns |    118.091 ns | 33.17 |    0.01 |
|                                  LowCostTake |            [0] |     33.669 ns |   0.0033 ns |   0.0025 ns |     33.669 ns |  9.46 |    0.00 |
|                        LowCostTakeWithStruct |            [0] |     42.561 ns |   0.0112 ns |   0.0104 ns |     42.560 ns | 11.96 |    0.00 |
|                               SkipTakeSingle |            [0] |    139.679 ns |   0.0603 ns |   0.0504 ns |    139.685 ns | 39.24 |    0.01 |
|                        LowCostSkipTakeSingle |            [0] |     41.652 ns |   0.0117 ns |   0.0110 ns |     41.652 ns | 11.70 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     48.890 ns |   0.0097 ns |   0.0091 ns |     48.890 ns | 13.73 |    0.00 |
|                              ForeachDelegate |            [0] |      7.720 ns |   0.0070 ns |   0.0062 ns |      7.720 ns |  2.17 |    0.00 |
|                                      Foreach |            [0] |      3.795 ns |   0.0013 ns |   0.0012 ns |      3.795 ns |  1.07 |    0.00 |
|                                          For |            [0] |      3.560 ns |   0.0006 ns |   0.0006 ns |      3.560 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |         **[1000]** | **14,978.937 ns** | **202.4060 ns** | **189.3307 ns** | **14,967.767 ns** | **59.72** |    **0.76** |
|                      LowCostLinqWithDelegate |         [1000] |  8,286.129 ns | 164.8987 ns | 413.6986 ns |  8,036.086 ns | 33.27 |    2.05 |
|                     LowCostLinqWithDelegate2 |         [1000] |  8,313.316 ns |  64.4493 ns |  60.2859 ns |  8,309.241 ns | 33.15 |    0.24 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,196.641 ns |   0.3490 ns |   0.3265 ns |  1,196.789 ns |  4.77 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,943.126 ns | 187.9198 ns | 175.7803 ns | 23,953.870 ns | 95.57 |    0.71 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,032.279 ns |   0.7908 ns |   0.7397 ns |  6,032.156 ns | 24.07 |    0.01 |
|                                    LinqCount |         [1000] |  7,935.356 ns | 102.5037 ns |  95.8820 ns |  7,951.657 ns | 31.67 |    0.39 |
|                 LowCostLinqWithDelegateCount |         [1000] |  6,840.133 ns | 139.0200 ns | 409.9037 ns |  6,691.016 ns | 27.10 |    1.72 |
|              LowCostLinqWithStructWhereCount |         [1000] |    645.168 ns |   0.2479 ns |   0.2319 ns |    645.043 ns |  2.57 |    0.00 |
|                                  LinqToArray |         [1000] |  8,534.832 ns | 128.2062 ns | 119.9242 ns |  8,558.868 ns | 34.04 |    0.50 |
|               LowCostLinqWithDelegateToArray |         [1000] |  8,978.427 ns |  15.1375 ns |  14.1596 ns |  8,974.178 ns | 35.82 |    0.06 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,142.387 ns |   5.6376 ns |   5.2734 ns |  2,143.708 ns |  8.55 |    0.02 |
|                                         Take |         [1000] |    444.278 ns |   0.7063 ns |   0.6606 ns |    444.396 ns |  1.77 |    0.00 |
|                                  LowCostTake |         [1000] |    280.476 ns |  18.9304 ns |  55.8167 ns |    308.092 ns |  1.25 |    0.03 |
|                        LowCostTakeWithStruct |         [1000] |     68.160 ns |   0.0142 ns |   0.0133 ns |     68.160 ns |  0.27 |    0.00 |
|                               SkipTakeSingle |         [1000] |    354.493 ns |   1.1562 ns |   1.0815 ns |    354.605 ns |  1.41 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    217.955 ns |   4.3510 ns |   7.7339 ns |    213.886 ns |  0.88 |    0.04 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     74.029 ns |   0.0095 ns |   0.0074 ns |     74.031 ns |  0.30 |    0.00 |
|                              ForeachDelegate |         [1000] |  4,313.174 ns |   1.9758 ns |   1.7515 ns |  4,312.993 ns | 17.21 |    0.01 |
|                                      Foreach |         [1000] |    481.312 ns |   1.0227 ns |   0.9566 ns |    481.457 ns |  1.92 |    0.00 |
|                                          For |         [1000] |    250.643 ns |   0.0943 ns |   0.0836 ns |    250.620 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |           **[50]** |    **623.443 ns** |   **2.4773 ns** |   **2.3173 ns** |    **623.626 ns** | **41.02** |    **0.15** |
|                      LowCostLinqWithDelegate |           [50] |    599.834 ns |  11.2046 ns |  11.5063 ns |    603.527 ns | 39.47 |    0.81 |
|                     LowCostLinqWithDelegate2 |           [50] |    458.067 ns |   9.7019 ns |  28.6063 ns |    460.763 ns | 30.23 |    1.66 |
|                   LowCostLinqWithStructWhere |           [50] |    102.738 ns |   0.1047 ns |   0.0980 ns |    102.765 ns |  6.76 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,064.860 ns |   4.3408 ns |   4.0604 ns |  1,065.117 ns | 70.06 |    0.27 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    350.081 ns |   0.0771 ns |   0.0721 ns |    350.066 ns | 23.03 |    0.02 |
|                                    LinqCount |           [50] |    446.135 ns |   0.7417 ns |   0.6938 ns |    446.101 ns | 29.35 |    0.05 |
|                 LowCostLinqWithDelegateCount |           [50] |    386.557 ns |   6.9140 ns |   6.4674 ns |    387.964 ns | 25.43 |    0.43 |
|              LowCostLinqWithStructWhereCount |           [50] |     54.378 ns |   0.0323 ns |   0.0286 ns |     54.367 ns |  3.58 |    0.00 |
|                                  LinqToArray |           [50] |    726.237 ns |  14.1810 ns |  18.9313 ns |    718.300 ns | 48.36 |    1.28 |
|               LowCostLinqWithDelegateToArray |           [50] |    559.949 ns |   0.9643 ns |   0.8548 ns |    560.009 ns | 36.84 |    0.07 |
|                 LowCostLinqWithStructToArray |           [50] |    196.640 ns |   0.1006 ns |   0.0892 ns |    196.665 ns | 12.94 |    0.01 |
|                                         Take |           [50] |    431.892 ns |   0.8063 ns |   0.7542 ns |    431.707 ns | 28.42 |    0.05 |
|                                  LowCostTake |           [50] |    186.003 ns |   3.7164 ns |   8.0792 ns |    183.410 ns | 12.37 |    0.63 |
|                        LowCostTakeWithStruct |           [50] |     68.733 ns |   0.0177 ns |   0.0165 ns |     68.736 ns |  4.52 |    0.00 |
|                               SkipTakeSingle |           [50] |    350.158 ns |   0.7381 ns |   0.6904 ns |    349.872 ns | 23.04 |    0.05 |
|                        LowCostSkipTakeSingle |           [50] |    213.875 ns |   4.2070 ns |   7.4780 ns |    210.053 ns | 14.03 |    0.50 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     73.967 ns |   0.0186 ns |   0.0155 ns |     73.965 ns |  4.87 |    0.00 |
|                              ForeachDelegate |           [50] |    226.585 ns |   0.3741 ns |   0.3499 ns |    226.705 ns | 14.91 |    0.03 |
|                                      Foreach |           [50] |     26.360 ns |   0.0854 ns |   0.0799 ns |     26.370 ns |  1.73 |    0.01 |
|                                          For |           [50] |     15.199 ns |   0.0098 ns |   0.0092 ns |     15.199 ns |  1.00 |    0.00 |
|                                              |                |               |             |             |               |       |         |
|                                         **Linq** |            **[5]** |    **140.936 ns** |   **0.0433 ns** |   **0.0384 ns** |    **140.937 ns** | **28.07** |    **0.02** |
|                      LowCostLinqWithDelegate |            [5] |     59.093 ns |   0.2784 ns |   0.2173 ns |     59.061 ns | 11.77 |    0.05 |
|                     LowCostLinqWithDelegate2 |            [5] |    116.589 ns |   4.4111 ns |  13.0064 ns |    122.229 ns | 24.37 |    1.32 |
|                   LowCostLinqWithStructWhere |            [5] |     41.035 ns |   0.0132 ns |   0.0117 ns |     41.030 ns |  8.17 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    171.232 ns |   0.1594 ns |   0.1491 ns |    171.265 ns | 34.10 |    0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     73.694 ns |   0.0156 ns |   0.0146 ns |     73.695 ns | 14.68 |    0.01 |
|                                    LinqCount |            [5] |    125.973 ns |   0.0615 ns |   0.0575 ns |    125.962 ns | 25.09 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |     61.319 ns |   1.4079 ns |   4.1512 ns |     60.191 ns | 12.18 |    0.86 |
|              LowCostLinqWithStructWhereCount |            [5] |     31.214 ns |   0.0078 ns |   0.0072 ns |     31.214 ns |  6.22 |    0.00 |
|                                  LinqToArray |            [5] |    184.155 ns |   0.0763 ns |   0.0714 ns |    184.168 ns | 36.67 |    0.02 |
|               LowCostLinqWithDelegateToArray |            [5] |     97.242 ns |   0.1123 ns |   0.1050 ns |     97.271 ns | 19.36 |    0.02 |
|                 LowCostLinqWithStructToArray |            [5] |     64.726 ns |   0.0312 ns |   0.0276 ns |     64.722 ns | 12.89 |    0.01 |
|                                         Take |            [5] |    215.110 ns |   0.2185 ns |   0.2044 ns |    215.028 ns | 42.84 |    0.05 |
|                                  LowCostTake |            [5] |     72.263 ns |   1.4724 ns |   4.2007 ns |     71.276 ns | 14.73 |    0.99 |
|                        LowCostTakeWithStruct |            [5] |     50.108 ns |   0.0133 ns |   0.0117 ns |     50.111 ns |  9.98 |    0.01 |
|                               SkipTakeSingle |            [5] |    196.885 ns |   0.0447 ns |   0.0396 ns |    196.892 ns | 39.21 |    0.02 |
|                        LowCostSkipTakeSingle |            [5] |     72.792 ns |   1.6076 ns |   2.3565 ns |     71.402 ns | 14.60 |    0.41 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     53.597 ns |   0.0177 ns |   0.0157 ns |     53.598 ns | 10.67 |    0.01 |
|                              ForeachDelegate |            [5] |     30.538 ns |   0.3182 ns |   0.2976 ns |     30.578 ns |  6.08 |    0.06 |
|                                      Foreach |            [5] |      5.765 ns |   0.0092 ns |   0.0081 ns |      5.767 ns |  1.15 |    0.00 |
|                                          For |            [5] |      5.022 ns |   0.0027 ns |   0.0026 ns |      5.022 ns |  1.00 |    0.00 |
