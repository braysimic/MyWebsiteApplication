using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(int id = 1)
        {
            if (id < 1 || id > 3)
                id = 1;

            return RedirectToAction($"Page{id}");
        }

        public IActionResult Page1()
        {
            ViewBag.CurrentStep = 1;
            return View();
        }

        public IActionResult Page2()
        {
            ViewBag.CurrentStep = 2;
            return View();
        }

        public IActionResult Page3()
        {
            ViewBag.CurrentStep = 3;
            return View();
        }
    }
}


