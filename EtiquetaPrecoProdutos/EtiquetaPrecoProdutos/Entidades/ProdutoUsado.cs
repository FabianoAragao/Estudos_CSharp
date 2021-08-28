using System;
using System.Globalization;

namespace EtiquetaPrecoProdutos.Entidades
{
    class ProdutoUsado : Produto
    {
        public DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado()
        {
        }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string EtquetaDePreco()
        {
            return Nome + "(Usado) $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + 
                    " (Data de fabricacao " + DataDeFabricacao.ToString("dd/MM/yyyy") + ")";
        }
    }
}
