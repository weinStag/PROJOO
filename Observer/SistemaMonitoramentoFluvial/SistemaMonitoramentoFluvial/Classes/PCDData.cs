using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoFluvial.Classes
{
    internal class PCDData : PCD
    {
        private string Nome { get; set; }
        private int Temperatura { get; set; }
        private int PH { get; set; }
        private int PA { get; set; }
        public PCDData(string nome, int temperatura, int ph, int pa) : base(nome, temperatura, ph, pa)
        {
            Nome = nome;
            Temperatura = temperatura;
            PH = ph;
            PA = pa;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
            NotifyUniversidades();
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetTemperatura(int temperatura)
        {
            Temperatura = temperatura;
            NotifyUniversidades();
        }

        public int GetTemperatura()
        {
            return Temperatura;
        }

        public void SetPH(int ph)
        {
            PH = ph;
            NotifyUniversidades();
        }

        public int GetPH()
        {
            return PH;
        }

        public void SetPA(int pa)
        {
            PA = pa;
            NotifyUniversidades();
        }

        public int GetPA()
        {
            return PA;
        }
    }
}
