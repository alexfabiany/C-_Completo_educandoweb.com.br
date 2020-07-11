using System;

namespace Course {
  class Program {
    static void Main(string[] args) {
      Console.Write("Enter the matrix rows and columns count: ");
      string[] numbers = Console.ReadLine().Split(' ');
      int m = int.Parse(numbers[0]);
      int n = int.Parse(numbers[1]);

      int[,] matrix = new int[m, n];

      for (int i = 0; i < m; i++) {
        string[] values = Console.ReadLine().Split(' ');
        for (int j = 0; j < n; j++) {
          matrix[i, j] = int.Parse(values[j]);
        }
      }

      Console.Write("Enter a number to find: ");
      int number = int.Parse(Console.ReadLine());

      for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
          if (matrix[i, j] == number) {
            Console.WriteLine("Position " + i + ", " + j + ":");
            if (j > 0) {
              Console.WriteLine("Left: " + matrix[i, j - 1]);
            }
            if (i > 0) {
              Console.WriteLine("Up: " + matrix[i - 1, j]);
            }
            if (j < n - 1) {
              Console.WriteLine("Right: " + matrix[i, j + 1]);
            }
            if (i < m - 1) {
              Console.WriteLine("Down: " + matrix[i + 1, j]);
            }
          }
        }
      }
    }
  }
}
