``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|-------:|---------:|
|                                         **Linq** |              **0** |    **110.993 ns** |  **0.1502 ns** |  **0.1405 ns** |  **37.97** |     **0.05** |
|                      LowCostLinqWithDelegate |              0 |     32.888 ns |  0.0100 ns |  0.0084 ns |  11.25 |     0.01 |
|                     LowCostLinqWithDelegate2 |              0 |     58.234 ns |  0.0307 ns |  0.0287 ns |  19.92 |     0.01 |
|                   LowCostLinqWithStructWhere |              0 |     41.781 ns |  0.0046 ns |  0.0043 ns |  14.29 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              0 |     63.866 ns |  0.1088 ns |  0.1018 ns |  21.85 |     0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |              0 |     60.670 ns |  0.0545 ns |  0.0455 ns |  20.76 |     0.02 |
|                                    LinqCount |              0 |    107.880 ns |  0.0383 ns |  0.0358 ns |  36.91 |     0.02 |
|                 LowCostLinqWithDelegateCount |              0 |     29.201 ns |  0.0052 ns |  0.0040 ns |   9.99 |     0.00 |
|              LowCostLinqWithStructWhereCount |              0 |     35.076 ns |  0.0071 ns |  0.0063 ns |  12.00 |     0.01 |
|                                  LinqToArray |              0 |    123.781 ns |  0.0530 ns |  0.0470 ns |  42.35 |     0.02 |
|               LowCostLinqWithDelegateToArray |              0 |     32.469 ns |  0.0342 ns |  0.0320 ns |  11.11 |     0.01 |
|                 LowCostLinqWithStructToArray |              0 |     43.510 ns |  0.0121 ns |  0.0107 ns |  14.89 |     0.01 |
|                                         Take |              0 |    145.633 ns |  0.1951 ns |  0.1729 ns |  49.82 |     0.06 |
|                                  LowCostTake |              0 |     45.903 ns |  0.0192 ns |  0.0150 ns |  15.70 |     0.01 |
|                        LowCostTakeWithStruct |              0 |     55.009 ns |  0.0062 ns |  0.0058 ns |  18.82 |     0.01 |
|                               SkipTakeSingle |              0 |    169.310 ns |  0.1915 ns |  0.1792 ns |  57.93 |     0.06 |
|                        LowCostSkipTakeSingle |              0 |     60.596 ns |  0.0142 ns |  0.0126 ns |  20.73 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |              0 |     66.587 ns |  0.0071 ns |  0.0066 ns |  22.78 |     0.01 |
|                              ForeachDelegate |              0 |      7.118 ns |  0.0070 ns |  0.0066 ns |   2.44 |     0.00 |
|                                      Foreach |              0 |      2.760 ns |  0.0009 ns |  0.0007 ns |   0.94 |     0.00 |
|                                          For |              0 |      2.923 ns |  0.0015 ns |  0.0013 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |           **1000** | **13,288.862 ns** |  **7.6914 ns** |  **7.1945 ns** |  **53.07** |     **0.03** |
|                      LowCostLinqWithDelegate |           1000 |  9,580.582 ns |  4.5407 ns |  3.0034 ns |  38.26 |     0.02 |
|                     LowCostLinqWithDelegate2 |           1000 | 10,111.411 ns |  4.2207 ns |  3.9480 ns |  40.38 |     0.02 |
|                   LowCostLinqWithStructWhere |           1000 |  1,486.278 ns |  0.1027 ns |  0.0857 ns |   5.94 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |           1000 | 20,413.285 ns | 12.3574 ns | 10.9545 ns |  81.52 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  5,801.723 ns |  5.6459 ns |  5.2812 ns |  23.17 |     0.02 |
|                                    LinqCount |           1000 |  9,239.990 ns |  2.4821 ns |  2.0727 ns |  36.90 |     0.02 |
|                 LowCostLinqWithDelegateCount |           1000 | 10,309.621 ns |  7.4173 ns |  6.9382 ns |  41.17 |     0.03 |
|              LowCostLinqWithStructWhereCount |           1000 |  1,352.125 ns |  0.2287 ns |  0.1910 ns |   5.40 |     0.00 |
|                                  LinqToArray |           1000 | 10,650.520 ns |  7.7418 ns |  6.8629 ns |  42.53 |     0.03 |
|               LowCostLinqWithDelegateToArray |           1000 | 12,787.724 ns | 11.6814 ns | 10.9268 ns |  51.07 |     0.05 |
|                 LowCostLinqWithStructToArray |           1000 |  2,247.228 ns |  4.3400 ns |  3.8473 ns |   8.97 |     0.02 |
|                                         Take |           1000 |    516.470 ns |  0.2742 ns |  0.2430 ns |   2.06 |     0.00 |
|                                  LowCostTake |           1000 |    245.582 ns |  0.0708 ns |  0.0628 ns |   0.98 |     0.00 |
|                        LowCostTakeWithStruct |           1000 |     91.904 ns |  0.0143 ns |  0.0112 ns |   0.37 |     0.00 |
|                               SkipTakeSingle |           1000 |    443.592 ns |  0.3991 ns |  0.3538 ns |   1.77 |     0.00 |
|                        LowCostSkipTakeSingle |           1000 |    298.920 ns |  0.1765 ns |  0.1651 ns |   1.19 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |           1000 |    129.796 ns |  0.0866 ns |  0.0767 ns |   0.52 |     0.00 |
|                              ForeachDelegate |           1000 |  6,215.600 ns |  0.6922 ns |  0.6136 ns |  24.82 |     0.01 |
|                                      Foreach |           1000 |    485.409 ns |  0.2341 ns |  0.2075 ns |   1.94 |     0.00 |
|                                          For |           1000 |    250.395 ns |  0.0965 ns |  0.0902 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |              **5** |    **189.238 ns** |  **0.1785 ns** |  **0.1582 ns** |  **44.05** |     **0.04** |
|                      LowCostLinqWithDelegate |              5 |     72.261 ns |  0.0323 ns |  0.0286 ns |  16.82 |     0.01 |
|                     LowCostLinqWithDelegate2 |              5 |    100.522 ns |  0.2196 ns |  0.2054 ns |  23.40 |     0.05 |
|                   LowCostLinqWithStructWhere |              5 |     59.380 ns |  0.0234 ns |  0.0219 ns |  13.82 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |              5 |    176.237 ns |  0.0631 ns |  0.0590 ns |  41.02 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |              5 |     86.221 ns |  0.0673 ns |  0.0596 ns |  20.07 |     0.02 |
|                                    LinqCount |              5 |    157.832 ns |  0.3069 ns |  0.2871 ns |  36.74 |     0.07 |
|                 LowCostLinqWithDelegateCount |              5 |     75.842 ns |  0.0296 ns |  0.0263 ns |  17.65 |     0.01 |
|              LowCostLinqWithStructWhereCount |              5 |     38.465 ns |  0.0149 ns |  0.0139 ns |   8.95 |     0.00 |
|                                  LinqToArray |              5 |    217.114 ns |  0.1119 ns |  0.0992 ns |  50.54 |     0.03 |
|               LowCostLinqWithDelegateToArray |              5 |    122.101 ns |  0.1248 ns |  0.1167 ns |  28.42 |     0.03 |
|                 LowCostLinqWithStructToArray |              5 |     75.307 ns |  0.0419 ns |  0.0392 ns |  17.53 |     0.01 |
|                                         Take |              5 |    251.864 ns |  0.3209 ns |  0.3002 ns |  58.63 |     0.07 |
|                                  LowCostTake |              5 |     83.427 ns |  0.0730 ns |  0.0683 ns |  19.42 |     0.02 |
|                        LowCostTakeWithStruct |              5 |     65.669 ns |  0.0422 ns |  0.0395 ns |  15.29 |     0.01 |
|                               SkipTakeSingle |              5 |    237.908 ns |  0.0556 ns |  0.0464 ns |  55.38 |     0.02 |
|                        LowCostSkipTakeSingle |              5 |    114.441 ns |  0.1404 ns |  0.1313 ns |  26.64 |     0.03 |
|              LowCostSkipTakeSingleWithStruct |              5 |     83.722 ns |  0.0574 ns |  0.0537 ns |  19.49 |     0.01 |
|                              ForeachDelegate |              5 |     37.745 ns |  0.0104 ns |  0.0092 ns |   8.79 |     0.00 |
|                                      Foreach |              5 |      5.515 ns |  0.0038 ns |  0.0036 ns |   1.28 |     0.00 |
|                                          For |              5 |      4.296 ns |  0.0022 ns |  0.0017 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |        |          |
|                                         **Linq** |             **50** |    **776.863 ns** |  **0.8608 ns** |  **0.8052 ns** |  **47.05** |     **0.06** |
|                      LowCostLinqWithDelegate |             50 |    507.754 ns |  0.2733 ns |  0.2557 ns |  30.75 |     0.03 |
|                     LowCostLinqWithDelegate2 |             50 |    559.200 ns |  0.6039 ns |  0.5649 ns |  33.86 |     0.04 |
|                   LowCostLinqWithStructWhere |             50 |    111.767 ns |  0.0510 ns |  0.0426 ns |   6.77 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,089.358 ns |  0.7431 ns |  0.6206 ns |  65.97 |     0.07 |
| LowCostLinqWithStructFilterCastToIEnumerable |             50 |    356.562 ns |  0.2895 ns |  0.2708 ns |  21.59 |     0.02 |
|                                    LinqCount |             50 |    570.480 ns |  0.3971 ns |  0.3520 ns |  34.55 |     0.04 |
|                 LowCostLinqWithDelegateCount |             50 |    542.772 ns |  0.0760 ns |  0.0674 ns |  32.87 |     0.03 |
|              LowCostLinqWithStructWhereCount |             50 |     87.119 ns |  0.0292 ns |  0.0273 ns |   5.28 |     0.00 |
|                                  LinqToArray |             50 |    857.980 ns |  0.8764 ns |  0.8198 ns |  51.96 |     0.07 |
|               LowCostLinqWithDelegateToArray |             50 |    802.326 ns |  0.8604 ns |  0.7627 ns |  48.59 |     0.06 |
|                 LowCostLinqWithStructToArray |             50 |    225.628 ns |  0.2047 ns |  0.1814 ns |  13.66 |     0.02 |
|                                         Take |             50 |    516.215 ns |  0.1100 ns |  0.0918 ns |  31.26 |     0.03 |
|                                  LowCostTake |             50 |    245.608 ns |  0.1837 ns |  0.1628 ns |  14.87 |     0.02 |
|                        LowCostTakeWithStruct |             50 |     98.302 ns |  0.0461 ns |  0.0431 ns |   5.95 |     0.01 |
|                               SkipTakeSingle |             50 |    443.964 ns |  0.1669 ns |  0.1104 ns |  26.89 |     0.02 |
|                        LowCostSkipTakeSingle |             50 |    297.728 ns |  0.0987 ns |  0.0923 ns |  18.03 |     0.02 |
|              LowCostSkipTakeSingleWithStruct |             50 |    129.808 ns |  0.1269 ns |  0.1187 ns |   7.86 |     0.01 |
|                              ForeachDelegate |             50 |    321.642 ns |  0.1835 ns |  0.1716 ns |  19.48 |     0.02 |
|                                      Foreach |             50 |     27.213 ns |  0.0089 ns |  0.0074 ns |   1.65 |     0.00 |
|                                          For |             50 |     16.513 ns |  0.0179 ns |  0.0149 ns |   1.00 |     0.00 |
