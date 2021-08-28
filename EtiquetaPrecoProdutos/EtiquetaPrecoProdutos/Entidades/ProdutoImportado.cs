using System;
using System.Globalization;

namespace EtiquetaPrecoProdutos.Entidades
{
    class ProdutoImportado : Produto
    {
        public double TaxaAlfandega { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string nome, double preco, double taxaAlfandega) : base(nome, preco)
        {
            TaxaAlfandega = taxaAlfandega;
        }

        public double PrecoTotal()
        {
            return Preco + TaxaAlfandega;
        }

        public override string EtquetaDePreco()
        {
            return Nome + " $" + PrecoTotal().ToString("F2",CultureInfo.InvariantCulture) + 
                    "(Taxação: $" + TaxaAlfandega.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }


    }
}
