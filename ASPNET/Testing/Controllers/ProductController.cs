using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository repo;
        public ProductController(IProductRepository repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {
            var products = repo.GetAllProducts();
            return View(products);
        }
        public IActionResult ViewProduct(int id)
        {
            var product = repo.GetProduct(id);
            return View(product);
        }
        public IActionResult UpdateProduct(int id)
        {
            var product = repo.GetProduct(id);
            if (product == null)
            {
                return View("ProductNotFound");
            }
            return View(product);
        }
        public IActionResult UpdateProductToDatabase(Product product)
        {
            repo.UpdateProduct(product);
            return RedirectToAction("ViewProduct", new { id = product.ProductID });
        }
        public IActionResult InsertProduct()
        {
            var product = repo.AssignCategory();
            return View(product);
        }
        public IActionResult InsertProductToDatabase(Product product)
        {
            repo.InsertProduct(product);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(Product product)
        {
            repo.DeleteProduct(product);
            return RedirectToAction("Index");
        }
    }
}
