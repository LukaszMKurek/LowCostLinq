``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **34.32 ns** |   **0.0110 ns** |   **0.0103 ns** |     **34.32 ns** |   **2.31** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     33.38 ns |   0.0096 ns |   0.0075 ns |     33.38 ns |   2.24 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     28.21 ns |   0.0018 ns |   0.0015 ns |     28.21 ns |   1.90 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     50.82 ns |   0.0026 ns |   0.0024 ns |     50.82 ns |   3.42 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     37.39 ns |   0.0086 ns |   0.0081 ns |     37.38 ns |   2.51 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     38.37 ns |   0.2663 ns |   0.2491 ns |     38.37 ns |   2.58 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     30.17 ns |   0.0867 ns |   0.0811 ns |     30.14 ns |   2.03 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     76.19 ns |   0.0338 ns |   0.0316 ns |     76.19 ns |   5.12 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     65.74 ns |   0.1617 ns |   0.1513 ns |     65.65 ns |   4.42 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     75.10 ns |   0.9791 ns |   0.9158 ns |     74.56 ns |   5.05 |     0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     67.52 ns |   0.0592 ns |   0.0494 ns |     67.52 ns |   4.54 |     0.00 |
|                                                 LinqCount |            [0] |     31.15 ns |   0.0198 ns |   0.0176 ns |     31.15 ns |   2.09 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     31.23 ns |   0.0222 ns |   0.0197 ns |     31.24 ns |   2.10 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     28.92 ns |   0.0090 ns |   0.0084 ns |     28.92 ns |   1.94 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     29.70 ns |   0.3148 ns |   0.2945 ns |     29.76 ns |   2.00 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     21.56 ns |   0.0009 ns |   0.0008 ns |     21.56 ns |   1.45 |     0.00 |
|                                               LinqToArray |            [0] |     42.33 ns |   0.0446 ns |   0.0348 ns |     42.33 ns |   2.84 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     42.66 ns |   0.0304 ns |   0.0284 ns |     42.66 ns |   2.87 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     40.26 ns |   0.1036 ns |   0.0969 ns |     40.31 ns |   2.71 |     0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     39.43 ns |   0.0115 ns |   0.0107 ns |     39.43 ns |   2.65 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     30.94 ns |   0.0232 ns |   0.0206 ns |     30.96 ns |   2.08 |     0.00 |
|                                                      Take |            [0] |     68.78 ns |   0.0240 ns |   0.0187 ns |     68.77 ns |   4.62 |     0.00 |
|                                               LowCostTake |            [0] |     42.63 ns |   0.0919 ns |   0.0860 ns |     42.67 ns |   2.86 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     37.55 ns |   0.0035 ns |   0.0033 ns |     37.55 ns |   2.52 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     49.44 ns |   0.0063 ns |   0.0059 ns |     49.44 ns |   3.32 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     39.48 ns |   0.0083 ns |   0.0078 ns |     39.48 ns |   2.65 |     0.00 |
|                                            SkipTakeSingle |            [0] |     90.67 ns |   0.1787 ns |   0.1671 ns |     90.72 ns |   6.09 |     0.01 |
|                                     LowCostSkipTakeSingle |            [0] |     46.40 ns |   0.0019 ns |   0.0016 ns |     46.40 ns |   3.12 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     45.28 ns |   0.4762 ns |   0.4454 ns |     44.95 ns |   3.04 |     0.03 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     49.23 ns |   0.0025 ns |   0.0023 ns |     49.23 ns |   3.31 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     47.55 ns |   0.0740 ns |   0.0692 ns |     47.57 ns |   3.20 |     0.00 |
|                                           ForeachDelegate |            [0] |     17.49 ns |   0.0046 ns |   0.0039 ns |     17.49 ns |   1.18 |     0.00 |
|                                                   Foreach |            [0] |     14.88 ns |   0.0058 ns |   0.0049 ns |     14.88 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** |  **7,403.43 ns** |   **5.1952 ns** |   **4.6055 ns** |  **7,403.53 ns** |   **1.40** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  4,359.96 ns |   9.6634 ns |   9.0391 ns |  4,363.25 ns |   0.83 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  3,625.99 ns |   1.9638 ns |   1.5332 ns |  3,626.08 ns |   0.69 |     0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  5,007.66 ns |  31.3998 ns |  29.3714 ns |  5,017.43 ns |   0.95 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  3,864.55 ns |   2.5722 ns |   2.1479 ns |  3,864.51 ns |   0.73 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,681.50 ns |   2.8540 ns |   2.5300 ns |  2,682.06 ns |   0.51 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,745.50 ns |   0.9207 ns |   0.8613 ns |  1,745.89 ns |   0.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 11,190.64 ns |   7.4511 ns |   6.9698 ns | 11,189.81 ns |   2.12 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 10,007.08 ns |  17.7706 ns |  16.6226 ns | 10,012.42 ns |   1.90 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,283.34 ns | 122.8065 ns | 114.8733 ns |  9,308.86 ns |   1.76 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,002.94 ns |   3.0801 ns |   2.7304 ns |  8,003.25 ns |   1.52 |     0.00 |
|                                                 LinqCount |         [1000] |  1,717.27 ns |   2.9467 ns |   2.7564 ns |  1,715.90 ns |   0.33 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  3,633.35 ns |   6.2869 ns |   5.8808 ns |  3,635.13 ns |   0.69 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  2,433.67 ns |  32.0856 ns |  28.4430 ns |  2,416.59 ns |   0.46 |     0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,734.29 ns |   1.6044 ns |   1.5008 ns |  1,733.98 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,211.67 ns |   0.0328 ns |   0.0307 ns |  1,211.66 ns |   0.23 |     0.00 |
|                                               LinqToArray |         [1000] |  3,019.41 ns |   8.2695 ns |   6.4563 ns |  3,017.94 ns |   0.57 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  5,600.81 ns |   5.9699 ns |   5.2922 ns |  5,598.71 ns |   1.06 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  3,870.02 ns |   3.0765 ns |   2.8778 ns |  3,870.96 ns |   0.73 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,193.53 ns |   1.4432 ns |   1.3499 ns |  3,193.50 ns |   0.61 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,289.11 ns |   4.8004 ns |   4.0085 ns |  2,287.24 ns |   0.43 |     0.00 |
|                                                      Take |         [1000] |    290.83 ns |   0.6288 ns |   0.5882 ns |    290.57 ns |   0.06 |     0.00 |
|                                               LowCostTake |         [1000] |    143.03 ns |   0.0444 ns |   0.0393 ns |    143.02 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    120.92 ns |   0.0090 ns |   0.0079 ns |    120.92 ns |   0.02 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    109.82 ns |   0.0233 ns |   0.0194 ns |    109.81 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     85.89 ns |   0.0059 ns |   0.0046 ns |     85.89 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    217.09 ns |   0.0653 ns |   0.0611 ns |    217.07 ns |   0.04 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    138.78 ns |   0.0649 ns |   0.0607 ns |    138.77 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    119.73 ns |   1.1871 ns |   1.1104 ns |    118.97 ns |   0.02 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     90.33 ns |   0.0498 ns |   0.0466 ns |     90.32 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     61.76 ns |   0.1523 ns |   0.1425 ns |     61.81 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |         [1000] |  6,811.26 ns |   1.9890 ns |   1.7632 ns |  6,812.10 ns |   1.29 |     0.00 |
|                                                   Foreach |         [1000] |  5,272.57 ns |   0.8426 ns |   0.7036 ns |  5,272.58 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **410.87 ns** |   **0.1215 ns** |   **0.1077 ns** |    **410.83 ns** |   **1.43** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    253.80 ns |   0.4920 ns |   0.4602 ns |    254.07 ns |   0.88 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    216.76 ns |   2.4831 ns |   2.3227 ns |    215.10 ns |   0.75 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           [50] |    293.90 ns |   0.1883 ns |   0.1762 ns |    293.96 ns |   1.02 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    234.45 ns |   0.0165 ns |   0.0154 ns |    234.46 ns |   0.82 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    179.49 ns |   1.8469 ns |   1.7276 ns |    178.06 ns |   0.62 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    126.52 ns |   0.0184 ns |   0.0144 ns |    126.52 ns |   0.44 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    655.07 ns |   0.1455 ns |   0.1361 ns |    655.05 ns |   2.28 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    572.72 ns |   0.1203 ns |   0.1066 ns |    572.73 ns |   1.99 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    542.03 ns |   0.0851 ns |   0.0754 ns |    542.05 ns |   1.89 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    475.91 ns |   0.1978 ns |   0.1544 ns |    475.91 ns |   1.66 |     0.00 |
|                                                 LinqCount |           [50] |    120.49 ns |   0.1492 ns |   0.1396 ns |    120.44 ns |   0.42 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    213.93 ns |   0.0236 ns |   0.0209 ns |    213.93 ns |   0.74 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    157.02 ns |   0.0459 ns |   0.0430 ns |    156.99 ns |   0.55 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    122.98 ns |   0.3061 ns |   0.2390 ns |    122.86 ns |   0.43 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     73.76 ns |   0.0046 ns |   0.0043 ns |     73.76 ns |   0.26 |     0.00 |
|                                               LinqToArray |           [50] |    356.83 ns |   0.1211 ns |   0.0946 ns |    356.83 ns |   1.24 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    409.02 ns |   0.2566 ns |   0.2142 ns |    408.97 ns |   1.42 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    309.23 ns |   0.9163 ns |   0.8571 ns |    309.08 ns |   1.08 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    262.62 ns |   0.0607 ns |   0.0474 ns |    262.61 ns |   0.91 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    213.29 ns |   0.5442 ns |   0.5091 ns |    213.27 ns |   0.74 |     0.00 |
|                                                      Take |           [50] |    295.00 ns |   4.2370 ns |   3.9633 ns |    294.90 ns |   1.03 |     0.01 |
|                                               LowCostTake |           [50] |    145.17 ns |   0.3222 ns |   0.3014 ns |    144.99 ns |   0.51 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    121.37 ns |   0.0118 ns |   0.0104 ns |    121.36 ns |   0.42 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    109.77 ns |   0.2106 ns |   0.1970 ns |    109.85 ns |   0.38 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     86.70 ns |   0.0189 ns |   0.0148 ns |     86.70 ns |   0.30 |     0.00 |
|                                            SkipTakeSingle |           [50] |    216.42 ns |   0.1017 ns |   0.0951 ns |    216.45 ns |   0.75 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    134.25 ns |   0.0554 ns |   0.0518 ns |    134.23 ns |   0.47 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    116.52 ns |   0.2336 ns |   0.2186 ns |    116.61 ns |   0.41 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     90.57 ns |   0.8115 ns |   0.7590 ns |     90.16 ns |   0.32 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     65.08 ns |   0.7469 ns |   0.6986 ns |     65.53 ns |   0.23 |     0.00 |
|                                           ForeachDelegate |           [50] |    365.44 ns |   0.0429 ns |   0.0401 ns |    365.44 ns |   1.27 |     0.00 |
|                                                   Foreach |           [50] |    287.35 ns |   0.4084 ns |   0.3820 ns |    287.50 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |     **70.92 ns** |   **0.0230 ns** |   **0.0192 ns** |     **70.91 ns** |   **1.72** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     56.82 ns |   0.0069 ns |   0.0061 ns |     56.82 ns |   1.38 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     47.93 ns |   0.0144 ns |   0.0120 ns |     47.92 ns |   1.16 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     66.65 ns |   0.5923 ns |   0.5540 ns |     66.73 ns |   1.62 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     59.17 ns |   0.0084 ns |   0.0074 ns |     59.17 ns |   1.43 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     59.84 ns |   0.0060 ns |   0.0050 ns |     59.84 ns |   1.45 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     42.21 ns |   0.0117 ns |   0.0104 ns |     42.21 ns |   1.02 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    142.80 ns |   1.8151 ns |   1.6979 ns |    143.29 ns |   3.46 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    120.00 ns |   0.1381 ns |   0.1292 ns |    119.98 ns |   2.91 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    125.52 ns |   0.2479 ns |   0.2319 ns |    125.57 ns |   3.04 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    110.15 ns |   0.1425 ns |   0.1264 ns |    110.09 ns |   2.67 |     0.00 |
|                                                 LinqCount |            [5] |     40.77 ns |   0.4762 ns |   0.4454 ns |     40.48 ns |   0.99 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     50.28 ns |   0.0389 ns |   0.0345 ns |     50.28 ns |   1.22 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     42.10 ns |   0.0161 ns |   0.0150 ns |     42.10 ns |   1.02 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     38.42 ns |   0.4424 ns |   0.4138 ns |     38.15 ns |   0.93 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     24.80 ns |   0.0132 ns |   0.0123 ns |     24.80 ns |   0.60 |     0.00 |
|                                               LinqToArray |            [5] |     96.49 ns |   0.0229 ns |   0.0214 ns |     96.48 ns |   2.34 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |     95.58 ns |   0.3497 ns |   0.3100 ns |     95.71 ns |   2.32 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     87.12 ns |   0.0256 ns |   0.0227 ns |     87.12 ns |   2.11 |     0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     82.27 ns |   0.2372 ns |   0.2219 ns |     82.13 ns |   1.99 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     66.15 ns |   0.0228 ns |   0.0191 ns |     66.15 ns |   1.60 |     0.00 |
|                                                      Take |            [5] |    131.36 ns |   1.5036 ns |   1.4065 ns |    130.62 ns |   3.18 |     0.03 |
|                                               LowCostTake |            [5] |     69.19 ns |   0.0236 ns |   0.0209 ns |     69.19 ns |   1.68 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     59.12 ns |   0.0163 ns |   0.0153 ns |     59.13 ns |   1.43 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     60.54 ns |   0.0221 ns |   0.0196 ns |     60.54 ns |   1.47 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     53.18 ns |   0.1727 ns |   0.1442 ns |     53.25 ns |   1.29 |     0.00 |
|                                            SkipTakeSingle |            [5] |    119.92 ns |   0.0468 ns |   0.0390 ns |    119.91 ns |   2.91 |     0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     65.49 ns |   0.0113 ns |   0.0105 ns |     65.49 ns |   1.59 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     58.83 ns |   0.0968 ns |   0.0906 ns |     58.80 ns |   1.43 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     61.38 ns |   0.0133 ns |   0.0118 ns |     61.38 ns |   1.49 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.13 ns |   0.3863 ns |   0.3613 ns |     45.90 ns |   1.12 |     0.01 |
|                                           ForeachDelegate |            [5] |     52.32 ns |   0.0242 ns |   0.0215 ns |     52.31 ns |   1.27 |     0.00 |
|                                                   Foreach |            [5] |     41.26 ns |   0.0330 ns |   0.0309 ns |     41.25 ns |   1.00 |     0.00 |
