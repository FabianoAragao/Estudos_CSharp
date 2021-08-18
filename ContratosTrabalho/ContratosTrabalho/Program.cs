using System;
using ContratosTrabalho.Entidades;
using ContratosTrabalho.Entidades.Enums;
using System.Globalization;

namespace ContratosTrabalho
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do departamento: ");
            string nomedep = Console.ReadLine();

            Console.WriteLine("Entre com o s dados do trabalhador:");
            Console.Write("Nome:");
            string nome = Console.ReadLine();
            
            Console.Write("Nivel(Junior,Pleno,Senior):");
            NivelDoTrabalhador nivel = Enum.Parse<NivelDoTrabalhador>(Console.ReadLine());

            Console.Write("Salario base:");
            double salarioBase = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Cria o objeto departamento
            Departamento departamento = new Departamento(nomedep);

            //AO INSTANCIAR O RABALHADOR O CONSTRUTOR PREENCHE OS DADOS DELE
            Trabalhador trab = new Trabalhador(nome, nivel, salarioBase, departamento);

            //pega o numero de contratos do trabalhador
            Console.Write("Quantos contratos tem esse trabalhador?");
            int numContratos = int.Parse(Console.ReadLine());

            ContratosPorHora contratos;

            //pega os dados dos contratos do trabalhador
            for (int i = 0; i < numContratos; i++)
            {
                Console.WriteLine("");
                Console.Write($"Entre com os dados do contrato #{i + 1}");
                Console.WriteLine("");

                Console.Write("Data(DD/MM/YYYY):");
                DateTime dtContrato = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora:");
                double vlrPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração(horas):");
                int hrContrato = int.Parse(Console.ReadLine());

                contratos = new ContratosPorHora(dtContrato, vlrPorHora, hrContrato);

                trab.addContrato(contratos);
            }

            Console.WriteLine("");

            //pega o mes em que sera calculado o salario
            Console.Write("Entre com o mes e ano para calcular o salario(MM/YYYY)");
            string dataSalario = Console.ReadLine();

            int mes = int.Parse(dataSalario.Substring(0, 2));

            int ano = int.Parse(dataSalario.Substring(3, 4));

            Console.WriteLine($"Nome: {trab.Nome}");
            Console.WriteLine($"Departamento:  {trab.Departamento.Nome}");
            Console.WriteLine($"Salario para {dataSalario}:  {trab.renda(mes,ano)}");
        }
    }
}
