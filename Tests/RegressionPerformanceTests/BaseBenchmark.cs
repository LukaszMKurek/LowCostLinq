using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Code;
using BenchmarkDotNet.Diagnosers;

namespace PerformanceTests
{
    //[MemoryDiagnoser]
    //[HardwareCounters(HardwareCounter.BranchMispredictions)]
    public abstract class BaseBenchmark<T>
    {
        public class CustomParam : IParam
        {
            private readonly int index;
            private readonly int size;

            public CustomParam(int index, int size)
            {
                this.index = index;
                this.size = size;
            }

            public object Value => index;

            public string DisplayText => $"{size}";

            public string ToSourceCode() => $"{index}";
        }

        private const int I_0 = 0;
        private const int I_1 = 1;
        private const int I_2 = 2;
        private const int I_3 = 5;
        private const int I_4 = 10;
        private const int I_5 = 20;
        private const int I_6 = 50;
        private const int I_7 = 100;
        private const int I_8 = 200;
        private const int I_9 = 1000;
        private const int I_10 = 10000;
        private const int I_11 = 100000;

        public IEnumerable<IParam> Parameters()
        {
            yield return new CustomParam(0, I_0);
            //yield return new CustomParam(1, I_1);
            //yield return new CustomParam(2, I_2);
            yield return new CustomParam(3, I_3);
            //yield return new CustomParam(4, I_4);
            //yield return new CustomParam(5, I_5);
            yield return new CustomParam(6, I_6);
            //yield return new CustomParam(7, I_7);
            //yield return new CustomParam(8, I_8);
            yield return new CustomParam(9, I_9);
            //yield return new CustomParam(10, I_10);
            //yield return new CustomParam(11, I_11);
        }
        
        [ParamsSource(nameof(Parameters))]
        public int CollectionSize { get; set; }

        public static readonly T[][] Array = new[]
        {
            new T[I_0], new T[I_1], new T[I_2], new T[I_3], new T[I_4], new T[I_5], new T[I_6], new T[I_7], new T[I_8], new T[I_9], new T[I_10], new T[I_11]
        };

        public static readonly List<T>[] List = new[]
            {
                new T[I_0], new T[I_1], new T[I_2], new T[I_3], new T[I_4], new T[I_5], new T[I_6], new T[I_7], new T[I_8], new T[I_9], new T[I_10], new T[I_11]
            }
            .Select(i => new List<T>(i)).ToArray();

        public static readonly IEnumerable<T>[] EnumerableArray = new[]
        {
            new T[I_0], new T[I_1], new T[I_2], new T[I_3], new T[I_4], new T[I_5], new T[I_6], new T[I_7], new T[I_8], new T[I_9], new T[I_10], new T[I_11]
        };

        public static readonly IEnumerable<T>[] EnumerableList = new[]
            {
                new T[I_0], new T[I_1], new T[I_2], new T[I_3], new T[I_4], new T[I_5], new T[I_6], new T[I_7], new T[I_8], new T[I_9], new T[I_10], new T[I_11]
            }
            .Select(i => new List<T>(i)).ToArray();

        public static readonly IEnumerable<T>[] EnumerableReadonlyCollection = new[]
            {
                new T[I_0], new T[I_1], new T[I_2], new T[I_3], new T[I_4], new T[I_5], new T[I_6], new T[I_7], new T[I_8], new T[I_9], new T[I_10], new T[I_11]
            }
            .Select(i => new List<T>(i).AsReadOnly()).ToArray();
    }
}