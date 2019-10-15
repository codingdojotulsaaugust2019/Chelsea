using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modelssandbox.Models;

namespace modelssandbox.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult user()
        {
            User someUser = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };
            return View("Index", someUser);
        }

        [Route("users")]
        public IActionResult users()
        {
            User buddy1 = new User()
            {
                FirstName = "Sally",
                LastName = "Sanderson"
            };
            User buddy2 = new User()
            {
                FirstName = "Buddy",
                LastName = "TheElf"
            };
            User buddy3 = new User()
            {
                FirstName = "Santa",
                LastName = "Klaus"
            };

            List<User> buddies = new List<User>();

            buddies.Add(buddy1);
            buddies.Add(buddy2);
            buddies.Add(buddy3);

            return View("Users", buddies);
        }


        [Route("numbers")]
        public IActionResult numbers()
        {
            int[] nums = {1,2,3,4,5,6};
            
            return View("Numbers", nums);
        }

        [Route("message")]
        public IActionResult message()
        {
            string message = "Heave down bowsprit plunder maroon marooned run a rig matey. Deadlights bounty nipperkin flogging gaff crack Jennys tea cup hearties. Ballast cable fluke bounty walk the plank log grog.";
            return View("Message", message);
        }

    }
}
