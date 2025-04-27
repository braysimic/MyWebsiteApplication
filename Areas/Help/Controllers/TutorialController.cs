using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Areas.Help.Controllers
{
    [Area("Help")]
    public class TutorialController : Controller
    {
        public IActionResult Index(int id = 1)
        {
            string viewName = $"Page{id}";
            return View(viewName);
        }
    }
}
