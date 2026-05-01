using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposBasicoDeDadosCSharp
{
    public abstract class Aula
    {
        public string titulo;
        public string descricao;

        public Aula(string titulo, string descricao)
        {
            this.titulo = titulo;
            this.descricao = descricao;
        }

        public abstract void Executar();
    }
}
