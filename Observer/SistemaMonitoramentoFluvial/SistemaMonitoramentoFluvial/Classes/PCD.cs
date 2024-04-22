using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoFluvial.Classes
{
    //PCD = Posto de Coleta de Dados
    internal class PCD
    {
        private readonly List<IUniversidade> Universidades;

        public PCD(string nome, int temperatura, int ph, int pa)
        {
            Universidades = new List<IUniversidade>();
        }

        public List<IUniversidade> GetUniversidades()
        {
            return Universidades;
        }

        public void AddUniversidade(IUniversidade Universidade)
        {
            Universidades.Add(Universidade);
        }

        public void RemoveUniversidade(IUniversidade Universidade)
        {
            Universidades.Remove(Universidade);
        }

        public void NotifyUniversidades()
        {
            foreach (IUniversidade Universidade in Universidades)
            {
                Universidade.Update(this);
            }
        }
    }
}
