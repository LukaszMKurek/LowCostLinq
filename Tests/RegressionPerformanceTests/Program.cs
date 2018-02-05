using BenchmarkDotNet.Running;

namespace PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArrayWhere<int>>();
            BenchmarkRunner.Run<ListWhere<int>>();
            BenchmarkRunner.Run<EnumerableArrayWhere<int>>();
            BenchmarkRunner.Run<EnumerableListWhere<int>>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere<int>>();
        }
    }
}