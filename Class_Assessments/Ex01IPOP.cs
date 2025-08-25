namespace SampleConApp
{
    internal class Ex01IPOP
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your address: ");
            //string address = Console.ReadLine();

            //Console.WriteLine($"Entered name is {name}\nEntered address is {address}");
            //Console.WriteLine("Entered name is {0}\nEntered address is {1}",name,address);

            DisplayUserDetails();
        }


        static void DisplayUserDetails()
        {
            Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Mobile Number: ");
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine($"Number is {name}\nAge is {age}\nNumber is {num}");

        }
    }
}
