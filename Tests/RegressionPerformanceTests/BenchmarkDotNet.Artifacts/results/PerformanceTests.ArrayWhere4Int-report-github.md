``` ini

BenchmarkDotNet=v0.11.0, OS=Windows 10.0.17134.228 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914070 Hz, Resolution=255.4885 ns, Timer=TSC
.NET Core SDK=2.1.302
  [Host]     : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.2 (CoreCLR 4.6.26628.05, CoreFX 4.6.26629.01), 64bit RyuJIT


```
|                                       Method | CollectionSize |          Mean |      Error |     StdDev |        Median | Scaled | ScaledSD |
|--------------------------------------------- |--------------- |--------------:|-----------:|-----------:|--------------:|-------:|---------:|
|                                         **Linq** |            **[0]** |    **101.412 ns** |  **0.1024 ns** |  **0.0958 ns** |    **101.376 ns** |  **27.20** |     **0.33** |
|                      LowCostLinqWithDelegate |            [0] |     32.751 ns |  0.3108 ns |  0.2908 ns |     32.666 ns |   8.78 |     0.13 |
|                     LowCostLinqWithDelegate2 |            [0] |     56.854 ns |  0.0026 ns |  0.0024 ns |     56.854 ns |  15.25 |     0.18 |
|                   LowCostLinqWithStructWhere |            [0] |     42.548 ns |  0.0019 ns |  0.0017 ns |     42.547 ns |  11.41 |     0.14 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [0] |     64.875 ns |  0.0560 ns |  0.0524 ns |     64.862 ns |  17.40 |     0.21 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [0] |     67.791 ns |  0.9901 ns |  0.9262 ns |     67.136 ns |  18.18 |     0.33 |
|                                    LinqCount |            [0] |    103.974 ns |  0.1218 ns |  0.1139 ns |    103.953 ns |  27.88 |     0.34 |
|                 LowCostLinqWithDelegateCount |            [0] |     29.490 ns |  0.0041 ns |  0.0032 ns |     29.490 ns |   7.91 |     0.10 |
|              LowCostLinqWithStructWhereCount |            [0] |     35.932 ns |  0.0016 ns |  0.0015 ns |     35.932 ns |   9.64 |     0.12 |
|                                  LinqToArray |            [0] |    119.724 ns |  0.1372 ns |  0.1145 ns |    119.757 ns |  32.11 |     0.39 |
|               LowCostLinqWithDelegateToArray |            [0] |     32.824 ns |  0.0510 ns |  0.0452 ns |     32.808 ns |   8.80 |     0.11 |
|                 LowCostLinqWithStructToArray |            [0] |     39.162 ns |  0.0088 ns |  0.0078 ns |     39.160 ns |  10.50 |     0.13 |
|                                         Take |            [0] |    141.220 ns |  0.0585 ns |  0.0547 ns |    141.210 ns |  37.87 |     0.46 |
|                                  LowCostTake |            [0] |     45.511 ns |  0.3914 ns |  0.3661 ns |     45.408 ns |  12.21 |     0.18 |
|                        LowCostTakeWithStruct |            [0] |     56.024 ns |  0.0044 ns |  0.0041 ns |     56.025 ns |  15.02 |     0.18 |
|                               SkipTakeSingle |            [0] |    161.242 ns |  0.0308 ns |  0.0273 ns |    161.241 ns |  43.24 |     0.52 |
|                        LowCostSkipTakeSingle |            [0] |     59.619 ns |  0.0678 ns |  0.0634 ns |     59.654 ns |  15.99 |     0.19 |
|              LowCostSkipTakeSingleWithStruct |            [0] |     67.585 ns |  0.0834 ns |  0.0651 ns |     67.565 ns |  18.13 |     0.22 |
|                              ForeachDelegate |            [0] |      7.793 ns |  0.0036 ns |  0.0034 ns |      7.795 ns |   2.09 |     0.03 |
|                                      Foreach |            [0] |      3.765 ns |  0.0014 ns |  0.0012 ns |      3.765 ns |   1.01 |     0.01 |
|                                          For |            [0] |      3.729 ns |  0.0503 ns |  0.0471 ns |      3.694 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |         **[1000]** | **11,919.443 ns** |  **5.0998 ns** |  **4.7704 ns** | **11,920.798 ns** |  **47.55** |     **0.02** |
|                      LowCostLinqWithDelegate |         [1000] |  9,051.583 ns | 41.2629 ns | 38.5973 ns |  9,043.539 ns |  36.11 |     0.15 |
|                     LowCostLinqWithDelegate2 |         [1000] | 10,662.821 ns |  7.8701 ns |  6.9767 ns | 10,663.540 ns |  42.53 |     0.03 |
|                   LowCostLinqWithStructWhere |         [1000] |  1,499.513 ns | 12.4710 ns | 11.6654 ns |  1,491.195 ns |   5.98 |     0.04 |
|     LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 20,343.929 ns | 29.3575 ns | 27.4610 ns | 20,336.615 ns |  81.15 |     0.11 |
| LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  5,792.764 ns |  1.5922 ns |  1.4893 ns |  5,792.347 ns |  23.11 |     0.01 |
|                                    LinqCount |         [1000] |  9,218.168 ns |  4.4208 ns |  3.9189 ns |  9,217.686 ns |  36.77 |     0.02 |
|                 LowCostLinqWithDelegateCount |         [1000] |  9,492.577 ns | 96.9762 ns | 90.7116 ns |  9,519.325 ns |  37.87 |     0.35 |
|              LowCostLinqWithStructWhereCount |         [1000] |  1,356.653 ns |  0.0534 ns |  0.0500 ns |  1,356.660 ns |   5.41 |     0.00 |
|                                  LinqToArray |         [1000] | 10,514.065 ns |  7.0592 ns |  6.6032 ns | 10,514.374 ns |  41.94 |     0.03 |
|               LowCostLinqWithDelegateToArray |         [1000] | 10,466.038 ns |  4.9669 ns |  4.4030 ns | 10,465.319 ns |  41.75 |     0.02 |
|                 LowCostLinqWithStructToArray |         [1000] |  2,280.613 ns | 35.3768 ns | 33.0915 ns |  2,300.270 ns |   9.10 |     0.13 |
|                                         Take |         [1000] |    497.295 ns |  0.1284 ns |  0.1201 ns |    497.257 ns |   1.98 |     0.00 |
|                                  LowCostTake |         [1000] |    277.614 ns |  0.0610 ns |  0.0571 ns |    277.612 ns |   1.11 |     0.00 |
|                        LowCostTakeWithStruct |         [1000] |     95.217 ns |  0.0078 ns |  0.0073 ns |     95.215 ns |   0.38 |     0.00 |
|                               SkipTakeSingle |         [1000] |    414.097 ns |  7.6404 ns |  7.1469 ns |    408.580 ns |   1.65 |     0.03 |
|                        LowCostSkipTakeSingle |         [1000] |    299.523 ns |  0.0487 ns |  0.0432 ns |    299.537 ns |   1.19 |     0.00 |
|              LowCostSkipTakeSingleWithStruct |         [1000] |    128.369 ns |  0.1088 ns |  0.0965 ns |    128.346 ns |   0.51 |     0.00 |
|                              ForeachDelegate |         [1000] |  6,221.791 ns |  0.2769 ns |  0.2312 ns |  6,221.864 ns |  24.82 |     0.00 |
|                                      Foreach |         [1000] |    479.354 ns |  6.6070 ns |  6.1802 ns |    480.994 ns |   1.91 |     0.02 |
|                                          For |         [1000] |    250.686 ns |  0.0108 ns |  0.0090 ns |    250.686 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |           **[50]** |    **702.946 ns** |  **0.4307 ns** |  **0.3596 ns** |    **702.836 ns** |  **45.72** |     **0.61** |
|                      LowCostLinqWithDelegate |           [50] |    475.512 ns |  0.5195 ns |  0.4860 ns |    475.465 ns |  30.93 |     0.41 |
|                     LowCostLinqWithDelegate2 |           [50] |    587.686 ns |  0.2024 ns |  0.1690 ns |    587.655 ns |  38.23 |     0.51 |
|                   LowCostLinqWithStructWhere |           [50] |    113.920 ns |  0.0089 ns |  0.0079 ns |    113.919 ns |   7.41 |     0.10 |
|     LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,115.666 ns |  1.9982 ns |  1.8692 ns |  1,115.828 ns |  72.57 |     0.97 |
| LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    359.614 ns |  0.0827 ns |  0.0733 ns |    359.592 ns |  23.39 |     0.31 |
|                                    LinqCount |           [50] |    571.740 ns |  9.3875 ns |  8.7811 ns |    565.938 ns |  37.19 |     0.74 |
|                 LowCostLinqWithDelegateCount |           [50] |    497.594 ns |  0.0377 ns |  0.0353 ns |    497.588 ns |  32.37 |     0.43 |
|              LowCostLinqWithStructWhereCount |           [50] |     89.179 ns |  0.1798 ns |  0.1682 ns |     89.271 ns |   5.80 |     0.08 |
|                                  LinqToArray |           [50] |    852.291 ns |  7.3406 ns |  6.5072 ns |    849.257 ns |  55.44 |     0.84 |
|               LowCostLinqWithDelegateToArray |           [50] |    665.123 ns |  1.8914 ns |  1.7692 ns |    664.269 ns |  43.26 |     0.59 |
|                 LowCostLinqWithStructToArray |           [50] |    206.857 ns |  0.2482 ns |  0.2200 ns |    206.830 ns |  13.46 |     0.18 |
|                                         Take |           [50] |    497.102 ns |  0.1033 ns |  0.0916 ns |    497.084 ns |  32.33 |     0.43 |
|                                  LowCostTake |           [50] |    268.626 ns |  0.1336 ns |  0.1185 ns |    268.657 ns |  17.47 |     0.23 |
|                        LowCostTakeWithStruct |           [50] |     91.634 ns |  0.0130 ns |  0.0102 ns |     91.635 ns |   5.96 |     0.08 |
|                               SkipTakeSingle |           [50] |    408.014 ns |  0.0912 ns |  0.0853 ns |    408.018 ns |  26.54 |     0.35 |
|                        LowCostSkipTakeSingle |           [50] |    299.009 ns |  0.1390 ns |  0.1086 ns |    299.002 ns |  19.45 |     0.26 |
|              LowCostSkipTakeSingleWithStruct |           [50] |    129.307 ns |  1.2754 ns |  1.1930 ns |    128.556 ns |   8.41 |     0.13 |
|                              ForeachDelegate |           [50] |    322.769 ns |  0.0726 ns |  0.0606 ns |    322.755 ns |  20.99 |     0.28 |
|                                      Foreach |           [50] |     26.874 ns |  0.0263 ns |  0.0246 ns |     26.875 ns |   1.75 |     0.02 |
|                                          For |           [50] |     15.376 ns |  0.2283 ns |  0.2136 ns |     15.277 ns |   1.00 |     0.00 |
|                                              |                |               |            |            |               |        |          |
|                                         **Linq** |            **[5]** |    **164.342 ns** |  **0.0854 ns** |  **0.0713 ns** |    **164.350 ns** |  **36.59** |     **0.02** |
|                      LowCostLinqWithDelegate |            [5] |     71.906 ns |  0.1060 ns |  0.0991 ns |     71.842 ns |  16.01 |     0.02 |
|                     LowCostLinqWithDelegate2 |            [5] |    107.036 ns |  0.0538 ns |  0.0449 ns |    107.056 ns |  23.83 |     0.01 |
|                   LowCostLinqWithStructWhere |            [5] |     51.570 ns |  0.3190 ns |  0.2983 ns |     51.673 ns |  11.48 |     0.06 |
|     LowCostLinqWithDelegateCastToIEnumerable |            [5] |    176.937 ns |  0.0727 ns |  0.0680 ns |    176.907 ns |  39.40 |     0.01 |
| LowCostLinqWithStructFilterCastToIEnumerable |            [5] |     92.591 ns |  0.1720 ns |  0.1609 ns |     92.632 ns |  20.62 |     0.03 |
|                                    LinqCount |            [5] |    150.673 ns |  0.0655 ns |  0.0613 ns |    150.667 ns |  33.55 |     0.01 |
|                 LowCostLinqWithDelegateCount |            [5] |     74.516 ns |  0.8105 ns |  0.7581 ns |     74.449 ns |  16.59 |     0.16 |
|              LowCostLinqWithStructWhereCount |            [5] |     39.252 ns |  0.0133 ns |  0.0124 ns |     39.254 ns |   8.74 |     0.00 |
|                                  LinqToArray |            [5] |    211.054 ns |  0.6630 ns |  0.6201 ns |    211.303 ns |  46.99 |     0.13 |
|               LowCostLinqWithDelegateToArray |            [5] |    107.873 ns |  1.7022 ns |  1.5922 ns |    106.804 ns |  24.02 |     0.34 |
|                 LowCostLinqWithStructToArray |            [5] |     71.049 ns |  0.0146 ns |  0.0136 ns |     71.044 ns |  15.82 |     0.00 |
|                                         Take |            [5] |    241.237 ns |  0.2092 ns |  0.1855 ns |    241.196 ns |  53.71 |     0.04 |
|                                  LowCostTake |            [5] |     94.615 ns |  0.1132 ns |  0.1004 ns |     94.640 ns |  21.07 |     0.02 |
|                        LowCostTakeWithStruct |            [5] |     65.626 ns |  0.6052 ns |  0.5661 ns |     65.212 ns |  14.61 |     0.12 |
|                               SkipTakeSingle |            [5] |    227.479 ns |  0.3045 ns |  0.2542 ns |    227.587 ns |  50.65 |     0.05 |
|                        LowCostSkipTakeSingle |            [5] |    110.771 ns |  0.0738 ns |  0.0616 ns |    110.773 ns |  24.66 |     0.01 |
|              LowCostSkipTakeSingleWithStruct |            [5] |     77.926 ns |  0.0036 ns |  0.0032 ns |     77.925 ns |  17.35 |     0.00 |
|                              ForeachDelegate |            [5] |     38.699 ns |  0.0203 ns |  0.0190 ns |     38.706 ns |   8.62 |     0.00 |
|                                      Foreach |            [5] |      5.680 ns |  0.0077 ns |  0.0072 ns |      5.682 ns |   1.26 |     0.00 |
|                                          For |            [5] |      4.491 ns |  0.0003 ns |  0.0003 ns |      4.491 ns |   1.00 |     0.00 |
