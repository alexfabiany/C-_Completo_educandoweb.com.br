using System.Globalization;

namespace Course {
  class ContaBancaria {
    private const double _taxasobresaque = 5.00;
    public int Numero { get; private set; }
    public string Titular { get; set; }
    public double Saldo { get; private set; }


    public ContaBancaria(int conta, string nome) {
      Numero = conta;
      Titular = nome;
    }

    public ContaBancaria(int conta, string nome, double valorInicial) : this(conta, nome) {
      Depositar(valorInicial);
    }

    public bool Depositar(double valor) {
      if (valor > 0) {
        Saldo += valor;
        return true;
      } else return false;
    }

    public bool Sacar(double valor) {
      if(valor > 0) {
        Saldo -= valor + _taxasobresaque;
        return true;
      } else return false;
    }
    
    public override string ToString() {
      return "Número.: "
        + Numero
        + ", Titular: "
        + Titular
        + ", Saldo: $"
        + Saldo.ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}
