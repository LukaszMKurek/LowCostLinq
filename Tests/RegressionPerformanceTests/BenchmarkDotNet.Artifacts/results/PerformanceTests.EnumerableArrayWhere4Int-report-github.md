``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |      StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|------------:|-------------:|-------:|---------:|
|                                                      **Linq** |            **[0]** |    **103.67 ns** |   **0.0624 ns** |   **0.0584 ns** |    **103.65 ns** |   **8.93** |     **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     45.86 ns |   0.0036 ns |   0.0030 ns |     45.86 ns |   3.95 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     46.06 ns |   0.0171 ns |   0.0160 ns |     46.05 ns |   3.97 |     0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     71.45 ns |   0.0069 ns |   0.0061 ns |     71.45 ns |   6.16 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     71.46 ns |   0.0079 ns |   0.0074 ns |     71.46 ns |   6.16 |     0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     55.47 ns |   0.1126 ns |   0.1054 ns |     55.41 ns |   4.78 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     57.39 ns |   0.0011 ns |   0.0010 ns |     57.39 ns |   4.94 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    107.70 ns |   0.0723 ns |   0.0641 ns |    107.68 ns |   9.28 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    109.48 ns |   0.0461 ns |   0.0431 ns |    109.46 ns |   9.43 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     97.99 ns |   1.4386 ns |   1.3456 ns |     97.07 ns |   8.44 |     0.11 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     96.63 ns |   0.0395 ns |   0.0350 ns |     96.63 ns |   8.33 |     0.00 |
|                                                 LinqCount |            [0] |    103.95 ns |   0.0321 ns |   0.0268 ns |    103.95 ns |   8.96 |     0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     47.38 ns |   0.0938 ns |   0.0784 ns |     47.35 ns |   4.08 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     43.33 ns |   0.0281 ns |   0.0263 ns |     43.34 ns |   3.73 |     0.00 |
|                           LowCostLinqWithStructWhereCount |            [0] |     47.30 ns |   0.0160 ns |   0.0149 ns |     47.29 ns |   4.07 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     46.50 ns |   0.0011 ns |   0.0009 ns |     46.50 ns |   4.01 |     0.00 |
|                                               LinqToArray |            [0] |    124.76 ns |   1.8990 ns |   1.7763 ns |    123.76 ns |  10.75 |     0.15 |
|                            LowCostLinqWithDelegateToArray |            [0] |     51.64 ns |   0.0194 ns |   0.0172 ns |     51.63 ns |   4.45 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     52.30 ns |   0.1627 ns |   0.1521 ns |     52.35 ns |   4.51 |     0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     64.50 ns |   0.8186 ns |   0.7657 ns |     64.53 ns |   5.56 |     0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     55.32 ns |   0.0277 ns |   0.0259 ns |     55.33 ns |   4.77 |     0.00 |
|                                                      Take |            [0] |    138.48 ns |   0.0211 ns |   0.0187 ns |    138.48 ns |  11.93 |     0.00 |
|                                               LowCostTake |            [0] |     58.13 ns |   0.1035 ns |   0.0917 ns |     58.17 ns |   5.01 |     0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     57.95 ns |   0.5063 ns |   0.4736 ns |     58.16 ns |   4.99 |     0.04 |
|                                     LowCostTakeWithStruct |            [0] |     67.20 ns |   0.0121 ns |   0.0113 ns |     67.20 ns |   5.79 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     67.94 ns |   0.0056 ns |   0.0052 ns |     67.94 ns |   5.85 |     0.00 |
|                                            SkipTakeSingle |            [0] |    162.35 ns |   0.0503 ns |   0.0471 ns |    162.33 ns |  13.99 |     0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     92.27 ns |   0.8606 ns |   0.8050 ns |     91.86 ns |   7.95 |     0.07 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     78.92 ns |   0.0651 ns |   0.0609 ns |     78.89 ns |   6.80 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     83.92 ns |   0.0203 ns |   0.0190 ns |     83.92 ns |   7.23 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     86.08 ns |   0.1588 ns |   0.1485 ns |     86.15 ns |   7.42 |     0.01 |
|                                           ForeachDelegate |            [0] |     15.98 ns |   0.2233 ns |   0.2089 ns |     15.84 ns |   1.38 |     0.02 |
|                                                   Foreach |            [0] |     11.61 ns |   0.0010 ns |   0.0010 ns |     11.61 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |         **[1000]** | **12,107.30 ns** |   **5.1347 ns** |   **4.8030 ns** | **12,108.64 ns** |   **2.97** |     **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] | 10,314.03 ns | 158.4521 ns | 148.2162 ns | 10,244.16 ns |   2.53 |     0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 10,666.58 ns |  32.4809 ns |  30.3826 ns | 10,668.79 ns |   2.61 |     0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 11,769.07 ns |  25.2691 ns |  22.4004 ns | 11,768.41 ns |   2.88 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 11,488.99 ns |  36.7136 ns |  32.5456 ns | 11,497.45 ns |   2.81 |     0.01 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,946.23 ns |  38.6981 ns |  77.2843 ns |  1,976.46 ns |   0.48 |     0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,566.12 ns |   0.2969 ns |   0.2778 ns |  1,566.15 ns |   0.38 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 23,657.55 ns |  37.4474 ns |  29.2365 ns | 23,658.33 ns |   5.80 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 22,953.48 ns |  38.4801 ns |  34.1116 ns | 22,949.02 ns |   5.62 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,020.84 ns |   5.2327 ns |   4.3696 ns |  8,018.89 ns |   1.96 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,261.04 ns |   3.7755 ns |   3.5316 ns |  8,260.99 ns |   2.02 |     0.00 |
|                                                 LinqCount |         [1000] |  8,987.12 ns |   4.6594 ns |   3.8908 ns |  8,985.83 ns |   2.20 |     0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  9,121.11 ns | 150.5463 ns | 140.8211 ns |  9,140.70 ns |   2.23 |     0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  9,836.11 ns |  83.3893 ns |  78.0024 ns |  9,849.57 ns |   2.41 |     0.02 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,366.58 ns |   0.1573 ns |   0.1394 ns |  1,366.55 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,365.91 ns |   0.6939 ns |   0.5418 ns |  1,365.57 ns |   0.33 |     0.00 |
|                                               LinqToArray |         [1000] | 10,654.40 ns | 154.0271 ns | 144.0770 ns | 10,555.97 ns |   2.61 |     0.03 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 11,960.89 ns |  33.6373 ns |  31.4643 ns | 11,974.34 ns |   2.93 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 11,660.27 ns |   2.8468 ns |   2.5236 ns | 11,660.44 ns |   2.86 |     0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,291.48 ns |  30.3569 ns |  28.3959 ns |  2,273.36 ns |   0.56 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,310.81 ns |   1.5669 ns |   1.4657 ns |  2,310.56 ns |   0.57 |     0.00 |
|                                                      Take |         [1000] |    503.20 ns |   1.0357 ns |   0.9688 ns |    503.59 ns |   0.12 |     0.00 |
|                                               LowCostTake |         [1000] |    303.38 ns |   0.0151 ns |   0.0126 ns |    303.38 ns |   0.07 |     0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    302.71 ns |   0.2944 ns |   0.2754 ns |    302.85 ns |   0.07 |     0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    126.05 ns |   1.9035 ns |   1.7805 ns |    124.79 ns |   0.03 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    115.61 ns |   0.1110 ns |   0.1039 ns |    115.62 ns |   0.03 |     0.00 |
|                                            SkipTakeSingle |         [1000] |    406.43 ns |   0.6753 ns |   0.5986 ns |    406.66 ns |   0.10 |     0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    338.16 ns |   4.6811 ns |   4.3787 ns |    337.49 ns |   0.08 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    330.05 ns |   0.8959 ns |   0.8380 ns |    330.40 ns |   0.08 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    135.85 ns |   0.0678 ns |   0.0635 ns |    135.83 ns |   0.03 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    150.86 ns |   0.1133 ns |   0.1060 ns |    150.86 ns |   0.04 |     0.00 |
|                                           ForeachDelegate |         [1000] |  9,172.43 ns |  90.4203 ns |  84.5792 ns |  9,121.32 ns |   2.25 |     0.02 |
|                                                   Foreach |         [1000] |  4,081.96 ns |   4.7106 ns |   4.4063 ns |  4,083.36 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |           **[50]** |    **717.88 ns** |   **0.2155 ns** |   **0.1910 ns** |    **717.88 ns** |   **3.21** |     **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    550.80 ns |   2.5067 ns |   2.3448 ns |    551.94 ns |   2.47 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    563.02 ns |   0.3155 ns |   0.2951 ns |    563.11 ns |   2.52 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    660.33 ns |   0.2053 ns |   0.1715 ns |    660.32 ns |   2.96 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    638.32 ns |   0.0761 ns |   0.0674 ns |    638.32 ns |   2.86 |     0.00 |
|                                LowCostLinqWithStructWhere |           [50] |    156.18 ns |   1.1632 ns |   1.0881 ns |    156.45 ns |   0.70 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    136.78 ns |   0.0779 ns |   0.0691 ns |    136.77 ns |   0.61 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,322.22 ns |  25.0651 ns |  25.7400 ns |  1,307.33 ns |   5.92 |     0.11 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,269.39 ns |   2.0644 ns |   1.7239 ns |  1,268.78 ns |   5.68 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    507.68 ns |   0.0969 ns |   0.0906 ns |    507.67 ns |   2.27 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    513.64 ns |   0.4144 ns |   0.3674 ns |    513.53 ns |   2.30 |     0.00 |
|                                                 LinqCount |           [50] |    563.96 ns |   8.4265 ns |   7.8821 ns |    567.88 ns |   2.52 |     0.03 |
|                              LowCostLinqWithDelegateCount |           [50] |    499.39 ns |   1.1285 ns |   1.0556 ns |    498.80 ns |   2.24 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    544.33 ns |   0.1480 ns |   0.1385 ns |    544.39 ns |   2.44 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    106.52 ns |   0.1016 ns |   0.0794 ns |    106.49 ns |   0.48 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    107.05 ns |   1.2796 ns |   1.1969 ns |    106.32 ns |   0.48 |     0.01 |
|                                               LinqToArray |           [50] |    839.37 ns |   0.4479 ns |   0.4190 ns |    839.19 ns |   3.76 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    752.54 ns |   0.5324 ns |   0.4719 ns |    752.70 ns |   3.37 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    748.30 ns |  10.0599 ns |   9.4100 ns |    740.74 ns |   3.35 |     0.04 |
|                              LowCostLinqWithStructToArray |           [50] |    219.30 ns |   0.0596 ns |   0.0529 ns |    219.29 ns |   0.98 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    221.77 ns |   0.3065 ns |   0.2717 ns |    221.68 ns |   0.99 |     0.00 |
|                                                      Take |           [50] |    509.27 ns |  10.0919 ns |  12.0137 ns |    500.71 ns |   2.28 |     0.05 |
|                                               LowCostTake |           [50] |    303.04 ns |   0.7754 ns |   0.7253 ns |    303.43 ns |   1.36 |     0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    299.98 ns |   0.0720 ns |   0.0562 ns |    299.97 ns |   1.34 |     0.00 |
|                                     LowCostTakeWithStruct |           [50] |    125.85 ns |   0.0504 ns |   0.0447 ns |    125.84 ns |   0.56 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    117.14 ns |   0.9387 ns |   0.8781 ns |    116.55 ns |   0.52 |     0.00 |
|                                            SkipTakeSingle |           [50] |    407.65 ns |   0.0969 ns |   0.0757 ns |    407.62 ns |   1.83 |     0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    334.24 ns |   0.0841 ns |   0.0657 ns |    334.22 ns |   1.50 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    329.04 ns |   0.6304 ns |   0.4922 ns |    328.86 ns |   1.47 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    134.92 ns |   0.0647 ns |   0.0605 ns |    134.94 ns |   0.60 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    144.52 ns |   0.1899 ns |   0.1776 ns |    144.49 ns |   0.65 |     0.00 |
|                                           ForeachDelegate |           [50] |    481.41 ns |   1.0232 ns |   0.9571 ns |    481.92 ns |   2.16 |     0.00 |
|                                                   Foreach |           [50] |    223.35 ns |   0.0566 ns |   0.0442 ns |    223.36 ns |   1.00 |     0.00 |
|                                                           |                |              |             |             |              |        |          |
|                                                      **Linq** |            **[5]** |    **182.33 ns** |   **0.1113 ns** |   **0.1041 ns** |    **182.30 ns** |   **5.67** |     **0.01** |
|                                   LowCostLinqWithDelegate |            [5] |     94.85 ns |   0.0305 ns |   0.0285 ns |     94.85 ns |   2.95 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     99.51 ns |   0.2000 ns |   0.1871 ns |     99.56 ns |   3.10 |     0.01 |
|                                  LowCostLinqWithDelegate2 |            [5] |    133.09 ns |   1.4251 ns |   1.3330 ns |    132.32 ns |   4.14 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    134.92 ns |   0.1004 ns |   0.0939 ns |    134.96 ns |   4.20 |     0.01 |
|                                LowCostLinqWithStructWhere |            [5] |     64.90 ns |   0.0287 ns |   0.0254 ns |     64.90 ns |   2.02 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     62.83 ns |   0.0273 ns |   0.0255 ns |     62.84 ns |   1.95 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    249.72 ns |   2.5154 ns |   2.2298 ns |    248.72 ns |   7.77 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    232.85 ns |   0.2387 ns |   0.2233 ns |    232.84 ns |   7.24 |     0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    141.03 ns |   0.0469 ns |   0.0416 ns |    141.03 ns |   4.39 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    140.04 ns |   0.0780 ns |   0.0692 ns |    140.03 ns |   4.36 |     0.01 |
|                                                 LinqCount |            [5] |    154.61 ns |   2.4206 ns |   2.2642 ns |    154.30 ns |   4.81 |     0.07 |
|                              LowCostLinqWithDelegateCount |            [5] |     85.70 ns |   0.0059 ns |   0.0049 ns |     85.70 ns |   2.67 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     89.05 ns |   0.0373 ns |   0.0312 ns |     89.04 ns |   2.77 |     0.01 |
|                           LowCostLinqWithStructWhereCount |            [5] |     49.74 ns |   0.4368 ns |   0.4086 ns |     49.47 ns |   1.55 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     49.13 ns |   0.0049 ns |   0.0046 ns |     49.12 ns |   1.53 |     0.00 |
|                                               LinqToArray |            [5] |    213.43 ns |   0.0963 ns |   0.0900 ns |    213.39 ns |   6.64 |     0.01 |
|                            LowCostLinqWithDelegateToArray |            [5] |    132.23 ns |   0.0288 ns |   0.0240 ns |    132.23 ns |   4.11 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    134.14 ns |   1.8947 ns |   1.7723 ns |    133.14 ns |   4.17 |     0.05 |
|                              LowCostLinqWithStructToArray |            [5] |     88.20 ns |   0.0305 ns |   0.0286 ns |     88.19 ns |   2.74 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     90.47 ns |   0.0644 ns |   0.0571 ns |     90.47 ns |   2.81 |     0.01 |
|                                                      Take |            [5] |    237.81 ns |   0.1770 ns |   0.1655 ns |    237.81 ns |   7.40 |     0.02 |
|                                               LowCostTake |            [5] |    122.52 ns |   1.4362 ns |   1.3434 ns |    122.61 ns |   3.81 |     0.04 |
|                                  LowCostTakeWithoutChecks |            [5] |    110.24 ns |   0.0442 ns |   0.0413 ns |    110.23 ns |   3.43 |     0.01 |
|                                     LowCostTakeWithStruct |            [5] |     80.32 ns |   0.0328 ns |   0.0274 ns |     80.32 ns |   2.50 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     79.18 ns |   0.0368 ns |   0.0288 ns |     79.17 ns |   2.46 |     0.01 |
|                                            SkipTakeSingle |            [5] |    228.90 ns |   0.3918 ns |   0.3665 ns |    228.90 ns |   7.12 |     0.02 |
|                                     LowCostSkipTakeSingle |            [5] |    142.68 ns |   0.0304 ns |   0.0254 ns |    142.68 ns |   4.44 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    133.50 ns |   0.3378 ns |   0.3160 ns |    133.66 ns |   4.15 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     89.96 ns |   0.7934 ns |   0.7422 ns |     89.40 ns |   2.80 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     90.33 ns |   0.1547 ns |   0.1447 ns |     90.40 ns |   2.81 |     0.01 |
|                                           ForeachDelegate |            [5] |     63.15 ns |   0.0152 ns |   0.0135 ns |     63.14 ns |   1.96 |     0.00 |
|                                                   Foreach |            [5] |     32.15 ns |   0.0719 ns |   0.0673 ns |     32.16 ns |   1.00 |     0.00 |
