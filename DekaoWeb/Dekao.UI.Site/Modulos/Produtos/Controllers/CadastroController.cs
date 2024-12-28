using Microsoft.AspNetCore.Mvc;

namespace Dekao.UI.Site.Modulos.Produtos.Controllers
{
    [Area("Produtos")]
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Busca()
        {
            return View();
        }
    }
}
