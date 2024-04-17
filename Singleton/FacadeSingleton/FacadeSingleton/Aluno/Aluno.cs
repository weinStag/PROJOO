using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingleton.Facade
{
    internal class Aluno
    {
        private readonly long matricula;
        private readonly string nome;
        public Aluno(long matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;
        }
        public long GetMatricula()
        {
            return matricula;
        }
        public string GetNome()
        {
            return nome;
        }
    }
}
