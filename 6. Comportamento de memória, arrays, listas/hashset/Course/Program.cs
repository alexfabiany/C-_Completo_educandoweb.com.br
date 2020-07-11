using System;
using System.Collections.Generic;

namespace Course {
  class Program {
    static void Main(string[] args) {

      HashSet<int> A = new HashSet<int>();
      HashSet<int> B = new HashSet<int>();
      HashSet<int> C = new HashSet<int>();

      A.Add(3);
      A.Add(5);
      A.Add(8);
      A.Add(9);

      B.Add(3);
      B.Add(4);
      B.Add(5);

       A.UnionWith(B);
      //A.IntersectWith(B);
      // A.ExceptWith(B);

      foreach (int i in A) {
        Console.WriteLine(i);
      }
    }
  }
}
