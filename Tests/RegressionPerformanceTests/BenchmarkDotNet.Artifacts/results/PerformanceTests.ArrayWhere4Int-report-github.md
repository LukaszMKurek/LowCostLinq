``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                       Method | CollectionSize |           Mean |       Error |        StdDev |  Ratio | RatioSD |
|--------------------------------------------- |--------------- |---------------:|------------:|--------------:|-------:|--------:|
|                                         **Linq** |            **[0]** |     **82.7507 ns** |   **0.0401 ns** |     **0.0356 ns** | **290.12** |    **0.15** |
|                      LowCostLinqWithDelegate |            [0] |     20.9200 ns |   0.0079 ns |     0.0070 ns |  73.34 |    0.03 |
|                     LowCostLinqWithDelegate2 |            [0] |     48.6825 ns |   0.0026 ns |     0.0024 ns | 170.68 |    0.04 |
|                   LowCostLinqWithStructWhere |            [0] |     33.7469 ns |   0.0015 ns |     0.0013 ns | 118.32 |    0.03 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     46.6262 ns |   0.0186 ns |     0.0156 ns | 163.47 |    0.06 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     38.1619 ns |   0.0071 ns |     0.0063 ns | 133.79 |    0.04 |
|                                    LinqCount |            [0] |     80.0352 ns |   0.0244 ns |     0.0190 ns | 280.59 |    0.12 |
|                 LowCostLinqWithDelegateCount |            [0] |     13.7707 ns |   0.0036 ns |     0.0032 ns |  48.28 |    0.02 |
|              LowCostLinqWithStructWhereCount |            [0] |     26.5785 ns |   0.0006 ns |     0.0005 ns |  93.18 |    0.02 |
|                                  LinqToArray |            [0] |     83.7496 ns |   0.0374 ns |     0.0313 ns | 293.62 |    0.10 |
|               LowCostLinqWithDelegateToArray |            [0] |     15.7754 ns |   0.0067 ns |     0.0063 ns |  55.31 |    0.03 |
|                 LowCostLinqWithStructToArray |            [0] |     28.9182 ns |   0.0017 ns |     0.0015 ns | 101.39 |    0.03 |
|                                         Take |            [0] |    103.1374 ns |   0.0166 ns |     0.0139 ns | 361.59 |    0.11 |
|                                  LowCostTake |            [0] |     29.3203 ns |   0.0025 ns |     0.0024 ns | 102.80 |    0.02 |
|                        LowCostTakeWithStruct |            [0] |     45.1109 ns |   0.0098 ns |     0.0092 ns | 158.16 |    0.06 |
|                               SkipTakeSingle |            [0] |    121.4544 ns |   0.0355 ns |     0.0277 ns | 425.80 |    0.16 |
|                        LowCostSkipTakeSingle |            [0] |     30.4300 ns |   0.0055 ns |     0.0052 ns | 106.69 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     46.4466 ns |   0.0035 ns |     0.0033 ns | 162.84 |    0.04 |
|                              ForeachDelegate |            [0] |      2.4066 ns |   0.0018 ns |     0.0017 ns |   8.44 |    0.01 |
|                                      Foreach |            [0] |      0.4985 ns |   0.0037 ns |     0.0032 ns |   1.75 |    0.01 |
|                                          For |            [0] |      0.2852 ns |   0.0001 ns |     0.0001 ns |   1.00 |    0.00 |
|                                              |                |                |             |               |        |         |
|                                         **Linq** |         **[1000]** | **17,255.4467 ns** | **353.0237 ns** | **1,040.8982 ns** |  **70.71** |    **4.07** |
|                      LowCostLinqWithDelegate |         [1000] |  6,990.6934 ns |   1.5013 ns |     1.4043 ns |  28.22 |    0.01 |
|                     LowCostLinqWithDelegate2 |         [1000] |  7,249.6180 ns |   3.7800 ns |     3.5358 ns |  29.26 |    0.01 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,190.7715 ns |   1.1462 ns |     1.0161 ns |   4.81 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  9,376.9909 ns |   1.8378 ns |     1.6291 ns |  37.85 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,148.2945 ns |   0.9873 ns |     0.8752 ns |  12.71 |    0.00 |
|                                    LinqCount |         [1000] | 12,236.7460 ns | 272.8241 ns |   804.4280 ns |  47.00 |    2.19 |
|                 LowCostLinqWithDelegateCount |         [1000] |  6,505.6054 ns |   0.5108 ns |     0.4778 ns |  26.26 |    0.00 |
|              LowCostLinqWithStructWhereCount |         [1000] |    502.8589 ns |   0.4545 ns |     0.4252 ns |   2.03 |    0.00 |
|                                  LinqToArray |         [1000] | 12,275.9339 ns | 233.4754 ns |   327.2999 ns |  49.67 |    1.53 |
|               LowCostLinqWithDelegateToArray |         [1000] |  7,506.6686 ns |   3.9102 ns |     3.2652 ns |  30.30 |    0.01 |
|                 LowCostLinqWithStructToArray |         [1000] |  1,599.3759 ns |   0.6663 ns |     0.5907 ns |   6.46 |    0.00 |
|                                         Take |         [1000] |    479.0262 ns |   6.3911 ns |     5.9783 ns |   1.93 |    0.02 |
|                                  LowCostTake |         [1000] |    189.9420 ns |   0.2336 ns |     0.2185 ns |   0.77 |    0.00 |
|                        LowCostTakeWithStruct |         [1000] |     70.2550 ns |   0.0281 ns |     0.0263 ns |   0.28 |    0.00 |
|                               SkipTakeSingle |         [1000] |    409.1540 ns |   4.9791 ns |     4.6574 ns |   1.65 |    0.02 |
|                        LowCostSkipTakeSingle |         [1000] |    217.2410 ns |   0.0652 ns |     0.0544 ns |   0.88 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     98.2427 ns |   0.0332 ns |     0.0294 ns |   0.40 |    0.00 |
|                              ForeachDelegate |         [1000] |  6,202.1804 ns |   0.1376 ns |     0.1149 ns |  25.03 |    0.00 |
|                                      Foreach |         [1000] |    247.8779 ns |   0.0157 ns |     0.0147 ns |   1.00 |    0.00 |
|                                          For |         [1000] |    247.7579 ns |   0.0149 ns |     0.0132 ns |   1.00 |    0.00 |
|                                              |                |                |             |               |        |         |
|                                         **Linq** |           **[50]** |    **846.0491 ns** |  **16.6565 ns** |    **27.3672 ns** |  **53.34** |    **2.10** |
|                      LowCostLinqWithDelegate |           [50] |    369.0057 ns |   0.1169 ns |     0.1094 ns |  23.33 |    0.19 |
|                     LowCostLinqWithDelegate2 |           [50] |    411.1452 ns |   0.1282 ns |     0.1136 ns |  26.00 |    0.22 |
|                   LowCostLinqWithStructWhere |           [50] |    101.4032 ns |   0.0511 ns |     0.0478 ns |   6.41 |    0.05 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    527.8310 ns |   1.3715 ns |     1.2829 ns |  33.38 |    0.29 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    198.4203 ns |   0.0478 ns |     0.0424 ns |  12.55 |    0.11 |
|                                    LinqCount |           [50] |    631.5475 ns |  12.4803 ns |    24.3420 ns |  39.72 |    1.63 |
|                 LowCostLinqWithDelegateCount |           [50] |    338.3869 ns |   0.1068 ns |     0.0891 ns |  21.41 |    0.19 |
|              LowCostLinqWithStructWhereCount |           [50] |     47.3471 ns |   0.0435 ns |     0.0407 ns |   2.99 |    0.02 |
|                                  LinqToArray |           [50] |    717.0379 ns |   9.3220 ns |     8.7198 ns |  45.34 |    0.66 |
|               LowCostLinqWithDelegateToArray |           [50] |    455.9022 ns |   0.2968 ns |     0.2776 ns |  28.83 |    0.25 |
|                 LowCostLinqWithStructToArray |           [50] |    144.8921 ns |   0.2444 ns |     0.2286 ns |   9.16 |    0.08 |
|                                         Take |           [50] |    484.0866 ns |   6.3844 ns |     5.9719 ns |  30.61 |    0.27 |
|                                  LowCostTake |           [50] |    190.1370 ns |   0.2734 ns |     0.2558 ns |  12.02 |    0.11 |
|                        LowCostTakeWithStruct |           [50] |     70.7907 ns |   0.0394 ns |     0.0368 ns |   4.48 |    0.04 |
|                               SkipTakeSingle |           [50] |    410.4721 ns |   4.8780 ns |     4.5629 ns |  25.96 |    0.43 |
|                        LowCostSkipTakeSingle |           [50] |    212.8347 ns |   0.0769 ns |     0.0719 ns |  13.46 |    0.11 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     98.2104 ns |   0.0749 ns |     0.0701 ns |   6.21 |    0.05 |
|                              ForeachDelegate |           [50] |    315.7873 ns |   0.1564 ns |     0.1463 ns |  19.97 |    0.17 |
|                                      Foreach |           [50] |     13.5720 ns |   0.0482 ns |     0.0451 ns |   0.86 |    0.01 |
|                                          For |           [50] |     15.8160 ns |   0.1401 ns |     0.1311 ns |   1.00 |    0.00 |
|                                              |                |                |             |               |        |         |
|                                         **Linq** |            **[5]** |    **150.1935 ns** |   **0.5498 ns** |     **0.4874 ns** |  **73.55** |    **0.23** |
|                      LowCostLinqWithDelegate |            [5] |     59.1226 ns |   0.2487 ns |     0.2326 ns |  28.94 |    0.11 |
|                     LowCostLinqWithDelegate2 |            [5] |     78.3034 ns |   0.0671 ns |     0.0628 ns |  38.35 |    0.05 |
|                   LowCostLinqWithStructWhere |            [5] |     39.7789 ns |   0.0011 ns |     0.0009 ns |  19.48 |    0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |     93.0034 ns |   0.0565 ns |     0.0528 ns |  45.54 |    0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     52.3040 ns |   0.0944 ns |     0.0737 ns |  25.62 |    0.05 |
|                                    LinqCount |            [5] |    133.4741 ns |   0.4000 ns |     0.3546 ns |  65.36 |    0.18 |
|                 LowCostLinqWithDelegateCount |            [5] |     43.1624 ns |   0.0140 ns |     0.0131 ns |  21.14 |    0.02 |
|              LowCostLinqWithStructWhereCount |            [5] |     28.2043 ns |   0.0027 ns |     0.0024 ns |  13.81 |    0.01 |
|                                  LinqToArray |            [5] |    166.3483 ns |   0.3611 ns |     0.3201 ns |  81.46 |    0.14 |
|               LowCostLinqWithDelegateToArray |            [5] |     73.2581 ns |   0.0977 ns |     0.0914 ns |  35.87 |    0.04 |
|                 LowCostLinqWithStructToArray |            [5] |     56.3145 ns |   0.0084 ns |     0.0070 ns |  27.58 |    0.02 |
|                                         Take |            [5] |    207.2182 ns |   0.5199 ns |     0.4342 ns | 101.48 |    0.24 |
|                                  LowCostTake |            [5] |     61.4394 ns |   0.0537 ns |     0.0502 ns |  30.09 |    0.03 |
|                        LowCostTakeWithStruct |            [5] |     51.8939 ns |   0.0031 ns |     0.0029 ns |  25.41 |    0.02 |
|                               SkipTakeSingle |            [5] |    197.2802 ns |   0.6832 ns |     0.6391 ns |  96.64 |    0.34 |
|                        LowCostSkipTakeSingle |            [5] |     69.1471 ns |   0.0737 ns |     0.0616 ns |  33.86 |    0.04 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     55.5560 ns |   0.0143 ns |     0.0134 ns |  27.21 |    0.02 |
|                              ForeachDelegate |            [5] |     32.2493 ns |   0.0504 ns |     0.0471 ns |  15.79 |    0.03 |
|                                      Foreach |            [5] |      2.2184 ns |   0.0064 ns |     0.0060 ns |   1.09 |    0.00 |
|                                          For |            [5] |      2.0421 ns |   0.0018 ns |     0.0016 ns |   1.00 |    0.00 |
