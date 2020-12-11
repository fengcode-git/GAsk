using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FengCode.Libs.Utils.Paging;
using GAsk.Library.BBL;
using GAsk.Library.DAL;
using GAsk.Library.Entity;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// 帖子列表视图
    /// </summary>
    public class PostListViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(List<PostView> pPostViews)
        { 
            PostListViewModel model = new PostListViewModel
            {
                PostViews = pPostViews
            };
            return View(model);
        }
    }
}