using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congresso.Individuo
{
    internal class Individuo : IIndividuo
    {
        private long assentoId;

        public Individuo()
        {

        }

        public long GetAssento()
        {
            return 1;
        }
    }
}
