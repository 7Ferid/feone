using Microsoft.AspNetCore.Mvc;

namespace feane_Front_To_Back.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
