using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SampleConApp
{

    class SuperClass
    {
       public SuperClass() {
            Console.WriteLine("Super class constructor");
        }
    }

    class BaseClass1:SuperClass {
        public BaseClass1()
        {
            Console.WriteLine("Base class constructor");
        }
    }
    internal class Ex15Constructors
    {
        static void Main(string[] args)
        {
           BaseClass1 baseClass = new BaseClass1();
        }
    }
}
