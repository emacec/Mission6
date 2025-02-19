using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;
using SQLitePCL;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _context;
    
        public HomeController(ApplicationContext temp) //Constructor
        {
            _context = temp;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FilmForm()
        {
            return View("FilmForm");
        }

        [HttpPost]
        public IActionResult FilmForm(Application response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); // add record to the database
                _context.SaveChanges();
            }
            

            return View("Confirmation", response);

        }

        public IActionResult GetToKnow()
        {
            return View();
        }
    }
}
