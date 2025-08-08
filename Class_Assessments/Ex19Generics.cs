using System;
using System.Collections.Generic;//This is the namespace for Generics.

//Generics is a feature of .NET that can allow to create classes, methods and interfaces that can work on any kind of data type. They are similar to templates in C++.
//They are said to be type-safe, meaning that they can enforce type constraints at compile time, reducing runtime errors. U dont have to unbox the data when U use generics, as they are already type-safe.
namespace SampleConApp
{
    internal class Ex19Generics
    {
        static void Main(string[] args)
        {
            //listExample();
            HashSetExample();
            DictionaryExample();
        }

        //HashSet is a collection of unique items. It is similar to a List. No Duplicates are allowed.
        private static void HashSetExample()
        {
            //HashSetSimpleMethod();
            HashSetOnEmployeeExample();
        }

        private static void HashSetOnEmployeeExample()
        {
            //In HashSet, the items are compared using the GetHashCode() and Equals() methods. If two items have the same hash code, then they are compared with the Equals method and then are considered equal/unequal.
            HashSet<Employee> employees = new HashSet<Employee>();
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });
            employees.Add(new Employee { EmpID = 2, EmpName = "Jane", EmpAddress = "Los Angeles", EmpSalary = 60000, Designation = "Developer" });
            employees.Add(new Employee { EmpID = 3, EmpName = "Doe", EmpAddress = "Chicago", EmpSalary = 55000, Designation = "Tester" });
            employees.Add(new Employee { EmpID = 4, EmpName = "Alice", EmpAddress = "Houston", EmpSalary = 70000, Designation = "Designer" });
            employees.Add(new Employee { EmpID = 5, EmpName = "Bob", EmpAddress = "Phoenix", EmpSalary = 65000, Designation = "Analyst" });
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });
            employees.Add(new Employee { EmpID = 1, EmpName = "John", EmpAddress = "New York", EmpSalary = 50000, Designation = "Manager" });

            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmpName} earns a salary of {emp.EmpSalary:C}");
            }
        }

        private static void HashSetSimpleMethod()
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("John");
            names.Add("Jane");
            names.Add("Doe");
            if (!names.Add("John"))
                Console.WriteLine("John is already the member of the  Team");
            Console.WriteLine("The total members of the team: " + names.Count);
        }

        private static void listExample()
        {
            List<string> names = new List<string>();
            names.Add("John");//Add only strings to the list.
            names.Add("Jane");
            names.Add("Doe");
            names.Add("Smith");
            names.Add("Alice");
            names.Add("Bob");
            names.Insert(2, "Charlie");//Insert at index 2. This will shift the other items to the right.

            //Iterating through the list using foreach loop. foreach is a easy way to iterate through a collection in C#. It is forward-only and readonly. U can move by 1 number at a time.
            foreach (string name in names)
            {
                Console.WriteLine(name.ToUpper());//No unboxing is required as the list is of type string.
            }
            //Like ArrayList, here also U can insert, remove, and search for items in the list from any where.
            string nameToFind = ConsoleUtil.GetInputString("Enter a name to find: ");
            if (!names.Contains(nameToFind))
            {
                Console.WriteLine("UR Entered Name does not exist");
            }
            else
            {
                //for(int i =0; i < names.Count; i++)
                //{
                //    if(names[i] == nameToFind)
                //    {
                //        Console.WriteLine($"UR Entered Name is found at index {i}");
                //        break; //Exit the loop once the name is found.
                //    }
                //}
                var index = names.IndexOf(nameToFind); //This will return the index of the name if found, otherwise -1.
                Console.WriteLine($"UR Entered Name is found at index {index}");
            }
        }

        //Similar to hashtable, but it is type-safe and faster. It is a collection of key-value pairs.Each item in the dictionary is a key-value pair, where the key is unique and the value can be of any type.
        private static void DictionaryExample()
        {
            //Dictionary is a collection of key-value pairs. It is similar to Hashtable, but it is type-safe and faster.
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("user1", "password1");
            users.Add("user2", "password2");
            users.Add("user3", "password3");
            //Check if the user exists in the dictionary.
            string username = ConsoleUtil.GetInputString("Enter the Username");
            if (!users.ContainsKey(username))
            {
                Console.WriteLine("User does not exist");
                return;
            }
            string password = ConsoleUtil.GetInputString("Enter the Password");
            if (!users[username].Equals(password))
            {
                Console.WriteLine("Invalid Password");
                return;
            }
            else
            {
                Console.WriteLine($"Welcome {username}");
            }
        }
    }
}