using Microsoft.AspNetCore.Mvc;

namespace HOL2.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";

            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";

            ViewBag.num2 = 200;

            return View();
        }
    }
}
