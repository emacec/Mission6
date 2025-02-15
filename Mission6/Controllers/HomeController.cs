using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Mission6.Models;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FilmForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FilmForm(Application response)
        {
            //_context.Applications.Add(response); // add record to the database
            //_context.SaveChanges();

            return View("Confirmation", response);

        }

        public IActionResult GetToKnow()
        {
            return View();
        }
    }
}
