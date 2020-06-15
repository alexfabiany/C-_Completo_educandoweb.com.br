using System.Globalization;

namespace Course {
  class Produto {
    private string Nome;
    private double Preco;
    private int Quantidade;

    public Produto(string nome, double preco, int quantidade) {
      Nome = nome;
<<<<<<< HEAD
      Preco = preco;
      Quantidade = quantidade;
=======
      this.Preco = preco;
      this.Quantidade = quantidade;
>>>>>>> f7bbca3f02fc8f9509bb49fe3639c381e3d6c654
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
