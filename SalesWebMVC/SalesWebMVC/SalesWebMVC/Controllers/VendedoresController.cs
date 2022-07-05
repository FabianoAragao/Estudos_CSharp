using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Servicos;

namespace SalesWebMVC.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly ServicoVendedor _servicoVendedor;

        public VendedoresController(ServicoVendedor servicoVendedor)
        {
            _servicoVendedor = servicoVendedor;
        }
        public IActionResult Index()
        {
            var list = _servicoVendedor.FindAll();

            return View(list);
        }
    }
}
