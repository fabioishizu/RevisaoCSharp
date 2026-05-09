using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aulas;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_Encapsulamento : Aula
    {
        public Aula_Encapsulamento() : base("Aula_Encapsulamento", "Encapsulamento")
        {
        }

        public override void Executar()
        {
            Produto p = new Produto("Tv", 900.00, 10);

            p.SetNome("TV 60 Polegadas");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            Console.WriteLine(p.GetQuantidade());
        }
    }
}
