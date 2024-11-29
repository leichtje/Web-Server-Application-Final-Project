using Microsoft.AspNetCore.Mvc;
using Web_Server_Application_Final_Project.Models;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class GameController : Controller
    {
        private  FinalContext context { get; set; }
        public GameController(FinalContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Types
                = context.Types.OrderBy(g => g.Name).ToList();
            return View("Edit", new Game());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Types
                = context.Types.OrderBy(g => g.Name).ToList();
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                if (game.GameId == 0)
                    context.Games.Add(game);
                else
                    context.Games.Update(game);
                context.SaveChanges();
                return RedirectToAction("VideoGames", "Home");
            }
            else
            {
                ViewBag.Action =
				game.GameId == 0 ? "Add" : "Edit";
                ViewBag.Types
                    = context.Types.OrderBy(g => g.Name).ToList();
                return View(game);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = context.Games.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("VideoGames", "Home");
        }
    }
}
