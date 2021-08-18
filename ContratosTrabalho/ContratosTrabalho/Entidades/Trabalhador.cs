using System;
using System.Collections.Generic;
using ContratosTrabalho.Entidades.Enums;

namespace ContratosTrabalho.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelDoTrabalhador Nivel{ get; set; }
        public double SalarioBase{ get; set; }
        public Departamento Departamento { get; set; }
        public List<ContratosPorHora> Contratos { get; set; } = new List<ContratosPorHora>();

        public Trabalhador(string nome, NivelDoTrabalhador nivel, double salarioBase, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public Trabalhador()
        {
        }

        public void addContrato(ContratosPorHora contrato) 
        {
            this.Contratos.Add(contrato);
        }

        public void removeContrato(ContratosPorHora contrato)
        {
            this.Contratos.Remove(contrato);
        }

        public double renda(int ano, int mes)
        {
            double soma = this.SalarioBase;

            foreach (ContratosPorHora contrato in Contratos)
            {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.ValorTotal();
                }
            }

            return soma;
        }
    }
}
