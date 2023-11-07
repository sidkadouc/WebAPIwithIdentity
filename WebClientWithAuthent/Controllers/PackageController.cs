using Microsoft.AspNetCore.Mvc;
using WebClientWithAuthent.Models;

namespace WebClientWithAuthent.Controllers
{
    public class PackageController : Controller
    {
        public PackageController()
        {
            
        }

        public IActionResult Second()
        {
            var packages = new List<Package>
            {
                new Package { Id = 1, Name = "Package 1" },
                new Package { Id = 2, Name = "Package 2" },
                new Package { Id = 3, Name = "Package 3" },
                new Package { Id = 4, Name = "Package 4" },
                new Package { Id = 5, Name = "Package 5" },
                new Package { Id = 6, Name = "Package 6" },
                new Package { Id = 7, Name = "Package 7" },
                new Package { Id = 8, Name = "Package 8" },
                new Package { Id = 9, Name = "Package 9" },
                new Package { Id = 10, Name = "Package 10" },
                new Package { Id = 11, Name = "Package 11" },
                new Package { Id = 12, Name = "Package 12" },
                new Package { Id = 13, Name = "Package 13" },
                new Package { Id = 14, Name = "Package 14" },
                new Package { Id = 15, Name = "Package 15" },
                new Package { Id = 16, Name = "Package 16" },
                new Package { Id = 17, Name = "Package 17" }
            };
            return View("Second", packages);
        }

        public IActionResult DFT()
        {
            return View();
        }
    }
}
