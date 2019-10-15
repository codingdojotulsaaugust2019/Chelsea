using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using dojoSurvey2.Models;



namespace dojoSurvey2.Controllers
    {
        public class FormController : Controller
        {
            [HttpGet]
            [Route("")]
            public IActionResult form()
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("result");
                }
                return View();
            }

            [HttpPost("result")]
            public IActionResult result(Ninja mySurvey)
            {
                return View(mySurvey);
            }

            
        }
    }