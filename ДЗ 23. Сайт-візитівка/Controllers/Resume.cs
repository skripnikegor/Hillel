using Microsoft.AspNetCore.Mvc;

namespace ДЗ_23._Сайт_візитівка.Controllers
{
    public class Resume : Controller
    {
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View("About");
        }
    }
}
