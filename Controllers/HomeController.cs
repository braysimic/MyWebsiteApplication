using Microsoft.AspNetCore.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var contacts = new List<string>
            {
                "Email: me@example.com",
                "Phone: 123-456-7890",
                "Address: 123 Main St"
            };

            ViewBag.Contacts = contacts;
            return View();
        }
    }
}

