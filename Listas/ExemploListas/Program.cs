using System;
using System.Collections.Generic;

namespace ExemploListas
{
    class Program
    {
        internal Funcionario Funcionario
        {
            get => default;
            set
            {
            }
        }

        static void Main(string[] args)
        {
            int idFunc;
            List<Funcionario> cadFuncionario = new List<Funcionario>();

            Console.WriteLine("Digite o numero de funconarios a cadastrar");
            int numeroDeFuncionarios = int.Parse(Console.ReadLine());

            for (int i = 0; i < numeroDeFuncionarios; i++)
            {
                Console.WriteLine("Digite o id do funcinario");
                idFunc = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite o nome do funcinario");
                string NomeFunc = Console.ReadLine();
                
                Console.WriteLine("Digite o salario do funcinario");
                double salarioFunc = double.Parse(Console.ReadLine());

                cadFuncionario.Add(new Funcionario(idFunc, NomeFunc, salarioFunc));
            }

            Console.WriteLine("Digite o ID do funcionario que recebera o aumento");
            int numFunc = int.Parse(Console.ReadLine());

            Funcionario FuncAt = cadFuncionario.Find(x => x.idFuncionario == numFunc);

            if (FuncAt != null)
            {
                Console.WriteLine("Digite a porcentagem de aumento");
                double porcAumento = int.Parse(Console.ReadLine());
                FuncAt.AumentaSalario(porcAumento);
            }
            else
            {
                Console.WriteLine("O funcinario não existe.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios:");

            foreach (Funcionario func in cadFuncionario)
            {
                Console.WriteLine(func);
            }
        }
    }
}
