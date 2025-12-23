using Microsoft.AspNetCore.Mvc;

namespace feane_Front_To_Back.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
