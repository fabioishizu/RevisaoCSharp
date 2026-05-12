using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_ExercicioFixacao5 : Aula
    {
        public int MyProperty { get; set; }
        public Aula_ExercicioFixacao5() : base("Exercício de Fixação 5", "Exercício de fixação 5")
        {
                
        }

        public override void Executar()
        {
            Console.WriteLine("Insira o número da conta:");
            var conta = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o nome do titular:");
            var titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial? (s/n)");
            var temDeposito = Console.ReadLine();
            Console.WriteLine("Insira o saldo inicial:");
            var saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            var contaBancaria = new Conta(conta, titular, saldo);
            Console.WriteLine(contaBancaria.ToString());

            if (temDeposito.ToLower() != "s")
            {
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Entre com um valor para depósito:");
            var valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Depositar(valor);
            Console.WriteLine(contaBancaria.ToString());

            Console.WriteLine("Entre com um valor para saque:");
            var valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(valorSaque);
            Console.WriteLine(contaBancaria.ToString());
        }
    }

    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public double Sacar(double valor)
        {
            Saldo -= valor + 5.0;
            return Saldo;
        }

        public override string ToString()
        {
            return $"Dados da conta: \n {Numero}, Titular: {Titular}," +
                $" Saldo: $ {Saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}";
        }
    }
}
