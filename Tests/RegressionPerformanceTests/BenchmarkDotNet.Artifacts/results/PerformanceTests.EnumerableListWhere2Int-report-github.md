``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **63.10 ns** |  **0.0130 ns** |  **0.0108 ns** |     **63.10 ns** |   **3.74** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     37.69 ns |  0.0058 ns |  0.0048 ns |     37.68 ns |   2.23 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     31.68 ns |  0.0070 ns |  0.0062 ns |     31.68 ns |   1.88 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     51.78 ns |  0.0335 ns |  0.0313 ns |     51.77 ns |   3.07 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     48.00 ns |  0.0020 ns |  0.0017 ns |     48.00 ns |   2.84 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     42.96 ns |  0.0176 ns |  0.0165 ns |     42.96 ns |   2.54 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     41.77 ns |  0.0151 ns |  0.0141 ns |     41.78 ns |   2.47 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     91.34 ns |  0.1459 ns |  0.1365 ns |     91.41 ns |   5.41 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     84.64 ns |  0.0313 ns |  0.0293 ns |     84.63 ns |   5.01 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     79.54 ns |  0.0728 ns |  0.0681 ns |     79.56 ns |   4.71 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     70.09 ns |  0.0443 ns |  0.0415 ns |     70.09 ns |   4.15 |     0.01 |
|                                                 LinqCount |              0 |     61.33 ns |  0.0920 ns |  0.0861 ns |     61.38 ns |   3.63 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     35.93 ns |  0.0138 ns |  0.0123 ns |     35.93 ns |   2.13 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     34.84 ns |  0.0141 ns |  0.0132 ns |     34.84 ns |   2.06 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     37.27 ns |  0.0055 ns |  0.0048 ns |     37.27 ns |   2.21 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     29.84 ns |  0.0014 ns |  0.0012 ns |     29.84 ns |   1.77 |     0.00 |
|                                               LinqToArray |              0 |     73.21 ns |  0.2042 ns |  0.1910 ns |     73.25 ns |   4.33 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |     46.56 ns |  0.0640 ns |  0.0599 ns |     46.54 ns |   2.76 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     45.30 ns |  0.0131 ns |  0.0095 ns |     45.30 ns |   2.68 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     45.78 ns |  0.0152 ns |  0.0142 ns |     45.78 ns |   2.71 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     38.97 ns |  0.0337 ns |  0.0315 ns |     38.97 ns |   2.31 |     0.00 |
|                                                      Take |              0 |     99.59 ns |  0.0347 ns |  0.0308 ns |     99.58 ns |   5.90 |     0.01 |
|                                               LowCostTake |              0 |     42.80 ns |  0.0117 ns |  0.0091 ns |     42.79 ns |   2.53 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     39.39 ns |  0.0047 ns |  0.0044 ns |     39.39 ns |   2.33 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     48.98 ns |  0.0129 ns |  0.0120 ns |     48.98 ns |   2.90 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     45.60 ns |  0.0064 ns |  0.0060 ns |     45.60 ns |   2.70 |     0.00 |
|                                            SkipTakeSingle |              0 |    121.96 ns |  0.2344 ns |  0.2078 ns |    121.94 ns |   7.22 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     51.36 ns |  0.0032 ns |  0.0030 ns |     51.35 ns |   3.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     48.99 ns |  0.0211 ns |  0.0177 ns |     48.99 ns |   2.90 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     69.79 ns |  0.0064 ns |  0.0060 ns |     69.79 ns |   4.13 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     51.62 ns |  0.0156 ns |  0.0130 ns |     51.63 ns |   3.06 |     0.00 |
|                                           ForeachDelegate |              0 |     19.41 ns |  0.0353 ns |  0.0330 ns |     19.42 ns |   1.15 |     0.00 |
|                                                   Foreach |              0 |     16.89 ns |  0.0214 ns |  0.0200 ns |     16.89 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **1000** |  **9,742.62 ns** | **13.1953 ns** | **12.3429 ns** |  **9,741.87 ns** |   **1.77** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  7,002.09 ns | 66.0250 ns | 58.5295 ns |  6,999.91 ns |   1.27 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  5,091.07 ns | 15.5569 ns | 14.5519 ns |  5,090.36 ns |   0.92 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  7,198.90 ns |  6.5845 ns |  6.1592 ns |  7,199.24 ns |   1.30 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  6,271.40 ns |  3.0423 ns |  2.5404 ns |  6,271.54 ns |   1.14 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  2,681.79 ns |  3.0170 ns |  2.6745 ns |  2,681.22 ns |   0.49 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,749.22 ns |  0.7845 ns |  0.7338 ns |  1,749.48 ns |   0.32 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 18,993.11 ns | 12.1609 ns | 10.7803 ns | 18,991.53 ns |   3.44 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 18,446.99 ns | 82.4974 ns | 77.1681 ns | 18,474.25 ns |   3.34 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  9,194.43 ns |  4.1399 ns |  3.6699 ns |  9,193.88 ns |   1.67 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,985.64 ns |  5.5387 ns |  5.1809 ns |  7,986.92 ns |   1.45 |     0.00 |
|                                                 LinqCount |           1000 |  3,908.02 ns |  7.3788 ns |  6.9021 ns |  3,907.09 ns |   0.71 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  5,308.74 ns |  3.7952 ns |  3.5501 ns |  5,311.11 ns |   0.96 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  4,948.12 ns |  9.6595 ns |  8.5629 ns |  4,951.99 ns |   0.90 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,737.85 ns |  1.2678 ns |  1.1239 ns |  1,738.02 ns |   0.31 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,219.42 ns |  0.3260 ns |  0.3049 ns |  1,219.52 ns |   0.22 |     0.00 |
|                                               LinqToArray |           1000 |  5,895.57 ns |  5.4916 ns |  5.1368 ns |  5,895.55 ns |   1.07 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  7,890.33 ns |  8.7223 ns |  8.1588 ns |  7,891.47 ns |   1.43 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  5,602.39 ns |  6.8749 ns |  6.4308 ns |  5,601.43 ns |   1.02 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  3,231.24 ns |  6.5618 ns |  6.1379 ns |  3,229.77 ns |   0.59 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,364.58 ns |  2.7431 ns |  2.1416 ns |  2,363.92 ns |   0.43 |     0.00 |
|                                                      Take |           1000 |    396.12 ns |  0.2707 ns |  0.2532 ns |    396.07 ns |   0.07 |     0.00 |
|                                               LowCostTake |           1000 |    189.13 ns |  0.0265 ns |  0.0235 ns |    189.13 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    156.34 ns |  0.0175 ns |  0.0137 ns |    156.34 ns |   0.03 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    121.45 ns |  0.0247 ns |  0.0231 ns |    121.44 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     89.04 ns |  0.0196 ns |  0.0130 ns |     89.04 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    300.71 ns |  0.0891 ns |  0.0834 ns |    300.72 ns |   0.05 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    181.32 ns |  0.0531 ns |  0.0497 ns |    181.29 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    172.36 ns |  0.1329 ns |  0.1243 ns |    172.29 ns |   0.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    111.69 ns |  0.0448 ns |  0.0397 ns |    111.68 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     74.17 ns |  0.4047 ns |  0.3785 ns |     74.49 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |           1000 |  8,511.76 ns | 25.3948 ns | 19.8266 ns |  8,508.11 ns |   1.54 |     0.00 |
|                                                   Foreach |           1000 |  5,517.92 ns |  2.6766 ns |  2.3727 ns |  5,516.57 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |              **5** |    **113.18 ns** |  **0.0708 ns** |  **0.0627 ns** |    **113.18 ns** |   **2.57** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     69.87 ns |  0.0714 ns |  0.0633 ns |     69.84 ns |   1.59 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     53.29 ns |  0.0241 ns |  0.0226 ns |     53.28 ns |   1.21 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |     79.59 ns |  0.0407 ns |  0.0340 ns |     79.58 ns |   1.81 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     73.29 ns |  0.0855 ns |  0.0800 ns |     73.30 ns |   1.66 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     57.74 ns |  0.0481 ns |  0.0450 ns |     57.75 ns |   1.31 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     49.22 ns |  0.0107 ns |  0.0090 ns |     49.22 ns |   1.12 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    198.97 ns |  0.1739 ns |  0.1627 ns |    198.93 ns |   4.52 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    192.09 ns |  0.2086 ns |  0.1951 ns |    192.11 ns |   4.36 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    124.79 ns |  0.0638 ns |  0.0533 ns |    124.78 ns |   2.83 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    115.72 ns |  3.5349 ns |  3.6300 ns |    113.90 ns |   2.63 |     0.08 |
|                                                 LinqCount |              5 |     81.87 ns |  0.0227 ns |  0.0190 ns |     81.87 ns |   1.86 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     62.77 ns |  0.0435 ns |  0.0407 ns |     62.76 ns |   1.42 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     58.20 ns |  0.0634 ns |  0.0593 ns |     58.22 ns |   1.32 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     45.88 ns |  0.0189 ns |  0.0176 ns |     45.87 ns |   1.04 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     33.15 ns |  0.0353 ns |  0.0330 ns |     33.16 ns |   0.75 |     0.00 |
|                                               LinqToArray |              5 |    143.13 ns |  0.2226 ns |  0.2083 ns |    143.06 ns |   3.25 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              5 |    113.79 ns |  0.0393 ns |  0.0328 ns |    113.79 ns |   2.58 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    105.00 ns |  0.0510 ns |  0.0452 ns |    105.00 ns |   2.38 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     91.27 ns |  0.1216 ns |  0.1078 ns |     91.25 ns |   2.07 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     78.24 ns |  0.0234 ns |  0.0196 ns |     78.24 ns |   1.78 |     0.00 |
|                                                      Take |              5 |    173.38 ns |  0.0760 ns |  0.0711 ns |    173.36 ns |   3.93 |     0.00 |
|                                               LowCostTake |              5 |     74.09 ns |  0.0146 ns |  0.0122 ns |     74.08 ns |   1.68 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     65.28 ns |  0.0635 ns |  0.0594 ns |     65.29 ns |   1.48 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     64.50 ns |  0.0312 ns |  0.0292 ns |     64.49 ns |   1.46 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     61.34 ns |  0.0061 ns |  0.0057 ns |     61.34 ns |   1.39 |     0.00 |
|                                            SkipTakeSingle |              5 |    166.39 ns |  0.1090 ns |  0.0911 ns |    166.35 ns |   3.78 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     77.05 ns |  0.0973 ns |  0.0910 ns |     77.07 ns |   1.75 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     69.38 ns |  0.0430 ns |  0.0381 ns |     69.36 ns |   1.57 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     68.49 ns |  0.0338 ns |  0.0282 ns |     68.48 ns |   1.55 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     55.40 ns |  0.0189 ns |  0.0168 ns |     55.39 ns |   1.26 |     0.00 |
|                                           ForeachDelegate |              5 |     61.50 ns |  0.0173 ns |  0.0153 ns |     61.50 ns |   1.40 |     0.00 |
|                                                   Foreach |              5 |     44.06 ns |  0.0251 ns |  0.0235 ns |     44.06 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |             **50** |    **553.55 ns** |  **0.1954 ns** |  **0.1828 ns** |    **553.48 ns** |   **1.84** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    408.88 ns |  0.1416 ns |  0.1182 ns |    408.87 ns |   1.36 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    284.78 ns |  0.0307 ns |  0.0287 ns |    284.78 ns |   0.94 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    396.44 ns |  0.0312 ns |  0.0261 ns |    396.44 ns |   1.31 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    357.79 ns |  0.0438 ns |  0.0389 ns |    357.78 ns |   1.19 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    179.56 ns |  0.0465 ns |  0.0388 ns |    179.57 ns |   0.60 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    132.54 ns |  0.0277 ns |  0.0245 ns |    132.54 ns |   0.44 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,049.13 ns |  0.6945 ns |  0.6496 ns |  1,049.30 ns |   3.48 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,023.44 ns |  0.7899 ns |  0.7002 ns |  1,023.16 ns |   3.39 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    546.97 ns |  0.3315 ns |  0.2588 ns |    546.98 ns |   1.81 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    477.34 ns |  0.1482 ns |  0.1313 ns |    477.33 ns |   1.58 |     0.00 |
|                                                 LinqCount |             50 |    259.48 ns |  0.1621 ns |  0.1437 ns |    259.52 ns |   0.86 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    306.20 ns |  0.0886 ns |  0.0829 ns |    306.21 ns |   1.02 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    279.64 ns |  0.2121 ns |  0.1656 ns |    279.59 ns |   0.93 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    131.16 ns |  0.0280 ns |  0.0262 ns |    131.15 ns |   0.44 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     82.71 ns |  0.0447 ns |  0.0418 ns |     82.73 ns |   0.27 |     0.00 |
|                                               LinqToArray |             50 |    551.23 ns |  0.2264 ns |  0.2007 ns |    551.21 ns |   1.83 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    525.92 ns |  0.4646 ns |  0.3879 ns |    525.94 ns |   1.74 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    433.85 ns |  1.0540 ns |  0.9859 ns |    433.69 ns |   1.44 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    286.48 ns |  0.4405 ns |  0.4120 ns |    286.61 ns |   0.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    238.10 ns |  0.1215 ns |  0.1077 ns |    238.08 ns |   0.79 |     0.00 |
|                                                      Take |             50 |    396.36 ns |  0.4041 ns |  0.3780 ns |    396.53 ns |   1.31 |     0.00 |
|                                               LowCostTake |             50 |    194.06 ns |  0.0343 ns |  0.0304 ns |    194.06 ns |   0.64 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    158.49 ns |  0.0618 ns |  0.0579 ns |    158.50 ns |   0.53 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    114.31 ns |  0.0128 ns |  0.0120 ns |    114.30 ns |   0.38 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     97.65 ns |  0.0777 ns |  0.0727 ns |     97.67 ns |   0.32 |     0.00 |
|                                            SkipTakeSingle |             50 |    300.59 ns |  0.0872 ns |  0.0816 ns |    300.57 ns |   1.00 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    181.00 ns |  0.0869 ns |  0.0813 ns |    181.04 ns |   0.60 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    172.43 ns |  0.0155 ns |  0.0121 ns |    172.43 ns |   0.57 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    100.32 ns |  0.0849 ns |  0.0795 ns |    100.34 ns |   0.33 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     75.17 ns |  0.0433 ns |  0.0338 ns |     75.17 ns |   0.25 |     0.00 |
|                                           ForeachDelegate |             50 |    446.78 ns |  0.7608 ns |  0.7117 ns |    446.93 ns |   1.48 |     0.00 |
|                                                   Foreach |             50 |    301.49 ns |  0.0545 ns |  0.0483 ns |    301.49 ns |   1.00 |     0.00 |
