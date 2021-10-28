using System;
using System.Globalization;
using ProcessamentoDeContratos.Entidades;
using ProcessamentoDeContratos.Servicos;
using ProcessamentoDeContratos.Servicos.Interfaces;

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
            IServicosPagamento paypal = new ServicoPaypal();

            Console.WriteLine("");

            Console.Write("Meses parcelamento: ");
            int numMeses = int.Parse(Console.ReadLine());

            double vlrParcela = 0;
            double vlrBase = (contrato.ValorContrato / numMeses);

            for (int i = 1; i <= numMeses; i++)
            {
                vlrParcela = vlrBase;

                vlrParcela += paypal.CalculaJuros(vlrBase, i);
                vlrParcela += paypal.CalculaTaxaPag(vlrParcela);

                contrato.AddParcela(new Parcela(contrato.DataContrato.AddMonths(i), vlrParcela));
            }

            Console.WriteLine("Parcelas:");
            Console.WriteLine(contrato.ToString());

        }
    }
}
