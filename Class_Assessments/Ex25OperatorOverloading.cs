using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex25OperatorOverloading
    {
        class Example
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public double Salary { get; set; }

            public static Example operator + (Example lhs,double rhs)
            {
                lhs.Salary += rhs;//Overloading the + operator to increase the salary
                return lhs;
            }
            public static Example operator - (Example lhs,double rhs)
            {
                lhs.Salary -= rhs;//Overloading the - operator to decrease the salary
                return lhs;
            }
        }
        static void Main(string[] args)
        {
            Example emp1=new Example { Id = 1, Name = "John", Salary = 50000 };
            emp1+= 5000; //Using the overloaded operator to increase salary
            emp1 -= 2000; //Using the overloaded operator to decrease salary
            Console.WriteLine("The salary is : " +emp1.Salary);
        }
    }
}
