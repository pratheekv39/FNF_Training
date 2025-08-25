using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignments
{
    internal class V_Pratheek_Assignment7
    {
        static void Main(string[] args)
        {
            IsPrimeNumber(17);
        }

        static bool IsPrimeNumber(int num)
        {
            for(int i = 2; i < Math.Sqrt(num);i++)
            {
                if(num%i==0)
                {
                    Console.WriteLine($"{num} is not a Prime Number");
                    return true;
                }
            }
            Console.WriteLine($"{num} is a Prime Number");
            return false;
        }
    }
}
