using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7_Arrays
{
    class Task_Sort
    {
        /*
        public int[] SortArray_17()
        {
            // Task 17.
            //
            //
            Console.Write("Enter a numbers: ");
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
        */


        public int[] SortArray_8()
        {
            // Task 8.
            //
            //
            Console.Write("Enter a numbers: ");
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SelectionSort(numbers);

            return numbers;
        }

        static void SelectionSort(int[] arr)
        {
            // Task 8.
            //
            //
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIdx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[minIdx])
                        minIdx = j;

                int temp = arr[minIdx];
                arr[minIdx] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
