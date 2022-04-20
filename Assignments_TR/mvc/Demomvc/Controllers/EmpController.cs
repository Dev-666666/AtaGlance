using Microsoft.AspNetCore.Mvc;
using Demomvc.Models;

namespace Demomvc.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult empDetails()
        {
            List<EmpData> details = new List<EmpData>()
            {
                new EmpData{ id=1,ename="Marshal",designation="Developer",salary=70000},
               new EmpData{ id=2,ename="Kavis",designation="Tester",salary=20000},
              new EmpData{ id=3,ename="Meena",designation="Network operator",salary=40000},
              new EmpData{ id=4,ename="Danniel",designation="Developer",salary=70000},
            };

            ViewBag.edetails = details;
            return View();
        }
    }
}
