``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914068 Hz, Resolution=255.4887 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |          Mean |      Error |     StdDev |        Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |--------------:|-----------:|-----------:|--------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **94.004 ns** |  **0.5088 ns** |  **0.4510 ns** |     **93.905 ns** |  **31.57** |     **0.15** |
|                                   LowCostLinqWithDelegate |              0 |     32.335 ns |  0.0144 ns |  0.0135 ns |     32.338 ns |  10.86 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     22.604 ns |  0.0090 ns |  0.0080 ns |     22.602 ns |   7.59 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              0 |     53.026 ns |  0.0140 ns |  0.0109 ns |     53.024 ns |  17.81 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     48.359 ns |  0.0039 ns |  0.0032 ns |     48.359 ns |  16.24 |     0.01 |
|                                LowCostLinqWithStructWhere |              0 |     41.524 ns |  0.0055 ns |  0.0043 ns |     41.524 ns |  13.95 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     35.312 ns |  0.0016 ns |  0.0014 ns |     35.312 ns |  11.86 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     62.319 ns |  0.0750 ns |  0.0702 ns |     62.348 ns |  20.93 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     58.369 ns |  0.0729 ns |  0.0647 ns |     58.354 ns |  19.60 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     57.552 ns |  0.1545 ns |  0.1445 ns |     57.512 ns |  19.33 |     0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     50.399 ns |  0.0229 ns |  0.0203 ns |     50.388 ns |  16.93 |     0.01 |
|                                                 LinqCount |              0 |     89.104 ns |  0.1211 ns |  0.1132 ns |     89.085 ns |  29.93 |     0.04 |
|                              LowCostLinqWithDelegateCount |              0 |     25.909 ns |  0.0205 ns |  0.0192 ns |     25.901 ns |   8.70 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     24.827 ns |  0.0195 ns |  0.0152 ns |     24.832 ns |   8.34 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              0 |     35.579 ns |  0.0044 ns |  0.0034 ns |     35.578 ns |  11.95 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     27.454 ns |  0.0019 ns |  0.0017 ns |     27.454 ns |   9.22 |     0.01 |
|                                               LinqToArray |              0 |     98.372 ns |  0.1237 ns |  0.1157 ns |     98.435 ns |  33.04 |     0.04 |
|                            LowCostLinqWithDelegateToArray |              0 |     29.192 ns |  0.0194 ns |  0.0172 ns |     29.188 ns |   9.80 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     29.671 ns |  0.0309 ns |  0.0258 ns |     29.680 ns |   9.96 |     0.01 |
|                              LowCostLinqWithStructToArray |              0 |     37.859 ns |  0.0036 ns |  0.0030 ns |     37.859 ns |  12.71 |     0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     31.136 ns |  0.0239 ns |  0.0224 ns |     31.132 ns |  10.46 |     0.01 |
|                                                      Take |              0 |    128.252 ns |  0.1358 ns |  0.1060 ns |    128.230 ns |  43.07 |     0.05 |
|                                               LowCostTake |              0 |     41.819 ns |  0.0104 ns |  0.0092 ns |     41.819 ns |  14.04 |     0.01 |
|                                  LowCostTakeWithoutChecks |              0 |     32.477 ns |  0.0139 ns |  0.0123 ns |     32.474 ns |  10.91 |     0.01 |
|                                     LowCostTakeWithStruct |              0 |     50.348 ns |  0.0029 ns |  0.0023 ns |     50.348 ns |  16.91 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     48.499 ns |  0.0126 ns |  0.0112 ns |     48.498 ns |  16.29 |     0.01 |
|                                            SkipTakeSingle |              0 |    148.426 ns |  0.0481 ns |  0.0402 ns |    148.426 ns |  49.85 |     0.04 |
|                                     LowCostSkipTakeSingle |              0 |     44.229 ns |  0.0200 ns |  0.0187 ns |     44.225 ns |  14.85 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     41.428 ns |  0.0018 ns |  0.0015 ns |     41.427 ns |  13.91 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     62.529 ns |  0.0262 ns |  0.0204 ns |     62.521 ns |  21.00 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     47.921 ns |  0.0028 ns |  0.0022 ns |     47.922 ns |  16.09 |     0.01 |
|                                           ForeachDelegate |              0 |     15.635 ns |  0.0150 ns |  0.0133 ns |     15.637 ns |   5.25 |     0.01 |
|                                                   Foreach |              0 |     11.930 ns |  0.0012 ns |  0.0009 ns |     11.930 ns |   4.01 |     0.00 |
|                                                       For |              0 |      2.978 ns |  0.0028 ns |  0.0023 ns |      2.976 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |           **1000** | **11,934.241 ns** | **13.0301 ns** | **12.1884 ns** | **11,935.313 ns** |  **47.66** |     **0.05** |
|                                   LowCostLinqWithDelegate |           1000 |  8,627.541 ns |  2.3533 ns |  1.9651 ns |  8,627.447 ns |  34.45 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  7,482.378 ns | 19.2497 ns | 17.0643 ns |  7,475.719 ns |  29.88 |     0.07 |
|                                  LowCostLinqWithDelegate2 |           1000 |  8,203.446 ns | 34.0046 ns | 31.8079 ns |  8,198.071 ns |  32.76 |     0.12 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  7,635.995 ns | 15.9240 ns | 14.8953 ns |  7,638.816 ns |  30.49 |     0.06 |
|                                LowCostLinqWithStructWhere |           1000 |  1,844.098 ns |  0.9216 ns |  0.8169 ns |  1,843.838 ns |   7.36 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,739.738 ns |  0.1135 ns |  0.1006 ns |  1,739.696 ns |   6.95 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 19,548.778 ns | 51.4132 ns | 48.0919 ns | 19,563.340 ns |  78.07 |     0.19 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 | 17,528.782 ns | 27.0198 ns | 23.9524 ns | 17,527.607 ns |  70.00 |     0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  6,798.601 ns |  4.7739 ns |  4.4655 ns |  6,797.792 ns |  27.15 |     0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  5,551.036 ns |  2.8641 ns |  2.6791 ns |  5,551.023 ns |  22.17 |     0.01 |
|                                                 LinqCount |           1000 |  6,523.313 ns | 29.4070 ns | 27.5073 ns |  6,519.623 ns |  26.05 |     0.11 |
|                              LowCostLinqWithDelegateCount |           1000 |  8,055.214 ns | 37.7365 ns | 35.2987 ns |  8,047.426 ns |  32.17 |     0.14 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  8,382.536 ns |  0.8398 ns |  0.7013 ns |  8,382.410 ns |  33.48 |     0.01 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,760.980 ns |  0.9995 ns |  0.9349 ns |  1,760.756 ns |   7.03 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,215.459 ns |  0.0765 ns |  0.0639 ns |  1,215.450 ns |   4.85 |     0.00 |
|                                               LinqToArray |           1000 |  8,921.608 ns | 11.5489 ns | 10.8028 ns |  8,922.677 ns |  35.63 |     0.04 |
|                            LowCostLinqWithDelegateToArray |           1000 | 10,531.289 ns |  2.5448 ns |  1.9868 ns | 10,531.783 ns |  42.06 |     0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  8,964.992 ns |  8.1324 ns |  7.2092 ns |  8,964.413 ns |  35.80 |     0.03 |
|                              LowCostLinqWithStructToArray |           1000 |  3,168.744 ns |  4.7176 ns |  4.1820 ns |  3,168.874 ns |  12.65 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,340.290 ns |  1.8227 ns |  1.5220 ns |  2,339.766 ns |   9.35 |     0.01 |
|                                                      Take |           1000 |    472.006 ns |  0.3949 ns |  0.3501 ns |    471.862 ns |   1.88 |     0.00 |
|                                               LowCostTake |           1000 |    217.537 ns |  0.1400 ns |  0.1309 ns |    217.485 ns |   0.87 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    192.143 ns |  0.0108 ns |  0.0084 ns |    192.142 ns |   0.77 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     90.606 ns |  0.0407 ns |  0.0361 ns |     90.609 ns |   0.36 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     89.088 ns |  0.1349 ns |  0.1261 ns |     89.072 ns |   0.36 |     0.00 |
|                                            SkipTakeSingle |           1000 |    377.897 ns |  0.1067 ns |  0.0946 ns |    377.930 ns |   1.51 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |    239.475 ns |  0.1240 ns |  0.1160 ns |    239.420 ns |   0.96 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    228.521 ns |  0.1388 ns |  0.1159 ns |    228.516 ns |   0.91 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |    106.549 ns |  0.0233 ns |  0.0168 ns |    106.546 ns |   0.43 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     74.620 ns |  0.0228 ns |  0.0190 ns |     74.612 ns |   0.30 |     0.00 |
|                                           ForeachDelegate |           1000 |  5,314.658 ns |  3.3570 ns |  3.1402 ns |  5,314.151 ns |  21.22 |     0.01 |
|                                                   Foreach |           1000 |  1,691.205 ns |  0.8019 ns |  0.7501 ns |  1,691.112 ns |   6.75 |     0.00 |
|                                                       For |           1000 |    250.402 ns |  0.0540 ns |  0.0451 ns |    250.402 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |              **5** |    **150.947 ns** |  **0.3745 ns** |  **0.3320 ns** |    **150.773 ns** |  **34.85** |     **0.09** |
|                                   LowCostLinqWithDelegate |              5 |     71.638 ns |  0.0423 ns |  0.0375 ns |     71.619 ns |  16.54 |     0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     55.905 ns |  0.0332 ns |  0.0310 ns |     55.908 ns |  12.91 |     0.02 |
|                                  LowCostLinqWithDelegate2 |              5 |     94.484 ns |  0.0772 ns |  0.0722 ns |     94.528 ns |  21.82 |     0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     79.937 ns |  0.1540 ns |  0.1440 ns |     79.859 ns |  18.46 |     0.04 |
|                                LowCostLinqWithStructWhere |              5 |     52.257 ns |  0.1092 ns |  0.1021 ns |     52.336 ns |  12.07 |     0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     44.737 ns |  0.0311 ns |  0.0259 ns |     44.744 ns |  10.33 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    173.037 ns |  0.2151 ns |  0.2012 ns |    173.119 ns |  39.96 |     0.07 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    149.736 ns |  0.3793 ns |  0.3548 ns |    149.809 ns |  34.57 |     0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |     87.837 ns |  0.2414 ns |  0.2258 ns |     87.780 ns |  20.28 |     0.06 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |     77.057 ns |  0.0383 ns |  0.0320 ns |     77.050 ns |  17.79 |     0.02 |
|                                                 LinqCount |              5 |    120.215 ns |  0.1169 ns |  0.1093 ns |    120.263 ns |  27.76 |     0.04 |
|                              LowCostLinqWithDelegateCount |              5 |     65.897 ns |  0.0739 ns |  0.0691 ns |     65.906 ns |  15.22 |     0.02 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     63.931 ns |  0.1818 ns |  0.1700 ns |     64.048 ns |  14.76 |     0.04 |
|                           LowCostLinqWithStructWhereCount |              5 |     43.948 ns |  0.0145 ns |  0.0135 ns |     43.948 ns |  10.15 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     32.350 ns |  0.0118 ns |  0.0110 ns |     32.351 ns |   7.47 |     0.01 |
|                                               LinqToArray |              5 |    182.696 ns |  0.2021 ns |  0.1890 ns |    182.596 ns |  42.19 |     0.07 |
|                            LowCostLinqWithDelegateToArray |              5 |    114.731 ns |  0.1131 ns |  0.1003 ns |    114.707 ns |  26.49 |     0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |    104.764 ns |  0.0967 ns |  0.0905 ns |    104.738 ns |  24.19 |     0.04 |
|                              LowCostLinqWithStructToArray |              5 |     81.518 ns |  0.0810 ns |  0.0757 ns |     81.501 ns |  18.82 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     68.443 ns |  0.0495 ns |  0.0439 ns |     68.436 ns |  15.80 |     0.02 |
|                                                      Take |              5 |    229.465 ns |  0.4574 ns |  0.4279 ns |    229.686 ns |  52.98 |     0.12 |
|                                               LowCostTake |              5 |     74.819 ns |  0.0358 ns |  0.0318 ns |     74.824 ns |  17.28 |     0.02 |
|                                  LowCostTakeWithoutChecks |              5 |     67.990 ns |  0.0421 ns |  0.0394 ns |     67.971 ns |  15.70 |     0.02 |
|                                     LowCostTakeWithStruct |              5 |     60.074 ns |  0.0324 ns |  0.0253 ns |     60.071 ns |  13.87 |     0.02 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     51.294 ns |  0.0081 ns |  0.0076 ns |     51.294 ns |  11.84 |     0.01 |
|                                            SkipTakeSingle |              5 |    202.241 ns |  0.1209 ns |  0.1131 ns |    202.290 ns |  46.70 |     0.06 |
|                                     LowCostSkipTakeSingle |              5 |     78.871 ns |  0.0494 ns |  0.0462 ns |     78.884 ns |  18.21 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     70.012 ns |  0.0408 ns |  0.0341 ns |     70.006 ns |  16.17 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     65.635 ns |  0.0190 ns |  0.0158 ns |     65.635 ns |  15.16 |     0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     53.925 ns |  0.0208 ns |  0.0174 ns |     53.923 ns |  12.45 |     0.02 |
|                                           ForeachDelegate |              5 |     43.002 ns |  0.0217 ns |  0.0192 ns |     43.004 ns |   9.93 |     0.01 |
|                                                   Foreach |              5 |     19.684 ns |  0.0117 ns |  0.0091 ns |     19.684 ns |   4.55 |     0.01 |
|                                                       For |              5 |      4.331 ns |  0.0060 ns |  0.0056 ns |      4.328 ns |   1.00 |     0.00 |
|                                                           |                |               |            |            |               |        |          |
|                                                      **Linq** |             **50** |    **693.095 ns** |  **0.2852 ns** |  **0.2668 ns** |    **693.009 ns** |  **38.63** |     **0.05** |
|                                   LowCostLinqWithDelegate |             50 |    461.305 ns |  0.0998 ns |  0.0934 ns |    461.326 ns |  25.71 |     0.03 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    403.930 ns |  0.5071 ns |  0.4495 ns |    404.071 ns |  22.51 |     0.04 |
|                                  LowCostLinqWithDelegate2 |             50 |    479.481 ns |  0.5470 ns |  0.5117 ns |    479.627 ns |  26.72 |     0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    423.777 ns |  0.3245 ns |  0.2877 ns |    423.786 ns |  23.62 |     0.03 |
|                                LowCostLinqWithStructWhere |             50 |    139.761 ns |  0.0305 ns |  0.0238 ns |    139.760 ns |   7.79 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    120.394 ns |  0.0163 ns |  0.0144 ns |    120.396 ns |   6.71 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |  1,055.613 ns |  0.8070 ns |  0.7549 ns |  1,055.682 ns |  58.83 |     0.09 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    950.299 ns |  0.4918 ns |  0.4600 ns |    950.208 ns |  52.96 |     0.07 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    395.445 ns |  0.3057 ns |  0.2860 ns |    395.406 ns |  22.04 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    332.877 ns |  0.3134 ns |  0.2931 ns |    332.795 ns |  18.55 |     0.03 |
|                                                 LinqCount |             50 |    416.766 ns |  0.3177 ns |  0.2817 ns |    416.714 ns |  23.23 |     0.03 |
|                              LowCostLinqWithDelegateCount |             50 |    432.143 ns |  0.4404 ns |  0.4119 ns |    432.100 ns |  24.09 |     0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    445.902 ns |  0.0573 ns |  0.0536 ns |    445.922 ns |  24.85 |     0.03 |
|                           LowCostLinqWithStructWhereCount |             50 |    130.664 ns |  0.1737 ns |  0.1625 ns |    130.726 ns |   7.28 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     81.983 ns |  0.0679 ns |  0.0635 ns |     82.007 ns |   4.57 |     0.01 |
|                                               LinqToArray |             50 |    734.840 ns |  0.4563 ns |  0.4268 ns |    734.825 ns |  40.96 |     0.06 |
|                            LowCostLinqWithDelegateToArray |             50 |    666.819 ns |  0.3573 ns |  0.3342 ns |    666.956 ns |  37.16 |     0.05 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    582.140 ns |  0.2433 ns |  0.2032 ns |    582.181 ns |  32.44 |     0.04 |
|                              LowCostLinqWithStructToArray |             50 |    270.450 ns |  0.3540 ns |  0.3311 ns |    270.297 ns |  15.07 |     0.03 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    223.128 ns |  0.3195 ns |  0.2989 ns |    223.033 ns |  12.44 |     0.02 |
|                                                      Take |             50 |    471.723 ns |  0.0919 ns |  0.0717 ns |    471.715 ns |  26.29 |     0.03 |
|                                               LowCostTake |             50 |    218.542 ns |  0.0113 ns |  0.0094 ns |    218.540 ns |  12.18 |     0.02 |
|                                  LowCostTakeWithoutChecks |             50 |    192.113 ns |  0.0797 ns |  0.0665 ns |    192.098 ns |  10.71 |     0.01 |
|                                     LowCostTakeWithStruct |             50 |    101.114 ns |  0.0078 ns |  0.0065 ns |    101.114 ns |   5.64 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     80.325 ns |  0.1153 ns |  0.0963 ns |     80.289 ns |   4.48 |     0.01 |
|                                            SkipTakeSingle |             50 |    376.803 ns |  0.1247 ns |  0.0974 ns |    376.791 ns |  21.00 |     0.03 |
|                                     LowCostSkipTakeSingle |             50 |    233.782 ns |  0.1927 ns |  0.1708 ns |    233.758 ns |  13.03 |     0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    222.613 ns |  0.0551 ns |  0.0399 ns |    222.627 ns |  12.41 |     0.02 |
|                           LowCostSkipTakeSingleWithStruct |             50 |    107.143 ns |  0.0839 ns |  0.0784 ns |    107.125 ns |   5.97 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     77.137 ns |  0.0096 ns |  0.0069 ns |     77.137 ns |   4.30 |     0.01 |
|                                           ForeachDelegate |             50 |    289.941 ns |  0.1152 ns |  0.0962 ns |    289.976 ns |  16.16 |     0.02 |
|                                                   Foreach |             50 |    102.384 ns |  0.0189 ns |  0.0147 ns |    102.382 ns |   5.71 |     0.01 |
|                                                       For |             50 |     17.942 ns |  0.0255 ns |  0.0238 ns |     17.941 ns |   1.00 |     0.00 |
