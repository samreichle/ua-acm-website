using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website.Controllers
{
    public class Privacy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
