``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17763.529 (1809/October2018Update/Redstone5)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.2.5 (CoreCLR 4.6.27617.05, CoreFX 4.6.27618.01), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |         Error |        StdDev |       Median | Ratio | RatioSD |
|---------------------------------------------------------- |--------------- |-------------:|--------------:|--------------:|-------------:|------:|--------:|
|                                                      **Linq** |            **[0]** |    **124.64 ns** |     **0.1376 ns** |     **0.1074 ns** |    **124.59 ns** |  **7.42** |    **0.02** |
|                                   LowCostLinqWithDelegate |            [0] |     46.16 ns |     0.0153 ns |     0.0136 ns |     46.16 ns |  2.75 |    0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |            [0] |     43.41 ns |     0.0115 ns |     0.0108 ns |     43.41 ns |  2.58 |    0.01 |
|                                  LowCostLinqWithDelegate2 |            [0] |     73.25 ns |     0.0106 ns |     0.0100 ns |     73.25 ns |  4.36 |    0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [0] |     72.15 ns |     0.9537 ns |     0.8455 ns |     72.14 ns |  4.30 |    0.06 |
|                                LowCostLinqWithStructWhere |            [0] |     56.42 ns |     0.0154 ns |     0.0129 ns |     56.42 ns |  3.36 |    0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [0] |     51.84 ns |     0.0092 ns |     0.0081 ns |     51.84 ns |  3.08 |    0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [0] |    122.33 ns |     0.0530 ns |     0.0496 ns |    122.32 ns |  7.28 |    0.02 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [0] |    118.11 ns |     0.1327 ns |     0.1036 ns |    118.08 ns |  7.03 |    0.02 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [0] |    113.30 ns |     0.0418 ns |     0.0391 ns |    113.29 ns |  6.74 |    0.02 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [0] |    110.06 ns |     0.0315 ns |     0.0279 ns |    110.05 ns |  6.55 |    0.02 |
|                                                 LinqCount |            [0] |    129.30 ns |     2.5566 ns |     2.7356 ns |    129.59 ns |  7.67 |    0.17 |
|                              LowCostLinqWithDelegateCount |            [0] |     44.22 ns |     0.0340 ns |     0.0318 ns |     44.22 ns |  2.63 |    0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [0] |     40.79 ns |     0.0122 ns |     0.0114 ns |     40.79 ns |  2.43 |    0.01 |
|                           LowCostLinqWithStructWhereCount |            [0] |     53.05 ns |     0.0627 ns |     0.0586 ns |     53.01 ns |  3.16 |    0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [0] |     44.85 ns |     0.0422 ns |     0.0374 ns |     44.83 ns |  2.67 |    0.01 |
|                                               LinqToArray |            [0] |    139.87 ns |     0.8653 ns |     0.7226 ns |    139.52 ns |  8.32 |    0.06 |
|                            LowCostLinqWithDelegateToArray |            [0] |     52.45 ns |     0.0575 ns |     0.0538 ns |     52.45 ns |  3.12 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [0] |     50.86 ns |     0.0208 ns |     0.0184 ns |     50.87 ns |  3.03 |    0.01 |
|                              LowCostLinqWithStructToArray |            [0] |     63.22 ns |     0.0127 ns |     0.0119 ns |     63.22 ns |  3.76 |    0.01 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [0] |     54.87 ns |     0.0781 ns |     0.0731 ns |     54.89 ns |  3.27 |    0.01 |
|                                                      Take |            [0] |    159.81 ns |     0.0697 ns |     0.0618 ns |    159.79 ns |  9.51 |    0.03 |
|                                               LowCostTake |            [0] |     59.37 ns |     0.0086 ns |     0.0077 ns |     59.37 ns |  3.53 |    0.01 |
|                                  LowCostTakeWithoutChecks |            [0] |     55.36 ns |     0.0186 ns |     0.0165 ns |     55.36 ns |  3.29 |    0.01 |
|                                     LowCostTakeWithStruct |            [0] |     69.96 ns |     0.0412 ns |     0.0344 ns |     69.96 ns |  4.16 |    0.01 |
|                        LowCostTakeWithStructWithoutChecks |            [0] |     65.56 ns |     0.0162 ns |     0.0143 ns |     65.56 ns |  3.90 |    0.01 |
|                                            SkipTakeSingle |            [0] |    186.19 ns |     0.0939 ns |     0.0878 ns |    186.17 ns | 11.08 |    0.03 |
|                                     LowCostSkipTakeSingle |            [0] |     78.89 ns |     1.1196 ns |     1.0473 ns |     78.47 ns |  4.68 |    0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |            [0] |     75.32 ns |     0.0152 ns |     0.0143 ns |     75.32 ns |  4.48 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |            [0] |     80.34 ns |     0.0531 ns |     0.0443 ns |     80.33 ns |  4.78 |    0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [0] |     78.91 ns |     0.1970 ns |     0.1747 ns |     78.99 ns |  4.69 |    0.02 |
|                                           ForeachDelegate |            [0] |     20.83 ns |     0.4428 ns |     0.4548 ns |     20.54 ns |  1.25 |    0.03 |
|                                                   Foreach |            [0] |     16.80 ns |     0.0620 ns |     0.0517 ns |     16.78 ns |  1.00 |    0.00 |
|                                                           |                |              |               |               |              |       |         |
|                                                      **Linq** |         **[1000]** | **15,285.83 ns** |   **360.9803 ns** |   **456.5244 ns** | **15,259.37 ns** |  **2.78** |    **0.09** |
|                                   LowCostLinqWithDelegate |         [1000] | 17,353.35 ns | 1,339.8542 ns | 3,950.5902 ns | 19,914.35 ns |  3.38 |    0.67 |
|                      LowCostLinqWithoutChecksWithDelegate |         [1000] | 12,101.87 ns |   348.8429 ns | 1,028.5710 ns | 11,903.85 ns |  2.05 |    0.12 |
|                                  LowCostLinqWithDelegate2 |         [1000] | 13,674.85 ns |   241.1001 ns |   213.7289 ns | 13,697.58 ns |  2.48 |    0.04 |
|                     LowCostLinqWithoutChecksWithDelegate2 |         [1000] | 13,965.42 ns |   304.0168 ns |   847.4774 ns | 14,052.98 ns |  2.55 |    0.15 |
|                                LowCostLinqWithStructWhere |         [1000] |  2,703.20 ns |     6.2929 ns |     5.8864 ns |  2,700.18 ns |  0.49 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |         [1000] |  1,765.00 ns |     0.4121 ns |     0.3653 ns |  1,765.15 ns |  0.32 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |         [1000] | 26,731.63 ns |   534.0236 ns | 1,289.7269 ns | 27,147.32 ns |  4.94 |    0.15 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |         [1000] | 24,961.03 ns |   492.0978 ns | 1,027.1914 ns | 25,166.40 ns |  4.52 |    0.23 |
|              LowCostLinqWithStructFilterCastToIEnumerable |         [1000] |  9,231.07 ns |     3.8581 ns |     3.4201 ns |  9,231.04 ns |  1.67 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |         [1000] |  8,590.87 ns |   148.2235 ns |   138.6484 ns |  8,501.41 ns |  1.55 |    0.03 |
|                                                 LinqCount |         [1000] |  8,722.47 ns |    36.6017 ns |    30.5640 ns |  8,718.18 ns |  1.58 |    0.01 |
|                              LowCostLinqWithDelegateCount |         [1000] | 10,895.88 ns |   217.1794 ns |   350.7042 ns | 10,938.88 ns |  1.98 |    0.07 |
|                 LowCostLinqWithoutChecksWithDelegateCount |         [1000] | 12,440.10 ns |   363.0832 ns | 1,070.5590 ns | 12,272.06 ns |  2.24 |    0.17 |
|                           LowCostLinqWithStructWhereCount |         [1000] |  1,773.83 ns |     0.5693 ns |     0.4754 ns |  1,773.97 ns |  0.32 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |         [1000] |  1,234.58 ns |     0.4669 ns |     0.3899 ns |  1,234.52 ns |  0.22 |    0.00 |
|                                               LinqToArray |         [1000] | 11,477.48 ns |   259.4761 ns |   363.7492 ns | 11,295.77 ns |  2.10 |    0.08 |
|                            LowCostLinqWithDelegateToArray |         [1000] | 12,951.46 ns |    40.7605 ns |    38.1274 ns | 12,960.43 ns |  2.34 |    0.01 |
|               LowCostLinqWithoutChecksWithDelegateToArray |         [1000] | 12,156.67 ns |    41.2059 ns |    38.5440 ns | 12,140.69 ns |  2.20 |    0.01 |
|                              LowCostLinqWithStructToArray |         [1000] |  3,448.33 ns |     7.7757 ns |     6.4931 ns |  3,448.78 ns |  0.62 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |         [1000] |  2,591.16 ns |     2.1425 ns |     2.0041 ns |  2,591.45 ns |  0.47 |    0.00 |
|                                                      Take |         [1000] |    546.28 ns |     0.3846 ns |     0.3598 ns |    546.34 ns |  0.10 |    0.00 |
|                                               LowCostTake |         [1000] |    361.97 ns |     8.7960 ns |    25.9351 ns |    356.64 ns |  0.07 |    0.00 |
|                                  LowCostTakeWithoutChecks |         [1000] |    307.30 ns |     8.5186 ns |    25.1172 ns |    302.32 ns |  0.06 |    0.00 |
|                                     LowCostTakeWithStruct |         [1000] |    137.51 ns |     0.2122 ns |     0.1881 ns |    137.51 ns |  0.02 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |         [1000] |    116.34 ns |     0.0523 ns |     0.0464 ns |    116.32 ns |  0.02 |    0.00 |
|                                            SkipTakeSingle |         [1000] |    471.02 ns |     0.8119 ns |     0.7197 ns |    471.11 ns |  0.09 |    0.00 |
|                                     LowCostSkipTakeSingle |         [1000] |    403.61 ns |     8.1012 ns |    19.8725 ns |    406.17 ns |  0.07 |    0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |         [1000] |    396.32 ns |     8.4217 ns |    24.6993 ns |    399.06 ns |  0.07 |    0.01 |
|                           LowCostSkipTakeSingleWithStruct |         [1000] |    172.77 ns |     1.6817 ns |     1.5731 ns |    172.03 ns |  0.03 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |         [1000] |    150.91 ns |     0.1244 ns |     0.1163 ns |    150.87 ns |  0.03 |    0.00 |
|                                           ForeachDelegate |         [1000] | 10,958.34 ns |     3.2788 ns |     2.9066 ns | 10,958.44 ns |  1.98 |    0.00 |
|                                                   Foreach |         [1000] |  5,524.68 ns |     1.2069 ns |     1.1289 ns |  5,524.06 ns |  1.00 |    0.00 |
|                                                           |                |              |               |               |              |       |         |
|                                                      **Linq** |           **[50]** |    **846.30 ns** |     **2.6644 ns** |     **2.2249 ns** |    **845.23 ns** |  **2.78** |    **0.01** |
|                                   LowCostLinqWithDelegate |           [50] |    701.33 ns |    15.6950 ns |    44.5242 ns |    700.33 ns |  2.29 |    0.09 |
|                      LowCostLinqWithoutChecksWithDelegate |           [50] |    634.35 ns |    12.7088 ns |    18.6285 ns |    632.97 ns |  2.08 |    0.07 |
|                                  LowCostLinqWithDelegate2 |           [50] |    791.99 ns |    11.2639 ns |     9.9851 ns |    790.91 ns |  2.60 |    0.03 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           [50] |    776.91 ns |    18.8892 ns |    55.6952 ns |    779.09 ns |  2.60 |    0.16 |
|                                LowCostLinqWithStructWhere |           [50] |    191.43 ns |     0.1026 ns |     0.0857 ns |    191.49 ns |  0.63 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           [50] |    145.65 ns |     0.4094 ns |     0.3829 ns |    145.39 ns |  0.48 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           [50] |  1,409.60 ns |    26.3857 ns |    24.6812 ns |  1,417.85 ns |  4.64 |    0.08 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           [50] |  1,362.08 ns |    25.8082 ns |    24.1410 ns |  1,367.04 ns |  4.48 |    0.08 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           [50] |    589.80 ns |    11.4506 ns |    12.2521 ns |    581.13 ns |  1.95 |    0.04 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           [50] |    541.60 ns |     0.0931 ns |     0.0870 ns |    541.56 ns |  1.78 |    0.00 |
|                                                 LinqCount |           [50] |    559.56 ns |     2.4822 ns |     2.3219 ns |    558.64 ns |  1.84 |    0.01 |
|                              LowCostLinqWithDelegateCount |           [50] |    827.86 ns |    79.1927 ns |   233.5013 ns |    645.40 ns |  3.07 |    0.66 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           [50] |    828.08 ns |    63.8402 ns |   188.2344 ns |    713.34 ns |  2.94 |    0.58 |
|                           LowCostLinqWithStructWhereCount |           [50] |    146.98 ns |     0.0592 ns |     0.0462 ns |    146.99 ns |  0.48 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           [50] |    102.00 ns |     1.0302 ns |     0.9636 ns |    101.51 ns |  0.34 |    0.00 |
|                                               LinqToArray |           [50] |    894.55 ns |     1.5066 ns |     1.3356 ns |    894.96 ns |  2.94 |    0.00 |
|                            LowCostLinqWithDelegateToArray |           [50] |    875.15 ns |     7.0159 ns |     6.5627 ns |    876.64 ns |  2.88 |    0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           [50] |    795.19 ns |    15.5254 ns |    18.4819 ns |    786.00 ns |  2.63 |    0.07 |
|                              LowCostLinqWithStructToArray |           [50] |    302.25 ns |     0.1600 ns |     0.1418 ns |    302.23 ns |  0.99 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           [50] |    247.28 ns |     0.1772 ns |     0.1571 ns |    247.28 ns |  0.81 |    0.00 |
|                                                      Take |           [50] |    569.12 ns |     6.6262 ns |     6.1981 ns |    571.02 ns |  1.87 |    0.02 |
|                                               LowCostTake |           [50] |    376.83 ns |     7.7893 ns |    22.9668 ns |    380.68 ns |  1.20 |    0.06 |
|                                  LowCostTakeWithoutChecks |           [50] |    322.10 ns |     9.1149 ns |    26.8756 ns |    313.33 ns |  1.08 |    0.07 |
|                                     LowCostTakeWithStruct |           [50] |    137.26 ns |     0.0440 ns |     0.0390 ns |    137.26 ns |  0.45 |    0.00 |
|                        LowCostTakeWithStructWithoutChecks |           [50] |    114.55 ns |     0.0152 ns |     0.0127 ns |    114.55 ns |  0.38 |    0.00 |
|                                            SkipTakeSingle |           [50] |    472.13 ns |     0.9290 ns |     0.8690 ns |    472.37 ns |  1.55 |    0.00 |
|                                     LowCostSkipTakeSingle |           [50] |    393.50 ns |     7.7793 ns |    15.8910 ns |    400.09 ns |  1.29 |    0.06 |
|                        LowCostSkipTakeSingleWithoutChecks |           [50] |    373.82 ns |     7.4397 ns |    11.1354 ns |    378.12 ns |  1.23 |    0.04 |
|                           LowCostSkipTakeSingleWithStruct |           [50] |    170.80 ns |     0.0927 ns |     0.0724 ns |    170.78 ns |  0.56 |    0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           [50] |    150.94 ns |     0.0430 ns |     0.0381 ns |    150.93 ns |  0.50 |    0.00 |
|                                           ForeachDelegate |           [50] |    583.02 ns |     0.1231 ns |     0.1151 ns |    582.99 ns |  1.92 |    0.00 |
|                                                   Foreach |           [50] |    304.06 ns |     0.0732 ns |     0.0685 ns |    304.05 ns |  1.00 |    0.00 |
|                                                           |                |              |               |               |              |       |         |
|                                                      **Linq** |            **[5]** |    **208.70 ns** |     **0.0737 ns** |     **0.0653 ns** |    **208.70 ns** |  **4.78** |    **0.00** |
|                                   LowCostLinqWithDelegate |            [5] |    117.32 ns |     2.3745 ns |     5.0602 ns |    117.99 ns |  2.68 |    0.16 |
|                      LowCostLinqWithoutChecksWithDelegate |            [5] |    113.59 ns |     2.5802 ns |     7.5672 ns |    112.49 ns |  2.68 |    0.17 |
|                                  LowCostLinqWithDelegate2 |            [5] |    155.60 ns |     3.0802 ns |     6.0076 ns |    156.69 ns |  3.60 |    0.14 |
|                     LowCostLinqWithoutChecksWithDelegate2 |            [5] |    150.85 ns |     3.0300 ns |     4.9783 ns |    152.24 ns |  3.47 |    0.13 |
|                                LowCostLinqWithStructWhere |            [5] |     69.85 ns |     0.0288 ns |     0.0241 ns |     69.86 ns |  1.60 |    0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |            [5] |     60.23 ns |     0.0122 ns |     0.0108 ns |     60.23 ns |  1.38 |    0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |            [5] |    263.60 ns |     5.1871 ns |     6.3702 ns |    259.46 ns |  6.09 |    0.17 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |            [5] |    246.36 ns |     0.3404 ns |     0.3184 ns |    246.34 ns |  5.64 |    0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |            [5] |    160.91 ns |     0.0327 ns |     0.0273 ns |    160.90 ns |  3.68 |    0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |            [5] |    151.36 ns |     2.4846 ns |     2.3241 ns |    150.07 ns |  3.45 |    0.04 |
|                                                 LinqCount |            [5] |    169.77 ns |     0.0485 ns |     0.0454 ns |    169.77 ns |  3.89 |    0.00 |
|                              LowCostLinqWithDelegateCount |            [5] |    100.83 ns |     2.0399 ns |     5.3381 ns |    101.38 ns |  2.27 |    0.16 |
|                 LowCostLinqWithoutChecksWithDelegateCount |            [5] |    101.38 ns |     2.1007 ns |     4.9104 ns |    100.90 ns |  2.27 |    0.08 |
|                           LowCostLinqWithStructWhereCount |            [5] |     61.64 ns |     0.0993 ns |     0.0776 ns |     61.61 ns |  1.41 |    0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |            [5] |     48.19 ns |     0.1436 ns |     0.1343 ns |     48.13 ns |  1.10 |    0.00 |
|                                               LinqToArray |            [5] |    236.61 ns |     0.0609 ns |     0.0540 ns |    236.61 ns |  5.42 |    0.00 |
|                            LowCostLinqWithDelegateToArray |            [5] |    144.36 ns |     0.0903 ns |     0.0845 ns |    144.37 ns |  3.30 |    0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |            [5] |    146.32 ns |     0.9559 ns |     0.7463 ns |    146.09 ns |  3.35 |    0.02 |
|                              LowCostLinqWithStructToArray |            [5] |    107.56 ns |     0.0557 ns |     0.0521 ns |    107.56 ns |  2.46 |    0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |            [5] |     92.45 ns |     0.0242 ns |     0.0227 ns |     92.45 ns |  2.12 |    0.00 |
|                                                      Take |            [5] |    270.70 ns |     0.0940 ns |     0.0879 ns |    270.72 ns |  6.20 |    0.00 |
|                                               LowCostTake |            [5] |    138.93 ns |     2.8069 ns |     3.3415 ns |    138.98 ns |  3.19 |    0.09 |
|                                  LowCostTakeWithoutChecks |            [5] |    114.62 ns |     2.7886 ns |     8.1785 ns |    113.72 ns |  2.59 |    0.17 |
|                                     LowCostTakeWithStruct |            [5] |     87.42 ns |     1.3149 ns |     1.2300 ns |     87.01 ns |  2.00 |    0.02 |
|                        LowCostTakeWithStructWithoutChecks |            [5] |     78.44 ns |     0.1747 ns |     0.1635 ns |     78.38 ns |  1.80 |    0.00 |
|                                            SkipTakeSingle |            [5] |    271.68 ns |     0.2222 ns |     0.2078 ns |    271.67 ns |  6.22 |    0.01 |
|                                     LowCostSkipTakeSingle |            [5] |    163.63 ns |     3.2761 ns |     7.9744 ns |    162.05 ns |  3.76 |    0.18 |
|                        LowCostSkipTakeSingleWithoutChecks |            [5] |    169.75 ns |     8.6119 ns |    25.3923 ns |    154.95 ns |  4.04 |    0.59 |
|                           LowCostSkipTakeSingleWithStruct |            [5] |    100.12 ns |     1.1693 ns |     1.0366 ns |     99.66 ns |  2.29 |    0.02 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |            [5] |     92.33 ns |     0.0363 ns |     0.0322 ns |     92.33 ns |  2.11 |    0.00 |
|                                           ForeachDelegate |            [5] |     75.78 ns |     0.0661 ns |     0.0552 ns |     75.76 ns |  1.73 |    0.00 |
|                                                   Foreach |            [5] |     43.68 ns |     0.0152 ns |     0.0127 ns |     43.68 ns |  1.00 |    0.00 |
