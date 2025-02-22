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

        public IActionResult List()
        {
            //Linq
            var applications = _context.Movies
                .Where(x => x.Edited == false)
                .OrderBy(x => x.Title).ToList();
            return View(applications);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.ApplicationID == id);

            return View("FilmForm", recordToEdit);
        }

        [HttpPost]

        public IActionResult Edit(Application updatedInfo)
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();

            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.ApplicationID == id);
            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Application delete)
        {
            _context.Movies.Remove(delete);
            _context.SaveChanges();

            return RedirectToAction("List");

        }

    }
}
