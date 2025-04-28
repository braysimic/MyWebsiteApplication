using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    [Area("Help")]
    public class HomeController : Controller
    {
        public IActionResult Index(int step = 1)
        {
            if (step < 1 || step > 3)
                step = 1;
                
            ViewBag.CurrentStep = step;
            return View();
        }
    }
}