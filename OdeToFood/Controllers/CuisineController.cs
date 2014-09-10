using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        //
        // GET: /Cuisine/
        [HttpGet] //Action Selector 
        //[Authorize] //Action Filter
        public ActionResult Search(string name)
        {
            var message = Server.HtmlEncode(name);
            //return RedirectToAction("Index","Home", new {name = name});
            //return Json(new {Message = message, Name = "Paul"}, JsonRequestBehavior.AllowGet);
            return Content(message);
        }

    }
}
