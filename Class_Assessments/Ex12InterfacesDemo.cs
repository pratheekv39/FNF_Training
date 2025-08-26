using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Interface is a set of members that can be implemented by a class. It contains only abstract methods. Interfaces cannot have fields, properties, or constructors. They can have methods, events, and indexers. A class can implement multiple interfaces, allowing for a form of multiple inheritance. Interfaces are used to define a contract that classes must adhere to, promoting loose coupling and flexibility in design.
//interface members cannot have access modifiers. All members of an interface are implicitly public and abstract.
//Purpose of the interface is to define a contract that compells a class that implements it to provide public implementations for the members defined in the interface.
//If an class implements an interface, it means that the class is providing a concrete implementation for all the members defined in the interface. This allows for polymorphism, where a reference of the interface type can be used to refer to an object of the class that implements the interface.

namespace SampleConApp
{
    interface Animal
    {
        public void Walk();
        public void Talk();
        public void Type();
    }

    class Horse : Animal
    {
        public void Talk()
        {
            Console.WriteLine("It talks");
        }

        public void Type()
        {
            Console.WriteLine("It is a Mammal");
        }

        public void Walk()
        {
            Console.WriteLine("It walks");

        }
    }




    class Ex12InterfacesDemo
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            horse.Walk();
            horse.Talk();
            horse.Type();
        }
    }
}
