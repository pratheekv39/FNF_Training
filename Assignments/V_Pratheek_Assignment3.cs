using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class V_Pratheek_Assignment3
    {


        static void Main(string[] args)
        {
            bool continueCalc = true;

            while (continueCalc)
            {
                Console.WriteLine("\n--- Math Calculator ---");

                Console.Write("Enter first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                double result = 0;
                bool validOperation = true;

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero is not allowed.");
                            validOperation = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator. Please use +, -, *, or /.");
                        validOperation = false;
                        break;
                }

                if (validOperation)
                {
                    Console.WriteLine($"Result: {result}");
                }

                Console.Write("\nDo you want to perform another calculation? (yes/no): ");
                string response = Console.ReadLine().ToLower();
                continueCalc = response == "yes";
            }

            Console.WriteLine("Calculator closed.");
        }
    }
}