using Microsoft.AspNetCore.Mvc;

namespace SiteAquario.Controllers
{
    public class GraficoController : Controller
    {
        public IActionResult Grafico()
        {
            return View();
        }
    }
}
