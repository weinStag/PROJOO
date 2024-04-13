using Congresso.Individuo;
using Congresso.Instituicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congresso
{
    internal class Congresso : ICongresso
    {
        private List<IInstituicao> instituicoes;
        private List<IIndividuo> individuos;

        public Congresso(List<IInstituicao> instituicoes, List<IIndividuo> individuos)
        {
            this.instituicoes = new List<IInstituicao>(instituicoes);
            this.individuos = new List<IIndividuo>(individuos);
        }

        public long TotalParticipantes()
        {
            var result = 0;
            instituicoes.ForEach(instituicao => result += instituicao.GetMembros().Count);
            result += individuos.Count();

            return result;
        }

        public long TotalAssentos()
        {
            long result = 0;

            instituicoes.ForEach(instituicao =>
            {
                long assentosInstituicao = 0;
                List<IIndividuo> individuosInstituicao = instituicao.GetMembros();
                individuosInstituicao.ForEach(individuo => assentosInstituicao += individuo.GetAssento());
                result += assentosInstituicao;
            });

            result += individuos.Count();

            return result;
        }
    }
}
