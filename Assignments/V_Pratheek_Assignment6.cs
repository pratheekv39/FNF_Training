using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments
{
    internal class V_Pratheek_Assignment6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Valid dates example");

            isValidDate(2004, 2, 29);
            isValidDate(2004, 2, 29);   // Leap year, valid
            isValidDate(2020, 12, 31);  // Valid end of year
            isValidDate(2023, 1, 1);    // Valid start of year
            isValidDate(2016, 2, 29);   // Leap year, valid
            isValidDate(2024, 4, 30);   // April has 30 days
            Console.WriteLine("\n");

            Console.WriteLine("Invalid dates example");
            isValidDate(2018, 2, 29);   // Not a leap year
            isValidDate(2025, 4, 31);   // April has only 30 days
            isValidDate(2022, 13, 10);  // Invalid month
            isValidDate(2022, 0, 10);   // Invalid month
            isValidDate(2022, 6, 0);    // Invalid day
            isValidDate(2022, 6, 32);   // June has only 30 days


        }

        static bool isValidDate(int year, int month, int day)
        {
            Hashtable table= new Hashtable();
            table.Add(1, 31);
            table.Add(2, 28);
            table.Add(3, 31);
            table.Add(4, 30);
            table.Add(5, 31);
            table.Add(6, 30);
            table.Add(7, 31);
            table.Add(8, 31);
            table.Add(9, 30);
            table.Add(10, 31);
            table.Add(11, 30);
            table.Add(12, 31);
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                table[2] = 29;
            }
            if(month <= 12 && month >= 1 && day <= (int)table[month] && day >= 1)
            {
                
                Console.WriteLine("Valid");
                return true;
            }

            else
            {
                Console.WriteLine("Invalid");
                return false;
            }
        }
    }
}
