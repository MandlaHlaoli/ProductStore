using Microsoft.AspNetCore.Mvc;
using ProductStore.Services;

namespace ProductStore.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ApplicationDbContext context;
        public ProductsController(ApplicationDbContext context) 
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
