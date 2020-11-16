using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Alex Fabiany", 0.0);
            BusinessAccount baccount = new BusinessAccount(1002, "Maria Possível", 0.0, 500.0);

            // Upcasting

            Account account1 = baccount;
            Account account2 = new BusinessAccount(1003, "Marcíria", 0.0, 200.0);
            Account account3 = new SavingsAccount(1004, "Valente", 0.0, 0.01);

            // Downcasting

            BusinessAccount account4 = (BusinessAccount)account2;
            account4.Loan(100.0);

            //BusinessAccount account5 = (BusinessAccount)account3; Erro na execução
            if(account3 is BusinessAccount)
            {
                // BusinessAccount account5 = (BusinessAccount)account3;
                BusinessAccount account5 = account3 as BusinessAccount;
                account5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(account3 is SavingsAccount)
            {
                // SavingsAccount account5 = (SavingsAccount)account3;
                SavingsAccount account5 = account3 as SavingsAccount;
                account5.UpdateBalance();
                Console.WriteLine("Updated!");
            }

            Console.WriteLine(account);
            Console.WriteLine(account1);
            Console.WriteLine(account2);
            Console.WriteLine(account3);
            Console.WriteLine(account4);
            
            // account.Balance = 20000.0;
        }
    }
}
