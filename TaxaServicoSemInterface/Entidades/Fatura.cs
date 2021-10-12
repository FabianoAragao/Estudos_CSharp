using System.Globalization;

namespace TaxaServico.Entidades
{
    class Fatura
    {
        public double PagamentoBase { get; set; }
        public double Imposto { get; set; }

        public Fatura(double pagamentoBase, double imposto)
        {
            PagamentoBase = pagamentoBase;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBase + Imposto; }
        }

        public override string ToString()
        {
            return $"Pagamento base: {PagamentoBase.ToString("F2",CultureInfo.InvariantCulture)}" +
                $"\nimposto: {Imposto.ToString("F2",CultureInfo.InvariantCulture)}" +
                $"\nTotal: {PagamentoTotal.ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
