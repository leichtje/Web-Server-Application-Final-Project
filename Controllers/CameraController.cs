using Microsoft.AspNetCore.Mvc;
using Web_Server_Application_Final_Project.Models;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class CameraController : Controller
    {
        private FinalContext context { get; set; }
        public CameraController(FinalContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Cameras
                = context.Cameras.OrderBy(c => c.Name).ToList();
            return View("Edit", new Camera());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Cameras
                = context.Cameras.OrderBy(c => c.Name).ToList();
            var camera = context.Cameras.Find(id);
            return View(camera);
        }

        [HttpPost]
        public IActionResult Edit(Camera camera)
        {
            if (ModelState.IsValid)
            {
                if (camera.CameraId == 0)
                    context.Cameras.Add(camera);
                else
                    context.Cameras.Update(camera);
                context.SaveChanges();
                return RedirectToAction("Cameras", "Home");
            }
            else
            {
                ViewBag.Action =
                camera.CameraId == 0 ? "Add" : "Edit";
                ViewBag.Cameras
                    = context.Cameras.OrderBy(c => c.Name).ToList();
                return View(camera);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var camera = context.Cameras.Find(id);
            return View(camera);
        }

        [HttpPost]
        public IActionResult Delete(Camera camera)
        {
            context.Cameras.Remove(camera);
            context.SaveChanges();
            return RedirectToAction("Cameras", "Home");
        }
    }
}
