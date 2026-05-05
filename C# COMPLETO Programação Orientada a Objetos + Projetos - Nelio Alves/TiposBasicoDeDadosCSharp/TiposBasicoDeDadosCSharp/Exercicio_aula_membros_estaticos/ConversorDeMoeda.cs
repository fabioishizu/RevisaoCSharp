using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposBasicoDeDadosCSharp.Exercicio_aula_membros_estaticos
{
    public static class ConversorDeMoeda
    {
        private static double IofTaxa = 0.06;
        public static double CalcularValorEmReais(double cotacao, double quantidadeDolar)
        {
            var valorConversaoBruto = (cotacao * quantidadeDolar);
            var valorIof = valorConversaoBruto * IofTaxa;
            var total = valorConversaoBruto + valorIof;
            return total;
        }
    }
}
