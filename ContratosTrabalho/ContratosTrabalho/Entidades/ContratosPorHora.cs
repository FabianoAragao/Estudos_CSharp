using System;

namespace ContratosTrabalho.Entidades
{
    class ContratosPorHora
    {
        public DateTime Data  { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }

        public ContratosPorHora()
        {
        }
        public ContratosPorHora(DateTime data, double valorPorHora, int horas)
        {
            this.Data = data;
            this.ValorPorHora = valorPorHora;
            this.Horas = horas;
        }

        public double ValorTotal()
        {
            return (double)this.Horas * this.ValorPorHora;
        }
            
    }
}
