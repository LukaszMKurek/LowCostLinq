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
|                                                      **Linq** |            **[0]** |     **58.06 ns** |  **0.0094 ns** |  **0.0078 ns** |     **58.06 ns** |   **3.92** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     37.44 ns |  0.0083 ns |  0.0070 ns |     37.44 ns |   2.53 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     29.93 ns |  0.0028 ns |  0.0026 ns |     29.93 ns |   2.02 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     52.04 ns |  0.4645 ns |  0.4345 ns |     51.79 ns |   3.52 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     47.96 ns |  0.0051 ns |  0.0045 ns |     47.96 ns |   3.24 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     45.20 ns |  0.0140 ns |  0.0117 ns |     45.20 ns |   3.05 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     38.50 ns |  0.0057 ns |  0.0053 ns |     38.49 ns |   2.60 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     96.68 ns |  1.3834 ns |  1.2941 ns |     95.89 ns |   6.53 |     0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     88.47 ns |  0.0740 ns |  0.0656 ns |     88.49 ns |   5.98 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     82.15 ns |  0.0484 ns |  0.0453 ns |     82.16 ns |   5.55 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     71.53 ns |  0.0142 ns |  0.0133 ns |     71.53 ns |   4.83 |     0.00 |
|                                                 LinqCount |            [0] |     57.27 ns |  0.0377 ns |  0.0352 ns |     57.25 ns |   3.87 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     36.63 ns |  0.0272 ns |  0.0241 ns |     36.63 ns |   2.48 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     33.62 ns |  0.0079 ns |  0.0074 ns |     33.62 ns |   2.27 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     37.22 ns |  0.0764 ns |  0.0715 ns |     37.18 ns |   2.52 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     29.15 ns |  0.0013 ns |  0.0012 ns |     29.15 ns |   1.97 |     0.00 |
|                                               LinqToArray |            [0] |     73.37 ns |  0.1641 ns |  0.1535 ns |     73.30 ns |   4.96 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [0] |     46.12 ns |  0.0307 ns |  0.0272 ns |     46.12 ns |   3.12 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     44.12 ns |  0.7250 ns |  0.6782 ns |     43.69 ns |   2.98 |     0.04 |
|                              LowCostLinqWithStructToArray |            [0] |     45.83 ns |  0.0067 ns |  0.0062 ns |     45.83 ns |   3.10 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     44.03 ns |  0.0164 ns |  0.0137 ns |     44.03 ns |   2.98 |     0.00 |
|                                                      Take |            [0] |     94.49 ns |  1.5307 ns |  1.4318 ns |     93.51 ns |   6.39 |     0.09 |
|                                               LowCostTake |            [0] |     43.83 ns |  0.0516 ns |  0.0482 ns |     43.84 ns |   2.96 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     39.47 ns |  0.0052 ns |  0.0048 ns |     39.47 ns |   2.67 |     0.00 |
|                                     LowCostTakeWithStruct |            [0] |     50.50 ns |  0.0155 ns |  0.0121 ns |     50.50 ns |   3.41 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     47.20 ns |  0.0067 ns |  0.0062 ns |     47.20 ns |   3.19 |     0.00 |
|                                            SkipTakeSingle |            [0] |    119.96 ns |  0.3270 ns |  0.2899 ns |    120.09 ns |   8.11 |     0.02 |
|                                     LowCostSkipTakeSingle |            [0] |     50.54 ns |  0.0158 ns |  0.0140 ns |     50.54 ns |   3.41 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     48.96 ns |  0.0036 ns |  0.0032 ns |     48.95 ns |   3.31 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     59.46 ns |  0.1500 ns |  0.1403 ns |     59.53 ns |   4.02 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     51.22 ns |  0.0024 ns |  0.0022 ns |     51.22 ns |   3.46 |     0.00 |
|                                           ForeachDelegate |            [0] |     19.57 ns |  0.2984 ns |  0.2791 ns |     19.34 ns |   1.32 |     0.02 |
|                                                   Foreach |            [0] |     14.80 ns |  0.0049 ns |  0.0043 ns |     14.80 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |         **[1000]** |  **8,765.09 ns** | **21.4136 ns** | **20.0303 ns** |  **8,769.53 ns** |   **1.67** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  6,735.15 ns |  2.8616 ns |  2.6767 ns |  6,734.72 ns |   1.28 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  6,140.10 ns | 30.2911 ns | 28.3343 ns |  6,133.70 ns |   1.17 |     0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  6,781.17 ns | 39.6443 ns | 37.0833 ns |  6,765.56 ns |   1.29 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  6,765.58 ns | 11.3629 ns | 10.6289 ns |  6,768.59 ns |   1.29 |     0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,707.97 ns | 31.2609 ns | 29.2414 ns |  2,692.74 ns |   0.51 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,747.26 ns |  0.5807 ns |  0.5431 ns |  1,746.99 ns |   0.33 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 20,207.15 ns | 62.2636 ns | 58.2414 ns | 20,211.04 ns |   3.84 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 19,110.38 ns | 58.9660 ns | 46.0368 ns | 19,113.06 ns |   3.63 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,397.77 ns | 28.5316 ns | 26.6885 ns |  9,399.02 ns |   1.79 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,947.12 ns |  4.6701 ns |  4.3684 ns |  8,946.50 ns |   1.70 |     0.00 |
|                                                 LinqCount |         [1000] |  3,906.42 ns |  3.2247 ns |  3.0164 ns |  3,906.12 ns |   0.74 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  5,446.99 ns | 58.2155 ns | 54.4548 ns |  5,481.58 ns |   1.03 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,040.28 ns | 13.1833 ns | 10.2927 ns |  5,035.27 ns |   0.96 |     0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,739.26 ns |  0.9644 ns |  0.9021 ns |  1,739.91 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,220.40 ns |  0.1033 ns |  0.0916 ns |  1,220.38 ns |   0.23 |     0.00 |
|                                               LinqToArray |         [1000] |  5,014.76 ns |  7.1097 ns |  5.5508 ns |  5,014.33 ns |   0.95 |     0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  7,952.91 ns |  6.9913 ns |  6.5397 ns |  7,950.74 ns |   1.51 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  7,157.48 ns |  3.7172 ns |  3.4770 ns |  7,156.30 ns |   1.36 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,227.14 ns |  3.0661 ns |  2.7180 ns |  3,227.48 ns |   0.61 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,382.49 ns | 42.6169 ns | 39.8639 ns |  2,354.29 ns |   0.45 |     0.01 |
|                                                      Take |         [1000] |    378.64 ns |  0.1424 ns |  0.1189 ns |    378.62 ns |   0.07 |     0.00 |
|                                               LowCostTake |         [1000] |    204.12 ns |  0.0476 ns |  0.0422 ns |    204.12 ns |   0.04 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    159.64 ns |  2.4615 ns |  2.3025 ns |    158.76 ns |   0.03 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    120.47 ns |  0.0100 ns |  0.0089 ns |    120.47 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     94.44 ns |  0.0106 ns |  0.0099 ns |     94.44 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    309.94 ns |  4.4922 ns |  4.2020 ns |    309.40 ns |   0.06 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    196.65 ns |  0.3424 ns |  0.3203 ns |    196.72 ns |   0.04 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    175.04 ns |  0.1099 ns |  0.1028 ns |    175.05 ns |   0.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     99.79 ns |  0.0308 ns |  0.0288 ns |     99.80 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     71.27 ns |  0.0081 ns |  0.0072 ns |     71.27 ns |   0.01 |     0.00 |
|                                           ForeachDelegate |         [1000] |  8,039.95 ns | 18.0433 ns | 16.8777 ns |  8,049.84 ns |   1.53 |     0.00 |
|                                                   Foreach |         [1000] |  5,263.84 ns |  2.6144 ns |  2.4456 ns |  5,262.62 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **[50]** |    **526.10 ns** |  **0.2799 ns** |  **0.2618 ns** |    **526.09 ns** |   **1.84** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    382.38 ns |  4.2005 ns |  3.9291 ns |    379.27 ns |   1.34 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    331.45 ns |  0.4117 ns |  0.3851 ns |    331.60 ns |   1.16 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    386.75 ns |  0.1667 ns |  0.1478 ns |    386.71 ns |   1.35 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    388.30 ns |  3.7926 ns |  3.5476 ns |    385.73 ns |   1.36 |     0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    189.31 ns |  0.0124 ns |  0.0103 ns |    189.31 ns |   0.66 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    154.53 ns |  0.1653 ns |  0.1546 ns |    154.56 ns |   0.54 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,190.20 ns |  0.8774 ns |  0.8207 ns |  1,190.36 ns |   4.16 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,067.13 ns |  1.4361 ns |  1.1212 ns |  1,067.26 ns |   3.73 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    564.85 ns |  0.1773 ns |  0.1572 ns |    564.83 ns |   1.97 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    523.79 ns |  0.1258 ns |  0.1177 ns |    523.78 ns |   1.83 |     0.00 |
|                                                 LinqCount |           [50] |    255.37 ns |  0.3875 ns |  0.3624 ns |    255.60 ns |   0.89 |     0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    317.42 ns |  0.0808 ns |  0.0716 ns |    317.44 ns |   1.11 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    291.59 ns |  3.1715 ns |  2.9666 ns |    291.90 ns |   1.02 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |    128.27 ns |  0.2766 ns |  0.2587 ns |    128.11 ns |   0.45 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     82.59 ns |  0.1261 ns |  0.1180 ns |     82.53 ns |   0.29 |     0.00 |
|                                               LinqToArray |           [50] |    507.88 ns |  0.0980 ns |  0.0869 ns |    507.87 ns |   1.77 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    527.39 ns |  0.2820 ns |  0.2499 ns |    527.41 ns |   1.84 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    492.14 ns |  1.0383 ns |  0.8106 ns |    491.89 ns |   1.72 |     0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    268.26 ns |  0.0993 ns |  0.0880 ns |    268.25 ns |   0.94 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    220.61 ns |  0.0580 ns |  0.0484 ns |    220.59 ns |   0.77 |     0.00 |
|                                                      Take |           [50] |    378.68 ns |  0.0924 ns |  0.0819 ns |    378.64 ns |   1.32 |     0.00 |
|                                               LowCostTake |           [50] |    204.19 ns |  0.3721 ns |  0.3481 ns |    203.99 ns |   0.71 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    165.11 ns |  0.0359 ns |  0.0318 ns |    165.10 ns |   0.58 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    115.94 ns |  0.2116 ns |  0.1979 ns |    116.02 ns |   0.40 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     91.57 ns |  0.0074 ns |  0.0061 ns |     91.57 ns |   0.32 |     0.00 |
|                                            SkipTakeSingle |           [50] |    308.68 ns |  0.0461 ns |  0.0431 ns |    308.68 ns |   1.08 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    197.84 ns |  0.1118 ns |  0.1045 ns |    197.85 ns |   0.69 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    174.91 ns |  2.5484 ns |  2.2591 ns |    173.88 ns |   0.61 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     99.74 ns |  0.0327 ns |  0.0305 ns |     99.75 ns |   0.35 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     75.22 ns |  0.0031 ns |  0.0026 ns |     75.22 ns |   0.26 |     0.00 |
|                                           ForeachDelegate |           [50] |    428.44 ns |  0.1982 ns |  0.1757 ns |    428.48 ns |   1.50 |     0.00 |
|                                                   Foreach |           [50] |    286.31 ns |  0.0541 ns |  0.0452 ns |    286.32 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |            **[5]** |    **108.43 ns** |  **0.0452 ns** |  **0.0423 ns** |    **108.42 ns** |   **2.66** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     68.04 ns |  0.0450 ns |  0.0398 ns |     68.03 ns |   1.67 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     56.51 ns |  0.8905 ns |  0.8330 ns |     56.01 ns |   1.38 |     0.02 |
|                                  LowCostLinqWithDelegate2 |            [5] |     81.30 ns |  0.0409 ns |  0.0382 ns |     81.30 ns |   1.99 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     72.35 ns |  0.1872 ns |  0.1751 ns |     72.28 ns |   1.77 |     0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     56.16 ns |  0.0254 ns |  0.0237 ns |     56.16 ns |   1.38 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     49.33 ns |  0.1050 ns |  0.0982 ns |     49.27 ns |   1.21 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    211.38 ns |  0.2099 ns |  0.1964 ns |    211.38 ns |   5.18 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    196.06 ns |  0.1358 ns |  0.1270 ns |    196.03 ns |   4.80 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    135.38 ns |  1.8366 ns |  1.7179 ns |    135.40 ns |   3.32 |     0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    116.57 ns |  0.0189 ns |  0.0158 ns |    116.57 ns |   2.86 |     0.00 |
|                                                 LinqCount |            [5] |     76.15 ns |  0.1487 ns |  0.1318 ns |     76.09 ns |   1.87 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     64.16 ns |  0.0511 ns |  0.0453 ns |     64.18 ns |   1.57 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     59.24 ns |  0.9563 ns |  0.8945 ns |     58.60 ns |   1.45 |     0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |     45.70 ns |  0.1294 ns |  0.1210 ns |     45.76 ns |   1.12 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     32.76 ns |  0.0125 ns |  0.0117 ns |     32.76 ns |   0.80 |     0.00 |
|                                               LinqToArray |            [5] |    139.04 ns |  0.1779 ns |  0.1664 ns |    139.11 ns |   3.41 |     0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    111.42 ns |  0.1006 ns |  0.0785 ns |    111.41 ns |   2.73 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    104.04 ns |  0.0683 ns |  0.0639 ns |    104.04 ns |   2.55 |     0.00 |
|                              LowCostLinqWithStructToArray |            [5] |     85.85 ns |  0.0335 ns |  0.0297 ns |     85.84 ns |   2.10 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     74.39 ns |  1.0441 ns |  0.9767 ns |     74.37 ns |   1.82 |     0.02 |
|                                                      Take |            [5] |    173.97 ns |  0.0464 ns |  0.0411 ns |    173.96 ns |   4.26 |     0.00 |
|                                               LowCostTake |            [5] |     76.19 ns |  0.1439 ns |  0.1346 ns |     76.20 ns |   1.87 |     0.00 |
|                                  LowCostTakeWithoutChecks |            [5] |     71.98 ns |  0.0283 ns |  0.0236 ns |     71.97 ns |   1.76 |     0.00 |
|                                     LowCostTakeWithStruct |            [5] |     65.14 ns |  0.5662 ns |  0.5296 ns |     65.29 ns |   1.60 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     58.46 ns |  0.0396 ns |  0.0370 ns |     58.46 ns |   1.43 |     0.00 |
|                                            SkipTakeSingle |            [5] |    160.16 ns |  0.0313 ns |  0.0293 ns |    160.16 ns |   3.92 |     0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     78.69 ns |  0.0472 ns |  0.0442 ns |     78.69 ns |   1.93 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     70.04 ns |  0.0502 ns |  0.0470 ns |     70.05 ns |   1.72 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     71.68 ns |  0.2018 ns |  0.1789 ns |     71.76 ns |   1.76 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     55.34 ns |  0.0046 ns |  0.0039 ns |     55.34 ns |   1.36 |     0.00 |
|                                           ForeachDelegate |            [5] |     59.54 ns |  0.0158 ns |  0.0148 ns |     59.54 ns |   1.46 |     0.00 |
|                                                   Foreach |            [5] |     40.81 ns |  0.0216 ns |  0.0169 ns |     40.81 ns |   1.00 |     0.00 |
