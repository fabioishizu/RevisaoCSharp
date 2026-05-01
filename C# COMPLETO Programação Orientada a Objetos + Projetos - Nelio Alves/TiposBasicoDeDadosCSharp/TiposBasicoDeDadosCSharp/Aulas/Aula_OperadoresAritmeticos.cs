using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_OperadoresAritmeticos : Aula
    {
        public Aula_OperadoresAritmeticos() :base("Operadores Aritméticos", "Aula sobre os operadores aritméticos em C#")
        {
             
        }

        public override void Executar()
        {
            //Operadores Aritméticos
            //+ realiza adição - realiza subtração * realiza multiplicação / realiza divisão % realiza módulo

            //O resultado será 20, pois a multiplicação tem precedência sobre a adição
            var resultado = 10 + 5 * 2;
            Console.WriteLine(resultado);

            //O resultado será 30, pois a adição está entre parênteses e será realizada primeiro
            resultado = (10 + 5) * 2; 
            Console.WriteLine(resultado);

            //O resultado será 1, pois o operador % retorna o resto da divisão
            resultado = 10 % 3; 
            Console.WriteLine(resultado);

            //O resultado será 3, pois a divisão de dois números inteiros retorna um número inteiro
            double resultadoDivisao1 = 10 / 3; 
            Console.WriteLine(resultadoDivisao1);

            //O resultado será 3.3333333333333335, pois a divisão de dois números double retorna um número double
            double resultadoDivisao2 = 10.0 / 3.0; 
            Console.WriteLine(resultadoDivisao2);

            //O resultado será 3.3333333333333335, pois a divisão de dois números double retorna um número double
            double resultadoDivisao3 = (double) 10 / 3;
            Console.WriteLine(resultadoDivisao3);

            //Fórmula de bhaskara
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double calculoFormula = (-b + Math.Sqrt(delta)) / (2.0 * a);
            Console.WriteLine(calculoFormula);
            Console.WriteLine(delta);
        }
    }
}
