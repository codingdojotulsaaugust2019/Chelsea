using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {

    
    public class ArtistController : Controller {

        private List<Artist> allArtists;

        public ArtistController() {
            allArtists = JsonToFile<Artist>.ReadJson();
        }

        //This method is shown to the user navigating to the default API domain name
        //It just displays some basic information on how this API functions
        [Route("")]
        [HttpGet]
        public string Index() {
            //String describing the API functionality
            string instructions = "Welcome to the Music API~~\n========================\n";
            instructions += "    Use the route /artists/ to get artist info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *RealName/{string}\n";
            instructions += "       *Hometown/{string}\n";
            instructions += "       *GroupId/{int}\n\n";
            instructions += "    Use the route /groups/ to get group info.\n";
            instructions += "    End-points:\n";
            instructions += "       *Name/{string}\n";
            instructions += "       *GroupId/{int}\n";
            instructions += "       *ListArtists=?(true/false)\n";
            return instructions;
        }

        [HttpGet("artists/Name/{name}")]
        public JsonResult Name(string name)
        {
            var myList = allArtists.Where(pal => pal.ArtistName.Contains(name));
            return Json(myList);
        }
        
        [HttpGet("artists/RealName/{name}")]
        public JsonResult RealName(string name)
        {
            var myList = allArtists.Where(pal => pal.RealName.Contains(name));
            return Json(myList);
        }

        [HttpGet("artists/HomeTown/{town}")]
        public JsonResult HomeTown(string town)
        {
            var myList = allArtists.Where(pal => pal.Hometown.Contains(town));
            return Json(myList);
        }

        [HttpGet("artists/GroupId/{id}")]
        public JsonResult Group(int id)
        {
            var myList = allArtists.Where(pal => pal.GroupId == id);
            return Json(myList);
        }
    }
}