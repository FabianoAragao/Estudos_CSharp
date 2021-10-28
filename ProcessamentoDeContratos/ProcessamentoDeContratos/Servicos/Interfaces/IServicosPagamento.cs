
namespace ProcessamentoDeContratos.Servicos.Interfaces
{
    interface IServicosPagamento
    {
        public double CalculaJuros(double vlrParcela ,int numMeses);
        public double CalculaTaxaPag(double vlrParcela);
    }
}
