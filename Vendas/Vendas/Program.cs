using Vendas.Entidades;
using Vendas.Entidades.Enums;
using System;
using System.Globalization;

namespace Vendas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Data de nascimento(DD/MM/YYYY): ");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do Pedido:");

            Console.Write("Status: ");
            PedidoStatus status = new PedidoStatus();
            status = Enum.Parse<PedidoStatus>(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Quantos itens para esse pedido? ");
            int numItens = int.Parse(Console.ReadLine());

            //cria o pedido
            Pedido novoPedido = new Pedido(status);
            // adiciona o cliente ao pedido
            novoPedido.ClienteVenda = new Cliente(nome, email, nascimento);

            for (int i = 1; i <= numItens; i++)
            {
                Console.WriteLine($"Entre com os dados do #{i} pedido:");

                Console.Write("Nome do produto: ");
                string nomeProduto = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double precoDoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Quantidade do produto: ");
                double quantidadeDoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto novoProduto = new Produto(nomeProduto,precoDoProduto);

                PedidoItem novoItem = new PedidoItem(quantidadeDoProduto, precoDoProduto, novoProduto);
                novoPedido.AddItemVenda(novoItem);
            }

            Console.WriteLine(novoPedido.ToString());
        }
    }
}
