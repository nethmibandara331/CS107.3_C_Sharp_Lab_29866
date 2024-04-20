using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet2Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            Console.WriteLine("Enter your account number:");
            account.AccountNumber=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter The amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.Deposit(amount);

            Console.WriteLine("Account number:"+account.AccountNumber);
            Console.WriteLine("Update balance:" + account.Balance);

            Console.ReadLine();
        }
    }

    internal class BankAccount
    {
        public int AccountNumber;
        public double Balance=1000;

        public void Deposit(double amount)
        {
            Balance=Balance+amount;
        }
    }
}
