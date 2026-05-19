using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposBasicoDeDadosCSharp.Aulas.Struct;

namespace TiposBasicoDeDadosCSharp.Aulas
{
    public class Aula_TipoReferenciaEValor : Aula
    {
        public Aula_TipoReferenciaEValor() : base("Tipos de Referência e Valor", "Tipos de referência e valor")
        {
                
        }

        public override void Executar()
        {
            Ponto p;
            p.x = 10;
            p.y = 20;
            Console.WriteLine(p);

            p = new Ponto();
            Console.WriteLine(p);
        }
    }
}
