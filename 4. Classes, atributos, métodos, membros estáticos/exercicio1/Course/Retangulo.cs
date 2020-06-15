using System;

namespace Course {
  class Retangulo {
    private double Largura;
    private double Altura;

    public Retangulo(double largura, double altura) {
      Largura = largura;
      Altura = altura;
    }

    public double Area() {
      return Largura * Altura;
    }

    public double Perimetro() {
      return 2 * ( Largura + Altura );
    }

    public double Diagonal() {
      return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
    }
  }
}
