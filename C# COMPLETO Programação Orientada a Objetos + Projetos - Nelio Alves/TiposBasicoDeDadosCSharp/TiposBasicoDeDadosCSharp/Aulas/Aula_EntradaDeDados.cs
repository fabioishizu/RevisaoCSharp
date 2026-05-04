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
            /*Console.WriteLine("Entre com seu nome completo:");
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
            }*/
            Exercicio3();
        }

        public void Exercicio1()
        {
            /*Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa, conforme exemplos.*/
            Console.WriteLine("Digite o primeiro número inteiro:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número inteiro:");
            int numero2 = int.Parse(Console.ReadLine());
            int resultado = numero1 + numero2;
            Console.WriteLine($"SOMA = {resultado}");
        }

        public void Exercicio2()
        {
            /*Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
            casas decimais conforme exemplos. Fórmula da área: area = π . raio2. Considere o valor de π = 3.14159*/

            Console.WriteLine("Digite o valor do raio do círculo:");    
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine($"ÁREA = {resultado.ToString("F4", CultureInfo.InvariantCulture)}");
        }

        public void Exercicio3()
        {
            /*Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
            de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).*/

            string[] valores = Console.ReadLine().Split(' ');  
            var valoresInt = Array.ConvertAll(valores, int.Parse);
            int resultado = (valoresInt[0] * valoresInt[1]) - (valoresInt[2] * valoresInt[3]);
            Console.WriteLine($"DIFERENCA = {resultado}");
        }
    }
}
