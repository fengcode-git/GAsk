using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// 活动列表视图组件
    /// </summary>
    public class ActivityListViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(List<ActivityView> pActivityViews)
        {
            ActivityListComponentModel model = new ActivityListComponentModel
            {
                ActivityViews = pActivityViews
            };
            return View(model);
        }
    }
}