using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Arrays
{
    class Task_Тwo_Same_Array
    {
        public string ReturnFrueOrFalse()
        {
            Console.Write("Enter a numbers: ");
            int[] array = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            Console.Write("Enter a numbers: ");
            int[] arrayTwo = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int length1 = array.Length;
            int length2 = arrayTwo.Length;

            if (length1 > length2 || length2 > length1)
            {
                return "false.";
            }


            for (int i = 0; i < length1; i++)
            {
                int num = array[i];
                for (int a = 0; a < length2; a++)
                {
                    int num1 = arrayTwo[a];
                    if (num != num1)
                    {
                        return "False. They are not the same.";
                    }
                }
            }
            return "True. They are the same.";
        }
    }
}
