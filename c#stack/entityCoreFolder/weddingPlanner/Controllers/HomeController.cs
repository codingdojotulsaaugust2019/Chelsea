using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using weddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;



namespace weddingPlanner.Controllers
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
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!"); 
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);

                dbContext.Add(user);
                dbContext.SaveChanges();
                int sesh = user.UserId;
                HttpContext.Session.SetInt32("UserId", sesh);
                
                return RedirectToAction("Dashboard");
            }
            return View("");
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                var userInDb = dbContext.Users.FirstOrDefault(u => u.Email == userSubmission.lEmail);
                if(userInDb == null)
                {
                    ModelState.AddModelError("lEmail", "Email not found.");
                    return View("Index");
                }
                
                var hasher = new PasswordHasher<LoginUser>();
                
                var result = hasher.VerifyHashedPassword(userSubmission, userInDb.Password, userSubmission.lPassword);
                
                if(result == 0)
                {
                    ModelState.AddModelError("lPassword", "Invalid password!");
                    return View("Index");
                }

                int sesh = userInDb.UserId;
                HttpContext.Session.SetInt32("UserId", sesh);

                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");

            if(IntVariable != null)
            {
                ViewBag.session = IntVariable;
                List<Wedding> weddings = dbContext.Weddings
                    .Include(w => w.Guests)
                    .ThenInclude(u => u.User)
                    .Include(w => w.Planner)
                    .ToList();

                return View(weddings);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("new")]
        public IActionResult New()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Wedding wedding)
        {
            if(ModelState.IsValid)
            {
                int? session = HttpContext.Session.GetInt32("UserId");
                dbContext.Weddings.Add(wedding);
                wedding.UserId = (int)session;
                ViewBag.session = session;
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            return View("New");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
            Wedding wedding = dbContext.Weddings.SingleOrDefault(w => w.WeddingId == id);
            dbContext.Weddings.Remove(wedding);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("rsvp")]
        public IActionResult RSVP(Guest input)
        {
            dbContext.Guests.Add(input);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost("unrsvp")]
        public IActionResult UNRSVP(Guest input)
        {
            Guest rsvp = dbContext.Guests.FirstOrDefault(g => g.UserId == input.UserId && g.WeddingId == input.WeddingId);

            dbContext.Guests.Remove(rsvp);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpGet("wedding/{id}")]
        public IActionResult Wedding(int id)
        {
            Wedding wedding = dbContext.Weddings
                    .Include(w => w.Guests)
                    .ThenInclude(u => u.User)
                    .Include(w => w.Planner)
                    .SingleOrDefault(w => w.WeddingId == id);
            //Wedding thisWedding = dbContext.Weddings.SingleOrDefault(wedding => wedding.WeddingId == id);
            return View(wedding);
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");
            HttpContext.Session.Clear();
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
