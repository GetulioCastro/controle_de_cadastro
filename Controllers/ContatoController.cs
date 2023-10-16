using Microsoft.AspNetCore.Mvc;

namespace ControleDeCadastro.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
