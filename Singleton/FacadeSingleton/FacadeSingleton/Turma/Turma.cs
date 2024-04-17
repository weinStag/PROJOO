using FacadeSingleton.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingleton.Facade
{
    internal class Turma
    {
        private readonly List<Aluno> alunos = new List<Aluno>();
        private Curso curso;
        public void SetCurso(Curso curso)
        {
            this.curso = curso;
        }
        public Curso GetCurso()
        {
            return curso;
        }
        public void AddAluno(Aluno aluno)
        {
            alunos.Add(aluno);
        }
        public List<Aluno> GetAlunos()
        {
            return alunos;
        }
    }
}
