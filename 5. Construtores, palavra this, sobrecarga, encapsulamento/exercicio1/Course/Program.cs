using System;
using System.Globalization;

namespace Course {
  class Program {
    static void Main(string[] args) {

      ContaBancaria conta;

      Console.Write("Informe o número da conta: ");
      int numero = int.Parse(Console.ReadLine());

      Console.Write("Informe o nome do titular da conta: ");
      string nome = Console.ReadLine();

      Console.Write("Haverá depósito inicial (s/n)? ");
      char resp = char.Parse(Console.ReadLine());

      if (resp == 's' || resp == 'S') {
        Console.Write("Informe o valor do depósito inicial: ");
        double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        conta = new ContaBancaria(numero, nome, depositoInicial);
      }
      else {
        conta = new ContaBancaria(numero, nome);
      }

      Console.WriteLine();
      Console.WriteLine("Dados da conta:");
      Console.WriteLine(conta);

      Console.WriteLine();
      Console.Write("Informe um valor para depósito: ");
      double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.Depositar(valorDeposito);      
      Console.WriteLine("Dados da conta atualizados:");
      Console.WriteLine(conta);

      Console.WriteLine();
      Console.Write("Informe um valor para saque: ");
      double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      conta.Sacar(valorSaque);
      Console.WriteLine("Dados atualizados:");
      Console.WriteLine(conta);
    }
  }
}
