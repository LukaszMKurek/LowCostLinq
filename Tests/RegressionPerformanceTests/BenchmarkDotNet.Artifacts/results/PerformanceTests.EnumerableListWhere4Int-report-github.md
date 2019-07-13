``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.615 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |       Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **124.75 ns** |   **0.0635 ns** |     **0.0563 ns** |    **124.73 ns** |  **7.38** |    **0.04** |
|                                   LowCostLinqWithDelegate |            [0] |     45.53 ns |   0.0072 ns |     0.0068 ns |     45.53 ns |  2.69 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     39.64 ns |   0.0069 ns |     0.0061 ns |     39.64 ns |  2.34 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     72.48 ns |   0.0164 ns |     0.0153 ns |     72.48 ns |  4.29 |    0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     64.22 ns |   0.0135 ns |     0.0126 ns |     64.22 ns |  3.80 |    0.02 |
|                                LowCostLinqWithStructWhere |            [0] |     56.81 ns |   0.0070 ns |     0.0065 ns |     56.81 ns |  3.36 |    0.02 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     49.48 ns |   0.0080 ns |     0.0075 ns |     49.48 ns |  2.93 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     79.87 ns |   0.0724 ns |     0.0678 ns |     79.88 ns |  4.72 |    0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     68.35 ns |   0.0187 ns |     0.0166 ns |     68.35 ns |  4.04 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     72.32 ns |   0.0312 ns |     0.0277 ns |     72.32 ns |  4.28 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     62.04 ns |   0.0309 ns |     0.0289 ns |     62.03 ns |  3.67 |    0.02 |
|                                                 LinqCount |            [0] |    126.61 ns |   0.2514 ns |     0.2352 ns |    126.65 ns |  7.49 |    0.05 |
|                              LowCostLinqWithDelegateCount |            [0] |     43.81 ns |   0.0118 ns |     0.0099 ns |     43.81 ns |  2.59 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     41.11 ns |   0.0069 ns |     0.0058 ns |     41.11 ns |  2.43 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     53.20 ns |   0.0097 ns |     0.0091 ns |     53.20 ns |  3.15 |    0.02 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     45.23 ns |   0.0089 ns |     0.0083 ns |     45.23 ns |  2.68 |    0.01 |
|                                               LinqToArray |            [0] |    140.83 ns |   0.0639 ns |     0.0597 ns |    140.82 ns |  8.33 |    0.04 |
|                            LowCostLinqWithDelegateToArray |            [0] |     52.88 ns |   0.0249 ns |     0.0233 ns |     52.88 ns |  3.13 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     50.00 ns |   0.0133 ns |     0.0125 ns |     50.00 ns |  2.96 |    0.02 |
|                              LowCostLinqWithStructToArray |            [0] |     60.73 ns |   0.0214 ns |     0.0201 ns |     60.72 ns |  3.59 |    0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     54.01 ns |   0.0153 ns |     0.0143 ns |     54.00 ns |  3.19 |    0.02 |
|                                                      Take |            [0] |    161.91 ns |   0.0736 ns |     0.0689 ns |    161.91 ns |  9.58 |    0.05 |
|                                               LowCostTake |            [0] |     57.54 ns |   0.0597 ns |     0.0558 ns |     57.53 ns |  3.40 |    0.02 |
|                                  LowCostTakeWithoutChecks |            [0] |     51.83 ns |   0.0089 ns |     0.0083 ns |     51.83 ns |  3.07 |    0.02 |
|                                     LowCostTakeWithStruct |            [0] |     68.79 ns |   0.0130 ns |     0.0122 ns |     68.79 ns |  4.07 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     62.58 ns |   0.0098 ns |     0.0082 ns |     62.58 ns |  3.70 |    0.02 |
|                                            SkipTakeSingle |            [0] |    184.72 ns |   0.0344 ns |     0.0305 ns |    184.71 ns | 10.92 |    0.06 |
|                                     LowCostSkipTakeSingle |            [0] |     78.20 ns |   0.0210 ns |     0.0187 ns |     78.20 ns |  4.62 |    0.02 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     75.90 ns |   0.0395 ns |     0.0369 ns |     75.91 ns |  4.49 |    0.02 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     81.79 ns |   0.0174 ns |     0.0162 ns |     81.79 ns |  4.84 |    0.03 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     78.60 ns |   0.0143 ns |     0.0134 ns |     78.60 ns |  4.65 |    0.02 |
|                                           ForeachDelegate |            [0] |     20.60 ns |   0.0130 ns |     0.0115 ns |     20.60 ns |  1.22 |    0.01 |
|                                                   Foreach |            [0] |     16.91 ns |   0.0947 ns |     0.0886 ns |     16.85 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **15,009.54 ns** | **307.5511 ns** |   **315.8323 ns** | **14,840.31 ns** |  **2.71** |    **0.06** |
|                                   LowCostLinqWithDelegate |         [1000] | 12,696.93 ns | 243.5513 ns |   316.6855 ns | 12,533.35 ns |  2.32 |    0.06 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 13,403.77 ns | 296.5124 ns |   874.2735 ns | 13,235.13 ns |  2.43 |    0.17 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 12,266.02 ns | 244.1585 ns |   446.4577 ns | 12,078.29 ns |  2.24 |    0.11 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 11,409.77 ns | 298.8409 ns |   881.1392 ns | 11,296.23 ns |  2.10 |    0.18 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,695.61 ns |   2.1961 ns |     2.0543 ns |  2,695.06 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,572.34 ns |   0.2140 ns |     0.1897 ns |  1,572.42 ns |  0.28 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 20,260.06 ns | 401.3983 ns |   946.1429 ns | 20,117.95 ns |  3.76 |    0.18 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 20,248.33 ns | 401.1993 ns | 1,125.0057 ns | 19,749.89 ns |  3.73 |    0.22 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  4,645.81 ns |   1.0418 ns |     0.9236 ns |  4,646.13 ns |  0.84 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  4,137.61 ns |   1.9234 ns |     1.7992 ns |  4,137.78 ns |  0.75 |    0.00 |
|                                                 LinqCount |         [1000] |  8,852.97 ns | 166.9052 ns |   139.3734 ns |  8,808.00 ns |  1.60 |    0.03 |
|                              LowCostLinqWithDelegateCount |         [1000] | 11,248.77 ns | 203.0163 ns |   303.8652 ns | 11,200.48 ns |  2.03 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  8,699.96 ns | 162.9379 ns |   144.4402 ns |  8,642.18 ns |  1.57 |    0.03 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,735.03 ns |   0.4487 ns |     0.4197 ns |  1,735.08 ns |  0.31 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    645.77 ns |   0.0225 ns |     0.0175 ns |    645.78 ns |  0.12 |    0.00 |
|                                               LinqToArray |         [1000] | 11,317.08 ns |  25.1590 ns |    23.5337 ns | 11,318.30 ns |  2.05 |    0.00 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 12,021.46 ns |  36.2956 ns |    33.9509 ns | 12,016.06 ns |  2.17 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 16,195.60 ns |  36.8007 ns |    34.4234 ns | 16,183.63 ns |  2.93 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  2,942.33 ns |   4.7758 ns |     4.4673 ns |  2,941.00 ns |  0.53 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,840.58 ns |   1.1998 ns |     1.0636 ns |  1,840.53 ns |  0.33 |    0.00 |
|                                                      Take |         [1000] |    548.07 ns |   0.6866 ns |     0.6423 ns |    548.16 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    339.86 ns |   6.8229 ns |    12.1278 ns |    339.24 ns |  0.06 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    428.89 ns |   8.5490 ns |     8.7792 ns |    429.53 ns |  0.08 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    134.86 ns |   0.0270 ns |     0.0239 ns |    134.87 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    103.72 ns |   0.0227 ns |     0.0212 ns |    103.72 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    474.63 ns |   0.6799 ns |     0.6360 ns |    474.62 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    384.39 ns |   8.6546 ns |    11.5537 ns |    378.96 ns |  0.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    370.29 ns |   8.4584 ns |    24.5394 ns |    363.71 ns |  0.07 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    160.77 ns |   0.0359 ns |     0.0336 ns |    160.77 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    143.17 ns |   0.0947 ns |     0.0885 ns |    143.19 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,962.04 ns |   2.3051 ns |     2.1562 ns | 10,961.94 ns |  1.98 |    0.00 |
|                                                   Foreach |         [1000] |  5,532.70 ns |   1.4839 ns |     1.3881 ns |  5,532.98 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **849.73 ns** |   **2.0471 ns** |     **1.8147 ns** |    **849.45 ns** |  **2.79** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    760.67 ns |   6.1148 ns |     5.1061 ns |    758.94 ns |  2.50 |    0.02 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    673.54 ns |  14.5758 ns |    42.9771 ns |    660.02 ns |  2.22 |    0.14 |
|                                  LowCostLinqWithDelegate2 |           [50] |    746.95 ns |  16.2808 ns |    46.7127 ns |    744.76 ns |  2.46 |    0.17 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    679.04 ns |  15.5879 ns |    45.7165 ns |    664.28 ns |  2.18 |    0.12 |
|                                LowCostLinqWithStructWhere |           [50] |    192.24 ns |   0.1112 ns |     0.1040 ns |    192.29 ns |  0.63 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    131.56 ns |   0.0240 ns |     0.0224 ns |    131.56 ns |  0.43 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,099.74 ns |  12.6693 ns |    11.8509 ns |  1,101.91 ns |  3.61 |    0.04 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,060.73 ns |  18.1618 ns |    16.9885 ns |  1,061.13 ns |  3.48 |    0.06 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    309.31 ns |   0.1043 ns |     0.0976 ns |    309.30 ns |  1.02 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    278.19 ns |   1.7439 ns |     1.6313 ns |    278.62 ns |  0.91 |    0.01 |
|                                                 LinqCount |           [50] |    560.46 ns |   1.3990 ns |     1.3087 ns |    560.22 ns |  1.84 |    0.00 |
|                              LowCostLinqWithDelegateCount |           [50] |    651.29 ns |  13.0378 ns |    37.4080 ns |    650.24 ns |  2.15 |    0.12 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    524.14 ns |  12.9266 ns |    36.8804 ns |    503.18 ns |  1.71 |    0.12 |
|                           LowCostLinqWithStructWhereCount |           [50] |    142.09 ns |   0.0252 ns |     0.0224 ns |    142.09 ns |  0.47 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     74.05 ns |   0.0377 ns |     0.0353 ns |     74.05 ns |  0.24 |    0.00 |
|                                               LinqToArray |           [50] |    897.46 ns |   1.6618 ns |     1.5545 ns |    897.17 ns |  2.95 |    0.01 |
|                            LowCostLinqWithDelegateToArray |           [50] |    784.19 ns |   1.9009 ns |     1.7781 ns |    784.04 ns |  2.58 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    977.09 ns |   2.6197 ns |     2.4505 ns |    976.01 ns |  3.21 |    0.01 |
|                              LowCostLinqWithStructToArray |           [50] |    288.74 ns |   0.0957 ns |     0.0848 ns |    288.73 ns |  0.95 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    225.19 ns |   0.2005 ns |     0.1875 ns |    225.22 ns |  0.74 |    0.00 |
|                                                      Take |           [50] |    548.78 ns |   0.8169 ns |     0.7641 ns |    548.82 ns |  1.80 |    0.00 |
|                                               LowCostTake |           [50] |    323.83 ns |   3.9492 ns |     3.2978 ns |    322.19 ns |  1.06 |    0.01 |
|                                  LowCostTakeWithoutChecks |           [50] |    301.26 ns |   6.8809 ns |    20.1804 ns |    289.44 ns |  0.98 |    0.05 |
|                                     LowCostTakeWithStruct |           [50] |    133.93 ns |   0.0374 ns |     0.0350 ns |    133.92 ns |  0.44 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    101.94 ns |   0.0121 ns |     0.0107 ns |    101.94 ns |  0.33 |    0.00 |
|                                            SkipTakeSingle |           [50] |    474.00 ns |   0.6821 ns |     0.6381 ns |    473.99 ns |  1.56 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    377.46 ns |   2.7002 ns |     2.1081 ns |    377.06 ns |  1.24 |    0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    368.75 ns |   8.1776 ns |    23.9834 ns |    367.37 ns |  1.20 |    0.08 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    163.37 ns |   0.0688 ns |     0.0644 ns |    163.37 ns |  0.54 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    142.64 ns |   0.0422 ns |     0.0374 ns |    142.64 ns |  0.47 |    0.00 |
|                                           ForeachDelegate |           [50] |    581.28 ns |   0.2396 ns |     0.2241 ns |    581.23 ns |  1.91 |    0.00 |
|                                                   Foreach |           [50] |    304.45 ns |   0.0718 ns |     0.0671 ns |    304.48 ns |  1.00 |    0.00 |
|                                                           |                |              |             |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **208.12 ns** |   **0.1608 ns** |     **0.1425 ns** |    **208.13 ns** |  **4.76** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    123.99 ns |   2.5065 ns |     5.9082 ns |    120.44 ns |  2.84 |    0.13 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    110.59 ns |   2.2380 ns |     5.6146 ns |    111.56 ns |  2.45 |    0.12 |
|                                  LowCostLinqWithDelegate2 |            [5] |    140.53 ns |   2.6934 ns |     2.3876 ns |    139.76 ns |  3.21 |    0.05 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    134.37 ns |   2.7124 ns |     5.6619 ns |    133.41 ns |  3.07 |    0.13 |
|                                LowCostLinqWithStructWhere |            [5] |     69.20 ns |   0.0216 ns |     0.0202 ns |     69.20 ns |  1.58 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     56.62 ns |   0.0220 ns |     0.0205 ns |     56.62 ns |  1.29 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    189.10 ns |   0.2877 ns |     0.2691 ns |    189.15 ns |  4.32 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    166.66 ns |   0.2351 ns |     0.2199 ns |    166.61 ns |  3.81 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     94.82 ns |   0.0377 ns |     0.0352 ns |     94.83 ns |  2.17 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     79.49 ns |   0.0499 ns |     0.0467 ns |     79.48 ns |  1.82 |    0.00 |
|                                                 LinqCount |            [5] |    171.01 ns |   0.1932 ns |     0.1807 ns |    171.06 ns |  3.91 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    103.47 ns |   2.0760 ns |     5.6829 ns |    103.10 ns |  2.32 |    0.12 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     85.88 ns |   1.7431 ns |     3.1874 ns |     84.13 ns |  2.00 |    0.09 |
|                           LowCostLinqWithStructWhereCount |            [5] |     60.95 ns |   0.0284 ns |     0.0266 ns |     60.94 ns |  1.39 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     47.71 ns |   0.0117 ns |     0.0109 ns |     47.71 ns |  1.09 |    0.00 |
|                                               LinqToArray |            [5] |    238.46 ns |   0.1378 ns |     0.1289 ns |    238.42 ns |  5.45 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    153.44 ns |   0.1056 ns |     0.0936 ns |    153.43 ns |  3.51 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    180.72 ns |   0.4225 ns |     0.3952 ns |    180.84 ns |  4.13 |    0.01 |
|                              LowCostLinqWithStructToArray |            [5] |    116.82 ns |   0.0463 ns |     0.0433 ns |    116.80 ns |  2.67 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |    103.51 ns |   0.0397 ns |     0.0371 ns |    103.51 ns |  2.37 |    0.00 |
|                                                      Take |            [5] |    271.59 ns |   0.1967 ns |     0.1840 ns |    271.58 ns |  6.21 |    0.01 |
|                                               LowCostTake |            [5] |    162.31 ns |   3.1485 ns |     3.6258 ns |    162.70 ns |  3.70 |    0.09 |
|                                  LowCostTakeWithoutChecks |            [5] |    115.10 ns |   2.4683 ns |     7.0422 ns |    115.43 ns |  2.61 |    0.17 |
|                                     LowCostTakeWithStruct |            [5] |     85.06 ns |   0.0260 ns |     0.0243 ns |     85.07 ns |  1.94 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     72.07 ns |   0.0269 ns |     0.0224 ns |     72.07 ns |  1.65 |    0.00 |
|                                            SkipTakeSingle |            [5] |    265.09 ns |   0.1902 ns |     0.1686 ns |    265.11 ns |  6.06 |    0.00 |
|                                     LowCostSkipTakeSingle |            [5] |    157.97 ns |   3.1835 ns |     6.0568 ns |    156.01 ns |  3.68 |    0.15 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    147.85 ns |   3.6598 ns |     8.5547 ns |    147.95 ns |  3.27 |    0.13 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     97.55 ns |   0.0562 ns |     0.0525 ns |     97.54 ns |  2.23 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     93.50 ns |   0.0243 ns |     0.0190 ns |     93.50 ns |  2.14 |    0.00 |
|                                           ForeachDelegate |            [5] |     75.90 ns |   0.0236 ns |     0.0221 ns |     75.90 ns |  1.74 |    0.00 |
|                                                   Foreach |            [5] |     43.74 ns |   0.0163 ns |     0.0152 ns |     43.75 ns |  1.00 |    0.00 |
