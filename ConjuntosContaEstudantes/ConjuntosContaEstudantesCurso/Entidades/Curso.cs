using System;

namespace ConjuntosContaEstudantesCurso.Entidades
{
    class Curso
    {
        public string CursoAtual { get; set; }
        public int CodAluno { get; set; }

        public override int GetHashCode()
        {
            return CodAluno.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Curso))
            {
                return false;
            }

            Curso other = obj as Curso;

            return CodAluno.Equals(other.CodAluno);
        }
    }
}
