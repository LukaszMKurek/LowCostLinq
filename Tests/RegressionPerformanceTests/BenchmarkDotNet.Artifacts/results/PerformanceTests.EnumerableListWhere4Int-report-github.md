``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **128.16 ns** |   **0.0740 ns** |     **0.0656 ns** |    **128.15 ns** |  **7.57** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     45.73 ns |   0.0081 ns |     0.0076 ns |     45.73 ns |  2.70 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     39.36 ns |   0.0101 ns |     0.0095 ns |     39.36 ns |  2.32 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     78.89 ns |   0.0366 ns |     0.0306 ns |     78.91 ns |  4.66 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     64.27 ns |   0.0438 ns |     0.0389 ns |     64.28 ns |  3.79 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     57.40 ns |   0.0962 ns |     0.0751 ns |     57.38 ns |  3.39 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     49.79 ns |   0.0084 ns |     0.0079 ns |     49.79 ns |  2.94 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    121.88 ns |   0.0489 ns |     0.0434 ns |    121.86 ns |  7.20 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    111.45 ns |   0.0400 ns |     0.0374 ns |    111.45 ns |  6.58 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    114.70 ns |   0.0216 ns |     0.0191 ns |    114.70 ns |  6.77 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     98.90 ns |   0.0396 ns |     0.0370 ns |     98.90 ns |  5.84 |    0.00 |
|                                                 LinqCount |            [0] |    125.80 ns |   0.0752 ns |     0.0704 ns |    125.80 ns |  7.43 |    0.01 |
|                              LowCostLinqWithDelegateCount |            [0] |     43.18 ns |   0.0703 ns |     0.0657 ns |     43.17 ns |  2.55 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     41.27 ns |   0.0065 ns |     0.0058 ns |     41.27 ns |  2.44 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     53.60 ns |   0.0061 ns |     0.0057 ns |     53.60 ns |  3.16 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     47.02 ns |   0.0102 ns |     0.0096 ns |     47.02 ns |  2.78 |    0.00 |
|                                               LinqToArray |            [0] |    140.33 ns |   0.1009 ns |     0.0944 ns |    140.34 ns |  8.28 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     53.50 ns |   0.0273 ns |     0.0255 ns |     53.51 ns |  3.16 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     52.02 ns |   0.0257 ns |     0.0241 ns |     52.02 ns |  3.07 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     63.44 ns |   0.0351 ns |     0.0329 ns |     63.45 ns |  3.75 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     56.25 ns |   0.0303 ns |     0.0284 ns |     56.25 ns |  3.32 |    0.00 |
|                                                      Take |            [0] |    164.29 ns |   0.0846 ns |     0.0791 ns |    164.32 ns |  9.70 |    0.00 |
|                                               LowCostTake |            [0] |     62.82 ns |   0.0112 ns |     0.0105 ns |     62.82 ns |  3.71 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     51.89 ns |   0.0083 ns |     0.0078 ns |     51.89 ns |  3.06 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     70.58 ns |   0.0102 ns |     0.0095 ns |     70.58 ns |  4.17 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     63.32 ns |   0.0042 ns |     0.0038 ns |     63.32 ns |  3.74 |    0.00 |
|                                            SkipTakeSingle |            [0] |    186.06 ns |   0.1084 ns |     0.1014 ns |    186.05 ns | 10.98 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     77.51 ns |   0.0336 ns |     0.0314 ns |     77.51 ns |  4.58 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     76.15 ns |   0.0187 ns |     0.0165 ns |     76.15 ns |  4.50 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     80.42 ns |   0.0195 ns |     0.0163 ns |     80.42 ns |  4.75 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     78.34 ns |   0.0141 ns |     0.0132 ns |     78.34 ns |  4.62 |    0.00 |
|                                           ForeachDelegate |            [0] |     20.75 ns |   0.0150 ns |     0.0133 ns |     20.75 ns |  1.23 |    0.00 |
|                                                   Foreach |            [0] |     16.94 ns |   0.0075 ns |     0.0070 ns |     16.94 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **15,270.93 ns** | **300.8038 ns** |   **510.7876 ns** | **15,117.22 ns** |  **2.66** |    **0.10** |
|                                   LowCostLinqWithDelegate |         [1000] | 11,496.58 ns | 206.8912 ns |   172.7635 ns | 11,513.96 ns |  1.99 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 12,438.46 ns | 289.0853 ns |   852.3744 ns | 11,867.31 ns |  2.14 |    0.16 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 12,735.74 ns | 280.1450 ns |   826.0139 ns | 12,574.74 ns |  2.16 |    0.13 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 13,621.19 ns | 339.8521 ns |   996.7274 ns | 13,752.18 ns |  2.36 |    0.18 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,698.93 ns |   2.0554 ns |     1.9226 ns |  2,698.57 ns |  0.47 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,610.72 ns |   0.3192 ns |     0.2985 ns |  1,610.70 ns |  0.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 25,011.90 ns |  49.4136 ns |    43.8039 ns | 25,014.26 ns |  4.34 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 25,730.96 ns | 517.6549 ns | 1,434.4194 ns | 25,443.58 ns |  4.33 |    0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,481.77 ns |   2.9547 ns |     2.6193 ns |  9,482.81 ns |  1.64 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,029.31 ns |   2.7764 ns |     2.5970 ns |  8,029.76 ns |  1.39 |    0.00 |
|                                                 LinqCount |         [1000] |  9,163.71 ns | 180.8971 ns |   357.0733 ns |  9,012.88 ns |  1.61 |    0.07 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,852.82 ns | 232.2807 ns |   677.5737 ns | 10,625.82 ns |  1.93 |    0.13 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 10,297.75 ns |  31.5229 ns |    24.6110 ns | 10,297.58 ns |  1.79 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,731.65 ns |   0.5106 ns |     0.4776 ns |  1,731.78 ns |  0.30 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    646.20 ns |   0.0530 ns |     0.0496 ns |    646.18 ns |  0.11 |    0.00 |
|                                               LinqToArray |         [1000] | 11,314.93 ns |  37.2116 ns |    34.8078 ns | 11,314.36 ns |  1.96 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 13,465.25 ns |  21.9849 ns |    19.4891 ns | 13,460.16 ns |  2.33 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,382.09 ns |  15.6674 ns |    14.6553 ns | 11,374.17 ns |  1.97 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,439.64 ns |  10.9557 ns |     9.7119 ns |  3,441.48 ns |  0.60 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,648.12 ns |   2.3934 ns |     2.2387 ns |  2,647.86 ns |  0.46 |    0.00 |
|                                                      Take |         [1000] |    549.93 ns |   0.4835 ns |     0.4286 ns |    549.76 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    334.54 ns |   6.7891 ns |    20.0178 ns |    328.18 ns |  0.06 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    273.93 ns |   1.1977 ns |     1.0001 ns |    273.58 ns |  0.05 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    134.19 ns |   0.0878 ns |     0.0733 ns |    134.19 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    105.50 ns |   0.0260 ns |     0.0243 ns |    105.50 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    472.62 ns |   0.3351 ns |     0.3134 ns |    472.50 ns |  0.08 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    392.61 ns |   7.8560 ns |    22.2863 ns |    385.01 ns |  0.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    336.44 ns |   0.6783 ns |     0.6345 ns |    336.29 ns |  0.06 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    183.06 ns |   0.0400 ns |     0.0355 ns |    183.05 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    147.53 ns |   0.0753 ns |     0.0704 ns |    147.51 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,954.70 ns |   3.5243 ns |     3.2966 ns | 10,954.28 ns |  1.90 |    0.00 |
|                                                   Foreach |         [1000] |  5,766.89 ns |   0.7331 ns |     0.6499 ns |  5,766.96 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **851.73 ns** |   **2.9062 ns** |     **2.7184 ns** |    **851.47 ns** |  **2.79** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    644.33 ns |  14.0950 ns |    41.5594 ns |    643.07 ns |  2.06 |    0.13 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    679.43 ns |  15.4162 ns |    45.2132 ns |    662.36 ns |  2.24 |    0.16 |
|                                  LowCostLinqWithDelegate2 |           [50] |    691.55 ns |   1.1645 ns |     1.0323 ns |    691.13 ns |  2.27 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    745.63 ns |  17.9936 ns |    53.0547 ns |    744.22 ns |  2.53 |    0.19 |
|                                LowCostLinqWithStructWhere |           [50] |    192.08 ns |   0.0803 ns |     0.0751 ns |    192.13 ns |  0.63 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    134.42 ns |   0.0112 ns |     0.0099 ns |    134.42 ns |  0.44 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,380.85 ns |  12.9389 ns |    11.4700 ns |  1,374.81 ns |  4.53 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,335.68 ns |  20.3524 ns |    19.0376 ns |  1,330.50 ns |  4.38 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    593.92 ns |   0.2013 ns |     0.1784 ns |    593.89 ns |  1.95 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    506.40 ns |   0.1978 ns |     0.1851 ns |    506.43 ns |  1.66 |    0.00 |
|                                                 LinqCount |           [50] |    559.85 ns |   1.0509 ns |     0.9316 ns |    559.70 ns |  1.84 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    586.74 ns |  16.4060 ns |    48.3736 ns |    556.44 ns |  1.96 |    0.16 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    608.66 ns |  13.6331 ns |    40.1976 ns |    604.83 ns |  1.92 |    0.10 |
|                           LowCostLinqWithStructWhereCount |           [50] |    144.38 ns |   0.0466 ns |     0.0436 ns |    144.40 ns |  0.47 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     73.48 ns |   0.0071 ns |     0.0066 ns |     73.48 ns |  0.24 |    0.00 |
|                                               LinqToArray |           [50] |    895.70 ns |   0.5735 ns |     0.5365 ns |    895.74 ns |  2.94 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    850.85 ns |   1.1410 ns |     1.0673 ns |    850.44 ns |  2.79 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    744.58 ns |   1.3789 ns |     1.2898 ns |    744.53 ns |  2.44 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    308.29 ns |   0.0786 ns |     0.0735 ns |    308.30 ns |  1.01 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    248.02 ns |   0.1222 ns |     0.1143 ns |    248.02 ns |  0.81 |    0.00 |
|                                                      Take |           [50] |    551.79 ns |   0.8177 ns |     0.7249 ns |    551.66 ns |  1.81 |    0.00 |
|                                               LowCostTake |           [50] |    468.47 ns |   5.4180 ns |     5.0680 ns |    469.20 ns |  1.54 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    298.76 ns |   6.6196 ns |    18.7788 ns |    295.73 ns |  0.96 |    0.05 |
|                                     LowCostTakeWithStruct |           [50] |    134.37 ns |   0.1484 ns |     0.1388 ns |    134.36 ns |  0.44 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    103.47 ns |   0.0241 ns |     0.0225 ns |    103.48 ns |  0.34 |    0.00 |
|                                            SkipTakeSingle |           [50] |    473.20 ns |   0.6108 ns |     0.5713 ns |    472.98 ns |  1.55 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    519.46 ns |  14.6655 ns |    43.2415 ns |    534.39 ns |  1.70 |    0.13 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    341.88 ns |   9.5600 ns |     8.9425 ns |    338.09 ns |  1.12 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    182.19 ns |   0.0539 ns |     0.0478 ns |    182.19 ns |  0.60 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    147.67 ns |   0.0316 ns |     0.0280 ns |    147.68 ns |  0.48 |    0.00 |
|                                           ForeachDelegate |           [50] |    581.14 ns |   0.1303 ns |     0.1219 ns |    581.12 ns |  1.91 |    0.00 |
|                                                   Foreach |           [50] |    304.86 ns |   0.0534 ns |     0.0499 ns |    304.86 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **208.64 ns** |   **0.0929 ns** |     **0.0869 ns** |    **208.64 ns** |  **4.75** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    104.23 ns |   1.9553 ns |     1.6327 ns |    103.57 ns |  2.37 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    108.77 ns |   2.1824 ns |     5.8251 ns |    107.10 ns |  2.52 |    0.15 |
|                                  LowCostLinqWithDelegate2 |            [5] |    151.58 ns |   3.0290 ns |     6.7121 ns |    147.88 ns |  3.47 |    0.17 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    142.50 ns |   2.8626 ns |     8.3503 ns |    141.12 ns |  3.25 |    0.18 |
|                                LowCostLinqWithStructWhere |            [5] |     69.47 ns |   0.0156 ns |     0.0139 ns |     69.47 ns |  1.58 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     57.93 ns |   0.0161 ns |     0.0150 ns |     57.93 ns |  1.32 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    277.33 ns |   0.4791 ns |     0.4482 ns |    277.49 ns |  6.32 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    242.07 ns |   0.3184 ns |     0.2978 ns |    242.00 ns |  5.51 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    164.80 ns |   0.2329 ns |     0.2178 ns |    164.79 ns |  3.75 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    141.69 ns |   0.0530 ns |     0.0470 ns |    141.70 ns |  3.23 |    0.00 |
|                                                 LinqCount |            [5] |    169.75 ns |   0.0937 ns |     0.0831 ns |    169.73 ns |  3.87 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    100.03 ns |   2.0280 ns |     5.4828 ns |    100.49 ns |  2.32 |    0.12 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     91.34 ns |   1.8420 ns |     3.2261 ns |     89.89 ns |  2.08 |    0.06 |
|                           LowCostLinqWithStructWhereCount |            [5] |     61.27 ns |   0.0226 ns |     0.0211 ns |     61.27 ns |  1.40 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     47.79 ns |   0.0109 ns |     0.0102 ns |     47.79 ns |  1.09 |    0.00 |
|                                               LinqToArray |            [5] |    236.91 ns |   0.0816 ns |     0.0681 ns |    236.93 ns |  5.40 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    146.07 ns |   0.0687 ns |     0.0609 ns |    146.06 ns |  3.33 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    139.41 ns |   0.1724 ns |     0.1613 ns |    139.34 ns |  3.18 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |    105.55 ns |   0.0423 ns |     0.0353 ns |    105.54 ns |  2.40 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     89.94 ns |   0.1182 ns |     0.1105 ns |     89.91 ns |  2.05 |    0.00 |
|                                                      Take |            [5] |    274.82 ns |   0.1590 ns |     0.1410 ns |    274.79 ns |  6.26 |    0.00 |
|                                               LowCostTake |            [5] |    123.62 ns |   0.6672 ns |     0.5571 ns |    123.53 ns |  2.82 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |    110.42 ns |   2.2274 ns |     6.3550 ns |    107.83 ns |  2.53 |    0.15 |
|                                     LowCostTakeWithStruct |            [5] |     85.13 ns |   0.0827 ns |     0.0774 ns |     85.11 ns |  1.94 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     72.80 ns |   0.0481 ns |     0.0426 ns |     72.81 ns |  1.66 |    0.00 |
|                                            SkipTakeSingle |            [5] |    265.09 ns |   0.0866 ns |     0.0767 ns |    265.09 ns |  6.04 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    159.05 ns |   3.1847 ns |     6.7868 ns |    158.26 ns |  3.63 |    0.17 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    136.47 ns |   0.2548 ns |     0.1990 ns |    136.51 ns |  3.11 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    101.23 ns |   0.0226 ns |     0.0201 ns |    101.24 ns |  2.31 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     91.49 ns |   0.0300 ns |     0.0281 ns |     91.48 ns |  2.08 |    0.00 |
|                                           ForeachDelegate |            [5] |     76.03 ns |   0.0473 ns |     0.0419 ns |     76.03 ns |  1.73 |    0.00 |
|                                                   Foreach |            [5] |     43.90 ns |   0.0189 ns |     0.0177 ns |     43.90 ns |  1.00 |    0.00 |
