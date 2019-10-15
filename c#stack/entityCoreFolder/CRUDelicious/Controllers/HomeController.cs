using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private deliciousContext dbContext;
     
        public HomeController(deliciousContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.Dishes.ToList();

            return View(AllDishes);
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }


        [HttpPost("/create")]
        public IActionResult Create(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                dbContext.Add(newDish);
                dbContext.SaveChanges();
                int identity = newDish.DishId;

                return RedirectToAction("Show", new {id=identity});
            }
            return View("New");
        }


        [HttpGet("Show/{id}")]
        public IActionResult Show(int id)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(d => d.DishId == id);
            return View(thisDish);
        }


        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(d => d.DishId == id);
            return View(thisDish);
        }


        [HttpPost("update/{id}")]
        public IActionResult Update(Dish updatedDish, int id)
        {
            if (ModelState.IsValid)
            {
                Dish thisDish = dbContext.Dishes.FirstOrDefault(d => d.DishId == id);

                thisDish.Name = updatedDish.Name;
                thisDish.Chef = updatedDish.Chef;
                thisDish.Tastiness = updatedDish.Tastiness;
                thisDish.Calories = updatedDish.Calories;
                thisDish.Description = updatedDish.Description;
                thisDish.UpdatedAt = DateTime.Now;
                dbContext.SaveChanges();

                Dish newDish = dbContext.Dishes.SingleOrDefault(d => d.DishId == id);


                return Redirect($"/Show/{id}");
            }
            return View("Edit", updatedDish);
        }


        [HttpGet("delete/{id}")]
        public RedirectToActionResult Delete(int id)
        {
            Dish thisDish = dbContext.Dishes.SingleOrDefault(d => d.DishId == id);
            dbContext.Dishes.Remove(thisDish);
            dbContext.SaveChanges();

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
