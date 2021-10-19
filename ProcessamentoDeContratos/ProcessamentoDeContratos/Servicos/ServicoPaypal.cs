using System.Globalization;

namespace ProcessamentoDeContratos.Servicos
{
    class ServicoPaypal :  IServicosPagamento
    {
        public double CalculaJuros(double vlrParcela, int numMeses)
        {
            double temp = vlrParcela + (vlrParcela * (0.01 * numMeses));//calcula a taxa de juros 
            return temp + (vlrParcela * 0.02);// calcula a taxa de pagamento do paypal
        }

        //public double CalculaTaxaPag(double vlrParcela)
        //{
         //   return vlrParcela + (vlrParcela * 0.02);
       // }
    }
}
