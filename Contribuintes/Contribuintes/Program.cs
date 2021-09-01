using System;
using System.Collections.Generic;
using System.Globalization;
using Contribuintes.Entidades;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> contribuintes = new List<Pessoa>();

            Console.Write("Numero de contribuintes: ");
            int numContribuintes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numContribuintes; i++)
            {
                Console.WriteLine($"Dados do imposto #{i}:");

                Console.Write("Pessoa fisica ou juridica(f/j)? ");
                char tipoContrib = char.Parse(Console.ReadLine());

                Console.Write("Nome:  ");
                string nomeContrib = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnualContrib = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ((tipoContrib == 'f') || (tipoContrib == 'F'))
                {
                    Console.Write("Gastos com saude: ");
                    double gastosComSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    contribuintes.Add(new PessoaFisica(nomeContrib,rendaAnualContrib,gastosComSaude));
                }
                else
                {
                    Console.Write("Numero de funcionarios: ");
                    int numFuncionarios = int.Parse(Console.ReadLine());

                    contribuintes.Add(new PessoaJuridica(nomeContrib, rendaAnualContrib,numFuncionarios));
                }
            }

            Console.WriteLine("IMPOSTOS PAGOS: ");

            double totImpostos = 0.00;

            foreach (Pessoa contr in contribuintes)
            {
                Console.WriteLine(contr.Nome + ": " + contr.CalcuoImposto().ToString("F2",CultureInfo.InvariantCulture));

                totImpostos += contr.CalcuoImposto();
            }

            Console.WriteLine($"TOTAL DE IMPOSTOS: {totImpostos.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
