using System;
using System.Globalization;

namespace Course {
  class Program {
    static void Main(string[] args) {

      Console.Write("Nome: ");
      string nome = Console.ReadLine();
      Console.Write("Salário Bruto: ");
      double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      Console.Write("Imposto: ");
      double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Funcionario func = new Funcionario(nome, salario, imposto);

      Console.WriteLine();
      Console.WriteLine("Funcionário: " + func);

      Console.WriteLine();
      Console.WriteLine("Deseja aumentar o salário em qual porcentagem? ");
      double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      func.AumentarSalario(porcent);

      Console.WriteLine();
      Console.WriteLine("Dados atualizados: " + func);
    }
  }
}
