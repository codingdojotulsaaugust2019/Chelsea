using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace RapperAPI.Controllers {
    public class GroupController : Controller {
        List<Group> allGroups {get; set;}
        public GroupController() {
            allGroups = JsonToFile<Group>.ReadJson();
        }

        [HttpGet("groups/Name/{name}")]
        public JsonResult Name(string name)
        {
            var myList = allGroups.Where(grp => grp.GroupName.Contains(name));
            return Json(myList);
        }

        [HttpGet("groups/GroupId/{id}")]
        public JsonResult ID(int id)
        {
            var grp = allGroups.Where(group => group.Id == id);
            return Json(grp);
        }

        [HttpGet("groups/all")]
        public JsonResult all()
        {
            return Json(allGroups);
        }

    }
}