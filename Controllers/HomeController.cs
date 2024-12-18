using Microsoft.AspNetCore.Mvc;
namespace CoffeCafeDay.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult PostContactNumber(string textInput)
        {
            ViewBag.ReceivedString = textInput;
            return RedirectToAction("Index", "Home");
        }

    }
}