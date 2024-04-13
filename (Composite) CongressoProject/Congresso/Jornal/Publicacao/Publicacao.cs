using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornal.Publicacao
{
    internal class Publicacao
    {
        private string titulo;
        private Publicacao publicacaoInner;
        private Artigo.Artigo artigo;

        public Publicacao(string titulo, Publicacao publicacaoInner, Artigo.Artigo artigo)
        {
            this.titulo = titulo;
            this.publicacaoInner = publicacaoInner;
            this.artigo = artigo;
        }

        public void printInfos(int level)
        {
            printLevels(level);
            Console.WriteLine("Titulo: " + titulo);
            if(artigo != null)
            {
                printLevels(level);
                Console.WriteLine("Artigo: " + artigo.PrintInfos());
            }
            if(publicacaoInner != null)
            {
                publicacaoInner.printInfos(++level);
            }
        }

        private void printLevels(int level)
        {
            for(int i = 0; i < level; i++)
            {
                Console.Write("    ");
            }
        }
    }
}
