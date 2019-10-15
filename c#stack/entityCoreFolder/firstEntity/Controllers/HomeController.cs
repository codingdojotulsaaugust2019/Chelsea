using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using firstEntity.Models;
using Microsoft.EntityFrameworkCore;

namespace firstEntity.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<User> AllUsers = dbContext.Users.ToList();

            List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson");

            List<User> MostRecent = dbContext.Users
                .OrderByDescending(u => u.CreatedAt)
                .Take(5)
                .ToList();

            return View();
        }

        [HttpGet("user")]
        public IActionResult GetOneUser(string Email)
        {
            User oneUser = dbContext.Users.FirstOrDefault(user => user.Email == Email);
            // Other code
            return Something;
        }

        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            // We can take the User object created from a form submission
            // And pass this object to the .Add() method
            dbContext.Add(newUser);
            // OR dbContext.Users.Add(newUser);
            dbContext.SaveChanges();
            // Other code
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
