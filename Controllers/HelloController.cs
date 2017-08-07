using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
 
namespace YourNamespace.Controllers
{
    public class HelloController : Controller
    {
        [HttpGet]
        [Route("")]
        public string DisplayOptions()
        {
            return "Use the following URL options for the app, /firstname, /lastname, /age, /favoritecolor. Each will return my info.";
        }
        
        [HttpGet]
        [Route("firstname")]
        public JsonResult DisplayFirstName()
        {
            return Json("Troy");
        }
        [HttpGet]
        [Route("lastname")]
        public JsonResult DisplayLastName()
        {
            return Json("Center");
        }
        [HttpGet]
        [Route("age")]
        public JsonResult DisplayAge()
        {
            return Json(34);
        }
        [HttpGet]
        [Route("favoritecolor")]
        public JsonResult DisplayFColor()
        {
            return Json("red");
        }
    }
       
}
