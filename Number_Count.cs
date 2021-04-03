using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Arrays
{
    class Number_Count
    {
        public void TheMostCommonElement()
        {
            Console.Write("Enter a numbers (1, 2, 2, 1, 2...): ");
            int[] numbersArray = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            foreach (int number in numbersArray)
            {
                if (!numbersCount.ContainsKey(number))
                    numbersCount.Add(number, 1);
                else
                    numbersCount[number]++;
            }

            foreach (var numCount in numbersCount.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"The digit: {numCount.Key} occurs most often: {numCount.Value}");
                return;
            }
            
        }

    }
}
