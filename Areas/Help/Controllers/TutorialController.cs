using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(int id = 1)
        {
            if (id < 1 || id > 3)
                return RedirectToAction("Index", new { id = 1 });

            return View($"Page{id}");
        }
    }
}


