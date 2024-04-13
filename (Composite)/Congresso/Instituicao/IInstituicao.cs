using System.Collections.Generic;

namespace Congresso.Instituicao
{
    internal interface IInstituicao
    {
        List<Individuo.IIndividuo> GetMembros();
        void AddIndividuo();
        void AddInstituicao(IInstituicao instituicao);
    }
}