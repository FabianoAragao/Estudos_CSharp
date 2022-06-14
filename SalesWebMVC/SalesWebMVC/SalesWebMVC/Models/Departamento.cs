using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public Departamento()
        {
        }

        public void AddVendedor(Vendedor vendedor)
        { 
            this.Vendedores.Add(vendedor);
        }

        public double TotalDeVendas(DateTime dtIni, DateTime dtFim)
        {
            return this.Vendedores.Sum(Vendedor => Vendedor.TotalDeVendas(dtIni,dtFim));
        }
    }
}
