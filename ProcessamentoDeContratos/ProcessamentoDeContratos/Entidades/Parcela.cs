using System;

namespace ProcessamentoDeContratos.Entidades
{
    class Parcela
    {
        public DateTime DataDoContrato { get; set; }
        public double ValorDoContrato { get; set; }

        public Parcela(DateTime dataDoContrato,double valorDoContrato)
        {
            ValorDoContrato = valorDoContrato;
            DataDoContrato = dataDoContrato;
        }
    }
}
