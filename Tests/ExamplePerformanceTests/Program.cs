﻿using BenchmarkDotNet.Running;
using PerformanceTests;

namespace ExamplePerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Example1>();
            BenchmarkRunner.Run<Example2>();
            BenchmarkRunner.Run<Example3>();
            BenchmarkRunner.Run<Example4>();
            BenchmarkRunner.Run<Example5>();
            BenchmarkRunner.Run<Example6>();
        }
    }
}