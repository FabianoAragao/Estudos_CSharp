using System;
using System.Collections.Generic;
using System.Globalization;
using Funcionario.Entidades;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero de funcionarios: ");
            int numFunc = int.Parse(Console.ReadLine());

            List<Funcionarios> cadFunc = new List<Funcionarios>();

            for (int i = 1; i <= numFunc; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Funcionario #{i}");

                Console.Write("Terceirizado(Y/N)? ");
                char funcTerceirizado = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string funcNome = Console.ReadLine();

                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                double valorAdicional;

                if ((funcTerceirizado == 'y') || (funcTerceirizado == 'Y'))
                {
                    Console.Write("Valor adicional: ");
                    valorAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    cadFunc.Add(new FuncionariosTerceirizados(funcNome, horas, valor, valorAdicional));
                }
                else
                {
                    cadFunc.Add(new Funcionarios(funcNome, horas, valor));
                }                
            }

            foreach (Funcionarios NovoFunc in cadFunc)
            {
                Console.WriteLine(NovoFunc.ToString());
            }
        }
    }
}
