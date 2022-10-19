using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using SealedClass_Console.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Console.Services
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SortBenchmark
    {
        private static string[] stringArr = new[] { "Bar", "Baz", "Foo", "Qux", "Abc", "Zxy", "Try", "Cab" };
        public static readonly Sorter arraySorter = new Sorter(stringArr);

        [Benchmark]
        public void BubbleSort() => arraySorter.BubbleSort();

        [Benchmark]
        public void BuiltInSortWithComparison() => arraySorter.BuiltInSortWithComparison();

        [Benchmark(Baseline = true)]
        public void SortWithLINQ() => arraySorter.SortWithLINQ();
    }
}
