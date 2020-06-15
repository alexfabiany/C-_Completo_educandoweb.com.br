using System.Globalization;

namespace Course {
  class Produto {
    private string Nome;
    private double Preco;
    private int Quantidade;

    public Produto(string nome, double preco, int quantidade) {
      Nome = nome;
      Preco = preco;
      Quantidade = quantidade;
    }

    public void AdicionarProdutos(int quantidade) {
      Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade) {
      Quantidade -= quantidade;
    }

    public double ValorTotalEmEstoque() {
      return Preco * Quantidade;
    }

    public override string ToString() {
      return Nome
        + ", $"
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
  }
}
