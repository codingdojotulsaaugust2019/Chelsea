using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CoreProj.Controllers
{

    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
//******************************************************************* */
        [HttpGet("projects")]
        public IActionResult projects()
        {
            return View();
        }
//******************************************************************* */

        [HttpGet("contact")]
        public IActionResult contact()
        {
            return View();
        }
    }
}