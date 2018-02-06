using BenchmarkDotNet.Running;

namespace PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArrayWhere1<int>>();
            BenchmarkRunner.Run<ListWhere1<int>>();
            BenchmarkRunner.Run<EnumerableArrayWhere1<int>>();
            BenchmarkRunner.Run<EnumerableListWhere1<int>>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere1<int>>();

            BenchmarkRunner.Run<ArrayWhere2<int>>();
            BenchmarkRunner.Run<ListWhere2<int>>();
            BenchmarkRunner.Run<EnumerableArrayWhere2<int>>();
            BenchmarkRunner.Run<EnumerableListWhere2<int>>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere2<int>>();
        }
    }
}