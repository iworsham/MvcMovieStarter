using Microsoft.AspNetCore.Mvc;
using MvcMovie.DataAccess;

namespace MvcMovie.Controllers
{
    public class MoviesController : Controller
    {
        // for every controller that accesses a database, we need a context property.
        private readonly MvcMovieContext _context;

        // We need to create that context when we create the controller.
        public MoviesController(MvcMovieContext context)
        {
            _context = context;
        }
        // controller methods are called Actions
        // GET "/movies" <- this route is determined by the name of the controller
        public IActionResult Index()
        {
            var movies = _context.Movies;
            return View(movies); //.NET will look for the view called Movies/Index
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}
