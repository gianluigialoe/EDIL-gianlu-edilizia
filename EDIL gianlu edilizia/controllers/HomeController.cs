using Microsoft.AspNetCore.Mvc;

namespace EDIL_gianlu_edilizia.controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title = "Sono la Home dalla ViewBag";
            return View();
        }
    }
}
