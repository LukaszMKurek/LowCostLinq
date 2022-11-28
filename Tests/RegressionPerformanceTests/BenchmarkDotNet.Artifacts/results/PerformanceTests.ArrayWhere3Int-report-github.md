``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                       Method | CollectionSize |           Mean |       Error |      StdDev |  Ratio | RatioSD |
|--------------------------------------------- |--------------- |---------------:|------------:|------------:|-------:|--------:|
|                                         **Linq** |            **[0]** |     **58.6241 ns** |   **0.0741 ns** |   **0.0693 ns** | **205.51** |    **0.21** |
|                      LowCostLinqWithDelegate |            [0] |     12.3108 ns |   0.0006 ns |   0.0006 ns |  43.15 |    0.01 |
|                     LowCostLinqWithDelegate2 |            [0] |     37.6753 ns |   0.0027 ns |   0.0025 ns | 132.06 |    0.03 |
|                   LowCostLinqWithStructWhere |            [0] |     26.5829 ns |   0.0015 ns |   0.0014 ns |  93.18 |    0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     32.9527 ns |   0.0187 ns |   0.0156 ns | 115.51 |    0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     20.4857 ns |   0.0075 ns |   0.0063 ns |  71.81 |    0.03 |
|                                    LinqCount |            [0] |     58.8792 ns |   0.0118 ns |   0.0105 ns | 206.38 |    0.05 |
|                 LowCostLinqWithDelegateCount |            [0] |      7.7730 ns |   0.0002 ns |   0.0002 ns |  27.25 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     19.5462 ns |   0.0006 ns |   0.0006 ns |  68.51 |    0.02 |
|                                  LinqToArray |            [0] |     57.3445 ns |   0.0393 ns |   0.0329 ns | 201.00 |    0.10 |
|               LowCostLinqWithDelegateToArray |            [0] |      9.5571 ns |   0.0177 ns |   0.0166 ns |  33.50 |    0.06 |
|                 LowCostLinqWithStructToArray |            [0] |     21.8128 ns |   0.0008 ns |   0.0007 ns |  76.46 |    0.02 |
|                                         Take |            [0] |     81.6667 ns |   0.0458 ns |   0.0428 ns | 286.25 |    0.16 |
|                                  LowCostTake |            [0] |     21.2033 ns |   0.0054 ns |   0.0051 ns |  74.32 |    0.02 |
|                        LowCostTakeWithStruct |            [0] |     33.2763 ns |   0.0130 ns |   0.0122 ns | 116.64 |    0.06 |
|                               SkipTakeSingle |            [0] |     99.9898 ns |   0.0172 ns |   0.0152 ns | 350.49 |    0.09 |
|                        LowCostSkipTakeSingle |            [0] |     22.0099 ns |   0.0080 ns |   0.0067 ns |  77.15 |    0.04 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     37.5975 ns |   0.0025 ns |   0.0022 ns | 131.79 |    0.03 |
|                              ForeachDelegate |            [0] |      1.9598 ns |   0.0003 ns |   0.0003 ns |   6.87 |    0.00 |
|                                      Foreach |            [0] |      0.5038 ns |   0.0072 ns |   0.0067 ns |   1.77 |    0.02 |
|                                          For |            [0] |      0.2853 ns |   0.0001 ns |   0.0001 ns |   1.00 |    0.00 |
|                                              |                |                |             |             |        |         |
|                                         **Linq** |         **[1000]** | **13,018.6247 ns** | **275.2455 ns** | **811.5677 ns** |  **49.44** |    **4.16** |
|                      LowCostLinqWithDelegate |         [1000] |  5,312.2955 ns |   1.6522 ns |   1.5454 ns |  21.44 |    0.01 |
|                     LowCostLinqWithDelegate2 |         [1000] |  5,801.8775 ns |   1.9728 ns |   1.8454 ns |  23.42 |    0.01 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,184.3022 ns |   8.5919 ns |   8.0369 ns |   4.78 |    0.03 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] |  8,138.7434 ns |   7.5136 ns |   7.0282 ns |  32.85 |    0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  3,747.3739 ns |   0.4208 ns |   0.3514 ns |  15.13 |    0.00 |
|                                    LinqCount |         [1000] |  9,034.9556 ns | 210.7956 ns | 614.9007 ns |  36.48 |    2.73 |
|                 LowCostLinqWithDelegateCount |         [1000] |  5,015.2655 ns |   0.1720 ns |   0.1436 ns |  20.24 |    0.00 |
|              LowCostLinqWithStructWhereCount |         [1000] |    496.4716 ns |   0.3047 ns |   0.2850 ns |   2.00 |    0.00 |
|                                  LinqToArray |         [1000] |  9,060.6789 ns | 170.8441 ns | 159.8077 ns |  36.57 |    0.64 |
|               LowCostLinqWithDelegateToArray |         [1000] |  5,817.8557 ns |   4.3737 ns |   3.6522 ns |  23.48 |    0.01 |
|                 LowCostLinqWithStructToArray |         [1000] |  1,606.2820 ns |   1.2656 ns |   1.1220 ns |   6.48 |    0.00 |
|                                         Take |         [1000] |    401.8858 ns |   3.7593 ns |   3.3326 ns |   1.62 |    0.01 |
|                                  LowCostTake |         [1000] |    129.9730 ns |   0.0827 ns |   0.0773 ns |   0.52 |    0.00 |
|                        LowCostTakeWithStruct |         [1000] |     58.4143 ns |   0.0016 ns |   0.0015 ns |   0.24 |    0.00 |
|                               SkipTakeSingle |         [1000] |    319.7816 ns |   2.4634 ns |   2.3043 ns |   1.29 |    0.01 |
|                        LowCostSkipTakeSingle |         [1000] |    142.2919 ns |   0.1358 ns |   0.1271 ns |   0.57 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |     63.0663 ns |   0.1036 ns |   0.0969 ns |   0.25 |    0.00 |
|                              ForeachDelegate |         [1000] |  4,769.7213 ns |   0.1904 ns |   0.1781 ns |  19.25 |    0.00 |
|                                      Foreach |         [1000] |    247.8505 ns |   0.0177 ns |   0.0165 ns |   1.00 |    0.00 |
|                                          For |         [1000] |    247.7492 ns |   0.0093 ns |   0.0087 ns |   1.00 |    0.00 |
|                                              |                |                |             |             |        |         |
|                                         **Linq** |           **[50]** |    **689.9127 ns** |  **13.5371 ns** |  **20.2617 ns** |  **48.28** |    **1.40** |
|                      LowCostLinqWithDelegate |           [50] |    279.5773 ns |   0.2153 ns |   0.2014 ns |  19.54 |    0.14 |
|                     LowCostLinqWithDelegate2 |           [50] |    318.3340 ns |   0.3373 ns |   0.3155 ns |  22.25 |    0.16 |
|                   LowCostLinqWithStructWhere |           [50] |     96.8380 ns |   0.0315 ns |   0.0295 ns |   6.77 |    0.05 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |    437.6565 ns |   0.1378 ns |   0.1222 ns |  30.61 |    0.22 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    213.1879 ns |   0.0526 ns |   0.0439 ns |  14.91 |    0.11 |
|                                    LinqCount |           [50] |    442.3154 ns |   8.7227 ns |  11.3420 ns |  30.57 |    0.78 |
|                 LowCostLinqWithDelegateCount |           [50] |    250.0019 ns |   0.0081 ns |   0.0072 ns |  17.49 |    0.12 |
|              LowCostLinqWithStructWhereCount |           [50] |     39.9575 ns |   0.0431 ns |   0.0360 ns |   2.79 |    0.02 |
|                                  LinqToArray |           [50] |    559.2004 ns |   8.2060 ns |   7.6759 ns |  39.09 |    0.56 |
|               LowCostLinqWithDelegateToArray |           [50] |    364.1642 ns |   0.3070 ns |   0.2871 ns |  25.46 |    0.19 |
|                 LowCostLinqWithStructToArray |           [50] |    138.5541 ns |   0.0720 ns |   0.0601 ns |   9.69 |    0.07 |
|                                         Take |           [50] |    402.4656 ns |   3.8526 ns |   3.6038 ns |  28.13 |    0.27 |
|                                  LowCostTake |           [50] |    129.9883 ns |   0.0530 ns |   0.0470 ns |   9.09 |    0.06 |
|                        LowCostTakeWithStruct |           [50] |     58.4650 ns |   0.0015 ns |   0.0013 ns |   4.09 |    0.03 |
|                               SkipTakeSingle |           [50] |    324.1742 ns |   2.9459 ns |   2.7556 ns |  22.66 |    0.27 |
|                        LowCostSkipTakeSingle |           [50] |    141.6452 ns |   0.1450 ns |   0.1356 ns |   9.90 |    0.07 |
|              LowCostSkipTakeSingleWithStruct |           [50] |     63.5570 ns |   0.0611 ns |   0.0572 ns |   4.44 |    0.03 |
|                              ForeachDelegate |           [50] |    243.2255 ns |   0.0083 ns |   0.0077 ns |  17.00 |    0.12 |
|                                      Foreach |           [50] |     13.5237 ns |   0.0425 ns |   0.0377 ns |   0.95 |    0.01 |
|                                          For |           [50] |     14.3059 ns |   0.1069 ns |   0.1000 ns |   1.00 |    0.00 |
|                                              |                |                |             |             |        |         |
|                                         **Linq** |            **[5]** |    **119.2557 ns** |   **0.3925 ns** |   **0.3671 ns** |  **58.31** |    **0.30** |
|                      LowCostLinqWithDelegate |            [5] |     35.5163 ns |   0.0506 ns |   0.0474 ns |  17.37 |    0.06 |
|                     LowCostLinqWithDelegate2 |            [5] |     57.5215 ns |   0.0445 ns |   0.0416 ns |  28.13 |    0.08 |
|                   LowCostLinqWithStructWhere |            [5] |     33.1216 ns |   0.0010 ns |   0.0009 ns |  16.19 |    0.05 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |     73.0960 ns |   0.0680 ns |   0.0636 ns |  35.74 |    0.10 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     38.8029 ns |   0.0341 ns |   0.0285 ns |  18.97 |    0.06 |
|                                    LinqCount |            [5] |     99.3498 ns |   0.2705 ns |   0.2530 ns |  48.58 |    0.22 |
|                 LowCostLinqWithDelegateCount |            [5] |     29.7350 ns |   0.0467 ns |   0.0390 ns |  14.54 |    0.06 |
|              LowCostLinqWithStructWhereCount |            [5] |     21.3774 ns |   0.0008 ns |   0.0006 ns |  10.45 |    0.03 |
|                                  LinqToArray |            [5] |    137.8394 ns |   0.5090 ns |   0.4761 ns |  67.40 |    0.28 |
|               LowCostLinqWithDelegateToArray |            [5] |     64.0568 ns |   0.1163 ns |   0.1088 ns |  31.32 |    0.09 |
|                 LowCostLinqWithStructToArray |            [5] |     49.8229 ns |   0.0066 ns |   0.0051 ns |  24.37 |    0.08 |
|                                         Take |            [5] |    173.1812 ns |   0.4221 ns |   0.3948 ns |  84.68 |    0.32 |
|                                  LowCostTake |            [5] |     43.2563 ns |   0.0491 ns |   0.0435 ns |  21.15 |    0.07 |
|                        LowCostTakeWithStruct |            [5] |     40.1111 ns |   0.0028 ns |   0.0023 ns |  19.61 |    0.06 |
|                               SkipTakeSingle |            [5] |    152.0771 ns |   0.4308 ns |   0.4029 ns |  74.36 |    0.30 |
|                        LowCostSkipTakeSingle |            [5] |     43.5389 ns |   0.0485 ns |   0.0405 ns |  21.29 |    0.07 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     42.1450 ns |   0.0016 ns |   0.0015 ns |  20.61 |    0.06 |
|                              ForeachDelegate |            [5] |     24.7979 ns |   0.0190 ns |   0.0178 ns |  12.13 |    0.04 |
|                                      Foreach |            [5] |      2.2159 ns |   0.0033 ns |   0.0031 ns |   1.08 |    0.00 |
|                                          For |            [5] |      2.0452 ns |   0.0065 ns |   0.0061 ns |   1.00 |    0.00 |
