using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_Server_Application_Final_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Web_Server_Application_Final_Project.Controllers
{
	
	public class HomeController : Controller
	{
     

        private FinalContext context { get; set; }
		//private GameContext gameContext { get; set; }

		public HomeController(FinalContext ctx)
		{
			context = ctx;
        }



		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Logan()
		{
			return View();
		}

        public IActionResult Jonathon()
        {
            return View();
        }

		public IActionResult Cameras() 
		{
			return View();
		}

		public IActionResult Movies()
		{
			var movies = context.Movies.Include(m => m.Genre).OrderBy(
			m => m.Name).ToList();
			return View(movies);
		}

        public IActionResult VideoGames()
        {
			var games = context.Games.Include(m => m.Type).OrderBy(
			m => m.Name).ToList();
			return View(games);

		}

        public IActionResult Place()
        {
            return View();
        }

        public IActionResult True()
        {
            return Redirect("https://youtu.be/dQw4w9WgXcQ?si=jculv-4M5s6_TeZl");
        }

        public IActionResult False()
        {
            return Redirect("https://www.youtube.com/watch?v=p7YXXieghto");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
