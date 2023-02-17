using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using ReverseString;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class ReverseStringBanchmark
    {
        private const string testString = "Hello world!";
        private readonly Reverse _reverseString = new();

        [Benchmark]
        public void ReverseStrUseForBenchmarkTest()
        {
            var result = _reverseString.ReverseStrUseFor(testString);
        }

        [Benchmark]
        public void ReverseStrUseWhileBenchmarkTest()
        {
            var result = _reverseString.ReverseStrUseWhile(testString);
        }
    }
}
