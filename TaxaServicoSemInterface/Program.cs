using System;
using System.Globalization;
using TaxaServico.Entidades;
using TaxaServico.Servicos;

namespace TaxaServico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados de aluguel: ");
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data de inicio(dd/MM/yyyy hh:mm): ");
            DateTime inicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",CultureInfo.InvariantCulture);
            Console.Write("Data de inicio(dd/MM/yyyy hh:mm): ");
            DateTime fim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Entre com o preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Aluguel aluguel = new Aluguel(inicio,fim, new Veiculo(modelo));
            ServicoDeAluguel servicoDeAluguel = new ServicoDeAluguel(precoHora, precoDia);

            servicoDeAluguel.ProcessarFatura(aluguel);


            Console.WriteLine("FATURA: ");
            Console.WriteLine(aluguel.Fatura);
        }       
    }
}
