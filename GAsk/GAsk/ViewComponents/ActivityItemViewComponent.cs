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
    /// 活动元素视图组件
    /// </summary>
    public class ActivityItemViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(ActivityView pActivityView)
        {
            if (pActivityView == null)
            {
                throw new ArgumentNullException(nameof(pActivityView));
            }
            ActivityItemComponentModel model = new ActivityItemComponentModel { ActivityView = pActivityView };
            return View(model);
        }
    }
}
