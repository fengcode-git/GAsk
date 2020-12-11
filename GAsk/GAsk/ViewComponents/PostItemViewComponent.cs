using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.DAL;
using GAsk.Library.Entity;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    /// <summary>
    /// 帖子项目
    /// </summary>
    public class PostItemViewComponent : ViewComponent
    {
        private readonly TagService tagService;
        public PostItemViewComponent(TagService tagService)
        {
            this.tagService = tagService ?? throw new ArgumentNullException(nameof(tagService));
        }

        public async Task<IViewComponentResult> InvokeAsync(PostView post)
        {
            List<Tag> tags = await this.tagService.GetTagsByPost(post);
            PostItemViewModel model = new PostItemViewModel(post, tags);
            return View(model);
        }
    }
}

