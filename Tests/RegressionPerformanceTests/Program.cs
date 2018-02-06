using BenchmarkDotNet.Running;

namespace PerformanceTests
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<ArrayWhere1Int>();
            BenchmarkRunner.Run<ListWhere1Int>();
            BenchmarkRunner.Run<EnumerableArrayWhere1Int>();
            BenchmarkRunner.Run<EnumerableListWhere1Int>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere1Int>();

            BenchmarkRunner.Run<ArrayWhere2Int>();
            BenchmarkRunner.Run<ListWhere2Int>();
            BenchmarkRunner.Run<EnumerableArrayWhere2Int>();
            BenchmarkRunner.Run<EnumerableListWhere2Int>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere2Int>();

            BenchmarkRunner.Run<ArrayWhere3Int>();
            BenchmarkRunner.Run<ListWhere3Int>();
            BenchmarkRunner.Run<EnumerableArrayWhere3Int>();
            BenchmarkRunner.Run<EnumerableListWhere3Int>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere3Int>();

            BenchmarkRunner.Run<ArrayWhere4Int>();
            BenchmarkRunner.Run<ListWhere4Int>();
            BenchmarkRunner.Run<EnumerableArrayWhere4Int>();
            BenchmarkRunner.Run<EnumerableListWhere4Int>();
            BenchmarkRunner.Run<EnumerableReadonlyCollectionWhere4Int>();
        }
    }
}