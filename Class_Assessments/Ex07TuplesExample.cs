using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex07TuplesExample
    {
        static void Main(string[] args)
        {
            var myExample = (45, "MyName");
            Console.WriteLine($"First Item is : " +myExample.Item1 + "\n" + "Second Item is : " +myExample.Item2);
            Console.WriteLine("Data type is: " + myExample.GetType().Name);


            //You can have named tuple a well.
            var person = (Name: "Pratheek", Age: 22, City: "Hassan");
            Console.WriteLine("Data type is: " + person.GetType().Name);

            Console.WriteLine("Name is :" +person.Name+"\n" + "Age is: " +person.Age+"\n" + "City is: " + person.City);

            var (longId, latId) = GetCoordinates();
            Console.WriteLine("Returned value is :" + (longId, latId));

           
        }
        static (double, double) GetCoordinates()
        {
            return (15.55, 16.44);
        }
    }
}
