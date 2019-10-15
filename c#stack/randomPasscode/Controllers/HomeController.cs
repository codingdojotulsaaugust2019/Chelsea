using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using randomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace randomPasscode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            int? IntVariable = HttpContext.Session.GetInt32("Count");
            if (IntVariable == null)
            {
                return RedirectToAction("Generate");
            }

            ViewBag.word = TempData["finalword"];
            ViewBag.count = IntVariable;


            return View();
        }

        [HttpGet("generate")]
        public IActionResult Generate()
        {
            int? IntVariable = HttpContext.Session.GetInt32("Count");
            if (IntVariable == null)
            {
                int Start = 0;
                HttpContext.Session.SetInt32("Count", Start);
            }
            int? Counter = HttpContext.Session.GetInt32("Count");
            Counter = Counter + 1;
            HttpContext.Session.SetInt32("Count", (int)Counter);
            ViewBag.Count = HttpContext.Session.GetInt32("Count");


            string reference = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Char[] word = new Char [14];
            Random rand = new Random();
            for (int i = 0; i < 14; i++)
            {
                word[i] = reference[rand.Next(1,58)];
            }

            string finalword = new String(word);

            TempData["finalword"] = finalword;

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
