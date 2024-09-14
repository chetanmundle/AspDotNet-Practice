using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoudMVC.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/Home")]
        [Route("/Home/Index")]
        public IActionResult Index()
        {
            return View();            //OR
            //return View("~/Views/Home/Index.cshtml");    // if we want to give the method name different
        }

        [Route("/Home/About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("/Home/Details/{id?}")]
        public int Details (int id)
        {
            return id; 
        }
    }
}
