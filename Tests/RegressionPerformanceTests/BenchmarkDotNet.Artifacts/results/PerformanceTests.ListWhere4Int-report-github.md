``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |           Mean |       Error |        StdDev |  Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |---------------:|------------:|--------------:|-------:|--------:|
|                                                      **Linq** |            **[0]** |     **92.0626 ns** |   **0.0419 ns** |     **0.0372 ns** | **282.29** |    **0.43** |
|                                   LowCostLinqWithDelegate |            [0] |     26.7409 ns |   0.0061 ns |     0.0057 ns |  82.00 |    0.11 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     20.6760 ns |   0.0058 ns |     0.0054 ns |  63.40 |    0.08 |
|                                  LowCostLinqWithDelegate2 |            [0] |     53.3507 ns |   0.0055 ns |     0.0051 ns | 163.59 |    0.22 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     49.4105 ns |   0.0033 ns |     0.0029 ns | 151.51 |    0.21 |
|                                LowCostLinqWithStructWhere |            [0] |     37.8398 ns |   0.0012 ns |     0.0010 ns | 116.03 |    0.17 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     34.0073 ns |   0.0050 ns |     0.0047 ns | 104.28 |    0.15 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     51.3860 ns |   0.0289 ns |     0.0256 ns | 157.57 |    0.26 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     46.4317 ns |   0.0133 ns |     0.0118 ns | 142.37 |    0.21 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     40.8254 ns |   0.0052 ns |     0.0044 ns | 125.19 |    0.18 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     38.0907 ns |   0.0038 ns |     0.0032 ns | 116.80 |    0.17 |
|                                                 LinqCount |            [0] |     87.7394 ns |   0.0163 ns |     0.0136 ns | 269.04 |    0.39 |
|                              LowCostLinqWithDelegateCount |            [0] |     15.2852 ns |   0.0050 ns |     0.0047 ns |  46.87 |    0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     13.9478 ns |   0.0061 ns |     0.0054 ns |  42.77 |    0.07 |
|                           LowCostLinqWithStructWhereCount |            [0] |     26.7197 ns |   0.0038 ns |     0.0036 ns |  81.93 |    0.11 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     28.1823 ns |   0.0009 ns |     0.0008 ns |  86.42 |    0.12 |
|                                               LinqToArray |            [0] |     92.0020 ns |   0.1410 ns |     0.1250 ns | 282.11 |    0.60 |
|                            LowCostLinqWithDelegateToArray |            [0] |     15.9754 ns |   0.0027 ns |     0.0025 ns |  48.99 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     15.4329 ns |   0.0163 ns |     0.0152 ns |  47.32 |    0.10 |
|                              LowCostLinqWithStructToArray |            [0] |     29.6642 ns |   0.0006 ns |     0.0005 ns |  90.96 |    0.12 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     28.8838 ns |   0.0035 ns |     0.0032 ns |  88.57 |    0.13 |
|                                                      Take |            [0] |    117.3464 ns |   0.0313 ns |     0.0278 ns | 359.82 |    0.48 |
|                                               LowCostTake |            [0] |     35.3107 ns |   0.0037 ns |     0.0035 ns | 108.27 |    0.15 |
|                                  LowCostTakeWithoutChecks |            [0] |     28.4939 ns |   0.0072 ns |     0.0068 ns |  87.37 |    0.12 |
|                                     LowCostTakeWithStruct |            [0] |     49.1006 ns |   0.0033 ns |     0.0031 ns | 150.56 |    0.20 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     45.0260 ns |   0.0054 ns |     0.0051 ns | 138.06 |    0.19 |
|                                            SkipTakeSingle |            [0] |    138.8342 ns |   0.0313 ns |     0.0278 ns | 425.71 |    0.57 |
|                                     LowCostSkipTakeSingle |            [0] |     30.7949 ns |   0.0121 ns |     0.0113 ns |  94.43 |    0.12 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     30.8182 ns |   0.0080 ns |     0.0075 ns |  94.50 |    0.13 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     47.3187 ns |   0.0048 ns |     0.0045 ns | 145.09 |    0.20 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     46.5810 ns |   0.0027 ns |     0.0024 ns | 142.83 |    0.19 |
|                                           ForeachDelegate |            [0] |      2.8369 ns |   0.0011 ns |     0.0010 ns |   8.70 |    0.01 |
|                                                   Foreach |            [0] |      0.9913 ns |   0.0018 ns |     0.0017 ns |   3.04 |    0.01 |
|                                                       For |            [0] |      0.3261 ns |   0.0005 ns |     0.0004 ns |   1.00 |    0.00 |
|                                                           |                |                |             |               |        |         |
|                                                      **Linq** |         **[1000]** | **17,068.3817 ns** | **371.0684 ns** | **1,088.2793 ns** |  **69.00** |    **4.62** |
|                                   LowCostLinqWithDelegate |         [1000] |  7,234.8569 ns |   4.5506 ns |     4.2566 ns |  29.16 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,984.7522 ns |   1.2087 ns |     1.0715 ns |  28.15 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  7,482.6341 ns |   0.5329 ns |     0.4450 ns |  30.16 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  7,250.0379 ns |   2.0264 ns |     1.8955 ns |  29.22 |    0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,550.5826 ns |   0.0876 ns |     0.0819 ns |   6.25 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,364.3268 ns |   0.9914 ns |     0.9273 ns |   5.50 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  9,617.6654 ns |   2.3666 ns |     2.0980 ns |  38.76 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  9,376.5077 ns |   0.9560 ns |     0.8475 ns |  37.79 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,397.7112 ns |   0.9978 ns |     0.7790 ns |  13.69 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,475.4869 ns |  31.2316 ns |    26.0798 ns |  14.01 |    0.10 |
|                                                 LinqCount |         [1000] | 12,365.0664 ns | 306.7808 ns |   904.5500 ns |  50.45 |    2.81 |
|                              LowCostLinqWithDelegateCount |         [1000] |  6,751.4628 ns |   2.3228 ns |     2.0591 ns |  27.21 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  6,988.0757 ns |   2.2590 ns |     2.1131 ns |  28.16 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    516.7463 ns |   0.3395 ns |     0.3009 ns |   2.08 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    512.0672 ns |   0.0817 ns |     0.0638 ns |   2.06 |    0.00 |
|                                               LinqToArray |         [1000] | 12,845.1895 ns | 252.8916 ns |   337.6030 ns |  51.81 |    1.39 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  8,001.5823 ns |   3.5943 ns |     3.1862 ns |  32.25 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,739.3650 ns |   6.3238 ns |     5.2806 ns |  31.19 |    0.02 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,623.5257 ns |   2.1899 ns |     2.0484 ns |   6.54 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,539.1871 ns |   1.5998 ns |     1.4182 ns |   6.20 |    0.01 |
|                                                      Take |         [1000] |    490.4216 ns |   6.7770 ns |     6.3392 ns |   1.98 |    0.03 |
|                                               LowCostTake |         [1000] |    199.6125 ns |   0.1746 ns |     0.1633 ns |   0.80 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    201.5970 ns |   0.0745 ns |     0.0660 ns |   0.81 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     84.3561 ns |   0.0314 ns |     0.0294 ns |   0.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     75.8874 ns |   0.0356 ns |     0.0315 ns |   0.31 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    416.0675 ns |   3.6704 ns |     3.4333 ns |   1.68 |    0.01 |
|                                     LowCostSkipTakeSingle |         [1000] |    226.2780 ns |   0.0391 ns |     0.0366 ns |   0.91 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    217.7039 ns |   0.0710 ns |     0.0664 ns |   0.88 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     99.7733 ns |   0.0623 ns |     0.0583 ns |   0.40 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     98.3349 ns |   0.0883 ns |     0.0826 ns |   0.40 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,446.4662 ns |   2.6477 ns |     2.4767 ns |  25.98 |    0.01 |
|                                                   Foreach |         [1000] |    484.5751 ns |   0.0484 ns |     0.0429 ns |   1.95 |    0.00 |
|                                                       For |         [1000] |    248.1289 ns |   0.0204 ns |     0.0191 ns |   1.00 |    0.00 |
|                                                           |                |                |             |               |        |         |
|                                                      **Linq** |           **[50]** |    **821.8713 ns** |  **16.4695 ns** |    **25.6410 ns** |  **59.22** |    **2.14** |
|                                   LowCostLinqWithDelegate |           [50] |    388.0740 ns |   0.1528 ns |     0.1355 ns |  27.75 |    0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    368.8907 ns |   0.0448 ns |     0.0419 ns |  26.38 |    0.07 |
|                                  LowCostLinqWithDelegate2 |           [50] |    422.5565 ns |   0.1231 ns |     0.1152 ns |  30.22 |    0.08 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    409.2186 ns |   0.0226 ns |     0.0200 ns |  29.27 |    0.08 |
|                                LowCostLinqWithStructWhere |           [50] |    119.9525 ns |   0.0259 ns |     0.0243 ns |   8.58 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    103.9446 ns |   0.0870 ns |     0.0727 ns |   7.43 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    532.9872 ns |   0.2986 ns |     0.2647 ns |  38.12 |    0.10 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    533.4298 ns |   0.2602 ns |     0.2307 ns |  38.15 |    0.10 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    226.3393 ns |   0.1242 ns |     0.1101 ns |  16.19 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    224.5028 ns |   0.0554 ns |     0.0491 ns |  16.06 |    0.04 |
|                                                 LinqCount |           [50] |    591.0685 ns |  11.5579 ns |    13.3101 ns |  42.24 |    1.15 |
|                              LowCostLinqWithDelegateCount |           [50] |    361.7066 ns |   0.1787 ns |     0.1584 ns |  25.87 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    351.8661 ns |   0.1980 ns |     0.1755 ns |  25.16 |    0.07 |
|                           LowCostLinqWithStructWhereCount |           [50] |     57.3082 ns |   0.0928 ns |     0.0868 ns |   4.10 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     54.1279 ns |   0.0414 ns |     0.0323 ns |   3.87 |    0.01 |
|                                               LinqToArray |           [50] |    736.0830 ns |   9.1551 ns |     8.1157 ns |  52.64 |    0.64 |
|                            LowCostLinqWithDelegateToArray |           [50] |    480.5296 ns |   0.4445 ns |     0.3941 ns |  34.36 |    0.10 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    492.1035 ns |   0.2964 ns |     0.2627 ns |  35.19 |    0.09 |
|                              LowCostLinqWithStructToArray |           [50] |    149.7073 ns |   0.4282 ns |     0.3796 ns |  10.71 |    0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    145.2254 ns |   0.1883 ns |     0.1762 ns |  10.39 |    0.03 |
|                                                      Take |           [50] |    479.6293 ns |   6.2359 ns |     5.8331 ns |  34.30 |    0.40 |
|                                               LowCostTake |           [50] |    200.3366 ns |   0.1201 ns |     0.1124 ns |  14.33 |    0.04 |
|                                  LowCostTakeWithoutChecks |           [50] |    199.8412 ns |   0.0133 ns |     0.0124 ns |  14.29 |    0.04 |
|                                     LowCostTakeWithStruct |           [50] |     84.3535 ns |   0.0305 ns |     0.0270 ns |   6.03 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     76.1120 ns |   0.0455 ns |     0.0404 ns |   5.44 |    0.02 |
|                                            SkipTakeSingle |           [50] |    422.1365 ns |   4.1371 ns |     3.8699 ns |  30.19 |    0.28 |
|                                     LowCostSkipTakeSingle |           [50] |    225.2431 ns |   0.1527 ns |     0.1354 ns |  16.11 |    0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    218.0633 ns |   0.0806 ns |     0.0754 ns |  15.59 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    101.2130 ns |   0.0709 ns |     0.0663 ns |   7.24 |    0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     98.5991 ns |   0.0800 ns |     0.0749 ns |   7.05 |    0.02 |
|                                           ForeachDelegate |           [50] |    331.6057 ns |   0.1112 ns |     0.0986 ns |  23.71 |    0.06 |
|                                                   Foreach |           [50] |     23.3075 ns |   0.0338 ns |     0.0316 ns |   1.67 |    0.00 |
|                                                       For |           [50] |     13.9833 ns |   0.0373 ns |     0.0349 ns |   1.00 |    0.00 |
|                                                           |                |                |             |               |        |         |
|                                                      **Linq** |            **[5]** |    **161.8235 ns** |   **0.4759 ns** |     **0.4452 ns** |  **78.93** |    **0.29** |
|                                   LowCostLinqWithDelegate |            [5] |     65.7404 ns |   0.2590 ns |     0.2423 ns |  32.06 |    0.16 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     59.9466 ns |   0.1773 ns |     0.1658 ns |  29.24 |    0.10 |
|                                  LowCostLinqWithDelegate2 |            [5] |     84.3755 ns |   0.0424 ns |     0.0397 ns |  41.15 |    0.12 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     80.0019 ns |   0.0338 ns |     0.0316 ns |  39.02 |    0.12 |
|                                LowCostLinqWithStructWhere |            [5] |     46.6020 ns |   0.0016 ns |     0.0014 ns |  22.73 |    0.07 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     41.5539 ns |   0.0011 ns |     0.0010 ns |  20.27 |    0.06 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |     99.8645 ns |   0.0576 ns |     0.0510 ns |  48.71 |    0.15 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     97.6238 ns |   0.0352 ns |     0.0312 ns |  47.62 |    0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     56.5092 ns |   0.0087 ns |     0.0073 ns |  27.57 |    0.08 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     53.7141 ns |   0.0162 ns |     0.0143 ns |  26.20 |    0.08 |
|                                                 LinqCount |            [5] |    137.2275 ns |   0.3176 ns |     0.2971 ns |  66.93 |    0.25 |
|                              LowCostLinqWithDelegateCount |            [5] |     54.2944 ns |   0.1081 ns |     0.0958 ns |  26.48 |    0.08 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     53.9708 ns |   0.0671 ns |     0.0628 ns |  26.32 |    0.09 |
|                           LowCostLinqWithStructWhereCount |            [5] |     30.4057 ns |   0.0010 ns |     0.0008 ns |  14.84 |    0.04 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     29.3377 ns |   0.0011 ns |     0.0011 ns |  14.31 |    0.04 |
|                                               LinqToArray |            [5] |    176.5075 ns |   0.4455 ns |     0.4167 ns |  86.09 |    0.32 |
|                            LowCostLinqWithDelegateToArray |            [5] |     74.8055 ns |   0.0814 ns |     0.0762 ns |  36.48 |    0.11 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     75.3071 ns |   0.1222 ns |     0.1143 ns |  36.73 |    0.13 |
|                              LowCostLinqWithStructToArray |            [5] |     60.5670 ns |   0.0137 ns |     0.0122 ns |  29.54 |    0.09 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     57.8705 ns |   0.0134 ns |     0.0119 ns |  28.23 |    0.09 |
|                                                      Take |            [5] |    219.9116 ns |   0.5572 ns |     0.5212 ns | 107.26 |    0.37 |
|                                               LowCostTake |            [5] |     73.3205 ns |   0.0906 ns |     0.0848 ns |  35.76 |    0.13 |
|                                  LowCostTakeWithoutChecks |            [5] |     64.3850 ns |   0.0715 ns |     0.0669 ns |  31.40 |    0.12 |
|                                     LowCostTakeWithStruct |            [5] |     58.6716 ns |   0.0048 ns |     0.0045 ns |  28.62 |    0.09 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     53.2075 ns |   0.0020 ns |     0.0019 ns |  25.95 |    0.08 |
|                                            SkipTakeSingle |            [5] |    208.1953 ns |   0.4689 ns |     0.4386 ns | 101.54 |    0.38 |
|                                     LowCostSkipTakeSingle |            [5] |     69.8186 ns |   0.0390 ns |     0.0346 ns |  34.06 |    0.11 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     68.9015 ns |   0.1094 ns |     0.0914 ns |  33.62 |    0.12 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     60.0723 ns |   0.0164 ns |     0.0153 ns |  29.30 |    0.09 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     59.0980 ns |   0.0070 ns |     0.0062 ns |  28.83 |    0.09 |
|                                           ForeachDelegate |            [5] |     35.1011 ns |   0.0506 ns |     0.0473 ns |  17.12 |    0.06 |
|                                                   Foreach |            [5] |      4.1620 ns |   0.0141 ns |     0.0132 ns |   2.03 |    0.01 |
|                                                       For |            [5] |      2.0503 ns |   0.0066 ns |     0.0062 ns |   1.00 |    0.00 |
