using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornal.Artigo
{
    internal class Artigo
    {
        private string nome;
        private List<String> autores;

        public Artigo(string nome, List<String> autores)
        {
            this.nome = nome;
            this.autores = autores;
        }

        public string PrintInfos()
        {
            return this.nome + " / Autores: " + string.Join(", ", this.autores);
        }
    }
}
