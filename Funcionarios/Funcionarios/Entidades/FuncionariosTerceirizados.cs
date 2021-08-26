using System;
using System.Collections.Generic;

namespace Funcionario.Entidades
{
    class FuncionariosTerceirizados : Funcionarios
    {
        public double ValorAdicional { get; set; }

        public FuncionariosTerceirizados()
        {
        }

        public FuncionariosTerceirizados(string nome, int horas, double valorPorHora, double valorAdicional) 
            :base(nome,horas,valorPorHora)
        {
            ValorAdicional = valorAdicional;
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + (ValorAdicional * 1.10);
        }
    }
}
