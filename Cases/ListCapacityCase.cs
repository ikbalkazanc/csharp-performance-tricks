using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace InterestingCases.Cases
{
  [MemoryDiagnoser]
    public class ListCapacityCase
    {
        [Benchmark]
        [Arguments(100)]
        [Arguments(10000)]
        public void List(int capacity)
        {
            var list = new List<int>();

            for (int i = 0; i < capacity; i++)
                list.Add(i);
            

        }

        [Benchmark]
        [Arguments(100)]
        [Arguments(10000)]
        public void CapacityList(int capacity)
        {
            var list = new List<int>(capacity);

            for (int i = 0; i < capacity; i++)
                list.Add(i);
            

        }
    }
}