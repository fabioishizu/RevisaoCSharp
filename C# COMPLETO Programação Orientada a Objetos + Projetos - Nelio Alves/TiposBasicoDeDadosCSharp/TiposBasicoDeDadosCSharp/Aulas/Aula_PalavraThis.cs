using Aulas;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_PalavraThis : Aula
    {
        public Aula_PalavraThis() : base("Aula_PalavraThis", "Palavra this")
        {
            
        }
        public override void Executar()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            var nome = Console.ReadLine();
            Console.Write("Preço: ");
            var preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }

    
}
