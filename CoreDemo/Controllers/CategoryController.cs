using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
