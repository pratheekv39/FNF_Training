using System;

namespace BankingDemo
{
    abstract class Account
    {
        static int _accountNoSeed = 1000;
        public int AccountNo { get; private set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public Account()
        {
            AccountNo = ++_accountNoSeed;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }
            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance is {Balance}.");
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount}. New balance is {Balance}.");
        }

        public abstract void CalculateInterest();
    }

    class SavingsAccount : Account
    {
        public double InterestRate { get; set; } = 2.5;

        public SavingsAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
        }

        public override void CalculateInterest()
        {
            double interest = Balance * InterestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest earned on Savings Account: {interest}");
        }
    }

    class RecurringDepositAccount : Account
    {
        public double InterestRate { get; set; } = 5.0;
        public double MonthlyDeposit { get; set; }
        public int Months { get; set; }

        public RecurringDepositAccount(string accountHolder, double monthlyDeposit, int months)
        {
            AccountHolder = accountHolder;
            MonthlyDeposit = monthlyDeposit;
            Months = months;
        }

        public override void CalculateInterest()
        {
            double interest = (MonthlyDeposit * Months * (Months + 1) * InterestRate) / (2 * 12 * 100);
            Deposit(interest);
            Console.WriteLine($"Interest earned on Recurring Deposit Account: {interest}");
        }
    }

    class FDAccount : Account
    {
        public double Principal { get; set; }
        public double InterestRate { get; set; } = 6.5;
        public int Years { get; set; }

        public FDAccount(string accountHolder, double principal, int years)
        {
            AccountHolder = accountHolder;
            Principal = principal;
            Years = years;
            Deposit(principal);
        }

        public override void CalculateInterest()
        {
            double interest = Principal * InterestRate * Years / 100;
            Deposit(interest);
            Console.WriteLine($"Interest earned on Fixed Deposit Account: {interest}");
        }
    }
}

namespace SampleConApp
{
    using BankingDemo;

    internal class Ex11AbstractClassesDemo
    {
        static Account CreateAccount()
        {
            Console.Write("Enter Account Holder Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Choose Account Type:");
            Console.WriteLine("1. Savings");
            Console.WriteLine("2. Recurring Deposit");
            Console.WriteLine("3. Fixed Deposit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    return new SavingsAccount(name);
                case 2:
                    Console.Write("Enter Monthly Deposit: ");
                    double monthly = double.Parse(Console.ReadLine());
                    Console.Write("Enter Number of Months: ");
                    int months = int.Parse(Console.ReadLine());
                    return new RecurringDepositAccount(name, monthly, months);
                case 3:
                    Console.Write("Enter Principal Amount: ");
                    double principal = double.Parse(Console.ReadLine());
                    Console.Write("Enter Number of Years: ");
                    int years = int.Parse(Console.ReadLine());
                    return new FDAccount(name, principal, years);
                default:
                    Console.WriteLine("Invalid choice. Defaulting to Savings Account.");
                    return new SavingsAccount(name);
            }
        }

        static void Main(string[] args)
        {
            Account acc = CreateAccount();

            Console.Write("Enter deposit amount: ");
            acc.Deposit(double.Parse(Console.ReadLine()));

            Console.Write("Enter withdrawal amount: ");
            acc.Withdraw(double.Parse(Console.ReadLine()));

            acc.CalculateInterest();
            Console.WriteLine("The current Balance : " + acc.Balance);
        }
    }
}
