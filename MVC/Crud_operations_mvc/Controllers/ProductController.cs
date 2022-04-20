using Microsoft.AspNetCore.Mvc;
using Crud_operations_mvc.Models;

namespace Crud_operations_mvc.Controllers
{
    public class ProductController : Controller
    {
        ProductDAL pd = new ProductDAL();
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult List()
        {
            ViewBag.Prolist = pd.GetAllProduct();
            return View();
        }
    }
}
