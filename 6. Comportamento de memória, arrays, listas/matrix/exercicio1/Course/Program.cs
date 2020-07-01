using System;

namespace Course {
  class Program {
    static void Main(string[] args) {

      Console.Write("Enter the matrix rows and columns count: ");
      int n = int.Parse(Console.ReadLine());

      int[,] matrix = new int[n, n];

      for (int i = 0; i < n; i++) {
        string[] values = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++) {
          matrix[i, j] = int.Parse(values[j]);
        }
      }

      Console.WriteLine("Main diagonal:");
      for (int i = 0; i < n; i++) {
        Console.Write(matrix[i, i] + " ");
      }

      Console.WriteLine();
      int count = 0;

      for (int i = 0; i < n; i++) {
        for (int j = 0; j < n; j++) {
          if(matrix[i,j] < 0) {
            count++;
          }
        }
      }
      Console.WriteLine("Negative numbers: " + count);
    }
  }
}
