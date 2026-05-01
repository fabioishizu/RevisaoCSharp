using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_OperadoresAtribuicao : Aula
    {
        int a = 10;
        public Aula_OperadoresAtribuicao() : base("Operadores de Atribuição", "Aula sobre os operadores de atribuição em C#")
        {
        }
        public override void Executar()
        {
            Console.WriteLine(a += 2);
            Console.WriteLine(a *= 2);
            Console.WriteLine(a -= 2);
            Console.WriteLine(a /= 2);
            Console.WriteLine(a %= 2);

            //no a++ ele atribui o valor de a e depois incrementa
            //já no ++a ele incrementa o valor de a e depois atribui
            Console.WriteLine(a++);
            Console.WriteLine(++a);
        }
    }
}
