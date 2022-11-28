``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                                    Method | CollectionSize |           Mean |       Error |      StdDev |         Median |  Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |---------------:|------------:|------------:|---------------:|-------:|--------:|
|                                                      **Linq** |            **[0]** |     **76.4519 ns** |   **0.0196 ns** |   **0.0174 ns** |     **76.4578 ns** | **234.40** |    **0.35** |
|                                   LowCostLinqWithDelegate |            [0] |     18.5047 ns |   0.0007 ns |   0.0007 ns |     18.5046 ns |  56.74 |    0.08 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     12.3104 ns |   0.0003 ns |   0.0002 ns |     12.3104 ns |  37.75 |    0.05 |
|                                  LowCostLinqWithDelegate2 |            [0] |     41.3014 ns |   0.0009 ns |   0.0008 ns |     41.3015 ns | 126.63 |    0.18 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     37.6727 ns |   0.0023 ns |   0.0021 ns |     37.6735 ns | 115.51 |    0.17 |
|                                LowCostLinqWithStructWhere |            [0] |     32.8518 ns |   0.0058 ns |   0.0054 ns |     32.8528 ns | 100.73 |    0.14 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     26.5985 ns |   0.0008 ns |   0.0007 ns |     26.5984 ns |  81.56 |    0.12 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |     35.3464 ns |   0.0174 ns |   0.0145 ns |     35.3438 ns | 108.38 |    0.15 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |     32.5950 ns |   0.0098 ns |   0.0082 ns |     32.5927 ns |  99.95 |    0.15 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     34.4054 ns |   0.0074 ns |   0.0065 ns |     34.4061 ns | 105.48 |    0.15 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |     32.0455 ns |   0.0189 ns |   0.0167 ns |     32.0423 ns |  98.25 |    0.14 |
|                                                 LinqCount |            [0] |     65.2198 ns |   0.0163 ns |   0.0144 ns |     65.2171 ns | 199.96 |    0.28 |
|                              LowCostLinqWithDelegateCount |            [0] |      8.4522 ns |   0.0003 ns |   0.0003 ns |      8.4521 ns |  25.92 |    0.04 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |      7.6602 ns |   0.0003 ns |   0.0002 ns |      7.6601 ns |  23.49 |    0.03 |
|                           LowCostLinqWithStructWhereCount |            [0] |     19.8556 ns |   0.0036 ns |   0.0032 ns |     19.8553 ns |  60.88 |    0.09 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     19.5183 ns |   0.0009 ns |   0.0008 ns |     19.5181 ns |  59.85 |    0.08 |
|                                               LinqToArray |            [0] |     68.1713 ns |   0.0404 ns |   0.0338 ns |     68.1648 ns | 209.03 |    0.32 |
|                            LowCostLinqWithDelegateToArray |            [0] |     10.1014 ns |   0.0008 ns |   0.0007 ns |     10.1011 ns |  30.97 |    0.04 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |      8.8290 ns |   0.0045 ns |   0.0039 ns |      8.8290 ns |  27.07 |    0.04 |
|                              LowCostLinqWithStructToArray |            [0] |     24.1113 ns |   0.0020 ns |   0.0019 ns |     24.1114 ns |  73.93 |    0.10 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     21.9938 ns |   0.0111 ns |   0.0098 ns |     21.9954 ns |  67.43 |    0.09 |
|                                                      Take |            [0] |     97.4819 ns |   0.0517 ns |   0.0484 ns |     97.4904 ns | 298.90 |    0.45 |
|                                               LowCostTake |            [0] |     25.1269 ns |   0.0004 ns |   0.0003 ns |     25.1268 ns |  77.04 |    0.11 |
|                                  LowCostTakeWithoutChecks |            [0] |     20.4920 ns |   0.0024 ns |   0.0022 ns |     20.4915 ns |  62.83 |    0.09 |
|                                     LowCostTakeWithStruct |            [0] |     38.7606 ns |   0.0041 ns |   0.0038 ns |     38.7590 ns | 118.85 |    0.17 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     33.4986 ns |   0.0103 ns |   0.0096 ns |     33.5026 ns | 102.71 |    0.16 |
|                                            SkipTakeSingle |            [0] |    114.6302 ns |   0.0243 ns |   0.0189 ns |    114.6337 ns | 351.48 |    0.51 |
|                                     LowCostSkipTakeSingle |            [0] |     22.7875 ns |   0.0192 ns |   0.0180 ns |     22.7947 ns |  69.87 |    0.09 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     21.9621 ns |   0.0155 ns |   0.0145 ns |     21.9618 ns |  67.34 |    0.13 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     38.5215 ns |   0.0006 ns |   0.0004 ns |     38.5216 ns | 118.11 |    0.17 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     37.6040 ns |   0.0035 ns |   0.0031 ns |     37.6027 ns | 115.29 |    0.17 |
|                                           ForeachDelegate |            [0] |      2.8166 ns |   0.0008 ns |   0.0007 ns |      2.8167 ns |   8.64 |    0.01 |
|                                                   Foreach |            [0] |      0.9910 ns |   0.0014 ns |   0.0012 ns |      0.9911 ns |   3.04 |    0.00 |
|                                                       For |            [0] |      0.3261 ns |   0.0005 ns |   0.0005 ns |      0.3262 ns |   1.00 |    0.00 |
|                                                           |                |                |             |             |                |        |         |
|                                                      **Linq** |         **[1000]** | **13,279.8540 ns** | **265.4664 ns** | **536.2552 ns** | **13,345.3445 ns** |  **53.65** |    **2.11** |
|                                   LowCostLinqWithDelegate |         [1000] |  5,544.8700 ns |   1.7746 ns |   1.6599 ns |  5,544.5480 ns |  22.35 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] |  5,305.3426 ns |   2.1512 ns |   2.0123 ns |  5,304.1908 ns |  21.38 |    0.01 |
|                                  LowCostLinqWithDelegate2 |         [1000] |  5,798.0888 ns |   1.4016 ns |   1.3110 ns |  5,798.4322 ns |  23.37 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] |  5,800.8280 ns |   0.9061 ns |   0.8033 ns |  5,800.9102 ns |  23.38 |    0.00 |
|                                LowCostLinqWithStructWhere |         [1000] |  1,549.8775 ns |   0.1132 ns |   0.0884 ns |  1,549.8496 ns |   6.25 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,392.3813 ns |  14.9599 ns |  13.2615 ns |  1,391.8626 ns |   5.61 |    0.05 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  8,439.4736 ns |   2.3165 ns |   2.0535 ns |  8,439.4226 ns |  34.01 |    0.01 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] |  7,939.9235 ns |   3.1899 ns |   2.8278 ns |  7,939.1823 ns |  32.00 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  4,362.5166 ns |   1.9464 ns |   1.7255 ns |  4,362.4081 ns |  17.58 |    0.01 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  3,886.5825 ns |   2.7821 ns |   2.4662 ns |  3,886.9587 ns |  15.66 |    0.01 |
|                                                 LinqCount |         [1000] |  9,053.7091 ns | 207.4751 ns | 611.7451 ns |  9,155.2818 ns |  36.13 |    2.24 |
|                              LowCostLinqWithDelegateCount |         [1000] |  5,023.1931 ns |   0.9927 ns |   0.9285 ns |  5,023.0865 ns |  20.25 |    0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] |  5,255.5039 ns |   0.7263 ns |   0.6794 ns |  5,255.4573 ns |  21.18 |    0.00 |
|                           LowCostLinqWithStructWhereCount |         [1000] |    509.8907 ns |   0.2588 ns |   0.2294 ns |    509.8701 ns |   2.06 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |    505.8471 ns |   0.2111 ns |   0.1871 ns |    505.9021 ns |   2.04 |    0.00 |
|                                               LinqToArray |         [1000] |  8,796.1632 ns | 171.7968 ns | 223.3843 ns |  8,744.7403 ns |  35.56 |    0.89 |
|                            LowCostLinqWithDelegateToArray |         [1000] |  6,522.5904 ns |   2.0364 ns |   1.8052 ns |  6,522.4228 ns |  26.29 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] |  6,503.2586 ns |  14.6472 ns |  12.9843 ns |  6,504.3346 ns |  26.21 |    0.05 |
|                              LowCostLinqWithStructToArray |         [1000] |  1,627.6069 ns |   0.5551 ns |   0.4921 ns |  1,627.5967 ns |   6.56 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  1,606.3347 ns |   1.4908 ns |   1.1639 ns |  1,605.8467 ns |   6.47 |    0.00 |
|                                                      Take |         [1000] |    412.5012 ns |   3.0414 ns |   2.8449 ns |    412.5286 ns |   1.66 |    0.01 |
|                                               LowCostTake |         [1000] |    140.2225 ns |   0.0153 ns |   0.0143 ns |    140.2237 ns |   0.57 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    142.1042 ns |   0.0348 ns |   0.0291 ns |    142.1030 ns |   0.57 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |     75.5606 ns |   0.0299 ns |   0.0250 ns |     75.5541 ns |   0.30 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |     63.2998 ns |   0.1024 ns |   0.0957 ns |     63.3322 ns |   0.26 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    329.2870 ns |   2.2545 ns |   2.1088 ns |    329.6626 ns |   1.33 |    0.01 |
|                                     LowCostSkipTakeSingle |         [1000] |    145.6536 ns |   0.1071 ns |   0.1002 ns |    145.6958 ns |   0.59 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    141.8281 ns |   0.0980 ns |   0.0917 ns |    141.8078 ns |   0.57 |    0.00 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |     67.2689 ns |   0.0168 ns |   0.0149 ns |     67.2673 ns |   0.27 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |     66.4161 ns |   0.0087 ns |   0.0077 ns |     66.4149 ns |   0.27 |    0.00 |
|                                           ForeachDelegate |         [1000] |  5,016.4373 ns |   0.2039 ns |   0.1807 ns |  5,016.4413 ns |  20.22 |    0.00 |
|                                                   Foreach |         [1000] |    484.5557 ns |   0.0233 ns |   0.0182 ns |    484.5536 ns |   1.95 |    0.00 |
|                                                       For |         [1000] |    248.1130 ns |   0.0094 ns |   0.0088 ns |    248.1128 ns |   1.00 |    0.00 |
|                                                           |                |                |             |             |                |        |         |
|                                                      **Linq** |           **[50]** |    **694.0422 ns** |  **13.3709 ns** |  **17.8498 ns** |    **697.3042 ns** |  **49.59** |    **1.32** |
|                                   LowCostLinqWithDelegate |           [50] |    293.6427 ns |   0.0579 ns |   0.0541 ns |    293.6537 ns |  20.95 |    0.07 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    296.5804 ns |   0.0910 ns |   0.0806 ns |    296.5776 ns |  21.16 |    0.07 |
|                                  LowCostLinqWithDelegate2 |           [50] |    327.1391 ns |   0.0223 ns |   0.0209 ns |    327.1389 ns |  23.34 |    0.08 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    327.4870 ns |   0.2295 ns |   0.2146 ns |    327.4541 ns |  23.36 |    0.08 |
|                                LowCostLinqWithStructWhere |           [50] |    114.3516 ns |   0.0102 ns |   0.0095 ns |    114.3501 ns |   8.16 |    0.03 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |     96.8681 ns |   0.0260 ns |   0.0231 ns |     96.8685 ns |   6.91 |    0.02 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |    463.2881 ns |   0.0919 ns |   0.0768 ns |    463.2772 ns |  33.07 |    0.09 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |    433.2036 ns |   0.0815 ns |   0.0681 ns |    433.2067 ns |  30.92 |    0.09 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    254.6462 ns |   0.0747 ns |   0.0624 ns |    254.6430 ns |  18.18 |    0.05 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    209.6271 ns |   0.1017 ns |   0.0902 ns |    209.6323 ns |  14.96 |    0.05 |
|                                                 LinqCount |           [50] |    444.6305 ns |   5.7475 ns |   5.3762 ns |    445.0701 ns |  31.72 |    0.41 |
|                              LowCostLinqWithDelegateCount |           [50] |    273.5744 ns |   0.0357 ns |   0.0334 ns |    273.5691 ns |  19.52 |    0.06 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    271.4005 ns |   0.1223 ns |   0.1144 ns |    271.3750 ns |  19.36 |    0.06 |
|                           LowCostLinqWithStructWhereCount |           [50] |     46.0769 ns |   0.0154 ns |   0.0128 ns |     46.0737 ns |   3.29 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |     45.5080 ns |   0.0998 ns |   0.0933 ns |     45.5107 ns |   3.25 |    0.01 |
|                                               LinqToArray |           [50] |    580.9634 ns |   4.3377 ns |   4.0575 ns |    580.2569 ns |  41.44 |    0.23 |
|                            LowCostLinqWithDelegateToArray |           [50] |    414.4193 ns |   0.3363 ns |   0.2981 ns |    414.2870 ns |  29.57 |    0.10 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    405.2189 ns |   0.1600 ns |   0.1336 ns |    405.2230 ns |  28.93 |    0.08 |
|                              LowCostLinqWithStructToArray |           [50] |    142.6381 ns |   0.2144 ns |   0.2006 ns |    142.6095 ns |  10.18 |    0.04 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    139.3334 ns |   0.1927 ns |   0.1803 ns |    139.3236 ns |   9.94 |    0.03 |
|                                                      Take |           [50] |    409.8865 ns |   3.9578 ns |   3.7021 ns |    410.6944 ns |  29.24 |    0.29 |
|                                               LowCostTake |           [50] |    142.3323 ns |   0.0301 ns |   0.0266 ns |    142.3364 ns |  10.15 |    0.03 |
|                                  LowCostTakeWithoutChecks |           [50] |    140.7663 ns |   0.0297 ns |   0.0278 ns |    140.7645 ns |  10.04 |    0.03 |
|                                     LowCostTakeWithStruct |           [50] |     75.0609 ns |   0.0126 ns |   0.0105 ns |     75.0610 ns |   5.36 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |     63.1449 ns |   0.0726 ns |   0.0679 ns |     63.0887 ns |   4.50 |    0.02 |
|                                            SkipTakeSingle |           [50] |    329.8445 ns |   2.3325 ns |   2.1818 ns |    329.9613 ns |  23.53 |    0.15 |
|                                     LowCostSkipTakeSingle |           [50] |    143.6796 ns |   0.0349 ns |   0.0310 ns |    143.6769 ns |  10.25 |    0.03 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    142.0581 ns |   0.0673 ns |   0.0597 ns |    142.0509 ns |  10.14 |    0.03 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |     67.8506 ns |   0.0113 ns |   0.0100 ns |     67.8475 ns |   4.84 |    0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |     66.2184 ns |   0.0093 ns |   0.0083 ns |     66.2184 ns |   4.72 |    0.02 |
|                                           ForeachDelegate |           [50] |    245.6526 ns |   0.0330 ns |   0.0308 ns |    245.6589 ns |  17.52 |    0.06 |
|                                                   Foreach |           [50] |     23.3007 ns |   0.0300 ns |   0.0281 ns |     23.3010 ns |   1.66 |    0.01 |
|                                                       For |           [50] |     14.0178 ns |   0.0493 ns |   0.0461 ns |     14.0182 ns |   1.00 |    0.00 |
|                                                           |                |                |             |             |                |        |         |
|                                                      **Linq** |            **[5]** |    **129.3581 ns** |   **0.3644 ns** |   **0.3409 ns** |    **129.3559 ns** |  **63.01** |    **0.22** |
|                                   LowCostLinqWithDelegate |            [5] |     42.4509 ns |   0.0510 ns |   0.0477 ns |     42.4518 ns |  20.68 |    0.07 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |     36.5887 ns |   0.0293 ns |   0.0274 ns |     36.5829 ns |  17.82 |    0.06 |
|                                  LowCostLinqWithDelegate2 |            [5] |     63.1104 ns |   0.0083 ns |   0.0074 ns |     63.1123 ns |  30.74 |    0.09 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |     59.8651 ns |   0.2002 ns |   0.1873 ns |     59.7941 ns |  29.16 |    0.14 |
|                                LowCostLinqWithStructWhere |            [5] |     41.4533 ns |   0.0015 ns |   0.0012 ns |     41.4531 ns |  20.19 |    0.07 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     34.2624 ns |   0.0014 ns |   0.0013 ns |     34.2622 ns |  16.69 |    0.05 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |     78.1538 ns |   0.0395 ns |   0.0351 ns |     78.1519 ns |  38.07 |    0.13 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |     75.0821 ns |   0.0593 ns |   0.0555 ns |     75.0846 ns |  36.57 |    0.11 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     51.2082 ns |   0.0743 ns |   0.0695 ns |     51.1675 ns |  24.95 |    0.10 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |     47.8175 ns |   0.0241 ns |   0.0213 ns |     47.8153 ns |  23.29 |    0.07 |
|                                                 LinqCount |            [5] |    101.3093 ns |   0.2846 ns |   0.2662 ns |    101.3113 ns |  49.35 |    0.23 |
|                              LowCostLinqWithDelegateCount |            [5] |     33.0218 ns |   0.0461 ns |   0.0431 ns |     33.0120 ns |  16.09 |    0.05 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |     30.6253 ns |   0.0690 ns |   0.0645 ns |     30.6305 ns |  14.92 |    0.05 |
|                           LowCostLinqWithStructWhereCount |            [5] |     23.3142 ns |   0.0010 ns |   0.0009 ns |     23.3143 ns |  11.36 |    0.03 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     22.8781 ns |   0.0018 ns |   0.0016 ns |     22.8776 ns |  11.14 |    0.03 |
|                                               LinqToArray |            [5] |    139.4619 ns |   0.7262 ns |   0.6793 ns |    139.7522 ns |  67.94 |    0.33 |
|                            LowCostLinqWithDelegateToArray |            [5] |     66.4409 ns |   0.0905 ns |   0.0847 ns |     66.4534 ns |  32.37 |    0.12 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |     64.0555 ns |   0.0409 ns |   0.0363 ns |     64.0488 ns |  31.20 |    0.11 |
|                              LowCostLinqWithStructToArray |            [5] |     52.2030 ns |   0.0050 ns |   0.0039 ns |     52.2036 ns |  25.43 |    0.09 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     50.6379 ns |   0.0140 ns |   0.0117 ns |     50.6415 ns |  24.67 |    0.08 |
|                                                      Take |            [5] |    179.1085 ns |   0.7826 ns |   0.7321 ns |    179.1171 ns |  87.25 |    0.37 |
|                                               LowCostTake |            [5] |     50.2773 ns |   0.0411 ns |   0.0384 ns |     50.2677 ns |  24.49 |    0.07 |
|                                  LowCostTakeWithoutChecks |            [5] |     44.4480 ns |   0.0354 ns |   0.0314 ns |     44.4478 ns |  21.65 |    0.07 |
|                                     LowCostTakeWithStruct |            [5] |     49.1006 ns |   0.0016 ns |   0.0014 ns |     49.1003 ns |  23.92 |    0.08 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     41.8531 ns |   0.0010 ns |   0.0009 ns |     41.8531 ns |  20.39 |    0.06 |
|                                            SkipTakeSingle |            [5] |    163.2358 ns |   0.2512 ns |   0.2350 ns |    163.2013 ns |  79.52 |    0.20 |
|                                     LowCostSkipTakeSingle |            [5] |     45.9348 ns |   0.0573 ns |   0.0508 ns |     45.9256 ns |  22.38 |    0.07 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |     43.4773 ns |   0.0339 ns |   0.0301 ns |     43.4701 ns |  21.18 |    0.06 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |     47.0208 ns |   0.0021 ns |   0.0019 ns |     47.0209 ns |  22.91 |    0.07 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     43.8399 ns |   0.0011 ns |   0.0010 ns |     43.8397 ns |  21.35 |    0.07 |
|                                           ForeachDelegate |            [5] |     26.6062 ns |   0.0033 ns |   0.0029 ns |     26.6061 ns |  12.96 |    0.04 |
|                                                   Foreach |            [5] |      4.1646 ns |   0.0128 ns |   0.0120 ns |      4.1652 ns |   2.03 |    0.01 |
|                                                       For |            [5] |      2.0529 ns |   0.0066 ns |   0.0062 ns |      2.0516 ns |   1.00 |    0.00 |
