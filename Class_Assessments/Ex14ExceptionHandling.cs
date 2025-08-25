using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Exceptions are scenarios that occur during the execution of a program that disrupt the normal flow of instructions.
 * Possible causes of exceptions include: File not found, network issues, invalid user input, access issues etc.
 * C# provides exception handling to manage these scenarios gracefully in the form of try-catch blocks
 * Try block contains code that may create an exception, catch block contains code that handles the specified exception.
 * Keywords: try, catch, finally, throw
 * throw keyword is used to wxplicitly throw an exception. It can be used to create custom exceptions or rethrow existing exceptions.
 * All Exceptions are derived from System.Exception class.
 * */
namespace SampleConApp
{
    internal class Ex14ExceptionHandling
    {

        [Serializable]
        public class DBFailureException : Exception
        {
            public DBFailureException() {
                Console.WriteLine("Cannot connect to the system");
            }
            public DBFailureException(string message) : base(message) { }
            public DBFailureException(string message, Exception inner) : base(message, inner) { }
            
        }
        static void Main(string[] args)
        {
        RETRY:
            try
            {
                //Console.WriteLine("Enter the age: ");
                //int age = int.Parse(Console.ReadLine());
                //Console.WriteLine($"The age is {age}");
                ThrowingExceptionExample();
            }


            catch (FormatException ex1)
            {
                Console.WriteLine($"The system generated the message: {ex1.Message}");
                Console.WriteLine($"Input must be a valid number");
                goto RETRY;
            }

            catch (OverflowException ex2)
            {
                Console.WriteLine($"The system generated the message: {ex2.Message}");
                Console.WriteLine($"Input must be within the range {int.MinValue} and {int.MaxValue}");
                goto RETRY;
            }
            catch(DBFailureException ex)
            {
                Console.WriteLine($"Custom Exception Caught: {ex.Message}");
            }
            finally
            {
                //Finally is more like a cleanup code that will always run.
                //You cannot have jump statements in a finally block like break, continue etc.
                Console.WriteLine("Finally block executed.This will always run");
            }
        }
        
        public static void ThrowingExceptionExample()
        {
            string name = ConsoleUtil.GetInputString("Enter the username: ");
            string pwd = ConsoleUtil.GetInputString("Enter the password: ");
            if(name=="admin" && pwd=="admin")
            {
                Console.WriteLine("Welcome to the system");
            }
            else
            {
                throw new DBFailureException();
            }

        }
    }
}
