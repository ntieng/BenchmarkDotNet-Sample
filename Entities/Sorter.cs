using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass_Console.Entities
{
    public class Sorter
    {
        private string[] input;
        public Sorter(string[] array)
        {
            input = array;
        }
        public void BubbleSort()
        {
            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i].CompareTo(input[j]) < 0)
                    {
                        (input[j], input[i]) = (input[i], input[j]);
                    }
                }
            }
        }
        public void BuiltInSortWithComparison()
        {
            Array.Sort(input, (a, b) => b.CompareTo(a));
        }
        public void SortWithLINQ()
        {
            input = input.OrderByDescending(s => s).ToArray();
        }
    }
}
