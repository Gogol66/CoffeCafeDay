using Microsoft.AspNetCore.Mvc;
namespace CoffeCafeDay.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostContactNumber(string contactNumber)
        {
            return View();
        }

    }
}