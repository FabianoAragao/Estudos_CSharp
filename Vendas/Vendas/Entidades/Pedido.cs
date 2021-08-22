using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System;
using Vendas.Entidades.Enums;

namespace Vendas.Entidades
{
    class Pedido
    {
        public DateTime Monento { get; set; } = DateTime.Now;
        public PedidoStatus Status { get; set; }
        public Cliente ClienteVenda { get; set; }
        public List<PedidoItem> IntensVenda { get; set; } = new List<PedidoItem>();

        public Pedido()
        {
        }

        public Pedido(PedidoStatus status)
        {
            Status = status;
        }

        public void AddItemVenda(PedidoItem NovoItem)
        {
            this.IntensVenda.Add(NovoItem);
        }

        public void RemoveItemVenda(PedidoItem RemoverItem)
        {
            this.IntensVenda.Remove(RemoverItem);
        }

        public double total()
        {
            double total = 0;

            foreach (PedidoItem pedido in this.IntensVenda)
            {
                total += pedido.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            double precoTotal = 0.00;

            StringBuilder retorno = new StringBuilder("");

            retorno.AppendLine("");

            retorno.AppendLine("Sumario da venda:");
            retorno.AppendLine($"Momento da venda: {this.Monento}");
            retorno.AppendLine($"Status da venda: {Status.ToString()}");

            retorno.Append($"Cliente: {ClienteVenda.Nome}");
            retorno.Append($"({ClienteVenda.DataDeNascimeto.ToString("MM/dd/yyyy")})");
            retorno.Append($" - {ClienteVenda.Email}");

            retorno.AppendLine("");

            retorno.AppendLine($"Itens da venda");

            foreach (PedidoItem Item in IntensVenda)
            {
                double subTotal = Item.SubTotal();

                retorno.Append($"{Item.ProdutoVenda.Nome}, ");
                retorno.Append($"${Item.Preco.ToString(CultureInfo.InvariantCulture)}, ");
                retorno.Append($"Quantidade: {Item.Quantidade.ToString(CultureInfo.InvariantCulture)}, ");
                retorno.Append($"Subtotal: {subTotal.ToString(CultureInfo.InvariantCulture)}");

                retorno.AppendLine("");

                precoTotal += subTotal;
            }

            retorno.AppendLine($"Preço Total: {precoTotal.ToString(CultureInfo.InvariantCulture)}");

            return retorno.ToString();
        }
    }
}
