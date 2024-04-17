using FacadeSingleton.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingleton.Facade
{
    internal class Escola
    {
        private static readonly List<Turma> turmas = new List<Turma>();
        public void addTurma(Turma turma)
        {
            turmas.Add(turma);
        }
        public static Curso GetCurso(long codigoCurso)
        {
            List<Curso> cursos = new List<Curso>();
            foreach (Turma turma in turmas)
            {
                cursos.Add(turma.GetCurso());
            }
            return cursos.FirstOrDefault(c => c.GetCodigoCurso() == codigoCurso);
        }
        public static Aluno GetAluno(long codigoAluno)
        {
            List<Aluno> alunos = new List<Aluno>();
            foreach (Turma turma in turmas)
            {
                foreach (Aluno aluno in turma.GetAlunos())
                {
                    alunos.Add(aluno);
                }
            }
            return alunos.FirstOrDefault(a => a.GetMatricula() == codigoAluno);
        }
    }
}
