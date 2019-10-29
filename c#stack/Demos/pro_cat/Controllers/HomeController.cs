using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pro_cat.Models;
using Microsoft.EntityFrameworkCore;// for mysql
using Microsoft.AspNetCore.Identity;// for hashing
using Microsoft.AspNetCore.Http; //for session


namespace pro_cat.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            var CategoriesWithProducts = dbContext.Categories.Include(category => category.CatProducts)
            .ThenInclude(catproduct => catproduct.Product).ToList();

            ViewBag.AllProducts = dbContext.Products.ToList();
            ViewBag.AllCategories = CategoriesWithProducts; 

            return View();
        }

        [HttpGet("addproduct")]
        public IActionResult AddProduct(){
            return View("AddProduct");
        }

        [HttpPost("submitproduct")]
        public IActionResult SubmitProduct(Product nProd){
            if(ModelState.IsValid){
                dbContext.Products.Add(nProd);
                dbContext.SaveChanges();
                return Redirect($"product/{nProd.ProdId}");
            }
            else {
                return View("AddProduct");
            }
        }

        [HttpGet("AddCategory")]
        public IActionResult AddCategory(){
            return View();
        }

        [HttpPost("submitcategory")]
        public IActionResult SubmitCategory(Category nCat){
            if(ModelState.IsValid){
                dbContext.Categories.Add(nCat);
                dbContext.SaveChanges();
                return Redirect($"category/{nCat.CatId}");
            }
            return View("AddCategory");
        }

        [HttpGet("category/{catid}")]
        public IActionResult ShowCategory(int catid){
            Category sCat = dbContext.Categories.Include(c => c.CatProducts)
            .ThenInclude(catprod => catprod.Product).FirstOrDefault(c => c.CatId == catid);

            List<Product> AssociatedProducts = dbContext.Products.Include(p => p.ProdCategories).ThenInclude(pc => pc.Category).Where(p => p.ProdCategories.Any(pc => pc.CatId == catid)).ToList();

            List<Product> AddableProducts = dbContext.Products.Except(AssociatedProducts).ToList();

            ViewBag.Associated_Products = AssociatedProducts;
            ViewBag.Products = AddableProducts;
            return View(sCat);
        }

        [HttpGet("product/{prodid}")]
        public IActionResult ShowProduct(int prodid){

            ProductView ProductViewView = new ProductView()
            {
                ShowProduct = dbContext.Products
                    .Include(p => p.ProdCategories)
                    .ThenInclude(assoc => assoc.Category)
                    .FirstOrDefault(product => product.ProdId == prodid),
                UnaddedCategories = dbContext.Categories
                    .Include(cat => cat.CatProducts)
                    .Where(cat => cat.CatProducts == null || cat.CatProducts.Any(catAssoc => catAssoc.ProdId == prodid) == false)
                    .ToList()
            };
            return View(ProductViewView);
        }


        
        [HttpPost("add_prod_to_cat")]
        public IActionResult AddProdToCat(Association newAss){
            Product pCheck = dbContext.Products.FirstOrDefault(p => p.ProdId == newAss.ProdId);
            Category cCheck = dbContext.Categories.FirstOrDefault(c => c.CatId == newAss.CatId);
            if( pCheck != null && cCheck != null){
                dbContext.Add(newAss);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost("add_cat_to_prod/{ProdId}")]
        public IActionResult AddCatToProd(ProductView PV, int ProdId){ //This and the above could be refactored and combined to handle adding either way.
            Association newAss = PV.Association;
            newAss.ProdId = ProdId;
            Product pCheck = dbContext.Products.FirstOrDefault(p => p.ProdId == newAss.ProdId);
            Category cCheck = dbContext.Categories.FirstOrDefault(c => c.CatId == newAss.CatId);
            if( pCheck != null && cCheck != null){
                dbContext.Add(newAss);
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
