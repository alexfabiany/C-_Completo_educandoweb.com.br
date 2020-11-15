using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(1010, "Alex Fabiany", 10000.0, 5000.0);
            Console.WriteLine(account.Balance);
            // account.Balance = 20000.0;
        }
    }
}
