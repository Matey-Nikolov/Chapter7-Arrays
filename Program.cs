using System;
using System.Linq;

namespace Chapter7_Arrays
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("1"); // Ok
                Console.WriteLine("2"); // OK
                Console.WriteLine("3"); // Ok
                Console.WriteLine("4"); // Ok
                Console.WriteLine("5"); // Ok
                Console.WriteLine("8"); // Ok
                Console.WriteLine("24"); // Ok

                Console.WriteLine("----------");

                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Task_One arr = new Task_One();
                        Console.WriteLine(string.Join(" ", arr.ReturnArrayBy5()));
                        Console.WriteLine("----------");
                        break;
                    case 2:
                        Task_Тwo_Same_Array task = new Task_Тwo_Same_Array();
                        Console.WriteLine(task.ReturnFrueOrFalse());
                        Console.WriteLine("----------");
                        break;
                    case 3:

                        Console.Write("Enter a letters (abc ...): ");
                        char[] chArray = Console.ReadLine()
                            .ToCharArray();

                        Console.Write("Enter a letters (bcd ...): ");
                        char[] chArray2 = Console.ReadLine()
                            .ToCharArray();

                        if (chArray.Length < chArray2.Length)
                        {
                            Console.WriteLine("(charArray) First array is lexicographicaly.");
                            break;
                        }
                        else if (chArray.Length > chArray2.Length)
                        {
                            Console.WriteLine("(chArray2) Second array is lexicographicaly.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < chArray.Length; i++)
                            {
                                if (chArray[i] < chArray2[i])
                                {
                                    Console.WriteLine("(charArray) First array is lexicographicaly.");
                                    break;
                                }
                                else if (chArray[i] > chArray2[i])
                                {
                                    Console.WriteLine("(chArray2) Second array is lexicographicaly.");
                                    break;
                                }
                            }
                        }
                        break; 
                    case 4:
                        Maximum_Number number = new Maximum_Number();
                        number.Array();
                        Console.WriteLine();
                        Console.WriteLine("----------");

                        break;
                    case 5:
                        Consecutive_Ascending_Number ascendingNumber = new Consecutive_Ascending_Number();
                        ascendingNumber.Ascending(); 
                        Console.WriteLine();
                        Console.WriteLine("----------");

                        break;
                    case 8:
                        Task_Sort numSort = new Task_Sort();
                        Console.WriteLine(string.Join(" ", numSort.SortArray()));
                        break;
                    case 24:

                        int number1 = int.Parse(Console.ReadLine());
                        int number2 = int.Parse(Console.ReadLine());

                        for (int i = 1; i <= number2 + 1; i++)
                        {
                            for (int a = 1; a <= number1; a++)
                            {
                                Console.WriteLine($"{i}{a}");
                            }
                        }
                        break;
                }
            }
        }
    }
}
