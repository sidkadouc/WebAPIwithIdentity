using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPIDemo.Controllers
{
    public class IndexController : Controller
    {
        [CustomAuthorizeAttribute()]
        [Route("IdentityCheck")]
        [HttpGet]
        public IActionResult IdentityCheck()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }

        // Called each time the user sign in to the client application or when session is expired
        [Authorize]
        [Route("GetUserRoles")]
        [HttpGet]
        public IActionResult GetUserRoles()
        {
            var UserId = User.Claims.FirstOrDefault(c => c.Type == "id");
            // TODO Call the database with user id and get the roles 

            // TODO return roles user has access to 
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }


    }
}
