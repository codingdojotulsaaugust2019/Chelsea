using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using exam.Models;
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
                
                    //Get where user IDs match
                    List<User> friends = dbContext.Users
                        .Include(user => user.IRequested)
                        .Include(user => user.RequestedMe)
                        .Where(user => 
                        //For the user target list
                            user.IRequested.Any(relation => relation.Accepted == true && relation.TargetId == sessionid)||
                        //For the user sender list 
                            user.RequestedMe.Any(relation => relation.Accepted == true && relation.SenderId == sessionid))
                        .ToList();

                        ViewBag.friends = friends;

                //This query gets invitations and tries to "Except" the above query which grabs friends. 
                List<User> MyInvitationz = dbContext.Users
                    .Include(user => user.IRequested)
                    //The IRequested list is the OTHER user's IRequested, not MY (session user) IRequested list.
                    .Where(user => user.IRequested.Any(relation => relation.TargetId == sessionid && relation.Accepted == false))
                    .ToList();

                    ViewBag.MyInvitationz = MyInvitationz;

                User userNsesh = dbContext.Users.SingleOrDefault(u => u.UserId == IntVariable);
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


        [HttpGet("allusers")]
        public IActionResult AllUsers()
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");
            int session = (int)IntVariable;

            if(IntVariable != null)
            {
                //GOAL: display Users who is not the user in session AND a request (from either side) has not been made.
                List<User> usersNotIncludingMeOrMyRequestedUsers = dbContext.Users
                .Include(user => user.IRequested)
                .Include (user => user.RequestedMe)
                //Where user is not the user in session
                .Where(user => user.UserId != session 
                && 
                //AND they didnt send me a request
                user.IRequested.Any(relation => relation.TargetId == session) == false
                &&
                //AND I didnt send them a request
                user.RequestedMe.Any(relation => relation.SenderId == session) == false)
                .ToList();
                

                return View(usersNotIncludingMeOrMyRequestedUsers);
            }
            return View("Index");
        }

        [HttpPost("friendrequest")]
        public IActionResult FriendRequest(Relationship input)
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");
            int session = (int) IntVariable;
            //BELOW: Edits Sender ID from form input
            input.SenderId = session;

            if(ModelState.IsValid)
            {
                //BELOW: Creates a relationship with form input, and saves the updated Sender ID from above. This input is where both SenderID and TargetID are saved to database.
                dbContext.Relationships.Add(input);
                dbContext.SaveChanges();
            }
            return RedirectToAction("AllUsers");
        }

        [HttpGet("accept/{id}")]
        public IActionResult Accept(int id)
        {
            int? IntVariable = HttpContext.Session.GetInt32("UserId");
            int accepter = (int)IntVariable;
            int sender = id;

            Relationship relationship = dbContext.Relationships.FirstOrDefault(target => target.TargetId == accepter && target.SenderId == sender);

            relationship.Accepted = true;
            dbContext.SaveChanges();

            return RedirectToAction("Logged");
        }

        [HttpGet("show/{id}")]
        public IActionResult Show(int id)
        {
            User user = dbContext.Users.SingleOrDefault(u => u.UserId == id);
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
