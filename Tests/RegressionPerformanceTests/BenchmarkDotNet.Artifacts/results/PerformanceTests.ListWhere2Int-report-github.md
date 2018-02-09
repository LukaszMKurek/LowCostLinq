``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **63.453 ns** |  **0.1094 ns** |  **0.0970 ns** |  **21.12** |     **0.03** |
|                                   LowCostLinqWithDelegate |              0 |     27.706 ns |  0.0023 ns |  0.0021 ns |   9.22 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     19.845 ns |  0.0013 ns |  0.0012 ns |   6.60 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     41.141 ns |  0.0114 ns |  0.0096 ns |  13.69 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     37.249 ns |  0.0165 ns |  0.0154 ns |  12.40 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     35.563 ns |  0.0020 ns |  0.0017 ns |  11.83 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     27.271 ns |  0.0043 ns |  0.0036 ns |   9.08 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     56.280 ns |  0.0316 ns |  0.0264 ns |  18.73 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     52.665 ns |  0.0353 ns |  0.0330 ns |  17.53 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     49.069 ns |  0.0131 ns |  0.0103 ns |  16.33 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     39.621 ns |  0.0056 ns |  0.0043 ns |  13.18 |     0.01 |
|                                                 LinqCount |              0 |     60.241 ns |  0.1332 ns |  0.1246 ns |  20.05 |     0.04 |
|                              LowCostLinqWithDelegateCount |              0 |     25.234 ns |  0.0197 ns |  0.0184 ns |   8.40 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     23.180 ns |  0.0044 ns |  0.0034 ns |   7.71 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     28.184 ns |  0.0011 ns |  0.0011 ns |   9.38 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     20.538 ns |  0.0037 ns |  0.0034 ns |   6.83 |     0.00 |
|                                               LinqToArray |              0 |     71.523 ns |  0.0718 ns |  0.0672 ns |  23.80 |     0.03 |
|                            LowCostLinqWithDelegateToArray |              0 |     27.626 ns |  0.0221 ns |  0.0207 ns |   9.19 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     26.872 ns |  0.0088 ns |  0.0068 ns |   8.94 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     31.229 ns |  0.0299 ns |  0.0280 ns |  10.39 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     23.539 ns |  0.0068 ns |  0.0057 ns |   7.83 |     0.00 |
|                                                      Take |              0 |     98.352 ns |  0.0168 ns |  0.0140 ns |  32.73 |     0.02 |
|                                               LowCostTake |              0 |     34.682 ns |  0.0265 ns |  0.0248 ns |  11.54 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     31.006 ns |  0.0022 ns |  0.0018 ns |  10.32 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     42.490 ns |  0.0044 ns |  0.0039 ns |  14.14 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     35.287 ns |  0.0009 ns |  0.0008 ns |  11.74 |     0.01 |
|                                            SkipTakeSingle |              0 |    120.555 ns |  0.1620 ns |  0.1515 ns |  40.12 |     0.05 |
|                                     LowCostSkipTakeSingle |              0 |     39.932 ns |  0.0204 ns |  0.0191 ns |  13.29 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     36.978 ns |  0.0098 ns |  0.0087 ns |  12.31 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     47.495 ns |  0.0021 ns |  0.0018 ns |  15.81 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     40.296 ns |  0.0069 ns |  0.0065 ns |  13.41 |     0.01 |
|                                           ForeachDelegate |              0 |     15.647 ns |  0.0037 ns |  0.0033 ns |   5.21 |     0.00 |
|                                                   Foreach |              0 |     12.092 ns |  0.0081 ns |  0.0063 ns |   4.02 |     0.00 |
|                                                       For |              0 |      3.005 ns |  0.0019 ns |  0.0018 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |        |          |
|                                                      **Linq** |           **1000** |  **9,262.958 ns** | **11.6171 ns** | **10.8666 ns** |  **37.00** |     **0.04** |
|                                   LowCostLinqWithDelegate |           1000 |  5,295.204 ns |  1.4483 ns |  1.1308 ns |  21.15 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,084.267 ns |  5.0559 ns |  4.7293 ns |  20.31 |     0.02 |
|                                  LowCostLinqWithDelegate2 |           1000 |  6,012.232 ns |  2.6335 ns |  2.3345 ns |  24.01 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  5,531.624 ns |  0.6824 ns |  0.5328 ns |  22.09 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  1,840.133 ns |  1.4641 ns |  1.3695 ns |   7.35 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,732.158 ns |  0.3323 ns |  0.2946 ns |   6.92 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 17,286.170 ns | 29.6252 ns | 23.1294 ns |  69.05 |     0.09 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 16,362.952 ns | 32.8102 ns | 30.6907 ns |  65.36 |     0.12 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,268.854 ns |  4.0750 ns |  3.6124 ns |  25.04 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  5,503.457 ns |  3.1084 ns |  2.9076 ns |  21.98 |     0.01 |
|                                                 LinqCount |           1000 |  3,963.794 ns | 15.5522 ns | 14.5475 ns |  15.83 |     0.06 |
|                              LowCostLinqWithDelegateCount |           1000 |  6,459.950 ns |  3.3024 ns |  2.7577 ns |  25.80 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,559.953 ns |  0.3366 ns |  0.2984 ns |  18.21 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,731.765 ns |  1.6904 ns |  1.5812 ns |   6.92 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,210.986 ns |  0.0340 ns |  0.0302 ns |   4.84 |     0.00 |
|                                               LinqToArray |           1000 |  5,341.631 ns |  6.3229 ns |  5.9144 ns |  21.34 |     0.02 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,508.300 ns |  9.2709 ns |  8.2184 ns |  29.99 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  6,586.386 ns | 17.5105 ns | 14.6220 ns |  26.31 |     0.06 |
|                              LowCostLinqWithStructToArray |           1000 |  3,171.648 ns |  5.6445 ns |  5.0037 ns |  12.67 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,335.061 ns |  1.6454 ns |  1.1897 ns |   9.33 |     0.00 |
|                                                      Take |           1000 |    405.231 ns |  0.4805 ns |  0.4495 ns |   1.62 |     0.00 |
|                                               LowCostTake |           1000 |    170.968 ns |  0.0119 ns |  0.0105 ns |   0.68 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    150.644 ns |  0.0996 ns |  0.0932 ns |   0.60 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     82.071 ns |  0.0130 ns |  0.0115 ns |   0.33 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     75.294 ns |  0.0913 ns |  0.0762 ns |   0.30 |     0.00 |
|                                            SkipTakeSingle |           1000 |    305.722 ns |  0.0477 ns |  0.0423 ns |   1.22 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    179.430 ns |  0.1897 ns |  0.1681 ns |   0.72 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    154.497 ns |  0.0225 ns |  0.0176 ns |   0.62 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     88.831 ns |  0.0866 ns |  0.0810 ns |   0.35 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     66.178 ns |  0.0436 ns |  0.0364 ns |   0.26 |     0.00 |
|                                           ForeachDelegate |           1000 |  4,570.237 ns |  6.5608 ns |  6.1370 ns |  18.25 |     0.02 |
|                                                   Foreach |           1000 |  1,691.394 ns |  1.6198 ns |  1.5152 ns |   6.76 |     0.01 |
|                                                       For |           1000 |    250.360 ns |  0.0082 ns |  0.0073 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |        |          |
|                                                      **Linq** |              **5** |    **111.822 ns** |  **0.0914 ns** |  **0.0855 ns** |  **25.73** |     **0.02** |
|                                   LowCostLinqWithDelegate |              5 |     53.734 ns |  0.0300 ns |  0.0251 ns |  12.36 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     43.590 ns |  0.0262 ns |  0.0233 ns |  10.03 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |     73.458 ns |  0.0536 ns |  0.0502 ns |  16.90 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     63.627 ns |  0.0836 ns |  0.0782 ns |  14.64 |     0.02 |
|                                LowCostLinqWithStructWhere |              5 |     45.757 ns |  0.0033 ns |  0.0027 ns |  10.53 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     36.238 ns |  0.0118 ns |  0.0099 ns |   8.34 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    145.357 ns |  0.2761 ns |  0.2582 ns |  33.44 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    134.388 ns |  0.0815 ns |  0.0762 ns |  30.92 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |     78.553 ns |  0.0232 ns |  0.0217 ns |  18.07 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |     67.492 ns |  0.0714 ns |  0.0633 ns |  15.53 |     0.02 |
|                                                 LinqCount |              5 |     79.879 ns |  0.1157 ns |  0.1082 ns |  18.38 |     0.03 |
|                              LowCostLinqWithDelegateCount |              5 |     56.862 ns |  0.0403 ns |  0.0377 ns |  13.08 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     46.419 ns |  0.0353 ns |  0.0330 ns |  10.68 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              5 |     37.083 ns |  0.0073 ns |  0.0064 ns |   8.53 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     29.996 ns |  0.0214 ns |  0.0200 ns |   6.90 |     0.01 |
|                                               LinqToArray |              5 |    138.360 ns |  0.1807 ns |  0.1691 ns |  31.83 |     0.04 |
|                            LowCostLinqWithDelegateToArray |              5 |     93.358 ns |  0.0931 ns |  0.0870 ns |  21.48 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     88.139 ns |  0.0238 ns |  0.0186 ns |  20.28 |     0.01 |
|                              LowCostLinqWithStructToArray |              5 |     77.442 ns |  0.0440 ns |  0.0367 ns |  17.82 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     64.008 ns |  0.0364 ns |  0.0322 ns |  14.73 |     0.01 |
|                                                      Take |              5 |    175.445 ns |  0.1413 ns |  0.1180 ns |  40.36 |     0.03 |
|                                               LowCostTake |              5 |     65.944 ns |  0.0346 ns |  0.0324 ns |  15.17 |     0.01 |
|                                  LowCostTakeWithoutChecks |              5 |     52.789 ns |  0.0262 ns |  0.0245 ns |  12.14 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     52.513 ns |  0.0119 ns |  0.0106 ns |  12.08 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     46.340 ns |  0.0088 ns |  0.0078 ns |  10.66 |     0.01 |
|                                            SkipTakeSingle |              5 |    163.123 ns |  0.1212 ns |  0.1133 ns |  37.53 |     0.03 |
|                                     LowCostSkipTakeSingle |              5 |     68.181 ns |  0.1058 ns |  0.0990 ns |  15.69 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     55.966 ns |  0.0882 ns |  0.0825 ns |  12.88 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     56.689 ns |  0.0263 ns |  0.0246 ns |  13.04 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     44.731 ns |  0.0183 ns |  0.0153 ns |  10.29 |     0.01 |
|                                           ForeachDelegate |              5 |     38.255 ns |  0.0120 ns |  0.0107 ns |   8.80 |     0.01 |
|                                                   Foreach |              5 |     19.794 ns |  0.0223 ns |  0.0209 ns |   4.55 |     0.01 |
|                                                       For |              5 |      4.347 ns |  0.0026 ns |  0.0023 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |        |          |
|                                                      **Linq** |             **50** |    **533.483 ns** |  **0.2881 ns** |  **0.2406 ns** |  **32.58** |     **0.03** |
|                                   LowCostLinqWithDelegate |             50 |    295.941 ns |  0.0894 ns |  0.0792 ns |  18.07 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    265.933 ns |  0.2618 ns |  0.2186 ns |  16.24 |     0.02 |
|                                  LowCostLinqWithDelegate2 |             50 |    344.926 ns |  0.1105 ns |  0.0979 ns |  21.07 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    314.971 ns |  0.2067 ns |  0.1933 ns |  19.24 |     0.02 |
|                                LowCostLinqWithStructWhere |             50 |    132.599 ns |  0.0323 ns |  0.0286 ns |   8.10 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    113.175 ns |  0.0565 ns |  0.0528 ns |   6.91 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    940.301 ns |  1.5608 ns |  1.2185 ns |  57.43 |     0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    873.025 ns |  0.8300 ns |  0.6931 ns |  53.32 |     0.05 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    366.985 ns |  0.1856 ns |  0.1736 ns |  22.41 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    322.508 ns |  0.0752 ns |  0.0628 ns |  19.70 |     0.01 |
|                                                 LinqCount |             50 |    262.324 ns |  0.5814 ns |  0.5439 ns |  16.02 |     0.03 |
|                              LowCostLinqWithDelegateCount |             50 |    358.826 ns |  0.0289 ns |  0.0242 ns |  21.91 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    255.723 ns |  0.0802 ns |  0.0750 ns |  15.62 |     0.01 |
|                           LowCostLinqWithStructWhereCount |             50 |    120.343 ns |  0.0651 ns |  0.0577 ns |   7.35 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     76.141 ns |  0.0080 ns |  0.0071 ns |   4.65 |     0.00 |
|                                               LinqToArray |             50 |    530.473 ns |  0.3975 ns |  0.3718 ns |  32.40 |     0.03 |
|                            LowCostLinqWithDelegateToArray |             50 |    508.452 ns |  0.2519 ns |  0.2103 ns |  31.05 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    459.840 ns |  0.9458 ns |  0.8847 ns |  28.08 |     0.06 |
|                              LowCostLinqWithStructToArray |             50 |    267.824 ns |  0.5719 ns |  0.5349 ns |  16.36 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    217.669 ns |  0.2579 ns |  0.2286 ns |  13.29 |     0.02 |
|                                                      Take |             50 |    404.840 ns |  0.2241 ns |  0.2096 ns |  24.72 |     0.02 |
|                                               LowCostTake |             50 |    169.493 ns |  0.0287 ns |  0.0190 ns |  10.35 |     0.01 |
|                                  LowCostTakeWithoutChecks |             50 |    150.183 ns |  0.1287 ns |  0.1203 ns |   9.17 |     0.01 |
|                                     LowCostTakeWithStruct |             50 |     82.070 ns |  0.0159 ns |  0.0141 ns |   5.01 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     75.606 ns |  0.0154 ns |  0.0120 ns |   4.62 |     0.00 |
|                                            SkipTakeSingle |             50 |    306.023 ns |  0.0615 ns |  0.0514 ns |  18.69 |     0.01 |
|                                     LowCostSkipTakeSingle |             50 |    180.142 ns |  0.6660 ns |  0.6229 ns |  11.00 |     0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    157.371 ns |  0.1318 ns |  0.1233 ns |   9.61 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     88.262 ns |  0.0174 ns |  0.0163 ns |   5.39 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     67.924 ns |  0.0570 ns |  0.0534 ns |   4.15 |     0.00 |
|                                           ForeachDelegate |             50 |    253.958 ns |  0.1780 ns |  0.1665 ns |  15.51 |     0.01 |
|                                                   Foreach |             50 |    102.366 ns |  0.0086 ns |  0.0076 ns |   6.25 |     0.00 |
|                                                       For |             50 |     16.374 ns |  0.0120 ns |  0.0112 ns |   1.00 |     0.00 |
