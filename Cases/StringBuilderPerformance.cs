using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace InterestingCases.Cases
{
    [MemoryDiagnoser]
    public class StringBuilderPerformance
    {
        [Benchmark]
        public void TinyStringProcess()
        {
            string first = "first";
            string second = "second";
            second = first + second;
          

        }
        [Benchmark]
        public void TinyStringProcessWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder("first");
            string second = "second";
            sb.Append(second);

        }
        [Benchmark]
        public void StringProcess()
        {
            string first = "first";
            string second = "second";
            for (int i = 0; i < 1000; i++)
            {
                second = first + second;
            }
        }
        [Benchmark]
        public void StringProcessWithStringBuilder()
        {
            StringBuilder sb = new StringBuilder("first");
            string second = "second";
            for (int i = 0; i < 1000; i++)
            {
                sb.Append(second);
            }
        }
    }
}
