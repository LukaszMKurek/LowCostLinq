using System;
using BenchmarkDotNet.Running;

namespace PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ArrayWhere<int>>();
            Console.WriteLine(summary);
            summary = BenchmarkRunner.Run<ListWhere<int>>();
            Console.WriteLine(summary);
            summary = BenchmarkRunner.Run<EnumerableArrayWhere<int>>();
            Console.WriteLine(summary);
            summary = BenchmarkRunner.Run<EnumerableListWhere<int>>();
            Console.WriteLine(summary);
            summary = BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere<int>>();
            Console.WriteLine(summary);
        }
    }
}