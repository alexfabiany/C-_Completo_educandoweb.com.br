using System;
using System.Globalization;

namespace Course {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Informe a largura e altura do retângulo: ");
      double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Retangulo ret = new Retangulo(largura, altura);

      Console.WriteLine("AREA: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("PERÍMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
      Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

      //Console.ReadLine();
    }
  }
}
