using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Arrays
{
    class Task_One
    {
        public int[] ReturnArrayBy5()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int[] array = new int[num];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            return array;
        }
    }
}
