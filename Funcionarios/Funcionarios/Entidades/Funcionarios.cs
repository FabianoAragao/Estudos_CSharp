using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Funcionario.Entidades
{
    class Funcionarios 
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionarios()
        {
        }

        public Funcionarios(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append($"{Nome} - $ {Pagamento().ToString("F2",CultureInfo.InvariantCulture)}");

            return retorno.ToString();
        }
    }
}
