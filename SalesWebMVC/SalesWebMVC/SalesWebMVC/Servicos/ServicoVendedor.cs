using SalesWebMVC.Models;

namespace SalesWebMVC.Servicos
{
    public class ServicoVendedor
    {
        private readonly SalesWebMVCContext _DbContext;

        public ServicoVendedor(SalesWebMVCContext dbContext)
        {
            _DbContext = dbContext;
        }

        public List<Vendedor> FindAll()
        {
            return _DbContext.Vendedor.ToList();
        }
    }
}
