using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jornal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // revista
            Artigo.Artigo artigoRevista = new Artigo.Artigo("Artigo Revista", new List<string> { "Autor 1", "Autor 2" });
            Publicacao.Publicacao revista = new Publicacao.Publicacao("Revista", null, artigoRevista);

            // caderno
            Artigo.Artigo artigoCaderno = new Artigo.Artigo("Artigo Caderno", new List<string> { "Autor 3", "Autor 4" });
            Publicacao.Publicacao caderno = new Publicacao.Publicacao("Caderno", revista, artigoCaderno);

            // jornal
            Artigo.Artigo artigoJornal = new Artigo.Artigo("Artigo Jornal", new List<string> { "Autor 5", "Autor 6" });
            Publicacao.Publicacao jornal = new Publicacao.Publicacao("Jornal", caderno, artigoJornal);

            // print publicacoes hierarchy

            jornal.printInfos(0);

            Console.ReadKey();
        }
    }
}
