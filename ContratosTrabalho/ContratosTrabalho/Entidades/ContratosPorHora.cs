using System;

namespace ContratosTrabalho.Entidades
{
    class ContratosPorHora
    {
        public DateTime data  { get; set; }
        public double valorPorHora { get; set; }
        public int horas { get; set; }

        public double ValorTotal()
        {
            return 0.00;
        }
            
    }
}
