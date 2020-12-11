using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.Entity;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    public class ArticleListViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(List<PostView> forPostViews)
        {
            if (forPostViews == null)
            {
                throw new ArgumentNullException(nameof(forPostViews));
            }
            ArticleListComponentModel model = new ArticleListComponentModel(forPostViews);
            return View(model);
        }
    }
}
