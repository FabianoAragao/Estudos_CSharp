using System;
using System.Globalization;
using ProcessamentoDeContratos.Entidades;
using ProcessamentoDeContratos.Servicos;

namespace ProcessamentoDeContratos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do contrato: ");

            Console.Write("Numero: ");
            int numContrato = int.Parse(Console.ReadLine());
            Console.Write("Data: ");
            DateTime dtContrato = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Valor: ");
            double valorContrato = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Contrato contrato = new Contrato(numContrato, dtContrato, valorContrato);

            Console.WriteLine("");

            Console.Write("Meses parcelamento: ");
            int numMeses = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numMeses; i++)
            {
                contrato.AddParcela(new Parcela(contrato.DataContrato.AddMonths(i),contrato.ValorContrato));
            }

            Console.WriteLine("Parcelas:");
            Console.WriteLine(contrato.ToString());

        }
    }
}
