using Microsoft.AspNetCore.Mvc;
using Web_Server_Application_Final_Project.Models;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class MovieController : Controller
    {
        private FinalContext context { get; set; }
        public MovieController(FinalContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Genres
                = context.Genres.OrderBy(g => g.Name).ToList();
            return View("Edit", new Movie());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Genres
                = context.Genres.OrderBy(g => g.Name).ToList();
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                if (movie.MovieId == 0)
                    context.Movies.Add(movie);
                else
                    context.Movies.Update(movie);
                context.SaveChanges();
                return RedirectToAction("Movies", "Home");
            }
            else
            {
                ViewBag.Action =
                movie.MovieId == 0 ? "Add" : "Edit";
                ViewBag.Genres
                    = context.Genres.OrderBy(g => g.Name).ToList();
                return View(movie);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(Movie movie)
        {
            context.Movies.Remove(movie);
            context.SaveChanges();
            return RedirectToAction("Movies", "Home");
        }
    }
}
