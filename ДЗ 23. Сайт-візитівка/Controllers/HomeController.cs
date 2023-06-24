using Microsoft.AspNetCore.Mvc;

namespace ДЗ_23._Сайт_візитівка.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
