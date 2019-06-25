``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **21.00 ns** |  **0.0091 ns** |  **0.0071 ns** |     **21.00 ns** |  **1.86** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     30.40 ns |  0.0058 ns |  0.0051 ns |     30.40 ns |  2.69 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     25.61 ns |  0.0049 ns |  0.0043 ns |     25.61 ns |  2.27 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     36.74 ns |  0.0081 ns |  0.0076 ns |     36.74 ns |  3.25 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     35.04 ns |  0.0059 ns |  0.0055 ns |     35.04 ns |  3.10 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     35.47 ns |  0.0124 ns |  0.0116 ns |     35.47 ns |  3.14 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     30.90 ns |  0.0041 ns |  0.0039 ns |     30.90 ns |  2.74 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     80.73 ns |  0.1334 ns |  0.1248 ns |     80.67 ns |  7.15 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     69.92 ns |  0.0499 ns |  0.0466 ns |     69.92 ns |  6.19 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     84.61 ns |  0.0507 ns |  0.0450 ns |     84.60 ns |  7.49 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     69.14 ns |  0.0496 ns |  0.0464 ns |     69.12 ns |  6.12 |    0.00 |
|                                                 LinqCount |            [0] |     25.62 ns |  0.0214 ns |  0.0200 ns |     25.61 ns |  2.27 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     23.16 ns |  0.0049 ns |  0.0043 ns |     23.16 ns |  2.05 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     22.40 ns |  0.0041 ns |  0.0038 ns |     22.40 ns |  1.98 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     22.12 ns |  0.0317 ns |  0.0297 ns |     22.10 ns |  1.96 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     22.17 ns |  0.0328 ns |  0.0307 ns |     22.18 ns |  1.96 |    0.00 |
|                                               LinqToArray |            [0] |     21.81 ns |  0.0067 ns |  0.0060 ns |     21.81 ns |  1.93 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     35.67 ns |  0.0357 ns |  0.0334 ns |     35.66 ns |  3.16 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     35.78 ns |  0.0272 ns |  0.0255 ns |     35.79 ns |  3.17 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     32.71 ns |  0.0247 ns |  0.0231 ns |     32.70 ns |  2.90 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     33.07 ns |  0.0288 ns |  0.0256 ns |     33.07 ns |  2.93 |    0.00 |
|                                                      Take |            [0] |     24.52 ns |  0.0277 ns |  0.0246 ns |     24.52 ns |  2.17 |    0.00 |
|                                               LowCostTake |            [0] |     38.74 ns |  0.0180 ns |  0.0168 ns |     38.75 ns |  3.43 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     34.86 ns |  0.0075 ns |  0.0070 ns |     34.86 ns |  3.09 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     41.12 ns |  0.0619 ns |  0.0579 ns |     41.14 ns |  3.64 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     39.14 ns |  0.0141 ns |  0.0125 ns |     39.13 ns |  3.46 |    0.00 |
|                                            SkipTakeSingle |            [0] |     38.65 ns |  0.0412 ns |  0.0386 ns |     38.66 ns |  3.42 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     45.56 ns |  0.0134 ns |  0.0112 ns |     45.56 ns |  4.03 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     45.67 ns |  0.0096 ns |  0.0085 ns |     45.67 ns |  4.04 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     43.28 ns |  0.0200 ns |  0.0177 ns |     43.28 ns |  3.83 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     42.86 ns |  0.0055 ns |  0.0049 ns |     42.86 ns |  3.79 |    0.00 |
|                                           ForeachDelegate |            [0] |     13.78 ns |  0.0047 ns |  0.0044 ns |     13.78 ns |  1.22 |    0.00 |
|                                                   Foreach |            [0] |     11.30 ns |  0.0022 ns |  0.0019 ns |     11.30 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |         **[1000]** |  **5,779.04 ns** |  **1.2606 ns** |  **0.9842 ns** |  **5,779.21 ns** |  **1.34** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  3,140.58 ns |  0.6712 ns |  0.5605 ns |  3,140.39 ns |  0.73 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  3,137.26 ns |  2.4285 ns |  2.2716 ns |  3,136.63 ns |  0.73 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  3,382.81 ns |  0.2909 ns |  0.2429 ns |  3,382.89 ns |  0.78 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  3,427.46 ns | 53.7818 ns | 50.3075 ns |  3,395.08 ns |  0.79 |    0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,259.10 ns |  0.4947 ns |  0.4131 ns |  1,258.88 ns |  0.29 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,243.17 ns |  0.2619 ns |  0.2322 ns |  1,243.26 ns |  0.29 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  9,453.12 ns |  6.0402 ns |  5.6500 ns |  9,453.56 ns |  2.19 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 10,413.65 ns | 79.7488 ns | 70.6952 ns | 10,381.72 ns |  2.41 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,723.96 ns |  6.7429 ns |  5.6306 ns |  8,723.98 ns |  2.02 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,469.23 ns |  2.3191 ns |  2.0558 ns |  8,469.42 ns |  1.96 |    0.00 |
|                                                 LinqCount |         [1000] |  1,473.52 ns |  1.9024 ns |  1.7796 ns |  1,473.96 ns |  0.34 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  2,451.26 ns | 39.7883 ns | 37.2180 ns |  2,451.75 ns |  0.57 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  2,175.14 ns |  0.7917 ns |  0.7018 ns |  2,175.13 ns |  0.50 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    520.89 ns |  0.4760 ns |  0.4453 ns |    520.62 ns |  0.12 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    520.79 ns |  0.4969 ns |  0.4648 ns |    520.60 ns |  0.12 |    0.00 |
|                                               LinqToArray |         [1000] |  2,962.44 ns | 59.0971 ns | 58.0412 ns |  2,917.55 ns |  0.69 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  4,320.92 ns |  8.9481 ns |  7.9323 ns |  4,318.55 ns |  1.00 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  4,327.62 ns |  4.6775 ns |  4.3754 ns |  4,329.63 ns |  1.00 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,130.44 ns |  1.1532 ns |  0.9630 ns |  2,130.40 ns |  0.49 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,184.23 ns |  2.2646 ns |  2.1183 ns |  2,183.88 ns |  0.51 |    0.00 |
|                                                      Take |         [1000] |    293.11 ns |  0.0623 ns |  0.0583 ns |    293.12 ns |  0.07 |    0.00 |
|                                               LowCostTake |         [1000] |    117.49 ns |  0.0254 ns |  0.0238 ns |    117.49 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    112.99 ns |  0.0089 ns |  0.0079 ns |    112.99 ns |  0.03 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     82.69 ns |  0.0485 ns |  0.0454 ns |     82.71 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     72.99 ns |  0.0518 ns |  0.0484 ns |     72.97 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    184.41 ns |  0.2480 ns |  0.2320 ns |    184.31 ns |  0.04 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    117.41 ns |  0.0110 ns |  0.0092 ns |    117.41 ns |  0.03 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    111.24 ns |  0.0654 ns |  0.0546 ns |    111.22 ns |  0.03 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     67.00 ns |  0.0952 ns |  0.0891 ns |     67.03 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     67.90 ns |  0.0430 ns |  0.0403 ns |     67.91 ns |  0.02 |    0.00 |
|                                           ForeachDelegate |         [1000] |  5,526.43 ns |  2.7618 ns |  2.5834 ns |  5,526.29 ns |  1.28 |    0.00 |
|                                                   Foreach |         [1000] |  4,319.46 ns |  1.6939 ns |  1.5845 ns |  4,318.86 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |           **[50]** |    **330.71 ns** |  **0.0995 ns** |  **0.0882 ns** |    **330.74 ns** |  **1.39** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    186.79 ns |  0.0063 ns |  0.0053 ns |    186.79 ns |  0.79 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    184.48 ns |  0.2059 ns |  0.1926 ns |    184.54 ns |  0.78 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    205.67 ns |  0.0493 ns |  0.0461 ns |    205.69 ns |  0.87 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    204.45 ns |  0.0669 ns |  0.0593 ns |    204.45 ns |  0.86 |    0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    106.36 ns |  0.1582 ns |  0.1480 ns |    106.34 ns |  0.45 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    103.11 ns |  0.0308 ns |  0.0288 ns |    103.11 ns |  0.43 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    583.08 ns |  0.2016 ns |  0.1787 ns |    583.08 ns |  2.46 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    596.27 ns |  0.1836 ns |  0.1717 ns |    596.21 ns |  2.51 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    524.13 ns |  0.2175 ns |  0.1928 ns |    524.16 ns |  2.21 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    497.45 ns |  0.1720 ns |  0.1609 ns |    497.43 ns |  2.10 |    0.00 |
|                                                 LinqCount |           [50] |    109.21 ns |  0.3130 ns |  0.2928 ns |    109.09 ns |  0.46 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    147.01 ns |  0.0293 ns |  0.0274 ns |    147.01 ns |  0.62 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    134.22 ns |  0.0365 ns |  0.0342 ns |    134.20 ns |  0.57 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     48.40 ns |  0.0540 ns |  0.0505 ns |     48.43 ns |  0.20 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     48.59 ns |  0.1644 ns |  0.1538 ns |     48.50 ns |  0.20 |    0.00 |
|                                               LinqToArray |           [50] |    354.05 ns |  0.1116 ns |  0.0989 ns |    354.04 ns |  1.49 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    325.99 ns |  0.1570 ns |  0.1469 ns |    325.98 ns |  1.37 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    324.30 ns |  0.1113 ns |  0.1041 ns |    324.30 ns |  1.37 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    212.75 ns |  0.1488 ns |  0.1243 ns |    212.73 ns |  0.90 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    208.48 ns |  0.1118 ns |  0.0991 ns |    208.51 ns |  0.88 |    0.00 |
|                                                      Take |           [50] |    293.21 ns |  0.0613 ns |  0.0573 ns |    293.23 ns |  1.24 |    0.00 |
|                                               LowCostTake |           [50] |    117.69 ns |  0.0169 ns |  0.0132 ns |    117.68 ns |  0.50 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    114.81 ns |  1.8150 ns |  1.6978 ns |    113.60 ns |  0.48 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |     81.74 ns |  0.0111 ns |  0.0093 ns |     81.74 ns |  0.34 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     71.87 ns |  0.0135 ns |  0.0126 ns |     71.87 ns |  0.30 |    0.00 |
|                                            SkipTakeSingle |           [50] |    184.21 ns |  0.0402 ns |  0.0376 ns |    184.21 ns |  0.78 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    119.90 ns |  1.5479 ns |  1.4479 ns |    119.03 ns |  0.51 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    111.33 ns |  0.0934 ns |  0.0828 ns |    111.32 ns |  0.47 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     65.92 ns |  0.1454 ns |  0.1360 ns |     65.89 ns |  0.28 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     65.60 ns |  0.0719 ns |  0.0638 ns |     65.62 ns |  0.28 |    0.00 |
|                                           ForeachDelegate |           [50] |    306.64 ns |  4.5960 ns |  4.2991 ns |    303.78 ns |  1.29 |    0.02 |
|                                                   Foreach |           [50] |    237.15 ns |  0.0733 ns |  0.0685 ns |    237.13 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |            **[5]** |     **62.37 ns** |  **0.0598 ns** |  **0.0559 ns** |     **62.37 ns** |  **1.80** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     48.52 ns |  0.5306 ns |  0.4431 ns |     48.24 ns |  1.40 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     41.72 ns |  0.0101 ns |  0.0085 ns |     41.72 ns |  1.20 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     53.88 ns |  0.0094 ns |  0.0083 ns |     53.88 ns |  1.55 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     50.97 ns |  0.0070 ns |  0.0065 ns |     50.97 ns |  1.47 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     44.13 ns |  0.0165 ns |  0.0155 ns |     44.14 ns |  1.27 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     38.33 ns |  0.0085 ns |  0.0075 ns |     38.33 ns |  1.11 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    136.68 ns |  0.0355 ns |  0.0332 ns |    136.68 ns |  3.94 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    125.85 ns |  0.1074 ns |  0.1005 ns |    125.81 ns |  3.63 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    130.01 ns |  0.0631 ns |  0.0559 ns |    130.00 ns |  3.75 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    114.68 ns |  1.5339 ns |  1.3598 ns |    114.01 ns |  3.31 |    0.04 |
|                                                 LinqCount |            [5] |     39.48 ns |  0.0235 ns |  0.0220 ns |     39.48 ns |  1.14 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     34.39 ns |  0.0182 ns |  0.0152 ns |     34.40 ns |  0.99 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     33.39 ns |  0.0101 ns |  0.0089 ns |     33.39 ns |  0.96 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     25.03 ns |  0.0036 ns |  0.0034 ns |     25.03 ns |  0.72 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     24.54 ns |  0.0046 ns |  0.0038 ns |     24.54 ns |  0.71 |    0.00 |
|                                               LinqToArray |            [5] |     97.02 ns |  0.0298 ns |  0.0278 ns |     97.02 ns |  2.80 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |     83.62 ns |  0.0262 ns |  0.0219 ns |     83.62 ns |  2.41 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     82.81 ns |  0.0198 ns |  0.0176 ns |     82.80 ns |  2.39 |    0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     68.27 ns |  0.0478 ns |  0.0447 ns |     68.24 ns |  1.97 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     67.33 ns |  0.0285 ns |  0.0253 ns |     67.33 ns |  1.94 |    0.00 |
|                                                      Take |            [5] |    123.14 ns |  0.1512 ns |  0.1414 ns |    123.09 ns |  3.55 |    0.00 |
|                                               LowCostTake |            [5] |     58.96 ns |  0.0162 ns |  0.0143 ns |     58.95 ns |  1.70 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     54.72 ns |  0.0398 ns |  0.0373 ns |     54.73 ns |  1.58 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     55.11 ns |  0.0246 ns |  0.0230 ns |     55.11 ns |  1.59 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     47.66 ns |  0.0109 ns |  0.0097 ns |     47.66 ns |  1.37 |    0.00 |
|                                            SkipTakeSingle |            [5] |    112.56 ns |  0.0310 ns |  0.0290 ns |    112.55 ns |  3.25 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     57.64 ns |  0.0222 ns |  0.0197 ns |     57.63 ns |  1.66 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     57.06 ns |  0.0105 ns |  0.0094 ns |     57.06 ns |  1.64 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     46.35 ns |  0.0062 ns |  0.0058 ns |     46.35 ns |  1.34 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.92 ns |  0.0163 ns |  0.0128 ns |     46.92 ns |  1.35 |    0.00 |
|                                           ForeachDelegate |            [5] |     44.85 ns |  0.0195 ns |  0.0182 ns |     44.85 ns |  1.29 |    0.00 |
|                                                   Foreach |            [5] |     34.68 ns |  0.0364 ns |  0.0341 ns |     34.68 ns |  1.00 |    0.00 |
