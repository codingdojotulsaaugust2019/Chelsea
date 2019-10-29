using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZombieProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace ZombieProject.Controllers
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

        [HttpGet("signup")]
        public IActionResult SignUp()
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
            return View("SignUp");
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
                int sessionid = (int)IntVariable;
                List<User> users = dbContext.Users.Where(user => user.UserId != sessionid).ToList();
                return View(users);
            }
            return RedirectToAction("Index");
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("profile/{id}")]
        public IActionResult Profile(int id)
        {
            User user = dbContext.Users.SingleOrDefault(usr => usr.UserId == id);
            return View(user);
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            int? sessionid = HttpContext.Session.GetInt32("UserId");
            int sesh = (int)sessionid;
            User user = dbContext.Users.SingleOrDefault(usr => usr.UserId == sesh);
            return View(user);
        }

        [HttpGet("messager/{id}")]
        public IActionResult Messager(int id)
        {
            User recipient = dbContext.Users.SingleOrDefault(usr => usr.UserId == id);

            int? intVar = HttpContext.Session.GetInt32("UserId");
            int sessionid = (int)intVar;
            User sender = dbContext.Users.SingleOrDefault(usr => usr.UserId == sessionid);
            //grab a list ordered by date descending of all messages from both sides.

            ViewBag.Sender = sender;
            ViewBag.Target = recipient;

            List<Message> messages = dbContext.Messages
                .Include(msg => msg.Sender)
                .Include(msg => msg.Target)
                .Where(msg => msg.SenderId == recipient.UserId || msg.SenderId == sessionid)
                .Where(msg => msg.TargetId == recipient.UserId || msg.TargetId == sessionid)
                .OrderBy(msg => msg.CreatedAt)
                .ToList();

            ViewBag.Messages = messages;

            TempData["Recipient"] = recipient.UserId;

            return View();
        }

        [HttpPost("sendmessage")]
        public IActionResult SendMessage(Message msg)
        {
            int x = (int)TempData["Recipient"];

            if(ModelState.IsValid)
            {
            User recipient = dbContext.Users.SingleOrDefault(usr => usr.UserId == x);

            int? intVar = HttpContext.Session.GetInt32("UserId");
            int sessionid = (int)intVar;
            User sender = dbContext.Users.SingleOrDefault(usr => usr.UserId == sessionid);
            //grab a list ordered by date descending of all messages from both sides.

            ViewBag.Sender = sender;
            ViewBag.Target = recipient;

            List<Message> messages = dbContext.Messages
                .Include(m => m.Sender)
                .Include(m => m.Target)
                .Where(m => m.SenderId == recipient.UserId || m.SenderId == sessionid)
                .Where(m => m.TargetId == recipient.UserId || m.TargetId == sessionid)
                .OrderByDescending (m => m.CreatedAt)
                .ToList();

            ViewBag.Messages = messages;

                dbContext.Messages.Add(msg);
                dbContext.SaveChanges();
                return Redirect($"messager/{x}");
            }
            return View("Messager");
        }

        [HttpGet("inbox")]
        public IActionResult inbox()
        {
            int? intVar = HttpContext.Session.GetInt32("UserId");
            int sessionid = (int)intVar;

            List<User> conversations = dbContext.Users
                .Include(usr => usr.ISentTo).ThenInclude(msg => msg.Target)
                .Include (usr => usr.IRecievedFrom).ThenInclude(msg => msg.Sender)
                .Where(usr => usr.ISentTo.Any(rel =>rel.TargetId == sessionid) 
                ||
                usr.IRecievedFrom.Any(rel => rel.SenderId == sessionid))
                .ToList(); 


            return View(conversations);
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
