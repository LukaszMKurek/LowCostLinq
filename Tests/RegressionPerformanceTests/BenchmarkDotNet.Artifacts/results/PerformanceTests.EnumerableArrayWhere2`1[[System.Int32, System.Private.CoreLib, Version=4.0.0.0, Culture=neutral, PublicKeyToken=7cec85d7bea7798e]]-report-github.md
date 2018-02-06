``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **51.59 ns** |  **0.5537 ns** |  **0.5179 ns** |   **4.01** |     **0.04** |
|                                   LowCostLinqWithDelegate |              0 |     36.52 ns |  0.0026 ns |  0.0023 ns |   2.84 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     35.91 ns |  0.0239 ns |  0.0224 ns |   2.79 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     49.90 ns |  0.0052 ns |  0.0046 ns |   3.88 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     50.63 ns |  0.0254 ns |  0.0199 ns |   3.94 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     51.97 ns |  0.0041 ns |  0.0034 ns |   4.04 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     43.71 ns |  0.0064 ns |  0.0054 ns |   3.40 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     91.62 ns |  0.9744 ns |  0.9115 ns |   7.12 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     87.37 ns |  0.0741 ns |  0.0693 ns |   6.79 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     74.01 ns |  0.0443 ns |  0.0414 ns |   5.75 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     71.59 ns |  0.0660 ns |  0.0551 ns |   5.57 |     0.00 |
|                                                 LinqCount |              0 |     49.32 ns |  0.0758 ns |  0.0709 ns |   3.83 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     35.30 ns |  0.0092 ns |  0.0086 ns |   2.74 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     35.04 ns |  0.0146 ns |  0.0136 ns |   2.72 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     30.84 ns |  0.0279 ns |  0.0261 ns |   2.40 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     30.80 ns |  0.0005 ns |  0.0004 ns |   2.39 |     0.00 |
|                                               LinqToArray |              0 |     65.66 ns |  0.0587 ns |  0.0520 ns |   5.10 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     46.34 ns |  0.0147 ns |  0.0115 ns |   3.60 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     46.51 ns |  0.2865 ns |  0.2680 ns |   3.62 |     0.02 |
|                              LowCostLinqWithStructToArray |              0 |     40.06 ns |  0.0502 ns |  0.0469 ns |   3.11 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     40.30 ns |  0.0296 ns |  0.0277 ns |   3.13 |     0.00 |
|                                                      Take |              0 |     85.98 ns |  0.0230 ns |  0.0192 ns |   6.68 |     0.00 |
|                                               LowCostTake |              0 |     41.25 ns |  0.0408 ns |  0.0381 ns |   3.21 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     43.85 ns |  0.0141 ns |  0.0118 ns |   3.41 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     58.26 ns |  0.0325 ns |  0.0304 ns |   4.53 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     48.59 ns |  0.0429 ns |  0.0335 ns |   3.78 |     0.00 |
|                                            SkipTakeSingle |              0 |    109.83 ns |  0.1410 ns |  0.1319 ns |   8.54 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     50.82 ns |  0.1469 ns |  0.1374 ns |   3.95 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     51.08 ns |  0.0023 ns |  0.0019 ns |   3.97 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     53.63 ns |  0.0441 ns |  0.0412 ns |   4.17 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     52.93 ns |  0.0182 ns |  0.0142 ns |   4.11 |     0.00 |
|                                           ForeachDelegate |              0 |     15.18 ns |  0.0114 ns |  0.0101 ns |   1.18 |     0.00 |
|                                                   Foreach |              0 |     12.86 ns |  0.0043 ns |  0.0036 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** |  **7,831.25 ns** |  **5.0500 ns** |  **3.9427 ns** |   **1.80** |     **0.02** |
|                                   LowCostLinqWithDelegate |           1000 |  5,641.09 ns | 30.0292 ns | 28.0893 ns |   1.30 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,217.68 ns | 17.7582 ns | 16.6110 ns |   1.20 |     0.01 |
|                                  LowCostLinqWithDelegate2 |           1000 |  6,407.77 ns | 22.5423 ns | 21.0860 ns |   1.47 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  6,524.10 ns |  5.1247 ns |  4.7936 ns |   1.50 |     0.01 |
|                                LowCostLinqWithStructWhere |           1000 |  1,730.32 ns |  1.3009 ns |  1.0863 ns |   0.40 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,563.26 ns |  0.4930 ns |  0.4611 ns |   0.36 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 18,440.36 ns | 64.8974 ns | 60.7050 ns |   4.24 |     0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 18,233.56 ns | 43.1737 ns | 36.0520 ns |   4.20 |     0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  7,758.60 ns |  5.4947 ns |  4.5884 ns |   1.79 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,495.45 ns |  4.5804 ns |  4.2845 ns |   1.72 |     0.02 |
|                                                 LinqCount |           1000 |  4,159.69 ns | 18.9584 ns | 17.7337 ns |   0.96 |     0.01 |
|                              LowCostLinqWithDelegateCount |           1000 |  4,098.30 ns |  1.5823 ns |  1.3213 ns |   0.94 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,603.20 ns | 32.4463 ns | 30.3503 ns |   1.06 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,355.04 ns |  0.1980 ns |  0.1654 ns |   0.31 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,346.61 ns |  0.6585 ns |  0.6160 ns |   0.31 |     0.00 |
|                                               LinqToArray |           1000 |  5,229.69 ns |  3.5061 ns |  3.2796 ns |   1.20 |     0.01 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,790.62 ns | 51.8460 ns | 48.4968 ns |   1.79 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  5,614.69 ns |  4.2106 ns |  3.5160 ns |   1.29 |     0.01 |
|                              LowCostLinqWithStructToArray |           1000 |  2,255.21 ns |  7.1070 ns |  6.6479 ns |   0.52 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,218.65 ns |  1.5029 ns |  1.3323 ns |   0.51 |     0.00 |
|                                                      Take |           1000 |    353.78 ns |  3.4006 ns |  3.1810 ns |   0.08 |     0.00 |
|                                               LowCostTake |           1000 |    161.90 ns |  0.2263 ns |  0.2117 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    172.33 ns |  0.0904 ns |  0.0802 ns |   0.04 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    102.69 ns |  0.0303 ns |  0.0269 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     87.85 ns |  0.0683 ns |  0.0639 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    262.84 ns |  0.0951 ns |  0.0843 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    159.14 ns |  0.0848 ns |  0.0708 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    161.22 ns |  0.0098 ns |  0.0087 ns |   0.04 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     79.02 ns |  0.0726 ns |  0.0643 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     73.28 ns |  0.0100 ns |  0.0078 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  7,133.99 ns |  3.8578 ns |  3.6086 ns |   1.64 |     0.01 |
|                                                   Foreach |           1000 |  4,346.44 ns | 43.9070 ns | 41.0706 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |     **99.06 ns** |  **0.1226 ns** |  **0.1147 ns** |   **2.87** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     60.96 ns |  0.6294 ns |  0.5887 ns |   1.76 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     58.23 ns |  0.0054 ns |  0.0036 ns |   1.69 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     76.05 ns |  0.0678 ns |  0.0635 ns |   2.20 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     85.79 ns |  0.4723 ns |  0.4418 ns |   2.48 |     0.01 |
|                                LowCostLinqWithStructWhere |              5 |     60.72 ns |  0.0358 ns |  0.0334 ns |   1.76 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     53.73 ns |  0.0066 ns |  0.0055 ns |   1.56 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    197.19 ns |  1.7267 ns |  1.6152 ns |   5.71 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    195.29 ns |  0.1203 ns |  0.1125 ns |   5.65 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    114.24 ns |  0.0238 ns |  0.0211 ns |   3.31 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    111.66 ns |  0.9736 ns |  0.9107 ns |   3.23 |     0.03 |
|                                                 LinqCount |              5 |     81.04 ns |  0.0263 ns |  0.0206 ns |   2.35 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     55.83 ns |  0.0406 ns |  0.0360 ns |   1.62 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     56.62 ns |  0.3525 ns |  0.3297 ns |   1.64 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              5 |     38.95 ns |  0.0147 ns |  0.0130 ns |   1.13 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     33.72 ns |  0.0055 ns |  0.0043 ns |   0.98 |     0.00 |
|                                               LinqToArray |              5 |    137.96 ns |  0.0338 ns |  0.0264 ns |   3.99 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    111.86 ns |  0.0758 ns |  0.0709 ns |   3.24 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    105.77 ns |  0.1051 ns |  0.0984 ns |   3.06 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     77.99 ns |  0.1149 ns |  0.1074 ns |   2.26 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     79.41 ns |  0.1150 ns |  0.1076 ns |   2.30 |     0.00 |
|                                                      Take |              5 |    162.97 ns |  0.1034 ns |  0.0917 ns |   4.72 |     0.00 |
|                                               LowCostTake |              5 |     65.94 ns |  0.0118 ns |  0.0092 ns |   1.91 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     72.03 ns |  0.0407 ns |  0.0318 ns |   2.09 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     70.10 ns |  0.0297 ns |  0.0278 ns |   2.03 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     68.20 ns |  0.0731 ns |  0.0684 ns |   1.97 |     0.00 |
|                                            SkipTakeSingle |              5 |    150.38 ns |  0.0314 ns |  0.0294 ns |   4.35 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     69.75 ns |  0.0339 ns |  0.0300 ns |   2.02 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     71.48 ns |  0.7004 ns |  0.6552 ns |   2.07 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     56.46 ns |  0.0049 ns |  0.0035 ns |   1.63 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     56.23 ns |  0.0085 ns |  0.0075 ns |   1.63 |     0.00 |
|                                           ForeachDelegate |              5 |     53.17 ns |  0.4114 ns |  0.3848 ns |   1.54 |     0.01 |
|                                                   Foreach |              5 |     34.54 ns |  0.0058 ns |  0.0049 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **456.03 ns** |  **0.2242 ns** |  **0.2097 ns** |   **1.93** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    317.16 ns |  0.3655 ns |  0.3240 ns |   1.34 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    301.19 ns |  2.5358 ns |  2.3720 ns |   1.27 |     0.01 |
|                                  LowCostLinqWithDelegate2 |             50 |    364.57 ns |  0.2735 ns |  0.2425 ns |   1.54 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    374.41 ns |  0.1206 ns |  0.1069 ns |   1.58 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    142.04 ns |  0.0192 ns |  0.0170 ns |   0.60 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    128.49 ns |  0.9609 ns |  0.8988 ns |   0.54 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,097.53 ns |  1.1372 ns |  1.0081 ns |   4.64 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,054.10 ns |  1.2585 ns |  1.1772 ns |   4.46 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    469.38 ns |  0.0599 ns |  0.0531 ns |   1.99 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    451.39 ns |  0.7156 ns |  0.5975 ns |   1.91 |     0.00 |
|                                                 LinqCount |             50 |    267.69 ns |  0.0649 ns |  0.0542 ns |   1.13 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    242.83 ns |  0.0908 ns |  0.0849 ns |   1.03 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    265.04 ns |  0.2966 ns |  0.2775 ns |   1.12 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |     85.79 ns |  0.4307 ns |  0.4028 ns |   0.36 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     87.35 ns |  0.0078 ns |  0.0069 ns |   0.37 |     0.00 |
|                                               LinqToArray |             50 |    517.55 ns |  0.4372 ns |  0.4090 ns |   2.19 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    531.46 ns |  0.4053 ns |  0.3593 ns |   2.25 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    437.54 ns |  0.7030 ns |  0.6576 ns |   1.85 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    227.42 ns |  0.3805 ns |  0.3373 ns |   0.96 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    226.61 ns |  1.7608 ns |  1.6470 ns |   0.96 |     0.01 |
|                                                      Take |             50 |    350.83 ns |  0.0439 ns |  0.0410 ns |   1.48 |     0.00 |
|                                               LowCostTake |             50 |    162.74 ns |  0.2252 ns |  0.2106 ns |   0.69 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    170.56 ns |  0.0772 ns |  0.0684 ns |   0.72 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    103.40 ns |  0.5845 ns |  0.5182 ns |   0.44 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     87.05 ns |  0.0224 ns |  0.0210 ns |   0.37 |     0.00 |
|                                            SkipTakeSingle |             50 |    259.95 ns |  0.0608 ns |  0.0475 ns |   1.10 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    159.82 ns |  0.0890 ns |  0.0833 ns |   0.68 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    161.75 ns |  0.0290 ns |  0.0242 ns |   0.68 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     73.63 ns |  0.0124 ns |  0.0110 ns |   0.31 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     73.67 ns |  0.0206 ns |  0.0182 ns |   0.31 |     0.00 |
|                                           ForeachDelegate |             50 |    379.86 ns |  0.0870 ns |  0.0679 ns |   1.61 |     0.00 |
|                                                   Foreach |             50 |    236.29 ns |  0.1551 ns |  0.1451 ns |   1.00 |     0.00 |
