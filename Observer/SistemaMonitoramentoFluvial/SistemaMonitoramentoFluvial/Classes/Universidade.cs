using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoFluvial.Classes
{
    internal class Universidade : IUniversidade
    {
        private readonly string Nome;

        public Universidade(string nome)
        {
            Nome = nome;
        }

        public void Update(PCD pcd)
        {
            Console.WriteLine("Universidade " + Nome + " foi notificada.");
        }
    }
}
