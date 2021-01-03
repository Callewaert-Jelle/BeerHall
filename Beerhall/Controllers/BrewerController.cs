using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Beerhall.Controllers
{
    public class BrewerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
