using System;
using System.Collections.Generic;
using ConjuntosContaEstudantesCurso.Entidades;

namespace ConjuntosContaEstudantesCurso
{
    class Program
    {
        static void Main(string[] args)
        {            
            HashSet<Curso> alunos = new HashSet<Curso>();

            for (int j = 1; j <= 3; j++)
            {
                string curso = "";
                switch (j)
                {
                    case 1:
                        curso = "A";
                        break;
                    case 2:
                        curso = "B";
                        break;

                    case 3:
                        curso = "C";
                        break;
                }

                Console.Write($"quantos estudantes tem no curso {curso}: ");
                int numEstudantes = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numEstudantes; i++)
                {
                    int aluno = int.Parse(Console.ReadLine());
                    alunos.Add(new Curso {CursoAtual = curso, CodAluno = aluno});
                }
            }

            Console.WriteLine($"Total de estudantes {alunos.Count}");
        }

    }
}
