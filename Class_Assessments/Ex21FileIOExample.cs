using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleConApp
{
    internal class Ex21FileIOExample
    {

        static void Main(string[] args)
        {
            var files = Directory.GetFiles("C:\\Users\\6152782\\Downloads");
            foreach (var file in files)
            {
                var selected_file = new FileInfo(file);
                Console.WriteLine($"The Name: {selected_file.Name}, Created on {selected_file.CreationTime}");

            }
            Console.WriteLine("Displaying Directories and its Info");
            var directorys = Directory.GetDirectories("C:\\Users\\6152782\\Downloads");
            foreach (var dirPath in directorys)
            {
                var dir = new DirectoryInfo(dirPath);
                Console.WriteLine(dir.Name);
            }

            var newDir = "C:\\Users\\6152782\\Downloads\\TestDir";
            var dirInfo = Directory.CreateDirectory(newDir);
            var parent = dirInfo.Parent;
            foreach (var dir_path in directorys)
            {
                var info = new DirectoryInfo(dir_path);
                foreach (var file in info.GetFiles())
                {
                    Console.WriteLine(file.Name);
                }
            }

            creatingCsvFile();
            readingCsvFile();
        }

        private static void creatingCsvFile()
        {
            var customer = new Customer
            {
                CustomerId = 123,
                CustomerName = "Joe",
                BillAmount = 5000
            };

            var filePath = "C:\\Users\\6152782\\Downloads\\customer.csv";
            var content = $"{customer.CustomerId},{customer.CustomerName},{customer.BillAmount}\n";
            File.WriteAllText(filePath, content);
            //Writes to the file, if the file does not exist, it shall create the file and write to it, of the file exists, it shall overwrite the contents.
        }

        private static void readingCsvFile()
        {
            var filePath = "C:\\Users\\6152782\\Downloads\\customer.csv";
            if (File.Exists(filePath))
            {
                var content = File.ReadAllText(filePath);
                var parts = content.Split(',');
                if (parts.Length == 3)
                {
                    var customer = new Customer
                    {
                        CustomerId = int.Parse(parts[0]),
                        CustomerName = parts[1],
                        BillAmount = double.Parse(parts[2])
                    };

                    Console.WriteLine($"Customer ID: {customer.CustomerId}, Customer Name: {customer.CustomerName},Customer Bill: {customer.BillAmount}");
                }

                else
                {
                    Console.WriteLine("Invalid CSV Format");
                }
            }
            else
            {
                Console.WriteLine("File Not Found");
            }



        }
    }
}
