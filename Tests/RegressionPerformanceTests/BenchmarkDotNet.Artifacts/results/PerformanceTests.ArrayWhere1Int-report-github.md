``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                         **Linq** |            **[0]** |    **19.886 ns** |  **0.2520 ns** |  **0.2234 ns** |    **19.791 ns** |   **5.41** |     **0.06** |
|                      LowCostLinqWithDelegate |            [0] |    18.898 ns |  0.0073 ns |  0.0068 ns |    18.901 ns |   5.15 |     0.00 |
|                     LowCostLinqWithDelegate2 |            [0] |    28.026 ns |  0.0032 ns |  0.0027 ns |    28.025 ns |   7.63 |     0.00 |
|                   LowCostLinqWithStructWhere |            [0] |    20.851 ns |  0.0503 ns |  0.0471 ns |    20.886 ns |   5.68 |     0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    36.423 ns |  0.0401 ns |  0.0335 ns |    36.426 ns |   9.92 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    38.387 ns |  0.0411 ns |  0.0384 ns |    38.404 ns |  10.45 |     0.01 |
|                                    LinqCount |            [0] |    25.177 ns |  0.0253 ns |  0.0237 ns |    25.171 ns |   6.86 |     0.01 |
|                 LowCostLinqWithDelegateCount |            [0] |    16.465 ns |  0.1217 ns |  0.1138 ns |    16.392 ns |   4.48 |     0.03 |
|              LowCostLinqWithStructWhereCount |            [0] |    15.581 ns |  0.0017 ns |  0.0015 ns |    15.581 ns |   4.24 |     0.00 |
|                                  LinqToArray |            [0] |    22.929 ns |  0.0069 ns |  0.0054 ns |    22.930 ns |   6.24 |     0.00 |
|               LowCostLinqWithDelegateToArray |            [0] |    19.844 ns |  0.0113 ns |  0.0100 ns |    19.842 ns |   5.40 |     0.00 |
|                 LowCostLinqWithStructToArray |            [0] |    18.891 ns |  0.0602 ns |  0.0563 ns |    18.927 ns |   5.14 |     0.02 |
|                                         Take |            [0] |    25.145 ns |  0.0178 ns |  0.0149 ns |    25.147 ns |   6.85 |     0.01 |
|                                  LowCostTake |            [0] |    26.381 ns |  0.3977 ns |  0.3720 ns |    26.313 ns |   7.18 |     0.10 |
|                        LowCostTakeWithStruct |            [0] |    28.218 ns |  0.0097 ns |  0.0086 ns |    28.218 ns |   7.68 |     0.00 |
|                               SkipTakeSingle |            [0] |    37.095 ns |  0.0170 ns |  0.0159 ns |    37.096 ns |  10.10 |     0.01 |
|                        LowCostSkipTakeSingle |            [0] |    28.751 ns |  0.0023 ns |  0.0019 ns |    28.751 ns |   7.83 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    32.081 ns |  0.0761 ns |  0.0674 ns |    32.122 ns |   8.73 |     0.02 |
|                              ForeachDelegate |            [0] |     6.664 ns |  0.0096 ns |  0.0075 ns |     6.663 ns |   1.81 |     0.00 |
|                                      Foreach |            [0] |     3.775 ns |  0.0116 ns |  0.0108 ns |     3.781 ns |   1.03 |     0.00 |
|                                          For |            [0] |     3.673 ns |  0.0020 ns |  0.0018 ns |     3.673 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |              |        |          |
|                                         **Linq** |         **[1000]** | **6,133.153 ns** | **58.2524 ns** | **54.4893 ns** | **6,093.206 ns** |  **24.43** |     **0.21** |
|                      LowCostLinqWithDelegate |         [1000] | 3,123.482 ns |  0.1406 ns |  0.1174 ns | 3,123.448 ns |  12.44 |     0.02 |
|                     LowCostLinqWithDelegate2 |         [1000] | 3,383.921 ns |  6.8584 ns |  6.0798 ns | 3,380.272 ns |  13.48 |     0.03 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,476.744 ns | 13.5725 ns | 12.6957 ns | 1,472.017 ns |   5.88 |     0.05 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 8,177.210 ns |  6.6923 ns |  5.5884 ns | 8,174.708 ns |  32.58 |     0.05 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 5,776.693 ns |  8.9423 ns |  8.3646 ns | 5,779.571 ns |  23.01 |     0.05 |
|                                    LinqCount |         [1000] | 1,721.136 ns |  3.7692 ns |  3.5257 ns | 1,720.488 ns |   6.86 |     0.02 |
|                 LowCostLinqWithDelegateCount |         [1000] | 2,201.333 ns | 24.1211 ns | 22.5629 ns | 2,206.264 ns |   8.77 |     0.09 |
|              LowCostLinqWithStructWhereCount |         [1000] | 1,329.006 ns |  0.0794 ns |  0.0620 ns | 1,328.995 ns |   5.29 |     0.01 |
|                                  LinqToArray |         [1000] | 3,000.239 ns |  7.3982 ns |  6.5584 ns | 3,003.182 ns |  11.95 |     0.03 |
|               LowCostLinqWithDelegateToArray |         [1000] | 3,666.426 ns | 53.7809 ns | 50.3066 ns | 3,632.305 ns |  14.61 |     0.19 |
|                 LowCostLinqWithStructToArray |         [1000] | 2,189.565 ns |  1.5180 ns |  1.4199 ns | 2,188.902 ns |   8.72 |     0.01 |
|                                         Take |         [1000] |   263.618 ns |  0.0425 ns |  0.0355 ns |   263.616 ns |   1.05 |     0.00 |
|                                  LowCostTake |         [1000] |    93.747 ns |  0.0067 ns |  0.0063 ns |    93.748 ns |   0.37 |     0.00 |
|                        LowCostTakeWithStruct |         [1000] |    62.737 ns |  0.7314 ns |  0.6842 ns |    62.347 ns |   0.25 |     0.00 |
|                               SkipTakeSingle |         [1000] |   181.783 ns |  0.0326 ns |  0.0305 ns |   181.784 ns |   0.72 |     0.00 |
|                        LowCostSkipTakeSingle |         [1000] |   100.363 ns |  0.0173 ns |  0.0153 ns |   100.361 ns |   0.40 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    54.716 ns |  0.0215 ns |  0.0190 ns |    54.706 ns |   0.22 |     0.00 |
|                              ForeachDelegate |         [1000] | 1,454.263 ns | 12.6501 ns | 11.8329 ns | 1,449.160 ns |   5.79 |     0.05 |
|                                      Foreach |         [1000] |   482.050 ns |  1.0135 ns |  0.9480 ns |   481.954 ns |   1.92 |     0.00 |
|                                          For |         [1000] |   251.000 ns |  0.3949 ns |  0.3694 ns |   250.950 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |              |        |          |
|                                         **Linq** |           **[50]** |   **338.103 ns** |  **0.0353 ns** |  **0.0313 ns** |   **338.095 ns** |  **22.24** |     **0.00** |
|                      LowCostLinqWithDelegate |           [50] |   185.851 ns |  0.9942 ns |  0.8302 ns |   185.546 ns |  12.23 |     0.05 |
|                     LowCostLinqWithDelegate2 |           [50] |   197.975 ns |  0.0240 ns |  0.0213 ns |   197.976 ns |  13.02 |     0.00 |
|                   LowCostLinqWithStructWhere |           [50] |    92.662 ns |  0.2841 ns |  0.2658 ns |    92.457 ns |   6.10 |     0.02 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   449.427 ns |  0.2903 ns |  0.2715 ns |   449.306 ns |  29.57 |     0.02 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   332.422 ns |  0.5800 ns |  0.5425 ns |   332.200 ns |  21.87 |     0.03 |
|                                    LinqCount |           [50] |   137.001 ns |  1.1516 ns |  1.0772 ns |   137.399 ns |   9.01 |     0.07 |
|                 LowCostLinqWithDelegateCount |           [50] |   129.731 ns |  0.2091 ns |  0.1956 ns |   129.797 ns |   8.54 |     0.01 |
|              LowCostLinqWithStructWhereCount |           [50] |    67.018 ns |  0.0119 ns |  0.0105 ns |    67.016 ns |   4.41 |     0.00 |
|                                  LinqToArray |           [50] |   355.055 ns |  6.4341 ns |  6.0185 ns |   354.261 ns |  23.36 |     0.38 |
|               LowCostLinqWithDelegateToArray |           [50] |   272.952 ns |  0.2204 ns |  0.1954 ns |   272.993 ns |  17.96 |     0.01 |
|                 LowCostLinqWithStructToArray |           [50] |   188.446 ns |  0.4965 ns |  0.4644 ns |   188.621 ns |  12.40 |     0.03 |
|                                         Take |           [50] |   263.634 ns |  0.0701 ns |  0.0621 ns |   263.644 ns |  17.34 |     0.01 |
|                                  LowCostTake |           [50] |    97.509 ns |  0.0548 ns |  0.0486 ns |    97.522 ns |   6.42 |     0.00 |
|                        LowCostTakeWithStruct |           [50] |    63.003 ns |  0.1722 ns |  0.1610 ns |    62.930 ns |   4.15 |     0.01 |
|                               SkipTakeSingle |           [50] |   181.772 ns |  0.5052 ns |  0.4725 ns |   181.496 ns |  11.96 |     0.03 |
|                        LowCostSkipTakeSingle |           [50] |   100.995 ns |  0.7899 ns |  0.7389 ns |   100.421 ns |   6.64 |     0.05 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    57.384 ns |  0.0134 ns |  0.0125 ns |    57.388 ns |   3.78 |     0.00 |
|                              ForeachDelegate |           [50] |    81.836 ns |  0.0112 ns |  0.0093 ns |    81.835 ns |   5.38 |     0.00 |
|                                      Foreach |           [50] |    27.330 ns |  0.2335 ns |  0.2184 ns |    27.219 ns |   1.80 |     0.01 |
|                                          For |           [50] |    15.200 ns |  0.0037 ns |  0.0029 ns |    15.199 ns |   1.00 |     0.00 |
|                                              |                |              |            |            |              |        |          |
|                                         **Linq** |            **[5]** |    **58.754 ns** |  **0.1012 ns** |  **0.0946 ns** |    **58.789 ns** |  **13.03** |     **0.02** |
|                      LowCostLinqWithDelegate |            [5] |    34.976 ns |  0.0677 ns |  0.0565 ns |    34.956 ns |   7.76 |     0.01 |
|                     LowCostLinqWithDelegate2 |            [5] |    45.315 ns |  0.0029 ns |  0.0025 ns |    45.316 ns |  10.05 |     0.00 |
|                   LowCostLinqWithStructWhere |            [5] |    28.138 ns |  0.0131 ns |  0.0110 ns |    28.137 ns |   6.24 |     0.00 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    77.384 ns |  0.1769 ns |  0.1655 ns |    77.426 ns |  17.16 |     0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    68.459 ns |  1.1836 ns |  1.1071 ns |    67.756 ns |  15.18 |     0.24 |
|                                    LinqCount |            [5] |    41.477 ns |  0.0085 ns |  0.0079 ns |    41.480 ns |   9.20 |     0.00 |
|                 LowCostLinqWithDelegateCount |            [5] |    28.074 ns |  0.0111 ns |  0.0098 ns |    28.073 ns |   6.23 |     0.00 |
|              LowCostLinqWithStructWhereCount |            [5] |    19.042 ns |  0.1897 ns |  0.1774 ns |    18.955 ns |   4.22 |     0.04 |
|                                  LinqToArray |            [5] |    95.144 ns |  0.0510 ns |  0.0452 ns |    95.129 ns |  21.10 |     0.01 |
|               LowCostLinqWithDelegateToArray |            [5] |    62.015 ns |  0.0355 ns |  0.0296 ns |    61.999 ns |  13.75 |     0.01 |
|                 LowCostLinqWithStructToArray |            [5] |    51.433 ns |  0.1472 ns |  0.1377 ns |    51.420 ns |  11.40 |     0.03 |
|                                         Take |            [5] |   112.408 ns |  0.0422 ns |  0.0395 ns |   112.400 ns |  24.92 |     0.01 |
|                                  LowCostTake |            [5] |    43.164 ns |  0.0094 ns |  0.0088 ns |    43.166 ns |   9.57 |     0.00 |
|                        LowCostTakeWithStruct |            [5] |    36.224 ns |  0.0292 ns |  0.0228 ns |    36.218 ns |   8.03 |     0.01 |
|                               SkipTakeSingle |            [5] |   108.178 ns |  0.1617 ns |  0.1263 ns |   108.145 ns |  23.99 |     0.03 |
|                        LowCostSkipTakeSingle |            [5] |    40.298 ns |  0.0054 ns |  0.0045 ns |    40.298 ns |   8.94 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    36.665 ns |  0.0215 ns |  0.0201 ns |    36.669 ns |   8.13 |     0.00 |
|                              ForeachDelegate |            [5] |    13.565 ns |  0.0072 ns |  0.0060 ns |    13.562 ns |   3.01 |     0.00 |
|                                      Foreach |            [5] |     5.652 ns |  0.0023 ns |  0.0022 ns |     5.652 ns |   1.25 |     0.00 |
|                                          For |            [5] |     4.510 ns |  0.0017 ns |  0.0013 ns |     4.510 ns |   1.00 |     0.00 |
