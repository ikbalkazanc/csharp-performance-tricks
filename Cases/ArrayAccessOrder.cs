using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace InterestingCases.Cases
{
    [MemoryDiagnoser]
    public class ArrayAccessOrder
    {
        //two dimension array
        private int[,] array = ArrayOf1000x1000();

        [Benchmark]
        public void SampleOne()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            for (int j = 0; j < 1000; j++)
                if (array[i, j] > 0)
                    result++;
        }

        [Benchmark]
        public void SampleTwo()
        {
            int result = 0;
            for (int i = 0; i < 1000; i++)
            for (int j = 0; j < 1000; j++)

                if (array[j, i] > 0)

                    result++;
        }

        private static int[,] ArrayOf1000x1000()
        {
            int[,] arr = new int[1000, 1000];

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    arr[j, i] = 1;
                }
            }

            return arr;
        }
    }
}