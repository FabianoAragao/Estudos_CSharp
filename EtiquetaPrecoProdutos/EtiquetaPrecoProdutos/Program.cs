using System;
using EtiquetaPrecoProdutos.Entidades;
using System.Collections.Generic;
using System.Globalization;

namespace EtiquetaPrecoProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> dadosProduto = new List<Produto>();

            Console.Write("Numero de produtos:");
            double numProdutos = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 1; i <= numProdutos; i++)
            {
                Console.WriteLine($"Dados do produto #{i}");

                Console.Write("Comum, usado ou importado (c/u/i)? ");
                char tipoProduto = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if ((tipoProduto == 'u') || (tipoProduto == 'U'))
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime dtFabProduo = DateTime.Parse(Console.ReadLine());

                    dadosProduto.Add(new ProdutoUsado(nomeProduto, precoProduto, dtFabProduo));
                }
                else if ((tipoProduto == 'i') || (tipoProduto == 'I'))
                {
                    Console.Write("Taxa alfandegaria: ");
                    double  taxaProduo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                    dadosProduto.Add(new ProdutoImportado(nomeProduto, precoProduto, taxaProduo));
                }
                else
                {
                    dadosProduto.Add(new Produto(nomeProduto, precoProduto));
                }
            }

            Console.WriteLine("ETIQUETAS DE PREÇO ");

            foreach (Produto prod in dadosProduto)
            {
                Console.WriteLine(prod.EtquetaDePreco());
            }
        }
    }
}
