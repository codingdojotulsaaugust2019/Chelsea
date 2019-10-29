using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bankAccounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;


namespace exam.Controllers
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
                int sessionid = (int)IntVariable;

                List<Transaction> Transactions = dbContext.Transactions
                    .Where(trans => trans.UserId == sessionid)
                    .ToList();

                ViewBag.Transactions = Transactions;

                User userNsesh = dbContext.Users.SingleOrDefault(u => u.UserId == sessionid);
                return View(userNsesh);
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

        [HttpPost("transaction")]
        public IActionResult Transaction(Transaction trans)
        {
            int? sessionid = HttpContext.Session.GetInt32("UserId");
            User user = dbContext.Users.FirstOrDefault(usr => usr.UserId == sessionid);

            //If the transaction's deposit field is false, then we are doing a withdarawl
            if(trans.Deposit == false)
            {
                if(trans.Amount > user.Balance)
                {
                    ModelState.AddModelError("Deposit","Cannot withdraw more than current balance.");
                }
                if(ModelState.IsValid)
                {
                    dbContext.Add(trans);
                    user.Balance = user.Balance - trans.Amount;
                    dbContext.SaveChanges();
                    return RedirectToAction("Logged");
                }
            }
            if(trans.Deposit == true)
            {
                dbContext.Add(trans);
                user.Balance = user.Balance + trans.Amount;
                dbContext.SaveChanges();
            }
            return RedirectToAction("Logged");
        }
    }
}