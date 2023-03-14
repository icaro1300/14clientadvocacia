using Microsoft.AspNetCore.Mvc;

namespace AdvocaciaCliente.Models
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        { return View(); }
    }
}
