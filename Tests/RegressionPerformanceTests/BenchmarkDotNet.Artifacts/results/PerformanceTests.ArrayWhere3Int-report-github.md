``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |            **[0]** |     **74.619 ns** |  **0.0370 ns** |  **0.0309 ns** |  **20.31** |     **0.01** |
|                      LowCostLinqWithDelegate |            [0] |     22.880 ns |  0.2244 ns |  0.2099 ns |   6.23 |     0.06 |
|                     LowCostLinqWithDelegate2 |            [0] |     47.565 ns |  0.0011 ns |  0.0010 ns |  12.95 |     0.00 |
|                   LowCostLinqWithStructWhere |            [0] |     36.899 ns |  0.0732 ns |  0.0685 ns |  10.04 |     0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     59.671 ns |  0.0611 ns |  0.0571 ns |  16.24 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     38.730 ns |  0.5502 ns |  0.5146 ns |  10.54 |     0.14 |
|                                    LinqCount |            [0] |     74.157 ns |  0.0428 ns |  0.0334 ns |  20.19 |     0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |     24.641 ns |  0.0370 ns |  0.0289 ns |   6.71 |     0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     28.330 ns |  0.0047 ns |  0.0044 ns |   7.71 |     0.00 |
|                                  LinqToArray |            [0] |     91.567 ns |  1.4720 ns |  1.3769 ns |  24.93 |     0.36 |
|               LowCostLinqWithDelegateToArray |            [0] |     28.348 ns |  0.0075 ns |  0.0070 ns |   7.72 |     0.00 |
|                 LowCostLinqWithStructToArray |            [0] |     32.008 ns |  0.0204 ns |  0.0191 ns |   8.71 |     0.01 |
|                                         Take |            [0] |    110.807 ns |  0.0217 ns |  0.0203 ns |  30.16 |     0.01 |
|                                  LowCostTake |            [0] |     32.151 ns |  0.0896 ns |  0.0699 ns |   8.75 |     0.02 |
|                        LowCostTakeWithStruct |            [0] |     42.082 ns |  0.0019 ns |  0.0018 ns |  11.46 |     0.00 |
|                               SkipTakeSingle |            [0] |    131.758 ns |  0.0959 ns |  0.0897 ns |  35.87 |     0.03 |
|                        LowCostSkipTakeSingle |            [0] |     41.360 ns |  0.0021 ns |  0.0019 ns |  11.26 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     48.574 ns |  0.0816 ns |  0.0723 ns |  13.22 |     0.02 |
|                              ForeachDelegate |            [0] |      7.679 ns |  0.0044 ns |  0.0041 ns |   2.09 |     0.00 |
|                                      Foreach |            [0] |      3.767 ns |  0.0027 ns |  0.0025 ns |   1.03 |     0.00 |
|                                          For |            [0] |      3.673 ns |  0.0015 ns |  0.0014 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |         **[1000]** | **10,671.355 ns** | **14.6057 ns** | **12.9476 ns** |  **42.14** |     **0.60** |
|                      LowCostLinqWithDelegate |         [1000] |  7,319.508 ns | 13.6295 ns | 12.7490 ns |  28.90 |     0.41 |
|                     LowCostLinqWithDelegate2 |         [1000] |  7,565.187 ns | 80.3695 ns | 75.1776 ns |  29.87 |     0.51 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,477.352 ns |  0.1278 ns |  0.1133 ns |   5.83 |     0.08 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 17,817.610 ns | 16.2026 ns | 14.3631 ns |  70.36 |     0.99 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,761.112 ns |  3.5455 ns |  2.9606 ns |  22.75 |     0.32 |
|                                    LinqCount |         [1000] |  6,716.162 ns | 28.3432 ns | 22.1285 ns |  26.52 |     0.38 |
|                 LowCostLinqWithDelegateCount |         [1000] |  7,465.273 ns | 11.8565 ns | 11.0906 ns |  29.48 |     0.42 |
|              LowCostLinqWithStructWhereCount |         [1000] |  1,346.386 ns |  0.0652 ns |  0.0578 ns |   5.32 |     0.07 |
|                                  LinqToArray |         [1000] |  7,888.032 ns |  5.3483 ns |  5.0028 ns |  31.15 |     0.44 |
|               LowCostLinqWithDelegateToArray |         [1000] |  8,741.333 ns |  2.3244 ns |  2.0605 ns |  34.52 |     0.49 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,218.894 ns |  6.8712 ns |  6.4274 ns |   8.76 |     0.13 |
|                                         Take |         [1000] |    437.658 ns |  0.0988 ns |  0.0876 ns |   1.73 |     0.02 |
|                                  LowCostTake |         [1000] |    192.609 ns |  0.1801 ns |  0.1596 ns |   0.76 |     0.01 |
|                        LowCostTakeWithStruct |         [1000] |     78.561 ns |  0.0109 ns |  0.0091 ns |   0.31 |     0.00 |
|                               SkipTakeSingle |         [1000] |    338.081 ns |  0.0695 ns |  0.0650 ns |   1.34 |     0.02 |
|                        LowCostSkipTakeSingle |         [1000] |    216.446 ns |  4.3327 ns |  4.0528 ns |   0.85 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     73.201 ns |  0.0122 ns |  0.0114 ns |   0.29 |     0.00 |
|                              ForeachDelegate |         [1000] |  4,309.480 ns |  0.3688 ns |  0.3450 ns |  17.02 |     0.24 |
|                                      Foreach |         [1000] |    468.146 ns |  8.7157 ns |  8.1527 ns |   1.85 |     0.04 |
|                                          For |         [1000] |    253.291 ns |  4.0049 ns |  3.7462 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |           **[50]** |    **616.911 ns** |  **0.7994 ns** |  **0.7086 ns** |  **32.12** |     **0.08** |
|                      LowCostLinqWithDelegate |           [50] |    396.397 ns |  0.7499 ns |  0.7015 ns |  20.64 |     0.06 |
|                     LowCostLinqWithDelegate2 |           [50] |    432.788 ns |  5.6513 ns |  5.2863 ns |  22.53 |     0.27 |
|                   LowCostLinqWithStructWhere |           [50] |    107.325 ns |  0.0174 ns |  0.0145 ns |   5.59 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    959.173 ns |  1.4564 ns |  1.3623 ns |  49.94 |     0.13 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    332.817 ns |  0.9315 ns |  0.8714 ns |  17.33 |     0.06 |
|                                    LinqCount |           [50] |    419.248 ns |  5.3685 ns |  5.0217 ns |  21.83 |     0.26 |
|                 LowCostLinqWithDelegateCount |           [50] |    397.763 ns |  0.0283 ns |  0.0236 ns |  20.71 |     0.04 |
|              LowCostLinqWithStructWhereCount |           [50] |     77.987 ns |  0.0027 ns |  0.0025 ns |   4.06 |     0.01 |
|                                  LinqToArray |           [50] |    678.278 ns | 13.3737 ns | 13.1347 ns |  35.32 |     0.67 |
|               LowCostLinqWithDelegateToArray |           [50] |    556.020 ns |  0.4375 ns |  0.3879 ns |  28.95 |     0.06 |
|                 LowCostLinqWithStructToArray |           [50] |    204.564 ns |  0.2077 ns |  0.1943 ns |  10.65 |     0.02 |
|                                         Take |           [50] |    437.861 ns |  0.1075 ns |  0.1005 ns |  22.80 |     0.05 |
|                                  LowCostTake |           [50] |    192.208 ns |  0.5037 ns |  0.4465 ns |  10.01 |     0.03 |
|                        LowCostTakeWithStruct |           [50] |     76.530 ns |  0.0123 ns |  0.0103 ns |   3.98 |     0.01 |
|                               SkipTakeSingle |           [50] |    336.409 ns |  0.0441 ns |  0.0413 ns |  17.52 |     0.04 |
|                        LowCostSkipTakeSingle |           [50] |    215.792 ns |  2.8675 ns |  2.6823 ns |  11.24 |     0.14 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     72.817 ns |  0.0425 ns |  0.0398 ns |   3.79 |     0.01 |
|                              ForeachDelegate |           [50] |    225.623 ns |  0.0240 ns |  0.0225 ns |  11.75 |     0.02 |
|                                      Foreach |           [50] |     27.330 ns |  0.2041 ns |  0.1909 ns |   1.42 |     0.01 |
|                                          For |           [50] |     19.207 ns |  0.0450 ns |  0.0421 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |            **[5]** |    **129.312 ns** |  **0.0481 ns** |  **0.0450 ns** |  **28.68** |     **0.01** |
|                      LowCostLinqWithDelegate |            [5] |     57.589 ns |  0.0542 ns |  0.0507 ns |  12.77 |     0.01 |
|                     LowCostLinqWithDelegate2 |            [5] |     83.282 ns |  0.0512 ns |  0.0454 ns |  18.47 |     0.01 |
|                   LowCostLinqWithStructWhere |            [5] |     56.313 ns |  0.0865 ns |  0.0809 ns |  12.49 |     0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    147.740 ns |  0.1595 ns |  0.1492 ns |  32.76 |     0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     68.176 ns |  0.6922 ns |  0.6475 ns |  15.12 |     0.14 |
|                                    LinqCount |            [5] |    111.850 ns |  0.0653 ns |  0.0545 ns |  24.81 |     0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |     60.259 ns |  0.1998 ns |  0.1869 ns |  13.36 |     0.04 |
|              LowCostLinqWithStructWhereCount |            [5] |     31.704 ns |  0.0290 ns |  0.0272 ns |   7.03 |     0.01 |
|                                  LinqToArray |            [5] |    175.930 ns |  2.6938 ns |  2.5198 ns |  39.02 |     0.54 |
|               LowCostLinqWithDelegateToArray |            [5] |     96.011 ns |  0.0334 ns |  0.0279 ns |  21.29 |     0.01 |
|                 LowCostLinqWithStructToArray |            [5] |     64.277 ns |  0.0332 ns |  0.0310 ns |  14.25 |     0.01 |
|                                         Take |            [5] |    205.568 ns |  0.0456 ns |  0.0404 ns |  45.59 |     0.01 |
|                                  LowCostTake |            [5] |     63.867 ns |  0.0550 ns |  0.0488 ns |  14.16 |     0.01 |
|                        LowCostTakeWithStruct |            [5] |     50.540 ns |  0.0155 ns |  0.0137 ns |  11.21 |     0.00 |
|                               SkipTakeSingle |            [5] |    186.579 ns |  0.0337 ns |  0.0315 ns |  41.38 |     0.01 |
|                        LowCostSkipTakeSingle |            [5] |     71.414 ns |  0.8250 ns |  0.7717 ns |  15.84 |     0.17 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     52.808 ns |  0.0136 ns |  0.0121 ns |  11.71 |     0.00 |
|                              ForeachDelegate |            [5] |     29.915 ns |  0.1078 ns |  0.0900 ns |   6.63 |     0.02 |
|                                      Foreach |            [5] |      5.666 ns |  0.0027 ns |  0.0021 ns |   1.26 |     0.00 |
|                                          For |            [5] |      4.509 ns |  0.0004 ns |  0.0003 ns |   1.00 |     0.00 |
