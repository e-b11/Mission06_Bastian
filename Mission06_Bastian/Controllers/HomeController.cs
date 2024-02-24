using Microsoft.AspNetCore.Mvc;
using Mission06_Bastian.Models;
using System.Diagnostics;

namespace Mission06_Bastian.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp) //Constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }

        public IActionResult ViewMovies()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }
        
        
      
    }
}
