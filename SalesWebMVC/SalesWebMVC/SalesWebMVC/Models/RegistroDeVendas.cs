using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class RegistroDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public StatusDeVenda StatusDeVenda { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroDeVendas()
        {
        }

        public RegistroDeVendas(int id, DateTime data, double quantidade, StatusDeVenda statusDeVenda, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            StatusDeVenda = statusDeVenda;
            Vendedor = vendedor;
        }
    }
}
