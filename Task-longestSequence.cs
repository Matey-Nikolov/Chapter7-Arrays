using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Arrays
{
    class Task_longestSequence
    {

        public int[] Array()
        {
            Console.Write("Enter a numbers: ");
            int[] arrayNumbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int length = arrayNumbers.Length;

            int start = 0;
            int len = 1;

            int bestStart = 0;
            int bestlen = 0;

            int[] longConsistents = new int[length];

            for (int i = 0; i < length - 1; i++)
            {

                if (arrayNumbers[i] == arrayNumbers[i + 1])
                {
                    start++;
                    if (start > bestStart)
                    {
                        bestlen = start;
                        bestStart = len;
                    }
                }
                else
                {
                    start = 1;
                    bestlen = i;
                }
            }

            int[] result = arrayNumbers
                .Skip(bestStart)
                .Take(bestlen)
                .ToArray();

            return result;
        }
    }
}
