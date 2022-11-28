``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19045.2311)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100
  [Host]     : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev | Ratio | RatioSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|------:|--------:|
|                                         **Linq** |            **[0]** |    **10.5862 ns** |  **0.0012 ns** |  **0.0011 ns** | **37.12** |    **0.01** |
|                      LowCostLinqWithDelegate |            [0] |     9.6461 ns |  0.0003 ns |  0.0003 ns | 33.82 |    0.01 |
|                     LowCostLinqWithDelegate2 |            [0] |    17.2683 ns |  0.0006 ns |  0.0006 ns | 60.55 |    0.01 |
|                   LowCostLinqWithStructWhere |            [0] |    14.4098 ns |  0.0006 ns |  0.0006 ns | 50.52 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |    22.0665 ns |  0.0077 ns |  0.0068 ns | 77.37 |    0.03 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    21.2898 ns |  0.0175 ns |  0.0155 ns | 74.64 |    0.06 |
|                                    LinqCount |            [0] |    11.4113 ns |  0.0196 ns |  0.0183 ns | 40.01 |    0.06 |
|                 LowCostLinqWithDelegateCount |            [0] |     7.5096 ns |  0.0019 ns |  0.0017 ns | 26.33 |    0.01 |
|              LowCostLinqWithStructWhereCount |            [0] |     7.5241 ns |  0.0004 ns |  0.0004 ns | 26.38 |    0.01 |
|                                  LinqToArray |            [0] |     7.3850 ns |  0.0189 ns |  0.0177 ns | 25.89 |    0.06 |
|               LowCostLinqWithDelegateToArray |            [0] |    10.1586 ns |  0.0057 ns |  0.0047 ns | 35.62 |    0.02 |
|                 LowCostLinqWithStructToArray |            [0] |     9.7444 ns |  0.0271 ns |  0.0254 ns | 34.17 |    0.09 |
|                                         Take |            [0] |    15.4146 ns |  0.0084 ns |  0.0078 ns | 54.05 |    0.03 |
|                                  LowCostTake |            [0] |    16.3495 ns |  0.0156 ns |  0.0138 ns | 57.32 |    0.05 |
|                        LowCostTakeWithStruct |            [0] |    20.6046 ns |  0.0008 ns |  0.0007 ns | 72.24 |    0.02 |
|                               SkipTakeSingle |            [0] |    23.1383 ns |  0.0420 ns |  0.0393 ns | 81.13 |    0.14 |
|                        LowCostSkipTakeSingle |            [0] |    20.2614 ns |  0.0035 ns |  0.0033 ns | 71.04 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |            [0] |    25.4562 ns |  0.0007 ns |  0.0007 ns | 89.25 |    0.02 |
|                              ForeachDelegate |            [0] |     1.1171 ns |  0.0001 ns |  0.0001 ns |  3.92 |    0.00 |
|                                      Foreach |            [0] |     0.4978 ns |  0.0056 ns |  0.0049 ns |  1.75 |    0.02 |
|                                          For |            [0] |     0.2852 ns |  0.0001 ns |  0.0001 ns |  1.00 |    0.00 |
|                                              |                |               |            |            |       |         |
|                                         **Linq** |         **[1000]** | **5,518.0878 ns** |  **2.1635 ns** |  **1.9179 ns** | **22.27** |    **0.01** |
|                      LowCostLinqWithDelegate |         [1000] | 2,308.4972 ns | 19.7673 ns | 18.4903 ns |  9.32 |    0.07 |
|                     LowCostLinqWithDelegate2 |         [1000] | 2,243.4406 ns | 10.1399 ns |  8.9888 ns |  9.06 |    0.04 |
|                   LowCostLinqWithStructWhere |         [1000] | 1,204.1823 ns |  7.4578 ns |  6.6111 ns |  4.86 |    0.03 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 5,046.5625 ns |  1.3405 ns |  1.1883 ns | 20.37 |    0.00 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] | 3,747.6374 ns |  0.4824 ns |  0.4276 ns | 15.13 |    0.00 |
|                                    LinqCount |         [1000] | 1,696.7520 ns |  2.8911 ns |  2.7044 ns |  6.85 |    0.01 |
|                 LowCostLinqWithDelegateCount |         [1000] | 1,682.0284 ns |  0.3257 ns |  0.2720 ns |  6.79 |    0.00 |
|              LowCostLinqWithStructWhereCount |         [1000] |   371.3762 ns |  0.0163 ns |  0.0145 ns |  1.50 |    0.00 |
|                                  LinqToArray |         [1000] | 2,547.4569 ns |  2.8452 ns |  2.6614 ns | 10.28 |    0.01 |
|               LowCostLinqWithDelegateToArray |         [1000] | 2,806.0712 ns |  1.4707 ns |  1.1482 ns | 11.33 |    0.00 |
|                 LowCostLinqWithStructToArray |         [1000] | 1,378.4169 ns |  0.5330 ns |  0.4725 ns |  5.56 |    0.00 |
|                                         Take |         [1000] |   246.5360 ns |  0.0640 ns |  0.0534 ns |  1.00 |    0.00 |
|                                  LowCostTake |         [1000] |    64.9593 ns |  0.0228 ns |  0.0214 ns |  0.26 |    0.00 |
|                        LowCostTakeWithStruct |         [1000] |    45.9483 ns |  0.0298 ns |  0.0278 ns |  0.19 |    0.00 |
|                               SkipTakeSingle |         [1000] |   153.7440 ns |  0.0235 ns |  0.0184 ns |  0.62 |    0.00 |
|                        LowCostSkipTakeSingle |         [1000] |    71.9163 ns |  0.0985 ns |  0.0921 ns |  0.29 |    0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    51.9210 ns |  0.0218 ns |  0.0182 ns |  0.21 |    0.00 |
|                              ForeachDelegate |         [1000] | 1,911.2021 ns |  0.0622 ns |  0.0551 ns |  7.71 |    0.00 |
|                                      Foreach |         [1000] |   247.8747 ns |  0.0365 ns |  0.0341 ns |  1.00 |    0.00 |
|                                          For |         [1000] |   247.7522 ns |  0.0147 ns |  0.0137 ns |  1.00 |    0.00 |
|                                              |                |               |            |            |       |         |
|                                         **Linq** |           **[50]** |   **299.8060 ns** |  **0.0831 ns** |  **0.0736 ns** | **19.02** |    **0.12** |
|                      LowCostLinqWithDelegate |           [50] |   123.8467 ns |  0.0216 ns |  0.0202 ns |  7.86 |    0.05 |
|                     LowCostLinqWithDelegate2 |           [50] |   143.6898 ns |  0.0457 ns |  0.0428 ns |  9.11 |    0.05 |
|                   LowCostLinqWithStructWhere |           [50] |    82.5634 ns |  0.0413 ns |  0.0323 ns |  5.24 |    0.03 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |   273.5117 ns |  0.2913 ns |  0.2274 ns | 17.36 |    0.11 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |   213.1895 ns |  0.0518 ns |  0.0459 ns | 13.53 |    0.08 |
|                                    LinqCount |           [50] |   108.1830 ns |  0.2910 ns |  0.2722 ns |  6.86 |    0.05 |
|                 LowCostLinqWithDelegateCount |           [50] |   105.0165 ns |  0.0433 ns |  0.0384 ns |  6.66 |    0.04 |
|              LowCostLinqWithStructWhereCount |           [50] |    28.6239 ns |  0.0258 ns |  0.0241 ns |  1.82 |    0.01 |
|                                  LinqToArray |           [50] |   248.6232 ns |  0.4406 ns |  0.4121 ns | 15.77 |    0.10 |
|               LowCostLinqWithDelegateToArray |           [50] |   208.2573 ns |  0.2271 ns |  0.2124 ns | 13.21 |    0.08 |
|                 LowCostLinqWithStructToArray |           [50] |   125.6991 ns |  0.0835 ns |  0.0652 ns |  7.98 |    0.05 |
|                                         Take |           [50] |   244.5945 ns |  0.0787 ns |  0.0658 ns | 15.53 |    0.09 |
|                                  LowCostTake |           [50] |    64.7219 ns |  0.0126 ns |  0.0118 ns |  4.11 |    0.02 |
|                        LowCostTakeWithStruct |           [50] |    46.4560 ns |  0.0231 ns |  0.0204 ns |  2.95 |    0.02 |
|                               SkipTakeSingle |           [50] |   153.7365 ns |  0.0869 ns |  0.0678 ns |  9.76 |    0.06 |
|                        LowCostSkipTakeSingle |           [50] |    74.7546 ns |  0.0368 ns |  0.0326 ns |  4.74 |    0.03 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    51.9368 ns |  0.0365 ns |  0.0341 ns |  3.29 |    0.02 |
|                              ForeachDelegate |           [50] |    99.3848 ns |  0.0027 ns |  0.0024 ns |  6.31 |    0.04 |
|                                      Foreach |           [50] |    13.5473 ns |  0.0390 ns |  0.0305 ns |  0.86 |    0.01 |
|                                          For |           [50] |    15.7666 ns |  0.1015 ns |  0.0950 ns |  1.00 |    0.00 |
|                                              |                |               |            |            |       |         |
|                                         **Linq** |            **[5]** |    **47.3356 ns** |  **0.0480 ns** |  **0.0449 ns** | **23.17** |    **0.03** |
|                      LowCostLinqWithDelegate |            [5] |    20.4430 ns |  0.0307 ns |  0.0287 ns | 10.01 |    0.02 |
|                     LowCostLinqWithDelegate2 |            [5] |    29.2333 ns |  0.0223 ns |  0.0197 ns | 14.31 |    0.02 |
|                   LowCostLinqWithStructWhere |            [5] |    20.3635 ns |  0.0007 ns |  0.0007 ns |  9.97 |    0.01 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    47.2726 ns |  0.0533 ns |  0.0445 ns | 23.14 |    0.04 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    38.5294 ns |  0.0363 ns |  0.0339 ns | 18.86 |    0.03 |
|                                    LinqCount |            [5] |    27.1210 ns |  0.0159 ns |  0.0141 ns | 13.28 |    0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |    16.2840 ns |  0.0184 ns |  0.0172 ns |  7.97 |    0.02 |
|              LowCostLinqWithStructWhereCount |            [5] |     9.3357 ns |  0.0011 ns |  0.0011 ns |  4.57 |    0.01 |
|                                  LinqToArray |            [5] |    57.2726 ns |  0.0452 ns |  0.0401 ns | 28.04 |    0.04 |
|               LowCostLinqWithDelegateToArray |            [5] |    49.6824 ns |  0.0520 ns |  0.0487 ns | 24.32 |    0.03 |
|                 LowCostLinqWithStructToArray |            [5] |    41.4949 ns |  0.0595 ns |  0.0528 ns | 20.31 |    0.03 |
|                                         Take |            [5] |    91.2698 ns |  0.0693 ns |  0.0649 ns | 44.68 |    0.07 |
|                                  LowCostTake |            [5] |    27.4223 ns |  0.0146 ns |  0.0137 ns | 13.42 |    0.02 |
|                        LowCostTakeWithStruct |            [5] |    26.9240 ns |  0.0007 ns |  0.0006 ns | 13.18 |    0.02 |
|                               SkipTakeSingle |            [5] |    80.1352 ns |  0.0699 ns |  0.0654 ns | 39.23 |    0.05 |
|                        LowCostSkipTakeSingle |            [5] |    27.3970 ns |  0.0073 ns |  0.0068 ns | 13.41 |    0.02 |
|              LowCostSkipTakeSingleWithStruct |            [5] |    30.0967 ns |  0.0007 ns |  0.0006 ns | 14.73 |    0.02 |
|                              ForeachDelegate |            [5] |    10.0408 ns |  0.0154 ns |  0.0144 ns |  4.92 |    0.01 |
|                                      Foreach |            [5] |     2.2201 ns |  0.0078 ns |  0.0073 ns |  1.09 |    0.00 |
|                                          For |            [5] |     2.0427 ns |  0.0026 ns |  0.0024 ns |  1.00 |    0.00 |
