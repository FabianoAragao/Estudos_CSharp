using System;

namespace Vendas.Entidades
{
    class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimeto{ get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, string email, DateTime dataDeNascimeto)
        {
            Nome = nome;
            Email = email;
            DataDeNascimeto = dataDeNascimeto;
        }
    }
}
