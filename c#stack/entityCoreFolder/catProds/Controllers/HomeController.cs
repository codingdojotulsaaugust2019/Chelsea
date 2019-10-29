using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using catProds.Models;

namespace catProds.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
        
        [HttpGet("")]
        public IActionResult Products()
        {
            List<Product> products = dbContext.Products.ToList();
            return View(products);
        }

        [HttpPost("newproduct")]
        public IActionResult newProduct(Product product)
        {
            dbContext.Add(product);
            dbContext.SaveChanges();
            return RedirectToAction("Products");
        }

        [HttpGet("categories")]
        public IActionResult Categories()
        {
            List<Category> cats = dbContext.Categories.ToList();
            return View(cats);
        }

        [HttpPost("newcategory")]
        public IActionResult newCategory(Category category)
        {
            dbContext.Add(category);
            dbContext.SaveChanges();
            return RedirectToAction("Categories");
        }

        [HttpGet("product/{id}")]
        public IActionResult Product(int id)
        {
            Product thing = dbContext.Products.FirstOrDefault(p => p.ProductId == id);
            ViewBag.cats = dbContext.Categories.ToList();

            List<Category> assocCat = dbContext.Categories.Include(cat => cat.Products).ThenInclude(assoc => assoc.Product).Where(cat => cat.Products.Any(assoc => assoc.ProductId == id)).ToList();

            ViewBag.cats1 = assocCat;

            return View(thing);
        }

        [HttpPost("addcat")]
        public IActionResult AddCategory(Association input)
        {
            int id = input.ProductId;
            dbContext.Add(input);
            dbContext.SaveChanges();
            return Redirect($"product/{id}");
        }
        
        [HttpGet("category/{id}")]
        public IActionResult Category(int id)
        {
            Category category = dbContext.Categories.FirstOrDefault(c => c.CategoryId == id);

            ViewBag.prods = dbContext.Products.ToList();

            List<Product> assocProds = dbContext.Products.Include(prod => prod.Categories).ThenInclude(assoc => assoc.Category).Where(prod => prod.Categories.Any(assoc => assoc.CategoryId == id)).ToList();

            ViewBag.prods1 = assocProds;

            return View(category);
        }

        [HttpPost("addproduct")]
        public IActionResult AddProduct(Association input)
        {
            int id = input.CategoryId;
            dbContext.Add(input);
            dbContext.SaveChanges();
            return Redirect($"category/{id}");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
