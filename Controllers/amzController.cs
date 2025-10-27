using Microsoft.AspNetCore.Mvc;

namespace amazoon.Controllers
{
    public class amzController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
