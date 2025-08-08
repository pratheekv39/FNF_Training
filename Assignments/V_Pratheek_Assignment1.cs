using System;
namespace Assignments
{
    internal class V_Pratheek_Assignment1
    {
        public static void DisplayRanges()
        {
            Console.WriteLine("Integral Types:");
            Console.WriteLine($"byte: {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"short: {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("\nFloating Point Types:");
            Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");
        }
        static void Main(string[] args)
        {
            DisplayRanges();
        }
    }
}
