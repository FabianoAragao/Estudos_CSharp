using System;

namespace ContratosTrabalho.Entidades
{
    class Trabalhador
    {
        public string nome { get; private set; }
        public NivelDoTrabalhador nivel{ get; private set; }
        public double salarioBase{ get; private set; }

        public void addContrato(ContratosPorHora contrato) 
        {
        
        }

        public void removeContrato(ContratosPorHora contrato)
        {
        
        }

        public double renda(int ano, int mes)
        {
            return 0.0;
        }
    }
}
