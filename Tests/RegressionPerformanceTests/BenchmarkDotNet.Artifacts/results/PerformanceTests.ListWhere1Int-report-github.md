``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.557 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **35.403 ns** |  **0.0587 ns** |  **0.0520 ns** |  **8.59** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [0] |    24.903 ns |  0.0064 ns |  0.0060 ns |  6.04 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |    19.170 ns |  0.0038 ns |  0.0036 ns |  4.65 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |    31.310 ns |  0.0046 ns |  0.0043 ns |  7.59 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    27.732 ns |  0.0028 ns |  0.0025 ns |  6.73 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |    29.906 ns |  0.0052 ns |  0.0046 ns |  7.25 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    21.321 ns |  0.0011 ns |  0.0009 ns |  5.17 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    43.917 ns |  0.0799 ns |  0.0708 ns | 10.65 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    39.327 ns |  0.0140 ns |  0.0117 ns |  9.54 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    47.381 ns |  0.0228 ns |  0.0214 ns | 11.49 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    43.572 ns |  0.0299 ns |  0.0280 ns | 10.57 |    0.01 |
|                                                 LinqCount |            [0] |    33.350 ns |  0.0180 ns |  0.0159 ns |  8.09 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |    25.170 ns |  0.0155 ns |  0.0145 ns |  6.10 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |    23.369 ns |  0.0095 ns |  0.0089 ns |  5.67 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |    23.160 ns |  0.0113 ns |  0.0101 ns |  5.62 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |    15.669 ns |  0.0066 ns |  0.0055 ns |  3.80 |    0.00 |
|                                               LinqToArray |            [0] |    45.762 ns |  0.0366 ns |  0.0342 ns | 11.10 |    0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |    29.743 ns |  0.0261 ns |  0.0244 ns |  7.21 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    28.777 ns |  0.0553 ns |  0.0517 ns |  6.98 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |    28.554 ns |  0.0270 ns |  0.0252 ns |  6.92 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |    20.475 ns |  0.0444 ns |  0.0416 ns |  4.97 |    0.01 |
|                                                      Take |            [0] |    73.420 ns |  0.1370 ns |  0.1144 ns | 17.80 |    0.03 |
|                                               LowCostTake |            [0] |    34.809 ns |  0.0206 ns |  0.0193 ns |  8.44 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |    26.325 ns |  0.0032 ns |  0.0030 ns |  6.38 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |    37.034 ns |  0.0039 ns |  0.0036 ns |  8.98 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    28.592 ns |  0.0714 ns |  0.0668 ns |  6.93 |    0.02 |
|                                            SkipTakeSingle |            [0] |    93.432 ns |  0.0207 ns |  0.0183 ns | 22.66 |    0.01 |
|                                     LowCostSkipTakeSingle |            [0] |    36.713 ns |  0.5489 ns |  0.5134 ns |  8.90 |    0.13 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    34.914 ns |  0.0118 ns |  0.0110 ns |  8.47 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    40.419 ns |  0.0092 ns |  0.0081 ns |  9.80 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    32.203 ns |  0.0071 ns |  0.0066 ns |  7.81 |    0.00 |
|                                           ForeachDelegate |            [0] |    15.590 ns |  0.2300 ns |  0.2151 ns |  3.78 |    0.05 |
|                                                   Foreach |            [0] |    12.619 ns |  0.0223 ns |  0.0208 ns |  3.06 |    0.00 |
|                                                       For |            [0] |     4.124 ns |  0.0011 ns |  0.0010 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |         **[1000]** | **7,567.670 ns** | **12.8456 ns** | **10.7267 ns** | **30.02** |    **0.07** |
|                                   LowCostLinqWithDelegate |         [1000] | 3,613.335 ns |  0.4564 ns |  0.4269 ns | 14.34 |    0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 3,309.527 ns | 14.2708 ns | 12.6507 ns | 13.13 |    0.05 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 3,882.405 ns | 40.1937 ns | 37.5972 ns | 15.41 |    0.14 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 3,355.893 ns | 12.0348 ns | 11.2573 ns | 13.32 |    0.05 |
|                                LowCostLinqWithStructWhere |         [1000] | 2,419.893 ns |  0.3128 ns |  0.2773 ns |  9.60 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,362.377 ns |  0.7327 ns |  0.6854 ns |  5.41 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 9,416.957 ns | 19.5078 ns | 17.2932 ns | 37.37 |    0.12 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 8,466.777 ns | 18.2179 ns | 17.0410 ns | 33.61 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 6,751.853 ns |  1.3749 ns |  1.2860 ns | 26.80 |    0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 5,920.949 ns |  3.1909 ns |  2.9848 ns | 23.50 |    0.05 |
|                                                 LinqCount |         [1000] | 1,720.998 ns |  0.7428 ns |  0.6202 ns |  6.83 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 3,628.464 ns |  8.5487 ns |  7.5782 ns | 14.40 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 2,415.597 ns |  0.5022 ns |  0.4697 ns |  9.59 |    0.02 |
|                           LowCostLinqWithStructWhereCount |         [1000] | 1,704.322 ns |  0.2340 ns |  0.2189 ns |  6.77 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   619.317 ns |  0.2245 ns |  0.1990 ns |  2.46 |    0.00 |
|                                               LinqToArray |         [1000] | 3,171.750 ns |  1.3714 ns |  1.2828 ns | 12.59 |    0.03 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 5,306.596 ns |  4.3912 ns |  3.8927 ns | 21.06 |    0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 4,053.400 ns |  2.2208 ns |  1.9687 ns | 16.09 |    0.03 |
|                              LowCostLinqWithStructToArray |         [1000] | 3,351.506 ns |  6.5428 ns |  5.8000 ns | 13.30 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 2,410.904 ns |  0.5797 ns |  0.4841 ns |  9.57 |    0.02 |
|                                                      Take |         [1000] |   311.033 ns |  0.0675 ns |  0.0632 ns |  1.23 |    0.00 |
|                                               LowCostTake |         [1000] |   121.753 ns |  0.0799 ns |  0.0708 ns |  0.48 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    98.845 ns |  0.0688 ns |  0.0644 ns |  0.39 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    78.656 ns |  0.1230 ns |  0.1150 ns |  0.31 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    59.642 ns |  0.0097 ns |  0.0090 ns |  0.24 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   230.220 ns |  0.0466 ns |  0.0413 ns |  0.91 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |   127.831 ns |  0.0874 ns |  0.0818 ns |  0.51 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |   103.261 ns |  0.2321 ns |  0.2171 ns |  0.41 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    83.316 ns |  0.0119 ns |  0.0112 ns |  0.33 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    59.528 ns |  0.1443 ns |  0.1350 ns |  0.24 |    0.00 |
|                                           ForeachDelegate |         [1000] | 2,892.941 ns |  1.7279 ns |  1.6163 ns | 11.48 |    0.02 |
|                                                   Foreach |         [1000] | 1,690.659 ns |  0.8307 ns |  0.7364 ns |  6.71 |    0.01 |
|                                                       For |         [1000] |   251.923 ns |  0.5670 ns |  0.5304 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |           **[50]** |   **417.645 ns** |  **0.2431 ns** |  **0.2274 ns** | **25.19** |    **0.06** |
|                                   LowCostLinqWithDelegate |           [50] |   209.860 ns |  0.2241 ns |  0.2096 ns | 12.66 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   180.617 ns |  3.1644 ns |  2.9600 ns | 10.89 |    0.17 |
|                                  LowCostLinqWithDelegate2 |           [50] |   229.292 ns |  0.0715 ns |  0.0669 ns | 13.83 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   188.576 ns |  0.1066 ns |  0.0997 ns | 11.37 |    0.02 |
|                                LowCostLinqWithStructWhere |           [50] |   149.996 ns |  0.0159 ns |  0.0141 ns |  9.05 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    98.754 ns |  0.0224 ns |  0.0199 ns |  5.96 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   529.591 ns |  0.3135 ns |  0.2933 ns | 31.94 |    0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   474.479 ns |  0.0995 ns |  0.0882 ns | 28.62 |    0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   391.492 ns |  0.1457 ns |  0.1292 ns | 23.61 |    0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   346.860 ns |  0.2387 ns |  0.2233 ns | 20.92 |    0.04 |
|                                                 LinqCount |           [50] |   127.603 ns |  2.4363 ns |  2.2789 ns |  7.69 |    0.13 |
|                              LowCostLinqWithDelegateCount |           [50] |   207.381 ns |  0.0676 ns |  0.0600 ns | 12.51 |    0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |   148.937 ns |  0.0899 ns |  0.0841 ns |  8.98 |    0.02 |
|                           LowCostLinqWithStructWhereCount |           [50] |   114.101 ns |  0.0628 ns |  0.0525 ns |  6.88 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    45.794 ns |  0.0191 ns |  0.0178 ns |  2.76 |    0.01 |
|                                               LinqToArray |           [50] |   373.031 ns |  0.0882 ns |  0.0825 ns | 22.49 |    0.04 |
|                            LowCostLinqWithDelegateToArray |           [50] |   371.771 ns |  0.5588 ns |  0.5227 ns | 22.42 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   294.349 ns |  0.2003 ns |  0.1564 ns | 17.74 |    0.03 |
|                              LowCostLinqWithStructToArray |           [50] |   265.863 ns |  0.1432 ns |  0.1270 ns | 16.03 |    0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   206.930 ns |  0.3845 ns |  0.3597 ns | 12.48 |    0.04 |
|                                                      Take |           [50] |   311.531 ns |  0.1033 ns |  0.0916 ns | 18.79 |    0.04 |
|                                               LowCostTake |           [50] |   122.072 ns |  0.1142 ns |  0.1068 ns |  7.36 |    0.02 |
|                                  LowCostTakeWithoutChecks |           [50] |    98.142 ns |  0.0155 ns |  0.0129 ns |  5.92 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    86.016 ns |  0.1157 ns |  0.1082 ns |  5.19 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    58.588 ns |  0.0150 ns |  0.0140 ns |  3.53 |    0.01 |
|                                            SkipTakeSingle |           [50] |   229.591 ns |  0.0429 ns |  0.0401 ns | 13.84 |    0.03 |
|                                     LowCostSkipTakeSingle |           [50] |   128.869 ns |  0.3100 ns |  0.2900 ns |  7.77 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |   103.057 ns |  0.0570 ns |  0.0533 ns |  6.21 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    82.842 ns |  0.0149 ns |  0.0125 ns |  4.99 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    59.626 ns |  0.0494 ns |  0.0462 ns |  3.60 |    0.01 |
|                                           ForeachDelegate |           [50] |   164.589 ns |  0.0252 ns |  0.0236 ns |  9.93 |    0.02 |
|                                                   Foreach |           [50] |   102.906 ns |  0.0780 ns |  0.0691 ns |  6.21 |    0.01 |
|                                                       For |           [50] |    16.583 ns |  0.0336 ns |  0.0314 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |       |         |
|                                                      **Linq** |            **[5]** |    **71.912 ns** |  **0.0703 ns** |  **0.0658 ns** | **12.47** |    **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |    43.790 ns |  0.0214 ns |  0.0201 ns |  7.59 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    35.352 ns |  0.0085 ns |  0.0080 ns |  6.13 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |    52.170 ns |  0.1036 ns |  0.0969 ns |  9.05 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    45.558 ns |  0.0212 ns |  0.0198 ns |  7.90 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |    41.679 ns |  0.0185 ns |  0.0174 ns |  7.23 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    29.495 ns |  0.1344 ns |  0.1257 ns |  5.11 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    93.034 ns |  0.0258 ns |  0.0241 ns | 16.13 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    83.705 ns |  0.1037 ns |  0.0970 ns | 14.51 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    83.417 ns |  0.0235 ns |  0.0219 ns | 14.46 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    73.390 ns |  0.1585 ns |  0.1323 ns | 12.72 |    0.02 |
|                                                 LinqCount |            [5] |    44.027 ns |  0.0200 ns |  0.0167 ns |  7.63 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    43.619 ns |  0.0184 ns |  0.0172 ns |  7.56 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    36.160 ns |  0.0202 ns |  0.0189 ns |  6.27 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |    31.351 ns |  0.0392 ns |  0.0367 ns |  5.44 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    19.315 ns |  0.0838 ns |  0.0783 ns |  3.35 |    0.01 |
|                                               LinqToArray |            [5] |    99.597 ns |  0.1878 ns |  0.1757 ns | 17.27 |    0.03 |
|                            LowCostLinqWithDelegateToArray |            [5] |    80.666 ns |  0.0253 ns |  0.0224 ns | 13.99 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    72.598 ns |  0.0236 ns |  0.0209 ns | 12.59 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    71.275 ns |  0.0267 ns |  0.0236 ns | 12.36 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    58.414 ns |  0.0239 ns |  0.0212 ns | 10.13 |    0.01 |
|                                                      Take |            [5] |   137.031 ns |  0.0652 ns |  0.0545 ns | 23.76 |    0.01 |
|                                               LowCostTake |            [5] |    56.314 ns |  0.0110 ns |  0.0103 ns |  9.76 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |    45.093 ns |  0.6440 ns |  0.6024 ns |  7.82 |    0.10 |
|                                     LowCostTakeWithStruct |            [5] |    48.336 ns |  0.0109 ns |  0.0102 ns |  8.38 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    36.882 ns |  0.0221 ns |  0.0207 ns |  6.39 |    0.00 |
|                                            SkipTakeSingle |            [5] |   125.404 ns |  0.0565 ns |  0.0528 ns | 21.74 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    55.525 ns |  1.0148 ns |  0.9493 ns |  9.64 |    0.17 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    47.880 ns |  0.0125 ns |  0.0117 ns |  8.30 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    49.694 ns |  0.0056 ns |  0.0053 ns |  8.62 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    36.921 ns |  0.4099 ns |  0.3834 ns |  6.40 |    0.07 |
|                                           ForeachDelegate |            [5] |    28.974 ns |  0.0099 ns |  0.0092 ns |  5.02 |    0.00 |
|                                                   Foreach |            [5] |    20.540 ns |  0.0173 ns |  0.0162 ns |  3.56 |    0.00 |
|                                                       For |            [5] |     5.768 ns |  0.0021 ns |  0.0018 ns |  1.00 |    0.00 |
