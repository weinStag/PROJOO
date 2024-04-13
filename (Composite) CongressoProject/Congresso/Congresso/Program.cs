using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congresso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instituicoes = new List<Instituicao.IInstituicao>();
            var individuos = new List<Individuo.IIndividuo>();

            // initialize a instance of 20 individuals
            for (int i = 0; i < 20; i++)
            {
                var individuo = new Individuo.Individuo();
                individuos.Add(individuo);
            }

            // initialize a instance of 5 institutions wich each one has 5 individuals
            for (int i = 0; i < 5; i++)
            {
                var instituicao = new Instituicao.Instituicao();
                for (int j = 0; j < 5; j++)
                {
                    instituicao.AddIndividuo();
                }
                instituicoes.Add(instituicao);
            }

            // add 2 institutions to the first institution
            for (int i = 0; i < 2; i++)
            {
                var instituicao = new Instituicao.Instituicao();
                for (int j = 0; j < 5; j++)
                {
                    instituicao.AddIndividuo();
                }
                instituicoes[0].AddInstituicao(instituicao);
            }

            // initialize a instance of Congresso
            var congresso = new Congresso(instituicoes, individuos);
            
            var totalParticipantes = congresso.TotalParticipantes();
            var totalAssentos = congresso.TotalAssentos();

            Console.WriteLine($"Total de participantes: {totalParticipantes}");

            Console.WriteLine($"Total de assentos: {totalAssentos}");

            // wait enter to close cmd
            Console.ReadLine();
        }
    }
}
