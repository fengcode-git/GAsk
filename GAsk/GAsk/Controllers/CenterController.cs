using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.Controllers
{
    public class CenterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}