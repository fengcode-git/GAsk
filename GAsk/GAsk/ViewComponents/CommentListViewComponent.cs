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
    /// <summary>
    /// 评论列表
    /// </summary>
    public class CommentListViewComponent: ViewComponent
    {
        private readonly CommentService commentService;
        private readonly PersonService personService;

        public CommentListViewComponent(CommentService commentService, PersonService personService)
        {
            this.commentService = commentService ?? throw new ArgumentNullException(nameof(commentService));
            this.personService = personService ?? throw new ArgumentNullException(nameof(personService));
        }

        public async Task<IViewComponentResult> InvokeAsync(Guid pPostId)
        {
            List<CommentView> comments = await this.commentService.GetCommentViewsAsync(pPostId);
            PersonView person = await this.personService.GetCurrentPersonViewAsync();
            return View(new CommentListComponentModel() { CommentViews = comments, LoginUser = person, PostId = pPostId,CurrentUrl = this.HttpContext.Request.Path });
        }
    }
}
