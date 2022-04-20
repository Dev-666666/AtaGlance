using Microsoft.AspNetCore.Mvc;

namespace Demomvc.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
