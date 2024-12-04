using Microsoft.AspNetCore.Mvc;

namespace Web_Server_Application_Final_Project.Controllers
{
    public class ActionController : Controller
    {
        public IActionResult JonathonLinkedIn()
        {
            return Redirect("https://www.linkedin.com/in/jleicht9/");
        }

        public IActionResult LoganLinkedIn()
        {
            return Redirect("https://www.linkedin.com/in/loganfree/");
        }

        
    }
}
