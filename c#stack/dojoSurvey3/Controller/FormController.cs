using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace dojoSurvey2.Controllers
    {
        public class FormController : Controller
        {
            [HttpGet]
            [Route("")]
            public IActionResult form()
            {
                return View();
            }

            [HttpPost("result")]
            public IActionResult result(Ninja mySurvey)
            {
                return View(mySurvey);
            }
        }
    }