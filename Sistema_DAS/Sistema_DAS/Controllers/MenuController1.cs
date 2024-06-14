using Microsoft.AspNetCore.Mvc;

namespace Sistema_DAS.Controllers
{
    public class MenuController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
