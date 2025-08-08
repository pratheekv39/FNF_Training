using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Object is the universal data type in C#. All data types in C# are derived from Object Class. It is a reference type. Object is like void*(Reference) of C/C++.
 * Boxing and Unboxing are the two important concepts in Object Class. Boxing is implicit casting where every type is implicitly converted to object type.Unboxing is explicit casting where Object type is expicitly converted to the original type. You cannot cast a reference type to a value type without unboxing.
 * */

namespace SampleConApp
{
    internal class Ex06ObjectClass
    {
        static void Main(string[] args)
        {
            object obj = 10;
            Console.WriteLine("The datatype is " +obj.GetType().Name);
            obj = "Sample Text";
            Console.WriteLine("The datatype is " +obj.GetType().Name);

        }
    }
}
