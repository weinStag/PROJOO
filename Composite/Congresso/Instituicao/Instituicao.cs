using Congresso.Individuo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congresso.Instituicao
{
    internal class Instituicao : IInstituicao
    {
        private List<IIndividuo> individuos;
        private List<IInstituicao> instituicoes;
        public Instituicao()
        {
            individuos = new List<IIndividuo>();
            instituicoes = new List<IInstituicao>();
        }

        public List<Individuo.IIndividuo> GetMembros()
        {
            List<Individuo.IIndividuo> result = new List<IIndividuo>();
            result.AddRange(individuos);
            //add to result all members of each institution
            instituicoes.ForEach(instituicao => {
                List<Individuo.IIndividuo> individuosDaInstituicao = instituicao.GetMembros();
                result.AddRange(individuosDaInstituicao);
            });
            return result;
        }

        public void AddIndividuo()
        {
            var individuo = new Individuo.Individuo();
            individuos.Add(individuo);
        }

        public void AddInstituicao(IInstituicao instituicao)
        {
            instituicoes.Add(instituicao);
        }
    }
}
