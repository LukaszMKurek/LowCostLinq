``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **94.835 ns** |   **0.0822 ns** |   **0.0769 ns** |     **94.850 ns** | **23.68** |    **0.26** |
|                                   LowCostLinqWithDelegate |            [0] |     31.597 ns |   0.0068 ns |   0.0063 ns |     31.595 ns |  7.89 |    0.09 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     22.969 ns |   0.0036 ns |   0.0034 ns |     22.970 ns |  5.74 |    0.06 |
|                                  LowCostLinqWithDelegate2 |            [0] |     53.199 ns |   0.1019 ns |   0.0953 ns |     53.241 ns | 13.28 |    0.15 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     48.517 ns |   0.0228 ns |   0.0214 ns |     48.516 ns | 12.11 |    0.13 |
|                                LowCostLinqWithStructWhere |            [0] |     42.235 ns |   0.0039 ns |   0.0036 ns |     42.235 ns | 10.55 |    0.12 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     36.595 ns |   0.0082 ns |   0.0077 ns |     36.596 ns |  9.14 |    0.10 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     62.156 ns |   0.1736 ns |   0.1624 ns |     62.192 ns | 15.53 |    0.18 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     54.540 ns |   0.0693 ns |   0.0649 ns |     54.554 ns | 13.62 |    0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     51.350 ns |   0.1004 ns |   0.0784 ns |     51.321 ns | 12.85 |    0.09 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     42.067 ns |   0.2118 ns |   0.1981 ns |     41.974 ns | 10.51 |    0.14 |
|                                                 LinqCount |            [0] |     93.937 ns |   0.0857 ns |   0.0802 ns |     93.893 ns | 23.45 |    0.26 |
|                              LowCostLinqWithDelegateCount |            [0] |     26.419 ns |   0.0125 ns |   0.0117 ns |     26.419 ns |  6.60 |    0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     25.538 ns |   0.0249 ns |   0.0233 ns |     25.535 ns |  6.38 |    0.07 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.084 ns |   0.0781 ns |   0.0730 ns |     37.117 ns |  9.26 |    0.11 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     28.788 ns |   0.0099 ns |   0.0088 ns |     28.791 ns |  7.19 |    0.08 |
|                                               LinqToArray |            [0] |    117.683 ns |   0.1359 ns |   0.1134 ns |    117.711 ns | 29.38 |    0.33 |
|                            LowCostLinqWithDelegateToArray |            [0] |     31.250 ns |   0.0225 ns |   0.0210 ns |     31.252 ns |  7.80 |    0.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     28.759 ns |   0.0407 ns |   0.0381 ns |     28.754 ns |  7.18 |    0.08 |
|                              LowCostLinqWithStructToArray |            [0] |     38.890 ns |   0.0056 ns |   0.0050 ns |     38.892 ns |  9.71 |    0.11 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     31.864 ns |   0.0521 ns |   0.0488 ns |     31.880 ns |  7.96 |    0.09 |
|                                                      Take |            [0] |    139.359 ns |   0.1938 ns |   0.1813 ns |    139.328 ns | 34.80 |    0.41 |
|                                               LowCostTake |            [0] |     36.388 ns |   0.0145 ns |   0.0129 ns |     36.388 ns |  9.09 |    0.10 |
|                                  LowCostTakeWithoutChecks |            [0] |     33.763 ns |   0.0060 ns |   0.0056 ns |     33.764 ns |  8.43 |    0.09 |
|                                     LowCostTakeWithStruct |            [0] |     49.667 ns |   0.1214 ns |   0.0947 ns |     49.646 ns | 12.43 |    0.07 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     42.891 ns |   0.1161 ns |   0.0907 ns |     42.880 ns | 10.74 |    0.08 |
|                                            SkipTakeSingle |            [0] |    161.042 ns |   1.1692 ns |   1.0364 ns |    160.591 ns | 40.23 |    0.59 |
|                                     LowCostSkipTakeSingle |            [0] |     44.767 ns |   0.6898 ns |   0.6115 ns |     44.494 ns | 11.18 |    0.22 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     41.890 ns |   0.6139 ns |   0.5743 ns |     41.698 ns | 10.45 |    0.16 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     56.442 ns |   0.1519 ns |   0.1269 ns |     56.477 ns | 14.09 |    0.15 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     48.800 ns |   0.1803 ns |   0.1686 ns |     48.802 ns | 12.19 |    0.16 |
|                                           ForeachDelegate |            [0] |     16.547 ns |   0.4358 ns |   0.3863 ns |     16.370 ns |  4.12 |    0.11 |
|                                                   Foreach |            [0] |     12.765 ns |   0.2805 ns |   0.2624 ns |     12.613 ns |  3.19 |    0.09 |
|                                                       For |            [0] |      4.006 ns |   0.0549 ns |   0.0458 ns |      3.996 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** | **13,310.341 ns** | **287.5760 ns** | **488.3259 ns** | **13,267.049 ns** | **53.05** |    **2.07** |
|                                   LowCostLinqWithDelegate |         [1000] |  8,955.223 ns | 348.4972 ns | 387.3537 ns |  8,844.911 ns | 35.93 |    1.61 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  8,221.331 ns | 159.0077 ns | 242.8215 ns |  8,171.625 ns | 32.97 |    1.06 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,077.978 ns |  93.5945 ns |  87.5484 ns | 11,066.960 ns | 44.10 |    0.35 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  8,886.655 ns | 145.2878 ns | 135.9023 ns |  8,817.595 ns | 35.37 |    0.54 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,849.635 ns |   0.2843 ns |   0.2520 ns |  1,849.564 ns |  7.36 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,376.633 ns |   0.8664 ns |   0.7235 ns |  1,376.544 ns |  5.48 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 18,808.801 ns | 373.9497 ns | 702.3682 ns | 19,148.172 ns | 74.93 |    2.53 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 17,450.885 ns | 348.2832 ns | 764.4900 ns | 16,992.778 ns | 69.35 |    2.74 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,560.628 ns |   1.4953 ns |   1.3255 ns |  5,560.516 ns | 22.13 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  4,598.698 ns |   0.6395 ns |   0.5669 ns |  4,598.527 ns | 18.31 |    0.01 |
|                                                 LinqCount |         [1000] |  6,995.434 ns |  57.4815 ns |  53.7683 ns |  6,998.807 ns | 27.85 |    0.22 |
|                              LowCostLinqWithDelegateCount |         [1000] |  8,986.515 ns | 164.0670 ns | 137.0034 ns |  8,932.701 ns | 35.77 |    0.55 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,838.919 ns | 231.6412 ns | 682.9993 ns |  8,780.543 ns | 34.11 |    1.98 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,714.514 ns |   0.8172 ns |   0.6380 ns |  1,714.798 ns |  6.82 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    631.070 ns |   0.0626 ns |   0.0555 ns |    631.064 ns |  2.51 |    0.00 |
|                                               LinqToArray |         [1000] |  8,931.282 ns |  28.0534 ns |  24.8686 ns |  8,927.728 ns | 35.55 |    0.10 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  9,254.390 ns |  15.5347 ns |  14.5311 ns |  9,250.615 ns | 36.84 |    0.06 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  9,595.659 ns |   8.2580 ns |   7.3205 ns |  9,595.666 ns | 38.20 |    0.03 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,932.833 ns |   6.6309 ns |   6.2026 ns |  2,934.278 ns | 11.67 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,850.397 ns |   6.0863 ns |   5.3954 ns |  1,851.637 ns |  7.37 |    0.02 |
|                                                      Take |         [1000] |    485.284 ns |   2.1466 ns |   2.0079 ns |    485.286 ns |  1.93 |    0.01 |
|                                               LowCostTake |         [1000] |    213.731 ns |   3.9150 ns |   3.2692 ns |    212.460 ns |  0.85 |    0.01 |
|                                  LowCostTakeWithoutChecks |         [1000] |    294.987 ns |   3.7989 ns |   3.5535 ns |    295.738 ns |  1.17 |    0.01 |
|                                     LowCostTakeWithStruct |         [1000] |     90.788 ns |   0.0191 ns |   0.0179 ns |     90.790 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     72.686 ns |   0.0143 ns |   0.0134 ns |     72.687 ns |  0.29 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    391.191 ns |   0.3479 ns |   0.3254 ns |    391.207 ns |  1.56 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    248.497 ns |   4.9619 ns |  12.5392 ns |    244.864 ns |  1.00 |    0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    229.379 ns |   1.0254 ns |   0.8006 ns |    229.468 ns |  0.91 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    112.304 ns |   0.1478 ns |   0.1382 ns |    112.323 ns |  0.45 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     77.650 ns |   0.0219 ns |   0.0183 ns |     77.646 ns |  0.31 |    0.00 |
|                                           ForeachDelegate |         [1000] |  5,996.605 ns |   0.7332 ns |   0.6859 ns |  5,996.629 ns | 23.87 |    0.01 |
|                                                   Foreach |         [1000] |  1,691.134 ns |   0.9841 ns |   0.9205 ns |  1,691.120 ns |  6.73 |    0.00 |
|                                                       For |         [1000] |    251.217 ns |   0.0627 ns |   0.0587 ns |    251.209 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **730.411 ns** |   **1.8340 ns** |   **1.4318 ns** |    **730.972 ns** | **44.37** |    **0.12** |
|                                   LowCostLinqWithDelegate |           [50] |    445.574 ns |   4.7696 ns |   3.9829 ns |    444.224 ns | 27.07 |    0.27 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    456.855 ns |   3.8408 ns |   3.5927 ns |    455.567 ns | 27.75 |    0.23 |
|                                  LowCostLinqWithDelegate2 |           [50] |    566.322 ns |  11.4135 ns |  33.4739 ns |    558.200 ns | 33.60 |    1.75 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    536.928 ns |  17.0401 ns |  50.2432 ns |    512.508 ns | 32.38 |    2.63 |
|                                LowCostLinqWithStructWhere |           [50] |    140.068 ns |   0.0182 ns |   0.0161 ns |    140.065 ns |  8.51 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    111.236 ns |   0.0177 ns |   0.0157 ns |    111.235 ns |  6.76 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    994.837 ns |   8.0797 ns |   7.5578 ns |    991.252 ns | 60.42 |    0.45 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    914.348 ns |  10.1206 ns |   9.4668 ns |    911.966 ns | 55.54 |    0.57 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    339.986 ns |   0.1495 ns |   0.1326 ns |    339.956 ns | 20.65 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    278.531 ns |   0.0598 ns |   0.0530 ns |    278.528 ns | 16.92 |    0.03 |
|                                                 LinqCount |           [50] |    414.743 ns |   0.3904 ns |   0.3260 ns |    414.771 ns | 25.19 |    0.04 |
|                              LowCostLinqWithDelegateCount |           [50] |    713.419 ns |  13.4235 ns |  12.5563 ns |    714.768 ns | 43.33 |    0.78 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    475.166 ns |  12.4428 ns |  36.6878 ns |    467.892 ns | 29.22 |    1.55 |
|                           LowCostLinqWithStructWhereCount |           [50] |    126.716 ns |   0.0591 ns |   0.0553 ns |    126.704 ns |  7.70 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     58.576 ns |   0.0154 ns |   0.0144 ns |     58.577 ns |  3.56 |    0.01 |
|                                               LinqToArray |           [50] |    739.194 ns |   0.9464 ns |   0.8853 ns |    739.551 ns | 44.90 |    0.10 |
|                            LowCostLinqWithDelegateToArray |           [50] |    609.858 ns |   0.6178 ns |   0.5779 ns |    609.968 ns | 37.04 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    606.507 ns |   0.4509 ns |   0.4218 ns |    606.420 ns | 36.84 |    0.06 |
|                              LowCostLinqWithStructToArray |           [50] |    254.297 ns |   0.0688 ns |   0.0610 ns |    254.286 ns | 15.45 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    197.744 ns |   0.0561 ns |   0.0497 ns |    197.749 ns | 12.01 |    0.02 |
|                                                      Take |           [50] |    484.046 ns |   0.2920 ns |   0.2732 ns |    483.997 ns | 29.40 |    0.05 |
|                                               LowCostTake |           [50] |    233.043 ns |   8.3533 ns |  24.4988 ns |    233.255 ns | 14.56 |    1.16 |
|                                  LowCostTakeWithoutChecks |           [50] |    215.710 ns |   1.8065 ns |   1.6898 ns |    216.019 ns | 13.10 |    0.10 |
|                                     LowCostTakeWithStruct |           [50] |    102.896 ns |   0.0407 ns |   0.0381 ns |    102.909 ns |  6.25 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     73.117 ns |   0.0367 ns |   0.0325 ns |     73.130 ns |  4.44 |    0.01 |
|                                            SkipTakeSingle |           [50] |    390.786 ns |   0.3982 ns |   0.3725 ns |    390.652 ns | 23.74 |    0.05 |
|                                     LowCostSkipTakeSingle |           [50] |    236.183 ns |   1.9917 ns |   1.7656 ns |    235.753 ns | 14.35 |    0.10 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    242.656 ns |   4.8509 ns |  13.9183 ns |    236.705 ns | 14.65 |    0.76 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    111.721 ns |   0.1001 ns |   0.0887 ns |    111.690 ns |  6.79 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     77.713 ns |   0.0755 ns |   0.0707 ns |     77.688 ns |  4.72 |    0.01 |
|                                           ForeachDelegate |           [50] |    319.837 ns |   0.0662 ns |   0.0587 ns |    319.839 ns | 19.43 |    0.03 |
|                                                   Foreach |           [50] |    102.963 ns |   0.0910 ns |   0.0852 ns |    102.925 ns |  6.25 |    0.01 |
|                                                       For |           [50] |     16.464 ns |   0.0266 ns |   0.0249 ns |     16.471 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **158.736 ns** |   **0.0759 ns** |   **0.0673 ns** |    **158.714 ns** | **28.56** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |     74.508 ns |   1.7205 ns |   5.0728 ns |     74.108 ns | 12.79 |    0.62 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     65.240 ns |   1.3930 ns |   4.0855 ns |     64.032 ns | 12.24 |    0.85 |
|                                  LowCostLinqWithDelegate2 |            [5] |     98.894 ns |   1.9885 ns |   3.7348 ns |     98.591 ns | 17.62 |    0.58 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     95.369 ns |   2.2349 ns |   6.5897 ns |     94.015 ns | 17.76 |    1.17 |
|                                LowCostLinqWithStructWhere |            [5] |     52.189 ns |   0.0098 ns |   0.0092 ns |     52.188 ns |  9.39 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     44.498 ns |   0.0330 ns |   0.0309 ns |     44.502 ns |  8.01 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    155.685 ns |   0.1004 ns |   0.0939 ns |    155.684 ns | 28.01 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    138.617 ns |   0.1862 ns |   0.1742 ns |    138.628 ns | 24.94 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     78.914 ns |   0.0318 ns |   0.0282 ns |     78.905 ns | 14.20 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     63.124 ns |   0.0877 ns |   0.0820 ns |     63.145 ns | 11.36 |    0.02 |
|                                                 LinqCount |            [5] |    125.056 ns |   0.0443 ns |   0.0414 ns |    125.065 ns | 22.50 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     68.762 ns |   0.3636 ns |   0.3037 ns |     68.780 ns | 12.37 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     69.478 ns |   1.7658 ns |   5.2065 ns |     68.112 ns | 12.20 |    0.74 |
|                           LowCostLinqWithStructWhereCount |            [5] |     44.343 ns |   0.0108 ns |   0.0096 ns |     44.343 ns |  7.98 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     31.172 ns |   0.0027 ns |   0.0026 ns |     31.173 ns |  5.61 |    0.00 |
|                                               LinqToArray |            [5] |    203.290 ns |   0.0564 ns |   0.0471 ns |    203.296 ns | 36.57 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    119.838 ns |   0.1397 ns |   0.1307 ns |    119.803 ns | 21.56 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    113.806 ns |   0.0539 ns |   0.0504 ns |    113.808 ns | 20.47 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |     87.185 ns |   0.1501 ns |   0.1404 ns |     87.211 ns | 15.69 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     74.493 ns |   0.0318 ns |   0.0297 ns |     74.488 ns | 13.40 |    0.01 |
|                                                      Take |            [5] |    234.995 ns |   1.6208 ns |   1.5161 ns |    234.881 ns | 42.28 |    0.28 |
|                                               LowCostTake |            [5] |     77.347 ns |   1.5566 ns |   2.8463 ns |     75.741 ns | 13.91 |    0.51 |
|                                  LowCostTakeWithoutChecks |            [5] |     94.240 ns |   2.3311 ns |   6.8732 ns |     96.632 ns | 17.36 |    0.63 |
|                                     LowCostTakeWithStruct |            [5] |     60.143 ns |   0.0210 ns |   0.0197 ns |     60.145 ns | 10.82 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     51.631 ns |   0.0059 ns |   0.0055 ns |     51.630 ns |  9.29 |    0.00 |
|                                            SkipTakeSingle |            [5] |    207.118 ns |   0.0653 ns |   0.0610 ns |    207.118 ns | 37.26 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     83.512 ns |   1.6851 ns |   3.5174 ns |     81.158 ns | 14.96 |    0.64 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     76.883 ns |   1.5628 ns |   4.1715 ns |     76.331 ns | 13.44 |    0.60 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     66.262 ns |   0.0473 ns |   0.0420 ns |     66.262 ns | 11.92 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.198 ns |   0.0227 ns |   0.0212 ns |     55.204 ns |  9.93 |    0.00 |
|                                           ForeachDelegate |            [5] |     45.570 ns |   0.0108 ns |   0.0090 ns |     45.568 ns |  8.20 |    0.00 |
|                                                   Foreach |            [5] |     20.606 ns |   0.0239 ns |   0.0211 ns |     20.601 ns |  3.71 |    0.00 |
|                                                       For |            [5] |      5.558 ns |   0.0013 ns |   0.0012 ns |      5.558 ns |  1.00 |    0.00 |
