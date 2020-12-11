using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Reflection;
using GAsk.Library.Enums;
using GAsk.Library.Utils;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// 过滤导航组件
    /// </summary>
    public class FilterNavbarViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FilterNavbarComponentModel model = new FilterNavbarComponentModel(this.HttpContext);
            return View(model);
        }
    }
}
