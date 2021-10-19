
namespace ProcessamentoDeContratos.Servicos
{
    interface IServicosPagamento
    {
        public double CalculaJuros(double vlrParcela ,int numMeses);
        //public double CalculaTaxaPag(double vlrParcela);
    }
}
