using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_ConversoesImplicitasExplicitas : Aula
    {
        public Aula_ConversoesImplicitasExplicitas() : base("Conversões Implícitas e Explícitas", "Aula sobre conversões de tipos em C#")
        {
        }

        public override void Executar()
        {
            double a;
            int b;

            a = 5.1;
            //b = a;Conversão implícita de double para int (pode causar perda de dados)
            b = (int)a;
            Console.WriteLine(b);

            int x = 5;
            int y = 2;

            //tanto x e y são inteiros, então a divisão deles também será um inteiro, e o resultado será 2
            double z = x / y;

            Console.WriteLine(z);

            //Agora com a conversão explícita de x para double, o resultado será 2.5
            double resultado = (double) x / y; 
            Console.WriteLine(resultado);
        }
    }
}
