``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |       Error |        StdDev |        Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|------------:|--------------:|--------------:|------:|--------:|
|                                         **Linq** |            **[0]** |     **49.165 ns** |   **0.0189 ns** |     **0.0177 ns** |     **49.170 ns** | **13.81** |    **0.01** |
|                      LowCostLinqWithDelegate |            [0] |     20.329 ns |   0.0040 ns |     0.0037 ns |     20.329 ns |  5.71 |    0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |     38.350 ns |   0.0044 ns |     0.0041 ns |     38.350 ns | 10.77 |    0.00 |
|                   LowCostLinqWithStructWhere |            [0] |     28.330 ns |   0.0072 ns |     0.0064 ns |     28.329 ns |  7.96 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     60.826 ns |   0.0256 ns |     0.0240 ns |     60.826 ns | 17.09 |    0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     48.812 ns |   0.0681 ns |     0.0637 ns |     48.776 ns | 13.71 |    0.02 |
|                                    LinqCount |            [0] |     48.585 ns |   0.0300 ns |     0.0251 ns |     48.585 ns | 13.65 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |     23.931 ns |   0.0455 ns |     0.0426 ns |     23.941 ns |  6.72 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     21.069 ns |   0.0056 ns |     0.0053 ns |     21.070 ns |  5.92 |    0.00 |
|                                  LinqToArray |            [0] |     64.561 ns |   0.0436 ns |     0.0386 ns |     64.566 ns | 18.13 |    0.01 |
|               LowCostLinqWithDelegateToArray |            [0] |     28.550 ns |   0.0393 ns |     0.0348 ns |     28.548 ns |  8.02 |    0.01 |
|                 LowCostLinqWithStructToArray |            [0] |     25.963 ns |   0.0113 ns |     0.0105 ns |     25.963 ns |  7.29 |    0.00 |
|                                         Take |            [0] |     87.128 ns |   0.1362 ns |     0.1274 ns |     87.069 ns | 24.48 |    0.03 |
|                                  LowCostTake |            [0] |     29.642 ns |   0.0030 ns |     0.0025 ns |     29.642 ns |  8.33 |    0.00 |
|                        LowCostTakeWithStruct |            [0] |     34.888 ns |   0.0064 ns |     0.0060 ns |     34.888 ns |  9.80 |    0.00 |
|                               SkipTakeSingle |            [0] |    108.804 ns |   0.0222 ns |     0.0186 ns |    108.810 ns | 30.56 |    0.01 |
|                        LowCostSkipTakeSingle |            [0] |     38.049 ns |   0.0068 ns |     0.0063 ns |     38.047 ns | 10.69 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     41.069 ns |   0.0053 ns |     0.0050 ns |     41.070 ns | 11.54 |    0.00 |
|                              ForeachDelegate |            [0] |      6.912 ns |   0.0031 ns |     0.0029 ns |      6.912 ns |  1.94 |    0.00 |
|                                      Foreach |            [0] |      4.123 ns |   0.0017 ns |     0.0016 ns |      4.123 ns |  1.16 |    0.00 |
|                                          For |            [0] |      3.560 ns |   0.0012 ns |     0.0010 ns |      3.560 ns |  1.00 |    0.00 |
|                                              |                |               |             |               |               |       |         |
|                                         **Linq** |         **[1000]** |  **7,763.885 ns** |   **4.2684 ns** |     **3.9926 ns** |  **7,763.818 ns** | **30.77** |    **0.02** |
|                      LowCostLinqWithDelegate |         [1000] |  4,941.215 ns |  98.5665 ns |   214.2754 ns |  4,802.233 ns | 19.75 |    0.75 |
|                     LowCostLinqWithDelegate2 |         [1000] |  6,434.114 ns |  58.6524 ns |    54.8635 ns |  6,428.193 ns | 25.49 |    0.22 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,222.441 ns |   0.4226 ns |     0.3953 ns |  1,222.521 ns |  4.84 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,123.107 ns | 454.7217 ns | 1,340.7572 ns | 19,779.753 ns | 80.89 |    2.00 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  6,032.618 ns |   1.2906 ns |     1.2073 ns |  6,032.550 ns | 23.91 |    0.01 |
|                                    LinqCount |         [1000] |  3,687.037 ns |   3.4026 ns |     3.1828 ns |  3,686.559 ns | 14.61 |    0.01 |
|                 LowCostLinqWithDelegateCount |         [1000] |  5,099.226 ns |  20.8702 ns |    18.5009 ns |  5,103.030 ns | 20.21 |    0.07 |
|              LowCostLinqWithStructWhereCount |         [1000] |    516.002 ns |   0.1587 ns |     0.1406 ns |    515.969 ns |  2.05 |    0.00 |
|                                  LinqToArray |         [1000] |  4,889.117 ns |   2.8930 ns |     2.7061 ns |  4,888.555 ns | 19.38 |    0.01 |
|               LowCostLinqWithDelegateToArray |         [1000] |  6,447.019 ns |   2.9327 ns |     2.5997 ns |  6,447.383 ns | 25.55 |    0.01 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,267.219 ns |  10.2087 ns |     9.5492 ns |  2,268.177 ns |  8.98 |    0.04 |
|                                         Take |         [1000] |    361.477 ns |   0.8911 ns |     0.7441 ns |    361.359 ns |  1.43 |    0.00 |
|                                  LowCostTake |         [1000] |    144.339 ns |   2.9012 ns |     5.7940 ns |    142.920 ns |  0.58 |    0.02 |
|                        LowCostTakeWithStruct |         [1000] |     61.507 ns |   0.0126 ns |     0.0118 ns |     61.512 ns |  0.24 |    0.00 |
|                               SkipTakeSingle |         [1000] |    271.173 ns |   0.3870 ns |     0.3620 ns |    270.997 ns |  1.07 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    145.462 ns |   3.1163 ns |     3.8271 ns |    143.634 ns |  0.58 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     66.481 ns |   0.0427 ns |     0.0399 ns |     66.487 ns |  0.26 |    0.00 |
|                              ForeachDelegate |         [1000] |  3,132.229 ns |   5.5561 ns |     5.1972 ns |  3,134.143 ns | 12.41 |    0.02 |
|                                      Foreach |         [1000] |    480.105 ns |   1.7164 ns |     1.6055 ns |    480.565 ns |  1.90 |    0.01 |
|                                          For |         [1000] |    252.320 ns |   0.0404 ns |     0.0358 ns |    252.319 ns |  1.00 |    0.00 |
|                                              |                |               |             |               |               |       |         |
|                                         **Linq** |           **[50]** |    **456.033 ns** |   **0.1250 ns** |     **0.1170 ns** |    **456.034 ns** | **28.76** |    **0.01** |
|                      LowCostLinqWithDelegate |           [50] |    263.403 ns |   5.6356 ns |     6.9211 ns |    259.774 ns | 16.65 |    0.50 |
|                     LowCostLinqWithDelegate2 |           [50] |    445.688 ns |   8.0628 ns |     7.5420 ns |    445.856 ns | 28.10 |    0.48 |
|                   LowCostLinqWithStructWhere |           [50] |     94.979 ns |   0.0204 ns |     0.0191 ns |     94.979 ns |  5.99 |    0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    890.874 ns |   4.4052 ns |     4.1207 ns |    888.978 ns | 56.17 |    0.26 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    355.653 ns |   0.1614 ns |     0.1509 ns |    355.681 ns | 22.43 |    0.01 |
|                                    LinqCount |           [50] |    246.830 ns |   0.1263 ns |     0.1182 ns |    246.770 ns | 15.56 |    0.01 |
|                 LowCostLinqWithDelegateCount |           [50] |    290.992 ns |   5.7758 ns |    12.3088 ns |    286.758 ns | 18.53 |    0.77 |
|              LowCostLinqWithStructWhereCount |           [50] |     46.109 ns |   0.0999 ns |     0.0934 ns |     46.057 ns |  2.91 |    0.01 |
|                                  LinqToArray |           [50] |    504.323 ns |   0.3588 ns |     0.3181 ns |    504.385 ns | 31.80 |    0.02 |
|               LowCostLinqWithDelegateToArray |           [50] |    443.388 ns |   0.6016 ns |     0.5333 ns |    443.126 ns | 27.96 |    0.04 |
|                 LowCostLinqWithStructToArray |           [50] |    194.894 ns |   0.1477 ns |     0.1310 ns |    194.930 ns | 12.29 |    0.01 |
|                                         Take |           [50] |    360.708 ns |   0.1520 ns |     0.1347 ns |    360.662 ns | 22.74 |    0.01 |
|                                  LowCostTake |           [50] |    148.711 ns |   1.1670 ns |     1.0916 ns |    148.816 ns |  9.38 |    0.07 |
|                        LowCostTakeWithStruct |           [50] |     61.851 ns |   0.0101 ns |     0.0095 ns |     61.851 ns |  3.90 |    0.00 |
|                               SkipTakeSingle |           [50] |    257.429 ns |   0.0757 ns |     0.0708 ns |    257.428 ns | 16.23 |    0.01 |
|                        LowCostSkipTakeSingle |           [50] |    147.208 ns |   3.1494 ns |     3.7491 ns |    145.082 ns |  9.34 |    0.26 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     68.223 ns |   0.0577 ns |     0.0540 ns |     68.213 ns |  4.30 |    0.00 |
|                              ForeachDelegate |           [50] |    166.746 ns |   0.2351 ns |     0.2199 ns |    166.757 ns | 10.51 |    0.01 |
|                                      Foreach |           [50] |     26.463 ns |   0.0494 ns |     0.0462 ns |     26.475 ns |  1.67 |    0.00 |
|                                          For |           [50] |     15.859 ns |   0.0064 ns |     0.0060 ns |     15.859 ns |  1.00 |    0.00 |
|                                              |                |               |             |               |               |       |         |
|                                         **Linq** |            **[5]** |     **98.565 ns** |   **0.1494 ns** |     **0.1397 ns** |     **98.509 ns** | **19.59** |    **0.03** |
|                      LowCostLinqWithDelegate |            [5] |     45.979 ns |   0.9353 ns |     2.0725 ns |     44.853 ns |  9.13 |    0.45 |
|                     LowCostLinqWithDelegate2 |            [5] |     66.881 ns |   2.0949 ns |     1.9595 ns |     65.835 ns | 13.29 |    0.39 |
|                   LowCostLinqWithStructWhere |            [5] |     34.407 ns |   0.0229 ns |     0.0203 ns |     34.400 ns |  6.84 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    143.749 ns |   0.1171 ns |     0.1095 ns |    143.747 ns | 28.57 |    0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     80.711 ns |   1.9707 ns |     1.8434 ns |     79.689 ns | 16.04 |    0.36 |
|                                    LinqCount |            [5] |     80.777 ns |   0.0367 ns |     0.0325 ns |     80.780 ns | 16.06 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |     50.635 ns |   0.2486 ns |     0.2204 ns |     50.654 ns | 10.06 |    0.04 |
|              LowCostLinqWithStructWhereCount |            [5] |     23.482 ns |   0.0021 ns |     0.0019 ns |     23.482 ns |  4.67 |    0.00 |
|                                  LinqToArray |            [5] |    142.291 ns |   0.1899 ns |     0.1776 ns |    142.246 ns | 28.28 |    0.04 |
|               LowCostLinqWithDelegateToArray |            [5] |     86.499 ns |   0.3130 ns |     0.2928 ns |     86.604 ns | 17.19 |    0.06 |
|                 LowCostLinqWithStructToArray |            [5] |     57.251 ns |   0.0303 ns |     0.0284 ns |     57.247 ns | 11.38 |    0.01 |
|                                         Take |            [5] |    165.775 ns |   0.1493 ns |     0.1324 ns |    165.735 ns | 32.95 |    0.03 |
|                                  LowCostTake |            [5] |     57.247 ns |   1.1518 ns |     1.7932 ns |     56.982 ns | 11.45 |    0.35 |
|                        LowCostTakeWithStruct |            [5] |     42.848 ns |   0.0077 ns |     0.0072 ns |     42.847 ns |  8.52 |    0.01 |
|                               SkipTakeSingle |            [5] |    150.724 ns |   0.0480 ns |     0.0449 ns |    150.715 ns | 29.96 |    0.02 |
|                        LowCostSkipTakeSingle |            [5] |     57.497 ns |   0.1151 ns |     0.1021 ns |     57.514 ns | 11.43 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     44.788 ns |   0.0237 ns |     0.0221 ns |     44.782 ns |  8.90 |    0.01 |
|                              ForeachDelegate |            [5] |     23.361 ns |   0.0516 ns |     0.0482 ns |     23.355 ns |  4.64 |    0.01 |
|                                      Foreach |            [5] |      5.763 ns |   0.0079 ns |     0.0074 ns |      5.764 ns |  1.15 |    0.00 |
|                                          For |            [5] |      5.031 ns |   0.0031 ns |     0.0029 ns |      5.032 ns |  1.00 |    0.00 |
