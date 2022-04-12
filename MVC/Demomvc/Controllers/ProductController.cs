using Microsoft.AspNetCore.Mvc;
using Demomvc.Models;

namespace Demomvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            ViewData["Message"]="welcome to the About page";
            List<string> color = new List<string>{ "red", "green", "blue" };
            ViewData["colorlist"] = color;
            ViewBag.Colors = color;
            ViewBag.msg = "Executing bag";
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Productlist> products = new List<Productlist>{
            new Productlist { pnm = "Laptop", id = 1, price = 5000 },
            new Productlist { pnm = "Desktop", id = 2, price = 15000 },
            new Productlist { pnm = "Tablet", id = 3, price = 2000 } };
            ViewBag.msg2 = "Executing Product bag";
            ViewBag.prolist = products;
            ViewData["prol"] = products;
            return View();
        }
    }
}
