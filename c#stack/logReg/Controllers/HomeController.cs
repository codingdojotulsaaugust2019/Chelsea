using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using logReg.Models;

namespace logReg.Controllers
{
    public class HomeController : Controller
    {
        
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("login")]
        public IActionResult Login(Login logged)
        {
            if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
        }


        [HttpPost("register")]
        public IActionResult Register(Register registered)
        {
            if(ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }
        return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
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
