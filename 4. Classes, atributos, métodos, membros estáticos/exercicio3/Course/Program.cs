using System;
using System.Globalization;

namespace Course {
  class Program {
    static void Main(string[] args) {

      Console.Write("Nome do Aluno: ");
      string nome = Console.ReadLine();
      Console.WriteLine("Informa as três notas do aluno: ");
      double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Aluno aluno = new Aluno(nome, nota1, nota2, nota3);

      Console.WriteLine(aluno);
    }
  }
}
