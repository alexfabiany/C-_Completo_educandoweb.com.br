using System;
using System.Collections.Generic;

namespace Course {
  class Program {
    static void Main(string[] args) {

      List<string> lista = new List<string>();

      lista.Add("Maria");
      lista.Add("Alex");
      lista.Add("Marcíria");
      lista.Add("Andreas");
      lista.Add("Anna");

      lista.Insert(3, "Valente");

      foreach (string nome in lista) {
        Console.WriteLine(nome);
      }

      Console.WriteLine("List count: " + lista.Count);

      string s1 = lista.Find(x => x[0] == 'A');
      Console.WriteLine("First 'A': " + s1);

      string s2 = lista.FindLast(x => x[0] == 'A');
      Console.WriteLine("Last 'A': " + s2);

      int pos1 = lista.FindIndex(x => x[0] == 'A');
      Console.WriteLine("First position 'A': " + pos1);

      int pos2 = lista.FindLastIndex(x => x[0] == 'A');
      Console.WriteLine("Last position 'A': " + pos2);

      Console.WriteLine("-----------------------------");
      List<string> filter5Words = lista.FindAll(x => x.Length >= 5);
      foreach (string nome in filter5Words) {
        Console.WriteLine(nome);
      }

      lista.RemoveRange(2, 2); // RemoveAt(3); // Remove("Anna");
      Console.WriteLine("-----------------------------");
      foreach (string nome in lista) {
        Console.WriteLine(nome);
      }

      lista.RemoveAll(x => x[0] == 'M');
      Console.WriteLine("-----------------------------");
      foreach (string nome in lista) {
        Console.WriteLine(nome);
      }

    }
  }
}
