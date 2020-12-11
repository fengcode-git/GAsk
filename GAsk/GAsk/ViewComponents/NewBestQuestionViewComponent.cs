using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GAsk.Library.BBL;
using GAsk.Library.Entity;
using GAsk.Models;
using Microsoft.AspNetCore.Mvc;

namespace GAsk.ViewComponents
{
    public class NewBestQuestionViewComponent: ViewComponent
    {
        private readonly PostService postService;

        public NewBestQuestionViewComponent(PostService postService)
        {
            this.postService = postService ?? throw new ArgumentNullException(nameof(postService));
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<PostView> posts = await this.postService.GetNewBestQuestionAsync();
            NewBestQuestionComponentModel model = new NewBestQuestionComponentModel { Posts = posts };
            return View(model);
        }
    }
}
