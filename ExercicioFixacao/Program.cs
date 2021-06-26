using System;
using System.Globalization;
using ExercicioFixacao.Entities;
using ExercicioFixacao.Entities.Exceptions;

namespace ExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data:");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string name = Console.ReadLine();

                Console.Write("Intial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw limit: "); ;
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, name, balance, limit);

                Console.Write("\nEnter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine("New balace: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch(DomainException a)
            {
                Console.WriteLine(a.Message);
            }
            catch(Exception b)
            {
                Console.WriteLine("Error: " + b.Message);
            }
        }
    }
}
