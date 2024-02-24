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
            ViewBag.Categories = _context.Categories.ToList()
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieForm", new Movie());
        }

        [HttpPost]
        public IActionResult MovieForm(Movie response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else //Invalid data
            {
                ViewBag.Categories = _context.Categories.ToList()
                    .OrderBy(x => x.CategoryId)
                    .ToList();

                return View(response);
            }

        }

        public IActionResult ViewMovies()
        {
            var movies = _context.Movies
                .OrderBy(x => x.Title)
                .ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);

            ViewBag.Categories = _context.Categories.ToList()
                .OrderBy(x => x.CategoryId)
                .ToList();

            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movie updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Movie deleteMovie) 
        { 
            _context.Movies.Remove(deleteMovie);
            _context.SaveChanges();

            return RedirectToAction("ViewMovies");
        }
       
      
    }
}
