using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using chefNdish.Models;
using Microsoft.EntityFrameworkCore;

namespace chefNdish.Controllers
{
    public class HomeController : Controller
    {

        private MyContext dbContext;
     
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Chefs()
        {
            List<Chef> chefs = dbContext.Chefs.ToList();

            return View(chefs);
        }

        [HttpGet("new")]
        public IActionResult ChefForm()
        {
            return View();
        }

        //[HttpGet("edit")]
        //public IActionResult EditChefForm()
        //{
        //    return View();
        //}

        [HttpPost("add")]
        public IActionResult Add(Chef chef)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Chefs");
            }
            return View("ChefForm");
        }

        //[HttpPost("update")]
        //public IActionResult Edit(Chef editChef, int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Chef chef = dbContext.ViewModel.Chef.FirstOrDefault(c => c.ChefId == id)
//
        //        chef.FirstName = editChef.FirstName;
        //        chef.LastName = editChef.LastName;
        //        chef.Birthday = editChef.Birthday;
        //        chef.UpdatedAt = DateTime.Now;
        //        dbContext.SaveChanges();
//
        //        return RedirectToAction("Chefs");
        //    }
        //    return View();
        //}

        public IActionResult Dishes()
        {
            List<Dish> dishesNcreator = dbContext.Dishes.Include(d => d.Creator).ToList();
            return View(dishesNcreator);
        }

        [HttpGet("newdish")]
        public IActionResult DishForm()
        {
            List<Chef> chefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = chefs;
            return View();
        }

        //[HttpGet("editdish")]
        //public IActionResult EditDishForm()
        //{
        //    return View();
        //}

        [HttpPost("adddish")]
        public IActionResult AddDish(Dish dish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            List<Chef> chefs = dbContext.Chefs.ToList();
            ViewBag.Chefs = chefs;
            return View("DishForm");
        }

        //[HttpPost("updatedish")]
        //public IActionResult EditDish(Dish updatedDish, int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Dish dish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);
//
        //        dish.Name = updatedDish.Name;
        //        dish.Tastiness = updatedDish.Tastiness;
        //        dish.ChefId = updatedDish.ChefId;
        //        dish.Calories = updatedDish.Calories;
        //        dish.Description = updatedDish.Description;
        //        dish.UpdatedAt = DateTime.Now;
//
        //        return RedirectToAction("Dishes");
        //    }
        //    return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
