``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **48.20 ns** |   **0.0321 ns** |  **0.0284 ns** |     **48.19 ns** |   **4.14** |     **0.05** |
|                                   LowCostLinqWithDelegate |            [0] |     36.12 ns |   0.4017 ns |  0.3758 ns |     36.08 ns |   3.10 |     0.05 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     34.51 ns |   0.0077 ns |  0.0072 ns |     34.51 ns |   2.96 |     0.04 |
|                                  LowCostLinqWithDelegate2 |            [0] |     47.90 ns |   0.0062 ns |  0.0049 ns |     47.91 ns |   4.11 |     0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     50.41 ns |   0.0018 ns |  0.0016 ns |     50.41 ns |   4.33 |     0.06 |
|                                LowCostLinqWithStructWhere |            [0] |     41.77 ns |   0.0052 ns |  0.0044 ns |     41.77 ns |   3.59 |     0.05 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     43.14 ns |   0.0048 ns |  0.0045 ns |     43.14 ns |   3.70 |     0.05 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     95.64 ns |   0.0748 ns |  0.0625 ns |     95.63 ns |   8.21 |     0.11 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     92.83 ns |   1.1182 ns |  0.9912 ns |     92.21 ns |   7.97 |     0.13 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     81.33 ns |   0.0661 ns |  0.0618 ns |     81.31 ns |   6.98 |     0.09 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     74.92 ns |   0.0204 ns |  0.0190 ns |     74.91 ns |   6.43 |     0.08 |
|                                                 LinqCount |            [0] |     47.14 ns |   0.0907 ns |  0.0848 ns |     47.13 ns |   4.05 |     0.05 |
|                              LowCostLinqWithDelegateCount |            [0] |     34.62 ns |   0.3991 ns |  0.3733 ns |     34.85 ns |   2.97 |     0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     34.87 ns |   0.0134 ns |  0.0118 ns |     34.88 ns |   2.99 |     0.04 |
|                           LowCostLinqWithStructWhereCount |            [0] |     30.54 ns |   0.0583 ns |  0.0545 ns |     30.56 ns |   2.62 |     0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     30.71 ns |   0.0017 ns |  0.0016 ns |     30.71 ns |   2.64 |     0.03 |
|                                               LinqToArray |            [0] |     63.23 ns |   0.2326 ns |  0.2062 ns |     63.19 ns |   5.43 |     0.07 |
|                            LowCostLinqWithDelegateToArray |            [0] |     45.56 ns |   0.0145 ns |  0.0136 ns |     45.55 ns |   3.91 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     46.13 ns |   0.0700 ns |  0.0655 ns |     46.15 ns |   3.96 |     0.05 |
|                              LowCostLinqWithStructToArray |            [0] |     40.21 ns |   0.4857 ns |  0.4543 ns |     39.86 ns |   3.45 |     0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     40.08 ns |   0.0281 ns |  0.0263 ns |     40.08 ns |   3.44 |     0.04 |
|                                                      Take |            [0] |     81.31 ns |   0.0290 ns |  0.0242 ns |     81.30 ns |   6.98 |     0.09 |
|                                               LowCostTake |            [0] |     40.87 ns |   0.0030 ns |  0.0027 ns |     40.87 ns |   3.51 |     0.05 |
|                                  LowCostTakeWithoutChecks |            [0] |     43.06 ns |   0.5581 ns |  0.5221 ns |     42.97 ns |   3.70 |     0.06 |
|                                     LowCostTakeWithStruct |            [0] |     47.64 ns |   0.0027 ns |  0.0024 ns |     47.64 ns |   4.09 |     0.05 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     48.37 ns |   0.1091 ns |  0.1021 ns |     48.44 ns |   4.15 |     0.05 |
|                                            SkipTakeSingle |            [0] |    105.04 ns |   1.7936 ns |  1.6777 ns |    103.84 ns |   9.02 |     0.18 |
|                                     LowCostSkipTakeSingle |            [0] |     50.30 ns |   0.0176 ns |  0.0165 ns |     50.30 ns |   4.32 |     0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     50.17 ns |   0.0031 ns |  0.0029 ns |     50.17 ns |   4.31 |     0.06 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     53.15 ns |   0.5046 ns |  0.4720 ns |     52.82 ns |   4.56 |     0.07 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     52.40 ns |   0.0013 ns |  0.0012 ns |     52.40 ns |   4.50 |     0.06 |
|                                           ForeachDelegate |            [0] |     15.51 ns |   0.0011 ns |  0.0011 ns |     15.50 ns |   1.33 |     0.02 |
|                                                   Foreach |            [0] |     11.65 ns |   0.1671 ns |  0.1563 ns |     11.53 ns |   1.00 |     0.00 |
|                                                           |                |              |             |            |              |        |          |
|                                                      **Linq** |         **[1000]** |  **7,073.19 ns** |   **8.5763 ns** |  **8.0223 ns** |  **7,070.09 ns** |   **1.74** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  6,058.37 ns |  61.2979 ns | 57.3381 ns |  6,062.75 ns |   1.49 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,346.45 ns |  24.0611 ns | 18.7853 ns |  6,355.28 ns |   1.56 |     0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  5,984.59 ns |  51.2361 ns | 47.9262 ns |  6,008.92 ns |   1.47 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,774.12 ns |   2.7315 ns |  2.4214 ns |  6,774.36 ns |   1.67 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,010.86 ns |   4.2100 ns |  3.5156 ns |  2,011.90 ns |   0.49 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,573.46 ns |  14.8934 ns | 13.9313 ns |  1,565.36 ns |   0.39 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 19,157.94 ns |  72.5141 ns | 64.2819 ns | 19,177.06 ns |   4.71 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 18,904.00 ns |  35.5358 ns | 29.6740 ns | 18,912.87 ns |   4.65 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,488.15 ns |  13.7113 ns | 11.4495 ns |  8,489.72 ns |   2.09 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,798.50 ns | 106.1558 ns | 99.2982 ns |  8,726.77 ns |   2.16 |     0.02 |
|                                                 LinqCount |         [1000] |  3,898.09 ns |   5.5097 ns |  4.8842 ns |  3,899.31 ns |   0.96 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  5,245.01 ns |   3.2117 ns |  2.6819 ns |  5,246.09 ns |   1.29 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  4,816.92 ns |   1.0393 ns |  0.9213 ns |  4,816.72 ns |   1.18 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,349.78 ns |   7.1828 ns |  6.7188 ns |  1,346.01 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,349.83 ns |   3.0482 ns |  2.8513 ns |  1,351.49 ns |   0.33 |     0.00 |
|                                               LinqToArray |         [1000] |  5,612.34 ns |   4.8981 ns |  4.3421 ns |  5,611.39 ns |   1.38 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  6,738.48 ns |   2.4324 ns |  2.1563 ns |  6,738.20 ns |   1.66 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,292.14 ns |   3.3217 ns |  2.9446 ns |  7,292.40 ns |   1.79 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,247.94 ns |   1.7443 ns |  1.6316 ns |  2,247.69 ns |   0.55 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,221.73 ns |   1.0900 ns |  1.0196 ns |  2,221.45 ns |   0.55 |     0.00 |
|                                                      Take |         [1000] |    339.08 ns |   2.8040 ns |  2.4857 ns |    338.02 ns |   0.08 |     0.00 |
|                                               LowCostTake |         [1000] |    193.17 ns |   0.1084 ns |  0.0961 ns |    193.15 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    163.37 ns |   0.1948 ns |  0.1822 ns |    163.44 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     98.12 ns |   0.0148 ns |  0.0138 ns |     98.12 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     88.49 ns |   0.0543 ns |  0.0508 ns |     88.47 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    259.34 ns |   0.0638 ns |  0.0597 ns |    259.33 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    171.97 ns |   0.0200 ns |  0.0188 ns |    171.97 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    174.54 ns |   0.1853 ns |  0.1733 ns |    174.64 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     73.71 ns |   0.0791 ns |  0.0661 ns |     73.69 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     72.55 ns |   0.1372 ns |  0.1283 ns |     72.59 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |         [1000] |  6,763.58 ns |   1.9977 ns |  1.6682 ns |  6,763.85 ns |   1.66 |     0.00 |
|                                                   Foreach |         [1000] |  4,065.41 ns |   0.6676 ns |  0.5918 ns |  4,065.21 ns |   1.00 |     0.00 |
|                                                           |                |              |             |            |              |        |          |
|                                                      **Linq** |           **[50]** |    **437.83 ns** |   **0.0659 ns** |  **0.0550 ns** |    **437.85 ns** |   **1.95** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    329.24 ns |   0.2084 ns |  0.1848 ns |    329.25 ns |   1.47 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    351.46 ns |   0.4455 ns |  0.4167 ns |    351.40 ns |   1.57 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    350.37 ns |   4.1717 ns |  3.9022 ns |    347.26 ns |   1.56 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    385.56 ns |   0.1898 ns |  0.1775 ns |    385.50 ns |   1.72 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    144.26 ns |   0.1699 ns |  0.1589 ns |    144.27 ns |   0.64 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    127.17 ns |   0.2590 ns |  0.2423 ns |    126.99 ns |   0.57 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,062.99 ns |  10.8194 ns | 10.1205 ns |  1,058.87 ns |   4.74 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,055.21 ns |   1.3187 ns |  1.2335 ns |  1,054.85 ns |   4.71 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    510.74 ns |   0.1343 ns |  0.1256 ns |    510.73 ns |   2.28 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    518.02 ns |   0.1241 ns |  0.1036 ns |    518.01 ns |   2.31 |     0.00 |
|                                                 LinqCount |           [50] |    251.97 ns |   0.2921 ns |  0.2732 ns |    252.00 ns |   1.12 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    299.09 ns |   3.6464 ns |  3.2325 ns |    298.85 ns |   1.33 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    275.96 ns |   0.0307 ns |  0.0287 ns |    275.96 ns |   1.23 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     84.98 ns |   0.0230 ns |  0.0180 ns |     84.97 ns |   0.38 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     85.23 ns |   0.0134 ns |  0.0126 ns |     85.22 ns |   0.38 |     0.00 |
|                                               LinqToArray |           [50] |    532.01 ns |   8.9582 ns |  8.3795 ns |    534.02 ns |   2.37 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           [50] |    469.75 ns |   0.3308 ns |  0.2933 ns |    469.77 ns |   2.10 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    495.83 ns |   0.3417 ns |  0.3196 ns |    495.89 ns |   2.21 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    203.91 ns |   0.2546 ns |  0.1988 ns |    203.84 ns |   0.91 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    206.19 ns |   0.5325 ns |  0.4981 ns |    206.36 ns |   0.92 |     0.00 |
|                                                      Take |           [50] |    337.09 ns |   0.0558 ns |  0.0495 ns |    337.08 ns |   1.50 |     0.00 |
|                                               LowCostTake |           [50] |    195.86 ns |   1.6223 ns |  1.5175 ns |    195.09 ns |   0.87 |     0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    162.29 ns |   0.0136 ns |  0.0127 ns |    162.29 ns |   0.72 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |     99.43 ns |   0.1757 ns |  0.1644 ns |     99.47 ns |   0.44 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     88.91 ns |   0.0035 ns |  0.0031 ns |     88.91 ns |   0.40 |     0.00 |
|                                            SkipTakeSingle |           [50] |    260.91 ns |   3.5172 ns |  3.2900 ns |    258.72 ns |   1.16 |     0.01 |
|                                     LowCostSkipTakeSingle |           [50] |    177.52 ns |   0.0118 ns |  0.0092 ns |    177.52 ns |   0.79 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    173.92 ns |   0.3953 ns |  0.3697 ns |    174.18 ns |   0.78 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     75.99 ns |   0.0361 ns |  0.0337 ns |     75.98 ns |   0.34 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     74.61 ns |   0.0388 ns |  0.0363 ns |     74.60 ns |   0.33 |     0.00 |
|                                           ForeachDelegate |           [50] |    364.03 ns |   0.0696 ns |  0.0651 ns |    364.02 ns |   1.62 |     0.00 |
|                                                   Foreach |           [50] |    224.13 ns |   0.0585 ns |  0.0489 ns |    224.13 ns |   1.00 |     0.00 |
|                                                           |                |              |             |            |              |        |          |
|                                                      **Linq** |            **[5]** |     **95.58 ns** |   **0.2087 ns** |  **0.1629 ns** |     **95.52 ns** |   **2.99** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     62.14 ns |   0.0698 ns |  0.0653 ns |     62.16 ns |   1.94 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     60.10 ns |   0.0243 ns |  0.0190 ns |     60.09 ns |   1.88 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     77.32 ns |   0.0469 ns |  0.0416 ns |     77.29 ns |   2.42 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     76.88 ns |   0.9228 ns |  0.8631 ns |     76.85 ns |   2.40 |     0.03 |
|                                LowCostLinqWithStructWhere |            [5] |     52.10 ns |   0.0243 ns |  0.0228 ns |     52.09 ns |   1.63 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     50.49 ns |   0.0299 ns |  0.0265 ns |     50.50 ns |   1.58 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    204.62 ns |   2.7105 ns |  2.5354 ns |    202.82 ns |   6.40 |     0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    198.55 ns |   0.2037 ns |  0.1806 ns |    198.53 ns |   6.21 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    126.68 ns |   0.0587 ns |  0.0490 ns |    126.67 ns |   3.96 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    118.71 ns |   0.0423 ns |  0.0353 ns |    118.69 ns |   3.71 |     0.00 |
|                                                 LinqCount |            [5] |     77.10 ns |   1.5131 ns |  1.4153 ns |     77.31 ns |   2.41 |     0.04 |
|                              LowCostLinqWithDelegateCount |            [5] |     58.13 ns |   0.0757 ns |  0.0708 ns |     58.12 ns |   1.82 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     56.71 ns |   0.0648 ns |  0.0574 ns |     56.71 ns |   1.77 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     33.82 ns |   0.3405 ns |  0.3185 ns |     33.62 ns |   1.06 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     34.06 ns |   0.0163 ns |  0.0152 ns |     34.05 ns |   1.06 |     0.00 |
|                                               LinqToArray |            [5] |    137.32 ns |   0.0249 ns |  0.0195 ns |    137.32 ns |   4.29 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    103.53 ns |   0.0546 ns |  0.0456 ns |    103.52 ns |   3.24 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    105.74 ns |   1.6427 ns |  1.5366 ns |    104.57 ns |   3.30 |     0.05 |
|                              LowCostLinqWithStructToArray |            [5] |     72.44 ns |   0.0230 ns |  0.0180 ns |     72.44 ns |   2.26 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     77.65 ns |   0.0411 ns |  0.0384 ns |     77.65 ns |   2.43 |     0.00 |
|                                                      Take |            [5] |    152.31 ns |   0.4427 ns |  0.4141 ns |    152.54 ns |   4.76 |     0.01 |
|                                               LowCostTake |            [5] |     69.93 ns |   0.0599 ns |  0.0501 ns |     69.93 ns |   2.19 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     71.36 ns |   0.0955 ns |  0.0894 ns |     71.30 ns |   2.23 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     60.86 ns |   0.0254 ns |  0.0212 ns |     60.85 ns |   1.90 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     59.34 ns |   0.1241 ns |  0.1161 ns |     59.37 ns |   1.85 |     0.00 |
|                                            SkipTakeSingle |            [5] |    149.21 ns |   2.8642 ns |  3.0647 ns |    147.03 ns |   4.66 |     0.09 |
|                                     LowCostSkipTakeSingle |            [5] |     71.36 ns |   0.0629 ns |  0.0588 ns |     71.38 ns |   2.23 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     71.43 ns |   0.0316 ns |  0.0264 ns |     71.42 ns |   2.23 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     55.96 ns |   0.1303 ns |  0.1219 ns |     56.03 ns |   1.75 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.93 ns |   0.0180 ns |  0.0169 ns |     55.92 ns |   1.75 |     0.00 |
|                                           ForeachDelegate |            [5] |     50.74 ns |   0.0245 ns |  0.0229 ns |     50.75 ns |   1.59 |     0.00 |
|                                                   Foreach |            [5] |     32.00 ns |   0.0233 ns |  0.0218 ns |     31.99 ns |   1.00 |     0.00 |
