``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914063 Hz, Resolution=255.4890 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **81.46 ns** |  **0.0365 ns** |  **0.0342 ns** |   **6.33** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     36.45 ns |  0.0175 ns |  0.0164 ns |   2.83 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     37.86 ns |  0.0044 ns |  0.0037 ns |   2.94 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     67.90 ns |  0.0257 ns |  0.0228 ns |   5.28 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     59.77 ns |  0.0057 ns |  0.0051 ns |   4.65 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     48.25 ns |  0.0483 ns |  0.0452 ns |   3.75 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     59.54 ns |  0.0030 ns |  0.0025 ns |   4.63 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     98.79 ns |  0.0975 ns |  0.0912 ns |   7.68 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     97.52 ns |  0.0811 ns |  0.0759 ns |   7.58 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     83.98 ns |  0.0792 ns |  0.0740 ns |   6.53 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     80.51 ns |  0.0571 ns |  0.0534 ns |   6.26 |     0.00 |
|                                                 LinqCount |              0 |     81.83 ns |  0.0298 ns |  0.0264 ns |   6.36 |     0.00 |
|                              LowCostLinqWithDelegateCount |              0 |     36.34 ns |  0.0418 ns |  0.0391 ns |   2.82 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     38.65 ns |  0.0043 ns |  0.0038 ns |   3.00 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     37.78 ns |  0.0176 ns |  0.0165 ns |   2.94 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     45.39 ns |  0.0026 ns |  0.0023 ns |   3.53 |     0.00 |
|                                               LinqToArray |              0 |     97.33 ns |  0.0687 ns |  0.0537 ns |   7.57 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              0 |     48.07 ns |  0.0300 ns |  0.0266 ns |   3.74 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     47.10 ns |  0.0375 ns |  0.0351 ns |   3.66 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     47.77 ns |  0.0524 ns |  0.0464 ns |   3.71 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     47.27 ns |  0.0635 ns |  0.0594 ns |   3.67 |     0.00 |
|                                                      Take |              0 |    118.45 ns |  0.0547 ns |  0.0511 ns |   9.21 |     0.01 |
|                                               LowCostTake |              0 |     44.06 ns |  0.0079 ns |  0.0066 ns |   3.43 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     44.92 ns |  0.0046 ns |  0.0043 ns |   3.49 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     53.95 ns |  0.0043 ns |  0.0038 ns |   4.19 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     61.77 ns |  0.0091 ns |  0.0085 ns |   4.80 |     0.00 |
|                                            SkipTakeSingle |              0 |    141.25 ns |  0.0505 ns |  0.0394 ns |  10.98 |     0.01 |
|                                     LowCostSkipTakeSingle |              0 |     55.20 ns |  0.0412 ns |  0.0322 ns |   4.29 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     56.11 ns |  0.0057 ns |  0.0051 ns |   4.36 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     59.43 ns |  0.0048 ns |  0.0043 ns |   4.62 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     59.20 ns |  0.0154 ns |  0.0144 ns |   4.60 |     0.00 |
|                                           ForeachDelegate |              0 |     16.39 ns |  0.0077 ns |  0.0068 ns |   1.27 |     0.00 |
|                                                   Foreach |              0 |     12.86 ns |  0.0058 ns |  0.0054 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **10,409.59 ns** |  **5.7786 ns** |  **5.4053 ns** |   **2.41** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  8,029.18 ns | 13.1815 ns | 11.6850 ns |   1.86 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  9,042.85 ns | 14.1285 ns | 12.5245 ns |   2.09 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  9,696.94 ns | 65.4378 ns | 61.2105 ns |   2.25 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  8,580.06 ns | 41.0819 ns | 38.4280 ns |   1.99 |     0.01 |
|                                LowCostLinqWithStructWhere |           1000 |  1,735.01 ns |  0.9567 ns |  0.8949 ns |   0.40 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,566.09 ns |  0.9473 ns |  0.8397 ns |   0.36 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 21,421.75 ns | 85.3525 ns | 79.8388 ns |   4.96 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 20,184.66 ns | 27.6031 ns | 25.8199 ns |   4.68 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  8,566.12 ns | 31.7692 ns | 29.7169 ns |   1.98 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  8,104.46 ns | 21.7780 ns | 19.3056 ns |   1.88 |     0.00 |
|                                                 LinqCount |           1000 |  6,563.86 ns |  3.7013 ns |  3.4622 ns |   1.52 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  8,422.28 ns |  8.3336 ns |  7.7952 ns |   1.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  7,616.38 ns |  3.6278 ns |  3.2159 ns |   1.76 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,376.13 ns |  2.0648 ns |  1.8304 ns |   0.32 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,360.34 ns |  1.0114 ns |  0.9460 ns |   0.32 |     0.00 |
|                                               LinqToArray |           1000 |  7,725.27 ns | 16.4307 ns | 15.3693 ns |   1.79 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  8,768.18 ns | 12.7400 ns | 11.9170 ns |   2.03 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  9,935.33 ns |  7.9080 ns |  7.3971 ns |   2.30 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,270.10 ns |  5.9048 ns |  5.5233 ns |   0.53 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,263.61 ns |  5.9250 ns |  5.5422 ns |   0.52 |     0.00 |
|                                                      Take |           1000 |    426.29 ns |  0.4146 ns |  0.3675 ns |   0.10 |     0.00 |
|                                               LowCostTake |           1000 |    236.63 ns |  0.1621 ns |  0.1516 ns |   0.05 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    208.86 ns |  0.0761 ns |  0.0712 ns |   0.05 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    107.15 ns |  0.1468 ns |  0.1373 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     96.67 ns |  0.0050 ns |  0.0044 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    348.64 ns |  0.3743 ns |  0.3501 ns |   0.08 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    250.53 ns |  0.0149 ns |  0.0139 ns |   0.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    240.26 ns |  0.5238 ns |  0.4900 ns |   0.06 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     87.54 ns |  0.0101 ns |  0.0095 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     86.62 ns |  0.2135 ns |  0.1997 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  8,382.27 ns |  2.3074 ns |  2.1583 ns |   1.94 |     0.00 |
|                                                   Foreach |           1000 |  4,316.89 ns |  2.3458 ns |  1.9589 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **139.32 ns** |  **0.0577 ns** |  **0.0540 ns** |   **4.03** |     **0.00** |
|                                   LowCostLinqWithDelegate |              5 |     76.17 ns |  0.0858 ns |  0.0803 ns |   2.20 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     75.94 ns |  0.1799 ns |  0.1682 ns |   2.20 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    105.50 ns |  0.0835 ns |  0.0781 ns |   3.05 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     95.04 ns |  0.0402 ns |  0.0356 ns |   2.75 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     58.47 ns |  0.0593 ns |  0.0555 ns |   1.69 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     56.38 ns |  0.0404 ns |  0.0378 ns |   1.63 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    217.23 ns |  0.0740 ns |  0.0618 ns |   6.28 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    206.10 ns |  0.2091 ns |  0.1956 ns |   5.96 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    125.77 ns |  0.0727 ns |  0.0645 ns |   3.64 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    123.70 ns |  0.0630 ns |  0.0558 ns |   3.58 |     0.00 |
|                                                 LinqCount |              5 |    119.32 ns |  0.0518 ns |  0.0485 ns |   3.45 |     0.00 |
|                              LowCostLinqWithDelegateCount |              5 |     75.93 ns |  0.0255 ns |  0.0213 ns |   2.20 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     70.94 ns |  0.0607 ns |  0.0568 ns |   2.05 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     41.51 ns |  0.0546 ns |  0.0510 ns |   1.20 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     41.74 ns |  0.0167 ns |  0.0140 ns |   1.21 |     0.00 |
|                                               LinqToArray |              5 |    176.21 ns |  0.2813 ns |  0.2632 ns |   5.10 |     0.01 |
|                            LowCostLinqWithDelegateToArray |              5 |    121.99 ns |  0.0451 ns |  0.0400 ns |   3.53 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    124.60 ns |  0.0837 ns |  0.0783 ns |   3.60 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |     87.05 ns |  0.0613 ns |  0.0573 ns |   2.52 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     87.15 ns |  0.1088 ns |  0.1017 ns |   2.52 |     0.00 |
|                                                      Take |              5 |    210.51 ns |  0.1253 ns |  0.1172 ns |   6.09 |     0.00 |
|                                               LowCostTake |              5 |     85.58 ns |  0.0514 ns |  0.0456 ns |   2.48 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |     80.58 ns |  0.0412 ns |  0.0385 ns |   2.33 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |     68.29 ns |  0.0297 ns |  0.0278 ns |   1.98 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     66.01 ns |  0.0282 ns |  0.0264 ns |   1.91 |     0.00 |
|                                            SkipTakeSingle |              5 |    192.35 ns |  0.0938 ns |  0.0831 ns |   5.56 |     0.00 |
|                                     LowCostSkipTakeSingle |              5 |     92.44 ns |  0.0314 ns |  0.0278 ns |   2.67 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    109.90 ns |  0.0328 ns |  0.0256 ns |   3.18 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     64.22 ns |  0.0071 ns |  0.0063 ns |   1.86 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     64.93 ns |  0.0173 ns |  0.0162 ns |   1.88 |     0.00 |
|                                           ForeachDelegate |              5 |     59.54 ns |  0.0115 ns |  0.0102 ns |   1.72 |     0.00 |
|                                                   Foreach |              5 |     34.57 ns |  0.0097 ns |  0.0086 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |    **609.43 ns** |  **0.3367 ns** |  **0.3149 ns** |   **2.58** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    433.60 ns |  0.1212 ns |  0.1074 ns |   1.84 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    499.68 ns |  0.2000 ns |  0.1871 ns |   2.12 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    545.27 ns |  0.1717 ns |  0.1522 ns |   2.31 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    484.62 ns |  0.1246 ns |  0.1165 ns |   2.05 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    139.21 ns |  0.0206 ns |  0.0192 ns |   0.59 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    132.23 ns |  0.0064 ns |  0.0057 ns |   0.56 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,203.58 ns |  0.7181 ns |  0.6366 ns |   5.10 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,095.73 ns |  0.6103 ns |  0.5708 ns |   4.64 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    518.19 ns |  5.2725 ns |  4.9319 ns |   2.20 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    485.04 ns |  0.1523 ns |  0.1351 ns |   2.05 |     0.00 |
|                                                 LinqCount |             50 |    414.84 ns |  0.3885 ns |  0.3634 ns |   1.76 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    454.49 ns |  0.0159 ns |  0.0149 ns |   1.93 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    408.18 ns |  0.0270 ns |  0.0240 ns |   1.73 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |     97.59 ns |  1.9770 ns |  2.3535 ns |   0.41 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    101.26 ns |  1.5836 ns |  1.4813 ns |   0.43 |     0.01 |
|                                               LinqToArray |             50 |    689.60 ns |  0.4326 ns |  0.3612 ns |   2.92 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    576.70 ns |  0.5598 ns |  0.4963 ns |   2.44 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    641.39 ns |  0.6097 ns |  0.5703 ns |   2.72 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    233.76 ns |  0.3090 ns |  0.2739 ns |   0.99 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    234.07 ns |  0.2415 ns |  0.2259 ns |   0.99 |     0.00 |
|                                                      Take |             50 |    426.05 ns |  0.2524 ns |  0.2238 ns |   1.80 |     0.00 |
|                                               LowCostTake |             50 |    239.05 ns |  0.1008 ns |  0.0894 ns |   1.01 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    208.35 ns |  0.0393 ns |  0.0367 ns |   0.88 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    107.91 ns |  0.0307 ns |  0.0287 ns |   0.46 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     94.32 ns |  0.0086 ns |  0.0067 ns |   0.40 |     0.00 |
|                                            SkipTakeSingle |             50 |    348.82 ns |  0.1992 ns |  0.1555 ns |   1.48 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    250.57 ns |  0.0485 ns |  0.0453 ns |   1.06 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    238.29 ns |  0.1919 ns |  0.1701 ns |   1.01 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     87.88 ns |  0.0185 ns |  0.0154 ns |   0.37 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     84.89 ns |  0.0460 ns |  0.0431 ns |   0.36 |     0.00 |
|                                           ForeachDelegate |             50 |    442.32 ns |  0.2852 ns |  0.2668 ns |   1.87 |     0.00 |
|                                                   Foreach |             50 |    236.05 ns |  0.0294 ns |  0.0275 ns |   1.00 |     0.00 |
