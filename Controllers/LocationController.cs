using Microsoft.AspNetCore.Mvc;
using Web_Server_Application_Final_Project.Models;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class LocationController : Controller
    {
        private FinalContext context { get; set; }
        public LocationController(FinalContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Locations
                = context.Locations.OrderBy(l => l.Name).ToList();
            return View("Edit", new Location());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Locations
                = context.Locations.OrderBy(l => l.Name).ToList();
            var location = context.Locations.Find(id);
            return View(location);
        }

        [HttpPost]
        public IActionResult Edit(Location location)
        {
            if (ModelState.IsValid)
            {
                if (location.LocationId == 0)
                    context.Locations.Add(location);
                else
                    context.Locations.Update(location);
                context.SaveChanges();
                return RedirectToAction("Place", "Home");
            }
            else
            {
                ViewBag.Action =
                location.LocationId == 0 ? "Add" : "Edit";
                ViewBag.Locations
                    = context.Locations.OrderBy(l => l.Name).ToList();
                return View(location);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var location = context.Locations.Find(id);
            return View(location);
        }

        [HttpPost]
        public IActionResult Delete(Location location)
        {
            context.Locations.Remove(location);
            context.SaveChanges();
            return RedirectToAction("Place", "Home");
        }
    }
}
