``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |     **21.12 ns** |  **0.0068 ns** |  **0.0063 ns** |     **21.12 ns** |   **1.73** |     **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |     32.10 ns |  0.0053 ns |  0.0047 ns |     32.10 ns |   2.63 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     31.08 ns |  0.0012 ns |  0.0011 ns |     31.08 ns |   2.54 |     0.03 |
|                                  LowCostLinqWithDelegate2 |            [0] |     39.31 ns |  0.0043 ns |  0.0041 ns |     39.31 ns |   3.22 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     42.58 ns |  0.0044 ns |  0.0039 ns |     42.58 ns |   3.48 |     0.04 |
|                                LowCostLinqWithStructWhere |            [0] |     36.14 ns |  0.0038 ns |  0.0034 ns |     36.14 ns |   2.96 |     0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     33.97 ns |  0.0017 ns |  0.0015 ns |     33.97 ns |   2.78 |     0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     74.97 ns |  0.0264 ns |  0.0206 ns |     74.97 ns |   6.13 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     70.09 ns |  0.9123 ns |  0.8534 ns |     69.40 ns |   5.73 |     0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     72.46 ns |  0.0531 ns |  0.0443 ns |     72.45 ns |   5.93 |     0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     71.70 ns |  0.0445 ns |  0.0395 ns |     71.70 ns |   5.87 |     0.06 |
|                                                 LinqCount |            [0] |     24.88 ns |  0.0960 ns |  0.0898 ns |     24.92 ns |   2.04 |     0.02 |
|                              LowCostLinqWithDelegateCount |            [0] |     23.32 ns |  0.0040 ns |  0.0036 ns |     23.32 ns |   1.91 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     26.54 ns |  0.0089 ns |  0.0083 ns |     26.54 ns |   2.17 |     0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     22.75 ns |  0.0009 ns |  0.0008 ns |     22.75 ns |   1.86 |     0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     22.82 ns |  0.0462 ns |  0.0409 ns |     22.84 ns |   1.87 |     0.02 |
|                                               LinqToArray |            [0] |     21.98 ns |  0.0143 ns |  0.0134 ns |     21.98 ns |   1.80 |     0.02 |
|                            LowCostLinqWithDelegateToArray |            [0] |     35.44 ns |  0.0172 ns |  0.0161 ns |     35.44 ns |   2.90 |     0.03 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     35.30 ns |  0.3882 ns |  0.3631 ns |     35.07 ns |   2.89 |     0.04 |
|                              LowCostLinqWithStructToArray |            [0] |     32.47 ns |  0.0645 ns |  0.0604 ns |     32.49 ns |   2.66 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     32.65 ns |  0.0111 ns |  0.0104 ns |     32.65 ns |   2.67 |     0.03 |
|                                                      Take |            [0] |     25.67 ns |  0.2245 ns |  0.2100 ns |     25.54 ns |   2.10 |     0.03 |
|                                               LowCostTake |            [0] |     41.49 ns |  0.0027 ns |  0.0024 ns |     41.49 ns |   3.39 |     0.04 |
|                                  LowCostTakeWithoutChecks |            [0] |     41.30 ns |  0.0592 ns |  0.0554 ns |     41.32 ns |   3.38 |     0.04 |
|                                     LowCostTakeWithStruct |            [0] |     43.41 ns |  0.0028 ns |  0.0026 ns |     43.41 ns |   3.55 |     0.04 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     43.18 ns |  0.3409 ns |  0.3188 ns |     42.92 ns |   3.53 |     0.05 |
|                                            SkipTakeSingle |            [0] |     37.71 ns |  0.0204 ns |  0.0181 ns |     37.71 ns |   3.09 |     0.03 |
|                                     LowCostSkipTakeSingle |            [0] |     42.99 ns |  0.0104 ns |  0.0092 ns |     42.99 ns |   3.52 |     0.04 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     41.01 ns |  0.0765 ns |  0.0715 ns |     40.97 ns |   3.36 |     0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     43.00 ns |  0.0043 ns |  0.0038 ns |     43.00 ns |   3.52 |     0.04 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     43.27 ns |  0.0020 ns |  0.0016 ns |     43.27 ns |   3.54 |     0.04 |
|                                           ForeachDelegate |            [0] |     13.92 ns |  0.0030 ns |  0.0028 ns |     13.92 ns |   1.14 |     0.01 |
|                                                   Foreach |            [0] |     12.22 ns |  0.1495 ns |  0.1398 ns |     12.16 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |         **[1000]** |  **5,540.93 ns** |  **0.6197 ns** |  **0.5494 ns** |  **5,540.87 ns** |   **1.36** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  3,620.21 ns |  3.4002 ns |  3.1805 ns |  3,618.53 ns |   0.89 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  3,863.40 ns |  0.8291 ns |  0.7350 ns |  3,863.50 ns |   0.95 |     0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  3,935.81 ns | 29.8815 ns | 26.4891 ns |  3,943.96 ns |   0.97 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  3,817.31 ns |  5.5184 ns |  4.3084 ns |  3,818.24 ns |   0.94 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,876.68 ns | 37.5210 ns | 89.8980 ns |  1,895.26 ns |   0.46 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,555.96 ns | 14.4090 ns | 12.7732 ns |  1,550.35 ns |   0.38 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 10,219.14 ns | 10.6273 ns |  9.4209 ns | 10,220.30 ns |   2.51 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  9,924.45 ns | 10.6596 ns |  9.4494 ns |  9,924.02 ns |   2.44 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,220.29 ns |  3.8280 ns |  3.3934 ns |  8,219.74 ns |   2.02 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,141.87 ns | 67.3192 ns | 59.6767 ns |  8,159.50 ns |   2.00 |     0.01 |
|                                                 LinqCount |         [1000] |  1,705.42 ns |  1.0156 ns |  0.9003 ns |  1,705.25 ns |   0.42 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  2,189.28 ns |  4.2370 ns |  3.9633 ns |  2,190.96 ns |   0.54 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  2,182.88 ns |  0.1393 ns |  0.1235 ns |  2,182.87 ns |   0.54 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,342.45 ns |  4.0394 ns |  3.7784 ns |  1,340.51 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,343.29 ns |  0.0777 ns |  0.0726 ns |  1,343.30 ns |   0.33 |     0.00 |
|                                               LinqToArray |         [1000] |  2,976.16 ns |  7.6353 ns |  7.1421 ns |  2,980.18 ns |   0.73 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  3,862.45 ns |  3.5132 ns |  3.2863 ns |  3,862.40 ns |   0.95 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  4,144.09 ns |  5.8609 ns |  4.5758 ns |  4,143.98 ns |   1.02 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,235.22 ns |  5.3801 ns |  5.0325 ns |  2,231.94 ns |   0.55 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,212.13 ns |  0.7092 ns |  0.6634 ns |  2,212.19 ns |   0.54 |     0.00 |
|                                                      Take |         [1000] |    262.61 ns |  0.0730 ns |  0.0570 ns |    262.60 ns |   0.06 |     0.00 |
|                                               LowCostTake |         [1000] |    124.67 ns |  0.9849 ns |  0.9213 ns |    124.06 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    121.92 ns |  0.0307 ns |  0.0257 ns |    121.91 ns |   0.03 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     96.30 ns |  0.0478 ns |  0.0447 ns |     96.31 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     83.52 ns |  0.0032 ns |  0.0028 ns |     83.52 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    184.48 ns |  2.1222 ns |  1.9851 ns |    182.96 ns |   0.05 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    107.76 ns |  0.0637 ns |  0.0532 ns |    107.72 ns |   0.03 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    105.20 ns |  0.0517 ns |  0.0483 ns |    105.18 ns |   0.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     63.69 ns |  0.5151 ns |  0.4818 ns |     63.74 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     62.67 ns |  0.0342 ns |  0.0285 ns |     62.65 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |         [1000] |  5,600.05 ns | 12.3039 ns | 11.5090 ns |  5,606.43 ns |   1.38 |     0.00 |
|                                                   Foreach |         [1000] |  4,065.31 ns |  0.4354 ns |  0.3860 ns |  4,065.29 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **[50]** |    **318.56 ns** |  **4.4083 ns** |  **4.1235 ns** |    **317.45 ns** |   **1.43** |     **0.02** |
|                                   LowCostLinqWithDelegate |           [50] |    216.49 ns |  0.0148 ns |  0.0139 ns |    216.49 ns |   0.97 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    229.04 ns |  0.4055 ns |  0.3793 ns |    229.17 ns |   1.03 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    234.26 ns |  2.6293 ns |  2.4594 ns |    232.71 ns |   1.05 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    232.87 ns |  0.0346 ns |  0.0324 ns |    232.86 ns |   1.04 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    138.35 ns |  1.4579 ns |  1.3637 ns |    138.87 ns |   0.62 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    120.32 ns |  0.2051 ns |  0.1919 ns |    120.40 ns |   0.54 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    612.16 ns |  8.5484 ns |  7.9962 ns |    611.64 ns |   2.74 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    579.99 ns |  2.6920 ns |  2.5181 ns |    579.43 ns |   2.60 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    495.42 ns |  0.1133 ns |  0.0946 ns |    495.42 ns |   2.22 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    491.94 ns |  0.9542 ns |  0.8925 ns |    492.13 ns |   2.20 |     0.00 |
|                                                 LinqCount |           [50] |    116.94 ns |  0.0924 ns |  0.0864 ns |    116.92 ns |   0.52 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    137.19 ns |  1.0395 ns |  0.9723 ns |    136.69 ns |   0.61 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    138.15 ns |  0.2262 ns |  0.2116 ns |    138.02 ns |   0.62 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |     76.90 ns |  0.0067 ns |  0.0059 ns |     76.90 ns |   0.34 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     78.01 ns |  0.1563 ns |  0.1462 ns |     77.92 ns |   0.35 |     0.00 |
|                                               LinqToArray |           [50] |    356.72 ns |  4.3355 ns |  4.0555 ns |    354.27 ns |   1.60 |     0.02 |
|                            LowCostLinqWithDelegateToArray |           [50] |    299.05 ns |  0.2568 ns |  0.2005 ns |    299.10 ns |   1.34 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    314.16 ns |  0.0822 ns |  0.0686 ns |    314.15 ns |   1.41 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    202.89 ns |  2.9784 ns |  2.7860 ns |    201.63 ns |   0.91 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    205.10 ns |  0.0984 ns |  0.0873 ns |    205.07 ns |   0.92 |     0.00 |
|                                                      Take |           [50] |    262.50 ns |  0.0765 ns |  0.0597 ns |    262.50 ns |   1.18 |     0.00 |
|                                               LowCostTake |           [50] |    123.91 ns |  0.0056 ns |  0.0044 ns |    123.91 ns |   0.55 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    123.70 ns |  1.4957 ns |  1.3991 ns |    123.30 ns |   0.55 |     0.01 |
|                                     LowCostTakeWithStruct |           [50] |     96.12 ns |  0.0142 ns |  0.0126 ns |     96.12 ns |   0.43 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     83.88 ns |  0.0116 ns |  0.0103 ns |     83.88 ns |   0.38 |     0.00 |
|                                            SkipTakeSingle |           [50] |    182.63 ns |  0.4902 ns |  0.4585 ns |    182.64 ns |   0.82 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    104.76 ns |  0.2621 ns |  0.2047 ns |    104.70 ns |   0.47 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    116.71 ns |  0.0046 ns |  0.0041 ns |    116.71 ns |   0.52 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     65.19 ns |  0.1544 ns |  0.1444 ns |     65.19 ns |   0.29 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     64.29 ns |  0.0478 ns |  0.0447 ns |     64.28 ns |   0.29 |     0.00 |
|                                           ForeachDelegate |           [50] |    302.92 ns |  0.6599 ns |  0.6173 ns |    302.58 ns |   1.36 |     0.00 |
|                                                   Foreach |           [50] |    223.31 ns |  0.0501 ns |  0.0444 ns |    223.32 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |            **[5]** |     **57.43 ns** |  **0.0319 ns** |  **0.0298 ns** |     **57.43 ns** |   **1.80** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     50.51 ns |  0.0152 ns |  0.0119 ns |     50.51 ns |   1.58 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     50.07 ns |  0.1002 ns |  0.0937 ns |     50.09 ns |   1.57 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     58.26 ns |  0.0149 ns |  0.0139 ns |     58.26 ns |   1.83 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     62.54 ns |  0.7088 ns |  0.6630 ns |     62.45 ns |   1.96 |     0.02 |
|                                LowCostLinqWithStructWhere |            [5] |     56.47 ns |  0.0257 ns |  0.0241 ns |     56.49 ns |   1.77 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     44.31 ns |  0.0499 ns |  0.0417 ns |     44.32 ns |   1.39 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    132.99 ns |  2.0193 ns |  1.8889 ns |    131.97 ns |   4.17 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    121.59 ns |  0.0674 ns |  0.0631 ns |    121.58 ns |   3.81 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    119.28 ns |  0.1430 ns |  0.1338 ns |    119.29 ns |   3.74 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    115.03 ns |  0.2537 ns |  0.2373 ns |    115.09 ns |   3.60 |     0.01 |
|                                                 LinqCount |            [5] |     39.11 ns |  0.4620 ns |  0.4321 ns |     39.21 ns |   1.23 |     0.01 |
|                              LowCostLinqWithDelegateCount |            [5] |     35.12 ns |  0.0209 ns |  0.0185 ns |     35.12 ns |   1.10 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     36.22 ns |  0.0093 ns |  0.0087 ns |     36.22 ns |   1.13 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     25.81 ns |  0.0578 ns |  0.0541 ns |     25.84 ns |   0.81 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     25.71 ns |  0.0223 ns |  0.0209 ns |     25.70 ns |   0.81 |     0.00 |
|                                               LinqToArray |            [5] |    100.00 ns |  0.0245 ns |  0.0217 ns |    100.00 ns |   3.13 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |     78.05 ns |  0.0251 ns |  0.0222 ns |     78.05 ns |   2.45 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     81.72 ns |  1.1555 ns |  1.0808 ns |     81.09 ns |   2.56 |     0.03 |
|                              LowCostLinqWithStructToArray |            [5] |     66.19 ns |  0.3579 ns |  0.2988 ns |     66.07 ns |   2.07 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     69.45 ns |  0.0294 ns |  0.0246 ns |     69.45 ns |   2.18 |     0.00 |
|                                                      Take |            [5] |    113.12 ns |  1.5028 ns |  1.4057 ns |    112.20 ns |   3.54 |     0.04 |
|                                               LowCostTake |            [5] |     60.44 ns |  0.1633 ns |  0.1527 ns |     60.44 ns |   1.89 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     61.71 ns |  0.0098 ns |  0.0091 ns |     61.71 ns |   1.93 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     54.99 ns |  0.0054 ns |  0.0045 ns |     54.99 ns |   1.72 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     54.84 ns |  0.4167 ns |  0.3898 ns |     54.55 ns |   1.72 |     0.01 |
|                                            SkipTakeSingle |            [5] |    108.92 ns |  0.2233 ns |  0.2089 ns |    109.00 ns |   3.41 |     0.01 |
|                                     LowCostSkipTakeSingle |            [5] |     52.03 ns |  0.0022 ns |  0.0021 ns |     52.03 ns |   1.63 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     58.28 ns |  0.5156 ns |  0.4823 ns |     57.99 ns |   1.83 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     47.09 ns |  0.0206 ns |  0.0182 ns |     47.08 ns |   1.48 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.74 ns |  0.0973 ns |  0.0862 ns |     46.77 ns |   1.46 |     0.00 |
|                                           ForeachDelegate |            [5] |     43.65 ns |  0.4866 ns |  0.4551 ns |     43.45 ns |   1.37 |     0.01 |
|                                                   Foreach |            [5] |     31.92 ns |  0.0221 ns |  0.0207 ns |     31.91 ns |   1.00 |     0.00 |
