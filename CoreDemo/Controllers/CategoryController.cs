using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = manager.GetAllCategories();
            return View(values);
        }
    }
}
