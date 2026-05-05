using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposBasicoDeDadosCSharp.Exercicio_aula_membros_estaticos;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_MembrosEstaticos : Aula
    {
        public Aula_MembrosEstaticos() : base("Membros Estáticos", "Aula sobre membros estáticos em C#")
        {
                
        }
        public override void Executar()
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantas dólares você deseja comprar?");
            double quantidadeDolar = double.Parse(Console.ReadLine());
            double valorEmReais = ConversorDeMoeda.CalcularValorEmReais(cotacao, quantidadeDolar);
            Console.WriteLine($"O valor em reais é: {valorEmReais:F2}");
        }
    }
}
