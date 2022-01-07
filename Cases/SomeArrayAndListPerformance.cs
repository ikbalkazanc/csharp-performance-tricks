using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace InterestingCases.Cases
{

    [MemoryDiagnoser]
    public class SomeArrayAndListPerformance
    {
        private const int SPECIFIC_NUMBER = 558855;
        [Benchmark]
        public void Array()
        {
            int[] array = new int[] { 1, 5, 4, 6 };

            //Add
            for (int i = 0; i < 100; i++)
            {
                array = array.Append(i).ToArray();
                
            }

            array = array.Append(SPECIFIC_NUMBER).ToArray();

            for (int i = 0; i < 100; i++)
            {
                array = array.Append(i).ToArray();
            }
            //Remove
            var removedIndex = System.Array.IndexOf(array,SPECIFIC_NUMBER);
            array = array[0..removedIndex].Concat(array[1..2].ToList()).ToArray();

        }

        [Benchmark]
        public void ArrayList()
        {

            var array = new ArrayList();
            //Add
            for (int i = 0; i < 100; i++)
            {
                array.Add(i);

            }

            array.Add(SPECIFIC_NUMBER);

            for (int i = 0; i < 100; i++)
            {
                array.Add(i);
            }
            //Remove
            array.Remove(SPECIFIC_NUMBER);
        }

        [Benchmark]
        public void List()
        {
            var list = new List<int>();
            //Add
            for (int i = 0; i < 100; i++)
            {
                list.Append(i);

            }

            list.Append(SPECIFIC_NUMBER);

            for (int i = 0; i < 100; i++)
            {
                list.Append(i);
            }
            //Remove
            list.Remove(SPECIFIC_NUMBER);
        }

        [Benchmark]
        public void LinkedList()
        {
            var list = new LinkedList<int>();
            //Add
            for (int i = 0; i < 100; i++)
            {
                list.AddFirst(i);

            }

            list.AddFirst(SPECIFIC_NUMBER);

            for (int i = 0; i < 100; i++)
            {
                list.AddFirst(i);
            }
            //Remove
            list.Remove(SPECIFIC_NUMBER);
        }

        [Benchmark]
        public void HashSet()
        {
            var set = new HashSet<int>();
            //Add
            for (int i = 0; i < 100; i++)
            {
                set.Add(i);

            }

            set.Add(SPECIFIC_NUMBER);

            for (int i = 0; i < 100; i++)
            {
                set.Add(i);
            }
            //Remove
            set.Remove(SPECIFIC_NUMBER);
        }
        [Benchmark]
        public void SortedSet()
        {
            var set = new SortedSet<int>();
            //Add
            for (int i = 0; i < 100; i++)
            {
                set.Add(i);

            }

            set.Add(SPECIFIC_NUMBER);

            for (int i = 0; i < 100; i++)
            {
                set.Add(i);
            }
            //Remove
            set.Remove(SPECIFIC_NUMBER);
        }
    }
}
