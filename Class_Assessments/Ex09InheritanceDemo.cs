using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class BaseClass
        //This class is internal.Internal classes are accessible only within the same assembly/project. If you want to make it accessible outside the assembly/project, you need to make it public.
    {
        public void Display()
        {
            Console.WriteLine("Base Class Display Method");
        }

    }

    //A derived class that inherits from Baseclass is required if you want to add a new functionality or override existing functionality of the base class. A class is immutable by default, meaning you cannot change it's functionality unless you inherit from it. (Open-Closed principle of SOLID)
    //C# does not support multiple inheritance, meaning a class cannot inherit from more than one base class at the same level. However, it can implement multiple interfaces. C# supports multi level inheritance.

    class DerivedClass : BaseClass
    {
        public void Show()
        {
            Console.WriteLine("Derived Class Show Method");
        }
    }

    class Ex09InheritanceDemo
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            d.Display();
            d.Show();  

        }
    }
}
