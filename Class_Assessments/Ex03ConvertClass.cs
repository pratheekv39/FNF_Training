using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    internal class Ex03ConvertClass
    {
        static void Main(string[] args)
        {
            TypeCastingExample();
        }

        static void TypeCastingExample()
        {
            int iVal = 123;
            long lVal = iVal;  //implicit conversion from int to long
            double dVal = 133.45;
            lVal = (long)dVal;  //explicit type conversion from double to long
            //You can use convert class to convert from one type to another. This is more safe than casting. If the casting is not possible, it throws anexception.
            lVal=Convert.ToInt64(dVal); //Convert class is available in system namespace.It has methods to convert from one type to another.
            Console.WriteLine(lVal);

        }
    }
}
