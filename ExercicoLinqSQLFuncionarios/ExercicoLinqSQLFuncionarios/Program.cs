using System;
using System.Linq;
using System.Globalization;
using System.Collections.Generic;
using ExercicoLinqSQLFuncionarios.Entidades;

namespace ExercicoLinqSQLFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho  do arquivo: ");        
            Arquivo arquivo = new Arquivo(@Console.ReadLine());
            //Arquivo arquivo = new Arquivo(@"D:\documentos\projetoDesenvolvimento\C#\Ws-Vs2019\ExercicoLinqSQLFuncionarios\ExercicoLinqSQLFuncionarios\Arquivo.csv");

            Console.Write("Entre com o salario: ");
            double filtroSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Funcionario> funcionario = new List<Funcionario>();

            foreach (string s in arquivo.Texto)
            {
                string[] valores = s.Split(";");

                funcionario.Add(new Funcionario(valores[0], valores[1],double.Parse(valores[2], CultureInfo.InvariantCulture)));
            }

            Console.WriteLine($"Email das pessoas que recebem mais de {filtroSalario.ToString("F2",CultureInfo.InvariantCulture)}: ");

            var email = (from p in funcionario where p.Salario >= filtroSalario orderby p.Email select p.Email);

            foreach (string s in email)
            {
                Console.WriteLine($"{s}");
            }
            
            var soma = (from p in funcionario where p.Nome[0] == 'M' select p.Salario).Sum();

            Console.Write("Soma dos salaros das pessoas com o nome iniciado em \"M\": " + soma.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
