using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class ContentController : Controller
    {// Get: ContentController actions
        public IActionResult Index()
        {
            return View();
        }


    }
}
