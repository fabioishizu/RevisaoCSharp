using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_TiposVariaveis : Aula
    {
        string produto1 = "Computador";
        string produto2 = "Mesa de escritório";

        byte idade = 30;
        int codigo = 5290;
        char genero = 'M';

        double preco1 = 2100.0;
        double preco2 = 650.50;
        double medida = 53.234567;


        public Aula_TiposVariaveis() : base("Tipos de Variáveis", "Aula sobre os diferentes tipos de variáveis em C#")
        {
            
        }

        public override void Executar()
        {
            Console.WriteLine("{0}, cujo o preço é $ {1:F2}", produto1, preco1);
            Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arredondado (três casas decimais): {0:F3}", medida);
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}", medida);
        }
    }
}
