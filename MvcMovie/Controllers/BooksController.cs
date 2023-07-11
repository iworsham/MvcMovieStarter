using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Returns()
        {
            return View();
        }
    }
}
