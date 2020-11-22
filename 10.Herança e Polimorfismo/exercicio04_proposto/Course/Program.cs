using System;
using System.Collections.Generic;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or Company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch.ToString().ToUpper() == "I")
                {
                    Console.Write("Health expeditures: ");
                    double healthExpeditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpeditures));
                }
                else if (ch.ToString().ToUpper() == "C")
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double totalTaxes = 0;
            foreach (TaxPayer taxPayer in list)
            {
                double tax = taxPayer.Tax();
                Console.WriteLine($"{taxPayer.Name} $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += tax;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.ReadKey();
        }
    }
}
