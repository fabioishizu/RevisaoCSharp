using System.Globalization;

namespace Aulas
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string _nome, double _preco, int _quantidade)
        {
            Nome = _nome;
            Preco = _preco;
            Quantidade = _quantidade;
        }

        public Produto(string _nome, double _preco)
        {
            Nome = _nome;
            Preco = _preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}