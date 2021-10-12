using System;

namespace TaxaServico.Entidades
{
    class Aluguel
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public Aluguel(DateTime inicio, DateTime final, Veiculo veiculo)
        {
            Inicio = inicio;
            Final = final;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
