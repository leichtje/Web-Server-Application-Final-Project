using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Web_Server_Application_Final_Project.Models;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class AdminController : Controller
    {
        private FinalContext context { get; set; }


        public AdminController(FinalContext ctx)
        {
            context = ctx;
        }

        [Route("/Admin/Movies")]
        public IActionResult MoviesAdmin()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(
            m => m.Name).ToList();
            return View(movies);
        }

        [Route("/Admin/VideoGames")]
        public IActionResult VideoGamesAdmin()
        {
            var games = context.Games.Include(m => m.Type).OrderBy(
            m => m.Name).ToList();
            return View(games);
        }

        [Route("/Admin/Cameras")]
        public IActionResult CamerasAdmin()
        {
            var cameras = context.Cameras.OrderBy(c => c.Rating).ToList();
            return View(cameras);
        }


        [Route("/Admin/Place")]
        public IActionResult PlaceAdmin()
        {
            var locations = context.Locations.OrderBy(l => l.Rating).ToList();
            return View(locations);
        }

    }
}
