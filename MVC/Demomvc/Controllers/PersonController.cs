using Microsoft.AspNetCore.Mvc;

namespace Demomvc.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PersonDetails()
        {
            List<string> opt = new List<string>();
            opt.Add("Select");
            opt.Add("Yes");
            opt.Add("No");
            ViewData["options"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(opt);
            return View();
        }

        [HttpPost]
        public IActionResult PersonDetails(IFormCollection fc, ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["Gender"];
            ViewBag.hobbies = hobbies;
            ViewBag.options = fc["Options"];
            return View("Details");
        }

    }
}
