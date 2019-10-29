using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using exam2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace exam2.Controllers
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
                
                return RedirectToAction("Logged");
            }
            return View("Index");
        }

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

                return RedirectToAction("Logged");
            }
            return View("Index");
        }

        [HttpGet("logged")]
        public IActionResult Logged()
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");


            if(IntVariable != null)
            {
                //ViewBags my User in Session
                User user = dbContext.Users.FirstOrDefault(u => u.UserId == IntVariable);
                ViewBag.user = user;

                //ViewBags my List of Ideas
                List<Idea> ideas = dbContext.Ideas
                .Include(idea => idea.Creator)
                .Include(idea => idea.Likes)
                .OrderByDescending(idea => idea.Likes.Count)
                .ToList();
                ViewBag.ideas = ideas;

                ViewBag.error = TempData["AlreadyLiked"];                

                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost("createidea")]
        public IActionResult CreateIdea(Idea idea)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(idea);
                int? sesh = HttpContext.Session.GetInt32("UserId");
                int sessionid = (int)sesh;
                idea.UserId = sessionid;
                dbContext.SaveChanges();
                return RedirectToAction("Logged");
            }

            //ViewBags my User in Session
                int? IntVariable = HttpContext.Session.GetInt32("UserId");
                User user = dbContext.Users.FirstOrDefault(u => u.UserId == IntVariable);
                ViewBag.user = user;

                //ViewBags my List of Ideas
                List<Idea> ideas = dbContext.Ideas
                .Include(i => i.Creator)
                .Include(i => i.Likes)
                .OrderByDescending(i => i.Likes.Count)
                .ToList();
                ViewBag.ideas = ideas;

            return View("Logged");
        }

        [HttpGet("idea/{id}")]
        public IActionResult ShowIdea(int id)
        {
            Idea idea = dbContext.Ideas
            .Include(i => i.Likes).ThenInclude(l => l.Liker)
            .Include(i =>i.Creator)
            .SingleOrDefault(i => i.IdeaId == id);
            return View(idea);
        }

        [HttpGet("person/{id}")]
        public IActionResult ShowPerson(int id)
        {
            User user = dbContext.Users
            .Include(usr => usr.Ideas)
            .Include(usr => usr.Likes)
            .SingleOrDefault(usr => usr.UserId == id);
            return View(user);
        }

        [HttpPost("createlike")]
        public IActionResult Like(Like like)
        {
            List<Like> currentLiked = dbContext.Likes.ToList();
            if(currentLiked.Any(l => l.UserId == like.UserId && l.IdeaId == like.IdeaId)==false)
            {
                dbContext.Likes.Add(like);
                dbContext.SaveChanges();
                return RedirectToAction("Logged");
            }
            TempData["AlreadyLiked"] = "You already liked this idea.";
            return RedirectToAction("Logged");
        }

        [HttpGet("delete/{id}")]
        public IActionResult Delete(int id)
        {
          Idea ideaToDelete = dbContext.Ideas.SingleOrDefault(idea => idea.IdeaId == id);
          dbContext.Ideas.Remove(ideaToDelete);
          dbContext.SaveChanges();
          return RedirectToAction("Logged");
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
