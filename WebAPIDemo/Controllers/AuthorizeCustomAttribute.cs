using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data;
using System.Security.Claims;
using WebAPIDemo.Services;

namespace WebAPIDemo.Controllers
{
    internal class CustomAuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        private readonly IEnumerable<Claim> _claims;

        private readonly Dictionary<string, List<string>> rolesByUser = new Dictionary<string, List<string>> { { "alice", new List<string> { "Admin" } } };
        public CustomAuthorizeAttribute(IHttpContextAccessor httpContextAccessor, IRolesService rolesServices)
        {
            _claims = httpContextAccessor.HttpContext.User.Claims;
            var userName = _claims.FirstOrDefault(c => c.Type == "name").Value;
            
            
            //Roles = String.Join(",", rolesByUser[userName]);
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
        }
    }
}