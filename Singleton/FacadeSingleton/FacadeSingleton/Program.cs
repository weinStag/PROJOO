using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingleton.Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Facade f1, f2, f3;
            f1 = Facade.obterInsancia();
            f2 = Facade.obterInsancia();
            f3 = Facade.obterInsancia();
            
            if(System.Object.ReferenceEquals(f1, f2) && System.Object.ReferenceEquals(f2, f3))
            {
                Console.WriteLine("Todas as referencias são iguais!");
            }
            else
            {
                Console.WriteLine("Referencias são diferentes");
            }

            Console.ReadLine();
        }
    }
}
