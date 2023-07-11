using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class GoatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
