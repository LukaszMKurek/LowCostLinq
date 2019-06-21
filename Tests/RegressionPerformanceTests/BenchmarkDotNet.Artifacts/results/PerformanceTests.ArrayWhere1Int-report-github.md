``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |
|--------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **20.499 ns** |  **0.1891 ns** |  **0.1769 ns** |    **20.407 ns** |  **5.88** |    **0.06** |
|                      LowCostLinqWithDelegate |            [0] |    18.848 ns |  0.0031 ns |  0.0026 ns |    18.847 ns |  5.39 |    0.09 |
|                     LowCostLinqWithDelegate2 |            [0] |    27.705 ns |  0.0025 ns |  0.0023 ns |    27.704 ns |  7.94 |    0.13 |
|                   LowCostLinqWithStructWhere |            [0] |    20.964 ns |  0.2126 ns |  0.1988 ns |    20.790 ns |  6.01 |    0.10 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    39.932 ns |  0.0171 ns |  0.0151 ns |    39.937 ns | 11.44 |    0.19 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    42.949 ns |  0.0178 ns |  0.0158 ns |    42.951 ns | 12.30 |    0.20 |
|                                    LinqCount |            [0] |    23.934 ns |  0.2592 ns |  0.2425 ns |    23.802 ns |  6.86 |    0.15 |
|                 LowCostLinqWithDelegateCount |            [0] |    15.983 ns |  0.0149 ns |  0.0139 ns |    15.982 ns |  4.58 |    0.07 |
|              LowCostLinqWithStructWhereCount |            [0] |    15.659 ns |  0.0035 ns |  0.0033 ns |    15.659 ns |  4.49 |    0.07 |
|                                  LinqToArray |            [0] |    22.626 ns |  0.0280 ns |  0.0248 ns |    22.626 ns |  6.48 |    0.11 |
|               LowCostLinqWithDelegateToArray |            [0] |    19.865 ns |  0.0061 ns |  0.0054 ns |    19.867 ns |  5.69 |    0.09 |
|                 LowCostLinqWithStructToArray |            [0] |    18.975 ns |  0.0166 ns |  0.0147 ns |    18.978 ns |  5.44 |    0.09 |
|                                         Take |            [0] |    24.085 ns |  0.0552 ns |  0.0517 ns |    24.076 ns |  6.90 |    0.10 |
|                                  LowCostTake |            [0] |    26.096 ns |  0.1430 ns |  0.1338 ns |    26.010 ns |  7.48 |    0.12 |
|                        LowCostTakeWithStruct |            [0] |    28.033 ns |  0.0054 ns |  0.0050 ns |    28.034 ns |  8.04 |    0.13 |
|                               SkipTakeSingle |            [0] |    35.291 ns |  0.0845 ns |  0.0749 ns |    35.305 ns | 10.11 |    0.16 |
|                        LowCostSkipTakeSingle |            [0] |    29.395 ns |  0.2493 ns |  0.2332 ns |    29.480 ns |  8.43 |    0.19 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    31.823 ns |  0.0065 ns |  0.0060 ns |    31.823 ns |  9.12 |    0.14 |
|                              ForeachDelegate |            [0] |     6.401 ns |  0.0024 ns |  0.0022 ns |     6.401 ns |  1.84 |    0.03 |
|                                      Foreach |            [0] |     3.616 ns |  0.0030 ns |  0.0028 ns |     3.616 ns |  1.04 |    0.02 |
|                                          For |            [0] |     3.489 ns |  0.0599 ns |  0.0560 ns |     3.453 ns |  1.00 |    0.00 |
|                                              |                |              |            |            |              |       |         |
|                                         **Linq** |         **[1000]** | **5,774.522 ns** |  **0.6895 ns** |  **0.6449 ns** | **5,774.326 ns** | **22.83** |    **0.39** |
|                      LowCostLinqWithDelegate |         [1000] | 3,129.855 ns |  5.8963 ns |  5.5154 ns | 3,133.029 ns | 12.38 |    0.21 |
|                     LowCostLinqWithDelegate2 |         [1000] | 3,392.126 ns | 33.4285 ns | 31.2691 ns | 3,369.098 ns | 13.41 |    0.30 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,464.141 ns |  0.1946 ns |  0.1725 ns | 1,464.118 ns |  5.79 |    0.10 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 8,169.200 ns |  2.8289 ns |  2.6462 ns | 8,168.781 ns | 32.30 |    0.55 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 5,798.959 ns |  6.7873 ns |  6.3489 ns | 5,800.443 ns | 22.93 |    0.39 |
|                                    LinqCount |         [1000] | 1,737.139 ns |  5.3526 ns |  4.4697 ns | 1,735.160 ns |  6.86 |    0.12 |
|                 LowCostLinqWithDelegateCount |         [1000] | 2,410.440 ns |  0.3459 ns |  0.3066 ns | 2,410.420 ns |  9.53 |    0.17 |
|              LowCostLinqWithStructWhereCount |         [1000] | 1,326.202 ns |  0.5501 ns |  0.5146 ns | 1,326.228 ns |  5.24 |    0.09 |
|                                  LinqToArray |         [1000] | 2,907.963 ns | 49.6594 ns | 46.4514 ns | 2,875.726 ns | 11.50 |    0.32 |
|               LowCostLinqWithDelegateToArray |         [1000] | 4,322.747 ns |  4.7737 ns |  4.4653 ns | 4,323.071 ns | 17.09 |    0.29 |
|                 LowCostLinqWithStructToArray |         [1000] | 2,401.832 ns |  3.3373 ns |  3.1217 ns | 2,400.189 ns |  9.50 |    0.16 |
|                                         Take |         [1000] |   287.243 ns |  0.0736 ns |  0.0688 ns |   287.260 ns |  1.14 |    0.02 |
|                                  LowCostTake |         [1000] |    96.862 ns |  0.8965 ns |  0.8386 ns |    96.222 ns |  0.38 |    0.01 |
|                        LowCostTakeWithStruct |         [1000] |    61.587 ns |  0.1271 ns |  0.1189 ns |    61.524 ns |  0.24 |    0.00 |
|                               SkipTakeSingle |         [1000] |   183.450 ns |  0.0348 ns |  0.0271 ns |   183.446 ns |  0.72 |    0.01 |
|                        LowCostSkipTakeSingle |         [1000] |    92.901 ns |  0.0616 ns |  0.0577 ns |    92.911 ns |  0.37 |    0.01 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    55.902 ns |  0.5517 ns |  0.5161 ns |    55.650 ns |  0.22 |    0.00 |
|                              ForeachDelegate |         [1000] | 1,681.735 ns |  0.2277 ns |  0.2130 ns | 1,681.744 ns |  6.65 |    0.11 |
|                                      Foreach |         [1000] |   449.308 ns |  8.9807 ns |  9.6092 ns |   448.421 ns |  1.78 |    0.05 |
|                                          For |         [1000] |   252.965 ns |  4.7584 ns |  4.4510 ns |   250.588 ns |  1.00 |    0.00 |
|                                              |                |              |            |            |              |       |         |
|                                         **Linq** |           **[50]** |   **327.448 ns** |  **0.0834 ns** |  **0.0780 ns** |   **327.434 ns** | **21.43** |    **0.23** |
|                      LowCostLinqWithDelegate |           [50] |   177.971 ns |  0.6264 ns |  0.5860 ns |   178.195 ns | 11.65 |    0.12 |
|                     LowCostLinqWithDelegate2 |           [50] |   199.112 ns |  2.5068 ns |  2.3448 ns |   197.948 ns | 13.03 |    0.25 |
|                   LowCostLinqWithStructWhere |           [50] |    93.032 ns |  0.0801 ns |  0.0749 ns |    93.016 ns |  6.09 |    0.06 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   453.071 ns |  0.0854 ns |  0.0757 ns |   453.033 ns | 29.64 |    0.32 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   339.695 ns |  5.3850 ns |  5.0372 ns |   336.243 ns | 22.23 |    0.51 |
|                                    LinqCount |           [50] |   134.983 ns |  2.0931 ns |  1.9579 ns |   135.664 ns |  8.83 |    0.16 |
|                 LowCostLinqWithDelegateCount |           [50] |   140.657 ns |  0.0258 ns |  0.0242 ns |   140.654 ns |  9.21 |    0.10 |
|              LowCostLinqWithStructWhereCount |           [50] |    66.858 ns |  0.0308 ns |  0.0288 ns |    66.857 ns |  4.38 |    0.05 |
|                                  LinqToArray |           [50] |   351.381 ns |  0.2410 ns |  0.2136 ns |   351.396 ns | 22.98 |    0.25 |
|               LowCostLinqWithDelegateToArray |           [50] |   312.942 ns |  0.4158 ns |  0.3890 ns |   312.870 ns | 20.48 |    0.23 |
|                 LowCostLinqWithStructToArray |           [50] |   200.144 ns |  0.1930 ns |  0.1805 ns |   200.170 ns | 13.10 |    0.14 |
|                                         Take |           [50] |   287.072 ns |  0.0887 ns |  0.0829 ns |   287.039 ns | 18.79 |    0.20 |
|                                  LowCostTake |           [50] |    96.845 ns |  1.1391 ns |  1.0655 ns |    95.926 ns |  6.34 |    0.13 |
|                        LowCostTakeWithStruct |           [50] |    62.338 ns |  0.0170 ns |  0.0142 ns |    62.339 ns |  4.07 |    0.04 |
|                               SkipTakeSingle |           [50] |   183.623 ns |  0.1273 ns |  0.1129 ns |   183.580 ns | 12.01 |    0.13 |
|                        LowCostSkipTakeSingle |           [50] |    92.776 ns |  0.0690 ns |  0.0612 ns |    92.764 ns |  6.07 |    0.07 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    55.343 ns |  0.4030 ns |  0.3770 ns |    55.217 ns |  3.62 |    0.03 |
|                              ForeachDelegate |           [50] |    95.717 ns |  0.0212 ns |  0.0198 ns |    95.710 ns |  6.26 |    0.07 |
|                                      Foreach |           [50] |    26.461 ns |  0.1364 ns |  0.1276 ns |    26.438 ns |  1.73 |    0.02 |
|                                          For |           [50] |    15.281 ns |  0.1781 ns |  0.1666 ns |    15.182 ns |  1.00 |    0.00 |
|                                              |                |              |            |            |              |       |         |
|                                         **Linq** |            **[5]** |    **58.837 ns** |  **0.0446 ns** |  **0.0395 ns** |    **58.822 ns** | **12.12** |    **0.14** |
|                      LowCostLinqWithDelegate |            [5] |    35.208 ns |  0.0638 ns |  0.0597 ns |    35.195 ns |  7.26 |    0.08 |
|                     LowCostLinqWithDelegate2 |            [5] |    45.483 ns |  0.0339 ns |  0.0317 ns |    45.482 ns |  9.37 |    0.11 |
|                   LowCostLinqWithStructWhere |            [5] |    28.315 ns |  0.2957 ns |  0.2766 ns |    28.266 ns |  5.84 |    0.09 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    81.085 ns |  0.0271 ns |  0.0253 ns |    81.085 ns | 16.71 |    0.18 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    71.345 ns |  0.0291 ns |  0.0272 ns |    71.352 ns | 14.70 |    0.16 |
|                                    LinqCount |            [5] |    41.320 ns |  0.6688 ns |  0.6256 ns |    40.872 ns |  8.52 |    0.20 |
|                 LowCostLinqWithDelegateCount |            [5] |    28.500 ns |  0.0309 ns |  0.0289 ns |    28.491 ns |  5.87 |    0.07 |
|              LowCostLinqWithStructWhereCount |            [5] |    19.310 ns |  0.0936 ns |  0.0876 ns |    19.297 ns |  3.98 |    0.06 |
|                                  LinqToArray |            [5] |    98.523 ns |  0.0453 ns |  0.0424 ns |    98.527 ns | 20.31 |    0.23 |
|               LowCostLinqWithDelegateToArray |            [5] |    68.504 ns |  1.3160 ns |  1.2310 ns |    67.627 ns | 14.12 |    0.31 |
|                 LowCostLinqWithStructToArray |            [5] |    55.426 ns |  0.0131 ns |  0.0123 ns |    55.426 ns | 11.42 |    0.13 |
|                                         Take |            [5] |   118.203 ns |  0.1081 ns |  0.1011 ns |   118.183 ns | 24.36 |    0.27 |
|                                  LowCostTake |            [5] |    42.885 ns |  0.0220 ns |  0.0172 ns |    42.888 ns |  8.82 |    0.10 |
|                        LowCostTakeWithStruct |            [5] |    37.183 ns |  0.0246 ns |  0.0218 ns |    37.185 ns |  7.66 |    0.09 |
|                               SkipTakeSingle |            [5] |   108.535 ns |  0.1457 ns |  0.1217 ns |   108.506 ns | 22.34 |    0.25 |
|                        LowCostSkipTakeSingle |            [5] |    40.879 ns |  0.0280 ns |  0.0248 ns |    40.890 ns |  8.42 |    0.09 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    36.850 ns |  0.3117 ns |  0.2916 ns |    36.869 ns |  7.59 |    0.06 |
|                              ForeachDelegate |            [5] |    14.417 ns |  0.0039 ns |  0.0037 ns |    14.417 ns |  2.97 |    0.03 |
|                                      Foreach |            [5] |     5.521 ns |  0.0134 ns |  0.0125 ns |     5.524 ns |  1.14 |    0.01 |
|                                          For |            [5] |     4.852 ns |  0.0581 ns |  0.0543 ns |     4.810 ns |  1.00 |    0.00 |
