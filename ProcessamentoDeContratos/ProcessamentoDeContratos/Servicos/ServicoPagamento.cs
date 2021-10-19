using System.Globalization;
using System;

namespace ProcessamentoDeContratos.Servicos
{
    class ServicoPagamento
    {
        public double Valor { get; set; }
        public int Meses { get; set; }

        private IServicosPagamento _servPag = new ServicoPaypal();

        public ServicoPagamento(double valor, int meses)
        {
            Valor = valor;
            Meses = meses;
        }

        public double ProcessarValor() 
        {
            double vlrRetorno = _servPag.CalculaJuros(Valor,Meses);
            return vlrRetorno;
        }
    }
}
