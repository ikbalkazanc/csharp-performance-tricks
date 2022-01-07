using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestingCases.Cases
{
    
    [MemoryDiagnoser]
    public class ListParameterPassCase
    {
        private List<int> emptylist = new List<int>();
        private List<int> list = Enumerable.Range(0, 1000).ToList();

        [Benchmark]
        public void PassParameterAsEnumerable()
        {
            PassParameterAsEnumerable(list);
        }
        [Benchmark]
        public void PassParameterAsList()
        {
            PassParameterAsList(list);
        }

        private void PassParameterAsEnumerable(IEnumerable<int> pass)
        {
            foreach (var VARIABLE in pass)
            {
            }
        }
        private void PassParameterAsList(List<int> pass)
        {
            foreach (var VARIABLE in pass)
            {
            }
        }

    }
}
    