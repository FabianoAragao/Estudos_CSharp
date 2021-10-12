using TaxaServico.Entidades;
using System;

namespace TaxaServico.Servicos
{
    class ServicoDeAluguel
    {
        public double PrecoPorHora { get; private set; }
        public double PrecoPorDia { get; private set; }

        private ITaxaImposto _imposto;

        public ServicoDeAluguel(double precoPorHora, double precoPorDia, ITaxaImposto imposto)
        {
            PrecoPorHora = precoPorHora;
            PrecoPorDia = precoPorDia;
            _imposto = imposto;
        }

        public void ProcessarFatura(Aluguel aluguel)
        {
            TimeSpan duracao = aluguel.Final.Subtract(aluguel.Inicio);
            double pagamentoBase = 0.0;

            if (Math.Ceiling(duracao.TotalHours) <= 12)
            {
                pagamentoBase = PrecoPorHora * Math.Ceiling(duracao.TotalHours);
            }
            else 
            {
                pagamentoBase = PrecoPorDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _imposto.CalculoImposto(pagamentoBase);

            aluguel.Fatura = new Fatura(pagamentoBase, imposto);
        }
    }
}
