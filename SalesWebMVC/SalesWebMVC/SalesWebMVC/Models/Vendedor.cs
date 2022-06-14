using System.Collections.Generic;
using System.Linq;


namespace SalesWebMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroDeVendas> Vendas { get; set; } = new List<RegistroDeVendas>();

        public Vendedor(int id, string nome, string email, DateTime dataDeNascimento, double salarioBase,
            Departamento departamento)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DataDeNascimento = dataDeNascimento;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public Vendedor()
        {
        }

        public void AddVendas(RegistroDeVendas venda)
        {
            this.Vendas.Add(venda);
        }
        public void RemoveVendas(RegistroDeVendas venda)
        {
            this.Vendas.Remove(venda);

        }

        public double TotalDeVendas(DateTime dtinicio, DateTime dtFim)
        {
            return this.Vendas.Where(vendas => vendas.Data >= dtinicio
                                        && vendas.Data <= dtFim)
                              .Sum(vendas => vendas.Quantidade);
        }
    }
}
