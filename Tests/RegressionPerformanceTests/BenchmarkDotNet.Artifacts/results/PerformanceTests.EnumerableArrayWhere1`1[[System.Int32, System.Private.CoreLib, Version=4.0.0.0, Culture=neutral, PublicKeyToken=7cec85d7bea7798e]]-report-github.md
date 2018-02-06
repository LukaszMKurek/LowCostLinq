``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.214)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3914065 Hz, Resolution=255.4889 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                                                    Method | CollectionSize |         Mean |      Error |     StdDev |       Median | Scaled | ScaledSD |
|---------------------------------------------------------- |--------------- |-------------:|-----------:|-----------:|-------------:|-------:|---------:|
|                                                      **Linq** |              **0** |     **22.02 ns** |  **0.0109 ns** |  **0.0085 ns** |     **22.02 ns** |   **1.71** |     **0.00** |
|                                   LowCostLinqWithDelegate |              0 |     32.97 ns |  0.0034 ns |  0.0029 ns |     32.97 ns |   2.56 |     0.00 |
|                      LowCostLinqWithoutChecksWithDelegate |              0 |     31.30 ns |  0.0075 ns |  0.0066 ns |     31.30 ns |   2.43 |     0.00 |
|                                  LowCostLinqWithDelegate2 |              0 |     40.14 ns |  0.2184 ns |  0.2043 ns |     39.98 ns |   3.12 |     0.02 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              0 |     41.54 ns |  0.0617 ns |  0.0547 ns |     41.52 ns |   3.23 |     0.00 |
|                                LowCostLinqWithStructWhere |              0 |     39.18 ns |  0.0063 ns |  0.0059 ns |     39.18 ns |   3.04 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |              0 |     33.90 ns |  0.0152 ns |  0.0127 ns |     33.91 ns |   2.63 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              0 |     75.46 ns |  0.8695 ns |  0.8133 ns |     75.58 ns |   5.86 |     0.06 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              0 |     72.26 ns |  0.1041 ns |  0.0974 ns |     72.30 ns |   5.61 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              0 |     73.66 ns |  0.0366 ns |  0.0325 ns |     73.65 ns |   5.72 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              0 |     71.79 ns |  0.0547 ns |  0.0511 ns |     71.79 ns |   5.57 |     0.00 |
|                                                 LinqCount |              0 |     25.64 ns |  0.2374 ns |  0.2221 ns |     25.48 ns |   1.99 |     0.02 |
|                              LowCostLinqWithDelegateCount |              0 |     23.91 ns |  0.0107 ns |  0.0084 ns |     23.90 ns |   1.86 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              0 |     23.68 ns |  0.0073 ns |  0.0064 ns |     23.68 ns |   1.84 |     0.00 |
|                           LowCostLinqWithStructWhereCount |              0 |     23.05 ns |  0.1804 ns |  0.1687 ns |     22.92 ns |   1.79 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              0 |     22.75 ns |  0.0028 ns |  0.0023 ns |     22.75 ns |   1.77 |     0.00 |
|                                               LinqToArray |              0 |     22.20 ns |  0.0069 ns |  0.0062 ns |     22.19 ns |   1.72 |     0.00 |
|                            LowCostLinqWithDelegateToArray |              0 |     36.11 ns |  0.3104 ns |  0.2904 ns |     36.15 ns |   2.80 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              0 |     36.03 ns |  0.0278 ns |  0.0260 ns |     36.02 ns |   2.80 |     0.00 |
|                              LowCostLinqWithStructToArray |              0 |     32.99 ns |  0.0360 ns |  0.0337 ns |     33.00 ns |   2.56 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |              0 |     32.34 ns |  0.0527 ns |  0.0493 ns |     32.33 ns |   2.51 |     0.00 |
|                                                      Take |              0 |     25.69 ns |  0.0137 ns |  0.0128 ns |     25.69 ns |   1.99 |     0.00 |
|                                               LowCostTake |              0 |     41.72 ns |  0.0244 ns |  0.0216 ns |     41.71 ns |   3.24 |     0.00 |
|                                  LowCostTakeWithoutChecks |              0 |     41.60 ns |  0.0088 ns |  0.0078 ns |     41.60 ns |   3.23 |     0.00 |
|                                     LowCostTakeWithStruct |              0 |     41.80 ns |  0.1376 ns |  0.1287 ns |     41.74 ns |   3.24 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              0 |     43.81 ns |  0.0073 ns |  0.0065 ns |     43.81 ns |   3.40 |     0.00 |
|                                            SkipTakeSingle |              0 |     37.35 ns |  0.0288 ns |  0.0225 ns |     37.35 ns |   2.90 |     0.00 |
|                                     LowCostSkipTakeSingle |              0 |     41.40 ns |  0.0029 ns |  0.0027 ns |     41.40 ns |   3.21 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |              0 |     46.58 ns |  0.0057 ns |  0.0041 ns |     46.58 ns |   3.62 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |              0 |     43.43 ns |  0.0016 ns |  0.0015 ns |     43.43 ns |   3.37 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              0 |     43.67 ns |  0.0378 ns |  0.0354 ns |     43.69 ns |   3.39 |     0.00 |
|                                           ForeachDelegate |              0 |     15.72 ns |  0.1088 ns |  0.1018 ns |     15.73 ns |   1.22 |     0.01 |
|                                                   Foreach |              0 |     12.88 ns |  0.0060 ns |  0.0050 ns |     12.88 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |           **1000** |  **5,453.90 ns** |  **3.1426 ns** |  **2.9396 ns** |  **5,453.83 ns** |   **1.26** |     **0.00** |
|                                   LowCostLinqWithDelegate |           1000 |  3,878.20 ns | 29.5772 ns | 26.2194 ns |  3,873.77 ns |   0.90 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |           1000 |  3,144.40 ns |  2.2386 ns |  1.8693 ns |  3,144.36 ns |   0.73 |     0.00 |
|                                  LowCostLinqWithDelegate2 |           1000 |  3,634.42 ns | 18.7167 ns | 15.6293 ns |  3,638.72 ns |   0.84 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |           1000 |  3,188.50 ns | 31.1407 ns | 29.1290 ns |  3,170.35 ns |   0.74 |     0.01 |
|                                LowCostLinqWithStructWhere |           1000 |  1,956.79 ns |  1.0754 ns |  0.9533 ns |  1,956.42 ns |   0.45 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |           1000 |  1,548.24 ns |  1.1652 ns |  1.0899 ns |  1,548.29 ns |   0.36 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |           1000 | 10,379.80 ns |  6.3639 ns |  5.6415 ns | 10,378.45 ns |   2.41 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |           1000 |  9,917.42 ns | 36.9053 ns | 30.8176 ns |  9,909.59 ns |   2.30 |     0.01 |
|              LowCostLinqWithStructFilterCastToIEnumerable |           1000 |  7,750.38 ns |  3.7096 ns |  3.0977 ns |  7,749.10 ns |   1.80 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |           1000 |  7,504.73 ns |  5.4635 ns |  5.1106 ns |  7,505.35 ns |   1.74 |     0.00 |
|                                                 LinqCount |           1000 |  1,710.77 ns |  2.4379 ns |  2.2804 ns |  1,710.20 ns |   0.40 |     0.00 |
|                              LowCostLinqWithDelegateCount |           1000 |  2,197.77 ns | 24.8925 ns | 23.2845 ns |  2,201.75 ns |   0.51 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |           1000 |  2,414.33 ns |  1.0232 ns |  0.9571 ns |  2,414.18 ns |   0.56 |     0.00 |
|                           LowCostLinqWithStructWhereCount |           1000 |  1,334.68 ns |  0.2106 ns |  0.1867 ns |  1,334.67 ns |   0.31 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |           1000 |  1,335.16 ns |  0.1019 ns |  0.0851 ns |  1,335.13 ns |   0.31 |     0.00 |
|                                               LinqToArray |           1000 |  3,357.84 ns |  2.6753 ns |  2.2340 ns |  3,357.56 ns |   0.78 |     0.00 |
|                            LowCostLinqWithDelegateToArray |           1000 |  3,939.57 ns |  4.0097 ns |  3.1305 ns |  3,939.47 ns |   0.91 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |           1000 |  3,680.13 ns |  3.3760 ns |  2.8191 ns |  3,679.62 ns |   0.85 |     0.00 |
|                              LowCostLinqWithStructToArray |           1000 |  2,259.40 ns | 21.3436 ns | 19.9649 ns |  2,261.18 ns |   0.52 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |           1000 |  2,247.41 ns |  7.0781 ns |  6.6209 ns |  2,244.05 ns |   0.52 |     0.00 |
|                                                      Take |           1000 |    265.96 ns |  0.0637 ns |  0.0421 ns |    265.96 ns |   0.06 |     0.00 |
|                                               LowCostTake |           1000 |    130.59 ns |  0.1175 ns |  0.1099 ns |    130.58 ns |   0.03 |     0.00 |
|                                  LowCostTakeWithoutChecks |           1000 |    116.82 ns |  0.6351 ns |  0.5941 ns |    116.49 ns |   0.03 |     0.00 |
|                                     LowCostTakeWithStruct |           1000 |     96.16 ns |  0.0126 ns |  0.0105 ns |     96.16 ns |   0.02 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |           1000 |     83.79 ns |  0.0212 ns |  0.0198 ns |     83.79 ns |   0.02 |     0.00 |
|                                            SkipTakeSingle |           1000 |    184.92 ns |  0.0199 ns |  0.0166 ns |    184.93 ns |   0.04 |     0.00 |
|                                     LowCostSkipTakeSingle |           1000 |     99.69 ns |  0.0920 ns |  0.0860 ns |     99.73 ns |   0.02 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |           1000 |    116.69 ns |  0.0299 ns |  0.0249 ns |    116.68 ns |   0.03 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |           1000 |     65.57 ns |  0.1145 ns |  0.1071 ns |     65.59 ns |   0.02 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |           1000 |     65.61 ns |  0.2243 ns |  0.1873 ns |     65.53 ns |   0.02 |     0.00 |
|                                           ForeachDelegate |           1000 |  5,040.04 ns |  6.5712 ns |  6.1467 ns |  5,041.59 ns |   1.17 |     0.00 |
|                                                   Foreach |           1000 |  4,313.37 ns |  0.5041 ns |  0.3936 ns |  4,313.45 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |              **5** |     **60.74 ns** |  **0.0402 ns** |  **0.0376 ns** |     **60.73 ns** |   **1.75** |     **0.01** |
|                                   LowCostLinqWithDelegate |              5 |     49.88 ns |  0.0195 ns |  0.0129 ns |     49.88 ns |   1.44 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |              5 |     47.02 ns |  0.0119 ns |  0.0093 ns |     47.02 ns |   1.36 |     0.01 |
|                                  LowCostLinqWithDelegate2 |              5 |     59.86 ns |  0.0125 ns |  0.0117 ns |     59.86 ns |   1.73 |     0.01 |
|                     LowCostLinqWithoutChecksWithDelegate2 |              5 |     58.39 ns |  0.0616 ns |  0.0576 ns |     58.39 ns |   1.68 |     0.01 |
|                                LowCostLinqWithStructWhere |              5 |     49.34 ns |  0.1508 ns |  0.1410 ns |     49.27 ns |   1.42 |     0.01 |
|                   LowCostLinqWithoutChecksWithStructWhere |              5 |     43.43 ns |  0.0255 ns |  0.0238 ns |     43.43 ns |   1.25 |     0.01 |
|                  LowCostLinqWithDelegateCastToIEnumerable |              5 |    127.26 ns |  0.1290 ns |  0.1206 ns |    127.27 ns |   3.67 |     0.03 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |              5 |    122.35 ns |  0.1809 ns |  0.1692 ns |    122.28 ns |   3.53 |     0.03 |
|              LowCostLinqWithStructFilterCastToIEnumerable |              5 |    115.05 ns |  0.1186 ns |  0.1109 ns |    115.08 ns |   3.32 |     0.03 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |              5 |    110.87 ns |  0.0704 ns |  0.0659 ns |    110.86 ns |   3.20 |     0.02 |
|                                                 LinqCount |              5 |     42.00 ns |  0.0285 ns |  0.0267 ns |     42.00 ns |   1.21 |     0.01 |
|                              LowCostLinqWithDelegateCount |              5 |     35.55 ns |  0.0187 ns |  0.0156 ns |     35.55 ns |   1.03 |     0.01 |
|                 LowCostLinqWithoutChecksWithDelegateCount |              5 |     36.08 ns |  0.0217 ns |  0.0193 ns |     36.09 ns |   1.04 |     0.01 |
|                           LowCostLinqWithStructWhereCount |              5 |     25.96 ns |  0.0093 ns |  0.0087 ns |     25.96 ns |   0.75 |     0.01 |
|              LowCostLinqWithoutChecksWithStructWhereCount |              5 |     26.22 ns |  0.0089 ns |  0.0079 ns |     26.22 ns |   0.76 |     0.01 |
|                                               LinqToArray |              5 |     96.95 ns |  0.0288 ns |  0.0241 ns |     96.95 ns |   2.80 |     0.02 |
|                            LowCostLinqWithDelegateToArray |              5 |     83.49 ns |  0.1272 ns |  0.1190 ns |     83.41 ns |   2.41 |     0.02 |
|               LowCostLinqWithoutChecksWithDelegateToArray |              5 |     82.84 ns |  0.0960 ns |  0.0898 ns |     82.84 ns |   2.39 |     0.02 |
|                              LowCostLinqWithStructToArray |              5 |     70.73 ns |  0.1454 ns |  0.1135 ns |     70.68 ns |   2.04 |     0.02 |
|                 LowCostLinqWithoutChecksWithStructToArray |              5 |     71.68 ns |  0.1182 ns |  0.1106 ns |     71.63 ns |   2.07 |     0.02 |
|                                                      Take |              5 |    118.10 ns |  0.0241 ns |  0.0213 ns |    118.09 ns |   3.41 |     0.03 |
|                                               LowCostTake |              5 |     64.22 ns |  0.0223 ns |  0.0209 ns |     64.22 ns |   1.85 |     0.01 |
|                                  LowCostTakeWithoutChecks |              5 |     59.74 ns |  0.1656 ns |  0.1468 ns |     59.67 ns |   1.72 |     0.01 |
|                                     LowCostTakeWithStruct |              5 |     55.51 ns |  0.0325 ns |  0.0304 ns |     55.50 ns |   1.60 |     0.01 |
|                        LowCostTakeWithStructWithoutChecks |              5 |     58.49 ns |  0.0128 ns |  0.0114 ns |     58.49 ns |   1.69 |     0.01 |
|                                            SkipTakeSingle |              5 |    112.69 ns |  1.0598 ns |  0.9913 ns |    112.14 ns |   3.25 |     0.04 |
|                                     LowCostSkipTakeSingle |              5 |     52.31 ns |  0.0248 ns |  0.0220 ns |     52.31 ns |   1.51 |     0.01 |
|                        LowCostSkipTakeSingleWithoutChecks |              5 |     51.88 ns |  0.0280 ns |  0.0262 ns |     51.88 ns |   1.50 |     0.01 |
|                           LowCostSkipTakeSingleWithStruct |              5 |     46.85 ns |  0.0342 ns |  0.0303 ns |     46.84 ns |   1.35 |     0.01 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |              5 |     47.03 ns |  0.0801 ns |  0.0710 ns |     47.00 ns |   1.36 |     0.01 |
|                                           ForeachDelegate |              5 |     41.92 ns |  0.0348 ns |  0.0325 ns |     41.93 ns |   1.21 |     0.01 |
|                                                   Foreach |              5 |     34.68 ns |  0.2990 ns |  0.2796 ns |     34.47 ns |   1.00 |     0.00 |
|                                                           |                |              |            |            |              |        |          |
|                                                      **Linq** |             **50** |    **314.95 ns** |  **0.2288 ns** |  **0.2140 ns** |    **314.99 ns** |   **1.33** |     **0.00** |
|                                   LowCostLinqWithDelegate |             50 |    226.46 ns |  2.6314 ns |  2.4614 ns |    228.11 ns |   0.96 |     0.01 |
|                      LowCostLinqWithoutChecksWithDelegate |             50 |    194.95 ns |  1.6334 ns |  1.5278 ns |    193.95 ns |   0.83 |     0.01 |
|                                  LowCostLinqWithDelegate2 |             50 |    225.74 ns |  0.3630 ns |  0.3218 ns |    225.68 ns |   0.96 |     0.00 |
|                     LowCostLinqWithoutChecksWithDelegate2 |             50 |    205.08 ns |  0.1020 ns |  0.0954 ns |    205.08 ns |   0.87 |     0.00 |
|                                LowCostLinqWithStructWhere |             50 |    137.65 ns |  0.0768 ns |  0.0600 ns |    137.64 ns |   0.58 |     0.00 |
|                   LowCostLinqWithoutChecksWithStructWhere |             50 |    123.85 ns |  0.0669 ns |  0.0626 ns |    123.87 ns |   0.52 |     0.00 |
|                  LowCostLinqWithDelegateCastToIEnumerable |             50 |    601.08 ns |  0.1040 ns |  0.0922 ns |    601.08 ns |   2.55 |     0.00 |
|     LowCostLinqWithoutChecksWithDelegateCastToIEnumerable |             50 |    570.29 ns |  0.5043 ns |  0.4471 ns |    570.17 ns |   2.42 |     0.00 |
|              LowCostLinqWithStructFilterCastToIEnumerable |             50 |    470.01 ns |  0.1576 ns |  0.1230 ns |    469.98 ns |   1.99 |     0.00 |
| LowCostLinqWithoutChecksWithStructFilterCastToIEnumerable |             50 |    451.46 ns |  0.4085 ns |  0.3821 ns |    451.36 ns |   1.91 |     0.00 |
|                                                 LinqCount |             50 |    123.21 ns |  0.2343 ns |  0.2192 ns |    123.14 ns |   0.52 |     0.00 |
|                              LowCostLinqWithDelegateCount |             50 |    136.44 ns |  0.0387 ns |  0.0323 ns |    136.45 ns |   0.58 |     0.00 |
|                 LowCostLinqWithoutChecksWithDelegateCount |             50 |    148.90 ns |  1.3795 ns |  1.2904 ns |    149.10 ns |   0.63 |     0.01 |
|                           LowCostLinqWithStructWhereCount |             50 |     77.40 ns |  0.0247 ns |  0.0219 ns |     77.40 ns |   0.33 |     0.00 |
|              LowCostLinqWithoutChecksWithStructWhereCount |             50 |     78.26 ns |  0.0130 ns |  0.0101 ns |     78.26 ns |   0.33 |     0.00 |
|                                               LinqToArray |             50 |    370.32 ns |  0.4633 ns |  0.4333 ns |    370.31 ns |   1.57 |     0.00 |
|                            LowCostLinqWithDelegateToArray |             50 |    316.60 ns |  0.4591 ns |  0.3833 ns |    316.44 ns |   1.34 |     0.00 |
|               LowCostLinqWithoutChecksWithDelegateToArray |             50 |    306.59 ns |  0.4915 ns |  0.4597 ns |    306.34 ns |   1.30 |     0.00 |
|                              LowCostLinqWithStructToArray |             50 |    223.55 ns |  0.3885 ns |  0.3634 ns |    223.35 ns |   0.95 |     0.00 |
|                 LowCostLinqWithoutChecksWithStructToArray |             50 |    222.68 ns |  2.4652 ns |  2.3059 ns |    221.38 ns |   0.94 |     0.01 |
|                                                      Take |             50 |    265.80 ns |  0.2187 ns |  0.1939 ns |    265.75 ns |   1.13 |     0.00 |
|                                               LowCostTake |             50 |    130.83 ns |  0.1618 ns |  0.1513 ns |    130.84 ns |   0.55 |     0.00 |
|                                  LowCostTakeWithoutChecks |             50 |    117.38 ns |  0.0098 ns |  0.0082 ns |    117.38 ns |   0.50 |     0.00 |
|                                     LowCostTakeWithStruct |             50 |     95.79 ns |  0.0166 ns |  0.0130 ns |     95.78 ns |   0.41 |     0.00 |
|                        LowCostTakeWithStructWithoutChecks |             50 |     81.98 ns |  0.0835 ns |  0.0740 ns |     81.96 ns |   0.35 |     0.00 |
|                                            SkipTakeSingle |             50 |    184.56 ns |  0.0313 ns |  0.0244 ns |    184.57 ns |   0.78 |     0.00 |
|                                     LowCostSkipTakeSingle |             50 |    110.12 ns |  0.0615 ns |  0.0480 ns |    110.14 ns |   0.47 |     0.00 |
|                        LowCostSkipTakeSingleWithoutChecks |             50 |    117.82 ns |  0.0135 ns |  0.0120 ns |    117.82 ns |   0.50 |     0.00 |
|                           LowCostSkipTakeSingleWithStruct |             50 |     68.44 ns |  0.1338 ns |  0.1251 ns |     68.45 ns |   0.29 |     0.00 |
|              LowCostSkipTakeSingleWithStructWithoutChecks |             50 |     71.55 ns |  0.6547 ns |  0.6124 ns |     71.55 ns |   0.30 |     0.00 |
|                                           ForeachDelegate |             50 |    274.86 ns |  0.2685 ns |  0.2511 ns |    274.86 ns |   1.16 |     0.00 |
|                                                   Foreach |             50 |    235.95 ns |  0.0248 ns |  0.0219 ns |    235.95 ns |   1.00 |     0.00 |
