``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |     **35.91 ns** |  **0.0169 ns** |  **0.0141 ns** |     **35.90 ns** |  **2.12** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [0] |     34.75 ns |  0.0161 ns |  0.0135 ns |     34.74 ns |  2.06 |    0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     28.67 ns |  0.0045 ns |  0.0040 ns |     28.67 ns |  1.70 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [0] |     41.83 ns |  0.0115 ns |  0.0102 ns |     41.83 ns |  2.48 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     37.46 ns |  0.0478 ns |  0.0423 ns |     37.46 ns |  2.22 |    0.00 |
|                                LowCostLinqWithStructWhere |            [0] |     36.80 ns |  0.1782 ns |  0.1580 ns |     36.72 ns |  2.18 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     30.28 ns |  0.0260 ns |  0.0217 ns |     30.29 ns |  1.79 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     82.71 ns |  0.0214 ns |  0.0200 ns |     82.71 ns |  4.89 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     73.51 ns |  0.0248 ns |  0.0232 ns |     73.51 ns |  4.35 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     85.63 ns |  0.0441 ns |  0.0344 ns |     85.63 ns |  5.07 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     74.45 ns |  0.0268 ns |  0.0224 ns |     74.45 ns |  4.41 |    0.00 |
|                                                 LinqCount |            [0] |     32.68 ns |  0.0558 ns |  0.0522 ns |     32.67 ns |  1.93 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [0] |     30.97 ns |  0.0853 ns |  0.0798 ns |     30.96 ns |  1.83 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     29.45 ns |  0.3607 ns |  0.3374 ns |     29.61 ns |  1.74 |    0.02 |
|                           LowCostLinqWithStructWhereCount |            [0] |     29.46 ns |  0.0203 ns |  0.0158 ns |     29.46 ns |  1.74 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     21.88 ns |  0.0141 ns |  0.0132 ns |     21.88 ns |  1.29 |    0.00 |
|                                               LinqToArray |            [0] |     46.67 ns |  0.0246 ns |  0.0218 ns |     46.68 ns |  2.76 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [0] |     42.74 ns |  0.0648 ns |  0.0541 ns |     42.74 ns |  2.53 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     40.74 ns |  0.0529 ns |  0.0495 ns |     40.76 ns |  2.41 |    0.00 |
|                              LowCostLinqWithStructToArray |            [0] |     39.06 ns |  0.0152 ns |  0.0127 ns |     39.07 ns |  2.31 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     32.13 ns |  0.5694 ns |  0.5326 ns |     32.15 ns |  1.90 |    0.03 |
|                                                      Take |            [0] |     68.25 ns |  0.0256 ns |  0.0227 ns |     68.25 ns |  4.04 |    0.00 |
|                                               LowCostTake |            [0] |     41.53 ns |  0.0178 ns |  0.0166 ns |     41.53 ns |  2.46 |    0.00 |
|                                  LowCostTakeWithoutChecks |            [0] |     37.43 ns |  0.0305 ns |  0.0285 ns |     37.42 ns |  2.21 |    0.00 |
|                                     LowCostTakeWithStruct |            [0] |     43.56 ns |  0.0506 ns |  0.0395 ns |     43.55 ns |  2.58 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     39.20 ns |  0.1036 ns |  0.0969 ns |     39.25 ns |  2.32 |    0.01 |
|                                            SkipTakeSingle |            [0] |     92.48 ns |  0.0245 ns |  0.0230 ns |     92.48 ns |  5.47 |    0.00 |
|                                     LowCostSkipTakeSingle |            [0] |     47.25 ns |  0.4356 ns |  0.4075 ns |     46.92 ns |  2.80 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     44.39 ns |  0.0063 ns |  0.0059 ns |     44.39 ns |  2.63 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     49.60 ns |  0.0057 ns |  0.0053 ns |     49.60 ns |  2.94 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     42.23 ns |  0.0068 ns |  0.0057 ns |     42.23 ns |  2.50 |    0.00 |
|                                           ForeachDelegate |            [0] |     19.25 ns |  0.0046 ns |  0.0041 ns |     19.25 ns |  1.14 |    0.00 |
|                                                   Foreach |            [0] |     16.90 ns |  0.0092 ns |  0.0086 ns |     16.90 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |         **[1000]** |  **6,751.33 ns** |  **4.6076 ns** |  **4.0845 ns** |  **6,749.50 ns** |  **1.22** |    **0.00** |
|                                   LowCostLinqWithDelegate |         [1000] |  4,394.29 ns | 70.8666 ns | 66.2886 ns |  4,338.67 ns |  0.80 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  3,611.76 ns |  1.9637 ns |  1.6398 ns |  3,612.35 ns |  0.65 |    0.00 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  4,579.08 ns |  3.0149 ns |  2.8202 ns |  4,579.50 ns |  0.83 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  3,859.36 ns |  1.7671 ns |  1.6529 ns |  3,859.41 ns |  0.70 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,698.92 ns | 28.0647 ns | 26.2517 ns |  2,683.16 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,802.45 ns |  0.3217 ns |  0.3009 ns |  1,802.38 ns |  0.33 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 11,337.77 ns |  6.3642 ns |  5.6417 ns | 11,336.90 ns |  2.06 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 10,602.83 ns |  5.2812 ns |  4.9400 ns | 10,603.56 ns |  1.92 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  8,749.94 ns | 90.9199 ns | 85.0465 ns |  8,703.67 ns |  1.59 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,456.06 ns |  2.7272 ns |  2.5510 ns |  8,455.22 ns |  1.53 |    0.00 |
|                                                 LinqCount |         [1000] |  2,019.17 ns | 16.4728 ns | 15.4086 ns |  2,024.28 ns |  0.37 |    0.00 |
|                              LowCostLinqWithDelegateCount |         [1000] |  3,615.18 ns |  1.7517 ns |  1.6386 ns |  3,615.13 ns |  0.66 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  2,452.77 ns | 37.0010 ns | 34.6108 ns |  2,454.42 ns |  0.44 |    0.01 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,733.62 ns |  0.3639 ns |  0.3226 ns |  1,733.61 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,214.73 ns |  2.2533 ns |  2.1078 ns |  1,215.79 ns |  0.22 |    0.00 |
|                                               LinqToArray |         [1000] |  3,212.64 ns | 61.8127 ns | 57.8197 ns |  3,176.85 ns |  0.58 |    0.01 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  5,308.98 ns |  3.5803 ns |  3.3490 ns |  5,309.30 ns |  0.96 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  4,099.65 ns |  5.6416 ns |  5.2772 ns |  4,099.06 ns |  0.74 |    0.00 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,423.21 ns |  6.7657 ns |  5.9976 ns |  3,424.84 ns |  0.62 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,580.00 ns | 47.7999 ns | 44.7121 ns |  2,581.72 ns |  0.47 |    0.01 |
|                                                      Take |         [1000] |    332.67 ns |  0.0909 ns |  0.0851 ns |    332.68 ns |  0.06 |    0.00 |
|                                               LowCostTake |         [1000] |    151.68 ns |  0.2388 ns |  0.2234 ns |    151.69 ns |  0.03 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    121.93 ns |  0.0942 ns |  0.0835 ns |    121.92 ns |  0.02 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    109.22 ns |  0.0534 ns |  0.0446 ns |    109.24 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     90.47 ns |  0.0711 ns |  0.0665 ns |     90.46 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    224.91 ns |  0.0327 ns |  0.0273 ns |    224.91 ns |  0.04 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    135.06 ns |  2.0112 ns |  1.8813 ns |    135.20 ns |  0.02 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    109.42 ns |  0.0523 ns |  0.0436 ns |    109.41 ns |  0.02 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     91.97 ns |  0.0474 ns |  0.0420 ns |     91.99 ns |  0.02 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     62.51 ns |  0.0920 ns |  0.0860 ns |     62.51 ns |  0.01 |    0.00 |
|                                           ForeachDelegate |         [1000] |  6,736.45 ns |  8.2843 ns |  7.7492 ns |  6,738.99 ns |  1.22 |    0.00 |
|                                                   Foreach |         [1000] |  5,516.98 ns |  1.3776 ns |  1.2886 ns |  5,516.73 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |           **[50]** |    **402.78 ns** |  **0.2934 ns** |  **0.2744 ns** |    **402.84 ns** |  **1.33** |    **0.00** |
|                                   LowCostLinqWithDelegate |           [50] |    256.22 ns |  2.7162 ns |  2.5407 ns |    257.07 ns |  0.84 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    213.45 ns |  0.1889 ns |  0.1767 ns |    213.52 ns |  0.70 |    0.00 |
|                                  LowCostLinqWithDelegate2 |           [50] |    272.23 ns |  0.2824 ns |  0.2642 ns |    272.25 ns |  0.90 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    233.72 ns |  2.3852 ns |  2.2311 ns |    232.23 ns |  0.77 |    0.01 |
|                                LowCostLinqWithStructWhere |           [50] |    176.01 ns |  0.4598 ns |  0.4301 ns |    175.70 ns |  0.58 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    129.97 ns |  0.0603 ns |  0.0564 ns |    129.97 ns |  0.43 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    669.66 ns |  0.3431 ns |  0.3209 ns |    669.76 ns |  2.20 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    625.45 ns |  9.5521 ns |  8.9351 ns |    620.71 ns |  2.06 |    0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    528.96 ns |  0.1705 ns |  0.1594 ns |    528.92 ns |  1.74 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    501.92 ns |  0.1159 ns |  0.1084 ns |    501.87 ns |  1.65 |    0.00 |
|                                                 LinqCount |           [50] |    136.25 ns |  0.2328 ns |  0.2178 ns |    136.18 ns |  0.45 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    219.96 ns |  2.4441 ns |  2.2862 ns |    218.49 ns |  0.72 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    154.98 ns |  0.3736 ns |  0.3495 ns |    155.20 ns |  0.51 |    0.00 |
|                           LowCostLinqWithStructWhereCount |           [50] |    125.22 ns |  0.1998 ns |  0.1869 ns |    125.26 ns |  0.41 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     74.26 ns |  0.0387 ns |  0.0362 ns |     74.27 ns |  0.24 |    0.00 |
|                                               LinqToArray |           [50] |    364.59 ns |  0.0965 ns |  0.0753 ns |    364.59 ns |  1.20 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    392.26 ns |  0.4005 ns |  0.3746 ns |    392.32 ns |  1.29 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    318.22 ns |  0.0700 ns |  0.0655 ns |    318.22 ns |  1.05 |    0.00 |
|                              LowCostLinqWithStructToArray |           [50] |    274.08 ns |  0.1613 ns |  0.1509 ns |    274.11 ns |  0.90 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    224.27 ns |  0.3416 ns |  0.3195 ns |    224.12 ns |  0.74 |    0.00 |
|                                                      Take |           [50] |    333.37 ns |  0.3933 ns |  0.3679 ns |    333.45 ns |  1.10 |    0.00 |
|                                               LowCostTake |           [50] |    151.95 ns |  0.0621 ns |  0.0581 ns |    151.96 ns |  0.50 |    0.00 |
|                                  LowCostTakeWithoutChecks |           [50] |    120.17 ns |  0.1482 ns |  0.1387 ns |    120.19 ns |  0.40 |    0.00 |
|                                     LowCostTakeWithStruct |           [50] |    110.00 ns |  0.0358 ns |  0.0335 ns |    110.00 ns |  0.36 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     86.40 ns |  0.2105 ns |  0.1969 ns |     86.54 ns |  0.28 |    0.00 |
|                                            SkipTakeSingle |           [50] |    224.88 ns |  0.0319 ns |  0.0266 ns |    224.89 ns |  0.74 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    133.58 ns |  1.2959 ns |  1.2122 ns |    132.94 ns |  0.44 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    110.75 ns |  0.0635 ns |  0.0594 ns |    110.74 ns |  0.36 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     91.47 ns |  0.1364 ns |  0.1276 ns |     91.46 ns |  0.30 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     64.54 ns |  0.7673 ns |  0.7177 ns |     64.16 ns |  0.21 |    0.00 |
|                                           ForeachDelegate |           [50] |    363.53 ns |  0.0602 ns |  0.0563 ns |    363.52 ns |  1.20 |    0.00 |
|                                                   Foreach |           [50] |    303.78 ns |  0.0807 ns |  0.0755 ns |    303.77 ns |  1.00 |    0.00 |
|                                                           |                |              |            |            |              |       |         |
|                                                      **Linq** |            **[5]** |     **72.80 ns** |  **0.0575 ns** |  **0.0449 ns** |     **72.80 ns** |  **1.67** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |     56.84 ns |  0.5421 ns |  0.5071 ns |     56.53 ns |  1.30 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     49.09 ns |  0.0580 ns |  0.0514 ns |     49.08 ns |  1.12 |    0.00 |
|                                  LowCostLinqWithDelegate2 |            [5] |     64.07 ns |  0.1227 ns |  0.1148 ns |     64.01 ns |  1.47 |    0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     58.15 ns |  0.0626 ns |  0.0522 ns |     58.14 ns |  1.33 |    0.00 |
|                                LowCostLinqWithStructWhere |            [5] |     52.22 ns |  0.0656 ns |  0.0512 ns |     52.20 ns |  1.19 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     42.32 ns |  0.0177 ns |  0.0157 ns |     42.32 ns |  0.97 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    148.44 ns |  0.0620 ns |  0.0580 ns |    148.44 ns |  3.40 |    0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    130.74 ns |  0.0961 ns |  0.0899 ns |    130.70 ns |  2.99 |    0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    131.68 ns |  0.0613 ns |  0.0478 ns |    131.68 ns |  3.01 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    116.95 ns |  0.0482 ns |  0.0451 ns |    116.96 ns |  2.68 |    0.00 |
|                                                 LinqCount |            [5] |     42.52 ns |  0.0315 ns |  0.0295 ns |     42.53 ns |  0.97 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |     50.59 ns |  0.1953 ns |  0.1631 ns |     50.51 ns |  1.16 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     41.46 ns |  0.0429 ns |  0.0401 ns |     41.46 ns |  0.95 |    0.00 |
|                           LowCostLinqWithStructWhereCount |            [5] |     38.62 ns |  0.1744 ns |  0.1631 ns |     38.54 ns |  0.88 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     25.26 ns |  0.2873 ns |  0.2687 ns |     25.09 ns |  0.58 |    0.01 |
|                                               LinqToArray |            [5] |    100.61 ns |  0.0859 ns |  0.0761 ns |    100.61 ns |  2.30 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |     96.20 ns |  0.0317 ns |  0.0296 ns |     96.19 ns |  2.20 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     88.88 ns |  1.6789 ns |  1.5705 ns |     87.73 ns |  2.03 |    0.04 |
|                              LowCostLinqWithStructToArray |            [5] |     84.50 ns |  0.0185 ns |  0.0173 ns |     84.50 ns |  1.93 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     69.93 ns |  0.0531 ns |  0.0471 ns |     69.92 ns |  1.60 |    0.00 |
|                                                      Take |            [5] |    133.96 ns |  0.0939 ns |  0.0878 ns |    133.97 ns |  3.06 |    0.00 |
|                                               LowCostTake |            [5] |     67.16 ns |  0.7010 ns |  0.6558 ns |     67.12 ns |  1.54 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [5] |     60.30 ns |  0.0771 ns |  0.0722 ns |     60.30 ns |  1.38 |    0.00 |
|                                     LowCostTakeWithStruct |            [5] |     60.10 ns |  0.0398 ns |  0.0372 ns |     60.10 ns |  1.37 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     53.40 ns |  0.0378 ns |  0.0335 ns |     53.39 ns |  1.22 |    0.00 |
|                                            SkipTakeSingle |            [5] |    123.04 ns |  0.0496 ns |  0.0440 ns |    123.02 ns |  2.81 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |     65.59 ns |  0.0383 ns |  0.0340 ns |     65.58 ns |  1.50 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     57.82 ns |  0.0305 ns |  0.0285 ns |     57.83 ns |  1.32 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     58.93 ns |  0.0261 ns |  0.0231 ns |     58.94 ns |  1.35 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     46.27 ns |  0.4277 ns |  0.4001 ns |     46.04 ns |  1.06 |    0.01 |
|                                           ForeachDelegate |            [5] |     53.12 ns |  0.1083 ns |  0.1013 ns |     53.06 ns |  1.22 |    0.00 |
|                                                   Foreach |            [5] |     43.72 ns |  0.0258 ns |  0.0241 ns |     43.72 ns |  1.00 |    0.00 |
