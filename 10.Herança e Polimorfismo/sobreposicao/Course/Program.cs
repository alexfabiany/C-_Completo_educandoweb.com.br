using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(1001, "Alex Fabiany", 500.0);
            Account account2 = new SavingsAccount(1002, "Marcíria Lima", 500.0, 0.01);

            account1.Withdraw(10.0);
            account2.Withdraw(10.0);

            Console.WriteLine(account1.Balance);
            Console.WriteLine(account2.Balance);
        }
    }
}
