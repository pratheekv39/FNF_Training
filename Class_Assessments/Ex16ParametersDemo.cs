using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

//Functions or methods allow to have parameters in them.
//C# supports different types of parameters : ref, out, params and normal parameters
namespace SampleConApp
{
    internal class Ex16ParametersDemo
    {
        public static void AddFunc(int first, int second, out double result)=> result= first + second;

        public static void NormalParameter(int x) => x += 100;

        public static long AddNumbers(params int[] numbers)
        {
            long sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static void ArithmeticFunction(int first, int second, ref double addedvalue,ref double subtractedvalue, ref double multipliedvalue,ref double dividedvalue)
        {
            addedvalue = first + second;
            subtractedvalue = first - second;
            multipliedvalue = first + second;

            if(second!=0)
            {
            addedvalue = first / second;
            }
            else
            {
                Console.WriteLine("Divide by Zero Error");
            }
        }

        static void Main(string[] args)
        {
            int x=10;
            NormalParameter(x);
            Console.WriteLine(x);
            double x2;
            AddFunc(10, 20, out x2);//Retains the result in the out parameter, even after the method call, the out parameter retains the value assigned in the method.
            Console.WriteLine(x2);
            double addedvalue = 0, subtractedvalue = 0, multipliedvalue = 0,dividedvalue=0 ;

            ArithmeticFunction(10, 20, ref addedvalue, ref subtractedvalue, ref multipliedvalue, ref dividedvalue);

            
            Console.WriteLine(AddNumbers(10, 20, 30)); //using params to add n number of parameters to a given function

        }
    }
}
