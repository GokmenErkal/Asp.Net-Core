using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.ViewComponents.Category
{
    public class CategoryList : ViewComponent
    {
        CategoryManager manager = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = manager.GetAllCategories();
            return View(values);
        }
    }
}
