using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class V_Pratheek_Assignment4
    {

        static void Main(string[] args)
        {
            Console.WriteLine("--- Dynamic Array Creator ---");

            Console.Write("Enter the type of array (int, double, string): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Enter the size of the array: ");
            if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0)
            {
                Console.WriteLine("Invalid size. Please enter a positive integer.");
                return;
            }

            Console.WriteLine($"Enter {size} values for the {type} array:");

            switch (type)
            {
                case "int":
                    int[] intArray = new int[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Element {i + 1}: ");
                        intArray[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nArray Contents:");
                    foreach (var item in intArray)
                        Console.WriteLine(item);
                    break;

                case "double":
                    double[] doubleArray = new double[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Element {i + 1}: ");
                        doubleArray[i] = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("\nArray Contents:");
                    foreach (var item in doubleArray)
                        Console.WriteLine(item);
                    break;

                case "string":
                    string[] stringArray = new string[size];
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write($"Element {i + 1}: ");
                        stringArray[i] = Console.ReadLine();
                    }
                    Console.WriteLine("\nArray Contents:");
                    foreach (var item in stringArray)
                        Console.WriteLine(item);
                    break;

                default:
                    Console.WriteLine("Unsupported type. Please choose from int, double, or string.");
                    break;
            }
        }
    }
}
