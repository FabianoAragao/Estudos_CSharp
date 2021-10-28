using ProcessamentoDeContratos.Servicos.Interfaces;

namespace ProcessamentoDeContratos.Servicos
{
    class ServicoPaypal :  IServicosPagamento
    {
        public double CalculaJuros(double vlrParcela, int numMeses)
        {
            return (vlrParcela * (0.01 * numMeses));
        }

        public double CalculaTaxaPag(double vlrParcela)
        {
            return (vlrParcela * 0.02);
        }
    }
}
