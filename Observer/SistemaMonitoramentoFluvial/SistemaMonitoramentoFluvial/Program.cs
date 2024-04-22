using SistemaMonitoramentoFluvial.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMonitoramentoFluvial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PCDData pcd1 = new PCDData("PCD1", 25, 7, 1013);
            PCDData pcd2 = new PCDData("PCD2", 26, 6, 1014);
            PCDData pcd3 = new PCDData("PCD3", 27, 5, 1015);

            pcd1.AddUniversidade(new Universidade("UNIFESP"));
            pcd1.AddUniversidade(new Universidade("USP"));
            pcd2.AddUniversidade(new Universidade("UNICAMP"));
            pcd3.AddUniversidade(new Universidade("UNESP"));

            Console.WriteLine("PCD1 Alterou a temperatura para 30.");
            pcd1.SetTemperatura(30);

            Console.WriteLine("PCD2 Alterou o PH para 6.");
            pcd2.SetPH(6);

            Console.WriteLine("PCD3 Alterou a pressão atmosférica para 1015.");
            pcd3.SetPA(1015);

            Console.ReadKey();
        }
    }
}
