using System;
using System.Globalization;
using System.Text;

namespace Course {
  class Aluno {
    private string Nome;
    private double Nota1, Nota2, Nota3;
    private const double NotaMinima = 70.0;

    public Aluno(string nome, double nota1, double nota2, double nota3) {
      Nome = nome;
      Nota1 = nota1;
      Nota2 = nota2;
      Nota3 = nota3;
    }

    public double NotaFinal() {
      return Nota1 + Nota2 + Nota3;
    }

    public bool Aprovado() {
      return NotaFinal() >= NotaMinima;
    }

    public double NotaRestante() {
      return Aprovado() ? 0.0 : NotaMinima - NotaFinal();
    }

    public override string ToString() {
      string resultado = "NOTA FINAL: " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);

      if (Aprovado()) {
       resultado += " << APROVADO >> :)";
      }
      else {
        resultado += " *** REPROVADO *** :("
          + "\n=> FALTARAM " + NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS!";
      }

      return resultado;
    }
  }
}
