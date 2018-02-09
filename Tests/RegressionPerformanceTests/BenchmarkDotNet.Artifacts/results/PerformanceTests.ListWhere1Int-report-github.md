``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |    **38.289 ns** |  **0.0568 ns** |  **0.0531 ns** |  **12.63** |     **0.03** |
|                                   LowCostLinqWithDelegate |              0 |    25.152 ns |  0.0206 ns |  0.0193 ns |   8.30 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |    18.906 ns |  0.0394 ns |  0.0329 ns |   6.24 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              0 |    34.030 ns |  0.0199 ns |  0.0176 ns |  11.23 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |    27.363 ns |  0.0590 ns |  0.0552 ns |   9.03 |     0.02 |
|                                LowCostLinqWithStructWhere |              0 |    28.501 ns |  0.0222 ns |  0.0197 ns |   9.40 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |    20.983 ns |  0.1082 ns |  0.1012 ns |   6.92 |     0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    39.823 ns |  0.0799 ns |  0.0708 ns |  13.14 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    36.054 ns |  0.1626 ns |  0.1521 ns |  11.90 |     0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |    41.306 ns |  0.0922 ns |  0.0863 ns |  13.63 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |    37.045 ns |  0.2022 ns |  0.1892 ns |  12.22 |     0.06 |
|                                                 LinqCount |              0 |    33.487 ns |  0.0558 ns |  0.0495 ns |  11.05 |     0.03 |
|                              LowCostLinqWithDelegateCount |              0 |    24.786 ns |  0.1370 ns |  0.1215 ns |   8.18 |     0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |    22.382 ns |  0.0389 ns |  0.0344 ns |   7.38 |     0.02 |
|                           LowCostLinqWithStructWhereCount |              0 |    22.107 ns |  0.0352 ns |  0.0294 ns |   7.29 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |    15.710 ns |  0.1838 ns |  0.1535 ns |   5.18 |     0.05 |
|                                               LinqToArray |              0 |    44.030 ns |  0.1780 ns |  0.1578 ns |  14.53 |     0.06 |
|                            LowCostLinqWithDelegateToArray |              0 |    28.248 ns |  0.0172 ns |  0.0144 ns |   9.32 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |    26.181 ns |  0.0852 ns |  0.0797 ns |   8.64 |     0.03 |
|                              LowCostLinqWithStructToArray |              0 |    25.087 ns |  0.1167 ns |  0.1091 ns |   8.28 |     0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |    18.216 ns |  0.1977 ns |  0.1849 ns |   6.01 |     0.06 |
|                                                      Take |              0 |    71.376 ns |  0.1222 ns |  0.1144 ns |  23.55 |     0.06 |
|                                               LowCostTake |              0 |    34.127 ns |  0.1039 ns |  0.0921 ns |  11.26 |     0.04 |
|                                  LowCostTakeWithoutChecks |              0 |    25.897 ns |  0.0406 ns |  0.0360 ns |   8.54 |     0.02 |
|                                     LowCostTakeWithStruct |              0 |    36.479 ns |  0.1540 ns |  0.1440 ns |  12.04 |     0.05 |
|                        LowCostTakeWithStructWithoutChecks |              0 |    27.526 ns |  0.0332 ns |  0.0277 ns |   9.08 |     0.02 |
|                                            SkipTakeSingle |              0 |    96.488 ns |  0.2344 ns |  0.2192 ns |  31.83 |     0.09 |
|                                     LowCostSkipTakeSingle |              0 |    36.141 ns |  0.0451 ns |  0.0422 ns |  11.92 |     0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |    34.746 ns |  0.2365 ns |  0.2212 ns |  11.46 |     0.07 |
|                           LowCostSkipTakeSingleWithStruct |              0 |    39.031 ns |  0.1316 ns |  0.1231 ns |  12.88 |     0.05 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |    31.508 ns |  0.0961 ns |  0.0899 ns |  10.40 |     0.03 |
|                                           ForeachDelegate |              0 |    15.062 ns |  0.0255 ns |  0.0213 ns |   4.97 |     0.01 |
|                                                   Foreach |              0 |    11.994 ns |  0.0440 ns |  0.0367 ns |   3.96 |     0.01 |
|                                                       For |              0 |     3.031 ns |  0.0067 ns |  0.0059 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **7,642.276 ns** | **12.5381 ns** | **11.1147 ns** |  **30.39** |     **0.04** |
|                                   LowCostLinqWithDelegate |           1000 | 3,690.043 ns | 23.4772 ns | 20.8119 ns |  14.68 |     0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 2,912.328 ns |  5.2719 ns |  4.9314 ns |  11.58 |     0.02 |
|                                  LowCostLinqWithDelegate2 |           1000 | 3,966.813 ns | 38.1580 ns | 35.6930 ns |  15.78 |     0.14 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 3,167.012 ns |  7.3365 ns |  6.8625 ns |  12.60 |     0.03 |
|                                LowCostLinqWithStructWhere |           1000 | 1,846.727 ns |  4.0757 ns |  3.8125 ns |   7.34 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 | 1,741.112 ns |  3.5860 ns |  3.3543 ns |   6.92 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 8,954.594 ns | 25.5679 ns | 23.9162 ns |  35.61 |     0.09 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 7,913.586 ns | 16.2320 ns | 15.1834 ns |  31.47 |     0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 7,044.609 ns | 11.0746 ns | 10.3592 ns |  28.02 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 6,047.014 ns | 13.6198 ns | 11.3731 ns |  24.05 |     0.04 |
|                                                 LinqCount |           1000 | 1,491.567 ns |  2.7922 ns |  2.4752 ns |   5.93 |     0.01 |
|                              LowCostLinqWithDelegateCount |           1000 | 3,879.390 ns | 22.2543 ns | 20.8167 ns |  15.43 |     0.08 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 2,435.184 ns |  6.6840 ns |  6.2522 ns |   9.68 |     0.02 |
|                           LowCostLinqWithStructWhereCount |           1000 | 1,738.819 ns |  3.0275 ns |  2.3636 ns |   6.92 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 | 1,207.695 ns |  0.5146 ns |  0.4298 ns |   4.80 |     0.00 |
|                                               LinqToArray |           1000 | 3,380.506 ns | 11.6760 ns | 10.9217 ns |  13.44 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           1000 | 4,898.635 ns |  7.4108 ns |  6.1883 ns |  19.48 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 3,897.934 ns |  9.1024 ns |  8.5144 ns |  15.50 |     0.03 |
|                              LowCostLinqWithStructToArray |           1000 | 3,147.247 ns |  7.6724 ns |  6.8014 ns |  12.52 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 | 2,298.383 ns | 13.5015 ns | 12.6293 ns |   9.14 |     0.05 |
|                                                      Take |           1000 |   321.634 ns |  0.0582 ns |  0.0545 ns |   1.28 |     0.00 |
|                                               LowCostTake |           1000 |   116.565 ns |  0.0416 ns |  0.0369 ns |   0.46 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    95.999 ns |  0.0130 ns |  0.0115 ns |   0.38 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    76.760 ns |  0.1872 ns |  0.1751 ns |   0.31 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    66.242 ns |  0.0172 ns |  0.0144 ns |   0.26 |     0.00 |
|                                            SkipTakeSingle |           1000 |   228.904 ns |  0.0330 ns |  0.0218 ns |   0.91 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |   123.573 ns |  0.0249 ns |  0.0194 ns |   0.49 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |   105.902 ns |  0.0476 ns |  0.0397 ns |   0.42 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    81.024 ns |  0.3312 ns |  0.2586 ns |   0.32 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    60.780 ns |  0.0335 ns |  0.0261 ns |   0.24 |     0.00 |
|                                           ForeachDelegate |           1000 | 2,900.165 ns |  7.9381 ns |  7.0370 ns |  11.53 |     0.03 |
|                                                   Foreach |           1000 | 1,692.513 ns |  3.8430 ns |  3.4067 ns |   6.73 |     0.01 |
|                                                       For |           1000 |   251.449 ns |  0.0423 ns |  0.0306 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **76.364 ns** |  **0.1883 ns** |  **0.1669 ns** |  **17.47** |     **0.05** |
|                                   LowCostLinqWithDelegate |              5 |    44.345 ns |  0.0857 ns |  0.0669 ns |  10.15 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |    34.498 ns |  0.0619 ns |  0.0549 ns |   7.89 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              5 |    55.810 ns |  0.0582 ns |  0.0421 ns |  12.77 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    43.993 ns |  0.0482 ns |  0.0427 ns |  10.07 |     0.02 |
|                                LowCostLinqWithStructWhere |              5 |    39.603 ns |  0.0672 ns |  0.0595 ns |   9.06 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |    30.002 ns |  0.0470 ns |  0.0392 ns |   6.87 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    87.798 ns |  0.1934 ns |  0.1510 ns |  20.09 |     0.05 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    77.406 ns |  0.0837 ns |  0.0783 ns |  17.71 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    78.537 ns |  0.1606 ns |  0.1254 ns |  17.97 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    69.696 ns |  0.1745 ns |  0.1547 ns |  15.95 |     0.04 |
|                                                 LinqCount |              5 |    41.315 ns |  0.0491 ns |  0.0459 ns |   9.45 |     0.02 |
|                              LowCostLinqWithDelegateCount |              5 |    45.349 ns |  0.3485 ns |  0.3090 ns |  10.38 |     0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    36.602 ns |  0.0528 ns |  0.0441 ns |   8.38 |     0.02 |
|                           LowCostLinqWithStructWhereCount |              5 |    31.187 ns |  0.1416 ns |  0.1324 ns |   7.14 |     0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |    21.278 ns |  0.0296 ns |  0.0277 ns |   4.87 |     0.01 |
|                                               LinqToArray |              5 |    98.106 ns |  0.1620 ns |  0.1353 ns |  22.45 |     0.05 |
|                            LowCostLinqWithDelegateToArray |              5 |    84.624 ns |  0.1286 ns |  0.1140 ns |  19.36 |     0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    78.715 ns |  0.3475 ns |  0.3250 ns |  18.01 |     0.08 |
|                              LowCostLinqWithStructToArray |              5 |    72.023 ns |  0.4071 ns |  0.3808 ns |  16.48 |     0.09 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    59.172 ns |  0.1767 ns |  0.1476 ns |  13.54 |     0.04 |
|                                                      Take |              5 |   139.005 ns |  0.3850 ns |  0.3601 ns |  31.81 |     0.10 |
|                                               LowCostTake |              5 |    54.993 ns |  0.0830 ns |  0.0736 ns |  12.58 |     0.03 |
|                                  LowCostTakeWithoutChecks |              5 |    42.935 ns |  0.2090 ns |  0.1955 ns |   9.82 |     0.05 |
|                                     LowCostTakeWithStruct |              5 |    47.051 ns |  0.0580 ns |  0.0484 ns |  10.77 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |              5 |    37.547 ns |  0.0277 ns |  0.0232 ns |   8.59 |     0.02 |
|                                            SkipTakeSingle |              5 |   127.609 ns |  0.4818 ns |  0.4506 ns |  29.20 |     0.11 |
|                                     LowCostSkipTakeSingle |              5 |    54.060 ns |  0.2597 ns |  0.2429 ns |  12.37 |     0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    46.276 ns |  0.0908 ns |  0.0849 ns |  10.59 |     0.03 |
|                           LowCostSkipTakeSingleWithStruct |              5 |    48.280 ns |  0.0719 ns |  0.0638 ns |  11.05 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |    37.827 ns |  0.0295 ns |  0.0261 ns |   8.66 |     0.02 |
|                                           ForeachDelegate |              5 |    29.798 ns |  0.0341 ns |  0.0302 ns |   6.82 |     0.01 |
|                                                   Foreach |              5 |    19.875 ns |  0.1043 ns |  0.0976 ns |   4.55 |     0.02 |
|                                                       For |              5 |     4.370 ns |  0.0088 ns |  0.0078 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |   **427.254 ns** |  **1.9898 ns** |  **1.8612 ns** |  **25.89** |     **0.12** |
|                                   LowCostLinqWithDelegate |             50 |   220.185 ns |  0.3553 ns |  0.2967 ns |  13.34 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |   172.731 ns |  0.7303 ns |  0.6831 ns |  10.47 |     0.04 |
|                                  LowCostLinqWithDelegate2 |             50 |   238.139 ns |  0.5058 ns |  0.4484 ns |  14.43 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |   187.624 ns |  0.4063 ns |  0.3801 ns |  11.37 |     0.03 |
|                                LowCostLinqWithStructWhere |             50 |   129.072 ns |  0.2460 ns |  0.2181 ns |   7.82 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |   106.516 ns |  0.5430 ns |  0.5080 ns |   6.46 |     0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |   497.420 ns |  1.8282 ns |  1.7101 ns |  30.15 |     0.11 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |   439.087 ns |  2.1184 ns |  1.7689 ns |  26.61 |     0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |   402.883 ns |  1.0685 ns |  0.9994 ns |  24.42 |     0.07 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |   346.166 ns |  0.3120 ns |  0.2919 ns |  20.98 |     0.04 |
|                                                 LinqCount |             50 |   112.282 ns |  0.2330 ns |  0.2180 ns |   6.80 |     0.02 |
|                              LowCostLinqWithDelegateCount |             50 |   223.141 ns |  0.1074 ns |  0.0897 ns |  13.52 |     0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |   150.225 ns |  0.0418 ns |  0.0391 ns |   9.10 |     0.02 |
|                           LowCostLinqWithStructWhereCount |             50 |   115.077 ns |  0.0204 ns |  0.0170 ns |   6.97 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    70.368 ns |  0.0232 ns |  0.0205 ns |   4.26 |     0.01 |
|                                               LinqToArray |             50 |   375.152 ns |  0.1500 ns |  0.1330 ns |  22.74 |     0.04 |
|                            LowCostLinqWithDelegateToArray |             50 |   386.863 ns |  1.3706 ns |  1.2821 ns |  23.45 |     0.09 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |   317.409 ns |  0.5981 ns |  0.5595 ns |  19.24 |     0.05 |
|                              LowCostLinqWithStructToArray |             50 |   266.587 ns |  0.5812 ns |  0.4853 ns |  16.16 |     0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |   218.610 ns |  0.5422 ns |  0.4528 ns |  13.25 |     0.04 |
|                                                      Take |             50 |   322.984 ns |  2.0226 ns |  1.6890 ns |  19.57 |     0.10 |
|                                               LowCostTake |             50 |   116.494 ns |  0.0226 ns |  0.0189 ns |   7.06 |     0.01 |
|                                  LowCostTakeWithoutChecks |             50 |    96.008 ns |  0.0771 ns |  0.0602 ns |   5.82 |     0.01 |
|                                     LowCostTakeWithStruct |             50 |    77.468 ns |  0.2237 ns |  0.2093 ns |   4.69 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    65.867 ns |  0.0269 ns |  0.0239 ns |   3.99 |     0.01 |
|                                            SkipTakeSingle |             50 |   229.826 ns |  1.1730 ns |  1.0972 ns |  13.93 |     0.07 |
|                                     LowCostSkipTakeSingle |             50 |   124.212 ns |  0.2390 ns |  0.2235 ns |   7.53 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |   105.961 ns |  0.1567 ns |  0.1466 ns |   6.42 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    80.240 ns |  0.2179 ns |  0.2038 ns |   4.86 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    60.063 ns |  0.0731 ns |  0.0611 ns |   3.64 |     0.01 |
|                                           ForeachDelegate |             50 |   171.763 ns |  1.3625 ns |  1.2745 ns |  10.41 |     0.08 |
|                                                   Foreach |             50 |   103.104 ns |  0.1915 ns |  0.1698 ns |   6.25 |     0.02 |
|                                                       For |             50 |    16.500 ns |  0.0338 ns |  0.0317 ns |   1.00 |     0.00 |
