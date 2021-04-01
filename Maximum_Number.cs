using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Arrays
{
    class Maximum_Number
    {
        public void Array()
        {
            Console.Write("Enter a numbers (1 1 1 2 3...): ");
            int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int longest = 1;
            int begin = 0;
            int currentLongest = 1;
            int currentBegin = 0;

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == values[i - 1])
                {
                    currentLongest++;

                    if (currentLongest > longest)
                    {
                        longest = currentLongest;
                        begin = currentBegin;
                    }
                }
                else
                {
                    currentLongest = 1;
                    currentBegin = i;
                }
            }

            for (int i = begin; i < begin + longest; i++)
                 Console.Write($"{values[i]} ");
        }

    }
}
