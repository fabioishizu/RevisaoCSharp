using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_EntradaDeDados : Aula
    {
        public Aula_EntradaDeDados() : base("Entrada de Dados", "Aula sobre entrada de dados em C#")
        {
                
        }

        public override void Executar()
        {
            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Quantos quartos team na sua casa?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto:");
            double precoProduto = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vetor = Console.ReadLine().Split(' ');

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(precoProduto.ToString("F2"), CultureInfo.InvariantCulture);

            foreach (var item in vetor)
            {
                Console.WriteLine(item);
            }
        }
    }
}
