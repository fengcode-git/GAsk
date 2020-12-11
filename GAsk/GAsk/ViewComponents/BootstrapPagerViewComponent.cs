using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    public class BootstrapPagerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int forPageSize, long forRowCount)
        {
            BootstrapPagerModel model = new BootstrapPagerModel(forPageSize, forRowCount,this.HttpContext);
            return View(model);
        }
    }
}