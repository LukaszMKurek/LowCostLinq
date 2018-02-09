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
|                                                      **Linq** |              **0** |    **135.67 ns** |  **0.1326 ns** |  **0.1240 ns** |   **7.73** |     **0.02** |
|                                   LowCostLinqWithDelegate |              0 |     52.97 ns |  0.0119 ns |  0.0112 ns |   3.02 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     54.41 ns |  0.0138 ns |  0.0129 ns |   3.10 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     79.31 ns |  0.0198 ns |  0.0175 ns |   4.52 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     88.25 ns |  0.0123 ns |  0.0096 ns |   5.03 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     65.88 ns |  0.0224 ns |  0.0187 ns |   3.75 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     61.57 ns |  0.0267 ns |  0.0236 ns |   3.51 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |    117.27 ns |  0.2024 ns |  0.1893 ns |   6.68 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |    115.95 ns |  0.0431 ns |  0.0403 ns |   6.60 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |    107.41 ns |  0.0146 ns |  0.0122 ns |   6.12 |     0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |    104.62 ns |  0.0439 ns |  0.0367 ns |   5.96 |     0.01 |
|                                                 LinqCount |              0 |    136.87 ns |  0.0572 ns |  0.0478 ns |   7.79 |     0.01 |
|                              LowCostLinqWithDelegateCount |              0 |     54.82 ns |  0.0239 ns |  0.0224 ns |   3.12 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     54.97 ns |  0.0389 ns |  0.0364 ns |   3.13 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     56.10 ns |  0.0458 ns |  0.0406 ns |   3.19 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     56.55 ns |  0.0667 ns |  0.0624 ns |   3.22 |     0.01 |
|                                               LinqToArray |              0 |    152.68 ns |  0.2621 ns |  0.2451 ns |   8.69 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              0 |     65.98 ns |  0.0193 ns |  0.0172 ns |   3.76 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     65.47 ns |  0.0572 ns |  0.0535 ns |   3.73 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     78.11 ns |  0.0153 ns |  0.0136 ns |   4.45 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     64.75 ns |  0.0267 ns |  0.0223 ns |   3.69 |     0.01 |
|                                                      Take |              0 |    170.84 ns |  0.2435 ns |  0.2278 ns |   9.73 |     0.02 |
|                                               LowCostTake |              0 |     75.96 ns |  0.0187 ns |  0.0166 ns |   4.33 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     66.11 ns |  0.0719 ns |  0.0672 ns |   3.76 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     76.19 ns |  0.0152 ns |  0.0135 ns |   4.34 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     81.54 ns |  0.0186 ns |  0.0155 ns |   4.64 |     0.01 |
|                                            SkipTakeSingle |              0 |    196.44 ns |  0.3816 ns |  0.3569 ns |  11.19 |     0.03 |
|                                     LowCostSkipTakeSingle |              0 |     89.78 ns |  0.1051 ns |  0.0983 ns |   5.11 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     89.65 ns |  0.0545 ns |  0.0509 ns |   5.11 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     92.31 ns |  0.0597 ns |  0.0558 ns |   5.26 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     96.97 ns |  0.0295 ns |  0.0261 ns |   5.52 |     0.01 |
|                                           ForeachDelegate |              0 |     22.02 ns |  0.0256 ns |  0.0200 ns |   1.25 |     0.00 |
|                                                   Foreach |              0 |     17.56 ns |  0.0345 ns |  0.0322 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |           **1000** | **19,494.76 ns** |  **5.6741 ns** |  **5.0299 ns** |   **3.69** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 | 16,546.39 ns |  3.7954 ns |  3.3645 ns |   3.14 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 | 15,927.67 ns | 97.3543 ns | 91.0653 ns |   3.02 |     0.02 |
|                                  LowCostLinqWithDelegate2 |           1000 | 16,682.12 ns | 30.8837 ns | 28.8887 ns |   3.16 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 | 17,279.27 ns |  8.9336 ns |  7.9194 ns |   3.27 |     0.00 |
|                                LowCostLinqWithStructWhere |           1000 |  6,277.58 ns |  1.8988 ns |  1.6832 ns |   1.19 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  6,757.48 ns |  5.3895 ns |  4.7776 ns |   1.28 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 28,670.87 ns | 21.8361 ns | 20.4255 ns |   5.43 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 28,919.92 ns | 31.4966 ns | 26.3011 ns |   5.48 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 | 13,035.25 ns |  4.0438 ns |  3.3768 ns |   2.47 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 | 12,556.45 ns |  7.4325 ns |  6.5887 ns |   2.38 |     0.00 |
|                                                 LinqCount |           1000 | 14,759.67 ns | 14.2211 ns | 13.3025 ns |   2.80 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 | 14,190.54 ns | 10.8866 ns |  9.6507 ns |   2.69 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 | 15,552.91 ns | 66.2570 ns | 61.9768 ns |   2.95 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           1000 |  5,560.95 ns |  2.6169 ns |  2.4479 ns |   1.05 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  5,565.87 ns |  2.8559 ns |  2.6714 ns |   1.05 |     0.00 |
|                                               LinqToArray |           1000 | 17,244.01 ns | 16.0866 ns | 15.0474 ns |   3.27 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 | 16,675.99 ns | 27.5240 ns | 25.7460 ns |   3.16 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 | 16,230.53 ns | 18.6769 ns | 17.4704 ns |   3.08 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  7,445.72 ns |  3.5223 ns |  2.9413 ns |   1.41 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  7,363.98 ns |  7.2946 ns |  6.0914 ns |   1.40 |     0.00 |
|                                                      Take |           1000 |    618.13 ns |  0.3775 ns |  0.3153 ns |   0.12 |     0.00 |
|                                               LowCostTake |           1000 |    437.24 ns |  0.1047 ns |  0.0929 ns |   0.08 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    395.54 ns |  0.3092 ns |  0.2892 ns |   0.07 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |    224.41 ns |  0.0333 ns |  0.0295 ns |   0.04 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |    206.54 ns |  0.0512 ns |  0.0454 ns |   0.04 |     0.00 |
|                                            SkipTakeSingle |           1000 |    592.29 ns |  1.5370 ns |  1.3625 ns |   0.11 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    457.53 ns |  0.4011 ns |  0.3752 ns |   0.09 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    462.44 ns |  0.1364 ns |  0.1276 ns |   0.09 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    276.80 ns |  0.0564 ns |  0.0440 ns |   0.05 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |    271.81 ns |  0.0869 ns |  0.0813 ns |   0.05 |     0.00 |
|                                           ForeachDelegate |           1000 | 10,995.67 ns | 96.8498 ns | 90.5933 ns |   2.08 |     0.02 |
|                                                   Foreach |           1000 |  5,276.83 ns |  3.6636 ns |  3.4269 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |              **5** |    **248.31 ns** |  **0.1291 ns** |  **0.1145 ns** |   **5.68** |     **0.01** |
|                                   LowCostLinqWithDelegate |              5 |    147.28 ns |  0.0548 ns |  0.0513 ns |   3.37 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |    145.09 ns |  0.0420 ns |  0.0372 ns |   3.32 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              5 |    176.64 ns |  0.1708 ns |  0.1514 ns |   4.04 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |    172.94 ns |  0.0755 ns |  0.0630 ns |   3.96 |     0.00 |
|                                LowCostLinqWithStructWhere |              5 |     88.72 ns |  0.0931 ns |  0.0871 ns |   2.03 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     95.36 ns |  0.0420 ns |  0.0393 ns |   2.18 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    274.47 ns |  0.1699 ns |  0.1506 ns |   6.28 |     0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    273.44 ns |  0.2082 ns |  0.1948 ns |   6.26 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    184.59 ns |  0.0421 ns |  0.0373 ns |   4.22 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    179.02 ns |  0.1526 ns |  0.1274 ns |   4.10 |     0.01 |
|                                                 LinqCount |              5 |    239.66 ns |  0.4612 ns |  0.4314 ns |   5.49 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |    140.71 ns |  0.0578 ns |  0.0512 ns |   3.22 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |    149.65 ns |  0.0309 ns |  0.0289 ns |   3.43 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              5 |     85.24 ns |  0.1438 ns |  0.1345 ns |   1.95 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     83.32 ns |  0.0694 ns |  0.0649 ns |   1.91 |     0.00 |
|                                               LinqToArray |              5 |    295.06 ns |  2.4793 ns |  2.3191 ns |   6.75 |     0.05 |
|                            LowCostLinqWithDelegateToArray |              5 |    187.23 ns |  0.0301 ns |  0.0218 ns |   4.29 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    189.05 ns |  0.0677 ns |  0.0633 ns |   4.33 |     0.00 |
|                              LowCostLinqWithStructToArray |              5 |    135.79 ns |  0.0626 ns |  0.0555 ns |   3.11 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |    130.11 ns |  0.1461 ns |  0.1057 ns |   2.98 |     0.00 |
|                                                      Take |              5 |    302.02 ns |  0.1298 ns |  0.1084 ns |   6.91 |     0.01 |
|                                               LowCostTake |              5 |    159.97 ns |  0.0362 ns |  0.0339 ns |   3.66 |     0.00 |
|                                  LowCostTakeWithoutChecks |              5 |    152.42 ns |  0.1063 ns |  0.0994 ns |   3.49 |     0.00 |
|                                     LowCostTakeWithStruct |              5 |    112.16 ns |  0.0510 ns |  0.0426 ns |   2.57 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |              5 |    101.70 ns |  0.0253 ns |  0.0224 ns |   2.33 |     0.00 |
|                                            SkipTakeSingle |              5 |    317.12 ns |  0.1933 ns |  0.1614 ns |   7.26 |     0.01 |
|                                     LowCostSkipTakeSingle |              5 |    181.94 ns |  0.1601 ns |  0.1498 ns |   4.16 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |    185.12 ns |  0.1951 ns |  0.1825 ns |   4.24 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              5 |    129.41 ns |  0.0420 ns |  0.0372 ns |   2.96 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |    129.26 ns |  0.0388 ns |  0.0363 ns |   2.96 |     0.00 |
|                                           ForeachDelegate |              5 |     76.96 ns |  0.0366 ns |  0.0306 ns |   1.76 |     0.00 |
|                                                   Foreach |              5 |     43.69 ns |  0.0504 ns |  0.0471 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |        |          |
|                                                      **Linq** |             **50** |  **1,118.46 ns** |  **0.3370 ns** |  **0.2814 ns** |   **3.86** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    884.99 ns |  0.1082 ns |  0.1012 ns |   3.06 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    863.10 ns |  0.1386 ns |  0.1229 ns |   2.98 |     0.00 |
|                                  LowCostLinqWithDelegate2 |             50 |    925.15 ns |  0.2871 ns |  0.2397 ns |   3.19 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    951.14 ns |  0.7852 ns |  0.7345 ns |   3.28 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    381.79 ns |  0.1046 ns |  0.0874 ns |   1.32 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    395.59 ns |  0.1081 ns |  0.0844 ns |   1.37 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,588.84 ns |  7.0827 ns |  6.6252 ns |   5.49 |     0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |  1,567.81 ns |  1.0173 ns |  0.9018 ns |   5.41 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    764.25 ns |  0.4074 ns |  0.3811 ns |   2.64 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    742.84 ns |  0.6764 ns |  0.6327 ns |   2.57 |     0.00 |
|                                                 LinqCount |             50 |    884.85 ns |  0.2535 ns |  0.2371 ns |   3.06 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    773.37 ns |  0.1714 ns |  0.1431 ns |   2.67 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    844.54 ns |  0.3740 ns |  0.3315 ns |   2.92 |     0.00 |
|                           LowCostLinqWithStructWhereCount |             50 |    338.71 ns |  0.1000 ns |  0.0781 ns |   1.17 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |    340.11 ns |  0.0812 ns |  0.0759 ns |   1.17 |     0.00 |
|                                               LinqToArray |             50 |  1,219.79 ns |  2.3766 ns |  2.2231 ns |   4.21 |     0.01 |
|                            LowCostLinqWithDelegateToArray |             50 |  1,050.84 ns |  0.9148 ns |  0.8109 ns |   3.63 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |  1,033.69 ns |  0.1552 ns |  0.1212 ns |   3.57 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    552.40 ns |  0.6951 ns |  0.6502 ns |   1.91 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    549.84 ns |  0.1838 ns |  0.1629 ns |   1.90 |     0.00 |
|                                                      Take |             50 |    617.80 ns |  0.3840 ns |  0.3404 ns |   2.13 |     0.00 |
|                                               LowCostTake |             50 |    445.62 ns |  0.1969 ns |  0.1746 ns |   1.54 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    395.51 ns |  0.0902 ns |  0.0753 ns |   1.37 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |    238.95 ns |  0.0575 ns |  0.0510 ns |   0.83 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |    207.06 ns |  0.1952 ns |  0.1826 ns |   0.71 |     0.00 |
|                                            SkipTakeSingle |             50 |    581.35 ns |  0.2045 ns |  0.1708 ns |   2.01 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    456.91 ns |  0.3800 ns |  0.3555 ns |   1.58 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    463.12 ns |  0.1754 ns |  0.1555 ns |   1.60 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    271.65 ns |  0.0868 ns |  0.0724 ns |   0.94 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |    261.48 ns |  0.0503 ns |  0.0446 ns |   0.90 |     0.00 |
|                                           ForeachDelegate |             50 |    584.98 ns |  0.6015 ns |  0.5626 ns |   2.02 |     0.00 |
|                                                   Foreach |             50 |    289.60 ns |  0.0903 ns |  0.0754 ns |   1.00 |     0.00 |
