``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |       Error |      StdDev |        Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|------------:|------------:|--------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **150.436 ns** |   **0.0745 ns** |   **0.0622 ns** |    **150.424 ns** | **33.47** |    **0.03** |
|                                   LowCostLinqWithDelegate |            [0] |     38.921 ns |   0.0187 ns |   0.0175 ns |     38.915 ns |  8.66 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     33.319 ns |   0.0064 ns |   0.0060 ns |     33.318 ns |  7.41 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     66.446 ns |   0.0150 ns |   0.0140 ns |     66.448 ns | 14.78 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     57.699 ns |   0.0118 ns |   0.0110 ns |     57.697 ns | 12.84 |    0.01 |
|                                LowCostLinqWithStructWhere |            [0] |     50.349 ns |   0.0224 ns |   0.0210 ns |     50.353 ns | 11.20 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     43.092 ns |   0.0078 ns |   0.0073 ns |     43.093 ns |  9.59 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     69.406 ns |   0.0618 ns |   0.0516 ns |     69.426 ns | 15.44 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     67.582 ns |   0.0356 ns |   0.0316 ns |     67.583 ns | 15.04 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     66.649 ns |   0.0341 ns |   0.0303 ns |     66.651 ns | 14.83 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     59.602 ns |   0.0219 ns |   0.0204 ns |     59.596 ns | 13.26 |    0.01 |
|                                                 LinqCount |            [0] |    124.272 ns |   0.3828 ns |   0.3581 ns |    124.409 ns | 27.65 |    0.09 |
|                              LowCostLinqWithDelegateCount |            [0] |     31.176 ns |   0.0080 ns |   0.0071 ns |     31.172 ns |  6.94 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     29.308 ns |   0.0079 ns |   0.0074 ns |     29.310 ns |  6.52 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     44.475 ns |   0.0094 ns |   0.0084 ns |     44.475 ns |  9.90 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     36.369 ns |   0.0476 ns |   0.0445 ns |     36.379 ns |  8.09 |    0.01 |
|                                               LinqToArray |            [0] |    135.623 ns |   0.0477 ns |   0.0373 ns |    135.621 ns | 30.17 |    0.03 |
|                            LowCostLinqWithDelegateToArray |            [0] |     34.526 ns |   0.0079 ns |   0.0074 ns |     34.524 ns |  7.68 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     32.808 ns |   0.0042 ns |   0.0039 ns |     32.807 ns |  7.30 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     45.847 ns |   0.0213 ns |   0.0199 ns |     45.853 ns | 10.20 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     38.871 ns |   0.0089 ns |   0.0083 ns |     38.868 ns |  8.65 |    0.01 |
|                                                      Take |            [0] |    163.553 ns |   0.0709 ns |   0.0663 ns |    163.550 ns | 36.39 |    0.04 |
|                                               LowCostTake |            [0] |     52.704 ns |   0.0068 ns |   0.0053 ns |     52.704 ns | 11.73 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     44.871 ns |   0.0059 ns |   0.0055 ns |     44.870 ns |  9.98 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     63.123 ns |   0.0089 ns |   0.0074 ns |     63.120 ns | 14.04 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     54.856 ns |   0.0084 ns |   0.0079 ns |     54.856 ns | 12.20 |    0.01 |
|                                            SkipTakeSingle |            [0] |    185.829 ns |   0.0671 ns |   0.0628 ns |    185.816 ns | 41.34 |    0.04 |
|                                     LowCostSkipTakeSingle |            [0] |     61.721 ns |   0.0095 ns |   0.0088 ns |     61.723 ns | 13.73 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     60.145 ns |   0.0185 ns |   0.0164 ns |     60.143 ns | 13.38 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     69.200 ns |   0.0123 ns |   0.0109 ns |     69.201 ns | 15.40 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     67.452 ns |   0.0175 ns |   0.0163 ns |     67.458 ns | 15.01 |    0.01 |
|                                           ForeachDelegate |            [0] |     16.388 ns |   0.0050 ns |   0.0044 ns |     16.389 ns |  3.65 |    0.00 |
|                                                   Foreach |            [0] |     12.729 ns |   0.0259 ns |   0.0230 ns |     12.736 ns |  2.83 |    0.01 |
|                                                       For |            [0] |      4.495 ns |   0.0043 ns |   0.0040 ns |      4.496 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |         **[1000]** | **15,249.515 ns** | **303.6445 ns** | **435.4779 ns** | **15,024.444 ns** | **60.90** |    **1.77** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,857.890 ns | 235.0126 ns | 631.3461 ns | 11,770.985 ns | 47.80 |    2.84 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,834.660 ns | 124.7960 ns | 104.2103 ns | 10,769.890 ns | 43.13 |    0.42 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 13,527.112 ns | 270.3993 ns | 735.6412 ns | 13,507.220 ns | 54.15 |    3.72 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 12,355.853 ns | 245.3446 ns | 489.9797 ns | 12,064.824 ns | 48.78 |    1.97 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,854.246 ns |   0.2970 ns |   0.2633 ns |  1,854.313 ns |  7.38 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,383.938 ns |   0.1965 ns |   0.1742 ns |  1,383.930 ns |  5.51 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,785.293 ns | 518.3341 ns | 576.1270 ns | 19,522.122 ns | 79.15 |    2.45 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,399.109 ns | 387.9593 ns | 709.4055 ns | 19,424.226 ns | 78.01 |    3.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  4,859.583 ns |   2.6296 ns |   2.4598 ns |  4,859.396 ns | 19.35 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,902.695 ns |   0.9506 ns |   0.8892 ns |  3,902.824 ns | 15.54 |    0.01 |
|                                                 LinqCount |         [1000] | 10,372.998 ns |  79.1977 ns |  74.0815 ns | 10,380.214 ns | 41.30 |    0.29 |
|                              LowCostLinqWithDelegateCount |         [1000] | 12,564.619 ns | 249.3178 ns | 652.4213 ns | 12,575.309 ns | 49.53 |    2.63 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,298.250 ns | 208.1059 ns | 173.7779 ns | 10,227.280 ns | 41.00 |    0.70 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,726.023 ns |   0.6748 ns |   0.6312 ns |  1,725.984 ns |  6.87 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    751.689 ns |   0.1282 ns |   0.1199 ns |    751.706 ns |  2.99 |    0.00 |
|                                               LinqToArray |         [1000] | 11,070.594 ns |  21.9800 ns |  20.5601 ns | 11,068.100 ns | 44.08 |    0.08 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 13,138.191 ns |  22.4846 ns |  21.0321 ns | 13,135.481 ns | 52.31 |    0.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,070.123 ns |  21.0962 ns |  19.7334 ns | 11,073.093 ns | 44.07 |    0.08 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,917.060 ns |   7.3989 ns |   6.5589 ns |  2,918.435 ns | 11.61 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,941.490 ns |   4.7480 ns |   4.4413 ns |  1,942.433 ns |  7.73 |    0.02 |
|                                                      Take |         [1000] |    543.067 ns |   0.6758 ns |   0.6322 ns |    543.056 ns |  2.16 |    0.00 |
|                                               LowCostTake |         [1000] |    387.503 ns |   9.5002 ns |  28.0115 ns |    398.528 ns |  1.54 |    0.12 |
|                                  LowCostTakeWithoutChecks |         [1000] |    294.177 ns |   5.8705 ns |  13.2507 ns |    292.815 ns |  1.17 |    0.06 |
|                                     LowCostTakeWithStruct |         [1000] |    112.382 ns |   0.0236 ns |   0.0221 ns |    112.381 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     91.862 ns |   0.0188 ns |   0.0157 ns |     91.856 ns |  0.37 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    487.428 ns |   0.8458 ns |   0.7912 ns |    487.384 ns |  1.94 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    353.522 ns |   7.2091 ns |  20.3334 ns |    344.951 ns |  1.40 |    0.09 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    300.564 ns |   5.8090 ns |   5.1496 ns |    298.984 ns |  1.20 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    155.905 ns |   0.0485 ns |   0.0453 ns |    155.903 ns |  0.62 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    122.472 ns |   0.1989 ns |   0.1861 ns |    122.440 ns |  0.49 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,947.867 ns |   2.7552 ns |   2.5772 ns |  6,947.206 ns | 27.66 |    0.01 |
|                                                   Foreach |         [1000] |  1,693.088 ns |   0.4739 ns |   0.4201 ns |  1,693.055 ns |  6.74 |    0.00 |
|                                                       For |         [1000] |    251.174 ns |   0.0914 ns |   0.0855 ns |    251.159 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |           **[50]** |    **881.325 ns** |   **3.4818 ns** |   **3.2569 ns** |    **879.954 ns** | **50.07** |    **0.18** |
|                                   LowCostLinqWithDelegate |           [50] |    932.067 ns |  14.3387 ns |  12.7109 ns |    933.303 ns | 52.95 |    0.73 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    606.389 ns |  12.1270 ns |  26.6191 ns |    597.127 ns | 34.89 |    1.53 |
|                                  LowCostLinqWithDelegate2 |           [50] |    737.508 ns |   5.4877 ns |   4.8647 ns |    737.389 ns | 41.90 |    0.27 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    647.078 ns |   2.4854 ns |   1.9404 ns |    646.900 ns | 36.76 |    0.11 |
|                                LowCostLinqWithStructWhere |           [50] |    148.679 ns |   0.0333 ns |   0.0312 ns |    148.677 ns |  8.45 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    118.545 ns |   0.0147 ns |   0.0138 ns |    118.545 ns |  6.73 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,112.530 ns |   7.5381 ns |   6.6823 ns |  1,112.316 ns | 63.21 |    0.39 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,008.642 ns |   8.0261 ns |   7.5076 ns |  1,011.075 ns | 57.30 |    0.43 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    311.846 ns |   0.0993 ns |   0.0880 ns |    311.832 ns | 17.72 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    264.314 ns |   0.1181 ns |   0.1047 ns |    264.340 ns | 15.02 |    0.01 |
|                                                 LinqCount |           [50] |    591.184 ns |   1.5479 ns |   1.4479 ns |    590.892 ns | 33.59 |    0.08 |
|                              LowCostLinqWithDelegateCount |           [50] |    645.230 ns |  14.0894 ns |  21.5160 ns |    632.366 ns | 36.60 |    1.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    554.980 ns |  16.1462 ns |  23.1564 ns |    543.290 ns | 32.14 |    1.56 |
|                           LowCostLinqWithStructWhereCount |           [50] |    133.358 ns |   0.0439 ns |   0.0411 ns |    133.369 ns |  7.58 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     69.495 ns |   0.0432 ns |   0.0405 ns |     69.493 ns |  3.95 |    0.00 |
|                                               LinqToArray |           [50] |    896.616 ns |   2.1228 ns |   1.8818 ns |    896.619 ns | 50.94 |    0.11 |
|                            LowCostLinqWithDelegateToArray |           [50] |    858.238 ns |   2.0643 ns |   1.9309 ns |    857.681 ns | 48.76 |    0.11 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    713.515 ns |   1.4990 ns |   1.4022 ns |    713.249 ns | 40.54 |    0.08 |
|                              LowCostLinqWithStructToArray |           [50] |    265.208 ns |   0.4642 ns |   0.4342 ns |    265.295 ns | 15.07 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    214.262 ns |   0.1122 ns |   0.1050 ns |    214.238 ns | 12.17 |    0.01 |
|                                                      Take |           [50] |    565.556 ns |   1.5078 ns |   1.4104 ns |    565.127 ns | 32.13 |    0.08 |
|                                               LowCostTake |           [50] |    331.468 ns |   6.6249 ns |  18.3575 ns |    319.909 ns | 18.63 |    1.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    285.222 ns |   5.7030 ns |  12.3978 ns |    277.624 ns | 16.68 |    0.85 |
|                                     LowCostTakeWithStruct |           [50] |    112.409 ns |   0.0140 ns |   0.0131 ns |    112.412 ns |  6.39 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     92.207 ns |   0.0227 ns |   0.0201 ns |     92.207 ns |  5.24 |    0.00 |
|                                            SkipTakeSingle |           [50] |    473.940 ns |   0.3255 ns |   0.3044 ns |    473.918 ns | 26.93 |    0.02 |
|                                     LowCostSkipTakeSingle |           [50] |    446.431 ns |  15.4821 ns |  45.6494 ns |    467.816 ns | 27.02 |    0.60 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    314.556 ns |   6.3037 ns |  11.8398 ns |    312.016 ns | 17.70 |    0.68 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    155.625 ns |   0.0543 ns |   0.0481 ns |    155.611 ns |  8.84 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    123.117 ns |   0.2422 ns |   0.2266 ns |    123.123 ns |  6.99 |    0.01 |
|                                           ForeachDelegate |           [50] |    370.112 ns |   0.1185 ns |   0.1109 ns |    370.111 ns | 21.03 |    0.01 |
|                                                   Foreach |           [50] |    103.207 ns |   0.1083 ns |   0.0905 ns |    103.241 ns |  5.86 |    0.01 |
|                                                       For |           [50] |     17.602 ns |   0.0057 ns |   0.0053 ns |     17.601 ns |  1.00 |    0.00 |
|                                                           |                |               |             |             |               |       |         |
|                                                      **Linq** |            **[5]** |    **235.048 ns** |   **0.1155 ns** |   **0.1024 ns** |    **235.027 ns** | **42.29** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [5] |    100.635 ns |   2.0405 ns |   5.7218 ns |     98.797 ns | 17.88 |    1.03 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     82.465 ns |   1.6624 ns |   3.8196 ns |     80.558 ns | 14.98 |    0.65 |
|                                  LowCostLinqWithDelegate2 |            [5] |    167.619 ns |   1.5416 ns |   1.2873 ns |    167.574 ns | 30.16 |    0.23 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    113.071 ns |   2.2755 ns |   4.1608 ns |    112.517 ns | 20.52 |    0.65 |
|                                LowCostLinqWithStructWhere |            [5] |     60.686 ns |   0.0500 ns |   0.0468 ns |     60.680 ns | 10.92 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     51.835 ns |   0.0169 ns |   0.0158 ns |     51.834 ns |  9.33 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    181.329 ns |   0.4585 ns |   0.4065 ns |    181.328 ns | 32.62 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    159.533 ns |   0.2061 ns |   0.1928 ns |    159.549 ns | 28.70 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     87.434 ns |   0.2150 ns |   0.2011 ns |     87.306 ns | 15.73 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     79.391 ns |   0.0336 ns |   0.0314 ns |     79.390 ns | 14.28 |    0.01 |
|                                                 LinqCount |            [5] |    171.500 ns |   0.0868 ns |   0.0812 ns |    171.505 ns | 30.86 |    0.02 |
|                              LowCostLinqWithDelegateCount |            [5] |     93.557 ns |   1.8818 ns |   5.4295 ns |     92.556 ns | 16.45 |    0.99 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     83.929 ns |   1.6938 ns |   4.3722 ns |     84.265 ns | 15.02 |    0.86 |
|                           LowCostLinqWithStructWhereCount |            [5] |     52.202 ns |   0.0517 ns |   0.0484 ns |     52.188 ns |  9.39 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     38.900 ns |   0.0100 ns |   0.0093 ns |     38.899 ns |  7.00 |    0.00 |
|                                               LinqToArray |            [5] |    235.299 ns |   0.2975 ns |   0.2783 ns |    235.240 ns | 42.33 |    0.05 |
|                            LowCostLinqWithDelegateToArray |            [5] |    139.103 ns |   0.1984 ns |   0.1855 ns |    139.147 ns | 25.03 |    0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    129.243 ns |   0.3422 ns |   0.3201 ns |    129.308 ns | 23.25 |    0.06 |
|                              LowCostLinqWithStructToArray |            [5] |     94.870 ns |   0.0347 ns |   0.0325 ns |     94.859 ns | 17.07 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     83.362 ns |   0.0219 ns |   0.0205 ns |     83.355 ns | 15.00 |    0.01 |
|                                                      Take |            [5] |    274.104 ns |   0.0947 ns |   0.0886 ns |    274.098 ns | 49.32 |    0.02 |
|                                               LowCostTake |            [5] |    111.241 ns |   0.2443 ns |   0.2040 ns |    111.222 ns | 20.01 |    0.03 |
|                                  LowCostTakeWithoutChecks |            [5] |    103.375 ns |   2.0758 ns |   4.9734 ns |    103.236 ns | 18.81 |    0.92 |
|                                     LowCostTakeWithStruct |            [5] |     76.363 ns |   0.0173 ns |   0.0161 ns |     76.370 ns | 13.74 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     64.518 ns |   0.0094 ns |   0.0083 ns |     64.515 ns | 11.61 |    0.00 |
|                                            SkipTakeSingle |            [5] |    265.617 ns |   0.1464 ns |   0.1369 ns |    265.594 ns | 47.79 |    0.03 |
|                                     LowCostSkipTakeSingle |            [5] |    129.835 ns |   2.6064 ns |   5.6660 ns |    129.980 ns | 23.60 |    0.85 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    145.690 ns |   2.9400 ns |   5.9389 ns |    147.048 ns | 26.00 |    1.37 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     85.665 ns |   0.0158 ns |   0.0132 ns |     85.669 ns | 15.41 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     78.618 ns |   0.0185 ns |   0.0173 ns |     78.618 ns | 14.15 |    0.01 |
|                                           ForeachDelegate |            [5] |     50.471 ns |   0.0200 ns |   0.0177 ns |     50.473 ns |  9.08 |    0.01 |
|                                                   Foreach |            [5] |     20.618 ns |   0.0237 ns |   0.0222 ns |     20.615 ns |  3.71 |    0.00 |
|                                                       For |            [5] |      5.558 ns |   0.0016 ns |   0.0015 ns |      5.558 ns |  1.00 |    0.00 |
