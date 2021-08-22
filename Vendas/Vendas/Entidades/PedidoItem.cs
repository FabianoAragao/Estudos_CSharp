using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vendas.Entidades
{
    class PedidoItem
    {
        public double Quantidade { get; set; }
        public double Preco { get; set; }

        public Produto ProdutoVenda { get; set; }

        public PedidoItem()
        {
        }

        public PedidoItem(double quantidade, double preco, Produto Produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            ProdutoVenda = Produto;
        }

        public double SubTotal()
        {
            return this.Preco * this.Quantidade;

        }
    }
}
