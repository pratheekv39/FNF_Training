using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class V_Pratheek_Assignment2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array:");
            int size = int.Parse(Console.ReadLine());

            int[] numbers = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Element {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            DisplayOddEven(numbers);
        }

        static void DisplayOddEven(int[] arr)
        {
            Console.WriteLine("\nEven Numbers:");
            foreach (int num in arr)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }

            Console.WriteLine("\nOdd Numbers:");
            foreach (int num in arr)
            {
                if (num % 2 != 0)
                    Console.WriteLine(num);
            }
        }
    }
}