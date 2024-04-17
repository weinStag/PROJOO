using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSingleton.Facade
{
    internal class Facade
    {
        private Facade() { }
        private static Facade instancia;
        public static Facade obterInsancia()
        {
            if(instancia == null)
            {
                instancia = new Facade();
            }
            return instancia;
        }
        public void Matricular(long codigoAluno, long codigoCurso, Turma turma)
        {
            if (turma == null)
            {
                turma = new Turma();
                Curso c = Escola.GetCurso(codigoCurso);
                turma.SetCurso(c);
            }
            Aluno rex = Escola.GetAluno(codigoAluno);
            turma.AddAluno(rex);
        }
        public void exibirStatus(Turma turma)
        {
            Console.WriteLine(turma.GetCurso().GetNome());
            List<Aluno> alunos = turma.GetAlunos();
            for(int i = 0; i < alunos.Count; i++)
            {
                Console.WriteLine(alunos[i]);
            }
        }
    }
}
