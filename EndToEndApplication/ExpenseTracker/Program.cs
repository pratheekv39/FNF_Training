using ExpenseManagerLib;
using ExpenseManagerLib.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IExpenseDB expenseDB = new ExpenseDB();

            while (true)
            {
                Console.WriteLine("Expense Tracker Menu:");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. Update Expense");
                Console.WriteLine("3. Delete Expense");
                Console.WriteLine("4. Get Expense by Id");
                Console.WriteLine("5. List All Expenses");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddExpense(expenseDB);
                        break;
                    case "2":
                        UpdateExpense(expenseDB);
                        break;
                    case "3":
                        DeleteExpense(expenseDB);
                        break;
                    case "4":
                        GetExpenseByID(expenseDB);
                        break;
                    case "5":
                        GetAllExpenses(expenseDB);
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Invalid option.\n");
                        break;
                }
            }
        }

        private static void GetAllExpenses(IExpenseDB expenseDB)
        {
            IEnumerable<Expense> expenses = expenseDB.GetAllExpenses();
            foreach (var exp in expenses)
            {
                Console.WriteLine($"Id: {exp.ExpId}, Desc: {exp.ExpDesc}, Amount: {exp.Amount}, Date: {exp.ExpDate:yyyy-MM-dd}");
            }
            Console.WriteLine();
        }

        private static void GetExpenseByID(IExpenseDB expenseDB)
        {
            Console.Write("Enter Expense Id to view: ");
            int getId = int.Parse(Console.ReadLine());
            expenseDB.GetExpense(getId);
        }

        private static void DeleteExpense(IExpenseDB expenseDB)
        {
            Console.Write("Enter Expense Id to delete: ");
            int delId = int.Parse(Console.ReadLine());
            expenseDB.DeleteExpense(delId);
            Console.WriteLine("Expense deleted.\n");
        }

        private static void UpdateExpense(IExpenseDB expenseDB)
        {
            var updateExpense = new Expense();
            Console.Write("Enter Expense Id to update: ");
            updateExpense.ExpId = int.Parse(Console.ReadLine());
            Console.Write("Enter New Description: ");
            updateExpense.ExpDesc = Console.ReadLine();
            Console.Write("Enter New Amount: ");
            updateExpense.Amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter New Date (yyyy-MM-dd): ");
            updateExpense.ExpDate = DateTime.Parse(Console.ReadLine());
            expenseDB.UpdateExpense(updateExpense);
            Console.WriteLine("Expense updated.\n");
        }

        private static void AddExpense(IExpenseDB expenseDB)
        {
            var newExpense = new Expense();
            Console.Write("Enter Description: ");
            newExpense.ExpDesc = Console.ReadLine();
            Console.Write("Enter Amount: ");
            newExpense.Amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter Date (yyyy-MM-dd): ");
            newExpense.ExpDate = DateTime.Parse(Console.ReadLine());
            expenseDB.AddExpense(newExpense);
            Console.WriteLine("Expense added.\n");
        }
    }
}
