using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using ExercicoResolvidoLinqSQLMediaProdutos.Entidades;

namespace ExercicoResolvidoLinqSQLMediaProdutos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o caminho do arquivo: ");
            Arquivo arquivo = new Arquivo(@Console.ReadLine());

            List<Produto> produto = new List<Produto>();

            foreach (string s in arquivo.Texto)
            {
                string[] valores = s.Split(";");

                produto.Add(new Produto(valores[0], double.Parse(valores[1],CultureInfo.InvariantCulture)));
            }

            var media = (from p in produto select p.Preco).Average();
            var prodSelecionados = (from p in produto where p.Preco <= media orderby p.Nome descending select p.Nome);

            Console.WriteLine($"Media dos produtos: {media.ToString("F2", CultureInfo.InvariantCulture)}");

            foreach (string obj in prodSelecionados)
            {
                Console.WriteLine($"Produtos abaixo da media: {obj}");
            }
        }
    }
}
