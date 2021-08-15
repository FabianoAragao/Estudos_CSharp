using System;
using ContratosTrabalho.Entidades;

namespace ContratosTrabalho
{
    class Trabalhador
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            Departamento departamento = new Departamento(Console.ReadLine());


        }
    }
}
