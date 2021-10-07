using Microsoft.AspNetCore.Mvc;

namespace RegistroDeVentas.Controllers
{
    public class PresentacionWeb3Controller : Controller
    {
        // GET
        public IActionResult Bienvenidxs()
        {
            return View();
        }
    }
}