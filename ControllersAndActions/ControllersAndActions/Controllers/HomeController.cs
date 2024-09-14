using Microsoft.AspNetCore.Mvc;

namespace ControllersAndActions.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Display()
        {
            return "Hello Chetan Mundle";
        }

        public int DisplayId(int id)
        {
            return id;
        }
    }
}
