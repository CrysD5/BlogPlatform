using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class CategoryController : Controller
    {
        // Get: CategoryController actions
        public IActionResult Index()
        {
            return View();
        }

    }
}
