using SportsStore.Domain.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace SportsStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        IProductRepository repository;

        public NavController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public PartialViewResult Menu(string category = null/*, bool horizontalLayout = false*/)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Products.Select(c => c.Category)
                                                              .Distinct()
                                                              .OrderBy(c => c);
            //string viewName = horizontalLayout ? "MenuHorizontal" : "Menu";
            //return PartialView(viewName, categories);

            return PartialView("FlexMenu", categories);
        }
    }
}