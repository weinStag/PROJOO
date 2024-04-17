namespace FacadeSingleton.Facade
{
    internal class Curso
    {
        private readonly long codigoCurso;
        private readonly string nome;
        public Curso(long codigoCurso, string nome)
        {
            this.codigoCurso = codigoCurso;
            this.nome = nome;
        }
        public long GetCodigoCurso()
        {
            return codigoCurso;
        }
        public string GetNome()
        {
            return nome;
        }
    }
}