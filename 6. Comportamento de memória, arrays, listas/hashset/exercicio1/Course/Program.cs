using System;
using System.Collections.Generic;

namespace Course {
  class Program {
    static void Main(string[] args) {

      HashSet<int> A = new HashSet<int>();
      HashSet<int> B = new HashSet<int>();
      HashSet<int> C = new HashSet<int>();

      Console.Write("O curso A possui quantos alunos? ");
      int count = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite os códigos dos alunos do curso A:");
      for (int i = 0; i < count; i++) {
        int codigo = int.Parse(Console.ReadLine());
        A.Add(codigo);
      }

      Console.Write("O curso B possui quantos alunos? ");
      count = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite os códigos dos alunos do curso B:");
      for (int i = 0; i < count; i++) {
        int codigo = int.Parse(Console.ReadLine());
        B.Add(codigo);
      }

      Console.Write("O curso C possui quantos alunos? ");
      count = int.Parse(Console.ReadLine());

      Console.WriteLine("Digite os códigos dos alunos do curso C:");
      for (int i = 0; i < count; i++) {
        int codigo = int.Parse(Console.ReadLine());
        C.Add(codigo);
      }

      HashSet<int> total = new HashSet<int>();
      total.UnionWith(A);
      total.UnionWith(B);
      total.UnionWith(C);

      Console.WriteLine("Total de alunos: " + total.Count);
      Console.ReadLine();
    }
  }
}
