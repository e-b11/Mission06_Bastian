using Microsoft.AspNetCore.Mvc;
using Mission06_Bastian.Models;
using System.Diagnostics;

namespace Mission06_Bastian.Controllers
{
    public class HomeController : Controller
    {      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
            return View();
        }
      
    }
}
