``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |          Mean |     Error |    StdDev |  Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |--------------:|----------:|----------:|-------:|--------:|
|                                                      **Linq** |            **[0]** |    **25.1108 ns** | **0.0306 ns** | **0.0286 ns** |  **77.01** |    **0.15** |
|                                   LowCostLinqWithDelegate |            [0] |    14.9314 ns | 0.0005 ns | 0.0004 ns |  45.79 |    0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     9.6460 ns | 0.0003 ns | 0.0003 ns |  29.58 |    0.05 |
|                                  LowCostLinqWithDelegate2 |            [0] |    21.3610 ns | 0.0004 ns | 0.0004 ns |  65.51 |    0.12 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |    17.2673 ns | 0.0006 ns | 0.0006 ns |  52.95 |    0.09 |
|                                LowCostLinqWithStructWhere |            [0] |    19.2440 ns | 0.0032 ns | 0.0030 ns |  59.01 |    0.11 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |    14.4093 ns | 0.0005 ns | 0.0005 ns |  44.19 |    0.08 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    24.5572 ns | 0.0094 ns | 0.0083 ns |  75.31 |    0.14 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    22.2597 ns | 0.0168 ns | 0.0140 ns |  68.26 |    0.16 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    22.8841 ns | 0.0174 ns | 0.0154 ns |  70.18 |    0.12 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    21.1464 ns | 0.0130 ns | 0.0109 ns |  64.84 |    0.12 |
|                                                 LinqCount |            [0] |    21.5380 ns | 0.0068 ns | 0.0061 ns |  66.05 |    0.13 |
|                              LowCostLinqWithDelegateCount |            [0] |     9.3004 ns | 0.0091 ns | 0.0076 ns |  28.52 |    0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     7.3794 ns | 0.0066 ns | 0.0058 ns |  22.63 |    0.04 |
|                           LowCostLinqWithStructWhereCount |            [0] |     7.9807 ns | 0.0007 ns | 0.0006 ns |  24.47 |    0.05 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     7.5023 ns | 0.0003 ns | 0.0002 ns |  23.01 |    0.04 |
|                                               LinqToArray |            [0] |    22.8601 ns | 0.0118 ns | 0.0098 ns |  70.10 |    0.14 |
|                            LowCostLinqWithDelegateToArray |            [0] |    10.9040 ns | 0.0170 ns | 0.0151 ns |  33.44 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |    10.9954 ns | 0.0038 ns | 0.0029 ns |  33.72 |    0.07 |
|                              LowCostLinqWithStructToArray |            [0] |    12.3767 ns | 0.0343 ns | 0.0321 ns |  37.95 |    0.12 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     9.9463 ns | 0.0028 ns | 0.0023 ns |  30.50 |    0.06 |
|                                                      Take |            [0] |    47.0551 ns | 0.0103 ns | 0.0086 ns | 144.29 |    0.27 |
|                                               LowCostTake |            [0] |    21.3911 ns | 0.0072 ns | 0.0068 ns |  65.60 |    0.12 |
|                                  LowCostTakeWithoutChecks |            [0] |    15.3947 ns | 0.0018 ns | 0.0017 ns |  47.21 |    0.09 |
|                                     LowCostTakeWithStruct |            [0] |    25.8898 ns | 0.0008 ns | 0.0007 ns |  79.39 |    0.15 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |    20.5125 ns | 0.0005 ns | 0.0004 ns |  62.90 |    0.11 |
|                                            SkipTakeSingle |            [0] |    66.1189 ns | 0.0123 ns | 0.0103 ns | 202.75 |    0.38 |
|                                     LowCostSkipTakeSingle |            [0] |    20.8092 ns | 0.0019 ns | 0.0017 ns |  63.81 |    0.11 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |    20.2916 ns | 0.0027 ns | 0.0024 ns |  62.23 |    0.11 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |    26.1528 ns | 0.0009 ns | 0.0008 ns |  80.20 |    0.14 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |    25.4347 ns | 0.0011 ns | 0.0010 ns |  78.00 |    0.14 |
|                                           ForeachDelegate |            [0] |     2.1048 ns | 0.0001 ns | 0.0001 ns |   6.45 |    0.01 |
|                                                   Foreach |            [0] |     0.9914 ns | 0.0012 ns | 0.0011 ns |   3.04 |    0.01 |
|                                                       For |            [0] |     0.3261 ns | 0.0007 ns | 0.0006 ns |   1.00 |    0.00 |
|                                                           |                |               |           |           |        |         |
|                                                      **Linq** |         **[1000]** | **5,305.4975 ns** | **5.8881 ns** | **5.5078 ns** |  **21.38** |    **0.02** |
|                                   LowCostLinqWithDelegate |         [1000] | 2,447.8327 ns | 3.2802 ns | 3.0683 ns |   9.87 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 2,207.6708 ns | 0.0811 ns | 0.0719 ns |   8.90 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 2,450.3981 ns | 2.2854 ns | 2.1377 ns |   9.88 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 2,452.5898 ns | 8.1870 ns | 7.6581 ns |   9.88 |    0.03 |
|                                LowCostLinqWithStructWhere |         [1000] | 1,557.9134 ns | 0.1276 ns | 0.1065 ns |   6.28 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] | 1,293.3605 ns | 1.4538 ns | 1.2887 ns |   5.21 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 5,282.5986 ns | 4.2373 ns | 3.9636 ns |  21.29 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 4,807.2417 ns | 0.2135 ns | 0.1893 ns |  19.37 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 4,182.9953 ns | 2.8252 ns | 2.3592 ns |  16.86 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] | 3,834.5682 ns | 2.1765 ns | 1.9294 ns |  15.45 |    0.01 |
|                                                 LinqCount |         [1000] | 1,708.7707 ns | 2.2436 ns | 1.9889 ns |   6.89 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 1,683.2257 ns | 1.2975 ns | 1.0835 ns |   6.78 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 1,919.2679 ns | 0.1412 ns | 0.1252 ns |   7.74 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |   613.4957 ns | 0.0646 ns | 0.0505 ns |   2.47 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |   493.3630 ns | 0.1106 ns | 0.0923 ns |   1.99 |    0.00 |
|                                               LinqToArray |         [1000] | 3,070.3238 ns | 1.3001 ns | 1.1525 ns |  12.37 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 2,560.5112 ns | 2.7174 ns | 2.2691 ns |  10.32 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 2,803.1822 ns | 1.9063 ns | 1.6899 ns |  11.30 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] | 1,830.1056 ns | 2.5593 ns | 2.3940 ns |   7.38 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] | 1,587.4730 ns | 1.0540 ns | 0.9344 ns |   6.40 |    0.00 |
|                                                      Take |         [1000] |   251.0169 ns | 0.0250 ns | 0.0196 ns |   1.01 |    0.00 |
|                                               LowCostTake |         [1000] |    78.0511 ns | 0.0086 ns | 0.0081 ns |   0.31 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    69.9340 ns | 0.0246 ns | 0.0218 ns |   0.28 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    62.0637 ns | 0.0477 ns | 0.0446 ns |   0.25 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    51.3597 ns | 0.0277 ns | 0.0259 ns |   0.21 |    0.00 |
|                                            SkipTakeSingle |         [1000] |   168.0742 ns | 0.0217 ns | 0.0192 ns |   0.68 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    73.8006 ns | 0.0597 ns | 0.0558 ns |   0.30 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    74.8149 ns | 0.0460 ns | 0.0430 ns |   0.30 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    54.0325 ns | 0.0293 ns | 0.0274 ns |   0.22 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    51.7420 ns | 0.0187 ns | 0.0175 ns |   0.21 |    0.00 |
|                                           ForeachDelegate |         [1000] | 1,917.8708 ns | 0.0404 ns | 0.0358 ns |   7.73 |    0.00 |
|                                                   Foreach |         [1000] |   485.0878 ns | 0.7934 ns | 0.7421 ns |   1.96 |    0.00 |
|                                                       For |         [1000] |   248.1226 ns | 0.0204 ns | 0.0190 ns |   1.00 |    0.00 |
|                                                           |                |               |           |           |        |         |
|                                                      **Linq** |           **[50]** |   **312.2823 ns** | **0.1812 ns** | **0.1606 ns** |  **21.49** |    **0.04** |
|                                   LowCostLinqWithDelegate |           [50] |   150.4306 ns | 0.1159 ns | 0.1084 ns |  10.35 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |   124.9922 ns | 0.0260 ns | 0.0231 ns |   8.60 |    0.02 |
|                                  LowCostLinqWithDelegate2 |           [50] |   145.2707 ns | 0.0993 ns | 0.0929 ns |  10.00 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |   139.4444 ns | 0.3439 ns | 0.3217 ns |   9.60 |    0.04 |
|                                LowCostLinqWithStructWhere |           [50] |   101.4898 ns | 0.0176 ns | 0.0156 ns |   6.98 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    88.4658 ns | 0.4526 ns | 0.4234 ns |   6.09 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |   271.5946 ns | 0.0637 ns | 0.0532 ns |  18.68 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |   270.8192 ns | 0.1043 ns | 0.0924 ns |  18.63 |    0.04 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   247.7951 ns | 0.0643 ns | 0.0570 ns |  17.05 |    0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |   225.0498 ns | 0.0434 ns | 0.0362 ns |  15.48 |    0.03 |
|                                                 LinqCount |           [50] |   110.6926 ns | 0.0494 ns | 0.0438 ns |   7.62 |    0.02 |
|                              LowCostLinqWithDelegateCount |           [50] |   107.5066 ns | 0.4221 ns | 0.3949 ns |   7.40 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    96.4298 ns | 0.0687 ns | 0.0574 ns |   6.63 |    0.01 |
|                           LowCostLinqWithStructWhereCount |           [50] |    40.4175 ns | 0.0890 ns | 0.0832 ns |   2.78 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    31.6649 ns | 0.0385 ns | 0.0360 ns |   2.18 |    0.01 |
|                                               LinqToArray |           [50] |   256.1681 ns | 0.4344 ns | 0.4064 ns |  17.63 |    0.05 |
|                            LowCostLinqWithDelegateToArray |           [50] |   208.4385 ns | 0.2487 ns | 0.2327 ns |  14.35 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |   195.8777 ns | 0.1474 ns | 0.1307 ns |  13.48 |    0.03 |
|                              LowCostLinqWithStructToArray |           [50] |   141.5132 ns | 0.6930 ns | 0.6482 ns |   9.74 |    0.05 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |   129.1322 ns | 0.1573 ns | 0.1471 ns |   8.89 |    0.02 |
|                                                      Take |           [50] |   250.3732 ns | 0.0776 ns | 0.0688 ns |  17.23 |    0.03 |
|                                               LowCostTake |           [50] |    77.9043 ns | 0.0239 ns | 0.0224 ns |   5.36 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    69.8877 ns | 0.0305 ns | 0.0255 ns |   4.81 |    0.01 |
|                                     LowCostTakeWithStruct |           [50] |    62.9093 ns | 0.0387 ns | 0.0362 ns |   4.33 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    51.6576 ns | 0.0261 ns | 0.0244 ns |   3.56 |    0.01 |
|                                            SkipTakeSingle |           [50] |   167.8122 ns | 0.0272 ns | 0.0241 ns |  11.55 |    0.02 |
|                                     LowCostSkipTakeSingle |           [50] |    73.5577 ns | 0.0392 ns | 0.0348 ns |   5.06 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    75.2329 ns | 0.0343 ns | 0.0321 ns |   5.18 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    53.9755 ns | 0.0529 ns | 0.0495 ns |   3.72 |    0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    51.7289 ns | 0.0040 ns | 0.0031 ns |   3.56 |    0.01 |
|                                           ForeachDelegate |           [50] |   106.3984 ns | 0.0155 ns | 0.0130 ns |   7.32 |    0.01 |
|                                                   Foreach |           [50] |    23.2998 ns | 0.0132 ns | 0.0117 ns |   1.60 |    0.00 |
|                                                       For |           [50] |    14.5286 ns | 0.0364 ns | 0.0340 ns |   1.00 |    0.00 |
|                                                           |                |               |           |           |        |         |
|                                                      **Linq** |            **[5]** |    **56.1415 ns** | **0.0616 ns** | **0.0576 ns** |  **27.41** |    **0.08** |
|                                   LowCostLinqWithDelegate |            [5] |    28.5504 ns | 0.0318 ns | 0.0298 ns |  13.94 |    0.04 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    22.5767 ns | 0.0171 ns | 0.0160 ns |  11.02 |    0.03 |
|                                  LowCostLinqWithDelegate2 |            [5] |    33.9605 ns | 0.0269 ns | 0.0251 ns |  16.58 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    31.3487 ns | 0.0196 ns | 0.0184 ns |  15.31 |    0.04 |
|                                LowCostLinqWithStructWhere |            [5] |    29.4402 ns | 0.0007 ns | 0.0006 ns |  14.37 |    0.04 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |    22.0349 ns | 0.0010 ns | 0.0009 ns |  10.76 |    0.03 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    48.6693 ns | 0.0422 ns | 0.0394 ns |  23.76 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    46.3377 ns | 0.0516 ns | 0.0458 ns |  22.62 |    0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    44.4652 ns | 0.2802 ns | 0.2621 ns |  21.71 |    0.14 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    39.2156 ns | 0.0515 ns | 0.0482 ns |  19.15 |    0.06 |
|                                                 LinqCount |            [5] |    29.7419 ns | 0.0439 ns | 0.0410 ns |  14.52 |    0.05 |
|                              LowCostLinqWithDelegateCount |            [5] |    17.5461 ns | 0.0090 ns | 0.0071 ns |   8.56 |    0.03 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    17.0098 ns | 0.0210 ns | 0.0196 ns |   8.30 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [5] |    12.3622 ns | 0.0006 ns | 0.0005 ns |   6.04 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |    10.2761 ns | 0.0019 ns | 0.0015 ns |   5.02 |    0.02 |
|                                               LinqToArray |            [5] |    62.4195 ns | 0.0402 ns | 0.0357 ns |  30.48 |    0.10 |
|                            LowCostLinqWithDelegateToArray |            [5] |    50.4293 ns | 0.0376 ns | 0.0352 ns |  24.62 |    0.07 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    48.0168 ns | 0.0223 ns | 0.0198 ns |  23.44 |    0.07 |
|                              LowCostLinqWithStructToArray |            [5] |    41.4283 ns | 0.0105 ns | 0.0093 ns |  20.23 |    0.06 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    39.6247 ns | 0.0066 ns | 0.0058 ns |  19.35 |    0.06 |
|                                                      Take |            [5] |    98.6340 ns | 0.0548 ns | 0.0486 ns |  48.16 |    0.13 |
|                                               LowCostTake |            [5] |    34.8673 ns | 0.0254 ns | 0.0237 ns |  17.02 |    0.05 |
|                                  LowCostTakeWithoutChecks |            [5] |    29.7965 ns | 0.0197 ns | 0.0185 ns |  14.55 |    0.04 |
|                                     LowCostTakeWithStruct |            [5] |    35.3492 ns | 0.0012 ns | 0.0011 ns |  17.26 |    0.05 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |    29.9657 ns | 0.0006 ns | 0.0005 ns |  14.63 |    0.05 |
|                                            SkipTakeSingle |            [5] |    88.6913 ns | 0.0433 ns | 0.0384 ns |  43.30 |    0.13 |
|                                     LowCostSkipTakeSingle |            [5] |    29.3032 ns | 0.0394 ns | 0.0329 ns |  14.31 |    0.05 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    28.0800 ns | 0.0173 ns | 0.0162 ns |  13.71 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    30.9767 ns | 0.0016 ns | 0.0014 ns |  15.12 |    0.05 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |    30.3394 ns | 0.0021 ns | 0.0017 ns |  14.81 |    0.05 |
|                                           ForeachDelegate |            [5] |    11.7115 ns | 0.0190 ns | 0.0168 ns |   5.72 |    0.02 |
|                                                   Foreach |            [5] |     4.1624 ns | 0.0141 ns | 0.0132 ns |   2.03 |    0.01 |
|                                                       For |            [5] |     2.0482 ns | 0.0063 ns | 0.0059 ns |   1.00 |    0.00 |
